using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.data
{
    public partial class SubCoursesssys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Advertises");

            migrationBuilder.AddColumn<double>(
                name: "DiscountAmount",
                table: "SubCourses",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SalePrice",
                table: "SubCourses",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(7085),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(3258),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(3645),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local).AddTicks(348));

            migrationBuilder.AddColumn<string>(
                name: "FacilitiesVideo",
                table: "GetFacilities",
                nullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(110),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 645, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(1801),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 645, DateTimeKind.Local).AddTicks(8218));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 918, DateTimeKind.Local).AddTicks(8261),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 645, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(5373),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 915, DateTimeKind.Local).AddTicks(3611),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 641, DateTimeKind.Local).AddTicks(6091));

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DiscountAmount",
                table: "SubCourses");

            migrationBuilder.DropColumn(
                name: "SalePrice",
                table: "SubCourses");

            migrationBuilder.DropColumn(
                name: "FacilitiesVideo",
                table: "GetFacilities");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Studentss",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local).AddTicks(3749),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local).AddTicks(348),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(3645));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 645, DateTimeKind.Local).AddTicks(6302),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(110));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 645, DateTimeKind.Local).AddTicks(8218),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(1801));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 645, DateTimeKind.Local).AddTicks(4088),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 918, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local).AddTicks(1997),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 919, DateTimeKind.Local).AddTicks(5373));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 641, DateTimeKind.Local).AddTicks(6091),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 7, 17, 6, 15, 8, 915, DateTimeKind.Local).AddTicks(3611));

            migrationBuilder.CreateTable(
                name: "Advertises",
                columns: table => new
                {
                    AdvertiseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdvertiseBelowText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiseHeading = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiseImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiseName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AdvertiseText = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2024, 7, 15, 18, 15, 1, 646, DateTimeKind.Local).AddTicks(5550)),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedOn = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advertises", x => x.AdvertiseId);
                });

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(4976));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(4986));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(4993));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(4996));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(4998));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(5001));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 593, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 585, DateTimeKind.Local).AddTicks(4730));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 586, DateTimeKind.Local).AddTicks(8161));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 586, DateTimeKind.Local).AddTicks(8191));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 586, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(931));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2092));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2101));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2105));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2107));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2116));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 595, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 589, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 589, DateTimeKind.Local).AddTicks(8561));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 589, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 589, DateTimeKind.Local).AddTicks(8575));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 591, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 7, 15, 18, 15, 1, 591, DateTimeKind.Local).AddTicks(3048));
        }
    }
}
