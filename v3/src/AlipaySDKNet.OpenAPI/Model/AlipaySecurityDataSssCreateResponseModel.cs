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
    /// AlipaySecurityDataSssCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipaySecurityDataSssCreateResponseModel")]
    public partial class AlipaySecurityDataSssCreateResponseModel : IEquatable<AlipaySecurityDataSssCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipaySecurityDataSssCreateResponseModel" /> class.
        /// </summary>
        /// <param name="c">区.</param>
        /// <param name="cOpenId">区.</param>
        public AlipaySecurityDataSssCreateResponseModel(string c = default(string), string cOpenId = default(string))
        {
            this.C = c;
            this.COpenId = cOpenId;
        }

        /// <summary>
        /// 区
        /// </summary>
        /// <value>区</value>
        [DataMember(Name = "c", EmitDefaultValue = false)]
        public string C { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        /// <value>区</value>
        [DataMember(Name = "c_open_id", EmitDefaultValue = false)]
        public string COpenId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipaySecurityDataSssCreateResponseModel {\n");
            sb.Append("  C: ").Append(C).Append("\n");
            sb.Append("  COpenId: ").Append(COpenId).Append("\n");
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
            return this.Equals(input as AlipaySecurityDataSssCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipaySecurityDataSssCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipaySecurityDataSssCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipaySecurityDataSssCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.C == input.C ||
                    (this.C != null &&
                    this.C.Equals(input.C))
                ) && 
                (
                    this.COpenId == input.COpenId ||
                    (this.COpenId != null &&
                    this.COpenId.Equals(input.COpenId))
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
                if (this.C != null)
                {
                    hashCode = (hashCode * 59) + this.C.GetHashCode();
                }
                if (this.COpenId != null)
                {
                    hashCode = (hashCode * 59) + this.COpenId.GetHashCode();
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
