using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class Displayname
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }
    }
}