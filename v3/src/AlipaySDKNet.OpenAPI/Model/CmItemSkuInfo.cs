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
    /// CmItemSkuInfo
    /// </summary>
    [DataContract(Name = "CmItemSkuInfo")]
    public partial class CmItemSkuInfo : IEquatable<CmItemSkuInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CmItemSkuInfo" /> class.
        /// </summary>
        /// <param name="gmtCreate">创建时间.</param>
        /// <param name="gmtModified">更新时间.</param>
        /// <param name="inventory">库存.</param>
        /// <param name="itemId">商品ID.</param>
        /// <param name="materialList">素材列表.</param>
        /// <param name="originalPrice">标价，单位分.</param>
        /// <param name="price">售价，单位分.</param>
        /// <param name="remainInventory">剩余库存.</param>
        /// <param name="skuId">商品SKU ID.</param>
        /// <param name="skuPropertyList">SKU属性列表.</param>
        /// <param name="status">商品SKU状态.</param>
        public CmItemSkuInfo(string gmtCreate = default(string), string gmtModified = default(string), int inventory = default(int), string itemId = default(string), List<MaterialInfo> materialList = default(List<MaterialInfo>), int originalPrice = default(int), int price = default(int), int remainInventory = default(int), string skuId = default(string), List<ItemSkuPropertyInfo> skuPropertyList = default(List<ItemSkuPropertyInfo>), string status = default(string))
        {
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.Inventory = inventory;
            this.ItemId = itemId;
            this.MaterialList = materialList;
            this.OriginalPrice = originalPrice;
            this.Price = price;
            this.RemainInventory = remainInventory;
            this.SkuId = skuId;
            this.SkuPropertyList = skuPropertyList;
            this.Status = status;
        }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 更新时间
        /// </summary>
        /// <value>更新时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 库存
        /// </summary>
        /// <value>库存</value>
        [DataMember(Name = "inventory", EmitDefaultValue = false)]
        public int Inventory { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        /// <value>商品ID</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 素材列表
        /// </summary>
        /// <value>素材列表</value>
        [DataMember(Name = "material_list", EmitDefaultValue = false)]
        public List<MaterialInfo> MaterialList { get; set; }

        /// <summary>
        /// 标价，单位分
        /// </summary>
        /// <value>标价，单位分</value>
        [DataMember(Name = "original_price", EmitDefaultValue = false)]
        public int OriginalPrice { get; set; }

        /// <summary>
        /// 售价，单位分
        /// </summary>
        /// <value>售价，单位分</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public int Price { get; set; }

        /// <summary>
        /// 剩余库存
        /// </summary>
        /// <value>剩余库存</value>
        [DataMember(Name = "remain_inventory", EmitDefaultValue = false)]
        public int RemainInventory { get; set; }

        /// <summary>
        /// 商品SKU ID
        /// </summary>
        /// <value>商品SKU ID</value>
        [DataMember(Name = "sku_id", EmitDefaultValue = false)]
        public string SkuId { get; set; }

        /// <summary>
        /// SKU属性列表
        /// </summary>
        /// <value>SKU属性列表</value>
        [DataMember(Name = "sku_property_list", EmitDefaultValue = false)]
        public List<ItemSkuPropertyInfo> SkuPropertyList { get; set; }

        /// <summary>
        /// 商品SKU状态
        /// </summary>
        /// <value>商品SKU状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CmItemSkuInfo {\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  Inventory: ").Append(Inventory).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  MaterialList: ").Append(MaterialList).Append("\n");
            sb.Append("  OriginalPrice: ").Append(OriginalPrice).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  RemainInventory: ").Append(RemainInventory).Append("\n");
            sb.Append("  SkuId: ").Append(SkuId).Append("\n");
            sb.Append("  SkuPropertyList: ").Append(SkuPropertyList).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as CmItemSkuInfo);
        }

        /// <summary>
        /// Returns true if CmItemSkuInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CmItemSkuInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CmItemSkuInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.Inventory == input.Inventory ||
                    this.Inventory.Equals(input.Inventory)
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.MaterialList == input.MaterialList ||
                    this.MaterialList != null &&
                    input.MaterialList != null &&
                    this.MaterialList.SequenceEqual(input.MaterialList)
                ) && 
                (
                    this.OriginalPrice == input.OriginalPrice ||
                    this.OriginalPrice.Equals(input.OriginalPrice)
                ) && 
                (
                    this.Price == input.Price ||
                    this.Price.Equals(input.Price)
                ) && 
                (
                    this.RemainInventory == input.RemainInventory ||
                    this.RemainInventory.Equals(input.RemainInventory)
                ) && 
                (
                    this.SkuId == input.SkuId ||
                    (this.SkuId != null &&
                    this.SkuId.Equals(input.SkuId))
                ) && 
                (
                    this.SkuPropertyList == input.SkuPropertyList ||
                    this.SkuPropertyList != null &&
                    input.SkuPropertyList != null &&
                    this.SkuPropertyList.SequenceEqual(input.SkuPropertyList)
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Inventory.GetHashCode();
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.MaterialList != null)
                {
                    hashCode = (hashCode * 59) + this.MaterialList.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OriginalPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.Price.GetHashCode();
                hashCode = (hashCode * 59) + this.RemainInventory.GetHashCode();
                if (this.SkuId != null)
                {
                    hashCode = (hashCode * 59) + this.SkuId.GetHashCode();
                }
                if (this.SkuPropertyList != null)
                {
                    hashCode = (hashCode * 59) + this.SkuPropertyList.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
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
