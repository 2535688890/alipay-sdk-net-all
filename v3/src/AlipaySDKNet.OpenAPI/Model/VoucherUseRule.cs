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
    /// VoucherUseRule
    /// </summary>
    [DataContract(Name = "VoucherUseRule")]
    public partial class VoucherUseRule : IEquatable<VoucherUseRule>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherUseRule" /> class.
        /// </summary>
        /// <param name="discountVoucher">discountVoucher.</param>
        /// <param name="exchangeVoucher">exchangeVoucher.</param>
        /// <param name="fixVoucher">fixVoucher.</param>
        /// <param name="specialVoucher">specialVoucher.</param>
        /// <param name="voucherAvailableScope">voucherAvailableScope.</param>
        /// <param name="voucherValidPeriod">voucherValidPeriod.</param>
        public VoucherUseRule(DiscountVoucher discountVoucher = default(DiscountVoucher), ExchangeVoucher exchangeVoucher = default(ExchangeVoucher), FixVoucher fixVoucher = default(FixVoucher), SpecialVoucher specialVoucher = default(SpecialVoucher), VoucherAvailableScope voucherAvailableScope = default(VoucherAvailableScope), VoucherValidPeriod voucherValidPeriod = default(VoucherValidPeriod))
        {
            this.DiscountVoucher = discountVoucher;
            this.ExchangeVoucher = exchangeVoucher;
            this.FixVoucher = fixVoucher;
            this.SpecialVoucher = specialVoucher;
            this.VoucherAvailableScope = voucherAvailableScope;
            this.VoucherValidPeriod = voucherValidPeriod;
        }

        /// <summary>
        /// Gets or Sets DiscountVoucher
        /// </summary>
        [DataMember(Name = "discount_voucher", EmitDefaultValue = false)]
        public DiscountVoucher DiscountVoucher { get; set; }

        /// <summary>
        /// Gets or Sets ExchangeVoucher
        /// </summary>
        [DataMember(Name = "exchange_voucher", EmitDefaultValue = false)]
        public ExchangeVoucher ExchangeVoucher { get; set; }

        /// <summary>
        /// Gets or Sets FixVoucher
        /// </summary>
        [DataMember(Name = "fix_voucher", EmitDefaultValue = false)]
        public FixVoucher FixVoucher { get; set; }

        /// <summary>
        /// Gets or Sets SpecialVoucher
        /// </summary>
        [DataMember(Name = "special_voucher", EmitDefaultValue = false)]
        public SpecialVoucher SpecialVoucher { get; set; }

        /// <summary>
        /// Gets or Sets VoucherAvailableScope
        /// </summary>
        [DataMember(Name = "voucher_available_scope", EmitDefaultValue = false)]
        public VoucherAvailableScope VoucherAvailableScope { get; set; }

        /// <summary>
        /// Gets or Sets VoucherValidPeriod
        /// </summary>
        [DataMember(Name = "voucher_valid_period", EmitDefaultValue = false)]
        public VoucherValidPeriod VoucherValidPeriod { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherUseRule {\n");
            sb.Append("  DiscountVoucher: ").Append(DiscountVoucher).Append("\n");
            sb.Append("  ExchangeVoucher: ").Append(ExchangeVoucher).Append("\n");
            sb.Append("  FixVoucher: ").Append(FixVoucher).Append("\n");
            sb.Append("  SpecialVoucher: ").Append(SpecialVoucher).Append("\n");
            sb.Append("  VoucherAvailableScope: ").Append(VoucherAvailableScope).Append("\n");
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
            return this.Equals(input as VoucherUseRule);
        }

        /// <summary>
        /// Returns true if VoucherUseRule instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherUseRule to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherUseRule input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DiscountVoucher == input.DiscountVoucher ||
                    (this.DiscountVoucher != null &&
                    this.DiscountVoucher.Equals(input.DiscountVoucher))
                ) && 
                (
                    this.ExchangeVoucher == input.ExchangeVoucher ||
                    (this.ExchangeVoucher != null &&
                    this.ExchangeVoucher.Equals(input.ExchangeVoucher))
                ) && 
                (
                    this.FixVoucher == input.FixVoucher ||
                    (this.FixVoucher != null &&
                    this.FixVoucher.Equals(input.FixVoucher))
                ) && 
                (
                    this.SpecialVoucher == input.SpecialVoucher ||
                    (this.SpecialVoucher != null &&
                    this.SpecialVoucher.Equals(input.SpecialVoucher))
                ) && 
                (
                    this.VoucherAvailableScope == input.VoucherAvailableScope ||
                    (this.VoucherAvailableScope != null &&
                    this.VoucherAvailableScope.Equals(input.VoucherAvailableScope))
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
                if (this.DiscountVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountVoucher.GetHashCode();
                }
                if (this.ExchangeVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.ExchangeVoucher.GetHashCode();
                }
                if (this.FixVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.FixVoucher.GetHashCode();
                }
                if (this.SpecialVoucher != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialVoucher.GetHashCode();
                }
                if (this.VoucherAvailableScope != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherAvailableScope.GetHashCode();
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
