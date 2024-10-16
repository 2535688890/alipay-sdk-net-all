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
    /// AlipayMarketingCardOpenResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardOpenResponseModel")]
    public partial class AlipayMarketingCardOpenResponseModel : IEquatable<AlipayMarketingCardOpenResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardOpenResponseModel" /> class.
        /// </summary>
        /// <param name="cardInfo">cardInfo.</param>
        /// <param name="openCardChannel">实际记录的领卡渠道（可能跟商户传入值不同）；  可直接标识领卡渠道，也可配合open_card_channel_id标识领卡渠道类型：  例如：  线下门店领取:20161534000000000008863（直接标识领卡渠道，门店shopId）  线下扫二维码领取:QR（标识领卡类型）;  线下活动领取:20170522000000000003609（直接标识领卡渠道，商户活动ID）.</param>
        /// <param name="openCardChannelId">实际记录的领卡来源渠道id（可能跟商户传入值不同）；  区别于open_card_channel领卡渠道；  一般使用场景：  open_card_channel用于区分渠道类型，例如取值为\&quot;SHOP\&quot;（门店），\&quot;ACTIVITY\&quot;（活动）；  则open_card_channel_id可用于区分同渠道的不同实体，对应取各门店ID或各活动的标识ID等；.</param>
        public AlipayMarketingCardOpenResponseModel(MerchantCard cardInfo = default(MerchantCard), string openCardChannel = default(string), string openCardChannelId = default(string))
        {
            this.CardInfo = cardInfo;
            this.OpenCardChannel = openCardChannel;
            this.OpenCardChannelId = openCardChannelId;
        }

        /// <summary>
        /// Gets or Sets CardInfo
        /// </summary>
        [DataMember(Name = "card_info", EmitDefaultValue = false)]
        public MerchantCard CardInfo { get; set; }

        /// <summary>
        /// 实际记录的领卡渠道（可能跟商户传入值不同）；  可直接标识领卡渠道，也可配合open_card_channel_id标识领卡渠道类型：  例如：  线下门店领取:20161534000000000008863（直接标识领卡渠道，门店shopId）  线下扫二维码领取:QR（标识领卡类型）;  线下活动领取:20170522000000000003609（直接标识领卡渠道，商户活动ID）
        /// </summary>
        /// <value>实际记录的领卡渠道（可能跟商户传入值不同）；  可直接标识领卡渠道，也可配合open_card_channel_id标识领卡渠道类型：  例如：  线下门店领取:20161534000000000008863（直接标识领卡渠道，门店shopId）  线下扫二维码领取:QR（标识领卡类型）;  线下活动领取:20170522000000000003609（直接标识领卡渠道，商户活动ID）</value>
        [DataMember(Name = "open_card_channel", EmitDefaultValue = false)]
        public string OpenCardChannel { get; set; }

        /// <summary>
        /// 实际记录的领卡来源渠道id（可能跟商户传入值不同）；  区别于open_card_channel领卡渠道；  一般使用场景：  open_card_channel用于区分渠道类型，例如取值为\&quot;SHOP\&quot;（门店），\&quot;ACTIVITY\&quot;（活动）；  则open_card_channel_id可用于区分同渠道的不同实体，对应取各门店ID或各活动的标识ID等；
        /// </summary>
        /// <value>实际记录的领卡来源渠道id（可能跟商户传入值不同）；  区别于open_card_channel领卡渠道；  一般使用场景：  open_card_channel用于区分渠道类型，例如取值为\&quot;SHOP\&quot;（门店），\&quot;ACTIVITY\&quot;（活动）；  则open_card_channel_id可用于区分同渠道的不同实体，对应取各门店ID或各活动的标识ID等；</value>
        [DataMember(Name = "open_card_channel_id", EmitDefaultValue = false)]
        public string OpenCardChannelId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardOpenResponseModel {\n");
            sb.Append("  CardInfo: ").Append(CardInfo).Append("\n");
            sb.Append("  OpenCardChannel: ").Append(OpenCardChannel).Append("\n");
            sb.Append("  OpenCardChannelId: ").Append(OpenCardChannelId).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardOpenResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardOpenResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardOpenResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardOpenResponseModel input)
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
                    this.OpenCardChannel == input.OpenCardChannel ||
                    (this.OpenCardChannel != null &&
                    this.OpenCardChannel.Equals(input.OpenCardChannel))
                ) && 
                (
                    this.OpenCardChannelId == input.OpenCardChannelId ||
                    (this.OpenCardChannelId != null &&
                    this.OpenCardChannelId.Equals(input.OpenCardChannelId))
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
                if (this.OpenCardChannel != null)
                {
                    hashCode = (hashCode * 59) + this.OpenCardChannel.GetHashCode();
                }
                if (this.OpenCardChannelId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenCardChannelId.GetHashCode();
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
