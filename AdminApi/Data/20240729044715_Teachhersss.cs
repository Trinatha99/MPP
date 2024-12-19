using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Teachhersss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(3796),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(1674),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(9251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(9454),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FixVideos",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(4748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(6589));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(7159),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(8251),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(5832),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DemoVideos",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(5808),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(7564));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(512),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 313, DateTimeKind.Local).AddTicks(8364),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 930, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(5797));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6391));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6398));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6400));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6403));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 280, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 274, DateTimeKind.Local).AddTicks(4373));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 275, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 275, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 275, DateTimeKind.Local).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6961));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6969));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6971));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6972));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6974));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 281, DateTimeKind.Local).AddTicks(6982));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 277, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 278, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 278, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 278, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 279, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 17, 15, 279, DateTimeKind.Local).AddTicks(1139));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(5612),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(4435),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(3334),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(888),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FixVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(6589),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(8441),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(9420),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(7097),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DemoVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(7564),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(2141),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 930, DateTimeKind.Local).AddTicks(9033),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 313, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(787));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1392));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1393));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1395));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1397));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 898, DateTimeKind.Local).AddTicks(1399));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 892, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 893, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 893, DateTimeKind.Local).AddTicks(8497));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 893, DateTimeKind.Local).AddTicks(8499));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(799));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(803));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(804));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 899, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 895, DateTimeKind.Local).AddTicks(7717));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 895, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 895, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 895, DateTimeKind.Local).AddTicks(8383));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 896, DateTimeKind.Local).AddTicks(7484));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 27, 9, 55, 7, 896, DateTimeKind.Local).AddTicks(8398));
        }
    }
}
