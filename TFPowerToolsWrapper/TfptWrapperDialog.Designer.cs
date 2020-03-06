namespace AshishT.Tools.TfptWrapper
{
    partial class TfptWrapperDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TfptWrapperDialog));
            this.tbcCommands = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cbGetCsCleanFirst = new System.Windows.Forms.CheckBox();
            this.txtGetCsChangesets = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtGetCsSqlFilterRegex = new System.Windows.Forms.TextBox();
            this.btnGetCsExeSql = new System.Windows.Forms.Button();
            this.txtGetCsSqlCmd = new System.Windows.Forms.TextBox();
            this.tbpReview = new System.Windows.Forms.TabPage();
            this.txtReviewFilespec = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ckbReviewRecursive = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbpTreeClean = new System.Windows.Forms.TabPage();
            this.ckbTCDelete = new System.Windows.Forms.CheckBox();
            this.tbpUU = new System.Windows.Forms.TabPage();
            this.txtUUFilespec = new System.Windows.Forms.TextBox();
            this.ckbUUFilespec = new System.Windows.Forms.CheckBox();
            this.txtUUChangeSet = new System.Windows.Forms.TextBox();
            this.ckbUUChangeSet = new System.Windows.Forms.CheckBox();
            this.ckbUUNoGet = new System.Windows.Forms.CheckBox();
            this.ckbUURecursive = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbpHistory = new System.Windows.Forms.TabPage();
            this.txtHistoryUser = new System.Windows.Forms.TextBox();
            this.ckbHistoryUser = new System.Windows.Forms.CheckBox();
            this.ckbHistoryBranches = new System.Windows.Forms.CheckBox();
            this.txtHistoryItemspec = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ckbHistoryRecursive = new System.Windows.Forms.CheckBox();
            this.tbpBulkCheckout = new System.Windows.Forms.TabPage();
            this.txtBulkCkoutItemspec = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ckbBulkCkoutRecursive = new System.Windows.Forms.CheckBox();
            this.tbpBulkCheckin = new System.Windows.Forms.TabPage();
            this.txtBulkCkinComment = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBulkCkinItemspec = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ckbBulkCkinRecursive = new System.Windows.Forms.CheckBox();
            this.tbpSearch = new System.Windows.Forms.TabPage();
            this.ckbSearchRecursive = new System.Windows.Forms.CheckBox();
            this.txtSearchFilespec = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTFPTLocation = new System.Windows.Forms.TextBox();
            this.btnBrowseTFPT = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtWorkspaceLocation = new System.Windows.Forms.TextBox();
            this.btnBrowseWorkspace = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ckbWordwrap = new System.Windows.Forms.CheckBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.txtTfsPassword = new System.Windows.Forms.TextBox();
            this.txtTfsUserName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAbort = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tbcCommands.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tbpReview.SuspendLayout();
            this.tbpTreeClean.SuspendLayout();
            this.tbpUU.SuspendLayout();
            this.tbpHistory.SuspendLayout();
            this.tbpBulkCheckout.SuspendLayout();
            this.tbpBulkCheckin.SuspendLayout();
            this.tbpSearch.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // tbcCommands
            // 
            this.tbcCommands.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcCommands.Controls.Add(this.tabPage1);
            this.tbcCommands.Controls.Add(this.tabPage2);
            this.tbcCommands.Controls.Add(this.tbpReview);
            this.tbcCommands.Controls.Add(this.tbpTreeClean);
            this.tbcCommands.Controls.Add(this.tbpUU);
            this.tbcCommands.Controls.Add(this.tbpHistory);
            this.tbcCommands.Controls.Add(this.tbpBulkCheckout);
            this.tbcCommands.Controls.Add(this.tbpBulkCheckin);
            this.tbcCommands.Controls.Add(this.tbpSearch);
            this.tbcCommands.Location = new System.Drawing.Point(12, 134);
            this.tbcCommands.Name = "tbcCommands";
            this.tbcCommands.SelectedIndex = 0;
            this.tbcCommands.Size = new System.Drawing.Size(945, 154);
            this.tbcCommands.TabIndex = 1;
            this.tbcCommands.Tag = "getcs";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.cbGetCsCleanFirst);
            this.tabPage1.Controls.Add(this.txtGetCsChangesets);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(937, 128);
            this.tabPage1.TabIndex = 7;
            this.tabPage1.Tag = "GetCS";
            this.tabPage1.Text = "获取多个变更集";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // cbGetCsCleanFirst
            // 
            this.cbGetCsCleanFirst.AutoSize = true;
            this.cbGetCsCleanFirst.Location = new System.Drawing.Point(16, 42);
            this.cbGetCsCleanFirst.Name = "cbGetCsCleanFirst";
            this.cbGetCsCleanFirst.Size = new System.Drawing.Size(216, 16);
            this.cbGetCsCleanFirst.TabIndex = 2;
            this.cbGetCsCleanFirst.Text = "获取之前先删除工作区中的所有文件";
            this.cbGetCsCleanFirst.UseVisualStyleBackColor = true;
            // 
            // txtGetCsChangesets
            // 
            this.txtGetCsChangesets.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetCsChangesets.Location = new System.Drawing.Point(69, 14);
            this.txtGetCsChangesets.Name = "txtGetCsChangesets";
            this.txtGetCsChangesets.Size = new System.Drawing.Size(664, 21);
            this.txtGetCsChangesets.TabIndex = 1;
            this.txtGetCsChangesets.Text = "3321,3359,3358";
            this.toolTip1.SetToolTip(this.txtGetCsChangesets, "多个变更集以逗号分隔。\r\n顺序随便，程序会对变更集排序。");
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 18);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 0;
            this.label11.Text = "变更集：";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtGetCsSqlFilterRegex);
            this.tabPage2.Controls.Add(this.btnGetCsExeSql);
            this.tabPage2.Controls.Add(this.txtGetCsSqlCmd);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(937, 128);
            this.tabPage2.TabIndex = 8;
            this.tabPage2.Text = "SqlCmd执行Sql";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 76);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(143, 36);
            this.label17.TabIndex = 9;
            this.label17.Text = "只执行路径符合\r\n该正则表达式的Sql\r\n（留空则执行所有Sql）：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(77, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "SqlCmd命令：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(86, 42);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(311, 12);
            this.label14.TabIndex = 8;
            this.label14.Text = "示例：sqlcmd -S SERVER -U USERNAME -P PWD -d DB -i ";
            // 
            // txtGetCsSqlFilterRegex
            // 
            this.txtGetCsSqlFilterRegex.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetCsSqlFilterRegex.Location = new System.Drawing.Point(149, 72);
            this.txtGetCsSqlFilterRegex.Multiline = true;
            this.txtGetCsSqlFilterRegex.Name = "txtGetCsSqlFilterRegex";
            this.txtGetCsSqlFilterRegex.Size = new System.Drawing.Size(398, 40);
            this.txtGetCsSqlFilterRegex.TabIndex = 7;
            this.txtGetCsSqlFilterRegex.Text = ".*\\\\FMCG.Database\\\\(ANP_Procedures|ANP_Function|Function|Procedures)\\\\.*\\.sql";
            // 
            // btnGetCsExeSql
            // 
            this.btnGetCsExeSql.Location = new System.Drawing.Point(488, 16);
            this.btnGetCsExeSql.Name = "btnGetCsExeSql";
            this.btnGetCsExeSql.Size = new System.Drawing.Size(117, 35);
            this.btnGetCsExeSql.TabIndex = 6;
            this.btnGetCsExeSql.Text = "执行Workspace中的sql文件";
            this.toolTip1.SetToolTip(this.btnGetCsExeSql, "执行之前应先获取变更集内容");
            this.btnGetCsExeSql.UseVisualStyleBackColor = true;
            this.btnGetCsExeSql.Click += new System.EventHandler(this.btnGetCsExeSql_Click);
            // 
            // txtGetCsSqlCmd
            // 
            this.txtGetCsSqlCmd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGetCsSqlCmd.Location = new System.Drawing.Point(88, 16);
            this.txtGetCsSqlCmd.Name = "txtGetCsSqlCmd";
            this.txtGetCsSqlCmd.Size = new System.Drawing.Size(373, 21);
            this.txtGetCsSqlCmd.TabIndex = 7;
            this.txtGetCsSqlCmd.Text = "sqlcmd -S . -U sa -P sa -d FMCG-null -i ";
            // 
            // tbpReview
            // 
            this.tbpReview.Controls.Add(this.txtReviewFilespec);
            this.tbpReview.Controls.Add(this.label6);
            this.tbpReview.Controls.Add(this.ckbReviewRecursive);
            this.tbpReview.Controls.Add(this.label5);
            this.tbpReview.Location = new System.Drawing.Point(4, 22);
            this.tbpReview.Name = "tbpReview";
            this.tbpReview.Size = new System.Drawing.Size(937, 128);
            this.tbpReview.TabIndex = 3;
            this.tbpReview.Tag = "ReviewChanges";
            this.tbpReview.Text = "Review Changes";
            this.tbpReview.UseVisualStyleBackColor = true;
            // 
            // txtReviewFilespec
            // 
            this.txtReviewFilespec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReviewFilespec.Location = new System.Drawing.Point(210, 37);
            this.txtReviewFilespec.Name = "txtReviewFilespec";
            this.txtReviewFilespec.Size = new System.Drawing.Size(650, 21);
            this.txtReviewFilespec.TabIndex = 3;
            this.txtReviewFilespec.Text = "*.*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(155, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "Filespec:";
            // 
            // ckbReviewRecursive
            // 
            this.ckbReviewRecursive.AutoSize = true;
            this.ckbReviewRecursive.Location = new System.Drawing.Point(9, 40);
            this.ckbReviewRecursive.Name = "ckbReviewRecursive";
            this.ckbReviewRecursive.Size = new System.Drawing.Size(78, 16);
            this.ckbReviewRecursive.TabIndex = 1;
            this.ckbReviewRecursive.Text = "Recursive";
            this.ckbReviewRecursive.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(635, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "*This command will launch a review dialog where you can review the changes made t" +
    "o the checked out files.";
            // 
            // tbpTreeClean
            // 
            this.tbpTreeClean.Controls.Add(this.ckbTCDelete);
            this.tbpTreeClean.Location = new System.Drawing.Point(4, 22);
            this.tbpTreeClean.Name = "tbpTreeClean";
            this.tbpTreeClean.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTreeClean.Size = new System.Drawing.Size(937, 128);
            this.tbpTreeClean.TabIndex = 0;
            this.tbpTreeClean.Tag = "TreeClean";
            this.tbpTreeClean.Text = "Tree Clean";
            this.tbpTreeClean.UseVisualStyleBackColor = true;
            // 
            // ckbTCDelete
            // 
            this.ckbTCDelete.AutoSize = true;
            this.ckbTCDelete.Location = new System.Drawing.Point(9, 15);
            this.ckbTCDelete.Name = "ckbTCDelete";
            this.ckbTCDelete.Size = new System.Drawing.Size(186, 16);
            this.ckbTCDelete.TabIndex = 0;
            this.ckbTCDelete.Text = "Delete Non-controlled Files";
            this.ckbTCDelete.UseVisualStyleBackColor = true;
            // 
            // tbpUU
            // 
            this.tbpUU.Controls.Add(this.txtUUFilespec);
            this.tbpUU.Controls.Add(this.ckbUUFilespec);
            this.tbpUU.Controls.Add(this.txtUUChangeSet);
            this.tbpUU.Controls.Add(this.ckbUUChangeSet);
            this.tbpUU.Controls.Add(this.ckbUUNoGet);
            this.tbpUU.Controls.Add(this.ckbUURecursive);
            this.tbpUU.Controls.Add(this.label3);
            this.tbpUU.Location = new System.Drawing.Point(4, 22);
            this.tbpUU.Name = "tbpUU";
            this.tbpUU.Padding = new System.Windows.Forms.Padding(3);
            this.tbpUU.Size = new System.Drawing.Size(937, 128);
            this.tbpUU.TabIndex = 1;
            this.tbpUU.Tag = "UndoUnchanged";
            this.tbpUU.Text = "Undo Unchanged";
            this.tbpUU.UseVisualStyleBackColor = true;
            // 
            // txtUUFilespec
            // 
            this.txtUUFilespec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUUFilespec.Enabled = false;
            this.txtUUFilespec.Location = new System.Drawing.Point(296, 53);
            this.txtUUFilespec.Name = "txtUUFilespec";
            this.txtUUFilespec.Size = new System.Drawing.Size(570, 21);
            this.txtUUFilespec.TabIndex = 6;
            // 
            // ckbUUFilespec
            // 
            this.ckbUUFilespec.AutoSize = true;
            this.ckbUUFilespec.Location = new System.Drawing.Point(205, 54);
            this.ckbUUFilespec.Name = "ckbUUFilespec";
            this.ckbUUFilespec.Size = new System.Drawing.Size(78, 16);
            this.ckbUUFilespec.TabIndex = 5;
            this.ckbUUFilespec.Text = "Filespec:";
            this.ckbUUFilespec.UseVisualStyleBackColor = true;
            this.ckbUUFilespec.CheckedChanged += new System.EventHandler(this.ckbUUFilespec_CheckedChanged);
            // 
            // txtUUChangeSet
            // 
            this.txtUUChangeSet.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUUChangeSet.Enabled = false;
            this.txtUUChangeSet.Location = new System.Drawing.Point(296, 31);
            this.txtUUChangeSet.Name = "txtUUChangeSet";
            this.txtUUChangeSet.Size = new System.Drawing.Size(570, 21);
            this.txtUUChangeSet.TabIndex = 4;
            this.txtUUChangeSet.Validated += new System.EventHandler(this.txtUUChangeSet_Validated);
            // 
            // ckbUUChangeSet
            // 
            this.ckbUUChangeSet.AutoSize = true;
            this.ckbUUChangeSet.Location = new System.Drawing.Point(205, 33);
            this.ckbUUChangeSet.Name = "ckbUUChangeSet";
            this.ckbUUChangeSet.Size = new System.Drawing.Size(90, 16);
            this.ckbUUChangeSet.TabIndex = 3;
            this.ckbUUChangeSet.Text = "Change Set:";
            this.ckbUUChangeSet.UseVisualStyleBackColor = true;
            this.ckbUUChangeSet.CheckedChanged += new System.EventHandler(this.ckbUUChangeSet_CheckedChanged);
            // 
            // ckbUUNoGet
            // 
            this.ckbUUNoGet.AutoSize = true;
            this.ckbUUNoGet.Location = new System.Drawing.Point(9, 54);
            this.ckbUUNoGet.Name = "ckbUUNoGet";
            this.ckbUUNoGet.Size = new System.Drawing.Size(60, 16);
            this.ckbUUNoGet.TabIndex = 2;
            this.ckbUUNoGet.Text = "No Get";
            this.ckbUUNoGet.UseVisualStyleBackColor = true;
            // 
            // ckbUURecursive
            // 
            this.ckbUURecursive.AutoSize = true;
            this.ckbUURecursive.Location = new System.Drawing.Point(9, 33);
            this.ckbUURecursive.Name = "ckbUURecursive";
            this.ckbUURecursive.Size = new System.Drawing.Size(78, 16);
            this.ckbUURecursive.TabIndex = 1;
            this.ckbUURecursive.Text = "Recursive";
            this.ckbUURecursive.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(371, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "*This command will execute without asking for the user input.";
            // 
            // tbpHistory
            // 
            this.tbpHistory.Controls.Add(this.txtHistoryUser);
            this.tbpHistory.Controls.Add(this.ckbHistoryUser);
            this.tbpHistory.Controls.Add(this.ckbHistoryBranches);
            this.tbpHistory.Controls.Add(this.txtHistoryItemspec);
            this.tbpHistory.Controls.Add(this.label9);
            this.tbpHistory.Controls.Add(this.ckbHistoryRecursive);
            this.tbpHistory.Location = new System.Drawing.Point(4, 22);
            this.tbpHistory.Name = "tbpHistory";
            this.tbpHistory.Size = new System.Drawing.Size(937, 128);
            this.tbpHistory.TabIndex = 6;
            this.tbpHistory.Tag = "History";
            this.tbpHistory.Text = "History";
            this.tbpHistory.UseVisualStyleBackColor = true;
            // 
            // txtHistoryUser
            // 
            this.txtHistoryUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoryUser.Enabled = false;
            this.txtHistoryUser.Location = new System.Drawing.Point(248, 16);
            this.txtHistoryUser.Name = "txtHistoryUser";
            this.txtHistoryUser.Size = new System.Drawing.Size(606, 21);
            this.txtHistoryUser.TabIndex = 5;
            this.txtHistoryUser.Validated += new System.EventHandler(this.txtHistoryUser_Validated);
            // 
            // ckbHistoryUser
            // 
            this.ckbHistoryUser.AutoSize = true;
            this.ckbHistoryUser.Location = new System.Drawing.Point(162, 18);
            this.ckbHistoryUser.Name = "ckbHistoryUser";
            this.ckbHistoryUser.Size = new System.Drawing.Size(54, 16);
            this.ckbHistoryUser.TabIndex = 4;
            this.ckbHistoryUser.Text = "User:";
            this.ckbHistoryUser.UseVisualStyleBackColor = true;
            this.ckbHistoryUser.CheckedChanged += new System.EventHandler(this.ckbHistoryUser_CheckedChanged);
            // 
            // ckbHistoryBranches
            // 
            this.ckbHistoryBranches.AutoSize = true;
            this.ckbHistoryBranches.Location = new System.Drawing.Point(9, 39);
            this.ckbHistoryBranches.Name = "ckbHistoryBranches";
            this.ckbHistoryBranches.Size = new System.Drawing.Size(114, 16);
            this.ckbHistoryBranches.TabIndex = 3;
            this.ckbHistoryBranches.Text = "Follow Branches";
            this.ckbHistoryBranches.UseVisualStyleBackColor = true;
            // 
            // txtHistoryItemspec
            // 
            this.txtHistoryItemspec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHistoryItemspec.Location = new System.Drawing.Point(248, 37);
            this.txtHistoryItemspec.Name = "txtHistoryItemspec";
            this.txtHistoryItemspec.Size = new System.Drawing.Size(606, 21);
            this.txtHistoryItemspec.TabIndex = 2;
            this.txtHistoryItemspec.Text = "*.*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(159, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 1;
            this.label9.Text = "Itemspec:";
            // 
            // ckbHistoryRecursive
            // 
            this.ckbHistoryRecursive.AutoSize = true;
            this.ckbHistoryRecursive.Checked = true;
            this.ckbHistoryRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbHistoryRecursive.Location = new System.Drawing.Point(9, 18);
            this.ckbHistoryRecursive.Name = "ckbHistoryRecursive";
            this.ckbHistoryRecursive.Size = new System.Drawing.Size(78, 16);
            this.ckbHistoryRecursive.TabIndex = 0;
            this.ckbHistoryRecursive.Text = "Recursive";
            this.ckbHistoryRecursive.UseVisualStyleBackColor = true;
            // 
            // tbpBulkCheckout
            // 
            this.tbpBulkCheckout.Controls.Add(this.txtBulkCkoutItemspec);
            this.tbpBulkCheckout.Controls.Add(this.label7);
            this.tbpBulkCheckout.Controls.Add(this.ckbBulkCkoutRecursive);
            this.tbpBulkCheckout.Location = new System.Drawing.Point(4, 22);
            this.tbpBulkCheckout.Name = "tbpBulkCheckout";
            this.tbpBulkCheckout.Size = new System.Drawing.Size(937, 128);
            this.tbpBulkCheckout.TabIndex = 4;
            this.tbpBulkCheckout.Tag = "BulkCheckout";
            this.tbpBulkCheckout.Text = "Bulk Checkout";
            this.tbpBulkCheckout.UseVisualStyleBackColor = true;
            // 
            // txtBulkCkoutItemspec
            // 
            this.txtBulkCkoutItemspec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBulkCkoutItemspec.Location = new System.Drawing.Point(218, 15);
            this.txtBulkCkoutItemspec.Name = "txtBulkCkoutItemspec";
            this.txtBulkCkoutItemspec.Size = new System.Drawing.Size(660, 21);
            this.txtBulkCkoutItemspec.TabIndex = 2;
            this.txtBulkCkoutItemspec.Text = "*.*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(159, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 1;
            this.label7.Text = "Itemspec:";
            // 
            // ckbBulkCkoutRecursive
            // 
            this.ckbBulkCkoutRecursive.AutoSize = true;
            this.ckbBulkCkoutRecursive.Location = new System.Drawing.Point(9, 18);
            this.ckbBulkCkoutRecursive.Name = "ckbBulkCkoutRecursive";
            this.ckbBulkCkoutRecursive.Size = new System.Drawing.Size(78, 16);
            this.ckbBulkCkoutRecursive.TabIndex = 0;
            this.ckbBulkCkoutRecursive.Text = "Recursive";
            this.ckbBulkCkoutRecursive.UseVisualStyleBackColor = true;
            // 
            // tbpBulkCheckin
            // 
            this.tbpBulkCheckin.Controls.Add(this.txtBulkCkinComment);
            this.tbpBulkCheckin.Controls.Add(this.label10);
            this.tbpBulkCheckin.Controls.Add(this.txtBulkCkinItemspec);
            this.tbpBulkCheckin.Controls.Add(this.label8);
            this.tbpBulkCheckin.Controls.Add(this.ckbBulkCkinRecursive);
            this.tbpBulkCheckin.Location = new System.Drawing.Point(4, 22);
            this.tbpBulkCheckin.Name = "tbpBulkCheckin";
            this.tbpBulkCheckin.Padding = new System.Windows.Forms.Padding(3);
            this.tbpBulkCheckin.Size = new System.Drawing.Size(937, 128);
            this.tbpBulkCheckin.TabIndex = 5;
            this.tbpBulkCheckin.Tag = "BulkCheckin";
            this.tbpBulkCheckin.Text = "Bulk Checkin";
            this.tbpBulkCheckin.UseVisualStyleBackColor = true;
            // 
            // txtBulkCkinComment
            // 
            this.txtBulkCkinComment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBulkCkinComment.Location = new System.Drawing.Point(218, 38);
            this.txtBulkCkinComment.Multiline = true;
            this.txtBulkCkinComment.Name = "txtBulkCkinComment";
            this.txtBulkCkinComment.Size = new System.Drawing.Size(708, 57);
            this.txtBulkCkinComment.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(111, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 12);
            this.label10.TabIndex = 3;
            this.label10.Text = "Checkin Comments:";
            // 
            // txtBulkCkinItemspec
            // 
            this.txtBulkCkinItemspec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBulkCkinItemspec.Location = new System.Drawing.Point(218, 15);
            this.txtBulkCkinItemspec.Name = "txtBulkCkinItemspec";
            this.txtBulkCkinItemspec.Size = new System.Drawing.Size(708, 21);
            this.txtBulkCkinItemspec.TabIndex = 2;
            this.txtBulkCkinItemspec.Text = "*.*";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(159, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 12);
            this.label8.TabIndex = 1;
            this.label8.Text = "Itemspec:";
            // 
            // ckbBulkCkinRecursive
            // 
            this.ckbBulkCkinRecursive.AutoSize = true;
            this.ckbBulkCkinRecursive.Location = new System.Drawing.Point(9, 18);
            this.ckbBulkCkinRecursive.Name = "ckbBulkCkinRecursive";
            this.ckbBulkCkinRecursive.Size = new System.Drawing.Size(78, 16);
            this.ckbBulkCkinRecursive.TabIndex = 0;
            this.ckbBulkCkinRecursive.Text = "Recursive";
            this.ckbBulkCkinRecursive.UseVisualStyleBackColor = true;
            // 
            // tbpSearch
            // 
            this.tbpSearch.Controls.Add(this.ckbSearchRecursive);
            this.tbpSearch.Controls.Add(this.txtSearchFilespec);
            this.tbpSearch.Controls.Add(this.label4);
            this.tbpSearch.Location = new System.Drawing.Point(4, 22);
            this.tbpSearch.Name = "tbpSearch";
            this.tbpSearch.Size = new System.Drawing.Size(937, 128);
            this.tbpSearch.TabIndex = 2;
            this.tbpSearch.Tag = "Search";
            this.tbpSearch.Text = "Search";
            this.tbpSearch.UseVisualStyleBackColor = true;
            // 
            // ckbSearchRecursive
            // 
            this.ckbSearchRecursive.AutoSize = true;
            this.ckbSearchRecursive.Checked = true;
            this.ckbSearchRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckbSearchRecursive.Location = new System.Drawing.Point(9, 18);
            this.ckbSearchRecursive.Name = "ckbSearchRecursive";
            this.ckbSearchRecursive.Size = new System.Drawing.Size(78, 16);
            this.ckbSearchRecursive.TabIndex = 0;
            this.ckbSearchRecursive.Text = "Recursive";
            this.ckbSearchRecursive.UseVisualStyleBackColor = true;
            // 
            // txtSearchFilespec
            // 
            this.txtSearchFilespec.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchFilespec.Location = new System.Drawing.Point(214, 15);
            this.txtSearchFilespec.Name = "txtSearchFilespec";
            this.txtSearchFilespec.Size = new System.Drawing.Size(664, 21);
            this.txtSearchFilespec.TabIndex = 2;
            this.txtSearchFilespec.Text = "*.*";
            this.txtSearchFilespec.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Filespec:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "TFPT Install Location:";
            // 
            // txtTFPTLocation
            // 
            this.txtTFPTLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.errorProvider.SetIconPadding(this.txtTFPTLocation, 2);
            this.txtTFPTLocation.Location = new System.Drawing.Point(153, 24);
            this.txtTFPTLocation.Name = "txtTFPTLocation";
            this.txtTFPTLocation.Size = new System.Drawing.Size(725, 21);
            this.txtTFPTLocation.TabIndex = 0;
            this.txtTFPTLocation.TabStop = false;
            this.txtTFPTLocation.Click += new System.EventHandler(this.OnTextboxEnter);
            this.txtTFPTLocation.TextChanged += new System.EventHandler(this.txtTFPTLocation_TextChanged);
            this.txtTFPTLocation.Enter += new System.EventHandler(this.OnTextboxEnter);
            this.txtTFPTLocation.Validated += new System.EventHandler(this.txtTFPTLocation_Validated);
            // 
            // btnBrowseTFPT
            // 
            this.btnBrowseTFPT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseTFPT.Location = new System.Drawing.Point(899, 22);
            this.btnBrowseTFPT.Name = "btnBrowseTFPT";
            this.btnBrowseTFPT.Size = new System.Drawing.Size(31, 21);
            this.btnBrowseTFPT.TabIndex = 1;
            this.btnBrowseTFPT.TabStop = false;
            this.btnBrowseTFPT.Text = "...";
            this.btnBrowseTFPT.UseVisualStyleBackColor = true;
            this.btnBrowseTFPT.Click += new System.EventHandler(this.OnBrowseTfptClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Workspace Location:";
            // 
            // txtWorkspaceLocation
            // 
            this.txtWorkspaceLocation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtWorkspaceLocation.Location = new System.Drawing.Point(153, 48);
            this.txtWorkspaceLocation.Name = "txtWorkspaceLocation";
            this.txtWorkspaceLocation.Size = new System.Drawing.Size(644, 21);
            this.txtWorkspaceLocation.TabIndex = 2;
            this.toolTip1.SetToolTip(this.txtWorkspaceLocation, "建议先到VS中新建一个空的工作区，然后选择该空工作区");
            this.txtWorkspaceLocation.Click += new System.EventHandler(this.OnTextboxEnter);
            this.txtWorkspaceLocation.TextChanged += new System.EventHandler(this.txtWorkspaceLocation_TextChanged);
            this.txtWorkspaceLocation.Enter += new System.EventHandler(this.OnTextboxEnter);
            this.txtWorkspaceLocation.Validated += new System.EventHandler(this.txtWorkspaceLocation_Validated);
            // 
            // btnBrowseWorkspace
            // 
            this.btnBrowseWorkspace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBrowseWorkspace.Location = new System.Drawing.Point(818, 46);
            this.btnBrowseWorkspace.Name = "btnBrowseWorkspace";
            this.btnBrowseWorkspace.Size = new System.Drawing.Size(31, 21);
            this.btnBrowseWorkspace.TabIndex = 3;
            this.btnBrowseWorkspace.Text = "...";
            this.toolTip1.SetToolTip(this.btnBrowseWorkspace, "建议先到VS中新建一个空的工作区，然后选择该空工作区");
            this.btnBrowseWorkspace.UseVisualStyleBackColor = true;
            this.btnBrowseWorkspace.Click += new System.EventHandler(this.OnBrowseClick);
            // 
            // txtOutput
            // 
            this.txtOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOutput.BackColor = System.Drawing.Color.White;
            this.txtOutput.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(20, 45);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(925, 339);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.WordWrap = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ckbWordwrap);
            this.groupBox1.Controls.Add(this.txtOutput);
            this.groupBox1.Location = new System.Drawing.Point(12, 294);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(941, 384);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // ckbWordwrap
            // 
            this.ckbWordwrap.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ckbWordwrap.AutoSize = true;
            this.ckbWordwrap.Location = new System.Drawing.Point(855, 18);
            this.ckbWordwrap.Name = "ckbWordwrap";
            this.ckbWordwrap.Size = new System.Drawing.Size(78, 16);
            this.ckbWordwrap.TabIndex = 0;
            this.ckbWordwrap.Text = "Word Wrap";
            this.ckbWordwrap.UseVisualStyleBackColor = true;
            this.ckbWordwrap.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnExecute
            // 
            this.btnExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExecute.Location = new System.Drawing.Point(783, 251);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 21);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "&Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btnHistory);
            this.groupBox2.Controls.Add(this.txtTfsPassword);
            this.groupBox2.Controls.Add(this.txtTfsUserName);
            this.groupBox2.Controls.Add(this.txtWorkspaceLocation);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTFPTLocation);
            this.groupBox2.Controls.Add(this.btnBrowseWorkspace);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.btnBrowseTFPT);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(945, 117);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Paths";
            // 
            // btnHistory
            // 
            this.btnHistory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHistory.Location = new System.Drawing.Point(855, 46);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(75, 21);
            this.btnHistory.TabIndex = 4;
            this.btnHistory.Text = "&History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // txtTfsPassword
            // 
            this.txtTfsPassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTfsPassword.Location = new System.Drawing.Point(459, 76);
            this.txtTfsPassword.Name = "txtTfsPassword";
            this.txtTfsPassword.PasswordChar = '*';
            this.txtTfsPassword.Size = new System.Drawing.Size(150, 21);
            this.txtTfsPassword.TabIndex = 6;
            this.txtTfsPassword.Click += new System.EventHandler(this.OnTextboxEnter);
            this.txtTfsPassword.TextChanged += new System.EventHandler(this.txtTfsPassword_TextChanged);
            this.txtTfsPassword.Enter += new System.EventHandler(this.OnTextboxEnter);
            // 
            // txtTfsUserName
            // 
            this.txtTfsUserName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTfsUserName.Location = new System.Drawing.Point(153, 76);
            this.txtTfsUserName.Name = "txtTfsUserName";
            this.txtTfsUserName.Size = new System.Drawing.Size(150, 21);
            this.txtTfsUserName.TabIndex = 5;
            this.txtTfsUserName.Click += new System.EventHandler(this.OnTextboxEnter);
            this.txtTfsUserName.TextChanged += new System.EventHandler(this.txtTfsUserName_TextChanged);
            this.txtTfsUserName.Enter += new System.EventHandler(this.OnTextboxEnter);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(370, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 12);
            this.label13.TabIndex = 0;
            this.label13.Text = "TFS Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(40, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(89, 12);
            this.label12.TabIndex = 0;
            this.label12.Text = "TFS User Name:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnAbort
            // 
            this.btnAbort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbort.Enabled = false;
            this.btnAbort.Location = new System.Drawing.Point(867, 251);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(75, 21);
            this.btnAbort.TabIndex = 1;
            this.btnAbort.Text = "&Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // TfptWrapperDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 690);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbcCommands);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TfptWrapperDialog";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Team Foundation Power Toys (TFPT) UI - V1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TfptWrapperDialog_FormClosing);
            this.tbcCommands.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tbpReview.ResumeLayout(false);
            this.tbpReview.PerformLayout();
            this.tbpTreeClean.ResumeLayout(false);
            this.tbpTreeClean.PerformLayout();
            this.tbpUU.ResumeLayout(false);
            this.tbpUU.PerformLayout();
            this.tbpHistory.ResumeLayout(false);
            this.tbpHistory.PerformLayout();
            this.tbpBulkCheckout.ResumeLayout(false);
            this.tbpBulkCheckout.PerformLayout();
            this.tbpBulkCheckin.ResumeLayout(false);
            this.tbpBulkCheckin.PerformLayout();
            this.tbpSearch.ResumeLayout(false);
            this.tbpSearch.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbcCommands;
        private System.Windows.Forms.TabPage tbpTreeClean;
        private System.Windows.Forms.TabPage tbpUU;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTFPTLocation;
        private System.Windows.Forms.Button btnBrowseTFPT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWorkspaceLocation;
        private System.Windows.Forms.Button btnBrowseWorkspace;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox ckbTCDelete;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox ckbUURecursive;
        private System.Windows.Forms.CheckBox ckbUUChangeSet;
        private System.Windows.Forms.CheckBox ckbUUNoGet;
        private System.Windows.Forms.TextBox txtUUFilespec;
        private System.Windows.Forms.CheckBox ckbUUFilespec;
        private System.Windows.Forms.TextBox txtUUChangeSet;
        private System.Windows.Forms.CheckBox ckbWordwrap;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.TabPage tbpSearch;
        private System.Windows.Forms.TextBox txtSearchFilespec;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox ckbSearchRecursive;
        private System.Windows.Forms.TabPage tbpReview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtReviewFilespec;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox ckbReviewRecursive;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.TabPage tbpBulkCheckout;
        private System.Windows.Forms.TextBox txtBulkCkoutItemspec;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ckbBulkCkoutRecursive;
        private System.Windows.Forms.TabPage tbpBulkCheckin;
        private System.Windows.Forms.TextBox txtBulkCkinItemspec;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox ckbBulkCkinRecursive;
        private System.Windows.Forms.TabPage tbpHistory;
        private System.Windows.Forms.TextBox txtHistoryItemspec;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox ckbHistoryRecursive;
        private System.Windows.Forms.CheckBox ckbHistoryUser;
        private System.Windows.Forms.CheckBox ckbHistoryBranches;
        private System.Windows.Forms.TextBox txtHistoryUser;
        private System.Windows.Forms.TextBox txtBulkCkinComment;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.CheckBox cbGetCsCleanFirst;
        private System.Windows.Forms.TextBox txtGetCsChangesets;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTfsUserName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTfsPassword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnGetCsExeSql;
        private System.Windows.Forms.TextBox txtGetCsSqlCmd;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtGetCsSqlFilterRegex;

    }
}

