using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    IsRoot = table.Column<bool>(type: "boolean", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUser",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Pin = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false),
                    LastName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    FirstName = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Patronymic = table.Column<string>(type: "text", nullable: true),
                    AssignmentDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    FairDate = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    IsRoot = table.Column<bool>(type: "boolean", nullable: false),
                    UserName = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    Email = table.Column<string>(type: "text", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "text", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUser", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Citizenships",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Citizenships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Extracts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Extracts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrivilegesMedicals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoefficentA = table.Column<int>(type: "integer", maxLength: 18, nullable: false),
                    CoefficentB = table.Column<int>(type: "integer", maxLength: 18, nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivilegesMedicals", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PrivilegesSocials",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CoefficentA = table.Column<int>(type: "integer", maxLength: 18, nullable: false),
                    CoefficentB = table.Column<int>(type: "integer", maxLength: 18, nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrivilegesSocials", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SocialStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Coefficent = table.Column<int>(type: "integer", maxLength: 18, nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SocialStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SurgicalGroup",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    WeightChild = table.Column<double>(type: "double precision", nullable: false),
                    WeightAdult = table.Column<double>(type: "double precision", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgicalGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TypeJoining",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypeJoining", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "RoleAccessRights",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    AccessRigthsType = table.Column<int>(type: "integer", nullable: false),
                    AccessRightsName = table.Column<string>(type: "text", nullable: true),
                    Order = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleAccessRights", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleAccessRights_ApplicationRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ApplicationRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ApplicationUserRole",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "integer", nullable: false),
                    UserId = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationUserRole", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_ApplicationUserRole_ApplicationRole_RoleId",
                        column: x => x.RoleId,
                        principalTable: "ApplicationRole",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ApplicationUserRole_ApplicationUser_UserId",
                        column: x => x.UserId,
                        principalTable: "ApplicationUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    RegionId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurgicalOnes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SurgicalGroupId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgicalOnes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurgicalOnes_SurgicalGroup_SurgicalGroupId",
                        column: x => x.SurgicalGroupId,
                        principalTable: "SurgicalGroup",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    Adress = table.Column<string>(type: "text", nullable: true),
                    FullName = table.Column<string>(type: "text", nullable: true),
                    Boss = table.Column<string>(type: "text", nullable: true),
                    DistrictId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hospitals_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurgicalTwos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SurgicalOneId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgicalTwos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurgicalTwos_SurgicalOnes_SurgicalOneId",
                        column: x => x.SurgicalOneId,
                        principalTable: "SurgicalOnes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Branches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CountBed = table.Column<int>(type: "integer", nullable: false),
                    HospitalId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    Code = table.Column<string>(type: "character varying(14)", maxLength: 14, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Branches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Branches_Hospitals_HospitalId",
                        column: x => x.HospitalId,
                        principalTable: "Hospitals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SurgicalThrees",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    SurgicalTwoId = table.Column<int>(type: "integer", nullable: false),
                    CreatedBy = table.Column<int>(type: "integer", nullable: false),
                    Created = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    LastModifiedBy = table.Column<int>(type: "integer", nullable: true),
                    LastModified = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Code = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SurgicalThrees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SurgicalThrees_SurgicalTwos_SurgicalTwoId",
                        column: x => x.SurgicalTwoId,
                        principalTable: "SurgicalTwos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "ApplicationRole",
                columns: new[] { "Id", "ConcurrencyStamp", "IsRoot", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { 1, "0405cb6c-6b34-4407-9c48-836885d581d3", true, "Суперадмин", "СУПЕРАДМИН" },
                    { 2, "598b1376-5f40-40b5-a069-b3d89e8a1b68", true, "Администратор", "АДМИНИСТРАТОР" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUser",
                columns: new[] { "Id", "AccessFailedCount", "AssignmentDate", "ConcurrencyStamp", "Email", "EmailConfirmed", "FairDate", "FirstName", "IsRoot", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "Patronymic", "PhoneNumber", "PhoneNumberConfirmed", "Pin", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "c94b51e5-52f3-4a06-a91b-f22a1588f9a4", null, false, null, "администратор", true, "Супер", false, null, "00000000000001", "00000000000001", "AQAAAAEAACcQAAAAEGRfB2kvtgwJUz/zUc6qK9WbgGF390HZb7+SQSNwVj7URD9LMxtsUxhVwxmxDm+lDA==", null, null, false, "00000000000001", "0382afaf-aeae-47ef-983d-c194ba94c64e", false, "00000000000001" });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, "41711000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Бишкек" },
                    { 2, "41721000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Ош" },
                    { 3, "41702000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Иссык-Кульская область" },
                    { 4, "41703000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Джалал-Абадская область" },
                    { 5, "41704000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Нарынская область" },
                    { 6, "41705000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Баткенская область" },
                    { 7, "41706000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ошская область" },
                    { 8, "41707000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Таласская область" },
                    { 9, "41708000000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Чуйская область" }
                });

            migrationBuilder.InsertData(
                table: "ApplicationUserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "Districts",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "RegionId" },
                values: new object[,]
                {
                    { 29, "41705214000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Баткенский район", 6 },
                    { 30, "41705236000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Лейлекский район", 6 },
                    { 31, "41705258000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Кадамжайский район", 6 },
                    { 32, "41705410000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Баткен", 6 },
                    { 33, "41705420000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Сулюкта", 6 },
                    { 34, "41705430000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Кызыл-Кия", 6 },
                    { 35, "41706207000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Алайский район", 7 },
                    { 36, "41706211000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Араванский район", 7 },
                    { 37, "41706226000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Кара-Сууский район", 7 },
                    { 38, "41706242000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ноокатский район", 7 },
                    { 39, "41706246000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Кара-Кулжинский район", 7 },
                    { 40, "41706255000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Узгенский район", 7 },
                    { 41, "41706259000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Чон-Алайский  район", 7 },
                    { 42, "41707215000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Кара-Бууринский район", 7 },
                    { 43, "41707220000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Бакай-Атинский район", 8 },
                    { 44, "41707225000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Манасский район", 8 },
                    { 45, "41707232000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Таласский район", 8 },
                    { 47, "41708203000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Аламудунский район", 9 },
                    { 48, "41708206000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ысык-Атинский район", 9 },
                    { 49, "41708209000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Жайылский район", 9 },
                    { 50, "41708213000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Кеминский район", 9 },
                    { 51, "41708217000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Московский район", 9 },
                    { 52, "41708219000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Панфиловский район", 9 },
                    { 53, "41708222000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Сокулукский район", 9 },
                    { 54, "41708223000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Чуйский район", 9 },
                    { 28, "41704400000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, null, "г. Нарын", 5 },
                    { 55, "41708400000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Токмок", 9 },
                    { 27, "41704245000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Нарынский район", 5 },
                    { 25, "41704230000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Жумгальский район", 5 },
                    { 56, "41711202000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Октябрьский район", 1 },
                    { 2, "41711203000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Первомайский район", 1 },
                    { 3, "41711204000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Свердловский район", 1 },
                    { 46, "41707400000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, null, null, "г. Талас", 1 },
                    { 4, "41702205000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ак-Суйский район", 3 },
                    { 5, "41702210000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Жети-Огузский район", 3 },
                    { 6, "41702215000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Иссык-Кульский район", 3 },
                    { 7, "41702220000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Тонский районрайон", 3 },
                    { 8, "41702225000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Тюпский район", 3 },
                    { 9, "41702420000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Балыкчы", 3 },
                    { 10, "41702410000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Каракол", 3 },
                    { 11, "41703204000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ала-Букинский район", 4 },
                    { 12, "41703207000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Базар-Коргонский район", 4 },
                    { 13, "41703211000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Аксыйский район", 4 },
                    { 14, "41703215000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ноокенский район", 4 },
                    { 15, "41703220000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Сузакский район", 4 },
                    { 16, "41703223000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Тогуз-Тороуский район", 4 },
                    { 17, "41703225000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Токтогульский район", 4 },
                    { 18, "41703230000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Чаткальский район", 4 },
                    { 19, "41703410000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Джалал-Абад", 4 },
                    { 20, "41703420000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Таш-Кумыр", 4 },
                    { 21, "41703430000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Майлуу-Суу", 4 },
                    { 22, "41703440000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Кара-Куль", 4 },
                    { 23, "41704210000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ак-Талинский район", 4 },
                    { 24, "41704220000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ат-Башынский район", 4 },
                    { 26, "41704235000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Кочкорский район", 5 },
                    { 1, "41711201000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ленинский район", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApplicationUserRole_RoleId",
                table: "ApplicationUserRole",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Branches_Code",
                table: "Branches",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Branches_HospitalId",
                table: "Branches",
                column: "HospitalId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_Code",
                table: "Districts",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Districts_RegionId",
                table: "Districts",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_Code",
                table: "Hospitals",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Hospitals_DistrictId",
                table: "Hospitals",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegesMedicals_Code",
                table: "PrivilegesMedicals",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrivilegesSocials_Code",
                table: "PrivilegesSocials",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Regions_Code",
                table: "Regions",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleAccessRights_RoleId",
                table: "RoleAccessRights",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SocialStatuses_Code",
                table: "SocialStatuses",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SurgicalOnes_SurgicalGroupId",
                table: "SurgicalOnes",
                column: "SurgicalGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgicalThrees_SurgicalTwoId",
                table: "SurgicalThrees",
                column: "SurgicalTwoId");

            migrationBuilder.CreateIndex(
                name: "IX_SurgicalTwos_SurgicalOneId",
                table: "SurgicalTwos",
                column: "SurgicalOneId");

            migrationBuilder.CreateIndex(
                name: "IX_TypeJoining_Code",
                table: "TypeJoining",
                column: "Code",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationUserRole");

            migrationBuilder.DropTable(
                name: "Branches");

            migrationBuilder.DropTable(
                name: "Citizenships");

            migrationBuilder.DropTable(
                name: "Extracts");

            migrationBuilder.DropTable(
                name: "PrivilegesMedicals");

            migrationBuilder.DropTable(
                name: "PrivilegesSocials");

            migrationBuilder.DropTable(
                name: "RoleAccessRights");

            migrationBuilder.DropTable(
                name: "SocialStatuses");

            migrationBuilder.DropTable(
                name: "SurgicalThrees");

            migrationBuilder.DropTable(
                name: "TypeJoining");

            migrationBuilder.DropTable(
                name: "ApplicationUser");

            migrationBuilder.DropTable(
                name: "Hospitals");

            migrationBuilder.DropTable(
                name: "ApplicationRole");

            migrationBuilder.DropTable(
                name: "SurgicalTwos");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "SurgicalOnes");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "SurgicalGroup");
        }
    }
}
