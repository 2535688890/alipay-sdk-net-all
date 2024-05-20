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
    /// AlipayPcreditHuabeiAuthRefundApplyModel
    /// </summary>
    [DataContract(Name = "AlipayPcreditHuabeiAuthRefundApplyModel")]
    public partial class AlipayPcreditHuabeiAuthRefundApplyModel : IEquatable<AlipayPcreditHuabeiAuthRefundApplyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayPcreditHuabeiAuthRefundApplyModel" /> class.
        /// </summary>
        /// <param name="agreementNo">签约花芝的业务协议号，在签约成功、结算成功等通知中回回传给商户。.</param>
        /// <param name="alipayUserId">支付宝用户ID.</param>
        /// <param name="authOptId">支付宝侧授权操作单据id,在结算扣款成功的通知消息中会回传。在周期扣款场景下，和trade_no必传其中一个值。.</param>
        /// <param name="memo">本次退款说明.</param>
        /// <param name="openId">支付宝用户ID.</param>
        /// <param name="outRequestNo">外部请求号.</param>
        /// <param name="partnerId">商户ID.</param>
        /// <param name="refundAmount">退款金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="refundType">MEMBER_FEE_REFUND 会员费结算退款 WITHHOLD_FEE_REFUND 周期扣款金额退款 默认为MEMBER_FEE_REFUND.</param>
        /// <param name="tradeNo">支付宝交易号,在结算扣款成功的通知中会回传。 在周期扣款场景下，和auth_opt_id必传其中一个值。.</param>
        public AlipayPcreditHuabeiAuthRefundApplyModel(string agreementNo = default(string), string alipayUserId = default(string), string authOptId = default(string), string memo = default(string), string openId = default(string), string outRequestNo = default(string), string partnerId = default(string), string refundAmount = default(string), string refundType = default(string), string tradeNo = default(string))
        {
            this.AgreementNo = agreementNo;
            this.AlipayUserId = alipayUserId;
            this.AuthOptId = authOptId;
            this.Memo = memo;
            this.OpenId = openId;
            this.OutRequestNo = outRequestNo;
            this.PartnerId = partnerId;
            this.RefundAmount = refundAmount;
            this.RefundType = refundType;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 签约花芝的业务协议号，在签约成功、结算成功等通知中回回传给商户。
        /// </summary>
        /// <value>签约花芝的业务协议号，在签约成功、结算成功等通知中回回传给商户。</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        /// <value>支付宝用户ID</value>
        [DataMember(Name = "alipay_user_id", EmitDefaultValue = false)]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 支付宝侧授权操作单据id,在结算扣款成功的通知消息中会回传。在周期扣款场景下，和trade_no必传其中一个值。
        /// </summary>
        /// <value>支付宝侧授权操作单据id,在结算扣款成功的通知消息中会回传。在周期扣款场景下，和trade_no必传其中一个值。</value>
        [DataMember(Name = "auth_opt_id", EmitDefaultValue = false)]
        public string AuthOptId { get; set; }

        /// <summary>
        /// 本次退款说明
        /// </summary>
        /// <value>本次退款说明</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        /// <value>支付宝用户ID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        /// <value>外部请求号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        /// <value>商户ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 退款金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>退款金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "refund_amount", EmitDefaultValue = false)]
        public string RefundAmount { get; set; }

        /// <summary>
        /// MEMBER_FEE_REFUND 会员费结算退款 WITHHOLD_FEE_REFUND 周期扣款金额退款 默认为MEMBER_FEE_REFUND
        /// </summary>
        /// <value>MEMBER_FEE_REFUND 会员费结算退款 WITHHOLD_FEE_REFUND 周期扣款金额退款 默认为MEMBER_FEE_REFUND</value>
        [DataMember(Name = "refund_type", EmitDefaultValue = false)]
        public string RefundType { get; set; }

        /// <summary>
        /// 支付宝交易号,在结算扣款成功的通知中会回传。 在周期扣款场景下，和auth_opt_id必传其中一个值。
        /// </summary>
        /// <value>支付宝交易号,在结算扣款成功的通知中会回传。 在周期扣款场景下，和auth_opt_id必传其中一个值。</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayPcreditHuabeiAuthRefundApplyModel {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  AlipayUserId: ").Append(AlipayUserId).Append("\n");
            sb.Append("  AuthOptId: ").Append(AuthOptId).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  RefundAmount: ").Append(RefundAmount).Append("\n");
            sb.Append("  RefundType: ").Append(RefundType).Append("\n");
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
            return this.Equals(input as AlipayPcreditHuabeiAuthRefundApplyModel);
        }

        /// <summary>
        /// Returns true if AlipayPcreditHuabeiAuthRefundApplyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayPcreditHuabeiAuthRefundApplyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayPcreditHuabeiAuthRefundApplyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.AlipayUserId == input.AlipayUserId ||
                    (this.AlipayUserId != null &&
                    this.AlipayUserId.Equals(input.AlipayUserId))
                ) && 
                (
                    this.AuthOptId == input.AuthOptId ||
                    (this.AuthOptId != null &&
                    this.AuthOptId.Equals(input.AuthOptId))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.RefundAmount == input.RefundAmount ||
                    (this.RefundAmount != null &&
                    this.RefundAmount.Equals(input.RefundAmount))
                ) && 
                (
                    this.RefundType == input.RefundType ||
                    (this.RefundType != null &&
                    this.RefundType.Equals(input.RefundType))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.AlipayUserId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayUserId.GetHashCode();
                }
                if (this.AuthOptId != null)
                {
                    hashCode = (hashCode * 59) + this.AuthOptId.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.RefundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RefundAmount.GetHashCode();
                }
                if (this.RefundType != null)
                {
                    hashCode = (hashCode * 59) + this.RefundType.GetHashCode();
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
