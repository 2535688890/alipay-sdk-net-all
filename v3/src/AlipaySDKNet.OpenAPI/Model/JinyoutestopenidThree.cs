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
    /// JinyoutestopenidThree
    /// </summary>
    [DataContract(Name = "JinyoutestopenidThree")]
    public partial class JinyoutestopenidThree : IEquatable<JinyoutestopenidThree>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JinyoutestopenidThree" /> class.
        /// </summary>
        /// <param name="a">12.</param>
        /// <param name="b">有openid,无枚举，有注意事项.</param>
        /// <param name="bOpenId">有openid,无枚举，有注意事项.</param>
        /// <param name="f">f.</param>
        public JinyoutestopenidThree(string a = default(string), string b = default(string), string bOpenId = default(string), JinyoutestopenidTwo f = default(JinyoutestopenidTwo))
        {
            this.A = a;
            this.B = b;
            this.BOpenId = bOpenId;
            this.F = f;
        }

        /// <summary>
        /// 12
        /// </summary>
        /// <value>12</value>
        [DataMember(Name = "a", EmitDefaultValue = false)]
        public string A { get; set; }

        /// <summary>
        /// 有openid,无枚举，有注意事项
        /// </summary>
        /// <value>有openid,无枚举，有注意事项</value>
        [DataMember(Name = "b", EmitDefaultValue = false)]
        public string B { get; set; }

        /// <summary>
        /// 有openid,无枚举，有注意事项
        /// </summary>
        /// <value>有openid,无枚举，有注意事项</value>
        [DataMember(Name = "b_open_id", EmitDefaultValue = false)]
        public string BOpenId { get; set; }

        /// <summary>
        /// Gets or Sets F
        /// </summary>
        [DataMember(Name = "f", EmitDefaultValue = false)]
        public JinyoutestopenidTwo F { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JinyoutestopenidThree {\n");
            sb.Append("  A: ").Append(A).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            sb.Append("  BOpenId: ").Append(BOpenId).Append("\n");
            sb.Append("  F: ").Append(F).Append("\n");
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
            return this.Equals(input as JinyoutestopenidThree);
        }

        /// <summary>
        /// Returns true if JinyoutestopenidThree instances are equal
        /// </summary>
        /// <param name="input">Instance of JinyoutestopenidThree to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JinyoutestopenidThree input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.A == input.A ||
                    (this.A != null &&
                    this.A.Equals(input.A))
                ) && 
                (
                    this.B == input.B ||
                    (this.B != null &&
                    this.B.Equals(input.B))
                ) && 
                (
                    this.BOpenId == input.BOpenId ||
                    (this.BOpenId != null &&
                    this.BOpenId.Equals(input.BOpenId))
                ) && 
                (
                    this.F == input.F ||
                    (this.F != null &&
                    this.F.Equals(input.F))
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
                if (this.A != null)
                {
                    hashCode = (hashCode * 59) + this.A.GetHashCode();
                }
                if (this.B != null)
                {
                    hashCode = (hashCode * 59) + this.B.GetHashCode();
                }
                if (this.BOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.BOpenId.GetHashCode();
                }
                if (this.F != null)
                {
                    hashCode = (hashCode * 59) + this.F.GetHashCode();
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
