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
    /// DeliveryFullSendConfig
    /// </summary>
    [DataContract(Name = "DeliveryFullSendConfig")]
    public partial class DeliveryFullSendConfig : IEquatable<DeliveryFullSendConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryFullSendConfig" /> class.
        /// </summary>
        /// <param name="deliveryContentInfo">deliveryContentInfo.</param>
        /// <param name="deliveryFloorAmount">满足消费金额门槛，左闭区间，单位元。 说明：限制支付时的订单金额最少满足的金额门槛。 限制：value &gt; 0 &amp;&amp; value &lt;&#x3D; 99999。.</param>
        public DeliveryFullSendConfig(DeliveryContentInfo deliveryContentInfo = default(DeliveryContentInfo), string deliveryFloorAmount = default(string))
        {
            this.DeliveryContentInfo = deliveryContentInfo;
            this.DeliveryFloorAmount = deliveryFloorAmount;
        }

        /// <summary>
        /// Gets or Sets DeliveryContentInfo
        /// </summary>
        [DataMember(Name = "delivery_content_info", EmitDefaultValue = false)]
        public DeliveryContentInfo DeliveryContentInfo { get; set; }

        /// <summary>
        /// 满足消费金额门槛，左闭区间，单位元。 说明：限制支付时的订单金额最少满足的金额门槛。 限制：value &gt; 0 &amp;&amp; value &lt;&#x3D; 99999。
        /// </summary>
        /// <value>满足消费金额门槛，左闭区间，单位元。 说明：限制支付时的订单金额最少满足的金额门槛。 限制：value &gt; 0 &amp;&amp; value &lt;&#x3D; 99999。</value>
        [DataMember(Name = "delivery_floor_amount", EmitDefaultValue = false)]
        public string DeliveryFloorAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryFullSendConfig {\n");
            sb.Append("  DeliveryContentInfo: ").Append(DeliveryContentInfo).Append("\n");
            sb.Append("  DeliveryFloorAmount: ").Append(DeliveryFloorAmount).Append("\n");
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
            return this.Equals(input as DeliveryFullSendConfig);
        }

        /// <summary>
        /// Returns true if DeliveryFullSendConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryFullSendConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryFullSendConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryContentInfo == input.DeliveryContentInfo ||
                    (this.DeliveryContentInfo != null &&
                    this.DeliveryContentInfo.Equals(input.DeliveryContentInfo))
                ) && 
                (
                    this.DeliveryFloorAmount == input.DeliveryFloorAmount ||
                    (this.DeliveryFloorAmount != null &&
                    this.DeliveryFloorAmount.Equals(input.DeliveryFloorAmount))
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
                if (this.DeliveryContentInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryContentInfo.GetHashCode();
                }
                if (this.DeliveryFloorAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryFloorAmount.GetHashCode();
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
