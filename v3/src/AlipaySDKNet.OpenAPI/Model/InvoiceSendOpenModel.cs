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
    /// InvoiceSendOpenModel
    /// </summary>
    [DataContract(Name = "InvoiceSendOpenModel")]
    public partial class InvoiceSendOpenModel : IEquatable<InvoiceSendOpenModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceSendOpenModel" /> class.
        /// </summary>
        /// <param name="applyId">支付宝端的申请id。如果在开票过程中，是通过支付宝提交的申请到机构端，支付宝会带上开票申请在支付宝生成的申请id，机构在回传发票的时候只需要回传这个申请id，不用获取用户的uid，支付宝可以根据申请id将发票归集到对应的用户名下.</param>
        /// <param name="checkCode">票面上的校验码信息。.</param>
        /// <param name="checker">票面上复核人信息。.</param>
        /// <param name="clerk">票面上开票员信息。.</param>
        /// <param name="exTaxAmount">不含税金额，票面上的不含税金额，单位（元），保留两位小数。.</param>
        /// <param name="extendFields">预留的扩展字段，格式如：key1&#x3D;value1\\nkey2&#x3D;value2\\nkey3&#x3D;value3，字段之间以\\n分隔。.</param>
        /// <param name="fileDownloadType">下载版式文件类型，需要回传文件下载链接的情况下必传.</param>
        /// <param name="fileDownloadUrl">发票版式文件下载地址。.</param>
        /// <param name="financialElectronicType">财政电子票据子类型.</param>
        /// <param name="invoiceCode">发票代码，该字段与invoice_no构成一张发票的唯一标识。.</param>
        /// <param name="invoiceContent">发票明细项。.</param>
        /// <param name="invoiceDate">开票日期，格式如：YYYY-MM-DD。.</param>
        /// <param name="invoiceKind">标识发票的类型， PLAIN:增值税电子普通发票; SPECIAL:增值税专用发票; ALL_ELECTRONIC_GENERAL:电子发票（普通发票）; ALL_ELECTRONIC_SPECIAL:电子发票（增值税专用发票）; PLAIN_INVOICE:增值税普通发票; FINANCIAL_ELECTRONIC_BILL:财政电子票据;.</param>
        /// <param name="invoiceMemo">票面上备注信息。.</param>
        /// <param name="invoiceNo">发票号码，该字段与invoice_code构成一张发票的唯一标识。.</param>
        /// <param name="invoiceTitle">invoiceTitle.</param>
        /// <param name="invoiceType">标识是红票还是蓝票，RED:红票;BLUE:蓝票。.</param>
        /// <param name="openId">支付宝用户userId，当发送红字发票时，即invoice_type＝RED时，可选填；或者apply_id不为空的时候，可选填；其他情况必填。.</param>
        /// <param name="oriBlueInvCode">红票情况下，必须填入原始蓝票的发票代码（全电票时为空）。.</param>
        /// <param name="oriBlueInvNo">红票情况下，必须填入原始蓝票的发票号码。.</param>
        /// <param name="outInvoiceId">外部发票id，isv生成发票之后所生成的发票流水号，主要用做存储。.</param>
        /// <param name="outTradeNo">该发票基于的实际交易流水号。.</param>
        /// <param name="payee">票面上收款人信息。.</param>
        /// <param name="payeeAddressTel">票面上销售方地址、电话信息。.</param>
        /// <param name="payeeBankNameAccount">票面上销售方开户行及账号。.</param>
        /// <param name="payeeRegisterName">票面上销售方企业名称。.</param>
        /// <param name="payeeRegisterNo">票面上销售方税号信息。.</param>
        /// <param name="sumAmount">价税合计，票面上的总开票金额，单位（元），保留两位小数，sum_amount&#x3D;ex_tax_amount+tax_amount。.</param>
        /// <param name="taxAmount">合计税额，票面上的合计税额，单位（元），保留两位小数。.</param>
        /// <param name="tradeList">交易内容，非必填但是不可以传空值，如果无需回传trade_list则不需要传该对象.</param>
        /// <param name="userId">支付宝用户userId，当发送红字发票时，即invoice_type＝RED时，可选填；或者apply_id不为空的时候，可选填；其他情况必填。.</param>
        public InvoiceSendOpenModel(string applyId = default(string), string checkCode = default(string), string checker = default(string), string clerk = default(string), string exTaxAmount = default(string), string extendFields = default(string), string fileDownloadType = default(string), string fileDownloadUrl = default(string), string financialElectronicType = default(string), string invoiceCode = default(string), List<InvoiceItemOpenModel> invoiceContent = default(List<InvoiceItemOpenModel>), string invoiceDate = default(string), string invoiceKind = default(string), string invoiceMemo = default(string), string invoiceNo = default(string), InvoiceTitleOpenModel invoiceTitle = default(InvoiceTitleOpenModel), string invoiceType = default(string), string openId = default(string), string oriBlueInvCode = default(string), string oriBlueInvNo = default(string), string outInvoiceId = default(string), string outTradeNo = default(string), string payee = default(string), string payeeAddressTel = default(string), string payeeBankNameAccount = default(string), string payeeRegisterName = default(string), string payeeRegisterNo = default(string), string sumAmount = default(string), string taxAmount = default(string), List<EinvTrade> tradeList = default(List<EinvTrade>), string userId = default(string))
        {
            this.ApplyId = applyId;
            this.CheckCode = checkCode;
            this.Checker = checker;
            this.Clerk = clerk;
            this.ExTaxAmount = exTaxAmount;
            this.ExtendFields = extendFields;
            this.FileDownloadType = fileDownloadType;
            this.FileDownloadUrl = fileDownloadUrl;
            this.FinancialElectronicType = financialElectronicType;
            this.InvoiceCode = invoiceCode;
            this.InvoiceContent = invoiceContent;
            this.InvoiceDate = invoiceDate;
            this.InvoiceKind = invoiceKind;
            this.InvoiceMemo = invoiceMemo;
            this.InvoiceNo = invoiceNo;
            this.InvoiceTitle = invoiceTitle;
            this.InvoiceType = invoiceType;
            this.OpenId = openId;
            this.OriBlueInvCode = oriBlueInvCode;
            this.OriBlueInvNo = oriBlueInvNo;
            this.OutInvoiceId = outInvoiceId;
            this.OutTradeNo = outTradeNo;
            this.Payee = payee;
            this.PayeeAddressTel = payeeAddressTel;
            this.PayeeBankNameAccount = payeeBankNameAccount;
            this.PayeeRegisterName = payeeRegisterName;
            this.PayeeRegisterNo = payeeRegisterNo;
            this.SumAmount = sumAmount;
            this.TaxAmount = taxAmount;
            this.TradeList = tradeList;
            this.UserId = userId;
        }

        /// <summary>
        /// 支付宝端的申请id。如果在开票过程中，是通过支付宝提交的申请到机构端，支付宝会带上开票申请在支付宝生成的申请id，机构在回传发票的时候只需要回传这个申请id，不用获取用户的uid，支付宝可以根据申请id将发票归集到对应的用户名下
        /// </summary>
        /// <value>支付宝端的申请id。如果在开票过程中，是通过支付宝提交的申请到机构端，支付宝会带上开票申请在支付宝生成的申请id，机构在回传发票的时候只需要回传这个申请id，不用获取用户的uid，支付宝可以根据申请id将发票归集到对应的用户名下</value>
        [DataMember(Name = "apply_id", EmitDefaultValue = false)]
        public string ApplyId { get; set; }

        /// <summary>
        /// 票面上的校验码信息。
        /// </summary>
        /// <value>票面上的校验码信息。</value>
        [DataMember(Name = "check_code", EmitDefaultValue = false)]
        public string CheckCode { get; set; }

        /// <summary>
        /// 票面上复核人信息。
        /// </summary>
        /// <value>票面上复核人信息。</value>
        [DataMember(Name = "checker", EmitDefaultValue = false)]
        public string Checker { get; set; }

        /// <summary>
        /// 票面上开票员信息。
        /// </summary>
        /// <value>票面上开票员信息。</value>
        [DataMember(Name = "clerk", EmitDefaultValue = false)]
        public string Clerk { get; set; }

        /// <summary>
        /// 不含税金额，票面上的不含税金额，单位（元），保留两位小数。
        /// </summary>
        /// <value>不含税金额，票面上的不含税金额，单位（元），保留两位小数。</value>
        [DataMember(Name = "ex_tax_amount", EmitDefaultValue = false)]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 预留的扩展字段，格式如：key1&#x3D;value1\\nkey2&#x3D;value2\\nkey3&#x3D;value3，字段之间以\\n分隔。
        /// </summary>
        /// <value>预留的扩展字段，格式如：key1&#x3D;value1\\nkey2&#x3D;value2\\nkey3&#x3D;value3，字段之间以\\n分隔。</value>
        [DataMember(Name = "extend_fields", EmitDefaultValue = false)]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 下载版式文件类型，需要回传文件下载链接的情况下必传
        /// </summary>
        /// <value>下载版式文件类型，需要回传文件下载链接的情况下必传</value>
        [DataMember(Name = "file_download_type", EmitDefaultValue = false)]
        public string FileDownloadType { get; set; }

        /// <summary>
        /// 发票版式文件下载地址。
        /// </summary>
        /// <value>发票版式文件下载地址。</value>
        [DataMember(Name = "file_download_url", EmitDefaultValue = false)]
        public string FileDownloadUrl { get; set; }

        /// <summary>
        /// 财政电子票据子类型
        /// </summary>
        /// <value>财政电子票据子类型</value>
        [DataMember(Name = "financial_electronic_type", EmitDefaultValue = false)]
        public string FinancialElectronicType { get; set; }

        /// <summary>
        /// 发票代码，该字段与invoice_no构成一张发票的唯一标识。
        /// </summary>
        /// <value>发票代码，该字段与invoice_no构成一张发票的唯一标识。</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 发票明细项。
        /// </summary>
        /// <value>发票明细项。</value>
        [DataMember(Name = "invoice_content", EmitDefaultValue = false)]
        public List<InvoiceItemOpenModel> InvoiceContent { get; set; }

        /// <summary>
        /// 开票日期，格式如：YYYY-MM-DD。
        /// </summary>
        /// <value>开票日期，格式如：YYYY-MM-DD。</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 标识发票的类型， PLAIN:增值税电子普通发票; SPECIAL:增值税专用发票; ALL_ELECTRONIC_GENERAL:电子发票（普通发票）; ALL_ELECTRONIC_SPECIAL:电子发票（增值税专用发票）; PLAIN_INVOICE:增值税普通发票; FINANCIAL_ELECTRONIC_BILL:财政电子票据;
        /// </summary>
        /// <value>标识发票的类型， PLAIN:增值税电子普通发票; SPECIAL:增值税专用发票; ALL_ELECTRONIC_GENERAL:电子发票（普通发票）; ALL_ELECTRONIC_SPECIAL:电子发票（增值税专用发票）; PLAIN_INVOICE:增值税普通发票; FINANCIAL_ELECTRONIC_BILL:财政电子票据;</value>
        [DataMember(Name = "invoice_kind", EmitDefaultValue = false)]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 票面上备注信息。
        /// </summary>
        /// <value>票面上备注信息。</value>
        [DataMember(Name = "invoice_memo", EmitDefaultValue = false)]
        public string InvoiceMemo { get; set; }

        /// <summary>
        /// 发票号码，该字段与invoice_code构成一张发票的唯一标识。
        /// </summary>
        /// <value>发票号码，该字段与invoice_code构成一张发票的唯一标识。</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceTitle
        /// </summary>
        [DataMember(Name = "invoice_title", EmitDefaultValue = false)]
        public InvoiceTitleOpenModel InvoiceTitle { get; set; }

        /// <summary>
        /// 标识是红票还是蓝票，RED:红票;BLUE:蓝票。
        /// </summary>
        /// <value>标识是红票还是蓝票，RED:红票;BLUE:蓝票。</value>
        [DataMember(Name = "invoice_type", EmitDefaultValue = false)]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 支付宝用户userId，当发送红字发票时，即invoice_type＝RED时，可选填；或者apply_id不为空的时候，可选填；其他情况必填。
        /// </summary>
        /// <value>支付宝用户userId，当发送红字发票时，即invoice_type＝RED时，可选填；或者apply_id不为空的时候，可选填；其他情况必填。</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票代码（全电票时为空）。
        /// </summary>
        /// <value>红票情况下，必须填入原始蓝票的发票代码（全电票时为空）。</value>
        [DataMember(Name = "ori_blue_inv_code", EmitDefaultValue = false)]
        public string OriBlueInvCode { get; set; }

        /// <summary>
        /// 红票情况下，必须填入原始蓝票的发票号码。
        /// </summary>
        /// <value>红票情况下，必须填入原始蓝票的发票号码。</value>
        [DataMember(Name = "ori_blue_inv_no", EmitDefaultValue = false)]
        public string OriBlueInvNo { get; set; }

        /// <summary>
        /// 外部发票id，isv生成发票之后所生成的发票流水号，主要用做存储。
        /// </summary>
        /// <value>外部发票id，isv生成发票之后所生成的发票流水号，主要用做存储。</value>
        [DataMember(Name = "out_invoice_id", EmitDefaultValue = false)]
        public string OutInvoiceId { get; set; }

        /// <summary>
        /// 该发票基于的实际交易流水号。
        /// </summary>
        /// <value>该发票基于的实际交易流水号。</value>
        [DataMember(Name = "out_trade_no", EmitDefaultValue = false)]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 票面上收款人信息。
        /// </summary>
        /// <value>票面上收款人信息。</value>
        [DataMember(Name = "payee", EmitDefaultValue = false)]
        public string Payee { get; set; }

        /// <summary>
        /// 票面上销售方地址、电话信息。
        /// </summary>
        /// <value>票面上销售方地址、电话信息。</value>
        [DataMember(Name = "payee_address_tel", EmitDefaultValue = false)]
        public string PayeeAddressTel { get; set; }

        /// <summary>
        /// 票面上销售方开户行及账号。
        /// </summary>
        /// <value>票面上销售方开户行及账号。</value>
        [DataMember(Name = "payee_bank_name_account", EmitDefaultValue = false)]
        public string PayeeBankNameAccount { get; set; }

        /// <summary>
        /// 票面上销售方企业名称。
        /// </summary>
        /// <value>票面上销售方企业名称。</value>
        [DataMember(Name = "payee_register_name", EmitDefaultValue = false)]
        public string PayeeRegisterName { get; set; }

        /// <summary>
        /// 票面上销售方税号信息。
        /// </summary>
        /// <value>票面上销售方税号信息。</value>
        [DataMember(Name = "payee_register_no", EmitDefaultValue = false)]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 价税合计，票面上的总开票金额，单位（元），保留两位小数，sum_amount&#x3D;ex_tax_amount+tax_amount。
        /// </summary>
        /// <value>价税合计，票面上的总开票金额，单位（元），保留两位小数，sum_amount&#x3D;ex_tax_amount+tax_amount。</value>
        [DataMember(Name = "sum_amount", EmitDefaultValue = false)]
        public string SumAmount { get; set; }

        /// <summary>
        /// 合计税额，票面上的合计税额，单位（元），保留两位小数。
        /// </summary>
        /// <value>合计税额，票面上的合计税额，单位（元），保留两位小数。</value>
        [DataMember(Name = "tax_amount", EmitDefaultValue = false)]
        public string TaxAmount { get; set; }

        /// <summary>
        /// 交易内容，非必填但是不可以传空值，如果无需回传trade_list则不需要传该对象
        /// </summary>
        /// <value>交易内容，非必填但是不可以传空值，如果无需回传trade_list则不需要传该对象</value>
        [DataMember(Name = "trade_list", EmitDefaultValue = false)]
        public List<EinvTrade> TradeList { get; set; }

        /// <summary>
        /// 支付宝用户userId，当发送红字发票时，即invoice_type＝RED时，可选填；或者apply_id不为空的时候，可选填；其他情况必填。
        /// </summary>
        /// <value>支付宝用户userId，当发送红字发票时，即invoice_type＝RED时，可选填；或者apply_id不为空的时候，可选填；其他情况必填。</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InvoiceSendOpenModel {\n");
            sb.Append("  ApplyId: ").Append(ApplyId).Append("\n");
            sb.Append("  CheckCode: ").Append(CheckCode).Append("\n");
            sb.Append("  Checker: ").Append(Checker).Append("\n");
            sb.Append("  Clerk: ").Append(Clerk).Append("\n");
            sb.Append("  ExTaxAmount: ").Append(ExTaxAmount).Append("\n");
            sb.Append("  ExtendFields: ").Append(ExtendFields).Append("\n");
            sb.Append("  FileDownloadType: ").Append(FileDownloadType).Append("\n");
            sb.Append("  FileDownloadUrl: ").Append(FileDownloadUrl).Append("\n");
            sb.Append("  FinancialElectronicType: ").Append(FinancialElectronicType).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceContent: ").Append(InvoiceContent).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceKind: ").Append(InvoiceKind).Append("\n");
            sb.Append("  InvoiceMemo: ").Append(InvoiceMemo).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  InvoiceTitle: ").Append(InvoiceTitle).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OriBlueInvCode: ").Append(OriBlueInvCode).Append("\n");
            sb.Append("  OriBlueInvNo: ").Append(OriBlueInvNo).Append("\n");
            sb.Append("  OutInvoiceId: ").Append(OutInvoiceId).Append("\n");
            sb.Append("  OutTradeNo: ").Append(OutTradeNo).Append("\n");
            sb.Append("  Payee: ").Append(Payee).Append("\n");
            sb.Append("  PayeeAddressTel: ").Append(PayeeAddressTel).Append("\n");
            sb.Append("  PayeeBankNameAccount: ").Append(PayeeBankNameAccount).Append("\n");
            sb.Append("  PayeeRegisterName: ").Append(PayeeRegisterName).Append("\n");
            sb.Append("  PayeeRegisterNo: ").Append(PayeeRegisterNo).Append("\n");
            sb.Append("  SumAmount: ").Append(SumAmount).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TradeList: ").Append(TradeList).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as InvoiceSendOpenModel);
        }

        /// <summary>
        /// Returns true if InvoiceSendOpenModel instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceSendOpenModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceSendOpenModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApplyId == input.ApplyId ||
                    (this.ApplyId != null &&
                    this.ApplyId.Equals(input.ApplyId))
                ) && 
                (
                    this.CheckCode == input.CheckCode ||
                    (this.CheckCode != null &&
                    this.CheckCode.Equals(input.CheckCode))
                ) && 
                (
                    this.Checker == input.Checker ||
                    (this.Checker != null &&
                    this.Checker.Equals(input.Checker))
                ) && 
                (
                    this.Clerk == input.Clerk ||
                    (this.Clerk != null &&
                    this.Clerk.Equals(input.Clerk))
                ) && 
                (
                    this.ExTaxAmount == input.ExTaxAmount ||
                    (this.ExTaxAmount != null &&
                    this.ExTaxAmount.Equals(input.ExTaxAmount))
                ) && 
                (
                    this.ExtendFields == input.ExtendFields ||
                    (this.ExtendFields != null &&
                    this.ExtendFields.Equals(input.ExtendFields))
                ) && 
                (
                    this.FileDownloadType == input.FileDownloadType ||
                    (this.FileDownloadType != null &&
                    this.FileDownloadType.Equals(input.FileDownloadType))
                ) && 
                (
                    this.FileDownloadUrl == input.FileDownloadUrl ||
                    (this.FileDownloadUrl != null &&
                    this.FileDownloadUrl.Equals(input.FileDownloadUrl))
                ) && 
                (
                    this.FinancialElectronicType == input.FinancialElectronicType ||
                    (this.FinancialElectronicType != null &&
                    this.FinancialElectronicType.Equals(input.FinancialElectronicType))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceContent == input.InvoiceContent ||
                    this.InvoiceContent != null &&
                    input.InvoiceContent != null &&
                    this.InvoiceContent.SequenceEqual(input.InvoiceContent)
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceKind == input.InvoiceKind ||
                    (this.InvoiceKind != null &&
                    this.InvoiceKind.Equals(input.InvoiceKind))
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
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OriBlueInvCode == input.OriBlueInvCode ||
                    (this.OriBlueInvCode != null &&
                    this.OriBlueInvCode.Equals(input.OriBlueInvCode))
                ) && 
                (
                    this.OriBlueInvNo == input.OriBlueInvNo ||
                    (this.OriBlueInvNo != null &&
                    this.OriBlueInvNo.Equals(input.OriBlueInvNo))
                ) && 
                (
                    this.OutInvoiceId == input.OutInvoiceId ||
                    (this.OutInvoiceId != null &&
                    this.OutInvoiceId.Equals(input.OutInvoiceId))
                ) && 
                (
                    this.OutTradeNo == input.OutTradeNo ||
                    (this.OutTradeNo != null &&
                    this.OutTradeNo.Equals(input.OutTradeNo))
                ) && 
                (
                    this.Payee == input.Payee ||
                    (this.Payee != null &&
                    this.Payee.Equals(input.Payee))
                ) && 
                (
                    this.PayeeAddressTel == input.PayeeAddressTel ||
                    (this.PayeeAddressTel != null &&
                    this.PayeeAddressTel.Equals(input.PayeeAddressTel))
                ) && 
                (
                    this.PayeeBankNameAccount == input.PayeeBankNameAccount ||
                    (this.PayeeBankNameAccount != null &&
                    this.PayeeBankNameAccount.Equals(input.PayeeBankNameAccount))
                ) && 
                (
                    this.PayeeRegisterName == input.PayeeRegisterName ||
                    (this.PayeeRegisterName != null &&
                    this.PayeeRegisterName.Equals(input.PayeeRegisterName))
                ) && 
                (
                    this.PayeeRegisterNo == input.PayeeRegisterNo ||
                    (this.PayeeRegisterNo != null &&
                    this.PayeeRegisterNo.Equals(input.PayeeRegisterNo))
                ) && 
                (
                    this.SumAmount == input.SumAmount ||
                    (this.SumAmount != null &&
                    this.SumAmount.Equals(input.SumAmount))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TradeList == input.TradeList ||
                    this.TradeList != null &&
                    input.TradeList != null &&
                    this.TradeList.SequenceEqual(input.TradeList)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.ApplyId != null)
                {
                    hashCode = (hashCode * 59) + this.ApplyId.GetHashCode();
                }
                if (this.CheckCode != null)
                {
                    hashCode = (hashCode * 59) + this.CheckCode.GetHashCode();
                }
                if (this.Checker != null)
                {
                    hashCode = (hashCode * 59) + this.Checker.GetHashCode();
                }
                if (this.Clerk != null)
                {
                    hashCode = (hashCode * 59) + this.Clerk.GetHashCode();
                }
                if (this.ExTaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ExTaxAmount.GetHashCode();
                }
                if (this.ExtendFields != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendFields.GetHashCode();
                }
                if (this.FileDownloadType != null)
                {
                    hashCode = (hashCode * 59) + this.FileDownloadType.GetHashCode();
                }
                if (this.FileDownloadUrl != null)
                {
                    hashCode = (hashCode * 59) + this.FileDownloadUrl.GetHashCode();
                }
                if (this.FinancialElectronicType != null)
                {
                    hashCode = (hashCode * 59) + this.FinancialElectronicType.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceContent != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceContent.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.InvoiceKind != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceKind.GetHashCode();
                }
                if (this.InvoiceMemo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceMemo.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.InvoiceTitle != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceTitle.GetHashCode();
                }
                if (this.InvoiceType != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceType.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OriBlueInvCode != null)
                {
                    hashCode = (hashCode * 59) + this.OriBlueInvCode.GetHashCode();
                }
                if (this.OriBlueInvNo != null)
                {
                    hashCode = (hashCode * 59) + this.OriBlueInvNo.GetHashCode();
                }
                if (this.OutInvoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.OutInvoiceId.GetHashCode();
                }
                if (this.OutTradeNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutTradeNo.GetHashCode();
                }
                if (this.Payee != null)
                {
                    hashCode = (hashCode * 59) + this.Payee.GetHashCode();
                }
                if (this.PayeeAddressTel != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeAddressTel.GetHashCode();
                }
                if (this.PayeeBankNameAccount != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeBankNameAccount.GetHashCode();
                }
                if (this.PayeeRegisterName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeRegisterName.GetHashCode();
                }
                if (this.PayeeRegisterNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeRegisterNo.GetHashCode();
                }
                if (this.SumAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SumAmount.GetHashCode();
                }
                if (this.TaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaxAmount.GetHashCode();
                }
                if (this.TradeList != null)
                {
                    hashCode = (hashCode * 59) + this.TradeList.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
