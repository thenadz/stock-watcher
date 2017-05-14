using System;
using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class EquityTradeTicket
    {
        [DataMember(Name = "ActionType")]
        private string actionType = EquityTradeTicketDisc.ActionType.Sell.ToString();

        public EquityTradeTicketDisc.ActionType ActionType
        {
            get
            {
                return (EquityTradeTicketDisc.ActionType)Enum.Parse(typeof(EquityTradeTicketDisc.ActionType), actionType);
            }

            set
            {
                actionType = value.ToString();
            }
        }

        [DataMember(Name = "SymbolId")]
        public string SymbolId { get; set; }

        [DataMember(Name = "ExecutionContextIndex")]
        public int ExecutionContextIndex { get; set; }

        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "AccountIdentifier")]
        public ReqAccountIdentifier AccountIdentifier { get; set; }

        [DataMember(Name = "Price")]
        public float Price { get; set; }

        [DataMember(Name = "IsAllOrNone")]
        public bool IsAllOrNone { get; set; }

        [DataMember(Name = "Duration")]
        private string duration = EquityTradeTicketDisc.Duration.Day.ToString();

        public EquityTradeTicketDisc.Duration Duration
        {
            get
            {
                return (EquityTradeTicketDisc.Duration)Enum.Parse(typeof(EquityTradeTicketDisc.Duration), duration);
            }

            set
            {
                duration = value.ToString();
            }
        }

        [DataMember(Name = "OrderType")]
        private string orderType = EquityTradeTicketDisc.OrderType.Market.ToString();

        public EquityTradeTicketDisc.OrderType OrderType
        {
            get
            {
                return (EquityTradeTicketDisc.OrderType)Enum.Parse(typeof(EquityTradeTicketDisc.OrderType), orderType);
            }

            set
            {
                orderType = value.ToString();
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