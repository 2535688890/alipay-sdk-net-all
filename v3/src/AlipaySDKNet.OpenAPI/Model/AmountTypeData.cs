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
    /// AmountTypeData
    /// </summary>
    [DataContract(Name = "AmountTypeData")]
    public partial class AmountTypeData : IEquatable<AmountTypeData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AmountTypeData" /> class.
        /// </summary>
        /// <param name="name">累计类型为金额类型的累计名称。为必传入参。.</param>
        /// <param name="outDiscountInfos">优惠信息。为List类型，支持传入多笔优惠，大部分场景传入一笔。包含：优惠名称，优惠类型，优惠金额（单位元）。 字段必传场景： 1.当累计模式为【交易绑定模式】时，为必传入参。 2.当累计模式为【交易解耦模式】，同时需要累计优惠信息时，为必传入参。.</param>
        /// <param name="tradeInfo">tradeInfo.</param>
        public AmountTypeData(string name = default(string), List<ZMGoOutDiscountInfo> outDiscountInfos = default(List<ZMGoOutDiscountInfo>), ZMGoTradeInfo tradeInfo = default(ZMGoTradeInfo))
        {
            this.Name = name;
            this.OutDiscountInfos = outDiscountInfos;
            this.TradeInfo = tradeInfo;
        }

        /// <summary>
        /// 累计类型为金额类型的累计名称。为必传入参。
        /// </summary>
        /// <value>累计类型为金额类型的累计名称。为必传入参。</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 优惠信息。为List类型，支持传入多笔优惠，大部分场景传入一笔。包含：优惠名称，优惠类型，优惠金额（单位元）。 字段必传场景： 1.当累计模式为【交易绑定模式】时，为必传入参。 2.当累计模式为【交易解耦模式】，同时需要累计优惠信息时，为必传入参。
        /// </summary>
        /// <value>优惠信息。为List类型，支持传入多笔优惠，大部分场景传入一笔。包含：优惠名称，优惠类型，优惠金额（单位元）。 字段必传场景： 1.当累计模式为【交易绑定模式】时，为必传入参。 2.当累计模式为【交易解耦模式】，同时需要累计优惠信息时，为必传入参。</value>
        [DataMember(Name = "out_discount_infos", EmitDefaultValue = false)]
        public List<ZMGoOutDiscountInfo> OutDiscountInfos { get; set; }

        /// <summary>
        /// Gets or Sets TradeInfo
        /// </summary>
        [DataMember(Name = "trade_info", EmitDefaultValue = false)]
        public ZMGoTradeInfo TradeInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AmountTypeData {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OutDiscountInfos: ").Append(OutDiscountInfos).Append("\n");
            sb.Append("  TradeInfo: ").Append(TradeInfo).Append("\n");
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
            return this.Equals(input as AmountTypeData);
        }

        /// <summary>
        /// Returns true if AmountTypeData instances are equal
        /// </summary>
        /// <param name="input">Instance of AmountTypeData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AmountTypeData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OutDiscountInfos == input.OutDiscountInfos ||
                    this.OutDiscountInfos != null &&
                    input.OutDiscountInfos != null &&
                    this.OutDiscountInfos.SequenceEqual(input.OutDiscountInfos)
                ) && 
                (
                    this.TradeInfo == input.TradeInfo ||
                    (this.TradeInfo != null &&
                    this.TradeInfo.Equals(input.TradeInfo))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.OutDiscountInfos != null)
                {
                    hashCode = (hashCode * 59) + this.OutDiscountInfos.GetHashCode();
                }
                if (this.TradeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeInfo.GetHashCode();
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
