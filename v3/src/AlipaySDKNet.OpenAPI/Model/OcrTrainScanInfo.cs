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
    /// OcrTrainScanInfo
    /// </summary>
    [DataContract(Name = "OcrTrainScanInfo")]
    public partial class OcrTrainScanInfo : IEquatable<OcrTrainScanInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OcrTrainScanInfo" /> class.
        /// </summary>
        /// <param name="destination">目的地.</param>
        /// <param name="invoiceDate">乘车日期.</param>
        /// <param name="origin">出发地.</param>
        /// <param name="passenger">乘客.</param>
        /// <param name="price">金额（元）.</param>
        /// <param name="remark">明细事由.</param>
        /// <param name="seatClass">座次.</param>
        /// <param name="trainNo">车次.</param>
        public OcrTrainScanInfo(string destination = default(string), string invoiceDate = default(string), string origin = default(string), string passenger = default(string), string price = default(string), string remark = default(string), string seatClass = default(string), string trainNo = default(string))
        {
            this.Destination = destination;
            this.InvoiceDate = invoiceDate;
            this.Origin = origin;
            this.Passenger = passenger;
            this.Price = price;
            this.Remark = remark;
            this.SeatClass = seatClass;
            this.TrainNo = trainNo;
        }

        /// <summary>
        /// 目的地
        /// </summary>
        /// <value>目的地</value>
        [DataMember(Name = "destination", EmitDefaultValue = false)]
        public string Destination { get; set; }

        /// <summary>
        /// 乘车日期
        /// </summary>
        /// <value>乘车日期</value>
        [DataMember(Name = "invoice_date", EmitDefaultValue = false)]
        public string InvoiceDate { get; set; }

        /// <summary>
        /// 出发地
        /// </summary>
        /// <value>出发地</value>
        [DataMember(Name = "origin", EmitDefaultValue = false)]
        public string Origin { get; set; }

        /// <summary>
        /// 乘客
        /// </summary>
        /// <value>乘客</value>
        [DataMember(Name = "passenger", EmitDefaultValue = false)]
        public string Passenger { get; set; }

        /// <summary>
        /// 金额（元）
        /// </summary>
        /// <value>金额（元）</value>
        [DataMember(Name = "price", EmitDefaultValue = false)]
        public string Price { get; set; }

        /// <summary>
        /// 明细事由
        /// </summary>
        /// <value>明细事由</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string Remark { get; set; }

        /// <summary>
        /// 座次
        /// </summary>
        /// <value>座次</value>
        [DataMember(Name = "seat_class", EmitDefaultValue = false)]
        public string SeatClass { get; set; }

        /// <summary>
        /// 车次
        /// </summary>
        /// <value>车次</value>
        [DataMember(Name = "train_no", EmitDefaultValue = false)]
        public string TrainNo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OcrTrainScanInfo {\n");
            sb.Append("  Destination: ").Append(Destination).Append("\n");
            sb.Append("  InvoiceDate: ").Append(InvoiceDate).Append("\n");
            sb.Append("  Origin: ").Append(Origin).Append("\n");
            sb.Append("  Passenger: ").Append(Passenger).Append("\n");
            sb.Append("  Price: ").Append(Price).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
            sb.Append("  SeatClass: ").Append(SeatClass).Append("\n");
            sb.Append("  TrainNo: ").Append(TrainNo).Append("\n");
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
            return this.Equals(input as OcrTrainScanInfo);
        }

        /// <summary>
        /// Returns true if OcrTrainScanInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of OcrTrainScanInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OcrTrainScanInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Destination == input.Destination ||
                    (this.Destination != null &&
                    this.Destination.Equals(input.Destination))
                ) && 
                (
                    this.InvoiceDate == input.InvoiceDate ||
                    (this.InvoiceDate != null &&
                    this.InvoiceDate.Equals(input.InvoiceDate))
                ) && 
                (
                    this.Origin == input.Origin ||
                    (this.Origin != null &&
                    this.Origin.Equals(input.Origin))
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
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
                ) && 
                (
                    this.SeatClass == input.SeatClass ||
                    (this.SeatClass != null &&
                    this.SeatClass.Equals(input.SeatClass))
                ) && 
                (
                    this.TrainNo == input.TrainNo ||
                    (this.TrainNo != null &&
                    this.TrainNo.Equals(input.TrainNo))
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
                if (this.Destination != null)
                {
                    hashCode = (hashCode * 59) + this.Destination.GetHashCode();
                }
                if (this.InvoiceDate != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceDate.GetHashCode();
                }
                if (this.Origin != null)
                {
                    hashCode = (hashCode * 59) + this.Origin.GetHashCode();
                }
                if (this.Passenger != null)
                {
                    hashCode = (hashCode * 59) + this.Passenger.GetHashCode();
                }
                if (this.Price != null)
                {
                    hashCode = (hashCode * 59) + this.Price.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
                }
                if (this.SeatClass != null)
                {
                    hashCode = (hashCode * 59) + this.SeatClass.GetHashCode();
                }
                if (this.TrainNo != null)
                {
                    hashCode = (hashCode * 59) + this.TrainNo.GetHashCode();
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
