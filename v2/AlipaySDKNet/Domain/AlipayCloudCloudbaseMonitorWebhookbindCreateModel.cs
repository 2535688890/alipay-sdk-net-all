using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseMonitorWebhookbindCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseMonitorWebhookbindCreateModel : AopObject
    {
        /// <summary>
        /// 绑定名称
        /// </summary>
        [XmlElement("name")]
        public string Name { get; set; }

        /// <summary>
        /// 请求对象
        /// </summary>
        [XmlElement("request_body")]
        public string RequestBody { get; set; }

        /// <summary>
        /// 请求头
        /// </summary>
        [XmlElement("request_headers")]
        public string RequestHeaders { get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        [XmlElement("request_type")]
        public string RequestType { get; set; }

        /// <summary>
        /// 请求地址
        /// </summary>
        [XmlElement("request_url")]
        public string RequestUrl { get; set; }
    }
}
