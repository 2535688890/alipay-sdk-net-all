/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-05-20
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// AntMerchantExpandShopModifyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandShopModifyErrorResponseModel")]
    public partial class AntMerchantExpandShopModifyErrorResponseModel : IEquatable<AntMerchantExpandShopModifyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum NOTALLOWEDSETTLE for value: NOT_ALLOWED_SETTLE
            /// </summary>
            [EnumMember(Value = "NOT_ALLOWED_SETTLE")]
            NOTALLOWEDSETTLE = 1,

            /// <summary>
            /// Enum SHOPCATEGORYISILLEGAL for value: SHOP_CATEGORY_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_CATEGORY_IS_ILLEGAL")]
            SHOPCATEGORYISILLEGAL = 2,

            /// <summary>
            /// Enum ISVNOTEXIST for value: ISV_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "ISV_NOT_EXIST")]
            ISVNOTEXIST = 3,

            /// <summary>
            /// Enum SHOPACCOUNTNOISILLEGAL for value: SHOP_ACCOUNT_NO_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_ACCOUNT_NO_IS_ILLEGAL")]
            SHOPACCOUNTNOISILLEGAL = 4,

            /// <summary>
            /// Enum INDUSTRYQUALIFICATIONISEMPTY for value: INDUSTRY_QUALIFICATION_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "INDUSTRY_QUALIFICATION_IS_EMPTY")]
            INDUSTRYQUALIFICATIONISEMPTY = 5,

            /// <summary>
            /// Enum SETTLEDOUTDOORIMAGEEMPTY for value: SETTLED_OUTDOORIMAGE_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_OUTDOORIMAGE_EMPTY")]
            SETTLEDOUTDOORIMAGEEMPTY = 6,

            /// <summary>
            /// Enum SETTLEDBIZADDRESSILLEGAL for value: SETTLED_BIZ_ADDRESS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_BIZ_ADDRESS_ILLEGAL")]
            SETTLEDBIZADDRESSILLEGAL = 7,

            /// <summary>
            /// Enum SHOPCATEGORYISEMPTY for value: SHOP_CATEGORY_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_CATEGORY_IS_EMPTY")]
            SHOPCATEGORYISEMPTY = 8,

            /// <summary>
            /// Enum CONTACTWAYVALUENULL for value: CONTACT_WAY_VALUE_NULL
            /// </summary>
            [EnumMember(Value = "CONTACT_WAY_VALUE_NULL")]
            CONTACTWAYVALUENULL = 9,

            /// <summary>
            /// Enum ADDRESSPROVINCECODEILLEGAL for value: ADDRESS_PROVINCE_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_PROVINCE_CODE_ILLEGAL")]
            ADDRESSPROVINCECODEILLEGAL = 10,

            /// <summary>
            /// Enum ADDRESSCITYCODEILLEGAL for value: ADDRESS_CITY_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_CITY_CODE_ILLEGAL")]
            ADDRESSCITYCODEILLEGAL = 11,

            /// <summary>
            /// Enum ADDRESSDISTRICTCODEILLEGAL for value: ADDRESS_DISTRICT_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_DISTRICT_CODE_ILLEGAL")]
            ADDRESSDISTRICTCODEILLEGAL = 12,

            /// <summary>
            /// Enum GONGANCHECKFAIL for value: GONGAN_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "GONGAN_CHECK_FAIL")]
            GONGANCHECKFAIL = 13,

            /// <summary>
            /// Enum GONGSHANGCHECKFAIL for value: GONGSHANG_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "GONGSHANG_CHECK_FAIL")]
            GONGSHANGCHECKFAIL = 14,

            /// <summary>
            /// Enum MERCHANTINPUTARGUMENTILLEGAL for value: MERCHANT_INPUT_ARGUMENT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MERCHANT_INPUT_ARGUMENT_ILLEGAL")]
            MERCHANTINPUTARGUMENTILLEGAL = 15,

            /// <summary>
            /// Enum CONTACTPERSONNAMENULL for value: CONTACT_PERSON_NAME_NULL
            /// </summary>
            [EnumMember(Value = "CONTACT_PERSON_NAME_NULL")]
            CONTACTPERSONNAMENULL = 16,

            /// <summary>
            /// Enum USERILLEGAL for value: USER_ILLEGAL
            /// </summary>
            [EnumMember(Value = "USER_ILLEGAL")]
            USERILLEGAL = 17,

            /// <summary>
            /// Enum BRANDILLEGAL for value: BRAND_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BRAND_ILLEGAL")]
            BRANDILLEGAL = 18,

            /// <summary>
            /// Enum PROFILEKEYILLEGAL for value: PROFILE_KEY_ILLEGAL
            /// </summary>
            [EnumMember(Value = "PROFILE_KEY_ILLEGAL")]
            PROFILEKEYILLEGAL = 19,

            /// <summary>
            /// Enum MERARGUMENTNULL for value: MER_ARGUMENT_NULL
            /// </summary>
            [EnumMember(Value = "MER_ARGUMENT_NULL")]
            MERARGUMENTNULL = 20,

            /// <summary>
            /// Enum IPROLEIDDONOTCHANGE for value: IP_ROLE_ID_DO_NOT_CHANGE
            /// </summary>
            [EnumMember(Value = "IP_ROLE_ID_DO_NOT_CHANGE")]
            IPROLEIDDONOTCHANGE = 21,

            /// <summary>
            /// Enum SHOPNOTEXIST for value: SHOP_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_NOT_EXIST")]
            SHOPNOTEXIST = 22,

            /// <summary>
            /// Enum RELATIONNOTEXIST for value: RELATION_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "RELATION_NOT_EXIST")]
            RELATIONNOTEXIST = 23,

            /// <summary>
            /// Enum SHOPALREADYEXIST for value: SHOP_ALREADY_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_ALREADY_EXIST")]
            SHOPALREADYEXIST = 24,

            /// <summary>
            /// Enum SETTLEDBANKCARDNOISEMPTY for value: SETTLED_BANKCARD_NO_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_BANKCARD_NO_IS_EMPTY")]
            SETTLEDBANKCARDNOISEMPTY = 25,

            /// <summary>
            /// Enum SETTLEDACCOUNTHOLDERNAMEEMPTY for value: SETTLED_ACCOUNTHOLDERNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTHOLDERNAME_EMPTY")]
            SETTLEDACCOUNTHOLDERNAMEEMPTY = 26,

            /// <summary>
            /// Enum SETTLEDACCOUNTBRANCHNAMEEMPTY for value: SETTLED_ACCOUNTBRANCHNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTBRANCHNAME_EMPTY")]
            SETTLEDACCOUNTBRANCHNAMEEMPTY = 27,

            /// <summary>
            /// Enum SETTLEDACCOUNTINSTNAMEEMPTY for value: SETTLED_ACCOUNTINSTNAME_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_ACCOUNTINSTNAME_EMPTY")]
            SETTLEDACCOUNTINSTNAMEEMPTY = 28,

            /// <summary>
            /// Enum SETTLEDUSAGETYPEISEMPTY for value: SETTLED_USAGETYPE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_USAGETYPE_IS_EMPTY")]
            SETTLEDUSAGETYPEISEMPTY = 29,

            /// <summary>
            /// Enum BANKBRANCHNAMEILLEGAL for value: BANK_BRANCH_NAME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_BRANCH_NAME_ILLEGAL")]
            BANKBRANCHNAMEILLEGAL = 30,

            /// <summary>
            /// Enum SETTLEDUSAGETYPEILLEGAL for value: SETTLED_USAGETYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_USAGETYPE_ILLEGAL")]
            SETTLEDUSAGETYPEILLEGAL = 31,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTINSTIDEMPTY for value: SETTLED_CARD_ACCOUNTINSTID_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTINSTID_EMPTY")]
            SETTLEDCARDACCOUNTINSTIDEMPTY = 32,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTTYPEEMPTY for value: SETTLED_CARD_ACCOUNTTYPE_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTTYPE_EMPTY")]
            SETTLEDCARDACCOUNTTYPEEMPTY = 33,

            /// <summary>
            /// Enum BANKACCOUNTINSTIDILLEGAL for value: BANK_ACCOUNTINSTID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_ACCOUNTINSTID_ILLEGAL")]
            BANKACCOUNTINSTIDILLEGAL = 34,

            /// <summary>
            /// Enum SETTLEDCARDACCOUNTTYPEILLEGAL for value: SETTLED_CARD_ACCOUNTTYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_ACCOUNTTYPE_ILLEGAL")]
            SETTLEDCARDACCOUNTTYPEILLEGAL = 35,

            /// <summary>
            /// Enum BANKACCOUNTINSTNAMEILLEGAL for value: BANK_ACCOUNTINSTNAME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_ACCOUNTINSTNAME_ILLEGAL")]
            BANKACCOUNTINSTNAMEILLEGAL = 36,

            /// <summary>
            /// Enum SETTLEDALIPAYACCOUNTNOTEXIST for value: SETTLED_ALIPAYACCOUNT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SETTLED_ALIPAYACCOUNT_NOT_EXIST")]
            SETTLEDALIPAYACCOUNTNOTEXIST = 37,

            /// <summary>
            /// Enum GONGSHANGLICENSEILLEGAL for value: GONGSHANG_LICENSE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "GONGSHANG_LICENSE_ILLEGAL")]
            GONGSHANGLICENSEILLEGAL = 38,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 39,

            /// <summary>
            /// Enum SHOPTYPEILLEGAL for value: SHOP_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_TYPE_ILLEGAL")]
            SHOPTYPEILLEGAL = 40,

            /// <summary>
            /// Enum LOCATIONCHECKFAIL for value: LOCATION_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "LOCATION_CHECK_FAIL")]
            LOCATIONCHECKFAIL = 41,

            /// <summary>
            /// Enum ATTACHMENTCHECKFAIL for value: ATTACHMENT_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_CHECK_FAIL")]
            ATTACHMENTCHECKFAIL = 42,

            /// <summary>
            /// Enum BUSINESSTIMEILLEGAL for value: BUSINESS_TIME_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BUSINESS_TIME_ILLEGAL")]
            BUSINESSTIMEILLEGAL = 43,

            /// <summary>
            /// Enum SHOPAUDITREJECT for value: SHOP_AUDIT_REJECT
            /// </summary>
            [EnumMember(Value = "SHOP_AUDIT_REJECT")]
            SHOPAUDITREJECT = 44,

            /// <summary>
            /// Enum ATTACHMENTURLNULL for value: ATTACHMENT_URL_NULL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_URL_NULL")]
            ATTACHMENTURLNULL = 45,

            /// <summary>
            /// Enum SHOPCODEALREADYEXIST for value: SHOP_CODE_ALREADY_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_CODE_ALREADY_EXIST")]
            SHOPCODEALREADYEXIST = 46,

            /// <summary>
            /// Enum MERARGUMENTILLEGAL for value: MER_ARGUMENT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "MER_ARGUMENT_ILLEGAL")]
            MERARGUMENTILLEGAL = 47,

            /// <summary>
            /// Enum FIELDLENGTHERROR for value: FIELD_LENGTH_ERROR
            /// </summary>
            [EnumMember(Value = "FIELD_LENGTH_ERROR")]
            FIELDLENGTHERROR = 48,

            /// <summary>
            /// Enum MERCHANTORDEREXECUTECONFLICT for value: MERCHANT_ORDER_EXECUTE_CONFLICT
            /// </summary>
            [EnumMember(Value = "MERCHANT_ORDER_EXECUTE_CONFLICT")]
            MERCHANTORDEREXECUTECONFLICT = 49,

            /// <summary>
            /// Enum THIRDSYSTEMERROR for value: THIRD_SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "THIRD_SYSTEM_ERROR")]
            THIRDSYSTEMERROR = 50,

            /// <summary>
            /// Enum CTUINDIRECTCREATEFAIL for value: CTU_INDIRECT_CREATE_FAIL
            /// </summary>
            [EnumMember(Value = "CTU_INDIRECT_CREATE_FAIL")]
            CTUINDIRECTCREATEFAIL = 51,

            /// <summary>
            /// Enum DETAILADDRESSNOTCONTAINKEYWORDVALUE for value: DETAIL_ADDRESS_NOT_CONTAIN_KEYWORD_VALUE
            /// </summary>
            [EnumMember(Value = "DETAIL_ADDRESS_NOT_CONTAIN_KEYWORD_VALUE")]
            DETAILADDRESSNOTCONTAINKEYWORDVALUE = 52,

            /// <summary>
            /// Enum SHOPNAMEEXISTRISK for value: SHOP_NAME_EXIST_RISK
            /// </summary>
            [EnumMember(Value = "SHOP_NAME_EXIST_RISK")]
            SHOPNAMEEXISTRISK = 53,

            /// <summary>
            /// Enum SHOPADDRESSEXISTRISK for value: SHOP_ADDRESS_EXIST_RISK
            /// </summary>
            [EnumMember(Value = "SHOP_ADDRESS_EXIST_RISK")]
            SHOPADDRESSEXISTRISK = 54,

            /// <summary>
            /// Enum SHOPREMARKEXISTRISK for value: SHOP_REMARK_EXIST_RISK
            /// </summary>
            [EnumMember(Value = "SHOP_REMARK_EXIST_RISK")]
            SHOPREMARKEXISTRISK = 55,

            /// <summary>
            /// Enum EXTERNALSHOPCODEEXISTRISK for value: EXTERNAL_SHOP_CODE_EXIST_RISK
            /// </summary>
            [EnumMember(Value = "EXTERNAL_SHOP_CODE_EXIST_RISK")]
            EXTERNALSHOPCODEEXISTRISK = 56,

            /// <summary>
            /// Enum DETAILADDRESSNOTCONTAINSCHINESECHARACTER for value: DETAIL_ADDRESS_NOT_CONTAINS_CHINESE_CHARACTER
            /// </summary>
            [EnumMember(Value = "DETAIL_ADDRESS_NOT_CONTAINS_CHINESE_CHARACTER")]
            DETAILADDRESSNOTCONTAINSCHINESECHARACTER = 57,

            /// <summary>
            /// Enum OUTDOORIMAGEURLISEMPTY for value: OUTDOOR_IMAGE_URL_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "OUTDOOR_IMAGE_URL_IS_EMPTY")]
            OUTDOORIMAGEURLISEMPTY = 58,

            /// <summary>
            /// Enum BIZSCENEPICURLISEMPTY for value: BIZ_SCENE_PIC_URL_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "BIZ_SCENE_PIC_URL_IS_EMPTY")]
            BIZSCENEPICURLISEMPTY = 59,

            /// <summary>
            /// Enum BUSINESSLICENSEURLISEMPTY for value: BUSINESS_LICENSE_URL_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "BUSINESS_LICENSE_URL_IS_EMPTY")]
            BUSINESSLICENSEURLISEMPTY = 60,

            /// <summary>
            /// Enum MERCHANTLOGOURLISEMPTY for value: MERCHANT_LOGO_URL_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "MERCHANT_LOGO_URL_IS_EMPTY")]
            MERCHANTLOGOURLISEMPTY = 61,

            /// <summary>
            /// Enum SETTLEDBANKCARDNUMBERLENGTHILLEGAL for value: SETTLED_BANKCARD_NUMBER_LENGTH_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_BANKCARD_NUMBER_LENGTH_ILLEGAL")]
            SETTLEDBANKCARDNUMBERLENGTHILLEGAL = 62,

            /// <summary>
            /// Enum ACCOUNTHOLDERNAMELENGTHILLEGAL for value: ACCOUNT_HOLDER_NAME_LENGTH_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ACCOUNT_HOLDER_NAME_LENGTH_ILLEGAL")]
            ACCOUNTHOLDERNAMELENGTHILLEGAL = 63,

            /// <summary>
            /// Enum ACCOUNTINSTPROVINCELENGTHILLEGAL for value: ACCOUNT_INST_PROVINCE_LENGTH_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ACCOUNT_INST_PROVINCE_LENGTH_ILLEGAL")]
            ACCOUNTINSTPROVINCELENGTHILLEGAL = 64,

            /// <summary>
            /// Enum ACCOUNTINSTCITYLENGTHILLEGAL for value: ACCOUNT_INST_CITY_LENGTH_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ACCOUNT_INST_CITY_LENGTH_ILLEGAL")]
            ACCOUNTINSTCITYLENGTHILLEGAL = 65,

            /// <summary>
            /// Enum ACCOUNTBRANCHNAMELENGTHILLEGAL for value: ACCOUNT_BRANCH_NAME_LENGTH_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ACCOUNT_BRANCH_NAME_LENGTH_ILLEGAL")]
            ACCOUNTBRANCHNAMELENGTHILLEGAL = 66,

            /// <summary>
            /// Enum ACCOUNTNAMELENGTHILLEGAL for value: ACCOUNT_NAME_LENGTH_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ACCOUNT_NAME_LENGTH_ILLEGAL")]
            ACCOUNTNAMELENGTHILLEGAL = 67,

            /// <summary>
            /// Enum ACCOUNTINSTIDLENGTHILLEGAL for value: ACCOUNT_INST_ID_LENGTH_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ACCOUNT_INST_ID_LENGTH_ILLEGAL")]
            ACCOUNTINSTIDLENGTHILLEGAL = 68,

            /// <summary>
            /// Enum OUTDOORIMAGEOSSKEYNOTEXIST for value: OUTDOOR_IMAGE_OSSKEY_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "OUTDOOR_IMAGE_OSSKEY_NOT_EXIST")]
            OUTDOORIMAGEOSSKEYNOTEXIST = 69,

            /// <summary>
            /// Enum BUSINESSLICENSEOSSKEYNOTEXIST for value: BUSINESS_LICENSE_OSSKEY_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "BUSINESS_LICENSE_OSSKEY_NOT_EXIST")]
            BUSINESSLICENSEOSSKEYNOTEXIST = 70,

            /// <summary>
            /// Enum SPECIALTRAVELPERMITOSSKEYNOTEXIST for value: SPECIAL_TRAVEL_PERMIT_OSSKEY_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SPECIAL_TRAVEL_PERMIT_OSSKEY_NOT_EXIST")]
            SPECIALTRAVELPERMITOSSKEYNOTEXIST = 71,

            /// <summary>
            /// Enum OTASNAPSHOTOSSKEYNOTEXIST for value: OTA_SNAPSHOT_OSSKEY_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "OTA_SNAPSHOT_OSSKEY_NOT_EXIST")]
            OTASNAPSHOTOSSKEYNOTEXIST = 72,

            /// <summary>
            /// Enum IDCARDMSGILLEGAL for value: ID_CARD_MSG_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ID_CARD_MSG_ILLEGAL")]
            IDCARDMSGILLEGAL = 73,

            /// <summary>
            /// Enum BUSINESSLICENSEILLEGAL for value: BUSINESS_LICENSE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BUSINESS_LICENSE_ILLEGAL")]
            BUSINESSLICENSEILLEGAL = 74,

            /// <summary>
            /// Enum BUSINESSADDRESSISEMPTY for value: BUSINESS_ADDRESS_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "BUSINESS_ADDRESS_IS_EMPTY")]
            BUSINESSADDRESSISEMPTY = 75,

            /// <summary>
            /// Enum DETAILADDRESSCONTAINPROVINCESCITYREGION for value: DETAIL_ADDRESS_CONTAIN_PROVINCES_CITY_REGION
            /// </summary>
            [EnumMember(Value = "DETAIL_ADDRESS_CONTAIN_PROVINCES_CITY_REGION")]
            DETAILADDRESSCONTAINPROVINCESCITYREGION = 76,

            /// <summary>
            /// Enum MERCHANTNOTEXIST for value: MERCHANT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "MERCHANT_NOT_EXIST")]
            MERCHANTNOTEXIST = 77,

            /// <summary>
            /// Enum SHOPINFOSOURCEOTHERTAG for value: SHOP_INFO_SOURCE_OTHER_TAG
            /// </summary>
            [EnumMember(Value = "SHOP_INFO_SOURCE_OTHER_TAG")]
            SHOPINFOSOURCEOTHERTAG = 78,

            /// <summary>
            /// Enum CONFIGERROR for value: CONFIG_ERROR
            /// </summary>
            [EnumMember(Value = "CONFIG_ERROR")]
            CONFIGERROR = 79,

            /// <summary>
            /// Enum ENUMILLEGAL for value: ENUM_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ENUM_ILLEGAL")]
            ENUMILLEGAL = 80,

            /// <summary>
            /// Enum ATTACHMENTTYPEILLEGAL for value: ATTACHMENT_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ATTACHMENT_TYPE_ILLEGAL")]
            ATTACHMENTTYPEILLEGAL = 81,

            /// <summary>
            /// Enum BANKCARDTYPEILLEGAL for value: BANK_CARD_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_CARD_TYPE_ILLEGAL")]
            BANKCARDTYPEILLEGAL = 82,

            /// <summary>
            /// Enum TARGETTYPEILLEGAL for value: TARGET_TYPE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "TARGET_TYPE_ILLEGAL")]
            TARGETTYPEILLEGAL = 83,

            /// <summary>
            /// Enum SHOPEXTINFONULL for value: SHOP_EXT_INFO_NULL
            /// </summary>
            [EnumMember(Value = "SHOP_EXT_INFO_NULL")]
            SHOPEXTINFONULL = 84,

            /// <summary>
            /// Enum SHOPINFOSOURCEILLEGAL for value: SHOP_INFO_SOURCE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_INFO_SOURCE_ILLEGAL")]
            SHOPINFOSOURCEILLEGAL = 85,

            /// <summary>
            /// Enum SHOPINFOSOURCECHANNELILLEGAL for value: SHOP_INFO_SOURCE_CHANNEL_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_INFO_SOURCE_CHANNEL_ILLEGAL")]
            SHOPINFOSOURCECHANNELILLEGAL = 86,

            /// <summary>
            /// Enum SHOPINFOSOURCEBIZFROMILLEGAL for value: SHOP_INFO_SOURCE_BIZ_FROM_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_INFO_SOURCE_BIZ_FROM_ILLEGAL")]
            SHOPINFOSOURCEBIZFROMILLEGAL = 87,

            /// <summary>
            /// Enum DISTRICTCODEILLEGAL for value: DISTRICT_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "DISTRICT_CODE_ILLEGAL")]
            DISTRICTCODEILLEGAL = 88,

            /// <summary>
            /// Enum UKOCCUPIED for value: UK_OCCUPIED
            /// </summary>
            [EnumMember(Value = "UK_OCCUPIED")]
            UKOCCUPIED = 89,

            /// <summary>
            /// Enum SETTLEDBANKCARDACCOUNTINSTPROVINCEISEMPTY for value: SETTLED_BANKCARD_ACCOUNTINSTPROVINCE_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_BANKCARD_ACCOUNTINSTPROVINCE_IS_EMPTY")]
            SETTLEDBANKCARDACCOUNTINSTPROVINCEISEMPTY = 90,

            /// <summary>
            /// Enum SETTLEDBANKCARDACCOUNTINSTCITYISEMPTY for value: SETTLED_BANKCARD_ACCOUNTINSTCITY_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SETTLED_BANKCARD_ACCOUNTINSTCITY_IS_EMPTY")]
            SETTLEDBANKCARDACCOUNTINSTCITYISEMPTY = 91,

            /// <summary>
            /// Enum SETTLEDCARDSIZEISILLEGAL for value: SETTLED_CARD_SIZE_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SETTLED_CARD_SIZE_IS_ILLEGAL")]
            SETTLEDCARDSIZEISILLEGAL = 92,

            /// <summary>
            /// Enum BUSINESSLICENSEEMPTY for value: BUSINESS_LICENSE_EMPTY
            /// </summary>
            [EnumMember(Value = "BUSINESS_LICENSE_EMPTY")]
            BUSINESSLICENSEEMPTY = 93,

            /// <summary>
            /// Enum BANKCODEILLEGAL for value: BANK_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "BANK_CODE_ILLEGAL")]
            BANKCODEILLEGAL = 94,

            /// <summary>
            /// Enum ADDRESSVERSIONCODEILLEGAL for value: ADDRESS_VERSION_CODE_ILLEGAL
            /// </summary>
            [EnumMember(Value = "ADDRESS_VERSION_CODE_ILLEGAL")]
            ADDRESSVERSIONCODEILLEGAL = 95,

            /// <summary>
            /// Enum SHOPSHOPNOISEMPTY for value: SHOP_SHOPNO_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_SHOPNO_IS_EMPTY")]
            SHOPSHOPNOISEMPTY = 96,

            /// <summary>
            /// Enum SHOPSHOPNAMEISEMPTY for value: SHOP_SHOPNAME_IS_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_SHOPNAME_IS_EMPTY")]
            SHOPSHOPNAMEISEMPTY = 97,

            /// <summary>
            /// Enum SHOPSOURCEISILLEGAL for value: SHOP_SOURCE_IS_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_SOURCE_IS_ILLEGAL")]
            SHOPSOURCEISILLEGAL = 98,

            /// <summary>
            /// Enum CATEGORYEVALUATEFAIL for value: CATEGORY_EVALUATE_FAIL
            /// </summary>
            [EnumMember(Value = "CATEGORY_EVALUATE_FAIL")]
            CATEGORYEVALUATEFAIL = 99,

            /// <summary>
            /// Enum CATEGORYWITHNOPROOF for value: CATEGORY_WITH_NO_PROOF
            /// </summary>
            [EnumMember(Value = "CATEGORY_WITH_NO_PROOF")]
            CATEGORYWITHNOPROOF = 100,

            /// <summary>
            /// Enum SHOPASSETCHECKRESULTEMPTY for value: SHOP_ASSET_CHECK_RESULT_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_ASSET_CHECK_RESULT_EMPTY")]
            SHOPASSETCHECKRESULTEMPTY = 101,

            /// <summary>
            /// Enum SHOPASSETNOTBINDABLE for value: SHOP_ASSET_NOT_BINDABLE
            /// </summary>
            [EnumMember(Value = "SHOP_ASSET_NOT_BINDABLE")]
            SHOPASSETNOTBINDABLE = 102,

            /// <summary>
            /// Enum SHOPASSETMAXLIMIT for value: SHOP_ASSET_MAX_LIMIT
            /// </summary>
            [EnumMember(Value = "SHOP_ASSET_MAX_LIMIT")]
            SHOPASSETMAXLIMIT = 103,

            /// <summary>
            /// Enum SHOPPRERISKLEVELERROR for value: SHOP_PRE_RISK_LEVEL_ERROR
            /// </summary>
            [EnumMember(Value = "SHOP_PRE_RISK_LEVEL_ERROR")]
            SHOPPRERISKLEVELERROR = 104,

            /// <summary>
            /// Enum SHOPPREPOINOTFILLERROR for value: SHOP_PRE_POI_NOT_FILL_ERROR
            /// </summary>
            [EnumMember(Value = "SHOP_PRE_POI_NOT_FILL_ERROR")]
            SHOPPREPOINOTFILLERROR = 105,

            /// <summary>
            /// Enum STOREIDLENGTHILLEGAL for value: STORE_ID_LENGTH_ILLEGAL
            /// </summary>
            [EnumMember(Value = "STORE_ID_LENGTH_ILLEGAL")]
            STOREIDLENGTHILLEGAL = 106,

            /// <summary>
            /// Enum SHOPCOVEROSSKEYNOTEXIST for value: SHOP_COVER_OSSKEY_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_COVER_OSSKEY_NOT_EXIST")]
            SHOPCOVEROSSKEYNOTEXIST = 107,

            /// <summary>
            /// Enum SHOPCOVERNOTEXIST for value: SHOP_COVER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "SHOP_COVER_NOT_EXIST")]
            SHOPCOVERNOTEXIST = 108,

            /// <summary>
            /// Enum SHOPEXTINFOINPUTARGUMENTILLEGAL for value: SHOP_EXT_INFO_INPUT_ARGUMENT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_EXT_INFO_INPUT_ARGUMENT_ILLEGAL")]
            SHOPEXTINFOINPUTARGUMENTILLEGAL = 109,

            /// <summary>
            /// Enum SHOPEXTINFOVALUEINPUTARGUMENTILLEGAL for value: SHOP_EXT_INFO_VALUE_INPUT_ARGUMENT_ILLEGAL
            /// </summary>
            [EnumMember(Value = "SHOP_EXT_INFO_VALUE_INPUT_ARGUMENT_ILLEGAL")]
            SHOPEXTINFOVALUEINPUTARGUMENTILLEGAL = 110,

            /// <summary>
            /// Enum SHOPCATEGORYEMPTY for value: SHOP_CATEGORY_EMPTY
            /// </summary>
            [EnumMember(Value = "SHOP_CATEGORY_EMPTY")]
            SHOPCATEGORYEMPTY = 111,

            /// <summary>
            /// Enum SHOPNAMEBRANDAUDITREJECT for value: SHOP_NAME_BRAND_AUDIT_REJECT
            /// </summary>
            [EnumMember(Value = "SHOP_NAME_BRAND_AUDIT_REJECT")]
            SHOPNAMEBRANDAUDITREJECT = 112,

            /// <summary>
            /// Enum SHOPNAMEBUSINESSAUDITREJECT for value: SHOP_NAME_BUSINESS_AUDIT_REJECT
            /// </summary>
            [EnumMember(Value = "SHOP_NAME_BUSINESS_AUDIT_REJECT")]
            SHOPNAMEBUSINESSAUDITREJECT = 113

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopModifyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AntMerchantExpandShopModifyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopModifyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AntMerchantExpandShopModifyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AntMerchantExpandShopModifyErrorResponseModel and cannot be null");
            // }
            this.Message = message;
            this.Links = links;
        }

        /// <summary>
        /// 解决方案链接
        /// </summary>
        /// <value>解决方案链接</value>
        [DataMember(Name = "links", EmitDefaultValue = false)]
        public string Links { get; set; }

        /// <summary>
        /// 错误描述
        /// </summary>
        /// <value>错误描述</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandShopModifyErrorResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AntMerchantExpandShopModifyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandShopModifyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandShopModifyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandShopModifyErrorResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = (hashCode * 59) + this.Code.GetHashCode();
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
