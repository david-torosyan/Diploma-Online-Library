using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5a6fd87e-98c2-4f50-9bf8-5b3b5814e6cd", "5a6fd87e-98c2-4f50-9bf8-5b3b5814e6cd", "maintainer", "MAINTAINER" },
                    { "8d9d971f-7a4c-4ca5-8a83-5c3e52fb3f64", "8d9d971f-7a4c-4ca5-8a83-5c3e52fb3f64", "user", "USER" },
                    { "9c4c64ec-39f1-4e38-b991-74d0caa3577c", "9c4c64ec-39f1-4e38-b991-74d0caa3577c", "admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5a6fd87e-98c2-4f50-9bf8-5b3b5814e6cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d9d971f-7a4c-4ca5-8a83-5c3e52fb3f64");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9c4c64ec-39f1-4e38-b991-74d0caa3577c");
        }
    }
}
