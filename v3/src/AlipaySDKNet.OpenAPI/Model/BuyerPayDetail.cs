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
    /// BuyerPayDetail
    /// </summary>
    [DataContract(Name = "BuyerPayDetail")]
    public partial class BuyerPayDetail : IEquatable<BuyerPayDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BuyerPayDetail" /> class.
        /// </summary>
        /// <param name="amount">买家支付金额，单位：元。.</param>
        /// <param name="payChannel">支付渠道.</param>
        public BuyerPayDetail(string amount = default(string), string payChannel = default(string))
        {
            this.Amount = amount;
            this.PayChannel = payChannel;
        }

        /// <summary>
        /// 买家支付金额，单位：元。
        /// </summary>
        /// <value>买家支付金额，单位：元。</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 支付渠道
        /// </summary>
        /// <value>支付渠道</value>
        [DataMember(Name = "pay_channel", EmitDefaultValue = false)]
        public string PayChannel { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BuyerPayDetail {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  PayChannel: ").Append(PayChannel).Append("\n");
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
            return this.Equals(input as BuyerPayDetail);
        }

        /// <summary>
        /// Returns true if BuyerPayDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of BuyerPayDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BuyerPayDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.PayChannel == input.PayChannel ||
                    (this.PayChannel != null &&
                    this.PayChannel.Equals(input.PayChannel))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.PayChannel != null)
                {
                    hashCode = (hashCode * 59) + this.PayChannel.GetHashCode();
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
