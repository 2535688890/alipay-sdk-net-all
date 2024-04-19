using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// MybankPaymentTradeBusinessOrderConfirmResponse.
    /// </summary>
    public class MybankPaymentTradeBusinessOrderConfirmResponse : AopResponse
    {
        /// <summary>
        /// 网商受理确认操作返回的流水号
        /// </summary>
        [XmlElement("operate_no")]
        public string OperateNo { get; set; }

        /// <summary>
        /// 请求流水号
        /// </summary>
        [XmlElement("request_no")]
        public string RequestNo { get; set; }

        /// <summary>
        /// 外部平台是否需要原单重试，失败时有值
        /// </summary>
        [XmlElement("retry")]
        public string Retry { get; set; }
    }
}
