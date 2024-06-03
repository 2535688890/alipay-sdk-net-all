using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayIserviceIcontrolDispatchQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceIcontrolDispatchQueryModel : AopObject
    {
        /// <summary>
        /// 业务标签
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 哈啰出行热线会话jobId
        /// </summary>
        [XmlElement("job_id")]
        public string JobId { get; set; }

        /// <summary>
        /// 问题级别
        /// </summary>
        [XmlElement("question_level")]
        public string QuestionLevel { get; set; }

        /// <summary>
        /// 会话标签
        /// </summary>
        [XmlElement("session_label")]
        public string SessionLabel { get; set; }
    }
}
