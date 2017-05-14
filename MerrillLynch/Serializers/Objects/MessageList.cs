using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
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