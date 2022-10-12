using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace csharp_boolflix.Migrations
{
    public partial class AddTableData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Actors",
                columns: new[] { "Id", "Name", "Nationality", "Surname" },
                values: new object[,]
                {
                    { 1, "Scarlett", "American", "Johansson" },
                    { 2, "Elizabeth", "American", "Olsen" },
                    { 3, "Cate", "Australian", "Blanchett" }
                });

            migrationBuilder.InsertData(
                table: "Characteristics",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pegi 13" },
                    { 2, "Pegi 16" },
                    { 3, "Pegi 18" },
                    { 4, "Violence" },
                    { 5, "Sex" },
                    { 6, "Drugs" },
                    { 7, "Splatter" },
                    { 8, "Racism" },
                    { 9, "Children" }
                });

            migrationBuilder.InsertData(
                table: "Episodes",
                columns: new[] { "Id", "Duration", "SeasonNumber", "TVSerieId" },
                values: new object[,]
                {
                    { 1, 53, 1, null },
                    { 2, 45, 1, null },
                    { 3, 49, 2, null }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Action" },
                    { 2, "Adventure" },
                    { 3, "Fantasy" },
                    { 4, "Sci-Fi" },
                    { 5, "Horror" },
                    { 6, "Noir" },
                    { 7, "Drama" },
                    { 8, "Comedy" },
                    { 9, "Love-Story" }
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Description", "Duration", "Image", "IsNew", "ReleaseYaer", "Title" },
                values: new object[,]
                {
                    { 1, "ER MEJO", 122, null, null, null, "LOTR 1" },
                    { 2, "ER PIU MEJO", 188, null, null, null, "LOTR 2" },
                    { 3, "ER MEJO DER MEJO", 244, null, null, null, "LOTR 3" }
                });

            migrationBuilder.InsertData(
                table: "TvSeries",
                columns: new[] { "Id", "Description", "Image", "IsNew", "ReleaseYaer", "Seasons", "Title" },
                values: new object[,]
                {
                    { 1, "Mamma pare che sono santo", null, null, null, 3, "Padre Maronno" },
                    { 2, "Winchester with a winchester", null, null, null, 15, "Supernatural" },
                    { 3, "Tenet u' succ e mellone", null, null, null, 1, "Boris" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Actors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Characteristics",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Episodes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Genres",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movies",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TvSeries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
