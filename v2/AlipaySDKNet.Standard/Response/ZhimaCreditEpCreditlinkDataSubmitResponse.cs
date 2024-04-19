using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// ZhimaCreditEpCreditlinkDataSubmitResponse.
    /// </summary>
    public class ZhimaCreditEpCreditlinkDataSubmitResponse : AopResponse
    {
        /// <summary>
        /// 征信数据提交结果。结构视data_type的不同而定
        /// </summary>
        [XmlElement("result_content")]
        public string ResultContent { get; set; }
    }
}
