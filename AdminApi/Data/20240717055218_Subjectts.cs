using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class Subjectts : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(5995),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(3519),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(3741),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(1080),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(2387),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 367, DateTimeKind.Local).AddTicks(9162),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 918, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(4836),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 364, DateTimeKind.Local).AddTicks(3846),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 915, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.CreateTable(
                name: "Subjects",
                columns: table => new
                {
                    SubjectId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCourseId = table.Column<int>(nullable: false),
                    SubjectName = table.Column<string>(nullable: true),
                    TeacherName = table.Column<string>(nullable: true),
                    FixVideo = table.Column<string>(nullable: true),
                    DemoVideo = table.Column<string>(nullable: true),
                    CreatedBy = table.Column<int>(nullable: false),
                    CreatedOn = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(6995)),
                    UpdatedBy = table.Column<int>(nullable: true),
                    UpdatedOn = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subjects", x => x.SubjectId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6305));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6307));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 322, DateTimeKind.Local).AddTicks(6319));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 314, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 317, DateTimeKind.Local).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 317, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 317, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 324, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(527));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(539));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(543));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 325, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 319, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 319, DateTimeKind.Local).AddTicks(8177));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 319, DateTimeKind.Local).AddTicks(8181));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 319, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 320, DateTimeKind.Local).AddTicks(8406));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 11, 22, 17, 320, DateTimeKind.Local).AddTicks(9408));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Subjects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(7085),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(5995));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(3258),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(3519));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(3645),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(110),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(1801),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(2387));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 918, DateTimeKind.Local).AddTicks(8261),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 367, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(5373),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 368, DateTimeKind.Local).AddTicks(4836));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 915, DateTimeKind.Local).AddTicks(3611),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 11, 22, 17, 364, DateTimeKind.Local).AddTicks(3846));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(4550));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5251));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5258));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5262));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5264));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5266));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5267));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 881, DateTimeKind.Local).AddTicks(5269));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 875, DateTimeKind.Local).AddTicks(3185));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 877, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 877, DateTimeKind.Local).AddTicks(4303));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 877, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4522));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4527));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4528));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4530));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4533));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4536));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 882, DateTimeKind.Local).AddTicks(4538));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 879, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 879, DateTimeKind.Local).AddTicks(3988));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 879, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 879, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 880, DateTimeKind.Local).AddTicks(1940));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 17, 6, 15, 8, 880, DateTimeKind.Local).AddTicks(2665));
        }
    }
}
