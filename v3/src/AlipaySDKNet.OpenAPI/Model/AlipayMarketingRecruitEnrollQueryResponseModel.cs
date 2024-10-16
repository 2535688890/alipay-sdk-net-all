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
    /// AlipayMarketingRecruitEnrollQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingRecruitEnrollQueryResponseModel")]
    public partial class AlipayMarketingRecruitEnrollQueryResponseModel : IEquatable<AlipayMarketingRecruitEnrollQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingRecruitEnrollQueryResponseModel" /> class.
        /// </summary>
        /// <param name="enrollId">报名ID.</param>
        /// <param name="enrollInfo">enrollInfo.</param>
        /// <param name="enrollSceneType">报名所属的活动报名场景。 枚举值： VOUCHER：属于券报名场景； MINI_APP：属于小程序报名场景；.</param>
        /// <param name="enrollTime">报名时间.</param>
        /// <param name="memo">备注字段.</param>
        /// <param name="outBizNo">外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。.</param>
        /// <param name="planId">招商方案ID.</param>
        /// <param name="status">报名状态： AUDITING 审核中； ENABLED 通过 ； REJECTED 不通过 ； CLOSING 下线审核中 ； CLOSED 已下线；.</param>
        public AlipayMarketingRecruitEnrollQueryResponseModel(string enrollId = default(string), RecruitEnrollInfo enrollInfo = default(RecruitEnrollInfo), string enrollSceneType = default(string), string enrollTime = default(string), string memo = default(string), string outBizNo = default(string), string planId = default(string), string status = default(string))
        {
            this.EnrollId = enrollId;
            this.EnrollInfo = enrollInfo;
            this.EnrollSceneType = enrollSceneType;
            this.EnrollTime = enrollTime;
            this.Memo = memo;
            this.OutBizNo = outBizNo;
            this.PlanId = planId;
            this.Status = status;
        }

        /// <summary>
        /// 报名ID
        /// </summary>
        /// <value>报名ID</value>
        [DataMember(Name = "enroll_id", EmitDefaultValue = false)]
        public string EnrollId { get; set; }

        /// <summary>
        /// Gets or Sets EnrollInfo
        /// </summary>
        [DataMember(Name = "enroll_info", EmitDefaultValue = false)]
        public RecruitEnrollInfo EnrollInfo { get; set; }

        /// <summary>
        /// 报名所属的活动报名场景。 枚举值： VOUCHER：属于券报名场景； MINI_APP：属于小程序报名场景；
        /// </summary>
        /// <value>报名所属的活动报名场景。 枚举值： VOUCHER：属于券报名场景； MINI_APP：属于小程序报名场景；</value>
        [DataMember(Name = "enroll_scene_type", EmitDefaultValue = false)]
        public string EnrollSceneType { get; set; }

        /// <summary>
        /// 报名时间
        /// </summary>
        /// <value>报名时间</value>
        [DataMember(Name = "enroll_time", EmitDefaultValue = false)]
        public string EnrollTime { get; set; }

        /// <summary>
        /// 备注字段
        /// </summary>
        /// <value>备注字段</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。
        /// </summary>
        /// <value>外部操作流水号。由商家/ISV 自定义，仅支持字母、数字、下划线且需保证每次操作唯一。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 招商方案ID
        /// </summary>
        /// <value>招商方案ID</value>
        [DataMember(Name = "plan_id", EmitDefaultValue = false)]
        public string PlanId { get; set; }

        /// <summary>
        /// 报名状态： AUDITING 审核中； ENABLED 通过 ； REJECTED 不通过 ； CLOSING 下线审核中 ； CLOSED 已下线；
        /// </summary>
        /// <value>报名状态： AUDITING 审核中； ENABLED 通过 ； REJECTED 不通过 ； CLOSING 下线审核中 ； CLOSED 已下线；</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingRecruitEnrollQueryResponseModel {\n");
            sb.Append("  EnrollId: ").Append(EnrollId).Append("\n");
            sb.Append("  EnrollInfo: ").Append(EnrollInfo).Append("\n");
            sb.Append("  EnrollSceneType: ").Append(EnrollSceneType).Append("\n");
            sb.Append("  EnrollTime: ").Append(EnrollTime).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  PlanId: ").Append(PlanId).Append("\n");
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
            return this.Equals(input as AlipayMarketingRecruitEnrollQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingRecruitEnrollQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingRecruitEnrollQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingRecruitEnrollQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnrollId == input.EnrollId ||
                    (this.EnrollId != null &&
                    this.EnrollId.Equals(input.EnrollId))
                ) && 
                (
                    this.EnrollInfo == input.EnrollInfo ||
                    (this.EnrollInfo != null &&
                    this.EnrollInfo.Equals(input.EnrollInfo))
                ) && 
                (
                    this.EnrollSceneType == input.EnrollSceneType ||
                    (this.EnrollSceneType != null &&
                    this.EnrollSceneType.Equals(input.EnrollSceneType))
                ) && 
                (
                    this.EnrollTime == input.EnrollTime ||
                    (this.EnrollTime != null &&
                    this.EnrollTime.Equals(input.EnrollTime))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.PlanId == input.PlanId ||
                    (this.PlanId != null &&
                    this.PlanId.Equals(input.PlanId))
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
                if (this.EnrollId != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollId.GetHashCode();
                }
                if (this.EnrollInfo != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollInfo.GetHashCode();
                }
                if (this.EnrollSceneType != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollSceneType.GetHashCode();
                }
                if (this.EnrollTime != null)
                {
                    hashCode = (hashCode * 59) + this.EnrollTime.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.PlanId != null)
                {
                    hashCode = (hashCode * 59) + this.PlanId.GetHashCode();
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
