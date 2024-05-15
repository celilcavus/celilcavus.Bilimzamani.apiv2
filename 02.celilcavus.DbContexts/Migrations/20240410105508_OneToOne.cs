using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace _02.celilcavus.DbContexts.Migrations
{
    /// <inheritdoc />
    public partial class OneToOne : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Authors_AuthorsId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AuthorsId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoriesId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "AuthorsId",
                table: "Posts");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts",
                column: "AuthorId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoriesId",
                table: "Posts",
                column: "CategoriesId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_Id",
                table: "Posts",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Id",
                table: "Categories",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Authors_Id",
                table: "Authors",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Authors_AuthorId",
                table: "Posts",
                column: "AuthorId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Authors_AuthorId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_AuthorId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_CategoriesId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_Id",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Categories_Id",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Authors_Id",
                table: "Authors");

            migrationBuilder.AddColumn<int>(
                name: "AuthorsId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_AuthorsId",
                table: "Posts",
                column: "AuthorsId");

            migrationBuilder.CreateIndex(
                name: "IX_Posts_CategoriesId",
                table: "Posts",
                column: "CategoriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Authors_AuthorsId",
                table: "Posts",
                column: "AuthorsId",
                principalTable: "Authors",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
