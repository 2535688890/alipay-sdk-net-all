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
    /// AlipayOpenAppServiceListQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAppServiceListQueryResponseModel")]
    public partial class AlipayOpenAppServiceListQueryResponseModel : IEquatable<AlipayOpenAppServiceListQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAppServiceListQueryResponseModel" /> class.
        /// </summary>
        /// <param name="pageNum">页码.</param>
        /// <param name="pageSize">每页记录数.</param>
        /// <param name="records">服务列表.</param>
        /// <param name="total">总记录数.</param>
        public AlipayOpenAppServiceListQueryResponseModel(int pageNum = default(int), int pageSize = default(int), List<StandardServiceBaseInfo> records = default(List<StandardServiceBaseInfo>), int total = default(int))
        {
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.Records = records;
            this.Total = total;
        }

        /// <summary>
        /// 页码
        /// </summary>
        /// <value>页码</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public int PageNum { get; set; }

        /// <summary>
        /// 每页记录数
        /// </summary>
        /// <value>每页记录数</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 服务列表
        /// </summary>
        /// <value>服务列表</value>
        [DataMember(Name = "records", EmitDefaultValue = false)]
        public List<StandardServiceBaseInfo> Records { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        /// <value>总记录数</value>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public int Total { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAppServiceListQueryResponseModel {\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
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
            return this.Equals(input as AlipayOpenAppServiceListQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAppServiceListQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAppServiceListQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAppServiceListQueryResponseModel input)
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
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
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
                hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
                }
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
