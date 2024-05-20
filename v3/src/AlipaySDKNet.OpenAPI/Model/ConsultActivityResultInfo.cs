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
    /// ConsultActivityResultInfo
    /// </summary>
    [DataContract(Name = "ConsultActivityResultInfo")]
    public partial class ConsultActivityResultInfo : IEquatable<ConsultActivityResultInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ConsultActivityResultInfo" /> class.
        /// </summary>
        /// <param name="activityId">活动id.</param>
        /// <param name="consultResultCode">咨询结果码.</param>
        public ConsultActivityResultInfo(string activityId = default(string), string consultResultCode = default(string))
        {
            this.ActivityId = activityId;
            this.ConsultResultCode = consultResultCode;
        }

        /// <summary>
        /// 活动id
        /// </summary>
        /// <value>活动id</value>
        [DataMember(Name = "activity_id", EmitDefaultValue = false)]
        public string ActivityId { get; set; }

        /// <summary>
        /// 咨询结果码
        /// </summary>
        /// <value>咨询结果码</value>
        [DataMember(Name = "consult_result_code", EmitDefaultValue = false)]
        public string ConsultResultCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConsultActivityResultInfo {\n");
            sb.Append("  ActivityId: ").Append(ActivityId).Append("\n");
            sb.Append("  ConsultResultCode: ").Append(ConsultResultCode).Append("\n");
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
            return this.Equals(input as ConsultActivityResultInfo);
        }

        /// <summary>
        /// Returns true if ConsultActivityResultInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ConsultActivityResultInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConsultActivityResultInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActivityId == input.ActivityId ||
                    (this.ActivityId != null &&
                    this.ActivityId.Equals(input.ActivityId))
                ) && 
                (
                    this.ConsultResultCode == input.ConsultResultCode ||
                    (this.ConsultResultCode != null &&
                    this.ConsultResultCode.Equals(input.ConsultResultCode))
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
                if (this.ActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.ActivityId.GetHashCode();
                }
                if (this.ConsultResultCode != null)
                {
                    hashCode = (hashCode * 59) + this.ConsultResultCode.GetHashCode();
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
