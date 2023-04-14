using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenOperationBizfeeAftechSubscribeResponse.
    /// </summary>
    public class AlipayOpenOperationBizfeeAftechSubscribeResponse : AopResponse
    {
        /// <summary>
        /// 结果码
        /// </summary>
        [XmlElement("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 结果信息
        /// </summary>
        [XmlElement("result_message")]
        public string ResultMessage { get; set; }
    }
}
