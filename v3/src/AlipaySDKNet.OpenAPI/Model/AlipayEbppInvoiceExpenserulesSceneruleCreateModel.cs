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
    /// AlipayEbppInvoiceExpenserulesSceneruleCreateModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpenserulesSceneruleCreateModel")]
    public partial class AlipayEbppInvoiceExpenserulesSceneruleCreateModel : IEquatable<AlipayEbppInvoiceExpenserulesSceneruleCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenserulesSceneruleCreateModel" /> class.
        /// </summary>
        /// <param name="accountId">共同账号ID.</param>
        /// <param name="agreementNo">授权签约协议号.</param>
        /// <param name="effectiveEndDate">有效期截止.</param>
        /// <param name="effectiveStartDate">有效期起始.</param>
        /// <param name="employeeList">切换open_id前请使用：员工支付宝uid列表 特殊说明：单次传入的最大员工数为50，后续通过修改费控规则员工接口进行员工调整.</param>
        /// <param name="employeeOpenIdList">切换open_id后请使用：员工open_id/企业码员工ID列表 特殊说明：单次传入的最大员工数为50，后续通过修改费控规则员工接口进行员工调整.</param>
        /// <param name="enterpriseId">企业码企业id.</param>
        /// <param name="expenseCtrlRuleInfoList">费控条件列表 特殊说明： 1）至少存在日额度（QUOTA_DAY）、月额度（QUOTA_MONTH）、有效期总额度（QUOTA_TOTAL）三者中的一个额度条件； 2）如果费用类型为MEAL，费控维度商户（MEAL_MERCHANT）和商户类型（MCC）对应的费控条件必须存在其一且不能同时存在； 3）如果费用类型为METRO，费控维度地铁卡类型（CARD_TYPE）对应的费控条件必须存在； 4）如果因公场景为OVERTIME，费控维度时间段（ALARM_CLOCK_TIME）对应的费控条件必须存在； 5）不能存在重复的费控维度对应的费控条件； 6）非MEAL费用类型，商户仅支持MERCHANT，不支持MEAL_MERCHANT.</param>
        /// <param name="expenseType">费用类型.</param>
        /// <param name="paymentPolicy">当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）.</param>
        /// <param name="sceneType">因公场景.</param>
        /// <param name="standardDesc">费控规则说明 特殊说明：敏感词校验.</param>
        /// <param name="standardName">费控规则名称 特殊说明： 1）敏感词校验 2）不能重复，若需要重复联系支持人员定向放开.</param>
        public AlipayEbppInvoiceExpenserulesSceneruleCreateModel(string accountId = default(string), string agreementNo = default(string), string effectiveEndDate = default(string), string effectiveStartDate = default(string), List<string> employeeList = default(List<string>), List<string> employeeOpenIdList = default(List<string>), string enterpriseId = default(string), List<ExpenseCtrRuleInfo> expenseCtrlRuleInfoList = default(List<ExpenseCtrRuleInfo>), string expenseType = default(string), string paymentPolicy = default(string), string sceneType = default(string), string standardDesc = default(string), string standardName = default(string))
        {
            this.AccountId = accountId;
            this.AgreementNo = agreementNo;
            this.EffectiveEndDate = effectiveEndDate;
            this.EffectiveStartDate = effectiveStartDate;
            this.EmployeeList = employeeList;
            this.EmployeeOpenIdList = employeeOpenIdList;
            this.EnterpriseId = enterpriseId;
            this.ExpenseCtrlRuleInfoList = expenseCtrlRuleInfoList;
            this.ExpenseType = expenseType;
            this.PaymentPolicy = paymentPolicy;
            this.SceneType = sceneType;
            this.StandardDesc = standardDesc;
            this.StandardName = standardName;
        }

        /// <summary>
        /// 共同账号ID
        /// </summary>
        /// <value>共同账号ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 授权签约协议号
        /// </summary>
        /// <value>授权签约协议号</value>
        [DataMember(Name = "agreement_no", EmitDefaultValue = false)]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 有效期截止
        /// </summary>
        /// <value>有效期截止</value>
        [DataMember(Name = "effective_end_date", EmitDefaultValue = false)]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        /// <value>有效期起始</value>
        [DataMember(Name = "effective_start_date", EmitDefaultValue = false)]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 切换open_id前请使用：员工支付宝uid列表 特殊说明：单次传入的最大员工数为50，后续通过修改费控规则员工接口进行员工调整
        /// </summary>
        /// <value>切换open_id前请使用：员工支付宝uid列表 特殊说明：单次传入的最大员工数为50，后续通过修改费控规则员工接口进行员工调整</value>
        [DataMember(Name = "employee_list", EmitDefaultValue = false)]
        public List<string> EmployeeList { get; set; }

        /// <summary>
        /// 切换open_id后请使用：员工open_id/企业码员工ID列表 特殊说明：单次传入的最大员工数为50，后续通过修改费控规则员工接口进行员工调整
        /// </summary>
        /// <value>切换open_id后请使用：员工open_id/企业码员工ID列表 特殊说明：单次传入的最大员工数为50，后续通过修改费控规则员工接口进行员工调整</value>
        [DataMember(Name = "employee_open_id_list", EmitDefaultValue = false)]
        public List<string> EmployeeOpenIdList { get; set; }

        /// <summary>
        /// 企业码企业id
        /// </summary>
        /// <value>企业码企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 费控条件列表 特殊说明： 1）至少存在日额度（QUOTA_DAY）、月额度（QUOTA_MONTH）、有效期总额度（QUOTA_TOTAL）三者中的一个额度条件； 2）如果费用类型为MEAL，费控维度商户（MEAL_MERCHANT）和商户类型（MCC）对应的费控条件必须存在其一且不能同时存在； 3）如果费用类型为METRO，费控维度地铁卡类型（CARD_TYPE）对应的费控条件必须存在； 4）如果因公场景为OVERTIME，费控维度时间段（ALARM_CLOCK_TIME）对应的费控条件必须存在； 5）不能存在重复的费控维度对应的费控条件； 6）非MEAL费用类型，商户仅支持MERCHANT，不支持MEAL_MERCHANT
        /// </summary>
        /// <value>费控条件列表 特殊说明： 1）至少存在日额度（QUOTA_DAY）、月额度（QUOTA_MONTH）、有效期总额度（QUOTA_TOTAL）三者中的一个额度条件； 2）如果费用类型为MEAL，费控维度商户（MEAL_MERCHANT）和商户类型（MCC）对应的费控条件必须存在其一且不能同时存在； 3）如果费用类型为METRO，费控维度地铁卡类型（CARD_TYPE）对应的费控条件必须存在； 4）如果因公场景为OVERTIME，费控维度时间段（ALARM_CLOCK_TIME）对应的费控条件必须存在； 5）不能存在重复的费控维度对应的费控条件； 6）非MEAL费用类型，商户仅支持MERCHANT，不支持MEAL_MERCHANT</value>
        [DataMember(Name = "expense_ctrl_rule_info_list", EmitDefaultValue = false)]
        public List<ExpenseCtrRuleInfo> ExpenseCtrlRuleInfoList { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        /// <value>费用类型</value>
        [DataMember(Name = "expense_type", EmitDefaultValue = false)]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）
        /// </summary>
        /// <value>当笔消费金额大于规则可用余额时，用于控制支付策略，该字段缺省时采取因公账户和个人账户组合支付策略， 枚举值：PERSONAL（全部个人账户支付）, COMBINATION（因公账户和个人账户组合支付）</value>
        [DataMember(Name = "payment_policy", EmitDefaultValue = false)]
        public string PaymentPolicy { get; set; }

        /// <summary>
        /// 因公场景
        /// </summary>
        /// <value>因公场景</value>
        [DataMember(Name = "scene_type", EmitDefaultValue = false)]
        public string SceneType { get; set; }

        /// <summary>
        /// 费控规则说明 特殊说明：敏感词校验
        /// </summary>
        /// <value>费控规则说明 特殊说明：敏感词校验</value>
        [DataMember(Name = "standard_desc", EmitDefaultValue = false)]
        public string StandardDesc { get; set; }

        /// <summary>
        /// 费控规则名称 特殊说明： 1）敏感词校验 2）不能重复，若需要重复联系支持人员定向放开
        /// </summary>
        /// <value>费控规则名称 特殊说明： 1）敏感词校验 2）不能重复，若需要重复联系支持人员定向放开</value>
        [DataMember(Name = "standard_name", EmitDefaultValue = false)]
        public string StandardName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpenserulesSceneruleCreateModel {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  AgreementNo: ").Append(AgreementNo).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  EmployeeList: ").Append(EmployeeList).Append("\n");
            sb.Append("  EmployeeOpenIdList: ").Append(EmployeeOpenIdList).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  ExpenseCtrlRuleInfoList: ").Append(ExpenseCtrlRuleInfoList).Append("\n");
            sb.Append("  ExpenseType: ").Append(ExpenseType).Append("\n");
            sb.Append("  PaymentPolicy: ").Append(PaymentPolicy).Append("\n");
            sb.Append("  SceneType: ").Append(SceneType).Append("\n");
            sb.Append("  StandardDesc: ").Append(StandardDesc).Append("\n");
            sb.Append("  StandardName: ").Append(StandardName).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpenserulesSceneruleCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpenserulesSceneruleCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpenserulesSceneruleCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpenserulesSceneruleCreateModel input)
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
                    this.AgreementNo == input.AgreementNo ||
                    (this.AgreementNo != null &&
                    this.AgreementNo.Equals(input.AgreementNo))
                ) && 
                (
                    this.EffectiveEndDate == input.EffectiveEndDate ||
                    (this.EffectiveEndDate != null &&
                    this.EffectiveEndDate.Equals(input.EffectiveEndDate))
                ) && 
                (
                    this.EffectiveStartDate == input.EffectiveStartDate ||
                    (this.EffectiveStartDate != null &&
                    this.EffectiveStartDate.Equals(input.EffectiveStartDate))
                ) && 
                (
                    this.EmployeeList == input.EmployeeList ||
                    this.EmployeeList != null &&
                    input.EmployeeList != null &&
                    this.EmployeeList.SequenceEqual(input.EmployeeList)
                ) && 
                (
                    this.EmployeeOpenIdList == input.EmployeeOpenIdList ||
                    this.EmployeeOpenIdList != null &&
                    input.EmployeeOpenIdList != null &&
                    this.EmployeeOpenIdList.SequenceEqual(input.EmployeeOpenIdList)
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.ExpenseCtrlRuleInfoList == input.ExpenseCtrlRuleInfoList ||
                    this.ExpenseCtrlRuleInfoList != null &&
                    input.ExpenseCtrlRuleInfoList != null &&
                    this.ExpenseCtrlRuleInfoList.SequenceEqual(input.ExpenseCtrlRuleInfoList)
                ) && 
                (
                    this.ExpenseType == input.ExpenseType ||
                    (this.ExpenseType != null &&
                    this.ExpenseType.Equals(input.ExpenseType))
                ) && 
                (
                    this.PaymentPolicy == input.PaymentPolicy ||
                    (this.PaymentPolicy != null &&
                    this.PaymentPolicy.Equals(input.PaymentPolicy))
                ) && 
                (
                    this.SceneType == input.SceneType ||
                    (this.SceneType != null &&
                    this.SceneType.Equals(input.SceneType))
                ) && 
                (
                    this.StandardDesc == input.StandardDesc ||
                    (this.StandardDesc != null &&
                    this.StandardDesc.Equals(input.StandardDesc))
                ) && 
                (
                    this.StandardName == input.StandardName ||
                    (this.StandardName != null &&
                    this.StandardName.Equals(input.StandardName))
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
                if (this.AgreementNo != null)
                {
                    hashCode = (hashCode * 59) + this.AgreementNo.GetHashCode();
                }
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.EffectiveStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveStartDate.GetHashCode();
                }
                if (this.EmployeeList != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeList.GetHashCode();
                }
                if (this.EmployeeOpenIdList != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeOpenIdList.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.ExpenseCtrlRuleInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseCtrlRuleInfoList.GetHashCode();
                }
                if (this.ExpenseType != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseType.GetHashCode();
                }
                if (this.PaymentPolicy != null)
                {
                    hashCode = (hashCode * 59) + this.PaymentPolicy.GetHashCode();
                }
                if (this.SceneType != null)
                {
                    hashCode = (hashCode * 59) + this.SceneType.GetHashCode();
                }
                if (this.StandardDesc != null)
                {
                    hashCode = (hashCode * 59) + this.StandardDesc.GetHashCode();
                }
                if (this.StandardName != null)
                {
                    hashCode = (hashCode * 59) + this.StandardName.GetHashCode();
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
