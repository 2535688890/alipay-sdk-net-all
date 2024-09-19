using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// XingheLendassistCarfinApplystatusNotifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class XingheLendassistCarfinApplystatusNotifyModel : AopObject
    {
        /// <summary>
        /// 星河侧唯一业务编号
        /// </summary>
        [XmlElement("apply_no")]
        public string ApplyNo { get; set; }

        /// <summary>
        /// 授信金额，单位分
        /// </summary>
        [XmlElement("credit_amt")]
        public long CreditAmt { get; set; }

        /// <summary>
        /// 取消失败时，申请单当前状态
        /// </summary>
        [XmlElement("current_status")]
        public string CurrentStatus { get; set; }

        /// <summary>
        /// 客户状态
        /// </summary>
        [XmlElement("cust_status")]
        public string CustStatus { get; set; }

        /// <summary>
        /// 资方支用号
        /// </summary>
        [XmlElement("fin_drawdown_no")]
        public string FinDrawdownNo { get; set; }

        /// <summary>
        /// 资方机构名称
        /// </summary>
        [XmlElement("fin_org")]
        public string FinOrg { get; set; }

        /// <summary>
        /// 放款金额，单位分
        /// </summary>
        [XmlElement("loan_amt")]
        public long LoanAmt { get; set; }

        /// <summary>
        /// 客户放款成功日期，yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("loan_date")]
        public string LoanDate { get; set; }

        /// <summary>
        /// 放款利率
        /// </summary>
        [XmlElement("loan_rate")]
        public string LoanRate { get; set; }

        /// <summary>
        /// 贷款期次
        /// </summary>
        [XmlElement("loan_term")]
        public long LoanTerm { get; set; }

        /// <summary>
        /// 客户贷款期次类型，Y、M、D分别代表年月日
        /// </summary>
        [XmlElement("loan_term_unit")]
        public string LoanTermUnit { get; set; }

        /// <summary>
        /// 抵押率，授信金额/车辆估值金额
        /// </summary>
        [XmlElement("mortgage_rate")]
        public string MortgageRate { get; set; }

        /// <summary>
        /// 机构侧支用号，放款时必传
        /// </summary>
        [XmlElement("org_drawdown_no")]
        public string OrgDrawdownNo { get; set; }

        /// <summary>
        /// 机构侧唯一业务编号
        /// </summary>
        [XmlElement("out_apply_no")]
        public string OutApplyNo { get; set; }

        /// <summary>
        /// 拒绝原因错误码
        /// </summary>
        [XmlElement("refuse_code")]
        public string RefuseCode { get; set; }

        /// <summary>
        /// 拒绝原因
        /// </summary>
        [XmlElement("refuse_msg")]
        public string RefuseMsg { get; set; }

        /// <summary>
        /// 还款方式，1：等额本金，2：等额本息，3：先息后本，4：一次性结清本息
        /// </summary>
        [XmlElement("repay_type")]
        public string RepayType { get; set; }

        /// <summary>
        /// CANCEL_FAIL: 取消失败（适用于客户挽回成功的场景，经联系后客户愿意继续办理） CANCEL_SUC: 取消成功（适用于客户确定放弃的场景，机构侧后续不能联系客户）
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 车辆估值金额，单位分
        /// </summary>
        [XmlElement("valuate_price")]
        public long ValuatePrice { get; set; }
    }
}
