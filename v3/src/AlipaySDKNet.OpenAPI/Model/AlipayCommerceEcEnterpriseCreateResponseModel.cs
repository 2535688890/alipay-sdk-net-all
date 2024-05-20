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
    /// AlipayCommerceEcEnterpriseCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEcEnterpriseCreateResponseModel")]
    public partial class AlipayCommerceEcEnterpriseCreateResponseModel : IEquatable<AlipayCommerceEcEnterpriseCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEcEnterpriseCreateResponseModel" /> class.
        /// </summary>
        /// <param name="enterpriseId">企业id.</param>
        /// <param name="iotGroupId">封闭场景（如班车）的人脸库id，如果入参create_iot_group传false，则不会创建企业人脸库，该字段为空。.</param>
        /// <param name="iotLogicGroupId">开放场景（如团餐）的人脸库id，如果入参create_iot_group传false，则不会创建企业人脸库，该字段为空。.</param>
        /// <param name="signUrl">资金代付签约链接.</param>
        public AlipayCommerceEcEnterpriseCreateResponseModel(string enterpriseId = default(string), string iotGroupId = default(string), string iotLogicGroupId = default(string), string signUrl = default(string))
        {
            this.EnterpriseId = enterpriseId;
            this.IotGroupId = iotGroupId;
            this.IotLogicGroupId = iotLogicGroupId;
            this.SignUrl = signUrl;
        }

        /// <summary>
        /// 企业id
        /// </summary>
        /// <value>企业id</value>
        [DataMember(Name = "enterprise_id", EmitDefaultValue = false)]
        public string EnterpriseId { get; set; }

        /// <summary>
        /// 封闭场景（如班车）的人脸库id，如果入参create_iot_group传false，则不会创建企业人脸库，该字段为空。
        /// </summary>
        /// <value>封闭场景（如班车）的人脸库id，如果入参create_iot_group传false，则不会创建企业人脸库，该字段为空。</value>
        [DataMember(Name = "iot_group_id", EmitDefaultValue = false)]
        public string IotGroupId { get; set; }

        /// <summary>
        /// 开放场景（如团餐）的人脸库id，如果入参create_iot_group传false，则不会创建企业人脸库，该字段为空。
        /// </summary>
        /// <value>开放场景（如团餐）的人脸库id，如果入参create_iot_group传false，则不会创建企业人脸库，该字段为空。</value>
        [DataMember(Name = "iot_logic_group_id", EmitDefaultValue = false)]
        public string IotLogicGroupId { get; set; }

        /// <summary>
        /// 资金代付签约链接
        /// </summary>
        /// <value>资金代付签约链接</value>
        [DataMember(Name = "sign_url", EmitDefaultValue = false)]
        public string SignUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEcEnterpriseCreateResponseModel {\n");
            sb.Append("  EnterpriseId: ").Append(EnterpriseId).Append("\n");
            sb.Append("  IotGroupId: ").Append(IotGroupId).Append("\n");
            sb.Append("  IotLogicGroupId: ").Append(IotLogicGroupId).Append("\n");
            sb.Append("  SignUrl: ").Append(SignUrl).Append("\n");
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
            return this.Equals(input as AlipayCommerceEcEnterpriseCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEcEnterpriseCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEcEnterpriseCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEcEnterpriseCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EnterpriseId == input.EnterpriseId ||
                    (this.EnterpriseId != null &&
                    this.EnterpriseId.Equals(input.EnterpriseId))
                ) && 
                (
                    this.IotGroupId == input.IotGroupId ||
                    (this.IotGroupId != null &&
                    this.IotGroupId.Equals(input.IotGroupId))
                ) && 
                (
                    this.IotLogicGroupId == input.IotLogicGroupId ||
                    (this.IotLogicGroupId != null &&
                    this.IotLogicGroupId.Equals(input.IotLogicGroupId))
                ) && 
                (
                    this.SignUrl == input.SignUrl ||
                    (this.SignUrl != null &&
                    this.SignUrl.Equals(input.SignUrl))
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
                if (this.EnterpriseId != null)
                {
                    hashCode = (hashCode * 59) + this.EnterpriseId.GetHashCode();
                }
                if (this.IotGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.IotGroupId.GetHashCode();
                }
                if (this.IotLogicGroupId != null)
                {
                    hashCode = (hashCode * 59) + this.IotLogicGroupId.GetHashCode();
                }
                if (this.SignUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SignUrl.GetHashCode();
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
