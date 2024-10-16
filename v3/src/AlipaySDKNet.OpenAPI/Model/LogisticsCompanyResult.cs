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
    /// LogisticsCompanyResult
    /// </summary>
    [DataContract(Name = "LogisticsCompanyResult")]
    public partial class LogisticsCompanyResult : IEquatable<LogisticsCompanyResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LogisticsCompanyResult" /> class.
        /// </summary>
        /// <param name="logisticsCode">物流公司编码.</param>
        /// <param name="logisticsName">物流公司名称.</param>
        public LogisticsCompanyResult(string logisticsCode = default(string), string logisticsName = default(string))
        {
            this.LogisticsCode = logisticsCode;
            this.LogisticsName = logisticsName;
        }

        /// <summary>
        /// 物流公司编码
        /// </summary>
        /// <value>物流公司编码</value>
        [DataMember(Name = "logistics_code", EmitDefaultValue = false)]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        /// <value>物流公司名称</value>
        [DataMember(Name = "logistics_name", EmitDefaultValue = false)]
        public string LogisticsName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LogisticsCompanyResult {\n");
            sb.Append("  LogisticsCode: ").Append(LogisticsCode).Append("\n");
            sb.Append("  LogisticsName: ").Append(LogisticsName).Append("\n");
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
            return this.Equals(input as LogisticsCompanyResult);
        }

        /// <summary>
        /// Returns true if LogisticsCompanyResult instances are equal
        /// </summary>
        /// <param name="input">Instance of LogisticsCompanyResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LogisticsCompanyResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LogisticsCode == input.LogisticsCode ||
                    (this.LogisticsCode != null &&
                    this.LogisticsCode.Equals(input.LogisticsCode))
                ) && 
                (
                    this.LogisticsName == input.LogisticsName ||
                    (this.LogisticsName != null &&
                    this.LogisticsName.Equals(input.LogisticsName))
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
                if (this.LogisticsCode != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsCode.GetHashCode();
                }
                if (this.LogisticsName != null)
                {
                    hashCode = (hashCode * 59) + this.LogisticsName.GetHashCode();
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
