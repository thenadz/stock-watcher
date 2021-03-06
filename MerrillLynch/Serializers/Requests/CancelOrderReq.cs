﻿using System.Runtime.Serialization;
using StockWatcher.MerrillLynch.Serializers.Responses;

namespace StockWatcher.MerrillLynch.Serializers.Requests
{
    [DataContract]
    public class CancelOrderReq : AbstractReq<CancelOrderResp>
    {
        [DataMember(Name = "oRequest")]
        public CancelEquityOrderReqData Data { get; set; }

        public override string RequestUri { get; } =
            "https://olui2.fs.ml.com/OrderStatus/UIServices/OrderStatusService.asmx/CancelOrder";

        public override string RequestReferer { get; } = "https://olui2.fs.ml.com/OrderStatus/OrderStatus.aspx";
    }

    [DataContract]
    public class CancelEquityOrderReqData
    {
        [DataMember(Name = "__type")]
        public string __type { get; set; }

        [DataMember(Name = "OrderNumber")]
        public object OrderNumber { get; set; }

        [DataMember(Name = "ProductType")]
        public string ProductType { get; set; }

        [DataMember(Name = "Index")]
        public string Index { get; set; }
    }

}
