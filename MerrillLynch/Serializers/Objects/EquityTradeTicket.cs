using System;
using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class EquityTradeTicket
    {
        private readonly bool enumsAsInts;

        public EquityTradeTicket(bool enumsAsInts)
        {
            this.enumsAsInts = enumsAsInts;

            // Default values least likely to get people into trouble when learning the library
            ActionType = EquityTradeTicketDisc.ActionType.Sell;
            Duration = EquityTradeTicketDisc.Duration.Day;
            OrderType = EquityTradeTicketDisc.OrderType.Market;
        }

        [DataMember(Name = "ActionType")]
        private object actionType;

        public EquityTradeTicketDisc.ActionType ActionType
        {
            get
            {
                return (EquityTradeTicketDisc.ActionType)(enumsAsInts ? actionType : Enum.Parse(typeof(EquityTradeTicketDisc.ActionType), (string)actionType));
            }

            set
            {
                actionType = enumsAsInts ? (object)(int)value : value.ToString();
            }
        }

        [DataMember(Name = "SymbolId")]
        public string SymbolId { get; set; }

        [DataMember(Name = "ExecutionContextIndex")]
        public object ExecutionContextIndex { get; set; }

        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "AccountIdentifier")]
        public ReqAccountIdentifier AccountIdentifier { get; set; }

        [DataMember(Name = "Price")]
        public int Price { get; set; }

        [DataMember(Name = "IsAllOrNone")]
        public bool IsAllOrNone { get; set; }

        [DataMember(Name = "Duration")]
        private object duration;

        public EquityTradeTicketDisc.Duration Duration
        {
            get
            {
                return (EquityTradeTicketDisc.Duration)(enumsAsInts ? duration : Enum.Parse(typeof(EquityTradeTicketDisc.Duration), (string)duration));
            }

            set
            {
                duration = enumsAsInts ? (object)(int)value : value.ToString();
            }
        }

        [DataMember(Name = "OrderType")]
        private object orderType;

        public EquityTradeTicketDisc.OrderType OrderType
        {
            get
            {
                return (EquityTradeTicketDisc.OrderType)(enumsAsInts ? orderType : Enum.Parse(typeof(EquityTradeTicketDisc.OrderType), (string)orderType));
            }

            set
            {
                orderType = enumsAsInts ? (object)(int)value : value.ToString();
            }
        }

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
}