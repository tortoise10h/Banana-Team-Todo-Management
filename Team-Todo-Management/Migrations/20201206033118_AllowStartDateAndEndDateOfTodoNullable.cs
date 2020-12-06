using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_Todo_Management.Migrations
{
    public partial class AllowStartDateAndEndDateOfTodoNullable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Todo",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Todo",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "6e314d07-f525-4e68-bbbc-364f2738d590");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "37278a68-eccc-4c55-a817-fa8facf5212b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c71d56f6-9ec9-4d1f-be94-6b3ae17446bf", "AQAAAAEAACcQAAAAEAl0I7f1ccIeUGBlpb9zCK1MgxjNGFgthEsg5ZtLGvGBhp5x/WinE5MeL/eq6dgR/A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f075f851-36c1-415b-b931-b6bc9b2183d8", "AQAAAAEAACcQAAAAEBKBy4YooS/nnEObobrUW2buXDu2Kjj3dzUGs5vQGLGUvupLU0YeTOOg5ykQUWRlQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "db7bbacf-3d91-4c6b-b0ca-e8e2be6f198a", "AQAAAAEAACcQAAAAEGI/lfRjQ0qvApaeKAaZqb3JIEfPQc+4/5p1cEELOFWKb3ktRA251QXOHJX4YoBRyA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "17566af0-914c-4b52-b59d-319d248100c1", "AQAAAAEAACcQAAAAEDr7SikDidbYwMJYG3vecr6KjYbVigPHkjiFi9rWzJBX0f/vxcLtMINLHVVViwMbYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c30fccbf-6f05-40a7-9995-287a923154e7", "AQAAAAEAACcQAAAAEGeo3ZwJ8wvz2W1UdD8a/QKdTZ7FrruJxNulMDD1o6WJl0V3Fr3UVMIWDWZusADBGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "972e7006-217d-41a6-a4c2-9285e8db253e", "AQAAAAEAACcQAAAAENM49u9Pt4ALttX4O+1/Zrj6sYuyHUJPZuqYBDx+J1DfI0iALVdEBH6FC9q22f4/bQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c8a8543c-2a2d-4395-9a13-417227c52ce0", "AQAAAAEAACcQAAAAEJ78RXzHhz5VtyHzeVzu0bLDqOZpw6q3hFtxWeOXmhOgAFBLofz43ZL0OAUNWkZNFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74a8915f-e1b1-4ea2-be0a-1a2c11d0630f", "AQAAAAEAACcQAAAAEGqCQGCeHeA80uY/NBUnr3KILJ0O1KZlUSWAajB5XsPpifcKKttfINVG58dEGPjJzg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57075d87-7a3f-44ef-b05b-bc3c0993fe9c", "AQAAAAEAACcQAAAAEAoi/L14ZZPl+6ZW92ZCUemZ9SH4nWgbYiFHdqKz5oFTU4HIAhs52jRphRUThLvsdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "72527f32-7330-4cc2-9841-12deefab222d", "AQAAAAEAACcQAAAAEFP9nOBwdNrF8P5/g4Kj/VCQ3HT5Ax6tQ+TF4MNInC/Pk4ql+Go5nl4Gnggyv8h+Bg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f633316-ec98-499a-b481-5521e4631b73", "AQAAAAEAACcQAAAAEFbhcDRNZExSmCCgtssGY9xqVfxam84jyhgWNBD7yQ8Xe8PFEAKtlwMlqJLY5XywAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "110391da-0c82-44db-842d-b15002ccd996", "AQAAAAEAACcQAAAAEAP9mDt0Df4ivMvMHvnD+cAtkNQt8UUmo+WetzK+e01t7Q9MY+ccn1QJUsWYhQwaMw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartDate",
                table: "Todo",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndDate",
                table: "Todo",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "a0e1284c-2c06-4975-9a2e-29cfd6e8a299");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "e9ac3cbc-d9f5-47c5-b978-567ec5ce6b4a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6f2f1671-4998-40bd-bb06-1cfb5542ed38", "AQAAAAEAACcQAAAAEK60oCT/wTWKvOslhKqHMXbjjy3QqdcPWj1TRc7K08kGjyv0zv/4LotruYlb5IDdJA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b7c76f4-7930-4d0e-bc7e-baa6a0d61676", "AQAAAAEAACcQAAAAEIRMtTKLlBDi4+VrQGeqdmyvWeT3Q07pRwPE52uCCNHdAO7/mo0S6wqsehqpS6f9CQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "79d4d34f-dfca-4910-9cc7-c6caace523ac", "AQAAAAEAACcQAAAAEIVfS2lilF056pSZS971q850vTkCmuS13wWvuKFidTtH2z5g0IyqpbDyJ6UC9FXPtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc23c471-ab7f-4ac3-a022-4f31dad9ee90", "AQAAAAEAACcQAAAAEHNq1eJJ324mOBz0p5x704MQMjiAd+aK8sxPGqTb5PEympMEsnC2cKHWx1DzB1ThaQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "78b3706b-bacf-4198-bbaf-f4c91b6aafce", "AQAAAAEAACcQAAAAEK9/VvTwzQfaYFg1CVya+dAEoAxAWDQkoCVdEm6QmwuIAnwe9IfhctbjAGUwoNQwUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0aaf97c-c842-44e4-9aa0-0d3e8bc349c2", "AQAAAAEAACcQAAAAEFTNOo1b+pOEo4+vQ8osyZyRTdPqrdXofQR99HZDwaEA62O7hbyuDPhHp9Qu0EUUeA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "694ac60a-833b-4d98-b41e-b8112bd65640", "AQAAAAEAACcQAAAAEPqee71bunHqzeRrvOxmfSQVZetcRp/3Qwi0Ew6SyxZ1feRkqn0PvtfYG1wI7LQ8HA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7f1c928-599c-4f4f-9fcd-4c5af62e5894", "AQAAAAEAACcQAAAAEMFm/j/Ta0VAmyohTFRf5rMjec0A+U5UGjMD12Nh0TxIamNtlpIo25SHGY2yqyjLkw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1870a2d8-3272-4e3c-9551-d8bf7a0b6c35", "AQAAAAEAACcQAAAAEOf7wlRE0pUj3fxxi9g8ezbvg9bZbmddjQNxouA7P9oYe/whhyiVMDVCuOJNVGrvQQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "62d7d2bc-2e58-427d-96e2-f6f53d273a5b", "AQAAAAEAACcQAAAAELzAvNMC5H4KdSNw7YtDfO0CBTr00uwSTHuwo7Z0w/xpMUyI4FcrpH7JlayqQ0Iz8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3628d307-08ea-4b70-bf2d-1ae494598b99", "AQAAAAEAACcQAAAAEDo58cWCmyYdF6ezFPm4ztRwGYo0NCqhrSxlJGHLoLGwoipQKNdgk5M0pKrQsAkUkA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b79f4ae-b775-4fb0-9867-d247136d2aad", "AQAAAAEAACcQAAAAEDp/3w2+59b8BR0hDAQNZ4VkvhTBygXK2gRHjetJ2SxLPzJPd4GHmbDCzZ68m0t35g==" });
        }
    }
}
