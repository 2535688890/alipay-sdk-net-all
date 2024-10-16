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
    /// DeliveryPlayConfig
    /// </summary>
    [DataContract(Name = "DeliveryPlayConfig")]
    public partial class DeliveryPlayConfig : IEquatable<DeliveryPlayConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryPlayConfig" /> class.
        /// </summary>
        /// <param name="deliveryFullSendConfig">deliveryFullSendConfig.</param>
        /// <param name="deliverySingleSendConfig">deliverySingleSendConfig.</param>
        public DeliveryPlayConfig(DeliveryFullSendConfig deliveryFullSendConfig = default(DeliveryFullSendConfig), DeliverySingleSendConfig deliverySingleSendConfig = default(DeliverySingleSendConfig))
        {
            this.DeliveryFullSendConfig = deliveryFullSendConfig;
            this.DeliverySingleSendConfig = deliverySingleSendConfig;
        }

        /// <summary>
        /// Gets or Sets DeliveryFullSendConfig
        /// </summary>
        [DataMember(Name = "delivery_full_send_config", EmitDefaultValue = false)]
        public DeliveryFullSendConfig DeliveryFullSendConfig { get; set; }

        /// <summary>
        /// Gets or Sets DeliverySingleSendConfig
        /// </summary>
        [DataMember(Name = "delivery_single_send_config", EmitDefaultValue = false)]
        public DeliverySingleSendConfig DeliverySingleSendConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryPlayConfig {\n");
            sb.Append("  DeliveryFullSendConfig: ").Append(DeliveryFullSendConfig).Append("\n");
            sb.Append("  DeliverySingleSendConfig: ").Append(DeliverySingleSendConfig).Append("\n");
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
            return this.Equals(input as DeliveryPlayConfig);
        }

        /// <summary>
        /// Returns true if DeliveryPlayConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryPlayConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryPlayConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryFullSendConfig == input.DeliveryFullSendConfig ||
                    (this.DeliveryFullSendConfig != null &&
                    this.DeliveryFullSendConfig.Equals(input.DeliveryFullSendConfig))
                ) && 
                (
                    this.DeliverySingleSendConfig == input.DeliverySingleSendConfig ||
                    (this.DeliverySingleSendConfig != null &&
                    this.DeliverySingleSendConfig.Equals(input.DeliverySingleSendConfig))
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
                if (this.DeliveryFullSendConfig != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryFullSendConfig.GetHashCode();
                }
                if (this.DeliverySingleSendConfig != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverySingleSendConfig.GetHashCode();
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
