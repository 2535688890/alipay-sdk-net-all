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
    /// AlipayEcoMycarParkingEnterinfoSyncModel
    /// </summary>
    [DataContract(Name = "AlipayEcoMycarParkingEnterinfoSyncModel")]
    public partial class AlipayEcoMycarParkingEnterinfoSyncModel : IEquatable<AlipayEcoMycarParkingEnterinfoSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayEcoMycarParkingEnterinfoSyncModel" /> class.
        /// </summary>
        /// <param name="agreementQuery">是否启用车牌代扣状态查询功能，true为启用，false为停用.</param>
        /// <param name="carColor">车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。.</param>
        /// <param name="carNumber">车牌号.</param>
        /// <param name="entranceId">用于识别车辆进口，多出入口车场适用.</param>
        /// <param name="freeMinutes">当前停车场的入场免费时长分钟数.</param>
        /// <param name="inTime">车辆入场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间.</param>
        /// <param name="isEncryptCarNumber">是否加密，默认为false.</param>
        /// <param name="isvUrl">智能助理当前的跳转链接。为ISV/&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb18\&quot;&gt;商家小程序scheme地址&lt;/a&gt;或H5页面地址。.</param>
        /// <param name="outSerialNo">外部停车流水号(用于串通进场与出场信息).</param>
        /// <param name="parkingId">支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create\&quot;&gt;alipay.eco.mycar.parking.parkinglotinfo.create&lt;/a&gt;(录入停车场信息)接口获取。.</param>
        /// <param name="spaceNumber">用于标识车辆停放车位编号，路侧适用.</param>
        /// <param name="storeId">与parking_id对应的外部停车场编号，在门店中维护.</param>
        public AlipayEcoMycarParkingEnterinfoSyncModel(bool agreementQuery = default(bool), string carColor = default(string), string carNumber = default(string), string entranceId = default(string), int freeMinutes = default(int), string inTime = default(string), bool isEncryptCarNumber = default(bool), string isvUrl = default(string), string outSerialNo = default(string), string parkingId = default(string), string spaceNumber = default(string), string storeId = default(string))
        {
            this.AgreementQuery = agreementQuery;
            this.CarColor = carColor;
            this.CarNumber = carNumber;
            this.EntranceId = entranceId;
            this.FreeMinutes = freeMinutes;
            this.InTime = inTime;
            this.IsEncryptCarNumber = isEncryptCarNumber;
            this.IsvUrl = isvUrl;
            this.OutSerialNo = outSerialNo;
            this.ParkingId = parkingId;
            this.SpaceNumber = spaceNumber;
            this.StoreId = storeId;
        }

        /// <summary>
        /// 是否启用车牌代扣状态查询功能，true为启用，false为停用
        /// </summary>
        /// <value>是否启用车牌代扣状态查询功能，true为启用，false为停用</value>
        [DataMember(Name = "agreement_query", EmitDefaultValue = true)]
        public bool AgreementQuery { get; set; }

        /// <summary>
        /// 车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。
        /// </summary>
        /// <value>车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。</value>
        [DataMember(Name = "car_color", EmitDefaultValue = false)]
        public string CarColor { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        /// <value>车牌号</value>
        [DataMember(Name = "car_number", EmitDefaultValue = false)]
        public string CarNumber { get; set; }

        /// <summary>
        /// 用于识别车辆进口，多出入口车场适用
        /// </summary>
        /// <value>用于识别车辆进口，多出入口车场适用</value>
        [DataMember(Name = "entrance_id", EmitDefaultValue = false)]
        public string EntranceId { get; set; }

        /// <summary>
        /// 当前停车场的入场免费时长分钟数
        /// </summary>
        /// <value>当前停车场的入场免费时长分钟数</value>
        [DataMember(Name = "free_minutes", EmitDefaultValue = false)]
        public int FreeMinutes { get; set; }

        /// <summary>
        /// 车辆入场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间
        /// </summary>
        /// <value>车辆入场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间</value>
        [DataMember(Name = "in_time", EmitDefaultValue = false)]
        public string InTime { get; set; }

        /// <summary>
        /// 是否加密，默认为false
        /// </summary>
        /// <value>是否加密，默认为false</value>
        [DataMember(Name = "is_encrypt_car_number", EmitDefaultValue = true)]
        public bool IsEncryptCarNumber { get; set; }

        /// <summary>
        /// 智能助理当前的跳转链接。为ISV/&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb18\&quot;&gt;商家小程序scheme地址&lt;/a&gt;或H5页面地址。
        /// </summary>
        /// <value>智能助理当前的跳转链接。为ISV/&lt;a href&#x3D;\&quot;https://opendocs.alipay.com/support/01rb18\&quot;&gt;商家小程序scheme地址&lt;/a&gt;或H5页面地址。</value>
        [DataMember(Name = "isv_url", EmitDefaultValue = false)]
        public string IsvUrl { get; set; }

        /// <summary>
        /// 外部停车流水号(用于串通进场与出场信息)
        /// </summary>
        /// <value>外部停车流水号(用于串通进场与出场信息)</value>
        [DataMember(Name = "out_serial_no", EmitDefaultValue = false)]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create\&quot;&gt;alipay.eco.mycar.parking.parkinglotinfo.create&lt;/a&gt;(录入停车场信息)接口获取。
        /// </summary>
        /// <value>支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 &lt;a href&#x3D;\&quot;https://opendocs.alipay.com/apis/api_19/alipay.eco.mycar.parking.parkinglotinfo.create\&quot;&gt;alipay.eco.mycar.parking.parkinglotinfo.create&lt;/a&gt;(录入停车场信息)接口获取。</value>
        [DataMember(Name = "parking_id", EmitDefaultValue = false)]
        public string ParkingId { get; set; }

        /// <summary>
        /// 用于标识车辆停放车位编号，路侧适用
        /// </summary>
        /// <value>用于标识车辆停放车位编号，路侧适用</value>
        [DataMember(Name = "space_number", EmitDefaultValue = false)]
        public string SpaceNumber { get; set; }

        /// <summary>
        /// 与parking_id对应的外部停车场编号，在门店中维护
        /// </summary>
        /// <value>与parking_id对应的外部停车场编号，在门店中维护</value>
        [DataMember(Name = "store_id", EmitDefaultValue = false)]
        public string StoreId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayEcoMycarParkingEnterinfoSyncModel {\n");
            sb.Append("  AgreementQuery: ").Append(AgreementQuery).Append("\n");
            sb.Append("  CarColor: ").Append(CarColor).Append("\n");
            sb.Append("  CarNumber: ").Append(CarNumber).Append("\n");
            sb.Append("  EntranceId: ").Append(EntranceId).Append("\n");
            sb.Append("  FreeMinutes: ").Append(FreeMinutes).Append("\n");
            sb.Append("  InTime: ").Append(InTime).Append("\n");
            sb.Append("  IsEncryptCarNumber: ").Append(IsEncryptCarNumber).Append("\n");
            sb.Append("  IsvUrl: ").Append(IsvUrl).Append("\n");
            sb.Append("  OutSerialNo: ").Append(OutSerialNo).Append("\n");
            sb.Append("  ParkingId: ").Append(ParkingId).Append("\n");
            sb.Append("  SpaceNumber: ").Append(SpaceNumber).Append("\n");
            sb.Append("  StoreId: ").Append(StoreId).Append("\n");
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
            return this.Equals(input as AlipayEcoMycarParkingEnterinfoSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayEcoMycarParkingEnterinfoSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayEcoMycarParkingEnterinfoSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayEcoMycarParkingEnterinfoSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.AgreementQuery == input.AgreementQuery ||
                    this.AgreementQuery.Equals(input.AgreementQuery)
                ) && 
                (
                    this.CarColor == input.CarColor ||
                    (this.CarColor != null &&
                    this.CarColor.Equals(input.CarColor))
                ) && 
                (
                    this.CarNumber == input.CarNumber ||
                    (this.CarNumber != null &&
                    this.CarNumber.Equals(input.CarNumber))
                ) && 
                (
                    this.EntranceId == input.EntranceId ||
                    (this.EntranceId != null &&
                    this.EntranceId.Equals(input.EntranceId))
                ) && 
                (
                    this.FreeMinutes == input.FreeMinutes ||
                    this.FreeMinutes.Equals(input.FreeMinutes)
                ) && 
                (
                    this.InTime == input.InTime ||
                    (this.InTime != null &&
                    this.InTime.Equals(input.InTime))
                ) && 
                (
                    this.IsEncryptCarNumber == input.IsEncryptCarNumber ||
                    this.IsEncryptCarNumber.Equals(input.IsEncryptCarNumber)
                ) && 
                (
                    this.IsvUrl == input.IsvUrl ||
                    (this.IsvUrl != null &&
                    this.IsvUrl.Equals(input.IsvUrl))
                ) && 
                (
                    this.OutSerialNo == input.OutSerialNo ||
                    (this.OutSerialNo != null &&
                    this.OutSerialNo.Equals(input.OutSerialNo))
                ) && 
                (
                    this.ParkingId == input.ParkingId ||
                    (this.ParkingId != null &&
                    this.ParkingId.Equals(input.ParkingId))
                ) && 
                (
                    this.SpaceNumber == input.SpaceNumber ||
                    (this.SpaceNumber != null &&
                    this.SpaceNumber.Equals(input.SpaceNumber))
                ) && 
                (
                    this.StoreId == input.StoreId ||
                    (this.StoreId != null &&
                    this.StoreId.Equals(input.StoreId))
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
                hashCode = (hashCode * 59) + this.AgreementQuery.GetHashCode();
                if (this.CarColor != null)
                {
                    hashCode = (hashCode * 59) + this.CarColor.GetHashCode();
                }
                if (this.CarNumber != null)
                {
                    hashCode = (hashCode * 59) + this.CarNumber.GetHashCode();
                }
                if (this.EntranceId != null)
                {
                    hashCode = (hashCode * 59) + this.EntranceId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.FreeMinutes.GetHashCode();
                if (this.InTime != null)
                {
                    hashCode = (hashCode * 59) + this.InTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEncryptCarNumber.GetHashCode();
                if (this.IsvUrl != null)
                {
                    hashCode = (hashCode * 59) + this.IsvUrl.GetHashCode();
                }
                if (this.OutSerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutSerialNo.GetHashCode();
                }
                if (this.ParkingId != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingId.GetHashCode();
                }
                if (this.SpaceNumber != null)
                {
                    hashCode = (hashCode * 59) + this.SpaceNumber.GetHashCode();
                }
                if (this.StoreId != null)
                {
                    hashCode = (hashCode * 59) + this.StoreId.GetHashCode();
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
