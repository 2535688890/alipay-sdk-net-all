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
    /// AlipayCommerceIotSdarttoolMessageQueryResponseModel
    /// </summary>
    [DataContract(Name = "AlipayCommerceIotSdarttoolMessageQueryResponseModel")]
    public partial class AlipayCommerceIotSdarttoolMessageQueryResponseModel : IEquatable<AlipayCommerceIotSdarttoolMessageQueryResponseModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayCommerceIotSdarttoolMessageQueryResponseModel" /> class.
        /// </summary>
        /// <param name="consumeErrCode">消息消费返回码，不用的消息类型返回码不一样.</param>
        /// <param name="consumeErrMsg">消息消费错误原因.</param>
        /// <param name="consumeState">消息消费状态1-未消费; 2-消费成功；3-消费失败.</param>
        /// <param name="deliverCnt">消息投递次数.</param>
        /// <param name="deliverStatus">消息投递状态 1: 未投递 2: 投递中 3: 投递成功 4: 投递失败 5: 消息失效不再发送.</param>
        /// <param name="lastDeliverAt">消息最后一次发送时间.</param>
        /// <param name="msgAckTime">消息确认消费时间(ms).</param>
        /// <param name="msgBida">消息必达类型 1-非必达; 2-必达..</param>
        /// <param name="msgExpireTime">消息过期时间(ms).</param>
        /// <param name="msgGmtCreate">消息创建时间(ms).</param>
        /// <param name="msgPriority">消息投递优先级.</param>
        public AlipayCommerceIotSdarttoolMessageQueryResponseModel(string consumeErrCode = default(string), string consumeErrMsg = default(string), int consumeState = default(int), int deliverCnt = default(int), string deliverStatus = default(string), int lastDeliverAt = default(int), int msgAckTime = default(int), int msgBida = default(int), int msgExpireTime = default(int), int msgGmtCreate = default(int), int msgPriority = default(int))
        {
            this.ConsumeErrCode = consumeErrCode;
            this.ConsumeErrMsg = consumeErrMsg;
            this.ConsumeState = consumeState;
            this.DeliverCnt = deliverCnt;
            this.DeliverStatus = deliverStatus;
            this.LastDeliverAt = lastDeliverAt;
            this.MsgAckTime = msgAckTime;
            this.MsgBida = msgBida;
            this.MsgExpireTime = msgExpireTime;
            this.MsgGmtCreate = msgGmtCreate;
            this.MsgPriority = msgPriority;
        }

        /// <summary>
        /// 消息消费返回码，不用的消息类型返回码不一样
        /// </summary>
        /// <value>消息消费返回码，不用的消息类型返回码不一样</value>
        [DataMember(Name = "consume_err_code", EmitDefaultValue = false)]
        public string ConsumeErrCode { get; set; }

        /// <summary>
        /// 消息消费错误原因
        /// </summary>
        /// <value>消息消费错误原因</value>
        [DataMember(Name = "consume_err_msg", EmitDefaultValue = false)]
        public string ConsumeErrMsg { get; set; }

        /// <summary>
        /// 消息消费状态1-未消费; 2-消费成功；3-消费失败
        /// </summary>
        /// <value>消息消费状态1-未消费; 2-消费成功；3-消费失败</value>
        [DataMember(Name = "consume_state", EmitDefaultValue = false)]
        public int ConsumeState { get; set; }

        /// <summary>
        /// 消息投递次数
        /// </summary>
        /// <value>消息投递次数</value>
        [DataMember(Name = "deliver_cnt", EmitDefaultValue = false)]
        public int DeliverCnt { get; set; }

        /// <summary>
        /// 消息投递状态 1: 未投递 2: 投递中 3: 投递成功 4: 投递失败 5: 消息失效不再发送
        /// </summary>
        /// <value>消息投递状态 1: 未投递 2: 投递中 3: 投递成功 4: 投递失败 5: 消息失效不再发送</value>
        [DataMember(Name = "deliver_status", EmitDefaultValue = false)]
        public string DeliverStatus { get; set; }

        /// <summary>
        /// 消息最后一次发送时间
        /// </summary>
        /// <value>消息最后一次发送时间</value>
        [DataMember(Name = "last_deliver_at", EmitDefaultValue = false)]
        public int LastDeliverAt { get; set; }

        /// <summary>
        /// 消息确认消费时间(ms)
        /// </summary>
        /// <value>消息确认消费时间(ms)</value>
        [DataMember(Name = "msg_ack_time", EmitDefaultValue = false)]
        public int MsgAckTime { get; set; }

        /// <summary>
        /// 消息必达类型 1-非必达; 2-必达.
        /// </summary>
        /// <value>消息必达类型 1-非必达; 2-必达.</value>
        [DataMember(Name = "msg_bida", EmitDefaultValue = false)]
        public int MsgBida { get; set; }

        /// <summary>
        /// 消息过期时间(ms)
        /// </summary>
        /// <value>消息过期时间(ms)</value>
        [DataMember(Name = "msg_expire_time", EmitDefaultValue = false)]
        public int MsgExpireTime { get; set; }

        /// <summary>
        /// 消息创建时间(ms)
        /// </summary>
        /// <value>消息创建时间(ms)</value>
        [DataMember(Name = "msg_gmt_create", EmitDefaultValue = false)]
        public int MsgGmtCreate { get; set; }

        /// <summary>
        /// 消息投递优先级
        /// </summary>
        /// <value>消息投递优先级</value>
        [DataMember(Name = "msg_priority", EmitDefaultValue = false)]
        public int MsgPriority { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayCommerceIotSdarttoolMessageQueryResponseModel {\n");
            sb.Append("  ConsumeErrCode: ").Append(ConsumeErrCode).Append("\n");
            sb.Append("  ConsumeErrMsg: ").Append(ConsumeErrMsg).Append("\n");
            sb.Append("  ConsumeState: ").Append(ConsumeState).Append("\n");
            sb.Append("  DeliverCnt: ").Append(DeliverCnt).Append("\n");
            sb.Append("  DeliverStatus: ").Append(DeliverStatus).Append("\n");
            sb.Append("  LastDeliverAt: ").Append(LastDeliverAt).Append("\n");
            sb.Append("  MsgAckTime: ").Append(MsgAckTime).Append("\n");
            sb.Append("  MsgBida: ").Append(MsgBida).Append("\n");
            sb.Append("  MsgExpireTime: ").Append(MsgExpireTime).Append("\n");
            sb.Append("  MsgGmtCreate: ").Append(MsgGmtCreate).Append("\n");
            sb.Append("  MsgPriority: ").Append(MsgPriority).Append("\n");
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
            return this.Equals(input as AlipayCommerceIotSdarttoolMessageQueryResponseModel);
        }

        /// <summary>
        /// Returns true if AlipayCommerceIotSdarttoolMessageQueryResponseModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayCommerceIotSdarttoolMessageQueryResponseModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayCommerceIotSdarttoolMessageQueryResponseModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConsumeErrCode == input.ConsumeErrCode ||
                    (this.ConsumeErrCode != null &&
                    this.ConsumeErrCode.Equals(input.ConsumeErrCode))
                ) && 
                (
                    this.ConsumeErrMsg == input.ConsumeErrMsg ||
                    (this.ConsumeErrMsg != null &&
                    this.ConsumeErrMsg.Equals(input.ConsumeErrMsg))
                ) && 
                (
                    this.ConsumeState == input.ConsumeState ||
                    this.ConsumeState.Equals(input.ConsumeState)
                ) && 
                (
                    this.DeliverCnt == input.DeliverCnt ||
                    this.DeliverCnt.Equals(input.DeliverCnt)
                ) && 
                (
                    this.DeliverStatus == input.DeliverStatus ||
                    (this.DeliverStatus != null &&
                    this.DeliverStatus.Equals(input.DeliverStatus))
                ) && 
                (
                    this.LastDeliverAt == input.LastDeliverAt ||
                    this.LastDeliverAt.Equals(input.LastDeliverAt)
                ) && 
                (
                    this.MsgAckTime == input.MsgAckTime ||
                    this.MsgAckTime.Equals(input.MsgAckTime)
                ) && 
                (
                    this.MsgBida == input.MsgBida ||
                    this.MsgBida.Equals(input.MsgBida)
                ) && 
                (
                    this.MsgExpireTime == input.MsgExpireTime ||
                    this.MsgExpireTime.Equals(input.MsgExpireTime)
                ) && 
                (
                    this.MsgGmtCreate == input.MsgGmtCreate ||
                    this.MsgGmtCreate.Equals(input.MsgGmtCreate)
                ) && 
                (
                    this.MsgPriority == input.MsgPriority ||
                    this.MsgPriority.Equals(input.MsgPriority)
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
                if (this.ConsumeErrCode != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeErrCode.GetHashCode();
                }
                if (this.ConsumeErrMsg != null)
                {
                    hashCode = (hashCode * 59) + this.ConsumeErrMsg.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ConsumeState.GetHashCode();
                hashCode = (hashCode * 59) + this.DeliverCnt.GetHashCode();
                if (this.DeliverStatus != null)
                {
                    hashCode = (hashCode * 59) + this.DeliverStatus.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LastDeliverAt.GetHashCode();
                hashCode = (hashCode * 59) + this.MsgAckTime.GetHashCode();
                hashCode = (hashCode * 59) + this.MsgBida.GetHashCode();
                hashCode = (hashCode * 59) + this.MsgExpireTime.GetHashCode();
                hashCode = (hashCode * 59) + this.MsgGmtCreate.GetHashCode();
                hashCode = (hashCode * 59) + this.MsgPriority.GetHashCode();
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
