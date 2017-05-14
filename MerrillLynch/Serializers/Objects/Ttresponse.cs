using System;
using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class Ttresponse
    {
        [DataMember(Name = "EquityTradeTicketCollection")]
        public EquityTradeTicketCollection[] EquityTradeTicketCollection { get; set; }

        [DataMember(Name = "CustomMessage")]
        public object CustomMessage { get; set; }

        [DataMember(Name = "IsSafePassEnabled")]
        public bool IsSafePassEnabled { get; set; }

        [DataMember(Name = "safePassData")]
        public object SafePassData { get; set; }

        [DataMember(Name = "SafePassResponse")]
        public object SafePassResponse { get; set; }

        [DataMember(Name = "AsOfDateTime")]
        public DateTime AsOfDateTime { get; set; }

        [DataMember(Name = "NetOutcome")]
        public int NetOutcome { get; set; }

        [DataMember(Name = "RequiresSimilarOrderAcknowledgement")]
        public bool RequiresSimilarOrderAcknowledgement { get; set; }

        [DataMember(Name = "InvalidNavigationDetected")]
        public bool InvalidNavigationDetected { get; set; }

        [DataMember(Name = "PcoeInput")]
        public object PcoeInput { get; set; }

        [DataMember(Name = "PcoeOutput")]
        public object PcoeOutput { get; set; }

        [DataMember(Name = "SoftBlockFieldViolation")]
        public object SoftBlockFieldViolation { get; set; }

        [DataMember(Name = "MessageList")]
        public MessageList[] MessageList { get; set; }

        [DataMember(Name = "ServiceTraceDetails")]
        public string ServiceTraceDetails { get; set; }
    }
}