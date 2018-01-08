using minergateapi.Client;
using Newtonsoft.Json.Linq;

namespace minergateapi
{
    internal class Program
    {
        private static readonly MinergateClient MgClient = new MinergateClient();

        private static void Main(string[] args)
        {
            /* Public */

            var profitRating = MgClient.CheckProfitRating();
            var topHashRate = MgClient.CheckTopHashRate();
            var byteCoinBlockChainInfo = MgClient.CheckBlockChainInfo(Coins.ByteCoin);

            /* Requires Authorization */

            var balance = MgClient.CheckBalance();
            var workers = MgClient.CheckWorkers();
            var miningStats = MgClient.CheckMiningStats();
            var transfers = MgClient.CheckTransfers(Coins.ByteCoin);
            var withdrawals = MgClient.CheckWithdrawals(Coins.ByteCoin);
            var affiliateLinks = MgClient.CheckAffiliateLinks();
            var affiliates = MgClient.CheckAffiliates();
            var affiliateProfit = MgClient.CheckAffiliateProfit();
            var invoices = MgClient.CheckInvoices();
            var nickName = MgClient.ReturnNickname();
        }

    }
}
