using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TradeSettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class TradeSettleInfo : AopObject
    {
        /// <summary>
        /// 交易结算明细信息
        /// </summary>
        [XmlArray("trade_settle_detail_list")]
        [XmlArrayItem("trade_settle_detail")]
        public List<TradeSettleDetail> TradeSettleDetailList { get; set; }

        /// <summary>
        /// 直付通账期、直连账期下返回，其他场景为空，表示一笔订单剩余待结算金额
        /// </summary>
        [XmlElement("trade_unsettled_amount")]
        public string TradeUnsettledAmount { get; set; }
    }
}
