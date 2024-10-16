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
    /// AlipayCommerceEcDepartmentInfoQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcDepartmentInfoQueryResponseModel")]
    public partial class AlipayCommerceEcDepartmentInfoQueryResponseModel : IEquatable<AlipayCommerceEcDepartmentInfoQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcDepartmentInfoQueryResponseModel" /> class.
        /// </summary>
        /// <param name="departmentInfo">departmentInfo.</param>
        public AlipayCommerceEcDepartmentInfoQueryResponseModel(DepartmentInfoDTO departmentInfo = default(DepartmentInfoDTO))
        {
            this.DepartmentInfo = departmentInfo;
        }

        /// <summary>
        /// Gets or Sets DepartmentInfo
        /// </summary>
        [DataMember(Name = "department_info", EmitDefaultValue = false)]
        public DepartmentInfoDTO DepartmentInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcDepartmentInfoQueryResponseModel {\n");
            sb.Append("  DepartmentInfo: ").Append(DepartmentInfo).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcDepartmentInfoQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcDepartmentInfoQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcDepartmentInfoQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcDepartmentInfoQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DepartmentInfo == input.DepartmentInfo ||
                    (this.DepartmentInfo != null &&
                    this.DepartmentInfo.Equals(input.DepartmentInfo))
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
                if (this.DepartmentInfo != null)
                {
                    hashCode = (hashCode * 59) + this.DepartmentInfo.GetHashCode();
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
