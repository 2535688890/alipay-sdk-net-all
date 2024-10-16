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
    /// AntMerchantExpandShopReceiptaccountSaveModel
    /// </summary>
    [DataContract(Name = "AntMerchantExpandShopReceiptaccountSaveModel")]
    public partial class AntMerchantExpandShopReceiptaccountSaveModel : IEquatable<AntMerchantExpandShopReceiptaccountSaveModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AntMerchantExpandShopReceiptaccountSaveModel" /> class.
        /// </summary>
        /// <param name="promise">是否承诺收单账号信息准确。具体承诺信息可查看 &lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/bmw-prod/922bafa8-a712-4f79-aa32-6f08d7359a5c.docx\&quot;&gt;门店信息承诺函&lt;/a&gt;。 Y 是 N 否.</param>
        /// <param name="receiptAccountId">收单账号.</param>
        /// <param name="shopId">店铺ID.</param>
        public AntMerchantExpandShopReceiptaccountSaveModel(string promise = default(string), string receiptAccountId = default(string), string shopId = default(string))
        {
            this.Promise = promise;
            this.ReceiptAccountId = receiptAccountId;
            this.ShopId = shopId;
        }

        /// <summary>
        /// 是否承诺收单账号信息准确。具体承诺信息可查看 &lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/bmw-prod/922bafa8-a712-4f79-aa32-6f08d7359a5c.docx\&quot;&gt;门店信息承诺函&lt;/a&gt;。 Y 是 N 否
        /// </summary>
        /// <value>是否承诺收单账号信息准确。具体承诺信息可查看 &lt;a href&#x3D;\&quot;https://gw.alipayobjects.com/os/bmw-prod/922bafa8-a712-4f79-aa32-6f08d7359a5c.docx\&quot;&gt;门店信息承诺函&lt;/a&gt;。 Y 是 N 否</value>
        [DataMember(Name = "promise", EmitDefaultValue = false)]
        public string Promise { get; set; }

        /// <summary>
        /// 收单账号
        /// </summary>
        /// <value>收单账号</value>
        [DataMember(Name = "receipt_account_id", EmitDefaultValue = false)]
        public string ReceiptAccountId { get; set; }

        /// <summary>
        /// 店铺ID
        /// </summary>
        /// <value>店铺ID</value>
        [DataMember(Name = "shop_id", EmitDefaultValue = false)]
        public string ShopId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AntMerchantExpandShopReceiptaccountSaveModel {\n");
            sb.Append("  Promise: ").Append(Promise).Append("\n");
            sb.Append("  ReceiptAccountId: ").Append(ReceiptAccountId).Append("\n");
            sb.Append("  ShopId: ").Append(ShopId).Append("\n");
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
            return this.Equals(input as AntMerchantExpandShopReceiptaccountSaveModel);
        }

        /// <summary>
        /// Returns true if AntMerchantExpandShopReceiptaccountSaveModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AntMerchantExpandShopReceiptaccountSaveModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AntMerchantExpandShopReceiptaccountSaveModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Promise == input.Promise ||
                    (this.Promise != null &&
                    this.Promise.Equals(input.Promise))
                ) && 
                (
                    this.ReceiptAccountId == input.ReceiptAccountId ||
                    (this.ReceiptAccountId != null &&
                    this.ReceiptAccountId.Equals(input.ReceiptAccountId))
                ) && 
                (
                    this.ShopId == input.ShopId ||
                    (this.ShopId != null &&
                    this.ShopId.Equals(input.ShopId))
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
                if (this.Promise != null)
                {
                    hashCode = (hashCode * 59) + this.Promise.GetHashCode();
                }
                if (this.ReceiptAccountId != null)
                {
                    hashCode = (hashCode * 59) + this.ReceiptAccountId.GetHashCode();
                }
                if (this.ShopId != null)
                {
                    hashCode = (hashCode * 59) + this.ShopId.GetHashCode();
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
