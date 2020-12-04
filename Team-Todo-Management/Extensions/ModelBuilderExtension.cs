using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Team_Todo_Management.Models;

namespace Team_Todo_Management.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigDBTablesRelationship(this ModelBuilder modelBuilder)
        {
        }

        public static void ConfigTablesRequirements(this ModelBuilder modelBuilder)
        {
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            /*------------------------------------
             |                                   |
             |       SEED USERS AND ROLES        |
             |                                   |
             |-----------------------------------| */
            string bossRoleId = "c2d4b743-d9da-443c-9f5a-c2682750c805";
            string staffRoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd";

            string staffId1 = "cc2a0eb3-8736-441d-9130-5b421db3ac0e";
            string staffId2 = "423e498c-fc67-4853-ac4f-f3cd91d32e87";
            string staffId3 = "78c5228f-f600-4545-abcd-f4cc21d18e4c";
            string staffId4 = "6665ddaa-72f9-4f90-a6b1-43eb68dea610";
            string staffId5 = "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1";
            string staffId6 = "308da0db-e863-4814-8930-de3540e5406d";
            string staffId7 = "927e4f6a-62ed-4e13-b002-7e133eb47bbc";
            string staffId8 = "e7610feb-110c-47d0-9a88-1bfdc12742a4";

            string bossId1 = "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98";
            string bossId2 = "3b488e0f-eb92-4994-a555-cbe4ecdf3672";
            string bossId3 = "52999f6b-a605-45b0-b98f-b8880fc46027";
            string bossId4 = "39b465e2-c398-494f-bb62-d1eb02aa5471";

            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Id = bossRoleId,
                        Name = "Boss",
                        NormalizedName = "boss"
                    },
                    new IdentityRole
                    {
                        Id = staffRoleId,
                        Name = "Staff",
                        NormalizedName = "staff"
                    }
                );

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>()
                .HasData(
                    new ApplicationUser
                    {
                        Id = bossId1,
                        FirstName = "Super Admin",
                        LastName = "Lil",
                        UserName = "lilsuperadmin@gmail.com",
                        NormalizedUserName = "lilsuperadmin@gmail.com".ToUpper(),
                        Email = "lilsuperadmin@gmail.com",
                        NormalizedEmail = "lilsuperadmin@gmail.com".ToUpper(),
                        PhoneNumber = "0901234573",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = bossId2,
                        FirstName = "Admin",
                        LastName = "Yung",
                        UserName = "yungadmin@gmail.com",
                        NormalizedUserName = "yungadmin@gmail.com".ToUpper(),
                        Email = "yungadmin@gmail.com",
                        NormalizedEmail = "yungadmin@gmail.com".ToUpper(),
                        PhoneNumber = "0901234576",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = bossId3,
                        FirstName = "Loan",
                        LastName = "Trần Kiều",
                        UserName = "trankieuloan@gmail.com",
                        NormalizedUserName = "trankieuloan@gmail.com".ToUpper(),
                        Email = "trankieuloan@gmail.com",
                        NormalizedEmail = "trankieuloan@gmail.com".ToUpper(),
                        PhoneNumber = "0901234581",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = bossId4,
                        FirstName = "Sơn",
                        LastName = "Phạm Vĩnh",
                        UserName = "phamvinhson@gmail.com",
                        NormalizedUserName = "phamvinhson@gmail.com".ToUpper(),
                        Email = "phamvinhson@gmail.com",
                        NormalizedEmail = "phamvinhson@gmail.com".ToUpper(),
                        PhoneNumber = "0901234586",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = staffId1,
                        FirstName = "Quát",
                        LastName = "Cao Bá",
                        UserName = "caobaquat@gmail.com",
                        NormalizedUserName = "caobaquat@gmail.com".ToUpper(),
                        Email = "caobaquat@gmail.com",
                        NormalizedEmail = "caobaquat@gmail.com".ToUpper(),
                        PhoneNumber = "0901234570",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = staffId2,
                        FirstName = "Thành",
                        LastName = "Huỳnh Trấn",
                        UserName = "huynhtranthanh@gmail.com",
                        NormalizedUserName = "huynhtranthanh@gmail.com".ToUpper(),
                        Email = "huynhtranthanh@gmail.com",
                        NormalizedEmail = "huynhtranthanh@gmail.com".ToUpper(),
                        PhoneNumber = "0901234571",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = staffId3,
                        FirstName = "Long",
                        LastName = "Nguyễn Thành",
                        UserName = "nguyenthanhlong@gmail.com",
                        NormalizedUserName = "nguyenthanhlong@gmail.com".ToUpper(),
                        Email = "nguyenthanhlong@gmail.com",
                        NormalizedEmail = "nguyenthanhlong@gmail.com".ToUpper(),
                        PhoneNumber = "0901234568",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = staffId4,
                        FirstName = "Hương",
                        LastName = "Hồ Xuân",
                        UserName = "hoxuanhuong@gmail.com",
                        NormalizedUserName = "hoxuanhuong@gmail.com".ToUpper(),
                        Email = "hoxuanhuong@gmail.com",
                        NormalizedEmail = "hoxuanhuong@gmail.com".ToUpper(),
                        PhoneNumber = "0901234583",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = staffId5,
                        FirstName = "Huệ",
                        LastName = "Nguyễn",
                        UserName = "nguyenhue@gmail.com",
                        NormalizedUserName = "nguyenhue@gmail.com".ToUpper(),
                        Email = "nguyenhue@gmail.com",
                        NormalizedEmail = "nguyenhue@gmail.com".ToUpper(),
                        PhoneNumber = "0901234564",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = staffId6,
                        FirstName = "Độ",
                        LastName = "Phùng Thanh",
                        UserName = "phungthanhdo@gmail.com",
                        NormalizedUserName = "phungthanhdo@gmail.com".ToUpper(),
                        Email = "phungthanhdo@gmail.com",
                        NormalizedEmail = "phungthanhdo@gmail.com".ToUpper(),
                        PhoneNumber = "0901234572",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = staffId7,
                        FirstName = "Trung",
                        LastName = "Phan Tấn",
                        UserName = "phantantrung@gmail.com",
                        NormalizedUserName = "phantantrung@gmail.com".ToUpper(),
                        Email = "phantantrung@gmail.com",
                        NormalizedEmail = "phantantrung@gmail.com".ToUpper(),
                        PhoneNumber = "0901234561",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = staffId8,
                        FirstName = "Tú",
                        LastName = "Trương Tuấn",
                        UserName = "truongtuantu@gmail.com",
                        NormalizedUserName = "truongtuantu@gmail.com".ToUpper(),
                        Email = "truongtuantu@gmail.com",
                        NormalizedEmail = "truongtuantu@gmail.com".ToUpper(),
                        PhoneNumber = "0901234578",
                        CreatedAt = new DateTime(2020, 1, 1),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    }
                );

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = bossRoleId,
                        UserId = bossId1
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = bossRoleId,
                        UserId = bossId2
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = bossRoleId,
                        UserId = bossId3
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = bossRoleId,
                        UserId = bossId4
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = staffRoleId,
                        UserId = staffId1
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = staffRoleId,
                        UserId = staffId2
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = staffRoleId,
                        UserId = staffId3
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = staffRoleId,
                        UserId = staffId4
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = staffRoleId,
                        UserId = staffId5
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = staffRoleId,
                        UserId = staffId6
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = staffRoleId,
                        UserId = staffId7
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = staffRoleId,
                        UserId = staffId8
                    }
                );
        }
    }
}
