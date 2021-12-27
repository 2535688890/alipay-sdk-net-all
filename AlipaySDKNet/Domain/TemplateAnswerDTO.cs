using System;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Aop.Api.Domain
{
    /// <summary>
    /// TemplateAnswerDTO Data Structure.
    /// </summary>
    [Serializable]
    public class TemplateAnswerDTO : AopObject
    {
        /// <summary>
        /// 答题对应的表达式
        /// </summary>
        [XmlElement("exp")]
        public string Exp { get; set; }

        /// <summary>
        /// 标签名称
        /// </summary>
        [XmlElement("label_name")]
        public string LabelName { get; set; }

        /// <summary>
        /// 表单提示
        /// </summary>
        [XmlElement("placeholder")]
        public string Placeholder { get; set; }

        /// <summary>
        /// 答题元素列表
        /// </summary>
        [XmlArray("selects")]
        [XmlArrayItem("answer_select_d_t_o")]
        public List<AnswerSelectDTO> Selects { get; set; }

        /// <summary>
        /// 输入框类型
        /// </summary>
        [XmlElement("type")]
        public string Type { get; set; }

        /// <summary>
        /// 唯一标识
        /// </summary>
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
