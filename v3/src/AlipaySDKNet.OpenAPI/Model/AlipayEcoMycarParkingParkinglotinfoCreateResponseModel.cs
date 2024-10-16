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
    /// AlipayEcoMycarParkingParkinglotinfoCreateResponseModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingParkinglotinfoCreateResponseModel")]
    public partial class AlipayEcoMycarParkingParkinglotinfoCreateResponseModel : IEquatable<AlipayEcoMycarParkingParkinglotinfoCreateResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingParkinglotinfoCreateResponseModel" /> class.
        /// </summary>
        /// <param name="parkingId">支付宝返回停车场id。成功不为空，失败返回空.</param>
        public AlipayEcoMycarParkingParkinglotinfoCreateResponseModel(string parkingId = default(string))
        {
            this.ParkingId = parkingId;
        }

        /// <summary>
        /// 支付宝返回停车场id。成功不为空，失败返回空
        /// </summary>
        /// <value>支付宝返回停车场id。成功不为空，失败返回空</value>
        [DataMember(Name = "parking_id", EmitDefaultValue = false)]
        public string ParkingId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingParkinglotinfoCreateResponseModel {\n");
            sb.Append("  ParkingId: ").Append(ParkingId).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingParkinglotinfoCreateResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingParkinglotinfoCreateResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingParkinglotinfoCreateResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingParkinglotinfoCreateResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ParkingId == input.ParkingId ||
                    (this.ParkingId != null &&
                    this.ParkingId.Equals(input.ParkingId))
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
                if (this.ParkingId != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingId.GetHashCode();
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
