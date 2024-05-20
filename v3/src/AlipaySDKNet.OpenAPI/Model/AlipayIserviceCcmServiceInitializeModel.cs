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
    /// AlipayIserviceCcmServiceInitializeModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmServiceInitializeModel")]
    public partial class AlipayIserviceCcmServiceInitializeModel : IEquatable<AlipayIserviceCcmServiceInitializeModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmServiceInitializeModel" /> class.
        /// </summary>
        /// <param name="description">服务描述.</param>
        /// <param name="icon">服务图标url。支持 http(s) 链接。.</param>
        /// <param name="serviceCode">服务编码。可在服务上架后，在服务市场上查询此信息。.</param>
        /// <param name="serviceName">服务名称。可在服务上架后，在服务市场上查询此信息。.</param>
        /// <param name="serviceOrderUrl">服务订购二维码链接.</param>
        /// <param name="spis">spi定义列表.</param>
        public AlipayIserviceCcmServiceInitializeModel(string description = default(string), string icon = default(string), string serviceCode = default(string), string serviceName = default(string), string serviceOrderUrl = default(string), List<IsvSpiDefinition> spis = default(List<IsvSpiDefinition>))
        {
            this.Description = description;
            this.Icon = icon;
            this.ServiceCode = serviceCode;
            this.ServiceName = serviceName;
            this.ServiceOrderUrl = serviceOrderUrl;
            this.Spis = spis;
        }

        /// <summary>
        /// 服务描述
        /// </summary>
        /// <value>服务描述</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// 服务图标url。支持 http(s) 链接。
        /// </summary>
        /// <value>服务图标url。支持 http(s) 链接。</value>
        [DataMember(Name = "icon", EmitDefaultValue = false)]
        public string Icon { get; set; }

        /// <summary>
        /// 服务编码。可在服务上架后，在服务市场上查询此信息。
        /// </summary>
        /// <value>服务编码。可在服务上架后，在服务市场上查询此信息。</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称。可在服务上架后，在服务市场上查询此信息。
        /// </summary>
        /// <value>服务名称。可在服务上架后，在服务市场上查询此信息。</value>
        [DataMember(Name = "service_name", EmitDefaultValue = false)]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务订购二维码链接
        /// </summary>
        /// <value>服务订购二维码链接</value>
        [DataMember(Name = "service_order_url", EmitDefaultValue = false)]
        public string ServiceOrderUrl { get; set; }

        /// <summary>
        /// spi定义列表
        /// </summary>
        /// <value>spi定义列表</value>
        [DataMember(Name = "spis", EmitDefaultValue = false)]
        public List<IsvSpiDefinition> Spis { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmServiceInitializeModel {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Icon: ").Append(Icon).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
            sb.Append("  ServiceName: ").Append(ServiceName).Append("\n");
            sb.Append("  ServiceOrderUrl: ").Append(ServiceOrderUrl).Append("\n");
            sb.Append("  Spis: ").Append(Spis).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmServiceInitializeModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmServiceInitializeModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmServiceInitializeModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmServiceInitializeModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Icon == input.Icon ||
                    (this.Icon != null &&
                    this.Icon.Equals(input.Icon))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
                ) && 
                (
                    this.ServiceName == input.ServiceName ||
                    (this.ServiceName != null &&
                    this.ServiceName.Equals(input.ServiceName))
                ) && 
                (
                    this.ServiceOrderUrl == input.ServiceOrderUrl ||
                    (this.ServiceOrderUrl != null &&
                    this.ServiceOrderUrl.Equals(input.ServiceOrderUrl))
                ) && 
                (
                    this.Spis == input.Spis ||
                    this.Spis != null &&
                    input.Spis != null &&
                    this.Spis.SequenceEqual(input.Spis)
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
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Icon != null)
                {
                    hashCode = (hashCode * 59) + this.Icon.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
                }
                if (this.ServiceName != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceName.GetHashCode();
                }
                if (this.ServiceOrderUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceOrderUrl.GetHashCode();
                }
                if (this.Spis != null)
                {
                    hashCode = (hashCode * 59) + this.Spis.GetHashCode();
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
