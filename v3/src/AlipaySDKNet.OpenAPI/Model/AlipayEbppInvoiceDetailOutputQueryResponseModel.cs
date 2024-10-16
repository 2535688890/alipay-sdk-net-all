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
    /// AlipayEbppInvoiceDetailOutputQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceDetailOutputQueryResponseModel")]
    public partial class AlipayEbppInvoiceDetailOutputQueryResponseModel : IEquatable<AlipayEbppInvoiceDetailOutputQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceDetailOutputQueryResponseModel" /> class.
        /// </summary>
        /// <param name="antiFakeCode">防伪码，发票校验码.</param>
        /// <param name="exTaxAmount">不含税金额（废弃），单位元.</param>
        /// <param name="expenseStatus">发票报销状态  取值范围：  WAIT_EXPENSE－未报销  EXPENSE_PROCESSING－报销中  EXPENSE_FINISHED－已报销.</param>
        /// <param name="hasRisk">该发票可能存在异常，请核实后使用  true:无异常  false:存在异常.</param>
        /// <param name="hasUploadPdf">是否已上传发票pdf文件  false－未上传  true－已上传.</param>
        /// <param name="invoiceAmount">发票金额（价税合计金额），单位元.</param>
        /// <param name="invoiceCode">发票代码 （全电票为空）.</param>
        /// <param name="invoiceDate">开票日期.</param>
        /// <param name="invoiceImgUrl">发票缩略图地址.</param>
        /// <param name="invoiceItemContentList">发票内容项.</param>
        /// <param name="invoiceNo">发票号码.</param>
        /// <param name="invoiceStatus">发票状态  SUCCEED－成功  EXPIRED－已失效  TRANSFERRED－已转交.</param>
        /// <param name="invoiceType">发票类型  值有两种情况：blue－蓝票 red－红票.</param>
        /// <param name="payeeAddress">销售方地址.</param>
        /// <param name="payeeBankAccount">销售方开户银行账号.</param>
        /// <param name="payeeBankName">销售方开户银行名称.</param>
        /// <param name="payeePhone">销售方电话.</param>
        /// <param name="payeeRegisterName">销售方名称.</param>
        /// <param name="payeeTaxNo">销售方税号.</param>
        /// <param name="payerAddress">购买方地址.</param>
        /// <param name="payerBankAccount">购买方开户银行账号.</param>
        /// <param name="payerBankName">购买方开户银行名称.</param>
        /// <param name="payerName">购买方名称.</param>
        /// <param name="payerPhone">购买方电话.</param>
        /// <param name="payerTaxNo">购买方税号.</param>
        /// <param name="sumTaxAmount">合计税额（废弃）.</param>
        /// <param name="taxType">票种 PLAIN：增值税电子普通发票 SPECIAL：增值税专用发票 ALL_ELECTRONIC_GENERAL：电子发票（普通发票） ALL_ELECTRONIC_SPECIAL：电子发票（增值税专用发票） PLAIN_INVOICE:增值税普通发票 PAPER_INVOICE:增值税普通发票（卷式） SALSE_INVOICE:机动车销售统一发票.</param>
        public AlipayEbppInvoiceDetailOutputQueryResponseModel(string antiFakeCode = default(string), string exTaxAmount = default(string), string expenseStatus = default(string), bool hasRisk = default(bool), string hasUploadPdf = default(string), string invoiceAmount = default(string), string invoiceCode = default(string), string invoiceDate = default(string), string invoiceImgUrl = default(string), List<InvoiceItemContent> invoiceItemContentList = default(List<InvoiceItemContent>), string invoiceNo = default(string), string invoiceStatus = default(string), string invoiceType = default(string), string payeeAddress = default(string), string payeeBankAccount = default(string), string payeeBankName = default(string), string payeePhone = default(string), string payeeRegisterName = default(string), string payeeTaxNo = default(string), string payerAddress = default(string), string payerBankAccount = default(string), string payerBankName = default(string), string payerName = default(string), string payerPhone = default(string), string payerTaxNo = default(string), string sumTaxAmount = default(string), string taxType = default(string))
        {
            this.AntiFakeCode = antiFakeCode;
            this.ExTaxAmount = exTaxAmount;
            this.ExpenseStatus = expenseStatus;
            this.HasRisk = hasRisk;
            this.HasUploadPdf = hasUploadPdf;
            this.InvoiceAmount = invoiceAmount;
            this.InvoiceCode = invoiceCode;
            this.InvoiceDate = invoiceDate;
            this.InvoiceImgUrl = invoiceImgUrl;
            this.InvoiceItemContentList = invoiceItemContentList;
            this.InvoiceNo = invoiceNo;
            this.InvoiceStatus = invoiceStatus;
            this.InvoiceType = invoiceType;
            this.PayeeAddress = payeeAddress;
            this.PayeeBankAccount = payeeBankAccount;
            this.PayeeBankName = payeeBankName;
            this.PayeePhone = payeePhone;
            this.PayeeRegisterName = payeeRegisterName;
            this.PayeeTaxNo = payeeTaxNo;
            this.PayerAddress = payerAddress;
            this.PayerBankAccount = payerBankAccount;
            this.PayerBankName = payerBankName;
            this.PayerName = payerName;
            this.PayerPhone = payerPhone;
            this.PayerTaxNo = payerTaxNo;
            this.SumTaxAmount = sumTaxAmount;
            this.TaxType = taxType;
        }

        /// <summary>
        /// 防伪码，发票校验码
        /// </summary>
        /// <value>防伪码，发票校验码</value>
        [DataMember(Name = "anti_fake_code", EmitDefaultValue = false)]
        public string AntiFakeCode { get; set; }

        /// <summary>
        /// 不含税金额（废弃），单位元
        /// </summary>
        /// <value>不含税金额（废弃），单位元</value>
        [DataMember(Name = "ex_tax_amount", EmitDefaultValue = false)]
        public string ExTaxAmount { get; set; }

        /// <summary>
        /// 发票报销状态  取值范围：  WAIT_EXPENSE－未报销  EXPENSE_PROCESSING－报销中  EXPENSE_FINISHED－已报销
        /// </summary>
        /// <value>发票报销状态  取值范围：  WAIT_EXPENSE－未报销  EXPENSE_PROCESSING－报销中  EXPENSE_FINISHED－已报销</value>
        [DataMember(Name = "expense_status", EmitDefaultValue = false)]
        public string ExpenseStatus { get; set; }

        /// <summary>
        /// 该发票可能存在异常，请核实后使用  true:无异常  false:存在异常
        /// </summary>
        /// <value>该发票可能存在异常，请核实后使用  true:无异常  false:存在异常</value>
        [DataMember(Name = "has_risk", EmitDefaultValue = true)]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 是否已上传发票pdf文件  false－未上传  true－已上传
        /// </summary>
        /// <value>是否已上传发票pdf文件  false－未上传  true－已上传</value>
        [DataMember(Name = "has_upload_pdf", EmitDefaultValue = false)]
        public string HasUploadPdf { get; set; }

        /// <summary>
        /// 发票金额（价税合计金额），单位元
        /// </summary>
        /// <value>发票金额（价税合计金额），单位元</value>
        [DataMember(Name = "invoice_amount", EmitDefaultValue = false)]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码 （全电票为空）
        /// </summary>
        /// <value>发票代码 （全电票为空）</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        /// <value>开票日期</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票缩略图地址
        /// </summary>
        /// <value>发票缩略图地址</value>
        [DataMember(Name = "invoice_img_url", EmitDefaultValue = false)]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 发票内容项
        /// </summary>
        /// <value>发票内容项</value>
        [DataMember(Name = "invoice_item_content_list", EmitDefaultValue = false)]
        public List<InvoiceItemContent> InvoiceItemContentList { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        /// <value>发票号码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态  SUCCEED－成功  EXPIRED－已失效  TRANSFERRED－已转交
        /// </summary>
        /// <value>发票状态  SUCCEED－成功  EXPIRED－已失效  TRANSFERRED－已转交</value>
        [DataMember(Name = "invoice_status", EmitDefaultValue = false)]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 发票类型  值有两种情况：blue－蓝票 red－红票
        /// </summary>
        /// <value>发票类型  值有两种情况：blue－蓝票 red－红票</value>
        [DataMember(Name = "invoice_type", EmitDefaultValue = false)]
        public string InvoiceType { get; set; }

        /// <summary>
        /// 销售方地址
        /// </summary>
        /// <value>销售方地址</value>
        [DataMember(Name = "payee_address", EmitDefaultValue = false)]
        public string PayeeAddress { get; set; }

        /// <summary>
        /// 销售方开户银行账号
        /// </summary>
        /// <value>销售方开户银行账号</value>
        [DataMember(Name = "payee_bank_account", EmitDefaultValue = false)]
        public string PayeeBankAccount { get; set; }

        /// <summary>
        /// 销售方开户银行名称
        /// </summary>
        /// <value>销售方开户银行名称</value>
        [DataMember(Name = "payee_bank_name", EmitDefaultValue = false)]
        public string PayeeBankName { get; set; }

        /// <summary>
        /// 销售方电话
        /// </summary>
        /// <value>销售方电话</value>
        [DataMember(Name = "payee_phone", EmitDefaultValue = false)]
        public string PayeePhone { get; set; }

        /// <summary>
        /// 销售方名称
        /// </summary>
        /// <value>销售方名称</value>
        [DataMember(Name = "payee_register_name", EmitDefaultValue = false)]
        public string PayeeRegisterName { get; set; }

        /// <summary>
        /// 销售方税号
        /// </summary>
        /// <value>销售方税号</value>
        [DataMember(Name = "payee_tax_no", EmitDefaultValue = false)]
        public string PayeeTaxNo { get; set; }

        /// <summary>
        /// 购买方地址
        /// </summary>
        /// <value>购买方地址</value>
        [DataMember(Name = "payer_address", EmitDefaultValue = false)]
        public string PayerAddress { get; set; }

        /// <summary>
        /// 购买方开户银行账号
        /// </summary>
        /// <value>购买方开户银行账号</value>
        [DataMember(Name = "payer_bank_account", EmitDefaultValue = false)]
        public string PayerBankAccount { get; set; }

        /// <summary>
        /// 购买方开户银行名称
        /// </summary>
        /// <value>购买方开户银行名称</value>
        [DataMember(Name = "payer_bank_name", EmitDefaultValue = false)]
        public string PayerBankName { get; set; }

        /// <summary>
        /// 购买方名称
        /// </summary>
        /// <value>购买方名称</value>
        [DataMember(Name = "payer_name", EmitDefaultValue = false)]
        public string PayerName { get; set; }

        /// <summary>
        /// 购买方电话
        /// </summary>
        /// <value>购买方电话</value>
        [DataMember(Name = "payer_phone", EmitDefaultValue = false)]
        public string PayerPhone { get; set; }

        /// <summary>
        /// 购买方税号
        /// </summary>
        /// <value>购买方税号</value>
        [DataMember(Name = "payer_tax_no", EmitDefaultValue = false)]
        public string PayerTaxNo { get; set; }

        /// <summary>
        /// 合计税额（废弃）
        /// </summary>
        /// <value>合计税额（废弃）</value>
        [DataMember(Name = "sum_tax_amount", EmitDefaultValue = false)]
        public string SumTaxAmount { get; set; }

        /// <summary>
        /// 票种 PLAIN：增值税电子普通发票 SPECIAL：增值税专用发票 ALL_ELECTRONIC_GENERAL：电子发票（普通发票） ALL_ELECTRONIC_SPECIAL：电子发票（增值税专用发票） PLAIN_INVOICE:增值税普通发票 PAPER_INVOICE:增值税普通发票（卷式） SALSE_INVOICE:机动车销售统一发票
        /// </summary>
        /// <value>票种 PLAIN：增值税电子普通发票 SPECIAL：增值税专用发票 ALL_ELECTRONIC_GENERAL：电子发票（普通发票） ALL_ELECTRONIC_SPECIAL：电子发票（增值税专用发票） PLAIN_INVOICE:增值税普通发票 PAPER_INVOICE:增值税普通发票（卷式） SALSE_INVOICE:机动车销售统一发票</value>
        [DataMember(Name = "tax_type", EmitDefaultValue = false)]
        public string TaxType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceDetailOutputQueryResponseModel {\n");
            sb.Append("  AntiFakeCode: ").Append(AntiFakeCode).Append("\n");
            sb.Append("  ExTaxAmount: ").Append(ExTaxAmount).Append("\n");
            sb.Append("  ExpenseStatus: ").Append(ExpenseStatus).Append("\n");
            sb.Append("  HasRisk: ").Append(HasRisk).Append("\n");
            sb.Append("  HasUploadPdf: ").Append(HasUploadPdf).Append("\n");
            sb.Append("  InvoiceAmount: ").Append(InvoiceAmount).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceImgUrl: ").Append(InvoiceImgUrl).Append("\n");
            sb.Append("  InvoiceItemContentList: ").Append(InvoiceItemContentList).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  InvoiceStatus: ").Append(InvoiceStatus).Append("\n");
            sb.Append("  InvoiceType: ").Append(InvoiceType).Append("\n");
            sb.Append("  PayeeAddress: ").Append(PayeeAddress).Append("\n");
            sb.Append("  PayeeBankAccount: ").Append(PayeeBankAccount).Append("\n");
            sb.Append("  PayeeBankName: ").Append(PayeeBankName).Append("\n");
            sb.Append("  PayeePhone: ").Append(PayeePhone).Append("\n");
            sb.Append("  PayeeRegisterName: ").Append(PayeeRegisterName).Append("\n");
            sb.Append("  PayeeTaxNo: ").Append(PayeeTaxNo).Append("\n");
            sb.Append("  PayerAddress: ").Append(PayerAddress).Append("\n");
            sb.Append("  PayerBankAccount: ").Append(PayerBankAccount).Append("\n");
            sb.Append("  PayerBankName: ").Append(PayerBankName).Append("\n");
            sb.Append("  PayerName: ").Append(PayerName).Append("\n");
            sb.Append("  PayerPhone: ").Append(PayerPhone).Append("\n");
            sb.Append("  PayerTaxNo: ").Append(PayerTaxNo).Append("\n");
            sb.Append("  SumTaxAmount: ").Append(SumTaxAmount).Append("\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceDetailOutputQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceDetailOutputQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceDetailOutputQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceDetailOutputQueryResponseModel input)
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
                    this.ExTaxAmount == input.ExTaxAmount ||
                    (this.ExTaxAmount != null &&
                    this.ExTaxAmount.Equals(input.ExTaxAmount))
                ) && 
                (
                    this.ExpenseStatus == input.ExpenseStatus ||
                    (this.ExpenseStatus != null &&
                    this.ExpenseStatus.Equals(input.ExpenseStatus))
                ) && 
                (
                    this.HasRisk == input.HasRisk ||
                    this.HasRisk.Equals(input.HasRisk)
                ) && 
                (
                    this.HasUploadPdf == input.HasUploadPdf ||
                    (this.HasUploadPdf != null &&
                    this.HasUploadPdf.Equals(input.HasUploadPdf))
                ) && 
                (
                    this.InvoiceAmount == input.InvoiceAmount ||
                    (this.InvoiceAmount != null &&
                    this.InvoiceAmount.Equals(input.InvoiceAmount))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceImgUrl == input.InvoiceImgUrl ||
                    (this.InvoiceImgUrl != null &&
                    this.InvoiceImgUrl.Equals(input.InvoiceImgUrl))
                ) && 
                (
                    this.InvoiceItemContentList == input.InvoiceItemContentList ||
                    this.InvoiceItemContentList != null &&
                    input.InvoiceItemContentList != null &&
                    this.InvoiceItemContentList.SequenceEqual(input.InvoiceItemContentList)
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.InvoiceStatus == input.InvoiceStatus ||
                    (this.InvoiceStatus != null &&
                    this.InvoiceStatus.Equals(input.InvoiceStatus))
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
                    this.PayeePhone == input.PayeePhone ||
                    (this.PayeePhone != null &&
                    this.PayeePhone.Equals(input.PayeePhone))
                ) && 
                (
                    this.PayeeRegisterName == input.PayeeRegisterName ||
                    (this.PayeeRegisterName != null &&
                    this.PayeeRegisterName.Equals(input.PayeeRegisterName))
                ) && 
                (
                    this.PayeeTaxNo == input.PayeeTaxNo ||
                    (this.PayeeTaxNo != null &&
                    this.PayeeTaxNo.Equals(input.PayeeTaxNo))
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
                    this.PayerName == input.PayerName ||
                    (this.PayerName != null &&
                    this.PayerName.Equals(input.PayerName))
                ) && 
                (
                    this.PayerPhone == input.PayerPhone ||
                    (this.PayerPhone != null &&
                    this.PayerPhone.Equals(input.PayerPhone))
                ) && 
                (
                    this.PayerTaxNo == input.PayerTaxNo ||
                    (this.PayerTaxNo != null &&
                    this.PayerTaxNo.Equals(input.PayerTaxNo))
                ) && 
                (
                    this.SumTaxAmount == input.SumTaxAmount ||
                    (this.SumTaxAmount != null &&
                    this.SumTaxAmount.Equals(input.SumTaxAmount))
                ) && 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
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
                if (this.ExTaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ExTaxAmount.GetHashCode();
                }
                if (this.ExpenseStatus != null)
                {
                    hashCode = (hashCode * 59) + this.ExpenseStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.HasRisk.GetHashCode();
                if (this.HasUploadPdf != null)
                {
                    hashCode = (hashCode * 59) + this.HasUploadPdf.GetHashCode();
                }
                if (this.InvoiceAmount != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceAmount.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.InvoiceImgUrl != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceImgUrl.GetHashCode();
                }
                if (this.InvoiceItemContentList != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceItemContentList.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.InvoiceStatus != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceStatus.GetHashCode();
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
                if (this.PayeePhone != null)
                {
                    hashCode = (hashCode * 59) + this.PayeePhone.GetHashCode();
                }
                if (this.PayeeRegisterName != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeRegisterName.GetHashCode();
                }
                if (this.PayeeTaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayeeTaxNo.GetHashCode();
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
                if (this.PayerName != null)
                {
                    hashCode = (hashCode * 59) + this.PayerName.GetHashCode();
                }
                if (this.PayerPhone != null)
                {
                    hashCode = (hashCode * 59) + this.PayerPhone.GetHashCode();
                }
                if (this.PayerTaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayerTaxNo.GetHashCode();
                }
                if (this.SumTaxAmount != null)
                {
                    hashCode = (hashCode * 59) + this.SumTaxAmount.GetHashCode();
                }
                if (this.TaxType != null)
                {
                    hashCode = (hashCode * 59) + this.TaxType.GetHashCode();
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
