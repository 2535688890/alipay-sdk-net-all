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
    /// Detail
    /// </summary>
    [DataContract(Name = "Detail")]
    public partial class Detail : IEquatable<Detail>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Detail" /> class.
        /// </summary>
        /// <param name="code">英文描述（collectAttachement值为true时必填） 以下是系统固定code,对上传的图片做相应的校验。 身份证校验情况： 身份证正面照片：ESIGN_IDCARD 身份证背面照片：ESIGN_BACK_IDCARD.</param>
        /// <param name="description">请上传手机正面照.</param>
        /// <param name="order">顺序（collectAttachement值为true时必填）.</param>
        public Detail(string code = default(string), string description = default(string), int order = default(int))
        {
            this.Code = code;
            this.Description = description;
            this.Order = order;
        }

        /// <summary>
        /// 英文描述（collectAttachement值为true时必填） 以下是系统固定code,对上传的图片做相应的校验。 身份证校验情况： 身份证正面照片：ESIGN_IDCARD 身份证背面照片：ESIGN_BACK_IDCARD
        /// </summary>
        /// <value>英文描述（collectAttachement值为true时必填） 以下是系统固定code,对上传的图片做相应的校验。 身份证校验情况： 身份证正面照片：ESIGN_IDCARD 身份证背面照片：ESIGN_BACK_IDCARD</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 请上传手机正面照
        /// </summary>
        /// <value>请上传手机正面照</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 顺序（collectAttachement值为true时必填）
        /// </summary>
        /// <value>顺序（collectAttachement值为true时必填）</value>
        [DataMember(Name = "order", EmitDefaultValue = false)]
        public int Order { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Detail {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Order: ").Append(Order).Append("\n");
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
            return this.Equals(input as Detail);
        }

        /// <summary>
        /// Returns true if Detail instances are equal
        /// </summary>
        /// <param name="input">Instance of Detail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Detail input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Order == input.Order ||
                    this.Order.Equals(input.Order)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Order.GetHashCode();
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
