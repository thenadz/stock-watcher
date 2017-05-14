using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
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
}