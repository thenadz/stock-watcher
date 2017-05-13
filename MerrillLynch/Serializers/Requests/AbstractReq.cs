using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using Newtonsoft.Json;

namespace StockWatcher.MerrillLynch.Serializers.Requests
{
    [DataContract]
    public abstract class AbstractReq<TResponse>
    {
        /// <summary>
        /// Don't access directly. Use wrapper property.
        /// </summary>
        private DataContractJsonSerializer reqSerializer;

        /// <summary>
        /// Don't access directly. Use wrapper property.
        /// </summary>
        private JsonSerializer respDeserializer;

        public abstract string RequestUri { get; }

        public virtual string RequestMethod { get; } = "POST";

        private DataContractJsonSerializer ReqSerializer => reqSerializer ?? (reqSerializer = new DataContractJsonSerializer(GetType()));

        private JsonSerializer RespDeserializer => respDeserializer ?? (respDeserializer = new JsonSerializer());

        public TResponse GetResponse(string userAgent, Uri referer, CookieContainer cookies, string pageId)
        {
            HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create(RequestUri);
            hwr.CookieContainer = cookies;
            hwr.Method = RequestMethod;

            hwr.Host = referer.Host;
            hwr.KeepAlive = true;
            hwr.Headers.Add($"Origin: {referer.GetLeftPart(UriPartial.Authority)}");
            hwr.UserAgent = userAgent;
            hwr.ContentType = "application/json; charset=UTF-8";
            hwr.Headers.Add("X-Requested-With: XMLHttpRequest");
            hwr.Headers.Add($"__PageIdHeader: {pageId}");
            hwr.Accept = "*/*";
            hwr.Referer = referer.OriginalString;
            hwr.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            ReqSerializer.WriteObject(hwr.GetRequestStream(), this);

            using (StreamReader sr = new StreamReader(hwr.GetResponse().GetResponseStream()))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                return RespDeserializer.Deserialize<TResponse>(jsonTextReader);
            }
        }
    }
}
