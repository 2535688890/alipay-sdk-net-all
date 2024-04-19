using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayTradeCreditFinancePayResponse.
    /// </summary>
    public class AlipayTradeCreditFinancePayResponse : AopResponse
    {
        /// <summary>
        /// 本次支付的金额，非特殊情况下和请求金额保持一致。单位为元；精确到小数点后两位，取值范围[0.01,100000000]
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 币种单位，目前只支持人民币CNY
        /// </summary>
        [XmlElement("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// 支付宝系统资金处理成功时间，格式为"yyyy-MM-dd HH:mm:ss"
        /// </summary>
        [XmlElement("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 外部请求号，和入参请求一致
        /// </summary>
        [XmlElement("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 本次支付的处理状态，SUCCESS：处理成功；FAIL：处理失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// 本次金融付款对应交易的买家ID
        /// </summary>
        [XmlElement("trade_buyer_id")]
        public string TradeBuyerId { get; set; }

        /// <summary>
        /// 本次金融付款对应的交易号，和入参请求一致
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }
    }
}
