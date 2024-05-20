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
    /// VoucherSendRuleDetailModify
    /// </summary>
    [DataContract(Name = "VoucherSendRuleDetailModify")]
    public partial class VoucherSendRuleDetailModify : IEquatable<VoucherSendRuleDetailModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherSendRuleDetailModify" /> class.
        /// </summary>
        /// <param name="naturalPersonLimit">是否开启自然人领取限制。 自然人表示按照身份证纬度进行领取限制。.</param>
        /// <param name="phoneNumberLimit">是否开启电话号码领取限制。.</param>
        /// <param name="voucherQuantityLimitPerUser">每人领取限制。 默认按照支付宝uid进行领取限制;.</param>
        public VoucherSendRuleDetailModify(bool naturalPersonLimit = default(bool), string phoneNumberLimit = default(string), int voucherQuantityLimitPerUser = default(int))
        {
            this.NaturalPersonLimit = naturalPersonLimit;
            this.PhoneNumberLimit = phoneNumberLimit;
            this.VoucherQuantityLimitPerUser = voucherQuantityLimitPerUser;
        }

        /// <summary>
        /// 是否开启自然人领取限制。 自然人表示按照身份证纬度进行领取限制。
        /// </summary>
        /// <value>是否开启自然人领取限制。 自然人表示按照身份证纬度进行领取限制。</value>
        [DataMember(Name = "natural_person_limit", EmitDefaultValue = true)]
        public bool NaturalPersonLimit { get; set; }

        /// <summary>
        /// 是否开启电话号码领取限制。
        /// </summary>
        /// <value>是否开启电话号码领取限制。</value>
        [DataMember(Name = "phone_number_limit", EmitDefaultValue = false)]
        public string PhoneNumberLimit { get; set; }

        /// <summary>
        /// 每人领取限制。 默认按照支付宝uid进行领取限制;
        /// </summary>
        /// <value>每人领取限制。 默认按照支付宝uid进行领取限制;</value>
        [DataMember(Name = "voucher_quantity_limit_per_user", EmitDefaultValue = false)]
        public int VoucherQuantityLimitPerUser { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherSendRuleDetailModify {\n");
            sb.Append("  NaturalPersonLimit: ").Append(NaturalPersonLimit).Append("\n");
            sb.Append("  PhoneNumberLimit: ").Append(PhoneNumberLimit).Append("\n");
            sb.Append("  VoucherQuantityLimitPerUser: ").Append(VoucherQuantityLimitPerUser).Append("\n");
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
            return this.Equals(input as VoucherSendRuleDetailModify);
        }

        /// <summary>
        /// Returns true if VoucherSendRuleDetailModify instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherSendRuleDetailModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherSendRuleDetailModify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NaturalPersonLimit == input.NaturalPersonLimit ||
                    this.NaturalPersonLimit.Equals(input.NaturalPersonLimit)
                ) && 
                (
                    this.PhoneNumberLimit == input.PhoneNumberLimit ||
                    (this.PhoneNumberLimit != null &&
                    this.PhoneNumberLimit.Equals(input.PhoneNumberLimit))
                ) && 
                (
                    this.VoucherQuantityLimitPerUser == input.VoucherQuantityLimitPerUser ||
                    this.VoucherQuantityLimitPerUser.Equals(input.VoucherQuantityLimitPerUser)
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
                hashCode = (hashCode * 59) + this.NaturalPersonLimit.GetHashCode();
                if (this.PhoneNumberLimit != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumberLimit.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VoucherQuantityLimitPerUser.GetHashCode();
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
