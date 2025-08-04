using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DummyProject.Model;

public partial class DummyAuthDbContext : DbContext
{
    public DummyAuthDbContext()
    {
    }

    public DummyAuthDbContext(DbContextOptions<DummyAuthDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; }

    public virtual DbSet<MisUser> MisUsers { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.HasDefaultSchema("db_owner");

        modelBuilder.Entity<EmployeeInfo>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__Employee__CBA14F48426A2430");

            entity.ToTable("EmployeeInfo");

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMPLOYEE_ID");
            entity.Property(e => e.CbsBranchCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("CBS_BRANCH_CODE");
            entity.Property(e => e.CbsBranchMnemonic)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("CBS_BRANCH_MNEMONIC");
            entity.Property(e => e.CbsBranchName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("CBS_BRANCH_NAME");
            entity.Property(e => e.DesigName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("DESIG_NAME");
            entity.Property(e => e.DivisionName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("DIVISION_NAME");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("EMAIL_ADDRESS");
            entity.Property(e => e.EmpGender)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("EMP_GENDER");
            entity.Property(e => e.EmpStatus)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("EMP_STATUS");
            entity.Property(e => e.FullName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("FULL_NAME");
            entity.Property(e => e.FunctionName)
                .HasMaxLength(150)
                .IsUnicode(false)
                .HasColumnName("FUNCTION_NAME");
            entity.Property(e => e.LineManagerCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("LINE_MANAGER_CODE");
            entity.Property(e => e.MisysId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("MISYS_ID");
            entity.Property(e => e.MobileNo)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("MOBILE_NO");
            entity.Property(e => e.OrbitBranchCode)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("ORBIT_BRANCH_CODE");
            entity.Property(e => e.OrbitBranchName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("ORBIT_BRANCH_NAME");
        });

        modelBuilder.Entity<MisUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("mis_User", "dbo");

            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
