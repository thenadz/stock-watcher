﻿using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class AccountRestriction
    {
        [DataMember(Name = "Code")]
        public string Code { get; set; }

        [DataMember(Name = "Value")]
        public string Value { get; set; }
    }
}