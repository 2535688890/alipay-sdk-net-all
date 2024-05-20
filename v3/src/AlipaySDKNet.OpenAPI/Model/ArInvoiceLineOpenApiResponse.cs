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
    /// ArInvoiceLineOpenApiResponse
    /// </summary>
    [DataContract(Name = "ArInvoiceLineOpenApiResponse")]
    public partial class ArInvoiceLineOpenApiResponse : IEquatable<ArInvoiceLineOpenApiResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArInvoiceLineOpenApiResponse" /> class.
        /// </summary>
        /// <param name="amt">amt.</param>
        /// <param name="dutyFreeFlag">免税标识.</param>
        /// <param name="inclTaxUnitAmt">含税单价.</param>
        /// <param name="invoiceId">关联的发票ID.</param>
        /// <param name="invoiceLineId">发票行iD.</param>
        /// <param name="measurementUnit">计量单位.</param>
        /// <param name="productName">货物或劳务名称.</param>
        /// <param name="productSpecification">规格型号.</param>
        /// <param name="quantity">数量.</param>
        /// <param name="taxAmt">taxAmt.</param>
        /// <param name="taxExclusiveAmt">taxExclusiveAmt.</param>
        /// <param name="taxRate">税率.</param>
        /// <param name="unitAmt">单价.</param>
        public ArInvoiceLineOpenApiResponse(MultiCurrencyMoneyOpenApi amt = default(MultiCurrencyMoneyOpenApi), string dutyFreeFlag = default(string), int inclTaxUnitAmt = default(int), string invoiceId = default(string), string invoiceLineId = default(string), string measurementUnit = default(string), string productName = default(string), string productSpecification = default(string), int quantity = default(int), MultiCurrencyMoneyOpenApi taxAmt = default(MultiCurrencyMoneyOpenApi), MultiCurrencyMoneyOpenApi taxExclusiveAmt = default(MultiCurrencyMoneyOpenApi), int taxRate = default(int), int unitAmt = default(int))
        {
            this.Amt = amt;
            this.DutyFreeFlag = dutyFreeFlag;
            this.InclTaxUnitAmt = inclTaxUnitAmt;
            this.InvoiceId = invoiceId;
            this.InvoiceLineId = invoiceLineId;
            this.MeasurementUnit = measurementUnit;
            this.ProductName = productName;
            this.ProductSpecification = productSpecification;
            this.Quantity = quantity;
            this.TaxAmt = taxAmt;
            this.TaxExclusiveAmt = taxExclusiveAmt;
            this.TaxRate = taxRate;
            this.UnitAmt = unitAmt;
        }

        /// <summary>
        /// Gets or Sets Amt
        /// </summary>
        [DataMember(Name = "amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi Amt { get; set; }

        /// <summary>
        /// 免税标识
        /// </summary>
        /// <value>免税标识</value>
        [DataMember(Name = "duty_free_flag", EmitDefaultValue = false)]
        public string DutyFreeFlag { get; set; }

        /// <summary>
        /// 含税单价
        /// </summary>
        /// <value>含税单价</value>
        [DataMember(Name = "incl_tax_unit_amt", EmitDefaultValue = false)]
        public int InclTaxUnitAmt { get; set; }

        /// <summary>
        /// 关联的发票ID
        /// </summary>
        /// <value>关联的发票ID</value>
        [DataMember(Name = "invoice_id", EmitDefaultValue = false)]
        public string InvoiceId { get; set; }

        /// <summary>
        /// 发票行iD
        /// </summary>
        /// <value>发票行iD</value>
        [DataMember(Name = "invoice_line_id", EmitDefaultValue = false)]
        public string InvoiceLineId { get; set; }

        /// <summary>
        /// 计量单位
        /// </summary>
        /// <value>计量单位</value>
        [DataMember(Name = "measurement_unit", EmitDefaultValue = false)]
        public string MeasurementUnit { get; set; }

        /// <summary>
        /// 货物或劳务名称
        /// </summary>
        /// <value>货物或劳务名称</value>
        [DataMember(Name = "product_name", EmitDefaultValue = false)]
        public string ProductName { get; set; }

        /// <summary>
        /// 规格型号
        /// </summary>
        /// <value>规格型号</value>
        [DataMember(Name = "product_specification", EmitDefaultValue = false)]
        public string ProductSpecification { get; set; }

        /// <summary>
        /// 数量
        /// </summary>
        /// <value>数量</value>
        [DataMember(Name = "quantity", EmitDefaultValue = false)]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or Sets TaxAmt
        /// </summary>
        [DataMember(Name = "tax_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi TaxAmt { get; set; }

        /// <summary>
        /// Gets or Sets TaxExclusiveAmt
        /// </summary>
        [DataMember(Name = "tax_exclusive_amt", EmitDefaultValue = false)]
        public MultiCurrencyMoneyOpenApi TaxExclusiveAmt { get; set; }

        /// <summary>
        /// 税率
        /// </summary>
        /// <value>税率</value>
        [DataMember(Name = "tax_rate", EmitDefaultValue = false)]
        public int TaxRate { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        /// <value>单价</value>
        [DataMember(Name = "unit_amt", EmitDefaultValue = false)]
        public int UnitAmt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArInvoiceLineOpenApiResponse {\n");
            sb.Append("  Amt: ").Append(Amt).Append("\n");
            sb.Append("  DutyFreeFlag: ").Append(DutyFreeFlag).Append("\n");
            sb.Append("  InclTaxUnitAmt: ").Append(InclTaxUnitAmt).Append("\n");
            sb.Append("  InvoiceId: ").Append(InvoiceId).Append("\n");
            sb.Append("  InvoiceLineId: ").Append(InvoiceLineId).Append("\n");
            sb.Append("  MeasurementUnit: ").Append(MeasurementUnit).Append("\n");
            sb.Append("  ProductName: ").Append(ProductName).Append("\n");
            sb.Append("  ProductSpecification: ").Append(ProductSpecification).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TaxAmt: ").Append(TaxAmt).Append("\n");
            sb.Append("  TaxExclusiveAmt: ").Append(TaxExclusiveAmt).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  UnitAmt: ").Append(UnitAmt).Append("\n");
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
            return this.Equals(input as ArInvoiceLineOpenApiResponse);
        }

        /// <summary>
        /// Returns true if ArInvoiceLineOpenApiResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of ArInvoiceLineOpenApiResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArInvoiceLineOpenApiResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amt == input.Amt ||
                    (this.Amt != null &&
                    this.Amt.Equals(input.Amt))
                ) && 
                (
                    this.DutyFreeFlag == input.DutyFreeFlag ||
                    (this.DutyFreeFlag != null &&
                    this.DutyFreeFlag.Equals(input.DutyFreeFlag))
                ) && 
                (
                    this.InclTaxUnitAmt == input.InclTaxUnitAmt ||
                    this.InclTaxUnitAmt.Equals(input.InclTaxUnitAmt)
                ) && 
                (
                    this.InvoiceId == input.InvoiceId ||
                    (this.InvoiceId != null &&
                    this.InvoiceId.Equals(input.InvoiceId))
                ) && 
                (
                    this.InvoiceLineId == input.InvoiceLineId ||
                    (this.InvoiceLineId != null &&
                    this.InvoiceLineId.Equals(input.InvoiceLineId))
                ) && 
                (
                    this.MeasurementUnit == input.MeasurementUnit ||
                    (this.MeasurementUnit != null &&
                    this.MeasurementUnit.Equals(input.MeasurementUnit))
                ) && 
                (
                    this.ProductName == input.ProductName ||
                    (this.ProductName != null &&
                    this.ProductName.Equals(input.ProductName))
                ) && 
                (
                    this.ProductSpecification == input.ProductSpecification ||
                    (this.ProductSpecification != null &&
                    this.ProductSpecification.Equals(input.ProductSpecification))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    this.Quantity.Equals(input.Quantity)
                ) && 
                (
                    this.TaxAmt == input.TaxAmt ||
                    (this.TaxAmt != null &&
                    this.TaxAmt.Equals(input.TaxAmt))
                ) && 
                (
                    this.TaxExclusiveAmt == input.TaxExclusiveAmt ||
                    (this.TaxExclusiveAmt != null &&
                    this.TaxExclusiveAmt.Equals(input.TaxExclusiveAmt))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    this.TaxRate.Equals(input.TaxRate)
                ) && 
                (
                    this.UnitAmt == input.UnitAmt ||
                    this.UnitAmt.Equals(input.UnitAmt)
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
                if (this.Amt != null)
                {
                    hashCode = (hashCode * 59) + this.Amt.GetHashCode();
                }
                if (this.DutyFreeFlag != null)
                {
                    hashCode = (hashCode * 59) + this.DutyFreeFlag.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InclTaxUnitAmt.GetHashCode();
                if (this.InvoiceId != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceId.GetHashCode();
                }
                if (this.InvoiceLineId != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceLineId.GetHashCode();
                }
                if (this.MeasurementUnit != null)
                {
                    hashCode = (hashCode * 59) + this.MeasurementUnit.GetHashCode();
                }
                if (this.ProductName != null)
                {
                    hashCode = (hashCode * 59) + this.ProductName.GetHashCode();
                }
                if (this.ProductSpecification != null)
                {
                    hashCode = (hashCode * 59) + this.ProductSpecification.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Quantity.GetHashCode();
                if (this.TaxAmt != null)
                {
                    hashCode = (hashCode * 59) + this.TaxAmt.GetHashCode();
                }
                if (this.TaxExclusiveAmt != null)
                {
                    hashCode = (hashCode * 59) + this.TaxExclusiveAmt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TaxRate.GetHashCode();
                hashCode = (hashCode * 59) + this.UnitAmt.GetHashCode();
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
