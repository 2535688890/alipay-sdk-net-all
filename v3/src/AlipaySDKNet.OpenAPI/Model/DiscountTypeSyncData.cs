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
    /// DiscountTypeSyncData
    /// </summary>
    [DataContract(Name = "DiscountTypeSyncData")]
    public partial class DiscountTypeSyncData : IEquatable<DiscountTypeSyncData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DiscountTypeSyncData" /> class.
        /// </summary>
        /// <param name="discountAmount">商户回传的优惠金额，如用户享受的红包金额，单位元.</param>
        /// <param name="discountDesc">商户数据回传的优惠信息的名称。.</param>
        public DiscountTypeSyncData(string discountAmount = default(string), string discountDesc = default(string))
        {
            this.DiscountAmount = discountAmount;
            this.DiscountDesc = discountDesc;
        }

        /// <summary>
        /// 商户回传的优惠金额，如用户享受的红包金额，单位元
        /// </summary>
        /// <value>商户回传的优惠金额，如用户享受的红包金额，单位元</value>
        [DataMember(Name = "discount_amount", EmitDefaultValue = false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 商户数据回传的优惠信息的名称。
        /// </summary>
        /// <value>商户数据回传的优惠信息的名称。</value>
        [DataMember(Name = "discount_desc", EmitDefaultValue = false)]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DiscountTypeSyncData {\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountDesc: ").Append(DiscountDesc).Append("\n");
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
            return this.Equals(input as DiscountTypeSyncData);
        }

        /// <summary>
        /// Returns true if DiscountTypeSyncData instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountTypeSyncData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountTypeSyncData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && 
                (
                    this.DiscountDesc == input.DiscountDesc ||
                    (this.DiscountDesc != null &&
                    this.DiscountDesc.Equals(input.DiscountDesc))
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
                if (this.DiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountAmount.GetHashCode();
                }
                if (this.DiscountDesc != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountDesc.GetHashCode();
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
