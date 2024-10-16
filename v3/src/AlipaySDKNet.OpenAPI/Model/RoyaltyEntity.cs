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
    /// RoyaltyEntity
    /// </summary>
    [DataContract(Name = "RoyaltyEntity")]
    public partial class RoyaltyEntity : IEquatable<RoyaltyEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RoyaltyEntity" /> class.
        /// </summary>
        /// <param name="account">分账接收方账号。 当分账方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字； 当分账方类型是loginName时，本参数为用户的支付宝登录号；当分账方类型是openId时，本参数传递支付宝openId信息。.</param>
        /// <param name="accountOpenId">分账接收方openId，本参数为分账接收方在该应用（AppId）下的唯一用户标识，仅用于分账关系查询接口出参。.</param>
        /// <param name="bindLoginName">作为查询返回结果：分账收款方绑定时的支付宝登录号。分账关系绑定（alipay.trade.royalty.relation.bind）时，通过type为loginName绑定传入的支付宝登录号，若使用userId绑定则不返回。.</param>
        /// <param name="loginName">作为查询返回结果：当前userId对应的支付宝登录号。当login_name与bind_login_name不相等时，表明该支付宝账户发生了登录号变更。.</param>
        /// <param name="memo">分账关系描述.</param>
        /// <param name="name">分账接收方真实姓名。 绑定分账关系时： 当分账方类型是userId时，本参数可以不传，若上传则进行校验不上传不会校验。 当分账方类型是loginName时，本参数必传。 解绑分账关系时：作为请求参数可不填，分账关系查询时不作为返回结果返回.</param>
        /// <param name="type">分账接收方类型。.</param>
        public RoyaltyEntity(string account = default(string), string accountOpenId = default(string), string bindLoginName = default(string), string loginName = default(string), string memo = default(string), string name = default(string), string type = default(string))
        {
            this.Account = account;
            this.AccountOpenId = accountOpenId;
            this.BindLoginName = bindLoginName;
            this.LoginName = loginName;
            this.Memo = memo;
            this.Name = name;
            this.Type = type;
        }

        /// <summary>
        /// 分账接收方账号。 当分账方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字； 当分账方类型是loginName时，本参数为用户的支付宝登录号；当分账方类型是openId时，本参数传递支付宝openId信息。
        /// </summary>
        /// <value>分账接收方账号。 当分账方类型是userId时，本参数为用户的支付宝账号对应的支付宝唯一用户号，以2088开头的纯16位数字； 当分账方类型是loginName时，本参数为用户的支付宝登录号；当分账方类型是openId时，本参数传递支付宝openId信息。</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// 分账接收方openId，本参数为分账接收方在该应用（AppId）下的唯一用户标识，仅用于分账关系查询接口出参。
        /// </summary>
        /// <value>分账接收方openId，本参数为分账接收方在该应用（AppId）下的唯一用户标识，仅用于分账关系查询接口出参。</value>
        [DataMember(Name = "account_open_id", EmitDefaultValue = false)]
        public string AccountOpenId { get; set; }

        /// <summary>
        /// 作为查询返回结果：分账收款方绑定时的支付宝登录号。分账关系绑定（alipay.trade.royalty.relation.bind）时，通过type为loginName绑定传入的支付宝登录号，若使用userId绑定则不返回。
        /// </summary>
        /// <value>作为查询返回结果：分账收款方绑定时的支付宝登录号。分账关系绑定（alipay.trade.royalty.relation.bind）时，通过type为loginName绑定传入的支付宝登录号，若使用userId绑定则不返回。</value>
        [DataMember(Name = "bind_login_name", EmitDefaultValue = false)]
        public string BindLoginName { get; set; }

        /// <summary>
        /// 作为查询返回结果：当前userId对应的支付宝登录号。当login_name与bind_login_name不相等时，表明该支付宝账户发生了登录号变更。
        /// </summary>
        /// <value>作为查询返回结果：当前userId对应的支付宝登录号。当login_name与bind_login_name不相等时，表明该支付宝账户发生了登录号变更。</value>
        [DataMember(Name = "login_name", EmitDefaultValue = false)]
        public string LoginName { get; set; }

        /// <summary>
        /// 分账关系描述
        /// </summary>
        /// <value>分账关系描述</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 分账接收方真实姓名。 绑定分账关系时： 当分账方类型是userId时，本参数可以不传，若上传则进行校验不上传不会校验。 当分账方类型是loginName时，本参数必传。 解绑分账关系时：作为请求参数可不填，分账关系查询时不作为返回结果返回
        /// </summary>
        /// <value>分账接收方真实姓名。 绑定分账关系时： 当分账方类型是userId时，本参数可以不传，若上传则进行校验不上传不会校验。 当分账方类型是loginName时，本参数必传。 解绑分账关系时：作为请求参数可不填，分账关系查询时不作为返回结果返回</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 分账接收方类型。
        /// </summary>
        /// <value>分账接收方类型。</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RoyaltyEntity {\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  AccountOpenId: ").Append(AccountOpenId).Append("\n");
            sb.Append("  BindLoginName: ").Append(BindLoginName).Append("\n");
            sb.Append("  LoginName: ").Append(LoginName).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as RoyaltyEntity);
        }

        /// <summary>
        /// Returns true if RoyaltyEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of RoyaltyEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RoyaltyEntity input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.AccountOpenId == input.AccountOpenId ||
                    (this.AccountOpenId != null &&
                    this.AccountOpenId.Equals(input.AccountOpenId))
                ) && 
                (
                    this.BindLoginName == input.BindLoginName ||
                    (this.BindLoginName != null &&
                    this.BindLoginName.Equals(input.BindLoginName))
                ) && 
                (
                    this.LoginName == input.LoginName ||
                    (this.LoginName != null &&
                    this.LoginName.Equals(input.LoginName))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
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
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.AccountOpenId != null)
                {
                    hashCode = (hashCode * 59) + this.AccountOpenId.GetHashCode();
                }
                if (this.BindLoginName != null)
                {
                    hashCode = (hashCode * 59) + this.BindLoginName.GetHashCode();
                }
                if (this.LoginName != null)
                {
                    hashCode = (hashCode * 59) + this.LoginName.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
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
