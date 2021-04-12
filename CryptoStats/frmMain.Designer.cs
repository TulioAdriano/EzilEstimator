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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblEthProfit = new System.Windows.Forms.Label();
            this.lblEzilDiff = new System.Windows.Forms.Label();
            this.lblNetHash = new System.Windows.Forms.Label();
            this.lblBlockReward = new System.Windows.Forms.Label();
            this.lblEthCurProfit = new System.Windows.Forms.Label();
            this.lblZilProfit = new System.Windows.Forms.Label();
            this.lblZilCurProfit = new System.Windows.Forms.Label();
            this.lblZilBlockReward = new System.Windows.Forms.Label();
            this.lblZilNetHash = new System.Windows.Forms.Label();
            this.lblZilEzilDiff = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkerGraph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtGranularity)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1636, 392);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.Size = new System.Drawing.Size(1035, 773);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETH in the last 24h:";
            // 
            // txtEth24h
            // 
            this.txtEth24h.Location = new System.Drawing.Point(223, 26);
            this.txtEth24h.Margin = new System.Windows.Forms.Padding(6);
            this.txtEth24h.Name = "txtEth24h";
            this.txtEth24h.Size = new System.Drawing.Size(330, 31);
            this.txtEth24h.TabIndex = 2;
            // 
            // lblEthUsd
            // 
            this.lblEthUsd.AutoSize = true;
            this.lblEthUsd.Location = new System.Drawing.Point(569, 32);
            this.lblEthUsd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEthUsd.Name = "lblEthUsd";
            this.lblEthUsd.Size = new System.Drawing.Size(92, 25);
            this.lblEthUsd.TabIndex = 3;
            this.lblEthUsd.Text = "= 0 USD";
            // 
            // lblEntryCount
            // 
            this.lblEntryCount.AutoSize = true;
            this.lblEntryCount.Location = new System.Drawing.Point(1631, 361);
            this.lblEntryCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEntryCount.Name = "lblEntryCount";
            this.lblEntryCount.Size = new System.Drawing.Size(95, 25);
            this.lblEntryCount.TabIndex = 4;
            this.lblEntryCount.Text = "0 entries";
            // 
            // picWorkerGraph
            // 
            this.picWorkerGraph.BackColor = System.Drawing.Color.White;
            this.picWorkerGraph.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picWorkerGraph.Location = new System.Drawing.Point(15, 767);
            this.picWorkerGraph.Margin = new System.Windows.Forms.Padding(6);
            this.picWorkerGraph.Name = "picWorkerGraph";
            this.picWorkerGraph.Size = new System.Drawing.Size(1598, 398);
            this.picWorkerGraph.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picWorkerGraph.TabIndex = 5;
            this.picWorkerGraph.TabStop = false;
            // 
            // workerTree
            // 
            this.workerTree.Location = new System.Drawing.Point(15, 60);
            this.workerTree.Margin = new System.Windows.Forms.Padding(6);
            this.workerTree.Name = "workerTree";
            this.workerTree.Size = new System.Drawing.Size(1047, 544);
            this.workerTree.TabIndex = 6;
            this.workerTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.workerTree_AfterSelect);
            // 
            // cmdRefeshGraph
            // 
            this.cmdRefeshGraph.Location = new System.Drawing.Point(912, 616);
            this.cmdRefeshGraph.Margin = new System.Windows.Forms.Padding(6);
            this.cmdRefeshGraph.Name = "cmdRefeshGraph";
            this.cmdRefeshGraph.Size = new System.Drawing.Size(150, 46);
            this.cmdRefeshGraph.TabIndex = 7;
            this.cmdRefeshGraph.Text = "Refresh";
            this.cmdRefeshGraph.UseVisualStyleBackColor = true;
            this.cmdRefeshGraph.Click += new System.EventHandler(this.cmdRefeshGraph_Click);
            // 
            // cmdRefreshRewards
            // 
            this.cmdRefreshRewards.Location = new System.Drawing.Point(2521, 334);
            this.cmdRefreshRewards.Margin = new System.Windows.Forms.Padding(6);
            this.cmdRefreshRewards.Name = "cmdRefreshRewards";
            this.cmdRefreshRewards.Size = new System.Drawing.Size(150, 46);
            this.cmdRefreshRewards.TabIndex = 8;
            this.cmdRefreshRewards.Text = "Refresh";
            this.cmdRefreshRewards.UseVisualStyleBackColor = true;
            this.cmdRefreshRewards.Click += new System.EventHandler(this.cmdRefreshRewards_Click);
            // 
            // cmdCombineGraphs
            // 
            this.cmdCombineGraphs.Location = new System.Drawing.Point(1157, 709);
            this.cmdCombineGraphs.Margin = new System.Windows.Forms.Padding(6);
            this.cmdCombineGraphs.Name = "cmdCombineGraphs";
            this.cmdCombineGraphs.Size = new System.Drawing.Size(222, 46);
            this.cmdCombineGraphs.TabIndex = 7;
            this.cmdCombineGraphs.Text = "Overlay Graphs";
            this.cmdCombineGraphs.UseVisualStyleBackColor = true;
            this.cmdCombineGraphs.Click += new System.EventHandler(this.cmdCombineGraphs_Click);
            // 
            // lblHashPower
            // 
            this.lblHashPower.AutoSize = true;
            this.lblHashPower.Location = new System.Drawing.Point(15, 616);
            this.lblHashPower.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHashPower.Name = "lblHashPower";
            this.lblHashPower.Size = new System.Drawing.Size(247, 25);
            this.lblHashPower.TabIndex = 9;
            this.lblHashPower.Text = "Total Hash Rate: 0 MH/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZIL in the last 24h:";
            // 
            // txtZil24h
            // 
            this.txtZil24h.Location = new System.Drawing.Point(223, 69);
            this.txtZil24h.Margin = new System.Windows.Forms.Padding(6);
            this.txtZil24h.Name = "txtZil24h";
            this.txtZil24h.Size = new System.Drawing.Size(330, 31);
            this.txtZil24h.TabIndex = 2;
            // 
            // lblZilUsd
            // 
            this.lblZilUsd.AutoSize = true;
            this.lblZilUsd.Location = new System.Drawing.Point(569, 75);
            this.lblZilUsd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZilUsd.Name = "lblZilUsd";
            this.lblZilUsd.Size = new System.Drawing.Size(92, 25);
            this.lblZilUsd.TabIndex = 3;
            this.lblZilUsd.Text = "= 0 USD";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(569, 114);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 25);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "= 0 USD";
            // 
            // lblEthBalance
            // 
            this.lblEthBalance.AutoSize = true;
            this.lblEthBalance.Location = new System.Drawing.Point(9, 150);
            this.lblEthBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEthBalance.Name = "lblEthBalance";
            this.lblEthBalance.Size = new System.Drawing.Size(152, 25);
            this.lblEthBalance.TabIndex = 10;
            this.lblEthBalance.Text = "Unpaid ETH: 0";
            // 
            // lblZilBalance
            // 
            this.lblZilBalance.AutoSize = true;
            this.lblZilBalance.Location = new System.Drawing.Point(9, 190);
            this.lblZilBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZilBalance.Name = "lblZilBalance";
            this.lblZilBalance.Size = new System.Drawing.Size(140, 25);
            this.lblZilBalance.TabIndex = 11;
            this.lblZilBalance.Text = "Unpaid ZIL: 0";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.Location = new System.Drawing.Point(160, 228);
            this.lblTotalBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(247, 28);
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
            this.menuStrip1.Size = new System.Drawing.Size(2686, 40);
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
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(72, 36);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(235, 44);
            this.settingsToolStripMenuItem.Text = "&Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(232, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(235, 44);
            this.exitToolStripMenuItem.Text = "E&xit";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 36);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(214, 44);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblZilValue
            // 
            this.lblZilValue.Location = new System.Drawing.Point(263, 190);
            this.lblZilValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZilValue.Name = "lblZilValue";
            this.lblZilValue.Size = new System.Drawing.Size(144, 38);
            this.lblZilValue.TabIndex = 12;
            this.lblZilValue.Text = "(0.00 USD)";
            this.lblZilValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEthValue
            // 
            this.lblEthValue.Location = new System.Drawing.Point(263, 150);
            this.lblEthValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEthValue.Name = "lblEthValue";
            this.lblEthValue.Size = new System.Drawing.Size(144, 40);
            this.lblEthValue.TabIndex = 12;
            this.lblEthValue.Text = "(0.00 USD)";
            this.lblEthValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // cmdMergeGraphs
            // 
            this.cmdMergeGraphs.Location = new System.Drawing.Point(1391, 709);
            this.cmdMergeGraphs.Margin = new System.Windows.Forms.Padding(6);
            this.cmdMergeGraphs.Name = "cmdMergeGraphs";
            this.cmdMergeGraphs.Size = new System.Drawing.Size(222, 46);
            this.cmdMergeGraphs.TabIndex = 7;
            this.cmdMergeGraphs.Text = "Merge Graphs";
            this.cmdMergeGraphs.UseVisualStyleBackColor = true;
            this.cmdMergeGraphs.Click += new System.EventHandler(this.cmdMergeGraphs_Click);
            // 
            // txtGranularity
            // 
            this.txtGranularity.Location = new System.Drawing.Point(1499, 669);
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
            this.txtGranularity.Size = new System.Drawing.Size(114, 31);
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
            this.label3.Location = new System.Drawing.Point(1391, 674);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "Seconds:";
            // 
            // lblPowerUsage
            // 
            this.lblPowerUsage.AutoSize = true;
            this.lblPowerUsage.Location = new System.Drawing.Point(383, 616);
            this.lblPowerUsage.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPowerUsage.Name = "lblPowerUsage";
            this.lblPowerUsage.Size = new System.Drawing.Size(208, 25);
            this.lblPowerUsage.TabIndex = 9;
            this.lblPowerUsage.Text = "Total Power: 0 KW/h";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(1636, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1038, 265);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Live Stats";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblEzilDiff);
            this.groupBox2.Controls.Add(this.lblNetHash);
            this.groupBox2.Controls.Add(this.lblBlockReward);
            this.groupBox2.Controls.Add(this.lblEthCurProfit);
            this.groupBox2.Controls.Add(this.lblEthProfit);
            this.groupBox2.Location = new System.Drawing.Point(1071, 60);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 265);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Minerstats Data (Ethereum)";
            // 
            // lblEthProfit
            // 
            this.lblEthProfit.AutoSize = true;
            this.lblEthProfit.Location = new System.Drawing.Point(6, 190);
            this.lblEthProfit.Name = "lblEthProfit";
            this.lblEthProfit.Size = new System.Drawing.Size(446, 25);
            this.lblEthProfit.TabIndex = 0;
            this.lblEthProfit.Text = "24h Profitability: 0.0000000 ETH (00.00 USD)";
            // 
            // lblEzilDiff
            // 
            this.lblEzilDiff.AutoSize = true;
            this.lblEzilDiff.Location = new System.Drawing.Point(6, 230);
            this.lblEzilDiff.Name = "lblEzilDiff";
            this.lblEzilDiff.Size = new System.Drawing.Size(461, 25);
            this.lblEzilDiff.TabIndex = 1;
            this.lblEzilDiff.Text = "Difference to Ezil: 0.0000000 ETH (00.00 USD)";
            // 
            // lblNetHash
            // 
            this.lblNetHash.AutoSize = true;
            this.lblNetHash.Location = new System.Drawing.Point(6, 32);
            this.lblNetHash.Name = "lblNetHash";
            this.lblNetHash.Size = new System.Drawing.Size(312, 25);
            this.lblNetHash.TabIndex = 0;
            this.lblNetHash.Text = "Network Hashrate: 000.00 TH/s";
            // 
            // lblBlockReward
            // 
            this.lblBlockReward.AutoSize = true;
            this.lblBlockReward.Location = new System.Drawing.Point(6, 75);
            this.lblBlockReward.Name = "lblBlockReward";
            this.lblBlockReward.Size = new System.Drawing.Size(306, 25);
            this.lblBlockReward.TabIndex = 0;
            this.lblBlockReward.Text = "Block Reward: 0.0000000 ETH";
            // 
            // lblEthCurProfit
            // 
            this.lblEthCurProfit.AutoSize = true;
            this.lblEthCurProfit.Location = new System.Drawing.Point(6, 150);
            this.lblEthCurProfit.Name = "lblEthCurProfit";
            this.lblEthCurProfit.Size = new System.Drawing.Size(481, 25);
            this.lblEthCurProfit.TabIndex = 0;
            this.lblEthCurProfit.Text = "Current Profitability: 0.0000000 ETH (00.00 USD)";
            // 
            // lblZilProfit
            // 
            this.lblZilProfit.AutoSize = true;
            this.lblZilProfit.Location = new System.Drawing.Point(6, 190);
            this.lblZilProfit.Name = "lblZilProfit";
            this.lblZilProfit.Size = new System.Drawing.Size(446, 25);
            this.lblZilProfit.TabIndex = 0;
            this.lblZilProfit.Text = "24h Profitability: 0.0000000 ETH (00.00 USD)";
            // 
            // lblZilCurProfit
            // 
            this.lblZilCurProfit.AutoSize = true;
            this.lblZilCurProfit.Location = new System.Drawing.Point(6, 150);
            this.lblZilCurProfit.Name = "lblZilCurProfit";
            this.lblZilCurProfit.Size = new System.Drawing.Size(481, 25);
            this.lblZilCurProfit.TabIndex = 0;
            this.lblZilCurProfit.Text = "Current Profitability: 0.0000000 ETH (00.00 USD)";
            // 
            // lblZilBlockReward
            // 
            this.lblZilBlockReward.AutoSize = true;
            this.lblZilBlockReward.Location = new System.Drawing.Point(6, 75);
            this.lblZilBlockReward.Name = "lblZilBlockReward";
            this.lblZilBlockReward.Size = new System.Drawing.Size(306, 25);
            this.lblZilBlockReward.TabIndex = 0;
            this.lblZilBlockReward.Text = "Block Reward: 0.0000000 ETH";
            // 
            // lblZilNetHash
            // 
            this.lblZilNetHash.AutoSize = true;
            this.lblZilNetHash.Location = new System.Drawing.Point(6, 32);
            this.lblZilNetHash.Name = "lblZilNetHash";
            this.lblZilNetHash.Size = new System.Drawing.Size(312, 25);
            this.lblZilNetHash.TabIndex = 0;
            this.lblZilNetHash.Text = "Network Hashrate: 000.00 TH/s";
            // 
            // lblZilEzilDiff
            // 
            this.lblZilEzilDiff.AutoSize = true;
            this.lblZilEzilDiff.Location = new System.Drawing.Point(6, 230);
            this.lblZilEzilDiff.Name = "lblZilEzilDiff";
            this.lblZilEzilDiff.Size = new System.Drawing.Size(461, 25);
            this.lblZilEzilDiff.TabIndex = 1;
            this.lblZilEzilDiff.Text = "Difference to Ezil: 0.0000000 ETH (00.00 USD)";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblZilEzilDiff);
            this.groupBox3.Controls.Add(this.lblZilNetHash);
            this.groupBox3.Controls.Add(this.lblZilBlockReward);
            this.groupBox3.Controls.Add(this.lblZilCurProfit);
            this.groupBox3.Controls.Add(this.lblZilProfit);
            this.groupBox3.Location = new System.Drawing.Point(1071, 339);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(542, 265);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Minerstats Data (Zilliqa)";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2686, 1180);
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
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmMain";
            this.Text = "Jamirocoin Ezil Estimator";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
        private System.Windows.Forms.Label lblZilProfit;
        private System.Windows.Forms.Label lblZilCurProfit;
        private System.Windows.Forms.Label lblZilBlockReward;
        private System.Windows.Forms.Label lblZilNetHash;
        private System.Windows.Forms.Label lblZilEzilDiff;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

