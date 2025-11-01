using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Data
{
    internal static class SeedDataFactory
    {
        internal static void SeedData(ModelBuilder builder)
        {
            // Սերմանման կատեգորիաներ
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "science" },
                new Category { Id = 2, Name = "fiction" },
                new Category { Id = 3, Name = "romance" },
                new Category { Id = 4, Name = "fantasy" },
                new Category { Id = 5, Name = "mystery" },
                new Category { Id = 6, Name = "history" },
                new Category { Id = 7, Name = "biography" },
                new Category { Id = 8, Name = "technology" },
                new Category { Id = 9, Name = "art" },
                new Category { Id = 10, Name = "travel" }
            );

            // Seed Authors
            builder.Entity<Author>().HasData(
                new Author { Id = 1, FullName = "Նավջոթ Ս. Սոջի" },
                new Author { Id = 2, FullName = "Փոլ Ռ. Էռլիխ" },
                new Author { Id = 3, FullName = "Ստիվ Թ. Բեքեթ" },
                new Author { Id = 4, FullName = "Ուորդ Չեսվոր್ತ" },
                new Author { Id = 5, FullName = "Հանս Մորավեց" },
                new Author { Id = 6, FullName = "Կարլո Ռովելի" },
                new Author { Id = 7, FullName = "Ֆրանչեսկա Վիդոտտո" },
                new Author { Id = 8, FullName = "Աբհայ Ռ. Սատոսկար" },
                new Author { Id = 9, FullName = "Գարի Էլ. Սայմոն" },
                new Author { Id = 10, FullName = "Փիթեր Ջ. Հոտեզ" },
                new Author { Id = 11, FullName = "Մորիյա Տսուժի" },
                new Author { Id = 12, FullName = "Ջորջ Դայսոն" },
                new Author { Id = 13, FullName = "Չարլզ Դարվին" },
                new Author { Id = 14, FullName = "Ֆլոյդ Ջեյմս Ռադըրթֆըրդ" },
                new Author { Id = 15, FullName = "Էնդրյու Ահլգրեն" },
                new Author { Id = 16, FullName = "Նիկոլայ Վ. Գոգոլ" },
                new Author { Id = 17, FullName = "Թուկիդիդես" },
                new Author { Id = 18, FullName = "Կնուտ Համսուն" },
                new Author { Id = 19, FullName = "Օսկար Ուայլդ" },
                new Author { Id = 20, FullName = "Մերի Շելլի" },
                new Author { Id = 21, FullName = "Վիրջինիա Ուլֆ" },
                new Author { Id = 22, FullName = "Բրունո Շուլց" },
                new Author { Id = 23, FullName = "Լի Չայլդ" },
                new Author { Id = 24, FullName = "Ջեյմս Ջոյս" },
                new Author { Id = 25, FullName = "Վիրջինիա Ուլֆ" },
                new Author { Id = 26, FullName = "Ջուդ Դեվերօ" },
                new Author { Id = 27, FullName = "Առնետ Լեմբ" },
                new Author { Id = 28, FullName = "Ջիլ Բարնեթ" },
                new Author { Id = 29, FullName = "Ջուդիթ ՄաքՆոթ" },
                new Author { Id = 30, FullName = "Շառլոթ Բրոնտե" },
                new Author { Id = 31, FullName = "Ջեյն Օսթին" },
                new Author { Id = 32, FullName = "Ջուլի Գարվուդ" },
                new Author { Id = 33, FullName = "Ջոջո Մոյես" },
                new Author { Id = 34, FullName = "Դանիել Ստիլ" },
                new Author { Id = 35, FullName = "Սանտա Մոնտեֆիորե" },
                new Author { Id = 36, FullName = "Յոհաննա Լինդսեյ" },
                new Author { Id = 37, FullName = "Ք. Ս. Լյուիս" },
                new Author { Id = 38, FullName = "Ուրսուլա Կ. Լե Գուին" },
                new Author { Id = 39, FullName = "Տովե Յանսոն" },
                new Author { Id = 40, FullName = "Ջ. Ռ. Ռ. Թոլկին" },
                new Author { Id = 41, FullName = "Ջոն Ռոնալդ Ռոյել Թոլկին" },
                new Author { Id = 42, FullName = "Լյուիս Քարոլ" },
                new Author { Id = 43, FullName = "Քլայվ Սթեյփլզ Լյուիս" },
                new Author { Id = 44, FullName = "Էլ. Ֆրենկ Բաում" },
                new Author { Id = 45, FullName = "Քեննեթ Գրեհեմ" },
                new Author { Id = 46, FullName = "Թրեյսի Դեոնն" },
                new Author { Id = 47, FullName = "Ագաթա Քրիստի" },
                new Author { Id = 48, FullName = "Դեն Բրաուն" },
                new Author { Id = 49, FullName = "Մարկ Հադդոն" },
                new Author { Id = 50, FullName = "Փ. Դ. Ջեյմս" },
                new Author { Id = 51, FullName = "Ֆյոդոր Դոստոևսկի" },
                new Author { Id = 52, FullName = "Ֆրեդ Վարգաս" },
                new Author { Id = 53, FullName = "Ջոզեֆին Թեյ" },
                new Author { Id = 54, FullName = "Քեյթ Մորտոն" },
                new Author { Id = 55, FullName = "Ք. Ս. Լյուիս" },
                new Author { Id = 56, FullName = "Ֆիլիպ Ֆրիման" },
                new Author { Id = 57, FullName = "Էլ. Ջեյ. Ֆ. Քեփի" },
                new Author { Id = 58, FullName = "Հելեն Ս. Ռաունթրի" },
                new Author { Id = 59, FullName = "Կարլ Բեքսոն" },
                new Author { Id = 60, FullName = "Ջերի Զ. Մյուլլեր" },
                new Author { Id = 61, FullName = "Ջոնաթան Հարիս" },
                new Author { Id = 62, FullName = "Սերհի Փլոխի" },
                new Author { Id = 63, FullName = "Գ. Ն. Դևի" },
                new Author { Id = 64, FullName = "Ջեֆրի Վ. Դևիս" },
                new Author { Id = 65, FullName = "Կ. Կ. Չակրավարտի" },
                new Author { Id = 66, FullName = "Վահան Մ. Կյուրքչյան" },
                new Author { Id = 67, FullName = "Վիկտոր Է. Թորեն" },
                new Author { Id = 68, FullName = "Ջոն Ռոբերտ Քրիստիանսոն" },
                new Author { Id = 69, FullName = "Վիլյամ Սմիթ" },
                new Author { Id = 70, FullName = "Էլիզաբեթ Գիլբերթ" },
                new Author { Id = 71, FullName = "Պրիմո Լևի" },
                new Author { Id = 72, FullName = "Չարլզ Նայթ" },
                new Author { Id = 73, FullName = "Դեզմոնդ Շում" },
                new Author { Id = 74, FullName = "Ջոն Ալեքսանդր Գայ" },
                new Author { Id = 75, FullName = "Ռիչարդ Ա. Բարիջ" },
                new Author { Id = 76, FullName = "Պլուտարխոս" },
                new Author { Id = 77, FullName = "Ջոն Լանգհորն" },
                new Author { Id = 78, FullName = "Վիլյամ Լանգհորն" },
                new Author { Id = 79, FullName = "Լանս Դեյ" },
                new Author { Id = 80, FullName = "Իյան ՄաքՆեյլ" },
                new Author { Id = 81, FullName = "Ֆլոյդ Ջեյմս Ռադըրթֆըրդ" },
                new Author { Id = 82, FullName = "Էնդրյու Ահլգրեն" },
                new Author { Id = 83, FullName = "Միչել Ռեզնիկ" },
                new Author { Id = 84, FullName = "Էնդրյու Ֆենբերգ" },
                new Author { Id = 85, FullName = "Սթիվեն Գրեհեմ" },
                new Author { Id = 86, FullName = "Սայմոն Մարվին" },
                new Author { Id = 87, FullName = "Հաննա Արենդտ" },
                new Author { Id = 88, FullName = "Օլիվեր Մանուել" },
                new Author { Id = 89, FullName = "Ֆրից Ուլման" },
                new Author { Id = 90, FullName = "Լեո Մարքս" },
                new Author { Id = 91, FullName = "Վոլֆգանգ Գերհարթց" },
                new Author { Id = 92, FullName = "Ջոն Դյուի" },
                new Author { Id = 93, FullName = "Ժան Ժիոնո" },
                new Author { Id = 94, FullName = "Ռոբերթ Բեր" },
                new Author { Id = 95, FullName = "Մերի Էլեն Միլլեր" },
                new Author { Id = 96, FullName = "Սայմոն Մարտին" },
                new Author { Id = 97, FullName = "Մարտին Քեմփ" },
                new Author { Id = 98, FullName = "Գի Դեբոր" },
                new Author { Id = 99, FullName = "Գոգոլ Գուգլ Թրանսլեյթ" },
                new Author { Id = 100, FullName = "Վահան Մ. Կյուրքչյան" },
                new Author { Id = 101, FullName = "Ջորջ Բեռնարդ Շոու" },
                new Author { Id = 102, FullName = "Ջեյն Փորթալ" },
                new Author { Id = 103, FullName = "Թոմ Մասթերս" },
                new Author { Id = 104, FullName = "Օրհան Փամուք" },
                new Author { Id = 105, FullName = "Կոնրադ Ջոզեֆ" },
                new Author { Id = 106, FullName = "Թոմ Սթոուն" },
                new Author { Id = 107, FullName = "Էրիկ Սոլստեն" },
                new Author { Id = 108, FullName = "Էլիզաբեթ Գիլբերթ" },
                new Author { Id = 109, FullName = "Թոնի Ուիթեն" },
                new Author { Id = 110, FullName = "Ռոհայաթ Էմոն Սուերիաթմաջա" },
                new Author { Id = 111, FullName = "Սուրայա Ա. Աֆիֆ" },
                new Author { Id = 112, FullName = "Ֆրանցիս Մորոնե" },
                new Author { Id = 113, FullName = "Փոլ Ֆ. Ջ. Իգլզ" },
                new Author { Id = 114, FullName = "Սթիվեն Ֆ. ՄաքՔուլ" },
                new Author { Id = 115, FullName = "Քրիստոֆեր Դ. Հեյնս" },
                new Author { Id = 116, FullName = "ՄԱԿ Շրջակա Միջավայրի Ծրագիր" },
                new Author { Id = 117, FullName = "Աշխարհի Զբոսաշրջության Կազմակերպություն" });


            // Seed Books
            builder.Entity<Book>().HasData(
                new Book
                {
                    Id = 1,
                    Title = "Conservation Biology for All",
                    ISBN = "9780199554232",
                    Pages = 369,
                    PublishedDate = new DateTime(2010, 1, 7),
                    Description = "Conservation Biology for All provides cutting-edge but basic conservation science to a global readership. A series of authoritative chapters have been written by the top names in conservation biology with the principal aim of disseminating cutting-edge conservation knowledge as widely as possible. Important topics such as balancing conversion and human needs, climate change, conservation planning, designing and analyzing conservation research, ecosystem services, endangered species management, extinctions, fire, habitat loss, and invasive species are covered. Numerous textboxes describing additional relevant material or case studies are also included. The global biodiversity crisis is now unstoppable; what can be saved in the developing world will require an educated constituency in both the developing and developed world. Habitat loss is particularly acute in developing countries, which is of special concern because it tends to be these locations where the greatest species diversity and richest centres of endemism are to be found. Sadly, developing world conservation scientists have found it difficult to access an authoritative textbook, which is particularly ironic since it is these countries where the potential benefits of knowledge application are greatest. There is now an urgent need to educate the next generation of scientists in developing countries, so that they are in a better position to protect their natural resources.",
                    AuthorId = 1, // Navjot S. Sodhi
                    CategoryId = 1,
                    BookURL = "https://conbio.org/images/content_publications/ConservationBiologyforAll_reducedsize.pdf",
                    ImageURL = "https://m.media-amazon.com/images/I/712UYtmr7IL._UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 2,
                    Title = "Industrial Chocolate Manufacture and Use",
                    ISBN = "9781444357554",
                    Pages = 679,
                    PublishedDate = new DateTime(2011, 9, 7),
                    Description = "Since the third edition of this standard work in 1999, there has been a significant increase in the amount of chocolate manufactured worldwide. The fourth edition of Industrial Chocolate Manufacture and Use provides up-to-date coverage of all major aspects of chocolate manufacture and use, from the growing of cocoa beans to the packaging and marketing of the end product. Retaining the important and well-received key features of the previous edition, the fourth edition also contains completely new chapters covering chocolate crumb, cold forming technologies, intellectual property, and nutrition. Furthermore, taking account of significant changes and trends within the chocolate industry, much new information is incorporated, particularly within such chapters as those covering the chemistry of flavour development, chocolate flow properties, chocolate packaging, and chocolate marketing. This fully revised and expanded new edition is an essential purchase for all those involved in the manufacture and use of chocolate.",
                    AuthorId = 3, // Steve T. Beckett
                    CategoryId = 1,
                    BookURL = "https://download.e-bookshelf.de/download/0000/5986/29/L-G-0000598629-0002363255.pdf",
                    ImageURL = "https://media.springernature.com/full/springer-static/cover-hires/book/978-1-4615-2111-2"
                },
                new Book
                {
                    Id = 3,
                    Title = "The Encyclopedia of Animals",
                    ISBN = "9780520244061",
                    Pages = 619,
                    PublishedDate = new DateTime(2004, 1, 1),
                    Description = "This lavishly illustrated trade reference to mammals, birds, reptiles, amphibians, fishes, and invertebrates features hundreds of glorious photos, masterful illustrations, and informative maps.",
                    AuthorId = 2, // No author in your model, set to 0 or handle as needed
                    CategoryId = 1,
                    BookURL = "https://archive.org/details/animalsavisualencyclopedia",
                    ImageURL = "https://m.media-amazon.com/images/I/91H7u1fM9vL._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 4,
                    Title = "Darwin Among The Machines",
                    ISBN = "UOM:39015041310320",
                    Pages = 312,
                    PublishedDate = new DateTime(1997, 5, 1),
                    Description = "In this astonishing prediction of the World Wide Web's ultimate challenge to human civilization--a globally networked, electronic, sentient being--Dyson traces the course of the information revolution, illuminating the lives, work, and ideas of visionaries who foresaw the development of artificial intelligence, artificial life, and the global mind.",
                    AuthorId = 12, // George Dyson
                    CategoryId = 1,
                    BookURL = "https://mediarep.org/server/api/core/bitstreams/e0da505d-200c-43ab-be4b-6604a4df816f/content",
                    ImageURL = "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1391566685i/191355.jpg"
                },
                new Book
                {
                    Id = 5,
                    Title = "Encyclopedia of Soil Science",
                    ISBN = "9781402039942",
                    Pages = 859,
                    PublishedDate = new DateTime(2007, 11, 22),
                    Description = "The Encyclopedia of Soil Science provides a comprehensive, alphabetical treatment of basic soil science in a single volume. It constitutes a wide ranging and authorative collection of some 160 academic articles covering the salient aspects of soil physics, chemistry, biology, fertility, technology, genesis, morphology, classification and geomorphology. With increased usage of soil for world food production, building materials, and waste repositories, demand has grown for a better global understanding of soil and its processes. longer articles by leading authorities from around the world are supplemented by some 430 definitions of common terms in soil sciences.",
                    AuthorId = 4, // Ward Chesworth
                    CategoryId = 1,
                    BookURL = "https://ens9004-infd.mendoza.edu.ar/sitio/geologia-goemorfologia/upload/12-%20CHESWORTH,%20W.%20-%20LIBRO%20-%20Encyclopedia%20of%20Soil%20Science.pdf",
                    ImageURL = "https://media.springernature.com/full/springer-static/cover-hires/book/978-1-4020-3995-9"
                },
                new Book
                {
                    Id = 6,
                    Title = "Mind Children",
                    ISBN = "9780674576186",
                    Pages = 228,
                    PublishedDate = new DateTime(1988, 1, 1),
                    Description = "\"A dizzying display of intellect and wild imaginings by Moravec, a world-class roboticist who has himself developed clever beasts . . . Undeniably, Moravec comes across as a highly knowledgeable and creative talent--which is just what the field needs\".--Kirkus Reviews.",
                    AuthorId = 5, // Hans Moravec
                    CategoryId = 1,
                    BookURL = "https://www.scribd.com/document/678843543/8-Moravec-H-1990-Mind-Children",
                    ImageURL = "https://www.hup.harvard.edu/img/feeds/jackets/9780674576186.png?fm=jpg&q=80&fit=max&w=630"
                },
                new Book
                {
                    Id = 7,
                    Title = "Covariant Loop Quantum Gravity",
                    ISBN = "9781107069626",
                    Pages = 267,
                    PublishedDate = new DateTime(2015, 1, 1),
                    Description = "A comprehensible introduction to the most fascinating research in theoretical physics: advanced quantum gravity. Ideal for researchers and graduate students.",
                    AuthorId = 6, // Carlo Rovelli
                    CategoryId = 1,
                    BookURL = "https://www.cpt.univ-mrs.fr/~rovelli/IntroductionLQG.pdf",
                    ImageURL = "https://m.media-amazon.com/images/I/813-Uql4q7L._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 8,
                    Title = "Science for All Americans",
                    ISBN = "UOM:39015025158489",
                    Pages = 282,
                    PublishedDate = new DateTime(1990, 1, 1),
                    Description = "In order to compete in the modern world, any society today must rank education in science, mathematics, and technology as one of its highest priorities. It's a sad but true fact, however, that most Americans are not scientifically literate. International studies of educational performance reveal that U.S. students consistently rank near the bottom in science and mathematics. The latest study of the National Assessment of Educational Progress has found that despite some small gains recently, the average performance of seventeen-year-olds in 1986 remained substantially lower than it had been in 1969. As the world approaches the twenty-first century, American schools--when it comes to the advancement of scientific knowledge--seem to be stuck in the Victorian age.In Science for All Americans, F. James Rutherford and Andrew Ahlgren brilliantly tackle this devastating problem. Based on Project 2061, a scientific literacy initiative sponsored by the American Association for the Advancement of Science, this wide-ranging, important volume explores what constitutes scientific literacy in a modern society; the knowledge, skills, and attitudes all students should acquire from their total school experience from kindergarten through high school; and what steps this country must take to begin reforming its system of education in science, mathematics, and technology.Science for All Americans describes the scientifically literate person as one who knows that science, mathematics, and technology are interdependent enterprises with strengths and limitations; who understands key concepts and principles of science; who recognizes both the diversity and unity of the natural world; and who uses scientific knowledge and scientific ways of thinking for personal and social purposes. Its recommendations for educational reform downplay traditional subject categories and instead highlight the connections between them. It also emphasizes ideas and thinking skills over the memorization of specialized vocabulary. For instance, basic scientific literacy means knowing that the chief function of living cells is assembling protein molecules according to the instructions coded in DNA molecules, but does not mean necessarily knowing the terms \"ribosome\" or \"deoxyribonucleic acid.\"Science, mathematics, and technology will be at the center of the radical changes in the nature of human existence that will occur during the next life span; therefore, preparing today's children for tomorrow's world must entail a solid education in these areas. Science for All Americans will help pave the way for the necessary reforms in America's schools.",
                    AuthorId = 14, // Floyd James Rutherford
                    CategoryId = 1,
                    BookURL = "https://academic.oup.com/book/51739",
                    ImageURL = "https://m.media-amazon.com/images/I/61iwcrSHQ6L._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 9,
                    Title = "The Expression of the Emotions in Man and Animals",
                    ISBN = "BSB:BSB10997144",
                    Pages = 406,
                    PublishedDate = new DateTime(1872, 1, 1),
                    Description = "MANY works have been written on Expression, but a greater number on Physiognomy, that is, on the recognition of character through the study of the permanent form of the features. With this latter subject I am not here concerned. The older treatises, which I have consulted, have been of little or no service to me. The famous 'Conferences' of the painter Le Brun, published in 1667, is the best known ancient work, and contains some good remarks. Another somewhat old essay, namely, the 'Discours, ' delivered 1774-1782, by the well-known Dutch anatomist Camper, can hardly be considered as having made any marked advance in the subject. The following works, on the contrary, deserve the fullest consideration",
                    AuthorId = 13, // Charles Darwin
                    CategoryId = 1,
                    BookURL = "https://darwin-online.org.uk/converted/pdf/1897_Expression_F1152.pdf",
                    ImageURL = "https://assets.cambridge.org/97811080/61834/large_cover/9781108061834i.jpg"
                },
                new Book
                {
                    Id = 10,
                    Title = "Medical Parasitology",
                    ISBN = "9781040195369",
                    Pages = 331,
                    PublishedDate = new DateTime(2009, 11, 23),
                    Description = "Infections caused by parasites are still a major global health problem. Although parasitic infections are responsible for a significant morbidity and mortality in the developing countries, they are also prevalent in the developed countries. Early diagnosis and treatment of a parasitic infection is not only critical for preventing morbidity and mort",
                    AuthorId = 8, // Abhay R. Satoskar
                    CategoryId = 1,
                    BookURL = "http://repository.stikesrspadgs.ac.id/63/1/Medical%20Parasitology%20Shymasundari-501hlm.pdf",
                    ImageURL = "https://m.media-amazon.com/images/I/819c-MQARGL._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 11,
                    Title = "Taras Bulba",
                    ISBN = "9788446023708",
                    Pages = 154,
                    PublishedDate = new DateTime(2006, 12, 19),
                    Description = "Feroces, crueles, valientes y apasionados, los cosacos hacen temblar la estepa bajo los cascos de sus caballos. Y entre ellos se encuentra Taras Bulba, un anciano lleno aún de fuerza e inteligencia que junto a sus hijos, Ostap y Andrí, avanzará por tierras polacas con intención de vengar su fe ortodoxa burlada por los católicos. Ninguna guarnición, ciudad amurallada o iglesia podrán detenerlos, hasta que la desgracia se cierna sobre ellos y el apuesto y enamoradizo Andrí haga que su padre maldiga el día en que lo engendró. Taras Bulba, una anomalía entre la obra más conocida de Gogol, es una aventura trepidante, una sinfonía en perpetuo crescendo, en la que cada capítulo es más intenso y sorprendente que el anterior. un fresco tan afinadamente dibujado y tan vívido que resulta absolutamente intemporal.",
                    AuthorId = 16,
                    CategoryId = 2,
                    BookURL = "https://dn790009.ca.archive.org/0/items/cu31924026658165/cu31924026658165.pdf",
                    ImageURL = "https://ww2.ebookelo.com/images/cover/21286.jpg"
                },
                new Book
                {
                    Id = 12,
                    Title = "The History of the Peloponnesian War",
                    ISBN = "9783968656762",
                    Pages = 738,
                    PublishedDate = new DateTime(2021, 1, 13),
                    Description = "The History of the Peloponnesian War (Greek: Ἱστορίαι, \"Histories\") is a historical account of the Peloponnesian War (431–404 BC), which was fought between the Peloponnesian League (led by Sparta) and the Delian League (led by Athens). It was written by Thucydides, an Athenian historian who also served as an Athenian general during the war. His account of the conflict is widely considered to be a classic and regarded as one of the earliest scholarly works of history. The History is divided into eight books.",
                    AuthorId = 17,
                    CategoryId = 2,
                    BookURL = "https://antilogicalism.com/wp-content/uploads/2017/07/history-pelo-war.pdf",
                    ImageURL = "https://cdn.kobo.com/book-images/d4a3769f-012a-48dc-a096-08e287b03557/1200/1200/False/the-history-of-the-peloponnesian-war-with-18-illustrations-and-a-free-audio-link.jpg"
                },
                new Book
                {
                    Id = 13,
                    Title = "The Mystery of mysteries",
                    ISBN = "9780141186184",
                    Pages = 356,
                    PublishedDate = new DateTime(2001, 1, 1),
                    Description = "The first complete English translation of the Nobel Prize-winner’s literary masterpiece A Penguin Classic Mysteries is the story of Johan Nilsen Nagel, a mysterious stranger who suddenly turns up in a small Norwegian town one summer—and just as suddenly disappears. Nagel is a complete outsider, a sort of modern Christ treated in a spirit of near parody. He condemns the politics and thought of the age, brings comfort to the “insulted and injured,” and gains the love of two women suggestive of the biblical Mary and Martha. But there is a sinister side of him: in his vest he carries a vial of prussic acid... The novel creates a powerful sense of Nagel's stream of thought, as he increasingly withdraws into the torture chamber of his own subconscious psyche. For more than seventy years, Penguin has been the leading publisher of classic literature in the English-speaking world. With more than 1,800 titles, Penguin Classics represents a global bookshelf of the best works throughout history and across genres and disciplines. Readers trust the series to provide authoritative texts enhanced by introductions and notes by distinguished scholars and contemporary authors, as well as up-to-date translations by award-winning translators.",
                    AuthorId = 18,
                    CategoryId = 2,
                    BookURL = "https://dn790008.ca.archive.org/0/items/cu31924022342871/cu31924022342871.pdf",
                    ImageURL = "https://i.gr-assets.com/images/S/compressed.photo.goodreads.com/books/1650844397l/60784591.jpg"
                },
                new Book
                {
                    Id = 14,
                    Title = "The Picture of Dorian Gray",
                    ISBN = "9780359788330",
                    Pages = 188,
                    PublishedDate = new DateTime(2019, 7, 12),
                    Description = "The Picture of Dorian Gray is the only published novel by Oscar Wilde, appearing as the lead story in Lippincott's Monthly Magazine on 20 June 1890, printed as the July 1890 issue. The magazine's editors feared the story was indecent as submitted, so they censored roughly 500 words, without Wilde's knowledge, before publication. But even with that, the story was still greeted with outrage by British reviewers, some of whom suggested that Wilde should be prosecuted on moral grounds, leading Wilde to defend the novel aggressively in letters to the British press. Today, Wilde's fin de siècle novella is considered a classic. This new edition from Immortal Books includes footnotes and images.",
                    AuthorId = 19,
                    CategoryId = 2,
                    BookURL = "https://publicdomainlibrary.org/en/ebooks/the-picture-of-dorian-gray?gad_source=1&gad_campaignid=22457961356&gclid=CjwKCAjwjffHBhBuEiwAKMb8pMSgkz-tGttv47qIsPHlijqk2n0fVPqoWapPnusGOGzyQVWHU7wi5BoCWecQAvD_BwE",
                    ImageURL = "https://storage.googleapis.com/media365-live.appspot.com/266c3ce1-c23a-4770-bbe7-8e37467cc81c/0d22b809-2cf9-463f-a0d4-2bbb98dbc5a9/eabb424e-d460-44c3-ab64-ef47be8b87f5.jpg"
                },
                new Book
                {
                    Id = 15,
                    Title = "Frankenstein",
                    ISBN = "EAN:8596547791485",
                    Pages = 234,
                    PublishedDate = new DateTime(2023, 12, 27),
                    Description = "Mary Shelley's 'Frankenstein' is a groundbreaking work of gothic literature that explores themes of ambition, isolation, and the consequences of playing god. Written in an epistolary format, the reader is drawn into the chilling tale of Victor Frankenstein and his creation, the monster. Shelley's descriptive prose and use of multiple narrators create a sense of foreboding and unease, making 'Frankenstein' a timeless classic in the literary canon. The novel also raises ethical questions about scientific responsibility and the limits of human knowledge, making it a thought-provoking read for modern audiences. Mary Shelley's personal experiences, including the death of her own children and her tumultuous relationship with Percy Bysshe Shelley, undoubtedly influenced the creation of 'Frankenstein.' Her unique perspective as a female author in the 19th century adds layers of depth to the story, highlighting the societal expectations and constraints faced by women of her time. I highly recommend 'Frankenstein' to readers who enjoy thought-provoking literature that delves into the darker aspects of human nature and morality.",
                    AuthorId = 20,
                    CategoryId = 2,
                    BookURL = "https://www.gutenberg.org/files/84/84-h/84-h.htm",
                    ImageURL = "https://img.perlego.com/book-covers/2501062/9782378072452_300_450.webp"
                },
                new Book
                {
                    Id = 16,
                    Title = "Mrs. Dalloway",
                    ISBN = "STANFORD:36105003773616",
                    Pages = 312,
                    PublishedDate = new DateTime(1925, 1, 1),
                    Description = "Heralded as Virginia Woolf's greatest novel, this is a vivid portrait of a single day in a woman's life. When we meet her, Mrs. Clarissa Dalloway is preoccupied with the last-minute details of party preparation while in her mind she is something much more than a perfect society hostess. As she readies her house, she is flooded with remembrances of faraway times. And, met with the realities of the present, Clarissa reexamines the choices that brought her there, hesitantly looking ahead to the unfamiliar work of growing old. \"Mrs. Dalloway was the first novel to split the atom. If the novel before Mrs. Dalloway aspired to immensities of scope and scale, to heroic journeys across vast landscapes, with Mrs. Dalloway Virginia Woolf insisted that it could also locate the enormous within the everyday; that a life of errands and party-giving was every bit as viable a subject as any life lived anywhere; and that should any human act in any novel seem unimportant, it has merely been inadequately observed. The novel asan art form has not been the same since. \"Mrs. Dalloway also contains some of the most beautiful, complex, incisive and idiosyncratic sentences ever written in English, and that alone would be reason enough to read it. It is one of the most moving, revolutionary artworks of the twentieth century.\" --Michael Cunningham, author of The Hours",
                    AuthorId = 21,
                    CategoryId = 2,
                    BookURL = "https://dn721907.ca.archive.org/0/items/in.ernet.dli.2015.93420/2015.93420.Mrs-Dalloway.pdf",
                    ImageURL = "https://cdn.kobo.com/book-images/dc043919-597a-4d28-bfe7-f2638a464ce1/1200/1200/False/mrs-dalloway-141.jpg"
                },
                new Book
                {
                    Id = 17,
                    Title = "The Street of Crocodiles",
                    ISBN = "9788087830277",
                    Pages = 136,
                    PublishedDate = new DateTime(2025, 3, 19),
                    Description = "''The Street of Crocodiles'' by Bruno Schulz (1892-1942) was first published in Polish in 1934; this English translation was first published in the US by Walker and Company in 1963, public domain. A novel that blends the real and the fantastic, from \"one of the most original imaginations in modern Europe\" (Cynthia Ozick). The Street of Crocodiles in the Polish city of Drogobych is a street of memories and dreams where recollections of Bruno Schulz's uncommon boyhood and of the eerie side of his merchant family's life are evoked in a startling blend of the real and the fantastic. Most memorable - and most chilling - is the portrait of the author's father, a maddened shopkeeper who imports rare birds' eggs to hatch in his attic, who believes tailors' dummies should be treated like people, and whose obsessive fear of cockroaches causes him to resemble one. Bruno Schulz, a Polish Jew killed by the Nazis in 1942, is considered by many to have been the leading Polish writer between the two world wars.",
                    AuthorId = 22,
                    CategoryId = 2,
                    BookURL = "https://archive.org/details/streetofcrocodil00schu_0",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSrhv8HOOGw56ABHammfAbunGUhTAi_F_2eQQ&s"
                },
                new Book
                {
                    Id = 18,
                    Title = "The Visitor",
                    ISBN = "9780553811889",
                    Pages = 516,
                    PublishedDate = new DateTime(2001, 1, 1),
                    Description = "\"Sergeant Amy Callan and Lieutenant Caroline Cook have a lot in common. Both were army high-flyers. Both were acquainted with Jack Reacher. Both were forced to resign from the service. Now they're both dead. Both were found in their own home, naked, in a bath full of paint. Both apparent victims of an army man. A loner, a smart guy with a score to settle, a ruthless vigilante. A man just like Jack Reacher.\"--Cover.",
                    AuthorId = 23,
                    CategoryId = 2,
                    BookURL = "https://cdn.bookey.app/files/pdf/book/en/the-visitor.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSwLvDmcI4YiQIE4eU9mKt_NuPUVulD8hiZxA&ss"
                },
                new Book
                {
                    Id = 19,
                    Title = "A Portrait of the Artist as a Young Man",
                    ISBN = "9781387679249",
                    Pages = 194,
                    PublishedDate = new DateTime(2018, 3, 19),
                    Description = "James JoyceÕs 1916 novella A Portrait of the Artist as a Young Man is about the early manhood of Stephen Dedalus, later one of the leading characters in Ulysses. StephenÕs growing self-awareness as an artist forces him to reject the whole narrow world in which he has been brought up, including family ties, nationalism, and the Catholic religion.",
                    AuthorId = 24,
                    CategoryId = 2,
                    BookURL = "https://www.gutenberg.org/files/4217/4217-h/4217-h.htm",
                    ImageURL = "https://archive.org/services/img/portrait_artist_pb_librivox/full/pct:500/0/default.jpg"
                },
                new Book
                {
                    Id = 20,
                    Title = "Jacob's Room",
                    ISBN = "9781681951607",
                    Pages = 183,
                    PublishedDate = new DateTime(2015, 8, 7),
                    Description = "A Nonconformist Novel with No Central Character “Either we are men, or we are women. Either we are cold, or we are sentimental. Either we are young, or growing old. In any case life is but a procession of shadows, and God knows why it is that we embrace them so eagerly, and see them depart with such anguish, being shadows.” - Virginia Woolf, Jacob's Room Jacob’s Room is not your typical Victorian English novel. The fact that there is no real protagonist stands out the most. Jacob is not actually a character, only a collection of memories, feelings and sensations. His life is like a room seen through the eyes of other people. This Xist Classics edition has been professionally formatted for e-readers with a linked table of contents. This eBook also contains a bonus book club leadership guide and discussion questions. We hope you’ll share this book with your friends, neighbors and colleagues and can’t wait to hear what you have to say about it.",
                    AuthorId = 25,
                    CategoryId = 2,
                    BookURL = "https://www.sas.upenn.edu/~cavitch/pdf-library/Woolf_Jacob_s_Room.pdf",
                    ImageURL = "https://www.epubbooks.com/images/covers/woolf-jacobs-room.jpg"
                },
                new Book
                {
                    Id = 21,
                    Title = "A Holiday of Love",
                    ISBN = "9781416517214",
                    Pages = 386,
                    PublishedDate = new DateTime(2005, 10, 25),
                    Description = "In New York City in the late 1800s, a beautiful but clumsy angel turns a lonely man's life around.... In medieval Scotland, the intrigues of a Christmas Mass imperil two Highland lovers....In Regency London, a world-weary lord receives an outrageous proposal....And in modern-day Colorado, a clever twelve-year-old plays matchmaker for his bighearted but impractical mother.",
                    AuthorId = 26, // Jude Deveraux (first author)
                    CategoryId = 3,
                    BookURL = "https://archive.org/details/holidayoflove00mcna",
                    ImageURL = "https://m.media-amazon.com/images/I/71naXXQqs6L._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 22,
                    Title = "Jane Eyre",
                    ISBN = "9780007866090",
                    Pages = 462,
                    PublishedDate = new DateTime(2010, 1, 1),
                    Description = "Bronte's infamous Gothic novel tells the story of orphan Jane, a child of unfortunate circumstances. Raised and treated badly by her aunt and cousins and eventually sent away to a cruel boarding school, it is not until Jane becomes a governess at Thornfield that she finds happiness. Meek, measured, but determined, Jane soon falls in love with her brooding and stormy master, Mr Rochester, but it is not long before strange and unnerving events occur in the house and Jane is forced to leave Thornfield to pursue her future.",
                    AuthorId = 30,
                    CategoryId = 3,
                    BookURL = "https://www.gutenberg.org/files/1260/1260-h/1260-h.htm",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSAYviU6qJ8Y4lqDwBrA7s1fN7ZWGErMtRBcQ&s"
                },
                new Book
                {
                    Id = 23,
                    Title = "Pride and Prejudice",
                    ISBN = "9780192815033",
                    Pages = 388,
                    PublishedDate = new DateTime(1980, 1, 1),
                    Description = "The text of Pride and Prejudice is the 1813 first edition text.",
                    AuthorId = 31,
                    CategoryId = 3,
                    BookURL = "https://giove.isti.cnr.it/demo/eread/Libri/joy/Pride.pdf",
                    ImageURL = "https://storage.googleapis.com/media365-live.appspot.com/266c3ce1-c23a-4770-bbe7-8e37467cc81c/22ce3cd6-766e-420b-98a2-bbdcd42d0605/9a042421-4511-4505-91dd-5f9b3429479c.jpg"
                },
                new Book
                {
                    Id = 24,
                    Title = "Prince Charming",
                    ISBN = "9780671870966",
                    Pages = 564,
                    PublishedDate = new DateTime(1995, 2, 1),
                    Description = "Beautiful Taylor Baker, whose fiance has eloped with her odious cousin and whose greedy uncle has his own plans for her, escapes to Montana with rough-edged American Lucas Ross.",
                    AuthorId = 32,
                    CategoryId = 3,
                    BookURL = "https://www.scribd.com/doc/300749775/Prince-Charming",
                    ImageURL = "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1610568034i/55509539.jpg"
                },
                new Book
                {
                    Id = 25,
                    Title = "Me Before You (Movie Tie-In)",
                    ISBN = "9780143109464",
                    Pages = 402,
                    PublishedDate = new DateTime(2016, 4, 26),
                    Description = "Taking a job as an assistant to extreme sports enthusiast Will, who is wheelchair bound after a motorcycle accident, Louisa struggles with her employer's acerbic moods and learns of his shocking plans before demonstrating to him that life is still worth living.",
                    AuthorId = 33,
                    CategoryId = 3,
                    BookURL = "https://icrrd.com/public/media/14-05-2021-091024Me-Before-You.pdf",
                    ImageURL = "https://m.media-amazon.com/images/I/914woZe6eBL._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 26,
                    Title = "Sunset in St. Tropez",
                    ISBN = "UOM:39015055087590",
                    Pages = 248,
                    PublishedDate = new DateTime(2002, 1, 1),
                    Description = "Taking a vacation together to grieve over the death of one of their group, five friends are dismayed by the ramshackle mansion they find instead of the garden villa they expected, and the unexpected appearance of the new girlfriend of the widowed husband.",
                    AuthorId = 34,
                    CategoryId = 3,
                    BookURL = "https://archive.org/details/sunsetinsttropez0000stee_q3j8",
                    ImageURL = "https://livrariapublica.com.br/capa/por-do-sol-em-saint-tropez-danielle-steel-pdf-B0176TJFF8.webp"
                },
                new Book
                {
                    Id = 27,
                    Title = "Last Voyage of the Valentina",
                    ISBN = "9780743299435",
                    Pages = 417,
                    PublishedDate = new DateTime(2006, 5, 23),
                    Description = "\"Originally published in Great Britain in 2005 by Hodder and Stoughton\"--T.p. verso.",
                    AuthorId = 35,
                    CategoryId = 3,
                    BookURL = "https://archive.org/details/lastvoyageofvale0000mont_v8n7",
                    ImageURL = "https://archive.org/services/img/lastvoyageofvale0000mont_v8n7/full/pct:200/0/default.jpg"
                },
                new Book
                {
                    Id = 28,
                    Title = "Special Delivery",
                    ISBN = "UOM:39015041359921",
                    Pages = 232,
                    PublishedDate = new DateTime(1997, 1, 1),
                    Description = "Tells the story of Jack Watson, a wealthy Beverly Hills businessman and widower, who falls in love with his daughter-in-law's mother and together they discover a relationship marked by challenges and surprises.",
                    AuthorId = 34,
                    CategoryId = 3,
                    BookURL = "https://archive.org/details/specialdelivery0000dani",
                    ImageURL = "https://media.oceanofpdf.com/2023/04/PDF-EPUB-Special-Delivery-A-short-crime-fiction-story-Case-Files-pocket-sized-murder-mysteries-by-Rachel-Amphlett-Download.jpg"
                },
                new Book
                {
                    Id = 29,
                    Title = "Love Only Once",
                    ISBN = "9780739446461",
                    Pages = 452,
                    PublishedDate = new DateTime(1985, 1, 1),
                    Description = "The exquisite niece of Lord Edward and Lady Charlotte Malory, Regina Ashton is outraged over her abduction by the arrogant, devilishly handsome Nicholas Eden, and is determined to make the rogue pay, with his heart.",
                    AuthorId = 36,
                    CategoryId = 3,
                    BookURL = "https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwiPk4Ko_cGQAxXgW_EDHfX3LOEQFnoECBgQAQ&url=https%3A%2F%2Farchive.org%2Fdetails%2Floveonlyonce00lind&usg=AOvVaw3eaa1Mhc73cUJ1Du7Tso0J&opi=89978449",
                    ImageURL = "https://image.ebooks.com/cover/692903.jpg"
                },
                new Book
                {
                    Id = 30,
                    Title = "Toxic Bachelors",
                    ISBN = "UOM:39015062619377",
                    Pages = 344,
                    PublishedDate = new DateTime(2005, 1, 1),
                    Description = "Three daunting bachelors embark on a journey to the Mediterranean where they face women who challenge their deepest relationship phobias, sparking big changes in the once-carefree trio that just might put an end to their carousing days.",
                    AuthorId = 34,
                    CategoryId = 3,
                    BookURL = "https://archive.org/details/toxicbachelors0000dani",
                    ImageURL = "https://archive.org/services/img/toxicbachelors0000dani"
                },
                new Book
                {
                    Id = 31,
                    Title = "The Magician's Nephew Color Gift Edition",
                    ISBN = "9780060530846",
                    Pages = 122,
                    PublishedDate = new DateTime(2003, 11, 4),
                    Description = "The first book in The Chronicles of Narnia is now available in a full-color, unabridged gift edition that includes all of the original Pauline Baynes illustrations.",
                    AuthorId = 37,
                    CategoryId = 4,
                    BookURL = "https://www.google.com/url?sa=t&rct=j&q=&esrc=s&source=web&cd=&ved=2ahUKEwj-8afY_cGQAxVWBdsEHQ61D-sQFnoECBgQAQ&url=https%3A%2F%2Fdn720006.ca.archive.org%2F0%2Fitems%2Fenglish-collections-k-z%2Fmagician%2527s%2520nephew%252C%2520The%2520-%2520C.%2520S.%2520Lewis.pdf&usg=AOvVaw0oCLuQynRIlzrwUbyuWEkv&opi=89978449",
                    ImageURL = "https://churchsource.com/cdn/shop/products/9780064471107_988c6bba-41a4-4f41-ac7b-52f6154e499f_1024x.jpg?v=1644428660"
                },
                new Book
                {
                    Id = 32,
                    Title = "A Wizard of Earthsea",
                    ISBN = "9780547851396",
                    Pages = 267,
                    PublishedDate = new DateTime(2012, 1, 1),
                    Description = "A boy grows to manhood while attempting to subdue the evil he unleashed on the world as an apprentice to the Master Wizard.",
                    AuthorId = 38,
                    CategoryId = 4,
                    BookURL = "https://archive.org/details/wizardofearthsea00legu_1",
                    ImageURL = "https://cdn.kobo.com/book-images/cdebd2d5-7b6e-4447-9990-4630e6c29e35/1200/1200/False/a-wizard-of-earthsea-1.jpg"
                },
                new Book
                {
                    Id = 33,
                    Title = "Moomin, Mymble and Little My",
                    ISBN = "9780953522743",
                    Pages = 0,
                    PublishedDate = new DateTime(2001, 1, 1),
                    Description = "Finnish artist Tove Jansson's Moomin stories have been continually in print for more than half a century, in 35 languages. They are among Europe's best loved and enduring children's classics, and through the TV animation (BBC2), the warm-hearted, whimsical creatures of Moomin valley have been brought to a new younger British audience.Introducing the first Sort Of Children's Classic in a new English version by Sophie Hannah. Sort of Books proudly presents the original full colour Moomin picture book with its irresistible cut-out page designs and playful rhyming text in a new version by one of Britain's star poets.",
                    AuthorId = 39,
                    CategoryId = 4,
                    BookURL = "https://www.scribd.com/document/720685287/The-Book-about-Moomin-Mymble-and-Little-My",
                    ImageURL = "https://imgv2-2-f.scribdassets.com/img/document/720685287/original/6bfbb8842c/1?v=1"
                },
                new Book
                {
                    Id = 34,
                    Title = "The Lord of the Rings",
                    ISBN = "PSU:000045256417",
                    Pages = 1176,
                    PublishedDate = new DateTime(2001, 1, 1),
                    Description = "Contains the complete set of the six books of Lord of the Rings.",
                    AuthorId = 40, // j.r.r. tolkien (first author)
                    CategoryId = 4,
                    BookURL = "https://ia903107.us.archive.org/35/items/j-r-r-tolkien-lord-of-the-rings-01-the-fellowship-of-the-ring-retail-pdf/j-r-r-tolkien-lord-of-the-rings-01-the-fellowship-of-the-ring-retail-pdf.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQrNrbgGKC7bY46PW56AIvpLH45OwGJT9uqpg&s"
                },
                new Book
                {
                    Id = 35,
                    Title = "Through the Looking-Glass",
                    ISBN = "9780688120498",
                    Pages = 248,
                    PublishedDate = new DateTime(1993, 4, 23),
                    Description = "Publisher description",
                    AuthorId = 42,
                    CategoryId = 4,
                    BookURL = "http://birrell.org/andrew/alice/lGlass.pdf",
                    ImageURL = "https://www.pdfbooksworld.com/image/cache/catalog/256-500x500.jpg"
                },
                new Book
                {
                    Id = 36,
                    Title = "The Voyage of the Dawn Treader",
                    ISBN = "9780006716655",
                    Pages = 196,
                    PublishedDate = new DateTime(1980, 1, 1),
                    Description = "The \"Dawn Treader\" is the first ship Narnia has seen in centuries. King Caspian has built it for his voyage to find the seven lords, good men whom his evil uncle Mizaz banished when he usurped the throne. The journey takes Edmund, Lucy, and their cousin Eustace to the Eastern Islands, beyond the Silver Sea, toward Aslan's country at the End of the World. Illustrations.",
                    AuthorId = 43,
                    CategoryId = 4,
                    BookURL = "https://www.samizdat.qc.ca/arts/lit/PDFs/VoyageoftheDawnTreader_CSL.pdf",
                    ImageURL = "https://online.fliphtml5.com/fazjo/bzig/files/large/1.webp?1611245094&1611245094"
                },
                new Book
                {
                    Id = 37,
                    Title = "The Lion, the Witch and the Wardrobe",
                    ISBN = "PSU:000028266402",
                    Pages = 168,
                    PublishedDate = new DateTime(1950, 1, 1),
                    Description = "The best-selling rack edition of The Lion, the Witch and the Wardrobe now has a movie still cover and an eight-page movie still insert! \"Excellent for Homeschool Use\"",
                    AuthorId = 43,
                    CategoryId = 4,
                    BookURL = "https://www.samizdat.qc.ca/arts/lit/PDFs/LionWitchWardrobe_CSL.pdf",
                    ImageURL = "https://imgv2-2-f.scribdassets.com/img/document/432919347/original/c0ed155ebd/1?v=1"
                },
                new Book
                {
                    Id = 38,
                    Title = "The Wizard of Oz",
                    ISBN = "9781905716524",
                    Pages = 188,
                    PublishedDate = new DateTime(2009, 1, 1),
                    Description = ".0000000000This is the story of Dorothy and her little dog Toto, who are carried away from Kansas by a cyclone and transported to the wonderful world of Oz. She meets three companions - the Scarecrow, the Tin Woodman and the Cowardly Lion - and the three journey to the Emerald City of Oz to ask the Wizard of Oz to give them their hearts' desires, which in Dorothy's case is to return home to Kansas. On their way to Oz and while fulfilling the tasks that the surprising Wizard asks of them they encounter witches, winged monkeys, the Deadly Desert, fighting trees and magic shoes.This edition is evocatively illustrated with the original drawings of W. W. Denslow, with an Afterword by Ned Halley.",
                    AuthorId = 44,
                    CategoryId = 4,
                    BookURL = "https://web.seducoahuila.gob.mx/biblioweb/upload/the_wonderful_wizard_of_oz.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRhsCGaMxMJsWSl5RMQ7za1U_HTzWSNhSJn_g&s"
                },
                new Book
                {
                    Id = 39,
                    Title = "The Wind in the Willows",
                    ISBN = "UOM:39015008859509",
                    Pages = 322,
                    PublishedDate = new DateTime(1908, 1, 1),
                    Description = "The escapades of four animal friends who live along a river in the English countryside--Toad, Mole, Rat, and Badger.",
                    AuthorId = 45,
                    CategoryId = 4,
                    BookURL = "https://www.sas.upenn.edu/~cavitch/pdf-library/Grahame_Wind_in_the_Willows_1908.pdf",
                    ImageURL = "https://www.rif.org/sites/default/files/images/2022/06/14/Book_Covers/wind-in-willows.jpg"
                },
                new Book
                {
                    Id = 40,
                    Title = "Bloodmarked",
                    ISBN = "9781534441637",
                    Pages = 576,
                    PublishedDate = new DateTime(2022, 11, 8),
                    Description = "\"When the leaders of the Order reveal that they will do everything in their power to keep the approaching demon war a secret, Bree and her friends go on the run so she can learn how to control her devastating new powers.\"--",
                    AuthorId = 46,
                    CategoryId = 4,
                    BookURL = "https://cdn.bookey.app/files/pdf/book/en/bloodmarked.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQYddngMuOus0j4dRoKcdZaEMLN6LZE9cKKBA&s"
                },
                 new Book
                 {
                     Id = 41,
                     Title = "QBD Murder on the Orient Express",
                     ISBN = "9780007948697",
                     Pages = 0,
                     PublishedDate = new DateTime(2015, 6, 8),
                     Description = "QBD Murder on the Orient Express",
                     AuthorId = 47,
                     CategoryId = 5,
                     BookURL = "https://www.by-the-way.fr/wp-content/uploads/2021/02/Murder-on-the-Orient-Express-1.pdf",
                     ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSL6oNHnP30AFFa0TerAy860nUAY1jNCpyUOg&s"
                 },
                new Book
                {
                    Id = 42,
                    Title = "The Da Vinci Code",
                    ISBN = "9780593054253",
                    Pages = 484,
                    PublishedDate = new DateTime(2004, 1, 1),
                    Description = "Harvard professor Robert Langdon receives an urgent late-night phone call while on business in Paris: the elderly curator of the Louvre, Jacques Sauni're, has been brutally murdered inside the museum. Alongside the body, police have found a series of baffling codes. As Langdon and a gifted French cryptologist, Sophie Neveu, begin to sort through the bizarre riddles, they are stunned to find a trail that leads to the works of Leonardo Da Vinci - and suggests the answer to a mystery that stretches deep into the vault of history. Langdon suspects the late curator was involved in the Priory of Sion - a centuries old secret society - and has sacrificed his life to protect the Priory's most sacred trust: the location of a vastly important religious relic hidden for centuries. But it now appears that Opus Dei, a clandestine sect that has long plotted to seize the Prirory's secret, has now made its move. Unless Langdon and Neveu can decipher the labyrinthine code and quickly assemble the pieces of the puzzle, the Priory's secret - and a stunning historical truth - will be lost forever. Breaking the mould of traditional suspense novels, The DA VINCI CODE is simultaneously lightning-paced, intelligent and intricately layered with remarkable research and detail. And in this exclusive edition Dan Brown allows the reader behind the scenes of the novel which now incorporates over 150 photographs and illustrations throughout the text showing the rich historical tapestry from which he drew his inspiration. The visual sources which provide both the backdrop and the stimulus for the novel's action are revealed for the first time and uniquely complement the reading experience.",
                    AuthorId = 48,
                    CategoryId = 5,
                    BookURL = "https://books.google.com/books/about/QBD_Murder_on_the_Orient_Express.html?hl=&id=VHYXrgEACAAJ",
                    ImageURL = "https://danbrown.com/wp-content/uploads/2024/10/Dan-Brown_DVCYA_book-cover.jpg"
                },
                new Book
                {
                    Id = 43,
                    Title = "The Curious Incident of the Dog in the Night-time",
                    ISBN = "UOM:39015062063501",
                    Pages = 288,
                    PublishedDate = new DateTime(2003, 1, 1),
                    Description = "YA. Murder mystery. Despite his overwhelming fear of interacting with people, Christopher, a mathematically-gifted, autistic fifteen-year-old boy, decides to investigate the murder of a neighbour's dog and uncovers secret information about his mother. Whitbread book of the year 2003. WAYRBA list 2005.",
                    AuthorId = 49,
                    CategoryId = 5,
                    BookURL = "https://englishprva.weebly.com/uploads/8/8/2/3/88239198/the_curious_incident_of_the_dog_in_the_night_time.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTtlv5N0MAfZQuADdOiaWgIZb8jaciZxqMYxw&s"
                },
                new Book
                {
                    Id = 44,
                    Title = "The Black Tower",
                    ISBN = "9780743219617",
                    Pages = 352,
                    PublishedDate = new DateTime(2001, 10, 2),
                    Description = "Adam Dalgliesh responds to an invitation to visit an old family friend, the chaplain at a private home for the disabled in Dorset. On arrival he discovers that his host has died suddenly.",
                    AuthorId = 50,
                    CategoryId = 5,
                    BookURL = "https://cdn.bookey.app/files/pdf/book/en/the-black-tower.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQDNcrRkQWMvXON46YjBGwXfOEMR4jAL8UWhA&s"
                },
                new Book
                {
                    Id = 45,
                    Title = "The ABC Murders",
                    ISBN = "9780006167242",
                    Pages = 224,
                    PublishedDate = new DateTime(1993, 1, 1),
                    Description = "When Alice Ascher is murdered in Andover, Hercule Poirot is already onto the clues. Alphabetically speaking, it's one down, 25 to go. This classic mystery is now repackaged in a digest-sized edition for young adults. Reissue.",
                    AuthorId = 47,
                    CategoryId = 5,
                    BookURL = "https://ia801500.us.archive.org/18/items/in.ernet.dli.2015.88942/2015.88942.The-A-B-C-Murders-A-Hercule-Poirot-Mystery.pdf",
                    ImageURL = "https://hive.dmmserver.com/media/640/97800071/9780007184798.jpg"
                },
                new Book
                {
                    Id = 46,
                    Title = "The Golden Ball and Other Stories",
                    ISBN = "9780425099223",
                    Pages = 244,
                    PublishedDate = new DateTime(1984, 1, 1),
                    Description = "It was an offer the St. Vincent family could not refuse -- a splendid mansion, complete with servants, with nothing asked for in return! But young Rupert St. Vincent suspected a sinister trap ...",
                    AuthorId = 47,
                    CategoryId = 5,
                    BookURL = "https://archive.org/details/goldenballothers00chri_0",
                    ImageURL = "https://m.media-amazon.com/images/I/810O+cRm1DL._AC_UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 47,
                    Title = "Crime and Punishment",
                    ISBN = "RUTGERS:390300038488030",
                    Pages = 520,
                    PublishedDate = new DateTime(1955, 1, 1),
                    Description = "Introduction by W. J. Leatherbarrow; Translation by Richard Pevear and Larissa Volokhonsky Copyright © Libri GmbH. All rights reserved.",
                    AuthorId = 51,
                    CategoryId = 5,
                    BookURL = "https://publicdomainlibrary.org/en/ebooks/crime-and-punishment?gad_source=1&gad_campaignid=22451384280&gclid=CjwKCAjwjffHBhBuEiwAKMb8pBjy-e_ly5ktSuU5W0sa-Ycd7i8lj_HgcPMuML_olDUDvpEaf9emqRoCw2gQAvD_BwE",
                    ImageURL = "https://cdn.kobo.com/book-images/2293d740-178e-4da1-a849-b11d6308fbaa/1200/1200/False/crime-and-punishment-35.jpg"
                },
                new Book
                {
                    Id = 48,
                    Title = "Seeking Whom He May Devour",
                    ISBN = "9780743284028",
                    Pages = 307,
                    PublishedDate = new DateTime(2006, 11, 7),
                    Description = "\"A small mountain community in the French Alps is roused to terror when they awaken each morning to find yet another of their sheep with its throat torn out. One of the villagers thinks it might be a werewolf, and when she's found killed in the same manner, people begin to wonder if she might have been right. Suspicion falls on Massart, a loner living on the edge of town\"--Publisher website (April 2007).",
                    AuthorId = 52,
                    CategoryId = 5,
                    BookURL = "https://archive.org/details/seekingwhomhemay00fred",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRiSPUuLhWO8R55NFwa9CFni3bZb5YRy32hHQ&s"
                },
                new Book
                {
                    Id = 49,
                    Title = "The Daughter of Time",
                    ISBN = "9780020545507",
                    Pages = 212,
                    PublishedDate = new DateTime(1988, 1, 1),
                    Description = "A hospitalized English policeman reconstructs historical evidence concerning Richard III's role in the murder of Edward IV's two sons.",
                    AuthorId = 53,
                    CategoryId = 5,
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTi55-EYvE9QWrcLwywNEee5WGxayNGrwJdAw&s",
                    BookURL = "https://gutenberg.ca/ebooks/teyj-daughteroftime/teyj-daughteroftime-00-h-dir/teyj-daughteroftime-00-h.html"
                },
                new Book
                {
                    Id = 50,
                    Title = "The House at Riverton",
                    ISBN = "9781416550532",
                    Pages = 496,
                    PublishedDate = new DateTime(2009, 3, 3),
                    Description = "Ninety-eight-year-old Grace Bradley is visited by a young director who takes her back to Riverton House where she reveals the secret behind the death of a young poet in the summer of 1924.",
                    AuthorId = 54,
                    CategoryId = 5,
                    BookURL = "https://archive.org/details/houseatriverto00mort",
                    ImageURL = "https://media.oceanofpdf.com/2019/10/PDF-EPUB-The-House-at-Riverton-Download.jpg"
                },
                new Book
                {
                    Id = 51,
                    Title = "The Discarded Image",
                    ISBN = "9780521477352",
                    Pages = 248,
                    PublishedDate = new DateTime(1994, 8, 26),
                    Description = "Hailed as \"the final memorial to the work of a great scholar and teacher and a wise and noble mind,\" this work paints a lucid picture of the medieval world view, as historical and cultural background to the literature of the Middle Ages and Renaissance.",
                    AuthorId = 55,
                    CategoryId = 6,
                    BookURL = "https://classicalastrologer.com/wp-content/uploads/2017/12/c-s-lewis-the-discarded-image.pdf",
                    ImageURL = "https://img.perlego.com/book-covers/588293/9780062313706_300_450.webp"
                },
                new Book
                {
                    Id = 52,
                    Title = "Alexander the Great",
                    ISBN = "9781439193280",
                    Pages = 418,
                    PublishedDate = new DateTime(2011, 1, 4),
                    Description = "In the first authoritative biography of Alexander the Great written for a general audience in a generation, classicist and historian Philip Freeman tells the remarkable life of the great conqueror. The celebrated Macedonian king has been one of the most enduring figures in history. He was a general of such skill and renown that for two thousand years other great leaders studied his strategy and tactics, from Hannibal to Napoleon, with countless more in between. He flashed across the sky of history like a comet, glowing brightly and burning out quickly: crowned at age nineteen, dead by thirty-two. He established the greatest empire of the ancient world; Greek coins and statues are found as far east as Afghanistan. Our interest in him has never faded. Alexander was born into the royal family of Macedonia, the kingdom that would soon rule over Greece. Tutored as a boy by Aristotle, Alexander had an inquisitive mind that would serve him well when he faced formidable obstacles during his military campaigns. Shortly after taking command of the army, he launched an invasion of the Persian empire, and continued his conquests as far south as the deserts of Egypt and as far east as the mountains of present-day Pakistan and the plains of India. Alexander spent nearly all his adult life away from his homeland, and he and his men helped spread the Greek language throughout western Asia, where it would become the lingua franca of the ancient world. Within a short time after Alexander’s death in Baghdad, his empire began to fracture. Best known among his successors are the Ptolemies of Egypt, whose empire lasted until Cleopatra. In his lively and authoritative biography of Alexander, classical scholar and historian Philip Freeman describes Alexander’s astonishing achievements and provides insight into the mercurial character of the great conqueror. Alexander could be petty and magnanimous, cruel and merciful, impulsive and farsighted. Above all, he was ferociously, intensely competitive and could not tolerate losing—which he rarely did. As Freeman explains, without Alexander, the influence of Greece on the ancient world would surely not have been as great as it was, even if his motivation was not to spread Greek culture for beneficial purposes but instead to unify his empire. Only a handful of people have influenced history as Alexander did, which is why he continues to fascinate us.",
                    AuthorId = 56,
                    CategoryId = 6,
                    BookURL = "https://www.defence.lk/upload/ebooks/Alexander%20the%20Great.pdf",
                    ImageURL = "https://online.flipbuilder.com/fdyv/lcvg/files/mobile/1.jpg?201020211740"
                },
                new Book
                {
                    Id = 53,
                    Title = "The Making of the Roman Army",
                    ISBN = "UOM:39015040081864",
                    Pages = 298,
                    PublishedDate = new DateTime(1984, 1, 1),
                    Description = "The Making of the Roman Army",
                    AuthorId = 57,
                    CategoryId = 6,
                    BookURL = "https://www.academia.edu/123650107/The_Making_of_the_Roman_Army_From_Republic_to_Empire",
                    ImageURL = "https://0.academia-photos.com/attachment_thumbnails/118032214/mini_magick20240907-1-c0ef9j.png?1725739352"
                },
                new Book
                {
                    Id = 54,
                    Title = "Pocahontas's People",
                    ISBN = "9780806128498",
                    Pages = 420,
                    PublishedDate = new DateTime(1990, 1, 1),
                    Description = "In this history, Helen C. Roundtree traces events that shaped the lives of the Powhatan Indians of Virginia, from their first encounter with English colonists, in 1607, to their present-day way of life and relationship to the state of Virginia and the federal government. Roundtree’s examination of those four hundred years misses not a beat in the pulse of Powhatan life. Combining meticulous scholarship and sensitivity, the author explores the diversity always found among Powhatan people, and those people’s relationships with the English, the government of the fledgling United States, the Union and the Confederacy, the U.S. Census Bureau, white supremacists, the U.S. Selective Service, and the civil rights movement.",
                    AuthorId = 58,
                    CategoryId = 6,
                    BookURL = "https://archive.org/details/pocahontasspeopl0000roun",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQNPK5irLXh4fL2zwTrziJM8ZMK-b_K0ZLMKw&s"
                },
                new Book
                {
                    Id = 55,
                    Title = "Oscar Wilde",
                    ISBN = "9780415159524",
                    Pages = 454,
                    PublishedDate = new DateTime(1997, 1, 1),
                    Description = "This set comprises 40 volumes covering 19th and 20th century European and American authors. These volumes will be available as a complete set, mini boxed sets (by theme) or as individual volumes. This second set compliments the first 68 volume set of Critical Heritage published by Routledge in October 1995.",
                    AuthorId = 59,
                    CategoryId = 6,
                    BookURL = "http://www.public-library.uk/dailyebook/Complete%20works%20of%20Oscar%20Wilde%20(1921)%201.pdf",
                    ImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781627933650/the-essential-oscar-wilde-9781627933650_hr.jpg"
                },
                new Book
                {
                    Id = 56,
                    Title = "Conservatism",
                    ISBN = "9780691037110",
                    Pages = 476,
                    PublishedDate = new DateTime(1997, 5, 4),
                    Description = "History Professor Jerry Muller locates the origins of modern conservatism within the Enlightenment and distinguishes conservatism from orthodoxy. Reviewing important specimens of analysis from the mid18th century through our own day, Muller demonstrates that characteristic features of conservative argument recur over time and across national borders.",
                    AuthorId = 60,
                    CategoryId = 6,
                    BookURL = "https://www.eolss.net/sample-chapters/C04/E6-32-04-03.pdfs",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQo_RV5oIFgxcTAFME084XVW6DQEOMihwYgmQ&s"
                },
                new Book
                {
                    Id = 57,
                    Title = "Constantinople: Capital of Byzantium",
                    ISBN = "9780826430861",
                    Pages = 308,
                    PublishedDate = new DateTime(2009, 5, 5),
                    Description = "This book examines the intriguing interaction between the spiritual and the political whilst reconstructs the awe-inspiring city in its heyday of 1200.",
                    AuthorId = 61,
                    CategoryId = 6,
                    BookURL = "https://archive.org/details/constantinopleca0000harr_q5n1",
                    ImageURL = "https://0.academia-photos.com/attachment_thumbnails/90991769/mini_magick20220913-1-bv6h0f.png?1663060204"
                },
                new Book
                {
                    Id = 58,
                    Title = "The Gates of Europe",
                    ISBN = "9780465073948",
                    Pages = 433,
                    PublishedDate = new DateTime(2015, 12, 1),
                    Description = "Ukraine is currently embroiled in a tense battle with Russia to preserve its economic and political independence. But today's conflict is only the latest in a long history of battles over Ukraine's existence as a sovereign nation. As award-winning historian Serhii Plokhy argues in The Gates of Europe, we must examine Ukraine's past in order to understand its fraught present and likely future. Situated between Europe, Russia, and the Asian East, Ukraine was shaped by the empires that have used it as astrategic gateway between East and West—from the Romans and Ottomans to the Third Reich and the Soviet Union,all have engaged in global fights for supremacy on Ukrainian soil.Each invading army left a lasting mark on the landscape and on the population, making modern Ukraine an amalgam of competing cultures.Authoritative and vividly written, The Gates of Europe will be the definitive history of Ukraine for years to come.",
                    AuthorId = 62,
                    CategoryId = 6,
                    BookURL = "https://shron3.chtyvo.org.ua/Plokhii_Serhii/The_Gates_of_Europe__A_History_of_Ukraine_anhl.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRa3veMqYITcruRWDhinKwL1BbD3aSanEqF6Q&s"
                },
                new Book
                {
                    Id = 59,
                    Title = "The Language Loss of the Indigenous",
                    ISBN = "9781317293132",
                    Pages = 294,
                    PublishedDate = new DateTime(2016, 2, 26),
                    Description = "This volume traces the theme of the loss of language and culture in numerous post-colonial contexts. It establishes that the aphasia imposed on the indigenous is but a visible symptom of a deeper malaise — the mismatch between the symbiotic relation nurtured by the indigenous with their environment and the idea of development put before them as their future. The essays here show how the cultures and the imaginative expressions of indigenous communities all over the world are undergoing a phase of rapid depletion. They unravel the indifference of market forces to diversity and that of the states, unwilling to protect and safeguard these marginalized communities. This book will be useful to scholars and researchers of cultural and literary studies, linguistics, sociology and social anthropology, as well as tribal and indigenous studies.",
                    AuthorId = 63,
                    CategoryId = 6,
                    BookURL = "https://www.academia.edu/33919901/The_Language_Loss_of_the_Indigenous",
                    ImageURL = "https://static.wixstatic.com/media/5ac455_64db10cfe2ab471fb0a3de1c37c1b854~mv2.jpg/v1/fill/w_638,h_1000,al_c,q_85,usm_0.66_1.00_0.01/5ac455_64db10cfe2ab471fb0a3de1c37c1b854~mv2.jpg"
                },
                new Book
                {
                    Id = 60,
                    Title = "A History of Armenia",
                    ISBN = "9781604449112",
                    Pages = 414,
                    PublishedDate = new DateTime(2018, 7, 1),
                    Description = "The volume is an easy reading and a must for the beginner student and interested party of the history of Armenia as well as for those more familiar with Armenian and its history. The author, an expert on Armenian history, has masterfully covered all aspects of the Armenian history such as Armenian literature, Armenian Church, the history of Armenian old and modern language, architecture, sculpture, music etc. along with all the historical events, starting from the beginning of the human civilization and that of Armenian one to the modern era of Armenia.",
                    AuthorId = 66,
                    CategoryId = 6,
                    BookURL = "https://ia601303.us.archive.org/31/items/historyofarmenia01cham/historyofarmenia01cham.pdf",
                    ImageURL = "https://archive.org/services/img/historyofarmenia0000bour/full/pct:200/0/default.jpg"
                },
                new Book
                {
                    Id = 61,
                    Title = "The Lord of Uraniborg",
                    ISBN = "9780521351584",
                    Pages = 537,
                    PublishedDate = new DateTime(1990, 1, 1),
                    Description = "The Lord of Uraniborg is a comprehensive biography of Tycho Brahe, father of modern astronomy, famed alchemist and littérateur of the sixteenth-century Danish Renaissance. Written in a lively and engaging style, Victor Thoren's biography offers interesting perspectives on Tycho's life and presents alternative analyses of virtually every aspect of his scientific work. A range of readers interested in astronomy, history of astronomy and the history of science will find this book fascinating.",
                    AuthorId = 67, // Victor E. Thoren (first author)
                    CategoryId = 7,
                    BookURL = "https://ia600100.us.archive.org/5/items/cu31924005641380/cu31924005641380.pdf",
                    ImageURL = "https://assets.cambridge.org/97805213/51584/large_cover/9780521351584i.jpg"
                },
                new Book
                {
                    Id = 62,
                    Title = "Dictionary of Greek and Roman Biography and Mythology: Earinus-Nyx",
                    ISBN = "UCAL:$B415016",
                    Pages = 1238,
                    PublishedDate = new DateTime(1846, 1, 1),
                    Description = "Dictionary of Greek and Roman Biography and Mythology: Earinus-Nyx",
                    AuthorId = 69,
                    CategoryId = 7,
                    BookURL = "https://archive.org/details/adictionarygree08smitgoog",
                    ImageURL = "https://assets.cambridge.org/97811080/60790/cover/9781108060790.jpg"
                },
                new Book
                {
                    Id = 63,
                    Title = "Eat, Pray, Love",
                    ISBN = "9780747585664",
                    Pages = 385,
                    PublishedDate = new DateTime(2007, 3, 5),
                    Description = "The Number One international bestseller, Eat, Pray Love is a journey around the world, a quest for spiritual enlightenment and a story for anyone who has battled with divorce, depression and heartbreak.",
                    AuthorId = 70,
                    CategoryId = 7,
                    BookURL = "https://institutes.abu.edu.ng/idr/public/assets/docs/Eat,%20Pray,%20Love%20(%20PDFDrive%20).pdf",
                    ImageURL = "https://online.fliphtml5.com/gutjj/zwbj/files/large/1.webp?1604750286&1604750286"
                },
                new Book
                {
                    Id = 64,
                    Title = "The Drowned and the Saved",
                    ISBN = "9781501167638",
                    Pages = 208,
                    PublishedDate = new DateTime(2017, 6, 20),
                    Description = "In his final book before his death, Primo Levi returns once more to his time at Auschwitz in a moving meditation on memory, resiliency, and the struggle to comprehend unimaginable tragedy. Drawing on history, philosophy, and his own personal experiences, Levi asks if we have already begun to forget about the Holocaust. His last book before his death, Levi returns to the subject that would define his reputation as a writer and a witness. Levi breaks his book into eight essays, ranging from topics like the unreliability of memory to how violence twists both the victim and the victimizer. He shares how difficult it is for him to tell his experiences with his children and friends. He also debunks the myth that most of the Germans were in the dark about the Final Solution or that Jews never attempted to escape the camps. As the Holocaust recedes into the past and fewer and fewer survivors are left to tell their stories, The Drowned and the Saved is a vital first-person testament. Along with Elie Wiesel and Hannah Arendt, Primo Levi is remembered as one of the most powerful and perceptive writers on the Holocaust and the Jewish experience during World War II. This is an essential book both for students and literary readers. Reading Primo Levi is a lesson in the resiliency of the human spirit.",
                    AuthorId = 71,
                    CategoryId = 7,
                    BookURL = "https://archive.org/details/drownedsaved0000levi",
                    ImageURL = "https://img.perlego.com/book-covers/2453188/9781788850278_300_450.webp"
                },
                new Book
                {
                    Id = 65,
                    Title = "Biography",
                    ISBN = "WISC:89094373321",
                    Pages = 532,
                    PublishedDate = new DateTime(1868, 1, 1),
                    Description = "Biography",
                    AuthorId = 72,
                    CategoryId = 7,
                    BookURL = "https://ati.dae.gov.in/ati12052021_9.pdf",
                    ImageURL = "https://marketplace.canva.com/EADaiR6K_s8/1/0/1003w/canva-white-night-sky-autobiography-book-cover-a71TNv3gBWU.jpg"
                },
                new Book
                {
                    Id = 66,
                    Title = "Red Roulette",
                    ISBN = "9781982156169",
                    Pages = 336,
                    PublishedDate = new DateTime(2022, 9, 6),
                    Description = "After the Communist Revolution, Desmond Shum's grandfather was marked as belonging to a \"black category\" that included former landlords and rich peasants--meaning the Shums would be stigmatized and impoverished. As Desmond was growing up, he vowed his life would be different. Through hard work and sheer tenacity Shum earned an American college degree and returned to China to establish himself in business. There, he met his future wife, the highly intelligent and equally ambitious Whitney Duan who was determined to make her mark within China's male-dominated society. Whitney and Desmond formed an effective team and, aided by relationships they formed with top members of the red aristocracy, vaulted into China's billionaire class. Soon they were developing the massive air cargo facility at Beijing International Airport, and they followed that feat with the creation of one of Beijing's premier hotels. They were dazzlingly successful, traveling in private jets, funding multi-million-dollar buildings and endowments, and purchasing expensive homes, vehicles, and art. But in 2017, their fates diverged irrevocably when Desmond, while residing overseas with his son, learned that his now ex-wife Whitney had vanished along with three coworkers. This is both Desmond's story and Whitney's, because she cannot tell it herself.",
                    AuthorId = 73,
                    CategoryId = 7,
                    BookURL = "https://ebook.micsapp.com/books/a54b5897bc",
                    ImageURL = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781982156176/red-roulette-9781982156176_hr.jpg"
                },
                new Book
                {
                    Id = 67,
                    Title = "My Heart is My Own",
                    ISBN = "9781841157535",
                    Pages = 612,
                    PublishedDate = new DateTime(2004, 1, 1),
                    Description = "This book is a reinterpretation of the life of Mary, Queen of Scots. John Guy returns to the archives to explode the myths and correct the inaccuracies that surround this most fascinating monarch. He also explains a central mystery: why Mary would have consented to marry - only three months after the death of her second husband, Lord Darnley - the man who was said to be his killer, the Earl of Bothwell. He also solves, through careful re-examination of the Casket Letters, the secret behind Darnley's spectacular assassination at Kirk o'Field.",
                    AuthorId = 74,
                    CategoryId = 7,
                    BookURL = "https://archive.org/details/myheartismyownli0000guyj_x8h0",
                    ImageURL = "https://cdn.penguin.co.uk/dam-assets/books/9780241963777/9780241963777-jacket-large.jpg"
                },
                new Book
                {
                    Id = 68,
                    Title = "What Are the Gospels?",
                    ISBN = "9780802809711",
                    Pages = 384,
                    PublishedDate = new DateTime(2004, 8, 9),
                    Description = "\"The publication of Richard Burridge's What Are the Gospels? in 1992 inaugurated a transformation in Gospel studies by overturning the previous consensus about Gospel uniqueness. Burridge argued convincingly for an understanding of the Gospels as biographies, a ubiquitous genre in the Graeco-Roman world. To establish this claim, Burridge compared each of the four canonical Gospels to the many extant Graeco-Roman biographies. Drawing on insights from literary theory, he demonstrated that the previously widespread view of the Gospels as unique compositions was false. Burridge went on to discuss what a properly \"biographical\" perspective might mean for Gospel interpretation, which was amply demonstrated in the revised second edition reflecting on how his view had become the new consensus. This third, twenty-fifth anniversary edition not only celebrates the continuing influence of What Are the Gospels?, but also features a major new contribution in which Burridge analyzes recent debates and scholarship about the Gospels. Burridge both answers his critics and reflects upon the new directions now being taken by those who accept the biographical approach. This new edition also features as an appendix a significant article in which he tackles the related problem of the genre of Acts. A proven book with lasting staying power, What Are the Gospels? is not only still as relevant and instructive as it was when first published, but will also doubtlessly inspire new research and scholarship in the years ahead.\"-- Provided by publisher.",
                    AuthorId = 75,
                    CategoryId = 7,
                    BookURL = "https://ia803108.us.archive.org/0/items/fourgospelstrans03camp/fourgospelstrans03camp.pdf",
                    ImageURL = "https://img.perlego.com/book-covers/1588168/9781481308762_300_450.webp"
                },
                new Book
                {
                    Id = 69,
                    Title = "The Lives of the Noble Grecians and Romaines",
                    ISBN = "UCSD:31822043010875",
                    Pages = 1214,
                    PublishedDate = new DateTime(1579, 1, 1),
                    Description = "The Lives of the Noble Grecians and Romaines",
                    AuthorId = 76,
                    CategoryId = 7,
                    BookURL = "https://archive.org/details/livesofnoblegrec00plutiala",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQPBgHZR7JwNhOrjgWbXPNs6WZY-SrFGSauew&s"
                },
                new Book
                {
                    Id = 70,
                    Title = "Plutarch's Lives Translated from the Original Greek",
                    ISBN = "UIUC:30112089235862",
                    Pages = 478,
                    PublishedDate = new DateTime(1873, 1, 1),
                    Description = "Plutarch's Lives Translated from the Original Greek",
                    AuthorId = 76,
                    CategoryId = 7,
                    BookURL = "https://archive.org/details/plutarchslivestr02plutiala",
                    ImageURL = "https://www.globalgreyebooks.com/content/book-covers/plutarch_plutarchs-lives-large.jpg"
                },
                new Book
                {
                    Id = 71,
                    Title = "Biographical Dictionary of the History of Technology",
                    ISBN = "9780415193993",
                    Pages = 1527,
                    PublishedDate = new DateTime(1998, 1, 1),
                    Description = "From ancient times to the present day, the major inventors, discoverers and entrepreneurs from around the world are profiled, and their contribution to society is explained and assessed.",
                    AuthorId = 79, // Lance Day (first author)
                    CategoryId = 8,
                    BookURL = "https://archive.org/details/isbn_9780415060424",
                    ImageURL = "https://images.routledge.com/common/jackets/crclarge/978041519/9780415193993.jpg"
                },
                new Book
                {
                    Id = 72,
                    Title = "Science for All Americans",
                    ISBN = "UOM:39015025158489",
                    Pages = 282,
                    PublishedDate = new DateTime(1990, 1, 1),
                    Description = "In order to compete in the modern world, any society today must rank education in science, mathematics, and technology as one of its highest priorities. It's a sad but true fact, however, that most Americans are not scientifically literate. International studies of educational performance reveal that U.S. students consistently rank near the bottom in science and mathematics. The latest study of the National Assessment of Educational Progress has found that despite some small gains recently, the average performance of seventeen-year-olds in 1986 remained substantially lower than it had been in 1969. As the world approaches the twenty-first century, American schools--when it comes to the advancement of scientific knowledge--seem to be stuck in the Victorian age.In Science for All Americans, F. James Rutherford and Andrew Ahlgren brilliantly tackle this devastating problem. Based on Project 2061, a scientific literacy initiative sponsored by the American Association for the Advancement of Science, this wide-ranging, important volume explores what constitutes scientific literacy in a modern society; the knowledge, skills, and attitudes all students should acquire from their total school experience from kindergarten through high school; and what steps this country must take to begin reforming its system of education in science, mathematics, and technology.Science for All Americans describes the scientifically literate person as one who knows that science, mathematics, and technology are interdependent enterprises with strengths and limitations; who understands key concepts and principles of science; who recognizes both the diversity and unity of the natural world; and who uses scientific knowledge and scientific ways of thinking for personal and social purposes. Its recommendations for educational reform downplay traditional subject categories and instead highlight the connections between them. It also emphasizes ideas and thinking skills over the memorization of specialized vocabulary. For instance, basic scientific literacy means knowing that the chief function of living cells is assembling protein molecules according to the instructions coded in DNA molecules, but does not mean necessarily knowing the terms \"ribosome\" or \"deoxyribonucleic acid.\"Science, mathematics, and technology will be at the center of the radical changes in the nature of human existence that will occur during the next life span; therefore, preparing today's children for tomorrow's world must entail a solid education in these areas. Science for All Americans will help pave the way for the necessary reforms in America's schools.",
                    AuthorId = 81,
                    CategoryId = 8,
                    BookURL = "https://archive.org/details/scienceforallame0000ruth",
                    ImageURL = "https://static.scientificamerican.com/sciam/cache/file/A3A34264-DE16-411B-B52C470B5968527B_source.jpg?w=1200"
                },
                new Book
                {
                    Id = 73,
                    Title = "Lifelong Kindergarten",
                    ISBN = "9780262037297",
                    Pages = 203,
                    PublishedDate = new DateTime(2017, 8, 25),
                    Description = "Creative learning -- Projects -- Passion -- Peers -- Play -- Creative society",
                    AuthorId = 83,
                    CategoryId = 8,
                    BookURL = "https://archive.org/details/lifelongkinderga0000resn",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTXDdonDaLNMGsKp3gZPB1iWmLayDUGADWCDA&s"
                },
                new Book
                {
                    Id = 74,
                    Title = "Critical Theory of Technology",
                    ISBN = "UOM:39015021517928",
                    Pages = 264,
                    PublishedDate = new DateTime(1991, 1, 1),
                    Description = "This pathbreaking book argues that the roots of the degradation of labor, education, and the environment lie not in technology per se but in the cultural values embodied in its design.",
                    AuthorId = 84,
                    CategoryId = 8,
                    BookURL = "https://archive.org/details/criticaltheoryof0000feen",
                    ImageURL = "https://m.media-amazon.com/images/I/31K71B64NXL._UF1000,1000_QL80_.jpg"
                },
                new Book
                {
                    Id = 75,
                    Title = "Splintering Urbanism",
                    ISBN = "9780415189644",
                    Pages = 516,
                    PublishedDate = new DateTime(2001, 1, 1),
                    Description = "This text offers an international and interdisciplinary analysis of the complex interactions between infrastructure networks and urban spaces. Drawing on case studies and examples from across the globe, it offers a statement on the urban condition.",
                    AuthorId = 85,
                    CategoryId = 8,
                    BookURL = "http://ndl.ethernet.edu.et/bitstream/123456789/25703/1/44.pdf",
                    ImageURL = "https://images.routledge.com/common/jackets/crclarge/978041518/9780415189651.jpg"
                },
                new Book
                {
                    Id = 76,
                    Title = "The Human Condition",
                    ISBN = "9780415189132",
                    Pages = 23,
                    PublishedDate = new DateTime(1958, 1, 1),
                    Description = "The Human Condition",
                    AuthorId = 87,
                    CategoryId = 8,
                    BookURL = "https://monoskop.org/images/e/e2/Arendt_Hannah_The_Human_Condition_2nd_1998.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT6y-gz8U6L28l2CB1b3ao-9jRktL019hQwvw&s"
                },
                new Book
                {
                    Id = 77,
                    Title = "Origin of Elements in the Solar System",
                    ISBN = "9780306465628",
                    Pages = 642,
                    PublishedDate = new DateTime(2000, 1, 1),
                    Description = "Based on an American Chemical Society Symposium organized by Professors Glenn Seaborg and Oliver Manuel, this volume provides a comprehensive record of different views on this important subject at the end of the 20th century. They have assembled a blend of highly respected experimentalistsand theorists from astronomy,geology,meteoritics,planetology and nuclear chemistry and physics to discuss the origin of elements in the solar system.The intent was to include all points of view and let history judge their validity.",
                    AuthorId = 88,
                    CategoryId = 8,
                    BookURL = "https://www.gresham.ac.uk/sites/default/files/2019-11-07_StephenWilkins_Elements-PP.pdf",
                    ImageURL = "https://imgv2-1-f.scribdassets.com/img/document/413150200/original/c7f42cf998/1?v=1"
                },
                new Book
                {
                    Id = 78,
                    Title = "Ullmann's Encyclopedia of Industrial Chemistry",
                    ISBN = "UCAL:B4584395",
                    Pages = 720,
                    PublishedDate = new DateTime(1991, 1, 1),
                    Description = "Ullmann's Encyclopedia of Industrial Chemistry",
                    AuthorId = 89,
                    CategoryId = 8,
                    BookURL = "https://archive.org/details/ullmannsencyclop0000unse_x4k7",
                    ImageURL = "https://m.media-amazon.com/images/I/51xa0kQZRFL.jpg"
                },
                new Book
                {
                    Id = 79,
                    Title = "The Machine in the Garden",
                    ISBN = "9780195133516",
                    Pages = 423,
                    PublishedDate = new DateTime(2000, 1, 1),
                    Description = "By examining the difference between pastoral and progressive ideals that characterised early 20th century American culture, the author shows how American thinkers have considered the relationship between technology and culture in their writings.",
                    AuthorId = 90,
                    CategoryId = 8,
                    BookURL = "https://archive.org/details/machineingardent0000marx",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTu4wT6_TQJWAnyKjsRUqaeuNYyuK-knc-yng&s"
                },
                new Book
                {
                    Id = 80,
                    Title = "Ullmann's Encyclopedia of Industrial Chemistry",
                    ISBN = "UOM:39015031845681",
                    Pages = 796,
                    PublishedDate = new DateTime(1995, 1, 1),
                    Description = "Supervised by an internationally acclaimed advisory board, the articles are written by over 3000 international experts from industry and universities, thoroughly edited to uniform style and layout in an in-house office. All figures are re-drawn to give a maximum of clarity and uniformity in style. Compared to the prior edition, almost 600f the material has either been newly written or thoroughly updated. The rest has been checked for validity and newer references have been added throughout.",
                    AuthorId = 89,
                    CategoryId = 8,
                    BookURL = "https://pdfcoffee.com/encyclopedia-of-industrial-chemistry-4-pdf-free.html",
                    ImageURL = "https://upload.wikimedia.org/wikipedia/en/e/e4/Ullmann%27s_Encyclopedia_of_Industrial_Chemistry.jpg"
                },
                new Book
                {
                    Id = 81,
                    Title = "Art as Experience",
                    ISBN = "9780399531972",
                    Pages = 385,
                    PublishedDate = new DateTime(2005, 7, 5),
                    Description = "Based on John Dewey's lectures on esthetics, delivered as the first William James Lecturer at Harvard in 1932, Art as Experience has grown to be considered internationally as the most distinguished work ever written by an American on the formal structure and characteristic effects of all the arts: architecture, sculpture, painting, music, and literature.",
                    AuthorId = 92,
                    CategoryId = 9,
                    BookURL = "https://ia902908.us.archive.org/28/items/deweyjohnartasanexperience/DEWEY%20John,%20Art%20as%20an%20Experience%22.pdf",
                    ImageURL = "https://m.media-amazon.com/images/S/compressed.photo.goodreads.com/books/1388193799i/75291.jpg"
                },
                new Book
                {
                    Id = 82,
                    Title = "The Man who Planted Trees",
                    ISBN = "NWU:35556029031994",
                    Pages = 62,
                    PublishedDate = new DateTime(1989, 1, 1),
                    Description = "Jean Giono's beautiful allegorical tale is legendary. Written in the 1950's, its message was ahead of its time, inspiring readers to rediscoverthe harmonies of the countryside and prevent its willful destruction. The narrator, journeying by foot across the barren plains of the lower Alps, has his thirst assuaged by the well water drawn by the shepherd Elzeaerd Bouffier. Here begins the subtle parable which Giono weaves of the life-giving shepherd who chooses to live alone and carry out the work of God. Over forty years the desolate hills and lifeless villages which sooppressed the traveler are transformed by the dedication of one man. All with the help of a few acorns. Giono's hope was to set in motion a worldwide reforestation program that would rejuvenate the earth. \"The Man Who Planted Trees\" is a hymn to creation and a purveyor of confidence in man's ability to change his-indeed the world's-lot. Review Citations: Ingram Advance 05/01/2005 pg. 77 (ISBN 1931498725, Hardcover)",
                    AuthorId = 93,
                    CategoryId = 9,
                    BookURL = "https://www.arvindguptatoys.com/arvindgupta/manplantedtrees.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSHCJq1wVMlYTdTu7Fxa4Q0YhgHTnhr29Ik9g&s"
                },
                new Book
                {
                    Id = 83,
                    Title = "The Handbook of Tibetan Buddhist Symbols",
                    ISBN = "9781932476033",
                    Pages = 284,
                    PublishedDate = new DateTime(2003, 1, 1),
                    Description = "Based on the author's previous publication The Encyclopedia of Tibetan Symbols and Motifs', this handbook contains an array of symbols and motifs, accompanied by succinct explanations. It provides treatment of the essential Tibetan religious figures, themes and motifs, both secular and religious. Robert Beer offers a compact, concise reference work based on his previous publication 'The Encyclopedia of Tibetan Symbols and Motifs'. This handbook contains an extensive array of symbols and motifs, accompanied by succinct explanations. It provides treatment of the most'",
                    AuthorId = 94,
                    CategoryId = 9,
                    BookURL = "https://www.shambhala.com/media/wysiwyg/9780834840003.pdf?srsltid=AfmBOoot2-XZTBP00RtDlSW08vxwAEQYt45jUSUuQq3NxAB8MlIO7Oij",
                    ImageURL = "https://images.thenile.io/r1000/9781590301005.jpg"
                },
                new Book
                {
                    Id = 84,
                    Title = "Courtly Art of the Ancient Maya",
                    ISBN = "9780500051290",
                    Pages = 304,
                    PublishedDate = new DateTime(2004, 1, 1),
                    Description = "A showcase of the breathtaking art of an ancient people features hundreds of illustrations that, combined with the latest research into and archaeological discoveries about Maya society, demonstrates the complexity and artistic genius of this legendary culture.",
                    AuthorId = 95,
                    CategoryId = 9,
                    BookURL = "https://multiverse.ssl.berkeley.edu/Portals/0/CalendarInTheSky/Resources/Lesson%20Plans/CourtlyArtAncientMaya_Curriculum.pdf",
                    ImageURL = "https://imgv2-1-f.scribdassets.com/img/document/14071925/original/d1353bceda/1?v=1"
                },
                new Book
                {
                    Id = 85,
                    Title = "Leonardo da Vinci",
                    ISBN = "9780191622601",
                    Pages = 429,
                    PublishedDate = new DateTime(2007, 10, 18),
                    Description = "This masterly account of Leonardo da Vinci and his vision of the world is now widely recognized as the classic treatment of Leonardo's art, science, and thought, giving an unparalleled insight into the broadening and deepening of Leonardo's intellect and vision throughout his artistic career. Martin Kemp, one of the world's leading authorities on Leonardo, takes us on a journey through the whole span of the great man's career. From his early training in Florence, through masterpieces such as The Last Supper and the Mona Lisa, to the work of Leonardo's last years, this book gives a fully integrated picture of his artistic, scientific, and technological achievements. Generously illustrated, and now including a new introductory chapter setting Leonardo's work in its historical context, this fully updated new edition provides an unparalleled insight into the marvellous works of this central figure in western art.",
                    AuthorId = 97,
                    CategoryId = 9,
                    BookURL = "https://ia801603.us.archive.org/13/items/leonardodavincih00heatrich/leonardodavincih00heatrich.pdf",
                    ImageURL = "https://storage.googleapis.com/media365-live.appspot.com/266c3ce1-c23a-4770-bbe7-8e37467cc81c/5a73122f-5a3b-408f-860c-2f940b2a1118/3d25cbe1-0aea-44f4-9937-a7965bae660b.jpg"
                },
                new Book
                {
                    Id = 86,
                    Title = "The Society of the Spectacle",
                    ISBN = "9798887440651",
                    Pages = 161,
                    PublishedDate = new DateTime(2024, 9, 3),
                    Description = "The Society of the Spectacle is a carefully considered effort to clarify the most fundamental tendencies and contradictions of the society in which we find ourselves—in order to facilitate its overthrow. Guy Debord was the founder of the Situationist International, the notorious avant-garde group that helped trigger the May 1968 revolt in France, which brought the entire country to a standstill for several weeks. His book The Society of the Spectacle, originally published in Paris in 1967, has been translated into more than twenty other languages and is arguably the most important radical work of the twentieth century. Ken Knabb’s meticulous new translation is the first edition in any language to include extensive annotations, clarifying the historical allusions and revealing the sources of Debord’s quotations and “détournements.” Contrary to popular misconceptions, Debord’s book is neither an ivory tower “philosophical” discourse nor a mere expression of “protest.” This makes the book more of a challenge, but it is also why it remains so pertinent more than half a century after its original publication, while countless other social theories and intellectual fads have come and gone. It has, in fact, become even more pertinent than ever, because the spectacle has become more all-pervading and glaringly obvious than ever. As Debord noted in his follow-up work, Comments on the Society of the Spectacle (1988), “spectacular domination has succeeded in raising an entire generation molded to its laws.” Debord’s book remains the best guidebook to understanding that mold and breaking it.",
                    AuthorId = 98,
                    CategoryId = 9,
                    BookURL = "https://files.libcom.org/files/The%20Society%20of%20the%20Spectacle%20Annotated%20Edition.pdf",
                    ImageURL = "https://files.libcom.org/files/images/library/The%20Society%20of%20the%20Spectacle.jpg"
                },
                new Book
                {
                    Id = 87,
                    Title = "Dead Souls",
                    ISBN = "9781387849604",
                    Pages = 266,
                    PublishedDate = new DateTime(2018, 5, 31),
                    Description = "This is the famed Gogol's unfinished novel as translated by google translate, which is to say that it's total gibberish, which, in its turn, is to say that you don't really have to read it (I didn't although I should one day because I brought it into being after all, and it might be fun) but you certainly want to have it. Think of it as a coffee table book to be casually picked up and as casually put back where it belongs.",
                    AuthorId = 99,
                    CategoryId = 9,
                    BookURL = "https://ebook-mecca.com/online/Nikolai%20Gogol%20Dead%20Souls.pdf",
                    ImageURL = "https://imgv2-1-f.scribdassets.com/img/document/544887197/original/f6fa979757/1?v=1"
                },
                new Book
                {
                    Id = 89,
                    Title = "Man and Superman",
                    ISBN = "EAN:8596547065753",
                    Pages = 241,
                    PublishedDate = new DateTime(2022, 6, 13),
                    Description = "Man and Superman, subtitled \"A Comedy and a Philosophy\", is a four-act drama written in 1903, in response to a call for Shaw to write a play based on the Don Juan theme. This book conveys the conflict between man as spiritual creator and woman as guardian of the biological continuity of the human race. It was written by George Bernard Shaw, an Irish playwright, critic, polemicist, and political activist.",
                    AuthorId = 101,
                    CategoryId = 9,
                    BookURL = "https://olli.gmu.edu/docstore/400docs/1101-403-Man-superman%20psu.pdf",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQtKlPZuYsF1QTJ4Sidh6J-vgfpLtEMx3P1dw&s"
                },
                new Book
                {
                    Id = 90,
                    Title = "Art Under Control in North Korea",
                    ISBN = "9781861892362",
                    Pages = 196,
                    PublishedDate = new DateTime(2005, 8, 15),
                    Description = "\"Art Under Control in North Korea is the first publication in the West to explore the role of art in one of the world'smost isolated nations.This timely publication places North Korean art in its historical,political and social contexts, discusses the state system of producing,employing, promoting and honouring artists,and examines the range of art produced,from painting and calligraphy to architecture and applied art.Jane Portal also compares the control exerted over artists by North Korean leaders to that of other absolute dictatorships,and looks at the way in which archaeology has been employed for political ends to justify the present leadership and its lineage.\"--BOOK JACKET.",
                    AuthorId = 102,
                    CategoryId = 9,
                    BookURL = "https://archive.org/details/artundercontroli0000port",
                    ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQJlOlS_kfSDfGud9SpzFvUJEIya1EVtxfohw&s"
                },
                 new Book
                 {
                     Id = 91,
                     Title = "Lonely Planet Georgia, Armenia & Azerbaijan",
                     ISBN = "9781838696467",
                     Pages = 579,
                     PublishedDate = new DateTime(2022, 7, 1),
                     Description = "Lonely Planet’s Georgia, Armenia & Azerbaijan is your passport to the most relevant, up-to-date advice on what to see and skip, and what hidden discoveries await you. Hike in Tusheti, explore Goris, and discover Baku; all with your trusted travel companion. Get to the heart of Georgia, Armenia & Azerbaijan and begin your journey now! Inside Lonely Planet’s Georgia, Armenia & Azerbaijan Travel Guide: Up-to-date information - all businesses were rechecked before publication to ensure they are still open after 2020’s COVID-19 outbreak NEW top experiences feature - a visually inspiring collection of Georgia, Armenia & Azerbaijan’s best experiences and where to have them What's NEW feature taps into cultural trends and helps you find fresh ideas and cool new areas NEW pull-out, passport-size 'Just Landed' card with wi-fi, ATM and transport info - all you need for a smooth journey from airport to hotel Colour maps and images throughout Highlights and itineraries help you tailor your trip to your personal needs and interests Insider tips to save time and money and get around like a local, avoiding crowds and trouble spots Essential info at your fingertips - hours of operation, websites, transit tips, prices Honest reviews for all budgets - eating, sleeping, sightseeing, going out, shopping, hidden gems that most guidebooks miss Cultural insights give you a richer, more rewarding travel experience - history, people, music, landscapes, wildlife, cuisine, politics Over 65 maps Covers Georgia, Armenia, Azerbaijan The Perfect Choice: Lonely Planet’s Georgia, Armenia & Azerbaijan, our most comprehensive guide to Georgia, Armenia & Azerbaijan, is perfect for both exploring top sights and taking roads less travelled. About Lonely Planet: Lonely Planet is a leading travel media company, providing both inspiring and trustworthy information for every kind of traveller since 1973. Over the past four decades, we've printed over 145 million guidebooks and phrasebooks for 120 languages, and grown a dedicated, passionate global community of travellers. You'll also find our content online, and in mobile apps, videos, 14 languages, armchair and lifestyle books, ebooks, and more, enabling you to explore every day. 'Lonely Planet guides are, quite simply, like no other.' – New York Times 'Lonely Planet. It's on everyone's bookshelves; it's in every traveller's hands. It's on mobile phones. It's on the Internet. It's everywhere, and it's telling entire generations of people how to travel the world.' – Fairfax Media (Australia)",
                     AuthorId = 103,
                     CategoryId = 10,
                     BookURL = "https://dspace.nplg.gov.ge/bitstream/1234/322530/1/Georgia_Armenia_I_Azerbaijan.pdf",
                     ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSNUuCWHjW9A1S4zxpkVxpPvmRHGxD5cjpfIg&s"
                 },
                 new Book
                 {
                     Id = 92,
                     Title = "The Museum of Innocence",
                     ISBN = "9780571268412",
                     Pages = 756,
                     PublishedDate = new DateTime(2011, 8, 5),
                     Description = "The Museum of Innocence - set in Istanbul between 1975 and today - tells the story of Kemal, the son of one of Istanbul's richest families, and of his obsessive love for a poor and distant relation, the beautiful Fusun, who is a shop-girl in a small boutique. In his romantic pursuit of Füsun over the next eight years, Kemal compulsively amasses a collection of objects that chronicles his lovelorn progress-a museum that is both a map of a society and of his heart. The novel depicts a panoramic view of life in Istanbul as it chronicles this long, obsessive love affair; and Pamuk beautifully captures the identity crisis experienced by Istanbul's upper classes that find themselves caught between traditional and westernised ways of being. Orhan Pamuk's first novel since winning the Nobel Prize is a stirring love story and exploration of the nature of romance. Pamuk built The Museum of Innocence in the house in which his hero's fictional family lived, to display Kemal's strange collection of objects associated with Fusun and their relationship. The house opened to the public in 2012 in the Beyoglu district of Istanbul. 'Pamuk has created a work concerning romantic love worthy to stand in the company of Lolita, Madame Bovary and Anna Karenina.' --Financial Times",
                     AuthorId = 104,
                     CategoryId = 10,
                     BookURL = "https://archive.org/details/museumofinnocenc00pamu_0",
                     ImageURL = "https://archive.org/services/img/museumofinnocenc00pamu_0/full/pct:200/0/default.jpg"
                 },
                 new Book
                 {
                     Id = 93,
                     Title = "Lord Jim",
                     ISBN = "9788831815727",
                     Pages = 387,
                     PublishedDate = new DateTime(2024, 6, 25),
                     Description = "Caduto in disgrazia a causa di un incidente in cui la paura ha preso il sopravvento, e per cui ha perduto il brevetto di ufficiale, Jim trascorre la propria esistenza spostandosi sempre più verso l'Estremo Oriente nel tentativo di sfuggire al proprio nome, finché in uno sperduto angolo del Borneo non riesce a riscattarsi, riassumendo il ruolo di eroe che aveva sempre sognato. Narrata dalla voce di Marlow, capitano di lungo corso che tenta di aiutare il giovane, la storia di Jim tratteggia uno dei personaggi più complessi della letteratura, in cui le vicende personali e le ambientazioni esotiche diventano rappresentazione dell'incertezza esistenziale e dell'impossibilità di conoscere l'animo umano e la realtà del mondo. Un romanzo costruito come un mosaico di punti di vista che ruotano intorno al medesimo evento, proposto qui in nuova traduzione e curatela di Rocco Coronato, professore di Letteratura inglese presso l'Università di Padova.",
                     AuthorId = 105,
                     CategoryId = 10,
                     BookURL = "https://dn721704.ca.archive.org/0/items/lordjimtale00conrrich/lordjimtale00conrrich.pdf",
                     ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRSDCNHjDxwYLddg8OcxgdwSY6f4vs8mFzwGQ&s"
                 },
                 new Book
                 {
                     Id = 94,
                     Title = "Zeus",
                     ISBN = "9781582345185",
                     Pages = 340,
                     PublishedDate = new DateTime(2008, 2, 5),
                     Description = "Traces the four-thousand-year history of the charismatic father of the Greek gods, from his origins in the Russian steppes and reign on Mount Olympus to his approaching end in Christian Constantinople, in an account that follows the author's journeys to relevant sites in Greek mythology.",
                     AuthorId = 106,
                     CategoryId = 10,
                     BookURL = "https://www.moonshiners.org.uk/MZ/zeus.pdf",
                     ImageURL = "https://assets.isu.pub/document-structure/241031180940-61a70be0017371569659054b3760945b/v1/abd52574d2850256bdcbf1543dd3c2b7.jpeg"
                 },
                 new Book
                 {
                     Id = 95,
                     Title = "Germany",
                     ISBN = "9780788181795",
                     Pages = 720,
                     PublishedDate = new DateTime(1999, 8, 1),
                     Description = "Reviews Germany's history, and treats in a concise and objective manner its dominant social, political, economic, and military aspects. Sections, written by experts, include: chronology of important events; early history to 1945; history 1945-1990; the society and its environment; social welfare, health care, and educ.; the domestic economy; international economic relations; government and politics; foreign relations; national security; military tradition; strategic concerns and military missions; the armed forces; defense budget; and such military issues as uniforms, ranks, and insignia, defense production and export, foreign military relations, and internal security.",
                     AuthorId = 107,
                     CategoryId = 10,
                     BookURL = "https://theswissbay.ch/pdf/Books/Linguistics/Mega%20linguistics%20pack/Indo-European/Germanic/German%2C%20Teach%20Yourself%20%28Adams%2C%20Wells%20%26%20Jenkins%29.pdf",
                     ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQdQUZdjqQuWk2AGTQqMDXpWz0nds_QWN4q-A&s"
                 },
                 new Book
                 {
                     Id = 96,
                     Title = "Eat, Pray, Love",
                     ISBN = "9780747585664",
                     Pages = 386,
                     PublishedDate = new DateTime(2007, 3, 5),
                     Description = "The Number One international bestseller, Eat, Pray Love is a journey around the world, a quest for spiritual enlightenment and a story for anyone who has battled with divorce, depression and heartbreak.",
                     AuthorId = 108,
                     CategoryId = 10,
                     BookURL = "https://institutes.abu.edu.ng/idr/public/assets/docs/Eat,%20Pray,%20Love%20(%20PDFDrive%20).pdf",
                     ImageURL = "https://online.fliphtml5.com/gutjj/zwbj/files/large/1.webp?1604750286&1604750286"
                 },
                 new Book
                 {
                     Id = 97,
                     Title = "Ecology of Java & Bali",
                     ISBN = "9789625930725",
                     Pages = 1040,
                     PublishedDate = new DateTime(1996, 1, 1),
                     Description = "Java and Bali are the best known of all the islands in Indonesia, and nowhere else in the country are ecological issues so acute. This book provides invaluable ecological data, so that development activities can be viewed in light of their ecological and social impacts.These eagerly-awaited volumes are the result of four years of research into the status of Indonesian coastal and marine ecosystems. They chart the extraordinary treasure trove of the areas marine biodiversity, and discuss the problems that have resulted from current population pressures and economic development.",
                     AuthorId = 109,
                     CategoryId = 10,
                     BookURL = "https://www.scribd.com/document/892886564/The-Ecology-of-Java-and-Bali-Whitten-instant-download",
                     ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStBIY-qHyoYmT5xTLTRQnxDrhbc_5Ym5CDjw&s"
                 },
                 new Book
                 {
                     Id = 98,
                     Title = "Architectural Guidebook to New York City",
                     ISBN = "9781423611165",
                     Pages = 440,
                     PublishedDate = new DateTime(2009, 9, 1),
                     Description = "$21.95 paperback 1-58685-113-6 August6 x 8/ in, 432 pp, Black & White Photographs, Rights: W, ArchitecturevFrancis Morrone has returned to the buildings of his original guidebook once again to detail additions and changes in name and usage, and the book has been modified to reflect post September 11th New York City. With its thoughtful detail and out-of-the-ordinary observations, this guidebook is a must-have for New Yorkers, tourists, and architectural lovers everywhere.Francis Morrone is a lecturer and tour leader for the Municipal Art Society of New York, a nonprofit civic organization founded in 1893. His writings on architecture and New York history appear in The New Criterion, the City Journal, and other publications. His other books include An Architectural Guidebook to Brooklyn and An Architectural Guidebook to Philadelphia. He lives in Brooklyn.James Iska, whose work has been exhibited all over the world and has appeared in the Washington Post, the Financial Times, the Chicago Sun-Times, and the Chicago Tribune, is currently on the staff of the Art Institute of Chicago.",
                     AuthorId = 112,
                     CategoryId = 10,
                     BookURL = "https://archive.org/details/aiaguidetonewyor0000unse_j8m6",
                     ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5ZqQcG7_pKTdOaXQspMyO7-fKrxoNidRpyw&s"
                 },
                 new Book
                 {
                     Id = 99,
                     Title = "Sustainable Tourism in Protected Areas",
                     ISBN = "9782831706481",
                     Pages = 191,
                     PublishedDate = new DateTime(2002, 1, 1),
                     Description = "This report tells how to ensure that tourism follows a sustainable path and that it contributes to the sustainable management of protected areas. Guidelines are presented to help readers understand protected area tourism and its management, and practical suggestions are based on theory and practice from around the world. Coverage includes biodiversity and conservation, planning for protected area tourism, culturally sensitive design and operation, visitor management, and human resources. There is no subject index. Eagles teaches at the University of Waterloo, Canada. Annotation copyrighted by Book News, Inc., Portland, OR.",
                     AuthorId = 113,
                     CategoryId = 10,
                     BookURL = "https://www.europarc.org/wp-content/uploads/2015/05/2012_Parks_and_Benefits_Guide_to_sustainable_tourism_in_Protected_Areas.pdf",
                     ImageURL = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQuN00TpctnWSLzvYdA_2rk8RxHDn9MM2hUwA&s"
                 });
        }
    }
}
