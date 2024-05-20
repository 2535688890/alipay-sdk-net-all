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
    /// AbilityPageQueryDTO
    /// </summary>
    [DataContract(Name = "AbilityPageQueryDTO")]
    public partial class AbilityPageQueryDTO : IEquatable<AbilityPageQueryDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AbilityPageQueryDTO" /> class.
        /// </summary>
        /// <param name="pageData">搜索运营列表的分页数据.</param>
        /// <param name="pageNum">当前页码，默认第一页.</param>
        /// <param name="pageSize">每页记录数，默认10.</param>
        /// <param name="totalNumber">记录总数.</param>
        public AbilityPageQueryDTO(List<SearchAbilityOrderData> pageData = default(List<SearchAbilityOrderData>), string pageNum = default(string), string pageSize = default(string), int totalNumber = default(int))
        {
            this.PageData = pageData;
            this.PageNum = pageNum;
            this.PageSize = pageSize;
            this.TotalNumber = totalNumber;
        }

        /// <summary>
        /// 搜索运营列表的分页数据
        /// </summary>
        /// <value>搜索运营列表的分页数据</value>
        [DataMember(Name = "page_data", EmitDefaultValue = false)]
        public List<SearchAbilityOrderData> PageData { get; set; }

        /// <summary>
        /// 当前页码，默认第一页
        /// </summary>
        /// <value>当前页码，默认第一页</value>
        [DataMember(Name = "page_num", EmitDefaultValue = false)]
        public string PageNum { get; set; }

        /// <summary>
        /// 每页记录数，默认10
        /// </summary>
        /// <value>每页记录数，默认10</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public string PageSize { get; set; }

        /// <summary>
        /// 记录总数
        /// </summary>
        /// <value>记录总数</value>
        [DataMember(Name = "total_number", EmitDefaultValue = false)]
        public int TotalNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AbilityPageQueryDTO {\n");
            sb.Append("  PageData: ").Append(PageData).Append("\n");
            sb.Append("  PageNum: ").Append(PageNum).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  TotalNumber: ").Append(TotalNumber).Append("\n");
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
            return this.Equals(input as AbilityPageQueryDTO);
        }

        /// <summary>
        /// Returns true if AbilityPageQueryDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of AbilityPageQueryDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbilityPageQueryDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PageData == input.PageData ||
                    this.PageData != null &&
                    input.PageData != null &&
                    this.PageData.SequenceEqual(input.PageData)
                ) && 
                (
                    this.PageNum == input.PageNum ||
                    (this.PageNum != null &&
                    this.PageNum.Equals(input.PageNum))
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    (this.PageSize != null &&
                    this.PageSize.Equals(input.PageSize))
                ) && 
                (
                    this.TotalNumber == input.TotalNumber ||
                    this.TotalNumber.Equals(input.TotalNumber)
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
                if (this.PageData != null)
                {
                    hashCode = (hashCode * 59) + this.PageData.GetHashCode();
                }
                if (this.PageNum != null)
                {
                    hashCode = (hashCode * 59) + this.PageNum.GetHashCode();
                }
                if (this.PageSize != null)
                {
                    hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalNumber.GetHashCode();
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
