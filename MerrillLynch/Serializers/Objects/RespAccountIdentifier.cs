using System;
using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class RespAccountIdentifier
    {
        [DataMember(Name = "_managedAcctCode")]
        public object _managedAcctCode { get; set; }

        [DataMember(Name = "_managedInd")]
        public bool _managedInd { get; set; }

        [DataMember(Name = "_managerName")]
        public string _managerName { get; set; }

        [DataMember(Name = "_managerStyle")]
        public string _managerStyle { get; set; }

        [DataMember(Name = "FAVisibilityInd")]
        public bool FAVisibilityInd { get; set; }

        [DataMember(Name = "LIIAInd")]
        public object LIIAInd { get; set; }

        [DataMember(Name = "OAInd")]
        public object OAInd { get; set; }

        [DataMember(Name = "TradeAccessInd")]
        public string TradeAccessInd { get; set; }

        [DataMember(Name = "FXTraitInd")]
        public bool FXTraitInd { get; set; }

        [DataMember(Name = "ConfidentialInd")]
        public bool ConfidentialInd { get; set; }

        [DataMember(Name = "NFSConversionInd")]
        public bool NFSConversionInd { get; set; }

        [DataMember(Name = "Nickname")]
        public object Nickname { get; set; }

        [DataMember(Name = "Entity")]
        public string Entity { get; set; }

        [DataMember(Name = "ProductCode")]
        public string ProductCode { get; set; }

        [DataMember(Name = "ProductSubCode")]
        public object ProductSubCode { get; set; }

        [DataMember(Name = "MarginInd")]
        public bool MarginInd { get; set; }

        [DataMember(Name = "LoanInd")]
        public bool LoanInd { get; set; }

        [DataMember(Name = "BusinessInd")]
        public bool BusinessInd { get; set; }

        [DataMember(Name = "PledgeInd")]
        public bool PledgeInd { get; set; }

        [DataMember(Name = "ChargeCards")]
        public object ChargeCards { get; set; }

        [DataMember(Name = "ManagedAcctCode")]
        public object ManagedAcctCode { get; set; }

        [DataMember(Name = "ManagedInd")]
        public bool ManagedInd { get; set; }

        [DataMember(Name = "ManagerName")]
        public string ManagerName { get; set; }

        [DataMember(Name = "ManagerStyle")]
        public string ManagerStyle { get; set; }

        [DataMember(Name = "AccountRestriction")]
        public AccountRestriction AccountRestriction { get; set; }

        [DataMember(Name = "ThirdPartyInd")]
        public object ThirdPartyInd { get; set; }

        [DataMember(Name = "ThirdPartyIdentifier")]
        public object ThirdPartyIdentifier { get; set; }

        [DataMember(Name = "AccessMask")]
        public string AccessMask { get; set; }

        [DataMember(Name = "AssetLiabilityInd")]
        public int AssetLiabilityInd { get; set; }

        [DataMember(Name = "TraitsEx")]
        public Traitsex TraitsEx { get; set; }

        [DataMember(Name = "Traits")]
        public Trait[] Traits { get; set; }

        [DataMember(Name = "DisplayInfo")]
        public DisplayInfo DisplayInfo { get; set; }

        [DataMember(Name = "AccountTypeForNavigationMatrix")]
        public string AccountTypeForNavigationMatrix { get; set; }

        [DataMember(Name = "AccountStatusForNavigationMatrix")]
        public string AccountStatusForNavigationMatrix { get; set; }

        [DataMember(Name = "FAVisibilityIndicator")]
        public bool FAVisibilityIndicator { get; set; }

        [DataMember(Name = "Identifier")]
        public Identifier Identifier { get; set; }

        [DataMember(Name = "IsActive")]
        public bool? IsActive { get; set; }

        [DataMember(Name = "OpenDate")]
        public DateTime? OpenDate { get; set; }

        [DataMember(Name = "OwnershipType")]
        public string OwnershipType { get; set; }

        [DataMember(Name = "Index")]
        public int Index { get; set; }

        [DataMember(Name = "EncryptedToken")]
        public object EncryptedToken { get; set; }

        [DataMember(Name = "AcctRelTypCd")]
        public string AcctRelTypCd { get; set; }
    }
}