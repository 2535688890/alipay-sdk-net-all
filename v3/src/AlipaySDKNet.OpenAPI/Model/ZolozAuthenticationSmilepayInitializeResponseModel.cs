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
    /// ZolozAuthenticationSmilepayInitializeResponseModel
    /// </summary>
    [DataContract(Name = "ZolozAuthenticationSmilepayInitializeResponseModel")]
    public partial class ZolozAuthenticationSmilepayInitializeResponseModel : IEquatable<ZolozAuthenticationSmilepayInitializeResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZolozAuthenticationSmilepayInitializeResponseModel" /> class.
        /// </summary>
        /// <param name="retCodeSub">返回详细码.</param>
        /// <param name="retMessageSub">返回详细信息.</param>
        /// <param name="zimId">ZIM上下文ID.</param>
        /// <param name="zimInitClientData">客户端协议.</param>
        public ZolozAuthenticationSmilepayInitializeResponseModel(string retCodeSub = default(string), string retMessageSub = default(string), string zimId = default(string), string zimInitClientData = default(string))
        {
            this.RetCodeSub = retCodeSub;
            this.RetMessageSub = retMessageSub;
            this.ZimId = zimId;
            this.ZimInitClientData = zimInitClientData;
        }

        /// <summary>
        /// 返回详细码
        /// </summary>
        /// <value>返回详细码</value>
        [DataMember(Name = "ret_code_sub", EmitDefaultValue = false)]
        public string RetCodeSub { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        /// <value>返回详细信息</value>
        [DataMember(Name = "ret_message_sub", EmitDefaultValue = false)]
        public string RetMessageSub { get; set; }

        /// <summary>
        /// ZIM上下文ID
        /// </summary>
        /// <value>ZIM上下文ID</value>
        [DataMember(Name = "zim_id", EmitDefaultValue = false)]
        public string ZimId { get; set; }

        /// <summary>
        /// 客户端协议
        /// </summary>
        /// <value>客户端协议</value>
        [DataMember(Name = "zim_init_client_data", EmitDefaultValue = false)]
        public string ZimInitClientData { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZolozAuthenticationSmilepayInitializeResponseModel {\n");
            sb.Append("  RetCodeSub: ").Append(RetCodeSub).Append("\n");
            sb.Append("  RetMessageSub: ").Append(RetMessageSub).Append("\n");
            sb.Append("  ZimId: ").Append(ZimId).Append("\n");
            sb.Append("  ZimInitClientData: ").Append(ZimInitClientData).Append("\n");
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
            return this.Equals(input as ZolozAuthenticationSmilepayInitializeResponseModel);
        }

        /// <summary>
        /// Returns true if ZolozAuthenticationSmilepayInitializeResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZolozAuthenticationSmilepayInitializeResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZolozAuthenticationSmilepayInitializeResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RetCodeSub == input.RetCodeSub ||
                    (this.RetCodeSub != null &&
                    this.RetCodeSub.Equals(input.RetCodeSub))
                ) && 
                (
                    this.RetMessageSub == input.RetMessageSub ||
                    (this.RetMessageSub != null &&
                    this.RetMessageSub.Equals(input.RetMessageSub))
                ) && 
                (
                    this.ZimId == input.ZimId ||
                    (this.ZimId != null &&
                    this.ZimId.Equals(input.ZimId))
                ) && 
                (
                    this.ZimInitClientData == input.ZimInitClientData ||
                    (this.ZimInitClientData != null &&
                    this.ZimInitClientData.Equals(input.ZimInitClientData))
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
                if (this.RetCodeSub != null)
                {
                    hashCode = (hashCode * 59) + this.RetCodeSub.GetHashCode();
                }
                if (this.RetMessageSub != null)
                {
                    hashCode = (hashCode * 59) + this.RetMessageSub.GetHashCode();
                }
                if (this.ZimId != null)
                {
                    hashCode = (hashCode * 59) + this.ZimId.GetHashCode();
                }
                if (this.ZimInitClientData != null)
                {
                    hashCode = (hashCode * 59) + this.ZimInitClientData.GetHashCode();
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
