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
    /// ZhimaCreditPayafteruseCreditbizorderOrderResponseModel
    /// </summary>
    [DataContract(Name = "ZhimaCreditPayafteruseCreditbizorderOrderResponseModel")]
    public partial class ZhimaCreditPayafteruseCreditbizorderOrderResponseModel : IEquatable<ZhimaCreditPayafteruseCreditbizorderOrderResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZhimaCreditPayafteruseCreditbizorderOrderResponseModel" /> class.
        /// </summary>
        /// <param name="creditBizOrderId">信用服务订单号.</param>
        /// <param name="outOrderNo">商户传入的外部订单号.</param>
        public ZhimaCreditPayafteruseCreditbizorderOrderResponseModel(string creditBizOrderId = default(string), string outOrderNo = default(string))
        {
            this.CreditBizOrderId = creditBizOrderId;
            this.OutOrderNo = outOrderNo;
        }

        /// <summary>
        /// 信用服务订单号
        /// </summary>
        /// <value>信用服务订单号</value>
        [DataMember(Name = "credit_biz_order_id", EmitDefaultValue = false)]
        public string CreditBizOrderId { get; set; }

        /// <summary>
        /// 商户传入的外部订单号
        /// </summary>
        /// <value>商户传入的外部订单号</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZhimaCreditPayafteruseCreditbizorderOrderResponseModel {\n");
            sb.Append("  CreditBizOrderId: ").Append(CreditBizOrderId).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
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
            return this.Equals(input as ZhimaCreditPayafteruseCreditbizorderOrderResponseModel);
        }

        /// <summary>
        /// Returns true if ZhimaCreditPayafteruseCreditbizorderOrderResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZhimaCreditPayafteruseCreditbizorderOrderResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZhimaCreditPayafteruseCreditbizorderOrderResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreditBizOrderId == input.CreditBizOrderId ||
                    (this.CreditBizOrderId != null &&
                    this.CreditBizOrderId.Equals(input.CreditBizOrderId))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
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
                if (this.CreditBizOrderId != null)
                {
                    hashCode = (hashCode * 59) + this.CreditBizOrderId.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
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
