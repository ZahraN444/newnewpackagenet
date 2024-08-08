// <copyright file="CountryExtendedEnum.cs" company="APIMatic">
// Copyright (c) APIMatic. All rights reserved.
// </copyright>
namespace Lob.Standard.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using APIMatic.Core.Utilities.Converters;
    using Lob.Standard;
    using Lob.Standard.Utilities;
    using Newtonsoft.Json;

    /// <summary>
    /// CountryExtendedEnum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum CountryExtendedEnum
    {
        /// <summary>
        /// AD.
        /// </summary>
        [EnumMember(Value = "AD")]
        AD,

        /// <summary>
        /// AE.
        /// </summary>
        [EnumMember(Value = "AE")]
        AE,

        /// <summary>
        /// AF.
        /// </summary>
        [EnumMember(Value = "AF")]
        AF,

        /// <summary>
        /// AG.
        /// </summary>
        [EnumMember(Value = "AG")]
        AG,

        /// <summary>
        /// AI.
        /// </summary>
        [EnumMember(Value = "AI")]
        AI,

        /// <summary>
        /// AL.
        /// </summary>
        [EnumMember(Value = "AL")]
        AL,

        /// <summary>
        /// AN.
        /// </summary>
        [EnumMember(Value = "AN")]
        AN,

        /// <summary>
        /// AO.
        /// </summary>
        [EnumMember(Value = "AO")]
        AO,

        /// <summary>
        /// AQ.
        /// </summary>
        [EnumMember(Value = "AQ")]
        AQ,

        /// <summary>
        /// AR.
        /// </summary>
        [EnumMember(Value = "AR")]
        AR,

        /// <summary>
        /// AT.
        /// </summary>
        [EnumMember(Value = "AT")]
        AT,

        /// <summary>
        /// AU.
        /// </summary>
        [EnumMember(Value = "AU")]
        AU,

        /// <summary>
        /// AW.
        /// </summary>
        [EnumMember(Value = "AW")]
        AW,

        /// <summary>
        /// AZ.
        /// </summary>
        [EnumMember(Value = "AZ")]
        AZ,

        /// <summary>
        /// BA.
        /// </summary>
        [EnumMember(Value = "BA")]
        BA,

        /// <summary>
        /// BB.
        /// </summary>
        [EnumMember(Value = "BB")]
        BB,

        /// <summary>
        /// BD.
        /// </summary>
        [EnumMember(Value = "BD")]
        BD,

        /// <summary>
        /// BE.
        /// </summary>
        [EnumMember(Value = "BE")]
        BE,

        /// <summary>
        /// BF.
        /// </summary>
        [EnumMember(Value = "BF")]
        BF,

        /// <summary>
        /// BG.
        /// </summary>
        [EnumMember(Value = "BG")]
        BG,

        /// <summary>
        /// BH.
        /// </summary>
        [EnumMember(Value = "BH")]
        BH,

        /// <summary>
        /// BI.
        /// </summary>
        [EnumMember(Value = "BI")]
        BI,

        /// <summary>
        /// BJ.
        /// </summary>
        [EnumMember(Value = "BJ")]
        BJ,

        /// <summary>
        /// BM.
        /// </summary>
        [EnumMember(Value = "BM")]
        BM,

        /// <summary>
        /// BN.
        /// </summary>
        [EnumMember(Value = "BN")]
        BN,

        /// <summary>
        /// BO.
        /// </summary>
        [EnumMember(Value = "BO")]
        BO,

        /// <summary>
        /// BQ.
        /// </summary>
        [EnumMember(Value = "BQ")]
        BQ,

        /// <summary>
        /// BR.
        /// </summary>
        [EnumMember(Value = "BR")]
        BR,

        /// <summary>
        /// BS.
        /// </summary>
        [EnumMember(Value = "BS")]
        BS,

        /// <summary>
        /// BT.
        /// </summary>
        [EnumMember(Value = "BT")]
        BT,

        /// <summary>
        /// BW.
        /// </summary>
        [EnumMember(Value = "BW")]
        BW,

        /// <summary>
        /// BY.
        /// </summary>
        [EnumMember(Value = "BY")]
        BY,

        /// <summary>
        /// BZ.
        /// </summary>
        [EnumMember(Value = "BZ")]
        BZ,

        /// <summary>
        /// CA.
        /// </summary>
        [EnumMember(Value = "CA")]
        CA,

        /// <summary>
        /// CD.
        /// </summary>
        [EnumMember(Value = "CD")]
        CD,

        /// <summary>
        /// CG.
        /// </summary>
        [EnumMember(Value = "CG")]
        CG,

        /// <summary>
        /// CH.
        /// </summary>
        [EnumMember(Value = "CH")]
        CH,

        /// <summary>
        /// CI.
        /// </summary>
        [EnumMember(Value = "CI")]
        CI,

        /// <summary>
        /// CK.
        /// </summary>
        [EnumMember(Value = "CK")]
        CK,

        /// <summary>
        /// CL.
        /// </summary>
        [EnumMember(Value = "CL")]
        CL,

        /// <summary>
        /// CM.
        /// </summary>
        [EnumMember(Value = "CM")]
        CM,

        /// <summary>
        /// CN.
        /// </summary>
        [EnumMember(Value = "CN")]
        CN,

        /// <summary>
        /// CO.
        /// </summary>
        [EnumMember(Value = "CO")]
        CO,

        /// <summary>
        /// CR.
        /// </summary>
        [EnumMember(Value = "CR")]
        CR,

        /// <summary>
        /// CS.
        /// </summary>
        [EnumMember(Value = "CS")]
        CS,

        /// <summary>
        /// CU.
        /// </summary>
        [EnumMember(Value = "CU")]
        CU,

        /// <summary>
        /// CV.
        /// </summary>
        [EnumMember(Value = "CV")]
        CV,

        /// <summary>
        /// CW.
        /// </summary>
        [EnumMember(Value = "CW")]
        CW,

        /// <summary>
        /// CY.
        /// </summary>
        [EnumMember(Value = "CY")]
        CY,

        /// <summary>
        /// CZ.
        /// </summary>
        [EnumMember(Value = "CZ")]
        CZ,

        /// <summary>
        /// DE.
        /// </summary>
        [EnumMember(Value = "DE")]
        DE,

        /// <summary>
        /// DJ.
        /// </summary>
        [EnumMember(Value = "DJ")]
        DJ,

        /// <summary>
        /// DK.
        /// </summary>
        [EnumMember(Value = "DK")]
        DK,

        /// <summary>
        /// DM.
        /// </summary>
        [EnumMember(Value = "DM")]
        DM,

        /// <summary>
        /// DO.
        /// </summary>
        [EnumMember(Value = "DO")]
        DO,

        /// <summary>
        /// DZ.
        /// </summary>
        [EnumMember(Value = "DZ")]
        DZ,

        /// <summary>
        /// EC.
        /// </summary>
        [EnumMember(Value = "EC")]
        EC,

        /// <summary>
        /// EE.
        /// </summary>
        [EnumMember(Value = "EE")]
        EE,

        /// <summary>
        /// EG.
        /// </summary>
        [EnumMember(Value = "EG")]
        EG,

        /// <summary>
        /// EH.
        /// </summary>
        [EnumMember(Value = "EH")]
        EH,

        /// <summary>
        /// ER.
        /// </summary>
        [EnumMember(Value = "ER")]
        ER,

        /// <summary>
        /// ES.
        /// </summary>
        [EnumMember(Value = "ES")]
        ES,

        /// <summary>
        /// ET.
        /// </summary>
        [EnumMember(Value = "ET")]
        ET,

        /// <summary>
        /// FI.
        /// </summary>
        [EnumMember(Value = "FI")]
        FI,

        /// <summary>
        /// FJ.
        /// </summary>
        [EnumMember(Value = "FJ")]
        FJ,

        /// <summary>
        /// FK.
        /// </summary>
        [EnumMember(Value = "FK")]
        FK,

        /// <summary>
        /// FO.
        /// </summary>
        [EnumMember(Value = "FO")]
        FO,

        /// <summary>
        /// FR.
        /// </summary>
        [EnumMember(Value = "FR")]
        FR,

        /// <summary>
        /// GA.
        /// </summary>
        [EnumMember(Value = "GA")]
        GA,

        /// <summary>
        /// GB.
        /// </summary>
        [EnumMember(Value = "GB")]
        GB,

        /// <summary>
        /// GD.
        /// </summary>
        [EnumMember(Value = "GD")]
        GD,

        /// <summary>
        /// GE.
        /// </summary>
        [EnumMember(Value = "GE")]
        GE,

        /// <summary>
        /// GH.
        /// </summary>
        [EnumMember(Value = "GH")]
        GH,

        /// <summary>
        /// GI.
        /// </summary>
        [EnumMember(Value = "GI")]
        GI,

        /// <summary>
        /// GL.
        /// </summary>
        [EnumMember(Value = "GL")]
        GL,

        /// <summary>
        /// GM.
        /// </summary>
        [EnumMember(Value = "GM")]
        GM,

        /// <summary>
        /// GN.
        /// </summary>
        [EnumMember(Value = "GN")]
        GN,

        /// <summary>
        /// GQ.
        /// </summary>
        [EnumMember(Value = "GQ")]
        GQ,

        /// <summary>
        /// GR.
        /// </summary>
        [EnumMember(Value = "GR")]
        GR,

        /// <summary>
        /// GS.
        /// </summary>
        [EnumMember(Value = "GS")]
        GS,

        /// <summary>
        /// GT.
        /// </summary>
        [EnumMember(Value = "GT")]
        GT,

        /// <summary>
        /// GW.
        /// </summary>
        [EnumMember(Value = "GW")]
        GW,

        /// <summary>
        /// GY.
        /// </summary>
        [EnumMember(Value = "GY")]
        GY,

        /// <summary>
        /// HK.
        /// </summary>
        [EnumMember(Value = "HK")]
        HK,

        /// <summary>
        /// HN.
        /// </summary>
        [EnumMember(Value = "HN")]
        HN,

        /// <summary>
        /// HR.
        /// </summary>
        [EnumMember(Value = "HR")]
        HR,

        /// <summary>
        /// HT.
        /// </summary>
        [EnumMember(Value = "HT")]
        HT,

        /// <summary>
        /// HU.
        /// </summary>
        [EnumMember(Value = "HU")]
        HU,

        /// <summary>
        /// ID.
        /// </summary>
        [EnumMember(Value = "ID")]
        ID,

        /// <summary>
        /// IE.
        /// </summary>
        [EnumMember(Value = "IE")]
        IE,

        /// <summary>
        /// IL.
        /// </summary>
        [EnumMember(Value = "IL")]
        IL,

        /// <summary>
        /// IN.
        /// </summary>
        [EnumMember(Value = "IN")]
        IN,

        /// <summary>
        /// IO.
        /// </summary>
        [EnumMember(Value = "IO")]
        IO,

        /// <summary>
        /// IQ.
        /// </summary>
        [EnumMember(Value = "IQ")]
        IQ,

        /// <summary>
        /// IR.
        /// </summary>
        [EnumMember(Value = "IR")]
        IR,

        /// <summary>
        /// IS.
        /// </summary>
        [EnumMember(Value = "IS")]
        IS,

        /// <summary>
        /// IT.
        /// </summary>
        [EnumMember(Value = "IT")]
        IT,

        /// <summary>
        /// JM.
        /// </summary>
        [EnumMember(Value = "JM")]
        JM,

        /// <summary>
        /// JO.
        /// </summary>
        [EnumMember(Value = "JO")]
        JO,

        /// <summary>
        /// JP.
        /// </summary>
        [EnumMember(Value = "JP")]
        JP,

        /// <summary>
        /// KE.
        /// </summary>
        [EnumMember(Value = "KE")]
        KE,

        /// <summary>
        /// KG.
        /// </summary>
        [EnumMember(Value = "KG")]
        KG,

        /// <summary>
        /// KH.
        /// </summary>
        [EnumMember(Value = "KH")]
        KH,

        /// <summary>
        /// KI.
        /// </summary>
        [EnumMember(Value = "KI")]
        KI,

        /// <summary>
        /// KM.
        /// </summary>
        [EnumMember(Value = "KM")]
        KM,

        /// <summary>
        /// KN.
        /// </summary>
        [EnumMember(Value = "KN")]
        KN,

        /// <summary>
        /// KP.
        /// </summary>
        [EnumMember(Value = "KP")]
        KP,

        /// <summary>
        /// KR.
        /// </summary>
        [EnumMember(Value = "KR")]
        KR,

        /// <summary>
        /// KW.
        /// </summary>
        [EnumMember(Value = "KW")]
        KW,

        /// <summary>
        /// KY.
        /// </summary>
        [EnumMember(Value = "KY")]
        KY,

        /// <summary>
        /// KZ.
        /// </summary>
        [EnumMember(Value = "KZ")]
        KZ,

        /// <summary>
        /// LA.
        /// </summary>
        [EnumMember(Value = "LA")]
        LA,

        /// <summary>
        /// LB.
        /// </summary>
        [EnumMember(Value = "LB")]
        LB,

        /// <summary>
        /// LC.
        /// </summary>
        [EnumMember(Value = "LC")]
        LC,

        /// <summary>
        /// LI.
        /// </summary>
        [EnumMember(Value = "LI")]
        LI,

        /// <summary>
        /// LK.
        /// </summary>
        [EnumMember(Value = "LK")]
        LK,

        /// <summary>
        /// LR.
        /// </summary>
        [EnumMember(Value = "LR")]
        LR,

        /// <summary>
        /// LS.
        /// </summary>
        [EnumMember(Value = "LS")]
        LS,

        /// <summary>
        /// LT.
        /// </summary>
        [EnumMember(Value = "LT")]
        LT,

        /// <summary>
        /// LU.
        /// </summary>
        [EnumMember(Value = "LU")]
        LU,

        /// <summary>
        /// LV.
        /// </summary>
        [EnumMember(Value = "LV")]
        LV,

        /// <summary>
        /// LY.
        /// </summary>
        [EnumMember(Value = "LY")]
        LY,

        /// <summary>
        /// MA.
        /// </summary>
        [EnumMember(Value = "MA")]
        MA,

        /// <summary>
        /// MC.
        /// </summary>
        [EnumMember(Value = "MC")]
        MC,

        /// <summary>
        /// MD.
        /// </summary>
        [EnumMember(Value = "MD")]
        MD,

        /// <summary>
        /// ME.
        /// </summary>
        [EnumMember(Value = "ME")]
        ME,

        /// <summary>
        /// MG.
        /// </summary>
        [EnumMember(Value = "MG")]
        MG,

        /// <summary>
        /// MK.
        /// </summary>
        [EnumMember(Value = "MK")]
        MK,

        /// <summary>
        /// ML.
        /// </summary>
        [EnumMember(Value = "ML")]
        ML,

        /// <summary>
        /// MM.
        /// </summary>
        [EnumMember(Value = "MM")]
        MM,

        /// <summary>
        /// MN.
        /// </summary>
        [EnumMember(Value = "MN")]
        MN,

        /// <summary>
        /// MO.
        /// </summary>
        [EnumMember(Value = "MO")]
        MO,

        /// <summary>
        /// MR.
        /// </summary>
        [EnumMember(Value = "MR")]
        MR,

        /// <summary>
        /// MS.
        /// </summary>
        [EnumMember(Value = "MS")]
        MS,

        /// <summary>
        /// MT.
        /// </summary>
        [EnumMember(Value = "MT")]
        MT,

        /// <summary>
        /// MU.
        /// </summary>
        [EnumMember(Value = "MU")]
        MU,

        /// <summary>
        /// MV.
        /// </summary>
        [EnumMember(Value = "MV")]
        MV,

        /// <summary>
        /// MW.
        /// </summary>
        [EnumMember(Value = "MW")]
        MW,

        /// <summary>
        /// MX.
        /// </summary>
        [EnumMember(Value = "MX")]
        MX,

        /// <summary>
        /// MY.
        /// </summary>
        [EnumMember(Value = "MY")]
        MY,

        /// <summary>
        /// MZ.
        /// </summary>
        [EnumMember(Value = "MZ")]
        MZ,

        /// <summary>
        /// NA.
        /// </summary>
        [EnumMember(Value = "NA")]
        NA,

        /// <summary>
        /// NE.
        /// </summary>
        [EnumMember(Value = "NE")]
        NE,

        /// <summary>
        /// NF.
        /// </summary>
        [EnumMember(Value = "NF")]
        NF,

        /// <summary>
        /// NG.
        /// </summary>
        [EnumMember(Value = "NG")]
        NG,

        /// <summary>
        /// NI.
        /// </summary>
        [EnumMember(Value = "NI")]
        NI,

        /// <summary>
        /// NL.
        /// </summary>
        [EnumMember(Value = "NL")]
        NL,

        /// <summary>
        /// NO.
        /// </summary>
        [EnumMember(Value = "NO")]
        NO,

        /// <summary>
        /// NP.
        /// </summary>
        [EnumMember(Value = "NP")]
        NP,

        /// <summary>
        /// NR.
        /// </summary>
        [EnumMember(Value = "NR")]
        NR,

        /// <summary>
        /// NU.
        /// </summary>
        [EnumMember(Value = "NU")]
        NU,

        /// <summary>
        /// NZ.
        /// </summary>
        [EnumMember(Value = "NZ")]
        NZ,

        /// <summary>
        /// OM.
        /// </summary>
        [EnumMember(Value = "OM")]
        OM,

        /// <summary>
        /// PA.
        /// </summary>
        [EnumMember(Value = "PA")]
        PA,

        /// <summary>
        /// PE.
        /// </summary>
        [EnumMember(Value = "PE")]
        PE,

        /// <summary>
        /// PG.
        /// </summary>
        [EnumMember(Value = "PG")]
        PG,

        /// <summary>
        /// PH.
        /// </summary>
        [EnumMember(Value = "PH")]
        PH,

        /// <summary>
        /// PK.
        /// </summary>
        [EnumMember(Value = "PK")]
        PK,

        /// <summary>
        /// PL.
        /// </summary>
        [EnumMember(Value = "PL")]
        PL,

        /// <summary>
        /// PN.
        /// </summary>
        [EnumMember(Value = "PN")]
        PN,

        /// <summary>
        /// PT.
        /// </summary>
        [EnumMember(Value = "PT")]
        PT,

        /// <summary>
        /// PY.
        /// </summary>
        [EnumMember(Value = "PY")]
        PY,

        /// <summary>
        /// QA.
        /// </summary>
        [EnumMember(Value = "QA")]
        QA,

        /// <summary>
        /// RO.
        /// </summary>
        [EnumMember(Value = "RO")]
        RO,

        /// <summary>
        /// RS.
        /// </summary>
        [EnumMember(Value = "RS")]
        RS,

        /// <summary>
        /// RU.
        /// </summary>
        [EnumMember(Value = "RU")]
        RU,

        /// <summary>
        /// RW.
        /// </summary>
        [EnumMember(Value = "RW")]
        RW,

        /// <summary>
        /// SA.
        /// </summary>
        [EnumMember(Value = "SA")]
        SA,

        /// <summary>
        /// SB.
        /// </summary>
        [EnumMember(Value = "SB")]
        SB,

        /// <summary>
        /// SC.
        /// </summary>
        [EnumMember(Value = "SC")]
        SC,

        /// <summary>
        /// SD.
        /// </summary>
        [EnumMember(Value = "SD")]
        SD,

        /// <summary>
        /// SE.
        /// </summary>
        [EnumMember(Value = "SE")]
        SE,

        /// <summary>
        /// SG.
        /// </summary>
        [EnumMember(Value = "SG")]
        SG,

        /// <summary>
        /// SH.
        /// </summary>
        [EnumMember(Value = "SH")]
        SH,

        /// <summary>
        /// SI.
        /// </summary>
        [EnumMember(Value = "SI")]
        SI,

        /// <summary>
        /// SK.
        /// </summary>
        [EnumMember(Value = "SK")]
        SK,

        /// <summary>
        /// SL.
        /// </summary>
        [EnumMember(Value = "SL")]
        SL,

        /// <summary>
        /// SM.
        /// </summary>
        [EnumMember(Value = "SM")]
        SM,

        /// <summary>
        /// SN.
        /// </summary>
        [EnumMember(Value = "SN")]
        SN,

        /// <summary>
        /// SO.
        /// </summary>
        [EnumMember(Value = "SO")]
        SO,

        /// <summary>
        /// SR.
        /// </summary>
        [EnumMember(Value = "SR")]
        SR,

        /// <summary>
        /// SS.
        /// </summary>
        [EnumMember(Value = "SS")]
        SS,

        /// <summary>
        /// ST.
        /// </summary>
        [EnumMember(Value = "ST")]
        ST,

        /// <summary>
        /// SV.
        /// </summary>
        [EnumMember(Value = "SV")]
        SV,

        /// <summary>
        /// SX.
        /// </summary>
        [EnumMember(Value = "SX")]
        SX,

        /// <summary>
        /// SY.
        /// </summary>
        [EnumMember(Value = "SY")]
        SY,

        /// <summary>
        /// SZ.
        /// </summary>
        [EnumMember(Value = "SZ")]
        SZ,

        /// <summary>
        /// TC.
        /// </summary>
        [EnumMember(Value = "TC")]
        TC,

        /// <summary>
        /// TD.
        /// </summary>
        [EnumMember(Value = "TD")]
        TD,

        /// <summary>
        /// TG.
        /// </summary>
        [EnumMember(Value = "TG")]
        TG,

        /// <summary>
        /// TH.
        /// </summary>
        [EnumMember(Value = "TH")]
        TH,

        /// <summary>
        /// TJ.
        /// </summary>
        [EnumMember(Value = "TJ")]
        TJ,

        /// <summary>
        /// TK.
        /// </summary>
        [EnumMember(Value = "TK")]
        TK,

        /// <summary>
        /// TL.
        /// </summary>
        [EnumMember(Value = "TL")]
        TL,

        /// <summary>
        /// TM.
        /// </summary>
        [EnumMember(Value = "TM")]
        TM,

        /// <summary>
        /// TN.
        /// </summary>
        [EnumMember(Value = "TN")]
        TN,

        /// <summary>
        /// TO.
        /// </summary>
        [EnumMember(Value = "TO")]
        TO,

        /// <summary>
        /// TR.
        /// </summary>
        [EnumMember(Value = "TR")]
        TR,

        /// <summary>
        /// TT.
        /// </summary>
        [EnumMember(Value = "TT")]
        TT,

        /// <summary>
        /// TV.
        /// </summary>
        [EnumMember(Value = "TV")]
        TV,

        /// <summary>
        /// TW.
        /// </summary>
        [EnumMember(Value = "TW")]
        TW,

        /// <summary>
        /// TZ.
        /// </summary>
        [EnumMember(Value = "TZ")]
        TZ,

        /// <summary>
        /// UA.
        /// </summary>
        [EnumMember(Value = "UA")]
        UA,

        /// <summary>
        /// UG.
        /// </summary>
        [EnumMember(Value = "UG")]
        UG,

        /// <summary>
        /// UY.
        /// </summary>
        [EnumMember(Value = "UY")]
        UY,

        /// <summary>
        /// UZ.
        /// </summary>
        [EnumMember(Value = "UZ")]
        UZ,

        /// <summary>
        /// VA.
        /// </summary>
        [EnumMember(Value = "VA")]
        VA,

        /// <summary>
        /// VC.
        /// </summary>
        [EnumMember(Value = "VC")]
        VC,

        /// <summary>
        /// VE.
        /// </summary>
        [EnumMember(Value = "VE")]
        VE,

        /// <summary>
        /// VG.
        /// </summary>
        [EnumMember(Value = "VG")]
        VG,

        /// <summary>
        /// VN.
        /// </summary>
        [EnumMember(Value = "VN")]
        VN,

        /// <summary>
        /// VU.
        /// </summary>
        [EnumMember(Value = "VU")]
        VU,

        /// <summary>
        /// WS.
        /// </summary>
        [EnumMember(Value = "WS")]
        WS,

        /// <summary>
        /// YE.
        /// </summary>
        [EnumMember(Value = "YE")]
        YE,

        /// <summary>
        /// ZA.
        /// </summary>
        [EnumMember(Value = "ZA")]
        ZA,

        /// <summary>
        /// ZM.
        /// </summary>
        [EnumMember(Value = "ZM")]
        ZM,

        /// <summary>
        /// ZW.
        /// </summary>
        [EnumMember(Value = "ZW")]
        ZW
    }
}