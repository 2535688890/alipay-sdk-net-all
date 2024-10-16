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
    /// VoucherDisplayInfoModify
    /// </summary>
    [DataContract(Name = "VoucherDisplayInfoModify")]
    public partial class VoucherDisplayInfoModify : IEquatable<VoucherDisplayInfoModify>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherDisplayInfoModify" /> class.
        /// </summary>
        /// <param name="brandLogo">商家logo  需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_BRAND_LOGO，返回的resource_id即为该参数的值.</param>
        /// <param name="brandName">商户品牌名称。.</param>
        /// <param name="customerServiceMobile">客服电话.</param>
        /// <param name="customerServiceUrl">客服链接.</param>
        /// <param name="voucherComment">券补充说明，该字段为可运营字段，可描述商品特色 会展示在用户支付宝卡包券详情页。.</param>
        /// <param name="voucherDescription">券详细使用说明。.</param>
        /// <param name="voucherDetailImages">券详细图列表，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_DETAIL_IMAGE  ,接口返回的resource_id即为该参数的值 上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB。.</param>
        /// <param name="voucherImage">券详情页封面图，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_IMAGE，接口返回的resource_id即为该参数的值。.</param>
        public VoucherDisplayInfoModify(string brandLogo = default(string), string brandName = default(string), string customerServiceMobile = default(string), string customerServiceUrl = default(string), string voucherComment = default(string), string voucherDescription = default(string), List<string> voucherDetailImages = default(List<string>), string voucherImage = default(string))
        {
            this.BrandLogo = brandLogo;
            this.BrandName = brandName;
            this.CustomerServiceMobile = customerServiceMobile;
            this.CustomerServiceUrl = customerServiceUrl;
            this.VoucherComment = voucherComment;
            this.VoucherDescription = voucherDescription;
            this.VoucherDetailImages = voucherDetailImages;
            this.VoucherImage = voucherImage;
        }

        /// <summary>
        /// 商家logo  需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_BRAND_LOGO，返回的resource_id即为该参数的值
        /// </summary>
        /// <value>商家logo  需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_BRAND_LOGO，返回的resource_id即为该参数的值</value>
        [DataMember(Name = "brand_logo", EmitDefaultValue = false)]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商户品牌名称。
        /// </summary>
        /// <value>商户品牌名称。</value>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// 客服电话
        /// </summary>
        /// <value>客服电话</value>
        [DataMember(Name = "customer_service_mobile", EmitDefaultValue = false)]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 客服链接
        /// </summary>
        /// <value>客服链接</value>
        [DataMember(Name = "customer_service_url", EmitDefaultValue = false)]
        public string CustomerServiceUrl { get; set; }

        /// <summary>
        /// 券补充说明，该字段为可运营字段，可描述商品特色 会展示在用户支付宝卡包券详情页。
        /// </summary>
        /// <value>券补充说明，该字段为可运营字段，可描述商品特色 会展示在用户支付宝卡包券详情页。</value>
        [DataMember(Name = "voucher_comment", EmitDefaultValue = false)]
        public string VoucherComment { get; set; }

        /// <summary>
        /// 券详细使用说明。
        /// </summary>
        /// <value>券详细使用说明。</value>
        [DataMember(Name = "voucher_description", EmitDefaultValue = false)]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券详细图列表，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_DETAIL_IMAGE  ,接口返回的resource_id即为该参数的值 上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB。
        /// </summary>
        /// <value>券详细图列表，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_DETAIL_IMAGE  ,接口返回的resource_id即为该参数的值 上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB。</value>
        [DataMember(Name = "voucher_detail_images", EmitDefaultValue = false)]
        public List<string> VoucherDetailImages { get; set; }

        /// <summary>
        /// 券详情页封面图，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_IMAGE，接口返回的resource_id即为该参数的值。
        /// </summary>
        /// <value>券详情页封面图，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_IMAGE，接口返回的resource_id即为该参数的值。</value>
        [DataMember(Name = "voucher_image", EmitDefaultValue = false)]
        public string VoucherImage { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherDisplayInfoModify {\n");
            sb.Append("  BrandLogo: ").Append(BrandLogo).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  CustomerServiceMobile: ").Append(CustomerServiceMobile).Append("\n");
            sb.Append("  CustomerServiceUrl: ").Append(CustomerServiceUrl).Append("\n");
            sb.Append("  VoucherComment: ").Append(VoucherComment).Append("\n");
            sb.Append("  VoucherDescription: ").Append(VoucherDescription).Append("\n");
            sb.Append("  VoucherDetailImages: ").Append(VoucherDetailImages).Append("\n");
            sb.Append("  VoucherImage: ").Append(VoucherImage).Append("\n");
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
            return this.Equals(input as VoucherDisplayInfoModify);
        }

        /// <summary>
        /// Returns true if VoucherDisplayInfoModify instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherDisplayInfoModify to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherDisplayInfoModify input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BrandLogo == input.BrandLogo ||
                    (this.BrandLogo != null &&
                    this.BrandLogo.Equals(input.BrandLogo))
                ) && 
                (
                    this.BrandName == input.BrandName ||
                    (this.BrandName != null &&
                    this.BrandName.Equals(input.BrandName))
                ) && 
                (
                    this.CustomerServiceMobile == input.CustomerServiceMobile ||
                    (this.CustomerServiceMobile != null &&
                    this.CustomerServiceMobile.Equals(input.CustomerServiceMobile))
                ) && 
                (
                    this.CustomerServiceUrl == input.CustomerServiceUrl ||
                    (this.CustomerServiceUrl != null &&
                    this.CustomerServiceUrl.Equals(input.CustomerServiceUrl))
                ) && 
                (
                    this.VoucherComment == input.VoucherComment ||
                    (this.VoucherComment != null &&
                    this.VoucherComment.Equals(input.VoucherComment))
                ) && 
                (
                    this.VoucherDescription == input.VoucherDescription ||
                    (this.VoucherDescription != null &&
                    this.VoucherDescription.Equals(input.VoucherDescription))
                ) && 
                (
                    this.VoucherDetailImages == input.VoucherDetailImages ||
                    this.VoucherDetailImages != null &&
                    input.VoucherDetailImages != null &&
                    this.VoucherDetailImages.SequenceEqual(input.VoucherDetailImages)
                ) && 
                (
                    this.VoucherImage == input.VoucherImage ||
                    (this.VoucherImage != null &&
                    this.VoucherImage.Equals(input.VoucherImage))
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
                if (this.BrandLogo != null)
                {
                    hashCode = (hashCode * 59) + this.BrandLogo.GetHashCode();
                }
                if (this.BrandName != null)
                {
                    hashCode = (hashCode * 59) + this.BrandName.GetHashCode();
                }
                if (this.CustomerServiceMobile != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerServiceMobile.GetHashCode();
                }
                if (this.CustomerServiceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerServiceUrl.GetHashCode();
                }
                if (this.VoucherComment != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherComment.GetHashCode();
                }
                if (this.VoucherDescription != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDescription.GetHashCode();
                }
                if (this.VoucherDetailImages != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDetailImages.GetHashCode();
                }
                if (this.VoucherImage != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherImage.GetHashCode();
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
