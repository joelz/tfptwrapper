using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

using AndrewTweddle.Tools.Utilities.CommandLine;
using CmdLine = AndrewTweddle.Tools.Utilities.CommandLine.CommandLineHelper;
using System.Text.RegularExpressions;
using System.Configuration;
using System.Reflection;

namespace AshishT.Tools.TfptWrapper
{
    class TfptWrapperController
    {
        
        private const string BATCH_FILE = "TFPTCommand.bat";
        private string tfptLocation = @"";
        private string tfLocation = @"C:\Program Files (x86)\Microsoft Visual Studio 10.0\Common7\IDE\TF.exe";
        private string tfsWorkspace = @"";
        private string tfsUserName = @"";
        private string tfsPassword = @"";

        private WorkspaceHistoryController workspaceHistory;
        private StringBuilder output;
        private TfptWrapperDialog ui;
        
        delegate void ExecuteCommand(string command);
        ExecuteCommand commandExecuter;
        AsyncCallback callback;

        internal delegate void CommandExecutedEventHandler(string output);
        internal event CommandExecutedEventHandler CommandExecuted;

        /// <summary>
        /// Gets or sets the TFPT location.
        /// </summary>
        /// <value>The TFPT location.</value>
        internal string TfptLocation
        {
            get { return tfptLocation; }
            set { tfptLocation = value; }
        }

        /// <summary>
        /// Gets or sets the workspace.
        /// </summary>
        /// <value>The workspace.</value>
        internal string WorkspaceLocation
        {
            get { return tfsWorkspace; }
            set { tfsWorkspace = value; }
        }


        internal string TfsUserName
        {
            get { return tfsUserName; }
            set { tfsUserName= value; }
        }

        internal string TfsPassword
        {
            get { return tfsPassword; }
            set { tfsPassword = value; }
        }

        /// <summary>
        /// Gets or sets the workspace history.
        /// </summary>
        /// <value>The workspace history.</value>
        private WorkspaceHistoryController WorkspaceHistory
        {
            get 
            {
                if (this.workspaceHistory == null) 
                    this.workspaceHistory = new WorkspaceHistoryController();

                return this.workspaceHistory;
            }
            set { workspaceHistory = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TfptController"/> class.
        /// </summary>
        public TfptWrapperController()
        {
            if (this.WorkspaceHistory.History.Count > 0)
                this.tfsWorkspace = this.WorkspaceHistory.History[0];

            LoadConfig();

            ui = new TfptWrapperDialog(this);
            commandExecuter = new ExecuteCommand(ProcessCommand);
        }

        /// <summary>
        /// 从App.config中加载上次的配置
        /// </summary>
        private void LoadConfig()
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);

            TfptLocation = configuration.AppSettings.Settings["tfptLocation"].Value;
            tfLocation = configuration.AppSettings.Settings["tfLocation"].Value;
            tfsWorkspace = configuration.AppSettings.Settings["tfsWorkspace"].Value;
            tfsUserName = configuration.AppSettings.Settings["tfsUserName"].Value;
            tfsPassword = configuration.AppSettings.Settings["tfsPassword"].Value;
        }

        /// <summary>
        /// 将当前用户填入的数据保存到App.config中
        /// </summary>
        internal void SaveConfig(string tfptlocationText, string tfsWorkspaceText, string tfsUserNameText, string tfsPasswordText)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(Assembly.GetExecutingAssembly().Location);

            configuration.AppSettings.Settings["tfptLocation"].Value = tfptlocationText;
            configuration.AppSettings.Settings["tfsWorkspace"].Value = tfsWorkspaceText;
            configuration.AppSettings.Settings["tfsUserName"].Value = tfsUserNameText;
            configuration.AppSettings.Settings["tfsPassword"].Value = tfsPasswordText;

            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

        /// <summary>
        /// Trees the clean.
        /// </summary>
        /// <param name="delete">if set to <c>true</c> [delete].</param>
        /// <returns></returns>
        internal string TreeClean(bool delete)
        {
            string errorMessage;
            StringBuilder output = new StringBuilder();

            try
            {
                StringBuilder arguments = new StringBuilder();
                arguments.Append("treeclean");
                if (delete)
                    arguments.Append(" -delete");

                StringBuilder cmdBuilder = new StringBuilder();
                cmdBuilder.Append("\"" + tfptLocation + "\"");
                cmdBuilder.Append(" ");
                cmdBuilder.Append(arguments.ToString());

                CreateBatchFile(cmdBuilder);
                output.Append(CmdLine.Run(BATCH_FILE, string.Empty, out errorMessage));
                output.Append((string.IsNullOrEmpty(errorMessage) ? string.Empty : errorMessage));
            }
            catch (CommandLineException ex)
            {
                output.Append(ex.Message);
            }

            return output.ToString();
        }

        /// <summary>
        /// Creates the batch file.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>
        private void CreateBatchFile(StringBuilder text)
        {
            StringBuilder baseText = new StringBuilder();
            baseText.AppendLine("cd /D " + this.tfsWorkspace);
            baseText.Append(text.ToString());

            using (StreamWriter writer = new StreamWriter(BATCH_FILE, false))
            {
                writer.Write(baseText.ToString());
            }
        }

        /// <summary>
        /// Processes the command.
        /// </summary>
        /// <param name="command">The command.</param>
        private void ProcessCommand(string command)
        {
            string errorMessage;
            output = new StringBuilder();

            try
            {
                output.Append(CmdLine.Run(BATCH_FILE, string.Empty, out errorMessage));
                output.Append((string.IsNullOrEmpty(errorMessage) ? string.Empty : errorMessage));
            }
            catch (CommandLineException ex)
            {
                output.Append(ex.Message);
            }
        }

        /// <summary>
        /// Callmes the specified result.
        /// </summary>
        /// <param name="result">The result.</param>
        private void Callme(IAsyncResult result)
        {
            CommandExecutedEventHandler temp = CommandExecuted;
            if (temp != null)
            {
                temp(output.ToString());
            }
        }

        /// <summary>
        /// Invokes the tree clean.
        /// </summary>
        /// <param name="delete">if set to <c>true</c> [delete].</param>
        internal void InvokeTreeClean(bool delete)
        {
            StringBuilder cmdBuilder = new StringBuilder();
            cmdBuilder.Append("\"" + tfptLocation + "\"");
            cmdBuilder.Append(" ");
            cmdBuilder.Append("treeclean");
            if (delete)
                cmdBuilder.Append(" -delete");

            BuildCommand(cmdBuilder);
        }

        /// <summary>
        /// Invokes the Undo Unchanged command.
        /// </summary>
        /// <param name="recursive">if set to <c>true</c> [recursive].</param>
        /// <param name="noGet">if set to <c>true</c> [no get].</param>
        /// <param name="changeSetNum">The change set number.</param>
        /// <param name="filespec">The filespec.</param>
        internal void InvokeUU(bool recursive, bool noGet, string changeSetNum, string filespec)
        {
            StringBuilder cmdBuilder = new StringBuilder();
            cmdBuilder.Append("\"" + tfptLocation + "\"");
            cmdBuilder.Append(" ");
            cmdBuilder.Append("uu");
            if (recursive)
                cmdBuilder.Append(" /recursive");
            if (noGet)
                cmdBuilder.Append(" /noget");
            if (!string.IsNullOrEmpty(changeSetNum))
                cmdBuilder.Append(" /changeset:" + changeSetNum);
            if (!string.IsNullOrEmpty(filespec))
                cmdBuilder.Append(" " + filespec);

            BuildCommand(cmdBuilder);
        }

        /// <summary>
        /// Invokes the review.
        /// </summary>
        /// <param name="recursive">if set to <c>true</c> [recursive].</param>
        /// <param name="filespec">The filespec.</param>
        internal void InvokeReview(bool recursive, string filespec)
        {
            StringBuilder cmdBuilder = new StringBuilder();
            cmdBuilder.Append("\"" + tfptLocation + "\"");
            cmdBuilder.Append(" ");
            cmdBuilder.Append("review");
            if (recursive)
                cmdBuilder.Append(" /recursive");
            cmdBuilder.Append(" ");
            cmdBuilder.Append(filespec);

            BuildCommand(cmdBuilder);
        }

        /// <summary>
        /// Invokes the search.
        /// </summary>
        /// <param name="recursive">if set to <c>true</c> [recursive].</param>
        /// <param name="filespec">The filespec.</param>
        internal void InvokeSearch(bool recursive, string filespec)
        {
            StringBuilder cmdBuilder = new StringBuilder();
            cmdBuilder.Append("dir /b");
            if (recursive)
                cmdBuilder.Append("/s");
            cmdBuilder.Append(" ");
            cmdBuilder.Append(filespec);

            BuildCommand(cmdBuilder);
        }

        /// <summary>
        /// Builds the command.
        /// </summary>
        /// <param name="cmdBuilder">The CMD builder.</param>
        private void BuildCommand(StringBuilder cmdBuilder)
        {
            CreateBatchFile(cmdBuilder);

            callback = new AsyncCallback(Callme);
            commandExecuter.BeginInvoke(BATCH_FILE, callback, commandExecuter);
            this.WorkspaceHistory.Add(this.tfsWorkspace);
        }

        /// <summary>
        /// Starts the UI.
        /// </summary>
        internal void StartUI()
        {
            this.ui.ShowDialog();
            this.WorkspaceHistory.SaveHistory();
        }

        /// <summary>
        /// Shows the history dialog.
        /// </summary>
        internal void ShowHistoryDialog()
        {
            if (this.WorkspaceHistory.ShowDialog(this.ui) == System.Windows.Forms.DialogResult.OK)
            {
                this.ui.SetWorkspace(this.workspaceHistory.Current);
            }
        }

        /// <summary>
        /// Invokes the bulk checkout.
        /// </summary>
        /// <param name="recursive">if set to <c>true</c> [recursive].</param>
        /// <param name="filespec">The filespec.</param>
        internal void InvokeBulkCheckout(bool recursive, string filespec)
        {
            StringBuilder cmdBuilder = new StringBuilder();
            cmdBuilder.Append("\"" + tfLocation + "\"");
            cmdBuilder.Append(" ");
            cmdBuilder.Append("checkout");
            if (recursive)
                cmdBuilder.Append(" /recursive");
            cmdBuilder.Append(" ");
            cmdBuilder.Append(filespec);

            BuildCommand(cmdBuilder);
        }

        /// <summary>
        /// Invokes the bulk checkin.
        /// </summary>
        /// <param name="p">if set to <c>true</c> [p].</param>
        /// <param name="p_2">The P_2.</param>
        internal void InvokeBulkCheckin(bool recursive, string filespec, string checkinComment)
        {
            StringBuilder cmdBuilder = new StringBuilder();
            cmdBuilder.Append("\"" + tfLocation + "\"");
            cmdBuilder.Append(" ");
            cmdBuilder.Append("checkin");
            if (recursive)
                cmdBuilder.Append(" /recursive");
            if (!string.IsNullOrEmpty(checkinComment))
                cmdBuilder.Append(" /comment:" + checkinComment);
            cmdBuilder.Append(" ");
            cmdBuilder.Append(filespec);

            BuildCommand(cmdBuilder);
        }

        /// <summary>
        /// Invokes the history.
        /// </summary>
        /// <param name="recursive">if set to <c>true</c> [recursive].</param>
        /// <param name="followBranches">if set to <c>true</c> [follow branches].</param>
        /// <param name="username">The username.</param>
        /// <param name="filespec">The filespec.</param>
        internal void InvokeHistory(bool recursive, bool followBranches, string username, string filespec)
        {
            StringBuilder cmdBuilder = new StringBuilder();
            cmdBuilder.Append("\"" + tfptLocation + "\"");
            cmdBuilder.Append(" ");
            cmdBuilder.Append("history");
            if (recursive)
                cmdBuilder.Append(" /recursive");
            if (followBranches)
                cmdBuilder.Append(" /followbranches");
            if (!string.IsNullOrEmpty(username))
                cmdBuilder.Append(" /user:" + username);
            if (!string.IsNullOrEmpty(filespec))
                cmdBuilder.Append(" " + filespec);

            BuildCommand(cmdBuilder);
        }

        /// <summary>
        /// Invokes the get changesets.
        /// </summary>
        /// <param name="changeSetNumbers">The changeSetNumbers.</param>
        /// <param name="cleanWsFirst">if set to <c>true</c> [recursive].</param>
        /// <param name="exeSql">if set to <c>true</c> [follow branches].</param>
        /// <param name="sqlCmd">The filespec.</param>
        internal void InvokeGetChangesets(string changeSetNumbers, bool cleanWsFirst, bool exeSql, string sqlCmd)
        {
            StringBuilder cmdBuilder = new StringBuilder();
            if (cleanWsFirst)
            {
                //这个命令只删除了文件，没有删除子文件夹
                cmdBuilder.Append("del \"" + tfsWorkspace + "\\*.*\"");
                cmdBuilder.Append(" /s /q /f ");
                cmdBuilder.Append(" " + Environment.NewLine);
            }

            string loginInfo =@"-login:"+this.TfsUserName+","+this.TfsPassword;
            string[] arrChangesets = changeSetNumbers.Replace('，',',').Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            List<int> listChangesets = new List<int>();
            foreach (var cs in arrChangesets)
                listChangesets.Add(Convert.ToInt32(cs));

            //对变更集排序，按从小到大的顺序
            listChangesets.Sort();

            //listChangesets.
            foreach (var cs in listChangesets)
            {
                cmdBuilder.Append("\"" + tfptLocation + "\"");
                cmdBuilder.Append(" ");
                cmdBuilder.Append(@"getcs /changeset:" + cs.ToString());
                cmdBuilder.Append(@" /force /overwrite ");
                cmdBuilder.Append(loginInfo);
                cmdBuilder.Append(" " + Environment.NewLine);
            }
            
            BuildCommand(cmdBuilder);
        }


        internal void InvokeExecuteSqlAfterGetChangesets(string sqlCmd,string filterRegex)
        {
            //匹配FMCG 中的Funcionts和sp的路径
            Regex regexObj = new Regex(@"",
                RegexOptions.Multiline);

            StringBuilder cmdBuilder = new StringBuilder();
            
            string[] filePaths = Directory.GetFiles(tfsWorkspace, "*.sql",
                                     SearchOption.AllDirectories);
            foreach (var filePath in filePaths)
            {
                if (regexObj.IsMatch(filePath))
                {
                    cmdBuilder.Append(sqlCmd + " \"" + filePath + "\"");
                    cmdBuilder.Append(" " + Environment.NewLine);
                }
            }
            
            BuildCommand(cmdBuilder);
        }
    }
}
