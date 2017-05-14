using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class TradeTicketPreview
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
}