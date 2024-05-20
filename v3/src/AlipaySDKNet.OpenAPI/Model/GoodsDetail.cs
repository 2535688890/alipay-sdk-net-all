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
    /// GoodsDetail
    /// </summary>
    [DataContract(Name = "GoodsDetail")]
    public partial class GoodsDetail : IEquatable<GoodsDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoodsDetail" /> class.
        /// </summary>
        /// <param name="alipayGoodsId">支付宝定义的统一商品编号.</param>
        /// <param name="body">商品描述信息.</param>
        /// <param name="categoriesTree">商品类目树，从商品类目根节点到叶子节点的类目id组成，类目id值使用|分割.</param>
        /// <param name="goodsCategory">商品类目.</param>
        /// <param name="goodsId">商品的编号，该参数传入支付券上绑定商品goods_id, 倘若无支付券需要消费，该字段传入商品最小粒度的商品ID（如：若商品有sku粒度，则传商户sku粒度的ID）.</param>
        /// <param name="goodsName">商品名称.</param>
        /// <param name="outItemId">商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7\&quot;&gt;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7&lt;/a&gt;.</param>
        /// <param name="outSkuId">商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7\&quot; &gt;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7&lt;/a&gt;.</param>
        /// <param name="price">商品单价，单位为元.</param>
        /// <param name="quantity">商品数量.</param>
        /// <param name="showUrl">商品的展示地址.</param>
        public GoodsDetail(string alipayGoodsId = default(string), string body = default(string), string categoriesTree = default(string), string goodsCategory = default(string), string goodsId = default(string), string goodsName = default(string), string outItemId = default(string), string outSkuId = default(string), string price = default(string), int quantity = default(int), string showUrl = default(string))
        {
            this.AlipayGoodsId = alipayGoodsId;
            this.Body = body;
            this.CategoriesTree = categoriesTree;
            this.GoodsCategory = goodsCategory;
            this.GoodsId = goodsId;
            this.GoodsName = goodsName;
            this.OutItemId = outItemId;
            this.OutSkuId = outSkuId;
            this.Price = price;
            this.Quantity = quantity;
            this.ShowUrl = showUrl;
        }

        /// <summary>
        /// 支付宝定义的统一商品编号
        /// </summary>
        /// <value>支付宝定义的统一商品编号</value>
        [DataMember(Name = "alipay_goods_id", EmitDefaultValue = false)]
        public string AlipayGoodsId { get; set; }

        /// <summary>
        /// 商品描述信息
        /// </summary>
        /// <value>商品描述信息</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// 商品类目树，从商品类目根节点到叶子节点的类目id组成，类目id值使用|分割
        /// </summary>
        /// <value>商品类目树，从商品类目根节点到叶子节点的类目id组成，类目id值使用|分割</value>
        [DataMember(Name = "categories_tree", EmitDefaultValue = false)]
        public string CategoriesTree { get; set; }

        /// <summary>
        /// 商品类目
        /// </summary>
        /// <value>商品类目</value>
        [DataMember(Name = "goods_category", EmitDefaultValue = false)]
        public string GoodsCategory { get; set; }

        /// <summary>
        /// 商品的编号，该参数传入支付券上绑定商品goods_id, 倘若无支付券需要消费，该字段传入商品最小粒度的商品ID（如：若商品有sku粒度，则传商户sku粒度的ID）
        /// </summary>
        /// <value>商品的编号，该参数传入支付券上绑定商品goods_id, 倘若无支付券需要消费，该字段传入商品最小粒度的商品ID（如：若商品有sku粒度，则传商户sku粒度的ID）</value>
        [DataMember(Name = "goods_id", EmitDefaultValue = false)]
        public string GoodsId { get; set; }

        /// <summary>
        /// 商品名称
        /// </summary>
        /// <value>商品名称</value>
        [DataMember(Name = "goods_name", EmitDefaultValue = false)]
        public string GoodsName { get; set; }

        /// <summary>
        /// 商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7\&quot;&gt;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7&lt;/a&gt;
        /// </summary>
        /// <value>商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7\&quot;&gt;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7&lt;/a&gt;</value>
        [DataMember(Name = "out_item_id", EmitDefaultValue = false)]
        public string OutItemId { get; set; }

        /// <summary>
        /// 商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7\&quot; &gt;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7&lt;/a&gt;
        /// </summary>
        /// <value>商家侧小程序商品ID，指商家提报给小程序商品库的商品。当前接口的extend_params.trade_component_order_id字段不为空时该字段必填，且与交易组件订单参数保持一致。了解小程序商品请参考：&lt;a target&#x3D;\&quot;_blank\&quot; href&#x3D;\&quot;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7\&quot; &gt;https://opendocs.alipay.com/mini/06uila?pathHash&#x3D;63b6fba7&lt;/a&gt;</value>
        [DataMember(Name = "out_sku_id", EmitDefaultValue = false)]
        public string OutSkuId { get; set; }

        /// <summary>
        /// 商品单价，单位为元
        /// </summary>
        /// <value>商品单价，单位为元</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 商品数量
        /// </summary>
        /// <value>商品数量</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// 商品的展示地址
        /// </summary>
        /// <value>商品的展示地址</value>
        [DataMember(Name = "show_url", EmitDefaultValue = false)]
        public string ShowUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GoodsDetail {\n");
            sb.Append("  AlipayGoodsId: ").Append(AlipayGoodsId).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CategoriesTree: ").Append(CategoriesTree).Append("\n");
            sb.Append("  GoodsCategory: ").Append(GoodsCategory).Append("\n");
            sb.Append("  GoodsId: ").Append(GoodsId).Append("\n");
            sb.Append("  GoodsName: ").Append(GoodsName).Append("\n");
            sb.Append("  OutItemId: ").Append(OutItemId).Append("\n");
            sb.Append("  OutSkuId: ").Append(OutSkuId).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  ShowUrl: ").Append(ShowUrl).Append("\n");
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
            return this.Equals(input as GoodsDetail);
        }

        /// <summary>
        /// Returns true if GoodsDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of GoodsDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GoodsDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AlipayGoodsId == input.AlipayGoodsId ||
                    (this.AlipayGoodsId != null &&
                    this.AlipayGoodsId.Equals(input.AlipayGoodsId))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.CategoriesTree == input.CategoriesTree ||
                    (this.CategoriesTree != null &&
                    this.CategoriesTree.Equals(input.CategoriesTree))
                ) && 
                (
                    this.GoodsCategory == input.GoodsCategory ||
                    (this.GoodsCategory != null &&
                    this.GoodsCategory.Equals(input.GoodsCategory))
                ) && 
                (
                    this.GoodsId == input.GoodsId ||
                    (this.GoodsId != null &&
                    this.GoodsId.Equals(input.GoodsId))
                ) && 
                (
                    this.GoodsName == input.GoodsName ||
                    (this.GoodsName != null &&
                    this.GoodsName.Equals(input.GoodsName))
                ) && 
                (
                    this.OutItemId == input.OutItemId ||
                    (this.OutItemId != null &&
                    this.OutItemId.Equals(input.OutItemId))
                ) && 
                (
                    this.OutSkuId == input.OutSkuId ||
                    (this.OutSkuId != null &&
                    this.OutSkuId.Equals(input.OutSkuId))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.ShowUrl == input.ShowUrl ||
                    (this.ShowUrl != null &&
                    this.ShowUrl.Equals(input.ShowUrl))
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
                if (this.AlipayGoodsId != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayGoodsId.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.CategoriesTree != null)
                {
                    hashCode = (hashCode * 59) + this.CategoriesTree.GetHashCode();
                }
                if (this.GoodsCategory != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsCategory.GetHashCode();
                }
                if (this.GoodsId != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsId.GetHashCode();
                }
                if (this.GoodsName != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsName.GetHashCode();
                }
                if (this.OutItemId != null)
                {
                    hashCode = (hashCode * 59) + this.OutItemId.GetHashCode();
                }
                if (this.OutSkuId != null)
                {
                    hashCode = (hashCode * 59) + this.OutSkuId.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.ShowUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ShowUrl.GetHashCode();
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
