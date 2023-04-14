using System;
using System.Xml.Serialization;

namespace Aop.Api.Response
{
    /// <summary>
    /// AlipayDataBillAccountbookereceiptApplyResponse.
    /// </summary>
    public class AlipayDataBillAccountbookereceiptApplyResponse : AopResponse
    {
        /// <summary>
        /// 文件申请号file_id信息。使用file_id可以查询处理状态
        /// </summary>
        [XmlElement("file_id")]
        public string FileId { get; set; }
    }
}
