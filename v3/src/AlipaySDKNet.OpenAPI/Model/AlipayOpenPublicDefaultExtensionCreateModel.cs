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
    /// AlipayOpenPublicDefaultExtensionCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicDefaultExtensionCreateModel")]
    public partial class AlipayOpenPublicDefaultExtensionCreateModel : IEquatable<AlipayOpenPublicDefaultExtensionCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicDefaultExtensionCreateModel" /> class.
        /// </summary>
        /// <param name="areas">默认扩展区列表，最多包含3个扩展区.</param>
        public AlipayOpenPublicDefaultExtensionCreateModel(List<ExtensionArea> areas = default(List<ExtensionArea>))
        {
            this.Areas = areas;
        }

        /// <summary>
        /// 默认扩展区列表，最多包含3个扩展区
        /// </summary>
        /// <value>默认扩展区列表，最多包含3个扩展区</value>
        [DataMember(Name = "areas", EmitDefaultValue = false)]
        public List<ExtensionArea> Areas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicDefaultExtensionCreateModel {\n");
            sb.Append("  Areas: ").Append(Areas).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicDefaultExtensionCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicDefaultExtensionCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicDefaultExtensionCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicDefaultExtensionCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Areas == input.Areas ||
                    this.Areas != null &&
                    input.Areas != null &&
                    this.Areas.SequenceEqual(input.Areas)
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
                if (this.Areas != null)
                {
                    hashCode = (hashCode * 59) + this.Areas.GetHashCode();
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
