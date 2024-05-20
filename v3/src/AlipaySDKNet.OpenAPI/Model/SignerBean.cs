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
    /// SignerBean
    /// </summary>
    [DataContract(Name = "SignerBean")]
    public partial class SignerBean : IEquatable<SignerBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SignerBean" /> class.
        /// </summary>
        /// <param name="email">个人邮箱.</param>
        /// <param name="idNumber">个人证件号.</param>
        /// <param name="idType">个人证件类型（证件号不为空时必填，详见个人证件类型说明 ）.</param>
        /// <param name="mobile">个人手机号.</param>
        /// <param name="name">个人姓名.</param>
        /// <param name="org">org.</param>
        /// <param name="thirdPartyUserId">个人唯一标识：可传入平台的个人用户id、支付宝userid、证件号、手机号、邮箱等。.</param>
        public SignerBean(string email = default(string), string idNumber = default(string), string idType = default(string), string mobile = default(string), string name = default(string), Org org = default(Org), string thirdPartyUserId = default(string))
        {
            this.Email = email;
            this.IdNumber = idNumber;
            this.IdType = idType;
            this.Mobile = mobile;
            this.Name = name;
            this.Org = org;
            this.ThirdPartyUserId = thirdPartyUserId;
        }

        /// <summary>
        /// 个人邮箱
        /// </summary>
        /// <value>个人邮箱</value>
        [DataMember(Name = "email", EmitDefaultValue = false)]
        public string Email { get; set; }

        /// <summary>
        /// 个人证件号
        /// </summary>
        /// <value>个人证件号</value>
        [DataMember(Name = "id_number", EmitDefaultValue = false)]
        public string IdNumber { get; set; }

        /// <summary>
        /// 个人证件类型（证件号不为空时必填，详见个人证件类型说明 ）
        /// </summary>
        /// <value>个人证件类型（证件号不为空时必填，详见个人证件类型说明 ）</value>
        [DataMember(Name = "id_type", EmitDefaultValue = false)]
        public string IdType { get; set; }

        /// <summary>
        /// 个人手机号
        /// </summary>
        /// <value>个人手机号</value>
        [DataMember(Name = "mobile", EmitDefaultValue = false)]
        public string Mobile { get; set; }

        /// <summary>
        /// 个人姓名
        /// </summary>
        /// <value>个人姓名</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Org
        /// </summary>
        [DataMember(Name = "org", EmitDefaultValue = false)]
        public Org Org { get; set; }

        /// <summary>
        /// 个人唯一标识：可传入平台的个人用户id、支付宝userid、证件号、手机号、邮箱等。
        /// </summary>
        /// <value>个人唯一标识：可传入平台的个人用户id、支付宝userid、证件号、手机号、邮箱等。</value>
        [DataMember(Name = "third_party_user_id", EmitDefaultValue = false)]
        public string ThirdPartyUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SignerBean {\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  IdNumber: ").Append(IdNumber).Append("\n");
            sb.Append("  IdType: ").Append(IdType).Append("\n");
            sb.Append("  Mobile: ").Append(Mobile).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Org: ").Append(Org).Append("\n");
            sb.Append("  ThirdPartyUserId: ").Append(ThirdPartyUserId).Append("\n");
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
            return this.Equals(input as SignerBean);
        }

        /// <summary>
        /// Returns true if SignerBean instances are equal
        /// </summary>
        /// <param name="input">Instance of SignerBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SignerBean input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.IdNumber == input.IdNumber ||
                    (this.IdNumber != null &&
                    this.IdNumber.Equals(input.IdNumber))
                ) && 
                (
                    this.IdType == input.IdType ||
                    (this.IdType != null &&
                    this.IdType.Equals(input.IdType))
                ) && 
                (
                    this.Mobile == input.Mobile ||
                    (this.Mobile != null &&
                    this.Mobile.Equals(input.Mobile))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Org == input.Org ||
                    (this.Org != null &&
                    this.Org.Equals(input.Org))
                ) && 
                (
                    this.ThirdPartyUserId == input.ThirdPartyUserId ||
                    (this.ThirdPartyUserId != null &&
                    this.ThirdPartyUserId.Equals(input.ThirdPartyUserId))
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
                if (this.Email != null)
                {
                    hashCode = (hashCode * 59) + this.Email.GetHashCode();
                }
                if (this.IdNumber != null)
                {
                    hashCode = (hashCode * 59) + this.IdNumber.GetHashCode();
                }
                if (this.IdType != null)
                {
                    hashCode = (hashCode * 59) + this.IdType.GetHashCode();
                }
                if (this.Mobile != null)
                {
                    hashCode = (hashCode * 59) + this.Mobile.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Org != null)
                {
                    hashCode = (hashCode * 59) + this.Org.GetHashCode();
                }
                if (this.ThirdPartyUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdPartyUserId.GetHashCode();
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
