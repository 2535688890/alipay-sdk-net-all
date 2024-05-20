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
    /// ViolationEvent
    /// </summary>
    [DataContract(Name = "ViolationEvent")]
    public partial class ViolationEvent : IEquatable<ViolationEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViolationEvent" /> class.
        /// </summary>
        /// <param name="canAppeal">商家是否可以申诉.</param>
        /// <param name="canRectify">商家是否可以整改.</param>
        /// <param name="punishAction">处罚动作及有效期.</param>
        /// <param name="status">违规工单状态枚举.</param>
        /// <param name="targetId">违规对象ID.</param>
        /// <param name="targetName">违规对象名称.</param>
        /// <param name="targetType">违规对象类型 小程序ID:APPID  生活号ID:PUBLICID.</param>
        /// <param name="violationRecordId">支付宝侧生成的违规记录唯一标识.</param>
        /// <param name="violationTime">违规时间，格式为 yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="violationType">即平台依据平台规范/规则，判定商户的违规类型.</param>
        public ViolationEvent(bool canAppeal = default(bool), bool canRectify = default(bool), string punishAction = default(string), string status = default(string), string targetId = default(string), string targetName = default(string), string targetType = default(string), string violationRecordId = default(string), string violationTime = default(string), string violationType = default(string))
        {
            this.CanAppeal = canAppeal;
            this.CanRectify = canRectify;
            this.PunishAction = punishAction;
            this.Status = status;
            this.TargetId = targetId;
            this.TargetName = targetName;
            this.TargetType = targetType;
            this.ViolationRecordId = violationRecordId;
            this.ViolationTime = violationTime;
            this.ViolationType = violationType;
        }

        /// <summary>
        /// 商家是否可以申诉
        /// </summary>
        /// <value>商家是否可以申诉</value>
        [DataMember(Name = "can_appeal", EmitDefaultValue = true)]
        public bool CanAppeal { get; set; }

        /// <summary>
        /// 商家是否可以整改
        /// </summary>
        /// <value>商家是否可以整改</value>
        [DataMember(Name = "can_rectify", EmitDefaultValue = true)]
        public bool CanRectify { get; set; }

        /// <summary>
        /// 处罚动作及有效期
        /// </summary>
        /// <value>处罚动作及有效期</value>
        [DataMember(Name = "punish_action", EmitDefaultValue = false)]
        public string PunishAction { get; set; }

        /// <summary>
        /// 违规工单状态枚举
        /// </summary>
        /// <value>违规工单状态枚举</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 违规对象ID
        /// </summary>
        /// <value>违规对象ID</value>
        [DataMember(Name = "target_id", EmitDefaultValue = false)]
        public string TargetId { get; set; }

        /// <summary>
        /// 违规对象名称
        /// </summary>
        /// <value>违规对象名称</value>
        [DataMember(Name = "target_name", EmitDefaultValue = false)]
        public string TargetName { get; set; }

        /// <summary>
        /// 违规对象类型 小程序ID:APPID  生活号ID:PUBLICID
        /// </summary>
        /// <value>违规对象类型 小程序ID:APPID  生活号ID:PUBLICID</value>
        [DataMember(Name = "target_type", EmitDefaultValue = false)]
        public string TargetType { get; set; }

        /// <summary>
        /// 支付宝侧生成的违规记录唯一标识
        /// </summary>
        /// <value>支付宝侧生成的违规记录唯一标识</value>
        [DataMember(Name = "violation_record_id", EmitDefaultValue = false)]
        public string ViolationRecordId { get; set; }

        /// <summary>
        /// 违规时间，格式为 yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>违规时间，格式为 yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "violation_time", EmitDefaultValue = false)]
        public string ViolationTime { get; set; }

        /// <summary>
        /// 即平台依据平台规范/规则，判定商户的违规类型
        /// </summary>
        /// <value>即平台依据平台规范/规则，判定商户的违规类型</value>
        [DataMember(Name = "violation_type", EmitDefaultValue = false)]
        public string ViolationType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ViolationEvent {\n");
            sb.Append("  CanAppeal: ").Append(CanAppeal).Append("\n");
            sb.Append("  CanRectify: ").Append(CanRectify).Append("\n");
            sb.Append("  PunishAction: ").Append(PunishAction).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TargetId: ").Append(TargetId).Append("\n");
            sb.Append("  TargetName: ").Append(TargetName).Append("\n");
            sb.Append("  TargetType: ").Append(TargetType).Append("\n");
            sb.Append("  ViolationRecordId: ").Append(ViolationRecordId).Append("\n");
            sb.Append("  ViolationTime: ").Append(ViolationTime).Append("\n");
            sb.Append("  ViolationType: ").Append(ViolationType).Append("\n");
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
            return this.Equals(input as ViolationEvent);
        }

        /// <summary>
        /// Returns true if ViolationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of ViolationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ViolationEvent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CanAppeal == input.CanAppeal ||
                    this.CanAppeal.Equals(input.CanAppeal)
                ) && 
                (
                    this.CanRectify == input.CanRectify ||
                    this.CanRectify.Equals(input.CanRectify)
                ) && 
                (
                    this.PunishAction == input.PunishAction ||
                    (this.PunishAction != null &&
                    this.PunishAction.Equals(input.PunishAction))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TargetId == input.TargetId ||
                    (this.TargetId != null &&
                    this.TargetId.Equals(input.TargetId))
                ) && 
                (
                    this.TargetName == input.TargetName ||
                    (this.TargetName != null &&
                    this.TargetName.Equals(input.TargetName))
                ) && 
                (
                    this.TargetType == input.TargetType ||
                    (this.TargetType != null &&
                    this.TargetType.Equals(input.TargetType))
                ) && 
                (
                    this.ViolationRecordId == input.ViolationRecordId ||
                    (this.ViolationRecordId != null &&
                    this.ViolationRecordId.Equals(input.ViolationRecordId))
                ) && 
                (
                    this.ViolationTime == input.ViolationTime ||
                    (this.ViolationTime != null &&
                    this.ViolationTime.Equals(input.ViolationTime))
                ) && 
                (
                    this.ViolationType == input.ViolationType ||
                    (this.ViolationType != null &&
                    this.ViolationType.Equals(input.ViolationType))
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
                hashCode = (hashCode * 59) + this.CanAppeal.GetHashCode();
                hashCode = (hashCode * 59) + this.CanRectify.GetHashCode();
                if (this.PunishAction != null)
                {
                    hashCode = (hashCode * 59) + this.PunishAction.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TargetId != null)
                {
                    hashCode = (hashCode * 59) + this.TargetId.GetHashCode();
                }
                if (this.TargetName != null)
                {
                    hashCode = (hashCode * 59) + this.TargetName.GetHashCode();
                }
                if (this.TargetType != null)
                {
                    hashCode = (hashCode * 59) + this.TargetType.GetHashCode();
                }
                if (this.ViolationRecordId != null)
                {
                    hashCode = (hashCode * 59) + this.ViolationRecordId.GetHashCode();
                }
                if (this.ViolationTime != null)
                {
                    hashCode = (hashCode * 59) + this.ViolationTime.GetHashCode();
                }
                if (this.ViolationType != null)
                {
                    hashCode = (hashCode * 59) + this.ViolationType.GetHashCode();
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
