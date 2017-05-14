using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class ReqAccountIdentifier
    {
        [DataMember(Name = "Type")]
        public string Type { get; set; } = "Account";

        [DataMember(Name = "Index")]
        public int Index { get; set; }
    }
}
