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
    /// JointAccountBillDetail
    /// </summary>
    [DataContract(Name = "JointAccountBillDetail")]
    public partial class JointAccountBillDetail : IEquatable<JointAccountBillDetail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JointAccountBillDetail" /> class.
        /// </summary>
        /// <param name="amount">消费金额，单位：元.</param>
        /// <param name="billNo">账单业务号.</param>
        /// <param name="bizDate">业务时间.</param>
        /// <param name="bizNo">订单号.</param>
        /// <param name="bizOutNo">外部单号.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="inOut">1-退款，2-支付.</param>
        /// <param name="openId">用户支付宝uid.</param>
        /// <param name="title">账单标题.</param>
        /// <param name="userId">用户支付宝uid.</param>
        public JointAccountBillDetail(string amount = default(string), string billNo = default(string), string bizDate = default(string), string bizNo = default(string), string bizOutNo = default(string), string enterpriseId = default(string), string inOut = default(string), string openId = default(string), string title = default(string), string userId = default(string))
        {
            this.Amount = amount;
            this.BillNo = billNo;
            this.BizDate = bizDate;
            this.BizNo = bizNo;
            this.BizOutNo = bizOutNo;
            this.EnterpriseId = enterpriseId;
            this.InOut = inOut;
            this.OpenId = openId;
            this.Title = title;
            this.UserId = userId;
        }

        /// <summary>
        /// 消费金额，单位：元
        /// </summary>
        /// <value>消费金额，单位：元</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 账单业务号
        /// </summary>
        /// <value>账单业务号</value>
        [DataMember(Name = "bill_no", EmitDefaultValue = false)]
        public string BillNo { get; set; }

        /// <summary>
        /// 业务时间
        /// </summary>
        /// <value>业务时间</value>
        [DataMember(Name = "biz_date", EmitDefaultValue = false)]
        public string BizDate { get; set; }

        /// <summary>
        /// 订单号
        /// </summary>
        /// <value>订单号</value>
        [DataMember(Name = "biz_no", EmitDefaultValue = false)]
        public string BizNo { get; set; }

        /// <summary>
        /// 外部单号
        /// </summary>
        /// <value>外部单号</value>
        [DataMember(Name = "biz_out_no", EmitDefaultValue = false)]
        public string BizOutNo { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 1-退款，2-支付
        /// </summary>
        /// <value>1-退款，2-支付</value>
        [DataMember(Name = "in_out", EmitDefaultValue = false)]
        public string InOut { get; set; }

        /// <summary>
        /// 用户支付宝uid
        /// </summary>
        /// <value>用户支付宝uid</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 账单标题
        /// </summary>
        /// <value>账单标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 用户支付宝uid
        /// </summary>
        /// <value>用户支付宝uid</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JointAccountBillDetail {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  BillNo: ").Append(BillNo).Append("\n");
            sb.Append("  BizDate: ").Append(BizDate).Append("\n");
            sb.Append("  BizNo: ").Append(BizNo).Append("\n");
            sb.Append("  BizOutNo: ").Append(BizOutNo).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  InOut: ").Append(InOut).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as JointAccountBillDetail);
        }

        /// <summary>
        /// Returns true if JointAccountBillDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of JointAccountBillDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JointAccountBillDetail input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.BillNo == input.BillNo ||
                    (this.BillNo != null &&
                    this.BillNo.Equals(input.BillNo))
                ) && 
                (
                    this.BizDate == input.BizDate ||
                    (this.BizDate != null &&
                    this.BizDate.Equals(input.BizDate))
                ) && 
                (
                    this.BizNo == input.BizNo ||
                    (this.BizNo != null &&
                    this.BizNo.Equals(input.BizNo))
                ) && 
                (
                    this.BizOutNo == input.BizOutNo ||
                    (this.BizOutNo != null &&
                    this.BizOutNo.Equals(input.BizOutNo))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.InOut == input.InOut ||
                    (this.InOut != null &&
                    this.InOut.Equals(input.InOut))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.BillNo != null)
                {
                    hashCode = (hashCode * 59) + this.BillNo.GetHashCode();
                }
                if (this.BizDate != null)
                {
                    hashCode = (hashCode * 59) + this.BizDate.GetHashCode();
                }
                if (this.BizNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizNo.GetHashCode();
                }
                if (this.BizOutNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizOutNo.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.InOut != null)
                {
                    hashCode = (hashCode * 59) + this.InOut.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
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
