using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class EquityTradeTicketDisc
    {
        public enum ActionType { Buy, Sell }

        public enum Duration { Day, GoodTillCancelled }

        public enum OrderType { Market, Limit, StopLimit, TrailingStopPercent, TrailingStopDollar, TrailingStopLimitPercent, TrailingStopLimitDollar }

        [DataMember(Name = "equityTradeTicket")]
        public EquityTradeTicket EquityTradeTicket { get; set; }

        [DataMember(Name = "Disclaimers")]
        public string Disclaimers { get; set; }

        [DataMember(Name = "SafePassRequest")]
        public SafePassRequest SafePassRequest { get; set; }

        [DataMember(Name = "ReAuthPassword")]
        public string ReAuthPassword { get; set; }
    }
}