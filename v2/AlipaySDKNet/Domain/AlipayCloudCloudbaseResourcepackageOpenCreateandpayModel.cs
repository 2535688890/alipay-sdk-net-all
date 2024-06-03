using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCloudCloudbaseResourcepackageOpenCreateandpayModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCloudCloudbaseResourcepackageOpenCreateandpayModel : AopObject
    {
        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [XmlElement("alipay_user_id")]
        public string AlipayUserId { get; set; }

        /// <summary>
        /// 是否自动续费
        /// </summary>
        [XmlElement("auto_renew")]
        public bool AutoRenew { get; set; }

        /// <summary>
        /// 小程序id
        /// </summary>
        [XmlElement("biz_app_id")]
        public string BizAppId { get; set; }

        /// <summary>
        /// 优惠券code列表，目前只使用第一张
        /// </summary>
        [XmlArray("coupon_codes")]
        [XmlArrayItem("string")]
        public List<string> CouponCodes { get; set; }

        /// <summary>
        /// 环境描述
        /// </summary>
        [XmlElement("env_description")]
        public string EnvDescription { get; set; }

        /// <summary>
        /// 环境名称
        /// </summary>
        [XmlElement("env_name")]
        public string EnvName { get; set; }

        /// <summary>
        /// 用于标记支付宝用户在应用下的唯一标识
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 购买时长(月)
        /// </summary>
        [XmlElement("purchase_month")]
        public long PurchaseMonth { get; set; }

        /// <summary>
        /// 环境区域  - cn-hangzhou
        /// </summary>
        [XmlElement("region")]
        public string Region { get; set; }

        /// <summary>
        /// 资源包规格编码  - public_cloudd_cd_cn_free_bag  - public_cloudd_cd_cn_base_bag  - public_cloudd_cd_cn_standard_bag  - public_cloudd_cd_cn_pro_bag  - public_cloudd_cd_cn_ent_bag  - public_cloudd_cd_cn_flagship_bag
        /// </summary>
        [XmlElement("spec_code")]
        public string SpecCode { get; set; }
    }
}
