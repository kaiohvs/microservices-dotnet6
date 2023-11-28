using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class CriandoSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "Category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 2L, "Camisa", "Uma linda camisa do jurassipark preta com vermelho", "Test", "Camisa JurassyPark", 69.799999999999997 },
                    { 3L, "Capacete", "Uma capacete do dart veider pequeno da cor preta", "Test", "Capacete dart veider", 169.80000000000001 },
                    { 4L, "Boneco", "Um boneco de 1.10 branco do tropper storm", "Test", "Boneco storm", 269.80000000000001 },
                    { 5L, "Camisa", "Uma linda camisa gamer preta", "Test", "Camisa gamer", 69.799999999999997 },
                    { 6L, "Camisa", "Uma linda camisa da spacex branca com a manga azul", "Test", "Camisa spacex", 69.799999999999997 },
                    { 7L, "Camisa", "Uma linda camisa da coffer amarelada", "Test", "Camisa coffer", 69.799999999999997 },
                    { 8L, "Moleton", "Um lindo moletom preto da serie cobra kay", "Test", "Moletom cobra kay", 100.0 },
                    { 9L, "Camisa", "Uma linda camisa do jurassipark preta com vermelho", "Test", "filme stall tack", 69.799999999999997 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);
        }
    }
}
