using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Baigiuakiweb.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDishSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BIT240237_Dishes_BIT240237_DishCategories_BIT240237_DishCategoryId",
                table: "BIT240237_Dishes");

            migrationBuilder.DropForeignKey(
                name: "FK_BIT240237_DishImages_BIT240237_Dishes_BIT240237_DishId",
                table: "BIT240237_DishImages");

            migrationBuilder.DropForeignKey(
                name: "FK_CourseImage_Courses_CourseId",
                table: "CourseImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseImage",
                table: "CourseImage");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BIT240237_DishImages",
                table: "BIT240237_DishImages");

            migrationBuilder.DropIndex(
                name: "IX_BIT240237_DishImages_BIT240237_DishId_BIT240237_IsThumbnail",
                table: "BIT240237_DishImages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BIT240237_Dishes",
                table: "BIT240237_Dishes");

            migrationBuilder.DropIndex(
                name: "IX_BIT240237_Dishes_BIT240237_DishCategoryId_BIT240237_Name",
                table: "BIT240237_Dishes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_BIT240237_DishCategories",
                table: "BIT240237_DishCategories");

            migrationBuilder.RenameTable(
                name: "CourseImage",
                newName: "CourseImages");

            migrationBuilder.RenameTable(
                name: "BIT240237_DishImages",
                newName: "DishImages_BIT240237");

            migrationBuilder.RenameTable(
                name: "BIT240237_Dishes",
                newName: "Dishes_BIT240237");

            migrationBuilder.RenameTable(
                name: "BIT240237_DishCategories",
                newName: "DishCategories_BIT240237");

            migrationBuilder.RenameIndex(
                name: "IX_CourseImage_CourseId",
                table: "CourseImages",
                newName: "IX_CourseImages_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseImages",
                table: "CourseImages",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishImages_BIT240237",
                table: "DishImages_BIT240237",
                column: "BIT240237_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dishes_BIT240237",
                table: "Dishes_BIT240237",
                column: "BIT240237_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DishCategories_BIT240237",
                table: "DishCategories_BIT240237",
                column: "BIT240237_Id");

            migrationBuilder.CreateIndex(
                name: "IX_DishImages_BIT240237_BIT240237_DishId",
                table: "DishImages_BIT240237",
                column: "BIT240237_DishId");

            migrationBuilder.CreateIndex(
                name: "IX_Dishes_BIT240237_BIT240237_DishCategoryId",
                table: "Dishes_BIT240237",
                column: "BIT240237_DishCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dishes_BIT240237_DishCategories_BIT240237_BIT240237_DishCategoryId",
                table: "Dishes_BIT240237",
                column: "BIT240237_DishCategoryId",
                principalTable: "DishCategories_BIT240237",
                principalColumn: "BIT240237_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_DishImages_BIT240237_Dishes_BIT240237_BIT240237_DishId",
                table: "DishImages_BIT240237",
                column: "BIT240237_DishId",
                principalTable: "Dishes_BIT240237",
                principalColumn: "BIT240237_Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CourseImages_Courses_CourseId",
                table: "CourseImages");

            migrationBuilder.DropForeignKey(
                name: "FK_Dishes_BIT240237_DishCategories_BIT240237_BIT240237_DishCategoryId",
                table: "Dishes_BIT240237");

            migrationBuilder.DropForeignKey(
                name: "FK_DishImages_BIT240237_Dishes_BIT240237_BIT240237_DishId",
                table: "DishImages_BIT240237");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DishImages_BIT240237",
                table: "DishImages_BIT240237");

            migrationBuilder.DropIndex(
                name: "IX_DishImages_BIT240237_BIT240237_DishId",
                table: "DishImages_BIT240237");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dishes_BIT240237",
                table: "Dishes_BIT240237");

            migrationBuilder.DropIndex(
                name: "IX_Dishes_BIT240237_BIT240237_DishCategoryId",
                table: "Dishes_BIT240237");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DishCategories_BIT240237",
                table: "DishCategories_BIT240237");

            migrationBuilder.DropPrimaryKey(
                name: "PK_CourseImages",
                table: "CourseImages");

            migrationBuilder.RenameTable(
                name: "DishImages_BIT240237",
                newName: "BIT240237_DishImages");

            migrationBuilder.RenameTable(
                name: "Dishes_BIT240237",
                newName: "BIT240237_Dishes");

            migrationBuilder.RenameTable(
                name: "DishCategories_BIT240237",
                newName: "BIT240237_DishCategories");

            migrationBuilder.RenameTable(
                name: "CourseImages",
                newName: "CourseImage");

            migrationBuilder.RenameIndex(
                name: "IX_CourseImages_CourseId",
                table: "CourseImage",
                newName: "IX_CourseImage_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BIT240237_DishImages",
                table: "BIT240237_DishImages",
                column: "BIT240237_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BIT240237_Dishes",
                table: "BIT240237_Dishes",
                column: "BIT240237_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BIT240237_DishCategories",
                table: "BIT240237_DishCategories",
                column: "BIT240237_Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CourseImage",
                table: "CourseImage",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_BIT240237_DishImages_BIT240237_DishId_BIT240237_IsThumbnail",
                table: "BIT240237_DishImages",
                columns: new[] { "BIT240237_DishId", "BIT240237_IsThumbnail" });

            migrationBuilder.CreateIndex(
                name: "IX_BIT240237_Dishes_BIT240237_DishCategoryId_BIT240237_Name",
                table: "BIT240237_Dishes",
                columns: new[] { "BIT240237_DishCategoryId", "BIT240237_Name" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_BIT240237_Dishes_BIT240237_DishCategories_BIT240237_DishCategoryId",
                table: "BIT240237_Dishes",
                column: "BIT240237_DishCategoryId",
                principalTable: "BIT240237_DishCategories",
                principalColumn: "BIT240237_Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BIT240237_DishImages_BIT240237_Dishes_BIT240237_DishId",
                table: "BIT240237_DishImages",
                column: "BIT240237_DishId",
                principalTable: "BIT240237_Dishes",
                principalColumn: "BIT240237_Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_CourseImage_Courses_CourseId",
                table: "CourseImage",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
