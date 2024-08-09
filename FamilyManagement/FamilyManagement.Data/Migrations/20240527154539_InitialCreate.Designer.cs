﻿// <auto-generated />
using System;
using FamilyManagement.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FamilyManagement.Data.Migrations
{
    [DbContext(typeof(FamilyManagementDbContext))]
    [Migration("20240527154539_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FamilyManagement.Data.Entities.Calendar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Calendars");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.CalendarToFamily", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.HasIndex("FamilyId");

                    b.ToTable("CalendarToFamilies");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.CalendarToUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.HasIndex("UserId");

                    b.ToTable("CalendarToUsers");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.Event", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CalendarId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("EndTime")
                        .HasColumnType("time");

                    b.Property<bool>("IsAFullDayEvent")
                        .HasColumnType("bit");

                    b.Property<int>("IsRepeatEvent")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<TimeSpan>("StartTime")
                        .HasColumnType("time");

                    b.Property<int>("ThemeColor")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CalendarId");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.Family", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Families");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.Task", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AssigneeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Deadline")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ToDoListId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AssigneeId");

                    b.HasIndex("OwnerId");

                    b.HasIndex("ToDoListId");

                    b.ToTable("Tasks");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.ToDoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("ToDoLists");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FamilyRole")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.UserToFamily", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.HasIndex("UserId");

                    b.ToTable("UserToFamilies");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.UserToToDoList", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ToDoListId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ToDoListId");

                    b.HasIndex("UserId");

                    b.ToTable("UserToToDoLists");
                });

            modelBuilder.Entity("FamilyManagement.Models.Entities.JwtToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("JwtTokens");
                });

            modelBuilder.Entity("FamilyManagement.Models.Entities.RefreshToken", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CreatedBy")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Token")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CreatedBy");

                    b.ToTable("RefreshTokens");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.CalendarToFamily", b =>
                {
                    b.HasOne("FamilyManagement.Data.Entities.Calendar", "Calendar")
                        .WithMany("CalendarToFamilies")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyManagement.Data.Entities.Family", "Family")
                        .WithMany("CalendarToFamilies")
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calendar");

                    b.Navigation("Family");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.CalendarToUser", b =>
                {
                    b.HasOne("FamilyManagement.Data.Entities.Calendar", "Calendar")
                        .WithMany("CalendarToUsers")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyManagement.Data.Entities.User", "User")
                        .WithMany("CalendarToUsers")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calendar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.Event", b =>
                {
                    b.HasOne("FamilyManagement.Data.Entities.Calendar", "Calendar")
                        .WithMany("Events")
                        .HasForeignKey("CalendarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Calendar");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.Task", b =>
                {
                    b.HasOne("FamilyManagement.Data.Entities.User", "Assignee")
                        .WithMany("Tasks")
                        .HasForeignKey("AssigneeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyManagement.Data.Entities.User", "Owner")
                        .WithMany()
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.ClientNoAction)
                        .IsRequired();

                    b.HasOne("FamilyManagement.Data.Entities.ToDoList", "ToDoList")
                        .WithMany("Tasks")
                        .HasForeignKey("ToDoListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Assignee");

                    b.Navigation("Owner");

                    b.Navigation("ToDoList");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.UserToFamily", b =>
                {
                    b.HasOne("FamilyManagement.Data.Entities.Family", "Family")
                        .WithMany()
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyManagement.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Family");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.UserToToDoList", b =>
                {
                    b.HasOne("FamilyManagement.Data.Entities.ToDoList", "ToDoList")
                        .WithMany("UserToToDoLists")
                        .HasForeignKey("ToDoListId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FamilyManagement.Data.Entities.User", "User")
                        .WithMany("UserToToDoLists")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ToDoList");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FamilyManagement.Models.Entities.JwtToken", b =>
                {
                    b.HasOne("FamilyManagement.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FamilyManagement.Models.Entities.RefreshToken", b =>
                {
                    b.HasOne("FamilyManagement.Data.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("CreatedBy")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.Calendar", b =>
                {
                    b.Navigation("CalendarToFamilies");

                    b.Navigation("CalendarToUsers");

                    b.Navigation("Events");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.Family", b =>
                {
                    b.Navigation("CalendarToFamilies");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.ToDoList", b =>
                {
                    b.Navigation("Tasks");

                    b.Navigation("UserToToDoLists");
                });

            modelBuilder.Entity("FamilyManagement.Data.Entities.User", b =>
                {
                    b.Navigation("CalendarToUsers");

                    b.Navigation("Tasks");

                    b.Navigation("UserToToDoLists");
                });
#pragma warning restore 612, 618
        }
    }
}
