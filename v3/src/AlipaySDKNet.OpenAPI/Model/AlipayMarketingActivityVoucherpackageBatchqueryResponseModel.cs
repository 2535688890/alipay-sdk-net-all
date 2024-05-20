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
    /// AlipayMarketingActivityVoucherpackageBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityVoucherpackageBatchqueryResponseModel")]
    public partial class AlipayMarketingActivityVoucherpackageBatchqueryResponseModel : IEquatable<AlipayMarketingActivityVoucherpackageBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityVoucherpackageBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="pageNum">分页参数，当前所在的页码.</param>
        /// <param name="pageSize">分页参数，每页记录数，最大不可超过30.</param>
        /// <param name="totalSize">券包总数量.</param>
        /// <param name="voucherPackageInfo">券包信息.</param>
        public AlipayMarketingActivityVoucherpackageBatchqueryResponseModel(int pageNum = default(int), int pageSize = default(int), int totalSize = default(int), List<VoucherPackageInfo> voucherPackageInfo = default(List<VoucherPackageInfo>))
        {
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalSize = totalSize;
            this.VoucherPackageInfo = voucherPackageInfo;
        }

        /// <summary>
        /// 分页参数，当前所在的页码
        /// </summary>
        /// <value>分页参数，当前所在的页码</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 分页参数，每页记录数，最大不可超过30
        /// </summary>
        /// <value>分页参数，每页记录数，最大不可超过30</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 券包总数量
        /// </summary>
        /// <value>券包总数量</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public int TotalSize { get; set; }

        /// <summary>
        /// 券包信息
        /// </summary>
        /// <value>券包信息</value>
        [DataMember(Name = "voucher_package_info", EmitDefaultValue = false)]
        public List<VoucherPackageInfo> VoucherPackageInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityVoucherpackageBatchqueryResponseModel {\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
            sb.Append("  VoucherPackageInfo: ").Append(VoucherPackageInfo).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityVoucherpackageBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityVoucherpackageBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityVoucherpackageBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityVoucherpackageBatchqueryResponseModel input)
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
                    this.VoucherPackageInfo == input.VoucherPackageInfo ||
                    this.VoucherPackageInfo != null &&
                    input.VoucherPackageInfo != null &&
                    this.VoucherPackageInfo.SequenceEqual(input.VoucherPackageInfo)
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
                if (this.VoucherPackageInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherPackageInfo.GetHashCode();
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
