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
    /// AlipayOpenMiniMiniappBrandUploadRequest
    /// </summary>
    [DataContract(Name = "alipay_open_mini_miniapp_brand_upload_request")]
    public partial class AlipayOpenMiniMiniappBrandUploadRequest : IEquatable<AlipayOpenMiniMiniappBrandUploadRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniMiniappBrandUploadRequest" /> class.
        /// </summary>
        /// <param name="fileContent">fileContent.</param>
        public AlipayOpenMiniMiniappBrandUploadRequest(System.IO.Stream fileContent = default(System.IO.Stream))
        {
            this.FileContent = fileContent;
        }

        /// <summary>
        /// Gets or Sets FileContent
        /// </summary>
        [DataMember(Name = "file_content", EmitDefaultValue = false)]
        public System.IO.Stream FileContent { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniMiniappBrandUploadRequest {\n");
            sb.Append("  FileContent: ").Append(FileContent).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniMiniappBrandUploadRequest);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniMiniappBrandUploadRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniMiniappBrandUploadRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniMiniappBrandUploadRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FileContent == input.FileContent ||
                    (this.FileContent != null &&
                    this.FileContent.Equals(input.FileContent))
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
                if (this.FileContent != null)
                {
                    hashCode = (hashCode * 59) + this.FileContent.GetHashCode();
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
