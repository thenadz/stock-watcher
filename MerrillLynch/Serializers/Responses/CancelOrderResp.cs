﻿using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Responses
{
    [DataContract]
    public class CancelOrderResp
    {
        [DataMember(Name = "d")]
        public CancelEquityOrderRespData Data { get; set; }
    }

    [DataContract]
    public class CancelEquityOrderRespData
    {
        [DataMember(Name = "__type")]
        public string __type { get; set; }

        [DataMember(Name = "ReturnCode")]
        public int ReturnCode { get; set; }

        [DataMember(Name = "ReturnMessage")]
        public object ReturnMessage { get; set; }

        [DataMember(Name = "OrderStatusResponseJson")]
        public string OrderStatusResponseJson { get; set; }

        [DataMember(Name = "HTMLTemplate")]
        public object HTMLTemplate { get; set; }

        [DataMember(Name = "TargetElement")]
        public object TargetElement { get; set; }
    }

}
