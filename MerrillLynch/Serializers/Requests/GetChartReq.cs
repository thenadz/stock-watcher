using System.Net.Http.Formatting;
using System.Runtime.Serialization;
using StockWatcher.MerrillLynch.Serializers.Responses;

namespace StockWatcher.MerrillLynch.Serializers.Requests
{
    [DataContract]
    public class GetChartReq : AbstractReq<GetChartResp>
    {
        public override string RequestUri { get; } = "https://olui2.fs.ml.com/MDWSODUtility/DataLoader.aspx?src=/research/resources/server/charts/buffer_getChart.asp";

        public override string RequestReferer => $"https://olui2.fs.ml.com/RIStocksUI/RIStocksCharting.aspx?symbol={TickerSymbol}";

        public override string MimeType { get; } = FormUrlEncodedMimeType;

        private MediaTypeFormatter formatter;

        public override MediaTypeFormatter Formatter => formatter ?? (formatter = new FormUrlEncodedMediaTypeFormatter());

        public string TickerSymbol { get; set; }

        [DataMember(Name = "inputs")]
        public string Inputs { get; set; }

        [DataMember(Name = "__PageIdField")]
        public string PageId { get; set; }

        [DataMember(Name = "..contenttype..")]
        public string ContentType { get; set; } = "text/javascript";

        [DataMember(Name = "..requester..")]
        public string Requester { get; set; } = "ContentBuffer";
    }
}
