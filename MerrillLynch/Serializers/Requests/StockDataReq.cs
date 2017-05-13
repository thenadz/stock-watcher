using System.Runtime.Serialization;
using StockWatcher.MerrillLynch.Serializers.Responses;

namespace StockWatcher.MerrillLynch.Serializers.Requests
{
    [DataContract]
    public class StockDataReq : AbstractReq<StockDataResp>
    {
        [DataMember(Name = "objRequest")]
        public StockDataReqData Data;

        public override string RequestUri { get; } =
            "https://olui2.fs.ml.com/sve/cse/uiservices/PlatformControlService.asmx/GetQuote";
    }

    [DataContract(Name = "objRequest")]
    public class StockDataReqData
    {
        [DataMember(Name = "InstrumentID")]
        public string InstrumentID;

        [DataMember(Name = "InstrumentIDType")]
        public int InstrumentIDType;

        [DataMember(Name = "Latency")]
        public int Latency;

        [DataMember(Name = "QuoteAction")]
        public int QuoteAction;

        [DataMember(Name = "AdditionalRequest")]
        public StockDataReqData AdditionalRequest;
    }
}
