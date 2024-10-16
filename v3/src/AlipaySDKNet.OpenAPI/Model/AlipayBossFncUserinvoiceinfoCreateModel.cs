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
    /// AlipayBossFncUserinvoiceinfoCreateModel
    /// </summary>
    [DataContract(Name = "AlipayBossFncUserinvoiceinfoCreateModel")]
    public partial class AlipayBossFncUserinvoiceinfoCreateModel : IEquatable<AlipayBossFncUserinvoiceinfoCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayBossFncUserinvoiceinfoCreateModel" /> class.
        /// </summary>
        /// <param name="acceptElectronic">是否接受电子票 true:是，false:否.</param>
        /// <param name="address">公司注册地址，公司营业执照上登记的住址，一般纳税人必须填写，小规模纳税人无需填写.</param>
        /// <param name="addressing">开票资料pid寻址方式 true:pid寻址mid,优先以mid维度保存开票资料,若无mid则以pid维度保存开票资料 false:不寻址mid,以pid维度保存开票资料;非主站商户体系都是以pid（ipRoleId）维度保存开票资料，该值直接填为false.</param>
        /// <param name="auto">是否自动申请开票 true:是，false:否.</param>
        /// <param name="bankAccount">银行账户，公司银行账号  一般纳税人必须填写，小规模纳税人无需填写.</param>
        /// <param name="bankName">开户行，办理银行开户手续的营业网点  一般纳税人必须填写，小规模纳税人无需填写.</param>
        /// <param name="businessLicenceUrl">营业执照地址，营业执照上传oss上的地址.</param>
        /// <param name="hold">是否暂停开票，商户添加的开票资料就是不暂停开票，如果后续要暂停开票，只能去结算中台处理。.</param>
        /// <param name="ipRoleId">商户的pid（ipRoleId）.</param>
        /// <param name="openAccountPermitUrl">银行开户许可证附件，银行开户许可证上传oss上的地址.</param>
        /// <param name="_operator">当前操作人.</param>
        /// <param name="operatorType">当前操作人类型,01:商户 02:管理员(小二).</param>
        /// <param name="otherQualificationUrl">其它资质证明地址，其他资质证明附件上传oss上的地址.</param>
        /// <param name="ou">外部只允许添加商户开票资料，该值填写为false.</param>
        /// <param name="taxNo">纳税人识别号，税务登记证上的号码。一般纳税人必须填写，小规模纳税人如果是商户也必须填写，个人无需填写.</param>
        /// <param name="taxPayerQualiValid">纳税人资格开始时间 （格式：时间戳）  一般纳税人必须填写，小规模纳税人无需填写.</param>
        /// <param name="taxPayerQualification">纳税人资格种类，01：一般纳税人；02：小规模纳税人；03：国际商户.</param>
        /// <param name="taxQualificationUrl">一般纳税人资格证书地址，一般纳税人资格证书上传oss上的地址.</param>
        /// <param name="taxRegCertUrl">税务登记证地址，税务登记证上传oss上的地址.</param>
        /// <param name="telephone">公司注册电话（手机号和座机均可）  一般纳税人必须填写，小规模纳税人无需填写.</param>
        /// <param name="title">发票抬头，票面信息上的抬头信息.</param>
        /// <param name="userMailInfoOrderList">收件人列表,若不修改此项可以不填  选择非电子票时，邮寄信息必填，且保证邮寄信息的ipRoleId和开票资料的ipRoleId相等.</param>
        public AlipayBossFncUserinvoiceinfoCreateModel(bool acceptElectronic = default(bool), string address = default(string), bool addressing = default(bool), bool auto = default(bool), string bankAccount = default(string), string bankName = default(string), string businessLicenceUrl = default(string), bool hold = default(bool), string ipRoleId = default(string), string openAccountPermitUrl = default(string), string _operator = default(string), string operatorType = default(string), string otherQualificationUrl = default(string), bool ou = default(bool), string taxNo = default(string), string taxPayerQualiValid = default(string), string taxPayerQualification = default(string), string taxQualificationUrl = default(string), string taxRegCertUrl = default(string), string telephone = default(string), string title = default(string), List<UserMailInfoOrder> userMailInfoOrderList = default(List<UserMailInfoOrder>))
        {
            this.AcceptElectronic = acceptElectronic;
            this.Address = address;
            this.Addressing = addressing;
            this.Auto = auto;
            this.BankAccount = bankAccount;
            this.BankName = bankName;
            this.BusinessLicenceUrl = businessLicenceUrl;
            this.Hold = hold;
            this.IpRoleId = ipRoleId;
            this.OpenAccountPermitUrl = openAccountPermitUrl;
            this.Operator = _operator;
            this.OperatorType = operatorType;
            this.OtherQualificationUrl = otherQualificationUrl;
            this.Ou = ou;
            this.TaxNo = taxNo;
            this.TaxPayerQualiValid = taxPayerQualiValid;
            this.TaxPayerQualification = taxPayerQualification;
            this.TaxQualificationUrl = taxQualificationUrl;
            this.TaxRegCertUrl = taxRegCertUrl;
            this.Telephone = telephone;
            this.Title = title;
            this.UserMailInfoOrderList = userMailInfoOrderList;
        }

        /// <summary>
        /// 是否接受电子票 true:是，false:否
        /// </summary>
        /// <value>是否接受电子票 true:是，false:否</value>
        [DataMember(Name = "accept_electronic", EmitDefaultValue = true)]
        public bool AcceptElectronic { get; set; }

        /// <summary>
        /// 公司注册地址，公司营业执照上登记的住址，一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        /// <value>公司注册地址，公司营业执照上登记的住址，一般纳税人必须填写，小规模纳税人无需填写</value>
        [DataMember(Name = "address", EmitDefaultValue = false)]
        public string Address { get; set; }

        /// <summary>
        /// 开票资料pid寻址方式 true:pid寻址mid,优先以mid维度保存开票资料,若无mid则以pid维度保存开票资料 false:不寻址mid,以pid维度保存开票资料;非主站商户体系都是以pid（ipRoleId）维度保存开票资料，该值直接填为false
        /// </summary>
        /// <value>开票资料pid寻址方式 true:pid寻址mid,优先以mid维度保存开票资料,若无mid则以pid维度保存开票资料 false:不寻址mid,以pid维度保存开票资料;非主站商户体系都是以pid（ipRoleId）维度保存开票资料，该值直接填为false</value>
        [DataMember(Name = "addressing", EmitDefaultValue = true)]
        public bool Addressing { get; set; }

        /// <summary>
        /// 是否自动申请开票 true:是，false:否
        /// </summary>
        /// <value>是否自动申请开票 true:是，false:否</value>
        [DataMember(Name = "auto", EmitDefaultValue = true)]
        public bool Auto { get; set; }

        /// <summary>
        /// 银行账户，公司银行账号  一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        /// <value>银行账户，公司银行账号  一般纳税人必须填写，小规模纳税人无需填写</value>
        [DataMember(Name = "bank_account", EmitDefaultValue = false)]
        public string BankAccount { get; set; }

        /// <summary>
        /// 开户行，办理银行开户手续的营业网点  一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        /// <value>开户行，办理银行开户手续的营业网点  一般纳税人必须填写，小规模纳税人无需填写</value>
        [DataMember(Name = "bank_name", EmitDefaultValue = false)]
        public string BankName { get; set; }

        /// <summary>
        /// 营业执照地址，营业执照上传oss上的地址
        /// </summary>
        /// <value>营业执照地址，营业执照上传oss上的地址</value>
        [DataMember(Name = "business_licence_url", EmitDefaultValue = false)]
        public string BusinessLicenceUrl { get; set; }

        /// <summary>
        /// 是否暂停开票，商户添加的开票资料就是不暂停开票，如果后续要暂停开票，只能去结算中台处理。
        /// </summary>
        /// <value>是否暂停开票，商户添加的开票资料就是不暂停开票，如果后续要暂停开票，只能去结算中台处理。</value>
        [DataMember(Name = "hold", EmitDefaultValue = true)]
        public bool Hold { get; set; }

        /// <summary>
        /// 商户的pid（ipRoleId）
        /// </summary>
        /// <value>商户的pid（ipRoleId）</value>
        [DataMember(Name = "ip_role_id", EmitDefaultValue = false)]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 银行开户许可证附件，银行开户许可证上传oss上的地址
        /// </summary>
        /// <value>银行开户许可证附件，银行开户许可证上传oss上的地址</value>
        [DataMember(Name = "open_account_permit_url", EmitDefaultValue = false)]
        public string OpenAccountPermitUrl { get; set; }

        /// <summary>
        /// 当前操作人
        /// </summary>
        /// <value>当前操作人</value>
        [DataMember(Name = "operator", EmitDefaultValue = false)]
        public string Operator { get; set; }

        /// <summary>
        /// 当前操作人类型,01:商户 02:管理员(小二)
        /// </summary>
        /// <value>当前操作人类型,01:商户 02:管理员(小二)</value>
        [DataMember(Name = "operator_type", EmitDefaultValue = false)]
        public string OperatorType { get; set; }

        /// <summary>
        /// 其它资质证明地址，其他资质证明附件上传oss上的地址
        /// </summary>
        /// <value>其它资质证明地址，其他资质证明附件上传oss上的地址</value>
        [DataMember(Name = "other_qualification_url", EmitDefaultValue = false)]
        public string OtherQualificationUrl { get; set; }

        /// <summary>
        /// 外部只允许添加商户开票资料，该值填写为false
        /// </summary>
        /// <value>外部只允许添加商户开票资料，该值填写为false</value>
        [DataMember(Name = "ou", EmitDefaultValue = true)]
        public bool Ou { get; set; }

        /// <summary>
        /// 纳税人识别号，税务登记证上的号码。一般纳税人必须填写，小规模纳税人如果是商户也必须填写，个人无需填写
        /// </summary>
        /// <value>纳税人识别号，税务登记证上的号码。一般纳税人必须填写，小规模纳税人如果是商户也必须填写，个人无需填写</value>
        [DataMember(Name = "tax_no", EmitDefaultValue = false)]
        public string TaxNo { get; set; }

        /// <summary>
        /// 纳税人资格开始时间 （格式：时间戳）  一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        /// <value>纳税人资格开始时间 （格式：时间戳）  一般纳税人必须填写，小规模纳税人无需填写</value>
        [DataMember(Name = "tax_payer_quali_valid", EmitDefaultValue = false)]
        public string TaxPayerQualiValid { get; set; }

        /// <summary>
        /// 纳税人资格种类，01：一般纳税人；02：小规模纳税人；03：国际商户
        /// </summary>
        /// <value>纳税人资格种类，01：一般纳税人；02：小规模纳税人；03：国际商户</value>
        [DataMember(Name = "tax_payer_qualification", EmitDefaultValue = false)]
        public string TaxPayerQualification { get; set; }

        /// <summary>
        /// 一般纳税人资格证书地址，一般纳税人资格证书上传oss上的地址
        /// </summary>
        /// <value>一般纳税人资格证书地址，一般纳税人资格证书上传oss上的地址</value>
        [DataMember(Name = "tax_qualification_url", EmitDefaultValue = false)]
        public string TaxQualificationUrl { get; set; }

        /// <summary>
        /// 税务登记证地址，税务登记证上传oss上的地址
        /// </summary>
        /// <value>税务登记证地址，税务登记证上传oss上的地址</value>
        [DataMember(Name = "tax_reg_cert_url", EmitDefaultValue = false)]
        public string TaxRegCertUrl { get; set; }

        /// <summary>
        /// 公司注册电话（手机号和座机均可）  一般纳税人必须填写，小规模纳税人无需填写
        /// </summary>
        /// <value>公司注册电话（手机号和座机均可）  一般纳税人必须填写，小规模纳税人无需填写</value>
        [DataMember(Name = "telephone", EmitDefaultValue = false)]
        public string Telephone { get; set; }

        /// <summary>
        /// 发票抬头，票面信息上的抬头信息
        /// </summary>
        /// <value>发票抬头，票面信息上的抬头信息</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 收件人列表,若不修改此项可以不填  选择非电子票时，邮寄信息必填，且保证邮寄信息的ipRoleId和开票资料的ipRoleId相等
        /// </summary>
        /// <value>收件人列表,若不修改此项可以不填  选择非电子票时，邮寄信息必填，且保证邮寄信息的ipRoleId和开票资料的ipRoleId相等</value>
        [DataMember(Name = "user_mail_info_order_list", EmitDefaultValue = false)]
        public List<UserMailInfoOrder> UserMailInfoOrderList { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayBossFncUserinvoiceinfoCreateModel {\n");
            sb.Append("  AcceptElectronic: ").Append(AcceptElectronic).Append("\n");
            sb.Append("  Address: ").Append(Address).Append("\n");
            sb.Append("  Addressing: ").Append(Addressing).Append("\n");
            sb.Append("  Auto: ").Append(Auto).Append("\n");
            sb.Append("  BankAccount: ").Append(BankAccount).Append("\n");
            sb.Append("  BankName: ").Append(BankName).Append("\n");
            sb.Append("  BusinessLicenceUrl: ").Append(BusinessLicenceUrl).Append("\n");
            sb.Append("  Hold: ").Append(Hold).Append("\n");
            sb.Append("  IpRoleId: ").Append(IpRoleId).Append("\n");
            sb.Append("  OpenAccountPermitUrl: ").Append(OpenAccountPermitUrl).Append("\n");
            sb.Append("  Operator: ").Append(Operator).Append("\n");
            sb.Append("  OperatorType: ").Append(OperatorType).Append("\n");
            sb.Append("  OtherQualificationUrl: ").Append(OtherQualificationUrl).Append("\n");
            sb.Append("  Ou: ").Append(Ou).Append("\n");
            sb.Append("  TaxNo: ").Append(TaxNo).Append("\n");
            sb.Append("  TaxPayerQualiValid: ").Append(TaxPayerQualiValid).Append("\n");
            sb.Append("  TaxPayerQualification: ").Append(TaxPayerQualification).Append("\n");
            sb.Append("  TaxQualificationUrl: ").Append(TaxQualificationUrl).Append("\n");
            sb.Append("  TaxRegCertUrl: ").Append(TaxRegCertUrl).Append("\n");
            sb.Append("  Telephone: ").Append(Telephone).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UserMailInfoOrderList: ").Append(UserMailInfoOrderList).Append("\n");
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
            return this.Equals(input as AlipayBossFncUserinvoiceinfoCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayBossFncUserinvoiceinfoCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayBossFncUserinvoiceinfoCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayBossFncUserinvoiceinfoCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AcceptElectronic == input.AcceptElectronic ||
                    this.AcceptElectronic.Equals(input.AcceptElectronic)
                ) && 
                (
                    this.Address == input.Address ||
                    (this.Address != null &&
                    this.Address.Equals(input.Address))
                ) && 
                (
                    this.Addressing == input.Addressing ||
                    this.Addressing.Equals(input.Addressing)
                ) && 
                (
                    this.Auto == input.Auto ||
                    this.Auto.Equals(input.Auto)
                ) && 
                (
                    this.BankAccount == input.BankAccount ||
                    (this.BankAccount != null &&
                    this.BankAccount.Equals(input.BankAccount))
                ) && 
                (
                    this.BankName == input.BankName ||
                    (this.BankName != null &&
                    this.BankName.Equals(input.BankName))
                ) && 
                (
                    this.BusinessLicenceUrl == input.BusinessLicenceUrl ||
                    (this.BusinessLicenceUrl != null &&
                    this.BusinessLicenceUrl.Equals(input.BusinessLicenceUrl))
                ) && 
                (
                    this.Hold == input.Hold ||
                    this.Hold.Equals(input.Hold)
                ) && 
                (
                    this.IpRoleId == input.IpRoleId ||
                    (this.IpRoleId != null &&
                    this.IpRoleId.Equals(input.IpRoleId))
                ) && 
                (
                    this.OpenAccountPermitUrl == input.OpenAccountPermitUrl ||
                    (this.OpenAccountPermitUrl != null &&
                    this.OpenAccountPermitUrl.Equals(input.OpenAccountPermitUrl))
                ) && 
                (
                    this.Operator == input.Operator ||
                    (this.Operator != null &&
                    this.Operator.Equals(input.Operator))
                ) && 
                (
                    this.OperatorType == input.OperatorType ||
                    (this.OperatorType != null &&
                    this.OperatorType.Equals(input.OperatorType))
                ) && 
                (
                    this.OtherQualificationUrl == input.OtherQualificationUrl ||
                    (this.OtherQualificationUrl != null &&
                    this.OtherQualificationUrl.Equals(input.OtherQualificationUrl))
                ) && 
                (
                    this.Ou == input.Ou ||
                    this.Ou.Equals(input.Ou)
                ) && 
                (
                    this.TaxNo == input.TaxNo ||
                    (this.TaxNo != null &&
                    this.TaxNo.Equals(input.TaxNo))
                ) && 
                (
                    this.TaxPayerQualiValid == input.TaxPayerQualiValid ||
                    (this.TaxPayerQualiValid != null &&
                    this.TaxPayerQualiValid.Equals(input.TaxPayerQualiValid))
                ) && 
                (
                    this.TaxPayerQualification == input.TaxPayerQualification ||
                    (this.TaxPayerQualification != null &&
                    this.TaxPayerQualification.Equals(input.TaxPayerQualification))
                ) && 
                (
                    this.TaxQualificationUrl == input.TaxQualificationUrl ||
                    (this.TaxQualificationUrl != null &&
                    this.TaxQualificationUrl.Equals(input.TaxQualificationUrl))
                ) && 
                (
                    this.TaxRegCertUrl == input.TaxRegCertUrl ||
                    (this.TaxRegCertUrl != null &&
                    this.TaxRegCertUrl.Equals(input.TaxRegCertUrl))
                ) && 
                (
                    this.Telephone == input.Telephone ||
                    (this.Telephone != null &&
                    this.Telephone.Equals(input.Telephone))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UserMailInfoOrderList == input.UserMailInfoOrderList ||
                    this.UserMailInfoOrderList != null &&
                    input.UserMailInfoOrderList != null &&
                    this.UserMailInfoOrderList.SequenceEqual(input.UserMailInfoOrderList)
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
                hashCode = (hashCode * 59) + this.AcceptElectronic.GetHashCode();
                if (this.Address != null)
                {
                    hashCode = (hashCode * 59) + this.Address.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Addressing.GetHashCode();
                hashCode = (hashCode * 59) + this.Auto.GetHashCode();
                if (this.BankAccount != null)
                {
                    hashCode = (hashCode * 59) + this.BankAccount.GetHashCode();
                }
                if (this.BankName != null)
                {
                    hashCode = (hashCode * 59) + this.BankName.GetHashCode();
                }
                if (this.BusinessLicenceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.BusinessLicenceUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Hold.GetHashCode();
                if (this.IpRoleId != null)
                {
                    hashCode = (hashCode * 59) + this.IpRoleId.GetHashCode();
                }
                if (this.OpenAccountPermitUrl != null)
                {
                    hashCode = (hashCode * 59) + this.OpenAccountPermitUrl.GetHashCode();
                }
                if (this.Operator != null)
                {
                    hashCode = (hashCode * 59) + this.Operator.GetHashCode();
                }
                if (this.OperatorType != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorType.GetHashCode();
                }
                if (this.OtherQualificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.OtherQualificationUrl.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Ou.GetHashCode();
                if (this.TaxNo != null)
                {
                    hashCode = (hashCode * 59) + this.TaxNo.GetHashCode();
                }
                if (this.TaxPayerQualiValid != null)
                {
                    hashCode = (hashCode * 59) + this.TaxPayerQualiValid.GetHashCode();
                }
                if (this.TaxPayerQualification != null)
                {
                    hashCode = (hashCode * 59) + this.TaxPayerQualification.GetHashCode();
                }
                if (this.TaxQualificationUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TaxQualificationUrl.GetHashCode();
                }
                if (this.TaxRegCertUrl != null)
                {
                    hashCode = (hashCode * 59) + this.TaxRegCertUrl.GetHashCode();
                }
                if (this.Telephone != null)
                {
                    hashCode = (hashCode * 59) + this.Telephone.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.UserMailInfoOrderList != null)
                {
                    hashCode = (hashCode * 59) + this.UserMailInfoOrderList.GetHashCode();
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
