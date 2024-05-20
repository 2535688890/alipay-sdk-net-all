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
    /// AlipayEbppInvoiceApplystatusQueryModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceApplystatusQueryModel")]
    public partial class AlipayEbppInvoiceApplystatusQueryModel : IEquatable<AlipayEbppInvoiceApplystatusQueryModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceApplystatusQueryModel" /> class.
        /// </summary>
        /// <param name="mShortName">定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\&quot;商户品牌简称\&quot;。 如：肯德基：KFC.</param>
        /// <param name="orderNoList">待查询订单开票状态列表，各订单号间通过英文逗号分割，不限于支付宝体内交易订单号。如：20200520110046966071,20200520110046966072,20200520110046966073.</param>
        /// <param name="subMShortName">定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\&quot;商户门店简称\&quot;。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\&quot;商户品牌简称+商户门店简称\&quot;作为确定商户及其下属机构的唯一标识，不可重复。.</param>
        public AlipayEbppInvoiceApplystatusQueryModel(string mShortName = default(string), List<string> orderNoList = default(List<string>), string subMShortName = default(string))
        {
            this.MShortName = mShortName;
            this.OrderNoList = orderNoList;
            this.SubMShortName = subMShortName;
        }

        /// <summary>
        /// 定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\&quot;商户品牌简称\&quot;。 如：肯德基：KFC
        /// </summary>
        /// <value>定义商户的一级简称,用于标识商户品牌，对应于商户入驻时填写的\&quot;商户品牌简称\&quot;。 如：肯德基：KFC</value>
        [DataMember(Name = "m_short_name", EmitDefaultValue = false)]
        public string MShortName { get; set; }

        /// <summary>
        /// 待查询订单开票状态列表，各订单号间通过英文逗号分割，不限于支付宝体内交易订单号。如：20200520110046966071,20200520110046966072,20200520110046966073
        /// </summary>
        /// <value>待查询订单开票状态列表，各订单号间通过英文逗号分割，不限于支付宝体内交易订单号。如：20200520110046966071,20200520110046966072,20200520110046966073</value>
        [DataMember(Name = "order_no_list", EmitDefaultValue = false)]
        public List<string> OrderNoList { get; set; }

        /// <summary>
        /// 定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\&quot;商户门店简称\&quot;。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\&quot;商户品牌简称+商户门店简称\&quot;作为确定商户及其下属机构的唯一标识，不可重复。
        /// </summary>
        /// <value>定义商户的二级简称,用于标识商户品牌下的分支机构，如门店，对应于商户入驻时填写的\&quot;商户门店简称\&quot;。 如：肯德基-杭州西湖区文一西路店：KFC-HZ-19003 要求：\&quot;商户品牌简称+商户门店简称\&quot;作为确定商户及其下属机构的唯一标识，不可重复。</value>
        [DataMember(Name = "sub_m_short_name", EmitDefaultValue = false)]
        public string SubMShortName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceApplystatusQueryModel {\n");
            sb.Append("  MShortName: ").Append(MShortName).Append("\n");
            sb.Append("  OrderNoList: ").Append(OrderNoList).Append("\n");
            sb.Append("  SubMShortName: ").Append(SubMShortName).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceApplystatusQueryModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceApplystatusQueryModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceApplystatusQueryModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceApplystatusQueryModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MShortName == input.MShortName ||
                    (this.MShortName != null &&
                    this.MShortName.Equals(input.MShortName))
                ) && 
                (
                    this.OrderNoList == input.OrderNoList ||
                    this.OrderNoList != null &&
                    input.OrderNoList != null &&
                    this.OrderNoList.SequenceEqual(input.OrderNoList)
                ) && 
                (
                    this.SubMShortName == input.SubMShortName ||
                    (this.SubMShortName != null &&
                    this.SubMShortName.Equals(input.SubMShortName))
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
                if (this.MShortName != null)
                {
                    hashCode = (hashCode * 59) + this.MShortName.GetHashCode();
                }
                if (this.OrderNoList != null)
                {
                    hashCode = (hashCode * 59) + this.OrderNoList.GetHashCode();
                }
                if (this.SubMShortName != null)
                {
                    hashCode = (hashCode * 59) + this.SubMShortName.GetHashCode();
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
