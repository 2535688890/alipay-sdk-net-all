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
    /// AlipayMarketingRecruitPlanlistQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingRecruitPlanlistQueryResponseModel")]
    public partial class AlipayMarketingRecruitPlanlistQueryResponseModel : IEquatable<AlipayMarketingRecruitPlanlistQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingRecruitPlanlistQueryResponseModel" /> class.
        /// </summary>
        /// <param name="data">方案列表.</param>
        /// <param name="pageNum">第几页，默认1（从1开始计数）.</param>
        /// <param name="pageSize">每页记录条数，默认20.</param>
        /// <param name="total">总数.</param>
        public AlipayMarketingRecruitPlanlistQueryResponseModel(List<RecruitPlanLight> data = default(List<RecruitPlanLight>), int pageNum = default(int), int pageSize = default(int), int total = default(int))
        {
            this.Data = data;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.Total = total;
        }

        /// <summary>
        /// 方案列表
        /// </summary>
        /// <value>方案列表</value>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public List<RecruitPlanLight> Data { get; set; }

        /// <summary>
        /// 第几页，默认1（从1开始计数）
        /// </summary>
        /// <value>第几页，默认1（从1开始计数）</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 每页记录条数，默认20
        /// </summary>
        /// <value>每页记录条数，默认20</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        /// <value>总数</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingRecruitPlanlistQueryResponseModel {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
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
            return this.Equals(input as AlipayMarketingRecruitPlanlistQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingRecruitPlanlistQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingRecruitPlanlistQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingRecruitPlanlistQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    this.PageNum.Equals(input.PageNum)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
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
