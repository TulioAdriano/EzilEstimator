
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
            this.lstMachines = new System.Windows.Forms.CheckedListBox();
            this.cmdAddMachine = new System.Windows.Forms.Button();
            this.cmdOk = new System.Windows.Forms.Button();
            this.cmdCancel = new System.Windows.Forms.Button();
            this.Machines = new System.Windows.Forms.GroupBox();
            this.txtNickname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtZil = new System.Windows.Forms.TextBox();
            this.txtEth = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtApiKey = new System.Windows.Forms.TextBox();
            this.Machines.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMachines
            // 
            this.lstMachines.FormattingEnabled = true;
            this.lstMachines.Location = new System.Drawing.Point(280, 30);
            this.lstMachines.Name = "lstMachines";
            this.lstMachines.Size = new System.Drawing.Size(388, 284);
            this.lstMachines.TabIndex = 6;
            this.lstMachines.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.lstMachines_ItemCheck);
            this.lstMachines.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstMachines_KeyDown);
            // 
            // cmdAddMachine
            // 
            this.cmdAddMachine.Location = new System.Drawing.Point(84, 218);
            this.cmdAddMachine.Name = "cmdAddMachine";
            this.cmdAddMachine.Size = new System.Drawing.Size(121, 49);
            this.cmdAddMachine.TabIndex = 5;
            this.cmdAddMachine.Text = "Add";
            this.cmdAddMachine.UseVisualStyleBackColor = true;
            this.cmdAddMachine.Click += new System.EventHandler(this.cmdAddMachine_Click);
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(207, 569);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(121, 49);
            this.cmdOk.TabIndex = 7;
            this.cmdOk.Text = "OK";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // cmdCancel
            // 
            this.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cmdCancel.Location = new System.Drawing.Point(366, 569);
            this.cmdCancel.Name = "cmdCancel";
            this.cmdCancel.Size = new System.Drawing.Size(121, 49);
            this.cmdCancel.TabIndex = 8;
            this.cmdCancel.Text = "Cancel";
            this.cmdCancel.UseVisualStyleBackColor = true;
            // 
            // Machines
            // 
            this.Machines.Controls.Add(this.txtNickname);
            this.Machines.Controls.Add(this.label4);
            this.Machines.Controls.Add(this.label3);
            this.Machines.Controls.Add(this.txtHost);
            this.Machines.Controls.Add(this.lstMachines);
            this.Machines.Controls.Add(this.cmdAddMachine);
            this.Machines.Location = new System.Drawing.Point(12, 230);
            this.Machines.Name = "Machines";
            this.Machines.Size = new System.Drawing.Size(674, 321);
            this.Machines.TabIndex = 3;
            this.Machines.TabStop = false;
            this.Machines.Text = "groupBox1";
            // 
            // txtNickname
            // 
            this.txtNickname.Location = new System.Drawing.Point(11, 132);
            this.txtNickname.Name = "txtNickname";
            this.txtNickname.Size = new System.Drawing.Size(263, 31);
            this.txtNickname.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Nickname:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(250, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Hostname or IP Address:";
            // 
            // txtHost
            // 
            this.txtHost.Location = new System.Drawing.Point(11, 58);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(263, 31);
            this.txtHost.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtZil);
            this.groupBox2.Controls.Add(this.txtEth);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(674, 124);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wallet Details";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "ZIL:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "ETH:";
            // 
            // txtZil
            // 
            this.txtZil.Location = new System.Drawing.Point(72, 72);
            this.txtZil.Name = "txtZil";
            this.txtZil.Size = new System.Drawing.Size(596, 31);
            this.txtZil.TabIndex = 1;
            this.txtZil.TextChanged += new System.EventHandler(this.txtZil_TextChanged);
            // 
            // txtEth
            // 
            this.txtEth.Location = new System.Drawing.Point(72, 31);
            this.txtEth.Name = "txtEth";
            this.txtEth.Size = new System.Drawing.Size(596, 31);
            this.txtEth.TabIndex = 0;
            this.txtEth.TextChanged += new System.EventHandler(this.txtEth_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtApiKey);
            this.groupBox3.Location = new System.Drawing.Point(12, 142);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(674, 82);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CoinMarketCap API Key";
            // 
            // txtApiKey
            // 
            this.txtApiKey.Location = new System.Drawing.Point(11, 33);
            this.txtApiKey.Name = "txtApiKey";
            this.txtApiKey.Size = new System.Drawing.Size(657, 31);
            this.txtApiKey.TabIndex = 2;
            this.txtApiKey.TextChanged += new System.EventHandler(this.txtApiKey_TextChanged);
            // 
            // frmConfiguration
            // 
            this.AcceptButton = this.cmdOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cmdCancel;
            this.ClientSize = new System.Drawing.Size(697, 636);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Machines);
            this.Controls.Add(this.cmdCancel);
            this.Controls.Add(this.cmdOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmConfiguration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.Load += new System.EventHandler(this.frmConfiguration_Load);
            this.Machines.ResumeLayout(false);
            this.Machines.PerformLayout();
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
        private System.Windows.Forms.GroupBox Machines;
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
    }
}