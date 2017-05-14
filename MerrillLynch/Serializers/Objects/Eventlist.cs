using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class Eventlist
    {
        [DataMember(Name = "refreshOnClick")]
        public object RefreshOnClick { get; set; }
    }
}