using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceAntestMockgrouplistQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceAntestMockgrouplistQueryModel : AopObject
    {
        /// <summary>
        /// appId
        /// </summary>
        [XmlElement("app_code")]
        public string AppCode { get; set; }
    }
}
