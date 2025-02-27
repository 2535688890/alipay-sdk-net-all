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
    /// McardNotifyMessage
    /// </summary>
    [DataContract(Name = "McardNotifyMessage")]
    public partial class McardNotifyMessage : IEquatable<McardNotifyMessage>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="McardNotifyMessage" /> class.
        /// </summary>
        /// <param name="changeReason">用户提醒信息，按如下格式拼装，需要ISV提供change_reason。  积分变动模板：{change_reason}，您的积分有变动  余额变动模板：{change_reason}，您的余额有变动  等级变更无需提供原因。.</param>
        /// <param name="extInfo">JSON格式扩展信息，主要是发送消息中的变量.</param>
        /// <param name="messageType">消息类型，每种消息都定义了固定消息模板.</param>
        public McardNotifyMessage(string changeReason = default(string), string extInfo = default(string), string messageType = default(string))
        {
            this.ChangeReason = changeReason;
            this.ExtInfo = extInfo;
            this.MessageType = messageType;
        }

        /// <summary>
        /// 用户提醒信息，按如下格式拼装，需要ISV提供change_reason。  积分变动模板：{change_reason}，您的积分有变动  余额变动模板：{change_reason}，您的余额有变动  等级变更无需提供原因。
        /// </summary>
        /// <value>用户提醒信息，按如下格式拼装，需要ISV提供change_reason。  积分变动模板：{change_reason}，您的积分有变动  余额变动模板：{change_reason}，您的余额有变动  等级变更无需提供原因。</value>
        [DataMember(Name = "change_reason", EmitDefaultValue = false)]
        public string ChangeReason { get; set; }

        /// <summary>
        /// JSON格式扩展信息，主要是发送消息中的变量
        /// </summary>
        /// <value>JSON格式扩展信息，主要是发送消息中的变量</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 消息类型，每种消息都定义了固定消息模板
        /// </summary>
        /// <value>消息类型，每种消息都定义了固定消息模板</value>
        [DataMember(Name = "message_type", EmitDefaultValue = false)]
        public string MessageType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class McardNotifyMessage {\n");
            sb.Append("  ChangeReason: ").Append(ChangeReason).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  MessageType: ").Append(MessageType).Append("\n");
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
            return this.Equals(input as McardNotifyMessage);
        }

        /// <summary>
        /// Returns true if McardNotifyMessage instances are equal
        /// </summary>
        /// <param name="input">Instance of McardNotifyMessage to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(McardNotifyMessage input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ChangeReason == input.ChangeReason ||
                    (this.ChangeReason != null &&
                    this.ChangeReason.Equals(input.ChangeReason))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.MessageType == input.MessageType ||
                    (this.MessageType != null &&
                    this.MessageType.Equals(input.MessageType))
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
                if (this.ChangeReason != null)
                {
                    hashCode = (hashCode * 59) + this.ChangeReason.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.MessageType != null)
                {
                    hashCode = (hashCode * 59) + this.MessageType.GetHashCode();
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
