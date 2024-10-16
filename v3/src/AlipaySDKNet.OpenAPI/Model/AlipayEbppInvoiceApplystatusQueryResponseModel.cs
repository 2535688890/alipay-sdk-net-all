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
    /// AlipayEbppInvoiceApplystatusQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceApplystatusQueryResponseModel")]
    public partial class AlipayEbppInvoiceApplystatusQueryResponseModel : IEquatable<AlipayEbppInvoiceApplystatusQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplystatusQueryResponseModel" /> class.
        /// </summary>
        /// <param name="applyStatusBriefDtos">每笔交易开票状态.</param>
        public AlipayEbppInvoiceApplystatusQueryResponseModel(List<OrderApplyStatusBriefDTO> applyStatusBriefDtos = default(List<OrderApplyStatusBriefDTO>))
        {
            this.ApplyStatusBriefDtos = applyStatusBriefDtos;
        }

        /// <summary>
        /// 每笔交易开票状态
        /// </summary>
        /// <value>每笔交易开票状态</value>
        [DataMember(Name = "apply_status_brief_dtos", EmitDefaultValue = false)]
        public List<OrderApplyStatusBriefDTO> ApplyStatusBriefDtos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceApplystatusQueryResponseModel {\n");
            sb.Append("  ApplyStatusBriefDtos: ").Append(ApplyStatusBriefDtos).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceApplystatusQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceApplystatusQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceApplystatusQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceApplystatusQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyStatusBriefDtos == input.ApplyStatusBriefDtos ||
                    this.ApplyStatusBriefDtos != null &&
                    input.ApplyStatusBriefDtos != null &&
                    this.ApplyStatusBriefDtos.SequenceEqual(input.ApplyStatusBriefDtos)
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
                if (this.ApplyStatusBriefDtos != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyStatusBriefDtos.GetHashCode();
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
