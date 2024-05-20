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
    /// ZMGOExtConfig
    /// </summary>
    [DataContract(Name = "ZMGOExtConfig")]
    public partial class ZMGOExtConfig : IEquatable<ZMGOExtConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZMGOExtConfig" /> class.
        /// </summary>
        /// <param name="textContentFillRuleId">文本内容填充规则ID.</param>
        /// <param name="textContentFillVariable">文本内容填充变量，变量key由运营同学提供.</param>
        public ZMGOExtConfig(string textContentFillRuleId = default(string), string textContentFillVariable = default(string))
        {
            this.TextContentFillRuleId = textContentFillRuleId;
            this.TextContentFillVariable = textContentFillVariable;
        }

        /// <summary>
        /// 文本内容填充规则ID
        /// </summary>
        /// <value>文本内容填充规则ID</value>
        [DataMember(Name = "text_content_fill_rule_id", EmitDefaultValue = false)]
        public string TextContentFillRuleId { get; set; }

        /// <summary>
        /// 文本内容填充变量，变量key由运营同学提供
        /// </summary>
        /// <value>文本内容填充变量，变量key由运营同学提供</value>
        [DataMember(Name = "text_content_fill_variable", EmitDefaultValue = false)]
        public string TextContentFillVariable { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZMGOExtConfig {\n");
            sb.Append("  TextContentFillRuleId: ").Append(TextContentFillRuleId).Append("\n");
            sb.Append("  TextContentFillVariable: ").Append(TextContentFillVariable).Append("\n");
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
            return this.Equals(input as ZMGOExtConfig);
        }

        /// <summary>
        /// Returns true if ZMGOExtConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ZMGOExtConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZMGOExtConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TextContentFillRuleId == input.TextContentFillRuleId ||
                    (this.TextContentFillRuleId != null &&
                    this.TextContentFillRuleId.Equals(input.TextContentFillRuleId))
                ) && 
                (
                    this.TextContentFillVariable == input.TextContentFillVariable ||
                    (this.TextContentFillVariable != null &&
                    this.TextContentFillVariable.Equals(input.TextContentFillVariable))
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
                if (this.TextContentFillRuleId != null)
                {
                    hashCode = (hashCode * 59) + this.TextContentFillRuleId.GetHashCode();
                }
                if (this.TextContentFillVariable != null)
                {
                    hashCode = (hashCode * 59) + this.TextContentFillVariable.GetHashCode();
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
