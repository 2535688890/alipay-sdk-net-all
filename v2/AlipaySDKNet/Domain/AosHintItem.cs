using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AosHintItem Data Structure.
    /// </summary>
    [Serializable]
    public class AosHintItem : AopObject
    {
        /// <summary>
        /// 业务链路ID
        /// </summary>
        [XmlElement("biz_trace_id")]
        public string BizTraceId { get; set; }

        /// <summary>
        /// item的打分
        /// </summary>
        [XmlElement("score")]
        public string Score { get; set; }

        /// <summary>
        /// 搜索结果item的sequence用于关联搜索热搜和用户点击行为
        /// </summary>
        [XmlElement("sequence")]
        public string Sequence { get; set; }

        /// <summary>
        /// 热搜的展示title
        /// </summary>
        [XmlElement("title")]
        public string Title { get; set; }

        /// <summary>
        /// 热搜item的trace_id用于关联搜索结果和用户行为 当前字段已废弃(接口改造导致参数冲突)
        /// </summary>
        [XmlElement("trace_id")]
        public string TraceId { get; set; }
    }
}
