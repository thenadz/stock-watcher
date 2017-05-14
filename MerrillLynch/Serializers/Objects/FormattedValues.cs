using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class FormattedValues
    {
        [DataMember(Name = "ActionTypeDisplayValue")]
        public string ActionTypeDisplayValue { get; set; }

        [DataMember(Name = "SymbolDisplayValue")]
        public string SymbolDisplayValue { get; set; }

        [DataMember(Name = "QuantityDisplayValue")]
        public string QuantityDisplayValue { get; set; }

        [DataMember(Name = "OrderTypeDisplayValue")]
        public string OrderTypeDisplayValue { get; set; }

        [DataMember(Name = "PriceDisplayValue")]
        public string PriceDisplayValue { get; set; }

        [DataMember(Name = "StopPriceDisplayValue")]
        public string StopPriceDisplayValue { get; set; }

        [DataMember(Name = "LimitPriceDisplayValue")]
        public string LimitPriceDisplayValue { get; set; }

        [DataMember(Name = "StopParameterDisplayValue")]
        public object StopParameterDisplayValue { get; set; }

        [DataMember(Name = "LimitParameterDisplayValue")]
        public object LimitParameterDisplayValue { get; set; }

        [DataMember(Name = "CalculatedStopPriceDisplayValue")]
        public string CalculatedStopPriceDisplayValue { get; set; }

        [DataMember(Name = "CalculatedLimitPriceDisplayValue")]
        public string CalculatedLimitPriceDisplayValue { get; set; }

        [DataMember(Name = "IsAllOrNoneDisplayValue")]
        public string IsAllOrNoneDisplayValue { get; set; }

        [DataMember(Name = "DurationTypeDisplayValue")]
        public string DurationTypeDisplayValue { get; set; }

        [DataMember(Name = "EstimatedOrderAmountDisplayValue")]
        public string EstimatedOrderAmountDisplayValue { get; set; }

        [DataMember(Name = "HandlingChargesDisplayValue")]
        public string HandlingChargesDisplayValue { get; set; }

        [DataMember(Name = "EstimatedFeesDisplayValue")]
        public string EstimatedFeesDisplayValue { get; set; }

        [DataMember(Name = "EstimatedCommissionDisplayValue")]
        public string EstimatedCommissionDisplayValue { get; set; }

        [DataMember(Name = "EstimatedTotalAmountDisplayValue")]
        public string EstimatedTotalAmountDisplayValue { get; set; }

        [DataMember(Name = "AsOfDateTimeDisplayValue")]
        public string AsOfDateTimeDisplayValue { get; set; }
    }
}