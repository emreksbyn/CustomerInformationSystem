using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccess.Migrations
{
    public partial class AddedDataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "Email", "Name", "Surname", "TcNo" },
                values: new object[] { 1, "emre@gmail.com", "Emre", "Kısaboyun", "123" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "CustomerId", "Description", "District" },
                values: new object[,]
                {
                    { 1, "İstanbul", 1, "Ev", "Kadıköy" },
                    { 2, "İstanbul", 1, "İş", "Ataşehir" }
                });

            migrationBuilder.InsertData(
                table: "TelephoneNumbers",
                columns: new[] { "Id", "CustomerId", "Description", "TelephoneNo" },
                values: new object[,]
                {
                    { 1, 1, "Kişisel", "1234567" },
                    { 2, 1, "İş", "7654321" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TelephoneNumbers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TelephoneNumbers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
