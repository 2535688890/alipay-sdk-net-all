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
    /// ZMGOObligationConfig
    /// </summary>
    [DataContract(Name = "ZMGOObligationConfig")]
    public partial class ZMGOObligationConfig : IEquatable<ZMGOObligationConfig>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ZMGOObligationConfig" /> class.
        /// </summary>
        /// <param name="benefitUrl">芝麻GO管理页做任务按钮对应链接.</param>
        /// <param name="obligationAmount">完成任务所需的最少额度，当obligation_template取值为：OBTL002时必传.</param>
        /// <param name="obligationTemplate">承诺模式下，义务的类型，包含次数类型和金额类型：     OBTL001(\&quot;OBTL001\&quot;, \&quot;在x时间内完成n次\&quot;),     OBTL002(\&quot;OBTL002\&quot;, \&quot;在x时间内达到n元金额\&quot;).</param>
        /// <param name="obligationTimes">完成任务所需的最少次数，当obligation_template取值为：OBTL001时必填.</param>
        /// <param name="promiseTypeDesc">任务描述.</param>
        /// <param name="taskProgressRedirectSchema">芝麻GO管理页任务进度重定向链接.</param>
        public ZMGOObligationConfig(string benefitUrl = default(string), string obligationAmount = default(string), string obligationTemplate = default(string), string obligationTimes = default(string), string promiseTypeDesc = default(string), string taskProgressRedirectSchema = default(string))
        {
            this.BenefitUrl = benefitUrl;
            this.ObligationAmount = obligationAmount;
            this.ObligationTemplate = obligationTemplate;
            this.ObligationTimes = obligationTimes;
            this.PromiseTypeDesc = promiseTypeDesc;
            this.TaskProgressRedirectSchema = taskProgressRedirectSchema;
        }

        /// <summary>
        /// 芝麻GO管理页做任务按钮对应链接
        /// </summary>
        /// <value>芝麻GO管理页做任务按钮对应链接</value>
        [DataMember(Name = "benefit_url", EmitDefaultValue = false)]
        public string BenefitUrl { get; set; }

        /// <summary>
        /// 完成任务所需的最少额度，当obligation_template取值为：OBTL002时必传
        /// </summary>
        /// <value>完成任务所需的最少额度，当obligation_template取值为：OBTL002时必传</value>
        [DataMember(Name = "obligation_amount", EmitDefaultValue = false)]
        public string ObligationAmount { get; set; }

        /// <summary>
        /// 承诺模式下，义务的类型，包含次数类型和金额类型：     OBTL001(\&quot;OBTL001\&quot;, \&quot;在x时间内完成n次\&quot;),     OBTL002(\&quot;OBTL002\&quot;, \&quot;在x时间内达到n元金额\&quot;)
        /// </summary>
        /// <value>承诺模式下，义务的类型，包含次数类型和金额类型：     OBTL001(\&quot;OBTL001\&quot;, \&quot;在x时间内完成n次\&quot;),     OBTL002(\&quot;OBTL002\&quot;, \&quot;在x时间内达到n元金额\&quot;)</value>
        [DataMember(Name = "obligation_template", EmitDefaultValue = false)]
        public string ObligationTemplate { get; set; }

        /// <summary>
        /// 完成任务所需的最少次数，当obligation_template取值为：OBTL001时必填
        /// </summary>
        /// <value>完成任务所需的最少次数，当obligation_template取值为：OBTL001时必填</value>
        [DataMember(Name = "obligation_times", EmitDefaultValue = false)]
        public string ObligationTimes { get; set; }

        /// <summary>
        /// 任务描述
        /// </summary>
        /// <value>任务描述</value>
        [DataMember(Name = "promise_type_desc", EmitDefaultValue = false)]
        public string PromiseTypeDesc { get; set; }

        /// <summary>
        /// 芝麻GO管理页任务进度重定向链接
        /// </summary>
        /// <value>芝麻GO管理页任务进度重定向链接</value>
        [DataMember(Name = "task_progress_redirect_schema", EmitDefaultValue = false)]
        public string TaskProgressRedirectSchema { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ZMGOObligationConfig {\n");
            sb.Append("  BenefitUrl: ").Append(BenefitUrl).Append("\n");
            sb.Append("  ObligationAmount: ").Append(ObligationAmount).Append("\n");
            sb.Append("  ObligationTemplate: ").Append(ObligationTemplate).Append("\n");
            sb.Append("  ObligationTimes: ").Append(ObligationTimes).Append("\n");
            sb.Append("  PromiseTypeDesc: ").Append(PromiseTypeDesc).Append("\n");
            sb.Append("  TaskProgressRedirectSchema: ").Append(TaskProgressRedirectSchema).Append("\n");
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
            return this.Equals(input as ZMGOObligationConfig);
        }

        /// <summary>
        /// Returns true if ZMGOObligationConfig instances are equal
        /// </summary>
        /// <param name="input">Instance of ZMGOObligationConfig to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ZMGOObligationConfig input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BenefitUrl == input.BenefitUrl ||
                    (this.BenefitUrl != null &&
                    this.BenefitUrl.Equals(input.BenefitUrl))
                ) && 
                (
                    this.ObligationAmount == input.ObligationAmount ||
                    (this.ObligationAmount != null &&
                    this.ObligationAmount.Equals(input.ObligationAmount))
                ) && 
                (
                    this.ObligationTemplate == input.ObligationTemplate ||
                    (this.ObligationTemplate != null &&
                    this.ObligationTemplate.Equals(input.ObligationTemplate))
                ) && 
                (
                    this.ObligationTimes == input.ObligationTimes ||
                    (this.ObligationTimes != null &&
                    this.ObligationTimes.Equals(input.ObligationTimes))
                ) && 
                (
                    this.PromiseTypeDesc == input.PromiseTypeDesc ||
                    (this.PromiseTypeDesc != null &&
                    this.PromiseTypeDesc.Equals(input.PromiseTypeDesc))
                ) && 
                (
                    this.TaskProgressRedirectSchema == input.TaskProgressRedirectSchema ||
                    (this.TaskProgressRedirectSchema != null &&
                    this.TaskProgressRedirectSchema.Equals(input.TaskProgressRedirectSchema))
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
                if (this.BenefitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BenefitUrl.GetHashCode();
                }
                if (this.ObligationAmount != null)
                {
                    hashCode = (hashCode * 59) + this.ObligationAmount.GetHashCode();
                }
                if (this.ObligationTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.ObligationTemplate.GetHashCode();
                }
                if (this.ObligationTimes != null)
                {
                    hashCode = (hashCode * 59) + this.ObligationTimes.GetHashCode();
                }
                if (this.PromiseTypeDesc != null)
                {
                    hashCode = (hashCode * 59) + this.PromiseTypeDesc.GetHashCode();
                }
                if (this.TaskProgressRedirectSchema != null)
                {
                    hashCode = (hashCode * 59) + this.TaskProgressRedirectSchema.GetHashCode();
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
