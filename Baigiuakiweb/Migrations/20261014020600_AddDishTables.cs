using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baigiuakiweb.Migrations
{
    /// <inheritdoc />
    public partial class AddDishTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategories_CourseCategoryId",
                table: "Courses");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseCategoryId_Name",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseImages",
                table: "CourseImages");

            migrationBuilder.RenameTable(
                name: "CourseImages",
                newName: "CourseImage");

            migrationBuilder.RenameIndex(
                name: "IX_CourseImages_CourseId",
                table: "CourseImage",
                newName: "IX_CourseImage_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseImage",
                table: "CourseImage",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "BIT240237_DishCategories",
                columns: table => new
                {
                    BIT240237_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BIT240237_Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BIT240237_Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIT240237_DishCategories", x => x.BIT240237_Id);
                });

            migrationBuilder.CreateTable(
                name: "BIT240237_Dishes",
                columns: table => new
                {
                    BIT240237_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BIT240237_Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    BIT240237_Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BIT240237_PreparationTime = table.Column<int>(type: "int", nullable: false),
                    BIT240237_IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    BIT240237_Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BIT240237_DishCategoryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIT240237_Dishes", x => x.BIT240237_Id);
                    table.ForeignKey(
                        name: "FK_BIT240237_Dishes_BIT240237_DishCategories_BIT240237_DishCategoryId",
                        column: x => x.BIT240237_DishCategoryId,
                        principalTable: "BIT240237_DishCategories",
                        principalColumn: "BIT240237_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BIT240237_DishImages",
                columns: table => new
                {
                    BIT240237_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BIT240237_ImageUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    BIT240237_IsThumbnail = table.Column<bool>(type: "bit", nullable: false),
                    BIT240237_DishId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BIT240237_DishImages", x => x.BIT240237_Id);
                    table.ForeignKey(
                        name: "FK_BIT240237_DishImages_BIT240237_Dishes_BIT240237_DishId",
                        column: x => x.BIT240237_DishId,
                        principalTable: "BIT240237_Dishes",
                        principalColumn: "BIT240237_Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_BIT240237_Dishes_BIT240237_DishCategoryId_BIT240237_Name",
                table: "BIT240237_Dishes",
                columns: new[] { "BIT240237_DishCategoryId", "BIT240237_Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BIT240237_DishImages_BIT240237_DishId_BIT240237_IsThumbnail",
                table: "BIT240237_DishImages",
                columns: new[] { "BIT240237_DishId", "BIT240237_IsThumbnail" });

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImage_Courses_CourseId",
                table: "CourseImage",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategories_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId",
                principalTable: "CourseCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseImage_Courses_CourseId",
                table: "CourseImage");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_CourseCategories_CourseCategoryId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "BIT240237_DishImages");

            migrationBuilder.DropTable(
                name: "BIT240237_Dishes");

            migrationBuilder.DropTable(
                name: "BIT240237_DishCategories");

            migrationBuilder.DropIndex(
                name: "IX_Courses_CourseCategoryId",
                table: "Courses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseImage",
                table: "CourseImage");

            migrationBuilder.RenameTable(
                name: "CourseImage",
                newName: "CourseImages");

            migrationBuilder.RenameIndex(
                name: "IX_CourseImage_CourseId",
                table: "CourseImages",
                newName: "IX_CourseImages_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseImages",
                table: "CourseImages",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_CourseCategoryId_Name",
                table: "Courses",
                columns: new[] { "CourseCategoryId", "Name" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_CourseCategories_CourseCategoryId",
                table: "Courses",
                column: "CourseCategoryId",
                principalTable: "CourseCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
