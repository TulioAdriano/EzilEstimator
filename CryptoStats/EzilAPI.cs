﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CryptoStats
{
    public class EzilAPI
    {
        public string ethAddress
        {
            get;
        }
        public string zilAddress
        {
            get;
        }

        public EzilAPI(string ethAddress, string zilAddress)
        {
            this.ethAddress = ethAddress;
            this.zilAddress = zilAddress;
        }

        public string GetRewards(int page = 1, int entries = 10, string coin = "eth")
        {
            string response = string.Empty;

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://billing.ezil.me/rewards/{ethAddress}.{zilAddress}?page={page}&per_page={entries}&coin={coin}";
                response = httpClient.GetStringAsync(new Uri(request)).Result;
            }

            return response;
        }
        public string GetBalances()
        {
            string response = string.Empty;

            using (HttpClient httpClient = new HttpClient())
            {
                string request = $"https://billing.ezil.me/balances/{ethAddress}.{zilAddress}";
                response = httpClient.GetStringAsync(new Uri(request)).Result;
            }

            return response;
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

}

