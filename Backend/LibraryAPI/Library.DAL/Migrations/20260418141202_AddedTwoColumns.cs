using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddedTwoColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsBookOnS3",
                table: "books",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsImageOnS3",
                table: "books",
                type: "boolean",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1075,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1076,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1155,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1156,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1157,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1170,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1171,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1172,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1173,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1174,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1175,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1176,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1177,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1178,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1179,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1180,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1181,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1182,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1183,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1184,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1185,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1186,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1187,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1188,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1189,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1190,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1191,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1192,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1193,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1194,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1195,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1202,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1203,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1204,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1205,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1206,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1207,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1208,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1209,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1210,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1211,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1212,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1213,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1214,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1215,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1216,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1217,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1218,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1219,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1220,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1221,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1222,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1223,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1224,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1225,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1226,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1227,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1228,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1229,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1230,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1231,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1232,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1233,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1234,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1235,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1236,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1237,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1238,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1239,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1240,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1241,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1242,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1243,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1244,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1245,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1246,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1247,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1248,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1249,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1250,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1251,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1252,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1253,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1254,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1255,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1256,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1257,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1258,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1259,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1260,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1261,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1262,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1263,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1264,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1265,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1266,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1267,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1268,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1269,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1270,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1271,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1272,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1273,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1274,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1275,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1276,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1277,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1278,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1279,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1280,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1281,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1282,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1283,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1284,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1285,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1286,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1287,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1288,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1289,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1290,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1291,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1292,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1293,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1294,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1295,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1296,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1297,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1298,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1299,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1300,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1301,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1302,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1303,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1304,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1307,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1308,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1309,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1310,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1311,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1312,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1313,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1314,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1315,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1316,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1317,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1318,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1319,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1320,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1321,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1322,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1323,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1324,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1325,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1326,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1327,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1328,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1329,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1330,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1331,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1332,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1333,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1334,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1335,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1336,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1337,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1338,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1339,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1340,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1341,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1342,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1343,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1344,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1345,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1346,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1347,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1348,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1349,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1350,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1351,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1352,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1353,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1354,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1355,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1356,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1357,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1359,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1361,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1362,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1363,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1364,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1365,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1366,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1367,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1368,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1369,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1370,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1371,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1372,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1373,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1374,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1375,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1376,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1377,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1378,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1379,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1380,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1381,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1382,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1383,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1384,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1386,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1387,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1388,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1389,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1390,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1391,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1392,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1393,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1394,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1395,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1396,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1397,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1398,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1399,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1401,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1402,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1403,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1404,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1405,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1406,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1407,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1408,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1409,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1410,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1412,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1414,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1415,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1416,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1417,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1418,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1419,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1420,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1421,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1422,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1423,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1424,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1425,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1426,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1427,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1428,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1429,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1430,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1431,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1432,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1433,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1434,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1435,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1436,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1437,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1438,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1439,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1440,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1441,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1442,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1443,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1444,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1445,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1446,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1447,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1448,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1449,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1450,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1451,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1452,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1453,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1454,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1455,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1456,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1457,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1458,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1459,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1460,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1461,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1462,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1463,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1464,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1465,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1466,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1467,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1468,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1469,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1470,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1471,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1472,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1473,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1474,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1475,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1476,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1477,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1478,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1479,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1480,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1481,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1482,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1483,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1484,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1485,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1486,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1487,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1488,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1489,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1490,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1491,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1492,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1493,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1494,
                columns: new[] { "IsBookOnS3", "IsImageOnS3" },
                values: new object[] { false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsBookOnS3",
                table: "books");

            migrationBuilder.DropColumn(
                name: "IsImageOnS3",
                table: "books");
        }
    }
}
