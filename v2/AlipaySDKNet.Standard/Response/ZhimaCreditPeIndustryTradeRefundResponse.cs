using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditPeIndustryTradeRefundResponse.
    /// </summary>
    public class ZhimaCreditPeIndustryTradeRefundResponse : AopResponse
    {
        /// <summary>
        /// 资金流水号,退款成功才有值
        /// </summary>
        [XmlElement("alipay_fund_order_no")]
        public string AlipayFundOrderNo { get; set; }

        /// <summary>
        /// 交易外部订单号,退款成功才有值,商户对账使用
        /// </summary>
        [XmlElement("alipay_out_trade_no")]
        public string AlipayOutTradeNo { get; set; }

        /// <summary>
        /// 退款金额,单位元
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 支付失败原因描述
        /// </summary>
        [XmlElement("message")]
        public string Message { get; set; }

        /// <summary>
        /// 入参传入的扣款资金单号
        /// </summary>
        [XmlElement("out_fund_no")]
        public string OutFundNo { get; set; }

        /// <summary>
        /// 入参传入的退款资金单号
        /// </summary>
        [XmlElement("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 支付处理时间，无支付行为时为空
        /// </summary>
        [XmlElement("pay_time")]
        public string PayTime { get; set; }

        /// <summary>
        /// 退款状态,退款成功:PAY_SUCCESS, 退款失败:PAY_FAILED, 退款中:PAY_INPROGRESS
        /// </summary>
        [XmlElement("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 传入的平台订单号
        /// </summary>
        [XmlElement("zm_order_id")]
        public string ZmOrderId { get; set; }
    }
}
