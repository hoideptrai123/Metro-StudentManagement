﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class StudentDBEntities : DbContext
    {
        public StudentDBEntities()
            : base("name=StudentDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AcademicMark> AcademicMark { get; set; }
        public virtual DbSet<ActivityGroup> ActivityGroup { get; set; }
        public virtual DbSet<Anouncement> Anouncement { get; set; }
        public virtual DbSet<BehaviorMark> BehaviorMark { get; set; }
        public virtual DbSet<Candre> Candre { get; set; }
        public virtual DbSet<Class> Class { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DiplomaProject> DiplomaProject { get; set; }
        public virtual DbSet<Discipline> Discipline { get; set; }
        public virtual DbSet<Exam> Exam { get; set; }
        public virtual DbSet<Faculty> Faculty { get; set; }
        public virtual DbSet<Parents> Parents { get; set; }
        public virtual DbSet<PlusFee> PlusFee { get; set; }
        public virtual DbSet<Policy> Policy { get; set; }
        public virtual DbSet<RegisterStudyUnit> RegisterStudyUnit { get; set; }
        public virtual DbSet<ScholarCondition> ScholarCondition { get; set; }
        public virtual DbSet<Scholarship> Scholarship { get; set; }
        public virtual DbSet<School> School { get; set; }
        public virtual DbSet<Semester> Semester { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<StudentUser> StudentUser { get; set; }
        public virtual DbSet<StudyFee> StudyFee { get; set; }
        public virtual DbSet<Teacher> Teacher { get; set; }
        public virtual DbSet<TeacherUser> TeacherUser { get; set; }
        public virtual DbSet<UserImage> UserImage { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<GeneralAnouncement> GeneralAnouncement { get; set; }
    
        public virtual ObjectResult<GetAcademicByID_Result> GetAcademicByID(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAcademicByID_Result>("GetAcademicByID", studentIDParameter);
        }
    
        public virtual ObjectResult<GetActivities_Result> GetActivities(string activities)
        {
            var activitiesParameter = activities != null ?
                new ObjectParameter("Activities", activities) :
                new ObjectParameter("Activities", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetActivities_Result>("GetActivities", activitiesParameter);
        }
    
        public virtual ObjectResult<GetActivityGroup_Result> GetActivityGroup(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetActivityGroup_Result>("GetActivityGroup", studentIDParameter);
        }
    
        public virtual ObjectResult<GetDetailActivity_Result> GetDetailActivity(string activitie)
        {
            var activitieParameter = activitie != null ?
                new ObjectParameter("Activitie", activitie) :
                new ObjectParameter("Activitie", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDetailActivity_Result>("GetDetailActivity", activitieParameter);
        }
    
        public virtual ObjectResult<GetDetailDisciplineByID_Result> GetDetailDisciplineByID(string disciplineID)
        {
            var disciplineIDParameter = disciplineID != null ?
                new ObjectParameter("DisciplineID", disciplineID) :
                new ObjectParameter("DisciplineID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDetailDisciplineByID_Result>("GetDetailDisciplineByID", disciplineIDParameter);
        }
    
        public virtual ObjectResult<GetDiplomaProject_Result> GetDiplomaProject(string studenID)
        {
            var studenIDParameter = studenID != null ?
                new ObjectParameter("StudenID", studenID) :
                new ObjectParameter("StudenID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDiplomaProject_Result>("GetDiplomaProject", studenIDParameter);
        }
    
        public virtual ObjectResult<GetStudentsInfoByID_Result> GetStudentsInfoByID(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentsInfoByID_Result>("GetStudentsInfoByID", studentIDParameter);
        }
    
        public virtual ObjectResult<GetUser_Result> GetUser(string iD, string passWord)
        {
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            var passWordParameter = passWord != null ?
                new ObjectParameter("PassWord", passWord) :
                new ObjectParameter("PassWord", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUser_Result>("GetUser", iDParameter, passWordParameter);
        }
    
        public virtual int ChangeUserPasswork(string newPasswork, string iD)
        {
            var newPassworkParameter = newPasswork != null ?
                new ObjectParameter("newPasswork", newPasswork) :
                new ObjectParameter("newPasswork", typeof(string));
    
            var iDParameter = iD != null ?
                new ObjectParameter("ID", iD) :
                new ObjectParameter("ID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ChangeUserPasswork", newPassworkParameter, iDParameter);
        }
    
        public virtual ObjectResult<GetUsersDetail_Result> GetUsersDetail(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUsersDetail_Result>("GetUsersDetail", studentIDParameter);
        }
    
        public virtual int AddNewUserImage(string imagePath, byte[] imageToByte, string studentID)
        {
            var imagePathParameter = imagePath != null ?
                new ObjectParameter("ImagePath", imagePath) :
                new ObjectParameter("ImagePath", typeof(string));
    
            var imageToByteParameter = imageToByte != null ?
                new ObjectParameter("ImageToByte", imageToByte) :
                new ObjectParameter("ImageToByte", typeof(byte[]));
    
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddNewUserImage", imagePathParameter, imageToByteParameter, studentIDParameter);
        }
    
        public virtual ObjectResult<IsDateRegister_Result> IsDateRegister()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<IsDateRegister_Result>("IsDateRegister");
        }
    
        public virtual ObjectResult<GetStudentAndParentInfoByID_Result> GetStudentAndParentInfoByID(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetStudentAndParentInfoByID_Result>("GetStudentAndParentInfoByID", studentIDParameter);
        }
    
        public virtual int UpdateStudentProfile(string studentID, string parentName, string parentMobile, Nullable<bool> parentGender, string presentAddress, string permanentAddress, string mobile, Nullable<bool> gender)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            var parentNameParameter = parentName != null ?
                new ObjectParameter("ParentName", parentName) :
                new ObjectParameter("ParentName", typeof(string));
    
            var parentMobileParameter = parentMobile != null ?
                new ObjectParameter("ParentMobile", parentMobile) :
                new ObjectParameter("ParentMobile", typeof(string));
    
            var parentGenderParameter = parentGender.HasValue ?
                new ObjectParameter("ParentGender", parentGender) :
                new ObjectParameter("ParentGender", typeof(bool));
    
            var presentAddressParameter = presentAddress != null ?
                new ObjectParameter("PresentAddress", presentAddress) :
                new ObjectParameter("PresentAddress", typeof(string));
    
            var permanentAddressParameter = permanentAddress != null ?
                new ObjectParameter("PermanentAddress", permanentAddress) :
                new ObjectParameter("PermanentAddress", typeof(string));
    
            var mobileParameter = mobile != null ?
                new ObjectParameter("Mobile", mobile) :
                new ObjectParameter("Mobile", typeof(string));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("Gender", gender) :
                new ObjectParameter("Gender", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStudentProfile", studentIDParameter, parentNameParameter, parentMobileParameter, parentGenderParameter, presentAddressParameter, permanentAddressParameter, mobileParameter, genderParameter);
        }
    
        public virtual ObjectResult<GetClassDetail_Result> GetClassDetail(string classID)
        {
            var classIDParameter = classID != null ?
                new ObjectParameter("ClassID", classID) :
                new ObjectParameter("ClassID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetClassDetail_Result>("GetClassDetail", classIDParameter);
        }
    
        public virtual ObjectResult<GetDeparmentDetail_Result> GetDeparmentDetail(string departmentID)
        {
            var departmentIDParameter = departmentID != null ?
                new ObjectParameter("DepartmentID", departmentID) :
                new ObjectParameter("DepartmentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDeparmentDetail_Result>("GetDeparmentDetail", departmentIDParameter);
        }
    
        public virtual ObjectResult<GetFacultyDetail_Result> GetFacultyDetail(string facultyID)
        {
            var facultyIDParameter = facultyID != null ?
                new ObjectParameter("FacultyID", facultyID) :
                new ObjectParameter("FacultyID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetFacultyDetail_Result>("GetFacultyDetail", facultyIDParameter);
        }
    
        public virtual ObjectResult<GetSchooltDetail_Result> GetSchooltDetail(string schoolID)
        {
            var schoolIDParameter = schoolID != null ?
                new ObjectParameter("SchoolID", schoolID) :
                new ObjectParameter("SchoolID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetSchooltDetail_Result>("GetSchooltDetail", schoolIDParameter);
        }
    
        public virtual ObjectResult<GetListDisciplineForThisUser_Result> GetListDisciplineForThisUser(string thisUser)
        {
            var thisUserParameter = thisUser != null ?
                new ObjectParameter("ThisUser", thisUser) :
                new ObjectParameter("ThisUser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetListDisciplineForThisUser_Result>("GetListDisciplineForThisUser", thisUserParameter);
        }
    
        public virtual int InsertRegisterStudyUnit(string studentID, string discipline, string semesterID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            var disciplineParameter = discipline != null ?
                new ObjectParameter("Discipline", discipline) :
                new ObjectParameter("Discipline", typeof(string));
    
            var semesterIDParameter = semesterID != null ?
                new ObjectParameter("SemesterID", semesterID) :
                new ObjectParameter("SemesterID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("InsertRegisterStudyUnit", studentIDParameter, disciplineParameter, semesterIDParameter);
        }
    
        public virtual ObjectResult<GetUniversityInfo_Result> GetUniversityInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetUniversityInfo_Result>("GetUniversityInfo");
        }
    
        public virtual ObjectResult<Get10NewestAnouncements_Result> Get10NewestAnouncements()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Get10NewestAnouncements_Result>("Get10NewestAnouncements");
        }
    
        public virtual ObjectResult<GetAllGeneralAnouncements_Result> GetAllGeneralAnouncements()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetAllGeneralAnouncements_Result>("GetAllGeneralAnouncements");
        }
    
        public virtual int DeleteRegisterStudyUnit(string studentID, string disciplineID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            var disciplineIDParameter = disciplineID != null ?
                new ObjectParameter("DisciplineID", disciplineID) :
                new ObjectParameter("DisciplineID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteRegisterStudyUnit", studentIDParameter, disciplineIDParameter);
        }
    
        public virtual ObjectResult<GetScheduleForDetail_Result> GetScheduleForDetail(string studentID, string semester, string studyDate)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            var semesterParameter = semester != null ?
                new ObjectParameter("Semester", semester) :
                new ObjectParameter("Semester", typeof(string));
    
            var studyDateParameter = studyDate != null ?
                new ObjectParameter("StudyDate", studyDate) :
                new ObjectParameter("StudyDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetScheduleForDetail_Result>("GetScheduleForDetail", studentIDParameter, semesterParameter, studyDateParameter);
        }
    
        public virtual int UpdateStarDay(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("UpdateStarDay", studentIDParameter);
        }
    
        public virtual ObjectResult<GetScheduleForDetail1_Result> GetScheduleForDetail1(string studentID, string semester, string studyDate)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            var semesterParameter = semester != null ?
                new ObjectParameter("Semester", semester) :
                new ObjectParameter("Semester", typeof(string));
    
            var studyDateParameter = studyDate != null ?
                new ObjectParameter("StudyDate", studyDate) :
                new ObjectParameter("StudyDate", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetScheduleForDetail1_Result>("GetScheduleForDetail1", studentIDParameter, semesterParameter, studyDateParameter);
        }
    
        public virtual ObjectResult<GetInfoDiscipline_Result> GetInfoDiscipline()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetInfoDiscipline_Result>("GetInfoDiscipline");
        }
    
        public virtual ObjectResult<GetInfoRegistered_Result> GetInfoRegistered(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetInfoRegistered_Result>("GetInfoRegistered", studentIDParameter);
        }
    
        public virtual ObjectResult<GetInfoRegistered1_Result> GetInfoRegistered1(string studentID)
        {
            var studentIDParameter = studentID != null ?
                new ObjectParameter("StudentID", studentID) :
                new ObjectParameter("StudentID", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetInfoRegistered1_Result>("GetInfoRegistered1", studentIDParameter);
        }
    
        public virtual ObjectResult<string> GetTeacherRegister()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetTeacherRegister");
        }
    
        public virtual ObjectResult<string> GetDepartmentRegister()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("GetDepartmentRegister");
        }
    
        public virtual ObjectResult<SortDisciplinebyTeacherAndDepartment_Result> SortDisciplinebyTeacherAndDepartment(string teacherName, string departmentName)
        {
            var teacherNameParameter = teacherName != null ?
                new ObjectParameter("TeacherName", teacherName) :
                new ObjectParameter("TeacherName", typeof(string));
    
            var departmentNameParameter = departmentName != null ?
                new ObjectParameter("DepartmentName", departmentName) :
                new ObjectParameter("DepartmentName", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SortDisciplinebyTeacherAndDepartment_Result>("SortDisciplinebyTeacherAndDepartment", teacherNameParameter, departmentNameParameter);
        }
    
        public virtual ObjectResult<GetDateRegisterUnit_Result> GetDateRegisterUnit()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDateRegisterUnit_Result>("GetDateRegisterUnit");
        }
    
        public virtual ObjectResult<Nullable<int>> TimeCloseRegisterUnit()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("TimeCloseRegisterUnit");
        }
    
        public virtual ObjectResult<GetGeneralAnoucementDetailByTitle_Result> GetGeneralAnoucementDetailByTitle(string title)
        {
            var titleParameter = title != null ?
                new ObjectParameter("title", title) :
                new ObjectParameter("title", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetGeneralAnoucementDetailByTitle_Result>("GetGeneralAnoucementDetailByTitle", titleParameter);
        }
    }
}
