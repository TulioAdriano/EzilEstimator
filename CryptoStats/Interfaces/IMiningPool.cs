using System.Collections.Generic;

namespace CryptoStats
{
    public interface IMiningPool
    {
        bool CanPageRewards
        {
            get;
        }

        MiningBalance GetBalances(Wallet wallet);
        MiningCurrentStats GetCurrentStats(Wallet wallet, bool includeReported = true);
        List<MiningStats> GetHistoricalStats(Wallet wallet, int timeFrame);
        List<MiningReward> GetRewards(Wallet wallet, int page = 1, int entries = 10, string coin = "eth");
    }
}