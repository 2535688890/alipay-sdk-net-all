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
    /// ZolozAuthenticationSmilepayInitializeModel
    /// </summary>
    [DataContract(Name = "ZolozAuthenticationSmilepayInitializeModel")]
    public partial class ZolozAuthenticationSmilepayInitializeModel : IEquatable<ZolozAuthenticationSmilepayInitializeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZolozAuthenticationSmilepayInitializeModel" /> class.
        /// </summary>
        /// <param name="apdidToken">设备指纹，用于唯一标识一台设备.</param>
        /// <param name="appName">人脸识别应用名称.</param>
        /// <param name="appVersion">人脸识别应用版本号.</param>
        /// <param name="baseVer">基础包版本号.</param>
        /// <param name="bioMetaInfo">生物识别元信息.</param>
        /// <param name="deviceModel">设备型号.</param>
        /// <param name="deviceType">设备类型.</param>
        /// <param name="extInfo">extInfo.</param>
        /// <param name="machineInfo">machineInfo.</param>
        /// <param name="merchantInfo">merchantInfo.</param>
        /// <param name="osVersion">操作系统版本号.</param>
        /// <param name="remoteLogId">业务ID.</param>
        /// <param name="zimVer">ZIM版本号.</param>
        public ZolozAuthenticationSmilepayInitializeModel(string apdidToken = default(string), string appName = default(string), string appVersion = default(string), string baseVer = default(string), string bioMetaInfo = default(string), string deviceModel = default(string), string deviceType = default(string), FaceExtParams extInfo = default(FaceExtParams), FaceMachineInfo machineInfo = default(FaceMachineInfo), FaceMerchantInfo merchantInfo = default(FaceMerchantInfo), string osVersion = default(string), string remoteLogId = default(string), string zimVer = default(string))
        {
            this.ApdidToken = apdidToken;
            this.AppName = appName;
            this.AppVersion = appVersion;
            this.BaseVer = baseVer;
            this.BioMetaInfo = bioMetaInfo;
            this.DeviceModel = deviceModel;
            this.DeviceType = deviceType;
            this.ExtInfo = extInfo;
            this.MachineInfo = machineInfo;
            this.MerchantInfo = merchantInfo;
            this.OsVersion = osVersion;
            this.RemoteLogId = remoteLogId;
            this.ZimVer = zimVer;
        }

        /// <summary>
        /// 设备指纹，用于唯一标识一台设备
        /// </summary>
        /// <value>设备指纹，用于唯一标识一台设备</value>
        [DataMember(Name = "apdid_token", EmitDefaultValue = false)]
        public string ApdidToken { get; set; }

        /// <summary>
        /// 人脸识别应用名称
        /// </summary>
        /// <value>人脸识别应用名称</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 人脸识别应用版本号
        /// </summary>
        /// <value>人脸识别应用版本号</value>
        [DataMember(Name = "app_version", EmitDefaultValue = false)]
        public string AppVersion { get; set; }

        /// <summary>
        /// 基础包版本号
        /// </summary>
        /// <value>基础包版本号</value>
        [DataMember(Name = "base_ver", EmitDefaultValue = false)]
        public string BaseVer { get; set; }

        /// <summary>
        /// 生物识别元信息
        /// </summary>
        /// <value>生物识别元信息</value>
        [DataMember(Name = "bio_meta_info", EmitDefaultValue = false)]
        public string BioMetaInfo { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        /// <value>设备型号</value>
        [DataMember(Name = "device_model", EmitDefaultValue = false)]
        public string DeviceModel { get; set; }

        /// <summary>
        /// 设备类型
        /// </summary>
        /// <value>设备类型</value>
        [DataMember(Name = "device_type", EmitDefaultValue = false)]
        public string DeviceType { get; set; }

        /// <summary>
        /// Gets or Sets ExtInfo
        /// </summary>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public FaceExtParams ExtInfo { get; set; }

        /// <summary>
        /// Gets or Sets MachineInfo
        /// </summary>
        [DataMember(Name = "machine_info", EmitDefaultValue = false)]
        public FaceMachineInfo MachineInfo { get; set; }

        /// <summary>
        /// Gets or Sets MerchantInfo
        /// </summary>
        [DataMember(Name = "merchant_info", EmitDefaultValue = false)]
        public FaceMerchantInfo MerchantInfo { get; set; }

        /// <summary>
        /// 操作系统版本号
        /// </summary>
        /// <value>操作系统版本号</value>
        [DataMember(Name = "os_version", EmitDefaultValue = false)]
        public string OsVersion { get; set; }

        /// <summary>
        /// 业务ID
        /// </summary>
        /// <value>业务ID</value>
        [DataMember(Name = "remote_log_id", EmitDefaultValue = false)]
        public string RemoteLogId { get; set; }

        /// <summary>
        /// ZIM版本号
        /// </summary>
        /// <value>ZIM版本号</value>
        [DataMember(Name = "zim_ver", EmitDefaultValue = false)]
        public string ZimVer { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZolozAuthenticationSmilepayInitializeModel {\n");
            sb.Append("  ApdidToken: ").Append(ApdidToken).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppVersion: ").Append(AppVersion).Append("\n");
            sb.Append("  BaseVer: ").Append(BaseVer).Append("\n");
            sb.Append("  BioMetaInfo: ").Append(BioMetaInfo).Append("\n");
            sb.Append("  DeviceModel: ").Append(DeviceModel).Append("\n");
            sb.Append("  DeviceType: ").Append(DeviceType).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  MachineInfo: ").Append(MachineInfo).Append("\n");
            sb.Append("  MerchantInfo: ").Append(MerchantInfo).Append("\n");
            sb.Append("  OsVersion: ").Append(OsVersion).Append("\n");
            sb.Append("  RemoteLogId: ").Append(RemoteLogId).Append("\n");
            sb.Append("  ZimVer: ").Append(ZimVer).Append("\n");
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
            return this.Equals(input as ZolozAuthenticationSmilepayInitializeModel);
        }

        /// <summary>
        /// Returns true if ZolozAuthenticationSmilepayInitializeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZolozAuthenticationSmilepayInitializeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZolozAuthenticationSmilepayInitializeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApdidToken == input.ApdidToken ||
                    (this.ApdidToken != null &&
                    this.ApdidToken.Equals(input.ApdidToken))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppVersion == input.AppVersion ||
                    (this.AppVersion != null &&
                    this.AppVersion.Equals(input.AppVersion))
                ) && 
                (
                    this.BaseVer == input.BaseVer ||
                    (this.BaseVer != null &&
                    this.BaseVer.Equals(input.BaseVer))
                ) && 
                (
                    this.BioMetaInfo == input.BioMetaInfo ||
                    (this.BioMetaInfo != null &&
                    this.BioMetaInfo.Equals(input.BioMetaInfo))
                ) && 
                (
                    this.DeviceModel == input.DeviceModel ||
                    (this.DeviceModel != null &&
                    this.DeviceModel.Equals(input.DeviceModel))
                ) && 
                (
                    this.DeviceType == input.DeviceType ||
                    (this.DeviceType != null &&
                    this.DeviceType.Equals(input.DeviceType))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.MachineInfo == input.MachineInfo ||
                    (this.MachineInfo != null &&
                    this.MachineInfo.Equals(input.MachineInfo))
                ) && 
                (
                    this.MerchantInfo == input.MerchantInfo ||
                    (this.MerchantInfo != null &&
                    this.MerchantInfo.Equals(input.MerchantInfo))
                ) && 
                (
                    this.OsVersion == input.OsVersion ||
                    (this.OsVersion != null &&
                    this.OsVersion.Equals(input.OsVersion))
                ) && 
                (
                    this.RemoteLogId == input.RemoteLogId ||
                    (this.RemoteLogId != null &&
                    this.RemoteLogId.Equals(input.RemoteLogId))
                ) && 
                (
                    this.ZimVer == input.ZimVer ||
                    (this.ZimVer != null &&
                    this.ZimVer.Equals(input.ZimVer))
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
                if (this.ApdidToken != null)
                {
                    hashCode = (hashCode * 59) + this.ApdidToken.GetHashCode();
                }
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AppVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AppVersion.GetHashCode();
                }
                if (this.BaseVer != null)
                {
                    hashCode = (hashCode * 59) + this.BaseVer.GetHashCode();
                }
                if (this.BioMetaInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BioMetaInfo.GetHashCode();
                }
                if (this.DeviceModel != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceModel.GetHashCode();
                }
                if (this.DeviceType != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceType.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.MachineInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MachineInfo.GetHashCode();
                }
                if (this.MerchantInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantInfo.GetHashCode();
                }
                if (this.OsVersion != null)
                {
                    hashCode = (hashCode * 59) + this.OsVersion.GetHashCode();
                }
                if (this.RemoteLogId != null)
                {
                    hashCode = (hashCode * 59) + this.RemoteLogId.GetHashCode();
                }
                if (this.ZimVer != null)
                {
                    hashCode = (hashCode * 59) + this.ZimVer.GetHashCode();
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
