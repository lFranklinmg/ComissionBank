﻿// <auto-generated />
using ComissionBank.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComissionBank.Migrations
{
    [DbContext(typeof(ComissionBankContext))]
    [Migration("20201127205901_Advisor")]
    partial class Advisor
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ComissionBank.Models.Advisor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<double>("CMBC");

                    b.Property<string>("Email");

                    b.Property<double>("ITAZ");

                    b.Property<string>("Initials");

                    b.Property<double>("JURC");

                    b.Property<string>("Name");

                    b.Property<double>("Net");

                    b.Property<double>("NetBirthday");

                    b.Property<double>("NetCertification");

                    b.Property<double>("NetTotal");

                    b.Property<double>("PAN");

                    b.Property<double>("PROTC");

                    b.Property<string>("Password");

                    b.Property<double>("XPC");

                    b.HasKey("Id");

                    b.ToTable("Advisor");
                });
#pragma warning restore 612, 618
        }
    }
}