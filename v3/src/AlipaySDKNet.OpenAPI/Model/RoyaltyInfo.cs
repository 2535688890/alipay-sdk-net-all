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
    /// RoyaltyInfo
    /// </summary>
    [DataContract(Name = "RoyaltyInfo")]
    public partial class RoyaltyInfo : IEquatable<RoyaltyInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoyaltyInfo" /> class.
        /// </summary>
        /// <param name="royaltyDetailInfos">分账明细的信息，可以描述多条分账指令，json数组。.</param>
        /// <param name="royaltyType">分账类型  卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）。.</param>
        public RoyaltyInfo(List<RoyaltyDetailInfos> royaltyDetailInfos = default(List<RoyaltyDetailInfos>), string royaltyType = default(string))
        {
            this.RoyaltyDetailInfos = royaltyDetailInfos;
            this.RoyaltyType = royaltyType;
        }

        /// <summary>
        /// 分账明细的信息，可以描述多条分账指令，json数组。
        /// </summary>
        /// <value>分账明细的信息，可以描述多条分账指令，json数组。</value>
        [DataMember(Name = "royalty_detail_infos", EmitDefaultValue = false)]
        public List<RoyaltyDetailInfos> RoyaltyDetailInfos { get; set; }

        /// <summary>
        /// 分账类型  卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）。
        /// </summary>
        /// <value>分账类型  卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）。</value>
        [DataMember(Name = "royalty_type", EmitDefaultValue = false)]
        public string RoyaltyType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoyaltyInfo {\n");
            sb.Append("  RoyaltyDetailInfos: ").Append(RoyaltyDetailInfos).Append("\n");
            sb.Append("  RoyaltyType: ").Append(RoyaltyType).Append("\n");
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
            return this.Equals(input as RoyaltyInfo);
        }

        /// <summary>
        /// Returns true if RoyaltyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of RoyaltyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoyaltyInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RoyaltyDetailInfos == input.RoyaltyDetailInfos ||
                    this.RoyaltyDetailInfos != null &&
                    input.RoyaltyDetailInfos != null &&
                    this.RoyaltyDetailInfos.SequenceEqual(input.RoyaltyDetailInfos)
                ) && 
                (
                    this.RoyaltyType == input.RoyaltyType ||
                    (this.RoyaltyType != null &&
                    this.RoyaltyType.Equals(input.RoyaltyType))
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
                if (this.RoyaltyDetailInfos != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyDetailInfos.GetHashCode();
                }
                if (this.RoyaltyType != null)
                {
                    hashCode = (hashCode * 59) + this.RoyaltyType.GetHashCode();
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
