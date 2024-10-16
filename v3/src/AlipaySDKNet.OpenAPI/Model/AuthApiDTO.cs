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
    /// AuthApiDTO
    /// </summary>
    [DataContract(Name = "AuthApiDTO")]
    public partial class AuthApiDTO : IEquatable<AuthApiDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthApiDTO" /> class.
        /// </summary>
        /// <param name="apiName">敏感信息可申请接口名.</param>
        /// <param name="fieldName">敏感信息申请字段.</param>
        /// <param name="packageCode">敏感信息申请能力code值.</param>
        public AuthApiDTO(string apiName = default(string), string fieldName = default(string), string packageCode = default(string))
        {
            this.ApiName = apiName;
            this.FieldName = fieldName;
            this.PackageCode = packageCode;
        }

        /// <summary>
        /// 敏感信息可申请接口名
        /// </summary>
        /// <value>敏感信息可申请接口名</value>
        [DataMember(Name = "api_name", EmitDefaultValue = false)]
        public string ApiName { get; set; }

        /// <summary>
        /// 敏感信息申请字段
        /// </summary>
        /// <value>敏感信息申请字段</value>
        [DataMember(Name = "field_name", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// 敏感信息申请能力code值
        /// </summary>
        /// <value>敏感信息申请能力code值</value>
        [DataMember(Name = "package_code", EmitDefaultValue = false)]
        public string PackageCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthApiDTO {\n");
            sb.Append("  ApiName: ").Append(ApiName).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  PackageCode: ").Append(PackageCode).Append("\n");
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
            return this.Equals(input as AuthApiDTO);
        }

        /// <summary>
        /// Returns true if AuthApiDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthApiDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthApiDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiName == input.ApiName ||
                    (this.ApiName != null &&
                    this.ApiName.Equals(input.ApiName))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.PackageCode == input.PackageCode ||
                    (this.PackageCode != null &&
                    this.PackageCode.Equals(input.PackageCode))
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
                if (this.ApiName != null)
                {
                    hashCode = (hashCode * 59) + this.ApiName.GetHashCode();
                }
                if (this.FieldName != null)
                {
                    hashCode = (hashCode * 59) + this.FieldName.GetHashCode();
                }
                if (this.PackageCode != null)
                {
                    hashCode = (hashCode * 59) + this.PackageCode.GetHashCode();
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
