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
    /// AlipayMarketingActivityDeliveryQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityDeliveryQueryResponseModel")]
    public partial class AlipayMarketingActivityDeliveryQueryResponseModel : IEquatable<AlipayMarketingActivityDeliveryQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityDeliveryQueryResponseModel" /> class.
        /// </summary>
        /// <param name="deliveryBaseInfo">deliveryBaseInfo.</param>
        /// <param name="deliveryBoothCode">运营计划的展位编码。 枚举值： SERVICE_MESSAGE：商家消息（包含订单、订阅、其他消息）.</param>
        /// <param name="deliveryErrorMsg">投放计划错误信息描述，如投放计划审核失败时为审核失败原因。.</param>
        /// <param name="deliveryId">投放计划id.</param>
        /// <param name="deliveryInfoList">\&quot;[已废弃] 投放信息列表\&quot;.</param>
        /// <param name="deliveryPlayConfig">deliveryPlayConfig.</param>
        /// <param name="deliveryStatus">投放计划状态。.</param>
        /// <param name="deliveryTargetRule">deliveryTargetRule.</param>
        public AlipayMarketingActivityDeliveryQueryResponseModel(DeliveryBaseInfo deliveryBaseInfo = default(DeliveryBaseInfo), string deliveryBoothCode = default(string), string deliveryErrorMsg = default(string), string deliveryId = default(string), List<PromoDeliveryInfo> deliveryInfoList = default(List<PromoDeliveryInfo>), DeliveryPlayConfig deliveryPlayConfig = default(DeliveryPlayConfig), string deliveryStatus = default(string), DeliveryTargetRule deliveryTargetRule = default(DeliveryTargetRule))
        {
            this.DeliveryBaseInfo = deliveryBaseInfo;
            this.DeliveryBoothCode = deliveryBoothCode;
            this.DeliveryErrorMsg = deliveryErrorMsg;
            this.DeliveryId = deliveryId;
            this.DeliveryInfoList = deliveryInfoList;
            this.DeliveryPlayConfig = deliveryPlayConfig;
            this.DeliveryStatus = deliveryStatus;
            this.DeliveryTargetRule = deliveryTargetRule;
        }

        /// <summary>
        /// Gets or Sets DeliveryBaseInfo
        /// </summary>
        [DataMember(Name = "delivery_base_info", EmitDefaultValue = false)]
        public DeliveryBaseInfo DeliveryBaseInfo { get; set; }

        /// <summary>
        /// 运营计划的展位编码。 枚举值： SERVICE_MESSAGE：商家消息（包含订单、订阅、其他消息）
        /// </summary>
        /// <value>运营计划的展位编码。 枚举值： SERVICE_MESSAGE：商家消息（包含订单、订阅、其他消息）</value>
        [DataMember(Name = "delivery_booth_code", EmitDefaultValue = false)]
        public string DeliveryBoothCode { get; set; }

        /// <summary>
        /// 投放计划错误信息描述，如投放计划审核失败时为审核失败原因。
        /// </summary>
        /// <value>投放计划错误信息描述，如投放计划审核失败时为审核失败原因。</value>
        [DataMember(Name = "delivery_error_msg", EmitDefaultValue = false)]
        public string DeliveryErrorMsg { get; set; }

        /// <summary>
        /// 投放计划id
        /// </summary>
        /// <value>投放计划id</value>
        [DataMember(Name = "delivery_id", EmitDefaultValue = false)]
        public string DeliveryId { get; set; }

        /// <summary>
        /// \&quot;[已废弃] 投放信息列表\&quot;
        /// </summary>
        /// <value>\&quot;[已废弃] 投放信息列表\&quot;</value>
        [DataMember(Name = "delivery_info_list", EmitDefaultValue = false)]
        public List<PromoDeliveryInfo> DeliveryInfoList { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryPlayConfig
        /// </summary>
        [DataMember(Name = "delivery_play_config", EmitDefaultValue = false)]
        public DeliveryPlayConfig DeliveryPlayConfig { get; set; }

        /// <summary>
        /// 投放计划状态。
        /// </summary>
        /// <value>投放计划状态。</value>
        [DataMember(Name = "delivery_status", EmitDefaultValue = false)]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// Gets or Sets DeliveryTargetRule
        /// </summary>
        [DataMember(Name = "delivery_target_rule", EmitDefaultValue = false)]
        public DeliveryTargetRule DeliveryTargetRule { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityDeliveryQueryResponseModel {\n");
            sb.Append("  DeliveryBaseInfo: ").Append(DeliveryBaseInfo).Append("\n");
            sb.Append("  DeliveryBoothCode: ").Append(DeliveryBoothCode).Append("\n");
            sb.Append("  DeliveryErrorMsg: ").Append(DeliveryErrorMsg).Append("\n");
            sb.Append("  DeliveryId: ").Append(DeliveryId).Append("\n");
            sb.Append("  DeliveryInfoList: ").Append(DeliveryInfoList).Append("\n");
            sb.Append("  DeliveryPlayConfig: ").Append(DeliveryPlayConfig).Append("\n");
            sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
            sb.Append("  DeliveryTargetRule: ").Append(DeliveryTargetRule).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityDeliveryQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityDeliveryQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityDeliveryQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityDeliveryQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DeliveryBaseInfo == input.DeliveryBaseInfo ||
                    (this.DeliveryBaseInfo != null &&
                    this.DeliveryBaseInfo.Equals(input.DeliveryBaseInfo))
                ) && 
                (
                    this.DeliveryBoothCode == input.DeliveryBoothCode ||
                    (this.DeliveryBoothCode != null &&
                    this.DeliveryBoothCode.Equals(input.DeliveryBoothCode))
                ) && 
                (
                    this.DeliveryErrorMsg == input.DeliveryErrorMsg ||
                    (this.DeliveryErrorMsg != null &&
                    this.DeliveryErrorMsg.Equals(input.DeliveryErrorMsg))
                ) && 
                (
                    this.DeliveryId == input.DeliveryId ||
                    (this.DeliveryId != null &&
                    this.DeliveryId.Equals(input.DeliveryId))
                ) && 
                (
                    this.DeliveryInfoList == input.DeliveryInfoList ||
                    this.DeliveryInfoList != null &&
                    input.DeliveryInfoList != null &&
                    this.DeliveryInfoList.SequenceEqual(input.DeliveryInfoList)
                ) && 
                (
                    this.DeliveryPlayConfig == input.DeliveryPlayConfig ||
                    (this.DeliveryPlayConfig != null &&
                    this.DeliveryPlayConfig.Equals(input.DeliveryPlayConfig))
                ) && 
                (
                    this.DeliveryStatus == input.DeliveryStatus ||
                    (this.DeliveryStatus != null &&
                    this.DeliveryStatus.Equals(input.DeliveryStatus))
                ) && 
                (
                    this.DeliveryTargetRule == input.DeliveryTargetRule ||
                    (this.DeliveryTargetRule != null &&
                    this.DeliveryTargetRule.Equals(input.DeliveryTargetRule))
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
                if (this.DeliveryBaseInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryBaseInfo.GetHashCode();
                }
                if (this.DeliveryBoothCode != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryBoothCode.GetHashCode();
                }
                if (this.DeliveryErrorMsg != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryErrorMsg.GetHashCode();
                }
                if (this.DeliveryId != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryId.GetHashCode();
                }
                if (this.DeliveryInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryInfoList.GetHashCode();
                }
                if (this.DeliveryPlayConfig != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryPlayConfig.GetHashCode();
                }
                if (this.DeliveryStatus != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryStatus.GetHashCode();
                }
                if (this.DeliveryTargetRule != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryTargetRule.GetHashCode();
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
