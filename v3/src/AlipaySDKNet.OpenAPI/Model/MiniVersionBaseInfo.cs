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
    /// MiniVersionBaseInfo
    /// </summary>
    [DataContract(Name = "MiniVersionBaseInfo")]
    public partial class MiniVersionBaseInfo : IEquatable<MiniVersionBaseInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MiniVersionBaseInfo" /> class.
        /// </summary>
        /// <param name="appVersion">版本号.</param>
        /// <param name="buildSource">小程序所属来源.</param>
        /// <param name="bundleId">com.alipay.alipaywallet:支付宝，com.amap.app:高德.</param>
        /// <param name="devId">小程序开发者ID.</param>
        /// <param name="grayStrategy">小程序灰度值.</param>
        /// <param name="miniAppId">小程序应用ID.</param>
        /// <param name="status">小程序状态.</param>
        public MiniVersionBaseInfo(string appVersion = default(string), string buildSource = default(string), string bundleId = default(string), string devId = default(string), string grayStrategy = default(string), string miniAppId = default(string), string status = default(string))
        {
            this.AppVersion = appVersion;
            this.BuildSource = buildSource;
            this.BundleId = bundleId;
            this.DevId = devId;
            this.GrayStrategy = grayStrategy;
            this.MiniAppId = miniAppId;
            this.Status = status;
        }

        /// <summary>
        /// 版本号
        /// </summary>
        /// <value>版本号</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 小程序所属来源
        /// </summary>
        /// <value>小程序所属来源</value>
        [DataMember(Name = "build_source", EmitDefaultValue = false)]
        public string BuildSource { get; set; }

        /// <summary>
        /// com.alipay.alipaywallet:支付宝，com.amap.app:高德
        /// </summary>
        /// <value>com.alipay.alipaywallet:支付宝，com.amap.app:高德</value>
        [DataMember(Name = "bundle_id", EmitDefaultValue = false)]
        public string BundleId { get; set; }

        /// <summary>
        /// 小程序开发者ID
        /// </summary>
        /// <value>小程序开发者ID</value>
        [DataMember(Name = "dev_id", EmitDefaultValue = false)]
        public string DevId { get; set; }

        /// <summary>
        /// 小程序灰度值
        /// </summary>
        /// <value>小程序灰度值</value>
        [DataMember(Name = "gray_strategy", EmitDefaultValue = false)]
        public string GrayStrategy { get; set; }

        /// <summary>
        /// 小程序应用ID
        /// </summary>
        /// <value>小程序应用ID</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序状态
        /// </summary>
        /// <value>小程序状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MiniVersionBaseInfo {\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BuildSource: ").Append(BuildSource).Append("\n");
            sb.Append("  BundleId: ").Append(BundleId).Append("\n");
            sb.Append("  DevId: ").Append(DevId).Append("\n");
            sb.Append("  GrayStrategy: ").Append(GrayStrategy).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
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
            return this.Equals(input as MiniVersionBaseInfo);
        }

        /// <summary>
        /// Returns true if MiniVersionBaseInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of MiniVersionBaseInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MiniVersionBaseInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.BuildSource == input.BuildSource ||
                    (this.BuildSource != null &&
                    this.BuildSource.Equals(input.BuildSource))
                ) && 
                (
                    this.BundleId == input.BundleId ||
                    (this.BundleId != null &&
                    this.BundleId.Equals(input.BundleId))
                ) && 
                (
                    this.DevId == input.DevId ||
                    (this.DevId != null &&
                    this.DevId.Equals(input.DevId))
                ) && 
                (
                    this.GrayStrategy == input.GrayStrategy ||
                    (this.GrayStrategy != null &&
                    this.GrayStrategy.Equals(input.GrayStrategy))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
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
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.BuildSource != null)
                {
                    hashCode = (hashCode * 59) + this.BuildSource.GetHashCode();
                }
                if (this.BundleId != null)
                {
                    hashCode = (hashCode * 59) + this.BundleId.GetHashCode();
                }
                if (this.DevId != null)
                {
                    hashCode = (hashCode * 59) + this.DevId.GetHashCode();
                }
                if (this.GrayStrategy != null)
                {
                    hashCode = (hashCode * 59) + this.GrayStrategy.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
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
