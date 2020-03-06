using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AshishT.Tools.TfptWrapper
{
    internal partial class WorkspaceHistoryDialog : Form
    {
        WorkspaceHistoryController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceHistoryDialog"/> class.
        /// </summary>
        public WorkspaceHistoryDialog(WorkspaceHistoryController controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.lsbHistory.DataSource = this.controller.History;
        }

        /// <summary>
        /// Handles the Load event of the WorkspaceHistoryDialog control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void WorkspaceHistoryDialog_Load(object sender, EventArgs e)
        {
            this.SelectListItem();
        }

        /// <summary>
        /// Selects the list item.
        /// </summary>
        private void SelectListItem()
        {
            if (this.lsbHistory.Items.Count > 0)
            {
                this.lsbHistory.SelectedIndex = 0;
                this.btnSelect.Enabled = this.btnDelete.Enabled = true;
            }
            else
            {
                this.btnSelect.Enabled = this.btnDelete.Enabled = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the btnSelect control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.controller.Current = this.lsbHistory.SelectedItem.ToString();
        }

        /// <summary>
        /// Handles the Click event of the btnDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.controller.History.RemoveAt(this.lsbHistory.SelectedIndex);
            this.RefreshList();
            this.SelectListItem();
        }

        /// <summary>
        /// Refreshes the list.
        /// </summary>
        internal void RefreshList()
        {
            this.lsbHistory.DataSource = null;
            this.lsbHistory.DataSource = this.controller.History;
        }

        /// <summary>
        /// Handles the DoubleClick event of the lsbHistory control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void lsbHistory_DoubleClick(object sender, EventArgs e)
        {
            if (this.btnDelete.Enabled)
                this.btnDelete_Click(sender, e);
        }
    }
}