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
    /// AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel")]
    public partial class AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel : IEquatable<AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel" /> class.
        /// </summary>
        /// <param name="allowCancel">是否允许取消.</param>
        /// <param name="cancelFee">取消金额.</param>
        public AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel(bool allowCancel = default(bool), string cancelFee = default(string))
        {
            this.AllowCancel = allowCancel;
            this.CancelFee = cancelFee;
        }

        /// <summary>
        /// 是否允许取消
        /// </summary>
        /// <value>是否允许取消</value>
        [DataMember(Name = "allow_cancel", EmitDefaultValue = true)]
        public bool AllowCancel { get; set; }

        /// <summary>
        /// 取消金额
        /// </summary>
        /// <value>取消金额</value>
        [DataMember(Name = "cancel_fee", EmitDefaultValue = false)]
        public string CancelFee { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel {\n");
            sb.Append("  AllowCancel: ").Append(AllowCancel).Append("\n");
            sb.Append("  CancelFee: ").Append(CancelFee).Append("\n");
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
            return this.Equals(input as AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceLogisticsOrderIstdcancelPreconsultResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllowCancel == input.AllowCancel ||
                    this.AllowCancel.Equals(input.AllowCancel)
                ) && 
                (
                    this.CancelFee == input.CancelFee ||
                    (this.CancelFee != null &&
                    this.CancelFee.Equals(input.CancelFee))
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
                hashCode = (hashCode * 59) + this.AllowCancel.GetHashCode();
                if (this.CancelFee != null)
                {
                    hashCode = (hashCode * 59) + this.CancelFee.GetHashCode();
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
