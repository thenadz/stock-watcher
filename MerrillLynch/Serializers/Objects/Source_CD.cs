using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class Source_CD
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Value")]
        public object Value { get; set; }
    }
}