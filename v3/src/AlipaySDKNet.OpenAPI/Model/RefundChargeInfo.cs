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
    /// RefundChargeInfo
    /// </summary>
    [DataContract(Name = "RefundChargeInfo")]
    public partial class RefundChargeInfo : IEquatable<RefundChargeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefundChargeInfo" /> class.
        /// </summary>
        /// <param name="chargeType">收单手续费trade，花呗分期手续hbfq，其他手续费charge.</param>
        /// <param name="refundChargeFee">实退费用。单位：元。.</param>
        /// <param name="refundSubFeeDetailList">组合支付退费明细.</param>
        /// <param name="switchFeeRate">签约费率.</param>
        public RefundChargeInfo(string chargeType = default(string), string refundChargeFee = default(string), List<RefundSubFee> refundSubFeeDetailList = default(List<RefundSubFee>), string switchFeeRate = default(string))
        {
            this.ChargeType = chargeType;
            this.RefundChargeFee = refundChargeFee;
            this.RefundSubFeeDetailList = refundSubFeeDetailList;
            this.SwitchFeeRate = switchFeeRate;
        }

        /// <summary>
        /// 收单手续费trade，花呗分期手续hbfq，其他手续费charge
        /// </summary>
        /// <value>收单手续费trade，花呗分期手续hbfq，其他手续费charge</value>
        [DataMember(Name = "charge_type", EmitDefaultValue = false)]
        public string ChargeType { get; set; }

        /// <summary>
        /// 实退费用。单位：元。
        /// </summary>
        /// <value>实退费用。单位：元。</value>
        [DataMember(Name = "refund_charge_fee", EmitDefaultValue = false)]
        public string RefundChargeFee { get; set; }

        /// <summary>
        /// 组合支付退费明细
        /// </summary>
        /// <value>组合支付退费明细</value>
        [DataMember(Name = "refund_sub_fee_detail_list", EmitDefaultValue = false)]
        public List<RefundSubFee> RefundSubFeeDetailList { get; set; }

        /// <summary>
        /// 签约费率
        /// </summary>
        /// <value>签约费率</value>
        [DataMember(Name = "switch_fee_rate", EmitDefaultValue = false)]
        public string SwitchFeeRate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RefundChargeInfo {\n");
            sb.Append("  ChargeType: ").Append(ChargeType).Append("\n");
            sb.Append("  RefundChargeFee: ").Append(RefundChargeFee).Append("\n");
            sb.Append("  RefundSubFeeDetailList: ").Append(RefundSubFeeDetailList).Append("\n");
            sb.Append("  SwitchFeeRate: ").Append(SwitchFeeRate).Append("\n");
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
            return this.Equals(input as RefundChargeInfo);
        }

        /// <summary>
        /// Returns true if RefundChargeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RefundChargeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RefundChargeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChargeType == input.ChargeType ||
                    (this.ChargeType != null &&
                    this.ChargeType.Equals(input.ChargeType))
                ) && 
                (
                    this.RefundChargeFee == input.RefundChargeFee ||
                    (this.RefundChargeFee != null &&
                    this.RefundChargeFee.Equals(input.RefundChargeFee))
                ) && 
                (
                    this.RefundSubFeeDetailList == input.RefundSubFeeDetailList ||
                    this.RefundSubFeeDetailList != null &&
                    input.RefundSubFeeDetailList != null &&
                    this.RefundSubFeeDetailList.SequenceEqual(input.RefundSubFeeDetailList)
                ) && 
                (
                    this.SwitchFeeRate == input.SwitchFeeRate ||
                    (this.SwitchFeeRate != null &&
                    this.SwitchFeeRate.Equals(input.SwitchFeeRate))
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
                if (this.ChargeType != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeType.GetHashCode();
                }
                if (this.RefundChargeFee != null)
                {
                    hashCode = (hashCode * 59) + this.RefundChargeFee.GetHashCode();
                }
                if (this.RefundSubFeeDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.RefundSubFeeDetailList.GetHashCode();
                }
                if (this.SwitchFeeRate != null)
                {
                    hashCode = (hashCode * 59) + this.SwitchFeeRate.GetHashCode();
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
