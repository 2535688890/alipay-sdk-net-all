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
    /// AlipayCommerceEcEnterpriseInfoModifyModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEnterpriseInfoModifyModel")]
    public partial class AlipayCommerceEcEnterpriseInfoModifyModel : IEquatable<AlipayCommerceEcEnterpriseInfoModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEnterpriseInfoModifyModel" /> class.
        /// </summary>
        /// <param name="enterpriseAlias">企业简称.</param>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="enterpriseName">企业名称.</param>
        public AlipayCommerceEcEnterpriseInfoModifyModel(string enterpriseAlias = default(string), string enterpriseId = default(string), string enterpriseName = default(string))
        {
            this.EnterpriseAlias = enterpriseAlias;
            this.EnterpriseId = enterpriseId;
            this.EnterpriseName = enterpriseName;
        }

        /// <summary>
        /// 企业简称
        /// </summary>
        /// <value>企业简称</value>
        [DataMember(Name = "enterprise_alias", EmitDefaultValue = false)]
        public string EnterpriseAlias { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 企业名称
        /// </summary>
        /// <value>企业名称</value>
        [DataMember(Name = "enterprise_name", EmitDefaultValue = false)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEnterpriseInfoModifyModel {\n");
            sb.Append("  EnterpriseAlias: ").Append(EnterpriseAlias).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  EnterpriseName: ").Append(EnterpriseName).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEnterpriseInfoModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEnterpriseInfoModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEnterpriseInfoModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEnterpriseInfoModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnterpriseAlias == input.EnterpriseAlias ||
                    (this.EnterpriseAlias != null &&
                    this.EnterpriseAlias.Equals(input.EnterpriseAlias))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.EnterpriseName == input.EnterpriseName ||
                    (this.EnterpriseName != null &&
                    this.EnterpriseName.Equals(input.EnterpriseName))
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
                if (this.EnterpriseAlias != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseAlias.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.EnterpriseName != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseName.GetHashCode();
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
