using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStats
{
    public class GMinerAPI
    {
        public static GMinerSummary GetSummary(string endPointIP, int endPointPort = 22333)
        {
            GMinerSummary gMinerSummary = null;
            using (HttpClient httpClient = new HttpClient())
            {
                var request = $"http://{endPointIP}:{endPointPort}/stat";
                var response = httpClient.GetStringAsync(new Uri(request)).Result;
                gMinerSummary = JsonConvert.DeserializeObject<GMinerSummary>(response);
            }

            return gMinerSummary;
        }

        public static TRexSummary GetTrexSummary(string endPointIP, int endPointPort = 10050)
        {
            TRexSummary trexSummary = new TRexSummary();
            GMinerSummary gMinerSummary = GetSummary(endPointIP, endPointPort);

            trexSummary.hashrate = gMinerSummary.devices.Sum(c => c.speed);
            List<Gpu> gpus = new List<Gpu>();
            trexSummary.velocities = new Velocities() { hashrate = new List<long[]>(), power = new List<long[]>() };
            foreach (var gpu in gMinerSummary.devices)
            {
                gpus.Add(new Gpu
                {
                    name = gpu.name.Replace("GeForce ", string.Empty),
                    vendor = string.Empty,
                    hashrate = gpu.speed,
                    power = gpu.power_usage,
                    temperature = gpu.temperature,
                    memory_temperature= gpu.memory_temperature,
                    efficiency = $"{(int)Math.Round((gpu.speed / gpu.power_usage) / 1000f)}kH/W",
                });
                ;

                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-70).ToUnixTimeSeconds(), trexSummary.hashrate - 1 });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-60).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-50).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-40).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-30).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-20).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-10).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.ToUnixTimeSeconds(), trexSummary.hashrate });

                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-70).ToUnixTimeSeconds(), gpu.power_usage - 6 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-60).ToUnixTimeSeconds(), gpu.power_usage - 5 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-50).ToUnixTimeSeconds(), gpu.power_usage - 4 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-40).ToUnixTimeSeconds(), gpu.power_usage - 3 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-30).ToUnixTimeSeconds(), gpu.power_usage - 2 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-20).ToUnixTimeSeconds(), gpu.power_usage - 1 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-10).ToUnixTimeSeconds(), gpu.power_usage });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.ToUnixTimeSeconds(), gpu.power_usage });
            }
            trexSummary.gpus = gpus.ToArray();

            return trexSummary;
        }

    }

    public class GMinerSummary
    {
        public string miner
        {
            get; set;
        }
        public int uptime
        {
            get; set;
        }
        public string server
        {
            get; set;
        }
        public string user
        {
            get; set;
        }
        public bool extended_share_info
        {
            get; set;
        }
        public float shares_per_minute
        {
            get; set;
        }
        public int pool_speed
        {
            get; set;
        }
        public string algorithm
        {
            get; set;
        }
        public float electricity
        {
            get; set;
        }
        public int total_accepted_shares
        {
            get; set;
        }
        public int total_rejected_shares
        {
            get; set;
        }
        public int total_stale_shares
        {
            get; set;
        }
        public int total_invalid_shares
        {
            get; set;
        }
        public GPUDevice[] devices
        {
            get; set;
        }
        public int speed_rate_precision
        {
            get; set;
        }
        public string speed_unit
        {
            get; set;
        }
        public string power_unit
        {
            get; set;
        }
    }

    public class GPUDevice
    {
        public int gpu_id
        {
            get; set;
        }
        public string bus_id
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public int speed
        {
            get; set;
        }
        public int accepted_shares
        {
            get; set;
        }
        public int rejected_shares
        {
            get; set;
        }
        public int stale_shares
        {
            get; set;
        }
        public int invalid_shares
        {
            get; set;
        }
        public int fan
        {
            get; set;
        }
        public int temperature
        {
            get; set;
        }
        public int temperature_limit
        {
            get; set;
        }
        public int memory_temperature
        {
            get; set;
        }
        public int memory_temperature_limit
        {
            get; set;
        }
        public int core_clock
        {
            get; set;
        }
        public int memory_clock
        {
            get; set;
        }
        public int power_usage
        {
            get; set;
        }
    }

}
