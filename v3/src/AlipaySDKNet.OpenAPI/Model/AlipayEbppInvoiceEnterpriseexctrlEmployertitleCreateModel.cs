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
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel")]
    public partial class AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel : IEquatable<AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel" /> class.
        /// </summary>
        /// <param name="accountId">企业共同账户id.</param>
        /// <param name="address">企业地址.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="bankAccount">开户行账号.</param>
        /// <param name="bankName">开户行名称.</param>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="taxRegisterNo">税号.</param>
        /// <param name="telephone">电话.</param>
        /// <param name="titleName">企业抬头名称.</param>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel(string accountId = default(string), string address = default(string), string agreementNo = default(string), string bankAccount = default(string), string bankName = default(string), string enterpriseId = default(string), string taxRegisterNo = default(string), string telephone = default(string), string titleName = default(string))
        {
            this.AccountId = accountId;
            this.Address = address;
            this.AgreementNo = agreementNo;
            this.BankAccount = bankAccount;
            this.BankName = bankName;
            this.EnterpriseId = enterpriseId;
            this.TaxRegisterNo = taxRegisterNo;
            this.Telephone = telephone;
            this.TitleName = titleName;
        }

        /// <summary>
        /// 企业共同账户id
        /// </summary>
        /// <value>企业共同账户id</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 企业地址
        /// </summary>
        /// <value>企业地址</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 开户行账号
        /// </summary>
        /// <value>开户行账号</value>
        [DataMember(Name = "bank_account", EmitDefaultValue = false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行名称
        /// </summary>
        /// <value>开户行名称</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 税号
        /// </summary>
        /// <value>税号</value>
        [DataMember(Name = "tax_register_no", EmitDefaultValue = false)]
        public string TaxRegisterNo { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        /// <value>电话</value>
        [DataMember(Name = "telephone", EmitDefaultValue = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// 企业抬头名称
        /// </summary>
        /// <value>企业抬头名称</value>
        [DataMember(Name = "title_name", EmitDefaultValue = false)]
        public string TitleName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  TaxRegisterNo: ").Append(TaxRegisterNo).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  TitleName: ").Append(TitleName).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseexctrlEmployertitleCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.TaxRegisterNo == input.TaxRegisterNo ||
                    (this.TaxRegisterNo != null &&
                    this.TaxRegisterNo.Equals(input.TaxRegisterNo))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.TitleName == input.TitleName ||
                    (this.TitleName != null &&
                    this.TitleName.Equals(input.TitleName))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.TaxRegisterNo != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRegisterNo.GetHashCode();
                }
                if (this.Telephone != null)
                {
                    hashCode = (hashCode * 59) + this.Telephone.GetHashCode();
                }
                if (this.TitleName != null)
                {
                    hashCode = (hashCode * 59) + this.TitleName.GetHashCode();
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
