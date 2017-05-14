using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
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
}