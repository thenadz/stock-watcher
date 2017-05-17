using System;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using StockWatcher.Util;

namespace StockWatcher.MerrillLynch.Serializers.Responses
{
    [DataContract]
    public class GetChartResp
    {
        [DataMember(Name = "getChart")]
        public GetChart Data { get; set; }
    }

    [DataContract]
    public class GetChart
    {
        [DataMember(Name = "symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "fileName")]
        public string FileName { get; set; }

        [DataMember(Name = "exportData")]
        public ExportData ExportData { get; set; }
    }

    [DataContract]
    public class ExportData
    {
        [DataMember(Name = "totalHeight")]
        public int TotalHeight { get; set; }

        [DataMember(Name = "totalWidth")]
        public string TotalWidth { get; set; }

        [DataMember(Name = "charts")]
        public Chart[] Charts { get; set; }
    }

    [DataContract]
    public class Chart
    {
        [DataMember(Name = "uid")]
        public string Uid { get; set; }

        [DataMember(Name = "coords")]
        public Coords Coords { get; set; }

        [DataMember(Name = "dataPoints")]
        public OrderedDictionary<int, DataPoint> DataPoints { get; set; }

        [DataMember(Name = "labels")]
        public Label[] Labels { get; set; }

        [DataMember(Name = "coName")]
        public string CoName { get; set; }

        [DataMember(Name = "symbolGWM")]
        public string SymbolGwm { get; set; }

        [DataMember(Name = "MaxRange")]
        public string MaxRange { get; set; }

        [DataMember(Name = "firstDataPointCoord")]
        public int FirstDataPointCoord { get; set; }

        [DataMember(Name = "lastDataPointCoord")]
        public int LastDataPointCoord { get; set; }

        [DataMember(Name = "eventDates")]
        public EventDates EventDates { get; set; }

        [DataMember(Name = "units")]
        public string Units { get; set; }
    }

    [DataContract]
    public class Coords
    {
        [DataMember(Name = "top")]
        public int Top { get; set; }

        [DataMember(Name = "left")]
        public int Left { get; set; }

        [DataMember(Name = "bottom")]
        public int Bottom { get; set; }

        [DataMember(Name = "right")]
        public int Right { get; set; }

        [DataMember(Name = "height")]
        public int Height { get; set; }

        [DataMember(Name = "width")]
        public int Width { get; set; }

        [DataMember(Name = "xaxis")]
        public Axis Xaxis { get; set; }

        [DataMember(Name = "yaxis")]
        public Axis Yaxis { get; set; }
    }

    [DataContract]
    public class Axis
    {
        [DataMember(Name = "top")]
        public int Top { get; set; }

        [DataMember(Name = "bottom")]
        public int Bottom { get; set; }

        [DataMember(Name = "left")]
        public int Left { get; set; }

        [DataMember(Name = "right")]
        public int Right { get; set; }

        [DataMember(Name = "height")]
        public int Height { get; set; }

        [DataMember(Name = "width")]
        public int Width { get; set; }

        [DataMember(Name = "minValue")]
        public int MinValue { get; set; }

        [DataMember(Name = "maxValue")]
        public int MaxValue { get; set; }
    }

    [DataContract]
    public class DataPoint
    {
        [DataMember(Name = "date")]
        public string Date { get; set; }

        [DataMember(Name = "close")]
        public string Close { get; set; }

        [DataMember(Name = "open")]
        public string Open { get; set; }

        [DataMember(Name = "low")]
        public string Low { get; set; }

        [DataMember(Name = "high")]
        public string High { get; set; }

        [DataMember(Name = "volume")]
        public string Volume { get; set; }

        [DataMember(Name = "rawDate")]
        public int RawDate { get; set; }
    }

    [DataContract]
    public class EventDates
    {
    }

    [DataContract]
    public class Label
    {
        [DataMember(Name = "type")]
        public string Type { get; set; }

        [DataMember(Name = "label")]
        public Label1 label { get; set; }
    }

    [DataContract]
    public class Label1
    {
        [DataMember(Name = "text")]
        public string Text { get; set; }

        [DataMember(Name = "_params")]
        public string[] Params { get; set; }

        [DataMember(Name = "uid")]
        public string Uid { get; set; }
    }

    public class DataPointsConverter : CustomCreationConverter<OrderedDictionary<int, DataPoint>>
    {
        public override OrderedDictionary<int, DataPoint> Create(Type objectType)
        {
            return new OrderedDictionary<int, DataPoint>();
        }

        public override bool CanConvert(Type objectType)
        {
            // in addition to handling IDictionary<string, object>
            // we want to handle the deserialization of dict value
            // which is of type object
            return objectType == typeof(object) || base.CanConvert(objectType);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.StartObject
                || reader.TokenType == JsonToken.Null)
                return base.ReadJson(reader, objectType, existingValue, serializer);

            // if the next token is not an object
            // then fall back on standard deserializer (strings, numbers etc.)
            return serializer.Deserialize(reader);
        }
    }
}
