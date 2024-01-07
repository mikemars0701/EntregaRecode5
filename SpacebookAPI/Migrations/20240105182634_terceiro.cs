using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SpacebookAPI.Migrations
{
    public partial class terceiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Viagem",
                columns: new[] { "id", "viagem_destino", "viagem_preco", "viagem_url" },
                values: new object[,]
                {
                    { 1, "Lua", 999.99m, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQqyNKJF0L88y06-Tp-uVoTEx7jeN2FQc5Hfabmplt5kq1ypHbKKqvWUz6qH19fNrNy2g8&usqp=CAU" },
                    { 2, "Terra", 999.99m, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRHVfPD7xVOprUwv9cBB9Ub8R6DcQkTfj0RGNloEhvCJg&s" },
                    { 3, "Marte", 999.99m, "https://media.istockphoto.com/id/1300652810/photo/mars-planet-3d-render-illustration-high-detailed-surface-features.jpg?s=612x612&w=0&k=20&c=V11fm3CB2JD1nmndQRTgBK-w4NOp72DXdxiOj2b9SHk=" },
                    { 4, "Jupiter", 999.99m, "https://t4.ftcdn.net/jpg/00/04/94/63/360_F_4946384_BOhNRo9oXd0KiN38sWXwIB72Rh8rzcv1.jpg" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Viagem",
                keyColumn: "id",
                keyValue: 4);
        }
    }
}
