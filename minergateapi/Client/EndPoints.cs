namespace minergateapi.Client
{
    public static class EndPoints
    {
        /* Public */
        public static string ProfitRating = "/pool/profit-rating";
        public static string TopHashRate = "/pool/top/hashrate";

        public static string BlockChainInfo(string coin)
        {
            return "/" + coin + "/status";
        }

        /* Requires Authorization */
        public static string Balance = "/balance";
        public static string Workers = "/workers";
        public static string MiningStats = "/mining/stats";
        public static string AffiliateLinks = "/affiliate/links";
        public static string Affiliates = "/affiliate/childrens";
        public static string AffiliateProfit = "/affiliate/profit";
        public static string Invoices = "/invoices";
        public static string Nickname = "/profile/nickname";

        public static string Transfers(string coin)
        {
            return "/transfers/" + coin;
        }

        public static string Withdrawals(string coin)
        {
            return "/withdrawals/" + coin;
        }
    }
}