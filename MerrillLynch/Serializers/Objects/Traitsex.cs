using System.Runtime.Serialization;

namespace StockWatcher.MerrillLynch.Serializers.Objects
{
    [DataContract]
    public class Traitsex
    {
        [DataMember(Name = "AcctNm")]
        public string AcctNm { get; set; }

        [DataMember(Name = "AcctOwnStyleCd")]
        public string AcctOwnStyleCd { get; set; }

        [DataMember(Name = "VisaDate")]
        public string VisaDate { get; set; }

        [DataMember(Name = "AcctUniqueId")]
        public string AcctUniqueId { get; set; }

        [DataMember(Name = "AcctNickNmTx")]
        public string AcctNickNmTx { get; set; }

        [DataMember(Name = "TraitStatus")]
        public string TraitStatus { get; set; }

        [DataMember(Name = "CRFStatus")]
        public string CRFStatus { get; set; }

        [DataMember(Name = "AdvisoryAccountTypeCd")]
        public string AdvisoryAccountTypeCd { get; set; }

        [DataMember(Name = "AdvisoryAccountTypeDesc")]
        public string AdvisoryAccountTypeDesc { get; set; }

        [DataMember(Name = "WireCall")]
        public string WireCall { get; set; }

        [DataMember(Name = "ProducerId")]
        public string ProducerId { get; set; }

        [DataMember(Name = "OwnerType")]
        public string OwnerType { get; set; }

        [DataMember(Name = "OwnerDescription")]
        public string OwnerDescription { get; set; }

        [DataMember(Name = "BusOwnerDesc")]
        public string BusOwnerDesc { get; set; }

        [DataMember(Name = "BusOwnerType")]
        public string BusOwnerType { get; set; }

        [DataMember(Name = "Email")]
        public string Email { get; set; }

        [DataMember(Name = "AddressLine1")]
        public string AddressLine1 { get; set; }

        [DataMember(Name = "AddressLine2")]
        public string AddressLine2 { get; set; }

        [DataMember(Name = "AddressLine3")]
        public string AddressLine3 { get; set; }

        [DataMember(Name = "AddressLine4")]
        public string AddressLine4 { get; set; }

        [DataMember(Name = "AddressLine5")]
        public string AddressLine5 { get; set; }

        [DataMember(Name = "AddressLine6")]
        public string AddressLine6 { get; set; }

        [DataMember(Name = "AccountTIN")]
        public string AccountTIN { get; set; }

        [DataMember(Name = "AccountStateOfResidence")]
        public string AccountStateOfResidence { get; set; }

        [DataMember(Name = "mlTraitServiceType")]
        public string MlTraitServiceType { get; set; }

        [DataMember(Name = "mlTraitPriorityInd")]
        public string MlTraitPriorityInd { get; set; }

        [DataMember(Name = "mlTraitVisaGold")]
        public string MlTraitVisaGold { get; set; }

        [DataMember(Name = "mlTraitVisaClassic")]
        public string MlTraitVisaClassic { get; set; }

        [DataMember(Name = "mlTraitBusinessVisa")]
        public string MlTraitBusinessVisa { get; set; }

        [DataMember(Name = "mlTraitVisa")]
        public string MlTraitVisa { get; set; }

        [DataMember(Name = "mlTraitSignatureVisa")]
        public string MlTraitSignatureVisa { get; set; }

        [DataMember(Name = "mlTraitCheckFree")]
        public string MlTraitCheckFree { get; set; }

        [DataMember(Name = "mlTraitMLOL")]
        public string mlTraitMLOL { get; set; }

        [DataMember(Name = "mlTraitFTS")]
        public string mlTraitFTS { get; set; }

        [DataMember(Name = "mlTraitDirectDeposit")]
        public string MlTraitDirectDeposit { get; set; }

        [DataMember(Name = "mlTraitQuiken")]
        public string MlTraitQuiken { get; set; }

        [DataMember(Name = "mlTraitBeyondBanking")]
        public string MlTraitBeyondBanking { get; set; }

        [DataMember(Name = "VisaPartNumber")]
        public string VisaPartNumber { get; set; }

        [DataMember(Name = "mlTraitGlobalGold")]
        public string MlTraitGlobalGold { get; set; }

        [DataMember(Name = "mlTraitCoeInd")]
        public string MlTraitCoeInd { get; set; }

        [DataMember(Name = "mlTraitCoeStatus")]
        public string MlTraitCoeStatus { get; set; }

        [DataMember(Name = "mlTraitCoeEmpInd")]
        public string MlTraitCoeEmpInd { get; set; }

        [DataMember(Name = "mlTraitOwnerGroup")]
        public string MlTraitOwnerGroup { get; set; }

        [DataMember(Name = "mlTraitTEFRA")]
        public string MlTraitTEFRA { get; set; }

        [DataMember(Name = "mlTraitCashMng")]
        public string MlTraitCashMng { get; set; }

        [DataMember(Name = "mlTraitAccountCode")]
        public string MlTraitAccountCode { get; set; }

        [DataMember(Name = "mlTraitAccChecks")]
        public string MlTraitAccChecks { get; set; }

        [DataMember(Name = "mlTraitIOoeInd")]
        public string MlTraitIOoeInd { get; set; }

        [DataMember(Name = "mlTraitMfundOeInd")]
        public string MlTraitMfundOeInd { get; set; }

        [DataMember(Name = "mlTraitCdOeInd")]
        public string MlTraitCdOeInd { get; set; }

        [DataMember(Name = "mlTraitCorpBondOeInd")]
        public string MlTraitCorpBondOeInd { get; set; }

        [DataMember(Name = "mlTraitMuniBondOeInd")]
        public string MlTraitMuniBondOeInd { get; set; }

        [DataMember(Name = "mlTraitZeroCoupOeInd")]
        public string MlTraitZeroCoupOeInd { get; set; }

        [DataMember(Name = "mlTraitMortBackOeInd")]
        public string MlTraitMortBackOeInd { get; set; }

        [DataMember(Name = "mlTraitUsTreasOeInd")]
        public string MlTraitUsTreasOeInd { get; set; }

        [DataMember(Name = "mlTraitIntrBondOeInd")]
        public string MlTraitIntrBondOeInd { get; set; }

        [DataMember(Name = "mlTraitUnlimAdvInd")]
        public string MlTraitUnlimAdvInd { get; set; }

        [DataMember(Name = "DistrictWireCode")]
        public string DistrictWireCode { get; set; }

        [DataMember(Name = "DivisionWireCode")]
        public string DivisionWireCode { get; set; }

        [DataMember(Name = "mlTraitPIAI")]
        public string MlTraitPiai { get; set; }

        [DataMember(Name = "mlTraitDISC")]
        public string MlTraitDISC { get; set; }

        [DataMember(Name = "mlTraitRCMA")]
        public string MlTraitRcma { get; set; }

        [DataMember(Name = "mlTraitCSLT")]
        public string MlTraitCSLT { get; set; }

        [DataMember(Name = "mlTraitDACC")]
        public string MlTraitDACC { get; set; }

        [DataMember(Name = "mlPropPHON")]
        public string MlPropPHON { get; set; }

        [DataMember(Name = "mlPropDSNM")]
        public string MlPropDSNM { get; set; }

        [DataMember(Name = "mlTraitPROF")]
        public string MlTraitProf { get; set; }

        [DataMember(Name = "mlTraitTEFRA2")]
        public string MlTraitTEFRA2 { get; set; }

        [DataMember(Name = "mlTraitFACOnline")]
        public string MlTraitFACOnline { get; set; }

        [DataMember(Name = "mlTraitOneClick")]
        public string MlTraitOneClick { get; set; }

        [DataMember(Name = "mlTraitIntExSop")]
        public string MlTraitIntExSop { get; set; }

        [DataMember(Name = "mlTraitOfficerInd")]
        public string MlTraitOfficerInd { get; set; }

        [DataMember(Name = "mlTraitBBLink")]
        public string MlTraitBBLink { get; set; }

        [DataMember(Name = "PriorityService")]
        public string PriorityService { get; set; }

        [DataMember(Name = "PrimaryServiceTypeCd")]
        public string PrimaryServiceTypeCd { get; set; }

        [DataMember(Name = "ConfidentialInd")]
        public string ConfidentialInd { get; set; }

        [DataMember(Name = "SDATypeCode")]
        public string SDATypeCode { get; set; }

        [DataMember(Name = "SDAPlan")]
        public string SDAPlan { get; set; }

        [DataMember(Name = "SDASSN")]
        public string SDASSN { get; set; }

        [DataMember(Name = "mlTraitRubicon")]
        public string MlTraitRubicon { get; set; }

        [DataMember(Name = "mlTraitFAC")]
        public string MlTraitFAC { get; set; }

        [DataMember(Name = "mlTraitLMA")]
        public string MlTraitLMA { get; set; }

        [DataMember(Name = "mlTrait3Pty")]
        public string MlTrait3Pty { get; set; }

        [DataMember(Name = "mlTraitBIA")]
        public string MlTraitBIA { get; set; }

        [DataMember(Name = "AccountOpenDate")]
        public string AccountOpenDate { get; set; }

        [DataMember(Name = "AccountCloseIndicator")]
        public string AccountCloseIndicator { get; set; }

        [DataMember(Name = "mlTraitAAA")]
        public string MlTraitAAA { get; set; }

        [DataMember(Name = "mlTraitTrustPI")]
        public string MlTraitTrustPi { get; set; }

        [DataMember(Name = "mlTraitPWA")]
        public string MlTraitPwa { get; set; }

        [DataMember(Name = "mlTraitMLPA")]
        public string MlTraitMLPA { get; set; }

        [DataMember(Name = "mlTraitFX")]
        public string MlTraitFX { get; set; }

        [DataMember(Name = "mlTraitFIRM")]
        public string MlTraitFIRM { get; set; }

        [DataMember(Name = "mlTraitAccFinGrCd")]
        public string MlTraitAccFinGrCd { get; set; }

        [DataMember(Name = "mlTraitMNGRln1")]
        public string MlTraitMNGRln1 { get; set; }

        [DataMember(Name = "MlTraitMNGRln2")]
        public string MlTraitMNGRln2 { get; set; }

        [DataMember(Name = "mlTraitMNGRphone")]
        public string MlTraitMNGRphone { get; set; }

        [DataMember(Name = "mlAccountService")]
        public string MlAccountService { get; set; }

        [DataMember(Name = "mlTraitMNGRAccInd")]
        public string MlTraitMNGRAccInd { get; set; }

        [DataMember(Name = "mlMngrStyle")]
        public string MlMngrStyle { get; set; }

        [DataMember(Name = "RetirementCloseIndicator")]
        public string RetirementCloseIndicator { get; set; }

        [DataMember(Name = "mlLimIndInvInd")]
        public string MlLimIndInvInd { get; set; }

        [DataMember(Name = "mlTraitASSTconvDT")]
        public string MlTraitASSTconvDT { get; set; }

        [DataMember(Name = "mlTraitNFSacc")]
        public string MlTraitNFSacc { get; set; }

        [DataMember(Name = "mlTraitCONVind")]
        public string MlTraitCONVind { get; set; }

        [DataMember(Name = "mlTraitPerfRptInd")]
        public string MlTraitPerfRptInd { get; set; }

        [DataMember(Name = "mlTraitProgramCode")]
        public string MlTraitProgramCode { get; set; }

        [DataMember(Name = "DOLAccountInScopeInd")]
        public string DOLAccountInScopeInd { get; set; }

        [DataMember(Name = "LegacyAssetExemptInd")]
        public string LegacyAssetExemptInd { get; set; }

        [DataMember(Name = "ClientContactType")]
        public string ClientContactType { get; set; }

        [DataMember(Name = "RolloverAttestationCode")]
        public string RolloverAttestationCode { get; set; }

        [DataMember(Name = "LAEReasonCode")]
        public string LAEReasonCode { get; set; }

        [DataMember(Name = "DRACode")]
        public string DRACode { get; set; }

        [DataMember(Name = "GESTrait")]
        public string GESTrait { get; set; }
    }
}