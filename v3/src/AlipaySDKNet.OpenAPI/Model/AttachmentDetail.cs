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
    /// AttachmentDetail
    /// </summary>
    [DataContract(Name = "AttachmentDetail")]
    public partial class AttachmentDetail : IEquatable<AttachmentDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentDetail" /> class.
        /// </summary>
        /// <param name="code">创建流程时指定的附件code，可能为空。（身份证正反面的固定code：正面：ESIGN_IDCARD，背面：ESIGN_BACK_IDCARD）.</param>
        /// <param name="fileName">附件文件名.</param>
        /// <param name="fileUrl">附件下载地址.</param>
        public AttachmentDetail(string code = default(string), string fileName = default(string), string fileUrl = default(string))
        {
            this.Code = code;
            this.FileName = fileName;
            this.FileUrl = fileUrl;
        }

        /// <summary>
        /// 创建流程时指定的附件code，可能为空。（身份证正反面的固定code：正面：ESIGN_IDCARD，背面：ESIGN_BACK_IDCARD）
        /// </summary>
        /// <value>创建流程时指定的附件code，可能为空。（身份证正反面的固定code：正面：ESIGN_IDCARD，背面：ESIGN_BACK_IDCARD）</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 附件文件名
        /// </summary>
        /// <value>附件文件名</value>
        [DataMember(Name = "file_name", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// 附件下载地址
        /// </summary>
        /// <value>附件下载地址</value>
        [DataMember(Name = "file_url", EmitDefaultValue = false)]
        public string FileUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachmentDetail {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  FileUrl: ").Append(FileUrl).Append("\n");
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
            return this.Equals(input as AttachmentDetail);
        }

        /// <summary>
        /// Returns true if AttachmentDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.FileUrl == input.FileUrl ||
                    (this.FileUrl != null &&
                    this.FileUrl.Equals(input.FileUrl))
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                if (this.FileUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileUrl.GetHashCode();
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
