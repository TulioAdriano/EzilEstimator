using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStats
{
    public class NbminerAPI
    {
        public static NbminerSummary GetSummary(string endPointIP, int endPointPort = 22333)
        {
            NbminerSummary nbminerSummary = null;
            using (HttpClient httpClient = new HttpClient())
            {
                var request = $"http://{endPointIP}:{endPointPort}/api/v1/status";
                var response = httpClient.GetStringAsync(new Uri(request)).Result;
                nbminerSummary = JsonConvert.DeserializeObject<NbminerSummary>(response);
            }

            return nbminerSummary;
        }

        public static TRexSummary GetTrexSummary(string endPointIP, int endPointPort = 22333)
        {
            TRexSummary trexSummary = new TRexSummary();
            NbminerSummary nbminerSummary = GetSummary(endPointIP, endPointPort);

            trexSummary.hashrate = (int)Math.Round(nbminerSummary.miner.total_hashrate_raw);
            List<Gpu> gpus = new List<Gpu>();
            trexSummary.velocities = new Velocities() { hashrate = new List<long[]>(), power = new List<long[]>() };
            foreach (var gpu in nbminerSummary.miner.devices)
            {
                gpus.Add(new Gpu
                {
                    name = gpu.info.Replace("GeForce ", string.Empty),
                    vendor = gpu.info.Split(' ')[0],
                    hashrate = (int)Math.Round(gpu.hashrate_raw),
                    power = gpu.power,
                    temperature = gpu.temperature,
                    efficiency = $"{(int)Math.Round((gpu.hashrate_raw / gpu.power) / 1000f)}kH/W",
                });;

                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-70).ToUnixTimeSeconds(), trexSummary.hashrate - 1 });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-60).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-50).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-40).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-30).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-20).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.AddSeconds(-10).ToUnixTimeSeconds(), trexSummary.hashrate });
                trexSummary.velocities.hashrate.Add(new long[] { DateTime.Now.ToUnixTimeSeconds(), trexSummary.hashrate });

                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-70).ToUnixTimeSeconds(), gpu.power - 6 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-60).ToUnixTimeSeconds(), gpu.power - 5 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-50).ToUnixTimeSeconds(), gpu.power - 4 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-40).ToUnixTimeSeconds(), gpu.power - 3 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-30).ToUnixTimeSeconds(), gpu.power - 2 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-20).ToUnixTimeSeconds(), gpu.power - 1 });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.AddSeconds(-10).ToUnixTimeSeconds(), gpu.power });
                trexSummary.velocities.power.Add(new long[] { DateTime.Now.ToUnixTimeSeconds(), gpu.power });
            }
            trexSummary.gpus = gpus.ToArray();

            return trexSummary;
        }

    }


    public class NbminerSummary
    {
        public Miner miner
        {
            get; set;
        }
        public int reboot_times
        {
            get; set;
        }
        public int start_time
        {
            get; set;
        }
        public Stratum stratum
        {
            get; set;
        }
        public string version
        {
            get; set;
        }
    }

    public class Miner
    {
        public Device[] devices
        {
            get; set;
        }
        public string total_hashrate
        {
            get; set;
        }
        public string total_hashrate2
        {
            get; set;
        }
        public int total_hashrate2_raw
        {
            get; set;
        }
        public float total_hashrate_raw
        {
            get; set;
        }
        public int total_power_consume
        {
            get; set;
        }
    }

    public class Device
    {
        public int accepted_shares
        {
            get; set;
        }
        public int core_clock
        {
            get; set;
        }
        public int core_utilization
        {
            get; set;
        }
        public int fan
        {
            get; set;
        }
        public string hashrate
        {
            get; set;
        }
        public string hashrate2
        {
            get; set;
        }
        public int hashrate2_raw
        {
            get; set;
        }
        public float hashrate_raw
        {
            get; set;
        }
        public int id
        {
            get; set;
        }
        public string info
        {
            get; set;
        }
        public int invalid_shares
        {
            get; set;
        }
        public int mem_clock
        {
            get; set;
        }
        public int mem_utilization
        {
            get; set;
        }
        public int pci_bus_id
        {
            get; set;
        }
        public int power
        {
            get; set;
        }
        public int rejected_shares
        {
            get; set;
        }
        public int temperature
        {
            get; set;
        }
    }

    public class Stratum
    {
        public int accepted_shares
        {
            get; set;
        }
        public string algorithm
        {
            get; set;
        }
        public string difficulty
        {
            get; set;
        }
        public bool dual_mine
        {
            get; set;
        }
        public int invalid_shares
        {
            get; set;
        }
        public int latency
        {
            get; set;
        }
        public string pool_hashrate_10m
        {
            get; set;
        }
        public string pool_hashrate_24h
        {
            get; set;
        }
        public string pool_hashrate_4h
        {
            get; set;
        }
        public int rejected_shares
        {
            get; set;
        }
        public string url
        {
            get; set;
        }
        public bool use_ssl
        {
            get; set;
        }
        public string user
        {
            get; set;
        }
    }

}
