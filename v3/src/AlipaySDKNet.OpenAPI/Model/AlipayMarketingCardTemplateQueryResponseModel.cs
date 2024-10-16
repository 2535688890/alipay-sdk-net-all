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
    /// AlipayMarketingCardTemplateQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayMarketingCardTemplateQueryResponseModel")]
    public partial class AlipayMarketingCardTemplateQueryResponseModel : IEquatable<AlipayMarketingCardTemplateQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayMarketingCardTemplateQueryResponseModel" /> class.
        /// </summary>
        /// <param name="accessVersion">接入版本，接入的是基础版本一定会有值.</param>
        /// <param name="bizNoPrefix">业务卡号前缀，由商户指定  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀.</param>
        /// <param name="bizNoSuffixLen">业务卡号后缀的长度  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀.</param>
        /// <param name="cardActionList">\&quot;卡行动点配置； 行动点，即用户可点击跳转的区块，类似按钮控件的交互； 单张卡最多4个行动点。\&quot;.</param>
        /// <param name="cardLevelConfs">卡等级配置.</param>
        /// <param name="cardSpecTag">卡特定标签，只供特定业务使用，通常接入无需关注.</param>
        /// <param name="cardType">会员卡类型：  OUT_MEMBER_CARD：外部权益卡.</param>
        /// <param name="columnInfoList">栏位信息（卡包详情页面展现的栏位）.</param>
        /// <param name="fieldRuleList">\&quot;字段规则列表，会员卡开卡过程中，会员卡信息的生成规则， 例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE\&quot;.</param>
        /// <param name="mdcodeNotifyConf">mdcodeNotifyConf.</param>
        /// <param name="openCardConf">openCardConf.</param>
        /// <param name="paidOuterCardConf">paidOuterCardConf.</param>
        /// <param name="pubChannels">卡模板投放渠道.</param>
        /// <param name="serviceLabelList">服务标签列表.</param>
        /// <param name="shopIds">支付宝门店id.</param>
        /// <param name="spiAppId">spi应用id，设置的实现spi.alipay.user.opencard.get接口的app_id.</param>
        /// <param name="templateBenefitInfo">\&quot;权益信息， 1、在卡包的卡详情页面会自动添加权益栏位，展现会员卡特权， 2、如果添加门店渠道，则可在门店页展现会员卡的权益\&quot;.</param>
        /// <param name="templateFormConfig">templateFormConfig.</param>
        /// <param name="templateStyleInfo">templateStyleInfo.</param>
        public AlipayMarketingCardTemplateQueryResponseModel(string accessVersion = default(string), string bizNoPrefix = default(string), string bizNoSuffixLen = default(string), List<TemplateActionInfoDTO> cardActionList = default(List<TemplateActionInfoDTO>), List<TemplateCardLevelConfDTO> cardLevelConfs = default(List<TemplateCardLevelConfDTO>), string cardSpecTag = default(string), string cardType = default(string), List<TemplateColumnInfoDTO> columnInfoList = default(List<TemplateColumnInfoDTO>), List<TemplateFieldRuleDTO> fieldRuleList = default(List<TemplateFieldRuleDTO>), TemplateMdcodeNotifyConfDTO mdcodeNotifyConf = default(TemplateMdcodeNotifyConfDTO), TemplateOpenCardConfDTO openCardConf = default(TemplateOpenCardConfDTO), PaidOuterCardTemplateConfDTO paidOuterCardConf = default(PaidOuterCardTemplateConfDTO), List<PubChannelDTO> pubChannels = default(List<PubChannelDTO>), List<string> serviceLabelList = default(List<string>), List<string> shopIds = default(List<string>), string spiAppId = default(string), List<TemplateBenefitInfoDTO> templateBenefitInfo = default(List<TemplateBenefitInfoDTO>), TemplateFormConfig templateFormConfig = default(TemplateFormConfig), TemplateStyleInfoDTO templateStyleInfo = default(TemplateStyleInfoDTO))
        {
            this.AccessVersion = accessVersion;
            this.BizNoPrefix = bizNoPrefix;
            this.BizNoSuffixLen = bizNoSuffixLen;
            this.CardActionList = cardActionList;
            this.CardLevelConfs = cardLevelConfs;
            this.CardSpecTag = cardSpecTag;
            this.CardType = cardType;
            this.ColumnInfoList = columnInfoList;
            this.FieldRuleList = fieldRuleList;
            this.MdcodeNotifyConf = mdcodeNotifyConf;
            this.OpenCardConf = openCardConf;
            this.PaidOuterCardConf = paidOuterCardConf;
            this.PubChannels = pubChannels;
            this.ServiceLabelList = serviceLabelList;
            this.ShopIds = shopIds;
            this.SpiAppId = spiAppId;
            this.TemplateBenefitInfo = templateBenefitInfo;
            this.TemplateFormConfig = templateFormConfig;
            this.TemplateStyleInfo = templateStyleInfo;
        }

        /// <summary>
        /// 接入版本，接入的是基础版本一定会有值
        /// </summary>
        /// <value>接入版本，接入的是基础版本一定会有值</value>
        [DataMember(Name = "access_version", EmitDefaultValue = false)]
        public string AccessVersion { get; set; }

        /// <summary>
        /// 业务卡号前缀，由商户指定  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀
        /// </summary>
        /// <value>业务卡号前缀，由商户指定  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀</value>
        [DataMember(Name = "biz_no_prefix", EmitDefaultValue = false)]
        public string BizNoPrefix { get; set; }

        /// <summary>
        /// 业务卡号后缀的长度  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀
        /// </summary>
        /// <value>业务卡号后缀的长度  支付宝业务卡号生成规则：biz_no_prefix(商户指定)卡号前缀 + biz_no_suffix(实时生成）卡号后缀</value>
        [DataMember(Name = "biz_no_suffix_len", EmitDefaultValue = false)]
        public string BizNoSuffixLen { get; set; }

        /// <summary>
        /// \&quot;卡行动点配置； 行动点，即用户可点击跳转的区块，类似按钮控件的交互； 单张卡最多4个行动点。\&quot;
        /// </summary>
        /// <value>\&quot;卡行动点配置； 行动点，即用户可点击跳转的区块，类似按钮控件的交互； 单张卡最多4个行动点。\&quot;</value>
        [DataMember(Name = "card_action_list", EmitDefaultValue = false)]
        public List<TemplateActionInfoDTO> CardActionList { get; set; }

        /// <summary>
        /// 卡等级配置
        /// </summary>
        /// <value>卡等级配置</value>
        [DataMember(Name = "card_level_confs", EmitDefaultValue = false)]
        public List<TemplateCardLevelConfDTO> CardLevelConfs { get; set; }

        /// <summary>
        /// 卡特定标签，只供特定业务使用，通常接入无需关注
        /// </summary>
        /// <value>卡特定标签，只供特定业务使用，通常接入无需关注</value>
        [DataMember(Name = "card_spec_tag", EmitDefaultValue = false)]
        public string CardSpecTag { get; set; }

        /// <summary>
        /// 会员卡类型：  OUT_MEMBER_CARD：外部权益卡
        /// </summary>
        /// <value>会员卡类型：  OUT_MEMBER_CARD：外部权益卡</value>
        [DataMember(Name = "card_type", EmitDefaultValue = false)]
        public string CardType { get; set; }

        /// <summary>
        /// 栏位信息（卡包详情页面展现的栏位）
        /// </summary>
        /// <value>栏位信息（卡包详情页面展现的栏位）</value>
        [DataMember(Name = "column_info_list", EmitDefaultValue = false)]
        public List<TemplateColumnInfoDTO> ColumnInfoList { get; set; }

        /// <summary>
        /// \&quot;字段规则列表，会员卡开卡过程中，会员卡信息的生成规则， 例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE\&quot;
        /// </summary>
        /// <value>\&quot;字段规则列表，会员卡开卡过程中，会员卡信息的生成规则， 例如：卡有效期为开卡后两年内有效，则设置为：DATE_IN_FUTURE\&quot;</value>
        [DataMember(Name = "field_rule_list", EmitDefaultValue = false)]
        public List<TemplateFieldRuleDTO> FieldRuleList { get; set; }

        /// <summary>
        /// Gets or Sets MdcodeNotifyConf
        /// </summary>
        [DataMember(Name = "mdcode_notify_conf", EmitDefaultValue = false)]
        public TemplateMdcodeNotifyConfDTO MdcodeNotifyConf { get; set; }

        /// <summary>
        /// Gets or Sets OpenCardConf
        /// </summary>
        [DataMember(Name = "open_card_conf", EmitDefaultValue = false)]
        public TemplateOpenCardConfDTO OpenCardConf { get; set; }

        /// <summary>
        /// Gets or Sets PaidOuterCardConf
        /// </summary>
        [DataMember(Name = "paid_outer_card_conf", EmitDefaultValue = false)]
        public PaidOuterCardTemplateConfDTO PaidOuterCardConf { get; set; }

        /// <summary>
        /// 卡模板投放渠道
        /// </summary>
        /// <value>卡模板投放渠道</value>
        [DataMember(Name = "pub_channels", EmitDefaultValue = false)]
        public List<PubChannelDTO> PubChannels { get; set; }

        /// <summary>
        /// 服务标签列表
        /// </summary>
        /// <value>服务标签列表</value>
        [DataMember(Name = "service_label_list", EmitDefaultValue = false)]
        public List<string> ServiceLabelList { get; set; }

        /// <summary>
        /// 支付宝门店id
        /// </summary>
        /// <value>支付宝门店id</value>
        [DataMember(Name = "shop_ids", EmitDefaultValue = false)]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// spi应用id，设置的实现spi.alipay.user.opencard.get接口的app_id
        /// </summary>
        /// <value>spi应用id，设置的实现spi.alipay.user.opencard.get接口的app_id</value>
        [DataMember(Name = "spi_app_id", EmitDefaultValue = false)]
        public string SpiAppId { get; set; }

        /// <summary>
        /// \&quot;权益信息， 1、在卡包的卡详情页面会自动添加权益栏位，展现会员卡特权， 2、如果添加门店渠道，则可在门店页展现会员卡的权益\&quot;
        /// </summary>
        /// <value>\&quot;权益信息， 1、在卡包的卡详情页面会自动添加权益栏位，展现会员卡特权， 2、如果添加门店渠道，则可在门店页展现会员卡的权益\&quot;</value>
        [DataMember(Name = "template_benefit_info", EmitDefaultValue = false)]
        public List<TemplateBenefitInfoDTO> TemplateBenefitInfo { get; set; }

        /// <summary>
        /// Gets or Sets TemplateFormConfig
        /// </summary>
        [DataMember(Name = "template_form_config", EmitDefaultValue = false)]
        public TemplateFormConfig TemplateFormConfig { get; set; }

        /// <summary>
        /// Gets or Sets TemplateStyleInfo
        /// </summary>
        [DataMember(Name = "template_style_info", EmitDefaultValue = false)]
        public TemplateStyleInfoDTO TemplateStyleInfo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayMarketingCardTemplateQueryResponseModel {\n");
            sb.Append("  AccessVersion: ").Append(AccessVersion).Append("\n");
            sb.Append("  BizNoPrefix: ").Append(BizNoPrefix).Append("\n");
            sb.Append("  BizNoSuffixLen: ").Append(BizNoSuffixLen).Append("\n");
            sb.Append("  CardActionList: ").Append(CardActionList).Append("\n");
            sb.Append("  CardLevelConfs: ").Append(CardLevelConfs).Append("\n");
            sb.Append("  CardSpecTag: ").Append(CardSpecTag).Append("\n");
            sb.Append("  CardType: ").Append(CardType).Append("\n");
            sb.Append("  ColumnInfoList: ").Append(ColumnInfoList).Append("\n");
            sb.Append("  FieldRuleList: ").Append(FieldRuleList).Append("\n");
            sb.Append("  MdcodeNotifyConf: ").Append(MdcodeNotifyConf).Append("\n");
            sb.Append("  OpenCardConf: ").Append(OpenCardConf).Append("\n");
            sb.Append("  PaidOuterCardConf: ").Append(PaidOuterCardConf).Append("\n");
            sb.Append("  PubChannels: ").Append(PubChannels).Append("\n");
            sb.Append("  ServiceLabelList: ").Append(ServiceLabelList).Append("\n");
            sb.Append("  ShopIds: ").Append(ShopIds).Append("\n");
            sb.Append("  SpiAppId: ").Append(SpiAppId).Append("\n");
            sb.Append("  TemplateBenefitInfo: ").Append(TemplateBenefitInfo).Append("\n");
            sb.Append("  TemplateFormConfig: ").Append(TemplateFormConfig).Append("\n");
            sb.Append("  TemplateStyleInfo: ").Append(TemplateStyleInfo).Append("\n");
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
            return this.Equals(input as AlipayMarketingCardTemplateQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayMarketingCardTemplateQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayMarketingCardTemplateQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayMarketingCardTemplateQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AccessVersion == input.AccessVersion ||
                    (this.AccessVersion != null &&
                    this.AccessVersion.Equals(input.AccessVersion))
                ) && 
                (
                    this.BizNoPrefix == input.BizNoPrefix ||
                    (this.BizNoPrefix != null &&
                    this.BizNoPrefix.Equals(input.BizNoPrefix))
                ) && 
                (
                    this.BizNoSuffixLen == input.BizNoSuffixLen ||
                    (this.BizNoSuffixLen != null &&
                    this.BizNoSuffixLen.Equals(input.BizNoSuffixLen))
                ) && 
                (
                    this.CardActionList == input.CardActionList ||
                    this.CardActionList != null &&
                    input.CardActionList != null &&
                    this.CardActionList.SequenceEqual(input.CardActionList)
                ) && 
                (
                    this.CardLevelConfs == input.CardLevelConfs ||
                    this.CardLevelConfs != null &&
                    input.CardLevelConfs != null &&
                    this.CardLevelConfs.SequenceEqual(input.CardLevelConfs)
                ) && 
                (
                    this.CardSpecTag == input.CardSpecTag ||
                    (this.CardSpecTag != null &&
                    this.CardSpecTag.Equals(input.CardSpecTag))
                ) && 
                (
                    this.CardType == input.CardType ||
                    (this.CardType != null &&
                    this.CardType.Equals(input.CardType))
                ) && 
                (
                    this.ColumnInfoList == input.ColumnInfoList ||
                    this.ColumnInfoList != null &&
                    input.ColumnInfoList != null &&
                    this.ColumnInfoList.SequenceEqual(input.ColumnInfoList)
                ) && 
                (
                    this.FieldRuleList == input.FieldRuleList ||
                    this.FieldRuleList != null &&
                    input.FieldRuleList != null &&
                    this.FieldRuleList.SequenceEqual(input.FieldRuleList)
                ) && 
                (
                    this.MdcodeNotifyConf == input.MdcodeNotifyConf ||
                    (this.MdcodeNotifyConf != null &&
                    this.MdcodeNotifyConf.Equals(input.MdcodeNotifyConf))
                ) && 
                (
                    this.OpenCardConf == input.OpenCardConf ||
                    (this.OpenCardConf != null &&
                    this.OpenCardConf.Equals(input.OpenCardConf))
                ) && 
                (
                    this.PaidOuterCardConf == input.PaidOuterCardConf ||
                    (this.PaidOuterCardConf != null &&
                    this.PaidOuterCardConf.Equals(input.PaidOuterCardConf))
                ) && 
                (
                    this.PubChannels == input.PubChannels ||
                    this.PubChannels != null &&
                    input.PubChannels != null &&
                    this.PubChannels.SequenceEqual(input.PubChannels)
                ) && 
                (
                    this.ServiceLabelList == input.ServiceLabelList ||
                    this.ServiceLabelList != null &&
                    input.ServiceLabelList != null &&
                    this.ServiceLabelList.SequenceEqual(input.ServiceLabelList)
                ) && 
                (
                    this.ShopIds == input.ShopIds ||
                    this.ShopIds != null &&
                    input.ShopIds != null &&
                    this.ShopIds.SequenceEqual(input.ShopIds)
                ) && 
                (
                    this.SpiAppId == input.SpiAppId ||
                    (this.SpiAppId != null &&
                    this.SpiAppId.Equals(input.SpiAppId))
                ) && 
                (
                    this.TemplateBenefitInfo == input.TemplateBenefitInfo ||
                    this.TemplateBenefitInfo != null &&
                    input.TemplateBenefitInfo != null &&
                    this.TemplateBenefitInfo.SequenceEqual(input.TemplateBenefitInfo)
                ) && 
                (
                    this.TemplateFormConfig == input.TemplateFormConfig ||
                    (this.TemplateFormConfig != null &&
                    this.TemplateFormConfig.Equals(input.TemplateFormConfig))
                ) && 
                (
                    this.TemplateStyleInfo == input.TemplateStyleInfo ||
                    (this.TemplateStyleInfo != null &&
                    this.TemplateStyleInfo.Equals(input.TemplateStyleInfo))
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
                if (this.AccessVersion != null)
                {
                    hashCode = (hashCode * 59) + this.AccessVersion.GetHashCode();
                }
                if (this.BizNoPrefix != null)
                {
                    hashCode = (hashCode * 59) + this.BizNoPrefix.GetHashCode();
                }
                if (this.BizNoSuffixLen != null)
                {
                    hashCode = (hashCode * 59) + this.BizNoSuffixLen.GetHashCode();
                }
                if (this.CardActionList != null)
                {
                    hashCode = (hashCode * 59) + this.CardActionList.GetHashCode();
                }
                if (this.CardLevelConfs != null)
                {
                    hashCode = (hashCode * 59) + this.CardLevelConfs.GetHashCode();
                }
                if (this.CardSpecTag != null)
                {
                    hashCode = (hashCode * 59) + this.CardSpecTag.GetHashCode();
                }
                if (this.CardType != null)
                {
                    hashCode = (hashCode * 59) + this.CardType.GetHashCode();
                }
                if (this.ColumnInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.ColumnInfoList.GetHashCode();
                }
                if (this.FieldRuleList != null)
                {
                    hashCode = (hashCode * 59) + this.FieldRuleList.GetHashCode();
                }
                if (this.MdcodeNotifyConf != null)
                {
                    hashCode = (hashCode * 59) + this.MdcodeNotifyConf.GetHashCode();
                }
                if (this.OpenCardConf != null)
                {
                    hashCode = (hashCode * 59) + this.OpenCardConf.GetHashCode();
                }
                if (this.PaidOuterCardConf != null)
                {
                    hashCode = (hashCode * 59) + this.PaidOuterCardConf.GetHashCode();
                }
                if (this.PubChannels != null)
                {
                    hashCode = (hashCode * 59) + this.PubChannels.GetHashCode();
                }
                if (this.ServiceLabelList != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceLabelList.GetHashCode();
                }
                if (this.ShopIds != null)
                {
                    hashCode = (hashCode * 59) + this.ShopIds.GetHashCode();
                }
                if (this.SpiAppId != null)
                {
                    hashCode = (hashCode * 59) + this.SpiAppId.GetHashCode();
                }
                if (this.TemplateBenefitInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateBenefitInfo.GetHashCode();
                }
                if (this.TemplateFormConfig != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateFormConfig.GetHashCode();
                }
                if (this.TemplateStyleInfo != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateStyleInfo.GetHashCode();
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
