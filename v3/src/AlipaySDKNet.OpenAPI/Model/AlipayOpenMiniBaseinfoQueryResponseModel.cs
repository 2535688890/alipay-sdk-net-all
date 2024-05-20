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
    /// AlipayOpenMiniBaseinfoQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayOpenMiniBaseinfoQueryResponseModel")]
    public partial class AlipayOpenMiniBaseinfoQueryResponseModel : IEquatable<AlipayOpenMiniBaseinfoQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayOpenMiniBaseinfoQueryResponseModel" /> class.
        /// </summary>
        /// <param name="appDesc">小程序应用描述.</param>
        /// <param name="appEnglishName">小程序应用英文名称.</param>
        /// <param name="appLogo">小程序应用logo图标.</param>
        /// <param name="appName">小程序应用名称.</param>
        /// <param name="appSlogan">小程序应用简介，一句话描述小程序功能.</param>
        /// <param name="categoryNames">类目名称，格式为第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目;.</param>
        /// <param name="packageNames">功能包名称.</param>
        /// <param name="safeDomains">域白名单.</param>
        /// <param name="serviceEmail">小程序客服邮箱.</param>
        /// <param name="servicePhone">小程序客服电话.</param>
        public AlipayOpenMiniBaseinfoQueryResponseModel(string appDesc = default(string), string appEnglishName = default(string), string appLogo = default(string), string appName = default(string), string appSlogan = default(string), string categoryNames = default(string), List<string> packageNames = default(List<string>), List<string> safeDomains = default(List<string>), string serviceEmail = default(string), string servicePhone = default(string))
        {
            this.AppDesc = appDesc;
            this.AppEnglishName = appEnglishName;
            this.AppLogo = appLogo;
            this.AppName = appName;
            this.AppSlogan = appSlogan;
            this.CategoryNames = categoryNames;
            this.PackageNames = packageNames;
            this.SafeDomains = safeDomains;
            this.ServiceEmail = serviceEmail;
            this.ServicePhone = servicePhone;
        }

        /// <summary>
        /// 小程序应用描述
        /// </summary>
        /// <value>小程序应用描述</value>
        [DataMember(Name = "app_desc", EmitDefaultValue = false)]
        public string AppDesc { get; set; }

        /// <summary>
        /// 小程序应用英文名称
        /// </summary>
        /// <value>小程序应用英文名称</value>
        [DataMember(Name = "app_english_name", EmitDefaultValue = false)]
        public string AppEnglishName { get; set; }

        /// <summary>
        /// 小程序应用logo图标
        /// </summary>
        /// <value>小程序应用logo图标</value>
        [DataMember(Name = "app_logo", EmitDefaultValue = false)]
        public string AppLogo { get; set; }

        /// <summary>
        /// 小程序应用名称
        /// </summary>
        /// <value>小程序应用名称</value>
        [DataMember(Name = "app_name", EmitDefaultValue = false)]
        public string AppName { get; set; }

        /// <summary>
        /// 小程序应用简介，一句话描述小程序功能
        /// </summary>
        /// <value>小程序应用简介，一句话描述小程序功能</value>
        [DataMember(Name = "app_slogan", EmitDefaultValue = false)]
        public string AppSlogan { get; set; }

        /// <summary>
        /// 类目名称，格式为第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目;
        /// </summary>
        /// <value>类目名称，格式为第一个一级类目_第一个二级类目;第二个一级类目_第二个二级类目;</value>
        [DataMember(Name = "category_names", EmitDefaultValue = false)]
        public string CategoryNames { get; set; }

        /// <summary>
        /// 功能包名称
        /// </summary>
        /// <value>功能包名称</value>
        [DataMember(Name = "package_names", EmitDefaultValue = false)]
        public List<string> PackageNames { get; set; }

        /// <summary>
        /// 域白名单
        /// </summary>
        /// <value>域白名单</value>
        [DataMember(Name = "safe_domains", EmitDefaultValue = false)]
        public List<string> SafeDomains { get; set; }

        /// <summary>
        /// 小程序客服邮箱
        /// </summary>
        /// <value>小程序客服邮箱</value>
        [DataMember(Name = "service_email", EmitDefaultValue = false)]
        public string ServiceEmail { get; set; }

        /// <summary>
        /// 小程序客服电话
        /// </summary>
        /// <value>小程序客服电话</value>
        [DataMember(Name = "service_phone", EmitDefaultValue = false)]
        public string ServicePhone { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayOpenMiniBaseinfoQueryResponseModel {\n");
            sb.Append("  AppDesc: ").Append(AppDesc).Append("\n");
            sb.Append("  AppEnglishName: ").Append(AppEnglishName).Append("\n");
            sb.Append("  AppLogo: ").Append(AppLogo).Append("\n");
            sb.Append("  AppName: ").Append(AppName).Append("\n");
            sb.Append("  AppSlogan: ").Append(AppSlogan).Append("\n");
            sb.Append("  CategoryNames: ").Append(CategoryNames).Append("\n");
            sb.Append("  PackageNames: ").Append(PackageNames).Append("\n");
            sb.Append("  SafeDomains: ").Append(SafeDomains).Append("\n");
            sb.Append("  ServiceEmail: ").Append(ServiceEmail).Append("\n");
            sb.Append("  ServicePhone: ").Append(ServicePhone).Append("\n");
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
            return this.Equals(input as AlipayOpenMiniBaseinfoQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayOpenMiniBaseinfoQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayOpenMiniBaseinfoQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayOpenMiniBaseinfoQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AppDesc == input.AppDesc ||
                    (this.AppDesc != null &&
                    this.AppDesc.Equals(input.AppDesc))
                ) && 
                (
                    this.AppEnglishName == input.AppEnglishName ||
                    (this.AppEnglishName != null &&
                    this.AppEnglishName.Equals(input.AppEnglishName))
                ) && 
                (
                    this.AppLogo == input.AppLogo ||
                    (this.AppLogo != null &&
                    this.AppLogo.Equals(input.AppLogo))
                ) && 
                (
                    this.AppName == input.AppName ||
                    (this.AppName != null &&
                    this.AppName.Equals(input.AppName))
                ) && 
                (
                    this.AppSlogan == input.AppSlogan ||
                    (this.AppSlogan != null &&
                    this.AppSlogan.Equals(input.AppSlogan))
                ) && 
                (
                    this.CategoryNames == input.CategoryNames ||
                    (this.CategoryNames != null &&
                    this.CategoryNames.Equals(input.CategoryNames))
                ) && 
                (
                    this.PackageNames == input.PackageNames ||
                    this.PackageNames != null &&
                    input.PackageNames != null &&
                    this.PackageNames.SequenceEqual(input.PackageNames)
                ) && 
                (
                    this.SafeDomains == input.SafeDomains ||
                    this.SafeDomains != null &&
                    input.SafeDomains != null &&
                    this.SafeDomains.SequenceEqual(input.SafeDomains)
                ) && 
                (
                    this.ServiceEmail == input.ServiceEmail ||
                    (this.ServiceEmail != null &&
                    this.ServiceEmail.Equals(input.ServiceEmail))
                ) && 
                (
                    this.ServicePhone == input.ServicePhone ||
                    (this.ServicePhone != null &&
                    this.ServicePhone.Equals(input.ServicePhone))
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
                if (this.AppDesc != null)
                {
                    hashCode = (hashCode * 59) + this.AppDesc.GetHashCode();
                }
                if (this.AppEnglishName != null)
                {
                    hashCode = (hashCode * 59) + this.AppEnglishName.GetHashCode();
                }
                if (this.AppLogo != null)
                {
                    hashCode = (hashCode * 59) + this.AppLogo.GetHashCode();
                }
                if (this.AppName != null)
                {
                    hashCode = (hashCode * 59) + this.AppName.GetHashCode();
                }
                if (this.AppSlogan != null)
                {
                    hashCode = (hashCode * 59) + this.AppSlogan.GetHashCode();
                }
                if (this.CategoryNames != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryNames.GetHashCode();
                }
                if (this.PackageNames != null)
                {
                    hashCode = (hashCode * 59) + this.PackageNames.GetHashCode();
                }
                if (this.SafeDomains != null)
                {
                    hashCode = (hashCode * 59) + this.SafeDomains.GetHashCode();
                }
                if (this.ServiceEmail != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceEmail.GetHashCode();
                }
                if (this.ServicePhone != null)
                {
                    hashCode = (hashCode * 59) + this.ServicePhone.GetHashCode();
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
