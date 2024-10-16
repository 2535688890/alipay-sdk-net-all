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
    /// AttachmentExplain
    /// </summary>
    [DataContract(Name = "AttachmentExplain")]
    public partial class AttachmentExplain : IEquatable<AttachmentExplain>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentExplain" /> class.
        /// </summary>
        /// <param name="allowMoreUploads">允许上传更多附件。开启后，除了“附件列表”中指定的内容，签署人可自由上传之多10张图片。默认值为false.</param>
        /// <param name="description">描述.</param>
        /// <param name="details">附件列表.</param>
        /// <param name="title">附件标题（collect_attachement值为true时必填.</param>
        public AttachmentExplain(bool allowMoreUploads = default(bool), string description = default(string), List<Detail> details = default(List<Detail>), string title = default(string))
        {
            this.AllowMoreUploads = allowMoreUploads;
            this.Description = description;
            this.Details = details;
            this.Title = title;
        }

        /// <summary>
        /// 允许上传更多附件。开启后，除了“附件列表”中指定的内容，签署人可自由上传之多10张图片。默认值为false
        /// </summary>
        /// <value>允许上传更多附件。开启后，除了“附件列表”中指定的内容，签署人可自由上传之多10张图片。默认值为false</value>
        [DataMember(Name = "allow_more_uploads", EmitDefaultValue = true)]
        public bool AllowMoreUploads { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        /// <value>描述</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 附件列表
        /// </summary>
        /// <value>附件列表</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<Detail> Details { get; set; }

        /// <summary>
        /// 附件标题（collect_attachement值为true时必填
        /// </summary>
        /// <value>附件标题（collect_attachement值为true时必填</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachmentExplain {\n");
            sb.Append("  AllowMoreUploads: ").Append(AllowMoreUploads).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Details: ").Append(Details).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
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
            return this.Equals(input as AttachmentExplain);
        }

        /// <summary>
        /// Returns true if AttachmentExplain instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentExplain to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentExplain input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowMoreUploads == input.AllowMoreUploads ||
                    this.AllowMoreUploads.Equals(input.AllowMoreUploads)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Details == input.Details ||
                    this.Details != null &&
                    input.Details != null &&
                    this.Details.SequenceEqual(input.Details)
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
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
                hashCode = (hashCode * 59) + this.AllowMoreUploads.GetHashCode();
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Details != null)
                {
                    hashCode = (hashCode * 59) + this.Details.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
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
