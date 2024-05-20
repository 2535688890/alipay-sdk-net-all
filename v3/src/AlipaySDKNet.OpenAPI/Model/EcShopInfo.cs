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
    /// EcShopInfo
    /// </summary>
    [DataContract(Name = "EcShopInfo")]
    public partial class EcShopInfo : IEquatable<EcShopInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EcShopInfo" /> class.
        /// </summary>
        /// <param name="address">门店地址.</param>
        /// <param name="cityId">城市编码.</param>
        /// <param name="cityName">城市名称.</param>
        /// <param name="districtId">区编码.</param>
        /// <param name="districtName">区名称.</param>
        /// <param name="latitude">纬度.</param>
        /// <param name="longitude">经度.</param>
        /// <param name="mccCode1">一级mcc编码.</param>
        /// <param name="mccCode2">二级mcc编码.</param>
        /// <param name="mccName1">一级mcc名称.</param>
        /// <param name="mccName2">二级mcc名称.</param>
        /// <param name="outdoorImgUrl">门头照地址.</param>
        /// <param name="poiId">高德poiId.</param>
        /// <param name="provinceId">省份编码.</param>
        /// <param name="provinceName">省份名称.</param>
        /// <param name="shopName">门店名称.</param>
        public EcShopInfo(string address = default(string), string cityId = default(string), string cityName = default(string), string districtId = default(string), string districtName = default(string), string latitude = default(string), string longitude = default(string), string mccCode1 = default(string), string mccCode2 = default(string), string mccName1 = default(string), string mccName2 = default(string), string outdoorImgUrl = default(string), string poiId = default(string), string provinceId = default(string), string provinceName = default(string), string shopName = default(string))
        {
            this.Address = address;
            this.CityId = cityId;
            this.CityName = cityName;
            this.DistrictId = districtId;
            this.DistrictName = districtName;
            this.Latitude = latitude;
            this.Longitude = longitude;
            this.MccCode1 = mccCode1;
            this.MccCode2 = mccCode2;
            this.MccName1 = mccName1;
            this.MccName2 = mccName2;
            this.OutdoorImgUrl = outdoorImgUrl;
            this.PoiId = poiId;
            this.ProvinceId = provinceId;
            this.ProvinceName = provinceName;
            this.ShopName = shopName;
        }

        /// <summary>
        /// 门店地址
        /// </summary>
        /// <value>门店地址</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 城市编码
        /// </summary>
        /// <value>城市编码</value>
        [DataMember(Name = "city_id", EmitDefaultValue = false)]
        public string CityId { get; set; }

        /// <summary>
        /// 城市名称
        /// </summary>
        /// <value>城市名称</value>
        [DataMember(Name = "city_name", EmitDefaultValue = false)]
        public string CityName { get; set; }

        /// <summary>
        /// 区编码
        /// </summary>
        /// <value>区编码</value>
        [DataMember(Name = "district_id", EmitDefaultValue = false)]
        public string DistrictId { get; set; }

        /// <summary>
        /// 区名称
        /// </summary>
        /// <value>区名称</value>
        [DataMember(Name = "district_name", EmitDefaultValue = false)]
        public string DistrictName { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        /// <value>纬度</value>
        [DataMember(Name = "latitude", EmitDefaultValue = false)]
        public string Latitude { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        /// <value>经度</value>
        [DataMember(Name = "longitude", EmitDefaultValue = false)]
        public string Longitude { get; set; }

        /// <summary>
        /// 一级mcc编码
        /// </summary>
        /// <value>一级mcc编码</value>
        [DataMember(Name = "mcc_code_1", EmitDefaultValue = false)]
        public string MccCode1 { get; set; }

        /// <summary>
        /// 二级mcc编码
        /// </summary>
        /// <value>二级mcc编码</value>
        [DataMember(Name = "mcc_code_2", EmitDefaultValue = false)]
        public string MccCode2 { get; set; }

        /// <summary>
        /// 一级mcc名称
        /// </summary>
        /// <value>一级mcc名称</value>
        [DataMember(Name = "mcc_name_1", EmitDefaultValue = false)]
        public string MccName1 { get; set; }

        /// <summary>
        /// 二级mcc名称
        /// </summary>
        /// <value>二级mcc名称</value>
        [DataMember(Name = "mcc_name_2", EmitDefaultValue = false)]
        public string MccName2 { get; set; }

        /// <summary>
        /// 门头照地址
        /// </summary>
        /// <value>门头照地址</value>
        [DataMember(Name = "outdoor_img_url", EmitDefaultValue = false)]
        public string OutdoorImgUrl { get; set; }

        /// <summary>
        /// 高德poiId
        /// </summary>
        /// <value>高德poiId</value>
        [DataMember(Name = "poi_id", EmitDefaultValue = false)]
        public string PoiId { get; set; }

        /// <summary>
        /// 省份编码
        /// </summary>
        /// <value>省份编码</value>
        [DataMember(Name = "province_id", EmitDefaultValue = false)]
        public string ProvinceId { get; set; }

        /// <summary>
        /// 省份名称
        /// </summary>
        /// <value>省份名称</value>
        [DataMember(Name = "province_name", EmitDefaultValue = false)]
        public string ProvinceName { get; set; }

        /// <summary>
        /// 门店名称
        /// </summary>
        /// <value>门店名称</value>
        [DataMember(Name = "shop_name", EmitDefaultValue = false)]
        public string ShopName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EcShopInfo {\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  CityId: ").Append(CityId).Append("\n");
            sb.Append("  CityName: ").Append(CityName).Append("\n");
            sb.Append("  DistrictId: ").Append(DistrictId).Append("\n");
            sb.Append("  DistrictName: ").Append(DistrictName).Append("\n");
            sb.Append("  Latitude: ").Append(Latitude).Append("\n");
            sb.Append("  Longitude: ").Append(Longitude).Append("\n");
            sb.Append("  MccCode1: ").Append(MccCode1).Append("\n");
            sb.Append("  MccCode2: ").Append(MccCode2).Append("\n");
            sb.Append("  MccName1: ").Append(MccName1).Append("\n");
            sb.Append("  MccName2: ").Append(MccName2).Append("\n");
            sb.Append("  OutdoorImgUrl: ").Append(OutdoorImgUrl).Append("\n");
            sb.Append("  PoiId: ").Append(PoiId).Append("\n");
            sb.Append("  ProvinceId: ").Append(ProvinceId).Append("\n");
            sb.Append("  ProvinceName: ").Append(ProvinceName).Append("\n");
            sb.Append("  ShopName: ").Append(ShopName).Append("\n");
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
            return this.Equals(input as EcShopInfo);
        }

        /// <summary>
        /// Returns true if EcShopInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of EcShopInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EcShopInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.CityId == input.CityId ||
                    (this.CityId != null &&
                    this.CityId.Equals(input.CityId))
                ) && 
                (
                    this.CityName == input.CityName ||
                    (this.CityName != null &&
                    this.CityName.Equals(input.CityName))
                ) && 
                (
                    this.DistrictId == input.DistrictId ||
                    (this.DistrictId != null &&
                    this.DistrictId.Equals(input.DistrictId))
                ) && 
                (
                    this.DistrictName == input.DistrictName ||
                    (this.DistrictName != null &&
                    this.DistrictName.Equals(input.DistrictName))
                ) && 
                (
                    this.Latitude == input.Latitude ||
                    (this.Latitude != null &&
                    this.Latitude.Equals(input.Latitude))
                ) && 
                (
                    this.Longitude == input.Longitude ||
                    (this.Longitude != null &&
                    this.Longitude.Equals(input.Longitude))
                ) && 
                (
                    this.MccCode1 == input.MccCode1 ||
                    (this.MccCode1 != null &&
                    this.MccCode1.Equals(input.MccCode1))
                ) && 
                (
                    this.MccCode2 == input.MccCode2 ||
                    (this.MccCode2 != null &&
                    this.MccCode2.Equals(input.MccCode2))
                ) && 
                (
                    this.MccName1 == input.MccName1 ||
                    (this.MccName1 != null &&
                    this.MccName1.Equals(input.MccName1))
                ) && 
                (
                    this.MccName2 == input.MccName2 ||
                    (this.MccName2 != null &&
                    this.MccName2.Equals(input.MccName2))
                ) && 
                (
                    this.OutdoorImgUrl == input.OutdoorImgUrl ||
                    (this.OutdoorImgUrl != null &&
                    this.OutdoorImgUrl.Equals(input.OutdoorImgUrl))
                ) && 
                (
                    this.PoiId == input.PoiId ||
                    (this.PoiId != null &&
                    this.PoiId.Equals(input.PoiId))
                ) && 
                (
                    this.ProvinceId == input.ProvinceId ||
                    (this.ProvinceId != null &&
                    this.ProvinceId.Equals(input.ProvinceId))
                ) && 
                (
                    this.ProvinceName == input.ProvinceName ||
                    (this.ProvinceName != null &&
                    this.ProvinceName.Equals(input.ProvinceName))
                ) && 
                (
                    this.ShopName == input.ShopName ||
                    (this.ShopName != null &&
                    this.ShopName.Equals(input.ShopName))
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
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                if (this.CityId != null)
                {
                    hashCode = (hashCode * 59) + this.CityId.GetHashCode();
                }
                if (this.CityName != null)
                {
                    hashCode = (hashCode * 59) + this.CityName.GetHashCode();
                }
                if (this.DistrictId != null)
                {
                    hashCode = (hashCode * 59) + this.DistrictId.GetHashCode();
                }
                if (this.DistrictName != null)
                {
                    hashCode = (hashCode * 59) + this.DistrictName.GetHashCode();
                }
                if (this.Latitude != null)
                {
                    hashCode = (hashCode * 59) + this.Latitude.GetHashCode();
                }
                if (this.Longitude != null)
                {
                    hashCode = (hashCode * 59) + this.Longitude.GetHashCode();
                }
                if (this.MccCode1 != null)
                {
                    hashCode = (hashCode * 59) + this.MccCode1.GetHashCode();
                }
                if (this.MccCode2 != null)
                {
                    hashCode = (hashCode * 59) + this.MccCode2.GetHashCode();
                }
                if (this.MccName1 != null)
                {
                    hashCode = (hashCode * 59) + this.MccName1.GetHashCode();
                }
                if (this.MccName2 != null)
                {
                    hashCode = (hashCode * 59) + this.MccName2.GetHashCode();
                }
                if (this.OutdoorImgUrl != null)
                {
                    hashCode = (hashCode * 59) + this.OutdoorImgUrl.GetHashCode();
                }
                if (this.PoiId != null)
                {
                    hashCode = (hashCode * 59) + this.PoiId.GetHashCode();
                }
                if (this.ProvinceId != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceId.GetHashCode();
                }
                if (this.ProvinceName != null)
                {
                    hashCode = (hashCode * 59) + this.ProvinceName.GetHashCode();
                }
                if (this.ShopName != null)
                {
                    hashCode = (hashCode * 59) + this.ShopName.GetHashCode();
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
