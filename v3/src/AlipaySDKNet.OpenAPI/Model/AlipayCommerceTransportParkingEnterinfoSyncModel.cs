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
    /// AlipayCommerceTransportParkingEnterinfoSyncModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceTransportParkingEnterinfoSyncModel")]
    public partial class AlipayCommerceTransportParkingEnterinfoSyncModel : IEquatable<AlipayCommerceTransportParkingEnterinfoSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceTransportParkingEnterinfoSyncModel" /> class.
        /// </summary>
        /// <param name="agreementQuery">是否启用车牌代扣状态查询功能，true为启用，false为停用.</param>
        /// <param name="chargeInfoList">本次行程收费计划清单.</param>
        /// <param name="entranceName">车辆进入停车场的入口通道名称.</param>
        /// <param name="entranceNumber">车辆进入停车场的入口通道编号；按线下实际编号为准；.</param>
        /// <param name="freeEnterMinutes">当前停车场的入场免费时长分钟数.</param>
        /// <param name="inTime">车辆入场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间.</param>
        /// <param name="isEncryptPlateNo">车牌是否加密，true为加密，false为不加密，默认为false.</param>
        /// <param name="membershipInfo">membershipInfo.</param>
        /// <param name="needCharge">当前行程是否需要计费。true：需要，false：不需要。不传默认为true。.</param>
        /// <param name="openAppid">蚂蚁会员统一ID对应的归属应用appid.</param>
        /// <param name="openId">蚂蚁会员统一ID.</param>
        /// <param name="outSerialNo">外部停车流水号(用于串通进场与出场信息).</param>
        /// <param name="parkingId">支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create (录入停车场信息)接口获取。.</param>
        /// <param name="plateColor">车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。.</param>
        /// <param name="plateNo">车牌号（支持加密格式）.</param>
        /// <param name="serviceUrl">停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F  2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex  3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex.</param>
        public AlipayCommerceTransportParkingEnterinfoSyncModel(bool agreementQuery = default(bool), List<ParkingChargeInfo> chargeInfoList = default(List<ParkingChargeInfo>), string entranceName = default(string), int entranceNumber = default(int), string freeEnterMinutes = default(string), string inTime = default(string), bool isEncryptPlateNo = default(bool), ParkingMembershipInfo membershipInfo = default(ParkingMembershipInfo), bool needCharge = default(bool), string openAppid = default(string), string openId = default(string), string outSerialNo = default(string), string parkingId = default(string), string plateColor = default(string), string plateNo = default(string), string serviceUrl = default(string))
        {
            this.AgreementQuery = agreementQuery;
            this.ChargeInfoList = chargeInfoList;
            this.EntranceName = entranceName;
            this.EntranceNumber = entranceNumber;
            this.FreeEnterMinutes = freeEnterMinutes;
            this.InTime = inTime;
            this.IsEncryptPlateNo = isEncryptPlateNo;
            this.MembershipInfo = membershipInfo;
            this.NeedCharge = needCharge;
            this.OpenAppid = openAppid;
            this.OpenId = openId;
            this.OutSerialNo = outSerialNo;
            this.ParkingId = parkingId;
            this.PlateColor = plateColor;
            this.PlateNo = plateNo;
            this.ServiceUrl = serviceUrl;
        }

        /// <summary>
        /// 是否启用车牌代扣状态查询功能，true为启用，false为停用
        /// </summary>
        /// <value>是否启用车牌代扣状态查询功能，true为启用，false为停用</value>
        [DataMember(Name = "agreement_query", EmitDefaultValue = true)]
        public bool AgreementQuery { get; set; }

        /// <summary>
        /// 本次行程收费计划清单
        /// </summary>
        /// <value>本次行程收费计划清单</value>
        [DataMember(Name = "charge_info_list", EmitDefaultValue = false)]
        public List<ParkingChargeInfo> ChargeInfoList { get; set; }

        /// <summary>
        /// 车辆进入停车场的入口通道名称
        /// </summary>
        /// <value>车辆进入停车场的入口通道名称</value>
        [DataMember(Name = "entrance_name", EmitDefaultValue = false)]
        public string EntranceName { get; set; }

        /// <summary>
        /// 车辆进入停车场的入口通道编号；按线下实际编号为准；
        /// </summary>
        /// <value>车辆进入停车场的入口通道编号；按线下实际编号为准；</value>
        [DataMember(Name = "entrance_number", EmitDefaultValue = false)]
        public int EntranceNumber { get; set; }

        /// <summary>
        /// 当前停车场的入场免费时长分钟数
        /// </summary>
        /// <value>当前停车场的入场免费时长分钟数</value>
        [DataMember(Name = "free_enter_minutes", EmitDefaultValue = false)]
        public string FreeEnterMinutes { get; set; }

        /// <summary>
        /// 车辆入场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间
        /// </summary>
        /// <value>车辆入场的时间，格式\&quot;YYYY-MM-DD HH:mm:ss\&quot;，24小时制，请保证服务器时间准确，入场时间不应晚于当前网络时间</value>
        [DataMember(Name = "in_time", EmitDefaultValue = false)]
        public string InTime { get; set; }

        /// <summary>
        /// 车牌是否加密，true为加密，false为不加密，默认为false
        /// </summary>
        /// <value>车牌是否加密，true为加密，false为不加密，默认为false</value>
        [DataMember(Name = "is_encrypt_plate_no", EmitDefaultValue = true)]
        public bool IsEncryptPlateNo { get; set; }

        /// <summary>
        /// Gets or Sets MembershipInfo
        /// </summary>
        [DataMember(Name = "membership_info", EmitDefaultValue = false)]
        public ParkingMembershipInfo MembershipInfo { get; set; }

        /// <summary>
        /// 当前行程是否需要计费。true：需要，false：不需要。不传默认为true。
        /// </summary>
        /// <value>当前行程是否需要计费。true：需要，false：不需要。不传默认为true。</value>
        [DataMember(Name = "need_charge", EmitDefaultValue = true)]
        public bool NeedCharge { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID对应的归属应用appid
        /// </summary>
        /// <value>蚂蚁会员统一ID对应的归属应用appid</value>
        [DataMember(Name = "open_appid", EmitDefaultValue = false)]
        public string OpenAppid { get; set; }

        /// <summary>
        /// 蚂蚁会员统一ID
        /// </summary>
        /// <value>蚂蚁会员统一ID</value>
        [DataMember(Name = "open_id", EmitDefaultValue = false)]
        public string OpenId { get; set; }

        /// <summary>
        /// 外部停车流水号(用于串通进场与出场信息)
        /// </summary>
        /// <value>外部停车流水号(用于串通进场与出场信息)</value>
        [DataMember(Name = "out_serial_no", EmitDefaultValue = false)]
        public string OutSerialNo { get; set; }

        /// <summary>
        /// 支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create (录入停车场信息)接口获取。
        /// </summary>
        /// <value>支付宝停车平台ID，由支付宝定义的该停车场标识，同一个isv或商户范围内唯一。通过 alipay.eco.mycar.parking.parkinglotinfo.create (录入停车场信息)接口获取。</value>
        [DataMember(Name = "parking_id", EmitDefaultValue = false)]
        public string ParkingId { get; set; }

        /// <summary>
        /// 车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。
        /// </summary>
        /// <value>车牌颜色，车牌颜色，枚举支持： *BLUE：蓝。 *GREEN：绿。 *YELLOW：黄。 *WHITE：白。 *BLACK：黑。 *LIMEGREEN：黄绿色。</value>
        [DataMember(Name = "plate_color", EmitDefaultValue = false)]
        public string PlateColor { get; set; }

        /// <summary>
        /// 车牌号（支持加密格式）
        /// </summary>
        /// <value>车牌号（支持加密格式）</value>
        [DataMember(Name = "plate_no", EmitDefaultValue = false)]
        public string PlateNo { get; set; }

        /// <summary>
        /// 停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F  2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex  3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex
        /// </summary>
        /// <value>停车服务页面地址。 1、服务商停车服务页面地址必须是支付宝小程序URL（无需转换https），详见：https://opendocs.alipay.com/support/01rb18#URL%20%E6%A0%BC%E5%BC%8F  2、若服务商没有服务链接，可传输支付宝停车官方小程序的服务链接：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;pages%2Fparking-fee%2Findex  3、若此次对接的是无感支付，则服务链接传输为：alipays://platformapi/startapp?appId&#x3D;2021001102642986&amp;page&#x3D;%2Fpages%2Fparking-bill%2Findex</value>
        [DataMember(Name = "service_url", EmitDefaultValue = false)]
        public string ServiceUrl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceTransportParkingEnterinfoSyncModel {\n");
            sb.Append("  AgreementQuery: ").Append(AgreementQuery).Append("\n");
            sb.Append("  ChargeInfoList: ").Append(ChargeInfoList).Append("\n");
            sb.Append("  EntranceName: ").Append(EntranceName).Append("\n");
            sb.Append("  EntranceNumber: ").Append(EntranceNumber).Append("\n");
            sb.Append("  FreeEnterMinutes: ").Append(FreeEnterMinutes).Append("\n");
            sb.Append("  InTime: ").Append(InTime).Append("\n");
            sb.Append("  IsEncryptPlateNo: ").Append(IsEncryptPlateNo).Append("\n");
            sb.Append("  MembershipInfo: ").Append(MembershipInfo).Append("\n");
            sb.Append("  NeedCharge: ").Append(NeedCharge).Append("\n");
            sb.Append("  OpenAppid: ").Append(OpenAppid).Append("\n");
            sb.Append("  OpenId: ").Append(OpenId).Append("\n");
            sb.Append("  OutSerialNo: ").Append(OutSerialNo).Append("\n");
            sb.Append("  ParkingId: ").Append(ParkingId).Append("\n");
            sb.Append("  PlateColor: ").Append(PlateColor).Append("\n");
            sb.Append("  PlateNo: ").Append(PlateNo).Append("\n");
            sb.Append("  ServiceUrl: ").Append(ServiceUrl).Append("\n");
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
            return this.Equals(input as AlipayCommerceTransportParkingEnterinfoSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceTransportParkingEnterinfoSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceTransportParkingEnterinfoSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceTransportParkingEnterinfoSyncModel input)
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
                    this.ChargeInfoList == input.ChargeInfoList ||
                    this.ChargeInfoList != null &&
                    input.ChargeInfoList != null &&
                    this.ChargeInfoList.SequenceEqual(input.ChargeInfoList)
                ) && 
                (
                    this.EntranceName == input.EntranceName ||
                    (this.EntranceName != null &&
                    this.EntranceName.Equals(input.EntranceName))
                ) && 
                (
                    this.EntranceNumber == input.EntranceNumber ||
                    this.EntranceNumber.Equals(input.EntranceNumber)
                ) && 
                (
                    this.FreeEnterMinutes == input.FreeEnterMinutes ||
                    (this.FreeEnterMinutes != null &&
                    this.FreeEnterMinutes.Equals(input.FreeEnterMinutes))
                ) && 
                (
                    this.InTime == input.InTime ||
                    (this.InTime != null &&
                    this.InTime.Equals(input.InTime))
                ) && 
                (
                    this.IsEncryptPlateNo == input.IsEncryptPlateNo ||
                    this.IsEncryptPlateNo.Equals(input.IsEncryptPlateNo)
                ) && 
                (
                    this.MembershipInfo == input.MembershipInfo ||
                    (this.MembershipInfo != null &&
                    this.MembershipInfo.Equals(input.MembershipInfo))
                ) && 
                (
                    this.NeedCharge == input.NeedCharge ||
                    this.NeedCharge.Equals(input.NeedCharge)
                ) && 
                (
                    this.OpenAppid == input.OpenAppid ||
                    (this.OpenAppid != null &&
                    this.OpenAppid.Equals(input.OpenAppid))
                ) && 
                (
                    this.OpenId == input.OpenId ||
                    (this.OpenId != null &&
                    this.OpenId.Equals(input.OpenId))
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
                    this.PlateColor == input.PlateColor ||
                    (this.PlateColor != null &&
                    this.PlateColor.Equals(input.PlateColor))
                ) && 
                (
                    this.PlateNo == input.PlateNo ||
                    (this.PlateNo != null &&
                    this.PlateNo.Equals(input.PlateNo))
                ) && 
                (
                    this.ServiceUrl == input.ServiceUrl ||
                    (this.ServiceUrl != null &&
                    this.ServiceUrl.Equals(input.ServiceUrl))
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
                if (this.ChargeInfoList != null)
                {
                    hashCode = (hashCode * 59) + this.ChargeInfoList.GetHashCode();
                }
                if (this.EntranceName != null)
                {
                    hashCode = (hashCode * 59) + this.EntranceName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EntranceNumber.GetHashCode();
                if (this.FreeEnterMinutes != null)
                {
                    hashCode = (hashCode * 59) + this.FreeEnterMinutes.GetHashCode();
                }
                if (this.InTime != null)
                {
                    hashCode = (hashCode * 59) + this.InTime.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IsEncryptPlateNo.GetHashCode();
                if (this.MembershipInfo != null)
                {
                    hashCode = (hashCode * 59) + this.MembershipInfo.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.NeedCharge.GetHashCode();
                if (this.OpenAppid != null)
                {
                    hashCode = (hashCode * 59) + this.OpenAppid.GetHashCode();
                }
                if (this.OpenId != null)
                {
                    hashCode = (hashCode * 59) + this.OpenId.GetHashCode();
                }
                if (this.OutSerialNo != null)
                {
                    hashCode = (hashCode * 59) + this.OutSerialNo.GetHashCode();
                }
                if (this.ParkingId != null)
                {
                    hashCode = (hashCode * 59) + this.ParkingId.GetHashCode();
                }
                if (this.PlateColor != null)
                {
                    hashCode = (hashCode * 59) + this.PlateColor.GetHashCode();
                }
                if (this.PlateNo != null)
                {
                    hashCode = (hashCode * 59) + this.PlateNo.GetHashCode();
                }
                if (this.ServiceUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ServiceUrl.GetHashCode();
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
