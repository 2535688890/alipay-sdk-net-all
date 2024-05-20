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
    /// AlipayFundJointaccountTradeQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundJointaccountTradeQueryResponseModel")]
    public partial class AlipayFundJointaccountTradeQueryResponseModel : IEquatable<AlipayFundJointaccountTradeQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundJointaccountTradeQueryResponseModel" /> class.
        /// </summary>
        /// <param name="buyerId">买家ID.</param>
        /// <param name="buyerOpenId">买家的openId.</param>
        /// <param name="createTime">交易创建时间.</param>
        /// <param name="totalAmount">订单总金额.</param>
        /// <param name="tradeFundBillList">资金单明细.</param>
        /// <param name="tradeInfoList">交易信息集合。查询为批量查询时，使用该结果返回.</param>
        /// <param name="tradeNo">交易单号.</param>
        /// <param name="tradeStatus">交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）.</param>
        public AlipayFundJointaccountTradeQueryResponseModel(string buyerId = default(string), string buyerOpenId = default(string), string createTime = default(string), string totalAmount = default(string), List<TradeFundBillDetail> tradeFundBillList = default(List<TradeFundBillDetail>), List<TradeInfoDTO> tradeInfoList = default(List<TradeInfoDTO>), string tradeNo = default(string), string tradeStatus = default(string))
        {
            this.BuyerId = buyerId;
            this.BuyerOpenId = buyerOpenId;
            this.CreateTime = createTime;
            this.TotalAmount = totalAmount;
            this.TradeFundBillList = tradeFundBillList;
            this.TradeInfoList = tradeInfoList;
            this.TradeNo = tradeNo;
            this.TradeStatus = tradeStatus;
        }

        /// <summary>
        /// 买家ID
        /// </summary>
        /// <value>买家ID</value>
        [DataMember(Name = "buyer_id", EmitDefaultValue = false)]
        public string BuyerId { get; set; }

        /// <summary>
        /// 买家的openId
        /// </summary>
        /// <value>买家的openId</value>
        [DataMember(Name = "buyer_open_id", EmitDefaultValue = false)]
        public string BuyerOpenId { get; set; }

        /// <summary>
        /// 交易创建时间
        /// </summary>
        /// <value>交易创建时间</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        /// <value>订单总金额</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = false)]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 资金单明细
        /// </summary>
        /// <value>资金单明细</value>
        [DataMember(Name = "trade_fund_bill_list", EmitDefaultValue = false)]
        public List<TradeFundBillDetail> TradeFundBillList { get; set; }

        /// <summary>
        /// 交易信息集合。查询为批量查询时，使用该结果返回
        /// </summary>
        /// <value>交易信息集合。查询为批量查询时，使用该结果返回</value>
        [DataMember(Name = "trade_info_list", EmitDefaultValue = false)]
        public List<TradeInfoDTO> TradeInfoList { get; set; }

        /// <summary>
        /// 交易单号
        /// </summary>
        /// <value>交易单号</value>
        [DataMember(Name = "trade_no", EmitDefaultValue = false)]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        /// <value>交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）</value>
        [DataMember(Name = "trade_status", EmitDefaultValue = false)]
        public string TradeStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundJointaccountTradeQueryResponseModel {\n");
            sb.Append("  BuyerId: ").Append(BuyerId).Append("\n");
            sb.Append("  BuyerOpenId: ").Append(BuyerOpenId).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  TradeFundBillList: ").Append(TradeFundBillList).Append("\n");
            sb.Append("  TradeInfoList: ").Append(TradeInfoList).Append("\n");
            sb.Append("  TradeNo: ").Append(TradeNo).Append("\n");
            sb.Append("  TradeStatus: ").Append(TradeStatus).Append("\n");
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
            return this.Equals(input as AlipayFundJointaccountTradeQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundJointaccountTradeQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundJointaccountTradeQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundJointaccountTradeQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BuyerId == input.BuyerId ||
                    (this.BuyerId != null &&
                    this.BuyerId.Equals(input.BuyerId))
                ) && 
                (
                    this.BuyerOpenId == input.BuyerOpenId ||
                    (this.BuyerOpenId != null &&
                    this.BuyerOpenId.Equals(input.BuyerOpenId))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.TradeFundBillList == input.TradeFundBillList ||
                    this.TradeFundBillList != null &&
                    input.TradeFundBillList != null &&
                    this.TradeFundBillList.SequenceEqual(input.TradeFundBillList)
                ) && 
                (
                    this.TradeInfoList == input.TradeInfoList ||
                    this.TradeInfoList != null &&
                    input.TradeInfoList != null &&
                    this.TradeInfoList.SequenceEqual(input.TradeInfoList)
                ) && 
                (
                    this.TradeNo == input.TradeNo ||
                    (this.TradeNo != null &&
                    this.TradeNo.Equals(input.TradeNo))
                ) && 
                (
                    this.TradeStatus == input.TradeStatus ||
                    (this.TradeStatus != null &&
                    this.TradeStatus.Equals(input.TradeStatus))
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
                if (this.BuyerId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerId.GetHashCode();
                }
                if (this.BuyerOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.BuyerOpenId.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                if (this.TotalAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalAmount.GetHashCode();
                }
                if (this.TradeFundBillList != null)
                {
                    hashCode = (hashCode * 59) + this.TradeFundBillList.GetHashCode();
                }
                if (this.TradeInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.TradeInfoList.GetHashCode();
                }
                if (this.TradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.TradeNo.GetHashCode();
                }
                if (this.TradeStatus != null)
                {
                    hashCode = (hashCode * 59) + this.TradeStatus.GetHashCode();
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
