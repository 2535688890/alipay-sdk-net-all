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
    /// AlipayCommerceIotDeviceReportUploadModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceIotDeviceReportUploadModel")]
    public partial class AlipayCommerceIotDeviceReportUploadModel : IEquatable<AlipayCommerceIotDeviceReportUploadModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceIotDeviceReportUploadModel" /> class.
        /// </summary>
        /// <param name="reportContent">设备检测报告详情.</param>
        /// <param name="sn">设备唯一标识.</param>
        public AlipayCommerceIotDeviceReportUploadModel(string reportContent = default(string), string sn = default(string))
        {
            this.ReportContent = reportContent;
            this.Sn = sn;
        }

        /// <summary>
        /// 设备检测报告详情
        /// </summary>
        /// <value>设备检测报告详情</value>
        [DataMember(Name = "report_content", EmitDefaultValue = false)]
        public string ReportContent { get; set; }

        /// <summary>
        /// 设备唯一标识
        /// </summary>
        /// <value>设备唯一标识</value>
        [DataMember(Name = "sn", EmitDefaultValue = false)]
        public string Sn { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceIotDeviceReportUploadModel {\n");
            sb.Append("  ReportContent: ").Append(ReportContent).Append("\n");
            sb.Append("  Sn: ").Append(Sn).Append("\n");
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
            return this.Equals(input as AlipayCommerceIotDeviceReportUploadModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceIotDeviceReportUploadModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceIotDeviceReportUploadModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceIotDeviceReportUploadModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReportContent == input.ReportContent ||
                    (this.ReportContent != null &&
                    this.ReportContent.Equals(input.ReportContent))
                ) && 
                (
                    this.Sn == input.Sn ||
                    (this.Sn != null &&
                    this.Sn.Equals(input.Sn))
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
                if (this.ReportContent != null)
                {
                    hashCode = (hashCode * 59) + this.ReportContent.GetHashCode();
                }
                if (this.Sn != null)
                {
                    hashCode = (hashCode * 59) + this.Sn.GetHashCode();
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
