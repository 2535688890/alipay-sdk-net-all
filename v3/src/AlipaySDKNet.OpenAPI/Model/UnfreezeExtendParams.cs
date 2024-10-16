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
    /// UnfreezeExtendParams
    /// </summary>
    [DataContract(Name = "UnfreezeExtendParams")]
    public partial class UnfreezeExtendParams : IEquatable<UnfreezeExtendParams>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UnfreezeExtendParams" /> class.
        /// </summary>
        /// <param name="quitType">退出类型.</param>
        /// <param name="totalDiscountAmount">芝麻Go开始到到期过程中享受的优惠总金额.</param>
        /// <param name="totalRealPayAmount">芝麻Go开始到到期过程中任务相关支付的总金额。.</param>
        /// <param name="totalTaskCount">芝麻Go开始到到期过程中和任务相关的完成次数.</param>
        public UnfreezeExtendParams(string quitType = default(string), string totalDiscountAmount = default(string), string totalRealPayAmount = default(string), string totalTaskCount = default(string))
        {
            this.QuitType = quitType;
            this.TotalDiscountAmount = totalDiscountAmount;
            this.TotalRealPayAmount = totalRealPayAmount;
            this.TotalTaskCount = totalTaskCount;
        }

        /// <summary>
        /// 退出类型
        /// </summary>
        /// <value>退出类型</value>
        [DataMember(Name = "quit_type", EmitDefaultValue = false)]
        public string QuitType { get; set; }

        /// <summary>
        /// 芝麻Go开始到到期过程中享受的优惠总金额
        /// </summary>
        /// <value>芝麻Go开始到到期过程中享受的优惠总金额</value>
        [DataMember(Name = "total_discount_amount", EmitDefaultValue = false)]
        public string TotalDiscountAmount { get; set; }

        /// <summary>
        /// 芝麻Go开始到到期过程中任务相关支付的总金额。
        /// </summary>
        /// <value>芝麻Go开始到到期过程中任务相关支付的总金额。</value>
        [DataMember(Name = "total_real_pay_amount", EmitDefaultValue = false)]
        public string TotalRealPayAmount { get; set; }

        /// <summary>
        /// 芝麻Go开始到到期过程中和任务相关的完成次数
        /// </summary>
        /// <value>芝麻Go开始到到期过程中和任务相关的完成次数</value>
        [DataMember(Name = "total_task_count", EmitDefaultValue = false)]
        public string TotalTaskCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UnfreezeExtendParams {\n");
            sb.Append("  QuitType: ").Append(QuitType).Append("\n");
            sb.Append("  TotalDiscountAmount: ").Append(TotalDiscountAmount).Append("\n");
            sb.Append("  TotalRealPayAmount: ").Append(TotalRealPayAmount).Append("\n");
            sb.Append("  TotalTaskCount: ").Append(TotalTaskCount).Append("\n");
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
            return this.Equals(input as UnfreezeExtendParams);
        }

        /// <summary>
        /// Returns true if UnfreezeExtendParams instances are equal
        /// </summary>
        /// <param name="input">Instance of UnfreezeExtendParams to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UnfreezeExtendParams input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.QuitType == input.QuitType ||
                    (this.QuitType != null &&
                    this.QuitType.Equals(input.QuitType))
                ) && 
                (
                    this.TotalDiscountAmount == input.TotalDiscountAmount ||
                    (this.TotalDiscountAmount != null &&
                    this.TotalDiscountAmount.Equals(input.TotalDiscountAmount))
                ) && 
                (
                    this.TotalRealPayAmount == input.TotalRealPayAmount ||
                    (this.TotalRealPayAmount != null &&
                    this.TotalRealPayAmount.Equals(input.TotalRealPayAmount))
                ) && 
                (
                    this.TotalTaskCount == input.TotalTaskCount ||
                    (this.TotalTaskCount != null &&
                    this.TotalTaskCount.Equals(input.TotalTaskCount))
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
                if (this.QuitType != null)
                {
                    hashCode = (hashCode * 59) + this.QuitType.GetHashCode();
                }
                if (this.TotalDiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalDiscountAmount.GetHashCode();
                }
                if (this.TotalRealPayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalRealPayAmount.GetHashCode();
                }
                if (this.TotalTaskCount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalTaskCount.GetHashCode();
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
