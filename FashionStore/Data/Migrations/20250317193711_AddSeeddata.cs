using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FashionStore.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeeddata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1377,
                column: "ImageUrl",
                value: "/images/62_TEKCOOL.jpg");

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductID", "CategoryID", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1037, 3, "Regular Fit Printed Blue Sweatshirt for Men", "/images/sw_Mack JONNEY.jpg", "Mack JONNEY", 45m },
                    { 1038, 3, "Sweat Shirt Men's Jacket For Men Winter Wear Standard Length Thermal Insulation Sweatshirt", "/images/sw_Boldfit.jpg", "Boldfit", 48m },
                    { 1039, 3, "Cotton Design Printed Hooded Hoodies/Sweatshirts for Men & Women", "/images/sw_ADRO  .jpg", "ADRO ", 51m },
                    { 1040, 3, "Men Sweatshirts || Sweatshirts for Men || Unisex Sweatshirts ||Hoodie for Men || Unisex Hoodie || Hoodie", "/images/sw_JVX.jpg", "JVX", 56m },
                    { 1041, 3, "Solid Regular Fit Plain Casual Stylish Latest | Full Sleeve T Shirt for Men", "/images/sw_GRECIILOOKS .jpg", "GRECIILOOKS ", 102m },
                    { 1042, 3, "Men's Cotton Hooded Sweatshirt", "/images/sw_Alan Jones.jpg", "Alan Jones", 27m },
                    { 1043, 3, "Solid Round Neck Cotton Fleece Sweatshirt for Men", "/images/sw_Mack Jonney_1.jpg", "Mack Jonney", 28m },
                    { 1044, 3, "Half Zipper Solid Sweatshirt for Men (Pack of 2)", "/images/sw_Trillion.jpg", "Trillion", 98m },
                    { 1045, 3, "Clothing Men's Cotton Hooded Sweatshirt", "/images/sw_Alan Jones_1.jpg", "Alan Jones", 68m },
                    { 1046, 3, "Men's Full Sleeve Printed Sweatshirt for Men", "/images/sw_Trillion.jpg", "Trillion", 55m },
                    { 1047, 3, "Clothing Men's Fleece Hooded Hoodie", "/images/sw_Alan Jones_2.jpg", "Alan Jones", 14m },
                    { 1048, 3, "Trendy Front & Back Printed Fullsleeve Hooded Sweatshirt for Men", "/images/sw_BULLMER.jpg", "BULLMER", 59m },
                    { 1049, 4, "Men Denim Full Sleeve Regular Winter Jacket", "/images/J_KOTTY.jpg", "KOTTY", 68m },
                    { 1050, 4, "acket For Men Winter Wear Nylon Winter Standard Length Jacket For Men Minus Degree Jackets From Minus 10 Degree Winter Wear For Men Insulated Winter Jackets For Men Heavy Jackets", "/images/J_Boldfit.jpg", "Boldfit", 54m },
                    { 1051, 4, "Jacket for Men Quilted Hooded Winter Jackets for Men & Boys Full Sleeve Mens Jacket Monsoon Jackets for Men All Weather Jacket for Men Wear Bomber Jacket for Men, Jerkin for Men", "/images/J_Boldfit_1.jpg", "Boldfit", 21m },
                    { 1052, 4, "Men Polyester Jackets || Bomber Jacket For Men || Lightweight Outwear Sportswear Bomber Standard Length Jacket", "/images/J_Lymio.jpg", "Lymio", 47m },
                    { 1053, 4, "Men's Jacket", "/images/J_VOXATI.jpg", "VOXATI", 57m },
                    { 1054, 4, "For Men's Loopknit Full Sleeve Regular Fit Solid Bomber Jacket (Color Black)", "/images/J_LEOTUDE.jpg", "LEOTUDE CASUAL JACKET", 77m },
                    { 1055, 4, "Men's Black Faux Leather Jacket with Zipper, Multiple Pockets, and Removable Hood Design", "/images/J_Blaq Ash.jpg", "Blaq Ash", 112m },
                    { 1056, 5, "Casual, Formal, Party, Festive and Wedding Blazer, Single Breasted", "/images/M_B_HUMJOLI.jpg", "HUMJOLI", 54m },
                    { 1057, 5, "Men's Poly Viscose V-Shape Tuxedo Style Waistcoat", "/images/M_B_OORA.jpg", "OORA", 29m },
                    { 1058, 5, "Men's Slim Fit Single Breasted Blazer", "/images/M_B_MANQ.jpg", "MANQ", 63m },
                    { 1059, 5, "Tweed Blazer for Men - Formal & Casual Winter Wear Blazer", "/images/M_B_TAHVO.jpg", "TAHVO", 98m },
                    { 1060, 5, "Men’s Regular Fit Formal Blazer (Blue)", "/images/M_B_RISANI.jpg", "RISANI", 55m },
                    { 1061, 5, "Casual, Formal, Party, Festive and Wedding Blazer, Single Breasted", "/images/M_B_HUMJOLI_1.jpg", "HUMJOLI", 57m },
                    { 1062, 5, "Men Regular Fit Blazer", "/images/M_B_WINTAGE.jpg", "WINTAGE", 14m },
                    { 1063, 5, "Grey Bandgala Blazer with Hanky", "/images/M_B_TAHVO_1.jpg", "TAHVO", 25m },
                    { 1064, 5, "Men's Regular Blazer", "/images/M_B_Peter England.jpg", "Peter England", 95m },
                    { 1065, 5, "Men's Regular Fit Blazer", "/images/M_B_Van Heusen.jpg", "Van Heusen", 96m },
                    { 1066, 5, "Law Firm Men's Blazer Black Coat Latest Stylish Perfect Single Breasted Regular Fit Advocate Blazer for Casual Formal Office Wear", "/images/M_B_Gwalior.jpg", "Gwalior", 82m },
                    { 1067, 5, "Blazer for Men ", "/images/M_B_Luxrio.jpg", "Luxrio", 54m },
                    { 1068, 6, "Men's Casual Stretchable Denim Tapered Fit Carrot Jeans", "/images/M_Je_Ben Martin.jpg", "Ben Martin", 36m },
                    { 1069, 6, "Men's Slim Fit Washed Jeans Stretchable", "/images/M_Je_Urbano Fashion.jpg", "Urbano Fashion", 112m },
                    { 1070, 6, "Comfort Denim Jeans for Men Stretchable Jeans Pant Cotton Rich Jeans Casual Jeans Anti Odor | Anti Stain | Breathable", "/images/M_Je_PSS FASHION.jpg", "PSS FASHION'S", 94m },
                    { 1071, 6, "Men's 512 Slim Tapered Fit Mid Rise Jeans", "/images/M_Je_Levis.jpg", "Levi's ", 82m },
                    { 1072, 6, "Men's Classic Tapered Stretchable Twill Jeans", "/images/M_Je_Peter England.jpg", "Peter England", 87m },
                    { 1073, 6, "Men Jeans || Jeans for Men || Men Jeans Pants || Jeans Pant for Man", "/images/M_Je_QNIM.jpg", "QNIM", 57m },
                    { 1074, 6, "Men's Loose Jeans || Men's Jeans Pants || Denim Jeans || Baggy Jeans for Men ", "/images/M_Je_Lymio.jpg", "Lymio", 19m },
                    { 1075, 6, "Men Jeans || Relaxed Pants || Denim Baggy Jeans", "/images/M_Je_London Hills.jpg", "London Hills", 75m },
                    { 1076, 6, "Men's Slim Fit Jeans", "/images/M_Je_Sf Jeans By Pantaloons.jpg", "Sf Jeans By Pantaloons", 28m },
                    { 1077, 6, "Men Solid Stretchable Blue Tapered Slim Fit Light Fade Midrise Jeans", "/images/M_Je_Everblue.jpg", "Everblue", 65m },
                    { 1078, 6, "Men Loose Fit Men's Flip Pocket Cargo || Men's Stylish Cotton Loose Fit Denim Cargo Jeans || Multi-Pocket Styling || Perfect for Casual Fashion || Comfortable Classic Men's Outerwear ", "/images/M_Je_TAGAS.jpg", "TAGAS", 39m },
                    { 1079, 6, "Men's Relaxed Jeans", "/images/M_Je_Lee.jpg", "Lee", 76m },
                    { 1080, 7, "Casual Regular Fit Trouser For Men", "/images/7_ENDEAVOUR.jpg", "ENDEAVOUR", 102m },
                    { 1081, 7, "Men's Solid Lycra Slim Fit Stretchable Casual Wear Comfortable Formal Trousers Pants Model 25.5 PantLycra COMBO3", "/images/7_Generic.jpg", "Generic", 19m },
                    { 1082, 7, "Men's Cargo Pants | Corduroy Trousers for Men Loose Fit | Cargos for Men | Men Cargo Trouser", "/images/7_Vogaan.jpg", "Vogaan", 48m },
                    { 1083, 7, "Men's Premium Polycotton Causal Baggy Fit Jogger || Lightweight & Flexible Elastic Waist with Drawstring || Wrinkle-Free Comfortable Trouser Pant for Summer", "/images/7_SMOWKLY.jpg", "SMOWKLY", 48m },
                    { 1084, 7, "Men's Regular Fit Dress Trousers, Formal Business Pants, Straight Leg", "/images/7_AXOLOTL.jpg", "AXOLOTL", 46m },
                    { 1085, 7, "Men's Slim Fit Formal Trousers with Mid-Rise Waist and Lycra Blend | Solid Pattern and Button Closure | Ideal for Office, Business, and Everyday Wear", "/images/7_BLACK SAND.jpg", "BLACK SAND", 67m },
                    { 1086, 7, "Men Cargo || Men Cargo Pants || Men Cargo Pants Cotton || Cargos for Men", "/images/7_Louis Philippe.jpg", "Louis Philippe", 45m },
                    { 1087, 7, "Slim Fit Solid Superior Comfort with Extra Stretch Trouser", "/images/7_Louis Philippe.jpg", "Louis Philippe", 48m },
                    { 1088, 7, "Cargo for Men | Men Cargo Pants | Men Cargo Pants Cotton | Men Cargo | Trousers for Men | Baggy Cargo Pants for Men | Cargos for Men", "/images/7_GRECIILOOKS.jpg", "GRECIILOOKS", 51m },
                    { 1089, 7, "Men's Formal Trousers || Slim Fit Men's Wear Trousers || Stretchable Formal Pant Trousers || Trouser for Men", "/images/7_TOPLOT.jpg", "TOPLOT", 56m },
                    { 1090, 7, "Men Cargo || Men Cargo Pants || Men Cargo Pants Cotton || Cargos for Men", "/images/7_Lymio.jpg", "Lymio", 102m },
                    { 1091, 8, "Shorts for Men Gym Half Pants for Men & Boys Training Mens Shorts Quick Dry Men Shorts for Workout & Home Wear Lightweight Gym Shorts for Men Gym Wear for Men Sports Shorts for Men", "/images/8_Boldfit.jpg", "Boldfit", 27m },
                    { 1092, 8, "Men's Super Combed Cotton Rich Regular Fit Solid Shorts with Side Pockets", "/images/8_Jockey.jpg", "Jockey", 28m },
                    { 1093, 8, "Men's Cotton Shorts | Shorts for Mens | Mens Shorts", "/images/8_DOBAD.jpg", "DOBAD", 48m },
                    { 1094, 8, "Men Shorts || Men Shorts Cotton || Men Shorts Casual", "/images/8_Lymio.jpg", "Lymio", 68m },
                    { 1095, 8, "Men's Solid Cotton Shorts ", "/images/8_TAGDO.jpg", "TAGDO", 55m },
                    { 1096, 8, "Men's Cotton Boxer Shorts Regular Fit Solid Shorts", "/images/8_Pepe Jeans.jpg", "Pepe Jeans", 14m },
                    { 1097, 8, "Men's Regular Fit Shorts with Pocket Multicolor", "/images/8_0-DEGREE.jpg", "0-DEGREE", 59m },
                    { 1098, 8, "Men Casual Shorts", "/images/8_U.S. POLO ASSN.jpg", "U.S. POLO ASSN", 68m },
                    { 1099, 9, "Men's Oversized Cargo Utility Joggers", "/images/9_NOBERO.jpg", "NOBERO", 54m },
                    { 1100, 9, "Men's Track Pant with Lycra Elastic Jogger Suitable for Active Wear | Jogger Yoga Wear, Sports", "/images/9_U GENIUS SPORTS.jpg", "U GENIUS SPORTS", 21m },
                    { 1101, 9, "Men Slim Fit Joggers for Men for Running, Gym Sports Lower for Men & Boys Summer Track Pants for Men", "/images/9_Boldfit.jpg", "Boldfit", 47m },
                    { 1102, 9, "Men Joggers ||Track Pant for Men || Men Joggers || Printed Joggers", "/images/9_Lymio.jpg", "Lymio", 57m },
                    { 1103, 9, "Men Regular Fit Track Pants", "/images/9_U.S. POLO ASSN.jpg", "U.S. POLO ASSN", 77m },
                    { 1104, 9, "Men's Track Pant with Lycra Elastic Jogger Suitable for Active Wear", "/images/9_Mehrang.jpg", "Mehrang", 112m },
                    { 1105, 10, "Mens 3392 Causal Shoes | Loafers | Moccasins | Lighweight Slip-On's | Soft Cushioned Insole | Trendy Non Lace-up Deisgn", "/images/10_Centrino.jpg", "Centrino", 54m },
                    { 1106, 10, "Mens I-and Laceup Casual Shoes", "/images/10_Bata.jpg", "Bata", 29m },
                    { 1107, 10, "Mens 3392 Causal Shoes | Loafers | Moccasins | Lighweight Slip-On's | Soft Cushioned Insole | Trendy Non Lace-up Deisgn | Stylish & Comfortable", "/images/10_Centrino_1.jpg", "Centrino", 63m },
                    { 1108, 10, "Men's Leather Casual Shoes", "/images/10_Woodland.jpg", "Woodland", 98m },
                    { 1109, 11, "Mens Stride Runner Running", "/images/11_Reebok.jpg", "Reebok", 55m },
                    { 1110, 11, "Mens Dazzler Sneaker", "/images/11_Puma.jpg", "Puma", 57m },
                    { 1111, 11, "Men Sport Shoes | Running Shoes | Casual Walking Shoes | Sneakers", "/images/11_BRUTON.jpg", "BRUTON", 14m },
                    { 1112, 11, "Mens Indus-251 Running Shoe", "/images/11_LANCER.jpg", "LANCER", 25m },
                    { 1113, 12, "Men's SFG 549 Flip-Flop", "/images/12_SPARX.jpg", "SPARX", 95m },
                    { 1114, 12, "Unisex Slide Max Slide", "/images/12_Puma.jpg", "Puma", 96m },
                    { 1115, 12, "Men's Rafa Sandal", "/images/12_U.S. POLO ASSN.jpg", "U.S. POLO ASSN", 82m },
                    { 1116, 12, "Men's Slip-On Slide Sandal", "/images/12_Woodland .jpg", "Woodland ", 54m },
                    { 1117, 13, "Bamboo Socks for Men | Ankle Length | Odour-Free & Breathable | Padded Base & Anti-bacterial | 3X Softer than Cotton Socks", "/images/13_HEELIUM.jpg", "HEELIUM", 36m },
                    { 1118, 13, "12 Pairs Solid Cotton Ankle Length Socks for Men & Women, Multicolor, Pack of 12, Free Size", "/images/13_SJeware.jpg", "SJeware", 112m },
                    { 1119, 13, "Men's Cotton Full Length Socks Free Size - Pack of 3", "/images/13_Peter England.jpg", "Peter England", 94m },
                    { 1120, 13, "Mens Cotton Ankle Length Socks (Pack of 3) Dark Grey, Navy, Black", "/images/13_Peter England_1.jpg", "Peter England", 82m },
                    { 1121, 14, "430 w/ 40mm Drivers, Beast Mode w/ 40ms Latency, 40hrs Playback, ENx Tech, Voice Assistant, BTv5.4, Adaptive Fit & Easy Access Controls, Bluetooth Over Ear Headphones(Black Sabre)", "/images/14_boAt Rockerz.jpg", "boAt Rockerz", 87m },
                    { 1122, 14, "Wireless Bluetooth Headphones with Mic, Up to 50Hrs Battery-Blue", "/images/14_Sony WH-CH520.jpg", "Sony WH-CH520", 57m },
                    { 1123, 14, "(1 Year Warranty Headset Bluetooth V5.0 with Mic and Noice Cancellation Feature | for Gym, Sports, Travelling and Driving Compatible with All Bluetooth Enabled Devices", "/images/14_Drumstone.jpg", "Drumstone", 19m },
                    { 1124, 14, "Active Noise Cancellation(~32dB), 120Hrs Battery, App Support, Crystal Bionic Sound, 4Mics ENx, v5.3 Bluetooth TWS in Ear Earbuds Wireless Earphones with mic (Crystal Black)", "/images/14_boAt Nirvana Ion ANC.jpg", "boAt Nirvana Ion ANC", 75m },
                    { 1125, 15, "Square 100% UV protected Sunglasses for Unisex", "/images/15_Fastrack.jpg", "Fastrack", 28m },
                    { 1126, 15, "3 Pack Polarized Sunglasses for Men Lightweight Sun Glasses with UV Protection for Driving Fishing Golf", "/images/15_Rocf Rossini.jpg", "Rocf Rossini", 65m },
                    { 1127, 15, "Unbreakable TR90 Polarized SPORTS SUNGLASSES - Chopper HD Clear Vision Motorcycle Riding Running Biking (Black)", "/images/15_ELEGANTE.jpg", "ELEGANTE", 39m },
                    { 1128, 15, "Unisex Combo offer pack of 4 shades glasses White Black Candy MC stan Rectangular Retro Vintage Narrow Non-Polarized Sunglasses Small Narrow Square Sun Glasses Combo offer pack (Medium)", "/images/15_Sheomy.jpg", "Sheomy", 76m },
                    { 1129, 16, "Women Cotton Tiered Printed Maxi Dress", "/images/16_BIBA.jpg", "BIBA", 102m },
                    { 1130, 16, "Floral Printed Smocked Tiered Dress | Maxi Dress with Square Neck", "/images/16_DRAPE AND DAZZLE.jpg", "DRAPE AND DAZZLE", 19m },
                    { 1131, 16, "Women's Rayon Viscose Anarkali Printed Kurta with Palazzo & Dupatta", "/images/16_GoSriKi.jpg", "GoSriKi", 48m },
                    { 1132, 16, "Dress for Women Printed Midi Dress with V-Neck, Puffed Sleeves", "/images/16_flowervelly.jpg", "flowervelly", 48m },
                    { 1133, 16, "Rayon Fit and Flare Below The Knee One Piece Dresses for Women | Dress", "/images/16_GRECIILOOKS.jpg", "GRECIILOOKS", 46m },
                    { 1134, 16, "Women Knee Length Dress", "/images/16_Max.jpg", "Max", 67m },
                    { 1135, 16, "Fashion Dress | Knee Length | Half Sleeve | Summer Dress | Casual Wear Dress for Women", "/images/16_Leriya.jpg", "Leriya", 78m },
                    { 1136, 16, "Women's Floral Printed Cotton Flared Maxi Dress (Drspinkkinnu_Baby Pink)", "/images/16_Stylum.jpg", "Stylum", 102m },
                    { 1137, 16, "Women coords Set | Women Cord Sets Stylish Short | 2 Piece Set for Women | Women Cord Sets Stylish Western | Cord Set for Women | Women Cord Sets", "/images/16_London Hills.jpg", "London Hills", 45m },
                    { 1138, 16, "Solid Halter Neck Solid Bodycon Midi Dress for Women's & Girl's", "/images/16_Aahwan.jpg", "Aahwan", 102m },
                    { 1139, 16, "Women Fancy Plain & Solid Designer Dress for Women", "/images/16_AASK.jpg", "AASK", 12m },
                    { 1140, 16, "Women's Polyester Shift Mini Dress", "/images/16_VERO MODA.jpg", "VERO MODA", 36m },
                    { 1141, 16, "Vertical Striped Pattern | Short-Sleeve | Casual Wear | Dress with Tie | Summer Dress for Women", "/images/16_Leriya Fashion.jpg", "Leriya Fashion", 65m },
                    { 1142, 16, "Dress for Woman - Short Dress & Long Dress Latest Stylish Unique Border Design and Tassel Stretchable with Adjustable Drawstring fit and Flare", "/images/16_KE KANHA EXPORTS.jpg", "KE KANHA EXPORTS", 59m },
                    { 1143, 16, "TASHVIKA'S Women's Skater Knee Length Dress", "/images/16_TASHVIKA.jpg", "TASHVIKA", 74m },
                    { 1144, 16, "Women's Lyocell Casual Solid Full Sleeve Collared Top and Pant Set with Blazer | Western Set for Women", "/images/16_House of Jangid.jpg", "House of Jangid", 54m },
                    { 1145, 16, "Solid Striped Backless Side Slit Dress Backless Dress for Women's & Girl's", "/images/16_Aahwan_1.jpg", "Aahwan", 86m },
                    { 1146, 16, "Dresses for Women|One Piece Dress for Women|Western Dress for Women", "/images/16_TOPLOT.jpg", "TOPLOT", 23m },
                    { 1147, 17, "Women's Casual Printed Round Neck, Oversized Longline Drop Shoulder Boho Style T-Shirt", "/images/17_TQH.jpg", "TQH", 67m },
                    { 1148, 17, "Women's Cotton Blend Full Sleeves Round Neck Printed T-Shirt | Combo of 2 Stylish & Comfortable Tees | Soft & Breathable Fabric | Casual Purple&Pink", "/images/17_LEEBURG.jpg", "LEEBURG", 45m },
                    { 1149, 17, "Training T Shirt for Women Cropped Tshirt for Women Relax Fit T Shirts for Women for Active Wear, Workout Quick Dry Gym Wear for Women Running Regular Fit T-Shirts for Women Short T Shirt", "/images/17_Boldfit.jpg", "Boldfit", 44m },
                    { 1150, 17, "Women's Print Oversized T-Shirt | Cotton Blend | Casual Loose Fit | S-XL | Trendy Graphic Tee", "/images/17_KOTTY.jpg", "KOTTY", 55m },
                    { 1151, 17, "Oversized Cottonblend Half Sleeve Round Neck Longline Drop Shoulder, Colorful Printed T-Shirt Women's Combo T-Shirts (Pack of 3)", "/images/17_LEOTUDE.jpg", "LEOTUDE", 66m },
                    { 1152, 17, "Women's Regular Fit T-Shirt", "/images/17_Max.jpg", "Max", 77m },
                    { 1153, 17, "Fashion Women Tops | Tops for Women | Regular Fit Tops for Jeans for Women | Korean Tops for Women | Trendy Tops for Women | Western Tops for Women Stylish", "/images/17_Leriya.jpg", "Leriya", 88m },
                    { 1154, 17, "Women Regular Fit Tops | Tops for Women | Tops for Jeans for Women | Korean Tops for Women | Tops for Women | Western Tops for Women Stylish", "/images/17_GRECIILOOKS.jpg", "GRECIILOOKS", 99m },
                    { 1155, 17, "Women Printed Round Neck Oversized T-Shirt | Loose Fit Drop Shoulder T-Shirt Pack of 3", "/images/17_London Hills.jpg", "London Hills", 25m },
                    { 1156, 18, "Fashion Waffle Women's Cotton Solid Half Sleeve Round Neck T-Shirt", "/images/18_Urvi.jpg", "Urvi", 63m },
                    { 1157, 18, "Women Regular Fit Tops | Tops for Women | Tops for Jeans for Women | Korean Tops for Women | Tops for Women | Western Tops for Women Stylish", "/images/18_GRECIILOOKS.jpg", "GRECIILOOKS", 37m },
                    { 1158, 18, "Graphic Women's Casual T-Shirt – Premium Cotton Printed Tee for Women | Stylish & Comfortable White T-Shirt", "/images/18_Mr Trending.jpg", "Mr Trending", 81m },
                    { 1159, 18, "Women's Casual Puff Sleeves Floral Print Peplum Top", "/images/18_Sheetal.jpg", "Sheetal", 95m },
                    { 1160, 18, "Women's Regular Fit Top", "/images/18_DEIDAD.jpg", "DEIDAD", 76m },
                    { 1161, 18, "Women's Korean Style Knitted Sheer Crochet Long Sleeve Hollow Out Colour Block Print Crop Top T-Shirt Sweater", "/images/18_ICW.jpg", "ICW ", 46m },
                    { 1162, 18, "Women's Printed Rayon Shirt Top for Women | Western Shirt for Women Stylish Latest | Office Wear Crop Top Blouse", "/images/18_Bollyclues.jpg", "Bollyclues", 35m },
                    { 1163, 18, "Women's Regular Top", "/images/18_rytras.jpg", "rytras", 102m },
                    { 1164, 19, "Women’s High-Rise Straight Fit Jeans | Stretchable Cotton Lycra Denim | Stylish & Comfortable Casual Wear ", "/images/19_FRENCH ROSE.jpg", "FRENCH ROSE", 78m },
                    { 1165, 19, "Women Cotton Solid Mid-Rise Super Flared Jeans", "/images/19_Globus.jpg", "Globus", 65m },
                    { 1166, 19, "Women's Mid Rise 80s Mom Tapered Jeans", "/images/19_Levi's.jpg", "Levi's", 94m },
                    { 1167, 19, "Women's Cotton Blend Stretchable Mid Rise Jeans", "/images/19_Nifty.jpg", "Nifty", 23m },
                    { 1168, 19, "High Rise Dark Wash Cotton Relaxed Fit Women's Jeans", "/images/19_Pepe Jeans.jpg", "Pepe Jeans", 22m },
                    { 1169, 19, "Women's 100% Cotton Solid Wide Leg Jeans", "/images/19_Bewakoof.jpg", "Bewakoof", 35m },
                    { 1170, 19, "Women Skinny Fit Mid-Rise Jeans", "/images/19_KETCH.jpg", "KETCH", 56m },
                    { 1171, 20, "Women's Cotton Printed Night Suit Set of Top & Shorts", "/images/20_KSHS.jpg", "KSHS", 102m },
                    { 1172, 20, "Women's Cotton Shorts | Shorts for Women Night Wear | Sports and Running Shorts for Women | Gym Workout and Yoga Shorts | Women Shorts | Regular Fit Shorts for Women Combo (Pack of 2)", "/images/20_Fflirtygo.jpg", "Fflirtygo", 45m },
                    { 1173, 20, "Women 's Shorts - Plain", "/images/20_Splash.jpg", "Splash", 102m },
                    { 1174, 20, "Women's Relaxed Fit Mid Rise Highly Distressed Regular-Length Denim", "/images/20_Miss Chase.jpg", "Miss Chase", 12m },
                    { 1175, 20, "Womens Regular casual wear relax fit Shorts- pack of 3", "/images/20_Generic.jpg", "Generic", 36m },
                    { 1176, 20, "Women's Super Combed Cotton Relaxed Fit Sleep Shorts with Convenient Side Pockets", "/images/20_Jockey RX72.jpg", "Jockey RX72", 65m },
                    { 1177, 21, "Women's Multicolored Round Neck Short Sleeves Floral Waist Tie-Up Regular Length Jumpsuit", "/images/21_Miss Chase.jpg", "Miss Chase", 59m },
                    { 1178, 21, "Rayon Printed Jumpsuit for Women", "/images/21_FCV.jpg", "FCV", 74m },
                    { 1179, 21, "Women Jumpsuit", "/images/21_Indya.jpg", "Indya", 54m },
                    { 1180, 21, "Almond Beige Printed", "/images/21_W for Woman.jpg", "W for Woman", 86m },
                    { 1181, 21, "Fashion Women Co Ord Set for Women | Co Ord Set for Women Stylish | Festive Co Ord Set for Women | Travel Co Ord Set for Women | Half Sleeve Women Co-ord set", "/images/21_Leriya.jpg", "Leriya", 23m },
                    { 1182, 22, "Casual & Formal Single-Breasted Blazer Regular Fit Stylish Blazer for Womens", "/images/22_Fokashe Store.jpg", "Fokashe Store", 67m },
                    { 1183, 22, "Women's White Waist Coat-Sleeveless, Cotton Blend Waist Coat, Solid Single Breasted Waist Coat Boost Your Style For All Occusion For Girls & Women", "/images/22_Tandul.jpg", "Tandul", 45m },
                    { 1184, 22, "Women's Solid WaistCoat for Women V Neck Button Closure Sleeveless Waist Coat With Two Pockets Ladies Cord Western Party Casual Wear for Girls", "/images/22_DEEBACO.jpg", "DEEBACO", 44m },
                    { 1185, 22, "Witty Taupe Clean Front Blazer", "/images/22_Salt Attire.jpg", "Salt Attire", 55m },
                    { 1186, 22, "Women's Solid Relaxed Fit 3/4 Sleeve Co-ord Blazer and Trouser Set.", "/images/22_KOTTY.jpg", "KOTTY", 66m },
                    { 1187, 23, "Women's Stylish Flower Printed Palazzo Skirt (Black)-(Freesize)", "/images/23_Niue.jpg", "Niue", 77m },
                    { 1188, 23, "Women's Plus Size Solid Rayon Combo Loose Fit Skirt Palazzo Set - 2 PCS", "/images/23_Lastinch.jpg", "Lastinch", 88m },
                    { 1189, 23, "Rayon Gold Print Skirt Palazzo || Free Size || Rayon Palazzo || Skirt Palazzo || GOLDPRINT Skirt Palazzo || Multicolour", "/images/23_ENDFASHION.jpg", "ENDFASHION", 99m },
                    { 1190, 23, "Craft Women's High Cotton Waist Flared Knit Skart Short Stylish Skirt", "/images/23_NEOPOL.jpg", "NEOPOL", 25m },
                    { 1191, 23, "Mid Length Cotton Blend Skirt 113 Black", "/images/23_JANAK.jpg", "JANAK", 63m },
                    { 1192, 24, "Women's Full Sleeve Denim Jacket", "/images/24_FUNDAY FASHION.jpg", "FUNDAY FASHION", 37m },
                    { 1193, 24, "Long Winter Wear Velvet Jacket For Women", "/images/24_Leather.jpg", "Leather", 81m },
                    { 1194, 24, "Waterproof Unisex Rain Coat Hooded Full Sleeves Outdoor Men, Women, Boys & Girls Rainwear Poncho Raincoat for Camping, Hiking & Travelling", "/images/24_HACER EVA.jpg", "HACER EVA", 95m },
                    { 1195, 24, "Polycotton Jacket For Women | Women's Jacket | Long Jacket For Women | Jacket Tops For Women | Oversized Jacket For Standard Length Women", "/images/24_GRECIILOOKS.jpg", "GRECIILOOKS", 76m },
                    { 1196, 24, "Women's Leather Jacket for Winter, Zipper Front", "/images/24_JUGLYGIRLS.jpg", "JUGLYGIRLS", 46m },
                    { 1197, 25, "Women's Stylish Printed Cotton Saree for Party, Daily and Casual Wear", "/images/25_SRILOK.jpg", "SRILOK", 35m },
                    { 1198, 25, "Women's Shimmer Organza Sequence Embroidery Saree With Unstitched Blouse Piece", "/images/25_AKHILAM.jpg", "AKHILAM", 102m },
                    { 1199, 25, "Women's Silk Cotton Kalamkari Print Saree With Blouse Piece", "/images/25_EthnicJunction.jpg", "EthnicJunction", 78m },
                    { 1200, 25, "Women's Georgette Digital Printed Ready To Wear one Minute Saree With Unstitched Blouse Piece", "/images/25_Sidhidata.jpg", "Sidhidata", 65m },
                    { 1201, 25, "Women's Self Woven, Lace Georgette Saree with Unstitched Blouse", "/images/25_SIRIL.jpg", "SIRIL", 94m },
                    { 1202, 26, "Women's Brick Red & Dusty Green Boat Neck Sleeveless Self Design Lace Overlaid Regular Dress", "/images/26_Miss Chase.jpg", "Miss Chase", 23m },
                    { 1203, 26, "Women's Rayon Blend Straight Embroidered Kurta with Pant & Dupatta", "/images/26_GoSriKi.jpg", "GoSriKi ", 22m },
                    { 1204, 26, "Women's Yellow Faux Georgette Stitched Top with Dupatta Full Sleeve Embroidered Anarkali Gown", "/images/26_Miss Ethnik.jpg", "Miss Ethnik", 35m },
                    { 1205, 26, "short Kaftan for women's & girls unique border design and tassel stretchable adjustable drawstring free size western kaftan fit flared floral all seasons", "/images/26_KE KANHA EXPORTS.jpg", "KE KANHA EXPORTS", 56m },
                    { 1206, 26, "women'S Georgette Lehenga And Choli With Long Shrug Set For Solid With Heavy Embroidery Work Set", "/images/26_madhuram.jpg", "madhuram", 102m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1097);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1098);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1099);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1100);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1101);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1102);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1103);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1104);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1105);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1106);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1107);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1108);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1109);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1110);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1111);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1112);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1113);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1114);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1115);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1116);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1117);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1118);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1119);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1120);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1121);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1122);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1123);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1124);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1125);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1126);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1127);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1128);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1129);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1130);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1131);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1132);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1133);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1134);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1135);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1136);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1137);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1138);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1139);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1140);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1141);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1142);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1143);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1144);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1145);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1146);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1147);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1148);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1149);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1150);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1151);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1152);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1153);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1154);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1155);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1156);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1157);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1158);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1159);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1160);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1161);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1162);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1164);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1165);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1166);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1167);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1168);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1169);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1170);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1171);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1172);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1173);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1174);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1175);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1176);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1177);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1178);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1180);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1181);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1182);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1183);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1184);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1185);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1186);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1187);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1188);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1189);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1190);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1191);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1192);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1193);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1194);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1195);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1196);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1197);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1198);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1199);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1200);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1201);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1202);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1203);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1204);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1205);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1206);

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductID",
                keyValue: 1377,
                column: "ImageUrl",
                value: " / images / 62_TEKCOOL.jpg");
        }
    }
}
