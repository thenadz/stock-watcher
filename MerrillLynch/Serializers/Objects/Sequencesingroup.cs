using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class Sequencesingroup
    {
        [DataMember(Name = "ParentGroupType")]
        public int ParentGroupType { get; set; }

        [DataMember(Name = "Sequence")]
        public int Sequence { get; set; }
    }
}