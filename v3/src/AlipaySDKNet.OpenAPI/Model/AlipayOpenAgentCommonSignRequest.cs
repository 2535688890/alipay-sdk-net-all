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
    /// AlipayOpenAgentCommonSignRequest
    /// </summary>
    [DataContract(Name = "alipay_open_agent_common_sign_request")]
    public partial class AlipayOpenAgentCommonSignRequest : IEquatable<AlipayOpenAgentCommonSignRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenAgentCommonSignRequest" /> class.
        /// </summary>
        /// <param name="appAuthPic">appAuthPic.</param>
        /// <param name="appDemo">appDemo.</param>
        /// <param name="appHomeScreenshot">appHomeScreenshot.</param>
        /// <param name="appItemScreenshot">appItemScreenshot.</param>
        /// <param name="appPayScreenshot">appPayScreenshot.</param>
        /// <param name="businessLicenseAuthPic">businessLicenseAuthPic.</param>
        /// <param name="businessLicensePic">businessLicensePic.</param>
        /// <param name="data">data.</param>
        /// <param name="h5ExtraPic">h5ExtraPic.</param>
        /// <param name="h5HomeScreenshot">h5HomeScreenshot.</param>
        /// <param name="h5ItemScreenshot">h5ItemScreenshot.</param>
        /// <param name="h5PayScreenshot">h5PayScreenshot.</param>
        /// <param name="h5SitesLoa">h5SitesLoa.</param>
        /// <param name="miniAppScreenshot">miniAppScreenshot.</param>
        /// <param name="shopScenePic">shopScenePic.</param>
        /// <param name="shopSignBoardPic">shopSignBoardPic.</param>
        /// <param name="specialLicensePic">specialLicensePic.</param>
        /// <param name="webHomeScreenshot">webHomeScreenshot.</param>
        /// <param name="webItemScreenshot">webItemScreenshot.</param>
        /// <param name="webPayScreenshot">webPayScreenshot.</param>
        /// <param name="webSitesLoa">webSitesLoa.</param>
        public AlipayOpenAgentCommonSignRequest(System.IO.Stream appAuthPic = default(System.IO.Stream), System.IO.Stream appDemo = default(System.IO.Stream), System.IO.Stream appHomeScreenshot = default(System.IO.Stream), System.IO.Stream appItemScreenshot = default(System.IO.Stream), System.IO.Stream appPayScreenshot = default(System.IO.Stream), System.IO.Stream businessLicenseAuthPic = default(System.IO.Stream), System.IO.Stream businessLicensePic = default(System.IO.Stream), AlipayOpenAgentCommonSignModel data = default(AlipayOpenAgentCommonSignModel), System.IO.Stream h5ExtraPic = default(System.IO.Stream), System.IO.Stream h5HomeScreenshot = default(System.IO.Stream), System.IO.Stream h5ItemScreenshot = default(System.IO.Stream), System.IO.Stream h5PayScreenshot = default(System.IO.Stream), System.IO.Stream h5SitesLoa = default(System.IO.Stream), System.IO.Stream miniAppScreenshot = default(System.IO.Stream), System.IO.Stream shopScenePic = default(System.IO.Stream), System.IO.Stream shopSignBoardPic = default(System.IO.Stream), System.IO.Stream specialLicensePic = default(System.IO.Stream), System.IO.Stream webHomeScreenshot = default(System.IO.Stream), System.IO.Stream webItemScreenshot = default(System.IO.Stream), System.IO.Stream webPayScreenshot = default(System.IO.Stream), System.IO.Stream webSitesLoa = default(System.IO.Stream))
        {
            this.AppAuthPic = appAuthPic;
            this.AppDemo = appDemo;
            this.AppHomeScreenshot = appHomeScreenshot;
            this.AppItemScreenshot = appItemScreenshot;
            this.AppPayScreenshot = appPayScreenshot;
            this.BusinessLicenseAuthPic = businessLicenseAuthPic;
            this.BusinessLicensePic = businessLicensePic;
            this.Data = data;
            this.H5ExtraPic = h5ExtraPic;
            this.H5HomeScreenshot = h5HomeScreenshot;
            this.H5ItemScreenshot = h5ItemScreenshot;
            this.H5PayScreenshot = h5PayScreenshot;
            this.H5SitesLoa = h5SitesLoa;
            this.MiniAppScreenshot = miniAppScreenshot;
            this.ShopScenePic = shopScenePic;
            this.ShopSignBoardPic = shopSignBoardPic;
            this.SpecialLicensePic = specialLicensePic;
            this.WebHomeScreenshot = webHomeScreenshot;
            this.WebItemScreenshot = webItemScreenshot;
            this.WebPayScreenshot = webPayScreenshot;
            this.WebSitesLoa = webSitesLoa;
        }

        /// <summary>
        /// Gets or Sets AppAuthPic
        /// </summary>
        [DataMember(Name = "app_auth_pic", EmitDefaultValue = false)]
        public System.IO.Stream AppAuthPic { get; set; }

        /// <summary>
        /// Gets or Sets AppDemo
        /// </summary>
        [DataMember(Name = "app_demo", EmitDefaultValue = false)]
        public System.IO.Stream AppDemo { get; set; }

        /// <summary>
        /// Gets or Sets AppHomeScreenshot
        /// </summary>
        [DataMember(Name = "app_home_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream AppHomeScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets AppItemScreenshot
        /// </summary>
        [DataMember(Name = "app_item_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream AppItemScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets AppPayScreenshot
        /// </summary>
        [DataMember(Name = "app_pay_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream AppPayScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets BusinessLicenseAuthPic
        /// </summary>
        [DataMember(Name = "business_license_auth_pic", EmitDefaultValue = false)]
        public System.IO.Stream BusinessLicenseAuthPic { get; set; }

        /// <summary>
        /// Gets or Sets BusinessLicensePic
        /// </summary>
        [DataMember(Name = "business_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream BusinessLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", EmitDefaultValue = false)]
        public AlipayOpenAgentCommonSignModel Data { get; set; }

        /// <summary>
        /// Gets or Sets H5ExtraPic
        /// </summary>
        [DataMember(Name = "h_5_extra_pic", EmitDefaultValue = false)]
        public System.IO.Stream H5ExtraPic { get; set; }

        /// <summary>
        /// Gets or Sets H5HomeScreenshot
        /// </summary>
        [DataMember(Name = "h_5_home_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream H5HomeScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets H5ItemScreenshot
        /// </summary>
        [DataMember(Name = "h_5_item_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream H5ItemScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets H5PayScreenshot
        /// </summary>
        [DataMember(Name = "h_5_pay_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream H5PayScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets H5SitesLoa
        /// </summary>
        [DataMember(Name = "h_5_sites_loa", EmitDefaultValue = false)]
        public System.IO.Stream H5SitesLoa { get; set; }

        /// <summary>
        /// Gets or Sets MiniAppScreenshot
        /// </summary>
        [DataMember(Name = "mini_app_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream MiniAppScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets ShopScenePic
        /// </summary>
        [DataMember(Name = "shop_scene_pic", EmitDefaultValue = false)]
        public System.IO.Stream ShopScenePic { get; set; }

        /// <summary>
        /// Gets or Sets ShopSignBoardPic
        /// </summary>
        [DataMember(Name = "shop_sign_board_pic", EmitDefaultValue = false)]
        public System.IO.Stream ShopSignBoardPic { get; set; }

        /// <summary>
        /// Gets or Sets SpecialLicensePic
        /// </summary>
        [DataMember(Name = "special_license_pic", EmitDefaultValue = false)]
        public System.IO.Stream SpecialLicensePic { get; set; }

        /// <summary>
        /// Gets or Sets WebHomeScreenshot
        /// </summary>
        [DataMember(Name = "web_home_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream WebHomeScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets WebItemScreenshot
        /// </summary>
        [DataMember(Name = "web_item_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream WebItemScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets WebPayScreenshot
        /// </summary>
        [DataMember(Name = "web_pay_screenshot", EmitDefaultValue = false)]
        public System.IO.Stream WebPayScreenshot { get; set; }

        /// <summary>
        /// Gets or Sets WebSitesLoa
        /// </summary>
        [DataMember(Name = "web_sites_loa", EmitDefaultValue = false)]
        public System.IO.Stream WebSitesLoa { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenAgentCommonSignRequest {\n");
            sb.Append("  AppAuthPic: ").Append(AppAuthPic).Append("\n");
            sb.Append("  AppDemo: ").Append(AppDemo).Append("\n");
            sb.Append("  AppHomeScreenshot: ").Append(AppHomeScreenshot).Append("\n");
            sb.Append("  AppItemScreenshot: ").Append(AppItemScreenshot).Append("\n");
            sb.Append("  AppPayScreenshot: ").Append(AppPayScreenshot).Append("\n");
            sb.Append("  BusinessLicenseAuthPic: ").Append(BusinessLicenseAuthPic).Append("\n");
            sb.Append("  BusinessLicensePic: ").Append(BusinessLicensePic).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  H5ExtraPic: ").Append(H5ExtraPic).Append("\n");
            sb.Append("  H5HomeScreenshot: ").Append(H5HomeScreenshot).Append("\n");
            sb.Append("  H5ItemScreenshot: ").Append(H5ItemScreenshot).Append("\n");
            sb.Append("  H5PayScreenshot: ").Append(H5PayScreenshot).Append("\n");
            sb.Append("  H5SitesLoa: ").Append(H5SitesLoa).Append("\n");
            sb.Append("  MiniAppScreenshot: ").Append(MiniAppScreenshot).Append("\n");
            sb.Append("  ShopScenePic: ").Append(ShopScenePic).Append("\n");
            sb.Append("  ShopSignBoardPic: ").Append(ShopSignBoardPic).Append("\n");
            sb.Append("  SpecialLicensePic: ").Append(SpecialLicensePic).Append("\n");
            sb.Append("  WebHomeScreenshot: ").Append(WebHomeScreenshot).Append("\n");
            sb.Append("  WebItemScreenshot: ").Append(WebItemScreenshot).Append("\n");
            sb.Append("  WebPayScreenshot: ").Append(WebPayScreenshot).Append("\n");
            sb.Append("  WebSitesLoa: ").Append(WebSitesLoa).Append("\n");
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
            return this.Equals(input as AlipayOpenAgentCommonSignRequest);
        }

        /// <summary>
        /// Returns true if AlipayOpenAgentCommonSignRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenAgentCommonSignRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenAgentCommonSignRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppAuthPic == input.AppAuthPic ||
                    (this.AppAuthPic != null &&
                    this.AppAuthPic.Equals(input.AppAuthPic))
                ) && 
                (
                    this.AppDemo == input.AppDemo ||
                    (this.AppDemo != null &&
                    this.AppDemo.Equals(input.AppDemo))
                ) && 
                (
                    this.AppHomeScreenshot == input.AppHomeScreenshot ||
                    (this.AppHomeScreenshot != null &&
                    this.AppHomeScreenshot.Equals(input.AppHomeScreenshot))
                ) && 
                (
                    this.AppItemScreenshot == input.AppItemScreenshot ||
                    (this.AppItemScreenshot != null &&
                    this.AppItemScreenshot.Equals(input.AppItemScreenshot))
                ) && 
                (
                    this.AppPayScreenshot == input.AppPayScreenshot ||
                    (this.AppPayScreenshot != null &&
                    this.AppPayScreenshot.Equals(input.AppPayScreenshot))
                ) && 
                (
                    this.BusinessLicenseAuthPic == input.BusinessLicenseAuthPic ||
                    (this.BusinessLicenseAuthPic != null &&
                    this.BusinessLicenseAuthPic.Equals(input.BusinessLicenseAuthPic))
                ) && 
                (
                    this.BusinessLicensePic == input.BusinessLicensePic ||
                    (this.BusinessLicensePic != null &&
                    this.BusinessLicensePic.Equals(input.BusinessLicensePic))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.H5ExtraPic == input.H5ExtraPic ||
                    (this.H5ExtraPic != null &&
                    this.H5ExtraPic.Equals(input.H5ExtraPic))
                ) && 
                (
                    this.H5HomeScreenshot == input.H5HomeScreenshot ||
                    (this.H5HomeScreenshot != null &&
                    this.H5HomeScreenshot.Equals(input.H5HomeScreenshot))
                ) && 
                (
                    this.H5ItemScreenshot == input.H5ItemScreenshot ||
                    (this.H5ItemScreenshot != null &&
                    this.H5ItemScreenshot.Equals(input.H5ItemScreenshot))
                ) && 
                (
                    this.H5PayScreenshot == input.H5PayScreenshot ||
                    (this.H5PayScreenshot != null &&
                    this.H5PayScreenshot.Equals(input.H5PayScreenshot))
                ) && 
                (
                    this.H5SitesLoa == input.H5SitesLoa ||
                    (this.H5SitesLoa != null &&
                    this.H5SitesLoa.Equals(input.H5SitesLoa))
                ) && 
                (
                    this.MiniAppScreenshot == input.MiniAppScreenshot ||
                    (this.MiniAppScreenshot != null &&
                    this.MiniAppScreenshot.Equals(input.MiniAppScreenshot))
                ) && 
                (
                    this.ShopScenePic == input.ShopScenePic ||
                    (this.ShopScenePic != null &&
                    this.ShopScenePic.Equals(input.ShopScenePic))
                ) && 
                (
                    this.ShopSignBoardPic == input.ShopSignBoardPic ||
                    (this.ShopSignBoardPic != null &&
                    this.ShopSignBoardPic.Equals(input.ShopSignBoardPic))
                ) && 
                (
                    this.SpecialLicensePic == input.SpecialLicensePic ||
                    (this.SpecialLicensePic != null &&
                    this.SpecialLicensePic.Equals(input.SpecialLicensePic))
                ) && 
                (
                    this.WebHomeScreenshot == input.WebHomeScreenshot ||
                    (this.WebHomeScreenshot != null &&
                    this.WebHomeScreenshot.Equals(input.WebHomeScreenshot))
                ) && 
                (
                    this.WebItemScreenshot == input.WebItemScreenshot ||
                    (this.WebItemScreenshot != null &&
                    this.WebItemScreenshot.Equals(input.WebItemScreenshot))
                ) && 
                (
                    this.WebPayScreenshot == input.WebPayScreenshot ||
                    (this.WebPayScreenshot != null &&
                    this.WebPayScreenshot.Equals(input.WebPayScreenshot))
                ) && 
                (
                    this.WebSitesLoa == input.WebSitesLoa ||
                    (this.WebSitesLoa != null &&
                    this.WebSitesLoa.Equals(input.WebSitesLoa))
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
                if (this.AppAuthPic != null)
                {
                    hashCode = (hashCode * 59) + this.AppAuthPic.GetHashCode();
                }
                if (this.AppDemo != null)
                {
                    hashCode = (hashCode * 59) + this.AppDemo.GetHashCode();
                }
                if (this.AppHomeScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.AppHomeScreenshot.GetHashCode();
                }
                if (this.AppItemScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.AppItemScreenshot.GetHashCode();
                }
                if (this.AppPayScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.AppPayScreenshot.GetHashCode();
                }
                if (this.BusinessLicenseAuthPic != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicenseAuthPic.GetHashCode();
                }
                if (this.BusinessLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicensePic.GetHashCode();
                }
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.H5ExtraPic != null)
                {
                    hashCode = (hashCode * 59) + this.H5ExtraPic.GetHashCode();
                }
                if (this.H5HomeScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.H5HomeScreenshot.GetHashCode();
                }
                if (this.H5ItemScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.H5ItemScreenshot.GetHashCode();
                }
                if (this.H5PayScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.H5PayScreenshot.GetHashCode();
                }
                if (this.H5SitesLoa != null)
                {
                    hashCode = (hashCode * 59) + this.H5SitesLoa.GetHashCode();
                }
                if (this.MiniAppScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.MiniAppScreenshot.GetHashCode();
                }
                if (this.ShopScenePic != null)
                {
                    hashCode = (hashCode * 59) + this.ShopScenePic.GetHashCode();
                }
                if (this.ShopSignBoardPic != null)
                {
                    hashCode = (hashCode * 59) + this.ShopSignBoardPic.GetHashCode();
                }
                if (this.SpecialLicensePic != null)
                {
                    hashCode = (hashCode * 59) + this.SpecialLicensePic.GetHashCode();
                }
                if (this.WebHomeScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.WebHomeScreenshot.GetHashCode();
                }
                if (this.WebItemScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.WebItemScreenshot.GetHashCode();
                }
                if (this.WebPayScreenshot != null)
                {
                    hashCode = (hashCode * 59) + this.WebPayScreenshot.GetHashCode();
                }
                if (this.WebSitesLoa != null)
                {
                    hashCode = (hashCode * 59) + this.WebSitesLoa.GetHashCode();
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
