using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class subgggs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(5267),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(3388),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.AddColumn<int>(
                name: "CourseId",
                table: "Subjects",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(1879),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(8664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(9032),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(4041));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(5612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(1285));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(7166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(3586),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 938, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(362),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(5206));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 745, DateTimeKind.Local).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 935, DateTimeKind.Local).AddTicks(5120));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(4417));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5338));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5349));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5358));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5360));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5362));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5366));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 711, DateTimeKind.Local).AddTicks(5368));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 704, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 706, DateTimeKind.Local).AddTicks(3562));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 706, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 706, DateTimeKind.Local).AddTicks(3595));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 712, DateTimeKind.Local).AddTicks(9266));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(63));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(64));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(66));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(67));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(70));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(71));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 713, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 708, DateTimeKind.Local).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 708, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 708, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 708, DateTimeKind.Local).AddTicks(3733));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 709, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 11, 58, 41, 709, DateTimeKind.Local).AddTicks(2988));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CourseId",
                table: "Subjects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(8852),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(7417),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(6357),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(3835),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(4041),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(1285),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(2760),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 938, DateTimeKind.Local).AddTicks(9096),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 939, DateTimeKind.Local).AddTicks(5206),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 7, 22, 54, 935, DateTimeKind.Local).AddTicks(5120),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 745, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(5232));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6393));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 897, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 887, DateTimeKind.Local).AddTicks(43));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 889, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 889, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 889, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2596));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 899, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 893, DateTimeKind.Local).AddTicks(620));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 893, DateTimeKind.Local).AddTicks(1980));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 893, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 893, DateTimeKind.Local).AddTicks(1994));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 895, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 25, 7, 22, 54, 895, DateTimeKind.Local).AddTicks(2489));
        }
    }
}
