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
    /// OrderVoucherAvailableCityCode
    /// </summary>
    [DataContract(Name = "OrderVoucherAvailableCityCode")]
    public partial class OrderVoucherAvailableCityCode : IEquatable<OrderVoucherAvailableCityCode>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderVoucherAvailableCityCode" /> class.
        /// </summary>
        /// <param name="allCity">是否全国。选择全国后，无须填写city_codes字段。系统默认填充全国全部城市信息。.</param>
        /// <param name="cityCodes">城市编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot; target&#x3D;\&quot;_blank\&quot;&gt;表格&lt;/a&gt;中内容填写。 （&lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot; target&#x3D;\&quot;_blank\&quot;&gt;参考资料&lt;/a&gt;）.</param>
        public OrderVoucherAvailableCityCode(bool allCity = default(bool), List<string> cityCodes = default(List<string>))
        {
            this.AllCity = allCity;
            this.CityCodes = cityCodes;
        }

        /// <summary>
        /// 是否全国。选择全国后，无须填写city_codes字段。系统默认填充全国全部城市信息。
        /// </summary>
        /// <value>是否全国。选择全国后，无须填写city_codes字段。系统默认填充全国全部城市信息。</value>
        [DataMember(Name = "all_city", EmitDefaultValue = true)]
        public bool AllCity { get; set; }

        /// <summary>
        /// 城市编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot; target&#x3D;\&quot;_blank\&quot;&gt;表格&lt;/a&gt;中内容填写。 （&lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot; target&#x3D;\&quot;_blank\&quot;&gt;参考资料&lt;/a&gt;）
        /// </summary>
        /// <value>城市编码。请按照&lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/basement_prod/253c4dcb-b8a4-4a1e-8be2-79e191a9b6db.xlsx\&quot; target&#x3D;\&quot;_blank\&quot;&gt;表格&lt;/a&gt;中内容填写。 （&lt;a href&#x3D;\&quot;http://www.stats.gov.cn/tjsj/tjbz/tjyqhdmhcxhfdm/\&quot; target&#x3D;\&quot;_blank\&quot;&gt;参考资料&lt;/a&gt;）</value>
        [DataMember(Name = "city_codes", EmitDefaultValue = false)]
        public List<string> CityCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderVoucherAvailableCityCode {\n");
            sb.Append("  AllCity: ").Append(AllCity).Append("\n");
            sb.Append("  CityCodes: ").Append(CityCodes).Append("\n");
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
            return this.Equals(input as OrderVoucherAvailableCityCode);
        }

        /// <summary>
        /// Returns true if OrderVoucherAvailableCityCode instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderVoucherAvailableCityCode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderVoucherAvailableCityCode input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AllCity == input.AllCity ||
                    this.AllCity.Equals(input.AllCity)
                ) && 
                (
                    this.CityCodes == input.CityCodes ||
                    this.CityCodes != null &&
                    input.CityCodes != null &&
                    this.CityCodes.SequenceEqual(input.CityCodes)
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
                hashCode = (hashCode * 59) + this.AllCity.GetHashCode();
                if (this.CityCodes != null)
                {
                    hashCode = (hashCode * 59) + this.CityCodes.GetHashCode();
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
