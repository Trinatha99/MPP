using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class FixDemos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DemoVideo",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "FixVideo",
                table: "Teachers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(5612),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.AddColumn<string>(
                name: "TeacherImage",
                table: "Teachers",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(4435),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(3334),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(664),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(8664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(888),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(8441),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(9420),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(7166));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(7097),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(2141),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 930, DateTimeKind.Local).AddTicks(9033),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 745, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.CreateTable(
                name: "DemoVideos",
                columns: table => new
                {
                    DemoVideoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    DemoVideoName = table.Column<string>(nullable: true),
                    DemoVideoUrl = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(7564)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DemoVideos", x => x.DemoVideoId);
                });

            migrationBuilder.CreateTable(
                name: "FixVideos",
                columns: table => new
                {
                    FixVideoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeacherId = table.Column<int>(nullable: false),
                    FixVideoName = table.Column<string>(nullable: true),
                    FixVideoUrl = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(6589)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FixVideos", x => x.FixVideoId);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DemoVideos");

            migrationBuilder.DropTable(
                name: "FixVideos");

            migrationBuilder.DropColumn(
                name: "TeacherImage",
                table: "Teachers");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Teachers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(5267),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(5612));

            migrationBuilder.AddColumn<string>(
                name: "DemoVideo",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FixVideo",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(3388),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(1879),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(8664),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(664));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(9032),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(888));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(5612),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(8441));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(7166),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(9420));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 749, DateTimeKind.Local).AddTicks(3586),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 933, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 750, DateTimeKind.Local).AddTicks(362),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 934, DateTimeKind.Local).AddTicks(2141));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 25, 11, 58, 41, 745, DateTimeKind.Local).AddTicks(7462),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 27, 9, 55, 7, 930, DateTimeKind.Local).AddTicks(9033));

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
    }
}
