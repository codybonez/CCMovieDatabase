using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class Added5movies : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ReleaseDate", "Title" },
                values: new object[] { "James, an NYC cop, is hired by Agent K of a secret government agency that monitors extraterrestrial life on Earth. Together, they must recover an item that has been stolen by an intergalactic villain.", new DateOnly(1997, 7, 25), "Men in Black" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ReleaseDate", "Title" },
                values: new object[] { "Jake Sully lives with his newfound family formed on the extrasolar moon Pandora. Once a familiar threat returns to finish what was previously started, Jake must work with Neytiri and the army of the Na'vi race to protect their home.", new DateOnly(2022, 12, 16), "Avatar: The Way of Water" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Description", "RatingId", "ReleaseDate", "Title" },
                values: new object[,]
                {
                    { 3, "The Avengers and their allies must be willing to sacrifice all in an attempt to defeat the powerful Thanos before his blitz of devastation and ruin puts an end to the universe.", 1, new DateOnly(2018, 4, 23), "Avengers: Infinity War" },
                    { 4, "A rat who can cook makes an unusual alliance with a young kitchen worker at a famous Paris restaurant.", 3, new DateOnly(2007, 6, 28), "Ratatouille" },
                    { 5, "In order to power the city, monsters have to scare children so that they scream. However, the children are toxic to the monsters, and after a child gets through, two monsters realize things may not be what they think", 3, new DateOnly(2001, 10, 28), "Monsters, Inc." }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ReleaseDate", "Title" },
                values: new object[] { "A mean lord exiles fairytale creatures to the swamp of a grumpy ogre, who must go on a quest and rescue a princess for the lord in order to get his land back.", new DateOnly(2001, 4, 26), "Shrek" });

            migrationBuilder.UpdateData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ReleaseDate", "Title" },
                values: new object[] { "Shrek is back baby!", new DateOnly(2002, 4, 26), "Shrek 2" });
        }
    }
}
