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
    /// AlipayFundEnterprisepayMemberModifyErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundEnterprisepayMemberModifyErrorResponseModel")]
    public partial class AlipayFundEnterprisepayMemberModifyErrorResponseModel : IEquatable<AlipayFundEnterprisepayMemberModifyErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 1,

            /// <summary>
            /// Enum AGREEMENTNOTEXIST for value: AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "AGREEMENT_NOT_EXIST")]
            AGREEMENTNOTEXIST = 2,

            /// <summary>
            /// Enum ILLEGALARGUMENT for value: ILLEGAL_ARGUMENT
            /// </summary>
            [EnumMember(Value = "ILLEGAL_ARGUMENT")]
            ILLEGALARGUMENT = 3,

            /// <summary>
            /// Enum HORIZONTALAUTHORITYEXCEPTION for value: HORIZONTAL_AUTHORITY_EXCEPTION
            /// </summary>
            [EnumMember(Value = "HORIZONTAL_AUTHORITY_EXCEPTION")]
            HORIZONTALAUTHORITYEXCEPTION = 4,

            /// <summary>
            /// Enum NOTREGISTERMEMBER for value: NOT_REGISTER_MEMBER
            /// </summary>
            [EnumMember(Value = "NOT_REGISTER_MEMBER")]
            NOTREGISTERMEMBER = 5,

            /// <summary>
            /// Enum FUNDGROUPNOTEXIST for value: FUND_GROUP_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "FUND_GROUP_NOT_EXIST")]
            FUNDGROUPNOTEXIST = 6,

            /// <summary>
            /// Enum FUNDIDENTITYNOTALLOWED for value: FUND_IDENTITY_NOT_ALLOWED
            /// </summary>
            [EnumMember(Value = "FUND_IDENTITY_NOT_ALLOWED")]
            FUNDIDENTITYNOTALLOWED = 7,

            /// <summary>
            /// Enum ACCOUNTNOMULTIFUNDPERMISSION for value: ACCOUNT_NO_MULTI_FUND_PERMISSION
            /// </summary>
            [EnumMember(Value = "ACCOUNT_NO_MULTI_FUND_PERMISSION")]
            ACCOUNTNOMULTIFUNDPERMISSION = 8,

            /// <summary>
            /// Enum AGREEMENTISINVALID for value: AGREEMENT_IS_INVALID
            /// </summary>
            [EnumMember(Value = "AGREEMENT_IS_INVALID")]
            AGREEMENTISINVALID = 9,

            /// <summary>
            /// Enum AGREEMENTSTATUSISNOTNORMAL for value: AGREEMENT_STATUS_IS_NOT_NORMAL
            /// </summary>
            [EnumMember(Value = "AGREEMENT_STATUS_IS_NOT_NORMAL")]
            AGREEMENTSTATUSISNOTNORMAL = 10,

            /// <summary>
            /// Enum AGREEMENTISOUTOFDATE for value: AGREEMENT_IS_OUT_OF_DATE
            /// </summary>
            [EnumMember(Value = "AGREEMENT_IS_OUT_OF_DATE")]
            AGREEMENTISOUTOFDATE = 11,

            /// <summary>
            /// Enum USERAGREEMENTSIGNFAIL for value: USER_AGREEMENT_SIGN_FAIL
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_SIGN_FAIL")]
            USERAGREEMENTSIGNFAIL = 12,

            /// <summary>
            /// Enum UNSUPPORTUPDATESCENE for value: UN_SUPPORT_UPDATE_SCENE
            /// </summary>
            [EnumMember(Value = "UN_SUPPORT_UPDATE_SCENE")]
            UNSUPPORTUPDATESCENE = 13,

            /// <summary>
            /// Enum USERAGREEMENTUPDATEFAIL for value: USER_AGREEMENT_UPDATE_FAIL
            /// </summary>
            [EnumMember(Value = "USER_AGREEMENT_UPDATE_FAIL")]
            USERAGREEMENTUPDATEFAIL = 14,

            /// <summary>
            /// Enum FUNDIDENTITYPARAMERROR for value: FUND_IDENTITY_PARAM_ERROR
            /// </summary>
            [EnumMember(Value = "FUND_IDENTITY_PARAM_ERROR")]
            FUNDIDENTITYPARAMERROR = 15,

            /// <summary>
            /// Enum BIZSCENENOTADMIT for value: BIZ_SCENE_NOT_ADMIT
            /// </summary>
            [EnumMember(Value = "BIZ_SCENE_NOT_ADMIT")]
            BIZSCENENOTADMIT = 16,

            /// <summary>
            /// Enum MEMBERFUNDMODIFYFAIL for value: MEMBER_FUND_MODIFY_FAIL
            /// </summary>
            [EnumMember(Value = "MEMBER_FUND_MODIFY_FAIL")]
            MEMBERFUNDMODIFYFAIL = 17,

            /// <summary>
            /// Enum JAIDENTITYINVALID for value: JA_IDENTITY_INVALID
            /// </summary>
            [EnumMember(Value = "JA_IDENTITY_INVALID")]
            JAIDENTITYINVALID = 18

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayMemberModifyErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayFundEnterprisepayMemberModifyErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundEnterprisepayMemberModifyErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayFundEnterprisepayMemberModifyErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayFundEnterprisepayMemberModifyErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayFundEnterprisepayMemberModifyErrorResponseModel {\n");
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
            return this.Equals(input as AlipayFundEnterprisepayMemberModifyErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundEnterprisepayMemberModifyErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundEnterprisepayMemberModifyErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundEnterprisepayMemberModifyErrorResponseModel input)
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
