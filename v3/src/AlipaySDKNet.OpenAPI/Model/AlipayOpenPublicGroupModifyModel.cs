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
    /// AlipayOpenPublicGroupModifyModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicGroupModifyModel")]
    public partial class AlipayOpenPublicGroupModifyModel : IEquatable<AlipayOpenPublicGroupModifyModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicGroupModifyModel" /> class.
        /// </summary>
        /// <param name="groupId">分组ID，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create\&quot;&gt;alipay.open.public.group.create&lt;/a&gt;（用户分组创建接口) 创建用户分组获取。.</param>
        /// <param name="labelRule">标签规则，满足该规则的粉丝将被圈定，标签id不能重复.</param>
        /// <param name="name">分组名称，仅支持中文、字母、数字、下划线的组合。.</param>
        public AlipayOpenPublicGroupModifyModel(string groupId = default(string), List<ComplexLabelRule> labelRule = default(List<ComplexLabelRule>), string name = default(string))
        {
            this.GroupId = groupId;
            this.LabelRule = labelRule;
            this.Name = name;
        }

        /// <summary>
        /// 分组ID，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create\&quot;&gt;alipay.open.public.group.create&lt;/a&gt;（用户分组创建接口) 创建用户分组获取。
        /// </summary>
        /// <value>分组ID，通过&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_6/alipay.open.public.group.create\&quot;&gt;alipay.open.public.group.create&lt;/a&gt;（用户分组创建接口) 创建用户分组获取。</value>
        [DataMember(Name = "group_id", EmitDefaultValue = false)]
        public string GroupId { get; set; }

        /// <summary>
        /// 标签规则，满足该规则的粉丝将被圈定，标签id不能重复
        /// </summary>
        /// <value>标签规则，满足该规则的粉丝将被圈定，标签id不能重复</value>
        [DataMember(Name = "label_rule", EmitDefaultValue = false)]
        public List<ComplexLabelRule> LabelRule { get; set; }

        /// <summary>
        /// 分组名称，仅支持中文、字母、数字、下划线的组合。
        /// </summary>
        /// <value>分组名称，仅支持中文、字母、数字、下划线的组合。</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicGroupModifyModel {\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  LabelRule: ").Append(LabelRule).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicGroupModifyModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicGroupModifyModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicGroupModifyModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicGroupModifyModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.LabelRule == input.LabelRule ||
                    this.LabelRule != null &&
                    input.LabelRule != null &&
                    this.LabelRule.SequenceEqual(input.LabelRule)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.LabelRule != null)
                {
                    hashCode = (hashCode * 59) + this.LabelRule.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
