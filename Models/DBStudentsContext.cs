using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DBfirstStudents.Models
{
    public partial class DBStudentsContext : DbContext
    {
        public DBStudentsContext()
        {
        }

        public DBStudentsContext(DbContextOptions<DBStudentsContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Course> Course { get; set; }
        public virtual DbSet<Enrollment> Enrollment { get; set; }
        public virtual DbSet<Student> Student { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
   optionsBuilder.UseSqlite("Data Source=DBStudents.db;");
// optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=DBStudents;Integrated Security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CourseId)
                    .HasColumnName("CourseID")
                    .HasColumnType("INT");

                entity.Property(e => e.Credits).HasColumnType("INT");

                entity.Property(e => e.Title).HasColumnType("NVARCHAR (50)");
            });

            modelBuilder.Entity<Enrollment>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CourseId)
                    .HasColumnName("CourseID")
                    .HasColumnType("INT");

                entity.Property(e => e.EnrollmentId)
                    .HasColumnName("EnrollmentID")
                    .HasColumnType("INT");

                entity.Property(e => e.Grade)
                    .HasColumnName("Grade")
                    .HasColumnType("INT");

                entity.Property(e => e.StudentID)
                    .HasColumnName("StudentID")
                    .HasColumnType("INT");
            });

            modelBuilder.Entity<Student>(entity =>
            {
               // entity.HasNoKey();

                entity.Property(e => e.EnrollmentDate).HasColumnType("DATETIME");

                entity.Property(e => e.FirstName).HasColumnType("NVARCHAR (50)");

                entity.Property(e => e.LastName).HasColumnType("NVARCHAR (50)");

                entity.Property(e => e.StudentID)
                    .HasColumnName("StudentID")
                    .HasColumnType("INT");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
