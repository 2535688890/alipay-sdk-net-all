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
    /// CompleteVoucherInfo
    /// </summary>
    [DataContract(Name = "CompleteVoucherInfo")]
    public partial class CompleteVoucherInfo : IEquatable<CompleteVoucherInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompleteVoucherInfo" /> class.
        /// </summary>
        /// <param name="antiFakeCode">防伪码.</param>
        /// <param name="checkSum">校验码.</param>
        /// <param name="deviceNo">开票机器码.</param>
        /// <param name="fileDownloadUrl">板式文件下载地址.</param>
        /// <param name="fileType">板式文件的类型.</param>
        /// <param name="invoiceAmount">发票金额（元）.</param>
        /// <param name="invoiceCode">发票代码.</param>
        /// <param name="invoiceContentList">汇总发票详细信息(目前该字段为空).</param>
        /// <param name="invoiceDate">发票日期.</param>
        /// <param name="invoiceKind">发票类型 0：增值税普通电子发票 1：增值税普通发票 2：增值税专用发票 3：增值税专用电子发票 4：财政电子发票.</param>
        /// <param name="invoiceMemo">备注.</param>
        /// <param name="invoiceNo">发票号码.</param>
        /// <param name="invoiceSource">发票来源，取值范围 SUMMARY_INVOICE_AUTO_OPEN 汇总开票系统自动开票，SUMMARY_INVOICE_MERCHANT_UPLOAD 汇总开票商户手动上传.</param>
        /// <param name="invoiceTitle">发票抬头.</param>
        /// <param name="invoiceType">发票类型(红、蓝).</param>
        /// <param name="payeeAddress">销售方地址.</param>
        /// <param name="payeeBankAccount">销售方银行账号.</param>
        /// <param name="payeeBankName">销售方银行名称.</param>
        /// <param name="payeeChecker">复核人.</param>
        /// <param name="payeeMobile">销售方电话.</param>
        /// <param name="payeeName">销售方名称.</param>
        /// <param name="payeeOperator">开票人.</param>
        /// <param name="payeeReceiver">收款人.</param>
        /// <param name="payeeRegisterNo">销售方税号.</param>
        /// <param name="payerAddress">购买方地址.</param>
        /// <param name="payerBankAccount">购买方银行账号.</param>
        /// <param name="payerBankName">购买方银行名称.</param>
        /// <param name="payerMobile">购买方电话.</param>
        /// <param name="payerName">购买方名称.</param>
        /// <param name="payerRegisterNo">购买方税号.</param>
        /// <param name="sumPrice">不含税金额（元）.</param>
        /// <param name="sumTax">合计税额（元）.</param>
        public CompleteVoucherInfo(string antiFakeCode = default(string), string checkSum = default(string), string deviceNo = default(string), string fileDownloadUrl = default(string), string fileType = default(string), int invoiceAmount = default(int), string invoiceCode = default(string), List<InvoiceContentInfo> invoiceContentList = default(List<InvoiceContentInfo>), string invoiceDate = default(string), int invoiceKind = default(int), string invoiceMemo = default(string), string invoiceNo = default(string), string invoiceSource = default(string), string invoiceTitle = default(string), string invoiceType = default(string), string payeeAddress = default(string), string payeeBankAccount = default(string), string payeeBankName = default(string), string payeeChecker = default(string), string payeeMobile = default(string), string payeeName = default(string), string payeeOperator = default(string), string payeeReceiver = default(string), string payeeRegisterNo = default(string), string payerAddress = default(string), string payerBankAccount = default(string), string payerBankName = default(string), string payerMobile = default(string), string payerName = default(string), string payerRegisterNo = default(string), int sumPrice = default(int), int sumTax = default(int))
        {
            this.AntiFakeCode = antiFakeCode;
            this.CheckSum = checkSum;
            this.DeviceNo = deviceNo;
            this.FileDownloadUrl = fileDownloadUrl;
            this.FileType = fileType;
            this.InvoiceAmount = invoiceAmount;
            this.InvoiceCode = invoiceCode;
            this.InvoiceContentList = invoiceContentList;
            this.InvoiceDate = invoiceDate;
            this.InvoiceKind = invoiceKind;
            this.InvoiceMemo = invoiceMemo;
            this.InvoiceNo = invoiceNo;
            this.InvoiceSource = invoiceSource;
            this.InvoiceTitle = invoiceTitle;
            this.InvoiceType = invoiceType;
            this.PayeeAddress = payeeAddress;
            this.PayeeBankAccount = payeeBankAccount;
            this.PayeeBankName = payeeBankName;
            this.PayeeChecker = payeeChecker;
            this.PayeeMobile = payeeMobile;
            this.PayeeName = payeeName;
            this.PayeeOperator = payeeOperator;
            this.PayeeReceiver = payeeReceiver;
            this.PayeeRegisterNo = payeeRegisterNo;
            this.PayerAddress = payerAddress;
            this.PayerBankAccount = payerBankAccount;
            this.PayerBankName = payerBankName;
            this.PayerMobile = payerMobile;
            this.PayerName = payerName;
            this.PayerRegisterNo = payerRegisterNo;
            this.SumPrice = sumPrice;
            this.SumTax = sumTax;
        }

        /// <summary>
        /// 防伪码
        /// </summary>
        /// <value>防伪码</value>
        [DataMember(Name = "anti_fake_code", EmitDefaultValue = false)]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 校验码
        /// </summary>
        /// <value>校验码</value>
        [DataMember(Name = "check_sum", EmitDefaultValue = false)]
        public string CheckSum { get; set; }

        /// <summary>
        /// 开票机器码
        /// </summary>
        /// <value>开票机器码</value>
        [DataMember(Name = "device_no", EmitDefaultValue = false)]
        public string DeviceNo { get; set; }

        /// <summary>
        /// 板式文件下载地址
        /// </summary>
        /// <value>板式文件下载地址</value>
        [DataMember(Name = "file_download_url", EmitDefaultValue = false)]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 板式文件的类型
        /// </summary>
        /// <value>板式文件的类型</value>
        [DataMember(Name = "file_type", EmitDefaultValue = false)]
        public string FileType { get; set; }

        /// <summary>
        /// 发票金额（元）
        /// </summary>
        /// <value>发票金额（元）</value>
        [DataMember(Name = "invoice_amount", EmitDefaultValue = false)]
        public int InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        /// <value>发票代码</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 汇总发票详细信息(目前该字段为空)
        /// </summary>
        /// <value>汇总发票详细信息(目前该字段为空)</value>
        [DataMember(Name = "invoice_content_list", EmitDefaultValue = false)]
        public List<InvoiceContentInfo> InvoiceContentList { get; set; }

        /// <summary>
        /// 发票日期
        /// </summary>
        /// <value>发票日期</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票类型 0：增值税普通电子发票 1：增值税普通发票 2：增值税专用发票 3：增值税专用电子发票 4：财政电子发票
        /// </summary>
        /// <value>发票类型 0：增值税普通电子发票 1：增值税普通发票 2：增值税专用发票 3：增值税专用电子发票 4：财政电子发票</value>
        [DataMember(Name = "invoice_kind", EmitDefaultValue = false)]
        public int InvoiceKind { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "invoice_memo", EmitDefaultValue = false)]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        /// <value>发票号码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票来源，取值范围 SUMMARY_INVOICE_AUTO_OPEN 汇总开票系统自动开票，SUMMARY_INVOICE_MERCHANT_UPLOAD 汇总开票商户手动上传
        /// </summary>
        /// <value>发票来源，取值范围 SUMMARY_INVOICE_AUTO_OPEN 汇总开票系统自动开票，SUMMARY_INVOICE_MERCHANT_UPLOAD 汇总开票商户手动上传</value>
        [DataMember(Name = "invoice_source", EmitDefaultValue = false)]
        public string InvoiceSource { get; set; }

        /// <summary>
        /// 发票抬头
        /// </summary>
        /// <value>发票抬头</value>
        [DataMember(Name = "invoice_title", EmitDefaultValue = false)]
        public string InvoiceTitle { get; set; }

        /// <summary>
        /// 发票类型(红、蓝)
        /// </summary>
        /// <value>发票类型(红、蓝)</value>
        [DataMember(Name = "invoice_type", EmitDefaultValue = false)]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        /// <value>销售方地址</value>
        [DataMember(Name = "payee_address", EmitDefaultValue = false)]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销售方银行账号
        /// </summary>
        /// <value>销售方银行账号</value>
        [DataMember(Name = "payee_bank_account", EmitDefaultValue = false)]
        public string PayeeBankAccount { get; set; }

        /// <summary>
        /// 销售方银行名称
        /// </summary>
        /// <value>销售方银行名称</value>
        [DataMember(Name = "payee_bank_name", EmitDefaultValue = false)]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 复核人
        /// </summary>
        /// <value>复核人</value>
        [DataMember(Name = "payee_checker", EmitDefaultValue = false)]
        public string PayeeChecker { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        /// <value>销售方电话</value>
        [DataMember(Name = "payee_mobile", EmitDefaultValue = false)]
        public string PayeeMobile { get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        /// <value>销售方名称</value>
        [DataMember(Name = "payee_name", EmitDefaultValue = false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// 开票人
        /// </summary>
        /// <value>开票人</value>
        [DataMember(Name = "payee_operator", EmitDefaultValue = false)]
        public string PayeeOperator { get; set; }

        /// <summary>
        /// 收款人
        /// </summary>
        /// <value>收款人</value>
        [DataMember(Name = "payee_receiver", EmitDefaultValue = false)]
        public string PayeeReceiver { get; set; }

        /// <summary>
        /// 销售方税号
        /// </summary>
        /// <value>销售方税号</value>
        [DataMember(Name = "payee_register_no", EmitDefaultValue = false)]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 购买方地址
        /// </summary>
        /// <value>购买方地址</value>
        [DataMember(Name = "payer_address", EmitDefaultValue = false)]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购买方银行账号
        /// </summary>
        /// <value>购买方银行账号</value>
        [DataMember(Name = "payer_bank_account", EmitDefaultValue = false)]
        public string PayerBankAccount { get; set; }

        /// <summary>
        /// 购买方银行名称
        /// </summary>
        /// <value>购买方银行名称</value>
        [DataMember(Name = "payer_bank_name", EmitDefaultValue = false)]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        /// <value>购买方电话</value>
        [DataMember(Name = "payer_mobile", EmitDefaultValue = false)]
        public string PayerMobile { get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        /// <value>购买方名称</value>
        [DataMember(Name = "payer_name", EmitDefaultValue = false)]
        public string PayerName { get; set; }

        /// <summary>
        /// 购买方税号
        /// </summary>
        /// <value>购买方税号</value>
        [DataMember(Name = "payer_register_no", EmitDefaultValue = false)]
        public string PayerRegisterNo { get; set; }

        /// <summary>
        /// 不含税金额（元）
        /// </summary>
        /// <value>不含税金额（元）</value>
        [DataMember(Name = "sum_price", EmitDefaultValue = false)]
        public int SumPrice { get; set; }

        /// <summary>
        /// 合计税额（元）
        /// </summary>
        /// <value>合计税额（元）</value>
        [DataMember(Name = "sum_tax", EmitDefaultValue = false)]
        public int SumTax { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CompleteVoucherInfo {\n");
            sb.Append("  AntiFakeCode: ").Append(AntiFakeCode).Append("\n");
            sb.Append("  CheckSum: ").Append(CheckSum).Append("\n");
            sb.Append("  DeviceNo: ").Append(DeviceNo).Append("\n");
            sb.Append("  FileDownloadUrl: ").Append(FileDownloadUrl).Append("\n");
            sb.Append("  FileType: ").Append(FileType).Append("\n");
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceContentList: ").Append(InvoiceContentList).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceKind: ").Append(InvoiceKind).Append("\n");
            sb.Append("  InvoiceMemo: ").Append(InvoiceMemo).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  InvoiceSource: ").Append(InvoiceSource).Append("\n");
            sb.Append("  InvoiceTitle: ").Append(InvoiceTitle).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  PayeeAddress: ").Append(PayeeAddress).Append("\n");
            sb.Append("  PayeeBankAccount: ").Append(PayeeBankAccount).Append("\n");
            sb.Append("  PayeeBankName: ").Append(PayeeBankName).Append("\n");
            sb.Append("  PayeeChecker: ").Append(PayeeChecker).Append("\n");
            sb.Append("  PayeeMobile: ").Append(PayeeMobile).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  PayeeOperator: ").Append(PayeeOperator).Append("\n");
            sb.Append("  PayeeReceiver: ").Append(PayeeReceiver).Append("\n");
            sb.Append("  PayeeRegisterNo: ").Append(PayeeRegisterNo).Append("\n");
            sb.Append("  PayerAddress: ").Append(PayerAddress).Append("\n");
            sb.Append("  PayerBankAccount: ").Append(PayerBankAccount).Append("\n");
            sb.Append("  PayerBankName: ").Append(PayerBankName).Append("\n");
            sb.Append("  PayerMobile: ").Append(PayerMobile).Append("\n");
            sb.Append("  PayerName: ").Append(PayerName).Append("\n");
            sb.Append("  PayerRegisterNo: ").Append(PayerRegisterNo).Append("\n");
            sb.Append("  SumPrice: ").Append(SumPrice).Append("\n");
            sb.Append("  SumTax: ").Append(SumTax).Append("\n");
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
            return this.Equals(input as CompleteVoucherInfo);
        }

        /// <summary>
        /// Returns true if CompleteVoucherInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CompleteVoucherInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompleteVoucherInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AntiFakeCode == input.AntiFakeCode ||
                    (this.AntiFakeCode != null &&
                    this.AntiFakeCode.Equals(input.AntiFakeCode))
                ) && 
                (
                    this.CheckSum == input.CheckSum ||
                    (this.CheckSum != null &&
                    this.CheckSum.Equals(input.CheckSum))
                ) && 
                (
                    this.DeviceNo == input.DeviceNo ||
                    (this.DeviceNo != null &&
                    this.DeviceNo.Equals(input.DeviceNo))
                ) && 
                (
                    this.FileDownloadUrl == input.FileDownloadUrl ||
                    (this.FileDownloadUrl != null &&
                    this.FileDownloadUrl.Equals(input.FileDownloadUrl))
                ) && 
                (
                    this.FileType == input.FileType ||
                    (this.FileType != null &&
                    this.FileType.Equals(input.FileType))
                ) && 
                (
                    this.InvoiceAmount == input.InvoiceAmount ||
                    this.InvoiceAmount.Equals(input.InvoiceAmount)
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceContentList == input.InvoiceContentList ||
                    this.InvoiceContentList != null &&
                    input.InvoiceContentList != null &&
                    this.InvoiceContentList.SequenceEqual(input.InvoiceContentList)
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceKind == input.InvoiceKind ||
                    this.InvoiceKind.Equals(input.InvoiceKind)
                ) && 
                (
                    this.InvoiceMemo == input.InvoiceMemo ||
                    (this.InvoiceMemo != null &&
                    this.InvoiceMemo.Equals(input.InvoiceMemo))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.InvoiceSource == input.InvoiceSource ||
                    (this.InvoiceSource != null &&
                    this.InvoiceSource.Equals(input.InvoiceSource))
                ) && 
                (
                    this.InvoiceTitle == input.InvoiceTitle ||
                    (this.InvoiceTitle != null &&
                    this.InvoiceTitle.Equals(input.InvoiceTitle))
                ) && 
                (
                    this.InvoiceType == input.InvoiceType ||
                    (this.InvoiceType != null &&
                    this.InvoiceType.Equals(input.InvoiceType))
                ) && 
                (
                    this.PayeeAddress == input.PayeeAddress ||
                    (this.PayeeAddress != null &&
                    this.PayeeAddress.Equals(input.PayeeAddress))
                ) && 
                (
                    this.PayeeBankAccount == input.PayeeBankAccount ||
                    (this.PayeeBankAccount != null &&
                    this.PayeeBankAccount.Equals(input.PayeeBankAccount))
                ) && 
                (
                    this.PayeeBankName == input.PayeeBankName ||
                    (this.PayeeBankName != null &&
                    this.PayeeBankName.Equals(input.PayeeBankName))
                ) && 
                (
                    this.PayeeChecker == input.PayeeChecker ||
                    (this.PayeeChecker != null &&
                    this.PayeeChecker.Equals(input.PayeeChecker))
                ) && 
                (
                    this.PayeeMobile == input.PayeeMobile ||
                    (this.PayeeMobile != null &&
                    this.PayeeMobile.Equals(input.PayeeMobile))
                ) && 
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) && 
                (
                    this.PayeeOperator == input.PayeeOperator ||
                    (this.PayeeOperator != null &&
                    this.PayeeOperator.Equals(input.PayeeOperator))
                ) && 
                (
                    this.PayeeReceiver == input.PayeeReceiver ||
                    (this.PayeeReceiver != null &&
                    this.PayeeReceiver.Equals(input.PayeeReceiver))
                ) && 
                (
                    this.PayeeRegisterNo == input.PayeeRegisterNo ||
                    (this.PayeeRegisterNo != null &&
                    this.PayeeRegisterNo.Equals(input.PayeeRegisterNo))
                ) && 
                (
                    this.PayerAddress == input.PayerAddress ||
                    (this.PayerAddress != null &&
                    this.PayerAddress.Equals(input.PayerAddress))
                ) && 
                (
                    this.PayerBankAccount == input.PayerBankAccount ||
                    (this.PayerBankAccount != null &&
                    this.PayerBankAccount.Equals(input.PayerBankAccount))
                ) && 
                (
                    this.PayerBankName == input.PayerBankName ||
                    (this.PayerBankName != null &&
                    this.PayerBankName.Equals(input.PayerBankName))
                ) && 
                (
                    this.PayerMobile == input.PayerMobile ||
                    (this.PayerMobile != null &&
                    this.PayerMobile.Equals(input.PayerMobile))
                ) && 
                (
                    this.PayerName == input.PayerName ||
                    (this.PayerName != null &&
                    this.PayerName.Equals(input.PayerName))
                ) && 
                (
                    this.PayerRegisterNo == input.PayerRegisterNo ||
                    (this.PayerRegisterNo != null &&
                    this.PayerRegisterNo.Equals(input.PayerRegisterNo))
                ) && 
                (
                    this.SumPrice == input.SumPrice ||
                    this.SumPrice.Equals(input.SumPrice)
                ) && 
                (
                    this.SumTax == input.SumTax ||
                    this.SumTax.Equals(input.SumTax)
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
                if (this.AntiFakeCode != null)
                {
                    hashCode = (hashCode * 59) + this.AntiFakeCode.GetHashCode();
                }
                if (this.CheckSum != null)
                {
                    hashCode = (hashCode * 59) + this.CheckSum.GetHashCode();
                }
                if (this.DeviceNo != null)
                {
                    hashCode = (hashCode * 59) + this.DeviceNo.GetHashCode();
                }
                if (this.FileDownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileDownloadUrl.GetHashCode();
                }
                if (this.FileType != null)
                {
                    hashCode = (hashCode * 59) + this.FileType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvoiceAmount.GetHashCode();
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceContentList != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceContentList.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InvoiceKind.GetHashCode();
                if (this.InvoiceMemo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceMemo.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.InvoiceSource != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceSource.GetHashCode();
                }
                if (this.InvoiceTitle != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceTitle.GetHashCode();
                }
                if (this.InvoiceType != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceType.GetHashCode();
                }
                if (this.PayeeAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeAddress.GetHashCode();
                }
                if (this.PayeeBankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeBankAccount.GetHashCode();
                }
                if (this.PayeeBankName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeBankName.GetHashCode();
                }
                if (this.PayeeChecker != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeChecker.GetHashCode();
                }
                if (this.PayeeMobile != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeMobile.GetHashCode();
                }
                if (this.PayeeName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeName.GetHashCode();
                }
                if (this.PayeeOperator != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeOperator.GetHashCode();
                }
                if (this.PayeeReceiver != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeReceiver.GetHashCode();
                }
                if (this.PayeeRegisterNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeRegisterNo.GetHashCode();
                }
                if (this.PayerAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PayerAddress.GetHashCode();
                }
                if (this.PayerBankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PayerBankAccount.GetHashCode();
                }
                if (this.PayerBankName != null)
                {
                    hashCode = (hashCode * 59) + this.PayerBankName.GetHashCode();
                }
                if (this.PayerMobile != null)
                {
                    hashCode = (hashCode * 59) + this.PayerMobile.GetHashCode();
                }
                if (this.PayerName != null)
                {
                    hashCode = (hashCode * 59) + this.PayerName.GetHashCode();
                }
                if (this.PayerRegisterNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayerRegisterNo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SumPrice.GetHashCode();
                hashCode = (hashCode * 59) + this.SumTax.GetHashCode();
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
