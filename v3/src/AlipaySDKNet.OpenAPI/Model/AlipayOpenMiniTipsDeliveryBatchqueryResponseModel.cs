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
    /// AlipayOpenMiniTipsDeliveryBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTipsDeliveryBatchqueryResponseModel")]
    public partial class AlipayOpenMiniTipsDeliveryBatchqueryResponseModel : IEquatable<AlipayOpenMiniTipsDeliveryBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTipsDeliveryBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="tipsDeliveryList">收藏引导活动信息列表。根据活动状态排序，顺序为：生效中，暂停，审核中，白名单生效中，初始化，审核失败，结束。相同状态优先展示状态更新时间最迟的活动。.</param>
        /// <param name="totalPages">总页数.</param>
        /// <param name="totalSize">收藏引导数据总数量.</param>
        public AlipayOpenMiniTipsDeliveryBatchqueryResponseModel(List<TipsDelivery> tipsDeliveryList = default(List<TipsDelivery>), int totalPages = default(int), int totalSize = default(int))
        {
            this.TipsDeliveryList = tipsDeliveryList;
            this.TotalPages = totalPages;
            this.TotalSize = totalSize;
        }

        /// <summary>
        /// 收藏引导活动信息列表。根据活动状态排序，顺序为：生效中，暂停，审核中，白名单生效中，初始化，审核失败，结束。相同状态优先展示状态更新时间最迟的活动。
        /// </summary>
        /// <value>收藏引导活动信息列表。根据活动状态排序，顺序为：生效中，暂停，审核中，白名单生效中，初始化，审核失败，结束。相同状态优先展示状态更新时间最迟的活动。</value>
        [DataMember(Name = "tips_delivery_list", EmitDefaultValue = false)]
        public List<TipsDelivery> TipsDeliveryList { get; set; }

        /// <summary>
        /// 总页数
        /// </summary>
        /// <value>总页数</value>
        [DataMember(Name = "total_pages", EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// 收藏引导数据总数量
        /// </summary>
        /// <value>收藏引导数据总数量</value>
        [DataMember(Name = "total_size", EmitDefaultValue = false)]
        public int TotalSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTipsDeliveryBatchqueryResponseModel {\n");
            sb.Append("  TipsDeliveryList: ").Append(TipsDeliveryList).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalSize: ").Append(TotalSize).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTipsDeliveryBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTipsDeliveryBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTipsDeliveryBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTipsDeliveryBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TipsDeliveryList == input.TipsDeliveryList ||
                    this.TipsDeliveryList != null &&
                    input.TipsDeliveryList != null &&
                    this.TipsDeliveryList.SequenceEqual(input.TipsDeliveryList)
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
                ) && 
                (
                    this.TotalSize == input.TotalSize ||
                    this.TotalSize.Equals(input.TotalSize)
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
                if (this.TipsDeliveryList != null)
                {
                    hashCode = (hashCode * 59) + this.TipsDeliveryList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalSize.GetHashCode();
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
