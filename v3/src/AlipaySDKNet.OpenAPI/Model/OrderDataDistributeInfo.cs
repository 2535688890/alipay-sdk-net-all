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
    /// OrderDataDistributeInfo
    /// </summary>
    [DataContract(Name = "OrderDataDistributeInfo")]
    public partial class OrderDataDistributeInfo : IEquatable<OrderDataDistributeInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderDataDistributeInfo" /> class.
        /// </summary>
        /// <param name="notDistributeReason">未分发到场景的具体原因。开发者可根据具体原因定位解决问题后发起重试。.</param>
        /// <param name="sceneCode">分发场景code。.</param>
        /// <param name="sceneName">分发场景名，对应scene_code。.</param>
        public OrderDataDistributeInfo(string notDistributeReason = default(string), string sceneCode = default(string), string sceneName = default(string))
        {
            this.NotDistributeReason = notDistributeReason;
            this.SceneCode = sceneCode;
            this.SceneName = sceneName;
        }

        /// <summary>
        /// 未分发到场景的具体原因。开发者可根据具体原因定位解决问题后发起重试。
        /// </summary>
        /// <value>未分发到场景的具体原因。开发者可根据具体原因定位解决问题后发起重试。</value>
        [DataMember(Name = "not_distribute_reason", EmitDefaultValue = false)]
        public string NotDistributeReason { get; set; }

        /// <summary>
        /// 分发场景code。
        /// </summary>
        /// <value>分发场景code。</value>
        [DataMember(Name = "scene_code", EmitDefaultValue = false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// 分发场景名，对应scene_code。
        /// </summary>
        /// <value>分发场景名，对应scene_code。</value>
        [DataMember(Name = "scene_name", EmitDefaultValue = false)]
        public string SceneName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderDataDistributeInfo {\n");
            sb.Append("  NotDistributeReason: ").Append(NotDistributeReason).Append("\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  SceneName: ").Append(SceneName).Append("\n");
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
            return this.Equals(input as OrderDataDistributeInfo);
        }

        /// <summary>
        /// Returns true if OrderDataDistributeInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderDataDistributeInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderDataDistributeInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.NotDistributeReason == input.NotDistributeReason ||
                    (this.NotDistributeReason != null &&
                    this.NotDistributeReason.Equals(input.NotDistributeReason))
                ) && 
                (
                    this.SceneCode == input.SceneCode ||
                    (this.SceneCode != null &&
                    this.SceneCode.Equals(input.SceneCode))
                ) && 
                (
                    this.SceneName == input.SceneName ||
                    (this.SceneName != null &&
                    this.SceneName.Equals(input.SceneName))
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
                if (this.NotDistributeReason != null)
                {
                    hashCode = (hashCode * 59) + this.NotDistributeReason.GetHashCode();
                }
                if (this.SceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCode.GetHashCode();
                }
                if (this.SceneName != null)
                {
                    hashCode = (hashCode * 59) + this.SceneName.GetHashCode();
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
