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
    /// AlipayEbppPdeductBillPayStatusResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppPdeductBillPayStatusResponseModel")]
    public partial class AlipayEbppPdeductBillPayStatusResponseModel : IEquatable<AlipayEbppPdeductBillPayStatusResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppPdeductBillPayStatusResponseModel" /> class.
        /// </summary>
        /// <param name="agreementId">支付宝协议流水.</param>
        /// <param name="openId">用户UserId在应用AppId下的唯一用户标识.</param>
        /// <param name="orderNo">支付宝流billNo.</param>
        /// <param name="orderResultCode">订单的结果码.</param>
        /// <param name="orderResultMsg">订单的结果描述.</param>
        /// <param name="outOrderNo">外部订单流水.</param>
        /// <param name="status">支付宝订单支付状态。  0：未知状态。  1：支付成功。  2：支付失败。.</param>
        public AlipayEbppPdeductBillPayStatusResponseModel(string agreementId = default(string), string openId = default(string), string orderNo = default(string), string orderResultCode = default(string), string orderResultMsg = default(string), string outOrderNo = default(string), string status = default(string))
        {
            this.AgreementId = agreementId;
            this.OpenId = openId;
            this.OrderNo = orderNo;
            this.OrderResultCode = orderResultCode;
            this.OrderResultMsg = orderResultMsg;
            this.OutOrderNo = outOrderNo;
            this.Status = status;
        }

        /// <summary>
        /// 支付宝协议流水
        /// </summary>
        /// <value>支付宝协议流水</value>
        [DataMember(Name = "agreement_id", EmitDefaultValue = false)]
        public string AgreementId { get; set; }

        /// <summary>
        /// 用户UserId在应用AppId下的唯一用户标识
        /// </summary>
        /// <value>用户UserId在应用AppId下的唯一用户标识</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 支付宝流billNo
        /// </summary>
        /// <value>支付宝流billNo</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单的结果码
        /// </summary>
        /// <value>订单的结果码</value>
        [DataMember(Name = "order_result_code", EmitDefaultValue = false)]
        public string OrderResultCode { get; set; }

        /// <summary>
        /// 订单的结果描述
        /// </summary>
        /// <value>订单的结果描述</value>
        [DataMember(Name = "order_result_msg", EmitDefaultValue = false)]
        public string OrderResultMsg { get; set; }

        /// <summary>
        /// 外部订单流水
        /// </summary>
        /// <value>外部订单流水</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 支付宝订单支付状态。  0：未知状态。  1：支付成功。  2：支付失败。
        /// </summary>
        /// <value>支付宝订单支付状态。  0：未知状态。  1：支付成功。  2：支付失败。</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppPdeductBillPayStatusResponseModel {\n");
            sb.Append("  AgreementId: ").Append(AgreementId).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  OrderResultCode: ").Append(OrderResultCode).Append("\n");
            sb.Append("  OrderResultMsg: ").Append(OrderResultMsg).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as AlipayEbppPdeductBillPayStatusResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppPdeductBillPayStatusResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppPdeductBillPayStatusResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppPdeductBillPayStatusResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementId == input.AgreementId ||
                    (this.AgreementId != null &&
                    this.AgreementId.Equals(input.AgreementId))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    (this.OrderNo != null &&
                    this.OrderNo.Equals(input.OrderNo))
                ) && 
                (
                    this.OrderResultCode == input.OrderResultCode ||
                    (this.OrderResultCode != null &&
                    this.OrderResultCode.Equals(input.OrderResultCode))
                ) && 
                (
                    this.OrderResultMsg == input.OrderResultMsg ||
                    (this.OrderResultMsg != null &&
                    this.OrderResultMsg.Equals(input.OrderResultMsg))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.AgreementId != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementId.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                }
                if (this.OrderResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.OrderResultCode.GetHashCode();
                }
                if (this.OrderResultMsg != null)
                {
                    hashCode = (hashCode * 59) + this.OrderResultMsg.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
