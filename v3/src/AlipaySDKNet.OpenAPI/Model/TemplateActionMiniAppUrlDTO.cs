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
    /// TemplateActionMiniAppUrlDTO
    /// </summary>
    [DataContract(Name = "TemplateActionMiniAppUrlDTO")]
    public partial class TemplateActionMiniAppUrlDTO : IEquatable<TemplateActionMiniAppUrlDTO>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateActionMiniAppUrlDTO" /> class.
        /// </summary>
        /// <param name="displayOnList">行动点按钮是否在列表页展示，true 或 false，不填则默认false；  列表页可以配置展示最多2项小程序跳转行动点。.</param>
        /// <param name="miniAppId">小程序appId.</param>
        /// <param name="miniPageParam">指定小程序页面，不填则默认跳转至对应小程序首页.</param>
        /// <param name="miniQueryParam">query参数，商户自定义传参，填入值将以\&quot;query\&quot;为参数名提交至指定小程序页面.</param>
        public TemplateActionMiniAppUrlDTO(string displayOnList = default(string), string miniAppId = default(string), string miniPageParam = default(string), string miniQueryParam = default(string))
        {
            this.DisplayOnList = displayOnList;
            this.MiniAppId = miniAppId;
            this.MiniPageParam = miniPageParam;
            this.MiniQueryParam = miniQueryParam;
        }

        /// <summary>
        /// 行动点按钮是否在列表页展示，true 或 false，不填则默认false；  列表页可以配置展示最多2项小程序跳转行动点。
        /// </summary>
        /// <value>行动点按钮是否在列表页展示，true 或 false，不填则默认false；  列表页可以配置展示最多2项小程序跳转行动点。</value>
        [DataMember(Name = "display_on_list", EmitDefaultValue = false)]
        public string DisplayOnList { get; set; }

        /// <summary>
        /// 小程序appId
        /// </summary>
        /// <value>小程序appId</value>
        [DataMember(Name = "mini_app_id", EmitDefaultValue = false)]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定小程序页面，不填则默认跳转至对应小程序首页
        /// </summary>
        /// <value>指定小程序页面，不填则默认跳转至对应小程序首页</value>
        [DataMember(Name = "mini_page_param", EmitDefaultValue = false)]
        public string MiniPageParam { get; set; }

        /// <summary>
        /// query参数，商户自定义传参，填入值将以\&quot;query\&quot;为参数名提交至指定小程序页面
        /// </summary>
        /// <value>query参数，商户自定义传参，填入值将以\&quot;query\&quot;为参数名提交至指定小程序页面</value>
        [DataMember(Name = "mini_query_param", EmitDefaultValue = false)]
        public string MiniQueryParam { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateActionMiniAppUrlDTO {\n");
            sb.Append("  DisplayOnList: ").Append(DisplayOnList).Append("\n");
            sb.Append("  MiniAppId: ").Append(MiniAppId).Append("\n");
            sb.Append("  MiniPageParam: ").Append(MiniPageParam).Append("\n");
            sb.Append("  MiniQueryParam: ").Append(MiniQueryParam).Append("\n");
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
            return this.Equals(input as TemplateActionMiniAppUrlDTO);
        }

        /// <summary>
        /// Returns true if TemplateActionMiniAppUrlDTO instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateActionMiniAppUrlDTO to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateActionMiniAppUrlDTO input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DisplayOnList == input.DisplayOnList ||
                    (this.DisplayOnList != null &&
                    this.DisplayOnList.Equals(input.DisplayOnList))
                ) && 
                (
                    this.MiniAppId == input.MiniAppId ||
                    (this.MiniAppId != null &&
                    this.MiniAppId.Equals(input.MiniAppId))
                ) && 
                (
                    this.MiniPageParam == input.MiniPageParam ||
                    (this.MiniPageParam != null &&
                    this.MiniPageParam.Equals(input.MiniPageParam))
                ) && 
                (
                    this.MiniQueryParam == input.MiniQueryParam ||
                    (this.MiniQueryParam != null &&
                    this.MiniQueryParam.Equals(input.MiniQueryParam))
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
                if (this.DisplayOnList != null)
                {
                    hashCode = (hashCode * 59) + this.DisplayOnList.GetHashCode();
                }
                if (this.MiniAppId != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppId.GetHashCode();
                }
                if (this.MiniPageParam != null)
                {
                    hashCode = (hashCode * 59) + this.MiniPageParam.GetHashCode();
                }
                if (this.MiniQueryParam != null)
                {
                    hashCode = (hashCode * 59) + this.MiniQueryParam.GetHashCode();
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
