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
    /// VoucherAvailableOutItemInfo
    /// </summary>
    [DataContract(Name = "VoucherAvailableOutItemInfo")]
    public partial class VoucherAvailableOutItemInfo : IEquatable<VoucherAvailableOutItemInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherAvailableOutItemInfo" /> class.
        /// </summary>
        /// <param name="itemAppId">小程序ID.</param>
        /// <param name="outItemId">外部商品ID.</param>
        public VoucherAvailableOutItemInfo(string itemAppId = default(string), string outItemId = default(string))
        {
            this.ItemAppId = itemAppId;
            this.OutItemId = outItemId;
        }

        /// <summary>
        /// 小程序ID
        /// </summary>
        /// <value>小程序ID</value>
        [DataMember(Name = "item_app_id", EmitDefaultValue = false)]
        public string ItemAppId { get; set; }

        /// <summary>
        /// 外部商品ID
        /// </summary>
        /// <value>外部商品ID</value>
        [DataMember(Name = "out_item_id", EmitDefaultValue = false)]
        public string OutItemId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherAvailableOutItemInfo {\n");
            sb.Append("  ItemAppId: ").Append(ItemAppId).Append("\n");
            sb.Append("  OutItemId: ").Append(OutItemId).Append("\n");
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
            return this.Equals(input as VoucherAvailableOutItemInfo);
        }

        /// <summary>
        /// Returns true if VoucherAvailableOutItemInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherAvailableOutItemInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherAvailableOutItemInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemAppId == input.ItemAppId ||
                    (this.ItemAppId != null &&
                    this.ItemAppId.Equals(input.ItemAppId))
                ) && 
                (
                    this.OutItemId == input.OutItemId ||
                    (this.OutItemId != null &&
                    this.OutItemId.Equals(input.OutItemId))
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
                if (this.ItemAppId != null)
                {
                    hashCode = (hashCode * 59) + this.ItemAppId.GetHashCode();
                }
                if (this.OutItemId != null)
                {
                    hashCode = (hashCode * 59) + this.OutItemId.GetHashCode();
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
