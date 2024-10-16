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
    /// AlipayOpenSearchBoxactivityApplyResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenSearchBoxactivityApplyResponseModel")]
    public partial class AlipayOpenSearchBoxactivityApplyResponseModel : IEquatable<AlipayOpenSearchBoxactivityApplyResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenSearchBoxactivityApplyResponseModel" /> class.
        /// </summary>
        /// <param name="boxActivityId">搜索直达活动ID.</param>
        public AlipayOpenSearchBoxactivityApplyResponseModel(string boxActivityId = default(string))
        {
            this.BoxActivityId = boxActivityId;
        }

        /// <summary>
        /// 搜索直达活动ID
        /// </summary>
        /// <value>搜索直达活动ID</value>
        [DataMember(Name = "box_activity_id", EmitDefaultValue = false)]
        public string BoxActivityId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenSearchBoxactivityApplyResponseModel {\n");
            sb.Append("  BoxActivityId: ").Append(BoxActivityId).Append("\n");
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
            return this.Equals(input as AlipayOpenSearchBoxactivityApplyResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenSearchBoxactivityApplyResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenSearchBoxactivityApplyResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenSearchBoxactivityApplyResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BoxActivityId == input.BoxActivityId ||
                    (this.BoxActivityId != null &&
                    this.BoxActivityId.Equals(input.BoxActivityId))
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
                if (this.BoxActivityId != null)
                {
                    hashCode = (hashCode * 59) + this.BoxActivityId.GetHashCode();
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
