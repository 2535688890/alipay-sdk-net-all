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
    /// AlipayMobilePublicShortlinkCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMobilePublicShortlinkCreateResponseModel")]
    public partial class AlipayMobilePublicShortlinkCreateResponseModel : IEquatable<AlipayMobilePublicShortlinkCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMobilePublicShortlinkCreateResponseModel" /> class.
        /// </summary>
        /// <param name="code">结果码.</param>
        /// <param name="msg">成功.</param>
        /// <param name="shortlink">短链接url.</param>
        public AlipayMobilePublicShortlinkCreateResponseModel(string code = default(string), string msg = default(string), string shortlink = default(string))
        {
            this.Code = code;
            this.Msg = msg;
            this.Shortlink = shortlink;
        }

        /// <summary>
        /// 结果码
        /// </summary>
        /// <value>结果码</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 成功
        /// </summary>
        /// <value>成功</value>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// 短链接url
        /// </summary>
        /// <value>短链接url</value>
        [DataMember(Name = "shortlink", EmitDefaultValue = false)]
        public string Shortlink { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMobilePublicShortlinkCreateResponseModel {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  Shortlink: ").Append(Shortlink).Append("\n");
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
            return this.Equals(input as AlipayMobilePublicShortlinkCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMobilePublicShortlinkCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMobilePublicShortlinkCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMobilePublicShortlinkCreateResponseModel input)
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
                    this.Shortlink == input.Shortlink ||
                    (this.Shortlink != null &&
                    this.Shortlink.Equals(input.Shortlink))
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
                if (this.Shortlink != null)
                {
                    hashCode = (hashCode * 59) + this.Shortlink.GetHashCode();
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
