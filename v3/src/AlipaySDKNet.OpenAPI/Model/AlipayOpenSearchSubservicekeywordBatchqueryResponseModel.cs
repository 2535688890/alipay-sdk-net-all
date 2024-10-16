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
    /// AlipayOpenSearchSubservicekeywordBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchSubservicekeywordBatchqueryResponseModel")]
    public partial class AlipayOpenSearchSubservicekeywordBatchqueryResponseModel : IEquatable<AlipayOpenSearchSubservicekeywordBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchSubservicekeywordBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="pageNumber">第几页.</param>
        /// <param name="pageSize">每页条数.</param>
        /// <param name="subserviceKeywordInfo">关键词明细.</param>
        /// <param name="totalCount">总条数.</param>
        /// <param name="totalPageCount">总页数.</param>
        public AlipayOpenSearchSubservicekeywordBatchqueryResponseModel(int pageNumber = default(int), int pageSize = default(int), List<SubServiceKeyWordInfo> subserviceKeywordInfo = default(List<SubServiceKeyWordInfo>), int totalCount = default(int), int totalPageCount = default(int))
        {
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.SubserviceKeywordInfo = subserviceKeywordInfo;
            this.TotalCount = totalCount;
            this.TotalPageCount = totalPageCount;
        }

        /// <summary>
        /// 第几页
        /// </summary>
        /// <value>第几页</value>
        [DataMember(Name = "page_number", EmitDefaultValue = false)]
        public int PageNumber { get; set; }

        /// <summary>
        /// 每页条数
        /// </summary>
        /// <value>每页条数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 关键词明细
        /// </summary>
        /// <value>关键词明细</value>
        [DataMember(Name = "subservice_keyword_info", EmitDefaultValue = false)]
        public List<SubServiceKeyWordInfo> SubserviceKeywordInfo { get; set; }

        /// <summary>
        /// 总条数
        /// </summary>
        /// <value>总条数</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

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
            sb.Append("class AlipayOpenSearchSubservicekeywordBatchqueryResponseModel {\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  SubserviceKeywordInfo: ").Append(SubserviceKeywordInfo).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchSubservicekeywordBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchSubservicekeywordBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchSubservicekeywordBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchSubservicekeywordBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageNumber == input.PageNumber ||
                    this.PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.SubserviceKeywordInfo == input.SubserviceKeywordInfo ||
                    this.SubserviceKeywordInfo != null &&
                    input.SubserviceKeywordInfo != null &&
                    this.SubserviceKeywordInfo.SequenceEqual(input.SubserviceKeywordInfo)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
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
                hashCode = (hashCode * 59) + this.PageNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.SubserviceKeywordInfo != null)
                {
                    hashCode = (hashCode * 59) + this.SubserviceKeywordInfo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
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
