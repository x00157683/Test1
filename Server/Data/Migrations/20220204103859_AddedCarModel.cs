using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Server.Data.Migrations
{
    public partial class AddedCarModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Cars",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Make", "Model", "Range" },
                values: new object[] { 1, 1, "Tesla", "Model X", 0.0 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Make", "Model", "Range" },
                values: new object[] { 2, 2, "Tesla", "Model S", 0.0 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Make", "Model", "Range" },
                values: new object[] { 3, 3, "Porsche", "Taycan", 0.0 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Make", "Model", "Range" },
                values: new object[] { 4, 1, "Nissan", "Leaf", 0.0 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Make", "Model", "Range" },
                values: new object[] { 5, 2, "Honda", "Up!", 0.0 });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "CategoryId", "Make", "Model", "Range" },
                values: new object[] { 6, 3, "Toyota", "GT", 0.0 });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars");

            migrationBuilder.DropIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Cars",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Cars");
        }
    }
}
