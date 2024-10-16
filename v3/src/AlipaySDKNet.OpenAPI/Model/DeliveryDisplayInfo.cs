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
    /// DeliveryDisplayInfo
    /// </summary>
    [DataContract(Name = "DeliveryDisplayInfo")]
    public partial class DeliveryDisplayInfo : IEquatable<DeliveryDisplayInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryDisplayInfo" /> class.
        /// </summary>
        /// <param name="mainTitle">副标题。.</param>
        /// <param name="subTitle">副标题.</param>
        public DeliveryDisplayInfo(string mainTitle = default(string), string subTitle = default(string))
        {
            this.MainTitle = mainTitle;
            this.SubTitle = subTitle;
        }

        /// <summary>
        /// 副标题。
        /// </summary>
        /// <value>副标题。</value>
        [DataMember(Name = "main_title", EmitDefaultValue = false)]
        public string MainTitle { get; set; }

        /// <summary>
        /// 副标题
        /// </summary>
        /// <value>副标题</value>
        [DataMember(Name = "sub_title", EmitDefaultValue = false)]
        public string SubTitle { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryDisplayInfo {\n");
            sb.Append("  MainTitle: ").Append(MainTitle).Append("\n");
            sb.Append("  SubTitle: ").Append(SubTitle).Append("\n");
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
            return this.Equals(input as DeliveryDisplayInfo);
        }

        /// <summary>
        /// Returns true if DeliveryDisplayInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryDisplayInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryDisplayInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MainTitle == input.MainTitle ||
                    (this.MainTitle != null &&
                    this.MainTitle.Equals(input.MainTitle))
                ) && 
                (
                    this.SubTitle == input.SubTitle ||
                    (this.SubTitle != null &&
                    this.SubTitle.Equals(input.SubTitle))
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
                if (this.MainTitle != null)
                {
                    hashCode = (hashCode * 59) + this.MainTitle.GetHashCode();
                }
                if (this.SubTitle != null)
                {
                    hashCode = (hashCode * 59) + this.SubTitle.GetHashCode();
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
