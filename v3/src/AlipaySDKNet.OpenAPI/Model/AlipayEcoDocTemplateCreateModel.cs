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
    /// AlipayEcoDocTemplateCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEcoDocTemplateCreateModel")]
    public partial class AlipayEcoDocTemplateCreateModel : IEquatable<AlipayEcoDocTemplateCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoDocTemplateCreateModel" /> class.
        /// </summary>
        /// <param name="contentMd5">模版文件的md5值。示例代码参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/00arl2#%E5%88%9B%E5%BB%BA%E5%90%88%E5%90%8C%E6%A8%A1%E6%9D%BF\&quot;&gt;创建合同模板&lt;/a&gt;.</param>
        /// <param name="contentType">目标文件的MIME类型。示例代码参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/00arl2#%E5%88%9B%E5%BB%BA%E5%90%88%E5%90%8C%E6%A8%A1%E6%9D%BF\&quot;&gt;创建合同模板&lt;/a&gt;.</param>
        /// <param name="convertToPdf">是否需要转成pdf，如果模板文件为.doc/.docx 传true，为pdf传false.</param>
        /// <param name="fileName">文件名称，必须带上文件扩展名如 .pdf、.doc、.docx，否则会导致后续发起流程校验异常。.</param>
        public AlipayEcoDocTemplateCreateModel(string contentMd5 = default(string), string contentType = default(string), string convertToPdf = default(string), string fileName = default(string))
        {
            this.ContentMd5 = contentMd5;
            this.ContentType = contentType;
            this.ConvertToPdf = convertToPdf;
            this.FileName = fileName;
        }

        /// <summary>
        /// 模版文件的md5值。示例代码参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/00arl2#%E5%88%9B%E5%BB%BA%E5%90%88%E5%90%8C%E6%A8%A1%E6%9D%BF\&quot;&gt;创建合同模板&lt;/a&gt;
        /// </summary>
        /// <value>模版文件的md5值。示例代码参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/00arl2#%E5%88%9B%E5%BB%BA%E5%90%88%E5%90%8C%E6%A8%A1%E6%9D%BF\&quot;&gt;创建合同模板&lt;/a&gt;</value>
        [DataMember(Name = "content_md_5", EmitDefaultValue = false)]
        public string ContentMd5 { get; set; }

        /// <summary>
        /// 目标文件的MIME类型。示例代码参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/00arl2#%E5%88%9B%E5%BB%BA%E5%90%88%E5%90%8C%E6%A8%A1%E6%9D%BF\&quot;&gt;创建合同模板&lt;/a&gt;
        /// </summary>
        /// <value>目标文件的MIME类型。示例代码参见 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/00arl2#%E5%88%9B%E5%BB%BA%E5%90%88%E5%90%8C%E6%A8%A1%E6%9D%BF\&quot;&gt;创建合同模板&lt;/a&gt;</value>
        [DataMember(Name = "content_type", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// 是否需要转成pdf，如果模板文件为.doc/.docx 传true，为pdf传false
        /// </summary>
        /// <value>是否需要转成pdf，如果模板文件为.doc/.docx 传true，为pdf传false</value>
        [DataMember(Name = "convert_to_pdf", EmitDefaultValue = false)]
        public string ConvertToPdf { get; set; }

        /// <summary>
        /// 文件名称，必须带上文件扩展名如 .pdf、.doc、.docx，否则会导致后续发起流程校验异常。
        /// </summary>
        /// <value>文件名称，必须带上文件扩展名如 .pdf、.doc、.docx，否则会导致后续发起流程校验异常。</value>
        [DataMember(Name = "file_name", EmitDefaultValue = false)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoDocTemplateCreateModel {\n");
            sb.Append("  ContentMd5: ").Append(ContentMd5).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ConvertToPdf: ").Append(ConvertToPdf).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
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
            return this.Equals(input as AlipayEcoDocTemplateCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoDocTemplateCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoDocTemplateCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoDocTemplateCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ContentMd5 == input.ContentMd5 ||
                    (this.ContentMd5 != null &&
                    this.ContentMd5.Equals(input.ContentMd5))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.ConvertToPdf == input.ConvertToPdf ||
                    (this.ConvertToPdf != null &&
                    this.ConvertToPdf.Equals(input.ConvertToPdf))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
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
                if (this.ContentMd5 != null)
                {
                    hashCode = (hashCode * 59) + this.ContentMd5.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                if (this.ConvertToPdf != null)
                {
                    hashCode = (hashCode * 59) + this.ConvertToPdf.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
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
