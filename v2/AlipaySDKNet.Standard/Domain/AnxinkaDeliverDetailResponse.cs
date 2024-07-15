using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AnxinkaDeliverDetailResponse Data Structure.
    /// </summary>
    [Serializable]
    public class AnxinkaDeliverDetailResponse : AopObject
    {
        /// <summary>
        /// 安心卡卡号
        /// </summary>
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [XmlElement("merchant_order_no")]
        public string MerchantOrderNo { get; set; }

        /// <summary>
        /// 平台订单号
        /// </summary>
        [XmlElement("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 安心付金额卡每笔退，卡使用扣除面额。单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 安心付金额卡每笔退，卡使用扣除实付面额。单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("refund_cash")]
        public string RefundCash { get; set; }

        /// <summary>
        /// 安心付金额卡每笔退款时间， 单位：秒。
        /// </summary>
        [XmlElement("refund_time")]
        public string RefundTime { get; set; }

        /// <summary>
        /// 安心付金额卡每笔使用收单商家账号
        /// </summary>
        [XmlElement("settle_pid")]
        public string SettlePid { get; set; }

        /// <summary>
        /// 安心付金额卡当前使用的核销门店的ID。
        /// </summary>
        [XmlElement("settle_shop_id")]
        public string SettleShopId { get; set; }

        /// <summary>
        /// 安心付金额卡当前使用的核销门店的门店备注名。
        /// </summary>
        [XmlElement("settle_shop_memo")]
        public string SettleShopMemo { get; set; }

        /// <summary>
        /// 安心付金额卡当前使用的核销门店的名称
        /// </summary>
        [XmlElement("settle_shop_name")]
        public string SettleShopName { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [XmlElement("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 安心付金额卡每笔使用，卡使用扣除面额。单位：元，精确到小数点后两位。
        /// </summary>
        [XmlElement("use_amount")]
        public string UseAmount { get; set; }

        /// <summary>
        /// 安心付金额卡每笔使用，卡使用扣除实付面额。单位：元，精确到小数点后两位
        /// </summary>
        [XmlElement("use_cash")]
        public string UseCash { get; set; }

        /// <summary>
        /// 安心付金额卡每笔使用状态，如已使用、已退款，是一个状态表示。
        /// </summary>
        [XmlElement("use_status")]
        public string UseStatus { get; set; }

        /// <summary>
        /// 安心付金额卡每笔使用时间，单位：秒。
        /// </summary>
        [XmlElement("use_time")]
        public string UseTime { get; set; }
    }
}
