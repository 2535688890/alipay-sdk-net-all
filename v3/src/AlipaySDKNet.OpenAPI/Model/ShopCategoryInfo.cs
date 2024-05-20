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
    /// ShopCategoryInfo
    /// </summary>
    [DataContract(Name = "ShopCategoryInfo")]
    public partial class ShopCategoryInfo : IEquatable<ShopCategoryInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShopCategoryInfo" /> class.
        /// </summary>
        /// <param name="categoryId">类目编号.</param>
        /// <param name="categoryLevel">类目层级,目前最多支持1、2、3三级.</param>
        /// <param name="categoryName">类目名称.</param>
        public ShopCategoryInfo(string categoryId = default(string), string categoryLevel = default(string), string categoryName = default(string))
        {
            this.CategoryId = categoryId;
            this.CategoryLevel = categoryLevel;
            this.CategoryName = categoryName;
        }

        /// <summary>
        /// 类目编号
        /// </summary>
        /// <value>类目编号</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public string CategoryId { get; set; }

        /// <summary>
        /// 类目层级,目前最多支持1、2、3三级
        /// </summary>
        /// <value>类目层级,目前最多支持1、2、3三级</value>
        [DataMember(Name = "category_level", EmitDefaultValue = false)]
        public string CategoryLevel { get; set; }

        /// <summary>
        /// 类目名称
        /// </summary>
        /// <value>类目名称</value>
        [DataMember(Name = "category_name", EmitDefaultValue = false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShopCategoryInfo {\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryLevel: ").Append(CategoryLevel).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
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
            return this.Equals(input as ShopCategoryInfo);
        }

        /// <summary>
        /// Returns true if ShopCategoryInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ShopCategoryInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShopCategoryInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) && 
                (
                    this.CategoryLevel == input.CategoryLevel ||
                    (this.CategoryLevel != null &&
                    this.CategoryLevel.Equals(input.CategoryLevel))
                ) && 
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
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
                if (this.CategoryId != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                }
                if (this.CategoryLevel != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryLevel.GetHashCode();
                }
                if (this.CategoryName != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryName.GetHashCode();
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
