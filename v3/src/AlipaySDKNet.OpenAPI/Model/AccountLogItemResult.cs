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
    /// AccountLogItemResult
    /// </summary>
    [DataContract(Name = "AccountLogItemResult")]
    public partial class AccountLogItemResult : IEquatable<AccountLogItemResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountLogItemResult" /> class.
        /// </summary>
        /// <param name="accountLogId">支付宝账务流水号。对账使用，不脱敏.</param>
        /// <param name="alipayOrderNo">支付宝订单号。对账使用，不脱敏.</param>
        /// <param name="balance">余额，仅供参考。由于架构原因，余额变动并不保证连续。也就是余额不一定等于上一笔余额减去当笔金额。但是会保证最终一致。.</param>
        /// <param name="billSource">业务账单来源，资金收支对应的上游业务订单数据来源，确认业务订单出处。此字段供商户对账使用，不脱敏。.</param>
        /// <param name="bizDesc">业务描述，资金收支对应的详细业务场景信息。此字段供商户对账使用，不脱敏。.</param>
        /// <param name="bizNos">业务订单号，资金收支相关的业务场景订单号明细，字母大写；M：平台交易主单号，S：平台交易子单号，O：业务系统单据号（如退款订单号）。此字段供商户对账使用，不脱敏。.</param>
        /// <param name="bizOrigNo">业务基础订单号，资金收支对应的原始业务订单唯一识别编号。此字段供商户对账使用，不脱敏。.</param>
        /// <param name="complementInfo">账单的补全信息，用于特殊场景，普通商户不需要传值，对账时可忽略。.</param>
        /// <param name="direction">收入/支出。表示收支。amount是正数，返回“收入”。amount是负数，返回“支出”.</param>
        /// <param name="merchantOrderNo">商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏.</param>
        /// <param name="merchantOutRefundNo">支付宝交易商户退款请求号。对应商户在调用收单退款接口openApi请求传入的outRequestNo参数值.</param>
        /// <param name="otherAccount">对方账户.</param>
        /// <param name="storeName">门店信息.</param>
        /// <param name="transAmount">金额.</param>
        /// <param name="transDt">入账时间.</param>
        /// <param name="transMemo">账务备注。由上游业务决定，不可依赖此字段进行对账.</param>
        /// <param name="type">账务记录的类型，仅供参考.</param>
        public AccountLogItemResult(string accountLogId = default(string), string alipayOrderNo = default(string), string balance = default(string), string billSource = default(string), string bizDesc = default(string), string bizNos = default(string), string bizOrigNo = default(string), string complementInfo = default(string), string direction = default(string), string merchantOrderNo = default(string), string merchantOutRefundNo = default(string), string otherAccount = default(string), string storeName = default(string), string transAmount = default(string), string transDt = default(string), string transMemo = default(string), string type = default(string))
        {
            this.AccountLogId = accountLogId;
            this.AlipayOrderNo = alipayOrderNo;
            this.Balance = balance;
            this.BillSource = billSource;
            this.BizDesc = bizDesc;
            this.BizNos = bizNos;
            this.BizOrigNo = bizOrigNo;
            this.ComplementInfo = complementInfo;
            this.Direction = direction;
            this.MerchantOrderNo = merchantOrderNo;
            this.MerchantOutRefundNo = merchantOutRefundNo;
            this.OtherAccount = otherAccount;
            this.StoreName = storeName;
            this.TransAmount = transAmount;
            this.TransDt = transDt;
            this.TransMemo = transMemo;
            this.Type = type;
        }

        /// <summary>
        /// 支付宝账务流水号。对账使用，不脱敏
        /// </summary>
        /// <value>支付宝账务流水号。对账使用，不脱敏</value>
        [DataMember(Name = "account_log_id", EmitDefaultValue = false)]
        public string AccountLogId { get; set; }

        /// <summary>
        /// 支付宝订单号。对账使用，不脱敏
        /// </summary>
        /// <value>支付宝订单号。对账使用，不脱敏</value>
        [DataMember(Name = "alipay_order_no", EmitDefaultValue = false)]
        public string AlipayOrderNo { get; set; }

        /// <summary>
        /// 余额，仅供参考。由于架构原因，余额变动并不保证连续。也就是余额不一定等于上一笔余额减去当笔金额。但是会保证最终一致。
        /// </summary>
        /// <value>余额，仅供参考。由于架构原因，余额变动并不保证连续。也就是余额不一定等于上一笔余额减去当笔金额。但是会保证最终一致。</value>
        [DataMember(Name = "balance", EmitDefaultValue = false)]
        public string Balance { get; set; }

        /// <summary>
        /// 业务账单来源，资金收支对应的上游业务订单数据来源，确认业务订单出处。此字段供商户对账使用，不脱敏。
        /// </summary>
        /// <value>业务账单来源，资金收支对应的上游业务订单数据来源，确认业务订单出处。此字段供商户对账使用，不脱敏。</value>
        [DataMember(Name = "bill_source", EmitDefaultValue = false)]
        public string BillSource { get; set; }

        /// <summary>
        /// 业务描述，资金收支对应的详细业务场景信息。此字段供商户对账使用，不脱敏。
        /// </summary>
        /// <value>业务描述，资金收支对应的详细业务场景信息。此字段供商户对账使用，不脱敏。</value>
        [DataMember(Name = "biz_desc", EmitDefaultValue = false)]
        public string BizDesc { get; set; }

        /// <summary>
        /// 业务订单号，资金收支相关的业务场景订单号明细，字母大写；M：平台交易主单号，S：平台交易子单号，O：业务系统单据号（如退款订单号）。此字段供商户对账使用，不脱敏。
        /// </summary>
        /// <value>业务订单号，资金收支相关的业务场景订单号明细，字母大写；M：平台交易主单号，S：平台交易子单号，O：业务系统单据号（如退款订单号）。此字段供商户对账使用，不脱敏。</value>
        [DataMember(Name = "biz_nos", EmitDefaultValue = false)]
        public string BizNos { get; set; }

        /// <summary>
        /// 业务基础订单号，资金收支对应的原始业务订单唯一识别编号。此字段供商户对账使用，不脱敏。
        /// </summary>
        /// <value>业务基础订单号，资金收支对应的原始业务订单唯一识别编号。此字段供商户对账使用，不脱敏。</value>
        [DataMember(Name = "biz_orig_no", EmitDefaultValue = false)]
        public string BizOrigNo { get; set; }

        /// <summary>
        /// 账单的补全信息，用于特殊场景，普通商户不需要传值，对账时可忽略。
        /// </summary>
        /// <value>账单的补全信息，用于特殊场景，普通商户不需要传值，对账时可忽略。</value>
        [DataMember(Name = "complement_info", EmitDefaultValue = false)]
        public string ComplementInfo { get; set; }

        /// <summary>
        /// 收入/支出。表示收支。amount是正数，返回“收入”。amount是负数，返回“支出”
        /// </summary>
        /// <value>收入/支出。表示收支。amount是正数，返回“收入”。amount是负数，返回“支出”</value>
        [DataMember(Name = "direction", EmitDefaultValue = false)]
        public string Direction { get; set; }

        /// <summary>
        /// 商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏
        /// </summary>
        /// <value>商户订单号，创建支付宝交易时传入的信息。对账使用，不脱敏</value>
        [DataMember(Name = "merchant_order_no", EmitDefaultValue = false)]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 支付宝交易商户退款请求号。对应商户在调用收单退款接口openApi请求传入的outRequestNo参数值
        /// </summary>
        /// <value>支付宝交易商户退款请求号。对应商户在调用收单退款接口openApi请求传入的outRequestNo参数值</value>
        [DataMember(Name = "merchant_out_refund_no", EmitDefaultValue = false)]
        public string MerchantOutRefundNo { get; set; }

        /// <summary>
        /// 对方账户
        /// </summary>
        /// <value>对方账户</value>
        [DataMember(Name = "other_account", EmitDefaultValue = false)]
        public string OtherAccount { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        /// <value>门店信息</value>
        [DataMember(Name = "store_name", EmitDefaultValue = false)]
        public string StoreName { get; set; }

        /// <summary>
        /// 金额
        /// </summary>
        /// <value>金额</value>
        [DataMember(Name = "trans_amount", EmitDefaultValue = false)]
        public string TransAmount { get; set; }

        /// <summary>
        /// 入账时间
        /// </summary>
        /// <value>入账时间</value>
        [DataMember(Name = "trans_dt", EmitDefaultValue = false)]
        public string TransDt { get; set; }

        /// <summary>
        /// 账务备注。由上游业务决定，不可依赖此字段进行对账
        /// </summary>
        /// <value>账务备注。由上游业务决定，不可依赖此字段进行对账</value>
        [DataMember(Name = "trans_memo", EmitDefaultValue = false)]
        public string TransMemo { get; set; }

        /// <summary>
        /// 账务记录的类型，仅供参考
        /// </summary>
        /// <value>账务记录的类型，仅供参考</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountLogItemResult {\n");
            sb.Append("  AccountLogId: ").Append(AccountLogId).Append("\n");
            sb.Append("  AlipayOrderNo: ").Append(AlipayOrderNo).Append("\n");
            sb.Append("  Balance: ").Append(Balance).Append("\n");
            sb.Append("  BillSource: ").Append(BillSource).Append("\n");
            sb.Append("  BizDesc: ").Append(BizDesc).Append("\n");
            sb.Append("  BizNos: ").Append(BizNos).Append("\n");
            sb.Append("  BizOrigNo: ").Append(BizOrigNo).Append("\n");
            sb.Append("  ComplementInfo: ").Append(ComplementInfo).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  MerchantOrderNo: ").Append(MerchantOrderNo).Append("\n");
            sb.Append("  MerchantOutRefundNo: ").Append(MerchantOutRefundNo).Append("\n");
            sb.Append("  OtherAccount: ").Append(OtherAccount).Append("\n");
            sb.Append("  StoreName: ").Append(StoreName).Append("\n");
            sb.Append("  TransAmount: ").Append(TransAmount).Append("\n");
            sb.Append("  TransDt: ").Append(TransDt).Append("\n");
            sb.Append("  TransMemo: ").Append(TransMemo).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as AccountLogItemResult);
        }

        /// <summary>
        /// Returns true if AccountLogItemResult instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountLogItemResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountLogItemResult input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountLogId == input.AccountLogId ||
                    (this.AccountLogId != null &&
                    this.AccountLogId.Equals(input.AccountLogId))
                ) && 
                (
                    this.AlipayOrderNo == input.AlipayOrderNo ||
                    (this.AlipayOrderNo != null &&
                    this.AlipayOrderNo.Equals(input.AlipayOrderNo))
                ) && 
                (
                    this.Balance == input.Balance ||
                    (this.Balance != null &&
                    this.Balance.Equals(input.Balance))
                ) && 
                (
                    this.BillSource == input.BillSource ||
                    (this.BillSource != null &&
                    this.BillSource.Equals(input.BillSource))
                ) && 
                (
                    this.BizDesc == input.BizDesc ||
                    (this.BizDesc != null &&
                    this.BizDesc.Equals(input.BizDesc))
                ) && 
                (
                    this.BizNos == input.BizNos ||
                    (this.BizNos != null &&
                    this.BizNos.Equals(input.BizNos))
                ) && 
                (
                    this.BizOrigNo == input.BizOrigNo ||
                    (this.BizOrigNo != null &&
                    this.BizOrigNo.Equals(input.BizOrigNo))
                ) && 
                (
                    this.ComplementInfo == input.ComplementInfo ||
                    (this.ComplementInfo != null &&
                    this.ComplementInfo.Equals(input.ComplementInfo))
                ) && 
                (
                    this.Direction == input.Direction ||
                    (this.Direction != null &&
                    this.Direction.Equals(input.Direction))
                ) && 
                (
                    this.MerchantOrderNo == input.MerchantOrderNo ||
                    (this.MerchantOrderNo != null &&
                    this.MerchantOrderNo.Equals(input.MerchantOrderNo))
                ) && 
                (
                    this.MerchantOutRefundNo == input.MerchantOutRefundNo ||
                    (this.MerchantOutRefundNo != null &&
                    this.MerchantOutRefundNo.Equals(input.MerchantOutRefundNo))
                ) && 
                (
                    this.OtherAccount == input.OtherAccount ||
                    (this.OtherAccount != null &&
                    this.OtherAccount.Equals(input.OtherAccount))
                ) && 
                (
                    this.StoreName == input.StoreName ||
                    (this.StoreName != null &&
                    this.StoreName.Equals(input.StoreName))
                ) && 
                (
                    this.TransAmount == input.TransAmount ||
                    (this.TransAmount != null &&
                    this.TransAmount.Equals(input.TransAmount))
                ) && 
                (
                    this.TransDt == input.TransDt ||
                    (this.TransDt != null &&
                    this.TransDt.Equals(input.TransDt))
                ) && 
                (
                    this.TransMemo == input.TransMemo ||
                    (this.TransMemo != null &&
                    this.TransMemo.Equals(input.TransMemo))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.AccountLogId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountLogId.GetHashCode();
                }
                if (this.AlipayOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.AlipayOrderNo.GetHashCode();
                }
                if (this.Balance != null)
                {
                    hashCode = (hashCode * 59) + this.Balance.GetHashCode();
                }
                if (this.BillSource != null)
                {
                    hashCode = (hashCode * 59) + this.BillSource.GetHashCode();
                }
                if (this.BizDesc != null)
                {
                    hashCode = (hashCode * 59) + this.BizDesc.GetHashCode();
                }
                if (this.BizNos != null)
                {
                    hashCode = (hashCode * 59) + this.BizNos.GetHashCode();
                }
                if (this.BizOrigNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizOrigNo.GetHashCode();
                }
                if (this.ComplementInfo != null)
                {
                    hashCode = (hashCode * 59) + this.ComplementInfo.GetHashCode();
                }
                if (this.Direction != null)
                {
                    hashCode = (hashCode * 59) + this.Direction.GetHashCode();
                }
                if (this.MerchantOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantOrderNo.GetHashCode();
                }
                if (this.MerchantOutRefundNo != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantOutRefundNo.GetHashCode();
                }
                if (this.OtherAccount != null)
                {
                    hashCode = (hashCode * 59) + this.OtherAccount.GetHashCode();
                }
                if (this.StoreName != null)
                {
                    hashCode = (hashCode * 59) + this.StoreName.GetHashCode();
                }
                if (this.TransAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TransAmount.GetHashCode();
                }
                if (this.TransDt != null)
                {
                    hashCode = (hashCode * 59) + this.TransDt.GetHashCode();
                }
                if (this.TransMemo != null)
                {
                    hashCode = (hashCode * 59) + this.TransMemo.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
