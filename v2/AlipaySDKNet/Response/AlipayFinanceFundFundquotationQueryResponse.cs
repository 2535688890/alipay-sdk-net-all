using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayFinanceFundFundquotationQueryResponse.
    /// </summary>
    public class AlipayFinanceFundFundquotationQueryResponse : AopResponse
    {
        /// <summary>
        /// 近半年收益：基金产品近半年内收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_half_year")]
        public string LastHalfYear { get; set; }

        /// <summary>
        /// 近一月收益率：基金产品近一月内收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_month")]
        public string LastMonth { get; set; }

        /// <summary>
        /// 近三月收益：基金产品近三月内收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_quarter")]
        public string LastQuarter { get; set; }

        /// <summary>
        /// 近一周收益率：基金产品近一周内收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_week")]
        public string LastWeek { get; set; }

        /// <summary>
        /// 近一年收益率：基金产品近一年内收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("last_year")]
        public string LastYear { get; set; }

        /// <summary>
        /// 发布日期：产品收益率发布的时间
        /// </summary>
        [XmlElement("report_date")]
        public string ReportDate { get; set; }

        /// <summary>
        /// 成立以来收益率：基金产品成立以来收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("since_establishment")]
        public string SinceEstablishment { get; set; }

        /// <summary>
        /// 今年以来收益率：基金产品今年以来收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("this_year")]
        public string ThisYear { get; set; }

        /// <summary>
        /// 三年内收益率：基金产品三年内收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("yield_3_year")]
        public string Yield3Year { get; set; }

        /// <summary>
        /// 近五年收益率：基金产品近五年内收益率  四舍五入后保留小数点后4位
        /// </summary>
        [XmlElement("yield_5_year")]
        public string Yield5Year { get; set; }
    }
}
