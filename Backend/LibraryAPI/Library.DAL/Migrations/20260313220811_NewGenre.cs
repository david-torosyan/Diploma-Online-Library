using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewGenre : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "categories",
                columns: new[] { "Id", "Name" },
                values: new object[] { 11, "another" });

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "AuthorId", "BookURL", "CategoryId", "Description", "ISBN", "ImageURL", "IsApproved", "Pages", "PublishedDate", "Title" },
                values: new object[] { 100, 113, "https://www.europarc.org/wp-content/uploads/2015/05/2012_Parks_and_Benefits_Guide_to_sustainable_tourism_in_Protected_Areas.pdf", 11, "This report tells how to ensure that tourism follows a sustainable path and that it contributes to the sustainable management of protected areas. Guidelines are presented to help readers understand protected area tourism and its management, and practical suggestions are based on theory and practice from around the world. Coverage includes biodiversity and conservation, planning for protected area tourism, culturally sensitive design and operation, visitor management, and human resources. There is no subject index. Eagles teaches at the University of Waterloo, Canada. Annotation copyrighted by Book News, Inc., Portland, OR.", "9782831706481", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQuN00TpctnWSLzvYdA_2rk8RxHDn9MM2hUwA&s", true, 191, new DateTime(2002, 1, 1, 0, 0, 0, DateTimeKind.Utc), "Sustainable Tourism in Protected Areas" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "categories",
                keyColumn: "Id",
                keyValue: 11);
        }
    }
}
