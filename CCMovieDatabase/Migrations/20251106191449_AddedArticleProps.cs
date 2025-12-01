using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddedArticleProps : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsFeatured",
                table: "Articles",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Articles",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsFeatured",
                table: "Articles");

            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Articles");
        }
    }
}
