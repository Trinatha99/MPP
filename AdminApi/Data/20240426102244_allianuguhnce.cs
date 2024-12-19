using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AdminApi.Data
{
    public partial class allianuguhnce : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GalleryCategoryId",
                table: "Galleries");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 865, DateTimeKind.Local).AddTicks(7419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 896, DateTimeKind.Local).AddTicks(683));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 865, DateTimeKind.Local).AddTicks(8017),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 896, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 865, DateTimeKind.Local).AddTicks(2231),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 895, DateTimeKind.Local).AddTicks(8390));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 865, DateTimeKind.Local).AddTicks(4376),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 895, DateTimeKind.Local).AddTicks(9461));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 864, DateTimeKind.Local).AddTicks(9690),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 895, DateTimeKind.Local).AddTicks(7262));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 866, DateTimeKind.Local).AddTicks(3),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 896, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 860, DateTimeKind.Local).AddTicks(6419),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 893, DateTimeKind.Local).AddTicks(3401));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9462));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9478));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9480));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9486));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9489));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 798, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 787, DateTimeKind.Local).AddTicks(8325));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 789, DateTimeKind.Local).AddTicks(7358));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 789, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 789, DateTimeKind.Local).AddTicks(7415));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9827));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9832));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9840));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 800, DateTimeKind.Local).AddTicks(9853));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 793, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 793, DateTimeKind.Local).AddTicks(3470));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 793, DateTimeKind.Local).AddTicks(3482));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 793, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 795, DateTimeKind.Local).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 26, 15, 52, 43, 795, DateTimeKind.Local).AddTicks(4121));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateAdded",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 896, DateTimeKind.Local).AddTicks(683),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 865, DateTimeKind.Local).AddTicks(7419));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "MarketUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 896, DateTimeKind.Local).AddTicks(887),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 865, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.AddColumn<int>(
                name: "GalleryCategoryId",
                table: "Galleries",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterValues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 895, DateTimeKind.Local).AddTicks(8390),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 865, DateTimeKind.Local).AddTicks(2231));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "FilterSettings",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 895, DateTimeKind.Local).AddTicks(9461),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 865, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Filters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 895, DateTimeKind.Local).AddTicks(7262),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 864, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Courses",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 896, DateTimeKind.Local).AddTicks(1733),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 866, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedOn",
                table: "Category",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2024, 4, 25, 16, 57, 22, 893, DateTimeKind.Local).AddTicks(3401),
                oldClrType: typeof(DateTime),
                oldDefaultValue: new DateTime(2024, 4, 26, 15, 52, 43, 860, DateTimeKind.Local).AddTicks(6419));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 858, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(723));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(733));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(740));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(749));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(752));

            migrationBuilder.UpdateData(
                table: "Menu",
                keyColumn: "MenuID",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 859, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 850, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 852, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 852, DateTimeKind.Local).AddTicks(3588));

            migrationBuilder.UpdateData(
                table: "MenuGroup",
                keyColumn: "MenuGroupID",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 852, DateTimeKind.Local).AddTicks(3592));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(7334));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 5,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8331));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 6,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8334));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 7,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 8,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8338));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 9,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8341));

            migrationBuilder.UpdateData(
                table: "MenuGroupWiseMenuMapping",
                keyColumn: "MenuGroupWiseMenuMappingId",
                keyValue: 10,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 860, DateTimeKind.Local).AddTicks(8343));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 854, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 854, DateTimeKind.Local).AddTicks(9627));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 3,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 854, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "UserRoleId",
                keyValue: 4,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 854, DateTimeKind.Local).AddTicks(9636));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 855, DateTimeKind.Local).AddTicks(9857));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                column: "DateAdded",
                value: new DateTime(2024, 4, 25, 16, 57, 22, 856, DateTimeKind.Local).AddTicks(838));
        }
    }
}
