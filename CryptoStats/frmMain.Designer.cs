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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWorkerGraph)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(1636, 356);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.RowHeadersWidth = 82;
            this.dataGridView.Size = new System.Drawing.Size(1035, 772);
            this.dataGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1656, 66);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETH in the last 24h:";
            // 
            // txtEth24h
            // 
            this.txtEth24h.Location = new System.Drawing.Point(1870, 60);
            this.txtEth24h.Margin = new System.Windows.Forms.Padding(6);
            this.txtEth24h.Name = "txtEth24h";
            this.txtEth24h.Size = new System.Drawing.Size(330, 31);
            this.txtEth24h.TabIndex = 2;
            // 
            // lblEthUsd
            // 
            this.lblEthUsd.AutoSize = true;
            this.lblEthUsd.Location = new System.Drawing.Point(2216, 66);
            this.lblEthUsd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEthUsd.Name = "lblEthUsd";
            this.lblEthUsd.Size = new System.Drawing.Size(92, 25);
            this.lblEthUsd.TabIndex = 3;
            this.lblEthUsd.Text = "= 0 USD";
            // 
            // lblEntryCount
            // 
            this.lblEntryCount.AutoSize = true;
            this.lblEntryCount.Location = new System.Drawing.Point(1631, 325);
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
            this.picWorkerGraph.Location = new System.Drawing.Point(15, 730);
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
            this.workerTree.Size = new System.Drawing.Size(1120, 513);
            this.workerTree.TabIndex = 6;
            this.workerTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.workerTree_AfterSelect);
            // 
            // cmdRefeshGraph
            // 
            this.cmdRefeshGraph.Location = new System.Drawing.Point(1151, 60);
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
            this.cmdRefreshRewards.Location = new System.Drawing.Point(2521, 298);
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
            this.cmdCombineGraphs.Location = new System.Drawing.Point(1391, 672);
            this.cmdCombineGraphs.Margin = new System.Windows.Forms.Padding(6);
            this.cmdCombineGraphs.Name = "cmdCombineGraphs";
            this.cmdCombineGraphs.Size = new System.Drawing.Size(222, 46);
            this.cmdCombineGraphs.TabIndex = 7;
            this.cmdCombineGraphs.Text = "Combine All Graphs";
            this.cmdCombineGraphs.UseVisualStyleBackColor = true;
            this.cmdCombineGraphs.Click += new System.EventHandler(this.cmdCombineGraphs_Click);
            // 
            // lblHashPower
            // 
            this.lblHashPower.AutoSize = true;
            this.lblHashPower.Location = new System.Drawing.Point(15, 579);
            this.lblHashPower.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHashPower.Name = "lblHashPower";
            this.lblHashPower.Size = new System.Drawing.Size(262, 25);
            this.lblHashPower.TabIndex = 9;
            this.lblHashPower.Text = "Total Hash Power: 0 MH/s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1656, 109);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZIL in the last 24h:";
            // 
            // txtZil24h
            // 
            this.txtZil24h.Location = new System.Drawing.Point(1870, 103);
            this.txtZil24h.Margin = new System.Windows.Forms.Padding(6);
            this.txtZil24h.Name = "txtZil24h";
            this.txtZil24h.Size = new System.Drawing.Size(330, 31);
            this.txtZil24h.TabIndex = 2;
            // 
            // lblZilUsd
            // 
            this.lblZilUsd.AutoSize = true;
            this.lblZilUsd.Location = new System.Drawing.Point(2216, 109);
            this.lblZilUsd.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZilUsd.Name = "lblZilUsd";
            this.lblZilUsd.Size = new System.Drawing.Size(92, 25);
            this.lblZilUsd.TabIndex = 3;
            this.lblZilUsd.Text = "= 0 USD";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(2216, 148);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(92, 25);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "= 0 USD";
            // 
            // lblEthBalance
            // 
            this.lblEthBalance.AutoSize = true;
            this.lblEthBalance.Location = new System.Drawing.Point(1656, 184);
            this.lblEthBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEthBalance.Name = "lblEthBalance";
            this.lblEthBalance.Size = new System.Drawing.Size(152, 25);
            this.lblEthBalance.TabIndex = 10;
            this.lblEthBalance.Text = "Unpaid ETH: 0";
            // 
            // lblZilBalance
            // 
            this.lblZilBalance.AutoSize = true;
            this.lblZilBalance.Location = new System.Drawing.Point(1656, 224);
            this.lblZilBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZilBalance.Name = "lblZilBalance";
            this.lblZilBalance.Size = new System.Drawing.Size(140, 25);
            this.lblZilBalance.TabIndex = 11;
            this.lblZilBalance.Text = "Unpaid ZIL: 0";
            // 
            // lblTotalBalance
            // 
            this.lblTotalBalance.Location = new System.Drawing.Point(1807, 262);
            this.lblTotalBalance.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblTotalBalance.Name = "lblTotalBalance";
            this.lblTotalBalance.Size = new System.Drawing.Size(247, 39);
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
            this.menuStrip1.Size = new System.Drawing.Size(2686, 42);
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
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(85, 38);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(359, 44);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // lblZilValue
            // 
            this.lblZilValue.Location = new System.Drawing.Point(1910, 224);
            this.lblZilValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZilValue.Name = "lblZilValue";
            this.lblZilValue.Size = new System.Drawing.Size(144, 38);
            this.lblZilValue.TabIndex = 12;
            this.lblZilValue.Text = "(0.00 USD)";
            this.lblZilValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEthValue
            // 
            this.lblEthValue.Location = new System.Drawing.Point(1910, 184);
            this.lblEthValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEthValue.Name = "lblEthValue";
            this.lblEthValue.Size = new System.Drawing.Size(144, 40);
            this.lblEthValue.TabIndex = 12;
            this.lblEthValue.Text = "(0.00 USD)";
            this.lblEthValue.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(2686, 1144);
            this.Controls.Add(this.lblEthValue);
            this.Controls.Add(this.lblZilValue);
            this.Controls.Add(this.lblTotalBalance);
            this.Controls.Add(this.lblZilBalance);
            this.Controls.Add(this.lblEthBalance);
            this.Controls.Add(this.lblHashPower);
            this.Controls.Add(this.cmdRefreshRewards);
            this.Controls.Add(this.cmdCombineGraphs);
            this.Controls.Add(this.cmdRefeshGraph);
            this.Controls.Add(this.workerTree);
            this.Controls.Add(this.picWorkerGraph);
            this.Controls.Add(this.lblEntryCount);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblZilUsd);
            this.Controls.Add(this.lblEthUsd);
            this.Controls.Add(this.txtZil24h);
            this.Controls.Add(this.txtEth24h);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}

