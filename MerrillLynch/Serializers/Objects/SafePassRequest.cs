using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class SafePassRequest
    {
        [DataMember(Name = "SafePassFunction")]
        public string SafePassFunction { get; set; }

        [DataMember(Name = "CurrentApplication")]
        public int CurrentApplication { get; set; }

        [DataMember(Name = "ShowSafePassIntroPanel")]
        public bool ShowSafePassIntroPanel { get; set; }

        [DataMember(Name = "ShowSafePassEntryPanel")]
        public bool ShowSafePassEntryPanel { get; set; }

        [DataMember(Name = "SafePassControlClientId")]
        public string SafePassControlClientId { get; set; }

        [DataMember(Name = "PopulateECMSOnlyForSafePassEntryPanel")]
        public bool PopulateECMSOnlyForSafePassEntryPanel { get; set; }

        [DataMember(Name = "SafePassCode")]
        public object SafePassCode { get; set; }

        [DataMember(Name = "IsStubSafePassRequest")]
        public bool IsStubSafePassRequest { get; set; }

        [DataMember(Name = "StubSafePassStatus")]
        public int StubSafePassStatus { get; set; }

        [DataMember(Name = "IntroHeaderRDN")]
        public string IntroHeaderRDN { get; set; }

        [DataMember(Name = "IntroFooterRDN")]
        public string IntroFooterRDN { get; set; }

        [DataMember(Name = "EntryHeaderRDN")]
        public string EntryHeaderRDN { get; set; }

        [DataMember(Name = "EntryMidRDN")]
        public string EntryMidRDN { get; set; }

        [DataMember(Name = "EntryFooterRDN")]
        public string EntryFooterRDN { get; set; }

        [DataMember(Name = "CurrentRUN")]
        public string CurrentRUN { get; set; }

        [DataMember(Name = "IsIntroHeaderContentParamsBased")]
        public bool IsIntroHeaderContentParamsBased { get; set; }

        [DataMember(Name = "IsIntroFooterContentParamsBased")]
        public bool IsIntroFooterContentParamsBased { get; set; }

        [DataMember(Name = "IsEntryHeaderContentParamsBased")]
        public bool IsEntryHeaderContentParamsBased { get; set; }

        [DataMember(Name = "IsEntryFooterContentParamsBased")]
        public bool IsEntryFooterContentParamsBased { get; set; }

        [DataMember(Name = "IsEntryMidContentParamsBased")]
        public bool IsEntryMidContentParamsBased { get; set; }

        [DataMember(Name = "CurrentMode")]
        public int CurrentMode { get; set; }

        [DataMember(Name = "AppFlowType")]
        public object AppFlowType { get; set; }

        [DataMember(Name = "AuthenticationRequested")]
        public bool AuthenticationRequested { get; set; }
    }
}