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
    /// OrderExtIstd
    /// </summary>
    [DataContract(Name = "OrderExtIstd")]
    public partial class OrderExtIstd : IEquatable<OrderExtIstd>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OrderExtIstd" /> class.
        /// </summary>
        /// <param name="cashOnDelivery">骑手应付金额.</param>
        /// <param name="cashOnPickup">骑手应收金额.</param>
        /// <param name="consumerOrderTime">消费者下单时间.</param>
        /// <param name="deliveryDirection">物流流向，1：从门店取件送至用户；2：从用户取件送至门店.</param>
        /// <param name="deliveryType">配送类型, 0: 即时单 1 预约单.</param>
        /// <param name="desc">备注.</param>
        /// <param name="expectedDeliveryTime">期望派单时间.</param>
        /// <param name="expectedFinishTime">期望送达时间.</param>
        /// <param name="expectedPickTime">期望取件时间.</param>
        /// <param name="insurePrice">保价金额.</param>
        /// <param name="isDirectDelivery">是否直拿直送，1:直拿直送 0:非直拿直送.</param>
        /// <param name="isFinishCodeNeeded">是否需要收货码，1:需要 0:不需要.</param>
        /// <param name="isInsured">是否保价，1:保价 0:不保价.</param>
        /// <param name="isPickupCodeNeeded">是否需要取货码，1:需要 0:不需要.</param>
        /// <param name="poiSeq">门店订单流水号.</param>
        /// <param name="serviceCode">即时配送公司的服务代码.</param>
        public OrderExtIstd(string cashOnDelivery = default(string), string cashOnPickup = default(string), string consumerOrderTime = default(string), int deliveryDirection = default(int), int deliveryType = default(int), string desc = default(string), string expectedDeliveryTime = default(string), string expectedFinishTime = default(string), string expectedPickTime = default(string), string insurePrice = default(string), int isDirectDelivery = default(int), int isFinishCodeNeeded = default(int), int isInsured = default(int), int isPickupCodeNeeded = default(int), string poiSeq = default(string), string serviceCode = default(string))
        {
            this.CashOnDelivery = cashOnDelivery;
            this.CashOnPickup = cashOnPickup;
            this.ConsumerOrderTime = consumerOrderTime;
            this.DeliveryDirection = deliveryDirection;
            this.DeliveryType = deliveryType;
            this.Desc = desc;
            this.ExpectedDeliveryTime = expectedDeliveryTime;
            this.ExpectedFinishTime = expectedFinishTime;
            this.ExpectedPickTime = expectedPickTime;
            this.InsurePrice = insurePrice;
            this.IsDirectDelivery = isDirectDelivery;
            this.IsFinishCodeNeeded = isFinishCodeNeeded;
            this.IsInsured = isInsured;
            this.IsPickupCodeNeeded = isPickupCodeNeeded;
            this.PoiSeq = poiSeq;
            this.ServiceCode = serviceCode;
        }

        /// <summary>
        /// 骑手应付金额
        /// </summary>
        /// <value>骑手应付金额</value>
        [DataMember(Name = "cash_on_delivery", EmitDefaultValue = false)]
        public string CashOnDelivery { get; set; }

        /// <summary>
        /// 骑手应收金额
        /// </summary>
        /// <value>骑手应收金额</value>
        [DataMember(Name = "cash_on_pickup", EmitDefaultValue = false)]
        public string CashOnPickup { get; set; }

        /// <summary>
        /// 消费者下单时间
        /// </summary>
        /// <value>消费者下单时间</value>
        [DataMember(Name = "consumer_order_time", EmitDefaultValue = false)]
        public string ConsumerOrderTime { get; set; }

        /// <summary>
        /// 物流流向，1：从门店取件送至用户；2：从用户取件送至门店
        /// </summary>
        /// <value>物流流向，1：从门店取件送至用户；2：从用户取件送至门店</value>
        [DataMember(Name = "delivery_direction", EmitDefaultValue = false)]
        public int DeliveryDirection { get; set; }

        /// <summary>
        /// 配送类型, 0: 即时单 1 预约单
        /// </summary>
        /// <value>配送类型, 0: 即时单 1 预约单</value>
        [DataMember(Name = "delivery_type", EmitDefaultValue = false)]
        public int DeliveryType { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        /// <value>备注</value>
        [DataMember(Name = "desc", EmitDefaultValue = false)]
        public string Desc { get; set; }

        /// <summary>
        /// 期望派单时间
        /// </summary>
        /// <value>期望派单时间</value>
        [DataMember(Name = "expected_delivery_time", EmitDefaultValue = false)]
        public string ExpectedDeliveryTime { get; set; }

        /// <summary>
        /// 期望送达时间
        /// </summary>
        /// <value>期望送达时间</value>
        [DataMember(Name = "expected_finish_time", EmitDefaultValue = false)]
        public string ExpectedFinishTime { get; set; }

        /// <summary>
        /// 期望取件时间
        /// </summary>
        /// <value>期望取件时间</value>
        [DataMember(Name = "expected_pick_time", EmitDefaultValue = false)]
        public string ExpectedPickTime { get; set; }

        /// <summary>
        /// 保价金额
        /// </summary>
        /// <value>保价金额</value>
        [DataMember(Name = "insure_price", EmitDefaultValue = false)]
        public string InsurePrice { get; set; }

        /// <summary>
        /// 是否直拿直送，1:直拿直送 0:非直拿直送
        /// </summary>
        /// <value>是否直拿直送，1:直拿直送 0:非直拿直送</value>
        [DataMember(Name = "is_direct_delivery", EmitDefaultValue = false)]
        public int IsDirectDelivery { get; set; }

        /// <summary>
        /// 是否需要收货码，1:需要 0:不需要
        /// </summary>
        /// <value>是否需要收货码，1:需要 0:不需要</value>
        [DataMember(Name = "is_finish_code_needed", EmitDefaultValue = false)]
        public int IsFinishCodeNeeded { get; set; }

        /// <summary>
        /// 是否保价，1:保价 0:不保价
        /// </summary>
        /// <value>是否保价，1:保价 0:不保价</value>
        [DataMember(Name = "is_insured", EmitDefaultValue = false)]
        public int IsInsured { get; set; }

        /// <summary>
        /// 是否需要取货码，1:需要 0:不需要
        /// </summary>
        /// <value>是否需要取货码，1:需要 0:不需要</value>
        [DataMember(Name = "is_pickup_code_needed", EmitDefaultValue = false)]
        public int IsPickupCodeNeeded { get; set; }

        /// <summary>
        /// 门店订单流水号
        /// </summary>
        /// <value>门店订单流水号</value>
        [DataMember(Name = "poi_seq", EmitDefaultValue = false)]
        public string PoiSeq { get; set; }

        /// <summary>
        /// 即时配送公司的服务代码
        /// </summary>
        /// <value>即时配送公司的服务代码</value>
        [DataMember(Name = "service_code", EmitDefaultValue = false)]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrderExtIstd {\n");
            sb.Append("  CashOnDelivery: ").Append(CashOnDelivery).Append("\n");
            sb.Append("  CashOnPickup: ").Append(CashOnPickup).Append("\n");
            sb.Append("  ConsumerOrderTime: ").Append(ConsumerOrderTime).Append("\n");
            sb.Append("  DeliveryDirection: ").Append(DeliveryDirection).Append("\n");
            sb.Append("  DeliveryType: ").Append(DeliveryType).Append("\n");
            sb.Append("  Desc: ").Append(Desc).Append("\n");
            sb.Append("  ExpectedDeliveryTime: ").Append(ExpectedDeliveryTime).Append("\n");
            sb.Append("  ExpectedFinishTime: ").Append(ExpectedFinishTime).Append("\n");
            sb.Append("  ExpectedPickTime: ").Append(ExpectedPickTime).Append("\n");
            sb.Append("  InsurePrice: ").Append(InsurePrice).Append("\n");
            sb.Append("  IsDirectDelivery: ").Append(IsDirectDelivery).Append("\n");
            sb.Append("  IsFinishCodeNeeded: ").Append(IsFinishCodeNeeded).Append("\n");
            sb.Append("  IsInsured: ").Append(IsInsured).Append("\n");
            sb.Append("  IsPickupCodeNeeded: ").Append(IsPickupCodeNeeded).Append("\n");
            sb.Append("  PoiSeq: ").Append(PoiSeq).Append("\n");
            sb.Append("  ServiceCode: ").Append(ServiceCode).Append("\n");
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
            return this.Equals(input as OrderExtIstd);
        }

        /// <summary>
        /// Returns true if OrderExtIstd instances are equal
        /// </summary>
        /// <param name="input">Instance of OrderExtIstd to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrderExtIstd input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CashOnDelivery == input.CashOnDelivery ||
                    (this.CashOnDelivery != null &&
                    this.CashOnDelivery.Equals(input.CashOnDelivery))
                ) && 
                (
                    this.CashOnPickup == input.CashOnPickup ||
                    (this.CashOnPickup != null &&
                    this.CashOnPickup.Equals(input.CashOnPickup))
                ) && 
                (
                    this.ConsumerOrderTime == input.ConsumerOrderTime ||
                    (this.ConsumerOrderTime != null &&
                    this.ConsumerOrderTime.Equals(input.ConsumerOrderTime))
                ) && 
                (
                    this.DeliveryDirection == input.DeliveryDirection ||
                    this.DeliveryDirection.Equals(input.DeliveryDirection)
                ) && 
                (
                    this.DeliveryType == input.DeliveryType ||
                    this.DeliveryType.Equals(input.DeliveryType)
                ) && 
                (
                    this.Desc == input.Desc ||
                    (this.Desc != null &&
                    this.Desc.Equals(input.Desc))
                ) && 
                (
                    this.ExpectedDeliveryTime == input.ExpectedDeliveryTime ||
                    (this.ExpectedDeliveryTime != null &&
                    this.ExpectedDeliveryTime.Equals(input.ExpectedDeliveryTime))
                ) && 
                (
                    this.ExpectedFinishTime == input.ExpectedFinishTime ||
                    (this.ExpectedFinishTime != null &&
                    this.ExpectedFinishTime.Equals(input.ExpectedFinishTime))
                ) && 
                (
                    this.ExpectedPickTime == input.ExpectedPickTime ||
                    (this.ExpectedPickTime != null &&
                    this.ExpectedPickTime.Equals(input.ExpectedPickTime))
                ) && 
                (
                    this.InsurePrice == input.InsurePrice ||
                    (this.InsurePrice != null &&
                    this.InsurePrice.Equals(input.InsurePrice))
                ) && 
                (
                    this.IsDirectDelivery == input.IsDirectDelivery ||
                    this.IsDirectDelivery.Equals(input.IsDirectDelivery)
                ) && 
                (
                    this.IsFinishCodeNeeded == input.IsFinishCodeNeeded ||
                    this.IsFinishCodeNeeded.Equals(input.IsFinishCodeNeeded)
                ) && 
                (
                    this.IsInsured == input.IsInsured ||
                    this.IsInsured.Equals(input.IsInsured)
                ) && 
                (
                    this.IsPickupCodeNeeded == input.IsPickupCodeNeeded ||
                    this.IsPickupCodeNeeded.Equals(input.IsPickupCodeNeeded)
                ) && 
                (
                    this.PoiSeq == input.PoiSeq ||
                    (this.PoiSeq != null &&
                    this.PoiSeq.Equals(input.PoiSeq))
                ) && 
                (
                    this.ServiceCode == input.ServiceCode ||
                    (this.ServiceCode != null &&
                    this.ServiceCode.Equals(input.ServiceCode))
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
                if (this.CashOnDelivery != null)
                {
                    hashCode = (hashCode * 59) + this.CashOnDelivery.GetHashCode();
                }
                if (this.CashOnPickup != null)
                {
                    hashCode = (hashCode * 59) + this.CashOnPickup.GetHashCode();
                }
                if (this.ConsumerOrderTime != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumerOrderTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.DeliveryDirection.GetHashCode();
                hashCode = (hashCode * 59) + this.DeliveryType.GetHashCode();
                if (this.Desc != null)
                {
                    hashCode = (hashCode * 59) + this.Desc.GetHashCode();
                }
                if (this.ExpectedDeliveryTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedDeliveryTime.GetHashCode();
                }
                if (this.ExpectedFinishTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedFinishTime.GetHashCode();
                }
                if (this.ExpectedPickTime != null)
                {
                    hashCode = (hashCode * 59) + this.ExpectedPickTime.GetHashCode();
                }
                if (this.InsurePrice != null)
                {
                    hashCode = (hashCode * 59) + this.InsurePrice.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsDirectDelivery.GetHashCode();
                hashCode = (hashCode * 59) + this.IsFinishCodeNeeded.GetHashCode();
                hashCode = (hashCode * 59) + this.IsInsured.GetHashCode();
                hashCode = (hashCode * 59) + this.IsPickupCodeNeeded.GetHashCode();
                if (this.PoiSeq != null)
                {
                    hashCode = (hashCode * 59) + this.PoiSeq.GetHashCode();
                }
                if (this.ServiceCode != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceCode.GetHashCode();
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
