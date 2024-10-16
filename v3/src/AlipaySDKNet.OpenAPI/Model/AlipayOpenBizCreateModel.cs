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
    /// AlipayOpenBizCreateModel
    /// </summary>
    [DataContract(Name = "AlipayOpenBizCreateModel")]
    public partial class AlipayOpenBizCreateModel : IEquatable<AlipayOpenBizCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenBizCreateModel" /> class.
        /// </summary>
        /// <param name="a">a.</param>
        /// <param name="b">1.</param>
        /// <param name="de">de.</param>
        /// <param name="stringbuff">1.</param>
        public AlipayOpenBizCreateModel(Gavintest a = default(Gavintest), string b = default(string), GavintestNewLeveaOne de = default(GavintestNewLeveaOne), string stringbuff = default(string))
        {
            this.A = a;
            this.B = b;
            this.De = de;
            this.Stringbuff = stringbuff;
        }

        /// <summary>
        /// Gets or Sets A
        /// </summary>
        [DataMember(Name = "a", EmitDefaultValue = false)]
        public Gavintest A { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "b", EmitDefaultValue = false)]
        public string B { get; set; }

        /// <summary>
        /// Gets or Sets De
        /// </summary>
        [DataMember(Name = "de", EmitDefaultValue = false)]
        public GavintestNewLeveaOne De { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        /// <value>1</value>
        [DataMember(Name = "stringbuff", EmitDefaultValue = false)]
        public string Stringbuff { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenBizCreateModel {\n");
            sb.Append("  A: ").Append(A).Append("\n");
            sb.Append("  B: ").Append(B).Append("\n");
            sb.Append("  De: ").Append(De).Append("\n");
            sb.Append("  Stringbuff: ").Append(Stringbuff).Append("\n");
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
            return this.Equals(input as AlipayOpenBizCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenBizCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenBizCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenBizCreateModel input)
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
                    this.De == input.De ||
                    (this.De != null &&
                    this.De.Equals(input.De))
                ) && 
                (
                    this.Stringbuff == input.Stringbuff ||
                    (this.Stringbuff != null &&
                    this.Stringbuff.Equals(input.Stringbuff))
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
                if (this.De != null)
                {
                    hashCode = (hashCode * 59) + this.De.GetHashCode();
                }
                if (this.Stringbuff != null)
                {
                    hashCode = (hashCode * 59) + this.Stringbuff.GetHashCode();
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
