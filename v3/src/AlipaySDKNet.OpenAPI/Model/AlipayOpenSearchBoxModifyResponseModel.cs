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
    /// AlipayOpenSearchBoxModifyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchBoxModifyResponseModel")]
    public partial class AlipayOpenSearchBoxModifyResponseModel : IEquatable<AlipayOpenSearchBoxModifyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchBoxModifyResponseModel" /> class.
        /// </summary>
        /// <param name="moduleId">模块配置ID.</param>
        public AlipayOpenSearchBoxModifyResponseModel(string moduleId = default(string))
        {
            this.ModuleId = moduleId;
        }

        /// <summary>
        /// 模块配置ID
        /// </summary>
        /// <value>模块配置ID</value>
        [DataMember(Name = "module_id", EmitDefaultValue = false)]
        public string ModuleId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchBoxModifyResponseModel {\n");
            sb.Append("  ModuleId: ").Append(ModuleId).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchBoxModifyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchBoxModifyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchBoxModifyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchBoxModifyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ModuleId == input.ModuleId ||
                    (this.ModuleId != null &&
                    this.ModuleId.Equals(input.ModuleId))
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
                if (this.ModuleId != null)
                {
                    hashCode = (hashCode * 59) + this.ModuleId.GetHashCode();
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
