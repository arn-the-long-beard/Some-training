﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Ng2AspCore.DBModel;
using System;

namespace TalaFisk.DBModel.Migrations
{
    [DbContext(typeof(HRContext))]
    partial class HRContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.2-rtm-10011")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ng2AspCore.DBModel.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("BirthDay");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("EmployeeId");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("Ng2AspCore.DBModel.Project", b =>
                {
                    b.Property<int>("ProjectId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(200);

                    b.Property<string>("Title")
                        .HasMaxLength(100);

                    b.HasKey("ProjectId");

                    b.ToTable("Projects");
                });

            modelBuilder.Entity("Ng2AspCore.DBModel.RoleAssignment", b =>
                {
                    b.Property<int>("RoleAssignmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Capacity");

                    b.Property<int>("EmployeeId");

                    b.Property<DateTime>("End");

                    b.Property<string>("Position")
                        .HasMaxLength(30);

                    b.Property<int>("ProjectId");

                    b.Property<DateTime>("Start");

                    b.HasKey("RoleAssignmentId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ProjectId");

                    b.ToTable("RoleAssignments");
                });

            modelBuilder.Entity("Ng2AspCore.DBModel.RoleAssignment", b =>
                {
                    b.HasOne("Ng2AspCore.DBModel.Employee", "Employee")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Ng2AspCore.DBModel.Project", "Project")
                        .WithMany("RoleAssignments")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
