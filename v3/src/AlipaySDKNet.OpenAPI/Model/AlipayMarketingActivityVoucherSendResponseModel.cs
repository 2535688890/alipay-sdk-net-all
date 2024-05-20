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
    /// AlipayMarketingActivityVoucherSendResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityVoucherSendResponseModel")]
    public partial class AlipayMarketingActivityVoucherSendResponseModel : IEquatable<AlipayMarketingActivityVoucherSendResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityVoucherSendResponseModel" /> class.
        /// </summary>
        /// <param name="voucherId">本次发放的支付券id.</param>
        public AlipayMarketingActivityVoucherSendResponseModel(string voucherId = default(string))
        {
            this.VoucherId = voucherId;
        }

        /// <summary>
        /// 本次发放的支付券id
        /// </summary>
        /// <value>本次发放的支付券id</value>
        [DataMember(Name = "voucher_id", EmitDefaultValue = false)]
        public string VoucherId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityVoucherSendResponseModel {\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityVoucherSendResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityVoucherSendResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityVoucherSendResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityVoucherSendResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.VoucherId == input.VoucherId ||
                    (this.VoucherId != null &&
                    this.VoucherId.Equals(input.VoucherId))
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
                if (this.VoucherId != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherId.GetHashCode();
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
