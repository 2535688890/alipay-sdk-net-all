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
    /// ItemPromoInfo
    /// </summary>
    [DataContract(Name = "ItemPromoInfo")]
    public partial class ItemPromoInfo : IEquatable<ItemPromoInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ItemPromoInfo" /> class.
        /// </summary>
        /// <param name="itemConsultList">商品咨询列表.</param>
        /// <param name="itemCoverPic">单品封面图.</param>
        /// <param name="itemDesc">单品描述.</param>
        /// <param name="itemDetailPicList">单品详情图列表.</param>
        /// <param name="itemName">单品名称.</param>
        public ItemPromoInfo(List<ItemConsultInfo> itemConsultList = default(List<ItemConsultInfo>), string itemCoverPic = default(string), string itemDesc = default(string), List<string> itemDetailPicList = default(List<string>), string itemName = default(string))
        {
            this.ItemConsultList = itemConsultList;
            this.ItemCoverPic = itemCoverPic;
            this.ItemDesc = itemDesc;
            this.ItemDetailPicList = itemDetailPicList;
            this.ItemName = itemName;
        }

        /// <summary>
        /// 商品咨询列表
        /// </summary>
        /// <value>商品咨询列表</value>
        [DataMember(Name = "item_consult_list", EmitDefaultValue = false)]
        public List<ItemConsultInfo> ItemConsultList { get; set; }

        /// <summary>
        /// 单品封面图
        /// </summary>
        /// <value>单品封面图</value>
        [DataMember(Name = "item_cover_pic", EmitDefaultValue = false)]
        public string ItemCoverPic { get; set; }

        /// <summary>
        /// 单品描述
        /// </summary>
        /// <value>单品描述</value>
        [DataMember(Name = "item_desc", EmitDefaultValue = false)]
        public string ItemDesc { get; set; }

        /// <summary>
        /// 单品详情图列表
        /// </summary>
        /// <value>单品详情图列表</value>
        [DataMember(Name = "item_detail_pic_list", EmitDefaultValue = false)]
        public List<string> ItemDetailPicList { get; set; }

        /// <summary>
        /// 单品名称
        /// </summary>
        /// <value>单品名称</value>
        [DataMember(Name = "item_name", EmitDefaultValue = false)]
        public string ItemName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ItemPromoInfo {\n");
            sb.Append("  ItemConsultList: ").Append(ItemConsultList).Append("\n");
            sb.Append("  ItemCoverPic: ").Append(ItemCoverPic).Append("\n");
            sb.Append("  ItemDesc: ").Append(ItemDesc).Append("\n");
            sb.Append("  ItemDetailPicList: ").Append(ItemDetailPicList).Append("\n");
            sb.Append("  ItemName: ").Append(ItemName).Append("\n");
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
            return this.Equals(input as ItemPromoInfo);
        }

        /// <summary>
        /// Returns true if ItemPromoInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ItemPromoInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ItemPromoInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemConsultList == input.ItemConsultList ||
                    this.ItemConsultList != null &&
                    input.ItemConsultList != null &&
                    this.ItemConsultList.SequenceEqual(input.ItemConsultList)
                ) && 
                (
                    this.ItemCoverPic == input.ItemCoverPic ||
                    (this.ItemCoverPic != null &&
                    this.ItemCoverPic.Equals(input.ItemCoverPic))
                ) && 
                (
                    this.ItemDesc == input.ItemDesc ||
                    (this.ItemDesc != null &&
                    this.ItemDesc.Equals(input.ItemDesc))
                ) && 
                (
                    this.ItemDetailPicList == input.ItemDetailPicList ||
                    this.ItemDetailPicList != null &&
                    input.ItemDetailPicList != null &&
                    this.ItemDetailPicList.SequenceEqual(input.ItemDetailPicList)
                ) && 
                (
                    this.ItemName == input.ItemName ||
                    (this.ItemName != null &&
                    this.ItemName.Equals(input.ItemName))
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
                if (this.ItemConsultList != null)
                {
                    hashCode = (hashCode * 59) + this.ItemConsultList.GetHashCode();
                }
                if (this.ItemCoverPic != null)
                {
                    hashCode = (hashCode * 59) + this.ItemCoverPic.GetHashCode();
                }
                if (this.ItemDesc != null)
                {
                    hashCode = (hashCode * 59) + this.ItemDesc.GetHashCode();
                }
                if (this.ItemDetailPicList != null)
                {
                    hashCode = (hashCode * 59) + this.ItemDetailPicList.GetHashCode();
                }
                if (this.ItemName != null)
                {
                    hashCode = (hashCode * 59) + this.ItemName.GetHashCode();
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
