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
    /// AlipayOpenMiniInnerversionUploadstatusQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerversionUploadstatusQueryResponseModel")]
    public partial class AlipayOpenMiniInnerversionUploadstatusQueryResponseModel : IEquatable<AlipayOpenMiniInnerversionUploadstatusQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerversionUploadstatusQueryResponseModel" /> class.
        /// </summary>
        /// <param name="buildInfo">构建信息.</param>
        /// <param name="buildPackageUrl">构建好的包地址.</param>
        /// <param name="buildStatus">构建状态.</param>
        /// <param name="logUrl">构建日志地址.</param>
        /// <param name="needRotation">是否需要轮询.</param>
        /// <param name="newBuildPackageUrl">构建好的appx2.0包地址.</param>
        /// <param name="newResultUrl">构建的结果地址.</param>
        /// <param name="resultUrl">构建的结果地址.</param>
        /// <param name="versionCreated">创建版本结果.</param>
        public AlipayOpenMiniInnerversionUploadstatusQueryResponseModel(string buildInfo = default(string), string buildPackageUrl = default(string), string buildStatus = default(string), string logUrl = default(string), string needRotation = default(string), string newBuildPackageUrl = default(string), string newResultUrl = default(string), string resultUrl = default(string), string versionCreated = default(string))
        {
            this.BuildInfo = buildInfo;
            this.BuildPackageUrl = buildPackageUrl;
            this.BuildStatus = buildStatus;
            this.LogUrl = logUrl;
            this.NeedRotation = needRotation;
            this.NewBuildPackageUrl = newBuildPackageUrl;
            this.NewResultUrl = newResultUrl;
            this.ResultUrl = resultUrl;
            this.VersionCreated = versionCreated;
        }

        /// <summary>
        /// 构建信息
        /// </summary>
        /// <value>构建信息</value>
        [DataMember(Name = "build_info", EmitDefaultValue = false)]
        public string BuildInfo { get; set; }

        /// <summary>
        /// 构建好的包地址
        /// </summary>
        /// <value>构建好的包地址</value>
        [DataMember(Name = "build_package_url", EmitDefaultValue = false)]
        public string BuildPackageUrl { get; set; }

        /// <summary>
        /// 构建状态
        /// </summary>
        /// <value>构建状态</value>
        [DataMember(Name = "build_status", EmitDefaultValue = false)]
        public string BuildStatus { get; set; }

        /// <summary>
        /// 构建日志地址
        /// </summary>
        /// <value>构建日志地址</value>
        [DataMember(Name = "log_url", EmitDefaultValue = false)]
        public string LogUrl { get; set; }

        /// <summary>
        /// 是否需要轮询
        /// </summary>
        /// <value>是否需要轮询</value>
        [DataMember(Name = "need_rotation", EmitDefaultValue = false)]
        public string NeedRotation { get; set; }

        /// <summary>
        /// 构建好的appx2.0包地址
        /// </summary>
        /// <value>构建好的appx2.0包地址</value>
        [DataMember(Name = "new_build_package_url", EmitDefaultValue = false)]
        public string NewBuildPackageUrl { get; set; }

        /// <summary>
        /// 构建的结果地址
        /// </summary>
        /// <value>构建的结果地址</value>
        [DataMember(Name = "new_result_url", EmitDefaultValue = false)]
        public string NewResultUrl { get; set; }

        /// <summary>
        /// 构建的结果地址
        /// </summary>
        /// <value>构建的结果地址</value>
        [DataMember(Name = "result_url", EmitDefaultValue = false)]
        public string ResultUrl { get; set; }

        /// <summary>
        /// 创建版本结果
        /// </summary>
        /// <value>创建版本结果</value>
        [DataMember(Name = "version_created", EmitDefaultValue = false)]
        public string VersionCreated { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerversionUploadstatusQueryResponseModel {\n");
            sb.Append("  BuildInfo: ").Append(BuildInfo).Append("\n");
            sb.Append("  BuildPackageUrl: ").Append(BuildPackageUrl).Append("\n");
            sb.Append("  BuildStatus: ").Append(BuildStatus).Append("\n");
            sb.Append("  LogUrl: ").Append(LogUrl).Append("\n");
            sb.Append("  NeedRotation: ").Append(NeedRotation).Append("\n");
            sb.Append("  NewBuildPackageUrl: ").Append(NewBuildPackageUrl).Append("\n");
            sb.Append("  NewResultUrl: ").Append(NewResultUrl).Append("\n");
            sb.Append("  ResultUrl: ").Append(ResultUrl).Append("\n");
            sb.Append("  VersionCreated: ").Append(VersionCreated).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerversionUploadstatusQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerversionUploadstatusQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerversionUploadstatusQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerversionUploadstatusQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuildInfo == input.BuildInfo ||
                    (this.BuildInfo != null &&
                    this.BuildInfo.Equals(input.BuildInfo))
                ) && 
                (
                    this.BuildPackageUrl == input.BuildPackageUrl ||
                    (this.BuildPackageUrl != null &&
                    this.BuildPackageUrl.Equals(input.BuildPackageUrl))
                ) && 
                (
                    this.BuildStatus == input.BuildStatus ||
                    (this.BuildStatus != null &&
                    this.BuildStatus.Equals(input.BuildStatus))
                ) && 
                (
                    this.LogUrl == input.LogUrl ||
                    (this.LogUrl != null &&
                    this.LogUrl.Equals(input.LogUrl))
                ) && 
                (
                    this.NeedRotation == input.NeedRotation ||
                    (this.NeedRotation != null &&
                    this.NeedRotation.Equals(input.NeedRotation))
                ) && 
                (
                    this.NewBuildPackageUrl == input.NewBuildPackageUrl ||
                    (this.NewBuildPackageUrl != null &&
                    this.NewBuildPackageUrl.Equals(input.NewBuildPackageUrl))
                ) && 
                (
                    this.NewResultUrl == input.NewResultUrl ||
                    (this.NewResultUrl != null &&
                    this.NewResultUrl.Equals(input.NewResultUrl))
                ) && 
                (
                    this.ResultUrl == input.ResultUrl ||
                    (this.ResultUrl != null &&
                    this.ResultUrl.Equals(input.ResultUrl))
                ) && 
                (
                    this.VersionCreated == input.VersionCreated ||
                    (this.VersionCreated != null &&
                    this.VersionCreated.Equals(input.VersionCreated))
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
                if (this.BuildInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BuildInfo.GetHashCode();
                }
                if (this.BuildPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BuildPackageUrl.GetHashCode();
                }
                if (this.BuildStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BuildStatus.GetHashCode();
                }
                if (this.LogUrl != null)
                {
                    hashCode = (hashCode * 59) + this.LogUrl.GetHashCode();
                }
                if (this.NeedRotation != null)
                {
                    hashCode = (hashCode * 59) + this.NeedRotation.GetHashCode();
                }
                if (this.NewBuildPackageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NewBuildPackageUrl.GetHashCode();
                }
                if (this.NewResultUrl != null)
                {
                    hashCode = (hashCode * 59) + this.NewResultUrl.GetHashCode();
                }
                if (this.ResultUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ResultUrl.GetHashCode();
                }
                if (this.VersionCreated != null)
                {
                    hashCode = (hashCode * 59) + this.VersionCreated.GetHashCode();
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
