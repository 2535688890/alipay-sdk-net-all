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
    /// AlipayOpenPublicAccountQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicAccountQueryResponseModel")]
    public partial class AlipayOpenPublicAccountQueryResponseModel : IEquatable<AlipayOpenPublicAccountQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAccountQueryResponseModel" /> class.
        /// </summary>
        /// <param name="publicBindAccounts">绑定账户列表.</param>
        public AlipayOpenPublicAccountQueryResponseModel(List<StdPublicBindAccount> publicBindAccounts = default(List<StdPublicBindAccount>))
        {
            this.PublicBindAccounts = publicBindAccounts;
        }

        /// <summary>
        /// 绑定账户列表
        /// </summary>
        /// <value>绑定账户列表</value>
        [DataMember(Name = "public_bind_accounts", EmitDefaultValue = false)]
        public List<StdPublicBindAccount> PublicBindAccounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicAccountQueryResponseModel {\n");
            sb.Append("  PublicBindAccounts: ").Append(PublicBindAccounts).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicAccountQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicAccountQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicAccountQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicAccountQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PublicBindAccounts == input.PublicBindAccounts ||
                    this.PublicBindAccounts != null &&
                    input.PublicBindAccounts != null &&
                    this.PublicBindAccounts.SequenceEqual(input.PublicBindAccounts)
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
                if (this.PublicBindAccounts != null)
                {
                    hashCode = (hashCode * 59) + this.PublicBindAccounts.GetHashCode();
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
