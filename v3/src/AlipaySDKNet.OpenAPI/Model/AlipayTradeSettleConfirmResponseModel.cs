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
    /// AlipayTradeSettleConfirmResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeSettleConfirmResponseModel")]
    public partial class AlipayTradeSettleConfirmResponseModel : IEquatable<AlipayTradeSettleConfirmResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeSettleConfirmResponseModel" /> class.
        /// </summary>
        /// <param name="outRequestNo">确认结算请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制.</param>
        /// <param name="settleAmount">本次确认结算的实际结算金额，单位为元。.</param>
        /// <param name="tradeNo">支付宝交易号.</param>
        public AlipayTradeSettleConfirmResponseModel(string outRequestNo = default(string), string settleAmount = default(string), string tradeNo = default(string))
        {
            this.OutRequestNo = outRequestNo;
            this.SettleAmount = settleAmount;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 确认结算请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制
        /// </summary>
        /// <value>确认结算请求流水号，开发者自行生成并保证唯一性，作为业务幂等性控制</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次确认结算的实际结算金额，单位为元。
        /// </summary>
        /// <value>本次确认结算的实际结算金额，单位为元。</value>
        [DataMember(Name = "settle_amount", EmitDefaultValue = false)]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        /// <value>支付宝交易号</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeSettleConfirmResponseModel {\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  SettleAmount: ").Append(SettleAmount).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
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
            return this.Equals(input as AlipayTradeSettleConfirmResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeSettleConfirmResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeSettleConfirmResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeSettleConfirmResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.SettleAmount == input.SettleAmount ||
                    (this.SettleAmount != null &&
                    this.SettleAmount.Equals(input.SettleAmount))
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
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
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.SettleAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SettleAmount.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
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
