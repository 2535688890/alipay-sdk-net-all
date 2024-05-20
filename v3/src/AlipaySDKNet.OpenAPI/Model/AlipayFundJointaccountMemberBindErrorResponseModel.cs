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
    /// AlipayFundJointaccountMemberBindErrorResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountMemberBindErrorResponseModel")]
    public partial class AlipayFundJointaccountMemberBindErrorResponseModel : IEquatable<AlipayFundJointaccountMemberBindErrorResponseModel>, IValidatableObject
    {
        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum PRODUCTNOTSIGN for value: PRODUCT_NOT_SIGN
            /// </summary>
            [EnumMember(Value = "PRODUCT_NOT_SIGN")]
            PRODUCTNOTSIGN = 1,

            /// <summary>
            /// Enum ANALYSISPARAMERROR for value: ANALYSIS_PARAM_ERROR
            /// </summary>
            [EnumMember(Value = "ANALYSIS_PARAM_ERROR")]
            ANALYSISPARAMERROR = 2,

            /// <summary>
            /// Enum PARAMNAMENOTBLANK for value: PARAM_NAME_NOT_BLANK
            /// </summary>
            [EnumMember(Value = "PARAM_NAME_NOT_BLANK")]
            PARAMNAMENOTBLANK = 3,

            /// <summary>
            /// Enum AGREEMENTNOTEXIST for value: AGREEMENT_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "AGREEMENT_NOT_EXIST")]
            AGREEMENTNOTEXIST = 4,

            /// <summary>
            /// Enum AGREEMENTISINVALID for value: AGREEMENT_IS_INVALID
            /// </summary>
            [EnumMember(Value = "AGREEMENT_IS_INVALID")]
            AGREEMENTISINVALID = 5,

            /// <summary>
            /// Enum AGREEMENTSTATUSISNOTNORMAL for value: AGREEMENT_STATUS_IS_NOT_NORMAL
            /// </summary>
            [EnumMember(Value = "AGREEMENT_STATUS_IS_NOT_NORMAL")]
            AGREEMENTSTATUSISNOTNORMAL = 6,

            /// <summary>
            /// Enum AGREEMENTISOUTOFDATE for value: AGREEMENT_IS_OUT_OF_DATE
            /// </summary>
            [EnumMember(Value = "AGREEMENT_IS_OUT_OF_DATE")]
            AGREEMENTISOUTOFDATE = 7,

            /// <summary>
            /// Enum HORIZONTALAUTHORITYEXCEPTION for value: HORIZONTAL_AUTHORITY_EXCEPTION
            /// </summary>
            [EnumMember(Value = "HORIZONTAL_AUTHORITY_EXCEPTION")]
            HORIZONTALAUTHORITYEXCEPTION = 8,

            /// <summary>
            /// Enum USERNOTEXIST for value: USER_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "USER_NOT_EXIST")]
            USERNOTEXIST = 9,

            /// <summary>
            /// Enum USERTYPENOTALLOWED for value: USER_TYPE_NOT_ALLOWED
            /// </summary>
            [EnumMember(Value = "USER_TYPE_NOT_ALLOWED")]
            USERTYPENOTALLOWED = 10,

            /// <summary>
            /// Enum USERUNREALNAME for value: USER_UNREAL_NAME
            /// </summary>
            [EnumMember(Value = "USER_UNREAL_NAME")]
            USERUNREALNAME = 11,

            /// <summary>
            /// Enum CERTTYPEERROR for value: CERT_TYPE_ERROR
            /// </summary>
            [EnumMember(Value = "CERT_TYPE_ERROR")]
            CERTTYPEERROR = 12,

            /// <summary>
            /// Enum NEEDTOSETPPW for value: NEED_TO_SET_PPW
            /// </summary>
            [EnumMember(Value = "NEED_TO_SET_PPW")]
            NEEDTOSETPPW = 13,

            /// <summary>
            /// Enum USERSTATUSERROR for value: USER_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "USER_STATUS_ERROR")]
            USERSTATUSERROR = 14,

            /// <summary>
            /// Enum INVITEMEMBERFAIL for value: INVITE_MEMBER_FAIL
            /// </summary>
            [EnumMember(Value = "INVITE_MEMBER_FAIL")]
            INVITEMEMBERFAIL = 15,

            /// <summary>
            /// Enum JOINTACCOUNTDUPLICATEINVITE for value: JOINT_ACCOUNT_DUPLICATE_INVITE
            /// </summary>
            [EnumMember(Value = "JOINT_ACCOUNT_DUPLICATE_INVITE")]
            JOINTACCOUNTDUPLICATEINVITE = 16,

            /// <summary>
            /// Enum ALREADYREGISTERMEMBER for value: ALREADY_REGISTER_MEMBER
            /// </summary>
            [EnumMember(Value = "ALREADY_REGISTER_MEMBER")]
            ALREADYREGISTERMEMBER = 17,

            /// <summary>
            /// Enum JOINTACCOUNTAPPLYSTATUSERROR for value: JOINT_ACCOUNT_APPLY_STATUS_ERROR
            /// </summary>
            [EnumMember(Value = "JOINT_ACCOUNT_APPLY_STATUS_ERROR")]
            JOINTACCOUNTAPPLYSTATUSERROR = 18,

            /// <summary>
            /// Enum ENTERPRISEMEMBERNUMEXCEEDMAX for value: ENTERPRISE_MEMBER_NUM_EXCEED_MAX
            /// </summary>
            [EnumMember(Value = "ENTERPRISE_MEMBER_NUM_EXCEED_MAX")]
            ENTERPRISEMEMBERNUMEXCEEDMAX = 19,

            /// <summary>
            /// Enum JOINEDACCOUNTNUMEXCEEDMAX for value: JOINED_ACCOUNT_NUM_EXCEED_MAX
            /// </summary>
            [EnumMember(Value = "JOINED_ACCOUNT_NUM_EXCEED_MAX")]
            JOINEDACCOUNTNUMEXCEEDMAX = 20,

            /// <summary>
            /// Enum USERGROUPOVERMAX for value: USER_GROUP_OVER_MAX
            /// </summary>
            [EnumMember(Value = "USER_GROUP_OVER_MAX")]
            USERGROUPOVERMAX = 21,

            /// <summary>
            /// Enum FUNDGROUPNOTEXIST for value: FUND_GROUP_NOT_EXIST
            /// </summary>
            [EnumMember(Value = "FUND_GROUP_NOT_EXIST")]
            FUNDGROUPNOTEXIST = 22,

            /// <summary>
            /// Enum FUNDIDENTITYNOTALLOWED for value: FUND_IDENTITY_NOT_ALLOWED
            /// </summary>
            [EnumMember(Value = "FUND_IDENTITY_NOT_ALLOWED")]
            FUNDIDENTITYNOTALLOWED = 23,

            /// <summary>
            /// Enum ACCOUNTNOMULTIFUNDPERMISSION for value: ACCOUNT_NO_MULTI_FUND_PERMISSION
            /// </summary>
            [EnumMember(Value = "ACCOUNT_NO_MULTI_FUND_PERMISSION")]
            ACCOUNTNOMULTIFUNDPERMISSION = 24,

            /// <summary>
            /// Enum FUNDIDENTITYPARAMERROR for value: FUND_IDENTITY_PARAM_ERROR
            /// </summary>
            [EnumMember(Value = "FUND_IDENTITY_PARAM_ERROR")]
            FUNDIDENTITYPARAMERROR = 25,

            /// <summary>
            /// Enum COMMONLOCKCONFLICT for value: COMMON_LOCK_CONFLICT
            /// </summary>
            [EnumMember(Value = "COMMON_LOCK_CONFLICT")]
            COMMONLOCKCONFLICT = 26,

            /// <summary>
            /// Enum ILLEGALARGUMENT for value: ILLEGAL_ARGUMENT
            /// </summary>
            [EnumMember(Value = "ILLEGAL_ARGUMENT")]
            ILLEGALARGUMENT = 27,

            /// <summary>
            /// Enum SYSTEMERROR for value: SYSTEM_ERROR
            /// </summary>
            [EnumMember(Value = "SYSTEM_ERROR")]
            SYSTEMERROR = 28,

            /// <summary>
            /// Enum COMMONRPCERROR for value: COMMON_RPC_ERROR
            /// </summary>
            [EnumMember(Value = "COMMON_RPC_ERROR")]
            COMMONRPCERROR = 29,

            /// <summary>
            /// Enum OPENIDTRANSFORMERROR for value: OPEN_ID_TRANSFORM_ERROR
            /// </summary>
            [EnumMember(Value = "OPEN_ID_TRANSFORM_ERROR")]
            OPENIDTRANSFORMERROR = 30

        }


        /// <summary>
        /// 错误码
        /// </summary>
        /// <value>错误码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountMemberBindErrorResponseModel" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AlipayFundJointaccountMemberBindErrorResponseModel() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountMemberBindErrorResponseModel" /> class.
        /// </summary>
        /// <param name="code">错误码 (required).</param>
        /// <param name="links">解决方案链接.</param>
        /// <param name="message">错误描述 (required).</param>
        public AlipayFundJointaccountMemberBindErrorResponseModel(CodeEnum code = default(CodeEnum), string links = default(string), string message = default(string))
        {
            this.Code = code;
            // to ensure "message" is required (not null)
            // if (message == null)
            // {
            //     throw new ArgumentNullException("message is a required property for AlipayFundJointaccountMemberBindErrorResponseModel and cannot be null");
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
            sb.Append("class AlipayFundJointaccountMemberBindErrorResponseModel {\n");
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
            return this.Equals(input as AlipayFundJointaccountMemberBindErrorResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountMemberBindErrorResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountMemberBindErrorResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountMemberBindErrorResponseModel input)
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
