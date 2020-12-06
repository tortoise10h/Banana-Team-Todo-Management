﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Team_Todo_Management.Data;

namespace Team_Todo_Management.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20201206102402_AddFieldDescription")]
    partial class AddFieldDescription
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "c2d4b743-d9da-443c-9f5a-c2682750c805",
                            ConcurrencyStamp = "144e5d39-c2ed-4fe4-b51c-3ef607d6c480",
                            Name = "Boss",
                            NormalizedName = "boss"
                        },
                        new
                        {
                            Id = "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                            ConcurrencyStamp = "f467c7eb-e2a7-46e1-9f39-8c3793042c1f",
                            Name = "Staff",
                            NormalizedName = "staff"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");

                    b.HasData(
                        new
                        {
                            UserId = "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                            RoleId = "c2d4b743-d9da-443c-9f5a-c2682750c805"
                        },
                        new
                        {
                            UserId = "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                            RoleId = "c2d4b743-d9da-443c-9f5a-c2682750c805"
                        },
                        new
                        {
                            UserId = "52999f6b-a605-45b0-b98f-b8880fc46027",
                            RoleId = "c2d4b743-d9da-443c-9f5a-c2682750c805"
                        },
                        new
                        {
                            UserId = "39b465e2-c398-494f-bb62-d1eb02aa5471",
                            RoleId = "c2d4b743-d9da-443c-9f5a-c2682750c805"
                        },
                        new
                        {
                            UserId = "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                            RoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd"
                        },
                        new
                        {
                            UserId = "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                            RoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd"
                        },
                        new
                        {
                            UserId = "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                            RoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd"
                        },
                        new
                        {
                            UserId = "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                            RoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd"
                        },
                        new
                        {
                            UserId = "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                            RoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd"
                        },
                        new
                        {
                            UserId = "308da0db-e863-4814-8930-de3540e5406d",
                            RoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd"
                        },
                        new
                        {
                            UserId = "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                            RoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd"
                        },
                        new
                        {
                            UserId = "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                            RoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Team_Todo_Management.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");

                    b.HasData(
                        new
                        {
                            Id = "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "824fcfef-5fae-4d77-9b49-cf0bcb50c8a6",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "lilsuperadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Super Admin",
                            LastName = "Lil",
                            LockoutEnabled = false,
                            NormalizedEmail = "LILSUPERADMIN@GMAIL.COM",
                            NormalizedUserName = "LILSUPERADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAnA7EMLjUrv0CDudJv3ABDlweprJxhnjqn5b1ZXobvuWMgdRG+rvpVOv4IKDSjVlA==",
                            PhoneNumber = "0901234573",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "lilsuperadmin@gmail.com"
                        },
                        new
                        {
                            Id = "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d9fd4770-5704-4da1-a6fd-355d8133a977",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "yungadmin@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Admin",
                            LastName = "Yung",
                            LockoutEnabled = false,
                            NormalizedEmail = "YUNGADMIN@GMAIL.COM",
                            NormalizedUserName = "YUNGADMIN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEALdaFiNu2nYqE+RHbNWFHOADyOObaqZbwDpcxlz0kesAl++8QfjDxObTdv542YuHQ==",
                            PhoneNumber = "0901234576",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "yungadmin@gmail.com"
                        },
                        new
                        {
                            Id = "52999f6b-a605-45b0-b98f-b8880fc46027",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "7cd52a91-0aed-4710-9a01-32d1e0a611bc",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "trankieuloan@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Loan",
                            LastName = "Trần Kiều",
                            LockoutEnabled = false,
                            NormalizedEmail = "TRANKIEULOAN@GMAIL.COM",
                            NormalizedUserName = "TRANKIEULOAN@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGKfxVWl9WlOs1DoBGxQRI0wxVSSZxi1A+xC5fH14xN3yAKVVYZJliboJdo542PQfA==",
                            PhoneNumber = "0901234581",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "trankieuloan@gmail.com"
                        },
                        new
                        {
                            Id = "39b465e2-c398-494f-bb62-d1eb02aa5471",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "f4e18f44-54a0-4f4a-9870-389bc348a1fa",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "phamvinhson@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Sơn",
                            LastName = "Phạm Vĩnh",
                            LockoutEnabled = false,
                            NormalizedEmail = "PHAMVINHSON@GMAIL.COM",
                            NormalizedUserName = "PHAMVINHSON@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAELt3RyPS+LLSpmnxV2StKKvZExxuVGeNeziKSsbX8MGGkn+JECm0l1HPWo481h9gFg==",
                            PhoneNumber = "0901234586",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "phamvinhson@gmail.com"
                        },
                        new
                        {
                            Id = "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "424c20fa-30d5-4c0a-8d24-519246c056b8",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "caobaquat@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Quát",
                            LastName = "Cao Bá",
                            LockoutEnabled = false,
                            NormalizedEmail = "CAOBAQUAT@GMAIL.COM",
                            NormalizedUserName = "CAOBAQUAT@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDQ+5HYBsmgp8FuXUsiBdKyMmYHcYEwXVCqSbMqn5AyFD9qW8CSjwa+S3tfg0IS8xA==",
                            PhoneNumber = "0901234570",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "caobaquat@gmail.com"
                        },
                        new
                        {
                            Id = "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0e993e41-17a8-43b5-8ebb-0dc5d05f258f",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "huynhtranthanh@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Thành",
                            LastName = "Huỳnh Trấn",
                            LockoutEnabled = false,
                            NormalizedEmail = "HUYNHTRANTHANH@GMAIL.COM",
                            NormalizedUserName = "HUYNHTRANTHANH@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEL7jRDL7lmkN5w5LdeLIy+qBJrr+Ze45AChkoLa6+7SRs7egDgiN0ihMfA3pyLNhBw==",
                            PhoneNumber = "0901234571",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "huynhtranthanh@gmail.com"
                        },
                        new
                        {
                            Id = "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "3bcda830-74ef-4ba3-bf25-d23ae69ca130",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nguyenthanhlong@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Long",
                            LastName = "Nguyễn Thành",
                            LockoutEnabled = false,
                            NormalizedEmail = "NGUYENTHANHLONG@GMAIL.COM",
                            NormalizedUserName = "NGUYENTHANHLONG@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAENON5dceDrbQiX7COVlNML00qN7nBqw5YWK94CpJegzKu1eEsUe4qBuMTCqoQn7VcQ==",
                            PhoneNumber = "0901234568",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "nguyenthanhlong@gmail.com"
                        },
                        new
                        {
                            Id = "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "d16c8856-89ad-48a7-8298-ef5fa88d3759",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "hoxuanhuong@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Hương",
                            LastName = "Hồ Xuân",
                            LockoutEnabled = false,
                            NormalizedEmail = "HOXUANHUONG@GMAIL.COM",
                            NormalizedUserName = "HOXUANHUONG@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEAjo+9QnMiMC3Aw0pkIXBS3shIfYMPrjPu1UP6jgdTcYeoD5IbC57UGRFM2jN6m1vg==",
                            PhoneNumber = "0901234583",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "hoxuanhuong@gmail.com"
                        },
                        new
                        {
                            Id = "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a6fea4fe-4e56-449a-b67c-b48234e40092",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "nguyenhue@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Huệ",
                            LastName = "Nguyễn",
                            LockoutEnabled = false,
                            NormalizedEmail = "NGUYENHUE@GMAIL.COM",
                            NormalizedUserName = "NGUYENHUE@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEGqkJPdOqNZuNsnIIWkybmuAeTykysP+y5XUZqgiWf3ymZW41M4stZvuMg1JttSqMA==",
                            PhoneNumber = "0901234564",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "nguyenhue@gmail.com"
                        },
                        new
                        {
                            Id = "308da0db-e863-4814-8930-de3540e5406d",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "1083030b-ca3c-4f2c-9fab-59c940ecc756",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "phungthanhdo@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Độ",
                            LastName = "Phùng Thanh",
                            LockoutEnabled = false,
                            NormalizedEmail = "PHUNGTHANHDO@GMAIL.COM",
                            NormalizedUserName = "PHUNGTHANHDO@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEOwbKuzq0RGSKKvI6vMb5AKV1WvG88Ugtc3TIUWxWNaP55OEkozdSlu6eBofBSZokw==",
                            PhoneNumber = "0901234572",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "phungthanhdo@gmail.com"
                        },
                        new
                        {
                            Id = "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "b3b7ea1f-968e-4d84-8395-f6017c684601",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "phantantrung@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Trung",
                            LastName = "Phan Tấn",
                            LockoutEnabled = false,
                            NormalizedEmail = "PHANTANTRUNG@GMAIL.COM",
                            NormalizedUserName = "PHANTANTRUNG@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEDbnKt8xw6zRUTlZhLlDUhSaScrV1hinV2UTBE9oH9/rKgl1LOEiuUfUCIO/vaU5hA==",
                            PhoneNumber = "0901234561",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "phantantrung@gmail.com"
                        },
                        new
                        {
                            Id = "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "0aed2e0e-99ed-4fdf-bfce-1f0bbd7ad4aa",
                            CreatedAt = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "truongtuantu@gmail.com",
                            EmailConfirmed = true,
                            FirstName = "Tú",
                            LastName = "Trương Tuấn",
                            LockoutEnabled = false,
                            NormalizedEmail = "TRUONGTUANTU@GMAIL.COM",
                            NormalizedUserName = "TRUONGTUANTU@GMAIL.COM",
                            PasswordHash = "AQAAAAEAACcQAAAAEHXNNOLYWBKgJTUUfZM+mVRZOpxE7nHqtk6hJKDjTfwYJNiZnmeawk5ads1SqLX6uQ==",
                            PhoneNumber = "0901234578",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "",
                            TwoFactorEnabled = false,
                            UserName = "truongtuantu@gmail.com"
                        });
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TodoId");

                    b.HasIndex("UserId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LogType")
                        .HasColumnType("int");

                    b.Property<string>("UserFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Media", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Filemime")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TodoId");

                    b.ToTable("Media");
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TodoId")
                        .HasColumnType("int");

                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("TodoId");

                    b.HasIndex("UserId");

                    b.ToTable("Participant");
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime>("LastModifiedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("LastModifiedById")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonInChargeId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Scope")
                        .HasColumnType("int");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonInChargeId");

                    b.ToTable("Todo");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Team_Todo_Management.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Team_Todo_Management.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team_Todo_Management.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Team_Todo_Management.Models.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Comment", b =>
                {
                    b.HasOne("Team_Todo_Management.Models.Todo", "Todo")
                        .WithMany("Comments")
                        .HasForeignKey("TodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team_Todo_Management.Models.ApplicationUser", "User")
                        .WithMany()
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Log", b =>
                {
                    b.HasOne("Team_Todo_Management.Models.ApplicationUser", "User")
                        .WithMany("Logs")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Media", b =>
                {
                    b.HasOne("Team_Todo_Management.Models.Todo", "Todo")
                        .WithMany("Medias")
                        .HasForeignKey("TodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Participant", b =>
                {
                    b.HasOne("Team_Todo_Management.Models.Todo", "Todo")
                        .WithMany("Participants")
                        .HasForeignKey("TodoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Team_Todo_Management.Models.ApplicationUser", "User")
                        .WithMany("Participants")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Team_Todo_Management.Models.Todo", b =>
                {
                    b.HasOne("Team_Todo_Management.Models.ApplicationUser", "PersonInCharge")
                        .WithMany("Todos")
                        .HasForeignKey("PersonInChargeId");
                });
#pragma warning restore 612, 618
        }
    }
}
