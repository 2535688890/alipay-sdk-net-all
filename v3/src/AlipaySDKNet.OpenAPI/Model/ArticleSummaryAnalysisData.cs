/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-05-20
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = AlipaySDKNet.OpenAPI.Client.OpenAPIDateConverter;

namespace AlipaySDKNet.OpenAPI.Model
{
    /// <summary>
    /// ArticleSummaryAnalysisData
    /// </summary>
    [DataContract(Name = "ArticleSummaryAnalysisData")]
    public partial class ArticleSummaryAnalysisData : IEquatable<ArticleSummaryAnalysisData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleSummaryAnalysisData" /> class.
        /// </summary>
        /// <param name="avgReadTime">人均阅读时长.</param>
        /// <param name="date">日期.</param>
        /// <param name="deliverUserCnt">送达人数.</param>
        /// <param name="exposeUserCnt">图文曝光人数.</param>
        /// <param name="praiseUserCnt">点赞数.</param>
        /// <param name="readUserCnt">图文阅读人数.</param>
        /// <param name="replyUserCnt">评论数.</param>
        /// <param name="shareUserCnt">分享人数.</param>
        public ArticleSummaryAnalysisData(string avgReadTime = default(string), string date = default(string), int deliverUserCnt = default(int), int exposeUserCnt = default(int), int praiseUserCnt = default(int), int readUserCnt = default(int), int replyUserCnt = default(int), int shareUserCnt = default(int))
        {
            this.AvgReadTime = avgReadTime;
            this.Date = date;
            this.DeliverUserCnt = deliverUserCnt;
            this.ExposeUserCnt = exposeUserCnt;
            this.PraiseUserCnt = praiseUserCnt;
            this.ReadUserCnt = readUserCnt;
            this.ReplyUserCnt = replyUserCnt;
            this.ShareUserCnt = shareUserCnt;
        }

        /// <summary>
        /// 人均阅读时长
        /// </summary>
        /// <value>人均阅读时长</value>
        [DataMember(Name = "avg_read_time", EmitDefaultValue = false)]
        public string AvgReadTime { get; set; }

        /// <summary>
        /// 日期
        /// </summary>
        /// <value>日期</value>
        [DataMember(Name = "date", EmitDefaultValue = false)]
        public string Date { get; set; }

        /// <summary>
        /// 送达人数
        /// </summary>
        /// <value>送达人数</value>
        [DataMember(Name = "deliver_user_cnt", EmitDefaultValue = false)]
        public int DeliverUserCnt { get; set; }

        /// <summary>
        /// 图文曝光人数
        /// </summary>
        /// <value>图文曝光人数</value>
        [DataMember(Name = "expose_user_cnt", EmitDefaultValue = false)]
        public int ExposeUserCnt { get; set; }

        /// <summary>
        /// 点赞数
        /// </summary>
        /// <value>点赞数</value>
        [DataMember(Name = "praise_user_cnt", EmitDefaultValue = false)]
        public int PraiseUserCnt { get; set; }

        /// <summary>
        /// 图文阅读人数
        /// </summary>
        /// <value>图文阅读人数</value>
        [DataMember(Name = "read_user_cnt", EmitDefaultValue = false)]
        public int ReadUserCnt { get; set; }

        /// <summary>
        /// 评论数
        /// </summary>
        /// <value>评论数</value>
        [DataMember(Name = "reply_user_cnt", EmitDefaultValue = false)]
        public int ReplyUserCnt { get; set; }

        /// <summary>
        /// 分享人数
        /// </summary>
        /// <value>分享人数</value>
        [DataMember(Name = "share_user_cnt", EmitDefaultValue = false)]
        public int ShareUserCnt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArticleSummaryAnalysisData {\n");
            sb.Append("  AvgReadTime: ").Append(AvgReadTime).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  DeliverUserCnt: ").Append(DeliverUserCnt).Append("\n");
            sb.Append("  ExposeUserCnt: ").Append(ExposeUserCnt).Append("\n");
            sb.Append("  PraiseUserCnt: ").Append(PraiseUserCnt).Append("\n");
            sb.Append("  ReadUserCnt: ").Append(ReadUserCnt).Append("\n");
            sb.Append("  ReplyUserCnt: ").Append(ReplyUserCnt).Append("\n");
            sb.Append("  ShareUserCnt: ").Append(ShareUserCnt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ArticleSummaryAnalysisData);
        }

        /// <summary>
        /// Returns true if ArticleSummaryAnalysisData instances are equal
        /// </summary>
        /// <param name="input">Instance of ArticleSummaryAnalysisData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleSummaryAnalysisData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AvgReadTime == input.AvgReadTime ||
                    (this.AvgReadTime != null &&
                    this.AvgReadTime.Equals(input.AvgReadTime))
                ) && 
                (
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
                ) && 
                (
                    this.DeliverUserCnt == input.DeliverUserCnt ||
                    this.DeliverUserCnt.Equals(input.DeliverUserCnt)
                ) && 
                (
                    this.ExposeUserCnt == input.ExposeUserCnt ||
                    this.ExposeUserCnt.Equals(input.ExposeUserCnt)
                ) && 
                (
                    this.PraiseUserCnt == input.PraiseUserCnt ||
                    this.PraiseUserCnt.Equals(input.PraiseUserCnt)
                ) && 
                (
                    this.ReadUserCnt == input.ReadUserCnt ||
                    this.ReadUserCnt.Equals(input.ReadUserCnt)
                ) && 
                (
                    this.ReplyUserCnt == input.ReplyUserCnt ||
                    this.ReplyUserCnt.Equals(input.ReplyUserCnt)
                ) && 
                (
                    this.ShareUserCnt == input.ShareUserCnt ||
                    this.ShareUserCnt.Equals(input.ShareUserCnt)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.AvgReadTime != null)
                {
                    hashCode = (hashCode * 59) + this.AvgReadTime.GetHashCode();
                }
                if (this.Date != null)
                {
                    hashCode = (hashCode * 59) + this.Date.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeliverUserCnt.GetHashCode();
                hashCode = (hashCode * 59) + this.ExposeUserCnt.GetHashCode();
                hashCode = (hashCode * 59) + this.PraiseUserCnt.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadUserCnt.GetHashCode();
                hashCode = (hashCode * 59) + this.ReplyUserCnt.GetHashCode();
                hashCode = (hashCode * 59) + this.ShareUserCnt.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
