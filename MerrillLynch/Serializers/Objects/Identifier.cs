using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
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
}