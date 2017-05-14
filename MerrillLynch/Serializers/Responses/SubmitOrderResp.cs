using System.Runtime.Serialization;
using StockWatcher.MerrillLynch.Serializers.Objects;

namespace StockWatcher.MerrillLynch.Serializers.Responses
{
    [DataContract]
    public class SubmitOrderResp
    {
        [DataMember(Name = "d")]
        public TradeTicketPreview Data { get; set; }
    }
}
