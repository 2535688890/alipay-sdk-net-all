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
    /// AlipayCommerceCityfacilitatorVoucherGenerateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceCityfacilitatorVoucherGenerateResponseModel")]
    public partial class AlipayCommerceCityfacilitatorVoucherGenerateResponseModel : IEquatable<AlipayCommerceCityfacilitatorVoucherGenerateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceCityfacilitatorVoucherGenerateResponseModel" /> class.
        /// </summary>
        /// <param name="expiredDate">核销码过期时间.</param>
        /// <param name="qrCodeNo">地铁购票二维码编码，可自定义.</param>
        /// <param name="ticketNo">地铁购票的核销码.</param>
        public AlipayCommerceCityfacilitatorVoucherGenerateResponseModel(string expiredDate = default(string), string qrCodeNo = default(string), string ticketNo = default(string))
        {
            this.ExpiredDate = expiredDate;
            this.QrCodeNo = qrCodeNo;
            this.TicketNo = ticketNo;
        }

        /// <summary>
        /// 核销码过期时间
        /// </summary>
        /// <value>核销码过期时间</value>
        [DataMember(Name = "expired_date", EmitDefaultValue = false)]
        public string ExpiredDate { get; set; }

        /// <summary>
        /// 地铁购票二维码编码，可自定义
        /// </summary>
        /// <value>地铁购票二维码编码，可自定义</value>
        [DataMember(Name = "qr_code_no", EmitDefaultValue = false)]
        public string QrCodeNo { get; set; }

        /// <summary>
        /// 地铁购票的核销码
        /// </summary>
        /// <value>地铁购票的核销码</value>
        [DataMember(Name = "ticket_no", EmitDefaultValue = false)]
        public string TicketNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceCityfacilitatorVoucherGenerateResponseModel {\n");
            sb.Append("  ExpiredDate: ").Append(ExpiredDate).Append("\n");
            sb.Append("  QrCodeNo: ").Append(QrCodeNo).Append("\n");
            sb.Append("  TicketNo: ").Append(TicketNo).Append("\n");
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
            return this.Equals(input as AlipayCommerceCityfacilitatorVoucherGenerateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceCityfacilitatorVoucherGenerateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceCityfacilitatorVoucherGenerateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceCityfacilitatorVoucherGenerateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ExpiredDate == input.ExpiredDate ||
                    (this.ExpiredDate != null &&
                    this.ExpiredDate.Equals(input.ExpiredDate))
                ) && 
                (
                    this.QrCodeNo == input.QrCodeNo ||
                    (this.QrCodeNo != null &&
                    this.QrCodeNo.Equals(input.QrCodeNo))
                ) && 
                (
                    this.TicketNo == input.TicketNo ||
                    (this.TicketNo != null &&
                    this.TicketNo.Equals(input.TicketNo))
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
                if (this.ExpiredDate != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiredDate.GetHashCode();
                }
                if (this.QrCodeNo != null)
                {
                    hashCode = (hashCode * 59) + this.QrCodeNo.GetHashCode();
                }
                if (this.TicketNo != null)
                {
                    hashCode = (hashCode * 59) + this.TicketNo.GetHashCode();
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
