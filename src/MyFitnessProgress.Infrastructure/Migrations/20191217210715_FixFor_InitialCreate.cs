using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFitnessProgress.Infrastructure.Migrations
{
    public partial class FixFor_InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Pictures_PictureId",
                schema: "diet",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "PictureId",
                schema: "diet",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 91, DateTimeKind.Utc).AddTicks(4580));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(5740));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(7430));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(7760));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(8420));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(8620));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(8910));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(9140));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(9340));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 139, DateTimeKind.Utc).AddTicks(9620));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 142, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(3660));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(4100));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(4360));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(4770));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(5010));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(5220));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(5540));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(5770));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(6180));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(6670));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(6870));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(7390));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(7630));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(7830));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(8030));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(8310));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(8510));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(8710));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(8990));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(9190));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(9390));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(2019, 12, 17, 21, 7, 15, 145, DateTimeKind.Utc).AddTicks(9590));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Pictures_PictureId",
                schema: "diet",
                table: "Products",
                column: "PictureId",
                principalSchema: "diet",
                principalTable: "Pictures",
                principalColumn: "PictureId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Pictures_PictureId",
                schema: "diet",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "PictureId",
                schema: "diet",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "ProductCategories",
                keyColumn: "ProductCategoryId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 1,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 2,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 3,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 4,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 5,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 6,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 7,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 8,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 9,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 10,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 11,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 12,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 13,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 14,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 15,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 16,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 17,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 18,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 19,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 20,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 21,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 22,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 23,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 24,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                schema: "diet",
                table: "Units",
                keyColumn: "UnitId",
                keyValue: 25,
                column: "CreationDate",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Pictures_PictureId",
                schema: "diet",
                table: "Products",
                column: "PictureId",
                principalSchema: "diet",
                principalTable: "Pictures",
                principalColumn: "PictureId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
