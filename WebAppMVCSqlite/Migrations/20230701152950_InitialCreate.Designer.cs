﻿// <auto-generated />
using System;
using LineList.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebAppMVCSqlite.Migrations
{
    [DbContext(typeof(LineListContext))]
    [Migration("20230701152950_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.8");

            modelBuilder.Entity("LineList.Models.DboAddress", b =>
                {
                    b.Property<long>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("AddressID");

                    b.Property<string>("City")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("FullAddress")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("Province")
                        .HasColumnType("NVARCHAR(1000)");

                    b.HasKey("AddressId");

                    b.ToTable("dbo.Address", (string)null);
                });

            modelBuilder.Entity("LineList.Models.DboHospital", b =>
                {
                    b.Property<long>("HospitalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("HospitalID");

                    b.Property<string>("InDate")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("Name")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("OutDate")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("PatientStatus")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("ReferralType")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("Section")
                        .HasColumnType("NVARCHAR(1000)");

                    b.HasKey("HospitalId");

                    b.ToTable("dbo.Hospital", (string)null);
                });

            modelBuilder.Entity("LineList.Models.DboLaboratory", b =>
                {
                    b.Property<long>("LabId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("LabID");

                    b.Property<long?>("AnswerDate")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LabName")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("SamplingDate")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<long?>("TestAnswer")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ToLabDate")
                        .HasColumnType("NVARCHAR(1000)");

                    b.HasKey("LabId");

                    b.ToTable("dbo.Laboratory", (string)null);
                });

            modelBuilder.Entity("LineList.Models.DboPatient", b =>
                {
                    b.Property<long>("PatientId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("PatientID");

                    b.Property<long?>("AddressId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("AddressID");

                    b.Property<string>("DateOfBirth")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("FatherName")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("FirstName")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("Gender")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<long?>("HospitalId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("HospitalID");

                    b.Property<string>("Job")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<long?>("LabId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("LabID");

                    b.Property<string>("LastName")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<string>("NationalCode")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<long?>("PatientStatusId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("PatientStatusID");

                    b.Property<long?>("VaccineId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("VaccineID");

                    b.HasKey("PatientId");

                    b.HasIndex("AddressId");

                    b.HasIndex("HospitalId");

                    b.HasIndex("LabId");

                    b.HasIndex("PatientStatusId");

                    b.HasIndex("VaccineId");

                    b.ToTable("dbo.Patient", (string)null);
                });

            modelBuilder.Entity("LineList.Models.DboPatientStatus", b =>
                {
                    b.Property<long>("PatientStatusId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("PatientStatusID");

                    b.Property<long?>("HistoryOfCovid")
                        .HasColumnType("INTEGER");

                    b.Property<long?>("IsPregnant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SymptomsDate")
                        .HasColumnType("NVARCHAR(1000)");

                    b.Property<long?>("UnderlyingDiseas")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UnderlyingDiseasName")
                        .HasColumnType("NVARCHAR(1000)");

                    b.HasKey("PatientStatusId");

                    b.ToTable("dbo.PatientStatus", (string)null);
                });

            modelBuilder.Entity("LineList.Models.DboSysdiagram", b =>
                {
                    b.Property<byte[]>("Definition")
                        .HasColumnType("BLOB")
                        .HasColumnName("definition");

                    b.Property<byte[]>("DiagramId")
                        .HasColumnType("BLOB")
                        .HasColumnName("diagram_id");

                    b.Property<byte[]>("Name")
                        .HasColumnType("BLOB")
                        .HasColumnName("name");

                    b.Property<byte[]>("PrincipalId")
                        .HasColumnType("BLOB")
                        .HasColumnName("principal_id");

                    b.Property<byte[]>("Version")
                        .HasColumnType("BLOB")
                        .HasColumnName("version");

                    b.ToTable("dbo.sysdiagrams", (string)null);
                });

            modelBuilder.Entity("LineList.Models.DboVaccine", b =>
                {
                    b.Property<long>("VaccineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("VaccineID");

                    b.Property<byte[]>("Check")
                        .HasColumnType("BOOLEAN");

                    b.Property<string>("Date")
                        .HasColumnType("NVARCHAR (1000)");

                    b.Property<string>("Time")
                        .HasColumnType("NVARCHAR (1000)");

                    b.Property<string>("Type")
                        .HasColumnType("NVARCHAR (1000)");

                    b.HasKey("VaccineId");

                    b.ToTable("dbo.Vaccine", (string)null);
                });

            modelBuilder.Entity("LineList.Models.DboPatient", b =>
                {
                    b.HasOne("LineList.Models.DboAddress", "Address")
                        .WithMany("DboPatients")
                        .HasForeignKey("AddressId");

                    b.HasOne("LineList.Models.DboHospital", "Hospital")
                        .WithMany("DboPatients")
                        .HasForeignKey("HospitalId");

                    b.HasOne("LineList.Models.DboLaboratory", "Lab")
                        .WithMany("DboPatients")
                        .HasForeignKey("LabId");

                    b.HasOne("LineList.Models.DboPatientStatus", "PatientStatus")
                        .WithMany("DboPatients")
                        .HasForeignKey("PatientStatusId");

                    b.HasOne("LineList.Models.DboVaccine", "Vaccine")
                        .WithMany("DboPatients")
                        .HasForeignKey("VaccineId");

                    b.Navigation("Address");

                    b.Navigation("Hospital");

                    b.Navigation("Lab");

                    b.Navigation("PatientStatus");

                    b.Navigation("Vaccine");
                });

            modelBuilder.Entity("LineList.Models.DboAddress", b =>
                {
                    b.Navigation("DboPatients");
                });

            modelBuilder.Entity("LineList.Models.DboHospital", b =>
                {
                    b.Navigation("DboPatients");
                });

            modelBuilder.Entity("LineList.Models.DboLaboratory", b =>
                {
                    b.Navigation("DboPatients");
                });

            modelBuilder.Entity("LineList.Models.DboPatientStatus", b =>
                {
                    b.Navigation("DboPatients");
                });

            modelBuilder.Entity("LineList.Models.DboVaccine", b =>
                {
                    b.Navigation("DboPatients");
                });
#pragma warning restore 612, 618
        }
    }
}
