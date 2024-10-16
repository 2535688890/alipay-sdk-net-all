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
    /// AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel")]
    public partial class AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel : IEquatable<AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel" /> class.
        /// </summary>
        /// <param name="adapterType">若适用范围为EMPLOYEE_ALL，则表示制度对企业下全员生效，owner_id_list不返回；若适配范围为EMPLOYEE_SELECT，owner_id_list返回员工对应的id信息，返回的id类型通过owner_type区分；若适配范围为EMPLOYEE_DEPARTMENT，则表示对指定的部门生效，返回owner_id_list为部门id列表.</param>
        /// <param name="consultMode">费控咨询模式.</param>
        /// <param name="effective">制度启用停用状态.</param>
        /// <param name="effectiveEndDate">制度生效结束时间.</param>
        /// <param name="effectiveStartDate">制度生效起始时间.</param>
        /// <param name="expenseType">费用类型.</param>
        /// <param name="institutionDesc">制度描述.</param>
        /// <param name="institutionId">制度id.</param>
        /// <param name="institutionName">制度名称.</param>
        /// <param name="issueRuleInfoList">发放规则信息列表.</param>
        /// <param name="outerSourceId">外部唯一标识.</param>
        /// <param name="ownerIdList">适配id列表.</param>
        /// <param name="ownerOpenIdList">适配开放id列表.</param>
        /// <param name="ownerType">适配id类型.</param>
        /// <param name="sceneType">因公场景.</param>
        /// <param name="standardInfoDetailList">使用规则列表.</param>
        /// <param name="standardInfoList">standardInfoList.</param>
        public AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel(string adapterType = default(string), string consultMode = default(string), string effective = default(string), string effectiveEndDate = default(string), string effectiveStartDate = default(string), string expenseType = default(string), string institutionDesc = default(string), string institutionId = default(string), string institutionName = default(string), List<IssueRuleInfo> issueRuleInfoList = default(List<IssueRuleInfo>), string outerSourceId = default(string), List<string> ownerIdList = default(List<string>), List<string> ownerOpenIdList = default(List<string>), string ownerType = default(string), string sceneType = default(string), List<StandardInfo> standardInfoDetailList = default(List<StandardInfo>), StandardInfo standardInfoList = default(StandardInfo))
        {
            this.AdapterType = adapterType;
            this.ConsultMode = consultMode;
            this.Effective = effective;
            this.EffectiveEndDate = effectiveEndDate;
            this.EffectiveStartDate = effectiveStartDate;
            this.ExpenseType = expenseType;
            this.InstitutionDesc = institutionDesc;
            this.InstitutionId = institutionId;
            this.InstitutionName = institutionName;
            this.IssueRuleInfoList = issueRuleInfoList;
            this.OuterSourceId = outerSourceId;
            this.OwnerIdList = ownerIdList;
            this.OwnerOpenIdList = ownerOpenIdList;
            this.OwnerType = ownerType;
            this.SceneType = sceneType;
            this.StandardInfoDetailList = standardInfoDetailList;
            this.StandardInfoList = standardInfoList;
        }

        /// <summary>
        /// 若适用范围为EMPLOYEE_ALL，则表示制度对企业下全员生效，owner_id_list不返回；若适配范围为EMPLOYEE_SELECT，owner_id_list返回员工对应的id信息，返回的id类型通过owner_type区分；若适配范围为EMPLOYEE_DEPARTMENT，则表示对指定的部门生效，返回owner_id_list为部门id列表
        /// </summary>
        /// <value>若适用范围为EMPLOYEE_ALL，则表示制度对企业下全员生效，owner_id_list不返回；若适配范围为EMPLOYEE_SELECT，owner_id_list返回员工对应的id信息，返回的id类型通过owner_type区分；若适配范围为EMPLOYEE_DEPARTMENT，则表示对指定的部门生效，返回owner_id_list为部门id列表</value>
        [DataMember(Name = "adapter_type", EmitDefaultValue = false)]
        public string AdapterType { get; set; }

        /// <summary>
        /// 费控咨询模式
        /// </summary>
        /// <value>费控咨询模式</value>
        [DataMember(Name = "consult_mode", EmitDefaultValue = false)]
        public string ConsultMode { get; set; }

        /// <summary>
        /// 制度启用停用状态
        /// </summary>
        /// <value>制度启用停用状态</value>
        [DataMember(Name = "effective", EmitDefaultValue = false)]
        public string Effective { get; set; }

        /// <summary>
        /// 制度生效结束时间
        /// </summary>
        /// <value>制度生效结束时间</value>
        [DataMember(Name = "effective_end_date", EmitDefaultValue = false)]
        public string EffectiveEndDate { get; set; }

        /// <summary>
        /// 制度生效起始时间
        /// </summary>
        /// <value>制度生效起始时间</value>
        [DataMember(Name = "effective_start_date", EmitDefaultValue = false)]
        public string EffectiveStartDate { get; set; }

        /// <summary>
        /// 费用类型
        /// </summary>
        /// <value>费用类型</value>
        [DataMember(Name = "expense_type", EmitDefaultValue = false)]
        public string ExpenseType { get; set; }

        /// <summary>
        /// 制度描述
        /// </summary>
        /// <value>制度描述</value>
        [DataMember(Name = "institution_desc", EmitDefaultValue = false)]
        public string InstitutionDesc { get; set; }

        /// <summary>
        /// 制度id
        /// </summary>
        /// <value>制度id</value>
        [DataMember(Name = "institution_id", EmitDefaultValue = false)]
        public string InstitutionId { get; set; }

        /// <summary>
        /// 制度名称
        /// </summary>
        /// <value>制度名称</value>
        [DataMember(Name = "institution_name", EmitDefaultValue = false)]
        public string InstitutionName { get; set; }

        /// <summary>
        /// 发放规则信息列表
        /// </summary>
        /// <value>发放规则信息列表</value>
        [DataMember(Name = "issue_rule_info_list", EmitDefaultValue = false)]
        public List<IssueRuleInfo> IssueRuleInfoList { get; set; }

        /// <summary>
        /// 外部唯一标识
        /// </summary>
        /// <value>外部唯一标识</value>
        [DataMember(Name = "outer_source_id", EmitDefaultValue = false)]
        public string OuterSourceId { get; set; }

        /// <summary>
        /// 适配id列表
        /// </summary>
        /// <value>适配id列表</value>
        [DataMember(Name = "owner_id_list", EmitDefaultValue = false)]
        public List<string> OwnerIdList { get; set; }

        /// <summary>
        /// 适配开放id列表
        /// </summary>
        /// <value>适配开放id列表</value>
        [DataMember(Name = "owner_open_id_list", EmitDefaultValue = false)]
        public List<string> OwnerOpenIdList { get; set; }

        /// <summary>
        /// 适配id类型
        /// </summary>
        /// <value>适配id类型</value>
        [DataMember(Name = "owner_type", EmitDefaultValue = false)]
        public string OwnerType { get; set; }

        /// <summary>
        /// 因公场景
        /// </summary>
        /// <value>因公场景</value>
        [DataMember(Name = "scene_type", EmitDefaultValue = false)]
        public string SceneType { get; set; }

        /// <summary>
        /// 使用规则列表
        /// </summary>
        /// <value>使用规则列表</value>
        [DataMember(Name = "standard_info_detail_list", EmitDefaultValue = false)]
        public List<StandardInfo> StandardInfoDetailList { get; set; }

        /// <summary>
        /// Gets or Sets StandardInfoList
        /// </summary>
        [DataMember(Name = "standard_info_list", EmitDefaultValue = false)]
        public StandardInfo StandardInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel {\n");
            sb.Append("  AdapterType: ").Append(AdapterType).Append("\n");
            sb.Append("  ConsultMode: ").Append(ConsultMode).Append("\n");
            sb.Append("  Effective: ").Append(Effective).Append("\n");
            sb.Append("  EffectiveEndDate: ").Append(EffectiveEndDate).Append("\n");
            sb.Append("  EffectiveStartDate: ").Append(EffectiveStartDate).Append("\n");
            sb.Append("  ExpenseType: ").Append(ExpenseType).Append("\n");
            sb.Append("  InstitutionDesc: ").Append(InstitutionDesc).Append("\n");
            sb.Append("  InstitutionId: ").Append(InstitutionId).Append("\n");
            sb.Append("  InstitutionName: ").Append(InstitutionName).Append("\n");
            sb.Append("  IssueRuleInfoList: ").Append(IssueRuleInfoList).Append("\n");
            sb.Append("  OuterSourceId: ").Append(OuterSourceId).Append("\n");
            sb.Append("  OwnerIdList: ").Append(OwnerIdList).Append("\n");
            sb.Append("  OwnerOpenIdList: ").Append(OwnerOpenIdList).Append("\n");
            sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
            sb.Append("  SceneType: ").Append(SceneType).Append("\n");
            sb.Append("  StandardInfoDetailList: ").Append(StandardInfoDetailList).Append("\n");
            sb.Append("  StandardInfoList: ").Append(StandardInfoList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceInstitutionDetailinfoQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdapterType == input.AdapterType ||
                    (this.AdapterType != null &&
                    this.AdapterType.Equals(input.AdapterType))
                ) && 
                (
                    this.ConsultMode == input.ConsultMode ||
                    (this.ConsultMode != null &&
                    this.ConsultMode.Equals(input.ConsultMode))
                ) && 
                (
                    this.Effective == input.Effective ||
                    (this.Effective != null &&
                    this.Effective.Equals(input.Effective))
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
                    this.ExpenseType == input.ExpenseType ||
                    (this.ExpenseType != null &&
                    this.ExpenseType.Equals(input.ExpenseType))
                ) && 
                (
                    this.InstitutionDesc == input.InstitutionDesc ||
                    (this.InstitutionDesc != null &&
                    this.InstitutionDesc.Equals(input.InstitutionDesc))
                ) && 
                (
                    this.InstitutionId == input.InstitutionId ||
                    (this.InstitutionId != null &&
                    this.InstitutionId.Equals(input.InstitutionId))
                ) && 
                (
                    this.InstitutionName == input.InstitutionName ||
                    (this.InstitutionName != null &&
                    this.InstitutionName.Equals(input.InstitutionName))
                ) && 
                (
                    this.IssueRuleInfoList == input.IssueRuleInfoList ||
                    this.IssueRuleInfoList != null &&
                    input.IssueRuleInfoList != null &&
                    this.IssueRuleInfoList.SequenceEqual(input.IssueRuleInfoList)
                ) && 
                (
                    this.OuterSourceId == input.OuterSourceId ||
                    (this.OuterSourceId != null &&
                    this.OuterSourceId.Equals(input.OuterSourceId))
                ) && 
                (
                    this.OwnerIdList == input.OwnerIdList ||
                    this.OwnerIdList != null &&
                    input.OwnerIdList != null &&
                    this.OwnerIdList.SequenceEqual(input.OwnerIdList)
                ) && 
                (
                    this.OwnerOpenIdList == input.OwnerOpenIdList ||
                    this.OwnerOpenIdList != null &&
                    input.OwnerOpenIdList != null &&
                    this.OwnerOpenIdList.SequenceEqual(input.OwnerOpenIdList)
                ) && 
                (
                    this.OwnerType == input.OwnerType ||
                    (this.OwnerType != null &&
                    this.OwnerType.Equals(input.OwnerType))
                ) && 
                (
                    this.SceneType == input.SceneType ||
                    (this.SceneType != null &&
                    this.SceneType.Equals(input.SceneType))
                ) && 
                (
                    this.StandardInfoDetailList == input.StandardInfoDetailList ||
                    this.StandardInfoDetailList != null &&
                    input.StandardInfoDetailList != null &&
                    this.StandardInfoDetailList.SequenceEqual(input.StandardInfoDetailList)
                ) && 
                (
                    this.StandardInfoList == input.StandardInfoList ||
                    (this.StandardInfoList != null &&
                    this.StandardInfoList.Equals(input.StandardInfoList))
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
                if (this.AdapterType != null)
                {
                    hashCode = (hashCode * 59) + this.AdapterType.GetHashCode();
                }
                if (this.ConsultMode != null)
                {
                    hashCode = (hashCode * 59) + this.ConsultMode.GetHashCode();
                }
                if (this.Effective != null)
                {
                    hashCode = (hashCode * 59) + this.Effective.GetHashCode();
                }
                if (this.EffectiveEndDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveEndDate.GetHashCode();
                }
                if (this.EffectiveStartDate != null)
                {
                    hashCode = (hashCode * 59) + this.EffectiveStartDate.GetHashCode();
                }
                if (this.ExpenseType != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseType.GetHashCode();
                }
                if (this.InstitutionDesc != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionDesc.GetHashCode();
                }
                if (this.InstitutionId != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionId.GetHashCode();
                }
                if (this.InstitutionName != null)
                {
                    hashCode = (hashCode * 59) + this.InstitutionName.GetHashCode();
                }
                if (this.IssueRuleInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.IssueRuleInfoList.GetHashCode();
                }
                if (this.OuterSourceId != null)
                {
                    hashCode = (hashCode * 59) + this.OuterSourceId.GetHashCode();
                }
                if (this.OwnerIdList != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerIdList.GetHashCode();
                }
                if (this.OwnerOpenIdList != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerOpenIdList.GetHashCode();
                }
                if (this.OwnerType != null)
                {
                    hashCode = (hashCode * 59) + this.OwnerType.GetHashCode();
                }
                if (this.SceneType != null)
                {
                    hashCode = (hashCode * 59) + this.SceneType.GetHashCode();
                }
                if (this.StandardInfoDetailList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardInfoDetailList.GetHashCode();
                }
                if (this.StandardInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardInfoList.GetHashCode();
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
