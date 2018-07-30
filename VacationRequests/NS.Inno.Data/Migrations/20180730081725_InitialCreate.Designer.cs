﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NS.Inno.Data;

namespace NS.Inno.Data.Migrations
{
    [DbContext(typeof(VacationRequestsContext))]
    [Migration("20180730081725_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NS.Inno.Models.ApprovingLevel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("ActionOn");

                    b.Property<int?>("CreatedById");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<int>("Level");

                    b.Property<string>("Status");

                    b.Property<int?>("VacationRequestId");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("VacationRequestId");

                    b.ToTable("ApprovingLevels");
                });

            modelBuilder.Entity("NS.Inno.Models.EmployeeOverlapPolicy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<int?>("User1Id");

                    b.Property<int?>("User2Id");

                    b.HasKey("Id");

                    b.HasIndex("User1Id");

                    b.HasIndex("User2Id");

                    b.ToTable("EmployeeOverlapPolicies");
                });

            modelBuilder.Entity("NS.Inno.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Teams");
                });

            modelBuilder.Entity("NS.Inno.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Active");

                    b.Property<string>("DisplayName");

                    b.Property<DateTime>("EmploymentDate");

                    b.Property<int>("Role");

                    b.Property<int?>("TeamId");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.HasIndex("TeamId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("NS.Inno.Models.VacationDays", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("DisplayName");

                    b.Property<int>("TotalDays");

                    b.Property<int?>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("VacationDayss");
                });

            modelBuilder.Entity("NS.Inno.Models.VacationRequest", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CreatedById");

                    b.Property<DateTime>("CreatedOn");

                    b.Property<DateTime>("DateFrom");

                    b.Property<DateTime>("DateTo");

                    b.Property<string>("Description");

                    b.Property<int?>("ModifiedById");

                    b.Property<DateTime>("ModifiedOn");

                    b.Property<int>("Status");

                    b.Property<int?>("UserId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("ModifiedById");

                    b.HasIndex("UserId");

                    b.ToTable("VacationRequests");
                });

            modelBuilder.Entity("NS.Inno.Models.ApprovingLevel", b =>
                {
                    b.HasOne("NS.Inno.Models.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("NS.Inno.Models.VacationRequest", "VacationRequest")
                        .WithMany()
                        .HasForeignKey("VacationRequestId");
                });

            modelBuilder.Entity("NS.Inno.Models.EmployeeOverlapPolicy", b =>
                {
                    b.HasOne("NS.Inno.Models.User", "User1")
                        .WithMany()
                        .HasForeignKey("User1Id");

                    b.HasOne("NS.Inno.Models.User", "User2")
                        .WithMany()
                        .HasForeignKey("User2Id");
                });

            modelBuilder.Entity("NS.Inno.Models.User", b =>
                {
                    b.HasOne("NS.Inno.Models.Team", "Team")
                        .WithMany("TeamLeaders")
                        .HasForeignKey("TeamId");
                });

            modelBuilder.Entity("NS.Inno.Models.VacationDays", b =>
                {
                    b.HasOne("NS.Inno.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("NS.Inno.Models.VacationRequest", b =>
                {
                    b.HasOne("NS.Inno.Models.User", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("NS.Inno.Models.User", "ModifiedBy")
                        .WithMany()
                        .HasForeignKey("ModifiedById");

                    b.HasOne("NS.Inno.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });
#pragma warning restore 612, 618
        }
    }
}