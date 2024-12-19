using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class stksudd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 198, DateTimeKind.Local).AddTicks(1567),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(5802));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 198, DateTimeKind.Local).AddTicks(2138),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(6154));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 197, DateTimeKind.Local).AddTicks(5194),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(2056));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 197, DateTimeKind.Local).AddTicks(8387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 197, DateTimeKind.Local).AddTicks(1732),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 159, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 198, DateTimeKind.Local).AddTicks(5013),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(7807));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 191, DateTimeKind.Local).AddTicks(3282),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 156, DateTimeKind.Local).AddTicks(1948));

            migrationBuilder.CreateTable(
                name: "Studentss",
                columns: table => new
                {
                    StudentsId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentsName = table.Column<string>(nullable: true),
                    StudentsAssignment = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Studentss", x => x.StudentsId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7110));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7113));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 126, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 118, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 119, DateTimeKind.Local).AddTicks(4910));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 119, DateTimeKind.Local).AddTicks(4944));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 119, DateTimeKind.Local).AddTicks(4948));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(4327));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5500));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5508));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5511));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5516));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5518));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5521));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5523));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 128, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 122, DateTimeKind.Local).AddTicks(5785));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 122, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 122, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 122, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 124, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 11, 30, 124, DateTimeKind.Local).AddTicks(3279));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Studentss");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(5802),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 198, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(6154),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 198, DateTimeKind.Local).AddTicks(2138));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(2056),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 197, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(3916),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 197, DateTimeKind.Local).AddTicks(8387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 159, DateTimeKind.Local).AddTicks(9656),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 197, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 160, DateTimeKind.Local).AddTicks(7807),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 198, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 3, 50, 156, DateTimeKind.Local).AddTicks(1948),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 11, 30, 191, DateTimeKind.Local).AddTicks(3282));

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    StudentAssignment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StudentName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8298));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8301));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8304));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8309));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8312));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 106, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 98, DateTimeKind.Local).AddTicks(7550));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 100, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 100, DateTimeKind.Local).AddTicks(892));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 100, DateTimeKind.Local).AddTicks(897));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(8987));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(9003));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 108, DateTimeKind.Local).AddTicks(9015));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 102, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 103, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 103, DateTimeKind.Local).AddTicks(758));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 103, DateTimeKind.Local).AddTicks(761));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 104, DateTimeKind.Local).AddTicks(4692));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 3, 50, 104, DateTimeKind.Local).AddTicks(6165));
        }
    }
}
