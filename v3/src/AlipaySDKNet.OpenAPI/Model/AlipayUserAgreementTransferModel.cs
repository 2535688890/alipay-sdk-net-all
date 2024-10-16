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
    /// AlipayUserAgreementTransferModel
    /// </summary>
    [DataContract(Name = "AlipayUserAgreementTransferModel")]
    public partial class AlipayUserAgreementTransferModel : IEquatable<AlipayUserAgreementTransferModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayUserAgreementTransferModel" /> class.
        /// </summary>
        /// <param name="agreementNo">支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ），如果传了该参数，其他参数会被忽略.</param>
        /// <param name="periodRuleParams">periodRuleParams.</param>
        /// <param name="targetProductCode">协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。这里指的是需要修改目标产品码的值.</param>
        public AlipayUserAgreementTransferModel(string agreementNo = default(string), PeriodRuleParams periodRuleParams = default(PeriodRuleParams), string targetProductCode = default(string))
        {
            this.AgreementNo = agreementNo;
            this.PeriodRuleParams = periodRuleParams;
            this.TargetProductCode = targetProductCode;
        }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ），如果传了该参数，其他参数会被忽略
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ），如果传了该参数，其他参数会被忽略</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// Gets or Sets PeriodRuleParams
        /// </summary>
        [DataMember(Name = "period_rule_params", EmitDefaultValue = false)]
        public PeriodRuleParams PeriodRuleParams { get; set; }

        /// <summary>
        /// 协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。这里指的是需要修改目标产品码的值
        /// </summary>
        /// <value>协议产品码，商户和支付宝签约时确定，不同业务场景对应不同的签约产品码。这里指的是需要修改目标产品码的值</value>
        [DataMember(Name = "target_product_code", EmitDefaultValue = false)]
        public string TargetProductCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayUserAgreementTransferModel {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  PeriodRuleParams: ").Append(PeriodRuleParams).Append("\n");
            sb.Append("  TargetProductCode: ").Append(TargetProductCode).Append("\n");
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
            return this.Equals(input as AlipayUserAgreementTransferModel);
        }

        /// <summary>
        /// Returns true if AlipayUserAgreementTransferModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayUserAgreementTransferModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayUserAgreementTransferModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.PeriodRuleParams == input.PeriodRuleParams ||
                    (this.PeriodRuleParams != null &&
                    this.PeriodRuleParams.Equals(input.PeriodRuleParams))
                ) && 
                (
                    this.TargetProductCode == input.TargetProductCode ||
                    (this.TargetProductCode != null &&
                    this.TargetProductCode.Equals(input.TargetProductCode))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.PeriodRuleParams != null)
                {
                    hashCode = (hashCode * 59) + this.PeriodRuleParams.GetHashCode();
                }
                if (this.TargetProductCode != null)
                {
                    hashCode = (hashCode * 59) + this.TargetProductCode.GetHashCode();
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
