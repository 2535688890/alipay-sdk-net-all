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
    /// AlipayOpenMiniInnerappCreateErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerappCreateErrorResponseModel")]
    public partial class AlipayOpenMiniInnerappCreateErrorResponseModel : IEquatable<AlipayOpenMiniInnerappCreateErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum INVALIDPARAMSWARN for value: INVALID_PARAMS_WARN
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMS_WARN")]
            INVALIDPARAMSWARN = 1,

            /// <summary>
            /// Enum APPNAMEISBLANK for value: APP_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_NAME_IS_BLANK")]
            APPNAMEISBLANK = 2,

            /// <summary>
            /// Enum INVALIDMINIAPPNAME for value: INVALID_MINI_APP_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME")]
            INVALIDMINIAPPNAME = 3,

            /// <summary>
            /// Enum INVALIDMINIAPPNAMELENGTH for value: INVALID_MINI_APP_NAME_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_NAME_LENGTH")]
            INVALIDMINIAPPNAMELENGTH = 4,

            /// <summary>
            /// Enum ENGLISHNAMEISBLANK for value: ENGLISH_NAME_IS_BLANK
            /// </summary>
            [EnumMember(Value = "ENGLISH_NAME_IS_BLANK")]
            ENGLISHNAMEISBLANK = 5,

            /// <summary>
            /// Enum INVALIDMINIAPPENNAME for value: INVALID_MINI_APP_EN_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_EN_NAME")]
            INVALIDMINIAPPENNAME = 6,

            /// <summary>
            /// Enum INVALIDMINIAPPENNAMELENGTH for value: INVALID_MINI_APP_EN_NAME_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_EN_NAME_LENGTH")]
            INVALIDMINIAPPENNAMELENGTH = 7,

            /// <summary>
            /// Enum SLOGANISBLANK for value: SLOGAN_IS_BLANK
            /// </summary>
            [EnumMember(Value = "SLOGAN_IS_BLANK")]
            SLOGANISBLANK = 8,

            /// <summary>
            /// Enum INVALIDMINIAPPSLOGANLENGTH for value: INVALID_MINI_APP_SLOGAN_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SLOGAN_LENGTH")]
            INVALIDMINIAPPSLOGANLENGTH = 9,

            /// <summary>
            /// Enum SERVICETELISBLANK for value: SERVICE_TEL_IS_BLANK
            /// </summary>
            [EnumMember(Value = "SERVICE_TEL_IS_BLANK")]
            SERVICETELISBLANK = 10,

            /// <summary>
            /// Enum INVALIDMINIAPPSERVICETEL for value: INVALID_MINI_APP_SERVICE_TEL
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_SERVICE_TEL")]
            INVALIDMINIAPPSERVICETEL = 11,

            /// <summary>
            /// Enum CATEGORYISBLANK for value: CATEGORY_IS_BLANK
            /// </summary>
            [EnumMember(Value = "CATEGORY_IS_BLANK")]
            CATEGORYISBLANK = 12,

            /// <summary>
            /// Enum CATEGORYNUMISINVALID for value: CATEGORY_NUM_IS_INVALID
            /// </summary>
            [EnumMember(Value = "CATEGORY_NUM_IS_INVALID")]
            CATEGORYNUMISINVALID = 13,

            /// <summary>
            /// Enum APPDESCISBLANK for value: APP_DESC_IS_BLANK
            /// </summary>
            [EnumMember(Value = "APP_DESC_IS_BLANK")]
            APPDESCISBLANK = 14,

            /// <summary>
            /// Enum MINIAPPNAMEDUPLICATE for value: MINI_APP_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_APP_NAME_DUPLICATE")]
            MINIAPPNAMEDUPLICATE = 15,

            /// <summary>
            /// Enum MINIAPPENNAMEDUPLICATE for value: MINI_APP_EN_NAME_DUPLICATE
            /// </summary>
            [EnumMember(Value = "MINI_APP_EN_NAME_DUPLICATE")]
            MINIAPPENNAMEDUPLICATE = 16,

            /// <summary>
            /// Enum INVALIDCATEGORY for value: INVALID_CATEGORY
            /// </summary>
            [EnumMember(Value = "INVALID_CATEGORY")]
            INVALIDCATEGORY = 17,

            /// <summary>
            /// Enum INVALIDMINIAPPDESCLENGTH for value: INVALID_MINI_APP_DESC_LENGTH
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_APP_DESC_LENGTH")]
            INVALIDMINIAPPDESCLENGTH = 18,

            /// <summary>
            /// Enum SUBAPPLICATIONTYPEERROR for value: SUB_APPLICATION_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "SUB_APPLICATION_TYPE_ERROR")]
            SUBAPPLICATIONTYPEERROR = 19,

            /// <summary>
            /// Enum INVALIDPARAMS for value: INVALID_PARAMS
            /// </summary>
            [EnumMember(Value = "INVALID_PARAMS")]
            INVALIDPARAMS = 20,

            /// <summary>
            /// Enum APPORIGINNOTEXIST for value: APP_ORIGIN_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ORIGIN_NOT_EXIST")]
            APPORIGINNOTEXIST = 21,

            /// <summary>
            /// Enum RISKDECISIONCHECKFAIL for value: RISK_DECISION_CHECK_FAIL
            /// </summary>
            [EnumMember(Value = "RISK_DECISION_CHECK_FAIL")]
            RISKDECISIONCHECKFAIL = 22,

            /// <summary>
            /// Enum LOGOISBLANK for value: LOGO_IS_BLANK
            /// </summary>
            [EnumMember(Value = "LOGO_IS_BLANK")]
            LOGOISBLANK = 23,

            /// <summary>
            /// Enum DESCRIPTIONISBLANK for value: DESCRIPTION_IS_BLANK
            /// </summary>
            [EnumMember(Value = "DESCRIPTION_IS_BLANK")]
            DESCRIPTIONISBLANK = 24,

            /// <summary>
            /// Enum SERVICETELANDMAILBOTHBLANK for value: SERVICE_TEL_AND_MAIL_BOTH_BLANK
            /// </summary>
            [EnumMember(Value = "SERVICE_TEL_AND_MAIL_BOTH_BLANK")]
            SERVICETELANDMAILBOTHBLANK = 25,

            /// <summary>
            /// Enum ISVAPPIDISBLANK for value: ISV_APP_ID_IS_BLANK
            /// </summary>
            [EnumMember(Value = "ISV_APP_ID_IS_BLANK")]
            ISVAPPIDISBLANK = 26,

            /// <summary>
            /// Enum MINIAPPIDEXIST for value: MINI_APP_ID_EXIST
            /// </summary>
            [EnumMember(Value = "MINI_APP_ID_EXIST")]
            MINIAPPIDEXIST = 27,

            /// <summary>
            /// Enum CREATEMINIAPPEXCEEDMAXCOUNT for value: CREATE_MINI_APP_EXCEED_MAX_COUNT
            /// </summary>
            [EnumMember(Value = "CREATE_MINI_APP_EXCEED_MAX_COUNT")]
            CREATEMINIAPPEXCEEDMAXCOUNT = 28,

            /// <summary>
            /// Enum APPIDILLEGAL for value: APP_ID_ILLEGAL
            /// </summary>
            [EnumMember(Value = "APP_ID_ILLEGAL")]
            APPIDILLEGAL = 29,

            /// <summary>
            /// Enum APPIDEXIST for value: APP_ID_EXIST
            /// </summary>
            [EnumMember(Value = "APP_ID_EXIST")]
            APPIDEXIST = 30,

            /// <summary>
            /// Enum INVALIDMINIPLUGINNAME for value: INVALID_MINI_PLUGIN_NAME
            /// </summary>
            [EnumMember(Value = "INVALID_MINI_PLUGIN_NAME")]
            INVALIDMINIPLUGINNAME = 31

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerappCreateErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayOpenMiniInnerappCreateErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerappCreateErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayOpenMiniInnerappCreateErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayOpenMiniInnerappCreateErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayOpenMiniInnerappCreateErrorResponseModel {\n");
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
            return this.Equals(input as AlipayOpenMiniInnerappCreateErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerappCreateErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerappCreateErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerappCreateErrorResponseModel input)
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
