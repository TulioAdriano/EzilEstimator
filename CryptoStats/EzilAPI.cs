using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStats
{
    public class EzilAPI
    {

        public static List<EzilReward> GetRewards(Wallet wallet, int page = 1, int entries = 10, string coin = "eth")
        {
            List<EzilReward> rewards = new List<EzilReward>();

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://billing.ezil.me/rewards/{wallet.Eth}.{wallet.Zil}?page={page}&per_page={entries}&coin={coin}";
                string response = httpClient.GetStringAsync(new Uri(request)).Result;
                rewards = JsonConvert.DeserializeObject<List<EzilReward>>(response);
            }

            return rewards;
        }
        public static EzilBalance GetBalances(Wallet wallet)
        {
            EzilBalance balances = null;

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://billing.ezil.me/balances/{wallet.Eth}.{wallet.Zil}";
                string response = httpClient.GetStringAsync(new Uri(request)).Result;
                balances = JsonConvert.DeserializeObject<EzilBalance>(response);
            }

            return balances;
        }

        public static List<EzilStats> GetHistoricalStats(Wallet wallet, int timeFrame)
        {
            List<EzilStats> stats = new List<EzilStats>();
            string timeFrom = DateTime.UtcNow.AddHours(-timeFrame).ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
            string timeTo = DateTime.UtcNow.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://stats.ezil.me/historical_stats/{wallet.Eth}.{wallet.Zil}?time_from={timeFrom}&time_to={timeTo}";
                string response = httpClient.GetStringAsync(new Uri(request)).Result;
                stats = JsonConvert.DeserializeObject<List<EzilStats>>(response);
            }

            return stats;
        }

        public static EzilCurrentStats GetCurrentStats(Wallet wallet, bool includeReported = true)
        {
            EzilCurrentStats currentStats = null;

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://stats.ezil.me/current_stats/{wallet.Eth}.{wallet.Zil}{(includeReported ? "/reported" : string.Empty)}";
                string response = httpClient.GetStringAsync(new Uri(request)).Result;
                currentStats = JsonConvert.DeserializeObject<EzilCurrentStats>(response);
            }

            return currentStats;
        }

        public static ZilInfo GetZilInfo()
        {
            ZilInfo zilinfo = null;
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    var request = $"https://xxx.ezil.me/blockchain_stats";
                    var response = httpClient.GetStringAsync(new Uri(request)).Result;
                    zilinfo = JsonConvert.DeserializeObject<ZilInfo>(response);
                }
                catch { }
            }

            return zilinfo;
        }
    }

    public class EzilReward
    {
        public float amount
        {
            get; set;
        }
        public string coin
        {
            get; set;
        }
        public ulong? block_number
        {
            get; set;
        }
        public float cashback_amount
        {
            get; set;
        }
        public DateTime created_at
        {
            get; set;
        }
        public long id
        {
            get; set;
        }
    }

    public class EzilBalance
    {
        public float eth
        {
            get; set;
        }
        public float zil
        {
            get; set;
        }
        public string eth_wallet
        {
            get; set;
        }
        public string zil_wallet
        {
            get; set;
        }
    }

    public class EzilStats
    {
        public DateTime time
        {
            get; set;
        }
        public int long_average_hashrate
        {
            get; set;
        }
        public int short_average_hashrate
        {
            get; set;
        }
        public int reported_hashrate
        {
            get; set;
        }
        public int rejected_shares_count
        {
            get; set;
        }
        public int invalid_shares_count
        {
            get; set;
        }
        public int stale_shares_count
        {
            get; set;
        }
        public int accepted_shares_count
        {
            get; set;
        }
        public int workers_count
        {
            get; set;
        }
    }


    public class EzilCurrentStats
    {
        public Eth eth
        {
            get; set;
        }
        public Etc etc
        {
            get; set;
        }
        public string last_share_coin
        {
            get; set;
        }
        public long current_hashrate
        {
            get; set;
        }
        public long average_hashrate
        {
            get; set;
        }
        public int last_share_timestamp
        {
            get; set;
        }
        public long reported_hashrate
        {
            get; set;
        }
    }

    public class Eth
    {
        public int current_hashrate
        {
            get; set;
        }
        public int average_hashrate
        {
            get; set;
        }
        public int last_share_timestamp
        {
            get; set;
        }
        public string last_share_coin
        {
            get; set;
        }
        public string wallet
        {
            get; set;
        }
        public int reported_hashrate
        {
            get; set;
        }
    }

    public class Etc
    {
        public int current_hashrate
        {
            get; set;
        }
        public int average_hashrate
        {
            get; set;
        }
        public int last_share_timestamp
        {
            get; set;
        }
        public string last_share_coin
        {
            get; set;
        }
        public string wallet
        {
            get; set;
        }
        public int reported_hashrate
        {
            get; set;
        }
    }

    public class ZilInfo
    {
        public long block_num
        {
            get; set;
        }
        public long tx_block_num
        {
            get; set;
        }
        public long[] difficulty
        {
            get; set;
        }
        public DateTime utc_time
        {
            get; set;
        }
        public DateTime? start_time
        {
            get; set;
        }
        public DateTime next_pow_time
        {
            get; set;
        }
    }
}


