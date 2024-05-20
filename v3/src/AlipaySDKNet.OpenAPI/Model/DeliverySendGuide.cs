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
    /// DeliverySendGuide
    /// </summary>
    [DataContract(Name = "DeliverySendGuide")]
    public partial class DeliverySendGuide : IEquatable<DeliverySendGuide>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliverySendGuide" /> class.
        /// </summary>
        /// <param name="deliveryGuideUrl">引导链接，从支付宝公域跳转到服务商(商户)承接页的引导链接。.</param>
        public DeliverySendGuide(string deliveryGuideUrl = default(string))
        {
            this.DeliveryGuideUrl = deliveryGuideUrl;
        }

        /// <summary>
        /// 引导链接，从支付宝公域跳转到服务商(商户)承接页的引导链接。
        /// </summary>
        /// <value>引导链接，从支付宝公域跳转到服务商(商户)承接页的引导链接。</value>
        [DataMember(Name = "delivery_guide_url", EmitDefaultValue = false)]
        public string DeliveryGuideUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliverySendGuide {\n");
            sb.Append("  DeliveryGuideUrl: ").Append(DeliveryGuideUrl).Append("\n");
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
            return this.Equals(input as DeliverySendGuide);
        }

        /// <summary>
        /// Returns true if DeliverySendGuide instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliverySendGuide to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliverySendGuide input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryGuideUrl == input.DeliveryGuideUrl ||
                    (this.DeliveryGuideUrl != null &&
                    this.DeliveryGuideUrl.Equals(input.DeliveryGuideUrl))
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
                if (this.DeliveryGuideUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryGuideUrl.GetHashCode();
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
