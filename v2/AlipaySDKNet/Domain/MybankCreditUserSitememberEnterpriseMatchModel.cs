using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MybankCreditUserSitememberEnterpriseMatchModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditUserSitememberEnterpriseMatchModel : AopObject
    {
        /// <summary>
        /// 工商注册号，与social_credit_code字段不能同时为空
        /// </summary>
        [XmlElement("business_reg_no")]
        public string BusinessRegNo { get; set; }

        /// <summary>
        /// 公司名称
        /// </summary>
        [XmlElement("company_name")]
        public string CompanyName { get; set; }

        /// <summary>
        /// 站点类型，如支付宝、淘宝等
        /// </summary>
        [XmlElement("site")]
        public string Site { get; set; }

        /// <summary>
        /// 站点登录号，比如企业支付宝的手机号或邮箱
        /// </summary>
        [XmlElement("site_login_id")]
        public string SiteLoginId { get; set; }

        /// <summary>
        /// 统一社会信用代码，与business_reg_no字段不能同时为空
        /// </summary>
        [XmlElement("social_credit_code")]
        public string SocialCreditCode { get; set; }
    }
}
