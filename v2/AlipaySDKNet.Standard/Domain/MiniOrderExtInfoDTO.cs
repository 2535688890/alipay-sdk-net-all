using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// MiniOrderExtInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class MiniOrderExtInfoDTO : AopObject
    {
        /// <summary>
        /// 二方接入交易组件用于返佣计算的特殊参数，单位为元
        /// </summary>
        [XmlElement("addition_rebate_base_price")]
        public string AdditionRebateBasePrice { get; set; }

        /// <summary>
        /// 预约上门取件的时间,格式为  yyyy-MM-dd HH:mm:ss
        /// </summary>
        [XmlElement("door_time")]
        public string DoorTime { get; set; }

        /// <summary>
        /// 芝麻免押冻结资金签名串，调用 <a href="https://opendocs.alipay.com/open/e2e70da4_alipay.fund.auth.order.app.freeze?pathHash=1002681c&ref=api">alipay.fund.auth.order.app.freeze</a>生成，用于租赁场景冻结授权资金
        /// </summary>
        [XmlElement("order_str")]
        public string OrderStr { get; set; }

        /// <summary>
        /// 订单的交易类型用于区分担保交易或者普通JSAPI支付，担保交易类型该字段必填，创支付单会对改类型进行校验，如果参入错误，创支付单会失败
        /// </summary>
        [XmlElement("order_trade_type")]
        public string OrderTradeType { get; set; }
    }
}
