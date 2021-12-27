using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// BelongMerchantInfo Data Structure.
    /// </summary>
    [Serializable]
    public class BelongMerchantInfo : AopObject
    {
        /// <summary>
        /// 合作业务类型,默认为ISV_FOR_MERCHANT  枚举值: ISV 服务商平台模式 ISV_FOR_MERCHANT 服务商代运营模式 限制: 1、ISV(平台模式)只有兑换券即voucher_type值为EXCHANGE_VOUCHER时才能使用
        /// </summary>
        [XmlElement("business_type")]
        public string BusinessType { get; set; }

        /// <summary>
        /// 商户id  限制: 1、服务商代运营模式必传 2、服务商代运营模式下服务商必须与商户建立代运营授权关系。代运营授权流程https://opendocs.alipay.com/mini/01hm6i#%E4%BB%A3%E8%BF%90%E8%90%A5%E6%8E%88%E6%9D%83
        /// </summary>
        [XmlElement("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 商户id类型。  枚举值： SMID 间连SMID PID    直连PID   特别说明： 如果merchant_id_type选择SMID。则表明当前商家券活动的归属者是该SMID所绑定的支付宝PID。 因此要求该SMID必须绑定相应的支付宝PID。  限制: 服务商代运营模式必传
        /// </summary>
        [XmlElement("merchant_id_type")]
        public string MerchantIdType { get; set; }
    }
}
