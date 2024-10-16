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
    /// AlipayFundAccountbookNotifyQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAccountbookNotifyQueryResponseModel")]
    public partial class AlipayFundAccountbookNotifyQueryResponseModel : IEquatable<AlipayFundAccountbookNotifyQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAccountbookNotifyQueryResponseModel" /> class.
        /// </summary>
        /// <param name="accountBookId">记账本ID.</param>
        /// <param name="code">响应code。 成功为10000； 业务异常为40004；.</param>
        /// <param name="msg">响应描述。 成功为Success； 业务异常为Business Failed；.</param>
        /// <param name="subscribeStatus">订阅关系状态， VALID：有效的； INVALID：失效的；.</param>
        public AlipayFundAccountbookNotifyQueryResponseModel(string accountBookId = default(string), string code = default(string), string msg = default(string), string subscribeStatus = default(string))
        {
            this.AccountBookId = accountBookId;
            this.Code = code;
            this.Msg = msg;
            this.SubscribeStatus = subscribeStatus;
        }

        /// <summary>
        /// 记账本ID
        /// </summary>
        /// <value>记账本ID</value>
        [DataMember(Name = "account_book_id", EmitDefaultValue = false)]
        public string AccountBookId { get; set; }

        /// <summary>
        /// 响应code。 成功为10000； 业务异常为40004；
        /// </summary>
        /// <value>响应code。 成功为10000； 业务异常为40004；</value>
        [DataMember(Name = "code", EmitDefaultValue = false)]
        public string Code { get; set; }

        /// <summary>
        /// 响应描述。 成功为Success； 业务异常为Business Failed；
        /// </summary>
        /// <value>响应描述。 成功为Success； 业务异常为Business Failed；</value>
        [DataMember(Name = "msg", EmitDefaultValue = false)]
        public string Msg { get; set; }

        /// <summary>
        /// 订阅关系状态， VALID：有效的； INVALID：失效的；
        /// </summary>
        /// <value>订阅关系状态， VALID：有效的； INVALID：失效的；</value>
        [DataMember(Name = "subscribe_status", EmitDefaultValue = false)]
        public string SubscribeStatus { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAccountbookNotifyQueryResponseModel {\n");
            sb.Append("  AccountBookId: ").Append(AccountBookId).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Msg: ").Append(Msg).Append("\n");
            sb.Append("  SubscribeStatus: ").Append(SubscribeStatus).Append("\n");
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
            return this.Equals(input as AlipayFundAccountbookNotifyQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAccountbookNotifyQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAccountbookNotifyQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAccountbookNotifyQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccountBookId == input.AccountBookId ||
                    (this.AccountBookId != null &&
                    this.AccountBookId.Equals(input.AccountBookId))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Msg == input.Msg ||
                    (this.Msg != null &&
                    this.Msg.Equals(input.Msg))
                ) && 
                (
                    this.SubscribeStatus == input.SubscribeStatus ||
                    (this.SubscribeStatus != null &&
                    this.SubscribeStatus.Equals(input.SubscribeStatus))
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
                if (this.AccountBookId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountBookId.GetHashCode();
                }
                if (this.Code != null)
                {
                    hashCode = (hashCode * 59) + this.Code.GetHashCode();
                }
                if (this.Msg != null)
                {
                    hashCode = (hashCode * 59) + this.Msg.GetHashCode();
                }
                if (this.SubscribeStatus != null)
                {
                    hashCode = (hashCode * 59) + this.SubscribeStatus.GetHashCode();
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
