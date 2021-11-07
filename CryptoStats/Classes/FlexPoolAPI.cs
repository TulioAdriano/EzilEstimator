using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace CryptoStats
{
    class FlexPoolAPI : IMiningPool
    {
        public bool CanPageRewards => false;

        public List<MiningReward> GetRewards(Wallet wallet, int page = 1, int entries = 10, string coin = "eth")
        {
            List<MiningReward> rewards = new List<MiningReward>();

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://api.flexpool.io/v2/miner/blockRewards?coin=eth&address={wallet.Eth}";
                string response = httpClient.GetStringAsync(new Uri(request)).Result;
                var rewardData = JsonConvert.DeserializeObject<FlexReward>(response);

                foreach (var result in rewardData.result)
                {
                    rewards.Add(new MiningReward()
                    {
                        coin = "eth",
                        created_at = DateTimeOffset.FromUnixTimeSeconds(result.timestamp).DateTime,
                        amount = result.reward / 1000000000000000000f,
                        block_number = (ulong)result.blockNumber,
                        id = 0 //NA
                    });
                }
            }

            return rewards;
        }

        public MiningBalance GetBalances(Wallet wallet)
        {
            MiningBalance balances = null;

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://api.flexpool.io/v2/miner/balance?coin=eth&address={wallet.Eth}";
                string response = httpClient.GetStringAsync(new Uri(request)).Result;
                var balanceData = JsonConvert.DeserializeObject<FlexBalance>(response);

                balances = new MiningBalance() { eth = (balanceData.result.balance / 1000000000000000000f), eth_wallet = wallet.Eth };
            }

            return balances;
        }

        public MiningCurrentStats GetCurrentStats(Wallet wallet, bool includeReported = true)
        {
            MiningCurrentStats currentStats = null;

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://api.flexpool.io/v2/miner/stats?coin=eth&address={wallet.Eth}";
                string response = httpClient.GetStringAsync(new Uri(request)).Result;
                var statsData = JsonConvert.DeserializeObject<FlexStats>(response);

                currentStats = new MiningCurrentStats()
                {
                    average_hashrate = (long)Math.Round(statsData.result.averageEffectiveHashrate),
                    current_hashrate = statsData.result.currentEffectiveHashrate
                };
            }

            return currentStats;
        }

        public List<MiningStats> GetHistoricalStats(Wallet wallet, int timeFrame)
        {
            List<MiningStats> stats = new List<MiningStats>();

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://api.flexpool.io/v2/miner/chart?coin=eth&address={wallet.Eth}";
                string response = httpClient.GetStringAsync(new Uri(request)).Result;
                var chartData = JsonConvert.DeserializeObject<FlexChart>(response);

                foreach (var result in chartData.result)
                {
                    stats.Add(new MiningStats() { 
                        time = DateTimeOffset.FromUnixTimeSeconds(result.timestamp).DateTime,
                        accepted_shares_count = result.validShares,
                        stale_shares_count = result.staleShares,
                        invalid_shares_count = result.invalidShares,
                        reported_hashrate = result.reportedHashrate,
                        long_average_hashrate = (int)Math.Round(result.averageEffectiveHashrate),
                        short_average_hashrate = result.effectiveHashrate
                    });
                }
            }

            return stats;
        }
    }


    public class FlexBalance
    {
        public object error
        {
            get; set;
        }
        public Result result
        {
            get; set;
        }
    }

    public class Result
    {
        public float balance
        {
            get; set;
        }
        public float balanceCountervalue
        {
            get; set;
        }
        public float price
        {
            get; set;
        }
    }

    public class FlexReward
    {
        public object error
        {
            get; set;
        }
        public RewardResult[] result
        {
            get; set;
        }
    }

    public class RewardResult
    {
        public float share
        {
            get; set;
        }
        public float reward
        {
            get; set;
        }
        public bool confirmed
        {
            get; set;
        }
        public string hash
        {
            get; set;
        }
        public int timestamp
        {
            get; set;
        }
        public int blockNumber
        {
            get; set;
        }
        public string blockType
        {
            get; set;
        }
    }

    public class FlexStats
    {
        public object error
        {
            get; set;
        }
        public StatsResult result
        {
            get; set;
        }
    }

    public class StatsResult
    {
        public float averageEffectiveHashrate
        {
            get; set;
        }
        public int currentEffectiveHashrate
        {
            get; set;
        }
        public int invalidShares
        {
            get; set;
        }
        public int reportedHashrate
        {
            get; set;
        }
        public int staleShares
        {
            get; set;
        }
        public int validShares
        {
            get; set;
        }
    }

    public class FlexChart
    {
        public object error
        {
            get; set;
        }
        public ChartResult[] result
        {
            get; set;
        }
    }

    public class ChartResult
    {
        public int timestamp
        {
            get; set;
        }
        public int effectiveHashrate
        {
            get; set;
        }
        public float averageEffectiveHashrate
        {
            get; set;
        }
        public int reportedHashrate
        {
            get; set;
        }
        public int validShares
        {
            get; set;
        }
        public int staleShares
        {
            get; set;
        }
        public int invalidShares
        {
            get; set;
        }
    }

}
