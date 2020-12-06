using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_Todo_Management.Migrations
{
    public partial class AddFieldDescription : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Todo",
                nullable: true);

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

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "824fcfef-5fae-4d77-9b49-cf0bcb50c8a6", "AQAAAAEAACcQAAAAEAnA7EMLjUrv0CDudJv3ABDlweprJxhnjqn5b1ZXobvuWMgdRG+rvpVOv4IKDSjVlA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Todo");

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
    }
}
