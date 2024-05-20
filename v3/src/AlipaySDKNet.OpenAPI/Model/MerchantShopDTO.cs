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
    /// MerchantShopDTO
    /// </summary>
    [DataContract(Name = "MerchantShopDTO")]
    public partial class MerchantShopDTO : IEquatable<MerchantShopDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MerchantShopDTO" /> class.
        /// </summary>
        /// <param name="shopName">门店名称，最长不超过256个字符。.</param>
        /// <param name="shopNo">门店编号。.</param>
        public MerchantShopDTO(string shopName = default(string), string shopNo = default(string))
        {
            this.ShopName = shopName;
            this.ShopNo = shopNo;
        }

        /// <summary>
        /// 门店名称，最长不超过256个字符。
        /// </summary>
        /// <value>门店名称，最长不超过256个字符。</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// 门店编号。
        /// </summary>
        /// <value>门店编号。</value>
        [DataMember(Name = "shop_no", EmitDefaultValue = false)]
        public string ShopNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class MerchantShopDTO {\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
            sb.Append("  ShopNo: ").Append(ShopNo).Append("\n");
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
            return this.Equals(input as MerchantShopDTO);
        }

        /// <summary>
        /// Returns true if MerchantShopDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of MerchantShopDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MerchantShopDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
                ) && 
                (
                    this.ShopNo == input.ShopNo ||
                    (this.ShopNo != null &&
                    this.ShopNo.Equals(input.ShopNo))
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
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
                }
                if (this.ShopNo != null)
                {
                    hashCode = (hashCode * 59) + this.ShopNo.GetHashCode();
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
