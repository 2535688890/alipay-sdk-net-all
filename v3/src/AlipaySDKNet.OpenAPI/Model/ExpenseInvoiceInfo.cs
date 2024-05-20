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
    /// ExpenseInvoiceInfo
    /// </summary>
    [DataContract(Name = "ExpenseInvoiceInfo")]
    public partial class ExpenseInvoiceInfo : IEquatable<ExpenseInvoiceInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseInvoiceInfo" /> class.
        /// </summary>
        /// <param name="employeeId">员工ID.</param>
        /// <param name="employeeOpenId">员工ID.</param>
        /// <param name="invoiceOutputInfo">invoiceOutputInfo.</param>
        /// <param name="ocrNormalScanInfo">ocrNormalScanInfo.</param>
        /// <param name="ocrPlaneScanInfo">ocrPlaneScanInfo.</param>
        /// <param name="ocrTaxiScanInfo">ocrTaxiScanInfo.</param>
        /// <param name="ocrTrainScanInfo">ocrTrainScanInfo.</param>
        /// <param name="voucherFileInfo">voucherFileInfo.</param>
        /// <param name="voucherId">凭证ID.</param>
        public ExpenseInvoiceInfo(string employeeId = default(string), string employeeOpenId = default(string), InvoiceOutputInfo invoiceOutputInfo = default(InvoiceOutputInfo), OcrNormalScanInfo ocrNormalScanInfo = default(OcrNormalScanInfo), OcrPlaneScanInfo ocrPlaneScanInfo = default(OcrPlaneScanInfo), OcrTaxiScanInfo ocrTaxiScanInfo = default(OcrTaxiScanInfo), OcrTrainScanInfo ocrTrainScanInfo = default(OcrTrainScanInfo), VoucherFileInfo voucherFileInfo = default(VoucherFileInfo), string voucherId = default(string))
        {
            this.EmployeeId = employeeId;
            this.EmployeeOpenId = employeeOpenId;
            this.InvoiceOutputInfo = invoiceOutputInfo;
            this.OcrNormalScanInfo = ocrNormalScanInfo;
            this.OcrPlaneScanInfo = ocrPlaneScanInfo;
            this.OcrTaxiScanInfo = ocrTaxiScanInfo;
            this.OcrTrainScanInfo = ocrTrainScanInfo;
            this.VoucherFileInfo = voucherFileInfo;
            this.VoucherId = voucherId;
        }

        /// <summary>
        /// 员工ID
        /// </summary>
        /// <value>员工ID</value>
        [DataMember(Name = "employee_id", EmitDefaultValue = false)]
        public string EmployeeId { get; set; }

        /// <summary>
        /// 员工ID
        /// </summary>
        /// <value>员工ID</value>
        [DataMember(Name = "employee_open_id", EmitDefaultValue = false)]
        public string EmployeeOpenId { get; set; }

        /// <summary>
        /// Gets or Sets InvoiceOutputInfo
        /// </summary>
        [DataMember(Name = "invoice_output_info", EmitDefaultValue = false)]
        public InvoiceOutputInfo InvoiceOutputInfo { get; set; }

        /// <summary>
        /// Gets or Sets OcrNormalScanInfo
        /// </summary>
        [DataMember(Name = "ocr_normal_scan_info", EmitDefaultValue = false)]
        public OcrNormalScanInfo OcrNormalScanInfo { get; set; }

        /// <summary>
        /// Gets or Sets OcrPlaneScanInfo
        /// </summary>
        [DataMember(Name = "ocr_plane_scan_info", EmitDefaultValue = false)]
        public OcrPlaneScanInfo OcrPlaneScanInfo { get; set; }

        /// <summary>
        /// Gets or Sets OcrTaxiScanInfo
        /// </summary>
        [DataMember(Name = "ocr_taxi_scan_info", EmitDefaultValue = false)]
        public OcrTaxiScanInfo OcrTaxiScanInfo { get; set; }

        /// <summary>
        /// Gets or Sets OcrTrainScanInfo
        /// </summary>
        [DataMember(Name = "ocr_train_scan_info", EmitDefaultValue = false)]
        public OcrTrainScanInfo OcrTrainScanInfo { get; set; }

        /// <summary>
        /// Gets or Sets VoucherFileInfo
        /// </summary>
        [DataMember(Name = "voucher_file_info", EmitDefaultValue = false)]
        public VoucherFileInfo VoucherFileInfo { get; set; }

        /// <summary>
        /// 凭证ID
        /// </summary>
        /// <value>凭证ID</value>
        [DataMember(Name = "voucher_id", EmitDefaultValue = false)]
        public string VoucherId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ExpenseInvoiceInfo {\n");
            sb.Append("  EmployeeId: ").Append(EmployeeId).Append("\n");
            sb.Append("  EmployeeOpenId: ").Append(EmployeeOpenId).Append("\n");
            sb.Append("  InvoiceOutputInfo: ").Append(InvoiceOutputInfo).Append("\n");
            sb.Append("  OcrNormalScanInfo: ").Append(OcrNormalScanInfo).Append("\n");
            sb.Append("  OcrPlaneScanInfo: ").Append(OcrPlaneScanInfo).Append("\n");
            sb.Append("  OcrTaxiScanInfo: ").Append(OcrTaxiScanInfo).Append("\n");
            sb.Append("  OcrTrainScanInfo: ").Append(OcrTrainScanInfo).Append("\n");
            sb.Append("  VoucherFileInfo: ").Append(VoucherFileInfo).Append("\n");
            sb.Append("  VoucherId: ").Append(VoucherId).Append("\n");
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
            return this.Equals(input as ExpenseInvoiceInfo);
        }

        /// <summary>
        /// Returns true if ExpenseInvoiceInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseInvoiceInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseInvoiceInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmployeeId == input.EmployeeId ||
                    (this.EmployeeId != null &&
                    this.EmployeeId.Equals(input.EmployeeId))
                ) && 
                (
                    this.EmployeeOpenId == input.EmployeeOpenId ||
                    (this.EmployeeOpenId != null &&
                    this.EmployeeOpenId.Equals(input.EmployeeOpenId))
                ) && 
                (
                    this.InvoiceOutputInfo == input.InvoiceOutputInfo ||
                    (this.InvoiceOutputInfo != null &&
                    this.InvoiceOutputInfo.Equals(input.InvoiceOutputInfo))
                ) && 
                (
                    this.OcrNormalScanInfo == input.OcrNormalScanInfo ||
                    (this.OcrNormalScanInfo != null &&
                    this.OcrNormalScanInfo.Equals(input.OcrNormalScanInfo))
                ) && 
                (
                    this.OcrPlaneScanInfo == input.OcrPlaneScanInfo ||
                    (this.OcrPlaneScanInfo != null &&
                    this.OcrPlaneScanInfo.Equals(input.OcrPlaneScanInfo))
                ) && 
                (
                    this.OcrTaxiScanInfo == input.OcrTaxiScanInfo ||
                    (this.OcrTaxiScanInfo != null &&
                    this.OcrTaxiScanInfo.Equals(input.OcrTaxiScanInfo))
                ) && 
                (
                    this.OcrTrainScanInfo == input.OcrTrainScanInfo ||
                    (this.OcrTrainScanInfo != null &&
                    this.OcrTrainScanInfo.Equals(input.OcrTrainScanInfo))
                ) && 
                (
                    this.VoucherFileInfo == input.VoucherFileInfo ||
                    (this.VoucherFileInfo != null &&
                    this.VoucherFileInfo.Equals(input.VoucherFileInfo))
                ) && 
                (
                    this.VoucherId == input.VoucherId ||
                    (this.VoucherId != null &&
                    this.VoucherId.Equals(input.VoucherId))
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
                if (this.EmployeeId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeId.GetHashCode();
                }
                if (this.EmployeeOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.EmployeeOpenId.GetHashCode();
                }
                if (this.InvoiceOutputInfo != null)
                {
                    hashCode = (hashCode * 59) + this.InvoiceOutputInfo.GetHashCode();
                }
                if (this.OcrNormalScanInfo != null)
                {
                    hashCode = (hashCode * 59) + this.OcrNormalScanInfo.GetHashCode();
                }
                if (this.OcrPlaneScanInfo != null)
                {
                    hashCode = (hashCode * 59) + this.OcrPlaneScanInfo.GetHashCode();
                }
                if (this.OcrTaxiScanInfo != null)
                {
                    hashCode = (hashCode * 59) + this.OcrTaxiScanInfo.GetHashCode();
                }
                if (this.OcrTrainScanInfo != null)
                {
                    hashCode = (hashCode * 59) + this.OcrTrainScanInfo.GetHashCode();
                }
                if (this.VoucherFileInfo != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherFileInfo.GetHashCode();
                }
                if (this.VoucherId != null)
                {
                    hashCode = (hashCode * 59) + this.VoucherId.GetHashCode();
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
