using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Team_Todo_Management.Migrations
{
    public partial class TodoUserEntityAndSeedUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    CreatedAt = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Todo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Scope = table.Column<int>(nullable: false),
                    CreatorId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Todo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Todo_AspNetUsers_CreatorId",
                        column: x => x.CreatorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c2d4b743-d9da-443c-9f5a-c2682750c805", "47deb218-531d-470c-b893-e0036dbd159d", "Boss", "boss" },
                    { "b979036b-d165-4bea-b6b6-16b22a3f54dd", "c7935f9f-ba16-413e-9ef5-7366dbcd8335", "Staff", "staff" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98", 0, "9b12314a-38a0-497c-a9ab-10ed6820a55b", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPZIIcyKMhxOyWW3CjR7/VExX2tyUDV4ErQOYRgC5HjNoxqH0gZCnI/VZaTcRCJPBQ==", "0901234573", false, "", false, "lilsuperadmin@gmail.com" },
                    { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", 0, "84a87488-d173-4f08-85af-044c1a043f79", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEOZXqZWmtzrCqcOmszy2RG8n/6tB16jDiVFouuLklZWOLIdEXYTfc2yelBYRJ3uOZw==", "0901234576", false, "", false, "yungadmin@gmail.com" },
                    { "52999f6b-a605-45b0-b98f-b8880fc46027", 0, "26cf84a3-3fb7-4b6c-aee3-562e86c0e53f", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAECZMFmGO749//n9Ck9lczTcjytvYAqBu58ZaPlk+NN9D/gIE04Jqg0JiQ1GC6Cduxw==", "0901234581", false, "", false, "trankieuloan@gmail.com" },
                    { "39b465e2-c398-494f-bb62-d1eb02aa5471", 0, "5eec964a-830d-4360-80e7-960f49440306", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEA7diFSCIydO5rUcy7jApGYIotVzuaiP1nhEMchPlRv+zCs9/GSu1o+XT3i/qL5ZOw==", "0901234586", false, "", false, "phamvinhson@gmail.com" },
                    { "cc2a0eb3-8736-441d-9130-5b421db3ac0e", 0, "d0fdd8a2-fc6c-452d-82d0-e39bed03c0dc", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEOxwubLSevN1Im1nh5jrZpy+1DtJ/UNdOFACgnfjwBVV40NzT4TSYzUflhikigCxDg==", "0901234570", false, "", false, "caobaquat@gmail.com" },
                    { "423e498c-fc67-4853-ac4f-f3cd91d32e87", 0, "7eb4041f-3ea1-470b-b779-8b7c7dee9f48", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEEStpOGLkXHmQcuO5qBUvt6ugWQKsOzCIIoSu+R1qQsM/3jqlOn2+byGmVtr/Jg9fA==", "0901234571", false, "", false, "huynhtranthanh@gmail.com" },
                    { "78c5228f-f600-4545-abcd-f4cc21d18e4c", 0, "bd7c67f6-6aaa-4f81-9876-09394671c5d8", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEMORD09yMEAIk7rHFBbIsqVgkmxo2+TDmtHhSYs099J8A2QkNB6VYujoG1VUh3Yj4Q==", "0901234568", false, "", false, "nguyenthanhlong@gmail.com" },
                    { "6665ddaa-72f9-4f90-a6b1-43eb68dea610", 0, "08f1c6d0-885b-4ccf-a0da-a8b22e4efa52", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEDZVHdSRlDeqZOpPCwWbRcDN1rxnufKC9dv1MXQjsxdTMcZpCBLtnyRIB7yO/VpYfw==", "0901234583", false, "", false, "hoxuanhuong@gmail.com" },
                    { "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1", 0, "beaf7a8c-57ec-4a68-9ac4-e894f572dc3d", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAECqcVAqYKihXQMS4noBNyL8SId8vuEdqy9iPK3mtlXMo/5M8HUZAY5w4gkkdXrA2oQ==", "0901234564", false, "", false, "nguyenhue@gmail.com" },
                    { "308da0db-e863-4814-8930-de3540e5406d", 0, "b51ade27-e3ee-4448-9102-15d129b97897", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEMdi/V36Ih8wtDJWU+P13eTx9+szh9TAZBc+hX0nVDobGxmnsaXfaJFQYa4H4+twQQ==", "0901234572", false, "", false, "phungthanhdo@gmail.com" },
                    { "927e4f6a-62ed-4e13-b002-7e133eb47bbc", 0, "b1f6f2b5-3e2b-477c-9fd8-341de34497d9", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEC4yzjcavPhvURREr066gD/iNBW+uG7C57ZVXen+GZ8gKvyv03sywNxV0UOJYztpgw==", "0901234561", false, "", false, "phantantrung@gmail.com" },
                    { "e7610feb-110c-47d0-9a88-1bfdc12742a4", 0, "8e97c5ad-4ccd-45a6-8191-d86ac235cddd", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEIEwyUIZvUGfNg1G1nL4FVYq1+rCr1ECebRHD6+5HXAJKZ8onq46o8mXLrFVZfPJxg==", "0901234578", false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98", "c2d4b743-d9da-443c-9f5a-c2682750c805" },
                    { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", "c2d4b743-d9da-443c-9f5a-c2682750c805" },
                    { "52999f6b-a605-45b0-b98f-b8880fc46027", "c2d4b743-d9da-443c-9f5a-c2682750c805" },
                    { "39b465e2-c398-494f-bb62-d1eb02aa5471", "c2d4b743-d9da-443c-9f5a-c2682750c805" },
                    { "cc2a0eb3-8736-441d-9130-5b421db3ac0e", "b979036b-d165-4bea-b6b6-16b22a3f54dd" },
                    { "423e498c-fc67-4853-ac4f-f3cd91d32e87", "b979036b-d165-4bea-b6b6-16b22a3f54dd" },
                    { "78c5228f-f600-4545-abcd-f4cc21d18e4c", "b979036b-d165-4bea-b6b6-16b22a3f54dd" },
                    { "6665ddaa-72f9-4f90-a6b1-43eb68dea610", "b979036b-d165-4bea-b6b6-16b22a3f54dd" },
                    { "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1", "b979036b-d165-4bea-b6b6-16b22a3f54dd" },
                    { "308da0db-e863-4814-8930-de3540e5406d", "b979036b-d165-4bea-b6b6-16b22a3f54dd" },
                    { "927e4f6a-62ed-4e13-b002-7e133eb47bbc", "b979036b-d165-4bea-b6b6-16b22a3f54dd" },
                    { "e7610feb-110c-47d0-9a88-1bfdc12742a4", "b979036b-d165-4bea-b6b6-16b22a3f54dd" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Todo_CreatorId",
                table: "Todo",
                column: "CreatorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Todo");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
