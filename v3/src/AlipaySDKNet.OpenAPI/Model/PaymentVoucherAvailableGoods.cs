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
    /// PaymentVoucherAvailableGoods
    /// </summary>
    [DataContract(Name = "PaymentVoucherAvailableGoods")]
    public partial class PaymentVoucherAvailableGoods : IEquatable<PaymentVoucherAvailableGoods>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentVoucherAvailableGoods" /> class.
        /// </summary>
        /// <param name="goodsDescription">商品描述信息。 用于券面展示，向用户介绍商品.</param>
        /// <param name="goodsIds">可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。.</param>
        /// <param name="goodsName">商品名称.</param>
        public PaymentVoucherAvailableGoods(string goodsDescription = default(string), List<string> goodsIds = default(List<string>), string goodsName = default(string))
        {
            this.GoodsDescription = goodsDescription;
            this.GoodsIds = goodsIds;
            this.GoodsName = goodsName;
        }

        /// <summary>
        /// 商品描述信息。 用于券面展示，向用户介绍商品
        /// </summary>
        /// <value>商品描述信息。 用于券面展示，向用户介绍商品</value>
        [DataMember(Name = "goods_description", EmitDefaultValue = false)]
        public string GoodsDescription { get; set; }

        /// <summary>
        /// 可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。
        /// </summary>
        /// <value>可优惠商品编码，商家自定义商品编码。当用户支付时，交易中的商品编码和支付券配置的商品编码有任一匹配时，可以使用优惠券。</value>
        [DataMember(Name = "goods_ids", EmitDefaultValue = false)]
        public List<string> GoodsIds { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "goods_name", EmitDefaultValue = false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentVoucherAvailableGoods {\n");
            sb.Append("  GoodsDescription: ").Append(GoodsDescription).Append("\n");
            sb.Append("  GoodsIds: ").Append(GoodsIds).Append("\n");
            sb.Append("  GoodsName: ").Append(GoodsName).Append("\n");
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
            return this.Equals(input as PaymentVoucherAvailableGoods);
        }

        /// <summary>
        /// Returns true if PaymentVoucherAvailableGoods instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentVoucherAvailableGoods to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentVoucherAvailableGoods input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GoodsDescription == input.GoodsDescription ||
                    (this.GoodsDescription != null &&
                    this.GoodsDescription.Equals(input.GoodsDescription))
                ) && 
                (
                    this.GoodsIds == input.GoodsIds ||
                    this.GoodsIds != null &&
                    input.GoodsIds != null &&
                    this.GoodsIds.SequenceEqual(input.GoodsIds)
                ) && 
                (
                    this.GoodsName == input.GoodsName ||
                    (this.GoodsName != null &&
                    this.GoodsName.Equals(input.GoodsName))
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
                if (this.GoodsDescription != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDescription.GetHashCode();
                }
                if (this.GoodsIds != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsIds.GetHashCode();
                }
                if (this.GoodsName != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsName.GetHashCode();
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
