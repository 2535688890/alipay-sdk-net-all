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
    /// AuthFieldApply
    /// </summary>
    [DataContract(Name = "AuthFieldApply")]
    public partial class AuthFieldApply : IEquatable<AuthFieldApply>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthFieldApply" /> class.
        /// </summary>
        /// <param name="apiName">接口英文名称，通过alipay.open.app.api.query接口查询获得。.</param>
        /// <param name="customerAnswer">贵公司是否有自己的客服渠道，能及时响应和处理舆情数量是多少？.</param>
        /// <param name="fieldName">字段英文名称，通过alipay.open.app.api.query接口查询获得。.</param>
        /// <param name="memo">备注.</param>
        /// <param name="packageCode">功能code，通过alipay.open.app.api.query接口查询获得.</param>
        /// <param name="qpsAnswer">接入后一年内预计接口秒级调用量峰值是多少？（最高峰值：1000QPS）.</param>
        /// <param name="sceneCode">场景code，alipay.open.app.api.scene.query 接口查询获得.</param>
        /// <param name="tinyAppTemplateId">当为使用使用模板的小程序申请时可传入所使用的小程序模板id.</param>
        public AuthFieldApply(string apiName = default(string), string customerAnswer = default(string), string fieldName = default(string), string memo = default(string), string packageCode = default(string), string qpsAnswer = default(string), string sceneCode = default(string), string tinyAppTemplateId = default(string))
        {
            this.ApiName = apiName;
            this.CustomerAnswer = customerAnswer;
            this.FieldName = fieldName;
            this.Memo = memo;
            this.PackageCode = packageCode;
            this.QpsAnswer = qpsAnswer;
            this.SceneCode = sceneCode;
            this.TinyAppTemplateId = tinyAppTemplateId;
        }

        /// <summary>
        /// 接口英文名称，通过alipay.open.app.api.query接口查询获得。
        /// </summary>
        /// <value>接口英文名称，通过alipay.open.app.api.query接口查询获得。</value>
        [DataMember(Name = "api_name", EmitDefaultValue = false)]
        public string ApiName { get; set; }

        /// <summary>
        /// 贵公司是否有自己的客服渠道，能及时响应和处理舆情数量是多少？
        /// </summary>
        /// <value>贵公司是否有自己的客服渠道，能及时响应和处理舆情数量是多少？</value>
        [DataMember(Name = "customer_answer", EmitDefaultValue = false)]
        public string CustomerAnswer { get; set; }

        /// <summary>
        /// 字段英文名称，通过alipay.open.app.api.query接口查询获得。
        /// </summary>
        /// <value>字段英文名称，通过alipay.open.app.api.query接口查询获得。</value>
        [DataMember(Name = "field_name", EmitDefaultValue = false)]
        public string FieldName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "memo", EmitDefaultValue = false)]
        public string Memo { get; set; }

        /// <summary>
        /// 功能code，通过alipay.open.app.api.query接口查询获得
        /// </summary>
        /// <value>功能code，通过alipay.open.app.api.query接口查询获得</value>
        [DataMember(Name = "package_code", EmitDefaultValue = false)]
        public string PackageCode { get; set; }

        /// <summary>
        /// 接入后一年内预计接口秒级调用量峰值是多少？（最高峰值：1000QPS）
        /// </summary>
        /// <value>接入后一年内预计接口秒级调用量峰值是多少？（最高峰值：1000QPS）</value>
        [DataMember(Name = "qps_answer", EmitDefaultValue = false)]
        public string QpsAnswer { get; set; }

        /// <summary>
        /// 场景code，alipay.open.app.api.scene.query 接口查询获得
        /// </summary>
        /// <value>场景code，alipay.open.app.api.scene.query 接口查询获得</value>
        [DataMember(Name = "scene_code", EmitDefaultValue = false)]
        public string SceneCode { get; set; }

        /// <summary>
        /// 当为使用使用模板的小程序申请时可传入所使用的小程序模板id
        /// </summary>
        /// <value>当为使用使用模板的小程序申请时可传入所使用的小程序模板id</value>
        [DataMember(Name = "tiny_app_template_id", EmitDefaultValue = false)]
        public string TinyAppTemplateId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AuthFieldApply {\n");
            sb.Append("  ApiName: ").Append(ApiName).Append("\n");
            sb.Append("  CustomerAnswer: ").Append(CustomerAnswer).Append("\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  PackageCode: ").Append(PackageCode).Append("\n");
            sb.Append("  QpsAnswer: ").Append(QpsAnswer).Append("\n");
            sb.Append("  SceneCode: ").Append(SceneCode).Append("\n");
            sb.Append("  TinyAppTemplateId: ").Append(TinyAppTemplateId).Append("\n");
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
            return this.Equals(input as AuthFieldApply);
        }

        /// <summary>
        /// Returns true if AuthFieldApply instances are equal
        /// </summary>
        /// <param name="input">Instance of AuthFieldApply to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuthFieldApply input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ApiName == input.ApiName ||
                    (this.ApiName != null &&
                    this.ApiName.Equals(input.ApiName))
                ) && 
                (
                    this.CustomerAnswer == input.CustomerAnswer ||
                    (this.CustomerAnswer != null &&
                    this.CustomerAnswer.Equals(input.CustomerAnswer))
                ) && 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.PackageCode == input.PackageCode ||
                    (this.PackageCode != null &&
                    this.PackageCode.Equals(input.PackageCode))
                ) && 
                (
                    this.QpsAnswer == input.QpsAnswer ||
                    (this.QpsAnswer != null &&
                    this.QpsAnswer.Equals(input.QpsAnswer))
                ) && 
                (
                    this.SceneCode == input.SceneCode ||
                    (this.SceneCode != null &&
                    this.SceneCode.Equals(input.SceneCode))
                ) && 
                (
                    this.TinyAppTemplateId == input.TinyAppTemplateId ||
                    (this.TinyAppTemplateId != null &&
                    this.TinyAppTemplateId.Equals(input.TinyAppTemplateId))
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
                if (this.ApiName != null)
                {
                    hashCode = (hashCode * 59) + this.ApiName.GetHashCode();
                }
                if (this.CustomerAnswer != null)
                {
                    hashCode = (hashCode * 59) + this.CustomerAnswer.GetHashCode();
                }
                if (this.FieldName != null)
                {
                    hashCode = (hashCode * 59) + this.FieldName.GetHashCode();
                }
                if (this.Memo != null)
                {
                    hashCode = (hashCode * 59) + this.Memo.GetHashCode();
                }
                if (this.PackageCode != null)
                {
                    hashCode = (hashCode * 59) + this.PackageCode.GetHashCode();
                }
                if (this.QpsAnswer != null)
                {
                    hashCode = (hashCode * 59) + this.QpsAnswer.GetHashCode();
                }
                if (this.SceneCode != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCode.GetHashCode();
                }
                if (this.TinyAppTemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TinyAppTemplateId.GetHashCode();
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
