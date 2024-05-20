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
    /// FlowSigner
    /// </summary>
    [DataContract(Name = "FlowSigner")]
    public partial class FlowSigner : IEquatable<FlowSigner>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlowSigner" /> class.
        /// </summary>
        /// <param name="orgThirdPartyUserId">创建流程时指定的企业唯一标识，仅签署主体为企业时返回.</param>
        /// <param name="signStatus">签署状态：0-待签, 1-未签, 2-已签 3-待审批 4-拒签.</param>
        /// <param name="signerAccountType">签署主体类型：0-个人, 1-企业.</param>
        /// <param name="thirdPartyUserId">创建流程时指定个人唯一标识.</param>
        public FlowSigner(string orgThirdPartyUserId = default(string), int signStatus = default(int), int signerAccountType = default(int), string thirdPartyUserId = default(string))
        {
            this.OrgThirdPartyUserId = orgThirdPartyUserId;
            this.SignStatus = signStatus;
            this.SignerAccountType = signerAccountType;
            this.ThirdPartyUserId = thirdPartyUserId;
        }

        /// <summary>
        /// 创建流程时指定的企业唯一标识，仅签署主体为企业时返回
        /// </summary>
        /// <value>创建流程时指定的企业唯一标识，仅签署主体为企业时返回</value>
        [DataMember(Name = "org_third_party_user_id", EmitDefaultValue = false)]
        public string OrgThirdPartyUserId { get; set; }

        /// <summary>
        /// 签署状态：0-待签, 1-未签, 2-已签 3-待审批 4-拒签
        /// </summary>
        /// <value>签署状态：0-待签, 1-未签, 2-已签 3-待审批 4-拒签</value>
        [DataMember(Name = "sign_status", EmitDefaultValue = false)]
        public int SignStatus { get; set; }

        /// <summary>
        /// 签署主体类型：0-个人, 1-企业
        /// </summary>
        /// <value>签署主体类型：0-个人, 1-企业</value>
        [DataMember(Name = "signer_account_type", EmitDefaultValue = false)]
        public int SignerAccountType { get; set; }

        /// <summary>
        /// 创建流程时指定个人唯一标识
        /// </summary>
        /// <value>创建流程时指定个人唯一标识</value>
        [DataMember(Name = "third_party_user_id", EmitDefaultValue = false)]
        public string ThirdPartyUserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FlowSigner {\n");
            sb.Append("  OrgThirdPartyUserId: ").Append(OrgThirdPartyUserId).Append("\n");
            sb.Append("  SignStatus: ").Append(SignStatus).Append("\n");
            sb.Append("  SignerAccountType: ").Append(SignerAccountType).Append("\n");
            sb.Append("  ThirdPartyUserId: ").Append(ThirdPartyUserId).Append("\n");
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
            return this.Equals(input as FlowSigner);
        }

        /// <summary>
        /// Returns true if FlowSigner instances are equal
        /// </summary>
        /// <param name="input">Instance of FlowSigner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlowSigner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.OrgThirdPartyUserId == input.OrgThirdPartyUserId ||
                    (this.OrgThirdPartyUserId != null &&
                    this.OrgThirdPartyUserId.Equals(input.OrgThirdPartyUserId))
                ) && 
                (
                    this.SignStatus == input.SignStatus ||
                    this.SignStatus.Equals(input.SignStatus)
                ) && 
                (
                    this.SignerAccountType == input.SignerAccountType ||
                    this.SignerAccountType.Equals(input.SignerAccountType)
                ) && 
                (
                    this.ThirdPartyUserId == input.ThirdPartyUserId ||
                    (this.ThirdPartyUserId != null &&
                    this.ThirdPartyUserId.Equals(input.ThirdPartyUserId))
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
                if (this.OrgThirdPartyUserId != null)
                {
                    hashCode = (hashCode * 59) + this.OrgThirdPartyUserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SignStatus.GetHashCode();
                hashCode = (hashCode * 59) + this.SignerAccountType.GetHashCode();
                if (this.ThirdPartyUserId != null)
                {
                    hashCode = (hashCode * 59) + this.ThirdPartyUserId.GetHashCode();
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
