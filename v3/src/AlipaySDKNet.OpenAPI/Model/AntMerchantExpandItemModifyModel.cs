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
    /// AntMerchantExpandItemModifyModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandItemModifyModel")]
    public partial class AntMerchantExpandItemModifyModel : IEquatable<AntMerchantExpandItemModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemModifyModel" /> class.
        /// </summary>
        /// <param name="detailUrl">商品详情地址.</param>
        /// <param name="extInfo">商品扩展信息：可以解析成 Map&lt;String, String&gt; 的 json string.</param>
        /// <param name="externalItemId">外部商品ID（item_id不为空时作为普通更新项，item_id为空时作为更新KEY）.</param>
        /// <param name="frontCategoryId">前台类目id, null表示未分类.</param>
        /// <param name="itemId">商品id(和external_item_id不能同时为空).</param>
        /// <param name="labelList">商品标签列表，null表示不修改标签列表，空list表示清空标签.</param>
        /// <param name="mainPic">商品主图.</param>
        /// <param name="name">商品名称.</param>
        /// <param name="opTimestamp">更新时间戳（只处理时间戳最大的一次请求）.</param>
        /// <param name="scene">场景：GAS_CHARGE（加油）.</param>
        /// <param name="skuList">SKU列表（会和商品已存在SKU做差异化比较后做增删改操作）.</param>
        /// <param name="status">商品状态：  EFFECT（有效）、 INVALID（无效）.</param>
        public AntMerchantExpandItemModifyModel(string detailUrl = default(string), string extInfo = default(string), string externalItemId = default(string), string frontCategoryId = default(string), string itemId = default(string), List<ItemLabelModifyInfo> labelList = default(List<ItemLabelModifyInfo>), string mainPic = default(string), string name = default(string), int opTimestamp = default(int), string scene = default(string), List<ItemSkuModifyInfo> skuList = default(List<ItemSkuModifyInfo>), string status = default(string))
        {
            this.DetailUrl = detailUrl;
            this.ExtInfo = extInfo;
            this.ExternalItemId = externalItemId;
            this.FrontCategoryId = frontCategoryId;
            this.ItemId = itemId;
            this.LabelList = labelList;
            this.MainPic = mainPic;
            this.Name = name;
            this.OpTimestamp = opTimestamp;
            this.Scene = scene;
            this.SkuList = skuList;
            this.Status = status;
        }

        /// <summary>
        /// 商品详情地址
        /// </summary>
        /// <value>商品详情地址</value>
        [DataMember(Name = "detail_url", EmitDefaultValue = false)]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 商品扩展信息：可以解析成 Map&lt;String, String&gt; 的 json string
        /// </summary>
        /// <value>商品扩展信息：可以解析成 Map&lt;String, String&gt; 的 json string</value>
        [DataMember(Name = "ext_info", EmitDefaultValue = false)]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 外部商品ID（item_id不为空时作为普通更新项，item_id为空时作为更新KEY）
        /// </summary>
        /// <value>外部商品ID（item_id不为空时作为普通更新项，item_id为空时作为更新KEY）</value>
        [DataMember(Name = "external_item_id", EmitDefaultValue = false)]
        public string ExternalItemId { get; set; }

        /// <summary>
        /// 前台类目id, null表示未分类
        /// </summary>
        /// <value>前台类目id, null表示未分类</value>
        [DataMember(Name = "front_category_id", EmitDefaultValue = false)]
        public string FrontCategoryId { get; set; }

        /// <summary>
        /// 商品id(和external_item_id不能同时为空)
        /// </summary>
        /// <value>商品id(和external_item_id不能同时为空)</value>
        [DataMember(Name = "item_id", EmitDefaultValue = false)]
        public string ItemId { get; set; }

        /// <summary>
        /// 商品标签列表，null表示不修改标签列表，空list表示清空标签
        /// </summary>
        /// <value>商品标签列表，null表示不修改标签列表，空list表示清空标签</value>
        [DataMember(Name = "label_list", EmitDefaultValue = false)]
        public List<ItemLabelModifyInfo> LabelList { get; set; }

        /// <summary>
        /// 商品主图
        /// </summary>
        /// <value>商品主图</value>
        [DataMember(Name = "main_pic", EmitDefaultValue = false)]
        public string MainPic { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 更新时间戳（只处理时间戳最大的一次请求）
        /// </summary>
        /// <value>更新时间戳（只处理时间戳最大的一次请求）</value>
        [DataMember(Name = "op_timestamp", EmitDefaultValue = false)]
        public int OpTimestamp { get; set; }

        /// <summary>
        /// 场景：GAS_CHARGE（加油）
        /// </summary>
        /// <value>场景：GAS_CHARGE（加油）</value>
        [DataMember(Name = "scene", EmitDefaultValue = false)]
        public string Scene { get; set; }

        /// <summary>
        /// SKU列表（会和商品已存在SKU做差异化比较后做增删改操作）
        /// </summary>
        /// <value>SKU列表（会和商品已存在SKU做差异化比较后做增删改操作）</value>
        [DataMember(Name = "sku_list", EmitDefaultValue = false)]
        public List<ItemSkuModifyInfo> SkuList { get; set; }

        /// <summary>
        /// 商品状态：  EFFECT（有效）、 INVALID（无效）
        /// </summary>
        /// <value>商品状态：  EFFECT（有效）、 INVALID（无效）</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandItemModifyModel {\n");
            sb.Append("  DetailUrl: ").Append(DetailUrl).Append("\n");
            sb.Append("  ExtInfo: ").Append(ExtInfo).Append("\n");
            sb.Append("  ExternalItemId: ").Append(ExternalItemId).Append("\n");
            sb.Append("  FrontCategoryId: ").Append(FrontCategoryId).Append("\n");
            sb.Append("  ItemId: ").Append(ItemId).Append("\n");
            sb.Append("  LabelList: ").Append(LabelList).Append("\n");
            sb.Append("  MainPic: ").Append(MainPic).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  OpTimestamp: ").Append(OpTimestamp).Append("\n");
            sb.Append("  Scene: ").Append(Scene).Append("\n");
            sb.Append("  SkuList: ").Append(SkuList).Append("\n");
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
            return this.Equals(input as AntMerchantExpandItemModifyModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandItemModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandItemModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandItemModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DetailUrl == input.DetailUrl ||
                    (this.DetailUrl != null &&
                    this.DetailUrl.Equals(input.DetailUrl))
                ) && 
                (
                    this.ExtInfo == input.ExtInfo ||
                    (this.ExtInfo != null &&
                    this.ExtInfo.Equals(input.ExtInfo))
                ) && 
                (
                    this.ExternalItemId == input.ExternalItemId ||
                    (this.ExternalItemId != null &&
                    this.ExternalItemId.Equals(input.ExternalItemId))
                ) && 
                (
                    this.FrontCategoryId == input.FrontCategoryId ||
                    (this.FrontCategoryId != null &&
                    this.FrontCategoryId.Equals(input.FrontCategoryId))
                ) && 
                (
                    this.ItemId == input.ItemId ||
                    (this.ItemId != null &&
                    this.ItemId.Equals(input.ItemId))
                ) && 
                (
                    this.LabelList == input.LabelList ||
                    this.LabelList != null &&
                    input.LabelList != null &&
                    this.LabelList.SequenceEqual(input.LabelList)
                ) && 
                (
                    this.MainPic == input.MainPic ||
                    (this.MainPic != null &&
                    this.MainPic.Equals(input.MainPic))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.OpTimestamp == input.OpTimestamp ||
                    this.OpTimestamp.Equals(input.OpTimestamp)
                ) && 
                (
                    this.Scene == input.Scene ||
                    (this.Scene != null &&
                    this.Scene.Equals(input.Scene))
                ) && 
                (
                    this.SkuList == input.SkuList ||
                    this.SkuList != null &&
                    input.SkuList != null &&
                    this.SkuList.SequenceEqual(input.SkuList)
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
                if (this.DetailUrl != null)
                {
                    hashCode = (hashCode * 59) + this.DetailUrl.GetHashCode();
                }
                if (this.ExtInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ExtInfo.GetHashCode();
                }
                if (this.ExternalItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ExternalItemId.GetHashCode();
                }
                if (this.FrontCategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.FrontCategoryId.GetHashCode();
                }
                if (this.ItemId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemId.GetHashCode();
                }
                if (this.LabelList != null)
                {
                    hashCode = (hashCode * 59) + this.LabelList.GetHashCode();
                }
                if (this.MainPic != null)
                {
                    hashCode = (hashCode * 59) + this.MainPic.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OpTimestamp.GetHashCode();
                if (this.Scene != null)
                {
                    hashCode = (hashCode * 59) + this.Scene.GetHashCode();
                }
                if (this.SkuList != null)
                {
                    hashCode = (hashCode * 59) + this.SkuList.GetHashCode();
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
