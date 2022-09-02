﻿// <auto-generated />
using LoanApp.dbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LoanApp.Migrations
{
    [DbContext(typeof(LoanAppDbContext))]
    [Migration("20220817095336_LoantoDb")]
    partial class LoantoDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LoanApp.Models.loans", b =>
                {
                    b.Property<int>("loanId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("interestRate")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("loanType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("loanId");

                    b.ToTable("Loans");
                });
#pragma warning restore 612, 618
        }
    }
}
