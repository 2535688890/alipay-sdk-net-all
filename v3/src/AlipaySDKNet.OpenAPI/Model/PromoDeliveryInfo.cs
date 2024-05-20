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
    /// PromoDeliveryInfo
    /// </summary>
    [DataContract(Name = "PromoDeliveryInfo")]
    public partial class PromoDeliveryInfo : IEquatable<PromoDeliveryInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PromoDeliveryInfo" /> class.
        /// </summary>
        /// <param name="activityId">活动id.</param>
        /// <param name="boothCode">展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAYMENT_RESULT.</param>
        /// <param name="channel">可投放的渠道标识..</param>
        /// <param name="channelName">渠道名称.</param>
        /// <param name="deliveryStatus">投放状态。.</param>
        public PromoDeliveryInfo(string activityId = default(string), string boothCode = default(string), string channel = default(string), string channelName = default(string), string deliveryStatus = default(string))
        {
            this.ActivityId = activityId;
            this.BoothCode = boothCode;
            this.Channel = channel;
            this.ChannelName = channelName;
            this.DeliveryStatus = deliveryStatus;
        }

        /// <summary>
        /// 活动id
        /// </summary>
        /// <value>活动id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAYMENT_RESULT
        /// </summary>
        /// <value>展位码:boothCode表达的是具体渠道所属的展位码。例如：支付结果页PAYMENT_RESULT</value>
        [DataMember(Name = "booth_code", EmitDefaultValue = false)]
        public string BoothCode { get; set; }

        /// <summary>
        /// 可投放的渠道标识.
        /// </summary>
        /// <value>可投放的渠道标识.</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; set; }

        /// <summary>
        /// 渠道名称
        /// </summary>
        /// <value>渠道名称</value>
        [DataMember(Name = "channel_name", EmitDefaultValue = false)]
        public string ChannelName { get; set; }

        /// <summary>
        /// 投放状态。
        /// </summary>
        /// <value>投放状态。</value>
        [DataMember(Name = "delivery_status", EmitDefaultValue = false)]
        public string DeliveryStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PromoDeliveryInfo {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  BoothCode: ").Append(BoothCode).Append("\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  ChannelName: ").Append(ChannelName).Append("\n");
            sb.Append("  DeliveryStatus: ").Append(DeliveryStatus).Append("\n");
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
            return this.Equals(input as PromoDeliveryInfo);
        }

        /// <summary>
        /// Returns true if PromoDeliveryInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PromoDeliveryInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PromoDeliveryInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.BoothCode == input.BoothCode ||
                    (this.BoothCode != null &&
                    this.BoothCode.Equals(input.BoothCode))
                ) && 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.ChannelName == input.ChannelName ||
                    (this.ChannelName != null &&
                    this.ChannelName.Equals(input.ChannelName))
                ) && 
                (
                    this.DeliveryStatus == input.DeliveryStatus ||
                    (this.DeliveryStatus != null &&
                    this.DeliveryStatus.Equals(input.DeliveryStatus))
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
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
                }
                if (this.BoothCode != null)
                {
                    hashCode = (hashCode * 59) + this.BoothCode.GetHashCode();
                }
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.ChannelName != null)
                {
                    hashCode = (hashCode * 59) + this.ChannelName.GetHashCode();
                }
                if (this.DeliveryStatus != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryStatus.GetHashCode();
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
