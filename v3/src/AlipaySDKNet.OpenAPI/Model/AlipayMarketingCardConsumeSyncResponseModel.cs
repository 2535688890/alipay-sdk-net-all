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
    /// AlipayMarketingCardConsumeSyncResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardConsumeSyncResponseModel")]
    public partial class AlipayMarketingCardConsumeSyncResponseModel : IEquatable<AlipayMarketingCardConsumeSyncResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardConsumeSyncResponseModel" /> class.
        /// </summary>
        /// <param name="externalCardNo">外部卡号.</param>
        public AlipayMarketingCardConsumeSyncResponseModel(string externalCardNo = default(string))
        {
            this.ExternalCardNo = externalCardNo;
        }

        /// <summary>
        /// 外部卡号
        /// </summary>
        /// <value>外部卡号</value>
        [DataMember(Name = "external_card_no", EmitDefaultValue = false)]
        public string ExternalCardNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardConsumeSyncResponseModel {\n");
            sb.Append("  ExternalCardNo: ").Append(ExternalCardNo).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardConsumeSyncResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardConsumeSyncResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardConsumeSyncResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardConsumeSyncResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExternalCardNo == input.ExternalCardNo ||
                    (this.ExternalCardNo != null &&
                    this.ExternalCardNo.Equals(input.ExternalCardNo))
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
                if (this.ExternalCardNo != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalCardNo.GetHashCode();
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
