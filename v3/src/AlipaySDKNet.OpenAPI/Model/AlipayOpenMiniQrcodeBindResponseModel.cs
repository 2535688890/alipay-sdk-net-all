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
    /// AlipayOpenMiniQrcodeBindResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniQrcodeBindResponseModel")]
    public partial class AlipayOpenMiniQrcodeBindResponseModel : IEquatable<AlipayOpenMiniQrcodeBindResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniQrcodeBindResponseModel" /> class.
        /// </summary>
        /// <param name="routeGroup">路由规则组，用于唯一标记一条路由规则.</param>
        public AlipayOpenMiniQrcodeBindResponseModel(string routeGroup = default(string))
        {
            this.RouteGroup = routeGroup;
        }

        /// <summary>
        /// 路由规则组，用于唯一标记一条路由规则
        /// </summary>
        /// <value>路由规则组，用于唯一标记一条路由规则</value>
        [DataMember(Name = "route_group", EmitDefaultValue = false)]
        public string RouteGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniQrcodeBindResponseModel {\n");
            sb.Append("  RouteGroup: ").Append(RouteGroup).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniQrcodeBindResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniQrcodeBindResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniQrcodeBindResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniQrcodeBindResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RouteGroup == input.RouteGroup ||
                    (this.RouteGroup != null &&
                    this.RouteGroup.Equals(input.RouteGroup))
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
                if (this.RouteGroup != null)
                {
                    hashCode = (hashCode * 59) + this.RouteGroup.GetHashCode();
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
