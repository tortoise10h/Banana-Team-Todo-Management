using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_Todo_Management.Migrations
{
    public partial class EditFieldUserInTodoToPersonInCharge : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_AspNetUsers_CreatedById",
                table: "Todo");

            migrationBuilder.DropIndex(
                name: "IX_Todo_CreatedById",
                table: "Todo");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Todo",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PersonInChargeId",
                table: "Todo",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Todo_PersonInChargeId",
                table: "Todo",
                column: "PersonInChargeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_AspNetUsers_PersonInChargeId",
                table: "Todo",
                column: "PersonInChargeId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Todo_AspNetUsers_PersonInChargeId",
                table: "Todo");

            migrationBuilder.DropIndex(
                name: "IX_Todo_PersonInChargeId",
                table: "Todo");

            migrationBuilder.DropColumn(
                name: "PersonInChargeId",
                table: "Todo");

            migrationBuilder.AlterColumn<string>(
                name: "CreatedById",
                table: "Todo",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "d34e0c21-ae47-4939-82cc-e5978674f0a8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "762f7eb7-9363-48c5-84d8-b98c32ad4cba");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23e084ba-2a33-4a92-b44f-028d8925e0da", "AQAAAAEAACcQAAAAEC8vv+7m+b+tMz/sF/t9OYt0CZkONDdiODQoNomdrkfjyqS7JIJr1+ABMk/fbkIx9Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7cc0d1e-9813-4733-9b97-32323bc4ca1b", "AQAAAAEAACcQAAAAEDfBkYa8v/k5Wl5LyAF4t6YAjehPcYNHB1SQ5OeMJDpL74cRUcXuOvtQc9t6Uw5Mcw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fdfab85e-160b-48f4-b3b3-de195194cae5", "AQAAAAEAACcQAAAAEKiFmod83gZTmoI3xnC2diJHW0idDBm4wqtfzIjTRRxUG0gnqePvMOdSwgsfJCR0Zw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9516c9d-abd7-4fa6-9936-86aed2c5dcad", "AQAAAAEAACcQAAAAEKU6du2l5YPK7cb7nVD/uPbI8USuFg/AAUNwNq4eKeJ1YUhBhbHXmn3N/PjlLD8Vyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "48e061a4-c7b6-4dda-8cf5-980c0af601a5", "AQAAAAEAACcQAAAAEHAI6s3HXyzULc7UzIIDsqD2PnTVTkizu07d1b/SDUsdjznpVADCsdriBL57Ms+WYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b7dea1e-05cf-4a2f-999b-f1c33abca12e", "AQAAAAEAACcQAAAAEFe2rfOIACivnYLQRqI6DZNU4xGahvQaaMfsdZeOdxI7R6tx2ffrjw7rnlU4N4WkXg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2e3d2778-5fc8-4d6e-92f9-d3902d26e681", "AQAAAAEAACcQAAAAEEA7xE/XoZlKQL8Bagfl7dHdAPFrU+9Enoqi07cT9eR1Id4BTyER9na4oEKomeu9uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "86fa1925-578c-47e5-b358-513ee3fee5a1", "AQAAAAEAACcQAAAAEHeBmDKe4Y8QAlckvTNBvbJ0TQgkcFnlTReHeiRcqj7dd4n85P1WsNTUCnNdHh/PTg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "293f5287-bf40-437f-b7d9-b973faca8eac", "AQAAAAEAACcQAAAAEPXc5NLIluD7/5Vim8udQGylOafYeZTK+zr6GSY86uev3uhP4rubrXqZ3+3tHUozdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5b3b1f4-034b-4b18-a4dc-520592d617d8", "AQAAAAEAACcQAAAAEGvO+zRbfeSJqpaB3nzMHAdtHWCorr1ufZOPgv6/1JwFYfrB/0DZW7Mfimf1DrbnQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef6f75c2-4989-469a-83c0-feed58f037c8", "AQAAAAEAACcQAAAAEFnCBil7CxtJZTMY3wuTomEwrFrD3vgpTRnXFRpL5Jv6BzUxFjX8dYGPFfEwElqwYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fd0aa69c-511d-45b2-8b96-c1679c8fd06e", "AQAAAAEAACcQAAAAEBTTIuDw1Ko70SLW2oA0oVB5G+qvrqd5u08U5oR5x25CvDAwZu1IZtUd7XSJjINAwA==" });

            migrationBuilder.CreateIndex(
                name: "IX_Todo_CreatedById",
                table: "Todo",
                column: "CreatedById");

            migrationBuilder.AddForeignKey(
                name: "FK_Todo_AspNetUsers_CreatedById",
                table: "Todo",
                column: "CreatedById",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
