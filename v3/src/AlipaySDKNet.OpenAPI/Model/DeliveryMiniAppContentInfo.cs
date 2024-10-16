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
    /// DeliveryMiniAppContentInfo
    /// </summary>
    [DataContract(Name = "DeliveryMiniAppContentInfo")]
    public partial class DeliveryMiniAppContentInfo : IEquatable<DeliveryMiniAppContentInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeliveryMiniAppContentInfo" /> class.
        /// </summary>
        /// <param name="miniAppDeliveryType">仅小程序推广可用。.</param>
        /// <param name="miniAppId">小程序ID.</param>
        /// <param name="serviceCodeList">小程序服务编码/home_page，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。 限制: 1.只有mini_app_id有值时该值传入才会有效 2.当前只支持一个服务code 3.service_codes必须是已传入的mini_app_id下的小程序.</param>
        public DeliveryMiniAppContentInfo(string miniAppDeliveryType = default(string), string miniAppId = default(string), List<string> serviceCodeList = default(List<string>))
        {
            this.MiniAppDeliveryType = miniAppDeliveryType;
            this.MiniAppId = miniAppId;
            this.ServiceCodeList = serviceCodeList;
        }

        /// <summary>
        /// 仅小程序推广可用。
        /// </summary>
        /// <value>仅小程序推广可用。</value>
        [DataMember(Name = "mini_app_delivery_type", EmitDefaultValue = false)]
        public string MiniAppDeliveryType { get; set; }

        /// <summary>
        /// 小程序ID
        /// </summary>
        /// <value>小程序ID</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 小程序服务编码/home_page，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。 限制: 1.只有mini_app_id有值时该值传入才会有效 2.当前只支持一个服务code 3.service_codes必须是已传入的mini_app_id下的小程序
        /// </summary>
        /// <value>小程序服务编码/home_page，通过 alipay.open.app.appcontent.function.create(小程序服务创建)接口创建服务后获取。 限制: 1.只有mini_app_id有值时该值传入才会有效 2.当前只支持一个服务code 3.service_codes必须是已传入的mini_app_id下的小程序</value>
        [DataMember(Name = "service_code_list", EmitDefaultValue = false)]
        public List<string> ServiceCodeList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DeliveryMiniAppContentInfo {\n");
            sb.Append("  MiniAppDeliveryType: ").Append(MiniAppDeliveryType).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  ServiceCodeList: ").Append(ServiceCodeList).Append("\n");
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
            return this.Equals(input as DeliveryMiniAppContentInfo);
        }

        /// <summary>
        /// Returns true if DeliveryMiniAppContentInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of DeliveryMiniAppContentInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeliveryMiniAppContentInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MiniAppDeliveryType == input.MiniAppDeliveryType ||
                    (this.MiniAppDeliveryType != null &&
                    this.MiniAppDeliveryType.Equals(input.MiniAppDeliveryType))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.ServiceCodeList == input.ServiceCodeList ||
                    this.ServiceCodeList != null &&
                    input.ServiceCodeList != null &&
                    this.ServiceCodeList.SequenceEqual(input.ServiceCodeList)
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
                if (this.MiniAppDeliveryType != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppDeliveryType.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.ServiceCodeList != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCodeList.GetHashCode();
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
