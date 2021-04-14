using Newtonsoft.Json;
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
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            LoadConfig();

            var workerStats = GetWorkerStats(machines);
            var workersInfo = GetWorkersInfo(workerStats, true);
            if (workersInfo != null && workersInfo.Count > 0)
            {
                DisplayWorkerGraph(workerStats[workerTree.SelectedNode.Text], workersInfo[0].MinHash, workersInfo[0].MaxHash);
            }

            GetStatsAndBalance();
            this.Cursor = Cursors.Default;
        }

        private void GetStatsAndBalance()
        {
            try
            {
                var rewards24 = GetEzilStats(ezilWallet);
                float eth = rewards24.Where(c => c.coin.Equals("eth")).Sum(s => s.amount);
                float zil = rewards24.Where(c => c.coin.Equals("zil")).Sum(s => s.amount);
                txtEth24h.Text = eth.ToString();
                txtZil24h.Text = zil.ToString();

                var balances = GetBalances(ezilWallet);
                lblEthBalance.Text = $"Unpaid ETH: {balances.eth}";
                lblZilBalance.Text = $"Unpaid ZIL: {balances.zil}";

                int timeFrame = rdo24h.Checked ? 24 : 48;
                var history = GetHistory(ezilWallet, timeFrame);
                var acceptedShares = history.Sum(c => c.accepted_shares_count);
                var staleShares = history.Sum(c => c.stale_shares_count);
                var invalidShares = history.Sum(c => c.invalid_shares_count);
                var staleRatio = (staleShares / ((double)(acceptedShares + staleShares + invalidShares)));
                lblAcceptedShares.Text = $"Total Accepted Shares: {acceptedShares}";
                lblStaleShares.Text = $"Total Stale Shares: {staleShares}";
                lblInvalidShares.Text = $"Total Invalid Shares: {invalidShares}";
                lblSharesRatio.Text = $"Stale Shares Ratio: {staleRatio:P2}";

                DisplayRewardGridInfo(rewards24);

                Display24hEarnings(eth, zil, balances);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private List<EzilStats> GetHistory(Wallet ezilWallet, int timeFrame)
        {
            try
            {
                EzilAPI ezilAPI = new EzilAPI(ezilWallet.Eth, ezilWallet.Zil);
                string response = ezilAPI.GetHistoricalStats(timeFrame);
                var ezilStats = JsonConvert.DeserializeObject<List<EzilStats>>(response);
                return ezilStats;
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    throw new Exception($"Cannot retrieve Ezil history. Make sure that your wallet addresses are correct.{Environment.NewLine}{ex.InnerException.Message}");
                }
                throw new Exception($"Cannot retrieve Ezil history. Make sure that your wallet addresses are correct.{Environment.NewLine}{ex.Message}");
            }
        }

        private void LoadConfig()
        {
            machines = JsonConvert.DeserializeObject<List<Machine>>(Properties.Settings.Default.Machines);
            apiKey = Properties.Settings.Default.CoinApiKey;
            ezilWallet = JsonConvert.DeserializeObject<Wallet>(Properties.Settings.Default.EzilWallet);      
        }

        private static EzilBalance GetBalances(Wallet ezilWallet)
        {
            try
            {
                EzilAPI ezilAPI = new EzilAPI(ezilWallet.Eth, ezilWallet.Zil);
                string response = ezilAPI.GetBalances();
                var balances = JsonConvert.DeserializeObject<EzilBalance>(response);
                return balances;
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    throw new Exception($"Cannot retrieve Ezil Wallet balance. Make sure that your wallet addresses are correct.{Environment.NewLine}{ex.InnerException.Message}");
                }
                throw new Exception($"Cannot retrieve Ezil Wallet balance. Make sure that your wallet addresses are correct.{Environment.NewLine}{ex.Message}");
            }
        }

        private List<WorkerInfo> GetWorkersInfo(Dictionary<string, TRexSummary> workerStats, bool updateTotalHash = true)
        {
            var workersInfo = new List<WorkerInfo>();
            foreach (var worker in workerStats)
            {
                if (worker.Key.ToLower().Contains("offline"))
                {
                    continue;
                }
                workersInfo.Add(new WorkerInfo()
                {
                    WorkerName = worker.Key,
                    HashPower = worker.Value.hashrate,
                    MaxHash = (worker.Value.velocities == null ? 0 : worker.Value.velocities.hashrate.Max(c => c[1])),
                    MinHash = (worker.Value.velocities == null ? 0 : worker.Value.velocities.hashrate.Min(c => c[1])),
                    PowerUsage = (long)Math.Round( worker.Value.velocities.power.Average(c=>c[1]))
                });
            }

            if (updateTotalHash)
            {
                double hashPower = (workersInfo.Sum(c => c.HashPower) / 1000000d);
                lblHashPower.Text = $"Total Hash Rate: {hashPower:0.00} MH/s";
                lblPowerUsage.Text= $"Total Power Usage: {(workersInfo.Sum(c => c.PowerUsage) / 1000d):0.00} KW/h";
            }

            return workersInfo;
        }

        private void DisplayWorkerGraph(TRexSummary workerStat, long minHash, long maxHash, Pen pen = null, int zoom = 2, bool printTimeStamp = true)
        {
            DisplayWorkerGraph(workerStat.velocities.hashrate, minHash, maxHash, pen, zoom, printTimeStamp);
        }

        private void DisplayWorkerGraph(List<long[]> hashrate, long minHash, long maxHash, Pen pen = null, int zoom = 2, bool printTimeStamp = true)
        {
            Pen graphPen = pen ?? Pens.Black;
            var font = new Font("Arial", 8);
            if (pen == null)
            {
                picWorkerGraph.Image = new Bitmap(800 * zoom, 200 * zoom);
            }
            using (var gfx = Graphics.FromImage(picWorkerGraph.Image))
            {
                int space = (int)Math.Round((800d * zoom) / hashrate.Count());
                int timeStep = hashrate.Count() / 4;
                List<int> timeSteps = new List<int>() { 0, timeStep, timeStep * 2, timeStep * 3 };
                int x = 0;
                int y = 0;
                long hashDiff = maxHash - minHash;
                int i = 0;
                foreach (var hash in hashrate)
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
                    var lastTimeStamp = DateTimeOffset.FromUnixTimeSeconds(hashrate.Last()[0]).DateTime.ToLocalTime();
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

            lblEntryCount.Text = $"{rewards24.Count} entries";
        }

        private void Display24hEarnings(float eth, float zil, EzilBalance balances)
        {
            try
            {
                //CoinListings coinListings = GetCryptoPrices(apiKey);
                //float ethPrice = coinListings.data.Where(d => d.symbol.Equals("ETH")).FirstOrDefault().quote.USD.price;
                //float zilPrice = coinListings.data.Where(d => d.symbol.Equals("ZIL")).FirstOrDefault().quote.USD.price;
                MinerstatsAPI minerstatsAPI = new MinerstatsAPI();
                var coinInfoList = minerstatsAPI.GetCoinInfo(new string[] { "ETH", "ZIL" });
                var coinInfoCurrEth = coinInfoList.Where(d => d.coin.Equals("ETH")).FirstOrDefault();

                float ethPrice = coinInfoList.Where(d => d.coin.Equals("ETH")).FirstOrDefault().price;
                float zilPrice = coinInfoList.Where(d => d.coin.Equals("ZIL")).FirstOrDefault().price;
                float ethValue = ethPrice * eth;
                float zilValue = zilPrice * zil;
                lblEthUsd.Text = $"= ${ethValue:0.00} @ ${ethPrice:0.00}";
                lblZilUsd.Text = $"= ${zilValue:0.00} @ ${zilPrice:0.00}";
                lblTotal.Text = $"= ${(ethValue + zilValue):0.00}/d, {((ethValue + zilValue) * 7):0.00}/w, {((ethValue + zilValue) * 30):0.00}/m, {((ethValue + zilValue) * 365):0.00}/y";

                float ethBalanceValue = balances.eth * ethPrice;
                float zilBalanceValue = balances.zil * zilPrice;
                lblEthValue.Text = $"({ethBalanceValue:0.00} USD)";
                lblZilValue.Text = $"({zilBalanceValue:0.00} USD)";
                lblTotalBalance.Text = $"= ({(ethBalanceValue + zilBalanceValue):0.00} USD)";

                var coinInfoEth24 = minerstatsAPI.GetCoinHistory("ETH");
                var currentStats = GetCurrentStats();
                long averageHash = currentStats.average_hashrate;
                lblNetHash.Text = $"Network Hashrate: {coinInfoCurrEth.network_hashrate/1000000000000} TH/s";
                lblBlockReward.Text = $"Block Reward: {coinInfoCurrEth.reward_block} ETH";
                float ethCur = ((coinInfoCurrEth.reward * 0.99f) * 24) * averageHash;
                lblEthCurProfit.Text = $"Current Profitability: {ethCur} ETH ({ethCur * ethPrice:0.00} USD)";
                float eth24h = ((coinInfoEth24.reward * 0.99f) * 24) * averageHash;
                lblEthProfit.Text = $"24h Profitability: {eth24h} ETH ({eth24h * ethPrice:0.00} USD)";
                float ezilDiff = eth - eth24h;
                lblEzilDiff.Text = $"Difference to Ezil: {ezilDiff} ETH ({ezilDiff * ethPrice:0.00} USD)";
                lblAverageHashrate.Text = $"Average Hash Rate = {averageHash / 1000000f:0.##} MH/s";
            }
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    throw new Exception($"Cannot retrieve cryptocurrency prices. Try again later.{Environment.NewLine}{ex.InnerException.Message}");
                }
                throw new Exception($"Cannot retrieve cryptocurrency prices. Try again later.{Environment.NewLine}{ex.Message}");
            }
        }

        private EzilCurrentStats GetCurrentStats()
        {
            EzilCurrentStats ezilCurrentStats = null;
            var ezilAPI = new EzilAPI(ezilWallet.Eth, ezilWallet.Zil);
            ezilCurrentStats = JsonConvert.DeserializeObject<EzilCurrentStats>(ezilAPI.GetCurrentStats());
            return ezilCurrentStats;
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
            try
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
            catch (Exception ex)
            {
                if (ex is AggregateException)
                {
                    throw new Exception($"Cannot retrieve Ezil Wallet details. Make sure that your wallet addresses are correct.{Environment.NewLine}{ex.InnerException.Message}");
                }
                throw new Exception($"Cannot retrieve Ezil Wallet details. Make sure that your wallet addresses are correct.{Environment.NewLine}{ex.Message}");
            }
        }

        private Dictionary<string, TRexSummary> GetWorkerStats(List<Machine> machines, bool reloadTree = true)
        {
            Dictionary<string, TRexSummary> workerStats = new Dictionary<string, TRexSummary>();

            foreach (var machine in machines)
            {
                try
                {
                    if (machine.Enabled)
                    {
                        workerStats.Add(machine.ToString(), TRexAPI.GetFullSummary(machine.Host));
                    }
                }
                catch
                {
                    workerStats.Add($"{machine} - OFFLINE", new TRexSummary());
                    machine.Enabled = false;
                }
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

                    if (workerStat.Value.gpus != null)
                    {
                        foreach (var gpu in workerStat.Value.gpus)
                        {
                            workerNode.Nodes.Add($"{gpu.vendor} {gpu.name}: Hash={(gpu.hashrate / 1000000d):0.00}MH/s Temp={gpu.temperature}°C Power={gpu.power}W Efficiency={gpu.efficiency}");
                        }
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
            this.Cursor = Cursors.WaitCursor;

            RefreshTree();
            this.Cursor = Cursors.Default;
        }

        private void RefreshTree()
        {
            string selectedNodeKey = string.Empty;
            if (workerTree.SelectedNode != null)
            {
                selectedNodeKey = workerTree.SelectedNode.Text;
            }

            var workersStats = GetWorkerStats(machines, true);
            var workerInfo = GetWorkersInfo(workersStats).Where(c => c.WorkerName.Equals(selectedNodeKey)).FirstOrDefault();
            if (workerInfo != null && !selectedNodeKey.Equals(string.Empty))
            {
                DisplayWorkerGraph(workersStats[selectedNodeKey], workerInfo.MinHash, workerInfo.MaxHash);
            }
        }

        private void cmdRefreshRewards_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            GetStatsAndBalance();
            this.Cursor = Cursors.Default;
        }

        private void cmdCombineGraphs_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            var pens = new List<Pen>() { Pens.Blue, Pens.Red, Pens.DarkGreen, Pens.Orange, Pens.Violet };
            var workerStats = GetWorkerStats(machines, true);
            var workersInfo = GetWorkersInfo(workerStats);

            long minHash = workersInfo.Min(c => c.MinHash);
            long maxHash = workersInfo.Max(c => c.MaxHash);
            int i = 0;

            picWorkerGraph.Image = new Bitmap(800 * 2, 200 * 2);
            bool printTimeStamp = true;
            foreach (var workerStat in workerStats)
            {
                DisplayWorkerGraph(workerStat.Value, minHash, maxHash, pens[(i++ % 5)], 2, printTimeStamp);
                printTimeStamp = false;
            }
            this.Cursor = Cursors.Default;
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StringBuilder aboutText = new StringBuilder();
            aboutText.AppendLine("Ezil Estimator");
            aboutText.AppendLine("Displays Ezil and T-Rex statistics from their respectives APIs and performs day/week/month/year estimates based on the last 24h data.");
            aboutText.AppendLine();
            aboutText.AppendLine("Developed by Tulio Gonçalves. ©2021");
            aboutText.AppendLine("https://github.com/TulioAdriano/EzilEstimator");

            MessageBox.Show(aboutText.ToString(), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cmdMergeGraphs_Click(object sender, EventArgs e)
        {
            List<long[]> hashRates = new List<long[]>();
            DateTime utcNow = DateTime.UtcNow;
            var trexData = GetWorkerStats(machines, false);
            int granularity = (int)txtGranularity.Value;
            for (int seconds = 3600; seconds > 0; seconds-= granularity)
            {
                var timeStart = utcNow.AddSeconds(-seconds);
                var timeEnd = timeStart.AddSeconds(granularity);

                long hashRate = 0;
                foreach (var item in trexData)
                {
                    var worker = item.Value;
                    if (item.Value.velocities == null)
                    {
                        continue;
                    }
                    var result = worker.velocities.hashrate.Where(c => c[0] >= timeStart.ToUnixTimeSeconds()
                                                                     && c[0] <= timeEnd.ToUnixTimeSeconds());
                    if (result.Count().Equals(0)) 
                    { 
                        continue; 
                    }
                    
                    var avgRate = result.Average(c => c[1]);
                    hashRate += (long)Math.Round(avgRate);
                }

                hashRates.Add(new long[2] { timeStart.ToUnixTimeSeconds(), hashRate });
            }

            DisplayWorkerGraph(hashRates, hashRates.Min(c => c[1]), hashRates.Max(c => c[1]));
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.Value is DateTime)
            {
                DateTime value = (DateTime)e.Value;
                switch (value.Kind)
                {
                    case DateTimeKind.Unspecified:
                        e.Value = DateTime.SpecifyKind(value, DateTimeKind.Utc).ToLocalTime();
                        break;
                    case DateTimeKind.Utc:
                        e.Value = value.ToLocalTime();
                        break;
                }
            }
        }

        private void rdo24h_CheckedChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            GetStatsAndBalance();
            this.Cursor = Cursors.Default;
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

        public long PowerUsage
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
