using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;

namespace AshishT.Tools.TfptWrapper
{
    class WorkspaceHistoryController
    {
        private WorkspaceHistoryDialog dialog;
        private string currentWorkspace;
        private List<string> history;

        /// <summary>
        /// Gets or sets the history.
        /// </summary>
        /// <value>The history.</value>
        public List<string> History
        {
            get { return history; }
            set { history = value; }
        }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>The current.</value>
        public string Current
        {
            get { return currentWorkspace; }
            set { currentWorkspace = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkspaceHistory"/> class.
        /// </summary>
        public WorkspaceHistoryController()
        {
            this.history = this.GetHistory();
            this.dialog = new WorkspaceHistoryDialog(this);
        }

        /// <summary>
        /// Gets the history.
        /// </summary>
        /// <returns></returns>
        private List<string> GetHistory()
        {
            string fileName = "History.dat";
            List<string> history = new List<string>();
            if (File.Exists(fileName))
            {
                using (StreamReader reader = new StreamReader(fileName))
                {
                    while (!reader.EndOfStream)
                    {
                        history.Add(reader.ReadLine());
                    }
                }
            }

            return history;
        }

        /// <summary>
        /// Saves the history.
        /// </summary>
        /// <param name="history">The history.</param>
        public void SaveHistory()
        {
            using (StreamWriter writer = new StreamWriter("History.dat"))
            {
                foreach (string s in this.history)
                {
                    writer.WriteLine(s);
                }
            }
        }

        /// <summary>
        /// Shows the dialog.
        /// </summary>
        public DialogResult ShowDialog(IWin32Window owner)
        {
            return this.dialog.ShowDialog(owner);
        }

        /// <summary>
        /// Adds the workspace to history.
        /// </summary>
        /// <param name="workspace">The workspace.</param>
        public void Add(string workspace)
        {
            if (this.History.IndexOf(workspace) == -1)
            {
                this.History.Add(workspace);
                this.dialog.RefreshList();
            }
        }
    }
}
