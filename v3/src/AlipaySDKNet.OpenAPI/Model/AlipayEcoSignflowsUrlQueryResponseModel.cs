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
    /// AlipayEcoSignflowsUrlQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoSignflowsUrlQueryResponseModel")]
    public partial class AlipayEcoSignflowsUrlQueryResponseModel : IEquatable<AlipayEcoSignflowsUrlQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoSignflowsUrlQueryResponseModel" /> class.
        /// </summary>
        /// <param name="previewShortUrl">预览短链地址（30天有效）.</param>
        /// <param name="previewUrl">预览长链地址(永久有效).</param>
        /// <param name="signShortUrl">签署短链地址（30天有效）.</param>
        /// <param name="signUrl">签署长链地址(永久有效).</param>
        public AlipayEcoSignflowsUrlQueryResponseModel(string previewShortUrl = default(string), string previewUrl = default(string), string signShortUrl = default(string), string signUrl = default(string))
        {
            this.PreviewShortUrl = previewShortUrl;
            this.PreviewUrl = previewUrl;
            this.SignShortUrl = signShortUrl;
            this.SignUrl = signUrl;
        }

        /// <summary>
        /// 预览短链地址（30天有效）
        /// </summary>
        /// <value>预览短链地址（30天有效）</value>
        [DataMember(Name = "preview_short_url", EmitDefaultValue = false)]
        public string PreviewShortUrl { get; set; }

        /// <summary>
        /// 预览长链地址(永久有效)
        /// </summary>
        /// <value>预览长链地址(永久有效)</value>
        [DataMember(Name = "preview_url", EmitDefaultValue = false)]
        public string PreviewUrl { get; set; }

        /// <summary>
        /// 签署短链地址（30天有效）
        /// </summary>
        /// <value>签署短链地址（30天有效）</value>
        [DataMember(Name = "sign_short_url", EmitDefaultValue = false)]
        public string SignShortUrl { get; set; }

        /// <summary>
        /// 签署长链地址(永久有效)
        /// </summary>
        /// <value>签署长链地址(永久有效)</value>
        [DataMember(Name = "sign_url", EmitDefaultValue = false)]
        public string SignUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoSignflowsUrlQueryResponseModel {\n");
            sb.Append("  PreviewShortUrl: ").Append(PreviewShortUrl).Append("\n");
            sb.Append("  PreviewUrl: ").Append(PreviewUrl).Append("\n");
            sb.Append("  SignShortUrl: ").Append(SignShortUrl).Append("\n");
            sb.Append("  SignUrl: ").Append(SignUrl).Append("\n");
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
            return this.Equals(input as AlipayEcoSignflowsUrlQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoSignflowsUrlQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoSignflowsUrlQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoSignflowsUrlQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PreviewShortUrl == input.PreviewShortUrl ||
                    (this.PreviewShortUrl != null &&
                    this.PreviewShortUrl.Equals(input.PreviewShortUrl))
                ) && 
                (
                    this.PreviewUrl == input.PreviewUrl ||
                    (this.PreviewUrl != null &&
                    this.PreviewUrl.Equals(input.PreviewUrl))
                ) && 
                (
                    this.SignShortUrl == input.SignShortUrl ||
                    (this.SignShortUrl != null &&
                    this.SignShortUrl.Equals(input.SignShortUrl))
                ) && 
                (
                    this.SignUrl == input.SignUrl ||
                    (this.SignUrl != null &&
                    this.SignUrl.Equals(input.SignUrl))
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
                if (this.PreviewShortUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PreviewShortUrl.GetHashCode();
                }
                if (this.PreviewUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PreviewUrl.GetHashCode();
                }
                if (this.SignShortUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignShortUrl.GetHashCode();
                }
                if (this.SignUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignUrl.GetHashCode();
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
