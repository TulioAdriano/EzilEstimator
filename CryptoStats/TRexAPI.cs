using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStats
{
    public class TRexAPI
    {
        public static TRexSummary GetSummary(string endPointIP, int endPointPort = 4067)
        {
            TRexSummary trexSummary = null;
            using (HttpClient httpClient = new HttpClient())
            {
                var request = $"http://{endPointIP}:{endPointPort}/summary";
                var response = httpClient.GetStringAsync(new Uri(request)).Result;
                trexSummary = JsonConvert.DeserializeObject<TRexSummary>(response);
            }

            return trexSummary;
        }
        public static TRexSummary GetFullSummary(string endPointIP, int endPointPort = 4067)
        {
            TRexSummary trexSummary = null;
            using (HttpClient httpClient = new HttpClient())
            {
                var request = $"http://{endPointIP}:{endPointPort}/summary?last-stat-ts=0";
                var response = httpClient.GetStringAsync(new Uri(request)).Result;
                trexSummary = JsonConvert.DeserializeObject<TRexSummary>(response);
            }

            return trexSummary;
        }
    }

    public class TRexSummary
    {
        public int accepted_count
        {
            get; set;
        }
        public Active_Pool active_pool
        {
            get; set;
        }
        public string algorithm
        {
            get; set;
        }
        public string api
        {
            get; set;
        }
        public string build_date
        {
            get; set;
        }
        public string coin
        {
            get; set;
        }
        public string cuda
        {
            get; set;
        }
        public string description
        {
            get; set;
        }
        public float difficulty
        {
            get; set;
        }
        public string driver
        {
            get; set;
        }
        public int gpu_total
        {
            get; set;
        }
        public Gpu[] gpus
        {
            get; set;
        }
        public int hashrate
        {
            get; set;
        }
        public int hashrate_day
        {
            get; set;
        }
        public int hashrate_hour
        {
            get; set;
        }
        public int hashrate_minute
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public string os
        {
            get; set;
        }
        public int rejected_count
        {
            get; set;
        }
        public string revision
        {
            get; set;
        }
        public float sharerate
        {
            get; set;
        }
        public float sharerate_average
        {
            get; set;
        }
        public int solved_count
        {
            get; set;
        }
        public Stat_By_Gpu[] stat_by_gpu
        {
            get; set;
        }
        public int success
        {
            get; set;
        }
        public int ts
        {
            get; set;
        }
        public int uptime
        {
            get; set;
        }
        public Velocities velocities
        {
            get; set;
        }
        public string version
        {
            get; set;
        }
        public Watchdog_Stat watchdog_stat
        {
            get; set;
        }
    }

    public class Active_Pool
    {
        public string difficulty
        {
            get; set;
        }
        public int ping
        {
            get; set;
        }
        public int retries
        {
            get; set;
        }
        public string url
        {
            get; set;
        }
        public string user
        {
            get; set;
        }
    }

    public class Velocities
    {
        public List<long[]> hashrate
        {
            get; set;
        }
        public List<long[]> power
        {
            get; set;
        }
    }

    public class Watchdog_Stat
    {
        public string backup
        {
            get; set;
        }
        public bool built_in
        {
            get; set;
        }
        public long startup_ts
        {
            get; set;
        }
        public int total_restarts
        {
            get; set;
        }
        public int uptime
        {
            get; set;
        }
        public string wd_version
        {
            get; set;
        }
    }

    public class Gpu
    {
        public int dag_build_mode
        {
            get; set;
        }
        public int device_id
        {
            get; set;
        }
        public string efficiency
        {
            get; set;
        }
        public int fan_speed
        {
            get; set;
        }
        public int gpu_id
        {
            get; set;
        }
        public int gpu_user_id
        {
            get; set;
        }
        public int hashrate
        {
            get; set;
        }
        public int hashrate_day
        {
            get; set;
        }
        public int hashrate_hour
        {
            get; set;
        }
        public int hashrate_instant
        {
            get; set;
        }
        public int hashrate_minute
        {
            get; set;
        }
        public float intensity
        {
            get; set;
        }
        public bool low_load
        {
            get; set;
        }
        public int memory_temperature
        {
            get; set;
        }
        public int mtweak
        {
            get; set;
        }
        public string name
        {
            get; set;
        }
        public int pci_bus
        {
            get; set;
        }
        public int pci_domain
        {
            get; set;
        }
        public int pci_id
        {
            get; set;
        }
        public bool potentially_unstable
        {
            get; set;
        }
        public int power
        {
            get; set;
        }
        public int power_avr
        {
            get; set;
        }
        public int temperature
        {
            get; set;
        }
        public string uuid
        {
            get; set;
        }
        public string vendor
        {
            get; set;
        }
    }

    public class Stat_By_Gpu
    {
        public int accepted_count
        {
            get; set;
        }
        public int rejected_count
        {
            get; set;
        }
        public int solved_count
        {
            get; set;
        }
    }
}
