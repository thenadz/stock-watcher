using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class TradeQuoteTemplate
    {
        [DataMember(Name = "TemplateID")]
        public string TemplateID { get; set; }

        [DataMember(Name = "TemplateHTML")]
        public string TemplateHTML { get; set; }
    }
}