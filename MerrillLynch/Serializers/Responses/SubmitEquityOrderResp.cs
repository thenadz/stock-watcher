using System;
using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Responses
{
    [DataContract]
    public class SubmitEquityOrderResp
    {
        [DataMember(Name = "d")]
        public SubmitEquityOrderRespData Data { get; set; }
    }

    [DataContract]
    public class SubmitEquityOrderRespData
    {
        [DataMember(Name = "__type")]
        public string __type { get; set; }

        [DataMember(Name = "AsofDateString")]
        public object AsofDateString { get; set; }

        [DataMember(Name = "SMCTaxLotOrderData")]
        public object SMCTaxLotOrderData { get; set; }

        [DataMember(Name = "CallSMCThroughAjax")]
        public bool CallSMCThroughAjax { get; set; }

        [DataMember(Name = "SMCResponseErrorWarning")]
        public object SMCResponseErrorWarning { get; set; }

        [DataMember(Name = "SMCRequestErrorWarning")]
        public object SMCRequestErrorWarning { get; set; }

        [DataMember(Name = "AjaxTimeoutValueForSMC")]
        public int AjaxTimeoutValueForSMC { get; set; }

        [DataMember(Name = "SMCResponse")]
        public object SMCResponse { get; set; }

        [DataMember(Name = "FormattedValues")]
        public FormattedValues FormattedValues { get; set; }

        [DataMember(Name = "ReAuthResponse")]
        public object ReAuthResponse { get; set; }

        [DataMember(Name = "ECMSSetDefaultContent")]
        public string ECMSSetDefaultContent { get; set; }

        [DataMember(Name = "ttresponse")]
        public Ttresponse Ttresponse { get; set; }

        [DataMember(Name = "tradeAccontName")]
        public string TradeAccontName { get; set; }

        [DataMember(Name = "tradeAccontNumber")]
        public string TradeAccontNumber { get; set; }

        [DataMember(Name = "IsRPOverlayLinkVisible")]
        public bool IsRPOverlayLinkVisible { get; set; }

        [DataMember(Name = "RDN_PageIntro")]
        public string RDN_PageIntro { get; set; }

        [DataMember(Name = "RDN_Disclaimer")]
        public string RDN_Disclaimer { get; set; }

        [DataMember(Name = "RDN_MarketingSpot_320")]
        public string RDN_MarketingSpot_320 { get; set; }

        [DataMember(Name = "SafePassResponse")]
        public object SafePassResponse { get; set; }
    }

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
        public AccountIdentifier AccountIdentifier { get; set; }

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

    [DataContract]
    public class AccountIdentifier
    {
        [DataMember(Name = "_managedAcctCode")]
        public object _managedAcctCode { get; set; }

        [DataMember(Name = "_managedInd")]
        public bool _managedInd { get; set; }

        [DataMember(Name = "_managerName")]
        public string _managerName { get; set; }

        [DataMember(Name = "_managerStyle")]
        public string _managerStyle { get; set; }

        [DataMember(Name = "FAVisibilityInd")]
        public bool FAVisibilityInd { get; set; }

        [DataMember(Name = "LIIAInd")]
        public object LIIAInd { get; set; }

        [DataMember(Name = "OAInd")]
        public object OAInd { get; set; }

        [DataMember(Name = "TradeAccessInd")]
        public string TradeAccessInd { get; set; }

        [DataMember(Name = "FXTraitInd")]
        public bool FXTraitInd { get; set; }

        [DataMember(Name = "ConfidentialInd")]
        public bool ConfidentialInd { get; set; }

        [DataMember(Name = "NFSConversionInd")]
        public bool NFSConversionInd { get; set; }

        [DataMember(Name = "Nickname")]
        public object Nickname { get; set; }

        [DataMember(Name = "Entity")]
        public string Entity { get; set; }

        [DataMember(Name = "ProductCode")]
        public string ProductCode { get; set; }

        [DataMember(Name = "ProductSubCode")]
        public object ProductSubCode { get; set; }

        [DataMember(Name = "MarginInd")]
        public bool MarginInd { get; set; }

        [DataMember(Name = "LoanInd")]
        public bool LoanInd { get; set; }

        [DataMember(Name = "BusinessInd")]
        public bool BusinessInd { get; set; }

        [DataMember(Name = "PledgeInd")]
        public bool PledgeInd { get; set; }

        [DataMember(Name = "ChargeCards")]
        public object ChargeCards { get; set; }

        [DataMember(Name = "ManagedAcctCode")]
        public object ManagedAcctCode { get; set; }

        [DataMember(Name = "ManagedInd")]
        public bool ManagedInd { get; set; }

        [DataMember(Name = "ManagerName")]
        public string ManagerName { get; set; }

        [DataMember(Name = "ManagerStyle")]
        public string ManagerStyle { get; set; }

        [DataMember(Name = "AccountRestriction")]
        public AccountRestriction AccountRestriction { get; set; }

        [DataMember(Name = "ThirdPartyInd")]
        public object ThirdPartyInd { get; set; }

        [DataMember(Name = "ThirdPartyIdentifier")]
        public object ThirdPartyIdentifier { get; set; }

        [DataMember(Name = "AccessMask")]
        public string AccessMask { get; set; }

        [DataMember(Name = "AssetLiabilityInd")]
        public int AssetLiabilityInd { get; set; }

        [DataMember(Name = "TraitsEx")]
        public Traitsex TraitsEx { get; set; }

        [DataMember(Name = "Traits")]
        public Trait[] Traits { get; set; }

        [DataMember(Name = "DisplayInfo")]
        public DisplayInfo DisplayInfo { get; set; }

        [DataMember(Name = "AccountTypeForNavigationMatrix")]
        public string AccountTypeForNavigationMatrix { get; set; }

        [DataMember(Name = "AccountStatusForNavigationMatrix")]
        public string AccountStatusForNavigationMatrix { get; set; }

        [DataMember(Name = "FAVisibilityIndicator")]
        public bool FAVisibilityIndicator { get; set; }

        [DataMember(Name = "Identifier")]
        public Identifier Identifier { get; set; }

        [DataMember(Name = "IsActive")]
        public bool IsActive { get; set; }

        [DataMember(Name = "OpenDate")]
        public DateTime OpenDate { get; set; }

        [DataMember(Name = "OwnershipType")]
        public string OwnershipType { get; set; }

        [DataMember(Name = "Index")]
        public int Index { get; set; }

        [DataMember(Name = "EncryptedToken")]
        public object EncryptedToken { get; set; }

        [DataMember(Name = "AcctRelTypCd")]
        public string AcctRelTypCd { get; set; }
    }

    [DataContract]
    public class AccountRestriction
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Value")]
        public string Value { get; set; }
    }

    [DataContract]
    public class Traitsex
    {
        [DataMember(Name = "AcctNm")]
        public string AcctNm { get; set; }

        [DataMember(Name = "AcctOwnStyleCd")]
        public string AcctOwnStyleCd { get; set; }

        [DataMember(Name = "VisaDate")]
        public string VisaDate { get; set; }

        [DataMember(Name = "AcctUniqueId")]
        public string AcctUniqueId { get; set; }

        [DataMember(Name = "AcctNickNmTx")]
        public string AcctNickNmTx { get; set; }

        [DataMember(Name = "TraitStatus")]
        public string TraitStatus { get; set; }

        [DataMember(Name = "CRFStatus")]
        public string CRFStatus { get; set; }

        [DataMember(Name = "AdvisoryAccountTypeCd")]
        public string AdvisoryAccountTypeCd { get; set; }

        [DataMember(Name = "AdvisoryAccountTypeDesc")]
        public string AdvisoryAccountTypeDesc { get; set; }

        [DataMember(Name = "WireCall")]
        public string WireCall { get; set; }

        [DataMember(Name = "ProducerId")]
        public string ProducerId { get; set; }

        [DataMember(Name = "OwnerType")]
        public string OwnerType { get; set; }

        [DataMember(Name = "OwnerDescription")]
        public string OwnerDescription { get; set; }

        [DataMember(Name = "BusOwnerDesc")]
        public string BusOwnerDesc { get; set; }

        [DataMember(Name = "BusOwnerType")]
        public string BusOwnerType { get; set; }

        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "AddressLine1")]
        public string AddressLine1 { get; set; }

        [DataMember(Name = "AddressLine2")]
        public string AddressLine2 { get; set; }

        [DataMember(Name = "AddressLine3")]
        public string AddressLine3 { get; set; }

        [DataMember(Name = "AddressLine4")]
        public string AddressLine4 { get; set; }

        [DataMember(Name = "AddressLine5")]
        public string AddressLine5 { get; set; }

        [DataMember(Name = "AddressLine6")]
        public string AddressLine6 { get; set; }

        [DataMember(Name = "AccountTIN")]
        public string AccountTIN { get; set; }

        [DataMember(Name = "AccountStateOfResidence")]
        public string AccountStateOfResidence { get; set; }

        [DataMember(Name = "mlTraitServiceType")]
        public string MlTraitServiceType { get; set; }

        [DataMember(Name = "mlTraitPriorityInd")]
        public string MlTraitPriorityInd { get; set; }

        [DataMember(Name = "mlTraitVisaGold")]
        public string MlTraitVisaGold { get; set; }

        [DataMember(Name = "mlTraitVisaClassic")]
        public string MlTraitVisaClassic { get; set; }

        [DataMember(Name = "mlTraitBusinessVisa")]
        public string MlTraitBusinessVisa { get; set; }

        [DataMember(Name = "mlTraitVisa")]
        public string MlTraitVisa { get; set; }

        [DataMember(Name = "mlTraitSignatureVisa")]
        public string MlTraitSignatureVisa { get; set; }

        [DataMember(Name = "mlTraitCheckFree")]
        public string MlTraitCheckFree { get; set; }

        [DataMember(Name = "mlTraitMLOL")]
        public string mlTraitMLOL { get; set; }

        [DataMember(Name = "mlTraitFTS")]
        public string mlTraitFTS { get; set; }

        [DataMember(Name = "mlTraitDirectDeposit")]
        public string MlTraitDirectDeposit { get; set; }

        [DataMember(Name = "mlTraitQuiken")]
        public string MlTraitQuiken { get; set; }

        [DataMember(Name = "mlTraitBeyondBanking")]
        public string MlTraitBeyondBanking { get; set; }

        [DataMember(Name = "VisaPartNumber")]
        public string VisaPartNumber { get; set; }

        [DataMember(Name = "mlTraitGlobalGold")]
        public string MlTraitGlobalGold { get; set; }

        [DataMember(Name = "mlTraitCoeInd")]
        public string MlTraitCoeInd { get; set; }

        [DataMember(Name = "mlTraitCoeStatus")]
        public string MlTraitCoeStatus { get; set; }

        [DataMember(Name = "mlTraitCoeEmpInd")]
        public string MlTraitCoeEmpInd { get; set; }

        [DataMember(Name = "mlTraitOwnerGroup")]
        public string MlTraitOwnerGroup { get; set; }

        [DataMember(Name = "mlTraitTEFRA")]
        public string MlTraitTEFRA { get; set; }

        [DataMember(Name = "mlTraitCashMng")]
        public string MlTraitCashMng { get; set; }

        [DataMember(Name = "mlTraitAccountCode")]
        public string MlTraitAccountCode { get; set; }

        [DataMember(Name = "mlTraitAccChecks")]
        public string MlTraitAccChecks { get; set; }

        [DataMember(Name = "mlTraitIOoeInd")]
        public string MlTraitIOoeInd { get; set; }

        [DataMember(Name = "mlTraitMfundOeInd")]
        public string MlTraitMfundOeInd { get; set; }

        [DataMember(Name = "mlTraitCdOeInd")]
        public string MlTraitCdOeInd { get; set; }

        [DataMember(Name = "mlTraitCorpBondOeInd")]
        public string MlTraitCorpBondOeInd { get; set; }

        [DataMember(Name = "mlTraitMuniBondOeInd")]
        public string MlTraitMuniBondOeInd { get; set; }

        [DataMember(Name = "mlTraitZeroCoupOeInd")]
        public string MlTraitZeroCoupOeInd { get; set; }

        [DataMember(Name = "mlTraitMortBackOeInd")]
        public string MlTraitMortBackOeInd { get; set; }

        [DataMember(Name = "mlTraitUsTreasOeInd")]
        public string MlTraitUsTreasOeInd { get; set; }

        [DataMember(Name = "mlTraitIntrBondOeInd")]
        public string MlTraitIntrBondOeInd { get; set; }

        [DataMember(Name = "mlTraitUnlimAdvInd")]
        public string MlTraitUnlimAdvInd { get; set; }

        [DataMember(Name = "DistrictWireCode")]
        public string DistrictWireCode { get; set; }

        [DataMember(Name = "DivisionWireCode")]
        public string DivisionWireCode { get; set; }

        [DataMember(Name = "mlTraitPIAI")]
        public string MlTraitPiai { get; set; }

        [DataMember(Name = "mlTraitDISC")]
        public string MlTraitDISC { get; set; }

        [DataMember(Name = "mlTraitRCMA")]
        public string MlTraitRcma { get; set; }

        [DataMember(Name = "mlTraitCSLT")]
        public string MlTraitCSLT { get; set; }

        [DataMember(Name = "mlTraitDACC")]
        public string MlTraitDACC { get; set; }

        [DataMember(Name = "mlPropPHON")]
        public string MlPropPHON { get; set; }

        [DataMember(Name = "mlPropDSNM")]
        public string MlPropDSNM { get; set; }

        [DataMember(Name = "mlTraitPROF")]
        public string MlTraitProf { get; set; }

        [DataMember(Name = "mlTraitTEFRA2")]
        public string MlTraitTEFRA2 { get; set; }

        [DataMember(Name = "mlTraitFACOnline")]
        public string MlTraitFACOnline { get; set; }

        [DataMember(Name = "mlTraitOneClick")]
        public string MlTraitOneClick { get; set; }

        [DataMember(Name = "mlTraitIntExSop")]
        public string MlTraitIntExSop { get; set; }

        [DataMember(Name = "mlTraitOfficerInd")]
        public string MlTraitOfficerInd { get; set; }

        [DataMember(Name = "mlTraitBBLink")]
        public string MlTraitBBLink { get; set; }

        [DataMember(Name = "PriorityService")]
        public string PriorityService { get; set; }

        [DataMember(Name = "PrimaryServiceTypeCd")]
        public string PrimaryServiceTypeCd { get; set; }

        [DataMember(Name = "ConfidentialInd")]
        public string ConfidentialInd { get; set; }

        [DataMember(Name = "SDATypeCode")]
        public string SDATypeCode { get; set; }

        [DataMember(Name = "SDAPlan")]
        public string SDAPlan { get; set; }

        [DataMember(Name = "SDASSN")]
        public string SDASSN { get; set; }

        [DataMember(Name = "mlTraitRubicon")]
        public string MlTraitRubicon { get; set; }

        [DataMember(Name = "mlTraitFAC")]
        public string MlTraitFAC { get; set; }

        [DataMember(Name = "mlTraitLMA")]
        public string MlTraitLMA { get; set; }

        [DataMember(Name = "mlTrait3Pty")]
        public string MlTrait3Pty { get; set; }

        [DataMember(Name = "mlTraitBIA")]
        public string MlTraitBIA { get; set; }

        [DataMember(Name = "AccountOpenDate")]
        public string AccountOpenDate { get; set; }

        [DataMember(Name = "AccountCloseIndicator")]
        public string AccountCloseIndicator { get; set; }

        [DataMember(Name = "mlTraitAAA")]
        public string MlTraitAAA { get; set; }

        [DataMember(Name = "mlTraitTrustPI")]
        public string MlTraitTrustPi { get; set; }

        [DataMember(Name = "mlTraitPWA")]
        public string MlTraitPwa { get; set; }

        [DataMember(Name = "mlTraitMLPA")]
        public string MlTraitMLPA { get; set; }

        [DataMember(Name = "mlTraitFX")]
        public string MlTraitFX { get; set; }

        [DataMember(Name = "mlTraitFIRM")]
        public string MlTraitFIRM { get; set; }

        [DataMember(Name = "mlTraitAccFinGrCd")]
        public string MlTraitAccFinGrCd { get; set; }

        [DataMember(Name = "mlTraitMNGRln1")]
        public string MlTraitMNGRln1 { get; set; }

        [DataMember(Name = "MlTraitMNGRln2")]
        public string MlTraitMNGRln2 { get; set; }

        [DataMember(Name = "mlTraitMNGRphone")]
        public string MlTraitMNGRphone { get; set; }

        [DataMember(Name = "mlAccountService")]
        public string MlAccountService { get; set; }

        [DataMember(Name = "mlTraitMNGRAccInd")]
        public string MlTraitMNGRAccInd { get; set; }

        [DataMember(Name = "mlMngrStyle")]
        public string MlMngrStyle { get; set; }

        [DataMember(Name = "RetirementCloseIndicator")]
        public string RetirementCloseIndicator { get; set; }

        [DataMember(Name = "mlLimIndInvInd")]
        public string MlLimIndInvInd { get; set; }

        [DataMember(Name = "mlTraitASSTconvDT")]
        public string MlTraitASSTconvDT { get; set; }

        [DataMember(Name = "mlTraitNFSacc")]
        public string MlTraitNFSacc { get; set; }

        [DataMember(Name = "mlTraitCONVind")]
        public string MlTraitCONVind { get; set; }

        [DataMember(Name = "mlTraitPerfRptInd")]
        public string MlTraitPerfRptInd { get; set; }

        [DataMember(Name = "mlTraitProgramCode")]
        public string MlTraitProgramCode { get; set; }

        [DataMember(Name = "DOLAccountInScopeInd")]
        public string DOLAccountInScopeInd { get; set; }

        [DataMember(Name = "LegacyAssetExemptInd")]
        public string LegacyAssetExemptInd { get; set; }

        [DataMember(Name = "ClientContactType")]
        public string ClientContactType { get; set; }

        [DataMember(Name = "RolloverAttestationCode")]
        public string RolloverAttestationCode { get; set; }

        [DataMember(Name = "LAEReasonCode")]
        public string LAEReasonCode { get; set; }

        [DataMember(Name = "DRACode")]
        public string DRACode { get; set; }

        [DataMember(Name = "GESTrait")]
        public string GESTrait { get; set; }
    }

    [DataContract]
    public class DisplayInfo
    {
        [DataMember(Name = "DisplayNames")]
        public Displayname[] DisplayNames { get; set; }

        [DataMember(Name = "SequencesInGroups")]
        public Sequencesingroup[] SequencesInGroups { get; set; }

        [DataMember(Name = "DisplaySeqNo")]
        public int DisplaySeqNo { get; set; }

        [DataMember(Name = "DisplaySeqNoAcrossAllGroups")]
        public int DisplaySeqNoAcrossAllGroups { get; set; }
    }

    [DataContract]
    public class Displayname
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }

    [DataContract]
    public class Sequencesingroup
    {
        [DataMember(Name = "ParentGroupType")]
        public int ParentGroupType { get; set; }

        [DataMember(Name = "Sequence")]
        public int Sequence { get; set; }
    }

    [DataContract]
    public class Identifier
    {
        [DataMember(Name = "FinancialInstitution")]
        public Financialinstitution FinancialInstitution { get; set; }

        [DataMember(Name = "Source_CD")]
        public Source_CD Source_CD { get; set; }

        [DataMember(Name = "UniqueID")]
        public string UniqueID { get; set; }

        [DataMember(Name = "Source_Keys")]
        public SourceKeys[] SourceKeys { get; set; }

        [DataMember(Name = "FinancialServiceType")]
        public Financialservicetype FinancialServiceType { get; set; }

        [DataMember(Name = "Number")]
        public string Number { get; set; }

        [DataMember(Name = "ManagementIdentifier")]
        public object ManagementIdentifier { get; set; }

        [DataMember(Name = "AccountNickname")]
        public object AccountNickname { get; set; }
    }

    [DataContract]
    public class Financialinstitution
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Value")]
        public string Value { get; set; }
    }

    [DataContract]
    public class Source_CD
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Value")]
        public object Value { get; set; }
    }

    [DataContract]
    public class Financialservicetype
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Value")]
        public string Value { get; set; }
    }

    [DataContract]
    public class SourceKeys
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Value")]
        public string Value { get; set; }
    }

    [DataContract]
    public class Trait
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Desc")]
        public string Desc { get; set; }
    }

    [DataContract]
    public class TradeQuoteResponse
    {
        [DataMember(Name = "TradeQuoteMapData")]
        public object[] TradeQuoteMapData { get; set; }

        [DataMember(Name = "TradeQuoteTemplate")]
        public TradeQuoteTemplate TradeQuoteTemplate { get; set; }

        [DataMember(Name = "TradeQuoteStatus")]
        public TradeQuoteStatus TradeQuoteStatus { get; set; }

        [DataMember(Name = "TradeQuoteData")]
        public TradeQuoteData TradeQuoteData { get; set; }
    }

    [DataContract]
    public class TradeQuoteTemplate
    {
        [DataMember(Name = "TemplateID")]
        public string TemplateID { get; set; }

        [DataMember(Name = "TemplateHTML")]
        public string TemplateHTML { get; set; }
    }

    [DataContract]
    public class TradeQuoteStatus
    {
        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "StatusMessage")]
        public string StatusMessage { get; set; }

        [DataMember(Name = "InnerException")]
        public string InnerException { get; set; }

        [DataMember(Name = "Type")]
        public int Type { get; set; }
    }

    [DataContract]
    public class TradeQuoteData
    {
        [DataMember(Name = "IsSelectList")]
        public object IsSelectList { get; set; }

        [DataMember(Name = "SelectListInd")]
        public string SelectListInd { get; set; }

        [DataMember(Name = "AERSymbol")]
        public string AERSymbol { get; set; }

        [DataMember(Name = "Ask")]
        public float Ask { get; set; }

        [DataMember(Name = "Bid")]
        public float Bid { get; set; }

        [DataMember(Name = "BidSize")]
        public int BidSize { get; set; }

        [DataMember(Name = "AskSize")]
        public int AskSize { get; set; }

        [DataMember(Name = "Volume")]
        public int Volume { get; set; }

        [DataMember(Name = "EHTPrice")]
        public object EHTPrice { get; set; }

        [DataMember(Name = "EHTPriceChangePct")]
        public object EHTPriceChangePct { get; set; }

        [DataMember(Name = "EHTPriceChange")]
        public object EHTPriceChange { get; set; }

        [DataMember(Name = "EHTDateTime")]
        public object EHTDateTime { get; set; }

        [DataMember(Name = "EHTMarketCloseDateTime")]
        public object EHTMarketCloseDateTime { get; set; }

        [DataMember(Name = "EHTAsOfDate")]
        public object EHTAsOfDate { get; set; }

        [DataMember(Name = "EHTAsk")]
        public object EHTAsk { get; set; }

        [DataMember(Name = "EHTBid")]
        public object EHTBid { get; set; }

        [DataMember(Name = "High52Week")]
        public object High52Week { get; set; }

        [DataMember(Name = "Low52Week")]
        public object Low52Week { get; set; }

        [DataMember(Name = "PrevClose")]
        public object PrevClose { get; set; }

        [DataMember(Name = "PrevOpen")]
        public object PrevOpen { get; set; }

        [DataMember(Name = "StockStyle")]
        public string StockStyle { get; set; }

        [DataMember(Name = "BondStyle")]
        public string BondStyle { get; set; }

        [DataMember(Name = "DaysHigh")]
        public float DaysHigh { get; set; }

        [DataMember(Name = "DaysLow")]
        public float DaysLow { get; set; }

        [DataMember(Name = "EquityTradingType")]
        public int EquityTradingType { get; set; }

        [DataMember(Name = "EHTPriceChangeColor")]
        public string EHTPriceChangeColor { get; set; }

        [DataMember(Name = "EHTPriceChangeInd")]
        public string EHTPriceChangeInd { get; set; }

        [DataMember(Name = "EHTPercentChangeColor")]
        public string EHTPercentChangeColor { get; set; }

        [DataMember(Name = "EHTBidSize")]
        public object EHTBidSize { get; set; }

        [DataMember(Name = "EHTAskSize")]
        public object EHTAskSize { get; set; }

        [DataMember(Name = "IsETFRestricted")]
        public object IsETFRestricted { get; set; }

        [DataMember(Name = "TradeVolume")]
        public int TradeVolume { get; set; }

        [DataMember(Name = "EHTTradeVolume")]
        public object EHTTradeVolume { get; set; }

        [DataMember(Name = "TradeExchAbbr")]
        public string TradeExchAbbr { get; set; }

        [DataMember(Name = "EHTTradeExchAbbr")]
        public string EHTTradeExchAbbr { get; set; }

        [DataMember(Name = "AskExchAbbr")]
        public string AskExchAbbr { get; set; }

        [DataMember(Name = "BidExchAbbr")]
        public string BidExchAbbr { get; set; }

        [DataMember(Name = "AsOfDateVisible")]
        public string AsOfDateVisible { get; set; }

        [DataMember(Name = "CurrentRequest")]
        public CurrentRequest CurrentRequest { get; set; }

        [DataMember(Name = "PriceChangeColor")]
        public string PriceChangeColor { get; set; }

        [DataMember(Name = "PriceChangeInd")]
        public string PriceChangeInd { get; set; }

        [DataMember(Name = "PercentChangeColor")]
        public string PercentChangeColor { get; set; }

        [DataMember(Name = "Symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "Price")]
        public float Price { get; set; }

        [DataMember(Name = "AsOfDate")]
        public DateTime AsOfDate { get; set; }

        [DataMember(Name = "PriceChange")]
        public float PriceChange { get; set; }

        [DataMember(Name = "PercentChange")]
        public float PercentChange { get; set; }

        [DataMember(Name = "RatingCollection")]
        public object RatingCollection { get; set; }

        [DataMember(Name = "IsHeld")]
        public bool IsHeld { get; set; }

        [DataMember(Name = "TradeCategory")]
        public int TradeCategory { get; set; }

        [DataMember(Name = "QuoteDataStatusCol")]
        public QuoteDataStatusCol[] QuoteDataStatusCol { get; set; }

        [DataMember(Name = "refreshOnClick")]
        public object RefreshOnClick { get; set; }

        [DataMember(Name = "RefreshVisible")]
        public string RefreshVisible { get; set; }

        [DataMember(Name = "ServiceSymbolType")]
        public int ServiceSymbolType { get; set; }

        [DataMember(Name = "DataType")]
        public string DataType { get; set; }

        [DataMember(Name = "SecurityType")]
        public int SecurityType { get; set; }

        [DataMember(Name = "ValidSecurityTypes")]
        public object ValidSecurityTypes { get; set; }

        [DataMember(Name = "RefreshADAText")]
        public string RefreshADAText { get; set; }
    }

    [DataContract]
    public class CurrentRequest
    {
        [DataMember(Name = "TradingType")]
        public int TradingType { get; set; }

        [DataMember(Name = "InstrumentId")]
        public string InstrumentId { get; set; }

        [DataMember(Name = "InstrumentIdType")]
        public int InstrumentIdType { get; set; }

        [DataMember(Name = "IsRealTime")]
        public bool IsRealTime { get; set; }

        [DataMember(Name = "CurrentTrdType")]
        public int CurrentTrdType { get; set; }

        [DataMember(Name = "AccountIndex")]
        public int AccountIndex { get; set; }

        [DataMember(Name = "EventList")]
        public Eventlist EventList { get; set; }

        [DataMember(Name = "IsRefreshVisible")]
        public bool IsRefreshVisible { get; set; }

        [DataMember(Name = "IsAsOfDateVisible")]
        public bool IsAsOfDateVisible { get; set; }

        [DataMember(Name = "ValidSecurityTypes")]
        public object ValidSecurityTypes { get; set; }

        [DataMember(Name = "RefreshADAText")]
        public string RefreshADAText { get; set; }
    }

    [DataContract]
    public class Eventlist
    {
        [DataMember(Name = "refreshOnClick")]
        public object RefreshOnClick { get; set; }
    }

    [DataContract]
    public class QuoteDataStatusCol
    {
        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "StatusMessage")]
        public string StatusMessage { get; set; }

        [DataMember(Name = "InnerException")]
        public string InnerException { get; set; }

        [DataMember(Name = "Type")]
        public int Type { get; set; }
    }

    [DataContract]
    public class MessageList
    {
        [DataMember(Name = "ActivityID")]
        public string ActivityID { get; set; }

        [DataMember(Name = "OutcomeType")]
        public int OutcomeType { get; set; }

        [DataMember(Name = "MessageText")]
        public string MessageText { get; set; }

        [DataMember(Name = "DisplayType")]
        public int DisplayType { get; set; }
    }
}
