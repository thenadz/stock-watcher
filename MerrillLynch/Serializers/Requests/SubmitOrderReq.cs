using System.Runtime.Serialization;
using StockWatcher.MerrillLynch.Serializers.Objects;
using StockWatcher.MerrillLynch.Serializers.Responses;

namespace StockWatcher.MerrillLynch.Serializers.Requests
{
    [DataContract]
    public class SubmitOrderReq : AbstractReq<SubmitOrderResp>
    {
        [DataMember(Name = "equityTradeTicketDisc")]
        public EquityTradeTicketDisc Data { get; set; }

        public override string RequestUri { get; } =
            "https://olui2.fs.ml.com/Equities/UIServices/PilotEquitiesUIService.asmx/SubmitEquityOrder";

        public override string RequestReferer { get; } = "https://olui2.fs.ml.com/Equities/OrderEntry.aspx";
    }
}
