using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Infrastructure.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Regions",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Districts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

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
                table: "Districts",
                columns: new[] { "Id", "Code", "Created", "CreatedBy", "LastModified", "LastModifiedBy", "Name", "RegionId" },
                values: new object[,]
                {
                    { 1, "41711201000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Ленинский район", 1 },
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
                    { 28, "41704400000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, null, null, "г. Нарын", 5 },
                    { 40, "41706255000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Узгенский район", 7 },
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
                    { 41, "41706259000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Чон-Алайский  район", 7 },
                    { 27, "41704245000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Нарынский район", 5 },
                    { 26, "41704235000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Кочкорский район", 5 },
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
                    { 54, "41708223000000", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "Чуйский район", 9 },
                    { 55, "41708400000010", new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, null, null, "г. Токмок", 9 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Districts",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Regions",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "Districts",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .OldAnnotation("Npgsql:IdentitySequenceOptions", "'100', '1', '', '', 'False', '1'")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);
        }
    }
}
