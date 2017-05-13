using System;
using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Responses
{
    [DataContract]
    public class StockDataResp
    {
        [DataMember(Name = "d")]
        public StockDataRespData Data { get; set; }
    }

    [DataContract]
    public class StockDataRespData
    {
        [DataMember(Name = "__type")]
        public string Type { get; set; }

        [DataMember(Name = "QuoteTemplate")]
        public QuoteTemplate QuoteTemplate { get; set; }

        [DataMember(Name = "QuoteData")]
        public QuoteData QuoteData { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }
    }

    [DataContract]
    public class QuoteTemplate
    {
        [DataMember(Name = "View")]
        public View View { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }
    }

    [DataContract]
    public class View
    {
        [DataMember(Name = "TemplateID")]
        public int TemplateID { get; set; }

        [DataMember(Name = "HTMLTemplate")]
        public string HTMLTemplate { get; set; }

        [DataMember(Name = "FieldMappings")]
        public FieldMapping[] FieldMappings { get; set; }

        [DataMember(Name = "LinkMappings")]
        public LinkMapping[] LinkMappings { get; set; }

        [DataMember(Name = "AdditionalDetails")]
        public AdditionalDetails AdditionalDetails { get; set; }
    }

    [DataContract]
    public class AdditionalDetails
    {
        [DataMember(Name = "Width")]
        public string Width { get; set; }

        [DataMember(Name = "CssClass")]
        public string CssClass { get; set; }

        [DataMember(Name = "InstrumentType")]
        public int InstrumentType { get; set; }

        [DataMember(Name = "MarketDataSymbol")]
        public string MarketDataSymbol { get; set; }

        [DataMember(Name = "Description")]
        public object Description { get; set; }

        [DataMember(Name = "PositionDetailQS")]
        public object PositionDetailQS { get; set; }

        [DataMember(Name = "MoreChartLinkRUN")]
        public string MoreChartLinkRUN { get; set; }

        [DataMember(Name = "MoreChartLinkEntitlement")]
        public string MoreChartLinkEntitlement { get; set; }

        [DataMember(Name = "ChartEntitlement")]
        public string ChartEntitlement { get; set; }

        [DataMember(Name = "IsPositionHeld")]
        public bool IsPositionHeld { get; set; }

        [DataMember(Name = "IsCEF")]
        public bool IsCEF { get; set; }

        [DataMember(Name = "ChartRUN")]
        public string ChartRUN { get; set; }

        [DataMember(Name = "IsPopupClickRedirectOn")]
        public bool IsPopupClickRedirectOn { get; set; }
    }

    [DataContract]
    public class FieldMapping
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Label")]
        public string Label { get; set; }

        [DataMember(Name = "Value")]
        public string Value { get; set; }

        [DataMember(Name = "FormatedValue")]
        public string FormatedValue { get; set; }

        [DataMember(Name = "BindAction")]
        public int BindAction { get; set; }
    }

    [DataContract]
    public class LinkMapping
    {
        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Label")]
        public string Label { get; set; }

        [DataMember(Name = "Type")]
        public int Type { get; set; }

        [DataMember(Name = "LinkRUN")]
        public string LinkRUN { get; set; }

        [DataMember(Name = "Entitlement")]
        public string Entitlement { get; set; }
    }

    [DataContract]
    public class QuoteData
    {
        [DataMember(Name = "InstrumentType")]
        public int InstrumentType { get; set; }

        [DataMember(Name = "Instrument")]
        public Instrument Instrument { get; set; }

        [DataMember(Name = "Status")]
        public int Status { get; set; }

        [DataMember(Name = "MarketDataSymbol")]
        public string MarketDataSymbol { get; set; }

        [DataMember(Name = "Holding")]
        public object Holding { get; set; }
    }

    [DataContract]
    public class Instrument
    {
        [DataMember(Name = "MarketData")]
        public MarketData MarketData { get; set; }

        [DataMember(Name = "StockType")]
        public int StockType { get; set; }

        [DataMember(Name = "IsOptionEligible")]
        public bool IsOptionEligible { get; set; }

        [DataMember(Name = "CUSIP")]
        public object CUSIP { get; set; }

        [DataMember(Name = "SEDOL")]
        public object SEDOL { get; set; }

        [DataMember(Name = "ISIN")]
        public object ISIN { get; set; }

        [DataMember(Name = "Symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "MarketDataSymbol")]
        public object MarketDataSymbol { get; set; }

        [DataMember(Name = "CustomSymbol")]
        public object CustomSymbol { get; set; }

        [DataMember(Name = "Ratings")]
        public Rating[] Ratings { get; set; }

        [DataMember(Name = "Sector")]
        public object Sector { get; set; }

        [DataMember(Name = "Industry")]
        public object Industry { get; set; }

        [DataMember(Name = "ExchangeInfo")]
        public ExchangeInfo[] ExchangeInfo { get; set; }

        [DataMember(Name = "ID")]
        public object ID { get; set; }

        [DataMember(Name = "DisplayName")]
        public object DisplayName { get; set; }

        [DataMember(Name = "Desc")]
        public string Desc { get; set; }

        [DataMember(Name = "Desc1")]
        public object Desc1 { get; set; }

        [DataMember(Name = "Desc2")]
        public object Desc2 { get; set; }

        [DataMember(Name = "Desc3")]
        public object Desc3 { get; set; }

        [DataMember(Name = "Desc4")]
        public object Desc4 { get; set; }

        [DataMember(Name = "ProductClass")]
        public object ProductClass { get; set; }

        [DataMember(Name = "Type")]
        public int Type { get; set; }
    }

    [DataContract]
    public class MarketData
    {
        [DataMember(Name = "LastTrade")]
        public LastTrade LastTrade { get; set; }

        [DataMember(Name = "Bid")]
        public float Bid { get; set; }

        [DataMember(Name = "Ask")]
        public float Ask { get; set; }

        [DataMember(Name = "High_52Wk")]
        public float High52Week { get; set; }

        [DataMember(Name = "Low_52Wk")]
        public float Low52Week { get; set; }

        [DataMember(Name = "Day_High")]
        public float DayHigh { get; set; }

        [DataMember(Name = "Day_Low")]
        public float DayLow { get; set; }

        [DataMember(Name = "OpenPrice")]
        public float OpenPrice { get; set; }

        [DataMember(Name = "ClosePrice")]
        public float ClosePrice { get; set; }

        [DataMember(Name = "DaysVolume")]
        public int DaysVolume { get; set; }

        [DataMember(Name = "AvgVolume")]
        public object AvgVolume { get; set; }

        [DataMember(Name = "Price")]
        public float Price { get; set; }

        [DataMember(Name = "PriceAsOf")]
        public DateTime PriceAsOf { get; set; }

        [DataMember(Name = "PriceChg")]
        public float PriceChg { get; set; }

        [DataMember(Name = "PriceChgPct")]
        public float PriceChgPct { get; set; }

        [DataMember(Name = "PERatio")]
        public object PERatio { get; set; }

        [DataMember(Name = "EPS")]
        public object EPS { get; set; }

        [DataMember(Name = "MarketCap")]
        public object MarketCap { get; set; }

        [DataMember(Name = "OutstandingShares")]
        public object OutstandingShares { get; set; }

        [DataMember(Name = "Yield")]
        public float Yield { get; set; }

        [DataMember(Name = "Date")]
        public object Date { get; set; }

        [DataMember(Name = "Time")]
        public object Time { get; set; }

        [DataMember(Name = "Dividend")]
        public float Dividend { get; set; }

        [DataMember(Name = "DividendDate")]
        public object DividendDate { get; set; }

        [DataMember(Name = "BetaPrice")]
        public object BetaPrice { get; set; }

        [DataMember(Name = "AvgVol10Day")]
        public object AvgVol10Day { get; set; }

        [DataMember(Name = "DividendYield")]
        public object DividendYield { get; set; }

        [DataMember(Name = "SectorCode")]
        public object SectorCode { get; set; }

        [DataMember(Name = "DivProjDate")]
        public object DivProjDate { get; set; }

        [DataMember(Name = "Exchange")]
        public object Exchange { get; set; }

        [DataMember(Name = "PrimaryExchange")]
        public object PrimaryExchange { get; set; }

        [DataMember(Name = "LastPrice")]
        public object LastPrice { get; set; }

        [DataMember(Name = "RealTime")]
        public bool RealTime { get; set; }

        [DataMember(Name = "AskSize")]
        public int AskSize { get; set; }

        [DataMember(Name = "BidSize")]
        public int BidSize { get; set; }
    }

    [DataContract]
    public class LastTrade
    {
        [DataMember(Name = "Ticks")]
        public long Ticks { get; set; }

        [DataMember(Name = "Days")]
        public int Days { get; set; }

        [DataMember(Name = "Hours")]
        public int Hours { get; set; }

        [DataMember(Name = "Milliseconds")]
        public int Milliseconds { get; set; }

        [DataMember(Name = "Minutes")]
        public int Minutes { get; set; }

        [DataMember(Name = "Seconds")]
        public int Seconds { get; set; }

        [DataMember(Name = "TotalDays")]
        public float TotalDays { get; set; }

        [DataMember(Name = "TotalHours")]
        public int TotalHours { get; set; }

        [DataMember(Name = "TotalMilliseconds")]
        public int TotalMilliseconds { get; set; }

        [DataMember(Name = "TotalMinutes")]
        public int TotalMinutes { get; set; }

        [DataMember(Name = "TotalSeconds")]
        public int TotalSeconds { get; set; }
    }

    [DataContract]
    public class Rating
    {
        [DataMember(Name = "Vendor")]
        public Vendor Vendor { get; set; }

        [DataMember(Name = "Value")]
        public string Value { get; set; }

        [DataMember(Name = "ValuationDate")]
        public DateTime ValuationDate { get; set; }

        [DataMember(Name = "VendorCount")]
        public int VendorCount { get; set; }

        [DataMember(Name = "RatingDesc")]
        public string RatingDesc { get; set; }

        [DataMember(Name = "RatingChgTime")]
        public object RatingChgTime { get; set; }

        [DataMember(Name = "StockStyle")]
        public object StockStyle { get; set; }

        [DataMember(Name = "BondStyle")]
        public object BondStyle { get; set; }

        [DataMember(Name = "LWVendorRating")]
        public object LWVendorRating { get; set; }

        [DataMember(Name = "LWRatingDesc")]
        public object LWRatingDesc { get; set; }

        [DataMember(Name = "LipperFeedDate")]
        public object LipperFeedDate { get; set; }

        [DataMember(Name = "OutofFunds")]
        public object OutOfFunds { get; set; }

        [DataMember(Name = "Category")]
        public object Category { get; set; }
    }

    [DataContract]
    public class Vendor
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Desc")]
        public string Desc { get; set; }
    }

    [DataContract]
    public class ExchangeInfo
    {
        [DataMember(Name = "Name")]
        public Name Name { get; set; }

        [DataMember(Name = "ExchangeSymbol")]
        public object ExchangeSymbol { get; set; }
    }

    [DataContract]
    public class Name
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Desc")]
        public string Desc { get; set; }
    }

}
