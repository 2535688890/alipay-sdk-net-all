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
    /// AlipayFundTransPayeeBindQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundTransPayeeBindQueryResponseModel")]
    public partial class AlipayFundTransPayeeBindQueryResponseModel : IEquatable<AlipayFundTransPayeeBindQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundTransPayeeBindQueryResponseModel" /> class.
        /// </summary>
        /// <param name="bind">是否绑定收款账号。true：已绑定；false：未绑定.</param>
        public AlipayFundTransPayeeBindQueryResponseModel(string bind = default(string))
        {
            this.Bind = bind;
        }

        /// <summary>
        /// 是否绑定收款账号。true：已绑定；false：未绑定
        /// </summary>
        /// <value>是否绑定收款账号。true：已绑定；false：未绑定</value>
        [DataMember(Name = "bind", EmitDefaultValue = false)]
        public string Bind { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundTransPayeeBindQueryResponseModel {\n");
            sb.Append("  Bind: ").Append(Bind).Append("\n");
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
            return this.Equals(input as AlipayFundTransPayeeBindQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundTransPayeeBindQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundTransPayeeBindQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundTransPayeeBindQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Bind == input.Bind ||
                    (this.Bind != null &&
                    this.Bind.Equals(input.Bind))
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
                if (this.Bind != null)
                {
                    hashCode = (hashCode * 59) + this.Bind.GetHashCode();
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
