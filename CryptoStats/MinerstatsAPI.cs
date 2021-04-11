using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStats
{
    public class MinerstatsAPI
    {
        public CoinInfo GetCoinInfo(string coin)
        {
            CoinInfo coinInfo = null;
            using (HttpClient httpClient = new HttpClient())
            {
                var request = $"https://api.minerstat.com/v2/coins?list={coin}";
                var response = httpClient.GetStringAsync(new Uri(request)).Result;
                coinInfo = JsonConvert.DeserializeObject<List<CoinInfo>>(response).FirstOrDefault();
            }

            return coinInfo;
        }

        public List<CoinInfo> GetCoinInfo(string[] coins)
        {
            List<CoinInfo> coinInfo = new List<CoinInfo>();
            using (HttpClient httpClient = new HttpClient())
            {
                var request = $"https://api.minerstat.com/v2/coins?list={String.Join(",", coins)}";
                var response = httpClient.GetStringAsync(new Uri(request)).Result;
                coinInfo = JsonConvert.DeserializeObject<List<CoinInfo>>(response);
            }

            return coinInfo;
        }

        public CoinInfo GetCoinHistory(string coin = "ETH", string algo = "Ethash")
        {
            CoinInfo coinInfo = null;
            using (HttpClient httpClient = new HttpClient())
            {
                var request = $"https://api.minerstat.com/v2/coins-history?coin={coin}&algo={algo}";
                var response = httpClient.GetStringAsync(new Uri(request)).Result;
                var coinsHistoryResponse = JObject.Parse(response);
                long oneDay = DateTime.UtcNow.AddDays(-1).ToUnixTimeSeconds();
                var items = coinsHistoryResponse["ETH"].Children().Where(c => Convert.ToInt64(((JProperty)c).Name) >= oneDay).Children();
                var result = items.Average(c => (decimal)c[0]);

                coinInfo = new CoinInfo()
                {
                    coin = coin,
                    algorithm = algo,
                    network_hashrate = (long)items.Average(c => (decimal)c[1]),
                    reward = (float)items.Average(c => Convert.ToDouble(c[2]))
                };
            }

            return coinInfo;
        }
    }

    public class CoinInfo
    {
        public string id
        {
            get; set;
        }
        public string coin
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public string type
        {
            get; set;
        }
        public string algorithm
        {
            get; set;
        }
        public long network_hashrate
        {
            get; set;
        }
        public long difficulty
        {
            get; set;
        }
        public float reward
        {
            get; set;
        }
        public string reward_unit
        {
            get; set;
        }
        public float reward_block
        {
            get; set;
        }
        public float price
        {
            get; set;
        }
        public float volume
        {
            get; set;
        }
        public int updated
        {
            get; set;
        }
    }

}
