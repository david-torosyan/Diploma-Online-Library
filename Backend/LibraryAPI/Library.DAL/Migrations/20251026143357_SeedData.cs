using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Library.DAL.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BookURL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageURL",
                table: "Books",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "Id", "FullName" },
                values: new object[,]
                {
                    { 1, "Նավջոթ Ս. Սոջի" },
                    { 2, "Փոլ Ռ. Էռլիխ" },
                    { 3, "Ստիվ Թ. Բեքեթ" },
                    { 4, "Ուորդ Չեսվոր್ತ" },
                    { 5, "Հանս Մորավեց" },
                    { 6, "Կարլո Ռովելի" },
                    { 7, "Ֆրանչեսկա Վիդոտտո" },
                    { 8, "Աբհայ Ռ. Սատոսկար" },
                    { 9, "Գարի Էլ. Սայմոն" },
                    { 10, "Փիթեր Ջ. Հոտեզ" },
                    { 11, "Մորիյա Տսուժի" },
                    { 12, "Ջորջ Դայսոն" },
                    { 13, "Չարլզ Դարվին" },
                    { 14, "Ֆլոյդ Ջեյմս Ռադըրթֆըրդ" },
                    { 15, "Էնդրյու Ահլգրեն" },
                    { 16, "Նիկոլայ Վ. Գոգոլ" },
                    { 17, "Թուկիդիդես" },
                    { 18, "Կնուտ Համսուն" },
                    { 19, "Օսկար Ուայլդ" },
                    { 20, "Մերի Շելլի" },
                    { 21, "Վիրջինիա Ուլֆ" },
                    { 22, "Բրունո Շուլց" },
                    { 23, "Լի Չայլդ" },
                    { 24, "Ջեյմս Ջոյս" },
                    { 25, "Վիրջինիա Ուլֆ" },
                    { 26, "Ջուդ Դեվերօ" },
                    { 27, "Առնետ Լեմբ" },
                    { 28, "Ջիլ Բարնեթ" },
                    { 29, "Ջուդիթ ՄաքՆոթ" },
                    { 30, "Շառլոթ Բրոնտե" },
                    { 31, "Ջեյն Օսթին" },
                    { 32, "Ջուլի Գարվուդ" },
                    { 33, "Ջոջո Մոյես" },
                    { 34, "Դանիել Ստիլ" },
                    { 35, "Սանտա Մոնտեֆիորե" },
                    { 36, "Յոհաննա Լինդսեյ" },
                    { 37, "Ք. Ս. Լյուիս" },
                    { 38, "Ուրսուլա Կ. Լե Գուին" },
                    { 39, "Տովե Յանսոն" },
                    { 40, "Ջ. Ռ. Ռ. Թոլկին" },
                    { 41, "Ջոն Ռոնալդ Ռոյել Թոլկին" },
                    { 42, "Լյուիս Քարոլ" },
                    { 43, "Քլայվ Սթեյփլզ Լյուիս" },
                    { 44, "Էլ. Ֆրենկ Բաում" },
                    { 45, "Քեննեթ Գրեհեմ" },
                    { 46, "Թրեյսի Դեոնն" },
                    { 47, "Ագաթա Քրիստի" },
                    { 48, "Դեն Բրաուն" },
                    { 49, "Մարկ Հադդոն" },
                    { 50, "Փ. Դ. Ջեյմս" },
                    { 51, "Ֆյոդոր Դոստոևսկի" },
                    { 52, "Ֆրեդ Վարգաս" },
                    { 53, "Ջոզեֆին Թեյ" },
                    { 54, "Քեյթ Մորտոն" },
                    { 55, "Ք. Ս. Լյուիս" },
                    { 56, "Ֆիլիպ Ֆրիման" },
                    { 57, "Էլ. Ջեյ. Ֆ. Քեփի" },
                    { 58, "Հելեն Ս. Ռաունթրի" },
                    { 59, "Կարլ Բեքսոն" },
                    { 60, "Ջերի Զ. Մյուլլեր" },
                    { 61, "Ջոնաթան Հարիս" },
                    { 62, "Սերհի Փլոխի" },
                    { 63, "Գ. Ն. Դևի" },
                    { 64, "Ջեֆրի Վ. Դևիս" },
                    { 65, "Կ. Կ. Չակրավարտի" },
                    { 66, "Վահան Մ. Կյուրքչյան" },
                    { 67, "Վիկտոր Է. Թորեն" },
                    { 68, "Ջոն Ռոբերտ Քրիստիանսոն" },
                    { 69, "Վիլյամ Սմիթ" },
                    { 70, "Էլիզաբեթ Գիլբերթ" },
                    { 71, "Պրիմո Լևի" },
                    { 72, "Չարլզ Նայթ" },
                    { 73, "Դեզմոնդ Շում" },
                    { 74, "Ջոն Ալեքսանդր Գայ" },
                    { 75, "Ռիչարդ Ա. Բարիջ" },
                    { 76, "Պլուտարխոս" },
                    { 77, "Ջոն Լանգհորն" },
                    { 78, "Վիլյամ Լանգհորն" },
                    { 79, "Լանս Դեյ" },
                    { 80, "Իյան ՄաքՆեյլ" },
                    { 81, "Ֆլոյդ Ջեյմս Ռադըրթֆըրդ" },
                    { 82, "Էնդրյու Ահլգրեն" },
                    { 83, "Միչել Ռեզնիկ" },
                    { 84, "Էնդրյու Ֆենբերգ" },
                    { 85, "Սթիվեն Գրեհեմ" },
                    { 86, "Սայմոն Մարվին" },
                    { 87, "Հաննա Արենդտ" },
                    { 88, "Օլիվեր Մանուել" },
                    { 89, "Ֆրից Ուլման" },
                    { 90, "Լեո Մարքս" },
                    { 91, "Վոլֆգանգ Գերհարթց" },
                    { 92, "Ջոն Դյուի" },
                    { 93, "Ժան Ժիոնո" },
                    { 94, "Ռոբերթ Բեր" },
                    { 95, "Մերի Էլեն Միլլեր" },
                    { 96, "Սայմոն Մարտին" },
                    { 97, "Մարտին Քեմփ" },
                    { 98, "Գի Դեբոր" },
                    { 99, "Գոգոլ Գուգլ Թրանսլեյթ" },
                    { 100, "Վահան Մ. Կյուրքչյան" },
                    { 101, "Ջորջ Բեռնարդ Շոու" },
                    { 102, "Ջեյն Փորթալ" },
                    { 103, "Թոմ Մասթերս" },
                    { 104, "Օրհան Փամուք" },
                    { 105, "Կոնրադ Ջոզեֆ" },
                    { 106, "Թոմ Սթոուն" },
                    { 107, "Էրիկ Սոլստեն" },
                    { 108, "Էլիզաբեթ Գիլբերթ" },
                    { 109, "Թոնի Ուիթեն" },
                    { 110, "Ռոհայաթ Էմոն Սուերիաթմաջա" },
                    { 111, "Սուրայա Ա. Աֆիֆ" },
                    { 112, "Ֆրանցիս Մորոնե" },
                    { 113, "Փոլ Ֆ. Ջ. Իգլզ" },
                    { 114, "Սթիվեն Ֆ. ՄաքՔուլ" },
                    { 115, "Քրիստոֆեր Դ. Հեյնս" },
                    { 116, "ՄԱԿ Շրջակա Միջավայրի Ծրագիր" },
                    { 117, "Աշխարհի Զբոսաշրջության Կազմակերպություն" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Գիտություն" },
                    { 2, "Գեղարվեստական" },
                    { 3, "Սերունդ" },
                    { 4, "Ֆանտաստիկա" },
                    { 5, "Խորհրդավորություն" },
                    { 6, "Պատմություն" },
                    { 7, "Կենսագրություն" },
                    { 8, "Տեխնոլոգիա" },
                    { 9, "Արվեստ" },
                    { 10, "Ճանապարհորդություն" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "Id", "AuthorId", "BookURL", "CategoryId", "Description", "ISBN", "ImageURL", "Pages", "PublishedDate", "Title" },
                values: new object[,]
                {
                    { 1, 1, "https://conbio.org/images/content_publications/ConservationBiologyforAll_reducedsize.pdf", 1, "Conservation Biology for All provides cutting-edge but basic conservation science to a global readership. A series of authoritative chapters have been written by the top names in conservation biology with the principal aim of disseminating cutting-edge conservation knowledge as widely as possible. Important topics such as balancing conversion and human needs, climate change, conservation planning, designing and analyzing conservation research, ecosystem services, endangered species management, extinctions, fire, habitat loss, and invasive species are covered. Numerous textboxes describing additional relevant material or case studies are also included. The global biodiversity crisis is now unstoppable; what can be saved in the developing world will require an educated constituency in both the developing and developed world. Habitat loss is particularly acute in developing countries, which is of special concern because it tends to be these locations where the greatest species diversity and richest centres of endemism are to be found. Sadly, developing world conservation scientists have found it difficult to access an authoritative textbook, which is particularly ironic since it is these countries where the potential benefits of knowledge application are greatest. There is now an urgent need to educate the next generation of scientists in developing countries, so that they are in a better position to protect their natural resources.", "9780199554232", "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg", 369, new DateTime(2010, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conservation Biology for All" },
                    { 2, 3, "https://download.e-bookshelf.de/download/0000/5986/29/L-G-0000598629-0002363255.pdf", 1, "Since the third edition of this standard work in 1999, there has been a significant increase in the amount of chocolate manufactured worldwide. The fourth edition of Industrial Chocolate Manufacture and Use provides up-to-date coverage of all major aspects of chocolate manufacture and use, from the growing of cocoa beans to the packaging and marketing of the end product. Retaining the important and well-received key features of the previous edition, the fourth edition also contains completely new chapters covering chocolate crumb, cold forming technologies, intellectual property, and nutrition. Furthermore, taking account of significant changes and trends within the chocolate industry, much new information is incorporated, particularly within such chapters as those covering the chemistry of flavour development, chocolate flow properties, chocolate packaging, and chocolate marketing. This fully revised and expanded new edition is an essential purchase for all those involved in the manufacture and use of chocolate.", "9781444357554", "https://media.springernature.com/full/springer-static/cover-hires/book/978-1-4615-2111-2", 679, new DateTime(2011, 9, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Industrial Chocolate Manufacture and Use" },
                    { 3, 2, "https://archive.org/details/animalsavisualencyclopedia", 1, "This lavishly illustrated trade reference to mammals, birds, reptiles, amphibians, fishes, and invertebrates features hundreds of glorious photos, masterful illustrations, and informative maps.", "9780520244061", "https://m.media-amazon.com/images/I/91H7u1fM9vL._AC_UF1000,1000_QL80_.jpg", 619, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Encyclopedia of Animals" },
                    { 4, 12, "https://mediarep.org/server/api/core/bitstreams/e0da505d-200c-43ab-be4b-6604a4df816f/content", 1, "In this astonishing prediction of the World Wide Web's ultimate challenge to human civilization--a globally networked, electronic, sentient being--Dyson traces the course of the information revolution, illuminating the lives, work, and ideas of visionaries who foresaw the development of artificial intelligence, artificial life, and the global mind.", "UOM:39015041310320", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg", 312, new DateTime(1997, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darwin Among The Machines" },
                    { 5, 4, "https://ens9004-infd.mendoza.edu.ar/sitio/geologia-goemorfologia/upload/12-%20CHESWORTH,%20W.%20-%20LIBRO%20-%20Encyclopedia%20of%20Soil%20Science.pdf", 1, "The Encyclopedia of Soil Science provides a comprehensive, alphabetical treatment of basic soil science in a single volume. It constitutes a wide ranging and authorative collection of some 160 academic articles covering the salient aspects of soil physics, chemistry, biology, fertility, technology, genesis, morphology, classification and geomorphology. With increased usage of soil for world food production, building materials, and waste repositories, demand has grown for a better global understanding of soil and its processes. longer articles by leading authorities from around the world are supplemented by some 430 definitions of common terms in soil sciences.", "9781402039942", "https://media.springernature.com/full/springer-static/cover-hires/book/978-1-4020-3995-9", 859, new DateTime(2007, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Encyclopedia of Soil Science" },
                    { 6, 5, "https://www.scribd.com/document/678843543/8-Moravec-H-1990-Mind-Children", 1, "\"A dizzying display of intellect and wild imaginings by Moravec, a world-class roboticist who has himself developed clever beasts . . . Undeniably, Moravec comes across as a highly knowledgeable and creative talent--which is just what the field needs\".--Kirkus Reviews.", "9780674576186", "https://www.hup.harvard.edu/img/feeds/jackets/9780674576186.png?fm=jpg&q=80&fit=max&w=630", 228, new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mind Children" },
                    { 7, 6, "https://www.cpt.univ-mrs.fr/~rovelli/IntroductionLQG.pdf", 1, "A comprehensible introduction to the most fascinating research in theoretical physics: advanced quantum gravity. Ideal for researchers and graduate students.", "9781107069626", "https://m.media-amazon.com/images/I/813-Uql4q7L._AC_UF1000,1000_QL80_.jpg", 267, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Covariant Loop Quantum Gravity" },
                    { 8, 14, "https://academic.oup.com/book/51739", 1, "In order to compete in the modern world, any society today must rank education in science, mathematics, and technology as one of its highest priorities. It's a sad but true fact, however, that most Americans are not scientifically literate. International studies of educational performance reveal that U.S. students consistently rank near the bottom in science and mathematics. The latest study of the National Assessment of Educational Progress has found that despite some small gains recently, the average performance of seventeen-year-olds in 1986 remained substantially lower than it had been in 1969. As the world approaches the twenty-first century, American schools--when it comes to the advancement of scientific knowledge--seem to be stuck in the Victorian age.In Science for All Americans, F. James Rutherford and Andrew Ahlgren brilliantly tackle this devastating problem. Based on Project 2061, a scientific literacy initiative sponsored by the American Association for the Advancement of Science, this wide-ranging, important volume explores what constitutes scientific literacy in a modern society; the knowledge, skills, and attitudes all students should acquire from their total school experience from kindergarten through high school; and what steps this country must take to begin reforming its system of education in science, mathematics, and technology.Science for All Americans describes the scientifically literate person as one who knows that science, mathematics, and technology are interdependent enterprises with strengths and limitations; who understands key concepts and principles of science; who recognizes both the diversity and unity of the natural world; and who uses scientific knowledge and scientific ways of thinking for personal and social purposes. Its recommendations for educational reform downplay traditional subject categories and instead highlight the connections between them. It also emphasizes ideas and thinking skills over the memorization of specialized vocabulary. For instance, basic scientific literacy means knowing that the chief function of living cells is assembling protein molecules according to the instructions coded in DNA molecules, but does not mean necessarily knowing the terms \"ribosome\" or \"deoxyribonucleic acid.\"Science, mathematics, and technology will be at the center of the radical changes in the nature of human existence that will occur during the next life span; therefore, preparing today's children for tomorrow's world must entail a solid education in these areas. Science for All Americans will help pave the way for the necessary reforms in America's schools.", "UOM:39015025158489", "https://m.media-amazon.com/images/I/61iwcrSHQ6L._AC_UF1000,1000_QL80_.jpg", 282, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Science for All Americans" },
                    { 9, 13, "https://darwin-online.org.uk/converted/pdf/1897_Expression_F1152.pdf", 1, "MANY works have been written on Expression, but a greater number on Physiognomy, that is, on the recognition of character through the study of the permanent form of the features. With this latter subject I am not here concerned. The older treatises, which I have consulted, have been of little or no service to me. The famous 'Conferences' of the painter Le Brun, published in 1667, is the best known ancient work, and contains some good remarks. Another somewhat old essay, namely, the 'Discours, ' delivered 1774-1782, by the well-known Dutch anatomist Camper, can hardly be considered as having made any marked advance in the subject. The following works, on the contrary, deserve the fullest consideration", "BSB:BSB10997144", "https://assets.cambridge.org/97811080/61834/large_cover/9781108061834i.jpg", 406, new DateTime(1872, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Expression of the Emotions in Man and Animals" },
                    { 10, 8, "http://repository.stikesrspadgs.ac.id/63/1/Medical%20Parasitology%20Shymasundari-501hlm.pdf", 1, "Infections caused by parasites are still a major global health problem. Although parasitic infections are responsible for a significant morbidity and mortality in the developing countries, they are also prevalent in the developed countries. Early diagnosis and treatment of a parasitic infection is not only critical for preventing morbidity and mort", "9781040195369", "https://m.media-amazon.com/images/I/819c-MQARGL._AC_UF1000,1000_QL80_.jpg", 331, new DateTime(2009, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Medical Parasitology" },
                    { 11, 16, "https://dn790009.ca.archive.org/0/items/cu31924026658165/cu31924026658165.pdf", 2, "Feroces, crueles, valientes y apasionados, los cosacos hacen temblar la estepa bajo los cascos de sus caballos. Y entre ellos se encuentra Taras Bulba, un anciano lleno aún de fuerza e inteligencia que junto a sus hijos, Ostap y Andrí, avanzará por tierras polacas con intención de vengar su fe ortodoxa burlada por los católicos. Ninguna guarnición, ciudad amurallada o iglesia podrán detenerlos, hasta que la desgracia se cierna sobre ellos y el apuesto y enamoradizo Andrí haga que su padre maldiga el día en que lo engendró. Taras Bulba, una anomalía entre la obra más conocida de Gogol, es una aventura trepidante, una sinfonía en perpetuo crescendo, en la que cada capítulo es más intenso y sorprendente que el anterior. un fresco tan afinadamente dibujado y tan vívido que resulta absolutamente intemporal.", "9788446023708", "https://ww2.ebookelo.com/images/cover/21286.jpg", 154, new DateTime(2006, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taras Bulba" },
                    { 12, 17, "https://antilogicalism.com/wp-content/uploads/2017/07/history-pelo-war.pdf", 2, "The History of the Peloponnesian War (Greek: Ἱστορίαι, \"Histories\") is a historical account of the Peloponnesian War (431–404 BC), which was fought between the Peloponnesian League (led by Sparta) and the Delian League (led by Athens). It was written by Thucydides, an Athenian historian who also served as an Athenian general during the war. His account of the conflict is widely considered to be a classic and regarded as one of the earliest scholarly works of history. The History is divided into eight books.", "9783968656762", "https://cdn.kobo.com/book-images/d4a3769f-012a-48dc-a096-08e287b03557/1200/1200/False/the-history-of-the-peloponnesian-war-with-18-illustrations-and-a-free-audio-link.jpg", 738, new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "The History of the Peloponnesian War" },
                    { 13, 18, "https://dn790008.ca.archive.org/0/items/cu31924022342871/cu31924022342871.pdf", 2, "The first complete English translation of the Nobel Prize-winner’s literary masterpiece A Penguin Classic Mysteries is the story of Johan Nilsen Nagel, a mysterious stranger who suddenly turns up in a small Norwegian town one summer—and just as suddenly disappears. Nagel is a complete outsider, a sort of modern Christ treated in a spirit of near parody. He condemns the politics and thought of the age, brings comfort to the “insulted and injured,” and gains the love of two women suggestive of the biblical Mary and Martha. But there is a sinister side of him: in his vest he carries a vial of prussic acid... The novel creates a powerful sense of Nagel's stream of thought, as he increasingly withdraws into the torture chamber of his own subconscious psyche. For more than seventy years, Penguin has been the leading publisher of classic literature in the English-speaking world. With more than 1,800 titles, Penguin Classics represents a global bookshelf of the best works throughout history and across genres and disciplines. Readers trust the series to provide authoritative texts enhanced by introductions and notes by distinguished scholars and contemporary authors, as well as up-to-date translations by award-winning translators.", "9780141186184", "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1650844397l/60784591.jpg", 356, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Mystery of mysteries" },
                    { 14, 19, "https://publicdomainlibrary.org/en/ebooks/the-picture-of-dorian-gray?gad_source=1&gad_campaignid=22457961356&gclid=CjwKCAjwjffHBhBuEiwAKMb8pMSgkz-tGttv47qIsPHlijqk2n0fVPqoWapPnusGOGzyQVWHU7wi5BoCWecQAvD_BwE", 2, "The Picture of Dorian Gray is the only published novel by Oscar Wilde, appearing as the lead story in Lippincott's Monthly Magazine on 20 June 1890, printed as the July 1890 issue. The magazine's editors feared the story was indecent as submitted, so they censored roughly 500 words, without Wilde's knowledge, before publication. But even with that, the story was still greeted with outrage by British reviewers, some of whom suggested that Wilde should be prosecuted on moral grounds, leading Wilde to defend the novel aggressively in letters to the British press. Today, Wilde's fin de siècle novella is considered a classic. This new edition from Immortal Books includes footnotes and images.", "9780359788330", "https://storage.googleapis.com/media365-live.appspot.com/266c3ce1-c23a-4770-bbe7-8e37467cc81c/0d22b809-2cf9-463f-a0d4-2bbb98dbc5a9/eabb424e-d460-44c3-ab64-ef47be8b87f5.jpg", 188, new DateTime(2019, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Picture of Dorian Gray" },
                    { 15, 20, "https://www.gutenberg.org/files/84/84-h/84-h.htm", 2, "Mary Shelley's 'Frankenstein' is a groundbreaking work of gothic literature that explores themes of ambition, isolation, and the consequences of playing god. Written in an epistolary format, the reader is drawn into the chilling tale of Victor Frankenstein and his creation, the monster. Shelley's descriptive prose and use of multiple narrators create a sense of foreboding and unease, making 'Frankenstein' a timeless classic in the literary canon. The novel also raises ethical questions about scientific responsibility and the limits of human knowledge, making it a thought-provoking read for modern audiences. Mary Shelley's personal experiences, including the death of her own children and her tumultuous relationship with Percy Bysshe Shelley, undoubtedly influenced the creation of 'Frankenstein.' Her unique perspective as a female author in the 19th century adds layers of depth to the story, highlighting the societal expectations and constraints faced by women of her time. I highly recommend 'Frankenstein' to readers who enjoy thought-provoking literature that delves into the darker aspects of human nature and morality.", "EAN:8596547791485", "https://img.perlego.com/book-covers/2501062/9782378072452_300_450.webp", 234, new DateTime(2023, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Frankenstein" },
                    { 16, 21, "https://dn721907.ca.archive.org/0/items/in.ernet.dli.2015.93420/2015.93420.Mrs-Dalloway.pdf", 2, "Heralded as Virginia Woolf's greatest novel, this is a vivid portrait of a single day in a woman's life. When we meet her, Mrs. Clarissa Dalloway is preoccupied with the last-minute details of party preparation while in her mind she is something much more than a perfect society hostess. As she readies her house, she is flooded with remembrances of faraway times. And, met with the realities of the present, Clarissa reexamines the choices that brought her there, hesitantly looking ahead to the unfamiliar work of growing old. \"Mrs. Dalloway was the first novel to split the atom. If the novel before Mrs. Dalloway aspired to immensities of scope and scale, to heroic journeys across vast landscapes, with Mrs. Dalloway Virginia Woolf insisted that it could also locate the enormous within the everyday; that a life of errands and party-giving was every bit as viable a subject as any life lived anywhere; and that should any human act in any novel seem unimportant, it has merely been inadequately observed. The novel asan art form has not been the same since. \"Mrs. Dalloway also contains some of the most beautiful, complex, incisive and idiosyncratic sentences ever written in English, and that alone would be reason enough to read it. It is one of the most moving, revolutionary artworks of the twentieth century.\" --Michael Cunningham, author of The Hours", "STANFORD:36105003773616", "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg", 312, new DateTime(1925, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mrs. Dalloway" },
                    { 17, 22, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrhv8HOOGw56ABHammfAbunGUhTAi_F_2eQQ&s", 2, "''The Street of Crocodiles'' by Bruno Schulz (1892-1942) was first published in Polish in 1934; this English translation was first published in the US by Walker and Company in 1963, public domain. A novel that blends the real and the fantastic, from \"one of the most original imaginations in modern Europe\" (Cynthia Ozick). The Street of Crocodiles in the Polish city of Drogobych is a street of memories and dreams where recollections of Bruno Schulz's uncommon boyhood and of the eerie side of his merchant family's life are evoked in a startling blend of the real and the fantastic. Most memorable - and most chilling - is the portrait of the author's father, a maddened shopkeeper who imports rare birds' eggs to hatch in his attic, who believes tailors' dummies should be treated like people, and whose obsessive fear of cockroaches causes him to resemble one. Bruno Schulz, a Polish Jew killed by the Nazis in 1942, is considered by many to have been the leading Polish writer between the two world wars.", "9788087830277", "https://archive.org/details/streetofcrocodil00schu_0", 136, new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Street of Crocodiles" },
                    { 18, 23, "https://cdn.bookey.app/files/pdf/book/en/the-visitor.pdf", 2, "\"Sergeant Amy Callan and Lieutenant Caroline Cook have a lot in common. Both were army high-flyers. Both were acquainted with Jack Reacher. Both were forced to resign from the service. Now they're both dead. Both were found in their own home, naked, in a bath full of paint. Both apparent victims of an army man. A loner, a smart guy with a score to settle, a ruthless vigilante. A man just like Jack Reacher.\"--Cover.", "9780553811889", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwLvDmcI4YiQIE4eU9mKt_NuPUVulD8hiZxA&ss", 516, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Visitor" },
                    { 19, 24, "https://www.gutenberg.org/files/4217/4217-h/4217-h.htm", 2, "James JoyceÕs 1916 novella A Portrait of the Artist as a Young Man is about the early manhood of Stephen Dedalus, later one of the leading characters in Ulysses. StephenÕs growing self-awareness as an artist forces him to reject the whole narrow world in which he has been brought up, including family ties, nationalism, and the Catholic religion.", "9781387679249", "https://archive.org/services/img/portrait_artist_pb_librivox/full/pct:500/0/default.jpg", 194, new DateTime(2018, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Portrait of the Artist as a Young Man" },
                    { 20, 25, "https://www.sas.upenn.edu/~cavitch/pdf-library/Woolf_Jacob_s_Room.pdf", 2, "A Nonconformist Novel with No Central Character “Either we are men, or we are women. Either we are cold, or we are sentimental. Either we are young, or growing old. In any case life is but a procession of shadows, and God knows why it is that we embrace them so eagerly, and see them depart with such anguish, being shadows.” - Virginia Woolf, Jacob's Room Jacob’s Room is not your typical Victorian English novel. The fact that there is no real protagonist stands out the most. Jacob is not actually a character, only a collection of memories, feelings and sensations. His life is like a room seen through the eyes of other people. This Xist Classics edition has been professionally formatted for e-readers with a linked table of contents. This eBook also contains a bonus book club leadership guide and discussion questions. We hope you’ll share this book with your friends, neighbors and colleagues and can’t wait to hear what you have to say about it.", "9781681951607", "https://www.epubbooks.com/images/covers/woolf-jacobs-room.jpg", 183, new DateTime(2015, 8, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jacob's Room" },
                    { 21, 26, "https://archive.org/details/holidayoflove00mcna", 3, "In New York City in the late 1800s, a beautiful but clumsy angel turns a lonely man's life around.... In medieval Scotland, the intrigues of a Christmas Mass imperil two Highland lovers....In Regency London, a world-weary lord receives an outrageous proposal....And in modern-day Colorado, a clever twelve-year-old plays matchmaker for his bighearted but impractical mother.", "9781416517214", "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg", 386, new DateTime(2005, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Holiday of Love" },
                    { 22, 30, "https://www.gutenberg.org/files/1260/1260-h/1260-h.htm", 3, "Bronte's infamous Gothic novel tells the story of orphan Jane, a child of unfortunate circumstances. Raised and treated badly by her aunt and cousins and eventually sent away to a cruel boarding school, it is not until Jane becomes a governess at Thornfield that she finds happiness. Meek, measured, but determined, Jane soon falls in love with her brooding and stormy master, Mr Rochester, but it is not long before strange and unnerving events occur in the house and Jane is forced to leave Thornfield to pursue her future.", "9780007866090", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAYviU6qJ8Y4lqDwBrA7s1fN7ZWGErMtRBcQ&s", 462, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jane Eyre" },
                    { 23, 31, "https://giove.isti.cnr.it/demo/eread/Libri/joy/Pride.pdf", 3, "The text of Pride and Prejudice is the 1813 first edition text.", "9780192815033", "https://storage.googleapis.com/media365-live.appspot.com/266c3ce1-c23a-4770-bbe7-8e37467cc81c/22ce3cd6-766e-420b-98a2-bbdcd42d0605/9a042421-4511-4505-91dd-5f9b3429479c.jpg", 388, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pride and Prejudice" },
                    { 24, 32, "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1610568034i/55509539.jpg", 3, "Beautiful Taylor Baker, whose fiance has eloped with her odious cousin and whose greedy uncle has his own plans for her, escapes to Montana with rough-edged American Lucas Ross.", "9780671870966", "https://www.scribd.com/doc/300749775/Prince-Charming", 564, new DateTime(1995, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Prince Charming" },
                    { 25, 33, "https://icrrd.com/public/media/14-05-2021-091024Me-Before-You.pdf", 3, "Taking a job as an assistant to extreme sports enthusiast Will, who is wheelchair bound after a motorcycle accident, Louisa struggles with her employer's acerbic moods and learns of his shocking plans before demonstrating to him that life is still worth living.", "9780143109464", "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg", 402, new DateTime(2016, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Me Before You (Movie Tie-In)" },
                    { 26, 34, "https://archive.org/details/sunsetinsttropez0000stee_q3j8", 3, "Taking a vacation together to grieve over the death of one of their group, five friends are dismayed by the ramshackle mansion they find instead of the garden villa they expected, and the unexpected appearance of the new girlfriend of the widowed husband.", "UOM:39015055087590", "https://livrariapublica.com.br/capa/por-do-sol-em-saint-tropez-danielle-steel-pdf-B0176TJFF8.webp", 248, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sunset in St. Tropez" },
                    { 27, 35, "https://archive.org/details/lastvoyageofvale0000mont_v8n7", 3, "\"Originally published in Great Britain in 2005 by Hodder and Stoughton\"--T.p. verso.", "9780743299435", "https://archive.org/services/img/lastvoyageofvale0000mont_v8n7/full/pct:200/0/default.jpg", 417, new DateTime(2006, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Last Voyage of the Valentina" },
                    { 28, 34, "https://archive.org/details/specialdelivery0000dani", 3, "Tells the story of Jack Watson, a wealthy Beverly Hills businessman and widower, who falls in love with his daughter-in-law's mother and together they discover a relationship marked by challenges and surprises.", "UOM:39015041359921", "https://media.oceanofpdf.com/2023/04/PDF-EPUB-Special-Delivery-A-short-crime-fiction-story-Case-Files-pocket-sized-murder-mysteries-by-Rachel-Amphlett-Download.jpg", 232, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Special Delivery" },
                    { 29, 36, "https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwiPk4Ko_cGQAxXgW_EDHfX3LOEQFnoECBgQAQ&url=https%3A%2F%2Farchive.org%2Fdetails%2Floveonlyonce00lind&usg=AOvVaw3eaa1Mhc73cUJ1Du7Tso0J&opi=89978449", 3, "The exquisite niece of Lord Edward and Lady Charlotte Malory, Regina Ashton is outraged over her abduction by the arrogant, devilishly handsome Nicholas Eden, and is determined to make the rogue pay, with his heart.", "9780739446461", "https://image.ebooks.com/cover/692903.jpg", 452, new DateTime(1985, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Love Only Once" },
                    { 30, 34, "https://archive.org/services/img/toxicbachelors0000dani", 3, "Three daunting bachelors embark on a journey to the Mediterranean where they face women who challenge their deepest relationship phobias, sparking big changes in the once-carefree trio that just might put an end to their carousing days.", "UOM:39015062619377", "https://archive.org/details/toxicbachelors0000dani", 344, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toxic Bachelors" },
                    { 31, 37, "https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwj-8afY_cGQAxVWBdsEHQ61D-sQFnoECBgQAQ&url=https%3A%2F%2Fdn720006.ca.archive.org%2F0%2Fitems%2Fenglish-collections-k-z%2Fmagician%2527s%2520nephew%252C%2520The%2520-%2520C.%2520S.%2520Lewis.pdf&usg=AOvVaw0oCLuQynRIlzrwUbyuWEkv&opi=89978449", 4, "The first book in The Chronicles of Narnia is now available in a full-color, unabridged gift edition that includes all of the original Pauline Baynes illustrations.", "9780060530846", "https://churchsource.com/cdn/shop/products/9780064471107_988c6bba-41a4-4f41-ac7b-52f6154e499f_1024x.jpg?v=1644428660", 122, new DateTime(2003, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Magician's Nephew Color Gift Edition" },
                    { 32, 38, "https://archive.org/details/wizardofearthsea00legu_1", 4, "A boy grows to manhood while attempting to subdue the evil he unleashed on the world as an apprentice to the Master Wizard.", "9780547851396", "https://cdn.kobo.com/book-images/cdebd2d5-7b6e-4447-9990-4630e6c29e35/1200/1200/False/a-wizard-of-earthsea-1.jpg", 267, new DateTime(2012, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A Wizard of Earthsea" },
                    { 33, 39, "https://www.scribd.com/document/720685287/The-Book-about-Moomin-Mymble-and-Little-My", 4, "Finnish artist Tove Jansson's Moomin stories have been continually in print for more than half a century, in 35 languages. They are among Europe's best loved and enduring children's classics, and through the TV animation (BBC2), the warm-hearted, whimsical creatures of Moomin valley have been brought to a new younger British audience.Introducing the first Sort Of Children's Classic in a new English version by Sophie Hannah. Sort of Books proudly presents the original full colour Moomin picture book with its irresistible cut-out page designs and playful rhyming text in a new version by one of Britain's star poets.", "9780953522743", "https://imgv2-2-f.scribdassets.com/img/document/720685287/original/6bfbb8842c/1?v=1", 0, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Moomin, Mymble and Little My" },
                    { 34, 40, "https://ia903107.us.archive.org/35/items/j-r-r-tolkien-lord-of-the-rings-01-the-fellowship-of-the-ring-retail-pdf/j-r-r-tolkien-lord-of-the-rings-01-the-fellowship-of-the-ring-retail-pdf.pdf", 4, "Contains the complete set of the six books of Lord of the Rings.", "PSU:000045256417", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s", 1176, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of the Rings" },
                    { 35, 42, "http://birrell.org/andrew/alice/lGlass.pdf", 4, "Publisher description", "9780688120498", "https://www.pdfbooksworld.com/image/cache/catalog/256-500x500.jpg", 248, new DateTime(1993, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Through the Looking-Glass" },
                    { 36, 43, "https://www.samizdat.qc.ca/arts/lit/PDFs/VoyageoftheDawnTreader_CSL.pdf", 4, "The \"Dawn Treader\" is the first ship Narnia has seen in centuries. King Caspian has built it for his voyage to find the seven lords, good men whom his evil uncle Mizaz banished when he usurped the throne. The journey takes Edmund, Lucy, and their cousin Eustace to the Eastern Islands, beyond the Silver Sea, toward Aslan's country at the End of the World. Illustrations.", "9780006716655", "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094", 196, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Voyage of the Dawn Treader" },
                    { 37, 43, "https://imgv2-2-f.scribdassets.com/img/document/432919347/original/c0ed155ebd/1?v=1", 4, "The best-selling rack edition of The Lion, the Witch and the Wardrobe now has a movie still cover and an eight-page movie still insert! \"Excellent for Homeschool Use\"", "PSU:000028266402", "https://www.samizdat.qc.ca/arts/lit/PDFs/LionWitchWardrobe_CSL.pdf", 168, new DateTime(1950, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lion, the Witch and the Wardrobe" },
                    { 38, 44, "https://web.seducoahuila.gob.mx/biblioweb/upload/the_wonderful_wizard_of_oz.pdf", 4, ".0000000000This is the story of Dorothy and her little dog Toto, who are carried away from Kansas by a cyclone and transported to the wonderful world of Oz. She meets three companions - the Scarecrow, the Tin Woodman and the Cowardly Lion - and the three journey to the Emerald City of Oz to ask the Wizard of Oz to give them their hearts' desires, which in Dorothy's case is to return home to Kansas. On their way to Oz and while fulfilling the tasks that the surprising Wizard asks of them they encounter witches, winged monkeys, the Deadly Desert, fighting trees and magic shoes.This edition is evocatively illustrated with the original drawings of W. W. Denslow, with an Afterword by Ned Halley.", "9781905716524", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhsCGaMxMJsWSl5RMQ7za1U_HTzWSNhSJn_g&s", 188, new DateTime(2009, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wizard of Oz" },
                    { 39, 45, "https://www.sas.upenn.edu/~cavitch/pdf-library/Grahame_Wind_in_the_Willows_1908.pdf", 4, "The escapades of four animal friends who live along a river in the English countryside--Toad, Mole, Rat, and Badger.", "UOM:39015008859509", "https://www.rif.org/sites/default/files/images/2022/06/14/Book_Covers/wind-in-willows.jpg", 322, new DateTime(1908, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Wind in the Willows" },
                    { 40, 46, "https://cdn.bookey.app/files/pdf/book/en/bloodmarked.pdf", 4, "\"When the leaders of the Order reveal that they will do everything in their power to keep the approaching demon war a secret, Bree and her friends go on the run so she can learn how to control her devastating new powers.\"--", "9781534441637", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s", 576, new DateTime(2022, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bloodmarked" },
                    { 41, 47, "https://www.by-the-way.fr/wp-content/uploads/2021/02/Murder-on-the-Orient-Express-1.pdf", 5, "QBD Murder on the Orient Express", "9780007948697", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSL6oNHnP30AFFa0TerAy860nUAY1jNCpyUOg&s", 0, new DateTime(2015, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "QBD Murder on the Orient Express" },
                    { 42, 48, "https://books.google.com/books/about/QBD_Murder_on_the_Orient_Express.html?hl=&id=VHYXrgEACAAJ", 5, "Harvard professor Robert Langdon receives an urgent late-night phone call while on business in Paris: the elderly curator of the Louvre, Jacques Sauni're, has been brutally murdered inside the museum. Alongside the body, police have found a series of baffling codes. As Langdon and a gifted French cryptologist, Sophie Neveu, begin to sort through the bizarre riddles, they are stunned to find a trail that leads to the works of Leonardo Da Vinci - and suggests the answer to a mystery that stretches deep into the vault of history. Langdon suspects the late curator was involved in the Priory of Sion - a centuries old secret society - and has sacrificed his life to protect the Priory's most sacred trust: the location of a vastly important religious relic hidden for centuries. But it now appears that Opus Dei, a clandestine sect that has long plotted to seize the Prirory's secret, has now made its move. Unless Langdon and Neveu can decipher the labyrinthine code and quickly assemble the pieces of the puzzle, the Priory's secret - and a stunning historical truth - will be lost forever. Breaking the mould of traditional suspense novels, The DA VINCI CODE is simultaneously lightning-paced, intelligent and intricately layered with remarkable research and detail. And in this exclusive edition Dan Brown allows the reader behind the scenes of the novel which now incorporates over 150 photographs and illustrations throughout the text showing the rich historical tapestry from which he drew his inspiration. The visual sources which provide both the backdrop and the stimulus for the novel's action are revealed for the first time and uniquely complement the reading experience.", "9780593054253", "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg", 484, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Da Vinci Code" },
                    { 43, 49, "https://englishprva.weebly.com/uploads/8/8/2/3/88239198/the_curious_incident_of_the_dog_in_the_night_time.pdf", 5, "YA. Murder mystery. Despite his overwhelming fear of interacting with people, Christopher, a mathematically-gifted, autistic fifteen-year-old boy, decides to investigate the murder of a neighbour's dog and uncovers secret information about his mother. Whitbread book of the year 2003. WAYRBA list 2005.", "UOM:39015062063501", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtlv5N0MAfZQuADdOiaWgIZb8jaciZxqMYxw&s", 288, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Curious Incident of the Dog in the Night-time" },
                    { 44, 50, "https://cdn.bookey.app/files/pdf/book/en/the-black-tower.pdf", 5, "Adam Dalgliesh responds to an invitation to visit an old family friend, the chaplain at a private home for the disabled in Dorset. On arrival he discovers that his host has died suddenly.", "9780743219617", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDNcrRkQWMvXON46YjBGwXfOEMR4jAL8UWhA&s", 352, new DateTime(2001, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Black Tower" },
                    { 45, 47, "https://ia801500.us.archive.org/18/items/in.ernet.dli.2015.88942/2015.88942.The-A-B-C-Murders-A-Hercule-Poirot-Mystery.pdf", 5, "When Alice Ascher is murdered in Andover, Hercule Poirot is already onto the clues. Alphabetically speaking, it's one down, 25 to go. This classic mystery is now repackaged in a digest-sized edition for young adults. Reissue.", "9780006167242", "https://hive.dmmserver.com/media/640/97800071/9780007184798.jpg", 224, new DateTime(1993, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The ABC Murders" },
                    { 46, 47, "https://archive.org/details/goldenballothers00chri_0", 5, "It was an offer the St. Vincent family could not refuse -- a splendid mansion, complete with servants, with nothing asked for in return! But young Rupert St. Vincent suspected a sinister trap ...", "9780425099223", "https://m.media-amazon.com/images/I/810O+cRm1DL._AC_UF1000,1000_QL80_.jpg", 244, new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Golden Ball and Other Stories" },
                    { 47, 51, "https://publicdomainlibrary.org/en/ebooks/crime-and-punishment?gad_source=1&gad_campaignid=22451384280&gclid=CjwKCAjwjffHBhBuEiwAKMb8pBjy-e_ly5ktSuU5W0sa-Ycd7i8lj_HgcPMuML_olDUDvpEaf9emqRoCw2gQAvD_BwE", 5, "Introduction by W. J. Leatherbarrow; Translation by Richard Pevear and Larissa Volokhonsky Copyright © Libri GmbH. All rights reserved.", "RUTGERS:390300038488030", "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg", 520, new DateTime(1955, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Crime and Punishment" },
                    { 48, 52, "https://archive.org/details/seekingwhomhemay00fred", 5, "\"A small mountain community in the French Alps is roused to terror when they awaken each morning to find yet another of their sheep with its throat torn out. One of the villagers thinks it might be a werewolf, and when she's found killed in the same manner, people begin to wonder if she might have been right. Suspicion falls on Massart, a loner living on the edge of town\"--Publisher website (April 2007).", "9780743284028", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRiSPUuLhWO8R55NFwa9CFni3bZb5YRy32hHQ&s", 307, new DateTime(2006, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Seeking Whom He May Devour" },
                    { 49, 53, "https://gutenberg.ca/ebooks/teyj-daughteroftime/teyj-daughteroftime-00-h-dir/teyj-daughteroftime-00-h.html", 5, "A hospitalized English policeman reconstructs historical evidence concerning Richard III's role in the murder of Edward IV's two sons.", "9780020545507", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTi55-EYvE9QWrcLwywNEee5WGxayNGrwJdAw&s", 212, new DateTime(1988, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Daughter of Time" },
                    { 50, 54, "https://archive.org/details/houseatriverto00mort", 5, "Ninety-eight-year-old Grace Bradley is visited by a young director who takes her back to Riverton House where she reveals the secret behind the death of a young poet in the summer of 1924.", "9781416550532", "https://media.oceanofpdf.com/2019/10/PDF-EPUB-The-House-at-Riverton-Download.jpg", 496, new DateTime(2009, 3, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The House at Riverton" },
                    { 51, 55, "https://classicalastrologer.com/wp-content/uploads/2017/12/c-s-lewis-the-discarded-image.pdf", 6, "Hailed as \"the final memorial to the work of a great scholar and teacher and a wise and noble mind,\" this work paints a lucid picture of the medieval world view, as historical and cultural background to the literature of the Middle Ages and Renaissance.", "9780521477352", "https://img.perlego.com/book-covers/588293/9780062313706_300_450.webp", 248, new DateTime(1994, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Discarded Image" },
                    { 52, 56, "https://online.flipbuilder.com/fdyv/lcvg/files/mobile/1.jpg?201020211740", 6, "In the first authoritative biography of Alexander the Great written for a general audience in a generation, classicist and historian Philip Freeman tells the remarkable life of the great conqueror. The celebrated Macedonian king has been one of the most enduring figures in history. He was a general of such skill and renown that for two thousand years other great leaders studied his strategy and tactics, from Hannibal to Napoleon, with countless more in between. He flashed across the sky of history like a comet, glowing brightly and burning out quickly: crowned at age nineteen, dead by thirty-two. He established the greatest empire of the ancient world; Greek coins and statues are found as far east as Afghanistan. Our interest in him has never faded. Alexander was born into the royal family of Macedonia, the kingdom that would soon rule over Greece. Tutored as a boy by Aristotle, Alexander had an inquisitive mind that would serve him well when he faced formidable obstacles during his military campaigns. Shortly after taking command of the army, he launched an invasion of the Persian empire, and continued his conquests as far south as the deserts of Egypt and as far east as the mountains of present-day Pakistan and the plains of India. Alexander spent nearly all his adult life away from his homeland, and he and his men helped spread the Greek language throughout western Asia, where it would become the lingua franca of the ancient world. Within a short time after Alexander’s death in Baghdad, his empire began to fracture. Best known among his successors are the Ptolemies of Egypt, whose empire lasted until Cleopatra. In his lively and authoritative biography of Alexander, classical scholar and historian Philip Freeman describes Alexander’s astonishing achievements and provides insight into the mercurial character of the great conqueror. Alexander could be petty and magnanimous, cruel and merciful, impulsive and farsighted. Above all, he was ferociously, intensely competitive and could not tolerate losing—which he rarely did. As Freeman explains, without Alexander, the influence of Greece on the ancient world would surely not have been as great as it was, even if his motivation was not to spread Greek culture for beneficial purposes but instead to unify his empire. Only a handful of people have influenced history as Alexander did, which is why he continues to fascinate us.", "9781439193280", "https://www.defence.lk/upload/ebooks/Alexander%20the%20Great.pdf", 418, new DateTime(2011, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander the Great" },
                    { 53, 57, "https://www.academia.edu/123650107/The_Making_of_the_Roman_Army_From_Republic_to_Empire", 6, "The Making of the Roman Army", "UOM:39015040081864", "https://0.academia-photos.com/attachment_thumbnails/118032214/mini_magick20240907-1-c0ef9j.png?1725739352", 298, new DateTime(1984, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Making of the Roman Army" },
                    { 54, 58, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNPK5irLXh4fL2zwTrziJM8ZMK-b_K0ZLMKw&s", 6, "In this history, Helen C. Roundtree traces events that shaped the lives of the Powhatan Indians of Virginia, from their first encounter with English colonists, in 1607, to their present-day way of life and relationship to the state of Virginia and the federal government. Roundtree’s examination of those four hundred years misses not a beat in the pulse of Powhatan life. Combining meticulous scholarship and sensitivity, the author explores the diversity always found among Powhatan people, and those people’s relationships with the English, the government of the fledgling United States, the Union and the Confederacy, the U.S. Census Bureau, white supremacists, the U.S. Selective Service, and the civil rights movement.", "9780806128498", "https://archive.org/details/pocahontasspeopl0000roun", 420, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pocahontas's People" },
                    { 55, 59, "http://www.public-library.uk/dailyebook/Complete%20works%20of%20Oscar%20Wilde%20(1921)%201.pdf", 6, "This set comprises 40 volumes covering 19th and 20th century European and American authors. These volumes will be available as a complete set, mini boxed sets (by theme) or as individual volumes. This second set compliments the first 68 volume set of Critical Heritage published by Routledge in October 1995.", "9780415159524", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781627933650/the-essential-oscar-wilde-9781627933650_hr.jpg", 454, new DateTime(1997, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Oscar Wilde" },
                    { 56, 60, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQo_RV5oIFgxcTAFME084XVW6DQEOMihwYgmQ&s", 6, "History Professor Jerry Muller locates the origins of modern conservatism within the Enlightenment and distinguishes conservatism from orthodoxy. Reviewing important specimens of analysis from the mid18th century through our own day, Muller demonstrates that characteristic features of conservative argument recur over time and across national borders.", "9780691037110", "https://www.eolss.net/sample-chapters/C04/E6-32-04-03.pdfs", 476, new DateTime(1997, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Conservatism" },
                    { 57, 61, "https://archive.org/details/constantinopleca0000harr_q5n1", 6, "This book examines the intriguing interaction between the spiritual and the political whilst reconstructs the awe-inspiring city in its heyday of 1200.", "9780826430861", "https://0.academia-photos.com/attachment_thumbnails/90991769/mini_magick20220913-1-bv6h0f.png?1663060204", 308, new DateTime(2009, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Constantinople: Capital of Byzantium" },
                    { 58, 62, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRa3veMqYITcruRWDhinKwL1BbD3aSanEqF6Q&s", 6, "Ukraine is currently embroiled in a tense battle with Russia to preserve its economic and political independence. But today's conflict is only the latest in a long history of battles over Ukraine's existence as a sovereign nation. As award-winning historian Serhii Plokhy argues in The Gates of Europe, we must examine Ukraine's past in order to understand its fraught present and likely future. Situated between Europe, Russia, and the Asian East, Ukraine was shaped by the empires that have used it as astrategic gateway between East and West—from the Romans and Ottomans to the Third Reich and the Soviet Union,all have engaged in global fights for supremacy on Ukrainian soil.Each invading army left a lasting mark on the landscape and on the population, making modern Ukraine an amalgam of competing cultures.Authoritative and vividly written, The Gates of Europe will be the definitive history of Ukraine for years to come.", "9780465073948", "https://shron3.chtyvo.org.ua/Plokhii_Serhii/The_Gates_of_Europe__A_History_of_Ukraine_anhl.pdf", 433, new DateTime(2015, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Gates of Europe" },
                    { 59, 63, "https://www.academia.edu/33919901/The_Language_Loss_of_the_Indigenous", 6, "This volume traces the theme of the loss of language and culture in numerous post-colonial contexts. It establishes that the aphasia imposed on the indigenous is but a visible symptom of a deeper malaise — the mismatch between the symbiotic relation nurtured by the indigenous with their environment and the idea of development put before them as their future. The essays here show how the cultures and the imaginative expressions of indigenous communities all over the world are undergoing a phase of rapid depletion. They unravel the indifference of market forces to diversity and that of the states, unwilling to protect and safeguard these marginalized communities. This book will be useful to scholars and researchers of cultural and literary studies, linguistics, sociology and social anthropology, as well as tribal and indigenous studies.", "9781317293132", "https://static.wixstatic.com/media/5ac455_64db10cfe2ab471fb0a3de1c37c1b854~mv2.jpg/v1/fill/w_638,h_1000,al_c,q_85,usm_0.66_1.00_0.01/5ac455_64db10cfe2ab471fb0a3de1c37c1b854~mv2.jpg", 294, new DateTime(2016, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Language Loss of the Indigenous" },
                    { 60, 66, "https://ia601303.us.archive.org/31/items/historyofarmenia01cham/historyofarmenia01cham.pdf", 6, "The volume is an easy reading and a must for the beginner student and interested party of the history of Armenia as well as for those more familiar with Armenian and its history. The author, an expert on Armenian history, has masterfully covered all aspects of the Armenian history such as Armenian literature, Armenian Church, the history of Armenian old and modern language, architecture, sculpture, music etc. along with all the historical events, starting from the beginning of the human civilization and that of Armenian one to the modern era of Armenia.", "9781604449112", "https://archive.org/services/img/historyofarmenia0000bour/full/pct:200/0/default.jpg", 414, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A History of Armenia" },
                    { 61, 67, "https://ia600100.us.archive.org/5/items/cu31924005641380/cu31924005641380.pdf", 7, "The Lord of Uraniborg is a comprehensive biography of Tycho Brahe, father of modern astronomy, famed alchemist and littérateur of the sixteenth-century Danish Renaissance. Written in a lively and engaging style, Victor Thoren's biography offers interesting perspectives on Tycho's life and presents alternative analyses of virtually every aspect of his scientific work. A range of readers interested in astronomy, history of astronomy and the history of science will find this book fascinating.", "9780521351584", "https://assets.cambridge.org/97805213/51584/large_cover/9780521351584i.jpg", 537, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lord of Uraniborg" },
                    { 62, 69, "https://archive.org/details/adictionarygree08smitgoog", 7, "Dictionary of Greek and Roman Biography and Mythology: Earinus-Nyx", "UCAL:$B415016", "https://assets.cambridge.org/97811080/60790/cover/9781108060790.jpg", 1238, new DateTime(1846, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dictionary of Greek and Roman Biography and Mythology: Earinus-Nyx" },
                    { 63, 70, "https://institutes.abu.edu.ng/idr/public/assets/docs/Eat,%20Pray,%20Love%20(%20PDFDrive%20).pdf", 7, "The Number One international bestseller, Eat, Pray Love is a journey around the world, a quest for spiritual enlightenment and a story for anyone who has battled with divorce, depression and heartbreak.", "9780747585664", "https://online.fliphtml5.com/gutjj/zwbj/files/large/1.webp?1604750286&1604750286", 385, new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eat, Pray, Love" },
                    { 64, 71, "https://archive.org/details/drownedsaved0000levi", 7, "In his final book before his death, Primo Levi returns once more to his time at Auschwitz in a moving meditation on memory, resiliency, and the struggle to comprehend unimaginable tragedy. Drawing on history, philosophy, and his own personal experiences, Levi asks if we have already begun to forget about the Holocaust. His last book before his death, Levi returns to the subject that would define his reputation as a writer and a witness. Levi breaks his book into eight essays, ranging from topics like the unreliability of memory to how violence twists both the victim and the victimizer. He shares how difficult it is for him to tell his experiences with his children and friends. He also debunks the myth that most of the Germans were in the dark about the Final Solution or that Jews never attempted to escape the camps. As the Holocaust recedes into the past and fewer and fewer survivors are left to tell their stories, The Drowned and the Saved is a vital first-person testament. Along with Elie Wiesel and Hannah Arendt, Primo Levi is remembered as one of the most powerful and perceptive writers on the Holocaust and the Jewish experience during World War II. This is an essential book both for students and literary readers. Reading Primo Levi is a lesson in the resiliency of the human spirit.", "9781501167638", "https://img.perlego.com/book-covers/2453188/9781788850278_300_450.webp", 208, new DateTime(2017, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Drowned and the Saved" },
                    { 65, 72, "https://ati.dae.gov.in/ati12052021_9.pdf", 7, "Biography", "WISC:89094373321", "https://marketplace.canva.com/EADaiR6K_s8/1/0/1003w/canva-white-night-sky-autobiography-book-cover-a71TNv3gBWU.jpg", 532, new DateTime(1868, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biography" },
                    { 66, 73, "https://ebook.micsapp.com/books/a54b5897bc", 7, "After the Communist Revolution, Desmond Shum's grandfather was marked as belonging to a \"black category\" that included former landlords and rich peasants--meaning the Shums would be stigmatized and impoverished. As Desmond was growing up, he vowed his life would be different. Through hard work and sheer tenacity Shum earned an American college degree and returned to China to establish himself in business. There, he met his future wife, the highly intelligent and equally ambitious Whitney Duan who was determined to make her mark within China's male-dominated society. Whitney and Desmond formed an effective team and, aided by relationships they formed with top members of the red aristocracy, vaulted into China's billionaire class. Soon they were developing the massive air cargo facility at Beijing International Airport, and they followed that feat with the creation of one of Beijing's premier hotels. They were dazzlingly successful, traveling in private jets, funding multi-million-dollar buildings and endowments, and purchasing expensive homes, vehicles, and art. But in 2017, their fates diverged irrevocably when Desmond, while residing overseas with his son, learned that his now ex-wife Whitney had vanished along with three coworkers. This is both Desmond's story and Whitney's, because she cannot tell it herself.", "9781982156169", "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781982156176/red-roulette-9781982156176_hr.jpg", 336, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red Roulette" },
                    { 67, 74, "https://archive.org/details/myheartismyownli0000guyj_x8h0", 7, "This book is a reinterpretation of the life of Mary, Queen of Scots. John Guy returns to the archives to explode the myths and correct the inaccuracies that surround this most fascinating monarch. He also explains a central mystery: why Mary would have consented to marry - only three months after the death of her second husband, Lord Darnley - the man who was said to be his killer, the Earl of Bothwell. He also solves, through careful re-examination of the Casket Letters, the secret behind Darnley's spectacular assassination at Kirk o'Field.", "9781841157535", "https://cdn.penguin.co.uk/dam-assets/books/9780241963777/9780241963777-jacket-large.jpg", 612, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "My Heart is My Own" },
                    { 68, 75, "https://ia803108.us.archive.org/0/items/fourgospelstrans03camp/fourgospelstrans03camp.pdf", 7, "\"The publication of Richard Burridge's What Are the Gospels? in 1992 inaugurated a transformation in Gospel studies by overturning the previous consensus about Gospel uniqueness. Burridge argued convincingly for an understanding of the Gospels as biographies, a ubiquitous genre in the Graeco-Roman world. To establish this claim, Burridge compared each of the four canonical Gospels to the many extant Graeco-Roman biographies. Drawing on insights from literary theory, he demonstrated that the previously widespread view of the Gospels as unique compositions was false. Burridge went on to discuss what a properly \"biographical\" perspective might mean for Gospel interpretation, which was amply demonstrated in the revised second edition reflecting on how his view had become the new consensus. This third, twenty-fifth anniversary edition not only celebrates the continuing influence of What Are the Gospels?, but also features a major new contribution in which Burridge analyzes recent debates and scholarship about the Gospels. Burridge both answers his critics and reflects upon the new directions now being taken by those who accept the biographical approach. This new edition also features as an appendix a significant article in which he tackles the related problem of the genre of Acts. A proven book with lasting staying power, What Are the Gospels? is not only still as relevant and instructive as it was when first published, but will also doubtlessly inspire new research and scholarship in the years ahead.\"-- Provided by publisher.", "9780802809711", "https://img.perlego.com/book-covers/1588168/9781481308762_300_450.webp", 384, new DateTime(2004, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "What Are the Gospels?" },
                    { 69, 76, "https://archive.org/details/livesofnoblegrec00plutiala", 7, "The Lives of the Noble Grecians and Romaines", "UCSD:31822043010875", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPBgHZR7JwNhOrjgWbXPNs6WZY-SrFGSauew&s", 1214, new DateTime(1579, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Lives of the Noble Grecians and Romaines" },
                    { 70, 76, "https://archive.org/details/plutarchslivestr02plutiala", 7, "Plutarch's Lives Translated from the Original Greek", "UIUC:30112089235862", "https://www.globalgreyebooks.com/content/book-covers/plutarch_plutarchs-lives-large.jpg", 478, new DateTime(1873, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Plutarch's Lives Translated from the Original Greek" },
                    { 71, 79, "https://archive.org/details/isbn_9780415060424", 8, "From ancient times to the present day, the major inventors, discoverers and entrepreneurs from around the world are profiled, and their contribution to society is explained and assessed.", "9780415193993", "https://images.routledge.com/common/jackets/crclarge/978041519/9780415193993.jpg", 1527, new DateTime(1998, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Biographical Dictionary of the History of Technology" },
                    { 72, 81, "https://archive.org/details/scienceforallame0000ruth", 8, "In order to compete in the modern world, any society today must rank education in science, mathematics, and technology as one of its highest priorities. It's a sad but true fact, however, that most Americans are not scientifically literate. International studies of educational performance reveal that U.S. students consistently rank near the bottom in science and mathematics. The latest study of the National Assessment of Educational Progress has found that despite some small gains recently, the average performance of seventeen-year-olds in 1986 remained substantially lower than it had been in 1969. As the world approaches the twenty-first century, American schools--when it comes to the advancement of scientific knowledge--seem to be stuck in the Victorian age.In Science for All Americans, F. James Rutherford and Andrew Ahlgren brilliantly tackle this devastating problem. Based on Project 2061, a scientific literacy initiative sponsored by the American Association for the Advancement of Science, this wide-ranging, important volume explores what constitutes scientific literacy in a modern society; the knowledge, skills, and attitudes all students should acquire from their total school experience from kindergarten through high school; and what steps this country must take to begin reforming its system of education in science, mathematics, and technology.Science for All Americans describes the scientifically literate person as one who knows that science, mathematics, and technology are interdependent enterprises with strengths and limitations; who understands key concepts and principles of science; who recognizes both the diversity and unity of the natural world; and who uses scientific knowledge and scientific ways of thinking for personal and social purposes. Its recommendations for educational reform downplay traditional subject categories and instead highlight the connections between them. It also emphasizes ideas and thinking skills over the memorization of specialized vocabulary. For instance, basic scientific literacy means knowing that the chief function of living cells is assembling protein molecules according to the instructions coded in DNA molecules, but does not mean necessarily knowing the terms \"ribosome\" or \"deoxyribonucleic acid.\"Science, mathematics, and technology will be at the center of the radical changes in the nature of human existence that will occur during the next life span; therefore, preparing today's children for tomorrow's world must entail a solid education in these areas. Science for All Americans will help pave the way for the necessary reforms in America's schools.", "UOM:39015025158489", "https://static.scientificamerican.com/sciam/cache/file/A3A34264-DE16-411B-B52C470B5968527B_source.jpg?w=1200", 282, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Science for All Americans" },
                    { 73, 83, "https://archive.org/details/lifelongkinderga0000resn", 8, "Creative learning -- Projects -- Passion -- Peers -- Play -- Creative society", "9780262037297", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXDdonDaLNMGsKp3gZPB1iWmLayDUGADWCDA&s", 203, new DateTime(2017, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lifelong Kindergarten" },
                    { 74, 84, "https://archive.org/details/criticaltheoryof0000feen", 8, "This pathbreaking book argues that the roots of the degradation of labor, education, and the environment lie not in technology per se but in the cultural values embodied in its design.", "UOM:39015021517928", "https://m.media-amazon.com/images/I/31K71B64NXL._UF1000,1000_QL80_.jpg", 264, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Critical Theory of Technology" },
                    { 75, 85, "http://ndl.ethernet.edu.et/bitstream/123456789/25703/1/44.pdf", 8, "This text offers an international and interdisciplinary analysis of the complex interactions between infrastructure networks and urban spaces. Drawing on case studies and examples from across the globe, it offers a statement on the urban condition.", "9780415189644", "https://images.routledge.com/common/jackets/crclarge/978041518/9780415189651.jpg", 516, new DateTime(2001, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Splintering Urbanism" },
                    { 76, 87, "https://monoskop.org/images/e/e2/Arendt_Hannah_The_Human_Condition_2nd_1998.pdf", 8, "The Human Condition", "9780415189132", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT6y-gz8U6L28l2CB1b3ao-9jRktL019hQwvw&s", 23, new DateTime(1958, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Human Condition" },
                    { 77, 88, "https://www.gresham.ac.uk/sites/default/files/2019-11-07_StephenWilkins_Elements-PP.pdf", 8, "Based on an American Chemical Society Symposium organized by Professors Glenn Seaborg and Oliver Manuel, this volume provides a comprehensive record of different views on this important subject at the end of the 20th century. They have assembled a blend of highly respected experimentalistsand theorists from astronomy,geology,meteoritics,planetology and nuclear chemistry and physics to discuss the origin of elements in the solar system.The intent was to include all points of view and let history judge their validity.", "9780306465628", "https://imgv2-1-f.scribdassets.com/img/document/413150200/original/c7f42cf998/1?v=1", 642, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Origin of Elements in the Solar System" },
                    { 78, 89, "https://archive.org/details/ullmannsencyclop0000unse_x4k7", 8, "Ullmann's Encyclopedia of Industrial Chemistry", "UCAL:B4584395", "https://i1.rgstatic.net/publication/270338813_Ulmann's_Encyclopedia_of_Industrial_Chemistry/links/54a7ebae0cf257a6360bda1b/largepreview.png", 720, new DateTime(1991, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullmann's Encyclopedia of Industrial Chemistry" },
                    { 79, 90, "https://archive.org/details/machineingardent0000marx", 8, "By examining the difference between pastoral and progressive ideals that characterised early 20th century American culture, the author shows how American thinkers have considered the relationship between technology and culture in their writings.", "9780195133516", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTu4wT6_TQJWAnyKjsRUqaeuNYyuK-knc-yng&s", 423, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Machine in the Garden" },
                    { 80, 89, "https://pdfcoffee.com/encyclopedia-of-industrial-chemistry-4-pdf-free.html", 8, "Supervised by an internationally acclaimed advisory board, the articles are written by over 3000 international experts from industry and universities, thoroughly edited to uniform style and layout in an in-house office. All figures are re-drawn to give a maximum of clarity and uniformity in style. Compared to the prior edition, almost 600f the material has either been newly written or thoroughly updated. The rest has been checked for validity and newer references have been added throughout.", "UOM:39015031845681", "https://upload.wikimedia.org/wikipedia/en/e/e4/Ullmann%27s_Encyclopedia_of_Industrial_Chemistry.jpg", 796, new DateTime(1995, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ullmann's Encyclopedia of Industrial Chemistry" },
                    { 81, 92, "https://ia902908.us.archive.org/28/items/deweyjohnartasanexperience/DEWEY%20John,%20Art%20as%20an%20Experience%22.pdf", 9, "Based on John Dewey's lectures on esthetics, delivered as the first William James Lecturer at Harvard in 1932, Art as Experience has grown to be considered internationally as the most distinguished work ever written by an American on the formal structure and characteristic effects of all the arts: architecture, sculpture, painting, music, and literature.", "9780399531972", "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1388193799i/75291.jpg", 385, new DateTime(2005, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Art as Experience" },
                    { 82, 93, "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHCJq1wVMlYTdTu7Fxa4Q0YhgHTnhr29Ik9g&s", 9, "Jean Giono's beautiful allegorical tale is legendary. Written in the 1950's, its message was ahead of its time, inspiring readers to rediscoverthe harmonies of the countryside and prevent its willful destruction. The narrator, journeying by foot across the barren plains of the lower Alps, has his thirst assuaged by the well water drawn by the shepherd Elzeaerd Bouffier. Here begins the subtle parable which Giono weaves of the life-giving shepherd who chooses to live alone and carry out the work of God. Over forty years the desolate hills and lifeless villages which sooppressed the traveler are transformed by the dedication of one man. All with the help of a few acorns. Giono's hope was to set in motion a worldwide reforestation program that would rejuvenate the earth. \"The Man Who Planted Trees\" is a hymn to creation and a purveyor of confidence in man's ability to change his-indeed the world's-lot. Review Citations: Ingram Advance 05/01/2005 pg. 77 (ISBN 1931498725, Hardcover)", "NWU:35556029031994", "https://www.arvindguptatoys.com/arvindgupta/manplantedtrees.pdf", 62, new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Man who Planted Trees" },
                    { 83, 94, "https://www.shambhala.com/media/wysiwyg/9780834840003.pdf?srsltid=AfmBOoot2-XZTBP00RtDlSW08vxwAEQYt45jUSUuQq3NxAB8MlIO7Oij", 9, "Based on the author's previous publication The Encyclopedia of Tibetan Symbols and Motifs', this handbook contains an array of symbols and motifs, accompanied by succinct explanations. It provides treatment of the essential Tibetan religious figures, themes and motifs, both secular and religious. Robert Beer offers a compact, concise reference work based on his previous publication 'The Encyclopedia of Tibetan Symbols and Motifs'. This handbook contains an extensive array of symbols and motifs, accompanied by succinct explanations. It provides treatment of the most'", "9781932476033", "https://images.thenile.io/r1000/9781590301005.jpg", 284, new DateTime(2003, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Handbook of Tibetan Buddhist Symbols" },
                    { 84, 95, "https://multiverse.ssl.berkeley.edu/Portals/0/CalendarInTheSky/Resources/Lesson%20Plans/CourtlyArtAncientMaya_Curriculum.pdf", 9, "A showcase of the breathtaking art of an ancient people features hundreds of illustrations that, combined with the latest research into and archaeological discoveries about Maya society, demonstrates the complexity and artistic genius of this legendary culture.", "9780500051290", "https://imgv2-1-f.scribdassets.com/img/document/14071925/original/d1353bceda/1?v=1", 304, new DateTime(2004, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Courtly Art of the Ancient Maya" },
                    { 85, 97, "https://ia801603.us.archive.org/13/items/leonardodavincih00heatrich/leonardodavincih00heatrich.pdf", 9, "This masterly account of Leonardo da Vinci and his vision of the world is now widely recognized as the classic treatment of Leonardo's art, science, and thought, giving an unparalleled insight into the broadening and deepening of Leonardo's intellect and vision throughout his artistic career. Martin Kemp, one of the world's leading authorities on Leonardo, takes us on a journey through the whole span of the great man's career. From his early training in Florence, through masterpieces such as The Last Supper and the Mona Lisa, to the work of Leonardo's last years, this book gives a fully integrated picture of his artistic, scientific, and technological achievements. Generously illustrated, and now including a new introductory chapter setting Leonardo's work in its historical context, this fully updated new edition provides an unparalleled insight into the marvellous works of this central figure in western art.", "9780191622601", "https://storage.googleapis.com/media365-live.appspot.com/266c3ce1-c23a-4770-bbe7-8e37467cc81c/5a73122f-5a3b-408f-860c-2f940b2a1118/3d25cbe1-0aea-44f4-9937-a7965bae660b.jpg", 429, new DateTime(2007, 10, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leonardo da Vinci" },
                    { 86, 98, "https://files.libcom.org/files/The%20Society%20of%20the%20Spectacle%20Annotated%20Edition.pdf", 9, "The Society of the Spectacle is a carefully considered effort to clarify the most fundamental tendencies and contradictions of the society in which we find ourselves—in order to facilitate its overthrow. Guy Debord was the founder of the Situationist International, the notorious avant-garde group that helped trigger the May 1968 revolt in France, which brought the entire country to a standstill for several weeks. His book The Society of the Spectacle, originally published in Paris in 1967, has been translated into more than twenty other languages and is arguably the most important radical work of the twentieth century. Ken Knabb’s meticulous new translation is the first edition in any language to include extensive annotations, clarifying the historical allusions and revealing the sources of Debord’s quotations and “détournements.” Contrary to popular misconceptions, Debord’s book is neither an ivory tower “philosophical” discourse nor a mere expression of “protest.” This makes the book more of a challenge, but it is also why it remains so pertinent more than half a century after its original publication, while countless other social theories and intellectual fads have come and gone. It has, in fact, become even more pertinent than ever, because the spectacle has become more all-pervading and glaringly obvious than ever. As Debord noted in his follow-up work, Comments on the Society of the Spectacle (1988), “spectacular domination has succeeded in raising an entire generation molded to its laws.” Debord’s book remains the best guidebook to understanding that mold and breaking it.", "9798887440651", "https://files.libcom.org/files/images/library/The%20Society%20of%20the%20Spectacle.jpg", 161, new DateTime(2024, 9, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Society of the Spectacle" },
                    { 87, 99, "https://ebook-mecca.com/online/Nikolai%20Gogol%20Dead%20Souls.pdf", 9, "This is the famed Gogol's unfinished novel as translated by google translate, which is to say that it's total gibberish, which, in its turn, is to say that you don't really have to read it (I didn't although I should one day because I brought it into being after all, and it might be fun) but you certainly want to have it. Think of it as a coffee table book to be casually picked up and as casually put back where it belongs.", "9781387849604", "https://imgv2-1-f.scribdassets.com/img/document/544887197/original/f6fa979757/1?v=1", 266, new DateTime(2018, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Dead Souls" },
                    { 88, 100, "https://ia601303.us.archive.org/31/items/historyofarmenia01cham/historyofarmenia01cham.pdf", 9, "The volume is an easy reading and a must for the beginner student and interested party of the history of Armenia as well as for those more familiar with Armenian and its history. The author, an expert on Armenian history, has masterfully covered all aspects of the Armenian history such as Armenian literature, Armenian Church, the history of Armenian old and modern language, architecture, sculpture, music etc. along with all the historical events, starting from the beginning of the human civilization and that of Armenian one to the modern era of Armenia.", "9781604449112", "https://archive.org/services/img/historyofarmenia0000bour/full/pct:200/0/default.jpg", 414, new DateTime(2018, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "A History of Armenia" },
                    { 89, 101, "https://olli.gmu.edu/docstore/400docs/1101-403-Man-superman%20psu.pdf", 9, "Man and Superman, subtitled \"A Comedy and a Philosophy\", is a four-act drama written in 1903, in response to a call for Shaw to write a play based on the Don Juan theme. This book conveys the conflict between man as spiritual creator and woman as guardian of the biological continuity of the human race. It was written by George Bernard Shaw, an Irish playwright, critic, polemicist, and political activist.", "EAN:8596547065753", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtKlPZuYsF1QTJ4Sidh6J-vgfpLtEMx3P1dw&s", 241, new DateTime(2022, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Man and Superman" },
                    { 90, 102, "https://archive.org/details/artundercontroli0000port", 9, "\"Art Under Control in North Korea is the first publication in the West to explore the role of art in one of the world'smost isolated nations.This timely publication places North Korean art in its historical,political and social contexts, discusses the state system of producing,employing, promoting and honouring artists,and examines the range of art produced,from painting and calligraphy to architecture and applied art.Jane Portal also compares the control exerted over artists by North Korean leaders to that of other absolute dictatorships,and looks at the way in which archaeology has been employed for political ends to justify the present leadership and its lineage.\"--BOOK JACKET.", "9781861892362", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJlOlS_kfSDfGud9SpzFvUJEIya1EVtxfohw&s", 196, new DateTime(2005, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Art Under Control in North Korea" },
                    { 91, 103, "https://dspace.nplg.gov.ge/bitstream/1234/322530/1/Georgia_Armenia_I_Azerbaijan.pdf", 10, "Lonely Planet’s Georgia, Armenia & Azerbaijan is your passport to the most relevant, up-to-date advice on what to see and skip, and what hidden discoveries await you. Hike in Tusheti, explore Goris, and discover Baku; all with your trusted travel companion. Get to the heart of Georgia, Armenia & Azerbaijan and begin your journey now! Inside Lonely Planet’s Georgia, Armenia & Azerbaijan Travel Guide: Up-to-date information - all businesses were rechecked before publication to ensure they are still open after 2020’s COVID-19 outbreak NEW top experiences feature - a visually inspiring collection of Georgia, Armenia & Azerbaijan’s best experiences and where to have them What's NEW feature taps into cultural trends and helps you find fresh ideas and cool new areas NEW pull-out, passport-size 'Just Landed' card with wi-fi, ATM and transport info - all you need for a smooth journey from airport to hotel Colour maps and images throughout Highlights and itineraries help you tailor your trip to your personal needs and interests Insider tips to save time and money and get around like a local, avoiding crowds and trouble spots Essential info at your fingertips - hours of operation, websites, transit tips, prices Honest reviews for all budgets - eating, sleeping, sightseeing, going out, shopping, hidden gems that most guidebooks miss Cultural insights give you a richer, more rewarding travel experience - history, people, music, landscapes, wildlife, cuisine, politics Over 65 maps Covers Georgia, Armenia, Azerbaijan The Perfect Choice: Lonely Planet’s Georgia, Armenia & Azerbaijan, our most comprehensive guide to Georgia, Armenia & Azerbaijan, is perfect for both exploring top sights and taking roads less travelled. About Lonely Planet: Lonely Planet is a leading travel media company, providing both inspiring and trustworthy information for every kind of traveller since 1973. Over the past four decades, we've printed over 145 million guidebooks and phrasebooks for 120 languages, and grown a dedicated, passionate global community of travellers. You'll also find our content online, and in mobile apps, videos, 14 languages, armchair and lifestyle books, ebooks, and more, enabling you to explore every day. 'Lonely Planet guides are, quite simply, like no other.' – New York Times 'Lonely Planet. It's on everyone's bookshelves; it's in every traveller's hands. It's on mobile phones. It's on the Internet. It's everywhere, and it's telling entire generations of people how to travel the world.' – Fairfax Media (Australia)", "9781838696467", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSNUuCWHjW9A1S4zxpkVxpPvmRHGxD5cjpfIg&s", 579, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lonely Planet Georgia, Armenia & Azerbaijan" },
                    { 92, 104, "https://archive.org/details/museumofinnocenc00pamu_0", 10, "The Museum of Innocence - set in Istanbul between 1975 and today - tells the story of Kemal, the son of one of Istanbul's richest families, and of his obsessive love for a poor and distant relation, the beautiful Fusun, who is a shop-girl in a small boutique. In his romantic pursuit of Füsun over the next eight years, Kemal compulsively amasses a collection of objects that chronicles his lovelorn progress-a museum that is both a map of a society and of his heart. The novel depicts a panoramic view of life in Istanbul as it chronicles this long, obsessive love affair; and Pamuk beautifully captures the identity crisis experienced by Istanbul's upper classes that find themselves caught between traditional and westernised ways of being. Orhan Pamuk's first novel since winning the Nobel Prize is a stirring love story and exploration of the nature of romance. Pamuk built The Museum of Innocence in the house in which his hero's fictional family lived, to display Kemal's strange collection of objects associated with Fusun and their relationship. The house opened to the public in 2012 in the Beyoglu district of Istanbul. 'Pamuk has created a work concerning romantic love worthy to stand in the company of Lolita, Madame Bovary and Anna Karenina.' --Financial Times", "9780571268412", "https://archive.org/services/img/museumofinnocenc00pamu_0/full/pct:200/0/default.jpg", 756, new DateTime(2011, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Museum of Innocence" },
                    { 93, 105, "https://dn721704.ca.archive.org/0/items/lordjimtale00conrrich/lordjimtale00conrrich.pdf", 10, "Caduto in disgrazia a causa di un incidente in cui la paura ha preso il sopravvento, e per cui ha perduto il brevetto di ufficiale, Jim trascorre la propria esistenza spostandosi sempre più verso l'Estremo Oriente nel tentativo di sfuggire al proprio nome, finché in uno sperduto angolo del Borneo non riesce a riscattarsi, riassumendo il ruolo di eroe che aveva sempre sognato. Narrata dalla voce di Marlow, capitano di lungo corso che tenta di aiutare il giovane, la storia di Jim tratteggia uno dei personaggi più complessi della letteratura, in cui le vicende personali e le ambientazioni esotiche diventano rappresentazione dell'incertezza esistenziale e dell'impossibilità di conoscere l'animo umano e la realtà del mondo. Un romanzo costruito come un mosaico di punti di vista che ruotano intorno al medesimo evento, proposto qui in nuova traduzione e curatela di Rocco Coronato, professore di Letteratura inglese presso l'Università di Padova.", "9788831815727", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRSDCNHjDxwYLddg8OcxgdwSY6f4vs8mFzwGQ&s", 387, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lord Jim" },
                    { 94, 106, "https://www.moonshiners.org.uk/MZ/zeus.pdf", 10, "Traces the four-thousand-year history of the charismatic father of the Greek gods, from his origins in the Russian steppes and reign on Mount Olympus to his approaching end in Christian Constantinople, in an account that follows the author's journeys to relevant sites in Greek mythology.", "9781582345185", "https://assets.isu.pub/document-structure/241031180940-61a70be0017371569659054b3760945b/v1/abd52574d2850256bdcbf1543dd3c2b7.jpeg", 340, new DateTime(2008, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zeus" },
                    { 95, 107, "https://theswissbay.ch/pdf/Books/Linguistics/Mega%20linguistics%20pack/Indo-European/Germanic/German%2C%20Teach%20Yourself%20%28Adams%2C%20Wells%20%26%20Jenkins%29.pdf", 10, "Reviews Germany's history, and treats in a concise and objective manner its dominant social, political, economic, and military aspects. Sections, written by experts, include: chronology of important events; early history to 1945; history 1945-1990; the society and its environment; social welfare, health care, and educ.; the domestic economy; international economic relations; government and politics; foreign relations; national security; military tradition; strategic concerns and military missions; the armed forces; defense budget; and such military issues as uniforms, ranks, and insignia, defense production and export, foreign military relations, and internal security.", "9780788181795", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdQUZdjqQuWk2AGTQqMDXpWz0nds_QWN4q-A&s", 720, new DateTime(1999, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Germany" },
                    { 96, 108, "https://institutes.abu.edu.ng/idr/public/assets/docs/Eat,%20Pray,%20Love%20(%20PDFDrive%20).pdf", 10, "The Number One international bestseller, Eat, Pray Love is a journey around the world, a quest for spiritual enlightenment and a story for anyone who has battled with divorce, depression and heartbreak.", "9780747585664", "https://online.fliphtml5.com/gutjj/zwbj/files/large/1.webp?1604750286&1604750286", 386, new DateTime(2007, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eat, Pray, Love" },
                    { 97, 109, "https://www.scribd.com/document/892886564/The-Ecology-of-Java-and-Bali-Whitten-instant-download", 10, "Java and Bali are the best known of all the islands in Indonesia, and nowhere else in the country are ecological issues so acute. This book provides invaluable ecological data, so that development activities can be viewed in light of their ecological and social impacts.These eagerly-awaited volumes are the result of four years of research into the status of Indonesian coastal and marine ecosystems. They chart the extraordinary treasure trove of the areas marine biodiversity, and discuss the problems that have resulted from current population pressures and economic development.", "9789625930725", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStBIY-qHyoYmT5xTLTRQnxDrhbc_5Ym5CDjw&s", 1040, new DateTime(1996, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ecology of Java & Bali" },
                    { 98, 112, "https://archive.org/details/aiaguidetonewyor0000unse_j8m6", 10, "$21.95 paperback 1-58685-113-6 August6 x 8/ in, 432 pp, Black & White Photographs, Rights: W, ArchitecturevFrancis Morrone has returned to the buildings of his original guidebook once again to detail additions and changes in name and usage, and the book has been modified to reflect post September 11th New York City. With its thoughtful detail and out-of-the-ordinary observations, this guidebook is a must-have for New Yorkers, tourists, and architectural lovers everywhere.Francis Morrone is a lecturer and tour leader for the Municipal Art Society of New York, a nonprofit civic organization founded in 1893. His writings on architecture and New York history appear in The New Criterion, the City Journal, and other publications. His other books include An Architectural Guidebook to Brooklyn and An Architectural Guidebook to Philadelphia. He lives in Brooklyn.James Iska, whose work has been exhibited all over the world and has appeared in the Washington Post, the Financial Times, the Chicago Sun-Times, and the Chicago Tribune, is currently on the staff of the Art Institute of Chicago.", "9781423611165", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5ZqQcG7_pKTdOaXQspMyO7-fKrxoNidRpyw&s", 440, new DateTime(2009, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Architectural Guidebook to New York City" },
                    { 99, 113, "https://www.europarc.org/wp-content/uploads/2015/05/2012_Parks_and_Benefits_Guide_to_sustainable_tourism_in_Protected_Areas.pdf", 10, "This report tells how to ensure that tourism follows a sustainable path and that it contributes to the sustainable management of protected areas. Guidelines are presented to help readers understand protected area tourism and its management, and practical suggestions are based on theory and practice from around the world. Coverage includes biodiversity and conservation, planning for protected area tourism, culturally sensitive design and operation, visitor management, and human resources. There is no subject index. Eagles teaches at the University of Waterloo, Canada. Annotation copyrighted by Book News, Inc., Portland, OR.", "9782831706481", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQuN00TpctnWSLzvYdA_2rk8RxHDn9MM2hUwA&s", 191, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sustainable Tourism in Protected Areas" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Books",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Authors",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "BookURL",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "ImageURL",
                table: "Books");
        }
    }
}
