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
    /// AlipayOpenPublicAdvertBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicAdvertBatchqueryResponseModel")]
    public partial class AlipayOpenPublicAdvertBatchqueryResponseModel : IEquatable<AlipayOpenPublicAdvertBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAdvertBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="advertList">广告位列表 。目前只有一个广告位。.</param>
        /// <param name="count">广告组数量.</param>
        public AlipayOpenPublicAdvertBatchqueryResponseModel(List<Advert> advertList = default(List<Advert>), int count = default(int))
        {
            this.AdvertList = advertList;
            this.Count = count;
        }

        /// <summary>
        /// 广告位列表 。目前只有一个广告位。
        /// </summary>
        /// <value>广告位列表 。目前只有一个广告位。</value>
        [DataMember(Name = "advert_list", EmitDefaultValue = false)]
        public List<Advert> AdvertList { get; set; }

        /// <summary>
        /// 广告组数量
        /// </summary>
        /// <value>广告组数量</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicAdvertBatchqueryResponseModel {\n");
            sb.Append("  AdvertList: ").Append(AdvertList).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicAdvertBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicAdvertBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicAdvertBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicAdvertBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdvertList == input.AdvertList ||
                    this.AdvertList != null &&
                    input.AdvertList != null &&
                    this.AdvertList.SequenceEqual(input.AdvertList)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
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
                if (this.AdvertList != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
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
