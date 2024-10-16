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
    /// AlipayBossFncInvoicereceiptBatchqueryModel
    /// </summary>
    [DataContract(Name = "AlipayBossFncInvoicereceiptBatchqueryModel")]
    public partial class AlipayBossFncInvoicereceiptBatchqueryModel : IEquatable<AlipayBossFncInvoicereceiptBatchqueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayBossFncInvoicereceiptBatchqueryModel" /> class.
        /// </summary>
        /// <param name="billNos">月账单号集合，唯一性ID集合，月账单表唯一主键ID集合.</param>
        /// <param name="outBizType">来源类型，01：主站；02：芝麻；03：金融云；04：微贷.</param>
        public AlipayBossFncInvoicereceiptBatchqueryModel(List<string> billNos = default(List<string>), string outBizType = default(string))
        {
            this.BillNos = billNos;
            this.OutBizType = outBizType;
        }

        /// <summary>
        /// 月账单号集合，唯一性ID集合，月账单表唯一主键ID集合
        /// </summary>
        /// <value>月账单号集合，唯一性ID集合，月账单表唯一主键ID集合</value>
        [DataMember(Name = "bill_nos", EmitDefaultValue = false)]
        public List<string> BillNos { get; set; }

        /// <summary>
        /// 来源类型，01：主站；02：芝麻；03：金融云；04：微贷
        /// </summary>
        /// <value>来源类型，01：主站；02：芝麻；03：金融云；04：微贷</value>
        [DataMember(Name = "out_biz_type", EmitDefaultValue = false)]
        public string OutBizType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayBossFncInvoicereceiptBatchqueryModel {\n");
            sb.Append("  BillNos: ").Append(BillNos).Append("\n");
            sb.Append("  OutBizType: ").Append(OutBizType).Append("\n");
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
            return this.Equals(input as AlipayBossFncInvoicereceiptBatchqueryModel);
        }

        /// <summary>
        /// Returns true if AlipayBossFncInvoicereceiptBatchqueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayBossFncInvoicereceiptBatchqueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayBossFncInvoicereceiptBatchqueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BillNos == input.BillNos ||
                    this.BillNos != null &&
                    input.BillNos != null &&
                    this.BillNos.SequenceEqual(input.BillNos)
                ) && 
                (
                    this.OutBizType == input.OutBizType ||
                    (this.OutBizType != null &&
                    this.OutBizType.Equals(input.OutBizType))
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
                if (this.BillNos != null)
                {
                    hashCode = (hashCode * 59) + this.BillNos.GetHashCode();
                }
                if (this.OutBizType != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizType.GetHashCode();
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
