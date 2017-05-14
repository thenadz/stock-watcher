using System;
using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class TradeQuoteData
    {
        [DataMember(Name = "IsSelectList")]
        public object IsSelectList { get; set; }

        [DataMember(Name = "SelectListInd")]
        public string SelectListInd { get; set; }

        [DataMember(Name = "AERSymbol")]
        public string AERSymbol { get; set; }

        [DataMember(Name = "Ask")]
        public float Ask { get; set; }

        [DataMember(Name = "Bid")]
        public float Bid { get; set; }

        [DataMember(Name = "BidSize")]
        public int BidSize { get; set; }

        [DataMember(Name = "AskSize")]
        public int AskSize { get; set; }

        [DataMember(Name = "Volume")]
        public int Volume { get; set; }

        [DataMember(Name = "EHTPrice")]
        public object EHTPrice { get; set; }

        [DataMember(Name = "EHTPriceChangePct")]
        public object EHTPriceChangePct { get; set; }

        [DataMember(Name = "EHTPriceChange")]
        public object EHTPriceChange { get; set; }

        [DataMember(Name = "EHTDateTime")]
        public object EHTDateTime { get; set; }

        [DataMember(Name = "EHTMarketCloseDateTime")]
        public object EHTMarketCloseDateTime { get; set; }

        [DataMember(Name = "EHTAsOfDate")]
        public object EHTAsOfDate { get; set; }

        [DataMember(Name = "EHTAsk")]
        public object EHTAsk { get; set; }

        [DataMember(Name = "EHTBid")]
        public object EHTBid { get; set; }

        [DataMember(Name = "High52Week")]
        public object High52Week { get; set; }

        [DataMember(Name = "Low52Week")]
        public object Low52Week { get; set; }

        [DataMember(Name = "PrevClose")]
        public object PrevClose { get; set; }

        [DataMember(Name = "PrevOpen")]
        public object PrevOpen { get; set; }

        [DataMember(Name = "StockStyle")]
        public string StockStyle { get; set; }

        [DataMember(Name = "BondStyle")]
        public string BondStyle { get; set; }

        [DataMember(Name = "DaysHigh")]
        public float DaysHigh { get; set; }

        [DataMember(Name = "DaysLow")]
        public float DaysLow { get; set; }

        [DataMember(Name = "EquityTradingType")]
        public int EquityTradingType { get; set; }

        [DataMember(Name = "EHTPriceChangeColor")]
        public string EHTPriceChangeColor { get; set; }

        [DataMember(Name = "EHTPriceChangeInd")]
        public string EHTPriceChangeInd { get; set; }

        [DataMember(Name = "EHTPercentChangeColor")]
        public string EHTPercentChangeColor { get; set; }

        [DataMember(Name = "EHTBidSize")]
        public object EHTBidSize { get; set; }

        [DataMember(Name = "EHTAskSize")]
        public object EHTAskSize { get; set; }

        [DataMember(Name = "IsETFRestricted")]
        public object IsETFRestricted { get; set; }

        [DataMember(Name = "TradeVolume")]
        public int TradeVolume { get; set; }

        [DataMember(Name = "EHTTradeVolume")]
        public object EHTTradeVolume { get; set; }

        [DataMember(Name = "TradeExchAbbr")]
        public string TradeExchAbbr { get; set; }

        [DataMember(Name = "EHTTradeExchAbbr")]
        public string EHTTradeExchAbbr { get; set; }

        [DataMember(Name = "AskExchAbbr")]
        public string AskExchAbbr { get; set; }

        [DataMember(Name = "BidExchAbbr")]
        public string BidExchAbbr { get; set; }

        [DataMember(Name = "AsOfDateVisible")]
        public string AsOfDateVisible { get; set; }

        [DataMember(Name = "CurrentRequest")]
        public CurrentRequest CurrentRequest { get; set; }

        [DataMember(Name = "PriceChangeColor")]
        public string PriceChangeColor { get; set; }

        [DataMember(Name = "PriceChangeInd")]
        public string PriceChangeInd { get; set; }

        [DataMember(Name = "PercentChangeColor")]
        public string PercentChangeColor { get; set; }

        [DataMember(Name = "Symbol")]
        public string Symbol { get; set; }

        [DataMember(Name = "Description")]
        public string Description { get; set; }

        [DataMember(Name = "Price")]
        public float Price { get; set; }

        [DataMember(Name = "AsOfDate")]
        public DateTime AsOfDate { get; set; }

        [DataMember(Name = "PriceChange")]
        public float PriceChange { get; set; }

        [DataMember(Name = "PercentChange")]
        public float PercentChange { get; set; }

        [DataMember(Name = "RatingCollection")]
        public object RatingCollection { get; set; }

        [DataMember(Name = "IsHeld")]
        public bool IsHeld { get; set; }

        [DataMember(Name = "TradeCategory")]
        public int TradeCategory { get; set; }

        [DataMember(Name = "QuoteDataStatusCol")]
        public QuoteDataStatusCol[] QuoteDataStatusCol { get; set; }

        [DataMember(Name = "refreshOnClick")]
        public object RefreshOnClick { get; set; }

        [DataMember(Name = "RefreshVisible")]
        public string RefreshVisible { get; set; }

        [DataMember(Name = "ServiceSymbolType")]
        public int ServiceSymbolType { get; set; }

        [DataMember(Name = "DataType")]
        public string DataType { get; set; }

        [DataMember(Name = "SecurityType")]
        public int SecurityType { get; set; }

        [DataMember(Name = "ValidSecurityTypes")]
        public object ValidSecurityTypes { get; set; }

        [DataMember(Name = "RefreshADAText")]
        public string RefreshADAText { get; set; }
    }
}