using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CCMovieDatabase.Migrations
{
    /// <inheritdoc />
    public partial class AddedArticles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "ArticleId", "Author", "Body", "CreatedAt", "IsFeatured", "ModifiedAt", "ShortDescription", "Slug", "ThumbnailUrl", "Title" },
                values: new object[,]
                {
                    { 1, "Jesse", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum and stuff", "hello_world", "https://craftypixels.com/placeholder-image/300", "Welcome to CCMovieDatabase" },
                    { 2, "Jesse", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum and stuff", "hello_world2", "https://craftypixels.com/placeholder-image/300", "More Movies Added" },
                    { 3, "Jesse", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum and stuff", "hello_world3", "https://craftypixels.com/placeholder-image/300", "For the love of movies" },
                    { 4, "Jesse", "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2025, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorem Ipsum and stuff", "hello_world4", "https://craftypixels.com/placeholder-image/300", "I wrote this" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "ArticleId",
                keyValue: 4);
        }
    }
}
