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
    /// ZMGOCycleFlexConfig
    /// </summary>
    [DataContract(Name = "ZMGOCycleFlexConfig")]
    public partial class ZMGOCycleFlexConfig : IEquatable<ZMGOCycleFlexConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZMGOCycleFlexConfig" /> class.
        /// </summary>
        /// <param name="cycleFlexWithholdFeeName">周期灵活扣的费用名称.</param>
        /// <param name="cycleFlexWithholdMaxPrice">周期灵活扣单期扣款的最大额度.</param>
        /// <param name="cycleFlexWithholdTotalPeriodCount">周期灵活扣的总期数.</param>
        public ZMGOCycleFlexConfig(string cycleFlexWithholdFeeName = default(string), string cycleFlexWithholdMaxPrice = default(string), int cycleFlexWithholdTotalPeriodCount = default(int))
        {
            this.CycleFlexWithholdFeeName = cycleFlexWithholdFeeName;
            this.CycleFlexWithholdMaxPrice = cycleFlexWithholdMaxPrice;
            this.CycleFlexWithholdTotalPeriodCount = cycleFlexWithholdTotalPeriodCount;
        }

        /// <summary>
        /// 周期灵活扣的费用名称
        /// </summary>
        /// <value>周期灵活扣的费用名称</value>
        [DataMember(Name = "cycle_flex_withhold_fee_name", EmitDefaultValue = false)]
        public string CycleFlexWithholdFeeName { get; set; }

        /// <summary>
        /// 周期灵活扣单期扣款的最大额度
        /// </summary>
        /// <value>周期灵活扣单期扣款的最大额度</value>
        [DataMember(Name = "cycle_flex_withhold_max_price", EmitDefaultValue = false)]
        public string CycleFlexWithholdMaxPrice { get; set; }

        /// <summary>
        /// 周期灵活扣的总期数
        /// </summary>
        /// <value>周期灵活扣的总期数</value>
        [DataMember(Name = "cycle_flex_withhold_total_period_count", EmitDefaultValue = false)]
        public int CycleFlexWithholdTotalPeriodCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZMGOCycleFlexConfig {\n");
            sb.Append("  CycleFlexWithholdFeeName: ").Append(CycleFlexWithholdFeeName).Append("\n");
            sb.Append("  CycleFlexWithholdMaxPrice: ").Append(CycleFlexWithholdMaxPrice).Append("\n");
            sb.Append("  CycleFlexWithholdTotalPeriodCount: ").Append(CycleFlexWithholdTotalPeriodCount).Append("\n");
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
            return this.Equals(input as ZMGOCycleFlexConfig);
        }

        /// <summary>
        /// Returns true if ZMGOCycleFlexConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ZMGOCycleFlexConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZMGOCycleFlexConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CycleFlexWithholdFeeName == input.CycleFlexWithholdFeeName ||
                    (this.CycleFlexWithholdFeeName != null &&
                    this.CycleFlexWithholdFeeName.Equals(input.CycleFlexWithholdFeeName))
                ) && 
                (
                    this.CycleFlexWithholdMaxPrice == input.CycleFlexWithholdMaxPrice ||
                    (this.CycleFlexWithholdMaxPrice != null &&
                    this.CycleFlexWithholdMaxPrice.Equals(input.CycleFlexWithholdMaxPrice))
                ) && 
                (
                    this.CycleFlexWithholdTotalPeriodCount == input.CycleFlexWithholdTotalPeriodCount ||
                    this.CycleFlexWithholdTotalPeriodCount.Equals(input.CycleFlexWithholdTotalPeriodCount)
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
                if (this.CycleFlexWithholdFeeName != null)
                {
                    hashCode = (hashCode * 59) + this.CycleFlexWithholdFeeName.GetHashCode();
                }
                if (this.CycleFlexWithholdMaxPrice != null)
                {
                    hashCode = (hashCode * 59) + this.CycleFlexWithholdMaxPrice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CycleFlexWithholdTotalPeriodCount.GetHashCode();
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
