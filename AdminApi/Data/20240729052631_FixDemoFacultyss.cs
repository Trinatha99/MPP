using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class FixDemoFacultyss : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "FixVideos");

            migrationBuilder.DropColumn(
                name: "TeacherId",
                table: "DemoVideos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(9368),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(3796));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(7685),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(2817));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(6084),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(1674));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(2235),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(9251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(2669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FixVideos",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(971),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(4748));

            migrationBuilder.AddColumn<int>(
                name: "FacultyVideoUploadId",
                table: "FixVideos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 207, DateTimeKind.Local).AddTicks(9008),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(669),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(8251));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 207, DateTimeKind.Local).AddTicks(6857),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(5832));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DemoVideos",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(2383),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(5808));

            migrationBuilder.AddColumn<int>(
                name: "FacultyVideoUploadId",
                table: "DemoVideos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(4457),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 203, DateTimeKind.Local).AddTicks(6491),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 313, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.CreateTable(
                name: "FacultyVideoUploads",
                columns: table => new
                {
                    FacultyVideoUploadId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(nullable: false),
                    SubCourseId = table.Column<int>(nullable: false),
                    SubjectId = table.Column<int>(nullable: false),
                    TeacherId = table.Column<int>(nullable: false),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(3845)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacultyVideoUploads", x => x.FacultyVideoUploadId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FacultyVideoUploads");

            migrationBuilder.DropColumn(
                name: "FacultyVideoUploadId",
                table: "FixVideos");

            migrationBuilder.DropColumn(
                name: "FacultyVideoUploadId",
                table: "DemoVideos");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(3796),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(2817),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(1674),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(6084));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(9251),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(2235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(9454),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FixVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(4748),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(971));

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "FixVideos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(7159),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 207, DateTimeKind.Local).AddTicks(9008));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(8251),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 316, DateTimeKind.Local).AddTicks(5832),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 207, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "DemoVideos",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(5808),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 209, DateTimeKind.Local).AddTicks(2383));

            migrationBuilder.AddColumn<int>(
                name: "TeacherId",
                table: "DemoVideos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 317, DateTimeKind.Local).AddTicks(512),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 208, DateTimeKind.Local).AddTicks(4457));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 29, 10, 17, 15, 313, DateTimeKind.Local).AddTicks(8364),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 29, 10, 56, 31, 203, DateTimeKind.Local).AddTicks(6491));

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
    }
}
