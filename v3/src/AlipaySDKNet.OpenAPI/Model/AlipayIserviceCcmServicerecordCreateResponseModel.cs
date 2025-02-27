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
    /// AlipayIserviceCcmServicerecordCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmServicerecordCreateResponseModel")]
    public partial class AlipayIserviceCcmServicerecordCreateResponseModel : IEquatable<AlipayIserviceCcmServicerecordCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmServicerecordCreateResponseModel" /> class.
        /// </summary>
        /// <param name="serviceRecordId">服务记录ID.</param>
        public AlipayIserviceCcmServicerecordCreateResponseModel(string serviceRecordId = default(string))
        {
            this.ServiceRecordId = serviceRecordId;
        }

        /// <summary>
        /// 服务记录ID
        /// </summary>
        /// <value>服务记录ID</value>
        [DataMember(Name = "service_record_id", EmitDefaultValue = false)]
        public string ServiceRecordId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmServicerecordCreateResponseModel {\n");
            sb.Append("  ServiceRecordId: ").Append(ServiceRecordId).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmServicerecordCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmServicerecordCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmServicerecordCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmServicerecordCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServiceRecordId == input.ServiceRecordId ||
                    (this.ServiceRecordId != null &&
                    this.ServiceRecordId.Equals(input.ServiceRecordId))
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
                if (this.ServiceRecordId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceRecordId.GetHashCode();
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
