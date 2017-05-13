using System.Runtime.Serialization;
using StockWatcher.MerrillLynch.Serializers.Responses;

namespace StockWatcher.MerrillLynch.Serializers.Requests
{
    [DataContract]
    public class SubmitEquityOrderReq : AbstractReq<SubmitEquityOrderResp>
    {
        public enum ActionType { Buy, Sell }

        public enum Duration { Day, GoodTillCancelled }

        public enum OrderType { Market, Limit, StopLimit, TrailingStopPercent, TrailingStopDollar, TrailingStopLimitPercent, TrailingStopLimitDollar }

        [DataMember(Name = "equityTradeTicketDisc")]
        public EquityTradeTicketDisc EquityTradeTicketDisc { get; set; }

        public override string RequestUri { get; } =
            "https://olui2.fs.ml.com/Equities/UIServices/PilotEquitiesUIService.asmx/SubmitEquityOrder";
    }

    [DataContract]
    public class EquityTradeTicketDisc
    {
        [DataMember(Name = "equityTradeTicket")]
        public EquityTradeTicket EquityTradeTicket { get; set; }

        [DataMember(Name = "Disclaimers")]
        public string Disclaimers { get; set; }

        [DataMember(Name = "SafePassRequest")]
        public SafePassRequest SafePassRequest { get; set; }

        [DataMember(Name = "ReAuthPassword")]
        public string ReAuthPassword { get; set; }
    }

    [DataContract]
    public class EquityTradeTicket
    {
        [DataMember(Name = "ActionType")]
        public SubmitEquityOrderReq.ActionType ActionType { get; set; }

        [DataMember(Name = "SymbolId")]
        public string SymbolId { get; set; }

        [DataMember(Name = "ExecutionContextIndex")]
        public int ExecutionContextIndex { get; set; }

        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "AccountIdentifier")]
        public Accountidentifier AccountIdentifier { get; set; }

        [DataMember(Name = "Price")]
        public float Price { get; set; }

        [DataMember(Name = "IsAllOrNone")]
        public bool IsAllOrNone { get; set; }

        [DataMember(Name = "Duration")]
        public SubmitEquityOrderReq.Duration Duration { get; set; }

        [DataMember(Name = "OrderType")]
        public SubmitEquityOrderReq.OrderType OrderType { get; set; }

        [DataMember(Name = "SimilarOrderAcknowledged")]
        public bool SimilarOrderAcknowledged { get; set; }

        [DataMember(Name = "StopPrice")]
        public int StopPrice { get; set; }

        [DataMember(Name = "LimitPrice")]
        public int LimitPrice { get; set; }

        [DataMember(Name = "StopParameter")]
        public int StopParameter { get; set; }

        [DataMember(Name = "LimitParameter")]
        public int LimitParameter { get; set; }

        [DataMember(Name = "IsTLTMethodDisplayed")]
        public bool IsTLTMethodDisplayed { get; set; }

        [DataMember(Name = "TLTData")]
        public string TLTData { get; set; }
    }

    [DataContract]
    public class Accountidentifier
    {
        [DataMember(Name = "Type")]
        public string Type { get; set; }

        [DataMember(Name = "Index")]
        public int Index { get; set; }
    }

    [DataContract]
    public class SafePassRequest
    {
        [DataMember(Name = "SafePassFunction")]
        public string SafePassFunction { get; set; }

        [DataMember(Name = "CurrentApplication")]
        public int CurrentApplication { get; set; }

        [DataMember(Name = "ShowSafePassIntroPanel")]
        public bool ShowSafePassIntroPanel { get; set; }

        [DataMember(Name = "ShowSafePassEntryPanel")]
        public bool ShowSafePassEntryPanel { get; set; }

        [DataMember(Name = "SafePassControlClientId")]
        public string SafePassControlClientId { get; set; }

        [DataMember(Name = "PopulateECMSOnlyForSafePassEntryPanel")]
        public bool PopulateECMSOnlyForSafePassEntryPanel { get; set; }

        [DataMember(Name = "SafePassCode")]
        public object SafePassCode { get; set; }

        [DataMember(Name = "IsStubSafePassRequest")]
        public bool IsStubSafePassRequest { get; set; }

        [DataMember(Name = "StubSafePassStatus")]
        public int StubSafePassStatus { get; set; }

        [DataMember(Name = "IntroHeaderRDN")]
        public string IntroHeaderRDN { get; set; }

        [DataMember(Name = "IntroFooterRDN")]
        public string IntroFooterRDN { get; set; }

        [DataMember(Name = "EntryHeaderRDN")]
        public string EntryHeaderRDN { get; set; }

        [DataMember(Name = "EntryMidRDN")]
        public string EntryMidRDN { get; set; }

        [DataMember(Name = "EntryFooterRDN")]
        public string EntryFooterRDN { get; set; }

        [DataMember(Name = "CurrentRUN")]
        public string CurrentRUN { get; set; }

        [DataMember(Name = "IsIntroHeaderContentParamsBased")]
        public bool IsIntroHeaderContentParamsBased { get; set; }

        [DataMember(Name = "IsIntroFooterContentParamsBased")]
        public bool IsIntroFooterContentParamsBased { get; set; }

        [DataMember(Name = "IsEntryHeaderContentParamsBased")]
        public bool IsEntryHeaderContentParamsBased { get; set; }

        [DataMember(Name = "IsEntryFooterContentParamsBased")]
        public bool IsEntryFooterContentParamsBased { get; set; }

        [DataMember(Name = "IsEntryMidContentParamsBased")]
        public bool IsEntryMidContentParamsBased { get; set; }

        [DataMember(Name = "CurrentMode")]
        public int CurrentMode { get; set; }

        [DataMember(Name = "AppFlowType")]
        public object AppFlowType { get; set; }

        [DataMember(Name = "AuthenticationRequested")]
        public bool AuthenticationRequested { get; set; }
    }

}
