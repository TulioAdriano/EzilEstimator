
namespace CryptoStats
{
    partial class frmConfiguration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfiguration));
            this.lstMachines = new System.Windows.Forms.CheckedListBox();
            this.cmdAddMachine = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoGminer = new System.Windows.Forms.RadioButton();
            this.rdoNbiner = new System.Windows.Forms.RadioButton();
            this.rdoTrex = new System.Windows.Forms.RadioButton();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.cmdUpdate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZil = new System.Windows.Forms.TextBox();
            this.txtEth = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.txtApiPwd = new System.Windows.Forms.TextBox();
            this.lblApiPwd = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMachines
            // 
            this.lstMachines.FormattingEnabled = true;
            this.lstMachines.Location = new System.Drawing.Point(144, 16);
            this.lstMachines.Margin = new System.Windows.Forms.Padding(2);
            this.lstMachines.Name = "lstMachines";
            this.lstMachines.Size = new System.Drawing.Size(239, 199);
            this.lstMachines.TabIndex = 6;
            this.lstMachines.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstMachines_ItemCheck);
            this.lstMachines.SelectedIndexChanged += new System.EventHandler(this.lstMachines_SelectedIndexChanged);
            this.lstMachines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMachines_KeyDown);
            // 
            // cmdAddMachine
            // 
            this.cmdAddMachine.Location = new System.Drawing.Point(80, 191);
            this.cmdAddMachine.Margin = new System.Windows.Forms.Padding(2);
            this.cmdAddMachine.Name = "cmdAddMachine";
            this.cmdAddMachine.Size = new System.Drawing.Size(60, 25);
            this.cmdAddMachine.TabIndex = 5;
            this.cmdAddMachine.Text = "Add";
            this.cmdAddMachine.UseVisualStyleBackColor = true;
            this.cmdAddMachine.Click += new System.EventHandler(this.cmdAddMachine_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(129, 356);
            this.cmdOk.Margin = new System.Windows.Forms.Padding(2);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(60, 25);
            this.cmdOk.TabIndex = 7;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(208, 356);
            this.cmdCancel.Margin = new System.Windows.Forms.Padding(2);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(60, 25);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            this.cmdCancel.Click += new System.EventHandler(this.cmdCancel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtApiPwd);
            this.groupBox1.Controls.Add(this.lblApiPwd);
            this.groupBox1.Controls.Add(this.rdoGminer);
            this.groupBox1.Controls.Add(this.rdoNbiner);
            this.groupBox1.Controls.Add(this.rdoTrex);
            this.groupBox1.Controls.Add(this.txtNickname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtHost);
            this.groupBox1.Controls.Add(this.lstMachines);
            this.groupBox1.Controls.Add(this.cmdUpdate);
            this.groupBox1.Controls.Add(this.cmdAddMachine);
            this.groupBox1.Location = new System.Drawing.Point(6, 120);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(387, 232);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Machines";
            // 
            // rdoGminer
            // 
            this.rdoGminer.AutoSize = true;
            this.rdoGminer.Location = new System.Drawing.Point(67, 118);
            this.rdoGminer.Name = "rdoGminer";
            this.rdoGminer.Size = new System.Drawing.Size(59, 17);
            this.rdoGminer.TabIndex = 9;
            this.rdoGminer.Text = "GMiner";
            this.rdoGminer.UseVisualStyleBackColor = true;
            // 
            // rdoNbiner
            // 
            this.rdoNbiner.AutoSize = true;
            this.rdoNbiner.Location = new System.Drawing.Point(67, 95);
            this.rdoNbiner.Name = "rdoNbiner";
            this.rdoNbiner.Size = new System.Drawing.Size(66, 17);
            this.rdoNbiner.TabIndex = 8;
            this.rdoNbiner.Text = "NBMiner";
            this.rdoNbiner.UseVisualStyleBackColor = true;
            // 
            // rdoTrex
            // 
            this.rdoTrex.AutoSize = true;
            this.rdoTrex.Checked = true;
            this.rdoTrex.Location = new System.Drawing.Point(6, 95);
            this.rdoTrex.Name = "rdoTrex";
            this.rdoTrex.Size = new System.Drawing.Size(54, 17);
            this.rdoTrex.TabIndex = 7;
            this.rdoTrex.TabStop = true;
            this.rdoTrex.Text = "T-Rex";
            this.rdoTrex.UseVisualStyleBackColor = true;
            this.rdoTrex.CheckedChanged += new System.EventHandler(this.rdoTrex_CheckedChanged);
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(6, 69);
            this.txtNickname.Margin = new System.Windows.Forms.Padding(2);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(134, 20);
            this.txtNickname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nickname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hostname or IP Address:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(6, 30);
            this.txtHost.Margin = new System.Windows.Forms.Padding(2);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(134, 20);
            this.txtHost.TabIndex = 3;
            // 
            // cmdUpdate
            // 
            this.cmdUpdate.Enabled = false;
            this.cmdUpdate.Location = new System.Drawing.Point(6, 191);
            this.cmdUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.cmdUpdate.Name = "cmdUpdate";
            this.cmdUpdate.Size = new System.Drawing.Size(60, 25);
            this.cmdUpdate.TabIndex = 5;
            this.cmdUpdate.Text = "Update";
            this.cmdUpdate.UseVisualStyleBackColor = true;
            this.cmdUpdate.Click += new System.EventHandler(this.cmdUpdate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtZil);
            this.groupBox2.Controls.Add(this.txtEth);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(387, 64);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wallet Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 39);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZIL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETH:";
            // 
            // txtZil
            // 
            this.txtZil.Location = new System.Drawing.Point(36, 37);
            this.txtZil.Margin = new System.Windows.Forms.Padding(2);
            this.txtZil.Name = "txtZil";
            this.txtZil.Size = new System.Drawing.Size(347, 20);
            this.txtZil.TabIndex = 1;
            this.txtZil.TextChanged += new System.EventHandler(this.txtZil_TextChanged);
            // 
            // txtEth
            // 
            this.txtEth.Location = new System.Drawing.Point(36, 16);
            this.txtEth.Margin = new System.Windows.Forms.Padding(2);
            this.txtEth.Name = "txtEth";
            this.txtEth.Size = new System.Drawing.Size(347, 20);
            this.txtEth.TabIndex = 0;
            this.txtEth.TextChanged += new System.EventHandler(this.txtEth_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtApiKey);
            this.groupBox3.Location = new System.Drawing.Point(6, 74);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(387, 43);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CoinMarketCap API Key (Currently Unused)";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(6, 17);
            this.txtApiKey.Margin = new System.Windows.Forms.Padding(2);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(377, 20);
            this.txtApiKey.TabIndex = 2;
            this.txtApiKey.TextChanged += new System.EventHandler(this.txtApiKey_TextChanged);
            // 
            // txtApiPwd
            // 
            this.txtApiPwd.Location = new System.Drawing.Point(6, 160);
            this.txtApiPwd.Margin = new System.Windows.Forms.Padding(2);
            this.txtApiPwd.Name = "txtApiPwd";
            this.txtApiPwd.Size = new System.Drawing.Size(134, 20);
            this.txtApiPwd.TabIndex = 11;
            // 
            // lblApiPwd
            // 
            this.lblApiPwd.AutoSize = true;
            this.lblApiPwd.Location = new System.Drawing.Point(3, 145);
            this.lblApiPwd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApiPwd.Name = "lblApiPwd";
            this.lblApiPwd.Size = new System.Drawing.Size(111, 13);
            this.lblApiPwd.TabIndex = 10;
            this.lblApiPwd.Text = "API Password (T-Rex)";
            // 
            // frmConfiguration
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(404, 391);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox lstMachines;
        private System.Windows.Forms.Button cmdAddMachine;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.Button cmdCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtZil;
        private System.Windows.Forms.TextBox txtEth;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtApiKey;
        private System.Windows.Forms.TextBox txtNickname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.RadioButton rdoNbiner;
        private System.Windows.Forms.RadioButton rdoTrex;
        private System.Windows.Forms.RadioButton rdoGminer;
        private System.Windows.Forms.Button cmdUpdate;
        private System.Windows.Forms.TextBox txtApiPwd;
        private System.Windows.Forms.Label lblApiPwd;
    }
}