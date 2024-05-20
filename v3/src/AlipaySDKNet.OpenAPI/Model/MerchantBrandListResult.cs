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
    /// MerchantBrandListResult
    /// </summary>
    [DataContract(Name = "MerchantBrandListResult")]
    public partial class MerchantBrandListResult : IEquatable<MerchantBrandListResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantBrandListResult" /> class.
        /// </summary>
        /// <param name="brandListResult">商户已有品牌.</param>
        public MerchantBrandListResult(List<BrandResult> brandListResult = default(List<BrandResult>))
        {
            this.BrandListResult = brandListResult;
        }

        /// <summary>
        /// 商户已有品牌
        /// </summary>
        /// <value>商户已有品牌</value>
        [DataMember(Name = "brand_list_result", EmitDefaultValue = false)]
        public List<BrandResult> BrandListResult { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantBrandListResult {\n");
            sb.Append("  BrandListResult: ").Append(BrandListResult).Append("\n");
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
            return this.Equals(input as MerchantBrandListResult);
        }

        /// <summary>
        /// Returns true if MerchantBrandListResult instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantBrandListResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantBrandListResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandListResult == input.BrandListResult ||
                    this.BrandListResult != null &&
                    input.BrandListResult != null &&
                    this.BrandListResult.SequenceEqual(input.BrandListResult)
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
                if (this.BrandListResult != null)
                {
                    hashCode = (hashCode * 59) + this.BrandListResult.GetHashCode();
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
