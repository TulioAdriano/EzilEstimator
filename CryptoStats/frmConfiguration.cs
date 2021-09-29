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
            var minerType = (rdoTrex.Checked ? MinerType.TRex : (rdoNbiner.Checked ? MinerType.NBMiner : MinerType.GMiner));
            machines.Add(new Machine { Host = txtHost.Text, Nickname = txtNickname.Text, Enabled = true, Miner_Type = minerType, ApiPassword = txtApiPwd.Text });
            lstMachines.Items.Add(machines.Last(), true);
            txtHost.Text = string.Empty;
            txtNickname.Text = string.Empty;
            txtApiPwd.Text = string.Empty;

            lstMachines.SelectedIndex = -1;
            cmdUpdate.Enabled = false;
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
                cmdUpdate.Enabled = false;
            }
        }

        private void cmdCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void lstMachines_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMachines.SelectedIndex < 0)
            {
                return;
            }

            var machine = (Machine)lstMachines.SelectedItem;

            txtHost.Text = machine.Host;
            txtNickname.Text = machine.Nickname;
            txtApiPwd.Text = machine.ApiPassword;
            switch (machine.Miner_Type)
            {
                case MinerType.TRex:
                    rdoTrex.Checked = true;
                    break;
                case MinerType.NBMiner:
                    rdoNbiner.Checked = true;
                    break;
                case MinerType.GMiner:
                    rdoGminer.Checked = true;
                    break;
            }

            cmdUpdate.Enabled = true; 
        }

        private void cmdUpdate_Click(object sender, EventArgs e)
        {
            ((Machine)lstMachines.SelectedItem).Host = txtHost.Text;
            ((Machine)lstMachines.SelectedItem).Nickname = txtNickname.Text;
            var minerType = (rdoTrex.Checked ? MinerType.TRex : (rdoNbiner.Checked ? MinerType.NBMiner : MinerType.GMiner));
            ((Machine)lstMachines.SelectedItem).Miner_Type = minerType;
            ((Machine)lstMachines.SelectedItem).ApiPassword = txtApiPwd.Text;

            machines[lstMachines.SelectedIndex] = lstMachines.SelectedItem as Machine;
            lstMachines.Refresh();
        }

        private void rdoTrex_CheckedChanged(object sender, EventArgs e)
        {
            txtApiPwd.Enabled = lblApiPwd.Enabled = rdoTrex.Checked;
            if (!rdoTrex.Checked)
            {
                txtApiPwd.Text = string.Empty;
            }
        }
    }
}
