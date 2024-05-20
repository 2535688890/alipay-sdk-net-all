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
    /// JobWorthPositionInfo
    /// </summary>
    [DataContract(Name = "JobWorthPositionInfo")]
    public partial class JobWorthPositionInfo : IEquatable<JobWorthPositionInfo>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JobWorthPositionInfo" /> class.
        /// </summary>
        /// <param name="age">职位要求-年龄要求 无要求（不传）、28岁以上(OVER28)、40岁以下(BELOW40)、25岁～35岁(25TO35).</param>
        /// <param name="benefit">福利，现有标签，最多5个标签，使用英文,分割 参考 https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.1.</param>
        /// <param name="certifications">技能、证书等要求，比如学历、健康证、普通话或其他技能证书等.</param>
        /// <param name="companyCertificate">发布企业统一社会信用代码.</param>
        /// <param name="companyLogoAftsId">上传的aftsid.</param>
        /// <param name="companyName">企业工商全称.</param>
        /// <param name="count">招聘人数.</param>
        /// <param name="education">学历要求,HIGHSCHOOL_AND_BELOW（高中及以下），POLYTECHNIC（中专），COLLEGE（大专），BACHELOR（本科），MASTER（硕士），DOCTOR_AND_ABOVE（博士及以上）.</param>
        /// <param name="gender">无要求（不传）、男或者女.</param>
        /// <param name="kaPositionId">合作方岗位id自定义保持唯一性.</param>
        /// <param name="positionDesc">长文本描述.</param>
        /// <param name="positionId">工作证岗位库的职位主键，只有更新职位信息时需要传入。第一次传入岗位后返回.</param>
        /// <param name="positionJobId">岗位对应的行业id，字段参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2.</param>
        /// <param name="positionJobName">岗位对应的职业名称.</param>
        /// <param name="positionProfessionId">岗位对应的职业id，字段参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2.</param>
        /// <param name="positionProperty">岗位属性：全职(FULL_TIME)或者兼职(PART_TIME).</param>
        /// <param name="positionStatus">职位的状态，只有上架(UNCHECK)和下架(OFFLINE)两种.</param>
        /// <param name="positionTitle">短文本描述.</param>
        /// <param name="salaryMax">薪水范围，不能低于salary_min.</param>
        /// <param name="salaryMin">薪水范围，不能高于salary_max.</param>
        /// <param name="salaryType">薪资类型：日结(DAY)、月结(MONTH)、周结(WEEK)、完工结(DONE)、其他(OTHER).</param>
        /// <param name="salaryUnit">薪资单位，元/日(DAY)、元/次(TIME)、元/月(MONTH)、元/小时(HOUR)、元/件 (NUM)、元/周 (WEEK)、其他 (OTHER).</param>
        /// <param name="skillTag">岗位需要的技能标签，最多5个，使用英文逗号分割.</param>
        /// <param name="skipUrl">职位跳转链接，当前只支持支付宝小程序，也就是alipays://platformapi/ 开头.</param>
        /// <param name="workCity">高德city code，例：北京010，线上工作9999 参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.3.</param>
        /// <param name="workLongitude">经纬度，前面是经度，后面是纬度，使用英文逗号隔开.</param>
        /// <param name="workRegion">工作地所在的区县,使用高德的adcode，例：朝阳区110105 参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2.</param>
        /// <param name="workYear">工作年限，1年以下（ONE）、1～3年（THREE）、3～5年（FIVE）、5～10年（TEN）、10年以上（OVER_TEN）.</param>
        public JobWorthPositionInfo(string age = default(string), string benefit = default(string), string certifications = default(string), string companyCertificate = default(string), string companyLogoAftsId = default(string), string companyName = default(string), int count = default(int), string education = default(string), string gender = default(string), string kaPositionId = default(string), string positionDesc = default(string), string positionId = default(string), string positionJobId = default(string), string positionJobName = default(string), string positionProfessionId = default(string), string positionProperty = default(string), string positionStatus = default(string), string positionTitle = default(string), string salaryMax = default(string), string salaryMin = default(string), string salaryType = default(string), string salaryUnit = default(string), string skillTag = default(string), string skipUrl = default(string), string workCity = default(string), string workLongitude = default(string), string workRegion = default(string), string workYear = default(string))
        {
            this.Age = age;
            this.Benefit = benefit;
            this.Certifications = certifications;
            this.CompanyCertificate = companyCertificate;
            this.CompanyLogoAftsId = companyLogoAftsId;
            this.CompanyName = companyName;
            this.Count = count;
            this.Education = education;
            this.Gender = gender;
            this.KaPositionId = kaPositionId;
            this.PositionDesc = positionDesc;
            this.PositionId = positionId;
            this.PositionJobId = positionJobId;
            this.PositionJobName = positionJobName;
            this.PositionProfessionId = positionProfessionId;
            this.PositionProperty = positionProperty;
            this.PositionStatus = positionStatus;
            this.PositionTitle = positionTitle;
            this.SalaryMax = salaryMax;
            this.SalaryMin = salaryMin;
            this.SalaryType = salaryType;
            this.SalaryUnit = salaryUnit;
            this.SkillTag = skillTag;
            this.SkipUrl = skipUrl;
            this.WorkCity = workCity;
            this.WorkLongitude = workLongitude;
            this.WorkRegion = workRegion;
            this.WorkYear = workYear;
        }

        /// <summary>
        /// 职位要求-年龄要求 无要求（不传）、28岁以上(OVER28)、40岁以下(BELOW40)、25岁～35岁(25TO35)
        /// </summary>
        /// <value>职位要求-年龄要求 无要求（不传）、28岁以上(OVER28)、40岁以下(BELOW40)、25岁～35岁(25TO35)</value>
        [DataMember(Name = "age", EmitDefaultValue = false)]
        public string Age { get; set; }

        /// <summary>
        /// 福利，现有标签，最多5个标签，使用英文,分割 参考 https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.1
        /// </summary>
        /// <value>福利，现有标签，最多5个标签，使用英文,分割 参考 https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.1</value>
        [DataMember(Name = "benefit", EmitDefaultValue = false)]
        public string Benefit { get; set; }

        /// <summary>
        /// 技能、证书等要求，比如学历、健康证、普通话或其他技能证书等
        /// </summary>
        /// <value>技能、证书等要求，比如学历、健康证、普通话或其他技能证书等</value>
        [DataMember(Name = "certifications", EmitDefaultValue = false)]
        public string Certifications { get; set; }

        /// <summary>
        /// 发布企业统一社会信用代码
        /// </summary>
        /// <value>发布企业统一社会信用代码</value>
        [DataMember(Name = "company_certificate", EmitDefaultValue = false)]
        public string CompanyCertificate { get; set; }

        /// <summary>
        /// 上传的aftsid
        /// </summary>
        /// <value>上传的aftsid</value>
        [DataMember(Name = "company_logo_afts_id", EmitDefaultValue = false)]
        public string CompanyLogoAftsId { get; set; }

        /// <summary>
        /// 企业工商全称
        /// </summary>
        /// <value>企业工商全称</value>
        [DataMember(Name = "company_name", EmitDefaultValue = false)]
        public string CompanyName { get; set; }

        /// <summary>
        /// 招聘人数
        /// </summary>
        /// <value>招聘人数</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// 学历要求,HIGHSCHOOL_AND_BELOW（高中及以下），POLYTECHNIC（中专），COLLEGE（大专），BACHELOR（本科），MASTER（硕士），DOCTOR_AND_ABOVE（博士及以上）
        /// </summary>
        /// <value>学历要求,HIGHSCHOOL_AND_BELOW（高中及以下），POLYTECHNIC（中专），COLLEGE（大专），BACHELOR（本科），MASTER（硕士），DOCTOR_AND_ABOVE（博士及以上）</value>
        [DataMember(Name = "education", EmitDefaultValue = false)]
        public string Education { get; set; }

        /// <summary>
        /// 无要求（不传）、男或者女
        /// </summary>
        /// <value>无要求（不传）、男或者女</value>
        [DataMember(Name = "gender", EmitDefaultValue = false)]
        public string Gender { get; set; }

        /// <summary>
        /// 合作方岗位id自定义保持唯一性
        /// </summary>
        /// <value>合作方岗位id自定义保持唯一性</value>
        [DataMember(Name = "ka_position_id", EmitDefaultValue = false)]
        public string KaPositionId { get; set; }

        /// <summary>
        /// 长文本描述
        /// </summary>
        /// <value>长文本描述</value>
        [DataMember(Name = "position_desc", EmitDefaultValue = false)]
        public string PositionDesc { get; set; }

        /// <summary>
        /// 工作证岗位库的职位主键，只有更新职位信息时需要传入。第一次传入岗位后返回
        /// </summary>
        /// <value>工作证岗位库的职位主键，只有更新职位信息时需要传入。第一次传入岗位后返回</value>
        [DataMember(Name = "position_id", EmitDefaultValue = false)]
        public string PositionId { get; set; }

        /// <summary>
        /// 岗位对应的行业id，字段参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2
        /// </summary>
        /// <value>岗位对应的行业id，字段参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2</value>
        [DataMember(Name = "position_job_id", EmitDefaultValue = false)]
        public string PositionJobId { get; set; }

        /// <summary>
        /// 岗位对应的职业名称
        /// </summary>
        /// <value>岗位对应的职业名称</value>
        [DataMember(Name = "position_job_name", EmitDefaultValue = false)]
        public string PositionJobName { get; set; }

        /// <summary>
        /// 岗位对应的职业id，字段参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2
        /// </summary>
        /// <value>岗位对应的职业id，字段参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2</value>
        [DataMember(Name = "position_profession_id", EmitDefaultValue = false)]
        public string PositionProfessionId { get; set; }

        /// <summary>
        /// 岗位属性：全职(FULL_TIME)或者兼职(PART_TIME)
        /// </summary>
        /// <value>岗位属性：全职(FULL_TIME)或者兼职(PART_TIME)</value>
        [DataMember(Name = "position_property", EmitDefaultValue = false)]
        public string PositionProperty { get; set; }

        /// <summary>
        /// 职位的状态，只有上架(UNCHECK)和下架(OFFLINE)两种
        /// </summary>
        /// <value>职位的状态，只有上架(UNCHECK)和下架(OFFLINE)两种</value>
        [DataMember(Name = "position_status", EmitDefaultValue = false)]
        public string PositionStatus { get; set; }

        /// <summary>
        /// 短文本描述
        /// </summary>
        /// <value>短文本描述</value>
        [DataMember(Name = "position_title", EmitDefaultValue = false)]
        public string PositionTitle { get; set; }

        /// <summary>
        /// 薪水范围，不能低于salary_min
        /// </summary>
        /// <value>薪水范围，不能低于salary_min</value>
        [DataMember(Name = "salary_max", EmitDefaultValue = false)]
        public string SalaryMax { get; set; }

        /// <summary>
        /// 薪水范围，不能高于salary_max
        /// </summary>
        /// <value>薪水范围，不能高于salary_max</value>
        [DataMember(Name = "salary_min", EmitDefaultValue = false)]
        public string SalaryMin { get; set; }

        /// <summary>
        /// 薪资类型：日结(DAY)、月结(MONTH)、周结(WEEK)、完工结(DONE)、其他(OTHER)
        /// </summary>
        /// <value>薪资类型：日结(DAY)、月结(MONTH)、周结(WEEK)、完工结(DONE)、其他(OTHER)</value>
        [DataMember(Name = "salary_type", EmitDefaultValue = false)]
        public string SalaryType { get; set; }

        /// <summary>
        /// 薪资单位，元/日(DAY)、元/次(TIME)、元/月(MONTH)、元/小时(HOUR)、元/件 (NUM)、元/周 (WEEK)、其他 (OTHER)
        /// </summary>
        /// <value>薪资单位，元/日(DAY)、元/次(TIME)、元/月(MONTH)、元/小时(HOUR)、元/件 (NUM)、元/周 (WEEK)、其他 (OTHER)</value>
        [DataMember(Name = "salary_unit", EmitDefaultValue = false)]
        public string SalaryUnit { get; set; }

        /// <summary>
        /// 岗位需要的技能标签，最多5个，使用英文逗号分割
        /// </summary>
        /// <value>岗位需要的技能标签，最多5个，使用英文逗号分割</value>
        [DataMember(Name = "skill_tag", EmitDefaultValue = false)]
        public string SkillTag { get; set; }

        /// <summary>
        /// 职位跳转链接，当前只支持支付宝小程序，也就是alipays://platformapi/ 开头
        /// </summary>
        /// <value>职位跳转链接，当前只支持支付宝小程序，也就是alipays://platformapi/ 开头</value>
        [DataMember(Name = "skip_url", EmitDefaultValue = false)]
        public string SkipUrl { get; set; }

        /// <summary>
        /// 高德city code，例：北京010，线上工作9999 参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.3
        /// </summary>
        /// <value>高德city code，例：北京010，线上工作9999 参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.3</value>
        [DataMember(Name = "work_city", EmitDefaultValue = false)]
        public string WorkCity { get; set; }

        /// <summary>
        /// 经纬度，前面是经度，后面是纬度，使用英文逗号隔开
        /// </summary>
        /// <value>经纬度，前面是经度，后面是纬度，使用英文逗号隔开</value>
        [DataMember(Name = "work_longitude", EmitDefaultValue = false)]
        public string WorkLongitude { get; set; }

        /// <summary>
        /// 工作地所在的区县,使用高德的adcode，例：朝阳区110105 参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2
        /// </summary>
        /// <value>工作地所在的区县,使用高德的adcode，例：朝阳区110105 参考https://www.yuque.com/docs/share/805e9840-ae9d-499c-b566-46b3b8c9fb2d?# 《4.1 服务端接入- -- -职位传入接口》的1.3.1.2</value>
        [DataMember(Name = "work_region", EmitDefaultValue = false)]
        public string WorkRegion { get; set; }

        /// <summary>
        /// 工作年限，1年以下（ONE）、1～3年（THREE）、3～5年（FIVE）、5～10年（TEN）、10年以上（OVER_TEN）
        /// </summary>
        /// <value>工作年限，1年以下（ONE）、1～3年（THREE）、3～5年（FIVE）、5～10年（TEN）、10年以上（OVER_TEN）</value>
        [DataMember(Name = "work_year", EmitDefaultValue = false)]
        public string WorkYear { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class JobWorthPositionInfo {\n");
            sb.Append("  Age: ").Append(Age).Append("\n");
            sb.Append("  Benefit: ").Append(Benefit).Append("\n");
            sb.Append("  Certifications: ").Append(Certifications).Append("\n");
            sb.Append("  CompanyCertificate: ").Append(CompanyCertificate).Append("\n");
            sb.Append("  CompanyLogoAftsId: ").Append(CompanyLogoAftsId).Append("\n");
            sb.Append("  CompanyName: ").Append(CompanyName).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  Education: ").Append(Education).Append("\n");
            sb.Append("  Gender: ").Append(Gender).Append("\n");
            sb.Append("  KaPositionId: ").Append(KaPositionId).Append("\n");
            sb.Append("  PositionDesc: ").Append(PositionDesc).Append("\n");
            sb.Append("  PositionId: ").Append(PositionId).Append("\n");
            sb.Append("  PositionJobId: ").Append(PositionJobId).Append("\n");
            sb.Append("  PositionJobName: ").Append(PositionJobName).Append("\n");
            sb.Append("  PositionProfessionId: ").Append(PositionProfessionId).Append("\n");
            sb.Append("  PositionProperty: ").Append(PositionProperty).Append("\n");
            sb.Append("  PositionStatus: ").Append(PositionStatus).Append("\n");
            sb.Append("  PositionTitle: ").Append(PositionTitle).Append("\n");
            sb.Append("  SalaryMax: ").Append(SalaryMax).Append("\n");
            sb.Append("  SalaryMin: ").Append(SalaryMin).Append("\n");
            sb.Append("  SalaryType: ").Append(SalaryType).Append("\n");
            sb.Append("  SalaryUnit: ").Append(SalaryUnit).Append("\n");
            sb.Append("  SkillTag: ").Append(SkillTag).Append("\n");
            sb.Append("  SkipUrl: ").Append(SkipUrl).Append("\n");
            sb.Append("  WorkCity: ").Append(WorkCity).Append("\n");
            sb.Append("  WorkLongitude: ").Append(WorkLongitude).Append("\n");
            sb.Append("  WorkRegion: ").Append(WorkRegion).Append("\n");
            sb.Append("  WorkYear: ").Append(WorkYear).Append("\n");
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
            return this.Equals(input as JobWorthPositionInfo);
        }

        /// <summary>
        /// Returns true if JobWorthPositionInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of JobWorthPositionInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobWorthPositionInfo input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Age == input.Age ||
                    (this.Age != null &&
                    this.Age.Equals(input.Age))
                ) && 
                (
                    this.Benefit == input.Benefit ||
                    (this.Benefit != null &&
                    this.Benefit.Equals(input.Benefit))
                ) && 
                (
                    this.Certifications == input.Certifications ||
                    (this.Certifications != null &&
                    this.Certifications.Equals(input.Certifications))
                ) && 
                (
                    this.CompanyCertificate == input.CompanyCertificate ||
                    (this.CompanyCertificate != null &&
                    this.CompanyCertificate.Equals(input.CompanyCertificate))
                ) && 
                (
                    this.CompanyLogoAftsId == input.CompanyLogoAftsId ||
                    (this.CompanyLogoAftsId != null &&
                    this.CompanyLogoAftsId.Equals(input.CompanyLogoAftsId))
                ) && 
                (
                    this.CompanyName == input.CompanyName ||
                    (this.CompanyName != null &&
                    this.CompanyName.Equals(input.CompanyName))
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.Education == input.Education ||
                    (this.Education != null &&
                    this.Education.Equals(input.Education))
                ) && 
                (
                    this.Gender == input.Gender ||
                    (this.Gender != null &&
                    this.Gender.Equals(input.Gender))
                ) && 
                (
                    this.KaPositionId == input.KaPositionId ||
                    (this.KaPositionId != null &&
                    this.KaPositionId.Equals(input.KaPositionId))
                ) && 
                (
                    this.PositionDesc == input.PositionDesc ||
                    (this.PositionDesc != null &&
                    this.PositionDesc.Equals(input.PositionDesc))
                ) && 
                (
                    this.PositionId == input.PositionId ||
                    (this.PositionId != null &&
                    this.PositionId.Equals(input.PositionId))
                ) && 
                (
                    this.PositionJobId == input.PositionJobId ||
                    (this.PositionJobId != null &&
                    this.PositionJobId.Equals(input.PositionJobId))
                ) && 
                (
                    this.PositionJobName == input.PositionJobName ||
                    (this.PositionJobName != null &&
                    this.PositionJobName.Equals(input.PositionJobName))
                ) && 
                (
                    this.PositionProfessionId == input.PositionProfessionId ||
                    (this.PositionProfessionId != null &&
                    this.PositionProfessionId.Equals(input.PositionProfessionId))
                ) && 
                (
                    this.PositionProperty == input.PositionProperty ||
                    (this.PositionProperty != null &&
                    this.PositionProperty.Equals(input.PositionProperty))
                ) && 
                (
                    this.PositionStatus == input.PositionStatus ||
                    (this.PositionStatus != null &&
                    this.PositionStatus.Equals(input.PositionStatus))
                ) && 
                (
                    this.PositionTitle == input.PositionTitle ||
                    (this.PositionTitle != null &&
                    this.PositionTitle.Equals(input.PositionTitle))
                ) && 
                (
                    this.SalaryMax == input.SalaryMax ||
                    (this.SalaryMax != null &&
                    this.SalaryMax.Equals(input.SalaryMax))
                ) && 
                (
                    this.SalaryMin == input.SalaryMin ||
                    (this.SalaryMin != null &&
                    this.SalaryMin.Equals(input.SalaryMin))
                ) && 
                (
                    this.SalaryType == input.SalaryType ||
                    (this.SalaryType != null &&
                    this.SalaryType.Equals(input.SalaryType))
                ) && 
                (
                    this.SalaryUnit == input.SalaryUnit ||
                    (this.SalaryUnit != null &&
                    this.SalaryUnit.Equals(input.SalaryUnit))
                ) && 
                (
                    this.SkillTag == input.SkillTag ||
                    (this.SkillTag != null &&
                    this.SkillTag.Equals(input.SkillTag))
                ) && 
                (
                    this.SkipUrl == input.SkipUrl ||
                    (this.SkipUrl != null &&
                    this.SkipUrl.Equals(input.SkipUrl))
                ) && 
                (
                    this.WorkCity == input.WorkCity ||
                    (this.WorkCity != null &&
                    this.WorkCity.Equals(input.WorkCity))
                ) && 
                (
                    this.WorkLongitude == input.WorkLongitude ||
                    (this.WorkLongitude != null &&
                    this.WorkLongitude.Equals(input.WorkLongitude))
                ) && 
                (
                    this.WorkRegion == input.WorkRegion ||
                    (this.WorkRegion != null &&
                    this.WorkRegion.Equals(input.WorkRegion))
                ) && 
                (
                    this.WorkYear == input.WorkYear ||
                    (this.WorkYear != null &&
                    this.WorkYear.Equals(input.WorkYear))
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
                if (this.Age != null)
                {
                    hashCode = (hashCode * 59) + this.Age.GetHashCode();
                }
                if (this.Benefit != null)
                {
                    hashCode = (hashCode * 59) + this.Benefit.GetHashCode();
                }
                if (this.Certifications != null)
                {
                    hashCode = (hashCode * 59) + this.Certifications.GetHashCode();
                }
                if (this.CompanyCertificate != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyCertificate.GetHashCode();
                }
                if (this.CompanyLogoAftsId != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyLogoAftsId.GetHashCode();
                }
                if (this.CompanyName != null)
                {
                    hashCode = (hashCode * 59) + this.CompanyName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Count.GetHashCode();
                if (this.Education != null)
                {
                    hashCode = (hashCode * 59) + this.Education.GetHashCode();
                }
                if (this.Gender != null)
                {
                    hashCode = (hashCode * 59) + this.Gender.GetHashCode();
                }
                if (this.KaPositionId != null)
                {
                    hashCode = (hashCode * 59) + this.KaPositionId.GetHashCode();
                }
                if (this.PositionDesc != null)
                {
                    hashCode = (hashCode * 59) + this.PositionDesc.GetHashCode();
                }
                if (this.PositionId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionId.GetHashCode();
                }
                if (this.PositionJobId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionJobId.GetHashCode();
                }
                if (this.PositionJobName != null)
                {
                    hashCode = (hashCode * 59) + this.PositionJobName.GetHashCode();
                }
                if (this.PositionProfessionId != null)
                {
                    hashCode = (hashCode * 59) + this.PositionProfessionId.GetHashCode();
                }
                if (this.PositionProperty != null)
                {
                    hashCode = (hashCode * 59) + this.PositionProperty.GetHashCode();
                }
                if (this.PositionStatus != null)
                {
                    hashCode = (hashCode * 59) + this.PositionStatus.GetHashCode();
                }
                if (this.PositionTitle != null)
                {
                    hashCode = (hashCode * 59) + this.PositionTitle.GetHashCode();
                }
                if (this.SalaryMax != null)
                {
                    hashCode = (hashCode * 59) + this.SalaryMax.GetHashCode();
                }
                if (this.SalaryMin != null)
                {
                    hashCode = (hashCode * 59) + this.SalaryMin.GetHashCode();
                }
                if (this.SalaryType != null)
                {
                    hashCode = (hashCode * 59) + this.SalaryType.GetHashCode();
                }
                if (this.SalaryUnit != null)
                {
                    hashCode = (hashCode * 59) + this.SalaryUnit.GetHashCode();
                }
                if (this.SkillTag != null)
                {
                    hashCode = (hashCode * 59) + this.SkillTag.GetHashCode();
                }
                if (this.SkipUrl != null)
                {
                    hashCode = (hashCode * 59) + this.SkipUrl.GetHashCode();
                }
                if (this.WorkCity != null)
                {
                    hashCode = (hashCode * 59) + this.WorkCity.GetHashCode();
                }
                if (this.WorkLongitude != null)
                {
                    hashCode = (hashCode * 59) + this.WorkLongitude.GetHashCode();
                }
                if (this.WorkRegion != null)
                {
                    hashCode = (hashCode * 59) + this.WorkRegion.GetHashCode();
                }
                if (this.WorkYear != null)
                {
                    hashCode = (hashCode * 59) + this.WorkYear.GetHashCode();
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
