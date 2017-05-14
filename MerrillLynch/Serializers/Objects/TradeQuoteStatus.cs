using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class TradeQuoteStatus
    {
        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "StatusMessage")]
        public string StatusMessage { get; set; }

        [DataMember(Name = "InnerException")]
        public string InnerException { get; set; }

        [DataMember(Name = "Type")]
        public int Type { get; set; }
    }
}