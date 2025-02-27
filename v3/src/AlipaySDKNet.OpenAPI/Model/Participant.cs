/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-16
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
    /// Participant
    /// </summary>
    [DataContract(Name = "Participant")]
    public partial class Participant : IEquatable<Participant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Participant" /> class.
        /// </summary>
        /// <param name="bankcardExtInfo">bankcardExtInfo.</param>
        /// <param name="certNo">参与方的证件号，支持身份证号、护照号。.</param>
        /// <param name="certType">参与方的证件类型。.</param>
        /// <param name="extInfo">描述参与方信息的扩展属性，使用前请与支付宝工程师确认.</param>
        /// <param name="identity">参与方的唯一标识.</param>
        /// <param name="identityType">参与方的标识类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、ALIPAY_OPEN_ID：支付宝openid 4、EXPRESS_DC_STFA：对公快捷银行卡.</param>
        /// <param name="merchantUserInfo">商户端的用户信息描述，目前可指定如下属性：  merchant_user_id：商户端的用户唯一ID  merchant_user_name：商户端的用户名  merchant_user_nickname：商户端的用户昵称  merchant_user_mobile：商户端的手机号.</param>
        /// <param name="name">参与方真实姓名，如果非空，将校验收款支付宝账号姓名一致性。当identity_type&#x3D;ALIPAY_LOGON_ID时，本字段必填。.</param>
        public Participant(BankcardExtInfo bankcardExtInfo = default(BankcardExtInfo), string certNo = default(string), string certType = default(string), string extInfo = default(string), string identity = default(string), string identityType = default(string), string merchantUserInfo = default(string), string name = default(string))
        {
            this.BankcardExtInfo = bankcardExtInfo;
            this.CertNo = certNo;
            this.CertType = certType;
            this.ExtInfo = extInfo;
            this.Identity = identity;
            this.IdentityType = identityType;
            this.MerchantUserInfo = merchantUserInfo;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets BankcardExtInfo
        /// </summary>
        [DataMember(Name = "bankcard_ext_info", EmitDefaultValue = false)]
        public BankcardExtInfo BankcardExtInfo { get; set; }

        /// <summary>
        /// 参与方的证件号，支持身份证号、护照号。
        /// </summary>
        /// <value>参与方的证件号，支持身份证号、护照号。</value>
        [DataMember(Name = "cert_no", EmitDefaultValue = false)]
        public string CertNo { get; set; }

        /// <summary>
        /// 参与方的证件类型。
        /// </summary>
        /// <value>参与方的证件类型。</value>
        [DataMember(Name = "cert_type", EmitDefaultValue = false)]
        public string CertType { get; set; }

        /// <summary>
        /// 描述参与方信息的扩展属性，使用前请与支付宝工程师确认
        /// </summary>
        /// <value>描述参与方信息的扩展属性，使用前请与支付宝工程师确认</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 参与方的唯一标识
        /// </summary>
        /// <value>参与方的唯一标识</value>
        [DataMember(Name = "identity", EmitDefaultValue = false)]
        public string Identity { get; set; }

        /// <summary>
        /// 参与方的标识类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、ALIPAY_OPEN_ID：支付宝openid 4、EXPRESS_DC_STFA：对公快捷银行卡
        /// </summary>
        /// <value>参与方的标识类型，目前支持如下类型： 1、ALIPAY_USER_ID 支付宝的会员ID 2、ALIPAY_LOGON_ID：支付宝登录号，支持邮箱和手机号格式 3、ALIPAY_OPEN_ID：支付宝openid 4、EXPRESS_DC_STFA：对公快捷银行卡</value>
        [DataMember(Name = "identity_type", EmitDefaultValue = false)]
        public string IdentityType { get; set; }

        /// <summary>
        /// 商户端的用户信息描述，目前可指定如下属性：  merchant_user_id：商户端的用户唯一ID  merchant_user_name：商户端的用户名  merchant_user_nickname：商户端的用户昵称  merchant_user_mobile：商户端的手机号
        /// </summary>
        /// <value>商户端的用户信息描述，目前可指定如下属性：  merchant_user_id：商户端的用户唯一ID  merchant_user_name：商户端的用户名  merchant_user_nickname：商户端的用户昵称  merchant_user_mobile：商户端的手机号</value>
        [DataMember(Name = "merchant_user_info", EmitDefaultValue = false)]
        public string MerchantUserInfo { get; set; }

        /// <summary>
        /// 参与方真实姓名，如果非空，将校验收款支付宝账号姓名一致性。当identity_type&#x3D;ALIPAY_LOGON_ID时，本字段必填。
        /// </summary>
        /// <value>参与方真实姓名，如果非空，将校验收款支付宝账号姓名一致性。当identity_type&#x3D;ALIPAY_LOGON_ID时，本字段必填。</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Participant {\n");
            sb.Append("  BankcardExtInfo: ").Append(BankcardExtInfo).Append("\n");
            sb.Append("  CertNo: ").Append(CertNo).Append("\n");
            sb.Append("  CertType: ").Append(CertType).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  Identity: ").Append(Identity).Append("\n");
            sb.Append("  IdentityType: ").Append(IdentityType).Append("\n");
            sb.Append("  MerchantUserInfo: ").Append(MerchantUserInfo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Participant);
        }

        /// <summary>
        /// Returns true if Participant instances are equal
        /// </summary>
        /// <param name="input">Instance of Participant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Participant input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BankcardExtInfo == input.BankcardExtInfo ||
                    (this.BankcardExtInfo != null &&
                    this.BankcardExtInfo.Equals(input.BankcardExtInfo))
                ) && 
                (
                    this.CertNo == input.CertNo ||
                    (this.CertNo != null &&
                    this.CertNo.Equals(input.CertNo))
                ) && 
                (
                    this.CertType == input.CertType ||
                    (this.CertType != null &&
                    this.CertType.Equals(input.CertType))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.Identity == input.Identity ||
                    (this.Identity != null &&
                    this.Identity.Equals(input.Identity))
                ) && 
                (
                    this.IdentityType == input.IdentityType ||
                    (this.IdentityType != null &&
                    this.IdentityType.Equals(input.IdentityType))
                ) && 
                (
                    this.MerchantUserInfo == input.MerchantUserInfo ||
                    (this.MerchantUserInfo != null &&
                    this.MerchantUserInfo.Equals(input.MerchantUserInfo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.BankcardExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BankcardExtInfo.GetHashCode();
                }
                if (this.CertNo != null)
                {
                    hashCode = (hashCode * 59) + this.CertNo.GetHashCode();
                }
                if (this.CertType != null)
                {
                    hashCode = (hashCode * 59) + this.CertType.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.Identity != null)
                {
                    hashCode = (hashCode * 59) + this.Identity.GetHashCode();
                }
                if (this.IdentityType != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityType.GetHashCode();
                }
                if (this.MerchantUserInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantUserInfo.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
