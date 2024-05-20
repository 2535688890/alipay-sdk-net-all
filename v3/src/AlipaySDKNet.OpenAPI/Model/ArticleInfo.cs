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
    /// ArticleInfo
    /// </summary>
    [DataContract(Name = "ArticleInfo")]
    public partial class ArticleInfo : IEquatable<ArticleInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ArticleInfo" /> class.
        /// </summary>
        /// <param name="attachments">文章对应附件集合.</param>
        /// <param name="categoryId">所属类目ID.</param>
        /// <param name="categoryNamePath">类目名称路径.</param>
        /// <param name="categoryPath">类目路径.</param>
        /// <param name="content">内容.</param>
        /// <param name="createTime">创建时间.</param>
        /// <param name="creatorId">创建人.</param>
        /// <param name="extendTitles">扩展标题.</param>
        /// <param name="id">文章ID.</param>
        /// <param name="keywords">标签.</param>
        /// <param name="libraryId">知识库ID.</param>
        /// <param name="orderNo">排序值.</param>
        /// <param name="pictures">文章对应图片集合.</param>
        /// <param name="publishEnd">有效期止.</param>
        /// <param name="publishStart">有效期起始.</param>
        /// <param name="sceneCodes">场景ID。1（内部知识库）；2（机器人）;3（帮助中心）；4（无线帮助中心）.</param>
        /// <param name="source">来源.</param>
        /// <param name="status">文章状态.</param>
        /// <param name="statusCode">文章状态码.</param>
        /// <param name="title">标题.</param>
        /// <param name="updateTime">修改时间.</param>
        /// <param name="updaterId">修改人.</param>
        /// <param name="updaterName">修改人名称.</param>
        public ArticleInfo(List<ArticleAttachmentInfo> attachments = default(List<ArticleAttachmentInfo>), int categoryId = default(int), string categoryNamePath = default(string), List<ArticleCategoryInfo> categoryPath = default(List<ArticleCategoryInfo>), string content = default(string), string createTime = default(string), string creatorId = default(string), List<string> extendTitles = default(List<string>), int id = default(int), List<string> keywords = default(List<string>), int libraryId = default(int), int orderNo = default(int), List<ArticleAttachmentInfo> pictures = default(List<ArticleAttachmentInfo>), string publishEnd = default(string), string publishStart = default(string), List<string> sceneCodes = default(List<string>), string source = default(string), string status = default(string), string statusCode = default(string), string title = default(string), string updateTime = default(string), string updaterId = default(string), string updaterName = default(string))
        {
            this.Attachments = attachments;
            this.CategoryId = categoryId;
            this.CategoryNamePath = categoryNamePath;
            this.CategoryPath = categoryPath;
            this.Content = content;
            this.CreateTime = createTime;
            this.CreatorId = creatorId;
            this.ExtendTitles = extendTitles;
            this.Id = id;
            this.Keywords = keywords;
            this.LibraryId = libraryId;
            this.OrderNo = orderNo;
            this.Pictures = pictures;
            this.PublishEnd = publishEnd;
            this.PublishStart = publishStart;
            this.SceneCodes = sceneCodes;
            this.Source = source;
            this.Status = status;
            this.StatusCode = statusCode;
            this.Title = title;
            this.UpdateTime = updateTime;
            this.UpdaterId = updaterId;
            this.UpdaterName = updaterName;
        }

        /// <summary>
        /// 文章对应附件集合
        /// </summary>
        /// <value>文章对应附件集合</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<ArticleAttachmentInfo> Attachments { get; set; }

        /// <summary>
        /// 所属类目ID
        /// </summary>
        /// <value>所属类目ID</value>
        [DataMember(Name = "category_id", EmitDefaultValue = false)]
        public int CategoryId { get; set; }

        /// <summary>
        /// 类目名称路径
        /// </summary>
        /// <value>类目名称路径</value>
        [DataMember(Name = "category_name_path", EmitDefaultValue = false)]
        public string CategoryNamePath { get; set; }

        /// <summary>
        /// 类目路径
        /// </summary>
        /// <value>类目路径</value>
        [DataMember(Name = "category_path", EmitDefaultValue = false)]
        public List<ArticleCategoryInfo> CategoryPath { get; set; }

        /// <summary>
        /// 内容
        /// </summary>
        /// <value>内容</value>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public string Content { get; set; }

        /// <summary>
        /// 创建时间
        /// </summary>
        /// <value>创建时间</value>
        [DataMember(Name = "create_time", EmitDefaultValue = false)]
        public string CreateTime { get; set; }

        /// <summary>
        /// 创建人
        /// </summary>
        /// <value>创建人</value>
        [DataMember(Name = "creator_id", EmitDefaultValue = false)]
        public string CreatorId { get; set; }

        /// <summary>
        /// 扩展标题
        /// </summary>
        /// <value>扩展标题</value>
        [DataMember(Name = "extend_titles", EmitDefaultValue = false)]
        public List<string> ExtendTitles { get; set; }

        /// <summary>
        /// 文章ID
        /// </summary>
        /// <value>文章ID</value>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public int Id { get; set; }

        /// <summary>
        /// 标签
        /// </summary>
        /// <value>标签</value>
        [DataMember(Name = "keywords", EmitDefaultValue = false)]
        public List<string> Keywords { get; set; }

        /// <summary>
        /// 知识库ID
        /// </summary>
        /// <value>知识库ID</value>
        [DataMember(Name = "library_id", EmitDefaultValue = false)]
        public int LibraryId { get; set; }

        /// <summary>
        /// 排序值
        /// </summary>
        /// <value>排序值</value>
        [DataMember(Name = "order_no", EmitDefaultValue = false)]
        public int OrderNo { get; set; }

        /// <summary>
        /// 文章对应图片集合
        /// </summary>
        /// <value>文章对应图片集合</value>
        [DataMember(Name = "pictures", EmitDefaultValue = false)]
        public List<ArticleAttachmentInfo> Pictures { get; set; }

        /// <summary>
        /// 有效期止
        /// </summary>
        /// <value>有效期止</value>
        [DataMember(Name = "publish_end", EmitDefaultValue = false)]
        public string PublishEnd { get; set; }

        /// <summary>
        /// 有效期起始
        /// </summary>
        /// <value>有效期起始</value>
        [DataMember(Name = "publish_start", EmitDefaultValue = false)]
        public string PublishStart { get; set; }

        /// <summary>
        /// 场景ID。1（内部知识库）；2（机器人）;3（帮助中心）；4（无线帮助中心）
        /// </summary>
        /// <value>场景ID。1（内部知识库）；2（机器人）;3（帮助中心）；4（无线帮助中心）</value>
        [DataMember(Name = "scene_codes", EmitDefaultValue = false)]
        public List<string> SceneCodes { get; set; }

        /// <summary>
        /// 来源
        /// </summary>
        /// <value>来源</value>
        [DataMember(Name = "source", EmitDefaultValue = false)]
        public string Source { get; set; }

        /// <summary>
        /// 文章状态
        /// </summary>
        /// <value>文章状态</value>
        [DataMember(Name = "status", EmitDefaultValue = false)]
        public string Status { get; set; }

        /// <summary>
        /// 文章状态码
        /// </summary>
        /// <value>文章状态码</value>
        [DataMember(Name = "status_code", EmitDefaultValue = false)]
        public string StatusCode { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        /// <value>标题</value>
        [DataMember(Name = "title", EmitDefaultValue = false)]
        public string Title { get; set; }

        /// <summary>
        /// 修改时间
        /// </summary>
        /// <value>修改时间</value>
        [DataMember(Name = "update_time", EmitDefaultValue = false)]
        public string UpdateTime { get; set; }

        /// <summary>
        /// 修改人
        /// </summary>
        /// <value>修改人</value>
        [DataMember(Name = "updater_id", EmitDefaultValue = false)]
        public string UpdaterId { get; set; }

        /// <summary>
        /// 修改人名称
        /// </summary>
        /// <value>修改人名称</value>
        [DataMember(Name = "updater_name", EmitDefaultValue = false)]
        public string UpdaterName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ArticleInfo {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  CategoryNamePath: ").Append(CategoryNamePath).Append("\n");
            sb.Append("  CategoryPath: ").Append(CategoryPath).Append("\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  CreateTime: ").Append(CreateTime).Append("\n");
            sb.Append("  CreatorId: ").Append(CreatorId).Append("\n");
            sb.Append("  ExtendTitles: ").Append(ExtendTitles).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Keywords: ").Append(Keywords).Append("\n");
            sb.Append("  LibraryId: ").Append(LibraryId).Append("\n");
            sb.Append("  OrderNo: ").Append(OrderNo).Append("\n");
            sb.Append("  Pictures: ").Append(Pictures).Append("\n");
            sb.Append("  PublishEnd: ").Append(PublishEnd).Append("\n");
            sb.Append("  PublishStart: ").Append(PublishStart).Append("\n");
            sb.Append("  SceneCodes: ").Append(SceneCodes).Append("\n");
            sb.Append("  Source: ").Append(Source).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  StatusCode: ").Append(StatusCode).Append("\n");
            sb.Append("  Title: ").Append(Title).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  UpdaterId: ").Append(UpdaterId).Append("\n");
            sb.Append("  UpdaterName: ").Append(UpdaterName).Append("\n");
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
            return this.Equals(input as ArticleInfo);
        }

        /// <summary>
        /// Returns true if ArticleInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of ArticleInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ArticleInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.CategoryId == input.CategoryId ||
                    this.CategoryId.Equals(input.CategoryId)
                ) && 
                (
                    this.CategoryNamePath == input.CategoryNamePath ||
                    (this.CategoryNamePath != null &&
                    this.CategoryNamePath.Equals(input.CategoryNamePath))
                ) && 
                (
                    this.CategoryPath == input.CategoryPath ||
                    this.CategoryPath != null &&
                    input.CategoryPath != null &&
                    this.CategoryPath.SequenceEqual(input.CategoryPath)
                ) && 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.CreateTime == input.CreateTime ||
                    (this.CreateTime != null &&
                    this.CreateTime.Equals(input.CreateTime))
                ) && 
                (
                    this.CreatorId == input.CreatorId ||
                    (this.CreatorId != null &&
                    this.CreatorId.Equals(input.CreatorId))
                ) && 
                (
                    this.ExtendTitles == input.ExtendTitles ||
                    this.ExtendTitles != null &&
                    input.ExtendTitles != null &&
                    this.ExtendTitles.SequenceEqual(input.ExtendTitles)
                ) && 
                (
                    this.Id == input.Id ||
                    this.Id.Equals(input.Id)
                ) && 
                (
                    this.Keywords == input.Keywords ||
                    this.Keywords != null &&
                    input.Keywords != null &&
                    this.Keywords.SequenceEqual(input.Keywords)
                ) && 
                (
                    this.LibraryId == input.LibraryId ||
                    this.LibraryId.Equals(input.LibraryId)
                ) && 
                (
                    this.OrderNo == input.OrderNo ||
                    this.OrderNo.Equals(input.OrderNo)
                ) && 
                (
                    this.Pictures == input.Pictures ||
                    this.Pictures != null &&
                    input.Pictures != null &&
                    this.Pictures.SequenceEqual(input.Pictures)
                ) && 
                (
                    this.PublishEnd == input.PublishEnd ||
                    (this.PublishEnd != null &&
                    this.PublishEnd.Equals(input.PublishEnd))
                ) && 
                (
                    this.PublishStart == input.PublishStart ||
                    (this.PublishStart != null &&
                    this.PublishStart.Equals(input.PublishStart))
                ) && 
                (
                    this.SceneCodes == input.SceneCodes ||
                    this.SceneCodes != null &&
                    input.SceneCodes != null &&
                    this.SceneCodes.SequenceEqual(input.SceneCodes)
                ) && 
                (
                    this.Source == input.Source ||
                    (this.Source != null &&
                    this.Source.Equals(input.Source))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.StatusCode == input.StatusCode ||
                    (this.StatusCode != null &&
                    this.StatusCode.Equals(input.StatusCode))
                ) && 
                (
                    this.Title == input.Title ||
                    (this.Title != null &&
                    this.Title.Equals(input.Title))
                ) && 
                (
                    this.UpdateTime == input.UpdateTime ||
                    (this.UpdateTime != null &&
                    this.UpdateTime.Equals(input.UpdateTime))
                ) && 
                (
                    this.UpdaterId == input.UpdaterId ||
                    (this.UpdaterId != null &&
                    this.UpdaterId.Equals(input.UpdaterId))
                ) && 
                (
                    this.UpdaterName == input.UpdaterName ||
                    (this.UpdaterName != null &&
                    this.UpdaterName.Equals(input.UpdaterName))
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
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.CategoryId.GetHashCode();
                if (this.CategoryNamePath != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryNamePath.GetHashCode();
                }
                if (this.CategoryPath != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryPath.GetHashCode();
                }
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.CreateTime != null)
                {
                    hashCode = (hashCode * 59) + this.CreateTime.GetHashCode();
                }
                if (this.CreatorId != null)
                {
                    hashCode = (hashCode * 59) + this.CreatorId.GetHashCode();
                }
                if (this.ExtendTitles != null)
                {
                    hashCode = (hashCode * 59) + this.ExtendTitles.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Id.GetHashCode();
                if (this.Keywords != null)
                {
                    hashCode = (hashCode * 59) + this.Keywords.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.LibraryId.GetHashCode();
                hashCode = (hashCode * 59) + this.OrderNo.GetHashCode();
                if (this.Pictures != null)
                {
                    hashCode = (hashCode * 59) + this.Pictures.GetHashCode();
                }
                if (this.PublishEnd != null)
                {
                    hashCode = (hashCode * 59) + this.PublishEnd.GetHashCode();
                }
                if (this.PublishStart != null)
                {
                    hashCode = (hashCode * 59) + this.PublishStart.GetHashCode();
                }
                if (this.SceneCodes != null)
                {
                    hashCode = (hashCode * 59) + this.SceneCodes.GetHashCode();
                }
                if (this.Source != null)
                {
                    hashCode = (hashCode * 59) + this.Source.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.StatusCode != null)
                {
                    hashCode = (hashCode * 59) + this.StatusCode.GetHashCode();
                }
                if (this.Title != null)
                {
                    hashCode = (hashCode * 59) + this.Title.GetHashCode();
                }
                if (this.UpdateTime != null)
                {
                    hashCode = (hashCode * 59) + this.UpdateTime.GetHashCode();
                }
                if (this.UpdaterId != null)
                {
                    hashCode = (hashCode * 59) + this.UpdaterId.GetHashCode();
                }
                if (this.UpdaterName != null)
                {
                    hashCode = (hashCode * 59) + this.UpdaterName.GetHashCode();
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
