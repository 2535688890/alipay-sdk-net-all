using System;
using System.Xml.Serialization;

namespace Aop.Api.Domain
{
    /// <summary>
    /// QuotaGradientRule Data Structure.
    /// </summary>
    [Serializable]
    public class QuotaGradientRule : AopObject
    {
        /// <summary>
        /// 芝麻分350-400限额
        /// </summary>
        [XmlElement("score_400")]
        public long Score400 { get; set; }

        /// <summary>
        /// 芝麻分400-450限额
        /// </summary>
        [XmlElement("score_450")]
        public long Score450 { get; set; }

        /// <summary>
        /// 芝麻分450-500限额
        /// </summary>
        [XmlElement("score_500")]
        public long Score500 { get; set; }

        /// <summary>
        /// 芝麻分500-550限额
        /// </summary>
        [XmlElement("score_550")]
        public long Score550 { get; set; }

        /// <summary>
        /// 芝麻分550-600限额
        /// </summary>
        [XmlElement("score_600")]
        public long Score600 { get; set; }

        /// <summary>
        /// 芝麻分600-650限额
        /// </summary>
        [XmlElement("score_650")]
        public long Score650 { get; set; }

        /// <summary>
        /// 芝麻分650-700限额
        /// </summary>
        [XmlElement("score_700")]
        public long Score700 { get; set; }

        /// <summary>
        /// 芝麻分700-750限额
        /// </summary>
        [XmlElement("score_750")]
        public long Score750 { get; set; }

        /// <summary>
        /// 芝麻分750-800限额
        /// </summary>
        [XmlElement("score_800")]
        public long Score800 { get; set; }

        /// <summary>
        /// 芝麻分800-850限额
        /// </summary>
        [XmlElement("score_850")]
        public long Score850 { get; set; }

        /// <summary>
        /// 芝麻分850-900限额
        /// </summary>
        [XmlElement("score_900")]
        public long Score900 { get; set; }

        /// <summary>
        /// 芝麻分900-950限额
        /// </summary>
        [XmlElement("score_950")]
        public long Score950 { get; set; }
    }
}
