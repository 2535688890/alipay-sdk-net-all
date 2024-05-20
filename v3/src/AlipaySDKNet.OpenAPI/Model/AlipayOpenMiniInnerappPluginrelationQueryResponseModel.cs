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
    /// AlipayOpenMiniInnerappPluginrelationQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniInnerappPluginrelationQueryResponseModel")]
    public partial class AlipayOpenMiniInnerappPluginrelationQueryResponseModel : IEquatable<AlipayOpenMiniInnerappPluginrelationQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniInnerappPluginrelationQueryResponseModel" /> class.
        /// </summary>
        /// <param name="page">页码.</param>
        /// <param name="pageSize">页大小.</param>
        /// <param name="pluginRelationInfoList">插件关联关系信息.</param>
        /// <param name="totalCount">总数.</param>
        public AlipayOpenMiniInnerappPluginrelationQueryResponseModel(int page = default(int), int pageSize = default(int), List<PluginUseRelationInfo> pluginRelationInfoList = default(List<PluginUseRelationInfo>), int totalCount = default(int))
        {
            this.Page = page;
            this.PageSize = pageSize;
            this.PluginRelationInfoList = pluginRelationInfoList;
            this.TotalCount = totalCount;
        }

        /// <summary>
        /// 页码
        /// </summary>
        /// <value>页码</value>
        [DataMember(Name = "page", EmitDefaultValue = false)]
        public int Page { get; set; }

        /// <summary>
        /// 页大小
        /// </summary>
        /// <value>页大小</value>
        [DataMember(Name = "page_size", EmitDefaultValue = false)]
        public int PageSize { get; set; }

        /// <summary>
        /// 插件关联关系信息
        /// </summary>
        /// <value>插件关联关系信息</value>
        [DataMember(Name = "plugin_relation_info_list", EmitDefaultValue = false)]
        public List<PluginUseRelationInfo> PluginRelationInfoList { get; set; }

        /// <summary>
        /// 总数
        /// </summary>
        /// <value>总数</value>
        [DataMember(Name = "total_count", EmitDefaultValue = false)]
        public int TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniInnerappPluginrelationQueryResponseModel {\n");
            sb.Append("  Page: ").Append(Page).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  PluginRelationInfoList: ").Append(PluginRelationInfoList).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniInnerappPluginrelationQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniInnerappPluginrelationQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniInnerappPluginrelationQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniInnerappPluginrelationQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Page == input.Page ||
                    this.Page.Equals(input.Page)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.PluginRelationInfoList == input.PluginRelationInfoList ||
                    this.PluginRelationInfoList != null &&
                    input.PluginRelationInfoList != null &&
                    this.PluginRelationInfoList.SequenceEqual(input.PluginRelationInfoList)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    this.TotalCount.Equals(input.TotalCount)
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
                hashCode = (hashCode * 59) + this.Page.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                if (this.PluginRelationInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.PluginRelationInfoList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalCount.GetHashCode();
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
