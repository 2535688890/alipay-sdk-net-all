using System;
using System.Xml.Serialization;
using Aop.Api.Domain;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFincoreComplianceRcsmartContentQueryResponse.
    /// </summary>
    public class AlipayFincoreComplianceRcsmartContentQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务执行结果数据： 风险结果信息,当接口调用返回result_code为"SUCCESS"时，返回具体的执行结果对象。如果data为null，则标识任务未执行完毕，可稍后再尝试查询结果。建议通过监听alipay.fincore.compliance.rcsmart.content.notify收到消息后尝试查询结果。
        /// </summary>
        [XmlElement("data")]
        public ContentRiskResult Data { get; set; }
    }
}
