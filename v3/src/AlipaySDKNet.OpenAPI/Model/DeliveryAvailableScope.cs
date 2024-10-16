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
    /// DeliveryAvailableScope
    /// </summary>
    [DataContract(Name = "DeliveryAvailableScope")]
    public partial class DeliveryAvailableScope : IEquatable<DeliveryAvailableScope>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryAvailableScope" /> class.
        /// </summary>
        /// <param name="deliveryAvailableCityCode">deliveryAvailableCityCode.</param>
        /// <param name="deliveryAvailableScopeType">投放可用范围类型，目前支持的类型是城市范围CITY_CODE.</param>
        public DeliveryAvailableScope(DeliveryAvailableCityCode deliveryAvailableCityCode = default(DeliveryAvailableCityCode), string deliveryAvailableScopeType = default(string))
        {
            this.DeliveryAvailableCityCode = deliveryAvailableCityCode;
            this.DeliveryAvailableScopeType = deliveryAvailableScopeType;
        }

        /// <summary>
        /// Gets or Sets DeliveryAvailableCityCode
        /// </summary>
        [DataMember(Name = "delivery_available_city_code", EmitDefaultValue = false)]
        public DeliveryAvailableCityCode DeliveryAvailableCityCode { get; set; }

        /// <summary>
        /// 投放可用范围类型，目前支持的类型是城市范围CITY_CODE
        /// </summary>
        /// <value>投放可用范围类型，目前支持的类型是城市范围CITY_CODE</value>
        [DataMember(Name = "delivery_available_scope_type", EmitDefaultValue = false)]
        public string DeliveryAvailableScopeType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryAvailableScope {\n");
            sb.Append("  DeliveryAvailableCityCode: ").Append(DeliveryAvailableCityCode).Append("\n");
            sb.Append("  DeliveryAvailableScopeType: ").Append(DeliveryAvailableScopeType).Append("\n");
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
            return this.Equals(input as DeliveryAvailableScope);
        }

        /// <summary>
        /// Returns true if DeliveryAvailableScope instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryAvailableScope to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryAvailableScope input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryAvailableCityCode == input.DeliveryAvailableCityCode ||
                    (this.DeliveryAvailableCityCode != null &&
                    this.DeliveryAvailableCityCode.Equals(input.DeliveryAvailableCityCode))
                ) && 
                (
                    this.DeliveryAvailableScopeType == input.DeliveryAvailableScopeType ||
                    (this.DeliveryAvailableScopeType != null &&
                    this.DeliveryAvailableScopeType.Equals(input.DeliveryAvailableScopeType))
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
                if (this.DeliveryAvailableCityCode != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAvailableCityCode.GetHashCode();
                }
                if (this.DeliveryAvailableScopeType != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAvailableScopeType.GetHashCode();
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
