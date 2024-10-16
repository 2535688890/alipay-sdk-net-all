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
    /// AntMerchantExpandItemQueryResponseModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandItemQueryResponseModel")]
    public partial class AntMerchantExpandItemQueryResponseModel : IEquatable<AntMerchantExpandItemQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandItemQueryResponseModel" /> class.
        /// </summary>
        /// <param name="itemList">商品列表.</param>
        public AntMerchantExpandItemQueryResponseModel(List<ItemModel> itemList = default(List<ItemModel>))
        {
            this.ItemList = itemList;
        }

        /// <summary>
        /// 商品列表
        /// </summary>
        /// <value>商品列表</value>
        [DataMember(Name = "item_list", EmitDefaultValue = false)]
        public List<ItemModel> ItemList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandItemQueryResponseModel {\n");
            sb.Append("  ItemList: ").Append(ItemList).Append("\n");
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
            return this.Equals(input as AntMerchantExpandItemQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandItemQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandItemQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandItemQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ItemList == input.ItemList ||
                    this.ItemList != null &&
                    input.ItemList != null &&
                    this.ItemList.SequenceEqual(input.ItemList)
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
                if (this.ItemList != null)
                {
                    hashCode = (hashCode * 59) + this.ItemList.GetHashCode();
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
