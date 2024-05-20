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
    /// AlipayMarketingActivityOrdervoucherUseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingActivityOrdervoucherUseModel")]
    public partial class AlipayMarketingActivityOrdervoucherUseModel : IEquatable<AlipayMarketingActivityOrdervoucherUseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingActivityOrdervoucherUseModel" /> class.
        /// </summary>
        /// <param name="bizDt">外部优惠券的核销时间，用于流水记录。 格式为：yyyy-MM-dd HH:mm:ss.</param>
        /// <param name="goodsDetail">商品明细信息.</param>
        /// <param name="merchantAccessMode">商户接入模式.</param>
        /// <param name="outBizNo">外部业务单号，用作幂等控制。    幂等作用：  参数不变的情况下，再次请求返回与上一次相同的结果。    外部接入方需保证业务单号唯一。.</param>
        /// <param name="realShopId">用户核销优惠券的代运营商业关系门店id，调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。 限制: 传入的门店id必须是创建商家券voucher_use_rule. voucher_available_scope.  order_voucher_available_shop对象中real_shop_ids中的门店id.</param>
        /// <param name="storeId">用户核销优惠券的支付门店id,调用接口&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/03s3jk?pathHash&#x3D;04312530&amp;scene&#x3D;common\&quot; target&#x3D;\&quot;_blank\&quot;&gt;ant.merchant.expand.shop.create&lt;/a&gt;创建门店返回的门店id。 限制: 传入的门店id必须是创建商家券voucher_use_rule. voucher_available_scope.  order_voucher_available_shop对象中shop_ids中的门店id.</param>
        /// <param name="totalFee">订单总金额.</param>
        /// <param name="tradeChannel">交易渠道。.</param>
        /// <param name="tradeNo">该交易在支付宝系统中的交易流水号。 注意：若用户使用支付宝为交易的渠道，本参数必填。.</param>
        /// <param name="voucherUseDetailInfo">voucherUseDetailInfo.</param>
        public AlipayMarketingActivityOrdervoucherUseModel(string bizDt = default(string), List<GoodsDetailDTO> goodsDetail = default(List<GoodsDetailDTO>), string merchantAccessMode = default(string), string outBizNo = default(string), string realShopId = default(string), string storeId = default(string), string totalFee = default(string), string tradeChannel = default(string), string tradeNo = default(string), VoucherUseDetailInfo voucherUseDetailInfo = default(VoucherUseDetailInfo))
        {
            this.BizDt = bizDt;
            this.GoodsDetail = goodsDetail;
            this.MerchantAccessMode = merchantAccessMode;
            this.OutBizNo = outBizNo;
            this.RealShopId = realShopId;
            this.StoreId = storeId;
            this.TotalFee = totalFee;
            this.TradeChannel = tradeChannel;
            this.TradeNo = tradeNo;
            this.VoucherUseDetailInfo = voucherUseDetailInfo;
        }

        /// <summary>
        /// 外部优惠券的核销时间，用于流水记录。 格式为：yyyy-MM-dd HH:mm:ss
        /// </summary>
        /// <value>外部优惠券的核销时间，用于流水记录。 格式为：yyyy-MM-dd HH:mm:ss</value>
        [DataMember(Name = "biz_dt", EmitDefaultValue = false)]
        public string BizDt { get; set; }

        /// <summary>
        /// 商品明细信息
        /// </summary>
        /// <value>商品明细信息</value>
        [DataMember(Name = "goods_detail", EmitDefaultValue = false)]
        public List<GoodsDetailDTO> GoodsDetail { get; set; }

        /// <summary>
        /// 商户接入模式
        /// </summary>
        /// <value>商户接入模式</value>
        [DataMember(Name = "merchant_access_mode", EmitDefaultValue = false)]
        public string MerchantAccessMode { get; set; }

        /// <summary>
        /// 外部业务单号，用作幂等控制。    幂等作用：  参数不变的情况下，再次请求返回与上一次相同的结果。    外部接入方需保证业务单号唯一。
        /// </summary>
        /// <value>外部业务单号，用作幂等控制。    幂等作用：  参数不变的情况下，再次请求返回与上一次相同的结果。    外部接入方需保证业务单号唯一。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 用户核销优惠券的代运营商业关系门店id，调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。 限制: 传入的门店id必须是创建商家券voucher_use_rule. voucher_available_scope.  order_voucher_available_shop对象中real_shop_ids中的门店id
        /// </summary>
        /// <value>用户核销优惠券的代运营商业关系门店id，调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id。 限制: 传入的门店id必须是创建商家券voucher_use_rule. voucher_available_scope.  order_voucher_available_shop对象中real_shop_ids中的门店id</value>
        [DataMember(Name = "real_shop_id", EmitDefaultValue = false)]
        public string RealShopId { get; set; }

        /// <summary>
        /// 用户核销优惠券的支付门店id,调用接口&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/03s3jk?pathHash&#x3D;04312530&amp;scene&#x3D;common\&quot; target&#x3D;\&quot;_blank\&quot;&gt;ant.merchant.expand.shop.create&lt;/a&gt;创建门店返回的门店id。 限制: 传入的门店id必须是创建商家券voucher_use_rule. voucher_available_scope.  order_voucher_available_shop对象中shop_ids中的门店id
        /// </summary>
        /// <value>用户核销优惠券的支付门店id,调用接口&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/03s3jk?pathHash&#x3D;04312530&amp;scene&#x3D;common\&quot; target&#x3D;\&quot;_blank\&quot;&gt;ant.merchant.expand.shop.create&lt;/a&gt;创建门店返回的门店id。 限制: 传入的门店id必须是创建商家券voucher_use_rule. voucher_available_scope.  order_voucher_available_shop对象中shop_ids中的门店id</value>
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        /// <value>订单总金额</value>
        [DataMember(Name = "total_fee", EmitDefaultValue = false)]
        public string TotalFee { get; set; }

        /// <summary>
        /// 交易渠道。
        /// </summary>
        /// <value>交易渠道。</value>
        [DataMember(Name = "trade_channel", EmitDefaultValue = false)]
        public string TradeChannel { get; set; }

        /// <summary>
        /// 该交易在支付宝系统中的交易流水号。 注意：若用户使用支付宝为交易的渠道，本参数必填。
        /// </summary>
        /// <value>该交易在支付宝系统中的交易流水号。 注意：若用户使用支付宝为交易的渠道，本参数必填。</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherUseDetailInfo
        /// </summary>
        [DataMember(Name = "voucher_use_detail_info", EmitDefaultValue = false)]
        public VoucherUseDetailInfo VoucherUseDetailInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingActivityOrdervoucherUseModel {\n");
            sb.Append("  BizDt: ").Append(BizDt).Append("\n");
            sb.Append("  GoodsDetail: ").Append(GoodsDetail).Append("\n");
            sb.Append("  MerchantAccessMode: ").Append(MerchantAccessMode).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  RealShopId: ").Append(RealShopId).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
            sb.Append("  TotalFee: ").Append(TotalFee).Append("\n");
            sb.Append("  TradeChannel: ").Append(TradeChannel).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
            sb.Append("  VoucherUseDetailInfo: ").Append(VoucherUseDetailInfo).Append("\n");
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
            return this.Equals(input as AlipayMarketingActivityOrdervoucherUseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingActivityOrdervoucherUseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingActivityOrdervoucherUseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingActivityOrdervoucherUseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BizDt == input.BizDt ||
                    (this.BizDt != null &&
                    this.BizDt.Equals(input.BizDt))
                ) && 
                (
                    this.GoodsDetail == input.GoodsDetail ||
                    this.GoodsDetail != null &&
                    input.GoodsDetail != null &&
                    this.GoodsDetail.SequenceEqual(input.GoodsDetail)
                ) && 
                (
                    this.MerchantAccessMode == input.MerchantAccessMode ||
                    (this.MerchantAccessMode != null &&
                    this.MerchantAccessMode.Equals(input.MerchantAccessMode))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.RealShopId == input.RealShopId ||
                    (this.RealShopId != null &&
                    this.RealShopId.Equals(input.RealShopId))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
                ) && 
                (
                    this.TotalFee == input.TotalFee ||
                    (this.TotalFee != null &&
                    this.TotalFee.Equals(input.TotalFee))
                ) && 
                (
                    this.TradeChannel == input.TradeChannel ||
                    (this.TradeChannel != null &&
                    this.TradeChannel.Equals(input.TradeChannel))
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
                ) && 
                (
                    this.VoucherUseDetailInfo == input.VoucherUseDetailInfo ||
                    (this.VoucherUseDetailInfo != null &&
                    this.VoucherUseDetailInfo.Equals(input.VoucherUseDetailInfo))
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
                if (this.BizDt != null)
                {
                    hashCode = (hashCode * 59) + this.BizDt.GetHashCode();
                }
                if (this.GoodsDetail != null)
                {
                    hashCode = (hashCode * 59) + this.GoodsDetail.GetHashCode();
                }
                if (this.MerchantAccessMode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantAccessMode.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.RealShopId != null)
                {
                    hashCode = (hashCode * 59) + this.RealShopId.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
                }
                if (this.TotalFee != null)
                {
                    hashCode = (hashCode * 59) + this.TotalFee.GetHashCode();
                }
                if (this.TradeChannel != null)
                {
                    hashCode = (hashCode * 59) + this.TradeChannel.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
                }
                if (this.VoucherUseDetailInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherUseDetailInfo.GetHashCode();
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
