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
    /// AlipayMarketingCardQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardQueryResponseModel")]
    public partial class AlipayMarketingCardQueryResponseModel : IEquatable<AlipayMarketingCardQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardQueryResponseModel" /> class.
        /// </summary>
        /// <param name="cardInfo">cardInfo.</param>
        /// <param name="paidOuterCardInfo">paidOuterCardInfo.</param>
        /// <param name="passId">商家会员卡页面跳转到支付宝卡券详情页的pass_id，对应schema地址中的参数p， 主要用于小程序跳往会员卡详情的链接拼接.</param>
        /// <param name="schemaUrl">商家会员卡页面跳转到支付宝卡券详情页面的schema地址.</param>
        public AlipayMarketingCardQueryResponseModel(MerchantCard cardInfo = default(MerchantCard), PaidOuterCardExtraInfoDTO paidOuterCardInfo = default(PaidOuterCardExtraInfoDTO), string passId = default(string), string schemaUrl = default(string))
        {
            this.CardInfo = cardInfo;
            this.PaidOuterCardInfo = paidOuterCardInfo;
            this.PassId = passId;
            this.SchemaUrl = schemaUrl;
        }

        /// <summary>
        /// Gets or Sets CardInfo
        /// </summary>
        [DataMember(Name = "card_info", EmitDefaultValue = false)]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// Gets or Sets PaidOuterCardInfo
        /// </summary>
        [DataMember(Name = "paid_outer_card_info", EmitDefaultValue = false)]
        public PaidOuterCardExtraInfoDTO PaidOuterCardInfo { get; set; }

        /// <summary>
        /// 商家会员卡页面跳转到支付宝卡券详情页的pass_id，对应schema地址中的参数p， 主要用于小程序跳往会员卡详情的链接拼接
        /// </summary>
        /// <value>商家会员卡页面跳转到支付宝卡券详情页的pass_id，对应schema地址中的参数p， 主要用于小程序跳往会员卡详情的链接拼接</value>
        [DataMember(Name = "pass_id", EmitDefaultValue = false)]
        public string PassId { get; set; }

        /// <summary>
        /// 商家会员卡页面跳转到支付宝卡券详情页面的schema地址
        /// </summary>
        /// <value>商家会员卡页面跳转到支付宝卡券详情页面的schema地址</value>
        [DataMember(Name = "schema_url", EmitDefaultValue = false)]
        public string SchemaUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardQueryResponseModel {\n");
            sb.Append("  CardInfo: ").Append(CardInfo).Append("\n");
            sb.Append("  PaidOuterCardInfo: ").Append(PaidOuterCardInfo).Append("\n");
            sb.Append("  PassId: ").Append(PassId).Append("\n");
            sb.Append("  SchemaUrl: ").Append(SchemaUrl).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CardInfo == input.CardInfo ||
                    (this.CardInfo != null &&
                    this.CardInfo.Equals(input.CardInfo))
                ) && 
                (
                    this.PaidOuterCardInfo == input.PaidOuterCardInfo ||
                    (this.PaidOuterCardInfo != null &&
                    this.PaidOuterCardInfo.Equals(input.PaidOuterCardInfo))
                ) && 
                (
                    this.PassId == input.PassId ||
                    (this.PassId != null &&
                    this.PassId.Equals(input.PassId))
                ) && 
                (
                    this.SchemaUrl == input.SchemaUrl ||
                    (this.SchemaUrl != null &&
                    this.SchemaUrl.Equals(input.SchemaUrl))
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
                if (this.CardInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CardInfo.GetHashCode();
                }
                if (this.PaidOuterCardInfo != null)
                {
                    hashCode = (hashCode * 59) + this.PaidOuterCardInfo.GetHashCode();
                }
                if (this.PassId != null)
                {
                    hashCode = (hashCode * 59) + this.PassId.GetHashCode();
                }
                if (this.SchemaUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SchemaUrl.GetHashCode();
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
