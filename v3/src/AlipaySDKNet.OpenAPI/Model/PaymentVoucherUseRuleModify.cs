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
    /// PaymentVoucherUseRuleModify
    /// </summary>
    [DataContract(Name = "PaymentVoucherUseRuleModify")]
    public partial class PaymentVoucherUseRuleModify : IEquatable<PaymentVoucherUseRuleModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVoucherUseRuleModify" /> class.
        /// </summary>
        /// <param name="availableAppIds">可核销的支付宝小程序id   限制：  1、必须是支付宝小程序  2、如果包含重复的小程序id会自动进行去重操作。 3、可核销小程序范围只能扩大不能缩小.</param>
        /// <param name="availableGoods">availableGoods.</param>
        /// <param name="availableMerchant">availableMerchant.</param>
        /// <param name="availableStoreIds">可核销支付门店id。   限制：  1、available_store_ids中的门店id必须是支付宝门店id。  2、available_store_ids如果包含重复的门店id会自动进行去重操作。 3、可核销门店范围只能扩大不能缩小.</param>
        /// <param name="voucherValidPeriod">voucherValidPeriod.</param>
        public PaymentVoucherUseRuleModify(string availableAppIds = default(string), PaymentVoucherAvailableGoodsModify availableGoods = default(PaymentVoucherAvailableGoodsModify), PaymentVoucherAvailableMerchantModify availableMerchant = default(PaymentVoucherAvailableMerchantModify), string availableStoreIds = default(string), PaymentVoucherValidPeriodModify voucherValidPeriod = default(PaymentVoucherValidPeriodModify))
        {
            this.AvailableAppIds = availableAppIds;
            this.AvailableGoods = availableGoods;
            this.AvailableMerchant = availableMerchant;
            this.AvailableStoreIds = availableStoreIds;
            this.VoucherValidPeriod = voucherValidPeriod;
        }

        /// <summary>
        /// 可核销的支付宝小程序id   限制：  1、必须是支付宝小程序  2、如果包含重复的小程序id会自动进行去重操作。 3、可核销小程序范围只能扩大不能缩小
        /// </summary>
        /// <value>可核销的支付宝小程序id   限制：  1、必须是支付宝小程序  2、如果包含重复的小程序id会自动进行去重操作。 3、可核销小程序范围只能扩大不能缩小</value>
        [DataMember(Name = "available_app_ids", EmitDefaultValue = false)]
        public string AvailableAppIds { get; set; }

        /// <summary>
        /// Gets or Sets AvailableGoods
        /// </summary>
        [DataMember(Name = "available_goods", EmitDefaultValue = false)]
        public PaymentVoucherAvailableGoodsModify AvailableGoods { get; set; }

        /// <summary>
        /// Gets or Sets AvailableMerchant
        /// </summary>
        [DataMember(Name = "available_merchant", EmitDefaultValue = false)]
        public PaymentVoucherAvailableMerchantModify AvailableMerchant { get; set; }

        /// <summary>
        /// 可核销支付门店id。   限制：  1、available_store_ids中的门店id必须是支付宝门店id。  2、available_store_ids如果包含重复的门店id会自动进行去重操作。 3、可核销门店范围只能扩大不能缩小
        /// </summary>
        /// <value>可核销支付门店id。   限制：  1、available_store_ids中的门店id必须是支付宝门店id。  2、available_store_ids如果包含重复的门店id会自动进行去重操作。 3、可核销门店范围只能扩大不能缩小</value>
        [DataMember(Name = "available_store_ids", EmitDefaultValue = false)]
        public string AvailableStoreIds { get; set; }

        /// <summary>
        /// Gets or Sets VoucherValidPeriod
        /// </summary>
        [DataMember(Name = "voucher_valid_period", EmitDefaultValue = false)]
        public PaymentVoucherValidPeriodModify VoucherValidPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVoucherUseRuleModify {\n");
            sb.Append("  AvailableAppIds: ").Append(AvailableAppIds).Append("\n");
            sb.Append("  AvailableGoods: ").Append(AvailableGoods).Append("\n");
            sb.Append("  AvailableMerchant: ").Append(AvailableMerchant).Append("\n");
            sb.Append("  AvailableStoreIds: ").Append(AvailableStoreIds).Append("\n");
            sb.Append("  VoucherValidPeriod: ").Append(VoucherValidPeriod).Append("\n");
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
            return this.Equals(input as PaymentVoucherUseRuleModify);
        }

        /// <summary>
        /// Returns true if PaymentVoucherUseRuleModify instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVoucherUseRuleModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVoucherUseRuleModify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvailableAppIds == input.AvailableAppIds ||
                    (this.AvailableAppIds != null &&
                    this.AvailableAppIds.Equals(input.AvailableAppIds))
                ) && 
                (
                    this.AvailableGoods == input.AvailableGoods ||
                    (this.AvailableGoods != null &&
                    this.AvailableGoods.Equals(input.AvailableGoods))
                ) && 
                (
                    this.AvailableMerchant == input.AvailableMerchant ||
                    (this.AvailableMerchant != null &&
                    this.AvailableMerchant.Equals(input.AvailableMerchant))
                ) && 
                (
                    this.AvailableStoreIds == input.AvailableStoreIds ||
                    (this.AvailableStoreIds != null &&
                    this.AvailableStoreIds.Equals(input.AvailableStoreIds))
                ) && 
                (
                    this.VoucherValidPeriod == input.VoucherValidPeriod ||
                    (this.VoucherValidPeriod != null &&
                    this.VoucherValidPeriod.Equals(input.VoucherValidPeriod))
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
                if (this.AvailableAppIds != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableAppIds.GetHashCode();
                }
                if (this.AvailableGoods != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableGoods.GetHashCode();
                }
                if (this.AvailableMerchant != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableMerchant.GetHashCode();
                }
                if (this.AvailableStoreIds != null)
                {
                    hashCode = (hashCode * 59) + this.AvailableStoreIds.GetHashCode();
                }
                if (this.VoucherValidPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherValidPeriod.GetHashCode();
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
