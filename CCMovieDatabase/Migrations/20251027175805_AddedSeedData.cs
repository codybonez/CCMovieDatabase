using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "MotionPictureRating", "ReleaseDate", "Title" },
                values: new object[] { 1, "A Movie about a big green loudmouth.", "PG", new DateOnly(2001, 4, 26), "Shrek" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
