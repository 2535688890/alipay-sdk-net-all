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
    /// VoucherDisplayPatternInfo
    /// </summary>
    [DataContract(Name = "VoucherDisplayPatternInfo")]
    public partial class VoucherDisplayPatternInfo : IEquatable<VoucherDisplayPatternInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VoucherDisplayPatternInfo" /> class.
        /// </summary>
        /// <param name="brandLogo">商家logo 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_BRAND_LOGO，返回的resource_id即为该参数的值。.</param>
        /// <param name="brandLogoUrl">商家品牌logo链接.</param>
        /// <param name="brandName">商户品牌名称。.</param>
        /// <param name="customerServiceMobile">客服电话。.</param>
        /// <param name="customerServiceUrl">客服链接。.</param>
        /// <param name="voucherDescription">券详细使用说明。.</param>
        /// <param name="voucherDetailImageUrls">券详情链接.</param>
        /// <param name="voucherDetailImages">券详细图列表，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_DETAIL_IMAGE  ,接口返回的resource_id即为该参数的值 上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB。.</param>
        /// <param name="voucherImage">券详情页封面图，会展示在用户支付宝卡包券详情页。 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_IMAGE，接口返回的resource_id即为该参数的值。.</param>
        /// <param name="voucherImageUrl">券封面链接.</param>
        /// <param name="voucherName">券名称。.</param>
        public VoucherDisplayPatternInfo(string brandLogo = default(string), string brandLogoUrl = default(string), string brandName = default(string), string customerServiceMobile = default(string), string customerServiceUrl = default(string), string voucherDescription = default(string), List<string> voucherDetailImageUrls = default(List<string>), List<string> voucherDetailImages = default(List<string>), string voucherImage = default(string), string voucherImageUrl = default(string), string voucherName = default(string))
        {
            this.BrandLogo = brandLogo;
            this.BrandLogoUrl = brandLogoUrl;
            this.BrandName = brandName;
            this.CustomerServiceMobile = customerServiceMobile;
            this.CustomerServiceUrl = customerServiceUrl;
            this.VoucherDescription = voucherDescription;
            this.VoucherDetailImageUrls = voucherDetailImageUrls;
            this.VoucherDetailImages = voucherDetailImages;
            this.VoucherImage = voucherImage;
            this.VoucherImageUrl = voucherImageUrl;
            this.VoucherName = voucherName;
        }

        /// <summary>
        /// 商家logo 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_BRAND_LOGO，返回的resource_id即为该参数的值。
        /// </summary>
        /// <value>商家logo 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_BRAND_LOGO，返回的resource_id即为该参数的值。</value>
        [DataMember(Name = "brand_logo", EmitDefaultValue = false)]
        public string BrandLogo { get; set; }

        /// <summary>
        /// 商家品牌logo链接
        /// </summary>
        /// <value>商家品牌logo链接</value>
        [DataMember(Name = "brand_logo_url", EmitDefaultValue = false)]
        public string BrandLogoUrl { get; set; }

        /// <summary>
        /// 商户品牌名称。
        /// </summary>
        /// <value>商户品牌名称。</value>
        [DataMember(Name = "brand_name", EmitDefaultValue = false)]
        public string BrandName { get; set; }

        /// <summary>
        /// 客服电话。
        /// </summary>
        /// <value>客服电话。</value>
        [DataMember(Name = "customer_service_mobile", EmitDefaultValue = false)]
        public string CustomerServiceMobile { get; set; }

        /// <summary>
        /// 客服链接。
        /// </summary>
        /// <value>客服链接。</value>
        [DataMember(Name = "customer_service_url", EmitDefaultValue = false)]
        public string CustomerServiceUrl { get; set; }

        /// <summary>
        /// 券详细使用说明。
        /// </summary>
        /// <value>券详细使用说明。</value>
        [DataMember(Name = "voucher_description", EmitDefaultValue = false)]
        public string VoucherDescription { get; set; }

        /// <summary>
        /// 券详情链接
        /// </summary>
        /// <value>券详情链接</value>
        [DataMember(Name = "voucher_detail_image_urls", EmitDefaultValue = false)]
        public List<string> VoucherDetailImageUrls { get; set; }

        /// <summary>
        /// 券详细图列表，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_DETAIL_IMAGE  ,接口返回的resource_id即为该参数的值 上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB。
        /// </summary>
        /// <value>券详细图列表，会展示在用户支付宝卡包券详情页 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_DETAIL_IMAGE  ,接口返回的resource_id即为该参数的值 上传图片尺寸600*600，支持格式：png、jpg、jpeg、bmp，大小不超过2MB。</value>
        [DataMember(Name = "voucher_detail_images", EmitDefaultValue = false)]
        public List<string> VoucherDetailImages { get; set; }

        /// <summary>
        /// 券详情页封面图，会展示在用户支付宝卡包券详情页。 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_IMAGE，接口返回的resource_id即为该参数的值。
        /// </summary>
        /// <value>券详情页封面图，会展示在用户支付宝卡包券详情页。 需要通过  alipay.marketing.material.image.upload接口上传图片，指定file_key为PROMO_VOUCHER_IMAGE，接口返回的resource_id即为该参数的值。</value>
        [DataMember(Name = "voucher_image", EmitDefaultValue = false)]
        public string VoucherImage { get; set; }

        /// <summary>
        /// 券封面链接
        /// </summary>
        /// <value>券封面链接</value>
        [DataMember(Name = "voucher_image_url", EmitDefaultValue = false)]
        public string VoucherImageUrl { get; set; }

        /// <summary>
        /// 券名称。
        /// </summary>
        /// <value>券名称。</value>
        [DataMember(Name = "voucher_name", EmitDefaultValue = false)]
        public string VoucherName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VoucherDisplayPatternInfo {\n");
            sb.Append("  BrandLogo: ").Append(BrandLogo).Append("\n");
            sb.Append("  BrandLogoUrl: ").Append(BrandLogoUrl).Append("\n");
            sb.Append("  BrandName: ").Append(BrandName).Append("\n");
            sb.Append("  CustomerServiceMobile: ").Append(CustomerServiceMobile).Append("\n");
            sb.Append("  CustomerServiceUrl: ").Append(CustomerServiceUrl).Append("\n");
            sb.Append("  VoucherDescription: ").Append(VoucherDescription).Append("\n");
            sb.Append("  VoucherDetailImageUrls: ").Append(VoucherDetailImageUrls).Append("\n");
            sb.Append("  VoucherDetailImages: ").Append(VoucherDetailImages).Append("\n");
            sb.Append("  VoucherImage: ").Append(VoucherImage).Append("\n");
            sb.Append("  VoucherImageUrl: ").Append(VoucherImageUrl).Append("\n");
            sb.Append("  VoucherName: ").Append(VoucherName).Append("\n");
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
            return this.Equals(input as VoucherDisplayPatternInfo);
        }

        /// <summary>
        /// Returns true if VoucherDisplayPatternInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of VoucherDisplayPatternInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VoucherDisplayPatternInfo input)
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
                    this.BrandLogoUrl == input.BrandLogoUrl ||
                    (this.BrandLogoUrl != null &&
                    this.BrandLogoUrl.Equals(input.BrandLogoUrl))
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
                    this.VoucherDescription == input.VoucherDescription ||
                    (this.VoucherDescription != null &&
                    this.VoucherDescription.Equals(input.VoucherDescription))
                ) && 
                (
                    this.VoucherDetailImageUrls == input.VoucherDetailImageUrls ||
                    this.VoucherDetailImageUrls != null &&
                    input.VoucherDetailImageUrls != null &&
                    this.VoucherDetailImageUrls.SequenceEqual(input.VoucherDetailImageUrls)
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
                ) && 
                (
                    this.VoucherImageUrl == input.VoucherImageUrl ||
                    (this.VoucherImageUrl != null &&
                    this.VoucherImageUrl.Equals(input.VoucherImageUrl))
                ) && 
                (
                    this.VoucherName == input.VoucherName ||
                    (this.VoucherName != null &&
                    this.VoucherName.Equals(input.VoucherName))
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
                if (this.BrandLogoUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BrandLogoUrl.GetHashCode();
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
                if (this.VoucherDescription != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDescription.GetHashCode();
                }
                if (this.VoucherDetailImageUrls != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDetailImageUrls.GetHashCode();
                }
                if (this.VoucherDetailImages != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherDetailImages.GetHashCode();
                }
                if (this.VoucherImage != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherImage.GetHashCode();
                }
                if (this.VoucherImageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherImageUrl.GetHashCode();
                }
                if (this.VoucherName != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherName.GetHashCode();
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
