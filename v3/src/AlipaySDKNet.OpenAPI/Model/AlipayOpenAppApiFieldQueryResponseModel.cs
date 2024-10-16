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
    /// AlipayOpenAppApiFieldQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppApiFieldQueryResponseModel")]
    public partial class AlipayOpenAppApiFieldQueryResponseModel : IEquatable<AlipayOpenAppApiFieldQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppApiFieldQueryResponseModel" /> class.
        /// </summary>
        /// <param name="authFieldResponse">authFieldResponse.</param>
        public AlipayOpenAppApiFieldQueryResponseModel(AuthFieldResponse authFieldResponse = default(AuthFieldResponse))
        {
            this.AuthFieldResponse = authFieldResponse;
        }

        /// <summary>
        /// Gets or Sets AuthFieldResponse
        /// </summary>
        [DataMember(Name = "auth_field_response", EmitDefaultValue = false)]
        public AuthFieldResponse AuthFieldResponse { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppApiFieldQueryResponseModel {\n");
            sb.Append("  AuthFieldResponse: ").Append(AuthFieldResponse).Append("\n");
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
            return this.Equals(input as AlipayOpenAppApiFieldQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppApiFieldQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppApiFieldQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppApiFieldQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AuthFieldResponse == input.AuthFieldResponse ||
                    (this.AuthFieldResponse != null &&
                    this.AuthFieldResponse.Equals(input.AuthFieldResponse))
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
                if (this.AuthFieldResponse != null)
                {
                    hashCode = (hashCode * 59) + this.AuthFieldResponse.GetHashCode();
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
