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
    /// AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel")]
    public partial class AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel : IEquatable<AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel" /> class.
        /// </summary>
        /// <param name="pageNum">当前页数.</param>
        /// <param name="pageSize">当前记录数.</param>
        /// <param name="standardRuleInfoList">费控规则列表.</param>
        /// <param name="totalPageCount">总页数.</param>
        public AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel(int pageNum = default(int), int pageSize = default(int), List<StandardRuleInfo> standardRuleInfoList = default(List<StandardRuleInfo>), int totalPageCount = default(int))
        {
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.StandardRuleInfoList = standardRuleInfoList;
            this.TotalPageCount = totalPageCount;
        }

        /// <summary>
        /// 当前页数
        /// </summary>
        /// <value>当前页数</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 当前记录数
        /// </summary>
        /// <value>当前记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 费控规则列表
        /// </summary>
        /// <value>费控规则列表</value>
        [DataMember(Name = "standard_rule_info_list", EmitDefaultValue = false)]
        public List<StandardRuleInfo> StandardRuleInfoList { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <value>总页数</value>
        [DataMember(Name = "total_page_count", EmitDefaultValue = false)]
        public int TotalPageCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel {\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  StandardRuleInfoList: ").Append(StandardRuleInfoList).Append("\n");
            sb.Append("  TotalPageCount: ").Append(TotalPageCount).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceExpenserulesSceneruleQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.StandardRuleInfoList == input.StandardRuleInfoList ||
                    this.StandardRuleInfoList != null &&
                    input.StandardRuleInfoList != null &&
                    this.StandardRuleInfoList.SequenceEqual(input.StandardRuleInfoList)
                ) && 
                (
                    this.TotalPageCount == input.TotalPageCount ||
                    this.TotalPageCount.Equals(input.TotalPageCount)
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
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.StandardRuleInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.StandardRuleInfoList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalPageCount.GetHashCode();
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
