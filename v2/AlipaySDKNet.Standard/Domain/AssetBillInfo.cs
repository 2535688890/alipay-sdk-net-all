using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AssetBillInfo Data Structure.
    /// </summary>
    [Serializable]
    public class AssetBillInfo : AopObject
    {
        /// <summary>
        /// 单据金额 amount = asset_amount + 手续费
        /// </summary>
        [XmlElement("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 资产金额
        /// </summary>
        [XmlElement("asset_amount")]
        public string AssetAmount { get; set; }

        /// <summary>
        /// 资产id，资金单据流水所属资产的id
        /// </summary>
        [XmlElement("asset_id")]
        public string AssetId { get; set; }

        /// <summary>
        /// 资产类型，资金流水所属资产的类型，BENEFIT_TEMPLATE表示权益模板，由支付宝权益结算平台定义
        /// </summary>
        [XmlElement("asset_type")]
        public string AssetType { get; set; }

        /// <summary>
        /// 资金单据流水号
        /// </summary>
        [XmlElement("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        [XmlElement("biz_dt")]
        public string BizDt { get; set; }

        /// <summary>
        /// biz_type = BENEFIT_TEMPLATE_RECHARGE时有效，表示业务系统来源
        /// </summary>
        [XmlElement("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 业务号，上游业务系统填充的业务号
        /// </summary>
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 业务类型 BENEFIT_TEMPLATE_RECHARGE: 创建模版 BENEFIT_TEMPLATE_RECYCLE: 模版回收 BENEFIT_TEMPLATE_SETTLE: 结算 BENEFIT_TEMPLATE_APPEND: 追加
        /// </summary>
        [XmlElement("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// biz_type=BENEFIT_TEMPLATE_RECHARGE时有效，表示活动id
        /// </summary>
        [XmlElement("camp_id")]
        public string CampId { get; set; }

        /// <summary>
        /// 外部资金单据号
        /// </summary>
        [XmlElement("out_bill_no")]
        public string OutBillNo { get; set; }

        /// <summary>
        /// biz_type = BENEFIT_TEMPLATE_SETTLE时有效，表示结算收款方账号
        /// </summary>
        [XmlElement("partner_settle_id")]
        public string PartnerSettleId { get; set; }

        /// <summary>
        /// biz_type= BENEFIT_TEMPLATE_SETTLE时有效，表示结算收款方账号类型
        /// </summary>
        [XmlElement("partner_settle_id_type")]
        public string PartnerSettleIdType { get; set; }

        /// <summary>
        /// 流水状态 I：初始化，结算已受理，资金划拨尚未完成； S：划拨资金成功； C：划拨资金失败
        /// </summary>
        [XmlElement("status")]
        public string Status { get; set; }

        /// <summary>
        /// biz_type = BENEFIT_TEMPLATE_SETTLE时有效，表示结算交易时间
        /// </summary>
        [XmlElement("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 资产所属方的支付宝会员id
        /// </summary>
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
