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
    /// EcOrderItem
    /// </summary>
    [DataContract(Name = "EcOrderItem")]
    public partial class EcOrderItem : IEquatable<EcOrderItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcOrderItem" /> class.
        /// </summary>
        /// <param name="accountId">共同账户ID.</param>
        /// <param name="bizOutNo">外部业务号.</param>
        /// <param name="employeeId">员工ID.</param>
        /// <param name="enterpriseId">企业ID.</param>
        /// <param name="gmtCreate">创建时间.</param>
        /// <param name="gmtModified">修改时间.</param>
        /// <param name="openId">用户支付宝UID.</param>
        /// <param name="orderContent">订单内容，JSON格式。.</param>
        /// <param name="orderId">订单ID.</param>
        /// <param name="orderType">订单类型 METRO：地铁 TAKEAWAY：外卖 OTHER：其他.</param>
        /// <param name="partnerId">合作伙伴ID.</param>
        /// <param name="payNo">关联支付宝交易号.</param>
        /// <param name="userId">用户支付宝UID.</param>
        public EcOrderItem(string accountId = default(string), string bizOutNo = default(string), string employeeId = default(string), string enterpriseId = default(string), string gmtCreate = default(string), string gmtModified = default(string), string openId = default(string), string orderContent = default(string), string orderId = default(string), string orderType = default(string), string partnerId = default(string), string payNo = default(string), string userId = default(string))
        {
            this.AccountId = accountId;
            this.BizOutNo = bizOutNo;
            this.EmployeeId = employeeId;
            this.EnterpriseId = enterpriseId;
            this.GmtCreate = gmtCreate;
            this.GmtModified = gmtModified;
            this.OpenId = openId;
            this.OrderContent = orderContent;
            this.OrderId = orderId;
            this.OrderType = orderType;
            this.PartnerId = partnerId;
            this.PayNo = payNo;
            this.UserId = userId;
        }

        /// <summary>
        /// 共同账户ID
        /// </summary>
        /// <value>共同账户ID</value>
        [DataMember(Name = "account_id", EmitDefaultValue = false)]
        public string AccountId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        /// <value>外部业务号</value>
        [DataMember(Name = "biz_out_no", EmitDefaultValue = false)]
        public string BizOutNo { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        /// <value>员工ID</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 企业ID
        /// </summary>
        /// <value>企业ID</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name = "gmt_modified", EmitDefaultValue = false)]
        public string GmtModified { get; set; }

        /// <summary>
        /// 用户支付宝UID
        /// </summary>
        /// <value>用户支付宝UID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 订单内容，JSON格式。
        /// </summary>
        /// <value>订单内容，JSON格式。</value>
        [DataMember(Name = "order_content", EmitDefaultValue = false)]
        public string OrderContent { get; set; }

        /// <summary>
        /// 订单ID
        /// </summary>
        /// <value>订单ID</value>
        [DataMember(Name = "order_id", EmitDefaultValue = false)]
        public string OrderId { get; set; }

        /// <summary>
        /// 订单类型 METRO：地铁 TAKEAWAY：外卖 OTHER：其他
        /// </summary>
        /// <value>订单类型 METRO：地铁 TAKEAWAY：外卖 OTHER：其他</value>
        [DataMember(Name = "order_type", EmitDefaultValue = false)]
        public string OrderType { get; set; }

        /// <summary>
        /// 合作伙伴ID
        /// </summary>
        /// <value>合作伙伴ID</value>
        [DataMember(Name = "partner_id", EmitDefaultValue = false)]
        public string PartnerId { get; set; }

        /// <summary>
        /// 关联支付宝交易号
        /// </summary>
        /// <value>关联支付宝交易号</value>
        [DataMember(Name = "pay_no", EmitDefaultValue = false)]
        public string PayNo { get; set; }

        /// <summary>
        /// 用户支付宝UID
        /// </summary>
        /// <value>用户支付宝UID</value>
        [DataMember(Name = "user_id", EmitDefaultValue = false)]
        public string UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcOrderItem {\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  BizOutNo: ").Append(BizOutNo).Append("\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtModified: ").Append(GmtModified).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OrderContent: ").Append(OrderContent).Append("\n");
            sb.Append("  OrderId: ").Append(OrderId).Append("\n");
            sb.Append("  OrderType: ").Append(OrderType).Append("\n");
            sb.Append("  PartnerId: ").Append(PartnerId).Append("\n");
            sb.Append("  PayNo: ").Append(PayNo).Append("\n");
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
            return this.Equals(input as EcOrderItem);
        }

        /// <summary>
        /// Returns true if EcOrderItem instances are equal
        /// </summary>
        /// <param name="input">Instance of EcOrderItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcOrderItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
                ) && 
                (
                    this.BizOutNo == input.BizOutNo ||
                    (this.BizOutNo != null &&
                    this.BizOutNo.Equals(input.BizOutNo))
                ) && 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtModified == input.GmtModified ||
                    (this.GmtModified != null &&
                    this.GmtModified.Equals(input.GmtModified))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
                ) && 
                (
                    this.OrderContent == input.OrderContent ||
                    (this.OrderContent != null &&
                    this.OrderContent.Equals(input.OrderContent))
                ) && 
                (
                    this.OrderId == input.OrderId ||
                    (this.OrderId != null &&
                    this.OrderId.Equals(input.OrderId))
                ) && 
                (
                    this.OrderType == input.OrderType ||
                    (this.OrderType != null &&
                    this.OrderType.Equals(input.OrderType))
                ) && 
                (
                    this.PartnerId == input.PartnerId ||
                    (this.PartnerId != null &&
                    this.PartnerId.Equals(input.PartnerId))
                ) && 
                (
                    this.PayNo == input.PayNo ||
                    (this.PayNo != null &&
                    this.PayNo.Equals(input.PayNo))
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
                if (this.AccountId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountId.GetHashCode();
                }
                if (this.BizOutNo != null)
                {
                    hashCode = (hashCode * 59) + this.BizOutNo.GetHashCode();
                }
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtModified != null)
                {
                    hashCode = (hashCode * 59) + this.GmtModified.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OrderContent != null)
                {
                    hashCode = (hashCode * 59) + this.OrderContent.GetHashCode();
                }
                if (this.OrderId != null)
                {
                    hashCode = (hashCode * 59) + this.OrderId.GetHashCode();
                }
                if (this.OrderType != null)
                {
                    hashCode = (hashCode * 59) + this.OrderType.GetHashCode();
                }
                if (this.PartnerId != null)
                {
                    hashCode = (hashCode * 59) + this.PartnerId.GetHashCode();
                }
                if (this.PayNo != null)
                {
                    hashCode = (hashCode * 59) + this.PayNo.GetHashCode();
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
