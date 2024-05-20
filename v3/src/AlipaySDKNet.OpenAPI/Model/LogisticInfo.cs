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
    /// LogisticInfo
    /// </summary>
    [DataContract(Name = "LogisticInfo")]
    public partial class LogisticInfo : IEquatable<LogisticInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogisticInfo" /> class.
        /// </summary>
        /// <param name="channel">物流公司名称.</param>
        /// <param name="detail">物流详情.</param>
        /// <param name="logisticId">物流id.</param>
        /// <param name="shipArea">发货地.</param>
        /// <param name="shipPeriod">发货时效.</param>
        /// <param name="status">物流状态.</param>
        /// <param name="stopUpdateTime">物流停更时间.</param>
        public LogisticInfo(string channel = default(string), string detail = default(string), string logisticId = default(string), string shipArea = default(string), string shipPeriod = default(string), string status = default(string), string stopUpdateTime = default(string))
        {
            this.Channel = channel;
            this.Detail = detail;
            this.LogisticId = logisticId;
            this.ShipArea = shipArea;
            this.ShipPeriod = shipPeriod;
            this.Status = status;
            this.StopUpdateTime = stopUpdateTime;
        }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        /// <value>物流公司名称</value>
        [DataMember(Name = "channel", EmitDefaultValue = false)]
        public string Channel { get; set; }

        /// <summary>
        /// 物流详情
        /// </summary>
        /// <value>物流详情</value>
        [DataMember(Name = "detail", EmitDefaultValue = false)]
        public string Detail { get; set; }

        /// <summary>
        /// 物流id
        /// </summary>
        /// <value>物流id</value>
        [DataMember(Name = "logistic_id", EmitDefaultValue = false)]
        public string LogisticId { get; set; }

        /// <summary>
        /// 发货地
        /// </summary>
        /// <value>发货地</value>
        [DataMember(Name = "ship_area", EmitDefaultValue = false)]
        public string ShipArea { get; set; }

        /// <summary>
        /// 发货时效
        /// </summary>
        /// <value>发货时效</value>
        [DataMember(Name = "ship_period", EmitDefaultValue = false)]
        public string ShipPeriod { get; set; }

        /// <summary>
        /// 物流状态
        /// </summary>
        /// <value>物流状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 物流停更时间
        /// </summary>
        /// <value>物流停更时间</value>
        [DataMember(Name = "stop_update_time", EmitDefaultValue = false)]
        public string StopUpdateTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogisticInfo {\n");
            sb.Append("  Channel: ").Append(Channel).Append("\n");
            sb.Append("  Detail: ").Append(Detail).Append("\n");
            sb.Append("  LogisticId: ").Append(LogisticId).Append("\n");
            sb.Append("  ShipArea: ").Append(ShipArea).Append("\n");
            sb.Append("  ShipPeriod: ").Append(ShipPeriod).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StopUpdateTime: ").Append(StopUpdateTime).Append("\n");
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
            return this.Equals(input as LogisticInfo);
        }

        /// <summary>
        /// Returns true if LogisticInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of LogisticInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogisticInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Channel == input.Channel ||
                    (this.Channel != null &&
                    this.Channel.Equals(input.Channel))
                ) && 
                (
                    this.Detail == input.Detail ||
                    (this.Detail != null &&
                    this.Detail.Equals(input.Detail))
                ) && 
                (
                    this.LogisticId == input.LogisticId ||
                    (this.LogisticId != null &&
                    this.LogisticId.Equals(input.LogisticId))
                ) && 
                (
                    this.ShipArea == input.ShipArea ||
                    (this.ShipArea != null &&
                    this.ShipArea.Equals(input.ShipArea))
                ) && 
                (
                    this.ShipPeriod == input.ShipPeriod ||
                    (this.ShipPeriod != null &&
                    this.ShipPeriod.Equals(input.ShipPeriod))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StopUpdateTime == input.StopUpdateTime ||
                    (this.StopUpdateTime != null &&
                    this.StopUpdateTime.Equals(input.StopUpdateTime))
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
                if (this.Channel != null)
                {
                    hashCode = (hashCode * 59) + this.Channel.GetHashCode();
                }
                if (this.Detail != null)
                {
                    hashCode = (hashCode * 59) + this.Detail.GetHashCode();
                }
                if (this.LogisticId != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticId.GetHashCode();
                }
                if (this.ShipArea != null)
                {
                    hashCode = (hashCode * 59) + this.ShipArea.GetHashCode();
                }
                if (this.ShipPeriod != null)
                {
                    hashCode = (hashCode * 59) + this.ShipPeriod.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.StopUpdateTime != null)
                {
                    hashCode = (hashCode * 59) + this.StopUpdateTime.GetHashCode();
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
