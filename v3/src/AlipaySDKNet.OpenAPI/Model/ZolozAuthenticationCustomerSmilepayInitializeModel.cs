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
    /// ZolozAuthenticationCustomerSmilepayInitializeModel
    /// </summary>
    [DataContract(Name = "ZolozAuthenticationCustomerSmilepayInitializeModel")]
    public partial class ZolozAuthenticationCustomerSmilepayInitializeModel : IEquatable<ZolozAuthenticationCustomerSmilepayInitializeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZolozAuthenticationCustomerSmilepayInitializeModel" /> class.
        /// </summary>
        /// <param name="serviceId">刷脸服务Id.</param>
        /// <param name="serviceParams">商户可传入刷脸服务所需的扩展参数，json格式.</param>
        /// <param name="zimmetainfo">{ \&quot;apdidToken\&quot;: \&quot;设备指纹\&quot;, \&quot;appName\&quot;: \&quot;应用名称\&quot;, \&quot;appVersion\&quot;: \&quot;应用版本\&quot;, \&quot;bioMetaInfo\&quot;: \&quot;生物信息如2.3.0:3,-4\&quot; }.</param>
        public ZolozAuthenticationCustomerSmilepayInitializeModel(string serviceId = default(string), string serviceParams = default(string), string zimmetainfo = default(string))
        {
            this.ServiceId = serviceId;
            this.ServiceParams = serviceParams;
            this.Zimmetainfo = zimmetainfo;
        }

        /// <summary>
        /// 刷脸服务Id
        /// </summary>
        /// <value>刷脸服务Id</value>
        [DataMember(Name = "service_id", EmitDefaultValue = false)]
        public string ServiceId { get; set; }

        /// <summary>
        /// 商户可传入刷脸服务所需的扩展参数，json格式
        /// </summary>
        /// <value>商户可传入刷脸服务所需的扩展参数，json格式</value>
        [DataMember(Name = "service_params", EmitDefaultValue = false)]
        public string ServiceParams { get; set; }

        /// <summary>
        /// { \&quot;apdidToken\&quot;: \&quot;设备指纹\&quot;, \&quot;appName\&quot;: \&quot;应用名称\&quot;, \&quot;appVersion\&quot;: \&quot;应用版本\&quot;, \&quot;bioMetaInfo\&quot;: \&quot;生物信息如2.3.0:3,-4\&quot; }
        /// </summary>
        /// <value>{ \&quot;apdidToken\&quot;: \&quot;设备指纹\&quot;, \&quot;appName\&quot;: \&quot;应用名称\&quot;, \&quot;appVersion\&quot;: \&quot;应用版本\&quot;, \&quot;bioMetaInfo\&quot;: \&quot;生物信息如2.3.0:3,-4\&quot; }</value>
        [DataMember(Name = "zimmetainfo", EmitDefaultValue = false)]
        public string Zimmetainfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZolozAuthenticationCustomerSmilepayInitializeModel {\n");
            sb.Append("  ServiceId: ").Append(ServiceId).Append("\n");
            sb.Append("  ServiceParams: ").Append(ServiceParams).Append("\n");
            sb.Append("  Zimmetainfo: ").Append(Zimmetainfo).Append("\n");
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
            return this.Equals(input as ZolozAuthenticationCustomerSmilepayInitializeModel);
        }

        /// <summary>
        /// Returns true if ZolozAuthenticationCustomerSmilepayInitializeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of ZolozAuthenticationCustomerSmilepayInitializeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZolozAuthenticationCustomerSmilepayInitializeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ServiceId == input.ServiceId ||
                    (this.ServiceId != null &&
                    this.ServiceId.Equals(input.ServiceId))
                ) && 
                (
                    this.ServiceParams == input.ServiceParams ||
                    (this.ServiceParams != null &&
                    this.ServiceParams.Equals(input.ServiceParams))
                ) && 
                (
                    this.Zimmetainfo == input.Zimmetainfo ||
                    (this.Zimmetainfo != null &&
                    this.Zimmetainfo.Equals(input.Zimmetainfo))
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
                if (this.ServiceId != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceId.GetHashCode();
                }
                if (this.ServiceParams != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceParams.GetHashCode();
                }
                if (this.Zimmetainfo != null)
                {
                    hashCode = (hashCode * 59) + this.Zimmetainfo.GetHashCode();
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
