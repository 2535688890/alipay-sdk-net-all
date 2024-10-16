/*
 * 支付宝开放平台API
 *
 * 支付宝开放平台v3协议文档
 *
 * The version of the OpenAPI document: 2024-10-16
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
    /// MarketingDeliveryDetail
    /// </summary>
    [DataContract(Name = "MarketingDeliveryDetail")]
    public partial class MarketingDeliveryDetail : IEquatable<MarketingDeliveryDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MarketingDeliveryDetail" /> class.
        /// </summary>
        /// <param name="bindIdList">投放详情绑定的模板id列表.</param>
        /// <param name="detailId">投放详情id.</param>
        /// <param name="gmtEnd">结束时间.</param>
        /// <param name="gmtStart">开始时间.</param>
        /// <param name="name">投放详情名称，取创建运营投放的title，未传title取券名称.</param>
        /// <param name="status">投放详情状态，INIT:下线状态，ON_LINE:上线状态.</param>
        public MarketingDeliveryDetail(List<string> bindIdList = default(List<string>), string detailId = default(string), string gmtEnd = default(string), string gmtStart = default(string), string name = default(string), string status = default(string))
        {
            this.BindIdList = bindIdList;
            this.DetailId = detailId;
            this.GmtEnd = gmtEnd;
            this.GmtStart = gmtStart;
            this.Name = name;
            this.Status = status;
        }

        /// <summary>
        /// 投放详情绑定的模板id列表
        /// </summary>
        /// <value>投放详情绑定的模板id列表</value>
        [DataMember(Name = "bind_id_list", EmitDefaultValue = false)]
        public List<string> BindIdList { get; set; }

        /// <summary>
        /// 投放详情id
        /// </summary>
        /// <value>投放详情id</value>
        [DataMember(Name = "detail_id", EmitDefaultValue = false)]
        public string DetailId { get; set; }

        /// <summary>
        /// 结束时间
        /// </summary>
        /// <value>结束时间</value>
        [DataMember(Name = "gmt_end", EmitDefaultValue = false)]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        /// <value>开始时间</value>
        [DataMember(Name = "gmt_start", EmitDefaultValue = false)]
        public string GmtStart { get; set; }

        /// <summary>
        /// 投放详情名称，取创建运营投放的title，未传title取券名称
        /// </summary>
        /// <value>投放详情名称，取创建运营投放的title，未传title取券名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 投放详情状态，INIT:下线状态，ON_LINE:上线状态
        /// </summary>
        /// <value>投放详情状态，INIT:下线状态，ON_LINE:上线状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MarketingDeliveryDetail {\n");
            sb.Append("  BindIdList: ").Append(BindIdList).Append("\n");
            sb.Append("  DetailId: ").Append(DetailId).Append("\n");
            sb.Append("  GmtEnd: ").Append(GmtEnd).Append("\n");
            sb.Append("  GmtStart: ").Append(GmtStart).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
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
            return this.Equals(input as MarketingDeliveryDetail);
        }

        /// <summary>
        /// Returns true if MarketingDeliveryDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of MarketingDeliveryDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MarketingDeliveryDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BindIdList == input.BindIdList ||
                    this.BindIdList != null &&
                    input.BindIdList != null &&
                    this.BindIdList.SequenceEqual(input.BindIdList)
                ) && 
                (
                    this.DetailId == input.DetailId ||
                    (this.DetailId != null &&
                    this.DetailId.Equals(input.DetailId))
                ) && 
                (
                    this.GmtEnd == input.GmtEnd ||
                    (this.GmtEnd != null &&
                    this.GmtEnd.Equals(input.GmtEnd))
                ) && 
                (
                    this.GmtStart == input.GmtStart ||
                    (this.GmtStart != null &&
                    this.GmtStart.Equals(input.GmtStart))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
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
                if (this.BindIdList != null)
                {
                    hashCode = (hashCode * 59) + this.BindIdList.GetHashCode();
                }
                if (this.DetailId != null)
                {
                    hashCode = (hashCode * 59) + this.DetailId.GetHashCode();
                }
                if (this.GmtEnd != null)
                {
                    hashCode = (hashCode * 59) + this.GmtEnd.GetHashCode();
                }
                if (this.GmtStart != null)
                {
                    hashCode = (hashCode * 59) + this.GmtStart.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
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
