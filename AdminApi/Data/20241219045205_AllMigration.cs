using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class AllMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(3269),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(9127));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(2290),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(7460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(1310),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(5865));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(9089),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(9271),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FixVideos",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(4384),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(6259),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 129, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(7907),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(3436),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 129, DateTimeKind.Local).AddTicks(6822));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FacultyVideoUploads",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(6405),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DemoVideos",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(5403),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(460),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(4166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 820, DateTimeKind.Local).AddTicks(490),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 126, DateTimeKind.Local).AddTicks(3383));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(3497));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4096));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4103));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 784, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 778, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 779, DateTimeKind.Local).AddTicks(8420));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 779, DateTimeKind.Local).AddTicks(8445));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 779, DateTimeKind.Local).AddTicks(8448));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3690));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3695));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3698));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3699));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3701));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3702));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 785, DateTimeKind.Local).AddTicks(3709));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 781, DateTimeKind.Local).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 782, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 782, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 782, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 782, DateTimeKind.Local).AddTicks(9525));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 12, 19, 10, 22, 4, 783, DateTimeKind.Local).AddTicks(263));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(9127),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(7460),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(2290));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(5865),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(1310));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(1975),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(9089));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(2332),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(9271));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FixVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(488),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 129, DateTimeKind.Local).AddTicks(8606),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(365),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 129, DateTimeKind.Local).AddTicks(6822),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 823, DateTimeKind.Local).AddTicks(3436));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FacultyVideoUploads",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(3382),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(6405));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DemoVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 131, DateTimeKind.Local).AddTicks(1854),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 130, DateTimeKind.Local).AddTicks(4166),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 824, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 13, 4, 17, 126, DateTimeKind.Local).AddTicks(3383),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 12, 19, 10, 22, 4, 820, DateTimeKind.Local).AddTicks(490));

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
    }
}
