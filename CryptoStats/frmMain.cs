﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoStats
{
    public partial class frmMain : Form
    {
        List<Machine> machines = new List<Machine>();
        string apiKey = string.Empty;
        Wallet ezilWallet = new Wallet();

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.EzilWallet.Equals(string.Empty))
            {
                frmConfiguration configForm = new frmConfiguration();
                if (configForm.ShowDialog().Equals(DialogResult.Cancel))
                {
                    MessageBox.Show("Application cannot start without completing configuration.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
            }

            LoadConfig();

            //Task.Run(() =>
            //{
                var workerStats = GetWorkerStats(machines);
                var workersInfo = GetWorkersInfo(workerStats, true);
                DisplayWorkerGraph(workerStats[workerTree.SelectedNode.Text], workersInfo[0].MinHash, workersInfo[0].MaxHash);

                var rewards24 = GetEzilStats(ezilWallet);
                float eth = rewards24.Where(c => c.coin.Equals("eth")).Sum(s => s.amount);
                float zil = rewards24.Where(c => c.coin.Equals("zil")).Sum(s => s.amount);

                var balances = GetBalances(ezilWallet);

                Display24hEarnings(eth, zil, balances);
                DisplayRewardGridInfo(rewards24);
            //});
        }

        private void LoadConfig()
        {
            machines = JsonConvert.DeserializeObject<List<Machine>>(Properties.Settings.Default.Machines);
            apiKey = Properties.Settings.Default.CoinApiKey;
            ezilWallet = JsonConvert.DeserializeObject<Wallet>(Properties.Settings.Default.EzilWallet);
        }

        private static EzilBalance GetBalances(Wallet ezilWallet)
        {
            EzilAPI ezilAPI = new EzilAPI(ezilWallet.Eth, ezilWallet.Zil);
            string response = ezilAPI.GetBalances();
            var balances = JsonConvert.DeserializeObject<EzilBalance>(response);
            return balances;
        }

        private List<WorkerInfo> GetWorkersInfo(Dictionary<string, TRexSummary> workerStats, bool updateTotalHash = true)
        {
            var workersInfo = new List<WorkerInfo>();
            foreach (var worker in workerStats)
            {
                workersInfo.Add(new WorkerInfo()
                {
                    WorkerName = worker.Key,
                    HashPower = worker.Value.hashrate,
                    MaxHash = worker.Value.velocities.hashrate.Max(c => c[1]),
                    MinHash = worker.Value.velocities.hashrate.Min(c => c[1])
                });
            }

            if (updateTotalHash)
            {
                lblHashPower.Text = $"Total Hash Power: {(workersInfo.Sum(c => c.HashPower) / 1000000d):0.00} MH/s";
            }

            return workersInfo;
        }

        private void DisplayWorkerGraph(TRexSummary workerStat, long minHash, long maxHash, Pen pen = null, int zoom = 2, bool printTimeStamp = true)
        {
            Pen graphPen = pen ?? Pens.Black;
            var font = new Font("Arial", 8);
            if (pen == null)
            {
                picWorkerGraph.Image = new Bitmap(800 * zoom, 200 * zoom);
            }
            using (var gfx = Graphics.FromImage(picWorkerGraph.Image))
            {
                int space = (int)Math.Round((800d * zoom) / workerStat.velocities.hashrate.Count());
                int timeStep = workerStat.velocities.hashrate.Count() / 4;
                List<int> timeSteps = new List<int>() { 0, timeStep, timeStep * 2, timeStep * 3 };
                int x = 0;
                int y = 0;
                long hashDiff = maxHash - minHash;
                int i = 0;
                foreach (var hash in workerStat.velocities.hashrate)
                {
                    int newY = (180 * zoom) - (int)(Math.Round(((double)(hash[1] - minHash) / (double)hashDiff) * (180 * zoom)));
                    gfx.DrawLine(graphPen, x, y, x + space, newY);
                    if (printTimeStamp && timeSteps.Contains(i++))
                    {
                        var timeStamp = DateTimeOffset.FromUnixTimeSeconds(hash[0]).DateTime.ToLocalTime();
                        gfx.DrawString($"{timeStamp.ToShortDateString()} {timeStamp.ToShortTimeString()}", font, Brushes.Red, x, 180 * zoom);
                    }
                    x += space;
                    y = newY;
                }
                if (printTimeStamp)
                {
                    var lastTimeStamp = DateTimeOffset.FromUnixTimeSeconds(workerStat.velocities.hashrate.Last()[0]).DateTime.ToLocalTime();
                    gfx.DrawString($"{lastTimeStamp.ToShortDateString()} {lastTimeStamp.ToShortTimeString()}", font, Brushes.Red, x, (180 * zoom));
                }

                gfx.DrawString($"{(maxHash / 1000000d):0.0}", font, Brushes.Black, 720 * zoom, 0);
                gfx.DrawString($"{(minHash / 1000000d):0.0}", font, Brushes.Black, 720 * zoom, 165 * zoom);
            }
            picWorkerGraph.Refresh();
        }

        private void DisplayRewardGridInfo(List<EzilReward> rewards24)
        {
            dataGridView.DataSource = rewards24;
            dataGridView.Columns[0].DefaultCellStyle.Format =
            dataGridView.Columns[3].DefaultCellStyle.Format = "0.#################################";
            //dataGridView.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            //dataGridView.Columns[3].AutoSizeMode = true;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            lblEntryCount.Text = $"{rewards24.Count} entries";
        }

        private void Display24hEarnings(float eth, float zil, EzilBalance balances)
        {
            CoinListings coinListings = GetCryptoPrices(apiKey);
            float ethPrice = coinListings.data.Where(d => d.symbol.Equals("ETH")).FirstOrDefault().quote.USD.price;
            float zilPrice = coinListings.data.Where(d => d.symbol.Equals("ZIL")).FirstOrDefault().quote.USD.price;
            txtEth24h.Text = eth.ToString();
            txtZil24h.Text = zil.ToString();
            float ethValue = ethPrice * eth;
            float zilValue = zilPrice * zil;
            lblEthUsd.Text = $"= ${ethValue:0.00} @ ${ethPrice:0.00}";
            lblZilUsd.Text = $"= ${zilValue:0.00} @ ${zilPrice:0.00}";
            lblTotal.Text = $"= ${(ethValue + zilValue):0.00}/d, {((ethValue + zilValue) * 7):0.00}/w, {((ethValue + zilValue) * 30):0.00}/m, {((ethValue + zilValue) * 365):0.00}/y";

            float ethBalanceValue = balances.eth * ethPrice;
            float zilBalanceValue = balances.zil * zilPrice;
            lblEthBalance.Text = $"Unpaid ETH: {balances.eth}"; 
            lblEthValue.Text = $"({ethBalanceValue:0.00} USD)";
            lblZilBalance.Text = $"Unpaid ZIL: {balances.zil}"; 
            lblZilValue.Text = $"({zilBalanceValue:0.00} USD)";
            lblTotalBalance.Text = $"= ({(ethBalanceValue + zilBalanceValue):0.00} USD)";
        }

        private static CoinListings GetCryptoPrices(string apiKey)
        {
            CoinMarketCapAPI coinMarketCapAPI = new CoinMarketCapAPI(apiKey);
            string coinresponse = coinMarketCapAPI.GetListings();
            var coinListings = JsonConvert.DeserializeObject<CoinListings>(coinresponse);
            return coinListings;
        }

        private static List<EzilReward> GetEzilStats(Wallet ezilWallet)
        {
            EzilAPI ezilAPI = new EzilAPI(ezilWallet.Eth, ezilWallet.Zil);
            List<EzilReward> ezilRewards = new List<EzilReward>();
            int page = 1;
            do
            {
                string response = ezilAPI.GetRewards(page++, 999, "eth");
                var rewards = JsonConvert.DeserializeObject<List<EzilReward>>(response);
                ezilRewards.AddRange(rewards/*.Where(r => r.coin.Equals("eth"))*/);
            } while (ezilRewards.Min(c => c.created_at) >= DateTime.UtcNow.AddDays(-1));

            var rewards24 = ezilRewards.Where(r => r.created_at >= DateTime.UtcNow.AddDays(-1)).ToList();

            page = 1;
            ezilRewards.Clear();
            do
            {
                string response = ezilAPI.GetRewards(page++, 999, "zil");
                var rewards = JsonConvert.DeserializeObject<List<EzilReward>>(response);
                ezilRewards.AddRange(rewards/*.Where(r => r.coin.Equals("eth"))*/);
            } while (ezilRewards.Min(c => c.created_at) >= DateTime.UtcNow.AddDays(-1));
            rewards24.AddRange(ezilRewards.Where(r => r.created_at >= DateTime.UtcNow.AddDays(-1)).ToList());

            return rewards24;
        }

        private Dictionary<string, TRexSummary> GetWorkerStats(List<Machine> machines, bool reloadTree = true)
        {
            Dictionary<string, TRexSummary> workerStats = new Dictionary<string, TRexSummary>();

            foreach (var machine in machines)
            {
                workerStats.Add($"{machine}", TRexAPI.GetFullSummary(machine.Host));
            }

            if (reloadTree)
            {
                workerTree.Nodes.Clear();
                foreach (var workerStat in workerStats)
                {
                    var workerNode = workerTree.Nodes.Add(workerStat.Key);
                    if (workerTree.SelectedNode == null)
                    {
                        workerTree.SelectedNode = workerNode;
                    }

                    foreach (var gpu in workerStat.Value.gpus)
                    {
                        workerNode.Nodes.Add($"{gpu.vendor} {gpu.name}: Hash={(gpu.hashrate / 1000000d):0.00}MH/s Temp={gpu.temperature}°C Power={gpu.power}W Efficiency={gpu.efficiency}");
                    }
                    workerNode.Expand();
                }
            }

            return workerStats;
        }

        private void workerTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent != null)
            {
                workerTree.SelectedNode = e.Node.Parent;
            }
            var workersStats = GetWorkerStats(machines, false);
            var workerInfo = GetWorkersInfo(workersStats, false).Where(c => c.WorkerName.Equals(workerTree.SelectedNode.Text)).FirstOrDefault();

            DisplayWorkerGraph(workersStats[workerTree.SelectedNode.Text], workerInfo.MinHash, workerInfo.MaxHash);
        }
        private void cmdRefeshGraph_Click(object sender, EventArgs e)
        {
            RefreshTree();
        }

        private void RefreshTree()
        {
            var selectedNodeKey = workerTree.SelectedNode.Text;
            var workersStats = GetWorkerStats(machines, true);
            var workerInfo = GetWorkersInfo(workersStats).Where(c => c.WorkerName.Equals(selectedNodeKey)).FirstOrDefault();

            DisplayWorkerGraph(workersStats[selectedNodeKey], workerInfo.MinHash, workerInfo.MaxHash);
        }

        private void cmdRefreshRewards_Click(object sender, EventArgs e)
        {
            var rewards24 = GetEzilStats(ezilWallet);
            float eth = rewards24.Where(c => c.coin.Equals("eth")).Sum(s => s.amount);
            float zil = rewards24.Where(c => c.coin.Equals("zil")).Sum(s => s.amount);

            var balances = GetBalances(ezilWallet);

            Display24hEarnings(eth, zil, balances);
            DisplayRewardGridInfo(rewards24);
        }

        private void cmdCombineGraphs_Click(object sender, EventArgs e)
        {
            var pens = new List<Pen>() { Pens.Blue, Pens.Red, Pens.DarkGreen, Pens.Orange };
            var workerStats = GetWorkerStats(machines, true);
            var workersInfo = GetWorkersInfo(workerStats);

            long minHash = workersInfo.Min(c => c.MinHash);
            long maxHash = workersInfo.Max(c => c.MaxHash);
            int i = 0;

            picWorkerGraph.Image = new Bitmap(800 * 2, 200 * 2);
            bool printTimeStamp = true;
            foreach (var workerStat in workerStats)
            {
                DisplayWorkerGraph(workerStat.Value, minHash, maxHash, pens[i++], 2, printTimeStamp);
                printTimeStamp = false;
            }
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguration configForm = new frmConfiguration();
            if (configForm.ShowDialog().Equals(DialogResult.OK))
            {
                LoadConfig();
                RefreshTree();
            }
        }
    }

    public static class Extensions
    {
        public static long ToUnixTimeSeconds(this DateTime date)
        {
            return ((DateTimeOffset)date).ToUnixTimeSeconds();
        }
    }

    public class WorkerInfo
    {
        public string WorkerName
        {
            get; set;
        }

        public long HashPower
        {
            get; set;
        }

        public long MaxHash
        {
            get; set;
        }

        public long MinHash
        {
            get; set;
        }
    }


    public class Machine
    {
        public string Host
        {
            get; set;
        }
        public string Nickname
        {
            get; set;
        }
        public bool Enabled
        {
            get; set;
        }
        public override string ToString()
        {
            return $"{Host} ({Nickname})";
        }
    }

    public class Wallet
    {
        public string Eth
        {
            get; set;
        }
        public string Zil
        {
            get; set;
        }
        public override string ToString()
        {
            return $"{Eth}.{Zil}";
        }
    }
}
