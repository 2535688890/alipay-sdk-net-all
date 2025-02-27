using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// AlipayCommerceMerchantcardPricepropertyCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceMerchantcardPricepropertyCreateModel : AopObject
    {
        /// <summary>
        /// 卡ID
        /// </summary>
        [XmlElement("card_template_id")]
        public string CardTemplateId { get; set; }

        /// <summary>
        /// 卡名称
        /// </summary>
        [XmlElement("card_template_name")]
        public string CardTemplateName { get; set; }

        /// <summary>
        /// 卡类型，当不传card_template_id且传入card_type时，会取商户的默认卡ID
        /// </summary>
        [XmlElement("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 原价，单位：分
        /// </summary>
        [XmlElement("original_price")]
        public long OriginalPrice { get; set; }

        /// <summary>
        /// 每期价格
        /// </summary>
        [XmlArray("period_price_list")]
        [XmlArrayItem("card_period_price")]
        public List<CardPeriodPrice> PeriodPriceList { get; set; }

        /// <summary>
        /// 售卖价格，单位：分
        /// </summary>
        [XmlElement("sale_price")]
        public long SalePrice { get; set; }
    }
}
