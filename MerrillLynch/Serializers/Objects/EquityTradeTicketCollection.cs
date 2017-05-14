using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class EquityTradeTicketCollection
    {
        [DataMember(Name = "ActionType")]
        public int ActionType { get; set; }

        [DataMember(Name = "SymbolId")]
        public string SymbolId { get; set; }

        [DataMember(Name = "ExecutionContextIndex")]
        public int ExecutionContextIndex { get; set; }

        [DataMember(Name = "Quantity")]
        public int Quantity { get; set; }

        [DataMember(Name = "AccountIdentifier")]
        public RespAccountIdentifier AccountIdentifier { get; set; }

        [DataMember(Name = "Price")]
        public float Price { get; set; }

        [DataMember(Name = "IsAllOrNone")]
        public bool IsAllOrNone { get; set; }

        [DataMember(Name = "Duration")]
        public int Duration { get; set; }

        [DataMember(Name = "OrderType")]
        public int OrderType { get; set; }

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

        [DataMember(Name = "OrderRevision")]
        public object OrderRevision { get; set; }

        [DataMember(Name = "SafePass")]
        public int SafePass { get; set; }

        [DataMember(Name = "TradingSessions")]
        public object TradingSessions { get; set; }

        [DataMember(Name = "IsTicketSafePassEnabled")]
        public bool IsTicketSafePassEnabled { get; set; }

        [DataMember(Name = "ChangeOrderInvokerType")]
        public int ChangeOrderInvokerType { get; set; }

        [DataMember(Name = "EquityTradeQuoteData")]
        public object EquityTradeQuoteData { get; set; }

        [DataMember(Name = "Origin")]
        public int Origin { get; set; }

        [DataMember(Name = "Preferences")]
        public object Preferences { get; set; }

        [DataMember(Name = "CommonActionType")]
        public int CommonActionType { get; set; }

        [DataMember(Name = "ProductType")]
        public int ProductType { get; set; }

        [DataMember(Name = "PreviousTLTData")]
        public object PreviousTLTData { get; set; }

        [DataMember(Name = "SymbolSecurityType")]
        public int SymbolSecurityType { get; set; }

        [DataMember(Name = "SafePassRequest")]
        public object SafePassRequest { get; set; }

        [DataMember(Name = "SpecificPortfolioDetail")]
        public object SpecificPortfolioDetail { get; set; }

        [DataMember(Name = "IsCalledSpecificPortfolioDetailsOnServer")]
        public bool IsCalledSpecificPortfolioDetailsOnServer { get; set; }

        [DataMember(Name = "DisClaimersList")]
        public object DisClaimersList { get; set; }

        [DataMember(Name = "Run")]
        public object Run { get; set; }

        [DataMember(Name = "TLTModalPopupData")]
        public object TLTModalPopupData { get; set; }

        [DataMember(Name = "OrderIndex")]
        public int OrderIndex { get; set; }

        [DataMember(Name = "OrderStatus")]
        public int OrderStatus { get; set; }

        [DataMember(Name = "OrderKey")]
        public object OrderKey { get; set; }

        [DataMember(Name = "PreviousQuantity")]
        public int PreviousQuantity { get; set; }

        [DataMember(Name = "ExecutedQuantity")]
        public int ExecutedQuantity { get; set; }

        [DataMember(Name = "CompanyName")]
        public string CompanyName { get; set; }

        [DataMember(Name = "PreviousOrderType")]
        public int PreviousOrderType { get; set; }

        [DataMember(Name = "OriginalOrderType")]
        public object OriginalOrderType { get; set; }

        [DataMember(Name = "PreviousPrice")]
        public int PreviousPrice { get; set; }

        [DataMember(Name = "PreviousLimitPrice")]
        public int PreviousLimitPrice { get; set; }

        [DataMember(Name = "PreviousStopPrice")]
        public int PreviousStopPrice { get; set; }

        [DataMember(Name = "PreviousLimitParameter")]
        public int PreviousLimitParameter { get; set; }

        [DataMember(Name = "PreviousStopParameter")]
        public int PreviousStopParameter { get; set; }

        [DataMember(Name = "PreviousIsAllOrNone")]
        public bool PreviousIsAllOrNone { get; set; }

        [DataMember(Name = "RTBSmam")]
        public bool RTBSmam { get; set; }

        [DataMember(Name = "RTBActionType")]
        public int RTBActionType { get; set; }

        [DataMember(Name = "RemainingQuantity")]
        public int RemainingQuantity { get; set; }

        [DataMember(Name = "PreviousDuration")]
        public int PreviousDuration { get; set; }

        [DataMember(Name = "CalculatedStopPrice")]
        public object CalculatedStopPrice { get; set; }

        [DataMember(Name = "CalculatedLimitPrice")]
        public object CalculatedLimitPrice { get; set; }

        [DataMember(Name = "PriceUpdateDateTime")]
        public object PriceUpdateDateTime { get; set; }

        [DataMember(Name = "EstimatedFees")]
        public int EstimatedFees { get; set; }

        [DataMember(Name = "EstimatedCommission")]
        public int EstimatedCommission { get; set; }

        [DataMember(Name = "EstimatedOrderAmount")]
        public float EstimatedOrderAmount { get; set; }

        [DataMember(Name = "EstimatedTotalAmount")]
        public float EstimatedTotalAmount { get; set; }

        [DataMember(Name = "EstimatedSECFee")]
        public object EstimatedSECFee { get; set; }

        [DataMember(Name = "HandlingCharges")]
        public int HandlingCharges { get; set; }

        [DataMember(Name = "isPriceSpecified")]
        public bool IsPriceSpecified { get; set; }

        [DataMember(Name = "FulfillmentDate")]
        public object FulfillmentDate { get; set; }

        [DataMember(Name = "Version")]
        public object Version { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "EstimatedValuesNotCalculable")]
        public bool EstimatedValuesNotCalculable { get; set; }

        [DataMember(Name = "FCWireCall")]
        public string FCWireCall { get; set; }

        [DataMember(Name = "SequenceNumber")]
        public int SequenceNumber { get; set; }

        [DataMember(Name = "RevisionNumber")]
        public object RevisionNumber { get; set; }

        [DataMember(Name = "IsProfessional")]
        public bool IsProfessional { get; set; }

        [DataMember(Name = "QuoteDataResponse")]
        public object QuoteDataResponse { get; set; }

        [DataMember(Name = "TradeQuoteResponse")]
        public TradeQuoteResponse TradeQuoteResponse { get; set; }

        [DataMember(Name = "TradeQuoteData")]
        public object TradeQuoteData { get; set; }

        [DataMember(Name = "HasOrderConfirmationBeenViewed")]
        public bool HasOrderConfirmationBeenViewed { get; set; }

        [DataMember(Name = "ZDTCallFailed")]
        public bool ZDTCallFailed { get; set; }

        [DataMember(Name = "RemoveWarnings")]
        public bool RemoveWarnings { get; set; }

        [DataMember(Name = "EvaluateSoftBlocks")]
        public bool EvaluateSoftBlocks { get; set; }

        [DataMember(Name = "HoldingData")]
        public object HoldingData { get; set; }

        [DataMember(Name = "QuoteData")]
        public object QuoteData { get; set; }

        [DataMember(Name = "IsBuyTransaction")]
        public bool IsBuyTransaction { get; set; }

        [DataMember(Name = "IsClosingTransaction")]
        public bool IsClosingTransaction { get; set; }

        [DataMember(Name = "IsCoveringShort")]
        public bool IsCoveringShort { get; set; }

        [DataMember(Name = "IsAmendFlow")]
        public bool IsAmendFlow { get; set; }

        [DataMember(Name = "GTCExpirationDate")]
        public object GTCExpirationDate { get; set; }

        [DataMember(Name = "ValidationErrors")]
        public object ValidationErrors { get; set; }

        [DataMember(Name = "OrderExecutionNumber")]
        public string OrderExecutionNumber { get; set; }

        [DataMember(Name = "OrderId")]
        public string OrderId { get; set; }

        [DataMember(Name = "UserSubmissionDate")]
        public object UserSubmissionDate { get; set; }

        [DataMember(Name = "FulfillmentTotal")]
        public object FulfillmentTotal { get; set; }

        [DataMember(Name = "IsTradeEnabled")]
        public bool IsTradeEnabled { get; set; }

        [DataMember(Name = "Platform")]
        public int Platform { get; set; }

        [DataMember(Name = "EvaluateTradeNotAvailable")]
        public bool EvaluateTradeNotAvailable { get; set; }

        [DataMember(Name = "RUNForTradeNotAvailable")]
        public object RUNForTradeNotAvailable { get; set; }

        [DataMember(Name = "ValidationMessages")]
        public object[] ValidationMessages { get; set; }
    }
}