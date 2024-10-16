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
    /// AlipayOfflineMarketShopCategoryQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOfflineMarketShopCategoryQueryResponseModel")]
    public partial class AlipayOfflineMarketShopCategoryQueryResponseModel : IEquatable<AlipayOfflineMarketShopCategoryQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOfflineMarketShopCategoryQueryResponseModel" /> class.
        /// </summary>
        /// <param name="shopCategoryConfigInfos">门店类目配置信息，包括能够开店的叶子节点类目信息，以及类目约束配置信息。.</param>
        public AlipayOfflineMarketShopCategoryQueryResponseModel(List<ShopCategoryConfigInfo> shopCategoryConfigInfos = default(List<ShopCategoryConfigInfo>))
        {
            this.ShopCategoryConfigInfos = shopCategoryConfigInfos;
        }

        /// <summary>
        /// 门店类目配置信息，包括能够开店的叶子节点类目信息，以及类目约束配置信息。
        /// </summary>
        /// <value>门店类目配置信息，包括能够开店的叶子节点类目信息，以及类目约束配置信息。</value>
        [DataMember(Name = "shop_category_config_infos", EmitDefaultValue = false)]
        public List<ShopCategoryConfigInfo> ShopCategoryConfigInfos { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOfflineMarketShopCategoryQueryResponseModel {\n");
            sb.Append("  ShopCategoryConfigInfos: ").Append(ShopCategoryConfigInfos).Append("\n");
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
            return this.Equals(input as AlipayOfflineMarketShopCategoryQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOfflineMarketShopCategoryQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOfflineMarketShopCategoryQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOfflineMarketShopCategoryQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ShopCategoryConfigInfos == input.ShopCategoryConfigInfos ||
                    this.ShopCategoryConfigInfos != null &&
                    input.ShopCategoryConfigInfos != null &&
                    this.ShopCategoryConfigInfos.SequenceEqual(input.ShopCategoryConfigInfos)
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
                if (this.ShopCategoryConfigInfos != null)
                {
                    hashCode = (hashCode * 59) + this.ShopCategoryConfigInfos.GetHashCode();
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
