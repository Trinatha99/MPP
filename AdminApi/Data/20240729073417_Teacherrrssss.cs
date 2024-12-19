using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Teacherrrssss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(9127),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.AddColumn<string>(
                name: "TeacherDetails",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(7460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(5865),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(1975),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(2332),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FixVideos",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(488),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 129, DateTimeKind.Local).AddTicks(8606),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 207, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(365),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 129, DateTimeKind.Local).AddTicks(6822),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 207, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FacultyVideoUploads",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(3382),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DemoVideos",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(1854),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(4166),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 126, DateTimeKind.Local).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 203, DateTimeKind.Local).AddTicks(6491));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(6834));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7762));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7765));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7767));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7772));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7774));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 83, DateTimeKind.Local).AddTicks(7776));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 75, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 78, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 78, DateTimeKind.Local).AddTicks(73));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 78, DateTimeKind.Local).AddTicks(76));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 84, DateTimeKind.Local).AddTicks(9308));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 85, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 80, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 80, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 80, DateTimeKind.Local).AddTicks(8662));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 80, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 81, DateTimeKind.Local).AddTicks(8907));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 13, 4, 17, 81, DateTimeKind.Local).AddTicks(9811));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherDetails",
                table: "Teachers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(9368),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(7685),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(6084),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(2235),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(2669),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FixVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(971),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 207, DateTimeKind.Local).AddTicks(9008),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 129, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(669),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 207, DateTimeKind.Local).AddTicks(6857),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 129, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FacultyVideoUploads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(3845),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DemoVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(2383),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(4457),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 203, DateTimeKind.Local).AddTicks(6491),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 126, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7825));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7853));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7869));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7876));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 151, DateTimeKind.Local).AddTicks(7878));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 140, DateTimeKind.Local).AddTicks(3292));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 143, DateTimeKind.Local).AddTicks(712));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 143, DateTimeKind.Local).AddTicks(770));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 143, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(1804));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(1827));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(2096));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 154, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 146, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 147, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 147, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 147, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 148, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 29, 10, 56, 31, 149, DateTimeKind.Local).AddTicks(151));
        }
    }
}
