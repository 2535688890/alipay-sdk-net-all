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
    /// AlipayTradeOrderPayResponseModel
    /// </summary>
    [DataContract(Name = "AlipayTradeOrderPayResponseModel")]
    public partial class AlipayTradeOrderPayResponseModel : IEquatable<AlipayTradeOrderPayResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeOrderPayResponseModel" /> class.
        /// </summary>
        /// <param name="asyncPaymentMode">异步支付模式。订单使用异步支付模式时才有值。 目前有五种值： ASYNC_DELAY_PAY(异步延时付款); ASYNC_REALTIME_PAY(异步准实时付款); SYNC_DIRECT_PAY(同步直接扣款); NORMAL_ASYNC_PAY(纯异步付款); QUOTA_OCCUPYIED_ASYNC_PAY(异步支付并且预占了先享后付额度);.</param>
        /// <param name="fulfillmentAmount">实际履约金额，单位（元）。仅履约场景才会返回.</param>
        /// <param name="gmtPayment">交易支付时间.</param>
        /// <param name="outRequestNo">商户请求号.</param>
        /// <param name="outTradeNo">商户订单号.</param>
        /// <param name="totalAmount">订单总金额。元为单元，精确到2位小数。.</param>
        /// <param name="tradeNo">支付宝交易号.</param>
        public AlipayTradeOrderPayResponseModel(string asyncPaymentMode = default(string), string fulfillmentAmount = default(string), string gmtPayment = default(string), string outRequestNo = default(string), string outTradeNo = default(string), string totalAmount = default(string), string tradeNo = default(string))
        {
            this.AsyncPaymentMode = asyncPaymentMode;
            this.FulfillmentAmount = fulfillmentAmount;
            this.GmtPayment = gmtPayment;
            this.OutRequestNo = outRequestNo;
            this.OutTradeNo = outTradeNo;
            this.TotalAmount = totalAmount;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 异步支付模式。订单使用异步支付模式时才有值。 目前有五种值： ASYNC_DELAY_PAY(异步延时付款); ASYNC_REALTIME_PAY(异步准实时付款); SYNC_DIRECT_PAY(同步直接扣款); NORMAL_ASYNC_PAY(纯异步付款); QUOTA_OCCUPYIED_ASYNC_PAY(异步支付并且预占了先享后付额度);
        /// </summary>
        /// <value>异步支付模式。订单使用异步支付模式时才有值。 目前有五种值： ASYNC_DELAY_PAY(异步延时付款); ASYNC_REALTIME_PAY(异步准实时付款); SYNC_DIRECT_PAY(同步直接扣款); NORMAL_ASYNC_PAY(纯异步付款); QUOTA_OCCUPYIED_ASYNC_PAY(异步支付并且预占了先享后付额度);</value>
        [DataMember(Name = "async_payment_mode", EmitDefaultValue = false)]
        public string AsyncPaymentMode { get; set; }

        /// <summary>
        /// 实际履约金额，单位（元）。仅履约场景才会返回
        /// </summary>
        /// <value>实际履约金额，单位（元）。仅履约场景才会返回</value>
        [DataMember(Name = "fulfillment_amount", EmitDefaultValue = false)]
        public string FulfillmentAmount { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        /// <value>交易支付时间</value>
        [DataMember(Name = "gmt_payment", EmitDefaultValue = false)]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 商户请求号
        /// </summary>
        /// <value>商户请求号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        /// <value>商户订单号</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 订单总金额。元为单元，精确到2位小数。
        /// </summary>
        /// <value>订单总金额。元为单元，精确到2位小数。</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public string TotalAmount { get; set; }

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
            sb.Append("class AlipayTradeOrderPayResponseModel {\n");
            sb.Append("  AsyncPaymentMode: ").Append(AsyncPaymentMode).Append("\n");
            sb.Append("  FulfillmentAmount: ").Append(FulfillmentAmount).Append("\n");
            sb.Append("  GmtPayment: ").Append(GmtPayment).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
            return this.Equals(input as AlipayTradeOrderPayResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeOrderPayResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeOrderPayResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeOrderPayResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AsyncPaymentMode == input.AsyncPaymentMode ||
                    (this.AsyncPaymentMode != null &&
                    this.AsyncPaymentMode.Equals(input.AsyncPaymentMode))
                ) && 
                (
                    this.FulfillmentAmount == input.FulfillmentAmount ||
                    (this.FulfillmentAmount != null &&
                    this.FulfillmentAmount.Equals(input.FulfillmentAmount))
                ) && 
                (
                    this.GmtPayment == input.GmtPayment ||
                    (this.GmtPayment != null &&
                    this.GmtPayment.Equals(input.GmtPayment))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.OutTradeNo == input.OutTradeNo ||
                    (this.OutTradeNo != null &&
                    this.OutTradeNo.Equals(input.OutTradeNo))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
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
                if (this.AsyncPaymentMode != null)
                {
                    hashCode = (hashCode * 59) + this.AsyncPaymentMode.GetHashCode();
                }
                if (this.FulfillmentAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FulfillmentAmount.GetHashCode();
                }
                if (this.GmtPayment != null)
                {
                    hashCode = (hashCode * 59) + this.GmtPayment.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
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
