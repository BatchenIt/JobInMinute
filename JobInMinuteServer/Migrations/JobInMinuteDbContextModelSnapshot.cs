﻿// <auto-generated />
using System;
using JobInMinuteServer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JobInMinuteServer.Migrations
{
    [DbContext(typeof(JobInMinuteDbContext))]
    partial class JobInMinuteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.17")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("JobInMinuteServer.Models.Candidate", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Education")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Experience")
                        .HasColumnType("real");

                    b.Property<string>("Interests")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LinkedIn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Mobility")
                        .HasColumnType("bit");

                    b.Property<string>("Resume")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Candidats");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.CandidateJobs", b =>
                {
                    b.Property<int>("CandidateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateID"));

                    b.Property<int>("CandidateID1")
                        .HasColumnType("int");

                    b.HasKey("CandidateID");

                    b.HasIndex("CandidateID1");

                    b.ToTable("CandidateJobs");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.CandidatePreferedCities", b =>
                {
                    b.Property<int>("CandidateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CandidateID"));

                    b.Property<int>("CandidateID1")
                        .HasColumnType("int");

                    b.HasKey("CandidateID");

                    b.HasIndex("CandidateID1");

                    b.ToTable("CandidatePreferedCities");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.City", b =>
                {
                    b.Property<int>("CityCode")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityCode"));

                    b.Property<int?>("CandidatePreferedCitiesCandidateID")
                        .HasColumnType("int");

                    b.Property<string>("CityName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CityCode");

                    b.HasIndex("CandidatePreferedCitiesCandidateID");

                    b.ToTable("Cities");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.Employer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("BN_number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("UserId");

                    b.ToTable("Employers");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.Job", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CandidateJobsCandidateID")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("EmployerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("EndAt")
                        .HasColumnType("datetime2");

                    b.Property<float>("Salary")
                        .HasColumnType("real");

                    b.Property<DateTime>("StartAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("CandidateJobsCandidateID");

                    b.HasIndex("EmployerId");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.User", b =>
                {
                    b.Property<int>("ID")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isEmployer")
                        .HasColumnType("bit");

                    b.HasKey("ID");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.Candidate", b =>
                {
                    b.HasOne("JobInMinuteServer.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.CandidateJobs", b =>
                {
                    b.HasOne("JobInMinuteServer.Models.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.CandidatePreferedCities", b =>
                {
                    b.HasOne("JobInMinuteServer.Models.Candidate", "Candidate")
                        .WithMany()
                        .HasForeignKey("CandidateID1")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidate");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.City", b =>
                {
                    b.HasOne("JobInMinuteServer.Models.CandidatePreferedCities", null)
                        .WithMany("Cities")
                        .HasForeignKey("CandidatePreferedCitiesCandidateID");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.Employer", b =>
                {
                    b.HasOne("JobInMinuteServer.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.Job", b =>
                {
                    b.HasOne("JobInMinuteServer.Models.CandidateJobs", null)
                        .WithMany("Jobs")
                        .HasForeignKey("CandidateJobsCandidateID");

                    b.HasOne("JobInMinuteServer.Models.Employer", "Employer")
                        .WithMany()
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employer");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.CandidateJobs", b =>
                {
                    b.Navigation("Jobs");
                });

            modelBuilder.Entity("JobInMinuteServer.Models.CandidatePreferedCities", b =>
                {
                    b.Navigation("Cities");
                });
#pragma warning restore 612, 618
        }
    }
}
