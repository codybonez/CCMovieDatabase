using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedImagesForMovies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ThumbnailURL",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTG_q0A0cypAsXxYlgs5J_554BrcnjeeKExlQE3ZaZUuPYv0fUd");

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                column: "ThumbnailURL",
                value: "https://encrypted-tbn3.gstatic.com/images?q=tbn:ANd9GcTPx7lW6h0G1O9-npEnVPL07fT74Tp6SFl0i47nxfypyVBcQFdS");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ThumbnailURL",
                table: "Movie");
        }
    }
}
