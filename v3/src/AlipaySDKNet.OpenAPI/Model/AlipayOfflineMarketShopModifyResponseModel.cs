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
    /// AlipayOfflineMarketShopModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOfflineMarketShopModifyResponseModel")]
    public partial class AlipayOfflineMarketShopModifyResponseModel : IEquatable<AlipayOfflineMarketShopModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMarketShopModifyResponseModel" /> class.
        /// </summary>
        /// <param name="applyId">修改门店请求受理成功后返回的支付宝流水ID，根据此ID调用接口  alipay.offline.market.applyorder.batchquery，能够获取当前修改店铺请求审核状态、驳回原因等信息。.</param>
        /// <param name="auditDesc">废弃字段。.</param>
        /// <param name="auditStatus">同步请求如果支付宝受理成功，将返回AUDITING状态。.</param>
        /// <param name="isOnline">废弃字段，T表示上架,F表示未上架。.</param>
        /// <param name="isShow">废弃字段，T表示显示，F表示隐藏。.</param>
        public AlipayOfflineMarketShopModifyResponseModel(string applyId = default(string), string auditDesc = default(string), string auditStatus = default(string), string isOnline = default(string), string isShow = default(string))
        {
            this.ApplyId = applyId;
            this.AuditDesc = auditDesc;
            this.AuditStatus = auditStatus;
            this.IsOnline = isOnline;
            this.IsShow = isShow;
        }

        /// <summary>
        /// 修改门店请求受理成功后返回的支付宝流水ID，根据此ID调用接口  alipay.offline.market.applyorder.batchquery，能够获取当前修改店铺请求审核状态、驳回原因等信息。
        /// </summary>
        /// <value>修改门店请求受理成功后返回的支付宝流水ID，根据此ID调用接口  alipay.offline.market.applyorder.batchquery，能够获取当前修改店铺请求审核状态、驳回原因等信息。</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 废弃字段。
        /// </summary>
        /// <value>废弃字段。</value>
        [DataMember(Name = "audit_desc", EmitDefaultValue = false)]
        public string AuditDesc { get; set; }

        /// <summary>
        /// 同步请求如果支付宝受理成功，将返回AUDITING状态。
        /// </summary>
        /// <value>同步请求如果支付宝受理成功，将返回AUDITING状态。</value>
        [DataMember(Name = "audit_status", EmitDefaultValue = false)]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 废弃字段，T表示上架,F表示未上架。
        /// </summary>
        /// <value>废弃字段，T表示上架,F表示未上架。</value>
        [DataMember(Name = "is_online", EmitDefaultValue = false)]
        public string IsOnline { get; set; }

        /// <summary>
        /// 废弃字段，T表示显示，F表示隐藏。
        /// </summary>
        /// <value>废弃字段，T表示显示，F表示隐藏。</value>
        [DataMember(Name = "is_show", EmitDefaultValue = false)]
        public string IsShow { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOfflineMarketShopModifyResponseModel {\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  AuditDesc: ").Append(AuditDesc).Append("\n");
            sb.Append("  AuditStatus: ").Append(AuditStatus).Append("\n");
            sb.Append("  IsOnline: ").Append(IsOnline).Append("\n");
            sb.Append("  IsShow: ").Append(IsShow).Append("\n");
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
            return this.Equals(input as AlipayOfflineMarketShopModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOfflineMarketShopModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOfflineMarketShopModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOfflineMarketShopModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyId == input.ApplyId ||
                    (this.ApplyId != null &&
                    this.ApplyId.Equals(input.ApplyId))
                ) && 
                (
                    this.AuditDesc == input.AuditDesc ||
                    (this.AuditDesc != null &&
                    this.AuditDesc.Equals(input.AuditDesc))
                ) && 
                (
                    this.AuditStatus == input.AuditStatus ||
                    (this.AuditStatus != null &&
                    this.AuditStatus.Equals(input.AuditStatus))
                ) && 
                (
                    this.IsOnline == input.IsOnline ||
                    (this.IsOnline != null &&
                    this.IsOnline.Equals(input.IsOnline))
                ) && 
                (
                    this.IsShow == input.IsShow ||
                    (this.IsShow != null &&
                    this.IsShow.Equals(input.IsShow))
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
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.AuditDesc != null)
                {
                    hashCode = (hashCode * 59) + this.AuditDesc.GetHashCode();
                }
                if (this.AuditStatus != null)
                {
                    hashCode = (hashCode * 59) + this.AuditStatus.GetHashCode();
                }
                if (this.IsOnline != null)
                {
                    hashCode = (hashCode * 59) + this.IsOnline.GetHashCode();
                }
                if (this.IsShow != null)
                {
                    hashCode = (hashCode * 59) + this.IsShow.GetHashCode();
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
