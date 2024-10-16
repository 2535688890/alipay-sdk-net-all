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
    /// AlipayCommerceEducateCampusInstitutionsQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceEducateCampusInstitutionsQueryResponseModel")]
    public partial class AlipayCommerceEducateCampusInstitutionsQueryResponseModel : IEquatable<AlipayCommerceEducateCampusInstitutionsQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceEducateCampusInstitutionsQueryResponseModel" /> class.
        /// </summary>
        /// <param name="schoolInfo">schoolInfo.</param>
        /// <param name="schoolInfoList">学校基础信息列表.</param>
        public AlipayCommerceEducateCampusInstitutionsQueryResponseModel(SchoolSimpleInfo schoolInfo = default(SchoolSimpleInfo), List<SchoolBaseInfo> schoolInfoList = default(List<SchoolBaseInfo>))
        {
            this.SchoolInfo = schoolInfo;
            this.SchoolInfoList = schoolInfoList;
        }

        /// <summary>
        /// Gets or Sets SchoolInfo
        /// </summary>
        [DataMember(Name = "school_info", EmitDefaultValue = false)]
        public SchoolSimpleInfo SchoolInfo { get; set; }

        /// <summary>
        /// 学校基础信息列表
        /// </summary>
        /// <value>学校基础信息列表</value>
        [DataMember(Name = "school_info_list", EmitDefaultValue = false)]
        public List<SchoolBaseInfo> SchoolInfoList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceEducateCampusInstitutionsQueryResponseModel {\n");
            sb.Append("  SchoolInfo: ").Append(SchoolInfo).Append("\n");
            sb.Append("  SchoolInfoList: ").Append(SchoolInfoList).Append("\n");
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
            return this.Equals(input as AlipayCommerceEducateCampusInstitutionsQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceEducateCampusInstitutionsQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceEducateCampusInstitutionsQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceEducateCampusInstitutionsQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SchoolInfo == input.SchoolInfo ||
                    (this.SchoolInfo != null &&
                    this.SchoolInfo.Equals(input.SchoolInfo))
                ) && 
                (
                    this.SchoolInfoList == input.SchoolInfoList ||
                    this.SchoolInfoList != null &&
                    input.SchoolInfoList != null &&
                    this.SchoolInfoList.SequenceEqual(input.SchoolInfoList)
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
                if (this.SchoolInfo != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolInfo.GetHashCode();
                }
                if (this.SchoolInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.SchoolInfoList.GetHashCode();
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
