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
    /// VoucherAvailableGeographyScopeInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableGeographyScopeInfo")]
    public partial class VoucherAvailableGeographyScopeInfo : IEquatable<VoucherAvailableGeographyScopeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableGeographyScopeInfo" /> class.
        /// </summary>
        /// <param name="availableGeographyCityInfo">availableGeographyCityInfo.</param>
        /// <param name="availableGeographyScopeType">券可用地理位置类型。.</param>
        /// <param name="availableGeographyShopInfo">availableGeographyShopInfo.</param>
        public VoucherAvailableGeographyScopeInfo(VoucherAvailableGeographyCityInfo availableGeographyCityInfo = default(VoucherAvailableGeographyCityInfo), string availableGeographyScopeType = default(string), VoucherAvailableGeographyShopInfo availableGeographyShopInfo = default(VoucherAvailableGeographyShopInfo))
        {
            this.AvailableGeographyCityInfo = availableGeographyCityInfo;
            this.AvailableGeographyScopeType = availableGeographyScopeType;
            this.AvailableGeographyShopInfo = availableGeographyShopInfo;
        }

        /// <summary>
        /// Gets or Sets AvailableGeographyCityInfo
        /// </summary>
        [DataMember(Name = "available_geography_city_info", EmitDefaultValue = false)]
        public VoucherAvailableGeographyCityInfo AvailableGeographyCityInfo { get; set; }

        /// <summary>
        /// 券可用地理位置类型。
        /// </summary>
        /// <value>券可用地理位置类型。</value>
        [DataMember(Name = "available_geography_scope_type", EmitDefaultValue = false)]
        public string AvailableGeographyScopeType { get; set; }

        /// <summary>
        /// Gets or Sets AvailableGeographyShopInfo
        /// </summary>
        [DataMember(Name = "available_geography_shop_info", EmitDefaultValue = false)]
        public VoucherAvailableGeographyShopInfo AvailableGeographyShopInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableGeographyScopeInfo {\n");
            sb.Append("  AvailableGeographyCityInfo: ").Append(AvailableGeographyCityInfo).Append("\n");
            sb.Append("  AvailableGeographyScopeType: ").Append(AvailableGeographyScopeType).Append("\n");
            sb.Append("  AvailableGeographyShopInfo: ").Append(AvailableGeographyShopInfo).Append("\n");
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
            return this.Equals(input as VoucherAvailableGeographyScopeInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableGeographyScopeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableGeographyScopeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableGeographyScopeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableGeographyCityInfo == input.AvailableGeographyCityInfo ||
                    (this.AvailableGeographyCityInfo != null &&
                    this.AvailableGeographyCityInfo.Equals(input.AvailableGeographyCityInfo))
                ) && 
                (
                    this.AvailableGeographyScopeType == input.AvailableGeographyScopeType ||
                    (this.AvailableGeographyScopeType != null &&
                    this.AvailableGeographyScopeType.Equals(input.AvailableGeographyScopeType))
                ) && 
                (
                    this.AvailableGeographyShopInfo == input.AvailableGeographyShopInfo ||
                    (this.AvailableGeographyShopInfo != null &&
                    this.AvailableGeographyShopInfo.Equals(input.AvailableGeographyShopInfo))
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
                if (this.AvailableGeographyCityInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableGeographyCityInfo.GetHashCode();
                }
                if (this.AvailableGeographyScopeType != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableGeographyScopeType.GetHashCode();
                }
                if (this.AvailableGeographyShopInfo != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableGeographyShopInfo.GetHashCode();
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
