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
    /// AttachmentExplainBean
    /// </summary>
    [DataContract(Name = "AttachmentExplainBean")]
    public partial class AttachmentExplainBean : IEquatable<AttachmentExplainBean>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentExplainBean" /> class.
        /// </summary>
        /// <param name="description">页面展示的任务描（collect_attachement值为true时必填）.</param>
        /// <param name="details">附件列表，用于定义每个附件code的描述及页面展示顺序.</param>
        /// <param name="title">页面展示的任务标题（collect_attachement值为true时必填）.</param>
        public AttachmentExplainBean(string description = default(string), List<DetailBean> details = default(List<DetailBean>), string title = default(string))
        {
            this.Description = description;
            this.Details = details;
            this.Title = title;
        }

        /// <summary>
        /// 页面展示的任务描（collect_attachement值为true时必填）
        /// </summary>
        /// <value>页面展示的任务描（collect_attachement值为true时必填）</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 附件列表，用于定义每个附件code的描述及页面展示顺序
        /// </summary>
        /// <value>附件列表，用于定义每个附件code的描述及页面展示顺序</value>
        [DataMember(Name = "details", EmitDefaultValue = false)]
        public List<DetailBean> Details { get; set; }

        /// <summary>
        /// 页面展示的任务标题（collect_attachement值为true时必填）
        /// </summary>
        /// <value>页面展示的任务标题（collect_attachement值为true时必填）</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachmentExplainBean {\n");
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
            return this.Equals(input as AttachmentExplainBean);
        }

        /// <summary>
        /// Returns true if AttachmentExplainBean instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentExplainBean to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentExplainBean input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
