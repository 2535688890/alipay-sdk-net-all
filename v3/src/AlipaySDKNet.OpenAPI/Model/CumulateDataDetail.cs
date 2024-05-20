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
    /// CumulateDataDetail
    /// </summary>
    [DataContract(Name = "CumulateDataDetail")]
    public partial class CumulateDataDetail : IEquatable<CumulateDataDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CumulateDataDetail" /> class.
        /// </summary>
        /// <param name="actionType">数据回传的动作类型，正向或逆向。.</param>
        /// <param name="bizTime">回传数据发生的实际时间.</param>
        /// <param name="dataType">回传数据类型。.</param>
        /// <param name="discountAmount">优惠金额.</param>
        /// <param name="discountDesc">优惠描述.</param>
        /// <param name="outBizNo">数据回传时传入的外部业务号。.</param>
        /// <param name="referOutBizNo">数据回传时逆向单据记录的对应正向单据的外部业务号。.</param>
        /// <param name="subDataType">回传数据子类型。.</param>
        /// <param name="taskAmount">任务金额.</param>
        /// <param name="taskDesc">任务描述.</param>
        /// <param name="taskTimes">任务次数.</param>
        public CumulateDataDetail(string actionType = default(string), string bizTime = default(string), string dataType = default(string), string discountAmount = default(string), string discountDesc = default(string), string outBizNo = default(string), string referOutBizNo = default(string), string subDataType = default(string), string taskAmount = default(string), string taskDesc = default(string), int taskTimes = default(int))
        {
            this.ActionType = actionType;
            this.BizTime = bizTime;
            this.DataType = dataType;
            this.DiscountAmount = discountAmount;
            this.DiscountDesc = discountDesc;
            this.OutBizNo = outBizNo;
            this.ReferOutBizNo = referOutBizNo;
            this.SubDataType = subDataType;
            this.TaskAmount = taskAmount;
            this.TaskDesc = taskDesc;
            this.TaskTimes = taskTimes;
        }

        /// <summary>
        /// 数据回传的动作类型，正向或逆向。
        /// </summary>
        /// <value>数据回传的动作类型，正向或逆向。</value>
        [DataMember(Name = "action_type", EmitDefaultValue = false)]
        public string ActionType { get; set; }

        /// <summary>
        /// 回传数据发生的实际时间
        /// </summary>
        /// <value>回传数据发生的实际时间</value>
        [DataMember(Name = "biz_time", EmitDefaultValue = false)]
        public string BizTime { get; set; }

        /// <summary>
        /// 回传数据类型。
        /// </summary>
        /// <value>回传数据类型。</value>
        [DataMember(Name = "data_type", EmitDefaultValue = false)]
        public string DataType { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        /// <value>优惠金额</value>
        [DataMember(Name = "discount_amount", EmitDefaultValue = false)]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 优惠描述
        /// </summary>
        /// <value>优惠描述</value>
        [DataMember(Name = "discount_desc", EmitDefaultValue = false)]
        public string DiscountDesc { get; set; }

        /// <summary>
        /// 数据回传时传入的外部业务号。
        /// </summary>
        /// <value>数据回传时传入的外部业务号。</value>
        [DataMember(Name = "out_biz_no", EmitDefaultValue = false)]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 数据回传时逆向单据记录的对应正向单据的外部业务号。
        /// </summary>
        /// <value>数据回传时逆向单据记录的对应正向单据的外部业务号。</value>
        [DataMember(Name = "refer_out_biz_no", EmitDefaultValue = false)]
        public string ReferOutBizNo { get; set; }

        /// <summary>
        /// 回传数据子类型。
        /// </summary>
        /// <value>回传数据子类型。</value>
        [DataMember(Name = "sub_data_type", EmitDefaultValue = false)]
        public string SubDataType { get; set; }

        /// <summary>
        /// 任务金额
        /// </summary>
        /// <value>任务金额</value>
        [DataMember(Name = "task_amount", EmitDefaultValue = false)]
        public string TaskAmount { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        /// <value>任务描述</value>
        [DataMember(Name = "task_desc", EmitDefaultValue = false)]
        public string TaskDesc { get; set; }

        /// <summary>
        /// 任务次数
        /// </summary>
        /// <value>任务次数</value>
        [DataMember(Name = "task_times", EmitDefaultValue = false)]
        public int TaskTimes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CumulateDataDetail {\n");
            sb.Append("  ActionType: ").Append(ActionType).Append("\n");
            sb.Append("  BizTime: ").Append(BizTime).Append("\n");
            sb.Append("  DataType: ").Append(DataType).Append("\n");
            sb.Append("  DiscountAmount: ").Append(DiscountAmount).Append("\n");
            sb.Append("  DiscountDesc: ").Append(DiscountDesc).Append("\n");
            sb.Append("  OutBizNo: ").Append(OutBizNo).Append("\n");
            sb.Append("  ReferOutBizNo: ").Append(ReferOutBizNo).Append("\n");
            sb.Append("  SubDataType: ").Append(SubDataType).Append("\n");
            sb.Append("  TaskAmount: ").Append(TaskAmount).Append("\n");
            sb.Append("  TaskDesc: ").Append(TaskDesc).Append("\n");
            sb.Append("  TaskTimes: ").Append(TaskTimes).Append("\n");
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
            return this.Equals(input as CumulateDataDetail);
        }

        /// <summary>
        /// Returns true if CumulateDataDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of CumulateDataDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CumulateDataDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ActionType == input.ActionType ||
                    (this.ActionType != null &&
                    this.ActionType.Equals(input.ActionType))
                ) && 
                (
                    this.BizTime == input.BizTime ||
                    (this.BizTime != null &&
                    this.BizTime.Equals(input.BizTime))
                ) && 
                (
                    this.DataType == input.DataType ||
                    (this.DataType != null &&
                    this.DataType.Equals(input.DataType))
                ) && 
                (
                    this.DiscountAmount == input.DiscountAmount ||
                    (this.DiscountAmount != null &&
                    this.DiscountAmount.Equals(input.DiscountAmount))
                ) && 
                (
                    this.DiscountDesc == input.DiscountDesc ||
                    (this.DiscountDesc != null &&
                    this.DiscountDesc.Equals(input.DiscountDesc))
                ) && 
                (
                    this.OutBizNo == input.OutBizNo ||
                    (this.OutBizNo != null &&
                    this.OutBizNo.Equals(input.OutBizNo))
                ) && 
                (
                    this.ReferOutBizNo == input.ReferOutBizNo ||
                    (this.ReferOutBizNo != null &&
                    this.ReferOutBizNo.Equals(input.ReferOutBizNo))
                ) && 
                (
                    this.SubDataType == input.SubDataType ||
                    (this.SubDataType != null &&
                    this.SubDataType.Equals(input.SubDataType))
                ) && 
                (
                    this.TaskAmount == input.TaskAmount ||
                    (this.TaskAmount != null &&
                    this.TaskAmount.Equals(input.TaskAmount))
                ) && 
                (
                    this.TaskDesc == input.TaskDesc ||
                    (this.TaskDesc != null &&
                    this.TaskDesc.Equals(input.TaskDesc))
                ) && 
                (
                    this.TaskTimes == input.TaskTimes ||
                    this.TaskTimes.Equals(input.TaskTimes)
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
                if (this.ActionType != null)
                {
                    hashCode = (hashCode * 59) + this.ActionType.GetHashCode();
                }
                if (this.BizTime != null)
                {
                    hashCode = (hashCode * 59) + this.BizTime.GetHashCode();
                }
                if (this.DataType != null)
                {
                    hashCode = (hashCode * 59) + this.DataType.GetHashCode();
                }
                if (this.DiscountAmount != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountAmount.GetHashCode();
                }
                if (this.DiscountDesc != null)
                {
                    hashCode = (hashCode * 59) + this.DiscountDesc.GetHashCode();
                }
                if (this.OutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutBizNo.GetHashCode();
                }
                if (this.ReferOutBizNo != null)
                {
                    hashCode = (hashCode * 59) + this.ReferOutBizNo.GetHashCode();
                }
                if (this.SubDataType != null)
                {
                    hashCode = (hashCode * 59) + this.SubDataType.GetHashCode();
                }
                if (this.TaskAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TaskAmount.GetHashCode();
                }
                if (this.TaskDesc != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDesc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TaskTimes.GetHashCode();
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
