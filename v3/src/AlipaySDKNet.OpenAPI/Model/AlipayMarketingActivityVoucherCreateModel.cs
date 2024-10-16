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
    /// AlipayMarketingActivityVoucherCreateModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityVoucherCreateModel")]
    public partial class AlipayMarketingActivityVoucherCreateModel : IEquatable<AlipayMarketingActivityVoucherCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityVoucherCreateModel" /> class.
        /// </summary>
        /// <param name="activityBaseInfo">activityBaseInfo.</param>
        /// <param name="activityName">活动名称。.</param>
        /// <param name="belongMerchantInfo">belongMerchantInfo.</param>
        /// <param name="merchantAccessMode">商户接入模式.</param>
        /// <param name="outBizNo">用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。.</param>
        /// <param name="publishEndTime">券发放结束时间。 格式为：yyyy-MM-dd HH:mm:ss 限制： 券发放结束时间 publish_end_time 与 券发放开始时间  publish_start_time 间隔必须小于等于180天.</param>
        /// <param name="publishStartTime">券发放开始时间。 格式为：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="voucherAvailableScopeInfo">voucherAvailableScopeInfo.</param>
        /// <param name="voucherBudgetInfo">voucherBudgetInfo.</param>
        /// <param name="voucherBudgetSupplyInfo">voucherBudgetSupplyInfo.</param>
        /// <param name="voucherCustomerGuideInfo">voucherCustomerGuideInfo.</param>
        /// <param name="voucherDeductInfo">voucherDeductInfo.</param>
        /// <param name="voucherDisplayInfo">voucherDisplayInfo.</param>
        /// <param name="voucherDisplayPatternInfo">voucherDisplayPatternInfo.</param>
        /// <param name="voucherSendModeInfo">voucherSendModeInfo.</param>
        /// <param name="voucherSendRule">voucherSendRule.</param>
        /// <param name="voucherType">券类型.</param>
        /// <param name="voucherUseRule">voucherUseRule.</param>
        /// <param name="voucherUseRuleInfo">voucherUseRuleInfo.</param>
        public AlipayMarketingActivityVoucherCreateModel(ActivityBaseInfo activityBaseInfo = default(ActivityBaseInfo), string activityName = default(string), PaymentVoucherBelongMerchantInfo belongMerchantInfo = default(PaymentVoucherBelongMerchantInfo), string merchantAccessMode = default(string), string outBizNo = default(string), string publishEndTime = default(string), string publishStartTime = default(string), VoucherAvailableScopeInfo voucherAvailableScopeInfo = default(VoucherAvailableScopeInfo), PaymentVoucherBudgetInfo voucherBudgetInfo = default(PaymentVoucherBudgetInfo), VoucherBudgetSupplyInfo voucherBudgetSupplyInfo = default(VoucherBudgetSupplyInfo), VoucherCustomerGuideInfo voucherCustomerGuideInfo = default(VoucherCustomerGuideInfo), VoucherDeductInfo voucherDeductInfo = default(VoucherDeductInfo), PaymentVoucherDisplayInfo voucherDisplayInfo = default(PaymentVoucherDisplayInfo), VoucherDisplayPatternInfo voucherDisplayPatternInfo = default(VoucherDisplayPatternInfo), VoucherSendModeInfo voucherSendModeInfo = default(VoucherSendModeInfo), PaymentVoucherSendRule voucherSendRule = default(PaymentVoucherSendRule), string voucherType = default(string), PaymentVoucherUseRule voucherUseRule = default(PaymentVoucherUseRule), VoucherUseRuleInfo voucherUseRuleInfo = default(VoucherUseRuleInfo))
        {
            this.ActivityBaseInfo = activityBaseInfo;
            this.ActivityName = activityName;
            this.BelongMerchantInfo = belongMerchantInfo;
            this.MerchantAccessMode = merchantAccessMode;
            this.OutBizNo = outBizNo;
            this.PublishEndTime = publishEndTime;
            this.PublishStartTime = publishStartTime;
            this.VoucherAvailableScopeInfo = voucherAvailableScopeInfo;
            this.VoucherBudgetInfo = voucherBudgetInfo;
            this.VoucherBudgetSupplyInfo = voucherBudgetSupplyInfo;
            this.VoucherCustomerGuideInfo = voucherCustomerGuideInfo;
            this.VoucherDeductInfo = voucherDeductInfo;
            this.VoucherDisplayInfo = voucherDisplayInfo;
            this.VoucherDisplayPatternInfo = voucherDisplayPatternInfo;
            this.VoucherSendModeInfo = voucherSendModeInfo;
            this.VoucherSendRule = voucherSendRule;
            this.VoucherType = voucherType;
            this.VoucherUseRule = voucherUseRule;
            this.VoucherUseRuleInfo = voucherUseRuleInfo;
        }

        /// <summary>
        /// Gets or Sets ActivityBaseInfo
        /// </summary>
        [DataMember(Name = "activity_base_info", EmitDefaultValue = false)]
        public ActivityBaseInfo ActivityBaseInfo { get; set; }

        /// <summary>
        /// 活动名称。
        /// </summary>
        /// <value>活动名称。</value>
        [DataMember(Name = "activity_name", EmitDefaultValue = false)]
        public string ActivityName { get; set; }

        /// <summary>
        /// Gets or Sets BelongMerchantInfo
        /// </summary>
        [DataMember(Name = "belong_merchant_info", EmitDefaultValue = false)]
        public PaymentVoucherBelongMerchantInfo BelongMerchantInfo { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        /// <value>商户接入模式</value>
        [DataMember(Name = "merchant_access_mode", EmitDefaultValue = false)]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。
        /// </summary>
        /// <value>用作幂等控制。  幂等作用： 参数不变的情况下，再次请求返回与上一次相同的结果。  外部接入方需保证业务单号唯一。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 券发放结束时间。 格式为：yyyy-MM-dd HH:mm:ss 限制： 券发放结束时间 publish_end_time 与 券发放开始时间  publish_start_time 间隔必须小于等于180天
        /// </summary>
        /// <value>券发放结束时间。 格式为：yyyy-MM-dd HH:mm:ss 限制： 券发放结束时间 publish_end_time 与 券发放开始时间  publish_start_time 间隔必须小于等于180天</value>
        [DataMember(Name = "publish_end_time", EmitDefaultValue = false)]
        public string PublishEndTime { get; set; }

        /// <summary>
        /// 券发放开始时间。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>券发放开始时间。 格式为：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "publish_start_time", EmitDefaultValue = false)]
        public string PublishStartTime { get; set; }

        /// <summary>
        /// Gets or Sets VoucherAvailableScopeInfo
        /// </summary>
        [DataMember(Name = "voucher_available_scope_info", EmitDefaultValue = false)]
        public VoucherAvailableScopeInfo VoucherAvailableScopeInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherBudgetInfo
        /// </summary>
        [DataMember(Name = "voucher_budget_info", EmitDefaultValue = false)]
        public PaymentVoucherBudgetInfo VoucherBudgetInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherBudgetSupplyInfo
        /// </summary>
        [DataMember(Name = "voucher_budget_supply_info", EmitDefaultValue = false)]
        public VoucherBudgetSupplyInfo VoucherBudgetSupplyInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherCustomerGuideInfo
        /// </summary>
        [DataMember(Name = "voucher_customer_guide_info", EmitDefaultValue = false)]
        public VoucherCustomerGuideInfo VoucherCustomerGuideInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDeductInfo
        /// </summary>
        [DataMember(Name = "voucher_deduct_info", EmitDefaultValue = false)]
        public VoucherDeductInfo VoucherDeductInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDisplayInfo
        /// </summary>
        [DataMember(Name = "voucher_display_info", EmitDefaultValue = false)]
        public PaymentVoucherDisplayInfo VoucherDisplayInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherDisplayPatternInfo
        /// </summary>
        [DataMember(Name = "voucher_display_pattern_info", EmitDefaultValue = false)]
        public VoucherDisplayPatternInfo VoucherDisplayPatternInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherSendModeInfo
        /// </summary>
        [DataMember(Name = "voucher_send_mode_info", EmitDefaultValue = false)]
        public VoucherSendModeInfo VoucherSendModeInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherSendRule
        /// </summary>
        [DataMember(Name = "voucher_send_rule", EmitDefaultValue = false)]
        public PaymentVoucherSendRule VoucherSendRule { get; set; }

        /// <summary>
        /// 券类型
        /// </summary>
        /// <value>券类型</value>
        [DataMember(Name = "voucher_type", EmitDefaultValue = false)]
        public string VoucherType { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseRule
        /// </summary>
        [DataMember(Name = "voucher_use_rule", EmitDefaultValue = false)]
        public PaymentVoucherUseRule VoucherUseRule { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseRuleInfo
        /// </summary>
        [DataMember(Name = "voucher_use_rule_info", EmitDefaultValue = false)]
        public VoucherUseRuleInfo VoucherUseRuleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityVoucherCreateModel {\n");
            sb.Append("  ActivityBaseInfo: ").Append(ActivityBaseInfo).Append("\n");
            sb.Append("  ActivityName: ").Append(ActivityName).Append("\n");
            sb.Append("  BelongMerchantInfo: ").Append(BelongMerchantInfo).Append("\n");
            sb.Append("  MerchantAccessMode: ").Append(MerchantAccessMode).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PublishEndTime: ").Append(PublishEndTime).Append("\n");
            sb.Append("  PublishStartTime: ").Append(PublishStartTime).Append("\n");
            sb.Append("  VoucherAvailableScopeInfo: ").Append(VoucherAvailableScopeInfo).Append("\n");
            sb.Append("  VoucherBudgetInfo: ").Append(VoucherBudgetInfo).Append("\n");
            sb.Append("  VoucherBudgetSupplyInfo: ").Append(VoucherBudgetSupplyInfo).Append("\n");
            sb.Append("  VoucherCustomerGuideInfo: ").Append(VoucherCustomerGuideInfo).Append("\n");
            sb.Append("  VoucherDeductInfo: ").Append(VoucherDeductInfo).Append("\n");
            sb.Append("  VoucherDisplayInfo: ").Append(VoucherDisplayInfo).Append("\n");
            sb.Append("  VoucherDisplayPatternInfo: ").Append(VoucherDisplayPatternInfo).Append("\n");
            sb.Append("  VoucherSendModeInfo: ").Append(VoucherSendModeInfo).Append("\n");
            sb.Append("  VoucherSendRule: ").Append(VoucherSendRule).Append("\n");
            sb.Append("  VoucherType: ").Append(VoucherType).Append("\n");
            sb.Append("  VoucherUseRule: ").Append(VoucherUseRule).Append("\n");
            sb.Append("  VoucherUseRuleInfo: ").Append(VoucherUseRuleInfo).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityVoucherCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityVoucherCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityVoucherCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityVoucherCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityBaseInfo == input.ActivityBaseInfo ||
                    (this.ActivityBaseInfo != null &&
                    this.ActivityBaseInfo.Equals(input.ActivityBaseInfo))
                ) && 
                (
                    this.ActivityName == input.ActivityName ||
                    (this.ActivityName != null &&
                    this.ActivityName.Equals(input.ActivityName))
                ) && 
                (
                    this.BelongMerchantInfo == input.BelongMerchantInfo ||
                    (this.BelongMerchantInfo != null &&
                    this.BelongMerchantInfo.Equals(input.BelongMerchantInfo))
                ) && 
                (
                    this.MerchantAccessMode == input.MerchantAccessMode ||
                    (this.MerchantAccessMode != null &&
                    this.MerchantAccessMode.Equals(input.MerchantAccessMode))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PublishEndTime == input.PublishEndTime ||
                    (this.PublishEndTime != null &&
                    this.PublishEndTime.Equals(input.PublishEndTime))
                ) && 
                (
                    this.PublishStartTime == input.PublishStartTime ||
                    (this.PublishStartTime != null &&
                    this.PublishStartTime.Equals(input.PublishStartTime))
                ) && 
                (
                    this.VoucherAvailableScopeInfo == input.VoucherAvailableScopeInfo ||
                    (this.VoucherAvailableScopeInfo != null &&
                    this.VoucherAvailableScopeInfo.Equals(input.VoucherAvailableScopeInfo))
                ) && 
                (
                    this.VoucherBudgetInfo == input.VoucherBudgetInfo ||
                    (this.VoucherBudgetInfo != null &&
                    this.VoucherBudgetInfo.Equals(input.VoucherBudgetInfo))
                ) && 
                (
                    this.VoucherBudgetSupplyInfo == input.VoucherBudgetSupplyInfo ||
                    (this.VoucherBudgetSupplyInfo != null &&
                    this.VoucherBudgetSupplyInfo.Equals(input.VoucherBudgetSupplyInfo))
                ) && 
                (
                    this.VoucherCustomerGuideInfo == input.VoucherCustomerGuideInfo ||
                    (this.VoucherCustomerGuideInfo != null &&
                    this.VoucherCustomerGuideInfo.Equals(input.VoucherCustomerGuideInfo))
                ) && 
                (
                    this.VoucherDeductInfo == input.VoucherDeductInfo ||
                    (this.VoucherDeductInfo != null &&
                    this.VoucherDeductInfo.Equals(input.VoucherDeductInfo))
                ) && 
                (
                    this.VoucherDisplayInfo == input.VoucherDisplayInfo ||
                    (this.VoucherDisplayInfo != null &&
                    this.VoucherDisplayInfo.Equals(input.VoucherDisplayInfo))
                ) && 
                (
                    this.VoucherDisplayPatternInfo == input.VoucherDisplayPatternInfo ||
                    (this.VoucherDisplayPatternInfo != null &&
                    this.VoucherDisplayPatternInfo.Equals(input.VoucherDisplayPatternInfo))
                ) && 
                (
                    this.VoucherSendModeInfo == input.VoucherSendModeInfo ||
                    (this.VoucherSendModeInfo != null &&
                    this.VoucherSendModeInfo.Equals(input.VoucherSendModeInfo))
                ) && 
                (
                    this.VoucherSendRule == input.VoucherSendRule ||
                    (this.VoucherSendRule != null &&
                    this.VoucherSendRule.Equals(input.VoucherSendRule))
                ) && 
                (
                    this.VoucherType == input.VoucherType ||
                    (this.VoucherType != null &&
                    this.VoucherType.Equals(input.VoucherType))
                ) && 
                (
                    this.VoucherUseRule == input.VoucherUseRule ||
                    (this.VoucherUseRule != null &&
                    this.VoucherUseRule.Equals(input.VoucherUseRule))
                ) && 
                (
                    this.VoucherUseRuleInfo == input.VoucherUseRuleInfo ||
                    (this.VoucherUseRuleInfo != null &&
                    this.VoucherUseRuleInfo.Equals(input.VoucherUseRuleInfo))
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
                if (this.ActivityBaseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityBaseInfo.GetHashCode();
                }
                if (this.ActivityName != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityName.GetHashCode();
                }
                if (this.BelongMerchantInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BelongMerchantInfo.GetHashCode();
                }
                if (this.MerchantAccessMode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccessMode.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PublishEndTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishEndTime.GetHashCode();
                }
                if (this.PublishStartTime != null)
                {
                    hashCode = (hashCode * 59) + this.PublishStartTime.GetHashCode();
                }
                if (this.VoucherAvailableScopeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherAvailableScopeInfo.GetHashCode();
                }
                if (this.VoucherBudgetInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherBudgetInfo.GetHashCode();
                }
                if (this.VoucherBudgetSupplyInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherBudgetSupplyInfo.GetHashCode();
                }
                if (this.VoucherCustomerGuideInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherCustomerGuideInfo.GetHashCode();
                }
                if (this.VoucherDeductInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDeductInfo.GetHashCode();
                }
                if (this.VoucherDisplayInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDisplayInfo.GetHashCode();
                }
                if (this.VoucherDisplayPatternInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDisplayPatternInfo.GetHashCode();
                }
                if (this.VoucherSendModeInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendModeInfo.GetHashCode();
                }
                if (this.VoucherSendRule != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherSendRule.GetHashCode();
                }
                if (this.VoucherType != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherType.GetHashCode();
                }
                if (this.VoucherUseRule != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseRule.GetHashCode();
                }
                if (this.VoucherUseRuleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseRuleInfo.GetHashCode();
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
