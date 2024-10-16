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
    /// AlipayOpenInviteOrderQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenInviteOrderQueryResponseModel")]
    public partial class AlipayOpenInviteOrderQueryResponseModel : IEquatable<AlipayOpenInviteOrderQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenInviteOrderQueryResponseModel" /> class.
        /// </summary>
        /// <param name="merchantPid">商家支付宝账号对应的ID，2088开头.</param>
        /// <param name="signStatusList">产品签约状态对象.</param>
        public AlipayOpenInviteOrderQueryResponseModel(string merchantPid = default(string), List<ProductInviteStatusInfo> signStatusList = default(List<ProductInviteStatusInfo>))
        {
            this.MerchantPid = merchantPid;
            this.SignStatusList = signStatusList;
        }

        /// <summary>
        /// 商家支付宝账号对应的ID，2088开头
        /// </summary>
        /// <value>商家支付宝账号对应的ID，2088开头</value>
        [DataMember(Name = "merchant_pid", EmitDefaultValue = false)]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 产品签约状态对象
        /// </summary>
        /// <value>产品签约状态对象</value>
        [DataMember(Name = "sign_status_list", EmitDefaultValue = false)]
        public List<ProductInviteStatusInfo> SignStatusList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenInviteOrderQueryResponseModel {\n");
            sb.Append("  MerchantPid: ").Append(MerchantPid).Append("\n");
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
            return this.Equals(input as AlipayOpenInviteOrderQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenInviteOrderQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenInviteOrderQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenInviteOrderQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MerchantPid == input.MerchantPid ||
                    (this.MerchantPid != null &&
                    this.MerchantPid.Equals(input.MerchantPid))
                ) && 
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
                if (this.MerchantPid != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantPid.GetHashCode();
                }
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
