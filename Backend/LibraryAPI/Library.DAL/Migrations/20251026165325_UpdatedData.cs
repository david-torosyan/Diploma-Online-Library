using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://archive.org/details/streetofcrocodil00schu_0", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrhv8HOOGw56ABHammfAbunGUhTAi_F_2eQQ&s" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://www.scribd.com/doc/300749775/Prince-Charming", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1610568034i/55509539.jpg" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://archive.org/details/toxicbachelors0000dani", "https://archive.org/services/img/toxicbachelors0000dani" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://www.samizdat.qc.ca/arts/lit/PDFs/LionWitchWardrobe_CSL.pdf", "https://imgv2-2-f.scribdassets.com/img/document/432919347/original/c0ed155ebd/1?v=1" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://www.defence.lk/upload/ebooks/Alexander%20the%20Great.pdf", "https://online.flipbuilder.com/fdyv/lcvg/files/mobile/1.jpg?201020211740" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://archive.org/details/pocahontasspeopl0000roun", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNPK5irLXh4fL2zwTrziJM8ZMK-b_K0ZLMKw&s" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://www.eolss.net/sample-chapters/C04/E6-32-04-03.pdfs", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQo_RV5oIFgxcTAFME084XVW6DQEOMihwYgmQ&s" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://shron3.chtyvo.org.ua/Plokhii_Serhii/The_Gates_of_Europe__A_History_of_Ukraine_anhl.pdf", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRa3veMqYITcruRWDhinKwL1BbD3aSanEqF6Q&s" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78,
                column: "ImageURL",
                value: "https://m.media-amazon.com/images/I/51xa0kQZRFL.jpg");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://www.arvindguptatoys.com/arvindgupta/manplantedtrees.pdf", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHCJq1wVMlYTdTu7Fxa4Q0YhgHTnhr29Ik9g&s" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrhv8HOOGw56ABHammfAbunGUhTAi_F_2eQQ&s", "https://archive.org/details/streetofcrocodil00schu_0" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1610568034i/55509539.jpg", "https://www.scribd.com/doc/300749775/Prince-Charming" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://archive.org/services/img/toxicbachelors0000dani", "https://archive.org/details/toxicbachelors0000dani" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://imgv2-2-f.scribdassets.com/img/document/432919347/original/c0ed155ebd/1?v=1", "https://www.samizdat.qc.ca/arts/lit/PDFs/LionWitchWardrobe_CSL.pdf" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://online.flipbuilder.com/fdyv/lcvg/files/mobile/1.jpg?201020211740", "https://www.defence.lk/upload/ebooks/Alexander%20the%20Great.pdf" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNPK5irLXh4fL2zwTrziJM8ZMK-b_K0ZLMKw&s", "https://archive.org/details/pocahontasspeopl0000roun" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQo_RV5oIFgxcTAFME084XVW6DQEOMihwYgmQ&s", "https://www.eolss.net/sample-chapters/C04/E6-32-04-03.pdfs" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRa3veMqYITcruRWDhinKwL1BbD3aSanEqF6Q&s", "https://shron3.chtyvo.org.ua/Plokhii_Serhii/The_Gates_of_Europe__A_History_of_Ukraine_anhl.pdf" });

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78,
                column: "ImageURL",
                value: "https://i1.rgstatic.net/publication/270338813_Ulmann's_Encyclopedia_of_Industrial_Chemistry/links/54a7ebae0cf257a6360bda1b/largepreview.png");

            migrationBuilder.UpdateData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BookURL", "ImageURL" },
                values: new object[] { "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHCJq1wVMlYTdTu7Fxa4Q0YhgHTnhr29Ik9g&s", "https://www.arvindguptatoys.com/arvindgupta/manplantedtrees.pdf" });
        }
    }
}
