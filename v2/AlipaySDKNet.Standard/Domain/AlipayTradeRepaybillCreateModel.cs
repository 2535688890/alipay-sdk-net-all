using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayTradeRepaybillCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayTradeRepaybillCreateModel : AopObject
    {
        /// <summary>
        /// 本次创建账单的金额，单位为元，精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("bill_amount")]
        public string BillAmount { get; set; }

        /// <summary>
        /// 账单产品类型，标识业务用，具体值支付宝根据业务接入场景进行分配。
        /// </summary>
        [XmlElement("bill_product")]
        public string BillProduct { get; set; }

        /// <summary>
        /// 外部账单编号，每个外部编号对应一个唯一的账单，用于幂等使用
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// 还款账单的用户正常最晚还款日期。 格式为：yyyy-MM-dd hh:mm:ss。
        /// </summary>
        [XmlElement("repay_expire_date")]
        public string RepayExpireDate { get; set; }

        /// <summary>
        /// 账单包含的还款交易详情
        /// </summary>
        [XmlArray("repay_trade_details")]
        [XmlArrayItem("repay_trade_detail")]
        public List<RepayTradeDetail> RepayTradeDetails { get; set; }

        /// <summary>
        /// 账单归属主体，蚂蚁统一会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
