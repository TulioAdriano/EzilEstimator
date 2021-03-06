namespace CryptoStats
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEth24h = new System.Windows.Forms.TextBox();
            this.lblEthUsd = new System.Windows.Forms.Label();
            this.lblEntryCount = new System.Windows.Forms.Label();
            this.picWorkerGraph = new System.Windows.Forms.PictureBox();
            this.workerTree = new System.Windows.Forms.TreeView();
            this.cmdRefeshGraph = new System.Windows.Forms.Button();
            this.cmdRefreshRewards = new System.Windows.Forms.Button();
            this.cmdCombineGraphs = new System.Windows.Forms.Button();
            this.lblHashPower = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtZil24h = new System.Windows.Forms.TextBox();
            this.lblZilUsd = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblEthBalance = new System.Windows.Forms.Label();
            this.lblZilBalance = new System.Windows.Forms.Label();
            this.lblTotalBalance = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblZilValue = new System.Windows.Forms.Label();
            this.lblEthValue = new System.Windows.Forms.Label();
            this.cmdMergeGraphs = new System.Windows.Forms.Button();
            this.txtGranularity = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPowerUsage = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNextZil = new System.Windows.Forms.Label();
            this.lblZilToday = new System.Windows.Forms.Label();
            this.lblEthToday = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEzilDiff = new System.Windows.Forms.Label();
            this.lblNetHash = new System.Windows.Forms.Label();
            this.lblBlockReward = new System.Windows.Forms.Label();
            this.lblEthCurProfit = new System.Windows.Forms.Label();
            this.lblEthProfit = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblAverageHashrate = new System.Windows.Forms.Label();
            this.rdo48h = new System.Windows.Forms.RadioButton();
            this.rdo24h = new System.Windows.Forms.RadioButton();
            this.lblInvalidShares = new System.Windows.Forms.Label();
            this.lblAcceptedShares = new System.Windows.Forms.Label();
            this.lblSharesRatio = new System.Windows.Forms.Label();
            this.lblStaleShares = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblRealHash = new System.Windows.Forms.Label();
            this.rdo24hHistory = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomHash = new System.Windows.Forms.NumericUpDown();
            this.rdoUseCustom = new System.Windows.Forms.RadioButton();
            this.rdoUseReported = new System.Windows.Forms.RadioButton();
            this.rdoUseAverage = new System.Windows.Forms.RadioButton();
            this.zilTimer = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.pbStatus = new System.Windows.Forms.ToolStripProgressBar();
            this.chkConsolidateMEV = new System.Windows.Forms.CheckBox();
            this.rdoEzil = new System.Windows.Forms.RadioButton();
            this.rdoFlexPool = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkerGraph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGranularity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomHash)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView.Location = new System.Drawing.Point(818, 196);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.Size = new System.Drawing.Size(536, 471);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETH in the last 24h:";
            // 
            // txtEth24h
            // 
            this.txtEth24h.Location = new System.Drawing.Point(112, 13);
            this.txtEth24h.Name = "txtEth24h";
            this.txtEth24h.Size = new System.Drawing.Size(167, 20);
            this.txtEth24h.TabIndex = 2;
            // 
            // lblEthUsd
            // 
            this.lblEthUsd.AutoSize = true;
            this.lblEthUsd.Location = new System.Drawing.Point(284, 16);
            this.lblEthUsd.Name = "lblEthUsd";
            this.lblEthUsd.Size = new System.Drawing.Size(48, 13);
            this.lblEthUsd.TabIndex = 3;
            this.lblEthUsd.Text = "= 0 USD";
            // 
            // lblEntryCount
            // 
            this.lblEntryCount.AutoSize = true;
            this.lblEntryCount.Location = new System.Drawing.Point(816, 180);
            this.lblEntryCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEntryCount.Name = "lblEntryCount";
            this.lblEntryCount.Size = new System.Drawing.Size(47, 13);
            this.lblEntryCount.TabIndex = 4;
            this.lblEntryCount.Text = "0 entries";
            // 
            // picWorkerGraph
            // 
            this.picWorkerGraph.BackColor = System.Drawing.Color.White;
            this.picWorkerGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWorkerGraph.Location = new System.Drawing.Point(8, 467);
            this.picWorkerGraph.Name = "picWorkerGraph";
            this.picWorkerGraph.Size = new System.Drawing.Size(800, 200);
            this.picWorkerGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkerGraph.TabIndex = 5;
            this.picWorkerGraph.TabStop = false;
            // 
            // workerTree
            // 
            this.workerTree.Location = new System.Drawing.Point(8, 30);
            this.workerTree.Name = "workerTree";
            this.workerTree.Size = new System.Drawing.Size(526, 382);
            this.workerTree.TabIndex = 6;
            this.workerTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.workerTree_AfterSelect);
            // 
            // cmdRefeshGraph
            // 
            this.cmdRefeshGraph.Location = new System.Drawing.Point(459, 415);
            this.cmdRefeshGraph.Name = "cmdRefeshGraph";
            this.cmdRefeshGraph.Size = new System.Drawing.Size(75, 23);
            this.cmdRefeshGraph.TabIndex = 7;
            this.cmdRefeshGraph.Text = "Refresh";
            this.cmdRefeshGraph.UseVisualStyleBackColor = true;
            this.cmdRefeshGraph.Click += new System.EventHandler(this.cmdRefeshGraph_Click);
            // 
            // cmdRefreshRewards
            // 
            this.cmdRefreshRewards.Location = new System.Drawing.Point(1280, 167);
            this.cmdRefreshRewards.Name = "cmdRefreshRewards";
            this.cmdRefreshRewards.Size = new System.Drawing.Size(75, 23);
            this.cmdRefreshRewards.TabIndex = 8;
            this.cmdRefreshRewards.Text = "Refresh";
            this.cmdRefreshRewards.UseVisualStyleBackColor = true;
            this.cmdRefreshRewards.Click += new System.EventHandler(this.cmdRefreshRewards_Click);
            // 
            // cmdCombineGraphs
            // 
            this.cmdCombineGraphs.Location = new System.Drawing.Point(578, 437);
            this.cmdCombineGraphs.Name = "cmdCombineGraphs";
            this.cmdCombineGraphs.Size = new System.Drawing.Size(111, 23);
            this.cmdCombineGraphs.TabIndex = 7;
            this.cmdCombineGraphs.Text = "Overlay Graphs";
            this.cmdCombineGraphs.UseVisualStyleBackColor = true;
            this.cmdCombineGraphs.Click += new System.EventHandler(this.cmdCombineGraphs_Click);
            // 
            // lblHashPower
            // 
            this.lblHashPower.AutoSize = true;
            this.lblHashPower.Location = new System.Drawing.Point(11, 415);
            this.lblHashPower.Name = "lblHashPower";
            this.lblHashPower.Size = new System.Drawing.Size(127, 13);
            this.lblHashPower.TabIndex = 9;
            this.lblHashPower.Text = "Total Hash Rate: 0 MH/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZIL in the last 24h:";
            // 
            // txtZil24h
            // 
            this.txtZil24h.Location = new System.Drawing.Point(112, 34);
            this.txtZil24h.Name = "txtZil24h";
            this.txtZil24h.Size = new System.Drawing.Size(167, 20);
            this.txtZil24h.TabIndex = 2;
            // 
            // lblZilUsd
            // 
            this.lblZilUsd.AutoSize = true;
            this.lblZilUsd.Location = new System.Drawing.Point(284, 38);
            this.lblZilUsd.Name = "lblZilUsd";
            this.lblZilUsd.Size = new System.Drawing.Size(48, 13);
            this.lblZilUsd.TabIndex = 3;
            this.lblZilUsd.Text = "= 0 USD";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(284, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(48, 13);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "= 0 USD";
            // 
            // lblEthBalance
            // 
            this.lblEthBalance.AutoSize = true;
            this.lblEthBalance.Location = new System.Drawing.Point(4, 75);
            this.lblEthBalance.Name = "lblEthBalance";
            this.lblEthBalance.Size = new System.Drawing.Size(78, 13);
            this.lblEthBalance.TabIndex = 10;
            this.lblEthBalance.Text = "Unpaid ETH: 0";
            // 
            // lblZilBalance
            // 
            this.lblZilBalance.AutoSize = true;
            this.lblZilBalance.Location = new System.Drawing.Point(4, 95);
            this.lblZilBalance.Name = "lblZilBalance";
            this.lblZilBalance.Size = new System.Drawing.Size(72, 13);
            this.lblZilBalance.TabIndex = 11;
            this.lblZilBalance.Text = "Unpaid ZIL: 0";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.Location = new System.Drawing.Point(80, 114);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(124, 14);
            this.lblTotalBalance.TabIndex = 12;
            this.lblTotalBalance.Text = "= (0.00 USD)";
            this.lblTotalBalance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(3, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 22);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(113, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblZilValue
            // 
            this.lblZilValue.Location = new System.Drawing.Point(132, 95);
            this.lblZilValue.Name = "lblZilValue";
            this.lblZilValue.Size = new System.Drawing.Size(72, 19);
            this.lblZilValue.TabIndex = 12;
            this.lblZilValue.Text = "(0.00 USD)";
            this.lblZilValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEthValue
            // 
            this.lblEthValue.Location = new System.Drawing.Point(132, 75);
            this.lblEthValue.Name = "lblEthValue";
            this.lblEthValue.Size = new System.Drawing.Size(72, 20);
            this.lblEthValue.TabIndex = 12;
            this.lblEthValue.Text = "(0.00 USD)";
            this.lblEthValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdMergeGraphs
            // 
            this.cmdMergeGraphs.Location = new System.Drawing.Point(696, 437);
            this.cmdMergeGraphs.Name = "cmdMergeGraphs";
            this.cmdMergeGraphs.Size = new System.Drawing.Size(111, 23);
            this.cmdMergeGraphs.TabIndex = 7;
            this.cmdMergeGraphs.Text = "Merge Graphs";
            this.cmdMergeGraphs.UseVisualStyleBackColor = true;
            this.cmdMergeGraphs.Click += new System.EventHandler(this.cmdMergeGraphs_Click);
            // 
            // txtGranularity
            // 
            this.txtGranularity.Location = new System.Drawing.Point(750, 417);
            this.txtGranularity.Margin = new System.Windows.Forms.Padding(2);
            this.txtGranularity.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.txtGranularity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtGranularity.Name = "txtGranularity";
            this.txtGranularity.Size = new System.Drawing.Size(57, 20);
            this.txtGranularity.TabIndex = 14;
            this.txtGranularity.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(696, 420);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seconds:";
            // 
            // lblPowerUsage
            // 
            this.lblPowerUsage.AutoSize = true;
            this.lblPowerUsage.Location = new System.Drawing.Point(195, 415);
            this.lblPowerUsage.Name = "lblPowerUsage";
            this.lblPowerUsage.Size = new System.Drawing.Size(108, 13);
            this.lblPowerUsage.TabIndex = 9;
            this.lblPowerUsage.Text = "Total Power: 0 KW/h";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNextZil);
            this.groupBox1.Controls.Add(this.lblZilToday);
            this.groupBox1.Controls.Add(this.lblEthToday);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtEth24h);
            this.groupBox1.Controls.Add(this.lblEthValue);
            this.groupBox1.Controls.Add(this.txtZil24h);
            this.groupBox1.Controls.Add(this.lblZilValue);
            this.groupBox1.Controls.Add(this.lblEthUsd);
            this.groupBox1.Controls.Add(this.lblTotalBalance);
            this.groupBox1.Controls.Add(this.lblZilUsd);
            this.groupBox1.Controls.Add(this.lblZilBalance);
            this.groupBox1.Controls.Add(this.lblTotal);
            this.groupBox1.Controls.Add(this.lblEthBalance);
            this.groupBox1.Location = new System.Drawing.Point(818, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(536, 132);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live Stats";
            // 
            // lblNextZil
            // 
            this.lblNextZil.AutoSize = true;
            this.lblNextZil.Location = new System.Drawing.Point(244, 114);
            this.lblNextZil.Name = "lblNextZil";
            this.lblNextZil.Size = new System.Drawing.Size(131, 13);
            this.lblNextZil.TabIndex = 14;
            this.lblNextZil.Text = "Next ZIL round in: 0:00:00";
            // 
            // lblZilToday
            // 
            this.lblZilToday.AutoSize = true;
            this.lblZilToday.Location = new System.Drawing.Point(244, 95);
            this.lblZilToday.Name = "lblZilToday";
            this.lblZilToday.Size = new System.Drawing.Size(100, 13);
            this.lblZilToday.TabIndex = 13;
            this.lblZilToday.Text = "ZIL earned today: 0";
            // 
            // lblEthToday
            // 
            this.lblEthToday.AutoSize = true;
            this.lblEthToday.Location = new System.Drawing.Point(244, 75);
            this.lblEthToday.Name = "lblEthToday";
            this.lblEthToday.Size = new System.Drawing.Size(106, 13);
            this.lblEthToday.TabIndex = 13;
            this.lblEthToday.Text = "ETH earned today: 0";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEzilDiff);
            this.groupBox2.Controls.Add(this.lblNetHash);
            this.groupBox2.Controls.Add(this.lblBlockReward);
            this.groupBox2.Controls.Add(this.lblEthCurProfit);
            this.groupBox2.Controls.Add(this.lblEthProfit);
            this.groupBox2.Location = new System.Drawing.Point(536, 30);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(271, 132);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minerstats Data (Ethereum)";
            // 
            // lblEzilDiff
            // 
            this.lblEzilDiff.AutoSize = true;
            this.lblEzilDiff.Location = new System.Drawing.Point(3, 115);
            this.lblEzilDiff.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEzilDiff.Name = "lblEzilDiff";
            this.lblEzilDiff.Size = new System.Drawing.Size(231, 13);
            this.lblEzilDiff.TabIndex = 1;
            this.lblEzilDiff.Text = "Difference to Ezil: 0.0000000 ETH (00.00 USD)";
            // 
            // lblNetHash
            // 
            this.lblNetHash.AutoSize = true;
            this.lblNetHash.Location = new System.Drawing.Point(3, 16);
            this.lblNetHash.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNetHash.Name = "lblNetHash";
            this.lblNetHash.Size = new System.Drawing.Size(160, 13);
            this.lblNetHash.TabIndex = 0;
            this.lblNetHash.Text = "Network Hashrate: 000.00 TH/s";
            // 
            // lblBlockReward
            // 
            this.lblBlockReward.AutoSize = true;
            this.lblBlockReward.Location = new System.Drawing.Point(3, 38);
            this.lblBlockReward.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblBlockReward.Name = "lblBlockReward";
            this.lblBlockReward.Size = new System.Drawing.Size(156, 13);
            this.lblBlockReward.TabIndex = 0;
            this.lblBlockReward.Text = "Block Reward: 0.0000000 ETH";
            // 
            // lblEthCurProfit
            // 
            this.lblEthCurProfit.AutoSize = true;
            this.lblEthCurProfit.Location = new System.Drawing.Point(3, 75);
            this.lblEthCurProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEthCurProfit.Name = "lblEthCurProfit";
            this.lblEthCurProfit.Size = new System.Drawing.Size(238, 13);
            this.lblEthCurProfit.TabIndex = 0;
            this.lblEthCurProfit.Text = "Current Profitability: 0.0000000 ETH (00.00 USD)";
            // 
            // lblEthProfit
            // 
            this.lblEthProfit.AutoSize = true;
            this.lblEthProfit.Location = new System.Drawing.Point(3, 95);
            this.lblEthProfit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEthProfit.Name = "lblEthProfit";
            this.lblEthProfit.Size = new System.Drawing.Size(222, 13);
            this.lblEthProfit.TabIndex = 0;
            this.lblEthProfit.Text = "24h Profitability: 0.0000000 ETH (00.00 USD)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblAverageHashrate);
            this.groupBox3.Controls.Add(this.rdo48h);
            this.groupBox3.Controls.Add(this.rdo24h);
            this.groupBox3.Controls.Add(this.lblInvalidShares);
            this.groupBox3.Controls.Add(this.lblAcceptedShares);
            this.groupBox3.Controls.Add(this.lblSharesRatio);
            this.groupBox3.Controls.Add(this.lblStaleShares);
            this.groupBox3.Location = new System.Drawing.Point(536, 265);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(271, 148);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ezil Historical Stats";
            // 
            // lblAverageHashrate
            // 
            this.lblAverageHashrate.AutoSize = true;
            this.lblAverageHashrate.Location = new System.Drawing.Point(3, 128);
            this.lblAverageHashrate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAverageHashrate.Name = "lblAverageHashrate";
            this.lblAverageHashrate.Size = new System.Drawing.Size(164, 13);
            this.lblAverageHashrate.TabIndex = 2;
            this.lblAverageHashrate.Text = "Average Hash Rate = 0.00 MH/s";
            // 
            // rdo48h
            // 
            this.rdo48h.AutoSize = true;
            this.rdo48h.Location = new System.Drawing.Point(60, 17);
            this.rdo48h.Margin = new System.Windows.Forms.Padding(2);
            this.rdo48h.Name = "rdo48h";
            this.rdo48h.Size = new System.Drawing.Size(43, 17);
            this.rdo48h.TabIndex = 1;
            this.rdo48h.Text = "48h";
            this.rdo48h.UseVisualStyleBackColor = true;
            // 
            // rdo24h
            // 
            this.rdo24h.AutoSize = true;
            this.rdo24h.Checked = true;
            this.rdo24h.Location = new System.Drawing.Point(6, 17);
            this.rdo24h.Margin = new System.Windows.Forms.Padding(2);
            this.rdo24h.Name = "rdo24h";
            this.rdo24h.Size = new System.Drawing.Size(43, 17);
            this.rdo24h.TabIndex = 1;
            this.rdo24h.TabStop = true;
            this.rdo24h.Text = "24h";
            this.rdo24h.UseVisualStyleBackColor = true;
            this.rdo24h.CheckedChanged += new System.EventHandler(this.rdo24h_CheckedChanged);
            // 
            // lblInvalidShares
            // 
            this.lblInvalidShares.AutoSize = true;
            this.lblInvalidShares.Location = new System.Drawing.Point(3, 85);
            this.lblInvalidShares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblInvalidShares.Name = "lblInvalidShares";
            this.lblInvalidShares.Size = new System.Drawing.Size(113, 13);
            this.lblInvalidShares.TabIndex = 0;
            this.lblInvalidShares.Text = "Total Invalid Shares: 0";
            // 
            // lblAcceptedShares
            // 
            this.lblAcceptedShares.AutoSize = true;
            this.lblAcceptedShares.Location = new System.Drawing.Point(3, 42);
            this.lblAcceptedShares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAcceptedShares.Name = "lblAcceptedShares";
            this.lblAcceptedShares.Size = new System.Drawing.Size(128, 13);
            this.lblAcceptedShares.TabIndex = 0;
            this.lblAcceptedShares.Text = "Total Accepted Shares: 0";
            // 
            // lblSharesRatio
            // 
            this.lblSharesRatio.AutoSize = true;
            this.lblSharesRatio.Location = new System.Drawing.Point(3, 106);
            this.lblSharesRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSharesRatio.Name = "lblSharesRatio";
            this.lblSharesRatio.Size = new System.Drawing.Size(115, 13);
            this.lblSharesRatio.TabIndex = 0;
            this.lblSharesRatio.Text = "Stale Shares Ratio: 0%";
            // 
            // lblStaleShares
            // 
            this.lblStaleShares.AutoSize = true;
            this.lblStaleShares.Location = new System.Drawing.Point(3, 64);
            this.lblStaleShares.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStaleShares.Name = "lblStaleShares";
            this.lblStaleShares.Size = new System.Drawing.Size(106, 13);
            this.lblStaleShares.TabIndex = 0;
            this.lblStaleShares.Text = "Total Stale Shares: 0";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblRealHash);
            this.groupBox4.Controls.Add(this.rdo24hHistory);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txtCustomHash);
            this.groupBox4.Controls.Add(this.rdoUseCustom);
            this.groupBox4.Controls.Add(this.rdoUseReported);
            this.groupBox4.Controls.Add(this.rdoUseAverage);
            this.groupBox4.Location = new System.Drawing.Point(536, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(271, 93);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "HashRate used for estimates";
            // 
            // lblRealHash
            // 
            this.lblRealHash.AutoSize = true;
            this.lblRealHash.Location = new System.Drawing.Point(159, 35);
            this.lblRealHash.Name = "lblRealHash";
            this.lblRealHash.Size = new System.Drawing.Size(49, 13);
            this.lblRealHash.TabIndex = 18;
            this.lblRealHash.Text = "(0 MH/s)";
            // 
            // rdo24hHistory
            // 
            this.rdo24hHistory.AutoSize = true;
            this.rdo24hHistory.Location = new System.Drawing.Point(141, 19);
            this.rdo24hHistory.Name = "rdo24hHistory";
            this.rdo24hHistory.Size = new System.Drawing.Size(128, 17);
            this.rdo24hHistory.TabIndex = 17;
            this.rdo24hHistory.TabStop = true;
            this.rdo24hHistory.Text = "Use 24h Hash History";
            this.rdo24hHistory.UseVisualStyleBackColor = true;
            this.rdo24hHistory.CheckedChanged += new System.EventHandler(this.rdo24hHistory_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(231, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "MH/s";
            // 
            // txtCustomHash
            // 
            this.txtCustomHash.Location = new System.Drawing.Point(116, 65);
            this.txtCustomHash.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomHash.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.txtCustomHash.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.txtCustomHash.Name = "txtCustomHash";
            this.txtCustomHash.Size = new System.Drawing.Size(110, 20);
            this.txtCustomHash.TabIndex = 15;
            this.txtCustomHash.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // rdoUseCustom
            // 
            this.rdoUseCustom.AutoSize = true;
            this.rdoUseCustom.Location = new System.Drawing.Point(6, 65);
            this.rdoUseCustom.Name = "rdoUseCustom";
            this.rdoUseCustom.Size = new System.Drawing.Size(105, 17);
            this.rdoUseCustom.TabIndex = 2;
            this.rdoUseCustom.Text = "Use custom rate:";
            this.rdoUseCustom.UseVisualStyleBackColor = true;
            this.rdoUseCustom.CheckedChanged += new System.EventHandler(this.rdoUseCustom_CheckedChanged);
            // 
            // rdoUseReported
            // 
            this.rdoUseReported.AutoSize = true;
            this.rdoUseReported.Location = new System.Drawing.Point(6, 42);
            this.rdoUseReported.Name = "rdoUseReported";
            this.rdoUseReported.Size = new System.Drawing.Size(139, 17);
            this.rdoUseReported.TabIndex = 1;
            this.rdoUseReported.Text = "Use T-Rex reported rate";
            this.rdoUseReported.UseVisualStyleBackColor = true;
            this.rdoUseReported.CheckedChanged += new System.EventHandler(this.rdoUseReported_CheckedChanged);
            // 
            // rdoUseAverage
            // 
            this.rdoUseAverage.AutoSize = true;
            this.rdoUseAverage.Checked = true;
            this.rdoUseAverage.Location = new System.Drawing.Point(6, 19);
            this.rdoUseAverage.Name = "rdoUseAverage";
            this.rdoUseAverage.Size = new System.Drawing.Size(105, 17);
            this.rdoUseAverage.TabIndex = 0;
            this.rdoUseAverage.TabStop = true;
            this.rdoUseAverage.Text = "Use Ezil average";
            this.rdoUseAverage.UseVisualStyleBackColor = true;
            this.rdoUseAverage.CheckedChanged += new System.EventHandler(this.rdoUseAverage_CheckedChanged);
            // 
            // zilTimer
            // 
            this.zilTimer.Interval = 1000;
            this.zilTimer.Tick += new System.EventHandler(this.zilTimer_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtStatus,
            this.pbStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 673);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1362, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtStatus
            // 
            this.txtStatus.AutoSize = false;
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(1245, 17);
            this.txtStatus.Spring = true;
            this.txtStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pbStatus
            // 
            this.pbStatus.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.pbStatus.Name = "pbStatus";
            this.pbStatus.Size = new System.Drawing.Size(100, 16);
            // 
            // chkConsolidateMEV
            // 
            this.chkConsolidateMEV.AutoSize = true;
            this.chkConsolidateMEV.Checked = true;
            this.chkConsolidateMEV.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkConsolidateMEV.Location = new System.Drawing.Point(1105, 179);
            this.chkConsolidateMEV.Name = "chkConsolidateMEV";
            this.chkConsolidateMEV.Size = new System.Drawing.Size(147, 17);
            this.chkConsolidateMEV.TabIndex = 21;
            this.chkConsolidateMEV.Text = "Consolidate MEV rewards";
            this.chkConsolidateMEV.UseVisualStyleBackColor = true;
            this.chkConsolidateMEV.CheckedChanged += new System.EventHandler(this.chkConsolidateMEV_CheckedChanged);
            // 
            // rdoEzil
            // 
            this.rdoEzil.AutoSize = true;
            this.rdoEzil.Location = new System.Drawing.Point(818, 161);
            this.rdoEzil.Name = "rdoEzil";
            this.rdoEzil.Size = new System.Drawing.Size(58, 17);
            this.rdoEzil.TabIndex = 22;
            this.rdoEzil.Text = "Ezil.me";
            this.rdoEzil.UseVisualStyleBackColor = true;
            this.rdoEzil.CheckedChanged += new System.EventHandler(this.rdoEzil_CheckedChanged);
            // 
            // rdoFlexPool
            // 
            this.rdoFlexPool.AutoSize = true;
            this.rdoFlexPool.Checked = true;
            this.rdoFlexPool.Location = new System.Drawing.Point(909, 161);
            this.rdoFlexPool.Name = "rdoFlexPool";
            this.rdoFlexPool.Size = new System.Drawing.Size(76, 17);
            this.rdoFlexPool.TabIndex = 22;
            this.rdoFlexPool.TabStop = true;
            this.rdoFlexPool.Text = "FlexPool.io";
            this.rdoFlexPool.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1362, 695);
            this.Controls.Add(this.rdoFlexPool);
            this.Controls.Add(this.rdoEzil);
            this.Controls.Add(this.chkConsolidateMEV);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGranularity);
            this.Controls.Add(this.lblPowerUsage);
            this.Controls.Add(this.lblHashPower);
            this.Controls.Add(this.cmdRefreshRewards);
            this.Controls.Add(this.cmdMergeGraphs);
            this.Controls.Add(this.cmdCombineGraphs);
            this.Controls.Add(this.cmdRefeshGraph);
            this.Controls.Add(this.workerTree);
            this.Controls.Add(this.picWorkerGraph);
            this.Controls.Add(this.lblEntryCount);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.Text = "Jamirocoin Ezil Estimator";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkerGraph)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGranularity)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtCustomHash)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEth24h;
        private System.Windows.Forms.Label lblEthUsd;
        private System.Windows.Forms.Label lblEntryCount;
        private System.Windows.Forms.PictureBox picWorkerGraph;
        private System.Windows.Forms.TreeView workerTree;
        private System.Windows.Forms.Button cmdRefeshGraph;
        private System.Windows.Forms.Button cmdRefreshRewards;
        private System.Windows.Forms.Button cmdCombineGraphs;
        private System.Windows.Forms.Label lblHashPower;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtZil24h;
        private System.Windows.Forms.Label lblZilUsd;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblEthBalance;
        private System.Windows.Forms.Label lblZilBalance;
        private System.Windows.Forms.Label lblTotalBalance;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label lblZilValue;
        private System.Windows.Forms.Label lblEthValue;
        private System.Windows.Forms.Button cmdMergeGraphs;
        private System.Windows.Forms.NumericUpDown txtGranularity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPowerUsage;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblEzilDiff;
        private System.Windows.Forms.Label lblNetHash;
        private System.Windows.Forms.Label lblBlockReward;
        private System.Windows.Forms.Label lblEthProfit;
        private System.Windows.Forms.Label lblEthCurProfit;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblInvalidShares;
        private System.Windows.Forms.Label lblAcceptedShares;
        private System.Windows.Forms.Label lblSharesRatio;
        private System.Windows.Forms.Label lblStaleShares;
        private System.Windows.Forms.RadioButton rdo48h;
        private System.Windows.Forms.RadioButton rdo24h;
        private System.Windows.Forms.Label lblAverageHashrate;
        private System.Windows.Forms.Label lblZilToday;
        private System.Windows.Forms.Label lblEthToday;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtCustomHash;
        private System.Windows.Forms.RadioButton rdoUseCustom;
        private System.Windows.Forms.RadioButton rdoUseReported;
        private System.Windows.Forms.RadioButton rdoUseAverage;
        private System.Windows.Forms.Label lblNextZil;
        private System.Windows.Forms.Timer zilTimer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel txtStatus;
        private System.Windows.Forms.ToolStripProgressBar pbStatus;
        private System.Windows.Forms.CheckBox chkConsolidateMEV;
        private System.Windows.Forms.RadioButton rdo24hHistory;
        private System.Windows.Forms.Label lblRealHash;
        private System.Windows.Forms.RadioButton rdoEzil;
        private System.Windows.Forms.RadioButton rdoFlexPool;
    }
}

