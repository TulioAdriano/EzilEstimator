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
        double hashPower = 0;
        ZilInfo zilInfo = null;

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
            LoadConfig();

            Task.Run(() =>
            {
                SetupProgressBar(2);
                txtStatus.Text = "Getting workers information";
                var workerStats = GetWorkerStats(machines);
                var workersInfo = GetWorkersInfo(workerStats, true);
                UpdateProgressBarValue(1);

                txtStatus.Text = "Plotting graph";
                if (workersInfo != null && workersInfo.Count > 0)
                {
                    if (workerTree.InvokeRequired)
                    {
                        workerTree.Invoke(new MethodInvoker(() =>
                        {
                            DisplayWorkerGraph(workerStats[workerTree.SelectedNode.Text], workersInfo[0].MinHash, workersInfo[0].MaxHash);
                        }));
                    }
                    else
                    {
                        DisplayWorkerGraph(workerStats[workerTree.SelectedNode.Text], workersInfo[0].MinHash, workersInfo[0].MaxHash);
                    }
                }
                UpdateProgressBarValue(2);

                GetStatsAndBalance();
            });

            zilTimer.Start();
        }

        private void GetStatsAndBalance()
        {
            SetCursor(Cursors.AppStarting);

            try
            {
                SetupProgressBar(5);
                txtStatus.Text = "Getting statistics from Ezil.me";
                var rewards24 = GetEzilStats();
                float eth = rewards24.Where(c => c.coin.Equals("eth")).Sum(s => s.amount);
                float zil = rewards24.Where(c => c.coin.Equals("zil")).Sum(s => s.amount);
                UpdateText(txtEth24h, eth.ToString());
                UpdateText(txtZil24h, zil.ToString());
                UpdateProgressBarValue(1);

                txtStatus.Text = "Getting balances from Ezil.me";
                var balances = GetBalances();
                UpdateText(lblEthBalance, $"Unpaid ETH: {balances.eth}");
                UpdateText(lblZilBalance, $"Unpaid ZIL: {balances.zil}");

                DateTime cutoffTime = (DateTime.UtcNow >= DateTime.UtcNow.Date.AddHours(6) ?
                                                          DateTime.UtcNow.Date.AddHours(6) :
                                                          DateTime.UtcNow.Date.AddDays(-1).AddHours(6));

                var ethRewardsToday = rewards24.Where(c => c.coin.Equals("eth") && c.created_at > cutoffTime);
                if (ethRewardsToday.Count() > 0)
                {
                    var timespanEth = ethRewardsToday.Max(c => c.created_at) - cutoffTime;
                    float ethValToday = ethRewardsToday.Sum(s => s.amount);
                    UpdateText(lblEthToday, $"ETH earned today: {ethValToday}; Trending to: {((ethValToday / timespanEth.TotalHours) * 24):0.#######}");
                }

                var zilRewardsToday = rewards24.Where(c => c.coin.Equals("zil") && c.created_at > cutoffTime);
                if (zilRewardsToday.Count() > 0)
                {
                    var timespanZil = zilRewardsToday.Max(c => c.created_at) - cutoffTime;
                    float zilValToday = zilRewardsToday.Sum(s => s.amount);
                    UpdateText(lblZilToday, $"ZIL earned today: {zilValToday}; Trending to: {((zilValToday / timespanZil.TotalHours) * 24):0.##}");
                }

                UpdateProgressBarValue(2);

                txtStatus.Text = "Getting rewards history from Ezil.me";
                int timeFrame = rdo24h.Checked ? 24 : 48;
                var history = GetHistory(ezilWallet, timeFrame);
                var acceptedShares = history.Sum(c => c.accepted_shares_count);
                var staleShares = history.Sum(c => c.stale_shares_count);
                var invalidShares = history.Sum(c => c.invalid_shares_count);
                var staleRatio = (staleShares / ((double)(acceptedShares + staleShares + invalidShares)));
                UpdateText(lblAcceptedShares, $"Total Accepted Shares: {acceptedShares}");
                UpdateText(lblStaleShares, $"Total Stale Shares: {staleShares}");
                UpdateText(lblInvalidShares, $"Total Invalid Shares: {invalidShares}");
                UpdateText(lblSharesRatio, $"Stale Shares Ratio: {staleRatio:P2}");
                UpdateProgressBarValue(3);

                txtStatus.Text = "Updating rewards list";
                DisplayRewardGridInfo(rewards24);
                UpdateProgressBarValue(4);

                txtStatus.Text = "Updating earnings statistics";
                Display24hEarnings(eth, zil, balances);
                UpdateProgressBarValue(5);
                txtStatus.Text = "Ready";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            SetCursor(Cursors.Default);
        }

        private void SetCursor(Cursor cursor)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => this.Cursor = cursor));
            }
            else
            {
                this.Cursor = cursor;
            }
        }

        private void SetupProgressBar(int maxVal)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    pbStatus.Maximum = maxVal;
                    pbStatus.Value = 0;
                }));
            }
            else
            {
                pbStatus.Maximum = maxVal;
                pbStatus.Value = 0;
            }
        }

        private void UpdateText(Control control, string text)
        {
            if (control.InvokeRequired)
            {
                control.Invoke(new MethodInvoker(() => control.Text = text));
            }
            else
            {
                control.Text = text;
            }
        }

        private void UpdateProgressBarValue(int value)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() => {
                    pbStatus.Value = value;
                }));
            }
            else
            {
                pbStatus.Value = value;
            }
        }

        private List<EzilStats> GetHistory(Wallet ezilWallet, int timeFrame)
        {
            try
            {
                var ezilStats = EzilAPI.GetHistoricalStats(ezilWallet, timeFrame);
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

        private EzilBalance GetBalances()
        {
            try
            {
                var balances = EzilAPI.GetBalances(ezilWallet);
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
                if (worker.Value == null || worker.Key.ToLower().Contains("offline"))
                {
                    continue;
                }
                workersInfo.Add(new WorkerInfo()
                {
                    WorkerName = worker.Key,
                    HashPower = worker.Value.hashrate,
                    MaxHash = (worker.Value.velocities == null ? 0 : worker.Value.velocities.hashrate.Max(c => c[1])),
                    MinHash = (worker.Value.velocities == null ? 0 : worker.Value.velocities.hashrate.Min(c => c[1])),
                    PowerUsage = (long)Math.Round(worker.Value.velocities.power.Average(c => c[1]))
                });
            }

            if (updateTotalHash)
            {
                hashPower = (workersInfo.Sum(c => c.HashPower) / 1000000d);
                UpdateText(lblHashPower, $"Total Hash Rate: {hashPower:0.00} MH/s");
                UpdateText(lblPowerUsage, $"Total Power Usage: {(workersInfo.Sum(c => c.PowerUsage) / 1000d):0.00} KW/h");
            }

            return workersInfo;
        }

        private void DisplayWorkerGraph(TRexSummary workerStat, long minHash, long maxHash, Pen pen = null, bool printTimeStamp = true)
        {
            DisplayWorkerGraph(workerStat.velocities.hashrate, minHash, maxHash, pen, printTimeStamp);
        }

        private void DisplayWorkerGraph(List<long[]> hashrate, long minHash, long maxHash, Pen pen = null, bool printTimeStamp = true)
        {
            Pen graphPen = pen ?? Pens.Black;
            var font = new Font("Arial", 8);
            double zoom = this.CreateGraphics().DpiX / 96d;
            if (pen == null)
            {
                picWorkerGraph.Image = new Bitmap((int)(800 * zoom), (int)(200 * zoom));
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
                    int newY = (int)(180 * zoom) - (int)(Math.Round(((double)(hash[1] - minHash) / (double)hashDiff) * (180 * zoom)));
                    gfx.DrawLine(graphPen, x, y, x + space, newY);
                    if (printTimeStamp && timeSteps.Contains(i++))
                    {
                        var timeStamp = DateTimeOffset.FromUnixTimeSeconds(hash[0]).DateTime.ToLocalTime();
                        gfx.DrawString($"{timeStamp.ToShortDateString()} {timeStamp.ToShortTimeString()}", font, Brushes.Red, x, (int)(180 * zoom));
                    }
                    x += space;
                    y = newY;
                }
                if (printTimeStamp)
                {
                    var lastTimeStamp = DateTimeOffset.FromUnixTimeSeconds(hashrate.Last()[0]).DateTime.ToLocalTime();
                    gfx.DrawString($"{lastTimeStamp.ToShortDateString()} {lastTimeStamp.ToShortTimeString()}", font, Brushes.Red, x, (int)(180 * zoom));
                }

                gfx.DrawString($"{(maxHash / 1000000d):0.0}", font, Brushes.Black, (int)(720 * zoom), 0);
                gfx.DrawString($"{(minHash / 1000000d):0.0}", font, Brushes.Black, (int)(720 * zoom), (int)(165 * zoom));
            }
            if (picWorkerGraph.InvokeRequired)
            {
                picWorkerGraph.Invoke(new MethodInvoker(() => picWorkerGraph.Refresh()));
            }
            else
            {
                picWorkerGraph.Refresh();
            }
        }

        private void DisplayRewardGridInfo(List<EzilReward> rewards24)
        {
            if (dataGridView.InvokeRequired)
            {
                dataGridView.Invoke(new MethodInvoker(() =>
                {
                    dataGridView.DataSource = rewards24;
                    dataGridView.Columns[0].DefaultCellStyle.Format =
                    dataGridView.Columns[3].DefaultCellStyle.Format = "0.#################################";

                    lblEntryCount.Text = $"{rewards24.Count} entries ({rewards24.Count(c => c.coin.Equals("eth"))} ETH, {rewards24.Count(c => c.coin.Equals("zil"))} ZIL)";
                }));
            }
            else
            {
                dataGridView.DataSource = rewards24;
                dataGridView.Columns[0].DefaultCellStyle.Format =
                dataGridView.Columns[3].DefaultCellStyle.Format = "0.#################################";

                lblEntryCount.Text = $"{rewards24.Count} entries ({rewards24.Count(c=>c.coin.Equals("eth"))} ETH, {rewards24.Count(c => c.coin.Equals("zil"))} ZIL)";
            }
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
                var coinInfoEth24 = minerstatsAPI.GetCoinHistory("ETH");

                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(() => UpdateUiLabels(eth, zil, balances, coinInfoList, coinInfoEth24)));
                }
                else
                {
                    UpdateUiLabels(eth, zil, balances, coinInfoList, coinInfoEth24);
                }
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

        private void UpdateUiLabels(float eth, float zil, EzilBalance balances, List<CoinInfo> coinInfoList, CoinInfo coinInfoEth24)
        {
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
            lblEthValue.Text = $"(${ethBalanceValue:0.00})";
            lblZilValue.Text = $"(${zilBalanceValue:0.00})";
            lblTotalBalance.Text = $"= (${(ethBalanceValue + zilBalanceValue):0.00})";

            float selectedHash = 0;
            var currentStats = GetCurrentStats();
            float averageHash = currentStats.average_hashrate;
            if (rdoUseAverage.Checked)
            {
                selectedHash = averageHash;
            }
            else if (rdoUseReported.Checked)
            {
                selectedHash = (float)hashPower * 1000000;
            }
            else
            {
                selectedHash = (float)txtCustomHash.Value * 1000000;
            }

            lblNetHash.Text = $"Network Hashrate: {coinInfoCurrEth.network_hashrate / 1000000000000} TH/s";
            lblBlockReward.Text = $"Block Reward: {coinInfoCurrEth.reward_block} ETH";
            float ethCur = ((coinInfoCurrEth.reward * 0.99f) * 24) * selectedHash;
            lblEthCurProfit.Text = $"Current Profitability: {ethCur} ETH (${ethCur * ethPrice:0.00})";
            float eth24h = ((coinInfoEth24.reward * 0.99f) * 24) * selectedHash;
            lblEthProfit.Text = $"24h Profitability: {eth24h} ETH (${eth24h * ethPrice:0.00})";
            float ezilDiff = eth - eth24h;
            lblEzilDiff.Text = $"Difference to Ezil: {ezilDiff} ETH (${ezilDiff * ethPrice:0.00})";
            lblAverageHashrate.Text = $"Average Hash Rate = {averageHash / 1000000f:0.##} MH/s";
        }

        private EzilCurrentStats GetCurrentStats()
        {
            var ezilCurrentStats = EzilAPI.GetCurrentStats(ezilWallet);
            return ezilCurrentStats;
        }

        private static CoinListings GetCryptoPrices(string apiKey)
        {
            CoinMarketCapAPI coinMarketCapAPI = new CoinMarketCapAPI(apiKey);
            string coinresponse = coinMarketCapAPI.GetListings();
            var coinListings = JsonConvert.DeserializeObject<CoinListings>(coinresponse);
            return coinListings;
        }

        private List<EzilReward> GetEzilStats()
        {
            try
            {
                List<EzilReward> ezilRewards = new List<EzilReward>();
                int page = 1;
                do
                {
                    var rewards = EzilAPI.GetRewards(ezilWallet, page++, 999, "eth");
                    ezilRewards.AddRange(rewards/*.Where(r => r.coin.Equals("eth"))*/);
                } while (ezilRewards.Min(c => c.created_at) >= DateTime.UtcNow.AddDays(-1));

                var rewards24 = ezilRewards.Where(r => r.created_at >= DateTime.UtcNow.AddDays(-1)).ToList();

                page = 1;
                ezilRewards.Clear();
                do
                {
                    var rewards = EzilAPI.GetRewards(ezilWallet, page++, 999, "zil");
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

            int currentPbValue = 0;
            int currentPbMax = 0;
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    currentPbMax = pbStatus.Maximum;
                    currentPbValue = pbStatus.Value;
                }));
            }
            else
            {
                currentPbMax = pbStatus.Maximum;
                currentPbValue = pbStatus.Value;
            }

            SetupProgressBar(machines.Count);
            int i = 0;
            foreach (var machine in machines)
            {
                try
                {
                    TRexSummary workerInfo = null;
                    if (machine.Enabled)
                    {
                        txtStatus.Text = $"Getting stats for {machine.Nickname}";
                        workerInfo = TRexAPI.GetFullSummary(machine.Host);
                    }
                    workerStats.Add(machine.ToString(), workerInfo);

                    if (workerInfo == null)
                    {
                        continue;
                    }
                }
                catch
                {
                    workerStats.Add($"{machine} - OFFLINE", new TRexSummary());
                    machine.Enabled = false;
                }
                finally
                {
                    UpdateProgressBarValue(++i);
                }
            }
            txtStatus.Text = "Ready";

            if (reloadTree)
            {
                if (this.InvokeRequired)
                {
                    this.Invoke(new MethodInvoker(() => ReloadTree(workerStats)));
                }
                else
                {
                    ReloadTree(workerStats);
                }
            }

            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(() =>
                {
                    pbStatus.Maximum = currentPbMax;
                    pbStatus.Value = currentPbValue;
                }));
            }
            else
            {
                pbStatus.Maximum = currentPbMax;
                pbStatus.Value = currentPbValue;
            }

            return workerStats;
        }

        private void ReloadTree(Dictionary<string, TRexSummary> workerStats)
        {
            workerTree.Nodes.Clear();
            foreach (var workerStat in workerStats)
            {
                if (workerStat.Value == null)
                {
                    continue;
                }

                var workerNode = workerTree.Nodes.Add(workerStat.Key);
                if (workerTree.SelectedNode == null)
                {
                    workerTree.SelectedNode = workerNode;
                }

                if (workerStat.Value.gpus != null)
                {
                    foreach (var gpu in workerStat.Value.gpus)
                    {
                        var gpuName = (gpu.name.StartsWith(gpu.vendor) ? gpu.name : $"{gpu.vendor} {gpu.name}");
                        var gpuMemTemp = (gpu.memory_temperature > 0 ? $"{gpu.memory_temperature}°C" : "NA");
                        workerNode.Nodes.Add($"{gpuName}: Hash={(gpu.hashrate / 1000000d):0.00}MH/s " +
                                                        $"GPU={gpu.temperature}°C " +
                                                        $"Mem={gpuMemTemp} " +
                                                        $"Power={gpu.power}W " +
                                                        $"Efficiency={gpu.efficiency}");
                    }
                }
                workerNode.Expand();
            }
        }

        private void workerTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (e.Node.Parent != null)
            {
                workerTree.SelectedNode = e.Node.Parent;
            }
            var workersStats = GetWorkerStats(machines, false);
            var workerInfo = GetWorkersInfo(workersStats, false).Where(c => c.WorkerName.Equals(workerTree.SelectedNode.Text)).FirstOrDefault();

            if (workerInfo != null)
            {
                DisplayWorkerGraph(workersStats[workerTree.SelectedNode.Text], workerInfo.MinHash, workerInfo.MaxHash);
            }
            this.Cursor = Cursors.Default;
        }
        private void cmdRefeshGraph_Click(object sender, EventArgs e)
        {
            Task.Run(() => RefreshTree());
        }

        private void RefreshTree()
        {
            SetCursor(Cursors.AppStarting);
            string selectedNodeKey = string.Empty;
            if (workerTree.InvokeRequired)
            {
                workerTree.Invoke(new MethodInvoker(() => {
                    if (workerTree.SelectedNode != null)
                    {
                        selectedNodeKey = workerTree.SelectedNode.Text;
                    }
                }));
            }
            else
            {
                if (workerTree.SelectedNode != null)
                {
                    selectedNodeKey = workerTree.SelectedNode.Text;
                }
            }

            var workersStats = GetWorkerStats(machines, true);
            var workerInfo = GetWorkersInfo(workersStats).Where(c => c.WorkerName.Equals(selectedNodeKey)).FirstOrDefault();
            if (workerInfo != null && !selectedNodeKey.Equals(string.Empty))
            {
                DisplayWorkerGraph(workersStats[selectedNodeKey], workerInfo.MinHash, workerInfo.MaxHash);
            }

            SetCursor(Cursors.Default);
        }

        private void cmdRefreshRewards_Click(object sender, EventArgs e)
        {
            //zilInfo = EzilAPI.GetZilInfo();
            Task.Run(() => GetStatsAndBalance());
        }

        private void cmdCombineGraphs_Click(object sender, EventArgs e)
        {
            Task.Run(() =>
            {
                SetCursor(Cursors.AppStarting);

                var pens = new List<Pen>() { Pens.Blue, Pens.Red, Pens.DarkGreen, Pens.Orange, Pens.Violet };
                var workerStats = GetWorkerStats(machines, true);
                var workersInfo = GetWorkersInfo(workerStats);

                long minHash = workersInfo.Min(c => c.MinHash);
                long maxHash = workersInfo.Max(c => c.MaxHash);
                int i = 0;

                double zoom = this.CreateGraphics().DpiX / 96d;

                picWorkerGraph.Image = new Bitmap((int)(800 * zoom), (int)(200 * zoom));
                bool printTimeStamp = true;
                foreach (var workerStat in workerStats)
                {
                    if (workerStat.Value == null)
                    {
                        continue;
                    }
                    DisplayWorkerGraph(workerStat.Value, minHash, maxHash, pens[(i++ % 5)], printTimeStamp);
                    printTimeStamp = false;
                }

                SetCursor(Cursors.Default);
            });
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguration configForm = new frmConfiguration();
            if (configForm.ShowDialog().Equals(DialogResult.OK))
            {
                LoadConfig();
                Task.Run(() => RefreshTree());
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
            Task.Run(() =>
            {
                SetCursor(Cursors.AppStarting);

                List<long[]> hashRates = new List<long[]>();
                DateTime utcNow = DateTime.UtcNow;
                var trexData = GetWorkerStats(machines, false);
                int granularity = (int)txtGranularity.Value;
                for (int seconds = 3600; seconds > 0; seconds -= granularity)
                {
                    var timeStart = utcNow.AddSeconds(-seconds);
                    var timeEnd = timeStart.AddSeconds(granularity);

                    long hashRate = 0;
                    foreach (var item in trexData)
                    {
                        if (item.Value == null)
                        {
                            continue;
                        }
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

                SetCursor(Cursors.Default);
            });
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
            Task.Run(() => GetStatsAndBalance());
        }

        private void rdoUseAverage_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                Task.Run(() => GetStatsAndBalance());
            }
        }

        private void rdoUseReported_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                Task.Run(() => GetStatsAndBalance());
            }
        }

        private void rdoUseCustom_CheckedChanged(object sender, EventArgs e)
        {
            if ((sender as RadioButton).Checked)
            {
                Task.Run(() => GetStatsAndBalance());
            }
        }

        private void zilTimer_Tick(object sender, EventArgs e)
        {
            if (zilInfo == null || zilInfo.next_pow_time <= DateTime.UtcNow || ((int)(zilInfo.next_pow_time - DateTime.UtcNow).TotalMinutes % 5) == 0)
            {
                zilInfo = EzilAPI.GetZilInfo();
            }

            var zilPowTime = (zilInfo.next_pow_time - DateTime.UtcNow);
            lblNextZil.Invoke(new MethodInvoker(() =>
            {
                lblNextZil.Text = $"Next ZIL round in: {zilPowTime.Hours}:{zilPowTime.Minutes:00}:{zilPowTime.Seconds:00} ";
            }));
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
