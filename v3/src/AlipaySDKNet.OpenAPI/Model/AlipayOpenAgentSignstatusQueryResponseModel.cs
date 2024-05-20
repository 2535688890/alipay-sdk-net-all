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
    /// AlipayOpenAgentSignstatusQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenAgentSignstatusQueryResponseModel")]
    public partial class AlipayOpenAgentSignstatusQueryResponseModel : IEquatable<AlipayOpenAgentSignstatusQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentSignstatusQueryResponseModel" /> class.
        /// </summary>
        /// <param name="signStatusList">商户产品签约状态结果对象数组，返回本次查询的产品的签约状态.</param>
        public AlipayOpenAgentSignstatusQueryResponseModel(List<ProductSignStatusInfo> signStatusList = default(List<ProductSignStatusInfo>))
        {
            this.SignStatusList = signStatusList;
        }

        /// <summary>
        /// 商户产品签约状态结果对象数组，返回本次查询的产品的签约状态
        /// </summary>
        /// <value>商户产品签约状态结果对象数组，返回本次查询的产品的签约状态</value>
        [DataMember(Name = "sign_status_list", EmitDefaultValue = false)]
        public List<ProductSignStatusInfo> SignStatusList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAgentSignstatusQueryResponseModel {\n");
            sb.Append("  SignStatusList: ").Append(SignStatusList).Append("\n");
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
            return this.Equals(input as AlipayOpenAgentSignstatusQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentSignstatusQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentSignstatusQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentSignstatusQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SignStatusList == input.SignStatusList ||
                    this.SignStatusList != null &&
                    input.SignStatusList != null &&
                    this.SignStatusList.SequenceEqual(input.SignStatusList)
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
                if (this.SignStatusList != null)
                {
                    hashCode = (hashCode * 59) + this.SignStatusList.GetHashCode();
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
