using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MyFitnessProgress.Infrastructure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "diet");

            migrationBuilder.CreateTable(
                name: "Macros",
                schema: "diet",
                columns: table => new
                {
                    MacroId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Carbohydrates = table.Column<decimal>(nullable: false),
                    Protein = table.Column<decimal>(nullable: false),
                    Fat = table.Column<decimal>(nullable: false),
                    Calories = table.Column<decimal>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Macros", x => x.MacroId);
                });

            migrationBuilder.CreateTable(
                name: "Pictures",
                schema: "diet",
                columns: table => new
                {
                    PictureId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    FilePath = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pictures", x => x.PictureId);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                schema: "diet",
                columns: table => new
                {
                    ProductCategoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.ProductCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Units",
                schema: "diet",
                columns: table => new
                {
                    UnitId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Units", x => x.UnitId);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "diet",
                columns: table => new
                {
                    ProductId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 500, nullable: true),
                    MacroId = table.Column<int>(nullable: false),
                    UnitId = table.Column<int>(nullable: false),
                    PictureId = table.Column<int>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastModify = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Macros_MacroId",
                        column: x => x.MacroId,
                        principalSchema: "diet",
                        principalTable: "Macros",
                        principalColumn: "MacroId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Pictures_PictureId",
                        column: x => x.PictureId,
                        principalSchema: "diet",
                        principalTable: "Pictures",
                        principalColumn: "PictureId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalSchema: "diet",
                        principalTable: "ProductCategories",
                        principalColumn: "ProductCategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Units_UnitId",
                        column: x => x.UnitId,
                        principalSchema: "diet",
                        principalTable: "Units",
                        principalColumn: "UnitId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "diet",
                table: "ProductCategories",
                columns: new[] { "ProductCategoryId", "CreationDate", "IsDeleted", "LastModify", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 12, 15, 19, 15, 45, 696, DateTimeKind.Utc).AddTicks(2400), false, null, "Nabiał" },
                    { 10, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(3790), false, null, "Owoce i Warzywa" },
                    { 9, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(3590), false, null, "Inne" },
                    { 8, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(3360), false, null, "Tłuszcze" },
                    { 7, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(3050), false, null, "Napoje" },
                    { 11, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(4070), false, null, "Przyprawy i zioła" },
                    { 5, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(2610), false, null, "Zbożowe" },
                    { 4, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(2170), false, null, "Pieczywo" },
                    { 3, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(1430), false, null, "Ryby i owoce morza" },
                    { 2, new DateTime(2019, 12, 15, 19, 15, 45, 755, DateTimeKind.Utc).AddTicks(3490), false, null, "Mięso i wyroby mięsne" },
                    { 6, new DateTime(2019, 12, 15, 19, 15, 45, 756, DateTimeKind.Utc).AddTicks(2830), false, null, "Orzechy i ziarna" }
                });

            migrationBuilder.InsertData(
                schema: "diet",
                table: "Units",
                columns: new[] { "UnitId", "CreationDate", "IsDeleted", "LastModify", "Name" },
                values: new object[,]
                {
                    { 14, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(9500), false, null, "Ząbek" },
                    { 23, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(1620), false, null, "Miarka" },
                    { 22, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(1410), false, null, "Kapsułka" },
                    { 21, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(1120), false, null, "Rurka" },
                    { 20, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(920), false, null, "Płat" },
                    { 19, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(710), false, null, "Szczypta" },
                    { 18, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(410), false, null, "Kropla" },
                    { 17, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(200), false, null, "Kieliszek" },
                    { 16, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(9990), false, null, "Łodyga" },
                    { 15, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(9780), false, null, "Liść" },
                    { 13, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(9300), false, null, "Kostka" },
                    { 7, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(6780), false, null, "Plasterek" },
                    { 11, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(8860), false, null, "Kromka" },
                    { 10, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(8570), false, null, "Listek" },
                    { 9, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(8350), false, null, "Łyżeczka" },
                    { 8, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(8080), false, null, "Opakowanie" },
                    { 24, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(1830), false, null, "Pęczek" },
                    { 6, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(6350), false, null, "Porcja" },
                    { 5, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(6100), false, null, "Plaster" },
                    { 4, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(5520), false, null, "Litr" },
                    { 3, new DateTime(2019, 12, 15, 19, 15, 45, 764, DateTimeKind.Utc).AddTicks(8360), false, null, "Sztuka" },
                    { 2, new DateTime(2019, 12, 15, 19, 15, 45, 764, DateTimeKind.Utc).AddTicks(7470), false, null, "Łyżka" },
                    { 1, new DateTime(2019, 12, 15, 19, 15, 45, 761, DateTimeKind.Utc).AddTicks(6530), false, null, "Garść" },
                    { 12, new DateTime(2019, 12, 15, 19, 15, 45, 767, DateTimeKind.Utc).AddTicks(9080), false, null, "Szklanka" },
                    { 25, new DateTime(2019, 12, 15, 19, 15, 45, 768, DateTimeKind.Utc).AddTicks(2110), false, null, "Gałka" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ProductCategories_Name",
                schema: "diet",
                table: "ProductCategories",
                column: "Name",
                unique: true,
                filter: "[Name] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Products_MacroId",
                schema: "diet",
                table: "Products",
                column: "MacroId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_PictureId",
                schema: "diet",
                table: "Products",
                column: "PictureId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                schema: "diet",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_UnitId",
                schema: "diet",
                table: "Products",
                column: "UnitId");

            migrationBuilder.CreateIndex(
                name: "IX_Units_Name",
                schema: "diet",
                table: "Units",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "diet");

            migrationBuilder.DropTable(
                name: "Macros",
                schema: "diet");

            migrationBuilder.DropTable(
                name: "Pictures",
                schema: "diet");

            migrationBuilder.DropTable(
                name: "ProductCategories",
                schema: "diet");

            migrationBuilder.DropTable(
                name: "Units",
                schema: "diet");
        }
    }
}
