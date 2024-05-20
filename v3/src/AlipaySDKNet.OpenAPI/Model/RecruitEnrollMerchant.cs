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
    /// RecruitEnrollMerchant
    /// </summary>
    [DataContract(Name = "RecruitEnrollMerchant")]
    public partial class RecruitEnrollMerchant : IEquatable<RecruitEnrollMerchant>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RecruitEnrollMerchant" /> class.
        /// </summary>
        /// <param name="merchantUid">商户唯一ID(商户pid).</param>
        public RecruitEnrollMerchant(string merchantUid = default(string))
        {
            this.MerchantUid = merchantUid;
        }

        /// <summary>
        /// 商户唯一ID(商户pid)
        /// </summary>
        /// <value>商户唯一ID(商户pid)</value>
        [DataMember(Name = "merchant_uid", EmitDefaultValue = false)]
        public string MerchantUid { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RecruitEnrollMerchant {\n");
            sb.Append("  MerchantUid: ").Append(MerchantUid).Append("\n");
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
            return this.Equals(input as RecruitEnrollMerchant);
        }

        /// <summary>
        /// Returns true if RecruitEnrollMerchant instances are equal
        /// </summary>
        /// <param name="input">Instance of RecruitEnrollMerchant to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RecruitEnrollMerchant input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantUid == input.MerchantUid ||
                    (this.MerchantUid != null &&
                    this.MerchantUid.Equals(input.MerchantUid))
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
                if (this.MerchantUid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantUid.GetHashCode();
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
