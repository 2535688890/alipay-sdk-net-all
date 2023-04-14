using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayOpenAppServiceViewcallbackQueryResponse.
    /// </summary>
    public class AlipayOpenAppServiceViewcallbackQueryResponse : AopResponse
    {
        /// <summary>
        /// 服务关联的服务标准类目ID和名称关系
        /// </summary>
        [XmlElement("catalog_map")]
        public string CatalogMap { get; set; }

        /// <summary>
        /// 服务属性扩展值，入关联的父服务编码，不同来源的服务之间可能存在差异性
        /// </summary>
        [XmlElement("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 高德POI_ID列表，多个之间以英文逗号分隔
        /// </summary>
        [XmlElement("poi_ids")]
        public string PoiIds { get; set; }

        /// <summary>
        /// 服务载体编码
        /// </summary>
        [XmlElement("service_carrier_code")]
        public string ServiceCarrierCode { get; set; }

        /// <summary>
        /// 载体类型
        /// </summary>
        [XmlElement("service_carrier_type")]
        public string ServiceCarrierType { get; set; }

        /// <summary>
        /// 载体url
        /// </summary>
        [XmlElement("service_carrier_url")]
        public string ServiceCarrierUrl { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [XmlElement("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务颗粒度如FUNCTION(功能级服务)
        /// </summary>
        [XmlElement("service_granularity_type")]
        public string ServiceGranularityType { get; set; }

        /// <summary>
        /// 服务logo
        /// </summary>
        [XmlElement("service_logo")]
        public string ServiceLogo { get; set; }

        /// <summary>
        /// VALID--生效、INVALID--失效
        /// </summary>
        [XmlElement("service_major_status")]
        public string ServiceMajorStatus { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [XmlElement("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务短描述
        /// </summary>
        [XmlElement("service_simple_desc")]
        public string ServiceSimpleDesc { get; set; }

        /// <summary>
        /// 服务来源
        /// </summary>
        [XmlElement("service_spec_code")]
        public string ServiceSpecCode { get; set; }
    }
}
