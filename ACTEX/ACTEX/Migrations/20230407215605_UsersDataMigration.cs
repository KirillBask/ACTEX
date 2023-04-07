using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ACTEX.Migrations
{
    /// <inheritdoc />
    public partial class UsersDataMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserTypes",
                columns: new[] { "Id", "AllowEdit", "Name" },
                values: new object[,]
                {
                    { 1, false, "Пользователь" },
                    { 2, true, "Администратор" },
                    { 3, true, "Модератор" },
                    { 4, false, "Тестировщик" },
                    { 5, false, "Гость" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "LastVisitDate", "Login", "Name", "Password", "TypeId" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "User1Login", "Пользователь1", "User1Pass", 1 },
                    { 2, new DateTime(2021, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin1Login", "Админ1", "Admin1Pass", 2 },
                    { 3, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mod1Login", "Модератор1", "Mod1Pass", 3 },
                    { 4, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test1Login", "Тест1", "Test1Pass", 4 },
                    { 5, new DateTime(2021, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guest1Login", "Гость1", "Guest1Pass", 5 },
                    { 6, new DateTime(2021, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "User2Login", "Пользователь2", "User2Pass", 1 },
                    { 7, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin2Login", "Админ2", "Admin2Pass", 2 },
                    { 8, new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mod2Login", "Модератор2", "Mod2Pass", 3 },
                    { 9, new DateTime(2021, 5, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test2Login", "Тест2", "Test2Pass", 4 },
                    { 10, new DateTime(2021, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guest2Login", "Гость2", "Guest2Pass", 5 },
                    { 11, new DateTime(2021, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "User3Login", "Пользователь3", "User3Pass", 1 },
                    { 12, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin3Login", "Админ3", "Admin3Pass", 2 },
                    { 13, new DateTime(2021, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mod3Login", "Модератор3", "Mod3Pass", 3 },
                    { 14, new DateTime(2021, 2, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Test3Login", "Тест3", "Test3Pass", 4 },
                    { 15, new DateTime(2021, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guest3Login", "Гость3", "Guest3Pass", 5 },
                    { 16, new DateTime(2021, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "andr16", "Андрей", "qwerty", 1 },
                    { 17, new DateTime(2021, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "serg123", "Сергей", "asdfgh", 5 },
                    { 18, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "anttoonn", "Антон", "123qwert", 3 },
                    { 19, new DateTime(2021, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "sasha1997", "Александр", "19970101", 2 },
                    { 20, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "nat789", "Наталья", "passworddrowssap", 1 },
                    { 21, new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "olggaa", "Ольга", "mypass123", 4 },
                    { 22, new DateTime(2021, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "max123", "Максим", "pass789", 4 },
                    { 23, new DateTime(2021, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "pavel546", "Павел", "5tgb4rfv", 5 },
                    { 24, new DateTime(2021, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "mar1983", "Мария", "123456789", 3 },
                    { 25, new DateTime(2021, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "oleggelo", "Олег", "drowssap", 1 },
                    { 26, new DateTime(2021, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "viktorr", "Виктор", "drowssap123", 2 },
                    { 27, new DateTime(2021, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "alina123", "Алина", "passssap", 5 },
                    { 28, new DateTime(2021, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "kir1990", "Кирилл", "235423723445", 1 },
                    { 29, new DateTime(2021, 3, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "alisa82", "Алиса", "zxcvbn", 1 },
                    { 30, new DateTime(2021, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "viktoria9", "Виктория", "poilkjy", 3 },
                    { 31, new DateTime(2021, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nasttsan", "Анастасия", "toppass789", 2 },
                    { 32, new DateTime(2021, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "georg4", "Георгий", "gfhjkm", 4 },
                    { 33, new DateTime(2021, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "ilya789", "Илья", "mkjhfg", 3 },
                    { 34, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "anna3", "Анна", "trefmpomsd213", 2 },
                    { 35, new DateTime(2021, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "katyaaytak", "Екатерина", "qwerty987", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 35);
        }
    }
}
