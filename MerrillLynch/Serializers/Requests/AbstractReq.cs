using System;
using System.IO;
using System.Net;
using System.Net.Http.Formatting;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace StockWatcher.MerrillLynch.Serializers.Requests
{
    [DataContract]
    public abstract class AbstractReq<TResponse>
        where TResponse : class
    {
        public const string JsonMimeType = "application/json";

        public const string FormUrlEncodedMimeType = "application/x-www-form-urlencoded";

        /// <summary>
        /// Don't access directly. Use wrapper property.
        /// </summary>
        private JsonSerializer serializer;

        public abstract string RequestUri { get; }

        public virtual string RequestReferer { get; } = null;

        public virtual string MimeType { get; } = JsonMimeType;

        public virtual string RequestMethod { get; } = "POST";

        // NOTE: Required for non-JSON requests
        public virtual MediaTypeFormatter Formatter { get; } = null;

        private JsonSerializer Serializer => serializer ?? (serializer = new JsonSerializer());

        public TResponse GetResponse(string userAgent, Uri referer, CookieContainer cookies, string pageId)
        {
            HttpWebRequest hwr = (HttpWebRequest)WebRequest.Create(RequestUri);
            hwr.CookieContainer = cookies;
            hwr.Method = RequestMethod;

            hwr.Host = referer.Host;
            hwr.KeepAlive = true;
            hwr.Headers.Add($"Origin: {referer.GetLeftPart(UriPartial.Authority)}");
            hwr.UserAgent = userAgent;
            hwr.ContentType = MimeType;
            hwr.Headers.Add($"__PageIdHeader: {pageId}");
            hwr.Accept = "*/*";
            hwr.Referer = referer.OriginalString;
            hwr.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            // serialize request to the wire
            Stream reqStream = hwr.GetRequestStream();
            switch (MimeType)
            {
                // JSON requests handled here
                case JsonMimeType:
                {
                    using (StreamWriter writer = new StreamWriter(reqStream))
                    using (JsonTextWriter jwriter = new JsonTextWriter(writer))
                    {
                        Serializer.Serialize(jwriter, this);
                    }
                    break;
                }

                // non-JSON requests handled here
                default:
                {
                    Formatter.WriteToStreamAsync(GetType(), this, reqStream, null, null).Wait();
                    break;
                }
            }

            // deserialize response from the wire
            using (StreamReader sr = new StreamReader(hwr.GetResponse().GetResponseStream()))
            using (JsonTextReader jsonTextReader = new JsonTextReader(sr))
            {
                return Serializer.Deserialize<TResponse>(jsonTextReader);
            }
        }
    }
}
