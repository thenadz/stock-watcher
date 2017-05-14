using System.ComponentModel;
using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class EquityTradeTicketDisc
    {
        public enum ActionType { Buy = 1, Sell }

        public enum Duration { Day = 1, GoodTillCancelled }

        public enum OrderType
        {
            [Description("Limit")]
            Limit = 0,

            [Description("Market")]
            Market = 1,

            [Description("Stop Quote")]
            Stop = 2,

            [Description("Stop Quote Limit")]
            StopLimit = 6,

            [Description("Trailing Stop Quote ($)")]
            TrailingStopDollar = 7,

            [Description("Trailing Stop Quote (%)")]
            TrailingStopPercent = 8,

            [Description("Trailing Stop Quote Limit ($)")]
            TrailingStopLimitDollar = 9,

            [Description("Trailing Stop Quote Limit (%)")]
            TrailingStopLimitPercent = 10
        }

        [DataMember(Name = "equitytradeticket")]
        public EquityTradeTicket EquityTradeTicket { get; set; }

        [DataMember(Name = "Disclaimers")]
        public string Disclaimers { get; set; }

        [DataMember(Name = "SafePassRequest")]
        public SafePassRequest SafePassRequest { get; set; }

        [DataMember(Name = "ReAuthPassword", EmitDefaultValue = false)]
        public string ReAuthPassword { get; set; }
    }
}