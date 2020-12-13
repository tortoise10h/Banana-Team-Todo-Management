using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_Todo_Management.Migrations
{
    public partial class AddAdminRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", "c2d4b743-d9da-443c-9f5a-c2682750c805" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98", "c2d4b743-d9da-443c-9f5a-c2682750c805" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "03a203d7-52e4-40c3-8fc0-b960aa9530d8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "65241def-363d-4f11-92a0-1c9fdff5603b");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "04df88e4-3cee-11eb-adc1-0242ac120002", "05598827-9ab9-4ae4-9f47-48886f839ae2", "Admin", "admin" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3d79bea7-445e-4cc3-920f-6e4ae53d0369", "AQAAAAEAACcQAAAAEPoH0xGLo4iruAquWAPOucGHMZwfc8uFDBQrMyXliRNBFuPYFUdJZF7IgijXwQ+H5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdcf2a3f-fb2b-4a3f-8a5b-0fef90632705", "AQAAAAEAACcQAAAAEKjnA3oaYkrmmXP9JVcbuRn+ovP1Fw2GK+hCNCeOJILMZv427Wl0Sg4sWqDKa2ZzIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f2859ae-a59f-4f76-b039-2fc715720753", "AQAAAAEAACcQAAAAEBK9vwRxwbzgrMb35Qio/8n/LGJUgyqbvOlY+n0TEPA22nFRckI4bqW7JBS5ndSrDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6489618c-a540-456b-a17c-05336b7f13b4", "AQAAAAEAACcQAAAAEJvokB5brLMsvhTXWUEb7WUiSjn4avol+rE2FCvL6fVs8RW+KeG9kdFWUra1jsyA3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e95f535d-9f4b-43a0-ac58-3ca97aa13232", "AQAAAAEAACcQAAAAEJdTrW0mKU4jume2AOYJ8p/Ph7Pr8jtkBCjrmpt57KMTlsMazSBRBZCxIQetOtDL+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27ea8787-c538-4e9c-a809-c24e193a9f29", "AQAAAAEAACcQAAAAEKSgi62f1BI+uKpVCv6LFWsnZD4Vs9yCH+CX1rPvJ71hswiK4mbP/NXVAlZJMRSamw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af1c0b2f-2929-4694-b744-33a9559b9533", "AQAAAAEAACcQAAAAEC0WpjdXVGt4Ec52ihsK91Gv6t7kaEkBwGq1ARz2I1bfZr+bir6cJ7x3w+ADIqkB5Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e77d0363-5155-446b-ad0a-9180c6eea5a0", "AQAAAAEAACcQAAAAEHEPHGQ49gH1SQPHV3EyfWo6DdALbi+Gjvy+3JWOrD6TMd3QquQaloOQdLkeb9LPcA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "abcfb120-131b-49a7-8366-a99e6994cbcd", "AQAAAAEAACcQAAAAEFrgl90iffjLrFZTpQBtKQPfDeO5JVs9w1sVp3yXoLlvAHXKdtXYbzMUfWs6PDnFhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1782009f-05db-4dd0-9a6f-8258a2a46017", "AQAAAAEAACcQAAAAEHKRwaWZ1MkUEJOxAcLIwdYZUjv1hJNlfNVLUkppR1RdYpUdyyVO8fkcrePjmcPNqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7f53d9b-7994-4054-80d1-da0809ceb772", "AQAAAAEAACcQAAAAECATtxH0CvaHaLKP0dPeVTWE+NVt6hjluhntl7XBMMVDnJida/fy/BQg7tBfS+qtzg==" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", "04df88e4-3cee-11eb-adc1-0242ac120002" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", "04df88e4-3cee-11eb-adc1-0242ac120002" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "04df88e4-3cee-11eb-adc1-0242ac120002");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "f467c7eb-e2a7-46e1-9f39-8c3793042c1f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "144e5d39-c2ed-4fe4-b51c-3ef607d6c480");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", "c2d4b743-d9da-443c-9f5a-c2682750c805" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1083030b-ca3c-4f2c-9fab-59c940ecc756", "AQAAAAEAACcQAAAAEOwbKuzq0RGSKKvI6vMb5AKV1WvG88Ugtc3TIUWxWNaP55OEkozdSlu6eBofBSZokw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f4e18f44-54a0-4f4a-9870-389bc348a1fa", "AQAAAAEAACcQAAAAELt3RyPS+LLSpmnxV2StKKvZExxuVGeNeziKSsbX8MGGkn+JECm0l1HPWo481h9gFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9fd4770-5704-4da1-a6fd-355d8133a977", "AQAAAAEAACcQAAAAEALdaFiNu2nYqE+RHbNWFHOADyOObaqZbwDpcxlz0kesAl++8QfjDxObTdv542YuHQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0e993e41-17a8-43b5-8ebb-0dc5d05f258f", "AQAAAAEAACcQAAAAEL7jRDL7lmkN5w5LdeLIy+qBJrr+Ze45AChkoLa6+7SRs7egDgiN0ihMfA3pyLNhBw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7cd52a91-0aed-4710-9a01-32d1e0a611bc", "AQAAAAEAACcQAAAAEGKfxVWl9WlOs1DoBGxQRI0wxVSSZxi1A+xC5fH14xN3yAKVVYZJliboJdo542PQfA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d16c8856-89ad-48a7-8298-ef5fa88d3759", "AQAAAAEAACcQAAAAEAjo+9QnMiMC3Aw0pkIXBS3shIfYMPrjPu1UP6jgdTcYeoD5IbC57UGRFM2jN6m1vg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6fea4fe-4e56-449a-b67c-b48234e40092", "AQAAAAEAACcQAAAAEGqkJPdOqNZuNsnIIWkybmuAeTykysP+y5XUZqgiWf3ymZW41M4stZvuMg1JttSqMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3bcda830-74ef-4ba3-bf25-d23ae69ca130", "AQAAAAEAACcQAAAAENON5dceDrbQiX7COVlNML00qN7nBqw5YWK94CpJegzKu1eEsUe4qBuMTCqoQn7VcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b3b7ea1f-968e-4d84-8395-f6017c684601", "AQAAAAEAACcQAAAAEDbnKt8xw6zRUTlZhLlDUhSaScrV1hinV2UTBE9oH9/rKgl1LOEiuUfUCIO/vaU5hA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "424c20fa-30d5-4c0a-8d24-519246c056b8", "AQAAAAEAACcQAAAAEDQ+5HYBsmgp8FuXUsiBdKyMmYHcYEwXVCqSbMqn5AyFD9qW8CSjwa+S3tfg0IS8xA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0aed2e0e-99ed-4fdf-bfce-1f0bbd7ad4aa", "AQAAAAEAACcQAAAAEHXNNOLYWBKgJTUUfZM+mVRZOpxE7nHqtk6hJKDjTfwYJNiZnmeawk5ads1SqLX6uQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98", 0, "824fcfef-5fae-4d77-9b49-cf0bcb50c8a6", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAnA7EMLjUrv0CDudJv3ABDlweprJxhnjqn5b1ZXobvuWMgdRG+rvpVOv4IKDSjVlA==", "0901234573", false, "", false, "lilsuperadmin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98", "c2d4b743-d9da-443c-9f5a-c2682750c805" });
        }
    }
}
