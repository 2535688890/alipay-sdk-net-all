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
    /// AlipayOpenPublicAdvertModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicAdvertModifyModel")]
    public partial class AlipayOpenPublicAdvertModifyModel : IEquatable<AlipayOpenPublicAdvertModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAdvertModifyModel" /> class.
        /// </summary>
        /// <param name="advertId">广告位id，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.advert.create\&quot;&gt;alipay.open.public.advert.create&lt;/a&gt;(生活号广告位添加接口)添加广告位获取。.</param>
        /// <param name="advertItems">广告位轮播内容列表。数量限制：大于1个，小于5个。广告位轮播内容顺序：与接口传入的顺序排列一致。.</param>
        public AlipayOpenPublicAdvertModifyModel(string advertId = default(string), List<AdvertItem> advertItems = default(List<AdvertItem>))
        {
            this.AdvertId = advertId;
            this.AdvertItems = advertItems;
        }

        /// <summary>
        /// 广告位id，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.advert.create\&quot;&gt;alipay.open.public.advert.create&lt;/a&gt;(生活号广告位添加接口)添加广告位获取。
        /// </summary>
        /// <value>广告位id，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.advert.create\&quot;&gt;alipay.open.public.advert.create&lt;/a&gt;(生活号广告位添加接口)添加广告位获取。</value>
        [DataMember(Name = "advert_id", EmitDefaultValue = false)]
        public string AdvertId { get; set; }

        /// <summary>
        /// 广告位轮播内容列表。数量限制：大于1个，小于5个。广告位轮播内容顺序：与接口传入的顺序排列一致。
        /// </summary>
        /// <value>广告位轮播内容列表。数量限制：大于1个，小于5个。广告位轮播内容顺序：与接口传入的顺序排列一致。</value>
        [DataMember(Name = "advert_items", EmitDefaultValue = false)]
        public List<AdvertItem> AdvertItems { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicAdvertModifyModel {\n");
            sb.Append("  AdvertId: ").Append(AdvertId).Append("\n");
            sb.Append("  AdvertItems: ").Append(AdvertItems).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicAdvertModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicAdvertModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicAdvertModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicAdvertModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdvertId == input.AdvertId ||
                    (this.AdvertId != null &&
                    this.AdvertId.Equals(input.AdvertId))
                ) && 
                (
                    this.AdvertItems == input.AdvertItems ||
                    this.AdvertItems != null &&
                    input.AdvertItems != null &&
                    this.AdvertItems.SequenceEqual(input.AdvertItems)
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
                if (this.AdvertId != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertId.GetHashCode();
                }
                if (this.AdvertItems != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertItems.GetHashCode();
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
