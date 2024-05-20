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
    /// AlipayTradeCustomsDeclareModel
    /// </summary>
    [DataContract(Name = "AlipayTradeCustomsDeclareModel")]
    public partial class AlipayTradeCustomsDeclareModel : IEquatable<AlipayTradeCustomsDeclareModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayTradeCustomsDeclareModel" /> class.
        /// </summary>
        /// <param name="amount">报关金额，单位为人民币“元”，精确到小数点后2位。.</param>
        /// <param name="buyerInfo">buyerInfo.</param>
        /// <param name="customsPlace">海关编号（大小写皆可）。参见“ &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/01x3kh#%E6%B5%B7%E5%85%B3%E7%BC%96%E5%8F%B7\&quot;&gt;海关编号&lt;/a&gt;”。.</param>
        /// <param name="declareMode">报关模式，默认可空，1表示需要强校验买家和支付人的身份信息。.</param>
        /// <param name="depositTradeNo">定金在支付宝系统中的交易流水号，最长64位。当该参数不为空时，代表为”定金+尾款“报关场景。.</param>
        /// <param name="isSplit">商户控制本单是否拆单的报关参数。  仅当该参数传值为T或者t时，才会触发拆单。.</param>
        /// <param name="merchantCustomsCode">商户在海关备案的编号。.</param>
        /// <param name="merchantCustomsName">商户海关备案名称。.</param>
        /// <param name="merchantId">国际站商户标识.</param>
        /// <param name="outRequestNo">报关流水号。商户生成的用于唯一标识一次报关操作的业务编号。 建议生成规则：yyyymmdd型8位日期拼接4位序列号。每个报关请求号仅允许传入：数字、英文字母、下划线”_”、短横线”－” 。长度6-64位前后不能有空格.</param>
        /// <param name="outTradeNo">国际站外部订单号.</param>
        /// <param name="subOutBizNo">拆单报关的商户子订单号。 用于区别拆单时不同子单。拆单时必须传入，否则会报INVALID_PARAMETER错误码。.</param>
        /// <param name="tradeNo">支付宝交易号。该交易在支付宝系统中的交易流水号，最长64位。.</param>
        public AlipayTradeCustomsDeclareModel(string amount = default(string), CustomsDeclareBuyerInfo buyerInfo = default(CustomsDeclareBuyerInfo), string customsPlace = default(string), int declareMode = default(int), string depositTradeNo = default(string), string isSplit = default(string), string merchantCustomsCode = default(string), string merchantCustomsName = default(string), string merchantId = default(string), string outRequestNo = default(string), string outTradeNo = default(string), string subOutBizNo = default(string), string tradeNo = default(string))
        {
            this.Amount = amount;
            this.BuyerInfo = buyerInfo;
            this.CustomsPlace = customsPlace;
            this.DeclareMode = declareMode;
            this.DepositTradeNo = depositTradeNo;
            this.IsSplit = isSplit;
            this.MerchantCustomsCode = merchantCustomsCode;
            this.MerchantCustomsName = merchantCustomsName;
            this.MerchantId = merchantId;
            this.OutRequestNo = outRequestNo;
            this.OutTradeNo = outTradeNo;
            this.SubOutBizNo = subOutBizNo;
            this.TradeNo = tradeNo;
        }

        /// <summary>
        /// 报关金额，单位为人民币“元”，精确到小数点后2位。
        /// </summary>
        /// <value>报关金额，单位为人民币“元”，精确到小数点后2位。</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// Gets or Sets BuyerInfo
        /// </summary>
        [DataMember(Name = "buyer_info", EmitDefaultValue = false)]
        public CustomsDeclareBuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// 海关编号（大小写皆可）。参见“ &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/01x3kh#%E6%B5%B7%E5%85%B3%E7%BC%96%E5%8F%B7\&quot;&gt;海关编号&lt;/a&gt;”。
        /// </summary>
        /// <value>海关编号（大小写皆可）。参见“ &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/pre-open/01x3kh#%E6%B5%B7%E5%85%B3%E7%BC%96%E5%8F%B7\&quot;&gt;海关编号&lt;/a&gt;”。</value>
        [DataMember(Name = "customs_place", EmitDefaultValue = false)]
        public string CustomsPlace { get; set; }

        /// <summary>
        /// 报关模式，默认可空，1表示需要强校验买家和支付人的身份信息。
        /// </summary>
        /// <value>报关模式，默认可空，1表示需要强校验买家和支付人的身份信息。</value>
        [DataMember(Name = "declare_mode", EmitDefaultValue = false)]
        public int DeclareMode { get; set; }

        /// <summary>
        /// 定金在支付宝系统中的交易流水号，最长64位。当该参数不为空时，代表为”定金+尾款“报关场景。
        /// </summary>
        /// <value>定金在支付宝系统中的交易流水号，最长64位。当该参数不为空时，代表为”定金+尾款“报关场景。</value>
        [DataMember(Name = "deposit_trade_no", EmitDefaultValue = false)]
        public string DepositTradeNo { get; set; }

        /// <summary>
        /// 商户控制本单是否拆单的报关参数。  仅当该参数传值为T或者t时，才会触发拆单。
        /// </summary>
        /// <value>商户控制本单是否拆单的报关参数。  仅当该参数传值为T或者t时，才会触发拆单。</value>
        [DataMember(Name = "is_split", EmitDefaultValue = false)]
        public string IsSplit { get; set; }

        /// <summary>
        /// 商户在海关备案的编号。
        /// </summary>
        /// <value>商户在海关备案的编号。</value>
        [DataMember(Name = "merchant_customs_code", EmitDefaultValue = false)]
        public string MerchantCustomsCode { get; set; }

        /// <summary>
        /// 商户海关备案名称。
        /// </summary>
        /// <value>商户海关备案名称。</value>
        [DataMember(Name = "merchant_customs_name", EmitDefaultValue = false)]
        public string MerchantCustomsName { get; set; }

        /// <summary>
        /// 国际站商户标识
        /// </summary>
        /// <value>国际站商户标识</value>
        [DataMember(Name = "merchant_id", EmitDefaultValue = false)]
        public string MerchantId { get; set; }

        /// <summary>
        /// 报关流水号。商户生成的用于唯一标识一次报关操作的业务编号。 建议生成规则：yyyymmdd型8位日期拼接4位序列号。每个报关请求号仅允许传入：数字、英文字母、下划线”_”、短横线”－” 。长度6-64位前后不能有空格
        /// </summary>
        /// <value>报关流水号。商户生成的用于唯一标识一次报关操作的业务编号。 建议生成规则：yyyymmdd型8位日期拼接4位序列号。每个报关请求号仅允许传入：数字、英文字母、下划线”_”、短横线”－” 。长度6-64位前后不能有空格</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 国际站外部订单号
        /// </summary>
        /// <value>国际站外部订单号</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 拆单报关的商户子订单号。 用于区别拆单时不同子单。拆单时必须传入，否则会报INVALID_PARAMETER错误码。
        /// </summary>
        /// <value>拆单报关的商户子订单号。 用于区别拆单时不同子单。拆单时必须传入，否则会报INVALID_PARAMETER错误码。</value>
        [DataMember(Name = "sub_out_biz_no", EmitDefaultValue = false)]
        public string SubOutBizNo { get; set; }

        /// <summary>
        /// 支付宝交易号。该交易在支付宝系统中的交易流水号，最长64位。
        /// </summary>
        /// <value>支付宝交易号。该交易在支付宝系统中的交易流水号，最长64位。</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayTradeCustomsDeclareModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BuyerInfo: ").Append(BuyerInfo).Append("\n");
            sb.Append("  CustomsPlace: ").Append(CustomsPlace).Append("\n");
            sb.Append("  DeclareMode: ").Append(DeclareMode).Append("\n");
            sb.Append("  DepositTradeNo: ").Append(DepositTradeNo).Append("\n");
            sb.Append("  IsSplit: ").Append(IsSplit).Append("\n");
            sb.Append("  MerchantCustomsCode: ").Append(MerchantCustomsCode).Append("\n");
            sb.Append("  MerchantCustomsName: ").Append(MerchantCustomsName).Append("\n");
            sb.Append("  MerchantId: ").Append(MerchantId).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  SubOutBizNo: ").Append(SubOutBizNo).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
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
            return this.Equals(input as AlipayTradeCustomsDeclareModel);
        }

        /// <summary>
        /// Returns true if AlipayTradeCustomsDeclareModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayTradeCustomsDeclareModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayTradeCustomsDeclareModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BuyerInfo == input.BuyerInfo ||
                    (this.BuyerInfo != null &&
                    this.BuyerInfo.Equals(input.BuyerInfo))
                ) && 
                (
                    this.CustomsPlace == input.CustomsPlace ||
                    (this.CustomsPlace != null &&
                    this.CustomsPlace.Equals(input.CustomsPlace))
                ) && 
                (
                    this.DeclareMode == input.DeclareMode ||
                    this.DeclareMode.Equals(input.DeclareMode)
                ) && 
                (
                    this.DepositTradeNo == input.DepositTradeNo ||
                    (this.DepositTradeNo != null &&
                    this.DepositTradeNo.Equals(input.DepositTradeNo))
                ) && 
                (
                    this.IsSplit == input.IsSplit ||
                    (this.IsSplit != null &&
                    this.IsSplit.Equals(input.IsSplit))
                ) && 
                (
                    this.MerchantCustomsCode == input.MerchantCustomsCode ||
                    (this.MerchantCustomsCode != null &&
                    this.MerchantCustomsCode.Equals(input.MerchantCustomsCode))
                ) && 
                (
                    this.MerchantCustomsName == input.MerchantCustomsName ||
                    (this.MerchantCustomsName != null &&
                    this.MerchantCustomsName.Equals(input.MerchantCustomsName))
                ) && 
                (
                    this.MerchantId == input.MerchantId ||
                    (this.MerchantId != null &&
                    this.MerchantId.Equals(input.MerchantId))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.OutTradeNo == input.OutTradeNo ||
                    (this.OutTradeNo != null &&
                    this.OutTradeNo.Equals(input.OutTradeNo))
                ) && 
                (
                    this.SubOutBizNo == input.SubOutBizNo ||
                    (this.SubOutBizNo != null &&
                    this.SubOutBizNo.Equals(input.SubOutBizNo))
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BuyerInfo != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerInfo.GetHashCode();
                }
                if (this.CustomsPlace != null)
                {
                    hashCode = (hashCode * 59) + this.CustomsPlace.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeclareMode.GetHashCode();
                if (this.DepositTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.DepositTradeNo.GetHashCode();
                }
                if (this.IsSplit != null)
                {
                    hashCode = (hashCode * 59) + this.IsSplit.GetHashCode();
                }
                if (this.MerchantCustomsCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCustomsCode.GetHashCode();
                }
                if (this.MerchantCustomsName != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCustomsName.GetHashCode();
                }
                if (this.MerchantId != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantId.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.SubOutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.SubOutBizNo.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
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
