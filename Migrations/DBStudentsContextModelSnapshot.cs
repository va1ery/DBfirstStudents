﻿// <auto-generated />
using System;
using DBfirstStudents.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBfirstStudents.Migrations
{
    [DbContext(typeof(DBStudentsContext))]
    partial class DBStudentsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("DBfirstStudents.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnName("CourseID")
                        .HasColumnType("INT");

                    b.Property<int>("Credits")
                        .HasColumnType("INT");

                    b.Property<string>("Title")
                        .HasColumnType("NVARCHAR (50)");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("DBfirstStudents.Models.Enrollment", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnName("CourseID")
                        .HasColumnType("INT");

                    b.Property<int>("EnrollmentId")
                        .HasColumnName("EnrollmentID")
                        .HasColumnType("INT");

                    b.Property<int>("Grade")
                        .HasColumnName("Grade")
                        .HasColumnType("INT");

                    b.Property<int>("StudentID")
                        .HasColumnName("StudentID")
                        .HasColumnType("INT");

                    b.ToTable("Enrollment");
                });

            modelBuilder.Entity("DBfirstStudents.Models.Student", b =>
                {
                    b.Property<DateTime>("EnrollmentDate")
                        .HasColumnType("DATETIME");

                    b.Property<string>("FirstName")
                        .HasColumnType("NVARCHAR (50)");

                    b.Property<string>("LastName")
                        .HasColumnType("NVARCHAR (50)");

                    b.Property<int>("StudentID")
                        .HasColumnName("StudentID")
                        .HasColumnType("INT");

                    b.ToTable("Student");
                });
#pragma warning restore 612, 618
        }
    }
}
