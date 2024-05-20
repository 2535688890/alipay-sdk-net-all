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
    /// AlipayEcoFilePathQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoFilePathQueryResponseModel")]
    public partial class AlipayEcoFilePathQueryResponseModel : IEquatable<AlipayEcoFilePathQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoFilePathQueryResponseModel" /> class.
        /// </summary>
        /// <param name="fileId">文件Id.</param>
        /// <param name="uploadUrl">文件直传地址, 可以重复使用，但是只能传一样的文件，有效期一小时.</param>
        public AlipayEcoFilePathQueryResponseModel(string fileId = default(string), string uploadUrl = default(string))
        {
            this.FileId = fileId;
            this.UploadUrl = uploadUrl;
        }

        /// <summary>
        /// 文件Id
        /// </summary>
        /// <value>文件Id</value>
        [DataMember(Name = "file_id", EmitDefaultValue = false)]
        public string FileId { get; set; }

        /// <summary>
        /// 文件直传地址, 可以重复使用，但是只能传一样的文件，有效期一小时
        /// </summary>
        /// <value>文件直传地址, 可以重复使用，但是只能传一样的文件，有效期一小时</value>
        [DataMember(Name = "upload_url", EmitDefaultValue = false)]
        public string UploadUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoFilePathQueryResponseModel {\n");
            sb.Append("  FileId: ").Append(FileId).Append("\n");
            sb.Append("  UploadUrl: ").Append(UploadUrl).Append("\n");
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
            return this.Equals(input as AlipayEcoFilePathQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoFilePathQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoFilePathQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoFilePathQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileId == input.FileId ||
                    (this.FileId != null &&
                    this.FileId.Equals(input.FileId))
                ) && 
                (
                    this.UploadUrl == input.UploadUrl ||
                    (this.UploadUrl != null &&
                    this.UploadUrl.Equals(input.UploadUrl))
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
                if (this.FileId != null)
                {
                    hashCode = (hashCode * 59) + this.FileId.GetHashCode();
                }
                if (this.UploadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.UploadUrl.GetHashCode();
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
