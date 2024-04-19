using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayInsSceneEmploymentGroupendorseCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsSceneEmploymentGroupendorseCancelModel : AopObject
    {
        /// <summary>
        /// 批改类型
        /// </summary>
        [XmlElement("endorse_order_type")]
        public string EndorseOrderType { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 渠道
        /// </summary>
        [XmlElement("partner_org_id")]
        public string PartnerOrgId { get; set; }

        /// <summary>
        /// 批减子单列表
        /// </summary>
        [XmlArray("policy_list")]
        [XmlArrayItem("string")]
        public List<string> PolicyList { get; set; }

        /// <summary>
        /// 场景
        /// </summary>
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }

        /// <summary>
        /// 主单号
        /// </summary>
        [XmlElement("summary_order_no")]
        public string SummaryOrderNo { get; set; }
    }
}
