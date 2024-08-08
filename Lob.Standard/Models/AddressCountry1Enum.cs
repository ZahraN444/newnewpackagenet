// <copyright file="AddressCountry1Enum.cs" company="APIMatic">
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
    /// AddressCountry1Enum.
    /// </summary>

    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressCountry1Enum
    {
        /// <summary>
        /// AFGHANISTAN.
        /// </summary>
        [EnumMember(Value = "AFGHANISTAN")]
        AFGHANISTAN,

        /// <summary>
        /// ALBANIA.
        /// </summary>
        [EnumMember(Value = "ALBANIA")]
        ALBANIA,

        /// <summary>
        /// ALGERIA.
        /// </summary>
        [EnumMember(Value = "ALGERIA")]
        ALGERIA,

        /// <summary>
        /// EnumAMERICANSAMOA.
        /// </summary>
        [EnumMember(Value = "AMERICAN SAMOA")]
        EnumAMERICANSAMOA,

        /// <summary>
        /// ANDORRA.
        /// </summary>
        [EnumMember(Value = "ANDORRA")]
        ANDORRA,

        /// <summary>
        /// ANGOLA.
        /// </summary>
        [EnumMember(Value = "ANGOLA")]
        ANGOLA,

        /// <summary>
        /// ANGUILLA.
        /// </summary>
        [EnumMember(Value = "ANGUILLA")]
        ANGUILLA,

        /// <summary>
        /// ANTARCTICA.
        /// </summary>
        [EnumMember(Value = "ANTARCTICA")]
        ANTARCTICA,

        /// <summary>
        /// EnumANTIGUAANDBARBUDA.
        /// </summary>
        [EnumMember(Value = "ANTIGUA AND BARBUDA")]
        EnumANTIGUAANDBARBUDA,

        /// <summary>
        /// ARGENTINA.
        /// </summary>
        [EnumMember(Value = "ARGENTINA")]
        ARGENTINA,

        /// <summary>
        /// ARUBA.
        /// </summary>
        [EnumMember(Value = "ARUBA")]
        ARUBA,

        /// <summary>
        /// AUSTRALIA.
        /// </summary>
        [EnumMember(Value = "AUSTRALIA")]
        AUSTRALIA,

        /// <summary>
        /// AUSTRIA.
        /// </summary>
        [EnumMember(Value = "AUSTRIA")]
        AUSTRIA,

        /// <summary>
        /// AZERBAIJAN.
        /// </summary>
        [EnumMember(Value = "AZERBAIJAN")]
        AZERBAIJAN,

        /// <summary>
        /// BAHRAIN.
        /// </summary>
        [EnumMember(Value = "BAHRAIN")]
        BAHRAIN,

        /// <summary>
        /// BANGLADESH.
        /// </summary>
        [EnumMember(Value = "BANGLADESH")]
        BANGLADESH,

        /// <summary>
        /// BARBADOS.
        /// </summary>
        [EnumMember(Value = "BARBADOS")]
        BARBADOS,

        /// <summary>
        /// BELARUS.
        /// </summary>
        [EnumMember(Value = "BELARUS")]
        BELARUS,

        /// <summary>
        /// BELGIUM.
        /// </summary>
        [EnumMember(Value = "BELGIUM")]
        BELGIUM,

        /// <summary>
        /// BELIZE.
        /// </summary>
        [EnumMember(Value = "BELIZE")]
        BELIZE,

        /// <summary>
        /// BENIN.
        /// </summary>
        [EnumMember(Value = "BENIN")]
        BENIN,

        /// <summary>
        /// BERMUDA.
        /// </summary>
        [EnumMember(Value = "BERMUDA")]
        BERMUDA,

        /// <summary>
        /// BHUTAN.
        /// </summary>
        [EnumMember(Value = "BHUTAN")]
        BHUTAN,

        /// <summary>
        /// EnumBOLIVIAPLURINATIONALSTATEOF.
        /// </summary>
        [EnumMember(Value = "BOLIVIA (PLURINATIONAL STATE OF)")]
        EnumBOLIVIAPLURINATIONALSTATEOF,

        /// <summary>
        /// EnumBONAIRESAINTEUSTATIUSANDSABA.
        /// </summary>
        [EnumMember(Value = "BONAIRE, SAINT EUSTATIUS AND SABA")]
        EnumBONAIRESAINTEUSTATIUSANDSABA,

        /// <summary>
        /// EnumBOSNIAANDHERZEGOVINA.
        /// </summary>
        [EnumMember(Value = "BOSNIA AND HERZEGOVINA")]
        EnumBOSNIAANDHERZEGOVINA,

        /// <summary>
        /// BOTSWANA.
        /// </summary>
        [EnumMember(Value = "BOTSWANA")]
        BOTSWANA,

        /// <summary>
        /// BRAZIL.
        /// </summary>
        [EnumMember(Value = "BRAZIL")]
        BRAZIL,

        /// <summary>
        /// EnumBRITISHINDIANOCEANTERRITORY.
        /// </summary>
        [EnumMember(Value = "BRITISH INDIAN OCEAN TERRITORY")]
        EnumBRITISHINDIANOCEANTERRITORY,

        /// <summary>
        /// EnumBRITISHVIRGINISLANDS.
        /// </summary>
        [EnumMember(Value = "BRITISH VIRGIN ISLANDS")]
        EnumBRITISHVIRGINISLANDS,

        /// <summary>
        /// EnumBRUNEIDARUSSALAM.
        /// </summary>
        [EnumMember(Value = "BRUNEI DARUSSALAM")]
        EnumBRUNEIDARUSSALAM,

        /// <summary>
        /// BULGARIA.
        /// </summary>
        [EnumMember(Value = "BULGARIA")]
        BULGARIA,

        /// <summary>
        /// EnumBURKINAFASO.
        /// </summary>
        [EnumMember(Value = "BURKINA FASO")]
        EnumBURKINAFASO,

        /// <summary>
        /// BURUNDI.
        /// </summary>
        [EnumMember(Value = "BURUNDI")]
        BURUNDI,

        /// <summary>
        /// EnumCABOVERDE.
        /// </summary>
        [EnumMember(Value = "CABO VERDE")]
        EnumCABOVERDE,

        /// <summary>
        /// CAMBODIA.
        /// </summary>
        [EnumMember(Value = "CAMBODIA")]
        CAMBODIA,

        /// <summary>
        /// CAMEROON.
        /// </summary>
        [EnumMember(Value = "CAMEROON")]
        CAMEROON,

        /// <summary>
        /// CANADA.
        /// </summary>
        [EnumMember(Value = "CANADA")]
        CANADA,

        /// <summary>
        /// EnumCAYMANISLANDS.
        /// </summary>
        [EnumMember(Value = "CAYMAN ISLANDS")]
        EnumCAYMANISLANDS,

        /// <summary>
        /// EnumCENTRALAFRICANREPUBLIC.
        /// </summary>
        [EnumMember(Value = "CENTRAL AFRICAN REPUBLIC")]
        EnumCENTRALAFRICANREPUBLIC,

        /// <summary>
        /// CHAD.
        /// </summary>
        [EnumMember(Value = "CHAD")]
        CHAD,

        /// <summary>
        /// CHILE.
        /// </summary>
        [EnumMember(Value = "CHILE")]
        CHILE,

        /// <summary>
        /// CHINA.
        /// </summary>
        [EnumMember(Value = "CHINA")]
        CHINA,

        /// <summary>
        /// COLOMBIA.
        /// </summary>
        [EnumMember(Value = "COLOMBIA")]
        COLOMBIA,

        /// <summary>
        /// COMOROS.
        /// </summary>
        [EnumMember(Value = "COMOROS")]
        COMOROS,

        /// <summary>
        /// CONGO.
        /// </summary>
        [EnumMember(Value = "CONGO")]
        CONGO,

        /// <summary>
        /// EnumCONGODEMOCRATICREPUBLICOFTHE.
        /// </summary>
        [EnumMember(Value = "CONGO, DEMOCRATIC REPUBLIC OF THE")]
        EnumCONGODEMOCRATICREPUBLICOFTHE,

        /// <summary>
        /// EnumCOOKISLANDS.
        /// </summary>
        [EnumMember(Value = "COOK ISLANDS")]
        EnumCOOKISLANDS,

        /// <summary>
        /// EnumCOSTARICA.
        /// </summary>
        [EnumMember(Value = "COSTA RICA")]
        EnumCOSTARICA,

        /// <summary>
        /// EnumCTEDIVOIRE.
        /// </summary>
        [EnumMember(Value = "CÔTE D'IVOIRE")]
        EnumCTEDIVOIRE,

        /// <summary>
        /// CROATIA.
        /// </summary>
        [EnumMember(Value = "CROATIA")]
        CROATIA,

        /// <summary>
        /// CUBA.
        /// </summary>
        [EnumMember(Value = "CUBA")]
        CUBA,

        /// <summary>
        /// CURAAO.
        /// </summary>
        [EnumMember(Value = "CURAÇAO")]
        CURAAO,

        /// <summary>
        /// CYPRUS.
        /// </summary>
        [EnumMember(Value = "CYPRUS")]
        CYPRUS,

        /// <summary>
        /// EnumCZECHREPUBLIC.
        /// </summary>
        [EnumMember(Value = "CZECH REPUBLIC")]
        EnumCZECHREPUBLIC,

        /// <summary>
        /// DENMARK.
        /// </summary>
        [EnumMember(Value = "DENMARK")]
        DENMARK,

        /// <summary>
        /// DJIBOUTI.
        /// </summary>
        [EnumMember(Value = "DJIBOUTI")]
        DJIBOUTI,

        /// <summary>
        /// DOMINICA.
        /// </summary>
        [EnumMember(Value = "DOMINICA")]
        DOMINICA,

        /// <summary>
        /// EnumDOMINICANREPUBLIC.
        /// </summary>
        [EnumMember(Value = "DOMINICAN REPUBLIC")]
        EnumDOMINICANREPUBLIC,

        /// <summary>
        /// ECUADOR.
        /// </summary>
        [EnumMember(Value = "ECUADOR")]
        ECUADOR,

        /// <summary>
        /// EGYPT.
        /// </summary>
        [EnumMember(Value = "EGYPT")]
        EGYPT,

        /// <summary>
        /// EnumELSALVADOR.
        /// </summary>
        [EnumMember(Value = "EL SALVADOR")]
        EnumELSALVADOR,

        /// <summary>
        /// EnumEQUATORIALGUINEA.
        /// </summary>
        [EnumMember(Value = "EQUATORIAL GUINEA")]
        EnumEQUATORIALGUINEA,

        /// <summary>
        /// ERITREA.
        /// </summary>
        [EnumMember(Value = "ERITREA")]
        ERITREA,

        /// <summary>
        /// ESTONIA.
        /// </summary>
        [EnumMember(Value = "ESTONIA")]
        ESTONIA,

        /// <summary>
        /// ESWATINI.
        /// </summary>
        [EnumMember(Value = "ESWATINI")]
        ESWATINI,

        /// <summary>
        /// ETHIOPIA.
        /// </summary>
        [EnumMember(Value = "ETHIOPIA")]
        ETHIOPIA,

        /// <summary>
        /// EnumFALKLANDISLANDSMALVINAS.
        /// </summary>
        [EnumMember(Value = "FALKLAND ISLANDS (MALVINAS)")]
        EnumFALKLANDISLANDSMALVINAS,

        /// <summary>
        /// EnumFAROEISLANDS.
        /// </summary>
        [EnumMember(Value = "FAROE ISLANDS")]
        EnumFAROEISLANDS,

        /// <summary>
        /// FIJI.
        /// </summary>
        [EnumMember(Value = "FIJI")]
        FIJI,

        /// <summary>
        /// FINLAND.
        /// </summary>
        [EnumMember(Value = "FINLAND")]
        FINLAND,

        /// <summary>
        /// FRANCE.
        /// </summary>
        [EnumMember(Value = "FRANCE")]
        FRANCE,

        /// <summary>
        /// GABON.
        /// </summary>
        [EnumMember(Value = "GABON")]
        GABON,

        /// <summary>
        /// GAMBIA.
        /// </summary>
        [EnumMember(Value = "GAMBIA")]
        GAMBIA,

        /// <summary>
        /// GEORGIA.
        /// </summary>
        [EnumMember(Value = "GEORGIA")]
        GEORGIA,

        /// <summary>
        /// GERMANY.
        /// </summary>
        [EnumMember(Value = "GERMANY")]
        GERMANY,

        /// <summary>
        /// GHANA.
        /// </summary>
        [EnumMember(Value = "GHANA")]
        GHANA,

        /// <summary>
        /// GIBRALTAR.
        /// </summary>
        [EnumMember(Value = "GIBRALTAR")]
        GIBRALTAR,

        /// <summary>
        /// GREECE.
        /// </summary>
        [EnumMember(Value = "GREECE")]
        GREECE,

        /// <summary>
        /// GREENLAND.
        /// </summary>
        [EnumMember(Value = "GREENLAND")]
        GREENLAND,

        /// <summary>
        /// GRENADA.
        /// </summary>
        [EnumMember(Value = "GRENADA")]
        GRENADA,

        /// <summary>
        /// GUATEMALA.
        /// </summary>
        [EnumMember(Value = "GUATEMALA")]
        GUATEMALA,

        /// <summary>
        /// GUINEA.
        /// </summary>
        [EnumMember(Value = "GUINEA")]
        GUINEA,

        /// <summary>
        /// GUINEABISSAU.
        /// </summary>
        [EnumMember(Value = "GUINEA-BISSAU")]
        GUINEABISSAU,

        /// <summary>
        /// GUYANA.
        /// </summary>
        [EnumMember(Value = "GUYANA")]
        GUYANA,

        /// <summary>
        /// HAITI.
        /// </summary>
        [EnumMember(Value = "HAITI")]
        HAITI,

        /// <summary>
        /// EnumHOLYSEE.
        /// </summary>
        [EnumMember(Value = "HOLY SEE")]
        EnumHOLYSEE,

        /// <summary>
        /// HONDURAS.
        /// </summary>
        [EnumMember(Value = "HONDURAS")]
        HONDURAS,

        /// <summary>
        /// EnumHONGKONG.
        /// </summary>
        [EnumMember(Value = "HONG KONG")]
        EnumHONGKONG,

        /// <summary>
        /// HUNGARY.
        /// </summary>
        [EnumMember(Value = "HUNGARY")]
        HUNGARY,

        /// <summary>
        /// ICELAND.
        /// </summary>
        [EnumMember(Value = "ICELAND")]
        ICELAND,

        /// <summary>
        /// INDIA.
        /// </summary>
        [EnumMember(Value = "INDIA")]
        INDIA,

        /// <summary>
        /// INDONESIA.
        /// </summary>
        [EnumMember(Value = "INDONESIA")]
        INDONESIA,

        /// <summary>
        /// EnumIRANISLAMICREPUBLICOF.
        /// </summary>
        [EnumMember(Value = "IRAN (ISLAMIC REPUBLIC OF)")]
        EnumIRANISLAMICREPUBLICOF,

        /// <summary>
        /// IRAQ.
        /// </summary>
        [EnumMember(Value = "IRAQ")]
        IRAQ,

        /// <summary>
        /// IRELAND.
        /// </summary>
        [EnumMember(Value = "IRELAND")]
        IRELAND,

        /// <summary>
        /// ISRAEL.
        /// </summary>
        [EnumMember(Value = "ISRAEL")]
        ISRAEL,

        /// <summary>
        /// ITALY.
        /// </summary>
        [EnumMember(Value = "ITALY")]
        ITALY,

        /// <summary>
        /// JAMAICA.
        /// </summary>
        [EnumMember(Value = "JAMAICA")]
        JAMAICA,

        /// <summary>
        /// JAPAN.
        /// </summary>
        [EnumMember(Value = "JAPAN")]
        JAPAN,

        /// <summary>
        /// JORDAN.
        /// </summary>
        [EnumMember(Value = "JORDAN")]
        JORDAN,

        /// <summary>
        /// KAZAKHSTAN.
        /// </summary>
        [EnumMember(Value = "KAZAKHSTAN")]
        KAZAKHSTAN,

        /// <summary>
        /// KENYA.
        /// </summary>
        [EnumMember(Value = "KENYA")]
        KENYA,

        /// <summary>
        /// KIRIBATI.
        /// </summary>
        [EnumMember(Value = "KIRIBATI")]
        KIRIBATI,

        /// <summary>
        /// EnumKOREADEMOCRATICPEOPLESREPUBLICOF.
        /// </summary>
        [EnumMember(Value = "KOREA (DEMOCRATIC PEOPLE’S REPUBLIC OF)")]
        EnumKOREADEMOCRATICPEOPLESREPUBLICOF,

        /// <summary>
        /// EnumKOREAREPUBLICOF.
        /// </summary>
        [EnumMember(Value = "KOREA, REPUBLIC OF")]
        EnumKOREAREPUBLICOF,

        /// <summary>
        /// KUWAIT.
        /// </summary>
        [EnumMember(Value = "KUWAIT")]
        KUWAIT,

        /// <summary>
        /// KYRGYZSTAN.
        /// </summary>
        [EnumMember(Value = "KYRGYZSTAN")]
        KYRGYZSTAN,

        /// <summary>
        /// EnumLAOPEOPLESDEMOCRATICREPUBLIC.
        /// </summary>
        [EnumMember(Value = "LAO PEOPLE’S DEMOCRATIC REPUBLIC")]
        EnumLAOPEOPLESDEMOCRATICREPUBLIC,

        /// <summary>
        /// LATVIA.
        /// </summary>
        [EnumMember(Value = "LATVIA")]
        LATVIA,

        /// <summary>
        /// LEBANON.
        /// </summary>
        [EnumMember(Value = "LEBANON")]
        LEBANON,

        /// <summary>
        /// LESOTHO.
        /// </summary>
        [EnumMember(Value = "LESOTHO")]
        LESOTHO,

        /// <summary>
        /// LIBERIA.
        /// </summary>
        [EnumMember(Value = "LIBERIA")]
        LIBERIA,

        /// <summary>
        /// LIBYA.
        /// </summary>
        [EnumMember(Value = "LIBYA")]
        LIBYA,

        /// <summary>
        /// LIECHTENSTEIN.
        /// </summary>
        [EnumMember(Value = "LIECHTENSTEIN")]
        LIECHTENSTEIN,

        /// <summary>
        /// LITHUANIA.
        /// </summary>
        [EnumMember(Value = "LITHUANIA")]
        LITHUANIA,

        /// <summary>
        /// LUXEMBOURG.
        /// </summary>
        [EnumMember(Value = "LUXEMBOURG")]
        LUXEMBOURG,

        /// <summary>
        /// MACAO.
        /// </summary>
        [EnumMember(Value = "MACAO")]
        MACAO,

        /// <summary>
        /// MACEDONIA.
        /// </summary>
        [EnumMember(Value = "MACEDONIA")]
        MACEDONIA,

        /// <summary>
        /// MADAGASCAR.
        /// </summary>
        [EnumMember(Value = "MADAGASCAR")]
        MADAGASCAR,

        /// <summary>
        /// MALAWI.
        /// </summary>
        [EnumMember(Value = "MALAWI")]
        MALAWI,

        /// <summary>
        /// MALAYSIA.
        /// </summary>
        [EnumMember(Value = "MALAYSIA")]
        MALAYSIA,

        /// <summary>
        /// MALDIVES.
        /// </summary>
        [EnumMember(Value = "MALDIVES")]
        MALDIVES,

        /// <summary>
        /// MALI.
        /// </summary>
        [EnumMember(Value = "MALI")]
        MALI,

        /// <summary>
        /// MALTA.
        /// </summary>
        [EnumMember(Value = "MALTA")]
        MALTA,

        /// <summary>
        /// MAURITANIA.
        /// </summary>
        [EnumMember(Value = "MAURITANIA")]
        MAURITANIA,

        /// <summary>
        /// MAURITIUS.
        /// </summary>
        [EnumMember(Value = "MAURITIUS")]
        MAURITIUS,

        /// <summary>
        /// MEXICO.
        /// </summary>
        [EnumMember(Value = "MEXICO")]
        MEXICO,

        /// <summary>
        /// EnumMOLDOVAREPUBLICOF.
        /// </summary>
        [EnumMember(Value = "MOLDOVA, REPUBLIC OF")]
        EnumMOLDOVAREPUBLICOF,

        /// <summary>
        /// MONACO.
        /// </summary>
        [EnumMember(Value = "MONACO")]
        MONACO,

        /// <summary>
        /// MONGOLIA.
        /// </summary>
        [EnumMember(Value = "MONGOLIA")]
        MONGOLIA,

        /// <summary>
        /// MONTENEGRO.
        /// </summary>
        [EnumMember(Value = "MONTENEGRO")]
        MONTENEGRO,

        /// <summary>
        /// MONTSERRAT.
        /// </summary>
        [EnumMember(Value = "MONTSERRAT")]
        MONTSERRAT,

        /// <summary>
        /// MOROCCO.
        /// </summary>
        [EnumMember(Value = "MOROCCO")]
        MOROCCO,

        /// <summary>
        /// MOZAMBIQUE.
        /// </summary>
        [EnumMember(Value = "MOZAMBIQUE")]
        MOZAMBIQUE,

        /// <summary>
        /// MYANMAR.
        /// </summary>
        [EnumMember(Value = "MYANMAR")]
        MYANMAR,

        /// <summary>
        /// NAMIBIA.
        /// </summary>
        [EnumMember(Value = "NAMIBIA")]
        NAMIBIA,

        /// <summary>
        /// NAURU.
        /// </summary>
        [EnumMember(Value = "NAURU")]
        NAURU,

        /// <summary>
        /// NEPAL.
        /// </summary>
        [EnumMember(Value = "NEPAL")]
        NEPAL,

        /// <summary>
        /// EnumNETHERLANDANTILLES.
        /// </summary>
        [EnumMember(Value = "NETHERLAND ANTILLES")]
        EnumNETHERLANDANTILLES,

        /// <summary>
        /// NETHERLANDS.
        /// </summary>
        [EnumMember(Value = "NETHERLANDS")]
        NETHERLANDS,

        /// <summary>
        /// EnumNEWZEALAND.
        /// </summary>
        [EnumMember(Value = "NEW ZEALAND")]
        EnumNEWZEALAND,

        /// <summary>
        /// NICARAGUA.
        /// </summary>
        [EnumMember(Value = "NICARAGUA")]
        NICARAGUA,

        /// <summary>
        /// NIGER.
        /// </summary>
        [EnumMember(Value = "NIGER")]
        NIGER,

        /// <summary>
        /// NIGERIA.
        /// </summary>
        [EnumMember(Value = "NIGERIA")]
        NIGERIA,

        /// <summary>
        /// NIUE.
        /// </summary>
        [EnumMember(Value = "NIUE")]
        NIUE,

        /// <summary>
        /// EnumNORFOLKISLAND.
        /// </summary>
        [EnumMember(Value = "NORFOLK ISLAND")]
        EnumNORFOLKISLAND,

        /// <summary>
        /// NORWAY.
        /// </summary>
        [EnumMember(Value = "NORWAY")]
        NORWAY,

        /// <summary>
        /// OMAN.
        /// </summary>
        [EnumMember(Value = "OMAN")]
        OMAN,

        /// <summary>
        /// PAKISTAN.
        /// </summary>
        [EnumMember(Value = "PAKISTAN")]
        PAKISTAN,

        /// <summary>
        /// PANAMA.
        /// </summary>
        [EnumMember(Value = "PANAMA")]
        PANAMA,

        /// <summary>
        /// EnumPAPUANEWGUINEA.
        /// </summary>
        [EnumMember(Value = "PAPUA NEW GUINEA")]
        EnumPAPUANEWGUINEA,

        /// <summary>
        /// PARAGUAY.
        /// </summary>
        [EnumMember(Value = "PARAGUAY")]
        PARAGUAY,

        /// <summary>
        /// PERU.
        /// </summary>
        [EnumMember(Value = "PERU")]
        PERU,

        /// <summary>
        /// PHILIPPINES.
        /// </summary>
        [EnumMember(Value = "PHILIPPINES")]
        PHILIPPINES,

        /// <summary>
        /// PITCAIRN.
        /// </summary>
        [EnumMember(Value = "PITCAIRN")]
        PITCAIRN,

        /// <summary>
        /// POLAND.
        /// </summary>
        [EnumMember(Value = "POLAND")]
        POLAND,

        /// <summary>
        /// PORTUGAL.
        /// </summary>
        [EnumMember(Value = "PORTUGAL")]
        PORTUGAL,

        /// <summary>
        /// QATAR.
        /// </summary>
        [EnumMember(Value = "QATAR")]
        QATAR,

        /// <summary>
        /// ROMANIA.
        /// </summary>
        [EnumMember(Value = "ROMANIA")]
        ROMANIA,

        /// <summary>
        /// EnumRUSSIANFEDERATION.
        /// </summary>
        [EnumMember(Value = "RUSSIAN FEDERATION")]
        EnumRUSSIANFEDERATION,

        /// <summary>
        /// RWANDA.
        /// </summary>
        [EnumMember(Value = "RWANDA")]
        RWANDA,

        /// <summary>
        /// EnumSAINTHELENA.
        /// </summary>
        [EnumMember(Value = "SAINT HELENA")]
        EnumSAINTHELENA,

        /// <summary>
        /// EnumSAINTKITTSANDNEVIS.
        /// </summary>
        [EnumMember(Value = "SAINT KITTS AND NEVIS")]
        EnumSAINTKITTSANDNEVIS,

        /// <summary>
        /// EnumSAINTLUCIA.
        /// </summary>
        [EnumMember(Value = "SAINT LUCIA")]
        EnumSAINTLUCIA,

        /// <summary>
        /// EnumSAINTVINCENTANDTHEGRENADINES.
        /// </summary>
        [EnumMember(Value = "SAINT VINCENT AND THE GRENADINES")]
        EnumSAINTVINCENTANDTHEGRENADINES,

        /// <summary>
        /// SAMOA.
        /// </summary>
        [EnumMember(Value = "SAMOA")]
        SAMOA,

        /// <summary>
        /// EnumSANMARINO.
        /// </summary>
        [EnumMember(Value = "SAN MARINO")]
        EnumSANMARINO,

        /// <summary>
        /// EnumSAOTOMEANDPRINCIPE.
        /// </summary>
        [EnumMember(Value = "SAO TOME AND PRINCIPE")]
        EnumSAOTOMEANDPRINCIPE,

        /// <summary>
        /// EnumSAUDIARABIA.
        /// </summary>
        [EnumMember(Value = "SAUDI ARABIA")]
        EnumSAUDIARABIA,

        /// <summary>
        /// SENEGAL.
        /// </summary>
        [EnumMember(Value = "SENEGAL")]
        SENEGAL,

        /// <summary>
        /// SERBIA.
        /// </summary>
        [EnumMember(Value = "SERBIA")]
        SERBIA,

        /// <summary>
        /// SEYCHELLES.
        /// </summary>
        [EnumMember(Value = "SEYCHELLES")]
        SEYCHELLES,

        /// <summary>
        /// EnumSIERRALEONE.
        /// </summary>
        [EnumMember(Value = "SIERRA LEONE")]
        EnumSIERRALEONE,

        /// <summary>
        /// SINGAPORE.
        /// </summary>
        [EnumMember(Value = "SINGAPORE")]
        SINGAPORE,

        /// <summary>
        /// EnumSINTMAARTEN.
        /// </summary>
        [EnumMember(Value = "SINT MAARTEN")]
        EnumSINTMAARTEN,

        /// <summary>
        /// SLOVAKIA.
        /// </summary>
        [EnumMember(Value = "SLOVAKIA")]
        SLOVAKIA,

        /// <summary>
        /// SLOVENIA.
        /// </summary>
        [EnumMember(Value = "SLOVENIA")]
        SLOVENIA,

        /// <summary>
        /// EnumSOLOMONISLANDS.
        /// </summary>
        [EnumMember(Value = "SOLOMON ISLANDS")]
        EnumSOLOMONISLANDS,

        /// <summary>
        /// SOMALIA.
        /// </summary>
        [EnumMember(Value = "SOMALIA")]
        SOMALIA,

        /// <summary>
        /// EnumSOUTHAFRICA.
        /// </summary>
        [EnumMember(Value = "SOUTH AFRICA")]
        EnumSOUTHAFRICA,

        /// <summary>
        /// EnumSOUTHGEORGIAANDTHESOUTHSANDWICHISLANDS.
        /// </summary>
        [EnumMember(Value = "SOUTH GEORGIA AND THE SOUTH SANDWICH ISLANDS")]
        EnumSOUTHGEORGIAANDTHESOUTHSANDWICHISLANDS,

        /// <summary>
        /// EnumSOUTHSUDAN.
        /// </summary>
        [EnumMember(Value = "SOUTH SUDAN")]
        EnumSOUTHSUDAN,

        /// <summary>
        /// SPAIN.
        /// </summary>
        [EnumMember(Value = "SPAIN")]
        SPAIN,

        /// <summary>
        /// EnumSRILANKA.
        /// </summary>
        [EnumMember(Value = "SRI LANKA")]
        EnumSRILANKA,

        /// <summary>
        /// SUDAN.
        /// </summary>
        [EnumMember(Value = "SUDAN")]
        SUDAN,

        /// <summary>
        /// SURINAME.
        /// </summary>
        [EnumMember(Value = "SURINAME")]
        SURINAME,

        /// <summary>
        /// SWEDEN.
        /// </summary>
        [EnumMember(Value = "SWEDEN")]
        SWEDEN,

        /// <summary>
        /// SWITZERLAND.
        /// </summary>
        [EnumMember(Value = "SWITZERLAND")]
        SWITZERLAND,

        /// <summary>
        /// EnumSYRIANARABREPUBLIC.
        /// </summary>
        [EnumMember(Value = "SYRIAN ARAB REPUBLIC")]
        EnumSYRIANARABREPUBLIC,

        /// <summary>
        /// TAIWAN.
        /// </summary>
        [EnumMember(Value = "TAIWAN")]
        TAIWAN,

        /// <summary>
        /// TAJIKISTAN.
        /// </summary>
        [EnumMember(Value = "TAJIKISTAN")]
        TAJIKISTAN,

        /// <summary>
        /// TANZANIA.
        /// </summary>
        [EnumMember(Value = "TANZANIA")]
        TANZANIA,

        /// <summary>
        /// THAILAND.
        /// </summary>
        [EnumMember(Value = "THAILAND")]
        THAILAND,

        /// <summary>
        /// EnumTHEBAHAMAS.
        /// </summary>
        [EnumMember(Value = "THE BAHAMAS")]
        EnumTHEBAHAMAS,

        /// <summary>
        /// TIMORLESTE.
        /// </summary>
        [EnumMember(Value = "TIMOR-LESTE")]
        TIMORLESTE,

        /// <summary>
        /// TOGO.
        /// </summary>
        [EnumMember(Value = "TOGO")]
        TOGO,

        /// <summary>
        /// TOKELAU.
        /// </summary>
        [EnumMember(Value = "TOKELAU")]
        TOKELAU,

        /// <summary>
        /// TONGA.
        /// </summary>
        [EnumMember(Value = "TONGA")]
        TONGA,

        /// <summary>
        /// EnumTRINIDADANDTOBAGO.
        /// </summary>
        [EnumMember(Value = "TRINIDAD AND TOBAGO")]
        EnumTRINIDADANDTOBAGO,

        /// <summary>
        /// TUNISIA.
        /// </summary>
        [EnumMember(Value = "TUNISIA")]
        TUNISIA,

        /// <summary>
        /// TURKEY.
        /// </summary>
        [EnumMember(Value = "TURKEY")]
        TURKEY,

        /// <summary>
        /// TURKMENISTAN.
        /// </summary>
        [EnumMember(Value = "TURKMENISTAN")]
        TURKMENISTAN,

        /// <summary>
        /// EnumTURKSANDCAICOSISLANDS.
        /// </summary>
        [EnumMember(Value = "TURKS AND CAICOS ISLANDS")]
        EnumTURKSANDCAICOSISLANDS,

        /// <summary>
        /// TUVALU.
        /// </summary>
        [EnumMember(Value = "TUVALU")]
        TUVALU,

        /// <summary>
        /// UGANDA.
        /// </summary>
        [EnumMember(Value = "UGANDA")]
        UGANDA,

        /// <summary>
        /// UKRAINE.
        /// </summary>
        [EnumMember(Value = "UKRAINE")]
        UKRAINE,

        /// <summary>
        /// EnumUNITEDARABEMIRATES.
        /// </summary>
        [EnumMember(Value = "UNITED ARAB EMIRATES")]
        EnumUNITEDARABEMIRATES,

        /// <summary>
        /// EnumUNITEDKINGDOM.
        /// </summary>
        [EnumMember(Value = "UNITED KINGDOM")]
        EnumUNITEDKINGDOM,

        /// <summary>
        /// URUGUAY.
        /// </summary>
        [EnumMember(Value = "URUGUAY")]
        URUGUAY,

        /// <summary>
        /// UZBEKISTAN.
        /// </summary>
        [EnumMember(Value = "UZBEKISTAN")]
        UZBEKISTAN,

        /// <summary>
        /// VANUATU.
        /// </summary>
        [EnumMember(Value = "VANUATU")]
        VANUATU,

        /// <summary>
        /// VENEZUELA.
        /// </summary>
        [EnumMember(Value = "VENEZUELA")]
        VENEZUELA,

        /// <summary>
        /// EnumVIETNAM.
        /// </summary>
        [EnumMember(Value = "VIET NAM")]
        EnumVIETNAM,

        /// <summary>
        /// EnumWESTERNSAHARA.
        /// </summary>
        [EnumMember(Value = "WESTERN SAHARA")]
        EnumWESTERNSAHARA,

        /// <summary>
        /// YEMEN.
        /// </summary>
        [EnumMember(Value = "YEMEN")]
        YEMEN,

        /// <summary>
        /// ZAMBIA.
        /// </summary>
        [EnumMember(Value = "ZAMBIA")]
        ZAMBIA,

        /// <summary>
        /// ZIMBABWE.
        /// </summary>
        [EnumMember(Value = "ZIMBABWE")]
        ZIMBABWE
    }
}