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
    /// AlipayOpenMiniTipsStatisticQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniTipsStatisticQueryResponseModel")]
    public partial class AlipayOpenMiniTipsStatisticQueryResponseModel : IEquatable<AlipayOpenMiniTipsStatisticQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniTipsStatisticQueryResponseModel" /> class.
        /// </summary>
        /// <param name="appCollectCnt">昨日（接口调用当日的前一天）小程序收藏人数，时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="appUv">昨日（接口调用当日的前一天）小程序访问人数。当小程序日访问量为0，或以活动维度查询，或时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="deliveryContent">收藏文案内容（仅以app维度查询时为空）,仅活动维度查询成功时返回。.</param>
        /// <param name="deliveryId">收藏引导投放活动ID（仅以app维度查询时为空）,仅活动维度查询成功时返回。.</param>
        /// <param name="tipsCollectRate">昨日（接口调用当日的前一天）收藏引导文案收藏转化率，数据为小数字符串类型，取小数点后两位，单位为百分比。小程序曝光数为0，或时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="tipsCollectUv">昨日（接口调用当日的前一天）收藏引导文案收藏用户数，时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="tipsExpoUv">昨日（接口调用当日的前一天）收藏引导文案曝光用户数，时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="totalAppCollectCnt">时间段内累计小程序收藏人数，时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="totalAppUv">时间段内累计小程序访问人数。当小程序日访问量为0，或以活动维度查询，或时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="totalTipsCollectRate">时间段内收藏引导文案收藏转化率，数据为小数字符串类型，取小数点后两位，单位为百分比。小程序曝光数为0，或时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="totalTipsCollectUv">时间段内累计收藏引导文案收藏用户数，时间内未创建投放活动，则响应时不传出参数。.</param>
        /// <param name="totalTipsExpoUv">时间段内累计收藏引导文案曝光用户数，仅当小程序/活动投放活动时返回。时间内未创建投放活动，则响应时不传出参数。.</param>
        public AlipayOpenMiniTipsStatisticQueryResponseModel(int appCollectCnt = default(int), int appUv = default(int), string deliveryContent = default(string), string deliveryId = default(string), string tipsCollectRate = default(string), int tipsCollectUv = default(int), int tipsExpoUv = default(int), int totalAppCollectCnt = default(int), int totalAppUv = default(int), string totalTipsCollectRate = default(string), int totalTipsCollectUv = default(int), int totalTipsExpoUv = default(int))
        {
            this.AppCollectCnt = appCollectCnt;
            this.AppUv = appUv;
            this.DeliveryContent = deliveryContent;
            this.DeliveryId = deliveryId;
            this.TipsCollectRate = tipsCollectRate;
            this.TipsCollectUv = tipsCollectUv;
            this.TipsExpoUv = tipsExpoUv;
            this.TotalAppCollectCnt = totalAppCollectCnt;
            this.TotalAppUv = totalAppUv;
            this.TotalTipsCollectRate = totalTipsCollectRate;
            this.TotalTipsCollectUv = totalTipsCollectUv;
            this.TotalTipsExpoUv = totalTipsExpoUv;
        }

        /// <summary>
        /// 昨日（接口调用当日的前一天）小程序收藏人数，时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>昨日（接口调用当日的前一天）小程序收藏人数，时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "app_collect_cnt", EmitDefaultValue = false)]
        public int AppCollectCnt { get; set; }

        /// <summary>
        /// 昨日（接口调用当日的前一天）小程序访问人数。当小程序日访问量为0，或以活动维度查询，或时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>昨日（接口调用当日的前一天）小程序访问人数。当小程序日访问量为0，或以活动维度查询，或时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "app_uv", EmitDefaultValue = false)]
        public int AppUv { get; set; }

        /// <summary>
        /// 收藏文案内容（仅以app维度查询时为空）,仅活动维度查询成功时返回。
        /// </summary>
        /// <value>收藏文案内容（仅以app维度查询时为空）,仅活动维度查询成功时返回。</value>
        [DataMember(Name = "delivery_content", EmitDefaultValue = false)]
        public string DeliveryContent { get; set; }

        /// <summary>
        /// 收藏引导投放活动ID（仅以app维度查询时为空）,仅活动维度查询成功时返回。
        /// </summary>
        /// <value>收藏引导投放活动ID（仅以app维度查询时为空）,仅活动维度查询成功时返回。</value>
        [DataMember(Name = "delivery_id", EmitDefaultValue = false)]
        public string DeliveryId { get; set; }

        /// <summary>
        /// 昨日（接口调用当日的前一天）收藏引导文案收藏转化率，数据为小数字符串类型，取小数点后两位，单位为百分比。小程序曝光数为0，或时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>昨日（接口调用当日的前一天）收藏引导文案收藏转化率，数据为小数字符串类型，取小数点后两位，单位为百分比。小程序曝光数为0，或时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "tips_collect_rate", EmitDefaultValue = false)]
        public string TipsCollectRate { get; set; }

        /// <summary>
        /// 昨日（接口调用当日的前一天）收藏引导文案收藏用户数，时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>昨日（接口调用当日的前一天）收藏引导文案收藏用户数，时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "tips_collect_uv", EmitDefaultValue = false)]
        public int TipsCollectUv { get; set; }

        /// <summary>
        /// 昨日（接口调用当日的前一天）收藏引导文案曝光用户数，时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>昨日（接口调用当日的前一天）收藏引导文案曝光用户数，时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "tips_expo_uv", EmitDefaultValue = false)]
        public int TipsExpoUv { get; set; }

        /// <summary>
        /// 时间段内累计小程序收藏人数，时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>时间段内累计小程序收藏人数，时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "total_app_collect_cnt", EmitDefaultValue = false)]
        public int TotalAppCollectCnt { get; set; }

        /// <summary>
        /// 时间段内累计小程序访问人数。当小程序日访问量为0，或以活动维度查询，或时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>时间段内累计小程序访问人数。当小程序日访问量为0，或以活动维度查询，或时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "total_app_uv", EmitDefaultValue = false)]
        public int TotalAppUv { get; set; }

        /// <summary>
        /// 时间段内收藏引导文案收藏转化率，数据为小数字符串类型，取小数点后两位，单位为百分比。小程序曝光数为0，或时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>时间段内收藏引导文案收藏转化率，数据为小数字符串类型，取小数点后两位，单位为百分比。小程序曝光数为0，或时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "total_tips_collect_rate", EmitDefaultValue = false)]
        public string TotalTipsCollectRate { get; set; }

        /// <summary>
        /// 时间段内累计收藏引导文案收藏用户数，时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>时间段内累计收藏引导文案收藏用户数，时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "total_tips_collect_uv", EmitDefaultValue = false)]
        public int TotalTipsCollectUv { get; set; }

        /// <summary>
        /// 时间段内累计收藏引导文案曝光用户数，仅当小程序/活动投放活动时返回。时间内未创建投放活动，则响应时不传出参数。
        /// </summary>
        /// <value>时间段内累计收藏引导文案曝光用户数，仅当小程序/活动投放活动时返回。时间内未创建投放活动，则响应时不传出参数。</value>
        [DataMember(Name = "total_tips_expo_uv", EmitDefaultValue = false)]
        public int TotalTipsExpoUv { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniTipsStatisticQueryResponseModel {\n");
            sb.Append("  AppCollectCnt: ").Append(AppCollectCnt).Append("\n");
            sb.Append("  AppUv: ").Append(AppUv).Append("\n");
            sb.Append("  DeliveryContent: ").Append(DeliveryContent).Append("\n");
            sb.Append("  DeliveryId: ").Append(DeliveryId).Append("\n");
            sb.Append("  TipsCollectRate: ").Append(TipsCollectRate).Append("\n");
            sb.Append("  TipsCollectUv: ").Append(TipsCollectUv).Append("\n");
            sb.Append("  TipsExpoUv: ").Append(TipsExpoUv).Append("\n");
            sb.Append("  TotalAppCollectCnt: ").Append(TotalAppCollectCnt).Append("\n");
            sb.Append("  TotalAppUv: ").Append(TotalAppUv).Append("\n");
            sb.Append("  TotalTipsCollectRate: ").Append(TotalTipsCollectRate).Append("\n");
            sb.Append("  TotalTipsCollectUv: ").Append(TotalTipsCollectUv).Append("\n");
            sb.Append("  TotalTipsExpoUv: ").Append(TotalTipsExpoUv).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniTipsStatisticQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniTipsStatisticQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniTipsStatisticQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniTipsStatisticQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppCollectCnt == input.AppCollectCnt ||
                    this.AppCollectCnt.Equals(input.AppCollectCnt)
                ) && 
                (
                    this.AppUv == input.AppUv ||
                    this.AppUv.Equals(input.AppUv)
                ) && 
                (
                    this.DeliveryContent == input.DeliveryContent ||
                    (this.DeliveryContent != null &&
                    this.DeliveryContent.Equals(input.DeliveryContent))
                ) && 
                (
                    this.DeliveryId == input.DeliveryId ||
                    (this.DeliveryId != null &&
                    this.DeliveryId.Equals(input.DeliveryId))
                ) && 
                (
                    this.TipsCollectRate == input.TipsCollectRate ||
                    (this.TipsCollectRate != null &&
                    this.TipsCollectRate.Equals(input.TipsCollectRate))
                ) && 
                (
                    this.TipsCollectUv == input.TipsCollectUv ||
                    this.TipsCollectUv.Equals(input.TipsCollectUv)
                ) && 
                (
                    this.TipsExpoUv == input.TipsExpoUv ||
                    this.TipsExpoUv.Equals(input.TipsExpoUv)
                ) && 
                (
                    this.TotalAppCollectCnt == input.TotalAppCollectCnt ||
                    this.TotalAppCollectCnt.Equals(input.TotalAppCollectCnt)
                ) && 
                (
                    this.TotalAppUv == input.TotalAppUv ||
                    this.TotalAppUv.Equals(input.TotalAppUv)
                ) && 
                (
                    this.TotalTipsCollectRate == input.TotalTipsCollectRate ||
                    (this.TotalTipsCollectRate != null &&
                    this.TotalTipsCollectRate.Equals(input.TotalTipsCollectRate))
                ) && 
                (
                    this.TotalTipsCollectUv == input.TotalTipsCollectUv ||
                    this.TotalTipsCollectUv.Equals(input.TotalTipsCollectUv)
                ) && 
                (
                    this.TotalTipsExpoUv == input.TotalTipsExpoUv ||
                    this.TotalTipsExpoUv.Equals(input.TotalTipsExpoUv)
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
                hashCode = (hashCode * 59) + this.AppCollectCnt.GetHashCode();
                hashCode = (hashCode * 59) + this.AppUv.GetHashCode();
                if (this.DeliveryContent != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryContent.GetHashCode();
                }
                if (this.DeliveryId != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryId.GetHashCode();
                }
                if (this.TipsCollectRate != null)
                {
                    hashCode = (hashCode * 59) + this.TipsCollectRate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TipsCollectUv.GetHashCode();
                hashCode = (hashCode * 59) + this.TipsExpoUv.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalAppCollectCnt.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalAppUv.GetHashCode();
                if (this.TotalTipsCollectRate != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTipsCollectRate.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalTipsCollectUv.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalTipsExpoUv.GetHashCode();
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
