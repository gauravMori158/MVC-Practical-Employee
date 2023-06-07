﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_Practical_EF.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class TestDb1Entities : DbContext
    {
        public TestDb1Entities()
            : base("name=TestDb1Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Employee> Employees { get; set; }
    
        public virtual int sp_DeleteUser(Nullable<int> id)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_DeleteUser", idParameter);
        }
    
        public virtual int sp_GetEmployeeInfo()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_GetEmployeeInfo");
        }
    
        public virtual int sp_InsertUser(string firstName, string middleName, string lastName, Nullable<int> empCode, Nullable<int> gender, Nullable<System.DateTime> doB, Nullable<int> salary, Nullable<System.DateTime> joiningDate, Nullable<System.DateTime> resignDate)
        {
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("middleName", middleName) :
                new ObjectParameter("middleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var empCodeParameter = empCode.HasValue ?
                new ObjectParameter("empCode", empCode) :
                new ObjectParameter("empCode", typeof(int));
    
            var genderParameter = gender.HasValue ?
                new ObjectParameter("gender", gender) :
                new ObjectParameter("gender", typeof(int));
    
            var doBParameter = doB.HasValue ?
                new ObjectParameter("doB", doB) :
                new ObjectParameter("doB", typeof(System.DateTime));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            var joiningDateParameter = joiningDate.HasValue ?
                new ObjectParameter("joiningDate", joiningDate) :
                new ObjectParameter("joiningDate", typeof(System.DateTime));
    
            var resignDateParameter = resignDate.HasValue ?
                new ObjectParameter("resignDate", resignDate) :
                new ObjectParameter("resignDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_InsertUser", firstNameParameter, middleNameParameter, lastNameParameter, empCodeParameter, genderParameter, doBParameter, salaryParameter, joiningDateParameter, resignDateParameter);
        }
    
        public virtual int sp_UpdateUser(Nullable<int> id, string firstName, string middleName, string lastName, Nullable<int> empCode, Nullable<int> salary, Nullable<System.DateTime> resignDate)
        {
            var idParameter = id.HasValue ?
                new ObjectParameter("id", id) :
                new ObjectParameter("id", typeof(int));
    
            var firstNameParameter = firstName != null ?
                new ObjectParameter("firstName", firstName) :
                new ObjectParameter("firstName", typeof(string));
    
            var middleNameParameter = middleName != null ?
                new ObjectParameter("middleName", middleName) :
                new ObjectParameter("middleName", typeof(string));
    
            var lastNameParameter = lastName != null ?
                new ObjectParameter("lastName", lastName) :
                new ObjectParameter("lastName", typeof(string));
    
            var empCodeParameter = empCode.HasValue ?
                new ObjectParameter("empCode", empCode) :
                new ObjectParameter("empCode", typeof(int));
    
            var salaryParameter = salary.HasValue ?
                new ObjectParameter("salary", salary) :
                new ObjectParameter("salary", typeof(int));
    
            var resignDateParameter = resignDate.HasValue ?
                new ObjectParameter("resignDate", resignDate) :
                new ObjectParameter("resignDate", typeof(System.DateTime));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_UpdateUser", idParameter, firstNameParameter, middleNameParameter, lastNameParameter, empCodeParameter, salaryParameter, resignDateParameter);
        }
    }
}
