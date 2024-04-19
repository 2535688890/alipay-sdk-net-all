using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// SettleDetailInfoDTO Data Structure.
    /// </summary>
    [Serializable]
    public class SettleDetailInfoDTO : AopObject
    {
        /// <summary>
        /// 仅在直付通账期模式下，当一笔交易需要分多次发起部分确认结算时使用，表示本次确认结算的实际结算金额。传递本字段后，原amount字段不再生效，结算金额以本字段为准。如已经发生过部分确认结算、不传递本字段则默认按剩余待结算金额一次性结算。
        /// </summary>
        [XmlElement("actual_amount")]
        public string ActualAmount { get; set; }

        /// <summary>
        /// 结算的金额，单位为元。在创建订单和支付接口时必须和交易金额相同。在结算确认接口时必须等于交易金额减去已退款金额。直付通账期模式下，如使用部分结算能力、传递了actual_amount字段，则忽略本字段的校验、可不传。
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 结算主体标识。当结算主体类型为SecondMerchant时，为二级商户的SecondMerchantID；当结算主体类型为Store时，为门店的外标。
        /// </summary>
        [XmlElement("settle_entity_id")]
        public string SettleEntityId { get; set; }

        /// <summary>
        /// 结算主体类型。 二级商户:SecondMerchant;商户或者直连商户门店:Store
        /// </summary>
        [XmlElement("settle_entity_type")]
        public string SettleEntityType { get; set; }

        /// <summary>
        /// 结算汇总维度，按照这个维度汇总成批次结算，由商户指定。 目前需要和结算收款方账户类型为cardAliasNo配合使用
        /// </summary>
        [XmlElement("summary_dimension")]
        public string SummaryDimension { get; set; }

        /// <summary>
        /// 结算收款方。当结算收款方类型是cardAliasNo时，本参数为用户在支付宝绑定的卡编号；结算收款方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字；当结算收款方类型是loginName时，本参数为用户的支付宝登录号；当结算收款方类型是defaultSettle时，本参数不能传值，保持为空。
        /// </summary>
        [XmlElement("trans_in")]
        public string TransIn { get; set; }

        /// <summary>
        /// 结算收款方的账户类型。 cardAliasNo：结算收款方的银行卡编号; userId：表示是支付宝账号对应的支付宝唯一用户号; loginName：表示是支付宝登录号； defaultSettle：表示结算到商户进件时设置的默认结算账号，结算主体为门店时不支持传defaultSettle；
        /// </summary>
        [XmlElement("trans_in_type")]
        public string TransInType { get; set; }
    }
}
