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
    /// AlipayMarketingActivityUserBatchqueryvoucherResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityUserBatchqueryvoucherResponseModel")]
    public partial class AlipayMarketingActivityUserBatchqueryvoucherResponseModel : IEquatable<AlipayMarketingActivityUserBatchqueryvoucherResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityUserBatchqueryvoucherResponseModel" /> class.
        /// </summary>
        /// <param name="pageNum">分页查询页码.</param>
        /// <param name="pageSize">分页查询单页数据条数.</param>
        /// <param name="totalSize">总数量.</param>
        /// <param name="userVoucherInfos">用户券实例.</param>
        public AlipayMarketingActivityUserBatchqueryvoucherResponseModel(int pageNum = default(int), int pageSize = default(int), int totalSize = default(int), List<UserVoucherInfo> userVoucherInfos = default(List<UserVoucherInfo>))
        {
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
            this.UserVoucherInfos = userVoucherInfos;
        }

        /// <summary>
        /// 分页查询页码
        /// </summary>
        /// <value>分页查询页码</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页查询单页数据条数
        /// </summary>
        /// <value>分页查询单页数据条数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 总数量
        /// </summary>
        /// <value>总数量</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public int TotalSize { get; set; }

        /// <summary>
        /// 用户券实例
        /// </summary>
        /// <value>用户券实例</value>
        [DataMember(Name = "user_voucher_infos", EmitDefaultValue = false)]
        public List<UserVoucherInfo> UserVoucherInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityUserBatchqueryvoucherResponseModel {\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  UserVoucherInfos: ").Append(UserVoucherInfos).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityUserBatchqueryvoucherResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityUserBatchqueryvoucherResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityUserBatchqueryvoucherResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityUserBatchqueryvoucherResponseModel input)
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
                    this.TotalSize == input.TotalSize ||
                    this.TotalSize.Equals(input.TotalSize)
                ) && 
                (
                    this.UserVoucherInfos == input.UserVoucherInfos ||
                    this.UserVoucherInfos != null &&
                    input.UserVoucherInfos != null &&
                    this.UserVoucherInfos.SequenceEqual(input.UserVoucherInfos)
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
                hashCode = (hashCode * 59) + this.TotalSize.GetHashCode();
                if (this.UserVoucherInfos != null)
                {
                    hashCode = (hashCode * 59) + this.UserVoucherInfos.GetHashCode();
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
