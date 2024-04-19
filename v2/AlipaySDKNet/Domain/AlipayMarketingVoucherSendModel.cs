using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingVoucherSendModel : AopObject
    {
        /// <summary>
        /// 券金额。浮点数，格式为#.00，单位是元。红包发放时填写，其它情形不能填
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 扩展参数，当前仅允许传入的key值为"alipayMiniAppToken"
        /// </summary>
        [XmlElement("extend_info")]
        public string ExtendInfo { get; set; }

        /// <summary>
        /// 支付宝登录ID，手机或邮箱 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [XmlElement("login_id")]
        public string LoginId { get; set; }

        /// <summary>
        /// 发券备注
        /// </summary>
        [XmlElement("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 支付宝用户ID 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [XmlElement("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部业务订单号，用于幂等控制，相同template_id和out_biz_no认为是同一次业务
        /// </summary>
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 淘宝昵称 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [XmlElement("taobao_nick")]
        public string TaobaoNick { get; set; }

        /// <summary>
        /// 券模板ID。如 <a href="https://opendocs.alipay.com/open/20170515180730063964/oe1vs5">无资金优惠券</a>、<a href="https://opendocs.alipay.com/open/20170320142638022200/fgxzva">现金抵价券</a> 创建的券模板id。
        /// </summary>
        [XmlElement("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 支付宝用户ID 。user_id, login_id, taobao_nick不能同时为空，优先级依次降低
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
