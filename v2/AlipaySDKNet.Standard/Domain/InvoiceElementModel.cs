using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// InvoiceElementModel Data Structure.
    /// </summary>
    [Serializable]
    public class InvoiceElementModel : AopObject
    {
        /// <summary>
        /// 发票报销状态  取值范围：  WAIT_EXPENSE－未报销  EXPENSE_PROCESSING－报销中  EXPENSE_FINISHED－已报销
        /// </summary>
        [XmlElement("expense_status")]
        public string ExpenseStatus { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [XmlElement("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 防伪校验码
        /// </summary>
        [XmlElement("fake_code")]
        public string FakeCode { get; set; }

        /// <summary>
        /// 发票是否有pdf文件
        /// </summary>
        [XmlElement("has_pdf_file")]
        public bool HasPdfFile { get; set; }

        /// <summary>
        /// 该发票可能存在异常，请核实后使用  true:无异常  false:存在异常
        /// </summary>
        [XmlElement("has_risk")]
        public bool HasRisk { get; set; }

        /// <summary>
        /// 发票金额，含税
        /// </summary>
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        [XmlElement("invoice_code")]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票日期
        /// </summary>
        [XmlElement("invoice_date")]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票pdf文件转换后jpg预览地址
        /// </summary>
        [XmlElement("invoice_img_url")]
        public string InvoiceImgUrl { get; set; }

        /// <summary>
        /// 发票类型 可选值 PLAIN：增值税电子普通发票 SPECIAL：增值税专用发票 ALL_ELECTRONIC_GENERAL： "电子发票（普通发票） ALL_ELECTRONIC_SPECIAL： "电子发票（专用发票） PLAIN_INVOICE:增值税普通发票 PAPER_INVOICE:增值税普通发票（卷式） SALSE_INVOICE:机动车销售统一发票 财政电子票据：FINANCIAL_ELECTRONIC_BILL
        /// </summary>
        [XmlElement("invoice_kind")]
        public string InvoiceKind { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        [XmlElement("invoice_no")]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 发票状态　  取值范围  SUCCEED－正常蓝票  EXPIRED－已失效
        /// </summary>
        [XmlElement("invoice_status")]
        public string InvoiceStatus { get; set; }

        /// <summary>
        /// 服务商联系方式
        /// </summary>
        [XmlElement("isv_contact")]
        public string IsvContact { get; set; }

        /// <summary>
        /// 服务商名称
        /// </summary>
        [XmlElement("isv_name")]
        public string IsvName { get; set; }

        /// <summary>
        /// logo地址
        /// </summary>
        [XmlElement("logo_url")]
        public string LogoUrl { get; set; }

        /// <summary>
        /// 商户全称
        /// </summary>
        [XmlElement("m_name")]
        public string MName { get; set; }

        /// <summary>
        /// 发票金额，不含税
        /// </summary>
        [XmlElement("out_tax_amount")]
        public string OutTaxAmount { get; set; }

        /// <summary>
        /// 销方名称
        /// </summary>
        [XmlElement("payee_name")]
        public string PayeeName { get; set; }

        /// <summary>
        /// 销方税号
        /// </summary>
        [XmlElement("payee_tax_no")]
        public string PayeeTaxNo { get; set; }

        /// <summary>
        /// 购方名称
        /// </summary>
        [XmlElement("payer_name")]
        public string PayerName { get; set; }

        /// <summary>
        /// 购方税号
        /// </summary>
        [XmlElement("payer_tax_no")]
        public string PayerTaxNo { get; set; }

        /// <summary>
        /// PDF的下载链接
        /// </summary>
        [XmlElement("pdf_url")]
        public string PdfUrl { get; set; }

        /// <summary>
        /// 表示发票来源，由发票回传方带入。例如：bz_gd，bz_ele，bz_tmall等
        /// </summary>
        [XmlElement("source")]
        public string Source { get; set; }

        /// <summary>
        /// 该发票对应的交易
        /// </summary>
        [XmlArray("trade_list")]
        [XmlArrayItem("einv_trade")]
        public List<EinvTrade> TradeList { get; set; }

        /// <summary>
        /// 交易匹配结果 match-匹配到 noMatched-未匹配到 notMatch-未做匹配
        /// </summary>
        [XmlElement("trade_match_result")]
        public string TradeMatchResult { get; set; }
    }
}
