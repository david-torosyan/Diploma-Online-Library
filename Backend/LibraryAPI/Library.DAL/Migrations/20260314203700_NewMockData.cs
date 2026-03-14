using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class NewMockData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageURL",
                value: "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 96,
                column: "ImageURL",
                value: "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg");

            migrationBuilder.InsertData(
                table: "books",
                columns: new[] { "Id", "AuthorId", "BookURL", "CategoryId", "Description", "ISBN", "ImageURL", "IsApproved", "Pages", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1000, 1, "https://example.com/library/conservation-biology-for-all/1000", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001000", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 180, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 1 · Variant 1)" },
                    { 1001, 3, "https://example.com/library/conservation-biology-for-all/1001", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001001", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 187, new DateTime(1998, 2, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 1 · Variant 2)" },
                    { 1002, 5, "https://example.com/library/conservation-biology-for-all/1002", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001002", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 194, new DateTime(2001, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 1 · Variant 3)" },
                    { 1003, 3, "https://example.com/library/conservation-biology-for-all/1003", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001003", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 193, new DateTime(2006, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 2 · Variant 1)" },
                    { 1004, 5, "https://example.com/library/conservation-biology-for-all/1004", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001004", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 200, new DateTime(2009, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 2 · Variant 2)" },
                    { 1005, 6, "https://example.com/library/conservation-biology-for-all/1005", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001005", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 207, new DateTime(2012, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 2 · Variant 3)" },
                    { 1006, 5, "https://example.com/library/conservation-biology-for-all/1006", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001006", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 206, new DateTime(2017, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 3 · Variant 1)" },
                    { 1007, 6, "https://example.com/library/conservation-biology-for-all/1007", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001007", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 213, new DateTime(1995, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 3 · Variant 2)" },
                    { 1008, 12, "https://example.com/library/conservation-biology-for-all/1008", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001008", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 220, new DateTime(1998, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 3 · Variant 3)" },
                    { 1009, 6, "https://example.com/library/conservation-biology-for-all/1009", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001009", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 219, new DateTime(2003, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 4 · Variant 1)" },
                    { 1010, 12, "https://example.com/library/conservation-biology-for-all/1010", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001010", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 226, new DateTime(2006, 5, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 4 · Variant 2)" },
                    { 1011, 19, "https://example.com/library/conservation-biology-for-all/1011", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001011", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 233, new DateTime(2009, 6, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 4 · Variant 3)" },
                    { 1012, 12, "https://example.com/library/conservation-biology-for-all/1012", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001012", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 232, new DateTime(2014, 5, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 5 · Variant 1)" },
                    { 1013, 19, "https://example.com/library/conservation-biology-for-all/1013", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001013", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 239, new DateTime(2017, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 5 · Variant 2)" },
                    { 1014, 21, "https://example.com/library/conservation-biology-for-all/1014", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001014", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 246, new DateTime(1995, 7, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 5 · Variant 3)" },
                    { 1015, 19, "https://example.com/library/conservation-biology-for-all/1015", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001015", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 245, new DateTime(2000, 6, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 6 · Variant 1)" },
                    { 1016, 21, "https://example.com/library/conservation-biology-for-all/1016", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001016", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 252, new DateTime(2003, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 6 · Variant 2)" },
                    { 1017, 23, "https://example.com/library/conservation-biology-for-all/1017", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001017", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 259, new DateTime(2006, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 6 · Variant 3)" },
                    { 1018, 21, "https://example.com/library/conservation-biology-for-all/1018", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001018", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 258, new DateTime(2011, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 7 · Variant 1)" },
                    { 1019, 23, "https://example.com/library/conservation-biology-for-all/1019", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001019", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 265, new DateTime(2014, 8, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 7 · Variant 2)" },
                    { 1020, 33, "https://example.com/library/conservation-biology-for-all/1020", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001020", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 272, new DateTime(2017, 9, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 7 · Variant 3)" },
                    { 1021, 23, "https://example.com/library/conservation-biology-for-all/1021", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001021", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 271, new DateTime(1997, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 8 · Variant 1)" },
                    { 1022, 33, "https://example.com/library/conservation-biology-for-all/1022", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001022", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 278, new DateTime(2000, 9, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 8 · Variant 2)" },
                    { 1023, 40, "https://example.com/library/conservation-biology-for-all/1023", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001023", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 285, new DateTime(2003, 10, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 8 · Variant 3)" },
                    { 1024, 33, "https://example.com/library/conservation-biology-for-all/1024", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001024", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 284, new DateTime(2008, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 9 · Variant 1)" },
                    { 1025, 40, "https://example.com/library/conservation-biology-for-all/1025", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001025", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 291, new DateTime(2011, 10, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 9 · Variant 2)" },
                    { 1026, 47, "https://example.com/library/conservation-biology-for-all/1026", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001026", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 298, new DateTime(2014, 11, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 9 · Variant 3)" },
                    { 1027, 40, "https://example.com/library/conservation-biology-for-all/1027", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001027", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 297, new DateTime(2019, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 10 · Variant 1)" },
                    { 1028, 47, "https://example.com/library/conservation-biology-for-all/1028", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001028", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 304, new DateTime(1997, 11, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 10 · Variant 2)" },
                    { 1029, 54, "https://example.com/library/conservation-biology-for-all/1029", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001029", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 311, new DateTime(2000, 12, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 10 · Variant 3)" },
                    { 1030, 47, "https://example.com/library/conservation-biology-for-all/1030", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001030", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 310, new DateTime(2005, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 11 · Variant 1)" },
                    { 1031, 54, "https://example.com/library/conservation-biology-for-all/1031", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001031", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 317, new DateTime(2008, 12, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 11 · Variant 2)" },
                    { 1032, 60, "https://example.com/library/conservation-biology-for-all/1032", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001032", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 324, new DateTime(2011, 1, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Conservation Biology for All (Edition 11 · Variant 3)" },
                    { 1033, 3, "https://example.com/library/industrial-chocolate-manufacture-and-use/1033", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001033", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 191, new DateTime(2002, 2, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 2 · Variant 1)" },
                    { 1034, 5, "https://example.com/library/industrial-chocolate-manufacture-and-use/1034", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001034", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 198, new DateTime(2005, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 2 · Variant 2)" },
                    { 1035, 6, "https://example.com/library/industrial-chocolate-manufacture-and-use/1035", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001035", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 205, new DateTime(2008, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 2 · Variant 3)" },
                    { 1036, 5, "https://example.com/library/industrial-chocolate-manufacture-and-use/1036", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001036", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 204, new DateTime(2013, 3, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 3 · Variant 1)" },
                    { 1037, 6, "https://example.com/library/industrial-chocolate-manufacture-and-use/1037", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001037", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 211, new DateTime(2016, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 3 · Variant 2)" },
                    { 1038, 12, "https://example.com/library/industrial-chocolate-manufacture-and-use/1038", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001038", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 218, new DateTime(2019, 5, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 3 · Variant 3)" },
                    { 1039, 6, "https://example.com/library/industrial-chocolate-manufacture-and-use/1039", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001039", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 217, new DateTime(1999, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 4 · Variant 1)" },
                    { 1040, 12, "https://example.com/library/industrial-chocolate-manufacture-and-use/1040", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001040", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 224, new DateTime(2002, 5, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 4 · Variant 2)" },
                    { 1041, 19, "https://example.com/library/industrial-chocolate-manufacture-and-use/1041", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001041", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 231, new DateTime(2005, 6, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 4 · Variant 3)" },
                    { 1042, 12, "https://example.com/library/industrial-chocolate-manufacture-and-use/1042", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001042", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 230, new DateTime(2010, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 5 · Variant 1)" },
                    { 1043, 19, "https://example.com/library/industrial-chocolate-manufacture-and-use/1043", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001043", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 237, new DateTime(2013, 6, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 5 · Variant 2)" },
                    { 1044, 21, "https://example.com/library/industrial-chocolate-manufacture-and-use/1044", 9, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001044", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 244, new DateTime(2016, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 5 · Variant 3)" },
                    { 1045, 19, "https://example.com/library/industrial-chocolate-manufacture-and-use/1045", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001045", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 243, new DateTime(1996, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 6 · Variant 1)" },
                    { 1046, 21, "https://example.com/library/industrial-chocolate-manufacture-and-use/1046", 9, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001046", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 250, new DateTime(1999, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 6 · Variant 2)" },
                    { 1047, 23, "https://example.com/library/industrial-chocolate-manufacture-and-use/1047", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001047", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 257, new DateTime(2002, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 6 · Variant 3)" },
                    { 1048, 21, "https://example.com/library/industrial-chocolate-manufacture-and-use/1048", 9, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001048", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 256, new DateTime(2007, 7, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 7 · Variant 1)" },
                    { 1049, 23, "https://example.com/library/industrial-chocolate-manufacture-and-use/1049", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001049", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 263, new DateTime(2010, 8, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 7 · Variant 2)" },
                    { 1050, 33, "https://example.com/library/industrial-chocolate-manufacture-and-use/1050", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001050", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 270, new DateTime(2013, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 7 · Variant 3)" },
                    { 1051, 23, "https://example.com/library/industrial-chocolate-manufacture-and-use/1051", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001051", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 269, new DateTime(2018, 8, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 8 · Variant 1)" },
                    { 1052, 33, "https://example.com/library/industrial-chocolate-manufacture-and-use/1052", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001052", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 276, new DateTime(1996, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 8 · Variant 2)" },
                    { 1053, 40, "https://example.com/library/industrial-chocolate-manufacture-and-use/1053", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001053", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 283, new DateTime(1999, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 8 · Variant 3)" },
                    { 1054, 33, "https://example.com/library/industrial-chocolate-manufacture-and-use/1054", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001054", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 282, new DateTime(2004, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 9 · Variant 1)" },
                    { 1055, 40, "https://example.com/library/industrial-chocolate-manufacture-and-use/1055", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001055", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 289, new DateTime(2007, 10, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 9 · Variant 2)" },
                    { 1056, 47, "https://example.com/library/industrial-chocolate-manufacture-and-use/1056", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001056", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 296, new DateTime(2010, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 9 · Variant 3)" },
                    { 1057, 40, "https://example.com/library/industrial-chocolate-manufacture-and-use/1057", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001057", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 295, new DateTime(2015, 10, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 10 · Variant 1)" },
                    { 1058, 47, "https://example.com/library/industrial-chocolate-manufacture-and-use/1058", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001058", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 302, new DateTime(2018, 11, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 10 · Variant 2)" },
                    { 1059, 54, "https://example.com/library/industrial-chocolate-manufacture-and-use/1059", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001059", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 309, new DateTime(1996, 12, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 10 · Variant 3)" },
                    { 1060, 47, "https://example.com/library/industrial-chocolate-manufacture-and-use/1060", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001060", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 308, new DateTime(2001, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 11 · Variant 1)" },
                    { 1061, 54, "https://example.com/library/industrial-chocolate-manufacture-and-use/1061", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001061", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 315, new DateTime(2004, 12, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 11 · Variant 2)" },
                    { 1062, 60, "https://example.com/library/industrial-chocolate-manufacture-and-use/1062", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001062", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 322, new DateTime(2007, 1, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 11 · Variant 3)" },
                    { 1063, 54, "https://example.com/library/industrial-chocolate-manufacture-and-use/1063", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001063", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 321, new DateTime(2012, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 12 · Variant 1)" },
                    { 1064, 60, "https://example.com/library/industrial-chocolate-manufacture-and-use/1064", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001064", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 328, new DateTime(2015, 1, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 12 · Variant 2)" },
                    { 1065, 70, "https://example.com/library/industrial-chocolate-manufacture-and-use/1065", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001065", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 335, new DateTime(2018, 2, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Industrial Chocolate Manufacture and Use (Edition 12 · Variant 3)" },
                    { 1066, 5, "https://example.com/library/the-picture-of-dorian-gray/1066", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001066", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 202, new DateTime(2009, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 3 · Variant 1)" },
                    { 1067, 6, "https://example.com/library/the-picture-of-dorian-gray/1067", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001067", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 209, new DateTime(2012, 4, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 3 · Variant 2)" },
                    { 1068, 12, "https://example.com/library/the-picture-of-dorian-gray/1068", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001068", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 216, new DateTime(2015, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 3 · Variant 3)" },
                    { 1069, 6, "https://example.com/library/the-picture-of-dorian-gray/1069", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001069", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 215, new DateTime(1995, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 4 · Variant 1)" },
                    { 1070, 12, "https://example.com/library/the-picture-of-dorian-gray/1070", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001070", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 222, new DateTime(1998, 5, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 4 · Variant 2)" },
                    { 1071, 19, "https://example.com/library/the-picture-of-dorian-gray/1071", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001071", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 229, new DateTime(2001, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 4 · Variant 3)" },
                    { 1072, 12, "https://example.com/library/the-picture-of-dorian-gray/1072", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001072", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 228, new DateTime(2006, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 5 · Variant 1)" },
                    { 1073, 19, "https://example.com/library/the-picture-of-dorian-gray/1073", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001073", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 235, new DateTime(2009, 6, 19, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 5 · Variant 2)" },
                    { 1074, 21, "https://example.com/library/the-picture-of-dorian-gray/1074", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001074", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 242, new DateTime(2012, 7, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 5 · Variant 3)" },
                    { 1075, 19, "https://example.com/library/the-picture-of-dorian-gray/1075", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001075", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 241, new DateTime(2017, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 6 · Variant 1)" },
                    { 1076, 21, "https://example.com/library/the-picture-of-dorian-gray/1076", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001076", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 248, new DateTime(1995, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 6 · Variant 2)" },
                    { 1077, 23, "https://example.com/library/the-picture-of-dorian-gray/1077", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001077", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 255, new DateTime(1998, 8, 24, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 6 · Variant 3)" },
                    { 1078, 21, "https://example.com/library/the-picture-of-dorian-gray/1078", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001078", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 254, new DateTime(2003, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 7 · Variant 1)" },
                    { 1079, 23, "https://example.com/library/the-picture-of-dorian-gray/1079", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001079", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 261, new DateTime(2006, 8, 25, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 7 · Variant 2)" },
                    { 1080, 33, "https://example.com/library/the-picture-of-dorian-gray/1080", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001080", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 268, new DateTime(2009, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 7 · Variant 3)" },
                    { 1081, 23, "https://example.com/library/the-picture-of-dorian-gray/1081", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001081", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 267, new DateTime(2014, 8, 26, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 8 · Variant 1)" },
                    { 1082, 33, "https://example.com/library/the-picture-of-dorian-gray/1082", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001082", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 274, new DateTime(2017, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 8 · Variant 2)" },
                    { 1083, 40, "https://example.com/library/the-picture-of-dorian-gray/1083", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001083", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 281, new DateTime(1995, 10, 3, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 8 · Variant 3)" },
                    { 1084, 33, "https://example.com/library/the-picture-of-dorian-gray/1084", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001084", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 280, new DateTime(2000, 9, 2, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 9 · Variant 1)" },
                    { 1085, 40, "https://example.com/library/the-picture-of-dorian-gray/1085", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001085", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 287, new DateTime(2003, 10, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 9 · Variant 2)" },
                    { 1086, 47, "https://example.com/library/the-picture-of-dorian-gray/1086", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001086", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 294, new DateTime(2006, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 9 · Variant 3)" },
                    { 1087, 40, "https://example.com/library/the-picture-of-dorian-gray/1087", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001087", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 293, new DateTime(2011, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 10 · Variant 1)" },
                    { 1088, 47, "https://example.com/library/the-picture-of-dorian-gray/1088", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001088", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 300, new DateTime(2014, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 10 · Variant 2)" },
                    { 1089, 54, "https://example.com/library/the-picture-of-dorian-gray/1089", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001089", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 307, new DateTime(2017, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 10 · Variant 3)" },
                    { 1090, 47, "https://example.com/library/the-picture-of-dorian-gray/1090", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001090", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 306, new DateTime(1997, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 11 · Variant 1)" },
                    { 1091, 54, "https://example.com/library/the-picture-of-dorian-gray/1091", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001091", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 313, new DateTime(2000, 12, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 11 · Variant 2)" },
                    { 1092, 60, "https://example.com/library/the-picture-of-dorian-gray/1092", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001092", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 320, new DateTime(2003, 1, 12, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 11 · Variant 3)" },
                    { 1093, 54, "https://example.com/library/the-picture-of-dorian-gray/1093", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001093", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 319, new DateTime(2008, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 12 · Variant 1)" },
                    { 1094, 60, "https://example.com/library/the-picture-of-dorian-gray/1094", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001094", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 326, new DateTime(2011, 1, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 12 · Variant 2)" },
                    { 1095, 70, "https://example.com/library/the-picture-of-dorian-gray/1095", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001095", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 333, new DateTime(2014, 2, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 12 · Variant 3)" },
                    { 1096, 60, "https://example.com/library/the-picture-of-dorian-gray/1096", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001096", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 332, new DateTime(2019, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 13 · Variant 1)" },
                    { 1097, 70, "https://example.com/library/the-picture-of-dorian-gray/1097", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001097", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 339, new DateTime(1997, 2, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 13 · Variant 2)" },
                    { 1098, 83, "https://example.com/library/the-picture-of-dorian-gray/1098", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001098", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 346, new DateTime(2000, 3, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Picture of Dorian Gray (Edition 13 · Variant 3)" },
                    { 1099, 6, "https://example.com/library/frankenstein/1099", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001099", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 213, new DateTime(2016, 4, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 4 · Variant 1)" },
                    { 1100, 12, "https://example.com/library/frankenstein/1100", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001100", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 220, new DateTime(2019, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 4 · Variant 2)" },
                    { 1101, 19, "https://example.com/library/frankenstein/1101", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001101", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 227, new DateTime(1997, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 4 · Variant 3)" },
                    { 1102, 12, "https://example.com/library/frankenstein/1102", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001102", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 226, new DateTime(2002, 5, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 5 · Variant 1)" },
                    { 1103, 19, "https://example.com/library/frankenstein/1103", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001103", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 233, new DateTime(2005, 6, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 5 · Variant 2)" },
                    { 1104, 21, "https://example.com/library/frankenstein/1104", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001104", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 240, new DateTime(2008, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 5 · Variant 3)" },
                    { 1105, 19, "https://example.com/library/frankenstein/1105", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001105", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 239, new DateTime(2013, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 6 · Variant 1)" },
                    { 1106, 21, "https://example.com/library/frankenstein/1106", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001106", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 246, new DateTime(2016, 7, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 6 · Variant 2)" },
                    { 1107, 23, "https://example.com/library/frankenstein/1107", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001107", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 253, new DateTime(2019, 8, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 6 · Variant 3)" },
                    { 1108, 21, "https://example.com/library/frankenstein/1108", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001108", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 252, new DateTime(1999, 7, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 7 · Variant 1)" },
                    { 1109, 23, "https://example.com/library/frankenstein/1109", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001109", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 259, new DateTime(2002, 8, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 7 · Variant 2)" },
                    { 1110, 33, "https://example.com/library/frankenstein/1110", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001110", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 266, new DateTime(2005, 9, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 7 · Variant 3)" },
                    { 1111, 23, "https://example.com/library/frankenstein/1111", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001111", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 265, new DateTime(2010, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 8 · Variant 1)" },
                    { 1112, 33, "https://example.com/library/frankenstein/1112", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001112", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 272, new DateTime(2013, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 8 · Variant 2)" },
                    { 1113, 40, "https://example.com/library/frankenstein/1113", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001113", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 279, new DateTime(2016, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 8 · Variant 3)" },
                    { 1114, 33, "https://example.com/library/frankenstein/1114", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001114", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 278, new DateTime(1996, 9, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 9 · Variant 1)" },
                    { 1115, 40, "https://example.com/library/frankenstein/1115", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001115", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 285, new DateTime(1999, 10, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 9 · Variant 2)" },
                    { 1116, 47, "https://example.com/library/frankenstein/1116", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001116", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 292, new DateTime(2002, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 9 · Variant 3)" },
                    { 1117, 40, "https://example.com/library/frankenstein/1117", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001117", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 291, new DateTime(2007, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 10 · Variant 1)" },
                    { 1118, 47, "https://example.com/library/frankenstein/1118", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001118", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 298, new DateTime(2010, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 10 · Variant 2)" },
                    { 1119, 54, "https://example.com/library/frankenstein/1119", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001119", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 305, new DateTime(2013, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 10 · Variant 3)" },
                    { 1120, 47, "https://example.com/library/frankenstein/1120", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001120", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 304, new DateTime(2018, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 11 · Variant 1)" },
                    { 1121, 54, "https://example.com/library/frankenstein/1121", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001121", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 311, new DateTime(1996, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 11 · Variant 2)" },
                    { 1122, 60, "https://example.com/library/frankenstein/1122", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001122", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 318, new DateTime(1999, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 11 · Variant 3)" },
                    { 1123, 54, "https://example.com/library/frankenstein/1123", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001123", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 317, new DateTime(2004, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 12 · Variant 1)" },
                    { 1124, 60, "https://example.com/library/frankenstein/1124", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001124", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 324, new DateTime(2007, 1, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 12 · Variant 2)" },
                    { 1125, 70, "https://example.com/library/frankenstein/1125", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001125", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 331, new DateTime(2010, 2, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 12 · Variant 3)" },
                    { 1126, 60, "https://example.com/library/frankenstein/1126", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001126", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 330, new DateTime(2015, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 13 · Variant 1)" },
                    { 1127, 70, "https://example.com/library/frankenstein/1127", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001127", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 337, new DateTime(2018, 2, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 13 · Variant 2)" },
                    { 1128, 83, "https://example.com/library/frankenstein/1128", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001128", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 344, new DateTime(1996, 3, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 13 · Variant 3)" },
                    { 1129, 70, "https://example.com/library/frankenstein/1129", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001129", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 343, new DateTime(2001, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 14 · Variant 1)" },
                    { 1130, 83, "https://example.com/library/frankenstein/1130", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001130", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 350, new DateTime(2004, 3, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 14 · Variant 2)" },
                    { 1131, 90, "https://example.com/library/frankenstein/1131", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001131", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 357, new DateTime(2007, 4, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Frankenstein (Edition 14 · Variant 3)" },
                    { 1132, 12, "https://example.com/library/mrs.-dalloway/1132", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001132", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 224, new DateTime(1998, 5, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 5 · Variant 1)" },
                    { 1133, 19, "https://example.com/library/mrs.-dalloway/1133", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001133", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 231, new DateTime(2001, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 5 · Variant 2)" },
                    { 1134, 21, "https://example.com/library/mrs.-dalloway/1134", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001134", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 238, new DateTime(2004, 7, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 5 · Variant 3)" },
                    { 1135, 19, "https://example.com/library/mrs.-dalloway/1135", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001135", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 237, new DateTime(2009, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 6 · Variant 1)" },
                    { 1136, 21, "https://example.com/library/mrs.-dalloway/1136", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001136", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 244, new DateTime(2012, 7, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 6 · Variant 2)" },
                    { 1137, 23, "https://example.com/library/mrs.-dalloway/1137", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001137", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 251, new DateTime(2015, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 6 · Variant 3)" },
                    { 1138, 21, "https://example.com/library/mrs.-dalloway/1138", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001138", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 250, new DateTime(1995, 7, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 7 · Variant 1)" },
                    { 1139, 23, "https://example.com/library/mrs.-dalloway/1139", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001139", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 257, new DateTime(1998, 8, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 7 · Variant 2)" },
                    { 1140, 33, "https://example.com/library/mrs.-dalloway/1140", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001140", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 264, new DateTime(2001, 9, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 7 · Variant 3)" },
                    { 1141, 23, "https://example.com/library/mrs.-dalloway/1141", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001141", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 263, new DateTime(2006, 8, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 8 · Variant 1)" },
                    { 1142, 33, "https://example.com/library/mrs.-dalloway/1142", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001142", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 270, new DateTime(2009, 9, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 8 · Variant 2)" },
                    { 1143, 40, "https://example.com/library/mrs.-dalloway/1143", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001143", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 277, new DateTime(2012, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 8 · Variant 3)" },
                    { 1144, 33, "https://example.com/library/mrs.-dalloway/1144", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001144", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 276, new DateTime(2017, 9, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 9 · Variant 1)" },
                    { 1145, 40, "https://example.com/library/mrs.-dalloway/1145", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001145", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 283, new DateTime(1995, 10, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 9 · Variant 2)" },
                    { 1146, 47, "https://example.com/library/mrs.-dalloway/1146", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001146", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 290, new DateTime(1998, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 9 · Variant 3)" },
                    { 1147, 40, "https://example.com/library/mrs.-dalloway/1147", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001147", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 289, new DateTime(2003, 10, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 10 · Variant 1)" },
                    { 1148, 47, "https://example.com/library/mrs.-dalloway/1148", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001148", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 296, new DateTime(2006, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 10 · Variant 2)" },
                    { 1149, 54, "https://example.com/library/mrs.-dalloway/1149", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001149", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 303, new DateTime(2009, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 10 · Variant 3)" },
                    { 1150, 47, "https://example.com/library/mrs.-dalloway/1150", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001150", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 302, new DateTime(2014, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 11 · Variant 1)" },
                    { 1151, 54, "https://example.com/library/mrs.-dalloway/1151", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001151", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 309, new DateTime(2017, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 11 · Variant 2)" },
                    { 1152, 60, "https://example.com/library/mrs.-dalloway/1152", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001152", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 316, new DateTime(1995, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 11 · Variant 3)" },
                    { 1153, 54, "https://example.com/library/mrs.-dalloway/1153", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001153", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 315, new DateTime(2000, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 12 · Variant 1)" },
                    { 1154, 60, "https://example.com/library/mrs.-dalloway/1154", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001154", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 322, new DateTime(2003, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 12 · Variant 2)" },
                    { 1155, 70, "https://example.com/library/mrs.-dalloway/1155", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001155", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 329, new DateTime(2006, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 12 · Variant 3)" },
                    { 1156, 60, "https://example.com/library/mrs.-dalloway/1156", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001156", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 328, new DateTime(2011, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 13 · Variant 1)" },
                    { 1157, 70, "https://example.com/library/mrs.-dalloway/1157", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001157", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 335, new DateTime(2014, 2, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 13 · Variant 2)" },
                    { 1158, 83, "https://example.com/library/mrs.-dalloway/1158", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001158", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 342, new DateTime(2017, 3, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 13 · Variant 3)" },
                    { 1159, 70, "https://example.com/library/mrs.-dalloway/1159", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001159", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 341, new DateTime(1997, 2, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 14 · Variant 1)" },
                    { 1160, 83, "https://example.com/library/mrs.-dalloway/1160", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001160", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 348, new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 14 · Variant 2)" },
                    { 1161, 90, "https://example.com/library/mrs.-dalloway/1161", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001161", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 355, new DateTime(2003, 4, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 14 · Variant 3)" },
                    { 1162, 83, "https://example.com/library/mrs.-dalloway/1162", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001162", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 354, new DateTime(2008, 3, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 15 · Variant 1)" },
                    { 1163, 90, "https://example.com/library/mrs.-dalloway/1163", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001163", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 361, new DateTime(2011, 4, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 15 · Variant 2)" },
                    { 1164, 1, "https://example.com/library/mrs.-dalloway/1164", 3, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001164", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 368, new DateTime(2014, 5, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Mrs. Dalloway (Edition 15 · Variant 3)" },
                    { 1165, 19, "https://example.com/library/the-wizard-of-oz/1165", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001165", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 235, new DateTime(2005, 6, 26, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 6 · Variant 1)" },
                    { 1166, 21, "https://example.com/library/the-wizard-of-oz/1166", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001166", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 242, new DateTime(2008, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 6 · Variant 2)" },
                    { 1167, 23, "https://example.com/library/the-wizard-of-oz/1167", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001167", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 249, new DateTime(2011, 8, 3, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 6 · Variant 3)" },
                    { 1168, 21, "https://example.com/library/the-wizard-of-oz/1168", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001168", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 248, new DateTime(2016, 7, 2, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 7 · Variant 1)" },
                    { 1169, 23, "https://example.com/library/the-wizard-of-oz/1169", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001169", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 255, new DateTime(2019, 8, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 7 · Variant 2)" },
                    { 1170, 33, "https://example.com/library/the-wizard-of-oz/1170", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001170", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 262, new DateTime(1997, 9, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 7 · Variant 3)" },
                    { 1171, 23, "https://example.com/library/the-wizard-of-oz/1171", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001171", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 261, new DateTime(2002, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 8 · Variant 1)" },
                    { 1172, 33, "https://example.com/library/the-wizard-of-oz/1172", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001172", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 268, new DateTime(2005, 9, 7, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 8 · Variant 2)" },
                    { 1173, 40, "https://example.com/library/the-wizard-of-oz/1173", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001173", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 275, new DateTime(2008, 10, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 8 · Variant 3)" },
                    { 1174, 33, "https://example.com/library/the-wizard-of-oz/1174", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001174", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 274, new DateTime(2013, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 9 · Variant 1)" },
                    { 1175, 40, "https://example.com/library/the-wizard-of-oz/1175", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001175", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 281, new DateTime(2016, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 9 · Variant 2)" },
                    { 1176, 47, "https://example.com/library/the-wizard-of-oz/1176", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001176", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 288, new DateTime(2019, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 9 · Variant 3)" },
                    { 1177, 40, "https://example.com/library/the-wizard-of-oz/1177", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001177", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 287, new DateTime(1999, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 10 · Variant 1)" },
                    { 1178, 47, "https://example.com/library/the-wizard-of-oz/1178", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001178", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 294, new DateTime(2002, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 10 · Variant 2)" },
                    { 1179, 54, "https://example.com/library/the-wizard-of-oz/1179", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001179", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 301, new DateTime(2005, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 10 · Variant 3)" },
                    { 1180, 47, "https://example.com/library/the-wizard-of-oz/1180", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001180", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 300, new DateTime(2010, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 11 · Variant 1)" },
                    { 1181, 54, "https://example.com/library/the-wizard-of-oz/1181", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001181", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 307, new DateTime(2013, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 11 · Variant 2)" },
                    { 1182, 60, "https://example.com/library/the-wizard-of-oz/1182", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001182", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 314, new DateTime(2016, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 11 · Variant 3)" },
                    { 1183, 54, "https://example.com/library/the-wizard-of-oz/1183", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001183", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 313, new DateTime(1996, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 12 · Variant 1)" },
                    { 1184, 60, "https://example.com/library/the-wizard-of-oz/1184", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001184", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 320, new DateTime(1999, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 12 · Variant 2)" },
                    { 1185, 70, "https://example.com/library/the-wizard-of-oz/1185", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001185", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 327, new DateTime(2002, 2, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 12 · Variant 3)" },
                    { 1186, 60, "https://example.com/library/the-wizard-of-oz/1186", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001186", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 326, new DateTime(2007, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 13 · Variant 1)" },
                    { 1187, 70, "https://example.com/library/the-wizard-of-oz/1187", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001187", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 333, new DateTime(2010, 2, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 13 · Variant 2)" },
                    { 1188, 83, "https://example.com/library/the-wizard-of-oz/1188", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001188", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 340, new DateTime(2013, 3, 24, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 13 · Variant 3)" },
                    { 1189, 70, "https://example.com/library/the-wizard-of-oz/1189", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001189", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 339, new DateTime(2018, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 14 · Variant 1)" },
                    { 1190, 83, "https://example.com/library/the-wizard-of-oz/1190", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001190", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 346, new DateTime(1996, 3, 25, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 14 · Variant 2)" },
                    { 1191, 90, "https://example.com/library/the-wizard-of-oz/1191", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001191", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 353, new DateTime(1999, 4, 27, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 14 · Variant 3)" },
                    { 1192, 83, "https://example.com/library/the-wizard-of-oz/1192", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001192", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 352, new DateTime(2004, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 15 · Variant 1)" },
                    { 1193, 90, "https://example.com/library/the-wizard-of-oz/1193", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001193", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 359, new DateTime(2007, 4, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 15 · Variant 2)" },
                    { 1194, 1, "https://example.com/library/the-wizard-of-oz/1194", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001194", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 366, new DateTime(2010, 5, 3, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 15 · Variant 3)" },
                    { 1195, 90, "https://example.com/library/the-wizard-of-oz/1195", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001195", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 365, new DateTime(2015, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 16 · Variant 1)" },
                    { 1196, 1, "https://example.com/library/the-wizard-of-oz/1196", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001196", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 372, new DateTime(2018, 5, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 16 · Variant 2)" },
                    { 1197, 3, "https://example.com/library/the-wizard-of-oz/1197", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001197", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 379, new DateTime(1996, 6, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Wizard of Oz (Edition 16 · Variant 3)" },
                    { 1198, 21, "https://example.com/library/the-lord-of-the-rings/1198", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001198", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 246, new DateTime(2012, 7, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 7 · Variant 1)" },
                    { 1199, 23, "https://example.com/library/the-lord-of-the-rings/1199", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001199", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 253, new DateTime(2015, 8, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 7 · Variant 2)" },
                    { 1200, 33, "https://example.com/library/the-lord-of-the-rings/1200", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001200", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 260, new DateTime(2018, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 7 · Variant 3)" },
                    { 1201, 23, "https://example.com/library/the-lord-of-the-rings/1201", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001201", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 259, new DateTime(1998, 8, 7, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 8 · Variant 1)" },
                    { 1202, 33, "https://example.com/library/the-lord-of-the-rings/1202", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001202", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 266, new DateTime(2001, 9, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 8 · Variant 2)" },
                    { 1203, 40, "https://example.com/library/the-lord-of-the-rings/1203", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001203", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 273, new DateTime(2004, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 8 · Variant 3)" },
                    { 1204, 33, "https://example.com/library/the-lord-of-the-rings/1204", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001204", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 272, new DateTime(2009, 9, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 9 · Variant 1)" },
                    { 1205, 40, "https://example.com/library/the-lord-of-the-rings/1205", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001205", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 279, new DateTime(2012, 10, 12, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 9 · Variant 2)" },
                    { 1206, 47, "https://example.com/library/the-lord-of-the-rings/1206", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001206", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 286, new DateTime(2015, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 9 · Variant 3)" },
                    { 1207, 40, "https://example.com/library/the-lord-of-the-rings/1207", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001207", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 285, new DateTime(1995, 10, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 10 · Variant 1)" },
                    { 1208, 47, "https://example.com/library/the-lord-of-the-rings/1208", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001208", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 292, new DateTime(1998, 11, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 10 · Variant 2)" },
                    { 1209, 54, "https://example.com/library/the-lord-of-the-rings/1209", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001209", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 299, new DateTime(2001, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 10 · Variant 3)" },
                    { 1210, 47, "https://example.com/library/the-lord-of-the-rings/1210", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001210", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 298, new DateTime(2006, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 11 · Variant 1)" },
                    { 1211, 54, "https://example.com/library/the-lord-of-the-rings/1211", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001211", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 305, new DateTime(2009, 12, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 11 · Variant 2)" },
                    { 1212, 60, "https://example.com/library/the-lord-of-the-rings/1212", 3, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001212", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 312, new DateTime(2012, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 11 · Variant 3)" },
                    { 1213, 54, "https://example.com/library/the-lord-of-the-rings/1213", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001213", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 311, new DateTime(2017, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 12 · Variant 1)" },
                    { 1214, 60, "https://example.com/library/the-lord-of-the-rings/1214", 3, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001214", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 318, new DateTime(1995, 1, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 12 · Variant 2)" },
                    { 1215, 70, "https://example.com/library/the-lord-of-the-rings/1215", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001215", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 325, new DateTime(1998, 2, 23, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 12 · Variant 3)" },
                    { 1216, 60, "https://example.com/library/the-lord-of-the-rings/1216", 3, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001216", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 324, new DateTime(2003, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 13 · Variant 1)" },
                    { 1217, 70, "https://example.com/library/the-lord-of-the-rings/1217", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001217", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 331, new DateTime(2006, 2, 24, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 13 · Variant 2)" },
                    { 1218, 83, "https://example.com/library/the-lord-of-the-rings/1218", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001218", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 338, new DateTime(2009, 3, 26, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 13 · Variant 3)" },
                    { 1219, 70, "https://example.com/library/the-lord-of-the-rings/1219", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001219", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 337, new DateTime(2014, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 14 · Variant 1)" },
                    { 1220, 83, "https://example.com/library/the-lord-of-the-rings/1220", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001220", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 344, new DateTime(2017, 3, 27, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 14 · Variant 2)" },
                    { 1221, 90, "https://example.com/library/the-lord-of-the-rings/1221", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001221", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 351, new DateTime(1995, 4, 2, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 14 · Variant 3)" },
                    { 1222, 83, "https://example.com/library/the-lord-of-the-rings/1222", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001222", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 350, new DateTime(2000, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 15 · Variant 1)" },
                    { 1223, 90, "https://example.com/library/the-lord-of-the-rings/1223", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001223", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 357, new DateTime(2003, 4, 3, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 15 · Variant 2)" },
                    { 1224, 1, "https://example.com/library/the-lord-of-the-rings/1224", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001224", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 364, new DateTime(2006, 5, 5, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 15 · Variant 3)" },
                    { 1225, 90, "https://example.com/library/the-lord-of-the-rings/1225", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001225", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 363, new DateTime(2011, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 16 · Variant 1)" },
                    { 1226, 1, "https://example.com/library/the-lord-of-the-rings/1226", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001226", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 370, new DateTime(2014, 5, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 16 · Variant 2)" },
                    { 1227, 3, "https://example.com/library/the-lord-of-the-rings/1227", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001227", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 377, new DateTime(2017, 6, 8, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 16 · Variant 3)" },
                    { 1228, 1, "https://example.com/library/the-lord-of-the-rings/1228", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001228", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 376, new DateTime(1997, 5, 7, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 17 · Variant 1)" },
                    { 1229, 3, "https://example.com/library/the-lord-of-the-rings/1229", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001229", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 383, new DateTime(2000, 6, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 17 · Variant 2)" },
                    { 1230, 5, "https://example.com/library/the-lord-of-the-rings/1230", 9, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001230", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 390, new DateTime(2003, 7, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The Lord of the Rings (Edition 17 · Variant 3)" },
                    { 1231, 23, "https://example.com/library/the-da-vinci-code/1231", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001231", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 257, new DateTime(2019, 8, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 8 · Variant 1)" },
                    { 1232, 33, "https://example.com/library/the-da-vinci-code/1232", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001232", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 264, new DateTime(1997, 9, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 8 · Variant 2)" },
                    { 1233, 40, "https://example.com/library/the-da-vinci-code/1233", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001233", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 271, new DateTime(2000, 10, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 8 · Variant 3)" },
                    { 1234, 33, "https://example.com/library/the-da-vinci-code/1234", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001234", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 270, new DateTime(2005, 9, 12, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 9 · Variant 1)" },
                    { 1235, 40, "https://example.com/library/the-da-vinci-code/1235", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001235", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 277, new DateTime(2008, 10, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 9 · Variant 2)" },
                    { 1236, 47, "https://example.com/library/the-da-vinci-code/1236", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001236", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 284, new DateTime(2011, 11, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 9 · Variant 3)" },
                    { 1237, 40, "https://example.com/library/the-da-vinci-code/1237", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001237", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 283, new DateTime(2016, 10, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 10 · Variant 1)" },
                    { 1238, 47, "https://example.com/library/the-da-vinci-code/1238", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001238", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 290, new DateTime(2019, 11, 17, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 10 · Variant 2)" },
                    { 1239, 54, "https://example.com/library/the-da-vinci-code/1239", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001239", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 297, new DateTime(1997, 12, 19, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 10 · Variant 3)" },
                    { 1240, 47, "https://example.com/library/the-da-vinci-code/1240", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001240", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 296, new DateTime(2002, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 11 · Variant 1)" },
                    { 1241, 54, "https://example.com/library/the-da-vinci-code/1241", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001241", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 303, new DateTime(2005, 12, 20, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 11 · Variant 2)" },
                    { 1242, 60, "https://example.com/library/the-da-vinci-code/1242", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001242", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 310, new DateTime(2008, 1, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 11 · Variant 3)" },
                    { 1243, 54, "https://example.com/library/the-da-vinci-code/1243", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001243", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 309, new DateTime(2013, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 12 · Variant 1)" },
                    { 1244, 60, "https://example.com/library/the-da-vinci-code/1244", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001244", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 316, new DateTime(2016, 1, 23, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 12 · Variant 2)" },
                    { 1245, 70, "https://example.com/library/the-da-vinci-code/1245", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001245", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 323, new DateTime(2019, 2, 25, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 12 · Variant 3)" },
                    { 1246, 60, "https://example.com/library/the-da-vinci-code/1246", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001246", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 322, new DateTime(1999, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 13 · Variant 1)" },
                    { 1247, 70, "https://example.com/library/the-da-vinci-code/1247", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001247", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 329, new DateTime(2002, 2, 26, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 13 · Variant 2)" },
                    { 1248, 83, "https://example.com/library/the-da-vinci-code/1248", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001248", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 336, new DateTime(2005, 3, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 13 · Variant 3)" },
                    { 1249, 70, "https://example.com/library/the-da-vinci-code/1249", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001249", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 335, new DateTime(2010, 2, 27, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 14 · Variant 1)" },
                    { 1250, 83, "https://example.com/library/the-da-vinci-code/1250", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001250", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 342, new DateTime(2013, 3, 2, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 14 · Variant 2)" },
                    { 1251, 90, "https://example.com/library/the-da-vinci-code/1251", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001251", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 349, new DateTime(2016, 4, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 14 · Variant 3)" },
                    { 1252, 83, "https://example.com/library/the-da-vinci-code/1252", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001252", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 348, new DateTime(1996, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 15 · Variant 1)" },
                    { 1253, 90, "https://example.com/library/the-da-vinci-code/1253", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001253", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 355, new DateTime(1999, 4, 5, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 15 · Variant 2)" },
                    { 1254, 1, "https://example.com/library/the-da-vinci-code/1254", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001254", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 362, new DateTime(2002, 5, 7, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 15 · Variant 3)" },
                    { 1255, 90, "https://example.com/library/the-da-vinci-code/1255", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001255", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 361, new DateTime(2007, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 16 · Variant 1)" },
                    { 1256, 1, "https://example.com/library/the-da-vinci-code/1256", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001256", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 368, new DateTime(2010, 5, 8, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 16 · Variant 2)" },
                    { 1257, 3, "https://example.com/library/the-da-vinci-code/1257", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001257", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 375, new DateTime(2013, 6, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 16 · Variant 3)" },
                    { 1258, 1, "https://example.com/library/the-da-vinci-code/1258", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001258", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 374, new DateTime(2018, 5, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 17 · Variant 1)" },
                    { 1259, 3, "https://example.com/library/the-da-vinci-code/1259", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001259", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 381, new DateTime(1996, 6, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 17 · Variant 2)" },
                    { 1260, 5, "https://example.com/library/the-da-vinci-code/1260", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001260", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 388, new DateTime(1999, 7, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 17 · Variant 3)" },
                    { 1261, 3, "https://example.com/library/the-da-vinci-code/1261", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001261", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 387, new DateTime(2004, 6, 12, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 18 · Variant 1)" },
                    { 1262, 5, "https://example.com/library/the-da-vinci-code/1262", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001262", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 394, new DateTime(2007, 7, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 18 · Variant 2)" },
                    { 1263, 6, "https://example.com/library/the-da-vinci-code/1263", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001263", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 401, new DateTime(2010, 8, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Da Vinci Code (Edition 18 · Variant 3)" },
                    { 1264, 33, "https://example.com/library/crime-and-punishment/1264", 3, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001264", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 268, new DateTime(2001, 9, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 9 · Variant 1)" },
                    { 1265, 40, "https://example.com/library/crime-and-punishment/1265", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001265", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 275, new DateTime(2004, 10, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 9 · Variant 2)" },
                    { 1266, 47, "https://example.com/library/crime-and-punishment/1266", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001266", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 282, new DateTime(2007, 11, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 9 · Variant 3)" },
                    { 1267, 40, "https://example.com/library/crime-and-punishment/1267", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001267", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 281, new DateTime(2012, 10, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 10 · Variant 1)" },
                    { 1268, 47, "https://example.com/library/crime-and-punishment/1268", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001268", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 288, new DateTime(2015, 11, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 10 · Variant 2)" },
                    { 1269, 54, "https://example.com/library/crime-and-punishment/1269", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001269", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 295, new DateTime(2018, 12, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 10 · Variant 3)" },
                    { 1270, 47, "https://example.com/library/crime-and-punishment/1270", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001270", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 294, new DateTime(1998, 11, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 11 · Variant 1)" },
                    { 1271, 54, "https://example.com/library/crime-and-punishment/1271", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001271", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 301, new DateTime(2001, 12, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 11 · Variant 2)" },
                    { 1272, 60, "https://example.com/library/crime-and-punishment/1272", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001272", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 308, new DateTime(2004, 1, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 11 · Variant 3)" },
                    { 1273, 54, "https://example.com/library/crime-and-punishment/1273", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001273", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 307, new DateTime(2009, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 12 · Variant 1)" },
                    { 1274, 60, "https://example.com/library/crime-and-punishment/1274", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001274", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 314, new DateTime(2012, 1, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 12 · Variant 2)" },
                    { 1275, 70, "https://example.com/library/crime-and-punishment/1275", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001275", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 321, new DateTime(2015, 2, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 12 · Variant 3)" },
                    { 1276, 60, "https://example.com/library/crime-and-punishment/1276", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001276", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 320, new DateTime(1995, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 13 · Variant 1)" },
                    { 1277, 70, "https://example.com/library/crime-and-punishment/1277", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001277", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 327, new DateTime(1998, 2, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 13 · Variant 2)" },
                    { 1278, 83, "https://example.com/library/crime-and-punishment/1278", 9, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001278", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 334, new DateTime(2001, 3, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 13 · Variant 3)" },
                    { 1279, 70, "https://example.com/library/crime-and-punishment/1279", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001279", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 333, new DateTime(2006, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 14 · Variant 1)" },
                    { 1280, 83, "https://example.com/library/crime-and-punishment/1280", 9, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001280", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 340, new DateTime(2009, 3, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 14 · Variant 2)" },
                    { 1281, 90, "https://example.com/library/crime-and-punishment/1281", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001281", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 347, new DateTime(2012, 4, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 14 · Variant 3)" },
                    { 1282, 83, "https://example.com/library/crime-and-punishment/1282", 9, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001282", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 346, new DateTime(2017, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 15 · Variant 1)" },
                    { 1283, 90, "https://example.com/library/crime-and-punishment/1283", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001283", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 353, new DateTime(1995, 4, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 15 · Variant 2)" },
                    { 1284, 1, "https://example.com/library/crime-and-punishment/1284", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001284", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 360, new DateTime(1998, 5, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 15 · Variant 3)" },
                    { 1285, 90, "https://example.com/library/crime-and-punishment/1285", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001285", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 359, new DateTime(2003, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 16 · Variant 1)" },
                    { 1286, 1, "https://example.com/library/crime-and-punishment/1286", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001286", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 366, new DateTime(2006, 5, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 16 · Variant 2)" },
                    { 1287, 3, "https://example.com/library/crime-and-punishment/1287", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001287", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 373, new DateTime(2009, 6, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 16 · Variant 3)" },
                    { 1288, 1, "https://example.com/library/crime-and-punishment/1288", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001288", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 372, new DateTime(2014, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 17 · Variant 1)" },
                    { 1289, 3, "https://example.com/library/crime-and-punishment/1289", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001289", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 379, new DateTime(2017, 6, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 17 · Variant 2)" },
                    { 1290, 5, "https://example.com/library/crime-and-punishment/1290", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001290", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 386, new DateTime(1995, 7, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 17 · Variant 3)" },
                    { 1291, 3, "https://example.com/library/crime-and-punishment/1291", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001291", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 385, new DateTime(2000, 6, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 18 · Variant 1)" },
                    { 1292, 5, "https://example.com/library/crime-and-punishment/1292", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001292", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 392, new DateTime(2003, 7, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 18 · Variant 2)" },
                    { 1293, 6, "https://example.com/library/crime-and-punishment/1293", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001293", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 399, new DateTime(2006, 8, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 18 · Variant 3)" },
                    { 1294, 5, "https://example.com/library/crime-and-punishment/1294", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001294", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 398, new DateTime(2011, 7, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 19 · Variant 1)" },
                    { 1295, 6, "https://example.com/library/crime-and-punishment/1295", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001295", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 405, new DateTime(2014, 8, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 19 · Variant 2)" },
                    { 1296, 12, "https://example.com/library/crime-and-punishment/1296", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001296", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 412, new DateTime(2017, 9, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Crime and Punishment (Edition 19 · Variant 3)" },
                    { 1297, 40, "https://example.com/library/eat-pray-love/1297", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001297", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 279, new DateTime(2008, 10, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 10 · Variant 1)" },
                    { 1298, 47, "https://example.com/library/eat-pray-love/1298", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001298", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 286, new DateTime(2011, 11, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 10 · Variant 2)" },
                    { 1299, 54, "https://example.com/library/eat-pray-love/1299", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001299", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 293, new DateTime(2014, 12, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 10 · Variant 3)" },
                    { 1300, 47, "https://example.com/library/eat-pray-love/1300", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001300", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 292, new DateTime(2019, 11, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 11 · Variant 1)" },
                    { 1301, 54, "https://example.com/library/eat-pray-love/1301", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001301", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 299, new DateTime(1997, 12, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 11 · Variant 2)" },
                    { 1302, 60, "https://example.com/library/eat-pray-love/1302", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001302", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 306, new DateTime(2000, 1, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 11 · Variant 3)" },
                    { 1303, 54, "https://example.com/library/eat-pray-love/1303", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001303", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 305, new DateTime(2005, 12, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 12 · Variant 1)" },
                    { 1304, 60, "https://example.com/library/eat-pray-love/1304", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001304", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 312, new DateTime(2008, 1, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 12 · Variant 2)" },
                    { 1305, 70, "https://example.com/library/eat-pray-love/1305", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001305", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 319, new DateTime(2011, 2, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 12 · Variant 3)" },
                    { 1306, 60, "https://example.com/library/eat-pray-love/1306", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001306", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 318, new DateTime(2016, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 13 · Variant 1)" },
                    { 1307, 70, "https://example.com/library/eat-pray-love/1307", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001307", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 325, new DateTime(2019, 2, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 13 · Variant 2)" },
                    { 1308, 83, "https://example.com/library/eat-pray-love/1308", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001308", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 332, new DateTime(1997, 3, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 13 · Variant 3)" },
                    { 1309, 70, "https://example.com/library/eat-pray-love/1309", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001309", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 331, new DateTime(2002, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 14 · Variant 1)" },
                    { 1310, 83, "https://example.com/library/eat-pray-love/1310", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001310", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 338, new DateTime(2005, 3, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 14 · Variant 2)" },
                    { 1311, 90, "https://example.com/library/eat-pray-love/1311", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001311", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 345, new DateTime(2008, 4, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 14 · Variant 3)" },
                    { 1312, 83, "https://example.com/library/eat-pray-love/1312", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001312", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 344, new DateTime(2013, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 15 · Variant 1)" },
                    { 1313, 90, "https://example.com/library/eat-pray-love/1313", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001313", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 351, new DateTime(2016, 4, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 15 · Variant 2)" },
                    { 1314, 1, "https://example.com/library/eat-pray-love/1314", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001314", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 358, new DateTime(2019, 5, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 15 · Variant 3)" },
                    { 1315, 90, "https://example.com/library/eat-pray-love/1315", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001315", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 357, new DateTime(1999, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 16 · Variant 1)" },
                    { 1316, 1, "https://example.com/library/eat-pray-love/1316", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001316", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 364, new DateTime(2002, 5, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 16 · Variant 2)" },
                    { 1317, 3, "https://example.com/library/eat-pray-love/1317", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001317", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 371, new DateTime(2005, 6, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 16 · Variant 3)" },
                    { 1318, 1, "https://example.com/library/eat-pray-love/1318", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001318", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 370, new DateTime(2010, 5, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 17 · Variant 1)" },
                    { 1319, 3, "https://example.com/library/eat-pray-love/1319", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001319", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 377, new DateTime(2013, 6, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 17 · Variant 2)" },
                    { 1320, 5, "https://example.com/library/eat-pray-love/1320", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001320", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 384, new DateTime(2016, 7, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 17 · Variant 3)" },
                    { 1321, 3, "https://example.com/library/eat-pray-love/1321", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001321", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 383, new DateTime(1996, 6, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 18 · Variant 1)" },
                    { 1322, 5, "https://example.com/library/eat-pray-love/1322", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001322", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 390, new DateTime(1999, 7, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 18 · Variant 2)" },
                    { 1323, 6, "https://example.com/library/eat-pray-love/1323", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001323", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 397, new DateTime(2002, 8, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 18 · Variant 3)" },
                    { 1324, 5, "https://example.com/library/eat-pray-love/1324", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001324", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 396, new DateTime(2007, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 19 · Variant 1)" },
                    { 1325, 6, "https://example.com/library/eat-pray-love/1325", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001325", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 403, new DateTime(2010, 8, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 19 · Variant 2)" },
                    { 1326, 12, "https://example.com/library/eat-pray-love/1326", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001326", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 410, new DateTime(2013, 9, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 19 · Variant 3)" },
                    { 1327, 6, "https://example.com/library/eat-pray-love/1327", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001327", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 409, new DateTime(2018, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 20 · Variant 1)" },
                    { 1328, 12, "https://example.com/library/eat-pray-love/1328", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001328", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 416, new DateTime(1996, 9, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 20 · Variant 2)" },
                    { 1329, 19, "https://example.com/library/eat-pray-love/1329", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001329", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 423, new DateTime(1999, 10, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Eat, Pray, Love (Edition 20 · Variant 3)" },
                    { 1330, 47, "https://example.com/library/science-for-all-americans/1330", 9, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001330", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 290, new DateTime(2015, 11, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 11 · Variant 1)" },
                    { 1331, 54, "https://example.com/library/science-for-all-americans/1331", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001331", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 297, new DateTime(2018, 12, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 11 · Variant 2)" },
                    { 1332, 60, "https://example.com/library/science-for-all-americans/1332", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001332", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 304, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 11 · Variant 3)" },
                    { 1333, 54, "https://example.com/library/science-for-all-americans/1333", 10, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001333", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 303, new DateTime(2001, 12, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 12 · Variant 1)" },
                    { 1334, 60, "https://example.com/library/science-for-all-americans/1334", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001334", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 310, new DateTime(2004, 1, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 12 · Variant 2)" },
                    { 1335, 70, "https://example.com/library/science-for-all-americans/1335", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001335", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 317, new DateTime(2007, 2, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 12 · Variant 3)" },
                    { 1336, 60, "https://example.com/library/science-for-all-americans/1336", 11, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001336", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 316, new DateTime(2012, 1, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 13 · Variant 1)" },
                    { 1337, 70, "https://example.com/library/science-for-all-americans/1337", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001337", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 323, new DateTime(2015, 2, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 13 · Variant 2)" },
                    { 1338, 83, "https://example.com/library/science-for-all-americans/1338", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001338", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 330, new DateTime(2018, 3, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 13 · Variant 3)" },
                    { 1339, 70, "https://example.com/library/science-for-all-americans/1339", 1, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001339", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 329, new DateTime(1998, 2, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 14 · Variant 1)" },
                    { 1340, 83, "https://example.com/library/science-for-all-americans/1340", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001340", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 336, new DateTime(2001, 3, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 14 · Variant 2)" },
                    { 1341, 90, "https://example.com/library/science-for-all-americans/1341", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001341", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 343, new DateTime(2004, 4, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 14 · Variant 3)" },
                    { 1342, 83, "https://example.com/library/science-for-all-americans/1342", 2, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001342", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 342, new DateTime(2009, 3, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 15 · Variant 1)" },
                    { 1343, 90, "https://example.com/library/science-for-all-americans/1343", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001343", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 349, new DateTime(2012, 4, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 15 · Variant 2)" },
                    { 1344, 1, "https://example.com/library/science-for-all-americans/1344", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001344", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 356, new DateTime(2015, 5, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 15 · Variant 3)" },
                    { 1345, 90, "https://example.com/library/science-for-all-americans/1345", 3, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001345", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 355, new DateTime(1995, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 16 · Variant 1)" },
                    { 1346, 1, "https://example.com/library/science-for-all-americans/1346", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001346", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 362, new DateTime(1998, 5, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 16 · Variant 2)" },
                    { 1347, 3, "https://example.com/library/science-for-all-americans/1347", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001347", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 369, new DateTime(2001, 6, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 16 · Variant 3)" },
                    { 1348, 1, "https://example.com/library/science-for-all-americans/1348", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001348", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 368, new DateTime(2006, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 17 · Variant 1)" },
                    { 1349, 3, "https://example.com/library/science-for-all-americans/1349", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001349", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 375, new DateTime(2009, 6, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 17 · Variant 2)" },
                    { 1350, 5, "https://example.com/library/science-for-all-americans/1350", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001350", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 382, new DateTime(2012, 7, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 17 · Variant 3)" },
                    { 1351, 3, "https://example.com/library/science-for-all-americans/1351", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001351", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 381, new DateTime(2017, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 18 · Variant 1)" },
                    { 1352, 5, "https://example.com/library/science-for-all-americans/1352", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001352", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 388, new DateTime(1995, 7, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 18 · Variant 2)" },
                    { 1353, 6, "https://example.com/library/science-for-all-americans/1353", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001353", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 395, new DateTime(1998, 8, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 18 · Variant 3)" },
                    { 1354, 5, "https://example.com/library/science-for-all-americans/1354", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001354", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 394, new DateTime(2003, 7, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 19 · Variant 1)" },
                    { 1355, 6, "https://example.com/library/science-for-all-americans/1355", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001355", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 401, new DateTime(2006, 8, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 19 · Variant 2)" },
                    { 1356, 12, "https://example.com/library/science-for-all-americans/1356", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001356", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 408, new DateTime(2009, 9, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 19 · Variant 3)" },
                    { 1357, 6, "https://example.com/library/science-for-all-americans/1357", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001357", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 407, new DateTime(2014, 8, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 20 · Variant 1)" },
                    { 1358, 12, "https://example.com/library/science-for-all-americans/1358", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001358", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 414, new DateTime(2017, 9, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 20 · Variant 2)" },
                    { 1359, 19, "https://example.com/library/science-for-all-americans/1359", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001359", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 421, new DateTime(1995, 10, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 20 · Variant 3)" },
                    { 1360, 12, "https://example.com/library/science-for-all-americans/1360", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001360", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 420, new DateTime(2000, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 21 · Variant 1)" },
                    { 1361, 19, "https://example.com/library/science-for-all-americans/1361", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001361", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 427, new DateTime(2003, 10, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 21 · Variant 2)" },
                    { 1362, 21, "https://example.com/library/science-for-all-americans/1362", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001362", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 434, new DateTime(2006, 11, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Science for All Americans (Edition 21 · Variant 3)" },
                    { 1363, 54, "https://example.com/library/the-discarded-image/1363", 1, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001363", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 301, new DateTime(1997, 12, 2, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 12 · Variant 1)" },
                    { 1364, 60, "https://example.com/library/the-discarded-image/1364", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001364", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 308, new DateTime(2000, 1, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 12 · Variant 2)" },
                    { 1365, 70, "https://example.com/library/the-discarded-image/1365", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001365", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 315, new DateTime(2003, 2, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 12 · Variant 3)" },
                    { 1366, 60, "https://example.com/library/the-discarded-image/1366", 2, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001366", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 314, new DateTime(2008, 1, 5, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 13 · Variant 1)" },
                    { 1367, 70, "https://example.com/library/the-discarded-image/1367", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001367", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 321, new DateTime(2011, 2, 7, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 13 · Variant 2)" },
                    { 1368, 83, "https://example.com/library/the-discarded-image/1368", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001368", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 328, new DateTime(2014, 3, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 13 · Variant 3)" },
                    { 1369, 70, "https://example.com/library/the-discarded-image/1369", 3, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001369", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 327, new DateTime(2019, 2, 8, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 14 · Variant 1)" },
                    { 1370, 83, "https://example.com/library/the-discarded-image/1370", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001370", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 334, new DateTime(1997, 3, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 14 · Variant 2)" },
                    { 1371, 90, "https://example.com/library/the-discarded-image/1371", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001371", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 341, new DateTime(2000, 4, 12, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 14 · Variant 3)" },
                    { 1372, 83, "https://example.com/library/the-discarded-image/1372", 4, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001372", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 340, new DateTime(2005, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 15 · Variant 1)" },
                    { 1373, 90, "https://example.com/library/the-discarded-image/1373", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001373", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 347, new DateTime(2008, 4, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 15 · Variant 2)" },
                    { 1374, 1, "https://example.com/library/the-discarded-image/1374", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001374", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 354, new DateTime(2011, 5, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 15 · Variant 3)" },
                    { 1375, 90, "https://example.com/library/the-discarded-image/1375", 5, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001375", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 353, new DateTime(2016, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 16 · Variant 1)" },
                    { 1376, 1, "https://example.com/library/the-discarded-image/1376", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001376", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 360, new DateTime(2019, 5, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 16 · Variant 2)" },
                    { 1377, 3, "https://example.com/library/the-discarded-image/1377", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001377", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 367, new DateTime(1997, 6, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 16 · Variant 3)" },
                    { 1378, 1, "https://example.com/library/the-discarded-image/1378", 6, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001378", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 366, new DateTime(2002, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 17 · Variant 1)" },
                    { 1379, 3, "https://example.com/library/the-discarded-image/1379", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001379", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 373, new DateTime(2005, 6, 19, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 17 · Variant 2)" },
                    { 1380, 5, "https://example.com/library/the-discarded-image/1380", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001380", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 380, new DateTime(2008, 7, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 17 · Variant 3)" },
                    { 1381, 3, "https://example.com/library/the-discarded-image/1381", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001381", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 379, new DateTime(2013, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 18 · Variant 1)" },
                    { 1382, 5, "https://example.com/library/the-discarded-image/1382", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001382", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 386, new DateTime(2016, 7, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 18 · Variant 2)" },
                    { 1383, 6, "https://example.com/library/the-discarded-image/1383", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001383", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 393, new DateTime(2019, 8, 24, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 18 · Variant 3)" },
                    { 1384, 5, "https://example.com/library/the-discarded-image/1384", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001384", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 392, new DateTime(1999, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 19 · Variant 1)" },
                    { 1385, 6, "https://example.com/library/the-discarded-image/1385", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001385", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 399, new DateTime(2002, 8, 25, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 19 · Variant 2)" },
                    { 1386, 12, "https://example.com/library/the-discarded-image/1386", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001386", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 406, new DateTime(2005, 9, 27, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 19 · Variant 3)" },
                    { 1387, 6, "https://example.com/library/the-discarded-image/1387", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001387", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 405, new DateTime(2010, 8, 26, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 20 · Variant 1)" },
                    { 1388, 12, "https://example.com/library/the-discarded-image/1388", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001388", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 412, new DateTime(2013, 9, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 20 · Variant 2)" },
                    { 1389, 19, "https://example.com/library/the-discarded-image/1389", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001389", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 419, new DateTime(2016, 10, 3, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 20 · Variant 3)" },
                    { 1390, 12, "https://example.com/library/the-discarded-image/1390", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001390", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 418, new DateTime(1996, 9, 2, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 21 · Variant 1)" },
                    { 1391, 19, "https://example.com/library/the-discarded-image/1391", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001391", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 425, new DateTime(1999, 10, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 21 · Variant 2)" },
                    { 1392, 21, "https://example.com/library/the-discarded-image/1392", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001392", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 432, new DateTime(2002, 11, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 21 · Variant 3)" },
                    { 1393, 19, "https://example.com/library/the-discarded-image/1393", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001393", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 431, new DateTime(2007, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 22 · Variant 1)" },
                    { 1394, 21, "https://example.com/library/the-discarded-image/1394", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001394", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 438, new DateTime(2010, 11, 7, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 22 · Variant 2)" },
                    { 1395, 23, "https://example.com/library/the-discarded-image/1395", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001395", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 445, new DateTime(2013, 12, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The Discarded Image (Edition 22 · Variant 3)" },
                    { 1396, 60, "https://example.com/library/bloodmarked/1396", 4, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001396", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 312, new DateTime(2004, 1, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 13 · Variant 1)" },
                    { 1397, 70, "https://example.com/library/bloodmarked/1397", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001397", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 319, new DateTime(2007, 2, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 13 · Variant 2)" },
                    { 1398, 83, "https://example.com/library/bloodmarked/1398", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001398", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 326, new DateTime(2010, 3, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 13 · Variant 3)" },
                    { 1399, 70, "https://example.com/library/bloodmarked/1399", 5, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001399", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 325, new DateTime(2015, 2, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 14 · Variant 1)" },
                    { 1400, 83, "https://example.com/library/bloodmarked/1400", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001400", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 332, new DateTime(2018, 3, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 14 · Variant 2)" },
                    { 1401, 90, "https://example.com/library/bloodmarked/1401", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001401", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 339, new DateTime(1996, 4, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 14 · Variant 3)" },
                    { 1402, 83, "https://example.com/library/bloodmarked/1402", 6, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001402", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 338, new DateTime(2001, 3, 13, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 15 · Variant 1)" },
                    { 1403, 90, "https://example.com/library/bloodmarked/1403", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001403", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 345, new DateTime(2004, 4, 15, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 15 · Variant 2)" },
                    { 1404, 1, "https://example.com/library/bloodmarked/1404", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001404", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 352, new DateTime(2007, 5, 17, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 15 · Variant 3)" },
                    { 1405, 90, "https://example.com/library/bloodmarked/1405", 7, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001405", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 351, new DateTime(2012, 4, 16, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 16 · Variant 1)" },
                    { 1406, 1, "https://example.com/library/bloodmarked/1406", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001406", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 358, new DateTime(2015, 5, 18, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 16 · Variant 2)" },
                    { 1407, 3, "https://example.com/library/bloodmarked/1407", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001407", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 365, new DateTime(2018, 6, 20, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 16 · Variant 3)" },
                    { 1408, 1, "https://example.com/library/bloodmarked/1408", 8, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001408", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 364, new DateTime(1998, 5, 19, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 17 · Variant 1)" },
                    { 1409, 3, "https://example.com/library/bloodmarked/1409", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001409", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 371, new DateTime(2001, 6, 21, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 17 · Variant 2)" },
                    { 1410, 5, "https://example.com/library/bloodmarked/1410", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001410", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 378, new DateTime(2004, 7, 23, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 17 · Variant 3)" },
                    { 1411, 3, "https://example.com/library/bloodmarked/1411", 9, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001411", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 377, new DateTime(2009, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 18 · Variant 1)" },
                    { 1412, 5, "https://example.com/library/bloodmarked/1412", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001412", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 384, new DateTime(2012, 7, 24, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 18 · Variant 2)" },
                    { 1413, 6, "https://example.com/library/bloodmarked/1413", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001413", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 391, new DateTime(2015, 8, 26, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 18 · Variant 3)" },
                    { 1414, 5, "https://example.com/library/bloodmarked/1414", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001414", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 390, new DateTime(1995, 7, 25, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 19 · Variant 1)" },
                    { 1415, 6, "https://example.com/library/bloodmarked/1415", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001415", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 397, new DateTime(1998, 8, 27, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 19 · Variant 2)" },
                    { 1416, 12, "https://example.com/library/bloodmarked/1416", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001416", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 404, new DateTime(2001, 9, 2, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 19 · Variant 3)" },
                    { 1417, 6, "https://example.com/library/bloodmarked/1417", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001417", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 403, new DateTime(2006, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 20 · Variant 1)" },
                    { 1418, 12, "https://example.com/library/bloodmarked/1418", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001418", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 410, new DateTime(2009, 9, 3, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 20 · Variant 2)" },
                    { 1419, 19, "https://example.com/library/bloodmarked/1419", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001419", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 417, new DateTime(2012, 10, 5, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 20 · Variant 3)" },
                    { 1420, 12, "https://example.com/library/bloodmarked/1420", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001420", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 416, new DateTime(2017, 9, 4, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 21 · Variant 1)" },
                    { 1421, 19, "https://example.com/library/bloodmarked/1421", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001421", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 423, new DateTime(1995, 10, 6, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 21 · Variant 2)" },
                    { 1422, 21, "https://example.com/library/bloodmarked/1422", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001422", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 430, new DateTime(1998, 11, 8, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 21 · Variant 3)" },
                    { 1423, 19, "https://example.com/library/bloodmarked/1423", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001423", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 429, new DateTime(2003, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 22 · Variant 1)" },
                    { 1424, 21, "https://example.com/library/bloodmarked/1424", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001424", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 436, new DateTime(2006, 11, 9, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 22 · Variant 2)" },
                    { 1425, 23, "https://example.com/library/bloodmarked/1425", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001425", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 443, new DateTime(2009, 12, 11, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 22 · Variant 3)" },
                    { 1426, 21, "https://example.com/library/bloodmarked/1426", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001426", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 442, new DateTime(2014, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 23 · Variant 1)" },
                    { 1427, 23, "https://example.com/library/bloodmarked/1427", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001427", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 449, new DateTime(2017, 12, 12, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 23 · Variant 2)" },
                    { 1428, 33, "https://example.com/library/bloodmarked/1428", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001428", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 456, new DateTime(1995, 1, 14, 0, 0, 0, 0, DateTimeKind.Utc), "Bloodmarked (Edition 23 · Variant 3)" },
                    { 1429, 70, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1429", 7, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001429", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 323, new DateTime(2011, 2, 12, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 14 · Variant 1)" },
                    { 1430, 83, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1430", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001430", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 330, new DateTime(2014, 3, 14, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 14 · Variant 2)" },
                    { 1431, 90, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1431", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001431", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 337, new DateTime(2017, 4, 16, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 14 · Variant 3)" },
                    { 1432, 83, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1432", 8, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001432", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 336, new DateTime(1997, 3, 15, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 15 · Variant 1)" },
                    { 1433, 90, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1433", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001433", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 343, new DateTime(2000, 4, 17, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 15 · Variant 2)" },
                    { 1434, 1, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1434", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001434", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 350, new DateTime(2003, 5, 19, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 15 · Variant 3)" },
                    { 1435, 90, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1435", 9, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001435", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 349, new DateTime(2008, 4, 18, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 16 · Variant 1)" },
                    { 1436, 1, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1436", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001436", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 356, new DateTime(2011, 5, 20, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 16 · Variant 2)" },
                    { 1437, 3, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1437", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001437", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 363, new DateTime(2014, 6, 22, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 16 · Variant 3)" },
                    { 1438, 1, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1438", 10, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001438", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 362, new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 17 · Variant 1)" },
                    { 1439, 3, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1439", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001439", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 369, new DateTime(1997, 6, 23, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 17 · Variant 2)" },
                    { 1440, 5, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1440", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001440", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 376, new DateTime(2000, 7, 25, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 17 · Variant 3)" },
                    { 1441, 3, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1441", 11, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001441", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 375, new DateTime(2005, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 18 · Variant 1)" },
                    { 1442, 5, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1442", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001442", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 382, new DateTime(2008, 7, 26, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 18 · Variant 2)" },
                    { 1443, 6, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1443", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001443", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 389, new DateTime(2011, 8, 1, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 18 · Variant 3)" },
                    { 1444, 5, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1444", 1, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001444", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 388, new DateTime(2016, 7, 27, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 19 · Variant 1)" },
                    { 1445, 6, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1445", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001445", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 395, new DateTime(2019, 8, 2, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 19 · Variant 2)" },
                    { 1446, 12, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1446", 3, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001446", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 402, new DateTime(1997, 9, 4, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 19 · Variant 3)" },
                    { 1447, 6, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1447", 2, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001447", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 401, new DateTime(2002, 8, 3, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 20 · Variant 1)" },
                    { 1448, 12, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1448", 3, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001448", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 408, new DateTime(2005, 9, 5, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 20 · Variant 2)" },
                    { 1449, 19, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1449", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001449", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 415, new DateTime(2008, 10, 7, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 20 · Variant 3)" },
                    { 1450, 12, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1450", 3, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001450", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 414, new DateTime(2013, 9, 6, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 21 · Variant 1)" },
                    { 1451, 19, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1451", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001451", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 421, new DateTime(2016, 10, 8, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 21 · Variant 2)" },
                    { 1452, 21, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1452", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001452", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 428, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 21 · Variant 3)" },
                    { 1453, 19, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1453", 4, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001453", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 427, new DateTime(1999, 10, 9, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 22 · Variant 1)" },
                    { 1454, 21, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1454", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001454", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 434, new DateTime(2002, 11, 11, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 22 · Variant 2)" },
                    { 1455, 23, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1455", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001455", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 441, new DateTime(2005, 12, 13, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 22 · Variant 3)" },
                    { 1456, 21, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1456", 5, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001456", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 440, new DateTime(2010, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 23 · Variant 1)" },
                    { 1457, 23, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1457", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001457", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 447, new DateTime(2013, 12, 14, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 23 · Variant 2)" },
                    { 1458, 33, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1458", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001458", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 454, new DateTime(2016, 1, 16, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 23 · Variant 3)" },
                    { 1459, 23, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1459", 6, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001459", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 453, new DateTime(1996, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 24 · Variant 1)" },
                    { 1460, 33, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1460", 7, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001460", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 460, new DateTime(1999, 1, 17, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 24 · Variant 2)" },
                    { 1461, 40, "https://example.com/library/a-portrait-of-the-artist-as-a-young-man/1461", 8, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001461", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 467, new DateTime(2002, 2, 19, 0, 0, 0, 0, DateTimeKind.Utc), "A Portrait of the Artist as a Young Man (Edition 24 · Variant 3)" },
                    { 1462, 83, "https://example.com/library/the-history-of-the-peloponnesian-war/1462", 10, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001462", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 334, new DateTime(2018, 3, 17, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 15 · Variant 1)" },
                    { 1463, 90, "https://example.com/library/the-history-of-the-peloponnesian-war/1463", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001463", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 341, new DateTime(1996, 4, 19, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 15 · Variant 2)" },
                    { 1464, 1, "https://example.com/library/the-history-of-the-peloponnesian-war/1464", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001464", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", true, 348, new DateTime(1999, 5, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 15 · Variant 3)" },
                    { 1465, 90, "https://example.com/library/the-history-of-the-peloponnesian-war/1465", 11, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001465", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 347, new DateTime(2004, 4, 20, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 16 · Variant 1)" },
                    { 1466, 1, "https://example.com/library/the-history-of-the-peloponnesian-war/1466", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001466", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 354, new DateTime(2007, 5, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 16 · Variant 2)" },
                    { 1467, 3, "https://example.com/library/the-history-of-the-peloponnesian-war/1467", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001467", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", true, 361, new DateTime(2010, 6, 24, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 16 · Variant 3)" },
                    { 1468, 1, "https://example.com/library/the-history-of-the-peloponnesian-war/1468", 1, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001468", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 360, new DateTime(2015, 5, 23, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 17 · Variant 1)" },
                    { 1469, 3, "https://example.com/library/the-history-of-the-peloponnesian-war/1469", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001469", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 367, new DateTime(2018, 6, 25, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 17 · Variant 2)" },
                    { 1470, 5, "https://example.com/library/the-history-of-the-peloponnesian-war/1470", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001470", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", true, 374, new DateTime(1996, 7, 27, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 17 · Variant 3)" },
                    { 1471, 3, "https://example.com/library/the-history-of-the-peloponnesian-war/1471", 2, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001471", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 373, new DateTime(2001, 6, 26, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 18 · Variant 1)" },
                    { 1472, 5, "https://example.com/library/the-history-of-the-peloponnesian-war/1472", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001472", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 380, new DateTime(2004, 7, 1, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 18 · Variant 2)" },
                    { 1473, 6, "https://example.com/library/the-history-of-the-peloponnesian-war/1473", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001473", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", true, 387, new DateTime(2007, 8, 3, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 18 · Variant 3)" },
                    { 1474, 5, "https://example.com/library/the-history-of-the-peloponnesian-war/1474", 3, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001474", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 386, new DateTime(2012, 7, 2, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 19 · Variant 1)" },
                    { 1475, 6, "https://example.com/library/the-history-of-the-peloponnesian-war/1475", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001475", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 393, new DateTime(2015, 8, 4, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 19 · Variant 2)" },
                    { 1476, 12, "https://example.com/library/the-history-of-the-peloponnesian-war/1476", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001476", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", true, 400, new DateTime(2018, 9, 6, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 19 · Variant 3)" },
                    { 1477, 6, "https://example.com/library/the-history-of-the-peloponnesian-war/1477", 4, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001477", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 399, new DateTime(1998, 8, 5, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 20 · Variant 1)" },
                    { 1478, 12, "https://example.com/library/the-history-of-the-peloponnesian-war/1478", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001478", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 406, new DateTime(2001, 9, 7, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 20 · Variant 2)" },
                    { 1479, 19, "https://example.com/library/the-history-of-the-peloponnesian-war/1479", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001479", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", true, 413, new DateTime(2004, 10, 9, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 20 · Variant 3)" },
                    { 1480, 12, "https://example.com/library/the-history-of-the-peloponnesian-war/1480", 5, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001480", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 412, new DateTime(2009, 9, 8, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 21 · Variant 1)" },
                    { 1481, 19, "https://example.com/library/the-history-of-the-peloponnesian-war/1481", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001481", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 419, new DateTime(2012, 10, 10, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 21 · Variant 2)" },
                    { 1482, 21, "https://example.com/library/the-history-of-the-peloponnesian-war/1482", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001482", "https://m.media-amazon.com/images/I/71X0qU1mJpL.jpg", true, 426, new DateTime(2015, 11, 12, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 21 · Variant 3)" },
                    { 1483, 19, "https://example.com/library/the-history-of-the-peloponnesian-war/1483", 6, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001483", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 425, new DateTime(1995, 10, 11, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 22 · Variant 1)" },
                    { 1484, 21, "https://example.com/library/the-history-of-the-peloponnesian-war/1484", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001484", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 432, new DateTime(1998, 11, 13, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 22 · Variant 2)" },
                    { 1485, 23, "https://example.com/library/the-history-of-the-peloponnesian-war/1485", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001485", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", true, 439, new DateTime(2001, 12, 15, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 22 · Variant 3)" },
                    { 1486, 21, "https://example.com/library/the-history-of-the-peloponnesian-war/1486", 7, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001486", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 438, new DateTime(2006, 11, 14, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 23 · Variant 1)" },
                    { 1487, 23, "https://example.com/library/the-history-of-the-peloponnesian-war/1487", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001487", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 445, new DateTime(2009, 12, 16, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 23 · Variant 2)" },
                    { 1488, 33, "https://example.com/library/the-history-of-the-peloponnesian-war/1488", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001488", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", true, 452, new DateTime(2012, 1, 18, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 23 · Variant 3)" },
                    { 1489, 23, "https://example.com/library/the-history-of-the-peloponnesian-war/1489", 8, "Anniversary print that blends familiar plots with new forewords and endnotes.", "9789000001489", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 451, new DateTime(2017, 12, 17, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 24 · Variant 1)" },
                    { 1490, 33, "https://example.com/library/the-history-of-the-peloponnesian-war/1490", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001490", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 458, new DateTime(1995, 1, 19, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 24 · Variant 2)" },
                    { 1491, 40, "https://example.com/library/the-history-of-the-peloponnesian-war/1491", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001491", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", true, 465, new DateTime(1998, 2, 21, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 24 · Variant 3)" },
                    { 1492, 33, "https://example.com/library/the-history-of-the-peloponnesian-war/1492", 9, "Collector's remix of a popular title with refreshed commentary and bonus reading notes.", "9789000001492", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 464, new DateTime(2003, 1, 20, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 25 · Variant 1)" },
                    { 1493, 40, "https://example.com/library/the-history-of-the-peloponnesian-war/1493", 10, "Limited gallery jacket pairing a classic narrative with a curated visual companion.", "9789000001493", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 471, new DateTime(2006, 2, 22, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 25 · Variant 2)" },
                    { 1494, 47, "https://example.com/library/the-history-of-the-peloponnesian-war/1494", 11, "Library exclusive run combining beloved stories with alternate artwork for display.", "9789000001494", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", true, 478, new DateTime(2009, 3, 24, 0, 0, 0, 0, DateTimeKind.Utc), "The History of the Peloponnesian War (Edition 25 · Variant 3)" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1206);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1207);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1208);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1209);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1210);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1211);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1212);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1213);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1214);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1215);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1216);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1217);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1218);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1219);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1220);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1221);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1222);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1223);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1224);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1225);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1226);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1227);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1228);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1229);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1230);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1231);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1232);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1233);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1234);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1235);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1236);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1237);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1238);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1239);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1240);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1241);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1242);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1243);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1244);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1245);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1246);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1247);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1248);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1249);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1250);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1251);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1252);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1253);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1254);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1255);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1256);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1257);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1258);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1259);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1260);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1261);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1262);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1263);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1265);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1266);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1267);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1268);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1269);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1270);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1271);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1272);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1273);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1275);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1276);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1277);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1278);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1279);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1280);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1281);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1282);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1283);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1284);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1285);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1286);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1287);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1288);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1289);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1290);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1291);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1292);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1293);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1294);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1295);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1296);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1297);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1298);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1299);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1300);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1301);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1302);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1303);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1304);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1305);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1306);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1307);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1308);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1309);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1310);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1311);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1312);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1313);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1314);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1315);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1316);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1317);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1318);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1319);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1320);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1321);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1322);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1323);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1324);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1325);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1326);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1327);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1328);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1329);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1330);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1331);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1332);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1333);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1334);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1335);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1336);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1337);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1338);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1339);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1340);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1341);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1342);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1343);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1344);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1345);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1346);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1347);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1348);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1349);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1350);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1351);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1352);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1353);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1354);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1355);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1356);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1357);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1358);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1359);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1360);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1361);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1362);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1363);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1364);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1365);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1366);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1367);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1368);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1369);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1370);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1371);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1372);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1373);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1374);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1375);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1376);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1377);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1378);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1379);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1380);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1381);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1383);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1384);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1385);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1386);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1387);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1388);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1389);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1390);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1391);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1392);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1393);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1394);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1395);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1396);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1397);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1398);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1399);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1400);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1401);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1402);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1403);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1404);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1405);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1406);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1407);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1408);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1409);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1410);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1411);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1412);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1413);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1414);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1415);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1416);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1417);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1418);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1419);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1420);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1421);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1422);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1423);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1424);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1425);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1426);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1427);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1428);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1429);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1430);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1431);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1432);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1433);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1434);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1435);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1436);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1437);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1438);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1439);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1440);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1441);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1442);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1443);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1444);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1445);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1446);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1447);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1448);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1449);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1450);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1451);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1452);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1453);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1454);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1455);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1456);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1457);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1458);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1459);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1460);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1461);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1462);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1463);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1464);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1465);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1466);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1467);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1468);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1469);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1470);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1471);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1472);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1473);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1474);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1475);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1476);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1477);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1478);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1479);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1480);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1481);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1482);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1483);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1484);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1485);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1486);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1487);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1488);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1489);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1490);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1491);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1492);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1493);

            migrationBuilder.DeleteData(
                table: "books",
                keyColumn: "Id",
                keyValue: 1494);

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 63,
                column: "ImageURL",
                value: "https://online.fliphtml5.com/gutjj/zwbj/files/large/1.webp?1604750286&1604750286");

            migrationBuilder.UpdateData(
                table: "books",
                keyColumn: "Id",
                keyValue: 96,
                column: "ImageURL",
                value: "https://online.fliphtml5.com/gutjj/zwbj/files/large/1.webp?1604750286&1604750286");
        }
    }
}
