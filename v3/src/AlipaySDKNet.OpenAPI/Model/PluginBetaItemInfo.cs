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
    /// PluginBetaItemInfo
    /// </summary>
    [DataContract(Name = "PluginBetaItemInfo")]
    public partial class PluginBetaItemInfo : IEquatable<PluginBetaItemInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PluginBetaItemInfo" /> class.
        /// </summary>
        /// <param name="appName">小程序名称.</param>
        /// <param name="betaStatus">被邀测状态，待确认WAITCHECK/确认CHECKED/拒绝REJECT.</param>
        /// <param name="memo">拒绝原因.</param>
        /// <param name="miniAppId">小程序ID.</param>
        /// <param name="pluginId">插件id.</param>
        /// <param name="pluginVersion">插件版本.</param>
        /// <param name="qrCodeUrl">邀测二维码.</param>
        public PluginBetaItemInfo(string appName = default(string), string betaStatus = default(string), string memo = default(string), string miniAppId = default(string), string pluginId = default(string), string pluginVersion = default(string), string qrCodeUrl = default(string))
        {
            this.AppName = appName;
            this.BetaStatus = betaStatus;
            this.Memo = memo;
            this.MiniAppId = miniAppId;
            this.PluginId = pluginId;
            this.PluginVersion = pluginVersion;
            this.QrCodeUrl = qrCodeUrl;
        }

        /// <summary>
        /// 小程序名称
        /// </summary>
        /// <value>小程序名称</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 被邀测状态，待确认WAITCHECK/确认CHECKED/拒绝REJECT
        /// </summary>
        /// <value>被邀测状态，待确认WAITCHECK/确认CHECKED/拒绝REJECT</value>
        [DataMember(Name = "beta_status", EmitDefaultValue = false)]
        public string BetaStatus { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        /// <value>拒绝原因</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        /// <value>小程序ID</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 插件id
        /// </summary>
        /// <value>插件id</value>
        [DataMember(Name = "plugin_id", EmitDefaultValue = false)]
        public string PluginId { get; set; }

        /// <summary>
        /// 插件版本
        /// </summary>
        /// <value>插件版本</value>
        [DataMember(Name = "plugin_version", EmitDefaultValue = false)]
        public string PluginVersion { get; set; }

        /// <summary>
        /// 邀测二维码
        /// </summary>
        /// <value>邀测二维码</value>
        [DataMember(Name = "qr_code_url", EmitDefaultValue = false)]
        public string QrCodeUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PluginBetaItemInfo {\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  BetaStatus: ").Append(BetaStatus).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  PluginId: ").Append(PluginId).Append("\n");
            sb.Append("  PluginVersion: ").Append(PluginVersion).Append("\n");
            sb.Append("  QrCodeUrl: ").Append(QrCodeUrl).Append("\n");
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
            return this.Equals(input as PluginBetaItemInfo);
        }

        /// <summary>
        /// Returns true if PluginBetaItemInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of PluginBetaItemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PluginBetaItemInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.BetaStatus == input.BetaStatus ||
                    (this.BetaStatus != null &&
                    this.BetaStatus.Equals(input.BetaStatus))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.PluginId == input.PluginId ||
                    (this.PluginId != null &&
                    this.PluginId.Equals(input.PluginId))
                ) && 
                (
                    this.PluginVersion == input.PluginVersion ||
                    (this.PluginVersion != null &&
                    this.PluginVersion.Equals(input.PluginVersion))
                ) && 
                (
                    this.QrCodeUrl == input.QrCodeUrl ||
                    (this.QrCodeUrl != null &&
                    this.QrCodeUrl.Equals(input.QrCodeUrl))
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
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.BetaStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BetaStatus.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.PluginId != null)
                {
                    hashCode = (hashCode * 59) + this.PluginId.GetHashCode();
                }
                if (this.PluginVersion != null)
                {
                    hashCode = (hashCode * 59) + this.PluginVersion.GetHashCode();
                }
                if (this.QrCodeUrl != null)
                {
                    hashCode = (hashCode * 59) + this.QrCodeUrl.GetHashCode();
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
