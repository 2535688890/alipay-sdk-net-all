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
    /// AlipayOpenPublicTopicBatchqueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenPublicTopicBatchqueryResponseModel")]
    public partial class AlipayOpenPublicTopicBatchqueryResponseModel : IEquatable<AlipayOpenPublicTopicBatchqueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenPublicTopicBatchqueryResponseModel" /> class.
        /// </summary>
        /// <param name="topicList">营销位列表.</param>
        public AlipayOpenPublicTopicBatchqueryResponseModel(List<Topic> topicList = default(List<Topic>))
        {
            this.TopicList = topicList;
        }

        /// <summary>
        /// 营销位列表
        /// </summary>
        /// <value>营销位列表</value>
        [DataMember(Name = "topic_list", EmitDefaultValue = false)]
        public List<Topic> TopicList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenPublicTopicBatchqueryResponseModel {\n");
            sb.Append("  TopicList: ").Append(TopicList).Append("\n");
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
            return this.Equals(input as AlipayOpenPublicTopicBatchqueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenPublicTopicBatchqueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenPublicTopicBatchqueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenPublicTopicBatchqueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TopicList == input.TopicList ||
                    this.TopicList != null &&
                    input.TopicList != null &&
                    this.TopicList.SequenceEqual(input.TopicList)
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
                if (this.TopicList != null)
                {
                    hashCode = (hashCode * 59) + this.TopicList.GetHashCode();
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
