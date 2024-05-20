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
    /// AlipayOpenPublicAdvertCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicAdvertCreateResponseModel")]
    public partial class AlipayOpenPublicAdvertCreateResponseModel : IEquatable<AlipayOpenPublicAdvertCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicAdvertCreateResponseModel" /> class.
        /// </summary>
        /// <param name="advertGroup">广告分组标识.</param>
        /// <param name="advertId">广告位id.</param>
        public AlipayOpenPublicAdvertCreateResponseModel(string advertGroup = default(string), string advertId = default(string))
        {
            this.AdvertGroup = advertGroup;
            this.AdvertId = advertId;
        }

        /// <summary>
        /// 广告分组标识
        /// </summary>
        /// <value>广告分组标识</value>
        [DataMember(Name = "advert_group", EmitDefaultValue = false)]
        public string AdvertGroup { get; set; }

        /// <summary>
        /// 广告位id
        /// </summary>
        /// <value>广告位id</value>
        [DataMember(Name = "advert_id", EmitDefaultValue = false)]
        public string AdvertId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicAdvertCreateResponseModel {\n");
            sb.Append("  AdvertGroup: ").Append(AdvertGroup).Append("\n");
            sb.Append("  AdvertId: ").Append(AdvertId).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicAdvertCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicAdvertCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicAdvertCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicAdvertCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AdvertGroup == input.AdvertGroup ||
                    (this.AdvertGroup != null &&
                    this.AdvertGroup.Equals(input.AdvertGroup))
                ) && 
                (
                    this.AdvertId == input.AdvertId ||
                    (this.AdvertId != null &&
                    this.AdvertId.Equals(input.AdvertId))
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
                if (this.AdvertGroup != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertGroup.GetHashCode();
                }
                if (this.AdvertId != null)
                {
                    hashCode = (hashCode * 59) + this.AdvertId.GetHashCode();
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
