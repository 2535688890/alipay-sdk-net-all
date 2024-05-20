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
    /// AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel")]
    public partial class AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel : IEquatable<AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="code">返回码 10000-成功 其他都是失败.</param>
        /// <param name="msg">返回消息.</param>
        /// <param name="titleInfoList">企业抬头信息.</param>
        public AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel(string code = default(string), string msg = default(string), List<EnterpriseTitleInfo> titleInfoList = default(List<EnterpriseTitleInfo>))
        {
            this.Code = code;
            this.Msg = msg;
            this.TitleInfoList = titleInfoList;
        }

        /// <summary>
        /// 返回码 10000-成功 其他都是失败
        /// </summary>
        /// <value>返回码 10000-成功 其他都是失败</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 返回消息
        /// </summary>
        /// <value>返回消息</value>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// 企业抬头信息
        /// </summary>
        /// <value>企业抬头信息</value>
        [DataMember(Name = "title_info_list", EmitDefaultValue = false)]
        public List<EnterpriseTitleInfo> TitleInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  TitleInfoList: ").Append(TitleInfoList).Append("\n");
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
            return this.Equals(input as AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEbppInvoiceEnterpriseexctrlEmployertitleBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
                ) && 
                (
                    this.TitleInfoList == input.TitleInfoList ||
                    this.TitleInfoList != null &&
                    input.TitleInfoList != null &&
                    this.TitleInfoList.SequenceEqual(input.TitleInfoList)
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
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
                }
                if (this.TitleInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.TitleInfoList.GetHashCode();
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
