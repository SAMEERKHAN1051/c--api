using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace API_ASSIGNMENTS.Models;

public partial class ApiassigmentContext : DbContext
{
    public ApiassigmentContext()
    {
    }

    public ApiassigmentContext(DbContextOptions<ApiassigmentContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("data source=.;initial catalog=apiassigment;user id=sa;password=aptech; TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__employee__3214EC07B31DC86B");

            entity.ToTable("employee");

            entity.HasIndex(e => e.EmpEmail, "UQ__employee__EE901BEDAD4E0E8C").IsUnique();

            entity.Property(e => e.EmpEmail)
                .HasMaxLength(224)
                .IsUnicode(false)
                .HasColumnName("Emp_email");
            entity.Property(e => e.EmpName)
                .HasMaxLength(224)
                .IsUnicode(false)
                .HasColumnName("Emp_name");
            entity.Property(e => e.EmpPhone)
                .HasMaxLength(224)
                .IsUnicode(false)
                .HasColumnName("Emp_phone");
            entity.Property(e => e.EmpSalary).HasColumnName("Emp_salary");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
