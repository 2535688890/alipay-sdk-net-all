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
    /// AlipayOpenMiniMiniappServiceconfigModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniMiniappServiceconfigModifyModel")]
    public partial class AlipayOpenMiniMiniappServiceconfigModifyModel : IEquatable<AlipayOpenMiniMiniappServiceconfigModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniMiniappServiceconfigModifyModel" /> class.
        /// </summary>
        /// <param name="homeOpen">云客服是否在小程序首页透出，true-开启，false-不开启.</param>
        /// <param name="serviceConfig">客服方式，目前支持ANTCLOUD-云客服.</param>
        public AlipayOpenMiniMiniappServiceconfigModifyModel(bool homeOpen = default(bool), string serviceConfig = default(string))
        {
            this.HomeOpen = homeOpen;
            this.ServiceConfig = serviceConfig;
        }

        /// <summary>
        /// 云客服是否在小程序首页透出，true-开启，false-不开启
        /// </summary>
        /// <value>云客服是否在小程序首页透出，true-开启，false-不开启</value>
        [DataMember(Name = "home_open", EmitDefaultValue = true)]
        public bool HomeOpen { get; set; }

        /// <summary>
        /// 客服方式，目前支持ANTCLOUD-云客服
        /// </summary>
        /// <value>客服方式，目前支持ANTCLOUD-云客服</value>
        [DataMember(Name = "service_config", EmitDefaultValue = false)]
        public string ServiceConfig { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniMiniappServiceconfigModifyModel {\n");
            sb.Append("  HomeOpen: ").Append(HomeOpen).Append("\n");
            sb.Append("  ServiceConfig: ").Append(ServiceConfig).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniMiniappServiceconfigModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniMiniappServiceconfigModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniMiniappServiceconfigModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniMiniappServiceconfigModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.HomeOpen == input.HomeOpen ||
                    this.HomeOpen.Equals(input.HomeOpen)
                ) && 
                (
                    this.ServiceConfig == input.ServiceConfig ||
                    (this.ServiceConfig != null &&
                    this.ServiceConfig.Equals(input.ServiceConfig))
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
                hashCode = (hashCode * 59) + this.HomeOpen.GetHashCode();
                if (this.ServiceConfig != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceConfig.GetHashCode();
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
