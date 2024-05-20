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
    /// AlipayOpenSearchBaseorderModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchBaseorderModifyModel")]
    public partial class AlipayOpenSearchBaseorderModifyModel : IEquatable<AlipayOpenSearchBaseorderModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchBaseorderModifyModel" /> class.
        /// </summary>
        /// <param name="bizData">bizData.</param>
        /// <param name="bizType">表示修改内容的业务类型.</param>
        /// <param name="optType">操作的具体类型.</param>
        public AlipayOpenSearchBaseorderModifyModel(SearchBaseOrderCreateApiRequest bizData = default(SearchBaseOrderCreateApiRequest), string bizType = default(string), string optType = default(string))
        {
            this.BizData = bizData;
            this.BizType = bizType;
            this.OptType = optType;
        }

        /// <summary>
        /// Gets or Sets BizData
        /// </summary>
        [DataMember(Name = "biz_data", EmitDefaultValue = false)]
        public SearchBaseOrderCreateApiRequest BizData { get; set; }

        /// <summary>
        /// 表示修改内容的业务类型
        /// </summary>
        /// <value>表示修改内容的业务类型</value>
        [DataMember(Name = "biz_type", EmitDefaultValue = false)]
        public string BizType { get; set; }

        /// <summary>
        /// 操作的具体类型
        /// </summary>
        /// <value>操作的具体类型</value>
        [DataMember(Name = "opt_type", EmitDefaultValue = false)]
        public string OptType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchBaseorderModifyModel {\n");
            sb.Append("  BizData: ").Append(BizData).Append("\n");
            sb.Append("  BizType: ").Append(BizType).Append("\n");
            sb.Append("  OptType: ").Append(OptType).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchBaseorderModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchBaseorderModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchBaseorderModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchBaseorderModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizData == input.BizData ||
                    (this.BizData != null &&
                    this.BizData.Equals(input.BizData))
                ) && 
                (
                    this.BizType == input.BizType ||
                    (this.BizType != null &&
                    this.BizType.Equals(input.BizType))
                ) && 
                (
                    this.OptType == input.OptType ||
                    (this.OptType != null &&
                    this.OptType.Equals(input.OptType))
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
                if (this.BizData != null)
                {
                    hashCode = (hashCode * 59) + this.BizData.GetHashCode();
                }
                if (this.BizType != null)
                {
                    hashCode = (hashCode * 59) + this.BizType.GetHashCode();
                }
                if (this.OptType != null)
                {
                    hashCode = (hashCode * 59) + this.OptType.GetHashCode();
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
