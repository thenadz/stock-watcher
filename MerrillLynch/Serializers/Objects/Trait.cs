using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class Trait
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Desc")]
        public string Desc { get; set; }
    }
}