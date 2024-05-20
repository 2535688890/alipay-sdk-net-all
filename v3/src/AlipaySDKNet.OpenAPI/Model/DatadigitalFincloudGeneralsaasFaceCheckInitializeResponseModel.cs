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
    /// DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel
    /// </summary>
    [DataContract(Name = "DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel")]
    public partial class DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel : IEquatable<DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel" /> class.
        /// </summary>
        /// <param name="certifyId">人脸检测流水ID，请保留方便排查问题.</param>
        /// <param name="pageUrl">检测页面url，需要给到终端SDK(该参数后续不再维护，建议使用该参数的商户进行如下升级： 1.在App端活体检测场景中使用了该参数的商户，新版客户端SDK不再依赖该参数，请参考产品官方文档接入指南中的&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/04pxpy?pathHash&#x3D;950007fa&amp;ref&#x3D;api\&quot;&gt;App端活体检测&lt;/a&gt;部分，进行客户端升级； 2.在H5活体检测场景中使用了该参数的商户，请替换为web_url进行认证。).</param>
        /// <param name="webUrl">H5活体检测地址.</param>
        public DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel(string certifyId = default(string), string pageUrl = default(string), string webUrl = default(string))
        {
            this.CertifyId = certifyId;
            this.PageUrl = pageUrl;
            this.WebUrl = webUrl;
        }

        /// <summary>
        /// 人脸检测流水ID，请保留方便排查问题
        /// </summary>
        /// <value>人脸检测流水ID，请保留方便排查问题</value>
        [DataMember(Name = "certify_id", EmitDefaultValue = false)]
        public string CertifyId { get; set; }

        /// <summary>
        /// 检测页面url，需要给到终端SDK(该参数后续不再维护，建议使用该参数的商户进行如下升级： 1.在App端活体检测场景中使用了该参数的商户，新版客户端SDK不再依赖该参数，请参考产品官方文档接入指南中的&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/04pxpy?pathHash&#x3D;950007fa&amp;ref&#x3D;api\&quot;&gt;App端活体检测&lt;/a&gt;部分，进行客户端升级； 2.在H5活体检测场景中使用了该参数的商户，请替换为web_url进行认证。)
        /// </summary>
        /// <value>检测页面url，需要给到终端SDK(该参数后续不再维护，建议使用该参数的商户进行如下升级： 1.在App端活体检测场景中使用了该参数的商户，新版客户端SDK不再依赖该参数，请参考产品官方文档接入指南中的&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/open/04pxpy?pathHash&#x3D;950007fa&amp;ref&#x3D;api\&quot;&gt;App端活体检测&lt;/a&gt;部分，进行客户端升级； 2.在H5活体检测场景中使用了该参数的商户，请替换为web_url进行认证。)</value>
        [DataMember(Name = "page_url", EmitDefaultValue = false)]
        [Obsolete]
        public string PageUrl { get; set; }

        /// <summary>
        /// H5活体检测地址
        /// </summary>
        /// <value>H5活体检测地址</value>
        [DataMember(Name = "web_url", EmitDefaultValue = false)]
        public string WebUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel {\n");
            sb.Append("  CertifyId: ").Append(CertifyId).Append("\n");
            sb.Append("  PageUrl: ").Append(PageUrl).Append("\n");
            sb.Append("  WebUrl: ").Append(WebUrl).Append("\n");
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
            return this.Equals(input as DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel);
        }

        /// <summary>
        /// Returns true if DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DatadigitalFincloudGeneralsaasFaceCheckInitializeResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CertifyId == input.CertifyId ||
                    (this.CertifyId != null &&
                    this.CertifyId.Equals(input.CertifyId))
                ) && 
                (
                    this.PageUrl == input.PageUrl ||
                    (this.PageUrl != null &&
                    this.PageUrl.Equals(input.PageUrl))
                ) && 
                (
                    this.WebUrl == input.WebUrl ||
                    (this.WebUrl != null &&
                    this.WebUrl.Equals(input.WebUrl))
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
                if (this.CertifyId != null)
                {
                    hashCode = (hashCode * 59) + this.CertifyId.GetHashCode();
                }
                if (this.PageUrl != null)
                {
                    hashCode = (hashCode * 59) + this.PageUrl.GetHashCode();
                }
                if (this.WebUrl != null)
                {
                    hashCode = (hashCode * 59) + this.WebUrl.GetHashCode();
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
