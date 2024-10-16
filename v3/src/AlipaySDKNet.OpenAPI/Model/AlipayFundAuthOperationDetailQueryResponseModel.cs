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
    /// AlipayFundAuthOperationDetailQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayFundAuthOperationDetailQueryResponseModel")]
    public partial class AlipayFundAuthOperationDetailQueryResponseModel : IEquatable<AlipayFundAuthOperationDetailQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayFundAuthOperationDetailQueryResponseModel" /> class.
        /// </summary>
        /// <param name="amount">该笔资金操作流水operation_id对应的操作金额，单位为：元（人民币）.</param>
        /// <param name="authNo">支付宝资金授权订单号.</param>
        /// <param name="creditAmount">该笔资金操作流水operation_id对应的操作信用金额.</param>
        /// <param name="creditMerchantExt">芝麻透出给商户的信息，具体内容由商户与芝麻约定后返回.</param>
        /// <param name="creditRiskInfo">creditRiskInfo.</param>
        /// <param name="enterprisePayInfo">因公付业务信息.</param>
        /// <param name="extraParam">商户请求创建预授权订单时传入的扩展参数，仅返回商户自定义的扩展信息（merchantExt）.</param>
        /// <param name="fundAmount">该笔资金操作流水operation_id对应的操作自有资金金额.</param>
        /// <param name="gmtCreate">资金授权单据操作流水创建时间，  格式：YYYY-MM-DD HH:MM:SS.</param>
        /// <param name="gmtTrans">支付宝账务处理成功时间，  格式：YYYY-MM-DD HH:MM:SS.</param>
        /// <param name="operationId">支付宝资金操作流水号.</param>
        /// <param name="operationType">支付宝资金操作类型，表示当前查询到的这笔明细的操作类型。.</param>
        /// <param name="orderStatus">授权单状态：INIT（初始状态：已创建未授权）、AUTHORIZED（已授权状态：授权成功，可以进行转支付或解冻操作）、FINISH（完成状态：转支付完成且无剩余冻结资金）、CLOSED（关闭状态：授权未完成超时关闭或冻结资金全额解冻）.</param>
        /// <param name="orderTitle">业务订单的简单描述，如商品名称等.</param>
        /// <param name="outOrderNo">商户的授权资金订单号.</param>
        /// <param name="outRequestNo">商户资金操作的请求流水号.</param>
        /// <param name="payerLogonId">付款方支付宝账号（Email或手机号），仅作展示使用，默认会加“*”号处理.</param>
        /// <param name="payerOpenId">支付宝openId，用户（userId）在应用（appId）下的唯一标识。.</param>
        /// <param name="payerUserId">付款方支付宝账号对应的支付宝唯一用户号，以2088开头的16位纯数字组成.</param>
        /// <param name="preAuthType">预授权类型，信用预授权情况下值为 CREDIT_AUTH，表示该笔预授权为信用预授权，实际没有冻结用户资金；其它情况均不返回该字段。.</param>
        /// <param name="remark">商户对本次操作的附言描述，长度不超过100个字母或50个汉字.</param>
        /// <param name="restAmount">订单当前剩余冻结金额，单位为：元（人民币）。.</param>
        /// <param name="restCreditAmount">剩余冻结信用金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="restFundAmount">剩余冻结自有资金金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="status">资金操作流水的状态，  目前支持：   INIT：初始  SUCCESS：成功  CLOSED：关闭.</param>
        /// <param name="totalFreezeAmount">订单累计的冻结金额，单位为：元（人民币）.</param>
        /// <param name="totalFreezeCreditAmount">累计冻结信用金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="totalFreezeFundAmount">累计冻结自有资金金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="totalPayAmount">订单累计用于支付的金额，单位为：元（人民币）.</param>
        /// <param name="totalPayCreditAmount">累计支付信用金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="totalPayFundAmount">累计支付自有资金金额，单位为：元（人民币），精确到小数点后两位.</param>
        /// <param name="transCurrency">标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP.</param>
        public AlipayFundAuthOperationDetailQueryResponseModel(string amount = default(string), string authNo = default(string), string creditAmount = default(string), string creditMerchantExt = default(string), CreditRiskInfo creditRiskInfo = default(CreditRiskInfo), string enterprisePayInfo = default(string), string extraParam = default(string), string fundAmount = default(string), string gmtCreate = default(string), string gmtTrans = default(string), string operationId = default(string), string operationType = default(string), string orderStatus = default(string), string orderTitle = default(string), string outOrderNo = default(string), string outRequestNo = default(string), string payerLogonId = default(string), string payerOpenId = default(string), string payerUserId = default(string), string preAuthType = default(string), string remark = default(string), string restAmount = default(string), string restCreditAmount = default(string), string restFundAmount = default(string), string status = default(string), string totalFreezeAmount = default(string), string totalFreezeCreditAmount = default(string), string totalFreezeFundAmount = default(string), string totalPayAmount = default(string), string totalPayCreditAmount = default(string), string totalPayFundAmount = default(string), string transCurrency = default(string))
        {
            this.Amount = amount;
            this.AuthNo = authNo;
            this.CreditAmount = creditAmount;
            this.CreditMerchantExt = creditMerchantExt;
            this.CreditRiskInfo = creditRiskInfo;
            this.EnterprisePayInfo = enterprisePayInfo;
            this.ExtraParam = extraParam;
            this.FundAmount = fundAmount;
            this.GmtCreate = gmtCreate;
            this.GmtTrans = gmtTrans;
            this.OperationId = operationId;
            this.OperationType = operationType;
            this.OrderStatus = orderStatus;
            this.OrderTitle = orderTitle;
            this.OutOrderNo = outOrderNo;
            this.OutRequestNo = outRequestNo;
            this.PayerLogonId = payerLogonId;
            this.PayerOpenId = payerOpenId;
            this.PayerUserId = payerUserId;
            this.PreAuthType = preAuthType;
            this.Remark = remark;
            this.RestAmount = restAmount;
            this.RestCreditAmount = restCreditAmount;
            this.RestFundAmount = restFundAmount;
            this.Status = status;
            this.TotalFreezeAmount = totalFreezeAmount;
            this.TotalFreezeCreditAmount = totalFreezeCreditAmount;
            this.TotalFreezeFundAmount = totalFreezeFundAmount;
            this.TotalPayAmount = totalPayAmount;
            this.TotalPayCreditAmount = totalPayCreditAmount;
            this.TotalPayFundAmount = totalPayFundAmount;
            this.TransCurrency = transCurrency;
        }

        /// <summary>
        /// 该笔资金操作流水operation_id对应的操作金额，单位为：元（人民币）
        /// </summary>
        /// <value>该笔资金操作流水operation_id对应的操作金额，单位为：元（人民币）</value>
        [DataMember(Name = "amount", EmitDefaultValue = false)]
        public string Amount { get; set; }

        /// <summary>
        /// 支付宝资金授权订单号
        /// </summary>
        /// <value>支付宝资金授权订单号</value>
        [DataMember(Name = "auth_no", EmitDefaultValue = false)]
        public string AuthNo { get; set; }

        /// <summary>
        /// 该笔资金操作流水operation_id对应的操作信用金额
        /// </summary>
        /// <value>该笔资金操作流水operation_id对应的操作信用金额</value>
        [DataMember(Name = "credit_amount", EmitDefaultValue = false)]
        public string CreditAmount { get; set; }

        /// <summary>
        /// 芝麻透出给商户的信息，具体内容由商户与芝麻约定后返回
        /// </summary>
        /// <value>芝麻透出给商户的信息，具体内容由商户与芝麻约定后返回</value>
        [DataMember(Name = "credit_merchant_ext", EmitDefaultValue = false)]
        public string CreditMerchantExt { get; set; }

        /// <summary>
        /// Gets or Sets CreditRiskInfo
        /// </summary>
        [DataMember(Name = "credit_risk_info", EmitDefaultValue = false)]
        public CreditRiskInfo CreditRiskInfo { get; set; }

        /// <summary>
        /// 因公付业务信息
        /// </summary>
        /// <value>因公付业务信息</value>
        [DataMember(Name = "enterprise_pay_info", EmitDefaultValue = false)]
        public string EnterprisePayInfo { get; set; }

        /// <summary>
        /// 商户请求创建预授权订单时传入的扩展参数，仅返回商户自定义的扩展信息（merchantExt）
        /// </summary>
        /// <value>商户请求创建预授权订单时传入的扩展参数，仅返回商户自定义的扩展信息（merchantExt）</value>
        [DataMember(Name = "extra_param", EmitDefaultValue = false)]
        public string ExtraParam { get; set; }

        /// <summary>
        /// 该笔资金操作流水operation_id对应的操作自有资金金额
        /// </summary>
        /// <value>该笔资金操作流水operation_id对应的操作自有资金金额</value>
        [DataMember(Name = "fund_amount", EmitDefaultValue = false)]
        public string FundAmount { get; set; }

        /// <summary>
        /// 资金授权单据操作流水创建时间，  格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        /// <value>资金授权单据操作流水创建时间，  格式：YYYY-MM-DD HH:MM:SS</value>
        [DataMember(Name = "gmt_create", EmitDefaultValue = false)]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 支付宝账务处理成功时间，  格式：YYYY-MM-DD HH:MM:SS
        /// </summary>
        /// <value>支付宝账务处理成功时间，  格式：YYYY-MM-DD HH:MM:SS</value>
        [DataMember(Name = "gmt_trans", EmitDefaultValue = false)]
        public string GmtTrans { get; set; }

        /// <summary>
        /// 支付宝资金操作流水号
        /// </summary>
        /// <value>支付宝资金操作流水号</value>
        [DataMember(Name = "operation_id", EmitDefaultValue = false)]
        public string OperationId { get; set; }

        /// <summary>
        /// 支付宝资金操作类型，表示当前查询到的这笔明细的操作类型。
        /// </summary>
        /// <value>支付宝资金操作类型，表示当前查询到的这笔明细的操作类型。</value>
        [DataMember(Name = "operation_type", EmitDefaultValue = false)]
        public string OperationType { get; set; }

        /// <summary>
        /// 授权单状态：INIT（初始状态：已创建未授权）、AUTHORIZED（已授权状态：授权成功，可以进行转支付或解冻操作）、FINISH（完成状态：转支付完成且无剩余冻结资金）、CLOSED（关闭状态：授权未完成超时关闭或冻结资金全额解冻）
        /// </summary>
        /// <value>授权单状态：INIT（初始状态：已创建未授权）、AUTHORIZED（已授权状态：授权成功，可以进行转支付或解冻操作）、FINISH（完成状态：转支付完成且无剩余冻结资金）、CLOSED（关闭状态：授权未完成超时关闭或冻结资金全额解冻）</value>
        [DataMember(Name = "order_status", EmitDefaultValue = false)]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 业务订单的简单描述，如商品名称等
        /// </summary>
        /// <value>业务订单的简单描述，如商品名称等</value>
        [DataMember(Name = "order_title", EmitDefaultValue = false)]
        public string OrderTitle { get; set; }

        /// <summary>
        /// 商户的授权资金订单号
        /// </summary>
        /// <value>商户的授权资金订单号</value>
        [DataMember(Name = "out_order_no", EmitDefaultValue = false)]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户资金操作的请求流水号
        /// </summary>
        /// <value>商户资金操作的请求流水号</value>
        [DataMember(Name = "out_request_no", EmitDefaultValue = false)]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 付款方支付宝账号（Email或手机号），仅作展示使用，默认会加“*”号处理
        /// </summary>
        /// <value>付款方支付宝账号（Email或手机号），仅作展示使用，默认会加“*”号处理</value>
        [DataMember(Name = "payer_logon_id", EmitDefaultValue = false)]
        public string PayerLogonId { get; set; }

        /// <summary>
        /// 支付宝openId，用户（userId）在应用（appId）下的唯一标识。
        /// </summary>
        /// <value>支付宝openId，用户（userId）在应用（appId）下的唯一标识。</value>
        [DataMember(Name = "payer_open_id", EmitDefaultValue = false)]
        public string PayerOpenId { get; set; }

        /// <summary>
        /// 付款方支付宝账号对应的支付宝唯一用户号，以2088开头的16位纯数字组成
        /// </summary>
        /// <value>付款方支付宝账号对应的支付宝唯一用户号，以2088开头的16位纯数字组成</value>
        [DataMember(Name = "payer_user_id", EmitDefaultValue = false)]
        public string PayerUserId { get; set; }

        /// <summary>
        /// 预授权类型，信用预授权情况下值为 CREDIT_AUTH，表示该笔预授权为信用预授权，实际没有冻结用户资金；其它情况均不返回该字段。
        /// </summary>
        /// <value>预授权类型，信用预授权情况下值为 CREDIT_AUTH，表示该笔预授权为信用预授权，实际没有冻结用户资金；其它情况均不返回该字段。</value>
        [DataMember(Name = "pre_auth_type", EmitDefaultValue = false)]
        public string PreAuthType { get; set; }

        /// <summary>
        /// 商户对本次操作的附言描述，长度不超过100个字母或50个汉字
        /// </summary>
        /// <value>商户对本次操作的附言描述，长度不超过100个字母或50个汉字</value>
        [DataMember(Name = "remark", EmitDefaultValue = false)]
        public string Remark { get; set; }

        /// <summary>
        /// 订单当前剩余冻结金额，单位为：元（人民币）。
        /// </summary>
        /// <value>订单当前剩余冻结金额，单位为：元（人民币）。</value>
        [DataMember(Name = "rest_amount", EmitDefaultValue = false)]
        public string RestAmount { get; set; }

        /// <summary>
        /// 剩余冻结信用金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>剩余冻结信用金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "rest_credit_amount", EmitDefaultValue = false)]
        public string RestCreditAmount { get; set; }

        /// <summary>
        /// 剩余冻结自有资金金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>剩余冻结自有资金金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "rest_fund_amount", EmitDefaultValue = false)]
        public string RestFundAmount { get; set; }

        /// <summary>
        /// 资金操作流水的状态，  目前支持：   INIT：初始  SUCCESS：成功  CLOSED：关闭
        /// </summary>
        /// <value>资金操作流水的状态，  目前支持：   INIT：初始  SUCCESS：成功  CLOSED：关闭</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 订单累计的冻结金额，单位为：元（人民币）
        /// </summary>
        /// <value>订单累计的冻结金额，单位为：元（人民币）</value>
        [DataMember(Name = "total_freeze_amount", EmitDefaultValue = false)]
        public string TotalFreezeAmount { get; set; }

        /// <summary>
        /// 累计冻结信用金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>累计冻结信用金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "total_freeze_credit_amount", EmitDefaultValue = false)]
        public string TotalFreezeCreditAmount { get; set; }

        /// <summary>
        /// 累计冻结自有资金金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>累计冻结自有资金金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "total_freeze_fund_amount", EmitDefaultValue = false)]
        public string TotalFreezeFundAmount { get; set; }

        /// <summary>
        /// 订单累计用于支付的金额，单位为：元（人民币）
        /// </summary>
        /// <value>订单累计用于支付的金额，单位为：元（人民币）</value>
        [DataMember(Name = "total_pay_amount", EmitDefaultValue = false)]
        public string TotalPayAmount { get; set; }

        /// <summary>
        /// 累计支付信用金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>累计支付信用金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "total_pay_credit_amount", EmitDefaultValue = false)]
        public string TotalPayCreditAmount { get; set; }

        /// <summary>
        /// 累计支付自有资金金额，单位为：元（人民币），精确到小数点后两位
        /// </summary>
        /// <value>累计支付自有资金金额，单位为：元（人民币），精确到小数点后两位</value>
        [DataMember(Name = "total_pay_fund_amount", EmitDefaultValue = false)]
        public string TotalPayFundAmount { get; set; }

        /// <summary>
        /// 标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP
        /// </summary>
        /// <value>标价币种,  amount 对应的币种单位。支持澳元：AUD, 新西兰元：NZD, 台币：TWD, 美元：USD, 欧元：EUR, 英镑：GBP</value>
        [DataMember(Name = "trans_currency", EmitDefaultValue = false)]
        public string TransCurrency { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayFundAuthOperationDetailQueryResponseModel {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  AuthNo: ").Append(AuthNo).Append("\n");
            sb.Append("  CreditAmount: ").Append(CreditAmount).Append("\n");
            sb.Append("  CreditMerchantExt: ").Append(CreditMerchantExt).Append("\n");
            sb.Append("  CreditRiskInfo: ").Append(CreditRiskInfo).Append("\n");
            sb.Append("  EnterprisePayInfo: ").Append(EnterprisePayInfo).Append("\n");
            sb.Append("  ExtraParam: ").Append(ExtraParam).Append("\n");
            sb.Append("  FundAmount: ").Append(FundAmount).Append("\n");
            sb.Append("  GmtCreate: ").Append(GmtCreate).Append("\n");
            sb.Append("  GmtTrans: ").Append(GmtTrans).Append("\n");
            sb.Append("  OperationId: ").Append(OperationId).Append("\n");
            sb.Append("  OperationType: ").Append(OperationType).Append("\n");
            sb.Append("  OrderStatus: ").Append(OrderStatus).Append("\n");
            sb.Append("  OrderTitle: ").Append(OrderTitle).Append("\n");
            sb.Append("  OutOrderNo: ").Append(OutOrderNo).Append("\n");
            sb.Append("  OutRequestNo: ").Append(OutRequestNo).Append("\n");
            sb.Append("  PayerLogonId: ").Append(PayerLogonId).Append("\n");
            sb.Append("  PayerOpenId: ").Append(PayerOpenId).Append("\n");
            sb.Append("  PayerUserId: ").Append(PayerUserId).Append("\n");
            sb.Append("  PreAuthType: ").Append(PreAuthType).Append("\n");
            sb.Append("  Remark: ").Append(Remark).Append("\n");
            sb.Append("  RestAmount: ").Append(RestAmount).Append("\n");
            sb.Append("  RestCreditAmount: ").Append(RestCreditAmount).Append("\n");
            sb.Append("  RestFundAmount: ").Append(RestFundAmount).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalFreezeAmount: ").Append(TotalFreezeAmount).Append("\n");
            sb.Append("  TotalFreezeCreditAmount: ").Append(TotalFreezeCreditAmount).Append("\n");
            sb.Append("  TotalFreezeFundAmount: ").Append(TotalFreezeFundAmount).Append("\n");
            sb.Append("  TotalPayAmount: ").Append(TotalPayAmount).Append("\n");
            sb.Append("  TotalPayCreditAmount: ").Append(TotalPayCreditAmount).Append("\n");
            sb.Append("  TotalPayFundAmount: ").Append(TotalPayFundAmount).Append("\n");
            sb.Append("  TransCurrency: ").Append(TransCurrency).Append("\n");
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
            return this.Equals(input as AlipayFundAuthOperationDetailQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayFundAuthOperationDetailQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayFundAuthOperationDetailQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayFundAuthOperationDetailQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
                ) && 
                (
                    this.AuthNo == input.AuthNo ||
                    (this.AuthNo != null &&
                    this.AuthNo.Equals(input.AuthNo))
                ) && 
                (
                    this.CreditAmount == input.CreditAmount ||
                    (this.CreditAmount != null &&
                    this.CreditAmount.Equals(input.CreditAmount))
                ) && 
                (
                    this.CreditMerchantExt == input.CreditMerchantExt ||
                    (this.CreditMerchantExt != null &&
                    this.CreditMerchantExt.Equals(input.CreditMerchantExt))
                ) && 
                (
                    this.CreditRiskInfo == input.CreditRiskInfo ||
                    (this.CreditRiskInfo != null &&
                    this.CreditRiskInfo.Equals(input.CreditRiskInfo))
                ) && 
                (
                    this.EnterprisePayInfo == input.EnterprisePayInfo ||
                    (this.EnterprisePayInfo != null &&
                    this.EnterprisePayInfo.Equals(input.EnterprisePayInfo))
                ) && 
                (
                    this.ExtraParam == input.ExtraParam ||
                    (this.ExtraParam != null &&
                    this.ExtraParam.Equals(input.ExtraParam))
                ) && 
                (
                    this.FundAmount == input.FundAmount ||
                    (this.FundAmount != null &&
                    this.FundAmount.Equals(input.FundAmount))
                ) && 
                (
                    this.GmtCreate == input.GmtCreate ||
                    (this.GmtCreate != null &&
                    this.GmtCreate.Equals(input.GmtCreate))
                ) && 
                (
                    this.GmtTrans == input.GmtTrans ||
                    (this.GmtTrans != null &&
                    this.GmtTrans.Equals(input.GmtTrans))
                ) && 
                (
                    this.OperationId == input.OperationId ||
                    (this.OperationId != null &&
                    this.OperationId.Equals(input.OperationId))
                ) && 
                (
                    this.OperationType == input.OperationType ||
                    (this.OperationType != null &&
                    this.OperationType.Equals(input.OperationType))
                ) && 
                (
                    this.OrderStatus == input.OrderStatus ||
                    (this.OrderStatus != null &&
                    this.OrderStatus.Equals(input.OrderStatus))
                ) && 
                (
                    this.OrderTitle == input.OrderTitle ||
                    (this.OrderTitle != null &&
                    this.OrderTitle.Equals(input.OrderTitle))
                ) && 
                (
                    this.OutOrderNo == input.OutOrderNo ||
                    (this.OutOrderNo != null &&
                    this.OutOrderNo.Equals(input.OutOrderNo))
                ) && 
                (
                    this.OutRequestNo == input.OutRequestNo ||
                    (this.OutRequestNo != null &&
                    this.OutRequestNo.Equals(input.OutRequestNo))
                ) && 
                (
                    this.PayerLogonId == input.PayerLogonId ||
                    (this.PayerLogonId != null &&
                    this.PayerLogonId.Equals(input.PayerLogonId))
                ) && 
                (
                    this.PayerOpenId == input.PayerOpenId ||
                    (this.PayerOpenId != null &&
                    this.PayerOpenId.Equals(input.PayerOpenId))
                ) && 
                (
                    this.PayerUserId == input.PayerUserId ||
                    (this.PayerUserId != null &&
                    this.PayerUserId.Equals(input.PayerUserId))
                ) && 
                (
                    this.PreAuthType == input.PreAuthType ||
                    (this.PreAuthType != null &&
                    this.PreAuthType.Equals(input.PreAuthType))
                ) && 
                (
                    this.Remark == input.Remark ||
                    (this.Remark != null &&
                    this.Remark.Equals(input.Remark))
                ) && 
                (
                    this.RestAmount == input.RestAmount ||
                    (this.RestAmount != null &&
                    this.RestAmount.Equals(input.RestAmount))
                ) && 
                (
                    this.RestCreditAmount == input.RestCreditAmount ||
                    (this.RestCreditAmount != null &&
                    this.RestCreditAmount.Equals(input.RestCreditAmount))
                ) && 
                (
                    this.RestFundAmount == input.RestFundAmount ||
                    (this.RestFundAmount != null &&
                    this.RestFundAmount.Equals(input.RestFundAmount))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.TotalFreezeAmount == input.TotalFreezeAmount ||
                    (this.TotalFreezeAmount != null &&
                    this.TotalFreezeAmount.Equals(input.TotalFreezeAmount))
                ) && 
                (
                    this.TotalFreezeCreditAmount == input.TotalFreezeCreditAmount ||
                    (this.TotalFreezeCreditAmount != null &&
                    this.TotalFreezeCreditAmount.Equals(input.TotalFreezeCreditAmount))
                ) && 
                (
                    this.TotalFreezeFundAmount == input.TotalFreezeFundAmount ||
                    (this.TotalFreezeFundAmount != null &&
                    this.TotalFreezeFundAmount.Equals(input.TotalFreezeFundAmount))
                ) && 
                (
                    this.TotalPayAmount == input.TotalPayAmount ||
                    (this.TotalPayAmount != null &&
                    this.TotalPayAmount.Equals(input.TotalPayAmount))
                ) && 
                (
                    this.TotalPayCreditAmount == input.TotalPayCreditAmount ||
                    (this.TotalPayCreditAmount != null &&
                    this.TotalPayCreditAmount.Equals(input.TotalPayCreditAmount))
                ) && 
                (
                    this.TotalPayFundAmount == input.TotalPayFundAmount ||
                    (this.TotalPayFundAmount != null &&
                    this.TotalPayFundAmount.Equals(input.TotalPayFundAmount))
                ) && 
                (
                    this.TransCurrency == input.TransCurrency ||
                    (this.TransCurrency != null &&
                    this.TransCurrency.Equals(input.TransCurrency))
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
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                }
                if (this.AuthNo != null)
                {
                    hashCode = (hashCode * 59) + this.AuthNo.GetHashCode();
                }
                if (this.CreditAmount != null)
                {
                    hashCode = (hashCode * 59) + this.CreditAmount.GetHashCode();
                }
                if (this.CreditMerchantExt != null)
                {
                    hashCode = (hashCode * 59) + this.CreditMerchantExt.GetHashCode();
                }
                if (this.CreditRiskInfo != null)
                {
                    hashCode = (hashCode * 59) + this.CreditRiskInfo.GetHashCode();
                }
                if (this.EnterprisePayInfo != null)
                {
                    hashCode = (hashCode * 59) + this.EnterprisePayInfo.GetHashCode();
                }
                if (this.ExtraParam != null)
                {
                    hashCode = (hashCode * 59) + this.ExtraParam.GetHashCode();
                }
                if (this.FundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.FundAmount.GetHashCode();
                }
                if (this.GmtCreate != null)
                {
                    hashCode = (hashCode * 59) + this.GmtCreate.GetHashCode();
                }
                if (this.GmtTrans != null)
                {
                    hashCode = (hashCode * 59) + this.GmtTrans.GetHashCode();
                }
                if (this.OperationId != null)
                {
                    hashCode = (hashCode * 59) + this.OperationId.GetHashCode();
                }
                if (this.OperationType != null)
                {
                    hashCode = (hashCode * 59) + this.OperationType.GetHashCode();
                }
                if (this.OrderStatus != null)
                {
                    hashCode = (hashCode * 59) + this.OrderStatus.GetHashCode();
                }
                if (this.OrderTitle != null)
                {
                    hashCode = (hashCode * 59) + this.OrderTitle.GetHashCode();
                }
                if (this.OutOrderNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutOrderNo.GetHashCode();
                }
                if (this.OutRequestNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutRequestNo.GetHashCode();
                }
                if (this.PayerLogonId != null)
                {
                    hashCode = (hashCode * 59) + this.PayerLogonId.GetHashCode();
                }
                if (this.PayerOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.PayerOpenId.GetHashCode();
                }
                if (this.PayerUserId != null)
                {
                    hashCode = (hashCode * 59) + this.PayerUserId.GetHashCode();
                }
                if (this.PreAuthType != null)
                {
                    hashCode = (hashCode * 59) + this.PreAuthType.GetHashCode();
                }
                if (this.Remark != null)
                {
                    hashCode = (hashCode * 59) + this.Remark.GetHashCode();
                }
                if (this.RestAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RestAmount.GetHashCode();
                }
                if (this.RestCreditAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RestCreditAmount.GetHashCode();
                }
                if (this.RestFundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.RestFundAmount.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.TotalFreezeAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalFreezeAmount.GetHashCode();
                }
                if (this.TotalFreezeCreditAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalFreezeCreditAmount.GetHashCode();
                }
                if (this.TotalFreezeFundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalFreezeFundAmount.GetHashCode();
                }
                if (this.TotalPayAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPayAmount.GetHashCode();
                }
                if (this.TotalPayCreditAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPayCreditAmount.GetHashCode();
                }
                if (this.TotalPayFundAmount != null)
                {
                    hashCode = (hashCode * 59) + this.TotalPayFundAmount.GetHashCode();
                }
                if (this.TransCurrency != null)
                {
                    hashCode = (hashCode * 59) + this.TransCurrency.GetHashCode();
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
