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
    /// AlipayEbppInvoiceExpensecontrolQuotaModifyModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpensecontrolQuotaModifyModel")]
    public partial class AlipayEbppInvoiceExpensecontrolQuotaModifyModel : IEquatable<AlipayEbppInvoiceExpensecontrolQuotaModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpensecontrolQuotaModifyModel" /> class.
        /// </summary>
        /// <param name="accountId">企业共同账户ID.</param>
        /// <param name="action">变更模式.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="amount">变更的金额/余额，以（分）为单位，当变更的资产类型为次卡时，当前的单位为次.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="outerSourceId">外部操作幂等ID（接入方接口调用幂等控制ID）.</param>
        /// <param name="platform">外部平台编码.</param>
        /// <param name="quotaId">额度ID.</param>
        /// <param name="shareMode">是否可转赠，1表示可转赠，0表示不可转赠.</param>
        public AlipayEbppInvoiceExpensecontrolQuotaModifyModel(string accountId = default(string), string action = default(string), string agreementNo = default(string), string amount = default(string), string enterpriseId = default(string), string outerSourceId = default(string), string platform = default(string), string quotaId = default(string), string shareMode = default(string))
        {
            this.AccountId = accountId;
            this.Action = action;
            this.AgreementNo = agreementNo;
            this.Amount = amount;
            this.EnterpriseId = enterpriseId;
            this.OuterSourceId = outerSourceId;
            this.Platform = platform;
            this.QuotaId = quotaId;
            this.ShareMode = shareMode;
        }

        /// <summary>
        /// 企业共同账户ID
        /// </summary>
        /// <value>企业共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 变更模式
        /// </summary>
        /// <value>变更模式</value>
        [DataMember(Name = "action", EmitDefaultValue = false)]
        public string Action { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 变更的金额/余额，以（分）为单位，当变更的资产类型为次卡时，当前的单位为次
        /// </summary>
        /// <value>变更的金额/余额，以（分）为单位，当变更的资产类型为次卡时，当前的单位为次</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 外部操作幂等ID（接入方接口调用幂等控制ID）
        /// </summary>
        /// <value>外部操作幂等ID（接入方接口调用幂等控制ID）</value>
        [DataMember(Name = "outer_source_id", EmitDefaultValue = false)]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 外部平台编码
        /// </summary>
        /// <value>外部平台编码</value>
        [DataMember(Name = "platform", EmitDefaultValue = false)]
        public string Platform { get; set; }

        /// <summary>
        /// 额度ID
        /// </summary>
        /// <value>额度ID</value>
        [DataMember(Name = "quota_id", EmitDefaultValue = false)]
        public string QuotaId { get; set; }

        /// <summary>
        /// 是否可转赠，1表示可转赠，0表示不可转赠
        /// </summary>
        /// <value>是否可转赠，1表示可转赠，0表示不可转赠</value>
        [DataMember(Name = "share_mode", EmitDefaultValue = false)]
        public string ShareMode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpensecontrolQuotaModifyModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  OuterSourceId: ").Append(OuterSourceId).Append("\n");
            sb.Append("  Platform: ").Append(Platform).Append("\n");
            sb.Append("  QuotaId: ").Append(QuotaId).Append("\n");
            sb.Append("  ShareMode: ").Append(ShareMode).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpensecontrolQuotaModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpensecontrolQuotaModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpensecontrolQuotaModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpensecontrolQuotaModifyModel input)
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
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.OuterSourceId == input.OuterSourceId ||
                    (this.OuterSourceId != null &&
                    this.OuterSourceId.Equals(input.OuterSourceId))
                ) && 
                (
                    this.Platform == input.Platform ||
                    (this.Platform != null &&
                    this.Platform.Equals(input.Platform))
                ) && 
                (
                    this.QuotaId == input.QuotaId ||
                    (this.QuotaId != null &&
                    this.QuotaId.Equals(input.QuotaId))
                ) && 
                (
                    this.ShareMode == input.ShareMode ||
                    (this.ShareMode != null &&
                    this.ShareMode.Equals(input.ShareMode))
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
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.OuterSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OuterSourceId.GetHashCode();
                }
                if (this.Platform != null)
                {
                    hashCode = (hashCode * 59) + this.Platform.GetHashCode();
                }
                if (this.QuotaId != null)
                {
                    hashCode = (hashCode * 59) + this.QuotaId.GetHashCode();
                }
                if (this.ShareMode != null)
                {
                    hashCode = (hashCode * 59) + this.ShareMode.GetHashCode();
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
