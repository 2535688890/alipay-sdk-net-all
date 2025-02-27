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
    /// AlipayCommerceTransportChargerChargerbindinfoSyncModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceTransportChargerChargerbindinfoSyncModel")]
    public partial class AlipayCommerceTransportChargerChargerbindinfoSyncModel : IEquatable<AlipayCommerceTransportChargerChargerbindinfoSyncModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceTransportChargerChargerbindinfoSyncModel" /> class.
        /// </summary>
        /// <param name="bindQrcode">绑定充电桩二维码值，用户扫码绑桩扫描的二维码.</param>
        /// <param name="bindStatus">绑定状态 1:绑定; 2:解绑;  0:未知.</param>
        /// <param name="bindTime">绑定时间，绑定成功必传.</param>
        /// <param name="connectorType">1：家用插座 2、交流接口插座 3：交流接口插头 4、直流接口枪头 5、无线充电座 6、其他.</param>
        /// <param name="currentOutputType">1：国标 2：欧标 3：美标 4：日标 5：其他.</param>
        /// <param name="equipId">设备编号.</param>
        /// <param name="equipImei">设备IMEI号.</param>
        /// <param name="equipName">设备名称，对用户展示，可以是设备名称，也可以是设备SN号，设备编号.</param>
        /// <param name="equipSn">设备SN号.</param>
        /// <param name="equipStatus">设备状态，遵循中电联协议的设备状态。0：离网;1：空闲;2：占用未充电;3：占用充电中;4：占用（预约锁定）;255：故障.</param>
        /// <param name="equipTypeNo">设备型号.</param>
        /// <param name="operatorId">运营商编码，一般为企业组织机构代码.</param>
        /// <param name="operatorUid">商户内部唯一标识用户的用户标识.</param>
        /// <param name="ratedCurrent">额定电流,单位：A.</param>
        /// <param name="ratedPower">额定功率，单位：kW.</param>
        /// <param name="ratedVoltage">额定电压，单位：V.</param>
        /// <param name="unbindTime">解绑时间，解绑必传.</param>
        public AlipayCommerceTransportChargerChargerbindinfoSyncModel(string bindQrcode = default(string), string bindStatus = default(string), string bindTime = default(string), string connectorType = default(string), string currentOutputType = default(string), string equipId = default(string), string equipImei = default(string), string equipName = default(string), string equipSn = default(string), string equipStatus = default(string), string equipTypeNo = default(string), string operatorId = default(string), string operatorUid = default(string), string ratedCurrent = default(string), string ratedPower = default(string), string ratedVoltage = default(string), string unbindTime = default(string))
        {
            this.BindQrcode = bindQrcode;
            this.BindStatus = bindStatus;
            this.BindTime = bindTime;
            this.ConnectorType = connectorType;
            this.CurrentOutputType = currentOutputType;
            this.EquipId = equipId;
            this.EquipImei = equipImei;
            this.EquipName = equipName;
            this.EquipSn = equipSn;
            this.EquipStatus = equipStatus;
            this.EquipTypeNo = equipTypeNo;
            this.OperatorId = operatorId;
            this.OperatorUid = operatorUid;
            this.RatedCurrent = ratedCurrent;
            this.RatedPower = ratedPower;
            this.RatedVoltage = ratedVoltage;
            this.UnbindTime = unbindTime;
        }

        /// <summary>
        /// 绑定充电桩二维码值，用户扫码绑桩扫描的二维码
        /// </summary>
        /// <value>绑定充电桩二维码值，用户扫码绑桩扫描的二维码</value>
        [DataMember(Name = "bind_qrcode", EmitDefaultValue = false)]
        public string BindQrcode { get; set; }

        /// <summary>
        /// 绑定状态 1:绑定; 2:解绑;  0:未知
        /// </summary>
        /// <value>绑定状态 1:绑定; 2:解绑;  0:未知</value>
        [DataMember(Name = "bind_status", EmitDefaultValue = false)]
        public string BindStatus { get; set; }

        /// <summary>
        /// 绑定时间，绑定成功必传
        /// </summary>
        /// <value>绑定时间，绑定成功必传</value>
        [DataMember(Name = "bind_time", EmitDefaultValue = false)]
        public string BindTime { get; set; }

        /// <summary>
        /// 1：家用插座 2、交流接口插座 3：交流接口插头 4、直流接口枪头 5、无线充电座 6、其他
        /// </summary>
        /// <value>1：家用插座 2、交流接口插座 3：交流接口插头 4、直流接口枪头 5、无线充电座 6、其他</value>
        [DataMember(Name = "connector_type", EmitDefaultValue = false)]
        public string ConnectorType { get; set; }

        /// <summary>
        /// 1：国标 2：欧标 3：美标 4：日标 5：其他
        /// </summary>
        /// <value>1：国标 2：欧标 3：美标 4：日标 5：其他</value>
        [DataMember(Name = "current_output_type", EmitDefaultValue = false)]
        public string CurrentOutputType { get; set; }

        /// <summary>
        /// 设备编号
        /// </summary>
        /// <value>设备编号</value>
        [DataMember(Name = "equip_id", EmitDefaultValue = false)]
        public string EquipId { get; set; }

        /// <summary>
        /// 设备IMEI号
        /// </summary>
        /// <value>设备IMEI号</value>
        [DataMember(Name = "equip_imei", EmitDefaultValue = false)]
        public string EquipImei { get; set; }

        /// <summary>
        /// 设备名称，对用户展示，可以是设备名称，也可以是设备SN号，设备编号
        /// </summary>
        /// <value>设备名称，对用户展示，可以是设备名称，也可以是设备SN号，设备编号</value>
        [DataMember(Name = "equip_name", EmitDefaultValue = false)]
        public string EquipName { get; set; }

        /// <summary>
        /// 设备SN号
        /// </summary>
        /// <value>设备SN号</value>
        [DataMember(Name = "equip_sn", EmitDefaultValue = false)]
        public string EquipSn { get; set; }

        /// <summary>
        /// 设备状态，遵循中电联协议的设备状态。0：离网;1：空闲;2：占用未充电;3：占用充电中;4：占用（预约锁定）;255：故障
        /// </summary>
        /// <value>设备状态，遵循中电联协议的设备状态。0：离网;1：空闲;2：占用未充电;3：占用充电中;4：占用（预约锁定）;255：故障</value>
        [DataMember(Name = "equip_status", EmitDefaultValue = false)]
        public string EquipStatus { get; set; }

        /// <summary>
        /// 设备型号
        /// </summary>
        /// <value>设备型号</value>
        [DataMember(Name = "equip_type_no", EmitDefaultValue = false)]
        public string EquipTypeNo { get; set; }

        /// <summary>
        /// 运营商编码，一般为企业组织机构代码
        /// </summary>
        /// <value>运营商编码，一般为企业组织机构代码</value>
        [DataMember(Name = "operator_id", EmitDefaultValue = false)]
        public string OperatorId { get; set; }

        /// <summary>
        /// 商户内部唯一标识用户的用户标识
        /// </summary>
        /// <value>商户内部唯一标识用户的用户标识</value>
        [DataMember(Name = "operator_uid", EmitDefaultValue = false)]
        public string OperatorUid { get; set; }

        /// <summary>
        /// 额定电流,单位：A
        /// </summary>
        /// <value>额定电流,单位：A</value>
        [DataMember(Name = "rated_current", EmitDefaultValue = false)]
        public string RatedCurrent { get; set; }

        /// <summary>
        /// 额定功率，单位：kW
        /// </summary>
        /// <value>额定功率，单位：kW</value>
        [DataMember(Name = "rated_power", EmitDefaultValue = false)]
        public string RatedPower { get; set; }

        /// <summary>
        /// 额定电压，单位：V
        /// </summary>
        /// <value>额定电压，单位：V</value>
        [DataMember(Name = "rated_voltage", EmitDefaultValue = false)]
        public string RatedVoltage { get; set; }

        /// <summary>
        /// 解绑时间，解绑必传
        /// </summary>
        /// <value>解绑时间，解绑必传</value>
        [DataMember(Name = "unbind_time", EmitDefaultValue = false)]
        public string UnbindTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceTransportChargerChargerbindinfoSyncModel {\n");
            sb.Append("  BindQrcode: ").Append(BindQrcode).Append("\n");
            sb.Append("  BindStatus: ").Append(BindStatus).Append("\n");
            sb.Append("  BindTime: ").Append(BindTime).Append("\n");
            sb.Append("  ConnectorType: ").Append(ConnectorType).Append("\n");
            sb.Append("  CurrentOutputType: ").Append(CurrentOutputType).Append("\n");
            sb.Append("  EquipId: ").Append(EquipId).Append("\n");
            sb.Append("  EquipImei: ").Append(EquipImei).Append("\n");
            sb.Append("  EquipName: ").Append(EquipName).Append("\n");
            sb.Append("  EquipSn: ").Append(EquipSn).Append("\n");
            sb.Append("  EquipStatus: ").Append(EquipStatus).Append("\n");
            sb.Append("  EquipTypeNo: ").Append(EquipTypeNo).Append("\n");
            sb.Append("  OperatorId: ").Append(OperatorId).Append("\n");
            sb.Append("  OperatorUid: ").Append(OperatorUid).Append("\n");
            sb.Append("  RatedCurrent: ").Append(RatedCurrent).Append("\n");
            sb.Append("  RatedPower: ").Append(RatedPower).Append("\n");
            sb.Append("  RatedVoltage: ").Append(RatedVoltage).Append("\n");
            sb.Append("  UnbindTime: ").Append(UnbindTime).Append("\n");
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
            return this.Equals(input as AlipayCommerceTransportChargerChargerbindinfoSyncModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceTransportChargerChargerbindinfoSyncModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceTransportChargerChargerbindinfoSyncModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceTransportChargerChargerbindinfoSyncModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.BindQrcode == input.BindQrcode ||
                    (this.BindQrcode != null &&
                    this.BindQrcode.Equals(input.BindQrcode))
                ) && 
                (
                    this.BindStatus == input.BindStatus ||
                    (this.BindStatus != null &&
                    this.BindStatus.Equals(input.BindStatus))
                ) && 
                (
                    this.BindTime == input.BindTime ||
                    (this.BindTime != null &&
                    this.BindTime.Equals(input.BindTime))
                ) && 
                (
                    this.ConnectorType == input.ConnectorType ||
                    (this.ConnectorType != null &&
                    this.ConnectorType.Equals(input.ConnectorType))
                ) && 
                (
                    this.CurrentOutputType == input.CurrentOutputType ||
                    (this.CurrentOutputType != null &&
                    this.CurrentOutputType.Equals(input.CurrentOutputType))
                ) && 
                (
                    this.EquipId == input.EquipId ||
                    (this.EquipId != null &&
                    this.EquipId.Equals(input.EquipId))
                ) && 
                (
                    this.EquipImei == input.EquipImei ||
                    (this.EquipImei != null &&
                    this.EquipImei.Equals(input.EquipImei))
                ) && 
                (
                    this.EquipName == input.EquipName ||
                    (this.EquipName != null &&
                    this.EquipName.Equals(input.EquipName))
                ) && 
                (
                    this.EquipSn == input.EquipSn ||
                    (this.EquipSn != null &&
                    this.EquipSn.Equals(input.EquipSn))
                ) && 
                (
                    this.EquipStatus == input.EquipStatus ||
                    (this.EquipStatus != null &&
                    this.EquipStatus.Equals(input.EquipStatus))
                ) && 
                (
                    this.EquipTypeNo == input.EquipTypeNo ||
                    (this.EquipTypeNo != null &&
                    this.EquipTypeNo.Equals(input.EquipTypeNo))
                ) && 
                (
                    this.OperatorId == input.OperatorId ||
                    (this.OperatorId != null &&
                    this.OperatorId.Equals(input.OperatorId))
                ) && 
                (
                    this.OperatorUid == input.OperatorUid ||
                    (this.OperatorUid != null &&
                    this.OperatorUid.Equals(input.OperatorUid))
                ) && 
                (
                    this.RatedCurrent == input.RatedCurrent ||
                    (this.RatedCurrent != null &&
                    this.RatedCurrent.Equals(input.RatedCurrent))
                ) && 
                (
                    this.RatedPower == input.RatedPower ||
                    (this.RatedPower != null &&
                    this.RatedPower.Equals(input.RatedPower))
                ) && 
                (
                    this.RatedVoltage == input.RatedVoltage ||
                    (this.RatedVoltage != null &&
                    this.RatedVoltage.Equals(input.RatedVoltage))
                ) && 
                (
                    this.UnbindTime == input.UnbindTime ||
                    (this.UnbindTime != null &&
                    this.UnbindTime.Equals(input.UnbindTime))
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
                if (this.BindQrcode != null)
                {
                    hashCode = (hashCode * 59) + this.BindQrcode.GetHashCode();
                }
                if (this.BindStatus != null)
                {
                    hashCode = (hashCode * 59) + this.BindStatus.GetHashCode();
                }
                if (this.BindTime != null)
                {
                    hashCode = (hashCode * 59) + this.BindTime.GetHashCode();
                }
                if (this.ConnectorType != null)
                {
                    hashCode = (hashCode * 59) + this.ConnectorType.GetHashCode();
                }
                if (this.CurrentOutputType != null)
                {
                    hashCode = (hashCode * 59) + this.CurrentOutputType.GetHashCode();
                }
                if (this.EquipId != null)
                {
                    hashCode = (hashCode * 59) + this.EquipId.GetHashCode();
                }
                if (this.EquipImei != null)
                {
                    hashCode = (hashCode * 59) + this.EquipImei.GetHashCode();
                }
                if (this.EquipName != null)
                {
                    hashCode = (hashCode * 59) + this.EquipName.GetHashCode();
                }
                if (this.EquipSn != null)
                {
                    hashCode = (hashCode * 59) + this.EquipSn.GetHashCode();
                }
                if (this.EquipStatus != null)
                {
                    hashCode = (hashCode * 59) + this.EquipStatus.GetHashCode();
                }
                if (this.EquipTypeNo != null)
                {
                    hashCode = (hashCode * 59) + this.EquipTypeNo.GetHashCode();
                }
                if (this.OperatorId != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorId.GetHashCode();
                }
                if (this.OperatorUid != null)
                {
                    hashCode = (hashCode * 59) + this.OperatorUid.GetHashCode();
                }
                if (this.RatedCurrent != null)
                {
                    hashCode = (hashCode * 59) + this.RatedCurrent.GetHashCode();
                }
                if (this.RatedPower != null)
                {
                    hashCode = (hashCode * 59) + this.RatedPower.GetHashCode();
                }
                if (this.RatedVoltage != null)
                {
                    hashCode = (hashCode * 59) + this.RatedVoltage.GetHashCode();
                }
                if (this.UnbindTime != null)
                {
                    hashCode = (hashCode * 59) + this.UnbindTime.GetHashCode();
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
