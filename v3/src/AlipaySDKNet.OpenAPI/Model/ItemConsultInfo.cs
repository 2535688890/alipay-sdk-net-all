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
    /// ItemConsultInfo
    /// </summary>
    [DataContract(Name = "ItemConsultInfo")]
    public partial class ItemConsultInfo : IEquatable<ItemConsultInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemConsultInfo" /> class.
        /// </summary>
        /// <param name="itemId">商品id.</param>
        /// <param name="promoAmount">商品优惠金额，单位为元.</param>
        /// <param name="promoCount">商品优惠数量.</param>
        public ItemConsultInfo(string itemId = default(string), string promoAmount = default(string), string promoCount = default(string))
        {
            this.ItemId = itemId;
            this.PromoAmount = promoAmount;
            this.PromoCount = promoCount;
        }

        /// <summary>
        /// 商品id
        /// </summary>
        /// <value>商品id</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品优惠金额，单位为元
        /// </summary>
        /// <value>商品优惠金额，单位为元</value>
        [DataMember(Name = "promo_amount", EmitDefaultValue = false)]
        public string PromoAmount { get; set; }

        /// <summary>
        /// 商品优惠数量
        /// </summary>
        /// <value>商品优惠数量</value>
        [DataMember(Name = "promo_count", EmitDefaultValue = false)]
        public string PromoCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemConsultInfo {\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  PromoAmount: ").Append(PromoAmount).Append("\n");
            sb.Append("  PromoCount: ").Append(PromoCount).Append("\n");
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
            return this.Equals(input as ItemConsultInfo);
        }

        /// <summary>
        /// Returns true if ItemConsultInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemConsultInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemConsultInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.PromoAmount == input.PromoAmount ||
                    (this.PromoAmount != null &&
                    this.PromoAmount.Equals(input.PromoAmount))
                ) && 
                (
                    this.PromoCount == input.PromoCount ||
                    (this.PromoCount != null &&
                    this.PromoCount.Equals(input.PromoCount))
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
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.PromoAmount != null)
                {
                    hashCode = (hashCode * 59) + this.PromoAmount.GetHashCode();
                }
                if (this.PromoCount != null)
                {
                    hashCode = (hashCode * 59) + this.PromoCount.GetHashCode();
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
