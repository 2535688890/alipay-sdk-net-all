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
    /// CommonVoucherDisplayLiteInfo
    /// </summary>
    [DataContract(Name = "CommonVoucherDisplayLiteInfo")]
    public partial class CommonVoucherDisplayLiteInfo : IEquatable<CommonVoucherDisplayLiteInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommonVoucherDisplayLiteInfo" /> class.
        /// </summary>
        /// <param name="brandLogo">商户品牌 logo 链接。.</param>
        /// <param name="brandName">商户品牌名称。 如果不设置品牌名称，则默认使用支付宝商家系统中维护的商家别名。 如果没有维护商家别名，则使用默认名称：商家优惠。  用户领取优惠券后，品牌名称会对用户进行展示。.</param>
        public CommonVoucherDisplayLiteInfo(string brandLogo = default(string), string brandName = default(string))
        {
            this.BrandLogo = brandLogo;
            this.BrandName = brandName;
        }

        /// <summary>
        /// 商户品牌 logo 链接。
        /// </summary>
        /// <value>商户品牌 logo 链接。</value>
        [DataMember(Name = "brand_logo", EmitDefaultValue = false)]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商户品牌名称。 如果不设置品牌名称，则默认使用支付宝商家系统中维护的商家别名。 如果没有维护商家别名，则使用默认名称：商家优惠。  用户领取优惠券后，品牌名称会对用户进行展示。
        /// </summary>
        /// <value>商户品牌名称。 如果不设置品牌名称，则默认使用支付宝商家系统中维护的商家别名。 如果没有维护商家别名，则使用默认名称：商家优惠。  用户领取优惠券后，品牌名称会对用户进行展示。</value>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CommonVoucherDisplayLiteInfo {\n");
            sb.Append("  BrandLogo: ").Append(BrandLogo).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
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
            return this.Equals(input as CommonVoucherDisplayLiteInfo);
        }

        /// <summary>
        /// Returns true if CommonVoucherDisplayLiteInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of CommonVoucherDisplayLiteInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommonVoucherDisplayLiteInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandLogo == input.BrandLogo ||
                    (this.BrandLogo != null &&
                    this.BrandLogo.Equals(input.BrandLogo))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
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
                if (this.BrandLogo != null)
                {
                    hashCode = (hashCode * 59) + this.BrandLogo.GetHashCode();
                }
                if (this.BrandName != null)
                {
                    hashCode = (hashCode * 59) + this.BrandName.GetHashCode();
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
