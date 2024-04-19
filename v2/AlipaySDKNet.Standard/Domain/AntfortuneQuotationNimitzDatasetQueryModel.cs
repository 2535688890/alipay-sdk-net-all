using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AntfortuneQuotationNimitzDatasetQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AntfortuneQuotationNimitzDatasetQueryModel : AopObject
    {
        /// <summary>
        /// Nimitz 查询语境
        /// </summary>
        [XmlElement("context")]
        public NimitzQueryContext Context { get; set; }

        /// <summary>
        /// 预留的扩展字段，json格式。
        /// </summary>
        [XmlElement("ext")]
        public string Ext { get; set; }

        /// <summary>
        /// Nimitz Dataset 请求
        /// </summary>
        [XmlElement("nimitz_dataset_request")]
        public NimitzDatasetRequest NimitzDatasetRequest { get; set; }

        /// <summary>
        /// 选择性参数，用于附带一些查询条件。
        /// </summary>
        [XmlElement("opt")]
        public string Opt { get; set; }

        /// <summary>
        /// 请求唯一id，用于排查问题
        /// </summary>
        [XmlElement("request_id")]
        public string RequestId { get; set; }
    }
}
