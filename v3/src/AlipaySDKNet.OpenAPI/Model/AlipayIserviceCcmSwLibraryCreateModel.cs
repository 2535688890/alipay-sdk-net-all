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
    /// AlipayIserviceCcmSwLibraryCreateModel
    /// </summary>
    [DataContract(Name = "AlipayIserviceCcmSwLibraryCreateModel")]
    public partial class AlipayIserviceCcmSwLibraryCreateModel : IEquatable<AlipayIserviceCcmSwLibraryCreateModel>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AlipayIserviceCcmSwLibraryCreateModel" /> class.
        /// </summary>
        /// <param name="ccsInstanceId">子部门ID，不传为默认部门.</param>
        /// <param name="instanceCode">知识库对应的类目树名称，与treeId不可同时为空.</param>
        /// <param name="name">知识库名称.</param>
        /// <param name="treeId">知识库对应的类目树Id，与instanceCode不可同时为空.</param>
        public AlipayIserviceCcmSwLibraryCreateModel(string ccsInstanceId = default(string), string instanceCode = default(string), string name = default(string), int treeId = default(int))
        {
            this.CcsInstanceId = ccsInstanceId;
            this.InstanceCode = instanceCode;
            this.Name = name;
            this.TreeId = treeId;
        }

        /// <summary>
        /// 子部门ID，不传为默认部门
        /// </summary>
        /// <value>子部门ID，不传为默认部门</value>
        [DataMember(Name = "ccs_instance_id", EmitDefaultValue = false)]
        public string CcsInstanceId { get; set; }

        /// <summary>
        /// 知识库对应的类目树名称，与treeId不可同时为空
        /// </summary>
        /// <value>知识库对应的类目树名称，与treeId不可同时为空</value>
        [DataMember(Name = "instance_code", EmitDefaultValue = false)]
        public string InstanceCode { get; set; }

        /// <summary>
        /// 知识库名称
        /// </summary>
        /// <value>知识库名称</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// 知识库对应的类目树Id，与instanceCode不可同时为空
        /// </summary>
        /// <value>知识库对应的类目树Id，与instanceCode不可同时为空</value>
        [DataMember(Name = "tree_id", EmitDefaultValue = false)]
        public int TreeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AlipayIserviceCcmSwLibraryCreateModel {\n");
            sb.Append("  CcsInstanceId: ").Append(CcsInstanceId).Append("\n");
            sb.Append("  InstanceCode: ").Append(InstanceCode).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  TreeId: ").Append(TreeId).Append("\n");
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
            return this.Equals(input as AlipayIserviceCcmSwLibraryCreateModel);
        }

        /// <summary>
        /// Returns true if AlipayIserviceCcmSwLibraryCreateModel instances are equal
        /// </summary>
        /// <param name="input">Instance of AlipayIserviceCcmSwLibraryCreateModel to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AlipayIserviceCcmSwLibraryCreateModel input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CcsInstanceId == input.CcsInstanceId ||
                    (this.CcsInstanceId != null &&
                    this.CcsInstanceId.Equals(input.CcsInstanceId))
                ) && 
                (
                    this.InstanceCode == input.InstanceCode ||
                    (this.InstanceCode != null &&
                    this.InstanceCode.Equals(input.InstanceCode))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.TreeId == input.TreeId ||
                    this.TreeId.Equals(input.TreeId)
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
                if (this.CcsInstanceId != null)
                {
                    hashCode = (hashCode * 59) + this.CcsInstanceId.GetHashCode();
                }
                if (this.InstanceCode != null)
                {
                    hashCode = (hashCode * 59) + this.InstanceCode.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TreeId.GetHashCode();
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
