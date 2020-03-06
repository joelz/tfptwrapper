using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Reflection;

namespace AshishT.Tools.TfptWrapper
{
    internal partial class TfptWrapperDialog : Form
    {
        TfptWrapperController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="TfptUI"/> class.
        /// </summary>
        public TfptWrapperDialog()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfptUI"/> class.
        /// </summary>
        /// <param name="controller">The controller.</param>
        public TfptWrapperDialog(TfptWrapperController controller)
            : this()
        {
            this.controller = controller;
            this.txtTFPTLocation.Text = controller.TfptLocation;
            this.txtWorkspaceLocation.Text = controller.WorkspaceLocation;
            this.txtTfsUserName.Text = controller.TfsUserName;
            this.txtTfsPassword.Text = controller.TfsPassword;
        }

        /// <summary>
        /// Called when [execute complete].
        /// </summary>
        /// <param name="output">The output.</param>
        void OnExecuteComplete(string output)
        {
            EnableExecute(true);
            UpdateOutput(output);
        }

        /// <summary>
        /// Gets the error from the error provider.
        /// </summary>
        /// <returns></returns>
        private string GetError()
        {
            string error = this.errorProvider.GetError(txtTFPTLocation);
            if (string.IsNullOrEmpty(error))
            {
                error = this.errorProvider.GetError(txtWorkspaceLocation);
                if (string.IsNullOrEmpty(error))
                {
                    error = this.errorProvider.GetError(txtUUChangeSet);
                    if (string.IsNullOrEmpty(error))
                    {
                        error = this.errorProvider.GetError(txtSearchFilespec);
                        if (!string.IsNullOrEmpty(error))
                        {
                            error = this.errorProvider.GetError(txtHistoryUser);
                            if (!string.IsNullOrEmpty(error))
                            {
                                this.txtHistoryUser.Focus();
                            }
                        }
                        else
                        {
                            this.txtSearchFilespec.Focus();
                        }
                    }
                    else
                    {
                        this.txtUUChangeSet.Focus();
                    }
                }
                else
                {
                    this.txtWorkspaceLocation.Focus();
                }
            }
            else
            {
                this.txtTFPTLocation.Focus();
            }

            return error;
        }

        /// <summary>
        /// Executes the command.
        /// </summary>
        private void ExecuteCommand()
        {
            TabPage selectedPage = this.tbcCommands.SelectedTab;
            Command selectedCommand = (Command)Enum.Parse(typeof(Command), selectedPage.Tag.ToString());
            switch (selectedCommand)
            {
                case Command.TreeClean:
                    this.controller.InvokeTreeClean(this.ckbTCDelete.Checked);
                    break;
                case Command.UndoUnchanged:
                    this.controller.InvokeUU(this.ckbUURecursive.Checked,
                        this.ckbUUNoGet.Checked, 
                        (this.ckbUUChangeSet.Checked) ? this.txtUUChangeSet.Text : string.Empty,
                        (this.ckbUUFilespec.Checked) ? this.txtUUFilespec.Text : string.Empty);
                    break;
                case Command.ReviewChanges:
                    this.controller.InvokeReview(this.ckbReviewRecursive.Checked, this.txtReviewFilespec.Text);
                    break;
                case Command.Search:
                    this.controller.InvokeSearch(this.ckbSearchRecursive.Checked, this.txtSearchFilespec.Text);
                    break;
                case Command.BulkCheckout:
                    if (MessageBox.Show("Are you sure you want to checkout the selected files?" + Environment.NewLine +
                        "This command cannot be aborted.",
                        "TF Power Tools",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        this.btnAbort.Enabled = false;
                        this.controller.InvokeBulkCheckout(this.ckbBulkCkoutRecursive.Checked, this.txtBulkCkoutItemspec.Text);
                    }
                    else
                        this.btnAbort_Click(this, EventArgs.Empty);
                    break;
                case Command.BulkCheckin:
                    this.controller.InvokeBulkCheckin(this.ckbBulkCkinRecursive.Checked, this.txtBulkCkinItemspec.Text, this.txtBulkCkinComment.Text);
                    break;
                case Command.History:
                    this.controller.InvokeHistory(this.ckbHistoryRecursive.Checked, 
                        this.ckbHistoryBranches.Checked,
                        (this.ckbHistoryUser.Checked) ? this.txtHistoryUser.Text : string.Empty,
                        this.txtHistoryItemspec.Text);
                    break;
                case Command.GetCS:
                    this.controller.InvokeGetChangesets(this.txtGetCsChangesets.Text,
                        this.cbGetCsCleanFirst.Checked,
                        false,
                        this.txtGetCsSqlCmd.Text);
                    break;
                default:
                    MessageBox.Show("This command does not exist. Wrong implementation.",
                        "Unrecognized Command", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }

        /// <summary>
        /// Enables the execute button.
        /// </summary>
        /// <param name="enable">if set to <c>true</c> [enable].</param>
        private void EnableExecute(bool enable)
        {
            this.btnExecute.BeginInvoke((MethodInvoker)delegate()
            {
                this.btnExecute.Enabled = enable;
            });
            this.btnAbort.BeginInvoke((MethodInvoker)delegate()
            {
                this.btnAbort.Enabled = !enable;
            });
        }

        /// <summary>
        /// Updates the output.
        /// </summary>
        /// <param name="output">The output.</param>
        private void UpdateOutput(string output)
        {
            this.txtOutput.BeginInvoke((MethodInvoker)delegate()
            {
                // This runs on the UI thread!
                this.txtOutput.Text = output;
            });
        }

        /// <summary>
        /// Sets the error provider.
        /// </summary>
        /// <param name="control">The control.</param>
        private void SetErrorProvider(Control control)
        {
            errorProvider.SetIconAlignment(control, ErrorIconAlignment.MiddleRight);
            errorProvider.SetIconPadding(control, 2);
        }

        /// <summary>
        /// Called when [browse click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OnBrowseClick(object sender, EventArgs e)
        {
            FolderBrowserDialog folderSelection = new FolderBrowserDialog();
            folderSelection.SelectedPath = this.txtWorkspaceLocation.Text;

            if (folderSelection.ShowDialog() == DialogResult.OK)
                this.txtWorkspaceLocation.Text = folderSelection.SelectedPath;
        }

        /// <summary>
        /// Called when [browse TFPT click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OnBrowseTfptClick(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.FileName = "TFPT.exe";
            openFileDialog.Filter = "Executable File (*.exe)|*.exe";
            openFileDialog.FileName = this.txtTFPTLocation.Text;
            openFileDialog.Multiselect = false;

            if (openFileDialog.ShowDialog() == DialogResult.OK)
                this.txtTFPTLocation.Text = openFileDialog.FileName;
        }

        /// <summary>
        /// Handles the Click event of the btnExecute control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnExecute_Click(object sender, EventArgs e)
        {
            this.controller.CommandExecuted += new TfptWrapperController.CommandExecutedEventHandler(OnExecuteComplete);
            string error = this.GetError();
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "TFPT UI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.EnableExecute(false);
            this.txtOutput.Text = "Please wait while the command is initialized and executed..";
            this.ExecuteCommand();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ckbUUChangeSet control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ckbUUChangeSet_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUUChangeSet.Enabled = this.ckbUUChangeSet.Checked;
            if (this.ckbUUChangeSet.Checked)
                this.txtUUChangeSet.Focus();
            else
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(txtUUChangeSet)))
                    errorProvider.SetError(txtUUChangeSet, string.Empty);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ckbUUFilespec control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ckbUUFilespec_CheckedChanged(object sender, EventArgs e)
        {
            this.txtUUFilespec.Enabled = this.ckbUUFilespec.Checked;
            if (this.ckbUUFilespec.Checked)
                this.txtUUFilespec.Focus();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the checkBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            this.txtOutput.WordWrap = this.ckbWordwrap.Checked;
        }

        /// <summary>
        /// Handles the TextChanged event of the txtTFPTLocation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtTFPTLocation_TextChanged(object sender, EventArgs e)
        {
            this.controller.TfptLocation = this.txtTFPTLocation.Text;
            this.errorProvider.SetError(this.txtTFPTLocation, string.Empty);
        }

        /// <summary>
        /// Handles the Validated event of the txtTFPTLocation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtTFPTLocation_Validated(object sender, EventArgs e)
        {
            SetErrorProvider(this.txtTFPTLocation);
            if (!File.Exists(this.txtTFPTLocation.Text))
            {
                errorProvider.SetError(txtTFPTLocation, "The location of TF Power Tools is invalid.");
            }
            else
            {
                errorProvider.SetError(txtTFPTLocation, "");
            }
        }

        /// <summary>
        /// Handles the Validated event of the txtWorkspaceLocation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtWorkspaceLocation_Validated(object sender, EventArgs e)
        {
            SetErrorProvider(this.txtWorkspaceLocation);
            if (!Directory.Exists(this.txtWorkspaceLocation.Text))
            {
                errorProvider.SetError(txtWorkspaceLocation, "The Workspace location is invalid.");
            }
            else
            {
                errorProvider.SetError(txtWorkspaceLocation, "");
            }
        }

        /// <summary>
        /// Handles the Validated event of the txtUUChangeSet control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtUUChangeSet_Validated(object sender, EventArgs e)
        {
            SetErrorProvider(this.txtUUChangeSet);

            try
            {
                int x = Int32.Parse(txtUUChangeSet.Text);
                if (x < 0) throw new Exception();
                errorProvider.SetError(txtUUChangeSet, "");
            }
            catch
            {
                errorProvider.SetError(txtUUChangeSet, "The changeset must be a non-negative number.");
            }
        }

        /// <summary>
        /// Handles the Validated event of the textBox1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void textBox1_Validated(object sender, EventArgs e)
        {
            SetErrorProvider(this.txtSearchFilespec);
            if (string.IsNullOrEmpty(this.txtSearchFilespec.Text))
            {
                errorProvider.SetError(txtSearchFilespec, "The search criterion is invalid.");
            }
            else
            {
                errorProvider.SetError(txtSearchFilespec, "");
            }
        }

        /// <summary>
        /// Handles the TextChanged event of the txtWorkspaceLocation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtWorkspaceLocation_TextChanged(object sender, EventArgs e)
        {
            this.controller.WorkspaceLocation = this.txtWorkspaceLocation.Text;
            this.errorProvider.SetError(this.txtWorkspaceLocation, string.Empty);
        }

        /// <summary>
        /// Handles the Click event of the btnAbort control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnAbort_Click(object sender, EventArgs e)
        {
            this.EnableExecute(true);
            this.controller.CommandExecuted -= new TfptWrapperController.CommandExecutedEventHandler(this.OnExecuteComplete);
            this.txtOutput.Text = "Command aborted by user." + Environment.NewLine;
            this.txtOutput.Text += @"This does not guarantee that the previous command was aborted. 
It may be completed as it runs on another thread.
Abort functionality simply lets user run another command before the previous command has completed its execution.";
        }

        /// <summary>
        /// Handles the Click event of the btnHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.controller.ShowHistoryDialog();
        }

        /// <summary>
        /// Sets the workspace.
        /// </summary>
        /// <param name="newWorkspace">The new workspace.</param>
        internal void SetWorkspace(string newWorkspace)
        {
            this.txtWorkspaceLocation.Text = newWorkspace;
        }

        /// <summary>
        /// Called when [textbox enter].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OnTextboxEnter(object sender, EventArgs e)
        {
            TextBox textbox = sender as TextBox;
            if (textbox != null && !textbox.Focused)
                textbox.SelectAll();
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ckbHistoryUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ckbHistoryUser_CheckedChanged(object sender, EventArgs e)
        {
            this.txtHistoryUser.Enabled = this.ckbHistoryUser.Checked;
            if (this.ckbHistoryUser.Checked)
                this.txtHistoryUser.Focus();
            else
            {
                if (!string.IsNullOrEmpty(errorProvider.GetError(txtHistoryUser)))
                    errorProvider.SetError(txtHistoryUser, string.Empty);
            }
        }

        /// <summary>
        /// Handles the Validated event of the txtHistoryUser control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void txtHistoryUser_Validated(object sender, EventArgs e)
        {
            SetErrorProvider(this.txtHistoryUser);
            if (this.txtHistoryUser.Text.Length == 0)
            {
                errorProvider.SetError(txtHistoryUser, "The username cannot be empty.");
            }
            else
            {
                errorProvider.SetError(txtHistoryUser, "");
            }
        }

        private void txtTfsPassword_TextChanged(object sender, EventArgs e)
        {
            this.controller.TfsPassword = this.txtTfsPassword.Text;
            this.errorProvider.SetError(this.txtTfsPassword, string.Empty);
        }

        private void txtTfsUserName_TextChanged(object sender, EventArgs e)
        {
            this.controller.TfsUserName = this.txtTfsUserName.Text;
            this.errorProvider.SetError(this.txtTfsUserName, string.Empty);
        }

        private void btnGetCsExeSql_Click(object sender, EventArgs e)
        {
            //提醒，让用户有反悔的机会
            if (MessageBox.Show("提醒：执行之前请确认已经将变更集获取到工作区。"+Environment.NewLine+"是否继续？", "TFPT UI",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                return;
            }

            //检查cmd文本框是否填写了值
            if (string.IsNullOrEmpty(this.txtGetCsSqlCmd.Text))
            {
                MessageBox.Show("请填写sqlcmd命令。", "TFPT UI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //注册命令行执行完毕后的回调函数
            this.controller.CommandExecuted += new TfptWrapperController.CommandExecutedEventHandler(OnExecuteComplete);

            //检查其他控件是否有错误
            string error = this.GetError();
            if (!string.IsNullOrEmpty(error))
            {
                MessageBox.Show(error, "TFPT UI",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //禁用Execute按钮，给输出框写入值
            this.EnableExecute(false);
            this.txtOutput.Text = "Please wait while the command is initialized and executed..";
            
            //生成命令，执行
            this.controller.InvokeExecuteSqlAfterGetChangesets(this.txtGetCsSqlCmd.Text,this.txtGetCsSqlFilterRegex.Text);
        }

        private void TfptWrapperDialog_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.controller.SaveConfig(this.txtTFPTLocation.Text, this.txtWorkspaceLocation.Text,
                                        this.txtTfsUserName.Text, this.txtTfsPassword.Text);
        }

    }
}