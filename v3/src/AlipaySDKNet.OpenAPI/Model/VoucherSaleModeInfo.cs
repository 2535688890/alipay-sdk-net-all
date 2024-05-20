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
    /// VoucherSaleModeInfo
    /// </summary>
    [DataContract(Name = "VoucherSaleModeInfo")]
    public partial class VoucherSaleModeInfo : IEquatable<VoucherSaleModeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherSaleModeInfo" /> class.
        /// </summary>
        /// <param name="fundCustodyMode">资金托管方式.</param>
        /// <param name="overdueRefundable">是否支持优惠券过期后，自动退款给用户。 不填默认否，枚举值： true：是  false：否。自动退款功能需要服务商在优惠券过期时，主动调用alipay.marketing.activity.order.refund接口进行退款。  如果配置优惠券时选择了过期自动退款，但是实际券过期后，服务商没有进行退款，那么用户投诉后，需要服务商进行解决。.</param>
        /// <param name="overdueRefundableNeedConfirm">在支持过期自动退款后，支付宝发起自动退款前 是否需要向商户确认退款。 不填默认否，枚举值： true：是 false：否。  如果选择了 true:是 ，则需要商户配合接入  过期自动退款前是否需要向商户确认SPI(spi.alipay.marketing.activity.order.refundconfirm)  以及   退款确认结果API(alipay.marketing.activity.order.refundconfirmcommit).</param>
        /// <param name="payeePid">收款账号。 目前的结算规则是，每核销一笔优惠券，支付宝会打款到该收款账户。.</param>
        /// <param name="refundable">购买的优惠券是否允许退款。 不填默认否，枚举值： true：是 false：否.</param>
        /// <param name="refundableNeedConfirm">在支持随时退后，支付宝发起退款前用于判断是否需要向商户确认退款。 不填默认否，枚举值： true：是 false：否。 如果选择了 true:是  ，则需要商户配合接入退款前是否需要向商户确认SPI(spi.alipay.marketing.activity.order.refundconfirm).</param>
        /// <param name="saleAmount">用户购买优惠券需要支付的金额.</param>
        /// <param name="settleInfo">settleInfo.</param>
        public VoucherSaleModeInfo(string fundCustodyMode = default(string), bool overdueRefundable = default(bool), bool overdueRefundableNeedConfirm = default(bool), string payeePid = default(string), bool refundable = default(bool), bool refundableNeedConfirm = default(bool), string saleAmount = default(string), BizfundSettleInfo settleInfo = default(BizfundSettleInfo))
        {
            this.FundCustodyMode = fundCustodyMode;
            this.OverdueRefundable = overdueRefundable;
            this.OverdueRefundableNeedConfirm = overdueRefundableNeedConfirm;
            this.PayeePid = payeePid;
            this.Refundable = refundable;
            this.RefundableNeedConfirm = refundableNeedConfirm;
            this.SaleAmount = saleAmount;
            this.SettleInfo = settleInfo;
        }

        /// <summary>
        /// 资金托管方式
        /// </summary>
        /// <value>资金托管方式</value>
        [DataMember(Name = "fund_custody_mode", EmitDefaultValue = false)]
        public string FundCustodyMode { get; set; }

        /// <summary>
        /// 是否支持优惠券过期后，自动退款给用户。 不填默认否，枚举值： true：是  false：否。自动退款功能需要服务商在优惠券过期时，主动调用alipay.marketing.activity.order.refund接口进行退款。  如果配置优惠券时选择了过期自动退款，但是实际券过期后，服务商没有进行退款，那么用户投诉后，需要服务商进行解决。
        /// </summary>
        /// <value>是否支持优惠券过期后，自动退款给用户。 不填默认否，枚举值： true：是  false：否。自动退款功能需要服务商在优惠券过期时，主动调用alipay.marketing.activity.order.refund接口进行退款。  如果配置优惠券时选择了过期自动退款，但是实际券过期后，服务商没有进行退款，那么用户投诉后，需要服务商进行解决。</value>
        [DataMember(Name = "overdue_refundable", EmitDefaultValue = true)]
        public bool OverdueRefundable { get; set; }

        /// <summary>
        /// 在支持过期自动退款后，支付宝发起自动退款前 是否需要向商户确认退款。 不填默认否，枚举值： true：是 false：否。  如果选择了 true:是 ，则需要商户配合接入  过期自动退款前是否需要向商户确认SPI(spi.alipay.marketing.activity.order.refundconfirm)  以及   退款确认结果API(alipay.marketing.activity.order.refundconfirmcommit)
        /// </summary>
        /// <value>在支持过期自动退款后，支付宝发起自动退款前 是否需要向商户确认退款。 不填默认否，枚举值： true：是 false：否。  如果选择了 true:是 ，则需要商户配合接入  过期自动退款前是否需要向商户确认SPI(spi.alipay.marketing.activity.order.refundconfirm)  以及   退款确认结果API(alipay.marketing.activity.order.refundconfirmcommit)</value>
        [DataMember(Name = "overdue_refundable_need_confirm", EmitDefaultValue = true)]
        public bool OverdueRefundableNeedConfirm { get; set; }

        /// <summary>
        /// 收款账号。 目前的结算规则是，每核销一笔优惠券，支付宝会打款到该收款账户。
        /// </summary>
        /// <value>收款账号。 目前的结算规则是，每核销一笔优惠券，支付宝会打款到该收款账户。</value>
        [DataMember(Name = "payee_pid", EmitDefaultValue = false)]
        public string PayeePid { get; set; }

        /// <summary>
        /// 购买的优惠券是否允许退款。 不填默认否，枚举值： true：是 false：否
        /// </summary>
        /// <value>购买的优惠券是否允许退款。 不填默认否，枚举值： true：是 false：否</value>
        [DataMember(Name = "refundable", EmitDefaultValue = true)]
        public bool Refundable { get; set; }

        /// <summary>
        /// 在支持随时退后，支付宝发起退款前用于判断是否需要向商户确认退款。 不填默认否，枚举值： true：是 false：否。 如果选择了 true:是  ，则需要商户配合接入退款前是否需要向商户确认SPI(spi.alipay.marketing.activity.order.refundconfirm)
        /// </summary>
        /// <value>在支持随时退后，支付宝发起退款前用于判断是否需要向商户确认退款。 不填默认否，枚举值： true：是 false：否。 如果选择了 true:是  ，则需要商户配合接入退款前是否需要向商户确认SPI(spi.alipay.marketing.activity.order.refundconfirm)</value>
        [DataMember(Name = "refundable_need_confirm", EmitDefaultValue = true)]
        public bool RefundableNeedConfirm { get; set; }

        /// <summary>
        /// 用户购买优惠券需要支付的金额
        /// </summary>
        /// <value>用户购买优惠券需要支付的金额</value>
        [DataMember(Name = "sale_amount", EmitDefaultValue = false)]
        public string SaleAmount { get; set; }

        /// <summary>
        /// Gets or Sets SettleInfo
        /// </summary>
        [DataMember(Name = "settle_info", EmitDefaultValue = false)]
        public BizfundSettleInfo SettleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherSaleModeInfo {\n");
            sb.Append("  FundCustodyMode: ").Append(FundCustodyMode).Append("\n");
            sb.Append("  OverdueRefundable: ").Append(OverdueRefundable).Append("\n");
            sb.Append("  OverdueRefundableNeedConfirm: ").Append(OverdueRefundableNeedConfirm).Append("\n");
            sb.Append("  PayeePid: ").Append(PayeePid).Append("\n");
            sb.Append("  Refundable: ").Append(Refundable).Append("\n");
            sb.Append("  RefundableNeedConfirm: ").Append(RefundableNeedConfirm).Append("\n");
            sb.Append("  SaleAmount: ").Append(SaleAmount).Append("\n");
            sb.Append("  SettleInfo: ").Append(SettleInfo).Append("\n");
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
            return this.Equals(input as VoucherSaleModeInfo);
        }

        /// <summary>
        /// Returns true if VoucherSaleModeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherSaleModeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherSaleModeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FundCustodyMode == input.FundCustodyMode ||
                    (this.FundCustodyMode != null &&
                    this.FundCustodyMode.Equals(input.FundCustodyMode))
                ) && 
                (
                    this.OverdueRefundable == input.OverdueRefundable ||
                    this.OverdueRefundable.Equals(input.OverdueRefundable)
                ) && 
                (
                    this.OverdueRefundableNeedConfirm == input.OverdueRefundableNeedConfirm ||
                    this.OverdueRefundableNeedConfirm.Equals(input.OverdueRefundableNeedConfirm)
                ) && 
                (
                    this.PayeePid == input.PayeePid ||
                    (this.PayeePid != null &&
                    this.PayeePid.Equals(input.PayeePid))
                ) && 
                (
                    this.Refundable == input.Refundable ||
                    this.Refundable.Equals(input.Refundable)
                ) && 
                (
                    this.RefundableNeedConfirm == input.RefundableNeedConfirm ||
                    this.RefundableNeedConfirm.Equals(input.RefundableNeedConfirm)
                ) && 
                (
                    this.SaleAmount == input.SaleAmount ||
                    (this.SaleAmount != null &&
                    this.SaleAmount.Equals(input.SaleAmount))
                ) && 
                (
                    this.SettleInfo == input.SettleInfo ||
                    (this.SettleInfo != null &&
                    this.SettleInfo.Equals(input.SettleInfo))
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
                if (this.FundCustodyMode != null)
                {
                    hashCode = (hashCode * 59) + this.FundCustodyMode.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OverdueRefundable.GetHashCode();
                hashCode = (hashCode * 59) + this.OverdueRefundableNeedConfirm.GetHashCode();
                if (this.PayeePid != null)
                {
                    hashCode = (hashCode * 59) + this.PayeePid.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Refundable.GetHashCode();
                hashCode = (hashCode * 59) + this.RefundableNeedConfirm.GetHashCode();
                if (this.SaleAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SaleAmount.GetHashCode();
                }
                if (this.SettleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.SettleInfo.GetHashCode();
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
