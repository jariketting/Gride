﻿// <auto-generated />
using System;
using Gride.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Gride.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Gride.Models.Availability", b =>
                {
                    b.Property<long>("EmployeeID");

                    b.Property<DateTime>("End");

                    b.Property<bool>("Prefered");

                    b.Property<DateTime>("Start");

                    b.HasKey("EmployeeID");

                    b.ToTable("Availability");
                });

            modelBuilder.Entity("Gride.Models.Binds.ShiftAndFunctionBind", b =>
                {
                    b.Property<decimal>("ShiftID")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<int>("FunctionID");

                    b.Property<decimal?>("ShiftID1")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<byte>("maxEmployees");

                    b.HasKey("ShiftID", "FunctionID");

                    b.HasAlternateKey("FunctionID", "ShiftID");

                    b.HasIndex("FunctionID")
                        .IsUnique();

                    b.HasIndex("ShiftID")
                        .IsUnique();

                    b.HasIndex("ShiftID1");

                    b.ToTable("shiftAndFunctionBind");
                });

            modelBuilder.Entity("Gride.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeID")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Admin");

                    b.Property<DateTime>("DoB");

                    b.Property<string>("EMail")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<float>("Experience");

                    b.Property<int>("Gender");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal>("LoginID")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(12);

                    b.Property<string>("ProfileImage");

                    b.HasKey("EmployeeID");

                    b.ToTable("Employee");
                });

            modelBuilder.Entity("Gride.Models.Function", b =>
                {
                    b.Property<int>("FunctionID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("EmployeeID");

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.HasKey("FunctionID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Function");
                });

            modelBuilder.Entity("Gride.Models.Location", b =>
                {
                    b.Property<int>("LocationID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Additions");

                    b.Property<string>("City");

                    b.Property<string>("Country");

                    b.Property<long?>("EmployeeID");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<string>("Postalcode");

                    b.Property<string>("Street")
                        .HasMaxLength(100);

                    b.Property<int>("StreetNumber");

                    b.HasKey("LocationID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("Location");
                });

            modelBuilder.Entity("Gride.Models.Message", b =>
                {
                    b.Property<decimal>("MessageID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<long>("EmployeeID");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<DateTime>("Time");

                    b.HasKey("MessageID");

                    b.HasAlternateKey("EmployeeID");

                    b.HasAlternateKey("EmployeeID", "MessageID");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("Gride.Models.Shift", b =>
                {
                    b.Property<decimal>("ShiftID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<DateTime>("End");

                    b.Property<int>("LocationID");

                    b.Property<DateTime>("Start");

                    b.HasKey("ShiftID");

                    b.HasAlternateKey("LocationID");

                    b.HasAlternateKey("LocationID", "ShiftID");

                    b.ToTable("Shift");
                });

            modelBuilder.Entity("Gride.Models.Skill", b =>
                {
                    b.Property<int>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("EmployeeID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<decimal?>("ShiftID")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("SkillID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("ShiftID");

                    b.ToTable("Skill");
                });

            modelBuilder.Entity("Gride.Models.Work", b =>
                {
                    b.Property<decimal>("WorkID")
                        .ValueGeneratedOnAdd()
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.Property<int>("Difference");

                    b.Property<long>("EmployeeID");

                    b.Property<decimal>("ShiftID")
                        .HasConversion(new ValueConverter<decimal, decimal>(v => default(decimal), v => default(decimal), new ConverterMappingHints(precision: 20, scale: 0)));

                    b.HasKey("WorkID");

                    b.HasAlternateKey("ShiftID", "EmployeeID");

                    b.HasAlternateKey("EmployeeID", "ShiftID", "WorkID");

                    b.HasIndex("EmployeeID")
                        .IsUnique();

                    b.ToTable("Work");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Gride.Models.Availability", b =>
                {
                    b.HasOne("Gride.Models.Employee", "Employee")
                        .WithOne()
                        .HasForeignKey("Gride.Models.Availability", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.Binds.ShiftAndFunctionBind", b =>
                {
                    b.HasOne("Gride.Models.Function", "Function")
                        .WithOne()
                        .HasForeignKey("Gride.Models.Binds.ShiftAndFunctionBind", "FunctionID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Shift", "Shift")
                        .WithOne()
                        .HasForeignKey("Gride.Models.Binds.ShiftAndFunctionBind", "ShiftID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Shift")
                        .WithMany("Functions")
                        .HasForeignKey("ShiftID1");
                });

            modelBuilder.Entity("Gride.Models.Function", b =>
                {
                    b.HasOne("Gride.Models.Employee")
                        .WithMany("Functions")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("Gride.Models.Location", b =>
                {
                    b.HasOne("Gride.Models.Employee")
                        .WithMany("Locations")
                        .HasForeignKey("EmployeeID");
                });

            modelBuilder.Entity("Gride.Models.Message", b =>
                {
                    b.HasOne("Gride.Models.Employee", "Employee")
                        .WithOne()
                        .HasForeignKey("Gride.Models.Message", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.Shift", b =>
                {
                    b.HasOne("Gride.Models.Location", "Location")
                        .WithOne()
                        .HasForeignKey("Gride.Models.Shift", "LocationID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Gride.Models.Skill", b =>
                {
                    b.HasOne("Gride.Models.Employee")
                        .WithMany("Skills")
                        .HasForeignKey("EmployeeID");

                    b.HasOne("Gride.Models.Shift")
                        .WithMany("Skills")
                        .HasForeignKey("ShiftID");
                });

            modelBuilder.Entity("Gride.Models.Work", b =>
                {
                    b.HasOne("Gride.Models.Employee", "Employee")
                        .WithOne()
                        .HasForeignKey("Gride.Models.Work", "EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Gride.Models.Shift", "Shift")
                        .WithOne()
                        .HasForeignKey("Gride.Models.Work", "WorkID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
