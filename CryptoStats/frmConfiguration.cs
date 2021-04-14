using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoStats
{
    public partial class frmConfiguration : Form
    {
        List<Machine> machines = new List<Machine>();
        string apiKey = string.Empty;
        Wallet ezilWallet = new Wallet();

        public frmConfiguration()
        {
            InitializeComponent();
        }

        private void frmConfiguration_Load(object sender, EventArgs e)
        {
            if (!Properties.Settings.Default.Machines.Equals(string.Empty))
            {
                machines = JsonConvert.DeserializeObject<List<Machine>>(Properties.Settings.Default.Machines);

                foreach (var machine in machines)
                {
                    lstMachines.Items.Add(machine, machine.Enabled);
                }
            }

            apiKey = Properties.Settings.Default.CoinApiKey;
            txtApiKey.Text = apiKey;

            if (!Properties.Settings.Default.EzilWallet.Equals(string.Empty))
            {
                ezilWallet = JsonConvert.DeserializeObject<Wallet>(Properties.Settings.Default.EzilWallet);
                txtEth.Text = ezilWallet.Eth;
                txtZil.Text = ezilWallet.Zil;
            }
        }

        private void txtEth_TextChanged(object sender, EventArgs e)
        {
            ezilWallet.Eth = txtEth.Text;
        }

        private void txtZil_TextChanged(object sender, EventArgs e)
        {
            ezilWallet.Zil = txtZil.Text;
        }

        private void txtApiKey_TextChanged(object sender, EventArgs e)
        {
            apiKey = txtApiKey.Text;
        }

        private void cmdAddMachine_Click(object sender, EventArgs e)
        {
            if (txtHost.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("Host name cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtHost.Text.Trim().IndexOfAny(Path.GetInvalidFileNameChars()) >= 0)
            {
                MessageBox.Show("Invalid host name. Please type the computer name or IP Address only.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            machines.Add(new Machine { Host = txtHost.Text, Nickname = txtNickname.Text, Enabled = true });
            lstMachines.Items.Add(machines.Last(), true);
            txtHost.Text = string.Empty;
            txtNickname.Text = string.Empty;
        }

        private void lstMachines_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            machines[e.Index].Enabled = e.NewValue.Equals(CheckState.Checked);
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            if (txtEth.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("ETH Wallet cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtZil.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("ZIL Wallet cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //if (txtApiKey.Text.Trim().Equals(string.Empty))
            //{
            //    if (MessageBox.Show("Without the API key you won't be able to see prices for ETH and ZIL.",
            //                        "Attention", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning).Equals(DialogResult.Cancel))
            //    {
            //        return;
            //    }
            //}

            Properties.Settings.Default.Machines = JsonConvert.SerializeObject(machines);
            Properties.Settings.Default.CoinApiKey = apiKey;
            Properties.Settings.Default.EzilWallet = JsonConvert.SerializeObject(ezilWallet);

            Properties.Settings.Default.Save();

            this.DialogResult = DialogResult.OK;
        }

        private void lstMachines_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Delete) && lstMachines.SelectedIndex >= 0)
            {
                machines.RemoveAt(lstMachines.SelectedIndex);
                lstMachines.Items.Remove(lstMachines.SelectedItem);
            }
        }
    }
}
