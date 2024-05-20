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
    /// SchoolSimpleInfo
    /// </summary>
    [DataContract(Name = "SchoolSimpleInfo")]
    public partial class SchoolSimpleInfo : IEquatable<SchoolSimpleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SchoolSimpleInfo" /> class.
        /// </summary>
        /// <param name="campusInfo">campusInfo.</param>
        /// <param name="cityCode">城市编码.</param>
        /// <param name="instId">学校内标.</param>
        /// <param name="instName">学校名称.</param>
        /// <param name="instStdCode">学校外标.</param>
        /// <param name="provinceCode">省份编码.</param>
        public SchoolSimpleInfo(CampusInfo campusInfo = default(CampusInfo), string cityCode = default(string), string instId = default(string), string instName = default(string), string instStdCode = default(string), string provinceCode = default(string))
        {
            this.CampusInfo = campusInfo;
            this.CityCode = cityCode;
            this.InstId = instId;
            this.InstName = instName;
            this.InstStdCode = instStdCode;
            this.ProvinceCode = provinceCode;
        }

        /// <summary>
        /// Gets or Sets CampusInfo
        /// </summary>
        [DataMember(Name = "campus_info", EmitDefaultValue = false)]
        public CampusInfo CampusInfo { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        /// <value>城市编码</value>
        [DataMember(Name = "city_code", EmitDefaultValue = false)]
        public string CityCode { get; set; }

        /// <summary>
        /// 学校内标
        /// </summary>
        /// <value>学校内标</value>
        [DataMember(Name = "inst_id", EmitDefaultValue = false)]
        public string InstId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        /// <value>学校名称</value>
        [DataMember(Name = "inst_name", EmitDefaultValue = false)]
        public string InstName { get; set; }

        /// <summary>
        /// 学校外标
        /// </summary>
        /// <value>学校外标</value>
        [DataMember(Name = "inst_std_code", EmitDefaultValue = false)]
        public string InstStdCode { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        /// <value>省份编码</value>
        [DataMember(Name = "province_code", EmitDefaultValue = false)]
        public string ProvinceCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SchoolSimpleInfo {\n");
            sb.Append("  CampusInfo: ").Append(CampusInfo).Append("\n");
            sb.Append("  CityCode: ").Append(CityCode).Append("\n");
            sb.Append("  InstId: ").Append(InstId).Append("\n");
            sb.Append("  InstName: ").Append(InstName).Append("\n");
            sb.Append("  InstStdCode: ").Append(InstStdCode).Append("\n");
            sb.Append("  ProvinceCode: ").Append(ProvinceCode).Append("\n");
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
            return this.Equals(input as SchoolSimpleInfo);
        }

        /// <summary>
        /// Returns true if SchoolSimpleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of SchoolSimpleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SchoolSimpleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CampusInfo == input.CampusInfo ||
                    (this.CampusInfo != null &&
                    this.CampusInfo.Equals(input.CampusInfo))
                ) && 
                (
                    this.CityCode == input.CityCode ||
                    (this.CityCode != null &&
                    this.CityCode.Equals(input.CityCode))
                ) && 
                (
                    this.InstId == input.InstId ||
                    (this.InstId != null &&
                    this.InstId.Equals(input.InstId))
                ) && 
                (
                    this.InstName == input.InstName ||
                    (this.InstName != null &&
                    this.InstName.Equals(input.InstName))
                ) && 
                (
                    this.InstStdCode == input.InstStdCode ||
                    (this.InstStdCode != null &&
                    this.InstStdCode.Equals(input.InstStdCode))
                ) && 
                (
                    this.ProvinceCode == input.ProvinceCode ||
                    (this.ProvinceCode != null &&
                    this.ProvinceCode.Equals(input.ProvinceCode))
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
                if (this.CampusInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CampusInfo.GetHashCode();
                }
                if (this.CityCode != null)
                {
                    hashCode = (hashCode * 59) + this.CityCode.GetHashCode();
                }
                if (this.InstId != null)
                {
                    hashCode = (hashCode * 59) + this.InstId.GetHashCode();
                }
                if (this.InstName != null)
                {
                    hashCode = (hashCode * 59) + this.InstName.GetHashCode();
                }
                if (this.InstStdCode != null)
                {
                    hashCode = (hashCode * 59) + this.InstStdCode.GetHashCode();
                }
                if (this.ProvinceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceCode.GetHashCode();
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
