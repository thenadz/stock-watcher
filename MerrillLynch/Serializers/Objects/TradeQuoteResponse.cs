using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class TradeQuoteResponse
    {
        [DataMember(Name = "TradeQuoteMapData")]
        public object[] TradeQuoteMapData { get; set; }

        [DataMember(Name = "TradeQuoteTemplate")]
        public TradeQuoteTemplate TradeQuoteTemplate { get; set; }

        [DataMember(Name = "TradeQuoteStatus")]
        public TradeQuoteStatus TradeQuoteStatus { get; set; }

        [DataMember(Name = "TradeQuoteData")]
        public TradeQuoteData TradeQuoteData { get; set; }
    }
}