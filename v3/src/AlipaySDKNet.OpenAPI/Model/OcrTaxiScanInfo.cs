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
    /// OcrTaxiScanInfo
    /// </summary>
    [DataContract(Name = "OcrTaxiScanInfo")]
    public partial class OcrTaxiScanInfo : IEquatable<OcrTaxiScanInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrTaxiScanInfo" /> class.
        /// </summary>
        /// <param name="getOffTime">下车时间.</param>
        /// <param name="getOnTime">上车时间.</param>
        /// <param name="invoiceCode">发票代码.</param>
        /// <param name="invoiceDate">开票时间.</param>
        /// <param name="invoiceNo">发票号码.</param>
        /// <param name="passenger">乘客人.</param>
        /// <param name="price">金额（元）.</param>
        /// <param name="travelDist">乘车距离.</param>
        public OcrTaxiScanInfo(string getOffTime = default(string), string getOnTime = default(string), string invoiceCode = default(string), string invoiceDate = default(string), string invoiceNo = default(string), string passenger = default(string), string price = default(string), string travelDist = default(string))
        {
            this.GetOffTime = getOffTime;
            this.GetOnTime = getOnTime;
            this.InvoiceCode = invoiceCode;
            this.InvoiceDate = invoiceDate;
            this.InvoiceNo = invoiceNo;
            this.Passenger = passenger;
            this.Price = price;
            this.TravelDist = travelDist;
        }

        /// <summary>
        /// 下车时间
        /// </summary>
        /// <value>下车时间</value>
        [DataMember(Name = "get_off_time", EmitDefaultValue = false)]
        public string GetOffTime { get; set; }

        /// <summary>
        /// 上车时间
        /// </summary>
        /// <value>上车时间</value>
        [DataMember(Name = "get_on_time", EmitDefaultValue = false)]
        public string GetOnTime { get; set; }

        /// <summary>
        /// 发票代码
        /// </summary>
        /// <value>发票代码</value>
        [DataMember(Name = "invoice_code", EmitDefaultValue = false)]
        public string InvoiceCode { get; set; }

        /// <summary>
        /// 开票时间
        /// </summary>
        /// <value>开票时间</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 发票号码
        /// </summary>
        /// <value>发票号码</value>
        [DataMember(Name = "invoice_no", EmitDefaultValue = false)]
        public string InvoiceNo { get; set; }

        /// <summary>
        /// 乘客人
        /// </summary>
        /// <value>乘客人</value>
        [DataMember(Name = "passenger", EmitDefaultValue = false)]
        public string Passenger { get; set; }

        /// <summary>
        /// 金额（元）
        /// </summary>
        /// <value>金额（元）</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 乘车距离
        /// </summary>
        /// <value>乘车距离</value>
        [DataMember(Name = "travel_dist", EmitDefaultValue = false)]
        public string TravelDist { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OcrTaxiScanInfo {\n");
            sb.Append("  GetOffTime: ").Append(GetOffTime).Append("\n");
            sb.Append("  GetOnTime: ").Append(GetOnTime).Append("\n");
            sb.Append("  InvoiceCode: ").Append(InvoiceCode).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  InvoiceNo: ").Append(InvoiceNo).Append("\n");
            sb.Append("  Passenger: ").Append(Passenger).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  TravelDist: ").Append(TravelDist).Append("\n");
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
            return this.Equals(input as OcrTaxiScanInfo);
        }

        /// <summary>
        /// Returns true if OcrTaxiScanInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrTaxiScanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrTaxiScanInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.GetOffTime == input.GetOffTime ||
                    (this.GetOffTime != null &&
                    this.GetOffTime.Equals(input.GetOffTime))
                ) && 
                (
                    this.GetOnTime == input.GetOnTime ||
                    (this.GetOnTime != null &&
                    this.GetOnTime.Equals(input.GetOnTime))
                ) && 
                (
                    this.InvoiceCode == input.InvoiceCode ||
                    (this.InvoiceCode != null &&
                    this.InvoiceCode.Equals(input.InvoiceCode))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.InvoiceNo == input.InvoiceNo ||
                    (this.InvoiceNo != null &&
                    this.InvoiceNo.Equals(input.InvoiceNo))
                ) && 
                (
                    this.Passenger == input.Passenger ||
                    (this.Passenger != null &&
                    this.Passenger.Equals(input.Passenger))
                ) && 
                (
                    this.Price == input.Price ||
                    (this.Price != null &&
                    this.Price.Equals(input.Price))
                ) && 
                (
                    this.TravelDist == input.TravelDist ||
                    (this.TravelDist != null &&
                    this.TravelDist.Equals(input.TravelDist))
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
                if (this.GetOffTime != null)
                {
                    hashCode = (hashCode * 59) + this.GetOffTime.GetHashCode();
                }
                if (this.GetOnTime != null)
                {
                    hashCode = (hashCode * 59) + this.GetOnTime.GetHashCode();
                }
                if (this.InvoiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceCode.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.InvoiceNo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceNo.GetHashCode();
                }
                if (this.Passenger != null)
                {
                    hashCode = (hashCode * 59) + this.Passenger.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.TravelDist != null)
                {
                    hashCode = (hashCode * 59) + this.TravelDist.GetHashCode();
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
