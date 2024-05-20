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
    /// AgreementParams
    /// </summary>
    [DataContract(Name = "AgreementParams")]
    public partial class AgreementParams : IEquatable<AgreementParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AgreementParams" /> class.
        /// </summary>
        /// <param name="agreementNo">支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）.</param>
        /// <param name="applyToken">鉴权申请token，其格式和内容，由支付宝定义。在需要做支付鉴权校验时，该参数不能为空。.</param>
        /// <param name="authConfirmNo">鉴权确认码，在需要做支付鉴权校验时，该参数不能为空.</param>
        /// <param name="deductPermission">商户代扣扣款许可.</param>
        public AgreementParams(string agreementNo = default(string), string applyToken = default(string), string authConfirmNo = default(string), string deductPermission = default(string))
        {
            this.AgreementNo = agreementNo;
            this.ApplyToken = applyToken;
            this.AuthConfirmNo = authConfirmNo;
            this.DeductPermission = deductPermission;
        }

        /// <summary>
        /// 支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）
        /// </summary>
        /// <value>支付宝系统中用以唯一标识用户签约记录的编号（用户签约成功后的协议号 ）</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 鉴权申请token，其格式和内容，由支付宝定义。在需要做支付鉴权校验时，该参数不能为空。
        /// </summary>
        /// <value>鉴权申请token，其格式和内容，由支付宝定义。在需要做支付鉴权校验时，该参数不能为空。</value>
        [DataMember(Name = "apply_token", EmitDefaultValue = false)]
        public string ApplyToken { get; set; }

        /// <summary>
        /// 鉴权确认码，在需要做支付鉴权校验时，该参数不能为空
        /// </summary>
        /// <value>鉴权确认码，在需要做支付鉴权校验时，该参数不能为空</value>
        [DataMember(Name = "auth_confirm_no", EmitDefaultValue = false)]
        public string AuthConfirmNo { get; set; }

        /// <summary>
        /// 商户代扣扣款许可
        /// </summary>
        /// <value>商户代扣扣款许可</value>
        [DataMember(Name = "deduct_permission", EmitDefaultValue = false)]
        public string DeductPermission { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AgreementParams {\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  ApplyToken: ").Append(ApplyToken).Append("\n");
            sb.Append("  AuthConfirmNo: ").Append(AuthConfirmNo).Append("\n");
            sb.Append("  DeductPermission: ").Append(DeductPermission).Append("\n");
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
            return this.Equals(input as AgreementParams);
        }

        /// <summary>
        /// Returns true if AgreementParams instances are equal
        /// </summary>
        /// <param name="input">Instance of AgreementParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AgreementParams input)
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
                    this.ApplyToken == input.ApplyToken ||
                    (this.ApplyToken != null &&
                    this.ApplyToken.Equals(input.ApplyToken))
                ) && 
                (
                    this.AuthConfirmNo == input.AuthConfirmNo ||
                    (this.AuthConfirmNo != null &&
                    this.AuthConfirmNo.Equals(input.AuthConfirmNo))
                ) && 
                (
                    this.DeductPermission == input.DeductPermission ||
                    (this.DeductPermission != null &&
                    this.DeductPermission.Equals(input.DeductPermission))
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
                if (this.ApplyToken != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyToken.GetHashCode();
                }
                if (this.AuthConfirmNo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthConfirmNo.GetHashCode();
                }
                if (this.DeductPermission != null)
                {
                    hashCode = (hashCode * 59) + this.DeductPermission.GetHashCode();
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
