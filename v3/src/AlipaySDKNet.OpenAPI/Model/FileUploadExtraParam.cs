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
    /// FileUploadExtraParam
    /// </summary>
    [DataContract(Name = "FileUploadExtraParam")]
    public partial class FileUploadExtraParam : IEquatable<FileUploadExtraParam>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FileUploadExtraParam" /> class.
        /// </summary>
        /// <param name="externUpload">是否同步上传到其他平台。素材类型为视频且需要同步优酷，请必传入参数youku，素材接口将代上传到优酷账号；素材类型为图片，无需传入参数.</param>
        /// <param name="fileEncryptType">文件加密类型.</param>
        public FileUploadExtraParam(string externUpload = default(string), string fileEncryptType = default(string))
        {
            this.ExternUpload = externUpload;
            this.FileEncryptType = fileEncryptType;
        }

        /// <summary>
        /// 是否同步上传到其他平台。素材类型为视频且需要同步优酷，请必传入参数youku，素材接口将代上传到优酷账号；素材类型为图片，无需传入参数
        /// </summary>
        /// <value>是否同步上传到其他平台。素材类型为视频且需要同步优酷，请必传入参数youku，素材接口将代上传到优酷账号；素材类型为图片，无需传入参数</value>
        [DataMember(Name = "extern_upload", EmitDefaultValue = false)]
        public string ExternUpload { get; set; }

        /// <summary>
        /// 文件加密类型
        /// </summary>
        /// <value>文件加密类型</value>
        [DataMember(Name = "file_encrypt_type", EmitDefaultValue = false)]
        public string FileEncryptType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileUploadExtraParam {\n");
            sb.Append("  ExternUpload: ").Append(ExternUpload).Append("\n");
            sb.Append("  FileEncryptType: ").Append(FileEncryptType).Append("\n");
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
            return this.Equals(input as FileUploadExtraParam);
        }

        /// <summary>
        /// Returns true if FileUploadExtraParam instances are equal
        /// </summary>
        /// <param name="input">Instance of FileUploadExtraParam to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileUploadExtraParam input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExternUpload == input.ExternUpload ||
                    (this.ExternUpload != null &&
                    this.ExternUpload.Equals(input.ExternUpload))
                ) && 
                (
                    this.FileEncryptType == input.FileEncryptType ||
                    (this.FileEncryptType != null &&
                    this.FileEncryptType.Equals(input.FileEncryptType))
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
                if (this.ExternUpload != null)
                {
                    hashCode = (hashCode * 59) + this.ExternUpload.GetHashCode();
                }
                if (this.FileEncryptType != null)
                {
                    hashCode = (hashCode * 59) + this.FileEncryptType.GetHashCode();
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
