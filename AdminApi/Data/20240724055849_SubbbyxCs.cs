using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class SubbbyxCs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 348, DateTimeKind.Local).AddTicks(1327),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(4725));

            migrationBuilder.AddColumn<string>(
                name: "SubjectDetails",
                table: "Subjects",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SubjectImage",
                table: "Subjects",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(9942),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(7058),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(7260),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(4301),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 511, DateTimeKind.Local).AddTicks(7009));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(6065),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 511, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(2629),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 511, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(8903),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(1911));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 344, DateTimeKind.Local).AddTicks(5156),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 508, DateTimeKind.Local).AddTicks(913));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(9002));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(9005));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(9014));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 308, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 301, DateTimeKind.Local).AddTicks(6067));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 303, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 303, DateTimeKind.Local).AddTicks(4531));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 303, DateTimeKind.Local).AddTicks(4534));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 309, DateTimeKind.Local).AddTicks(9863));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(807));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 310, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 306, DateTimeKind.Local).AddTicks(860));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 306, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 306, DateTimeKind.Local).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 306, DateTimeKind.Local).AddTicks(1998));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 307, DateTimeKind.Local).AddTicks(1829));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 28, 49, 307, DateTimeKind.Local).AddTicks(3332));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SubjectDetails",
                table: "Subjects");

            migrationBuilder.DropColumn(
                name: "SubjectImage",
                table: "Subjects");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Subjects",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(4725),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 348, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(3309),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(9942));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(235),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(592),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(7260));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 511, DateTimeKind.Local).AddTicks(7009),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(4301));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 511, DateTimeKind.Local).AddTicks(8698),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(6065));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 511, DateTimeKind.Local).AddTicks(5245),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 512, DateTimeKind.Local).AddTicks(1911),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 347, DateTimeKind.Local).AddTicks(8903));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 24, 11, 14, 28, 508, DateTimeKind.Local).AddTicks(913),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 24, 11, 28, 49, 344, DateTimeKind.Local).AddTicks(5156));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4062));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4071));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4073));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4078));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 471, DateTimeKind.Local).AddTicks(4080));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 464, DateTimeKind.Local).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 466, DateTimeKind.Local).AddTicks(108));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 466, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 466, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(5929));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6547));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6554));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6557));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6558));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6560));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 472, DateTimeKind.Local).AddTicks(6570));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 468, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 468, DateTimeKind.Local).AddTicks(5097));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 468, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 468, DateTimeKind.Local).AddTicks(5107));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 469, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 24, 11, 14, 28, 469, DateTimeKind.Local).AddTicks(7437));
        }
    }
}
