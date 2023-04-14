using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceIotDeviceUpgradeappCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotDeviceUpgradeappCreateModel : AopObject
    {
        /// <summary>
        /// 用户问题排查是的问题记录
        /// </summary>
        [XmlElement("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 设备的标示
        /// </summary>
        [XmlArray("sn")]
        [XmlArrayItem("string")]
        public List<string> Sn { get; set; }

        /// <summary>
        /// 目标应用的唯一标示
        /// </summary>
        [XmlElement("target_app_id")]
        public string TargetAppId { get; set; }

        /// <summary>
        /// 应用需要升级到的目标版本
        /// </summary>
        [XmlElement("target_app_version")]
        public string TargetAppVersion { get; set; }
    }
}
