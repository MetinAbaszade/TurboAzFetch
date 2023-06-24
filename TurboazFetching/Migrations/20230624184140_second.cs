using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TurboazFetching.Migrations
{
    /// <inheritdoc />
    public partial class second : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Brands",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.AddColumn<int>(
                name: "AutoSalonId",
                table: "Cars",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "AutoSalons",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocationUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slogan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LogoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CoverUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AutoSalons", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AutoSalons",
                columns: new[] { "Id", "CoverUrl", "Description", "Location", "LocationUrl", "LogoUrl", "Number", "Slogan", "Title" },
                values: new object[,]
                {
                    { 1, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F21%2F14%2F51%2F26%2F261e01b2-128d-4278-8228-8f4ac69db606%2FGLE450x.png", "Abşeron Avtomobil Mərkəzi Mercedes-Benz markasının Azərbaycandakı rəsmi dileridir.", "Bakı ş., Sumqayıt şossesi, 6-cı km.", "https://www.google.com/maps?q=40.462017%2C49.750759&amp;ll=40.462017%2C49.750759&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2020%2F06%2F08%2F10%2F59%2F42%2Fe8503c3d-a5c8-4345-b4cd-3af8d27153f2%2Flogogo.png", "[\r\n  \"(050) 289-09-85\",\r\n  \"(050) 289-09-80\",\r\n  \"(051) 232-87-70\"\r\n]", "The best or nothing", "Abşeron Mercedes-Benz" },
                    { 2, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F03%2F04%2F10%2F24%2F12%2Ffbefa7eb-08e7-4fd3-84aa-e259d169bfa6%2FHaima_Turbo_az_Cover.png", "“ASIA Motors” 1992 ci ildən avtomobil istehsal edən &quot;Haima&quot; markasının Azərbaycanda rəsmi idxalçısıdır. Avtomobillər 5 il və ya 100.000 km istehsalçı zəmanətinə malikdir.", "Bakı ş., Xətai r., Babək pr. 28", "https://www.google.com/maps?q=40.390124%2C49.886863&amp;ll=40.390124%2C49.886863&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F12%2F08%2F10%2F26%2F25%2F58112807-afe5-4ac7-a003-fc640a28d75e%2Flogogogo.png", "[\r\n  \"(055) 585-19-92\",\r\n  \"(012) 525-51-51\"\r\n]", "\"ASIA Motors - Haima\" rəsmi olaraq avtomobil və ehtiyat hissələrin satışı, eləcə də servis xidməti üzrə fəaliyyət göstərir. ", "ASIA Motors - Haima" },
                    { 3, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F03%2F04%2F10%2F23%2F59%2Fb3a56221-fa79-47b0-a10f-1c9bdf5b7eed%2FMG_Turbo_az_Cover.png", "Əfsanəvi Britaniya Əsilli MG (Morris Garages) markasının Azərbaycanda yeganə və rəsmi idxalçısı &quot;ASİA Motors&quot; şirkətidir. ", "Bakı ş., Xətai r., Babək pr. 28", "https://www.google.com/maps?q=40.389594%2C49.885298&amp;ll=40.389594%2C49.885298&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2023%2F05%2F20%2F15%2F39%2F46%2F7e1bd26e-78b0-415d-9618-ef2cc149199a%2FTurbo%20Avatar.png", "[\r\n  \"(050) 400-19-24\",\r\n  \"(050) 444-19-24\",\r\n  \"(012) 525-51-51\"\r\n]", "\"ASIA Motors\" rəsmi olaraq avtomobil və ehtiyat hissələrin satışı, eləcə də servis xidməti üzrə fəaliyyət göstərir. Avtomobillər 5 il və ya 150.000 km istehsalçı zəmanətinə malikdir. ", "ASIA Motors - MG " },
                    { 4, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F02%2F01%2F11%2F49%2F16%2Fd8d712c3-9ab7-4c51-84bf-4918f8cabed2%2FWuling%20-%20Turbo_az%20-%20Cover.png", "&quot;ASIA Motors - Wuling&quot; rəsmi olaraq avtomobil və ehtiyat hissələrin satışı, eləcə də servis xidməti üzrə fəaliyyət göstərir. Wuling avtomobillərinə 2 il və ya 50000 km zəmanət verilir.", "Bakı ş., Xətai r., Babək pr. 28", "https://www.google.com/maps?q=40.390124%2C49.886863&amp;ll=40.390124%2C49.886863&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F10%2F31%2F18%2F04%2F07%2Fc7f8e3b9-e958-48ae-b151-b86baf80c02d%2Flogo.png", "[\r\n  \"(050) 400-19-24\",\r\n  \"(050) 444-19-24\",\r\n  \"(012) 525-51-51\"\r\n]", "\"ASIA Motors\" - \"SAIC Motor\" və \"General Motors\"un birgə istehsalı olan Wuling markasının Azərbaycanda yeganə idxalçısıdır.", "ASIA Motors - Wuling" },
                    { 5, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F04%2F05%2F17%2F47%2F59%2F14c64ef7-2ee8-4ff0-b97a-4fcb400968f0%2Fturbooo.jpg", "Dream Auto MMC şirkəti Audi brendinin Azərbaycanda rəsmi distribütorudur.", "Bakı ş., Xətai r., Babək pr. 43A", "https://www.google.com/maps?q=40.392351%2C49.910994&amp;ll=40.392351%2C49.910994&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2020%2F12%2F14%2F15%2F08%2F55%2F8d367cbf-ca39-4dbc-a78f-002df6eb2372%2Faudi%20logo.jpg", "[\r\n  \"(050) 570-00-77\",\r\n  \"(012) 570-00-77\"\r\n]", "Texnologiyadan öndə", "Audi Azərbaycan" },
                    { 6, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F07%2F25%2F17%2F32%2F26%2F95c93a64-1b0f-475b-b337-583d306b18e8%2FTURBO.jpg", "ALFA ROMEO avtomobillərinin Azərbaycanda rəsmi distribütoru Avtolüks Azərbaycan MMC-dir. Avtomobillərə 3 il və ya 60.000 km rəsmi istehalçı zəmanəti verilir.    ", "Bakı ş., Nəsimi r., Ü.Hacıbəyli küç. 57", "https://www.google.com/maps?q=40.377204%2C49.861052&amp;ll=40.377204%2C49.861052&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2019%2F04%2F18%2F16%2F36%2F39%2Fc1f19f4f-5e4a-4f8d-907f-399aff9b6d5e%2FAlfa%20Romeo%20logo.jpg", "[\r\n  \"(012) 983\",\r\n  \"(012) 404-83-95\",\r\n  \"(055) 444-47-00\",\r\n  \"(055) 444-61-00\"\r\n]", "La meccanica delle emozioni", "Autolux Azerbaijan - Alfa Romeo" },
                    { 7, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F01%2F21%2F11%2F49%2F43%2F6e444997-5126-41b0-b155-c20ee4002c08%2Fdodce.png", "DODGE avtomobillərinin Azərbaycanda rəsmi düstribüteri Avtolüks Azərbaycan MMC-dir. Avtomobillərə 3 il və ya 60.000 km rəsmi istehalçı zəmanəti verilir.", "Bakı ş., Nəsimi r., Ü.Hacıbəyli küç. 57", "https://www.google.com/maps?q=40.377159%2C49.860993&amp;ll=40.377159%2C49.860993&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2019%2F04%2F18%2F16%2F44%2F08%2F7ba8412b-3f5a-4f59-811e-4a709289148e%2FDodge%20logo.jpg", "[\r\n  \"(012) 983\",\r\n  \"(012) 404-83-95\",\r\n  \"(055) 444-47-00\",\r\n  \"(055) 444-61-00\"\r\n]", "Domestic. Not Domesticated.", "Autolux Azerbaijan - Dodge" },
                    { 8, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F07%2F06%2F12%2F55%2F12%2Fd97013d3-dce3-4f26-a628-0606aa2312ee%2FFiatDobloTURBO.jpg", "&quot;Fiat&quot;ın Azərbaycanda rəsmi distribütoru &quot;AvtoLüks Azərbaycan&quot; təklif etdiyi avtomobillərə 3 il və ya 60000 km rəsmi istehsalçı zəmanəti verir.", "Bakı ş., Nərimanov r., Zaur Nudirəliyev küç., 8", "https://www.google.com/maps?q=40.402467%2C49.865365&amp;ll=40.402467%2C49.865365&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F07%2F15%2F16%2F25%2F23%2Fceee62e8-0f4a-4112-9208-08250db9eeec%2Ffiatlogo.png", "[\r\n  \"(012) 983\",\r\n  \"(055) 444-47-00\",\r\n  \"(055) 444-61-00\"\r\n]", "Simply more.", "Autolux Azerbaijan - Fiat  " },
                    { 9, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F07%2F27%2F09%2F47%2F18%2Fcb81b80a-80c9-4204-b52f-95f9a62e4002%2FTurboCover.jpg", "JAGUAR avtomobillərinin Azərbaycanda rəsmi distribütoru Avtolüks Azərbaycan MMC-dir. ", "Bakı ş., Nərimanov r., Zaur Nudirəliyev küç., 8", "https://www.google.com/maps?q=40.402066%2C49.866083&amp;ll=40.402066%2C49.866083&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2019%2F04%2F18%2F16%2F29%2F59%2F9a8922c8-bb23-4f0a-9235-56f0eeaaf4e6%2FJaguar%20logo.jpg", "[\r\n  \"(055) 983-09-83\"\r\n]", "Avtomobillərə 3 il və ya 100000 km rəsmi istehalçı zəmanəti verilir.  ", "Autolux Azerbaijan - Jaguar" },
                    { 10, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F03%2F29%2F18%2F46%2F05%2F8cdad728-1981-4cef-81f8-473c04321249%2Fjeep-grand-cherokee.jpg", "JEEP avtomobillərinin Azərbaycanda rəsmi distribütoru Avtolüks Azərbaycan MMC-dir. Avtomobillərə 3 il və ya 60.000 km rəsmi istehalçı zəmanəti verilir. ", "Bakı ş., Nəsimi r., Ü.Hacıbəyli küç. 57", "https://www.google.com/maps?q=40.3772%2C49.861003&amp;ll=40.3772%2C49.861003&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2019%2F04%2F18%2F16%2F17%2F28%2F7601c4f2-563a-49c5-9812-a16d4f397504%2FJeep%20logo.jpg", "[\r\n  \"(012) 983\",\r\n  \"(012) 404-83-95\",\r\n  \"(055) 444-47-00\",\r\n  \"(055) 444-61-00\"\r\n]", "There's Only One.", "Autolux Azerbaijan - Jeep" },
                    { 11, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F02%2F08%2F16%2F04%2F11%2Ff73d7306-57d4-4636-91a1-0f51b9a0821a%2F1%20%286%29.jpg", "Land Rover avtomobillərinin Azərbaycanda rəsmi distribütoru Avtolüks Azərbaycan MMC-dir. Avtomobillərə 3 il və ya 100000 km rəsmi istehalçı zəmanəti verilir.", "Bakı ş., Nərimanv r., Zaur Nudirəliyev küç., 8", "https://www.google.com/maps?q=40.40214%2C49.866148&amp;ll=40.40214%2C49.866148&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2019%2F04%2F23%2F16%2F34%2F21%2Fed146d40-25cc-49b1-aa53-3fe947e64ae6%2FLand%20Rover%20logo.jpg", "[\r\n  \"(055) 983-09-83\"\r\n]", "Above & Beyond", "Autolux Azerbaijan - Land Rover" },
                    { 12, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F03%2F02%2F09%2F21%2F46%2F150280b2-62eb-4e25-9167-011b11dac166%2F2000-643.jpg", "Ən yaxşı və ya heç bir şey! AutoStar Kaukasus Mərkəzi 25 ildir ki,  Mercedes-Benz markasının Azərbaycandakı rəsmi dileridir.", "Bakı ş., Xətai r., Babək pr. 1145", "https://www.google.com/maps?q=40.38838%2C49.877714&amp;ll=40.38838%2C49.877714&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2020%2F06%2F11%2F15%2F13%2F55%2Feac32f75-e5a6-453e-a36d-cd59aace7d7a%2FMB55.jpg", "[\r\n  \"(012) 496-50-50\",\r\n  \"(050) 255-18-04\",\r\n  \"(050) 285-95-91\",\r\n  \"(050) 636-20-03\",\r\n  \"(050) 221-55-95\"\r\n]", "The best or nothing", "AutoStar Kaukasus GmbH" },
                    { 13, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F08%2F29%2F15%2F04%2F18%2F08ca3e46-3e31-45e1-ba0a-3b08e17151dd%2Ffiat12.png", "&quot;Autouniversal&quot; MMC artıq 20 ildir ki &quot;Fiat&quot; və &quot;Fiat Professional&quot; brendin Azərbaycanda rəsmi distribütorudur. Şirkətimiz Sizə bütün fəaliyyət sahələri üçün geniş çeşiddə müxtəlif modifikasiyalı modellər təklif edir. ", "Bakı ş., Babək pr. 36E", "https://www.google.com/maps?q=40.39068%2C49.90479&amp;ll=40.39068%2C49.90479&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F08%2F29%2F10%2F19%2F34%2F2b5560fd-4187-4a23-a55f-4f6a9edc39a7%2Ffiatlogo.png", "[\r\n  \"(012) 424-66-90\",\r\n  \"(050) 363-83-78\"\r\n]", "Yüksək ixtisaslı avtoservis mütəxəssisləri Sizə orijinal ehtiyat hissələri və ən yüksək səviyyədə xidmət təklif edir. Ödəniş şərtləri: Nağd, köçürmə yolu ilə, kredit və lizinq.", "Autouniversal - Fiat Professional" },
                    { 14, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F16%2F11%2F12%2F44%2F9d44c55a-2fd5-4dad-b1a2-e7bcfd6d86eb%2FBAIC-X7-turbo-3.jpg", "BAIC markasının Azərbaycandakı rəsmi distribütoru “Performance Center” şirkətidir.", "Bakı ş., Yasamal r., H.Zərdabi 88", "https://www.google.com/maps?q=40.397859%2C49.806388&amp;ll=40.397859%2C49.806388&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F09%2F02%2F11%2F18%2F55%2Fe3197aef-69e0-47c2-a4af-20858f48f55e%2Fbaiclogo.png", "[\r\n  \"(050) 251-41-54\",\r\n  \"(050) 268-90-40\",\r\n  \"(050) 268-90-39\",\r\n  \"(050) 270-41-20\",\r\n  \"(051) 250-95-95\"\r\n]", "İnnovativ gələcək!", "BAIC Azərbaycan" },
                    { 15, "https://turbo.azstatic.com/uploads/f1010x323/2019%2F09%2F06%2F09%2F47%2F10%2F9e3b27ad-fc8e-451a-a07f-2469529c8e31%2Fbently.png", "Bentley Motors-un Azərbaycanda rəsmi nümayəndəsi.", "Bakı ş., Nəsimi r., Neftçilər pr. 153, Port Baku", "https://www.google.com/maps?q=40.375729%2C49.862844&amp;ll=40.375729%2C49.862844&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2018%2F11%2F22%2F09%2F42%2F40%2F6393d4aa-170a-4a7e-b2b2-9cb198c94e98%2FLogo%20small%20161x161.jpg", "[\r\n  \"(012) 404-82-82\",\r\n  \"(050) 216-35-38\"\r\n]", "100 Years of Extraordinary", "Bentley Baku" },
                    { 16, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F02%2F24%2F11%2F49%2F30%2F2bbfe2f0-1ce9-4d19-8d23-8bcb431b508a%2F050%20258%2055%2045.png", "&quot;Bestune&quot; brendinin Azərbaycanda rəsmi distribütoru &quot;Cahan Motors&quot; şirkətidir.", "Bakı ş., Xətai r., Babək pr., 21/99 (Cahan Motors)", "https://www.google.com/maps?q=40.390249%2C49.887254&amp;ll=40.390249%2C49.887254&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F03%2F08%2F13%2F55%2F16%2F0d430504-6f4c-4861-9c94-33cf0660cb68%2Flogogo.png", "[\r\n  \"(012) 310-07-85\",\r\n  \"(055) 258-55-45\"\r\n]", "Better than the best!", "Bestune Azərbaycan" },
                    { 17, "https://turbo.azstatic.com/uploads/f1010x323/2017%2F10%2F11%2F18%2F22%2F54%2F782%2FIMG_4505.jpg", "BMW, Rolls-Royce və MINI avtomobillərin Azərbaycanda rəsmi idxalçısı.", "Bakı ş., Nəsimi r., A.Salamzadə küç., 33", "https://www.google.com/maps?q=40.405829%2C49.821736&amp;ll=40.405829%2C49.821736&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F06%2F16%2F13%2F03%2F60724f02-e17a-4bf3-9202-95cbad91d0b8%2FImprotex%20Motors%20logos.jpg", "[\r\n  \"(012) 530-31-13\",\r\n  \"(050) 207-17-60\",\r\n  \"(050) 207-17-90\",\r\n  \"(050) 207-17-80\",\r\n  \"(051) 215-17-14\"\r\n]", "Sükan arxasında əsl zövq", "BMW Azerbaijan" },
                    { 18, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F08%2F31%2F11%2F20%2F11%2F72e3c495-d5ef-4759-9e07-370e7e8c77c7%2F3.png", "&quot;Sazmoto&quot; MMC şirkəti &quot;CFMoto&quot; brendinin Azərbaycanda rəsmi nümayəndəsidir. Ödəniş nağd, BirKart və ya daxili kreditlə mümkündür.\r\n", "Bakı ş., Xətai r., M.Hadi 2372", "https://www.google.com/maps?q=40.380024%2C49.953788&amp;ll=40.380024%2C49.953788&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F08%2F25%2F10%2F59%2F45%2Ff9481104-3fde-4f50-a3a6-eef5a2c1af40%2F1.png", "[\r\n  \"(051) 233-24-84\"\r\n]", "2 il və ya 24.000 km qədər rəsmi zəmanət!", "CFMoto Azərbaycan" },
                    { 19, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F03%2F28%2F15%2F06%2F03%2Fa2283f47-5db1-4096-b791-d61071584881%2F2020X643.png", "Changan Azərbaycan Avtomobil Evi tam yenilənmiş model sırası və ən sərfəli şərtləri ilə artıq xidmətinizdədir. ", "Bakı ş., Babək pr. 74 ", "https://www.google.com/maps?q=40.393479%2C49.951185&amp;ll=40.393479%2C49.951185&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F02%2F15%2F10%2F13%2F21%2F508c3558-3d3f-4622-9361-6ac0f556e740%2Flogo.png", "[\r\n  \"(051) 207-53-16\",\r\n  \"(051) 201-49-30\",\r\n  \"(051) 277-07-05\",\r\n  \"(051) 201-49-29\",\r\n  \"(051) 201-99-00\"\r\n]", "Changan - Driving forward with you", "Changan Azerbaijan" },
                    { 20, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F03%2F14%2F17%2F00%2F34%2F7f3e86ac-062f-4a7e-a0de-68cf81c6178d%2Fg%20n.jpg", "Chery avtomobillərinin rəsmi distribütoru &quot;Efendiler Motors&quot; MMC.", "Baki ş, Nizami r., Babək pr., 37", "https://www.google.com/maps?q=40.390579%2C49.901615&amp;ll=40.390579%2C49.901615&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F06%2F13%2F10%2F35%2F26%2Fd4de4f67-258a-46b8-9772-025194b9c42b%2Flogogogo.png", "[\r\n  \"(050) 808-70-70\"\r\n]", "Chery - Fun to Drive", "Chery Azərbaycan" },
                    { 21, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F05%2F30%2F17%2F42%2F42%2F2e22be48-1283-4b5f-9695-380d2c9b8978%2Fcovere.jpg", "&quot;Azərmaş CP&quot; – Chevrolet brendinin Azərbaycanda rəsmi distribütorudur. Sərfəli kredit və lizinq şərtləri təklif olunur. \r\n", "Bakı ş., Xətai r., Babək pr. 44A", "https://www.google.com/maps?q=40.392036%2C49.915248&amp;ll=40.392036%2C49.915248&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F03%2F02%2F15%2F29%2F50%2Fe9f90c78-aa6f-470c-adcd-404bb7dda9b0%2FChevrolet%20Logo.png", "[\r\n  \"(051) 230-60-35\",\r\n  \"(012) 424-81-81\",\r\n  \"*8181\"\r\n]", "3 il və ya 100 000 km zəmanətlə! ", "Chevrolet Azərbaycan" },
                    { 22, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F03%2F02%2F15%2F30%2F14%2F2228f59c-a63c-4598-b59e-4a13f78d18c2%2Fchev2.png", "&quot;Azərmaş CP&quot; – Chevrolet brendinin Azərbaycanda rəsmi dileridir. Sərfəli kredit və lizinq şərtləri təklif olunur. \r\n", "Baki ş., Badamdar qəs., Avtomobil bazarı", "https://www.google.com/maps?q=40.361657%2C49.796392&amp;ll=40.361657%2C49.796392&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F01%2F25%2F16%2F22%2F58%2F0169b3f3-b969-4dc4-8ee9-0059ce38950d%2FChevrolet%20Logo.png", "[\r\n  \"(051) 230-60-34\"\r\n]", "3 il və ya 100 000 km zəmanətlə! ", "Chevrolet Badamdar " },
                    { 23, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F03%2F07%2F16%2F39%2F53%2Fcf2fa7a1-ed00-4b65-abd6-0cb3eb213e70%2FTurbo.az.jpg", "&quot;Xəzər Auto&quot; MMC – &quot;DFSK&quot; markalı kommersiya və minik avtomobillərinin Azərbaycanda rəsmi distribütorudur. Satış köçürmə yolu, nağd, kredit və lizing ilə mümkündür.", "Bakı ş., Nərimanov r., Z.Bünyadov pr., 36B", "https://www.google.com/maps?q=40.412014%2C49.841595&amp;ll=40.412014%2C49.841595&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F12%2F13%2F09%2F48%2F11%2F1c316abe-efec-4c00-bcd3-87d8fb958d85%2Fdfsklogo.png", "[\r\n  \"(012) 436-21-79\",\r\n  \"(050) 358-86-86\",\r\n  \"(050) 582-48-48\"\r\n]", "Avtomobillərə rəsmi istehsalçı tərəfindən 3 il və ya 100.000 km zəmanət verilir", "DFSK Azərbaycan" },
                    { 24, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F08%2F11%2F17%2F39%2Fdf9a9bef-219e-417e-8514-1946b9b11dee%2Fturbo_cover_kaiyi.jpg", "KAIYI markasının Azərbaycanda rəsmi distribütoru &quot;FNC Motors&quot; şirkətidir.", "Bakı ş., Xətai r., Babək pr., 31", "https://www.google.com/maps?q=40.39017%2C49.885138&amp;ll=40.39017%2C49.885138&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F07%2F01%2F15%2F50%2F39%2F36eb3af2-4743-4270-bb35-f150a89cbe1b%2FKAI%CC%87YI%CC%87%20Logo.png", "[\r\n  \"(050) 555-09-34\",\r\n  \"(070) 555-09-34\",\r\n  \"(077) 434-09-34\"\r\n]", "3 il və ya 100000 km zəmanət!", "FNC Motors - KAIYI" },
                    { 25, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F07%2F18%2F15%2F41%2F33%2Fd724b2fe-6c12-4e41-b7bc-95b502e4df51%2FFord%20PUMA%202%20-%20TURBO%20Az%20Cover.jpg", "Ford avtomobillərinin Azərbaycanda rəsmi dileri.", "Bakı-Sumqayıt şossesi 6-cı km", "https://www.google.com/maps?q=40.459821%2C49.754235&amp;ll=40.459821%2C49.754235&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F02%2F16%2F15%2F57%2F36%2F083d0718-283a-4436-adcf-7f98e3e23377%2Flogogo.png", "[\r\n  \"(050) 263-05-15\",\r\n  \"(055) 235-10-53\",\r\n  \"(077) 377-67-56\"\r\n]", "Bring on Tomorrow", "Ford Abşeron Mərkəzi" },
                    { 26, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F07%2F19%2F16%2F57%2F14%2F7db2275e-e0a6-4311-a406-9067fa26181c%2Fcoverere.png", "GAZ Rəsmi distribütordan alınan hər avtomobilə 12 ayda cəmi 17% və 30% ilkin ödənişlə lizinq təklif edir. Kasko və nömrə daxildir!", "Baki ş, Nizami r., Babək pr., 39B", "https://www.google.com/maps?q=40.3915%2C49.906018&amp;ll=40.3915%2C49.906018&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F11%2F14%2F15%2F57%2F3eeb2678-24db-41e9-b338-4bd1a5af2a53%2Fgazlogo.png", "[\r\n  \"(050) 634-82-52\"\r\n]", "GAZ rəsmi distribütor avtomobilləri lizinq və nağd qiymətlə alıcılara təqdim olunur", "GAZ Distribütor" },
                    { 27, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F09%2F23%2F15%2F57%2F15%2F8a1089ce-e5b1-4f5b-b6ab-6bb93cf48130%2FIMG_7715.JPG", "Geely Avtomobillərinin rəsmi distribütoru &quot;Rich Motors&quot; MMC.", "Baki ş, Nizami r., Babək pr., 35A", "https://www.google.com/maps?q=40.390685%2C49.90173&amp;ll=40.390685%2C49.90173&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2023%2F01%2F17%2F11%2F06%2F44%2Fe6f88b54-a5b2-4f33-a112-7d1524d647dc%2FProfile%20picture%20for%20official%20media.jpg", "[\r\n  \"(050) 838-58-58\",\r\n  \"(055) 555-77-88\"\r\n]", "Happy Life, Geely Drive!", "Geely Azərbaycan" },
                    { 28, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F16%2F14%2F46%2F29%2F05f1ea56-921d-4056-922a-1be2297607ec%2Fnew-aile_edit%20%281%29.png", "Çinin №1 yolsuzluq avtomobili brendi olan Haval avtomobillərinin rəsmi nümayəndəsi.", "Bakı ş., Xətai r., Babək pr. 282", "https://www.google.com/maps?q=40.391734%2C49.915967&amp;ll=40.391734%2C49.915967&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F07%2F26%2F10%2F09%2F07%2F48177c61-7717-4339-b26b-329d3e2a09f4%2Flogo.png", "[\r\n  \"*7999\",\r\n  \"(055) 679-23-23\",\r\n  \"(055) 678-24-24\"\r\n]", "Çinin №1 yolsuzluq avtomobili brendi.", "Haval Azerbaijan" },
                    { 29, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F01%2F11%2F14%2F33%2F40%2Fe38636e8-9064-4b61-9a72-eec6b4b4f4be%2FHonda%20CRV%20-%20turbo%20az%20cover%202022.jpg", "Honda avtomobillərinin Azərbaycanda rəsmi distribütoru.", "Bakı-Sumqayıt şossesi 6-cı km", "https://www.google.com/maps?q=40.459617%2C49.754321&amp;ll=40.459617%2C49.754321&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2020%2F09%2F23%2F11%2F08%2F35%2Fdd832ce7-2cfa-488d-bf08-73498c410489%2FHONDA%20AZERBAIJAN%20-%20LOGO.png", "[\r\n  \"(077) 477-77-47\",\r\n  \"(055) 740-47-74\"\r\n]", "The Power of Dreams", "Honda Azerbaijan" },
                    { 30, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F03%2F09%2F11%2F34%2F32%2Fd595e5a4-79f6-4e71-9e3c-647895ea439c%2F055%20234%2055%2045%20Bab%C9%99k%20pr.%202199%20Cahan%20Motors.png", "&quot;Hongqi&quot; brendinin Azərbaycanda rəsmi distribütoru &quot;Cahan Motors&quot; şirkətidir.", "Bakı ş., Xətai r., Babək pr., 21/99 (Cahan Motors)", "https://www.google.com/maps?q=40.390249%2C49.887254&amp;ll=40.390249%2C49.887254&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F03%2F08%2F12%2F43%2F44%2F7c707de6-1211-4464-9be8-95fc4ff8bc68%2FIMG_20220308_124204_621.png", "[\r\n  \"(055) 234-55-45\"\r\n]", "Luxury automotive brand of FAW Group", "Hongqi Azərbaycan" },
                    { 31, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F04%2F18%2F13%2F36%2F27%2F26292284-27e7-460c-ade1-3a21339d7fb0%2Fi20.jpg", "&quot;Hyundai Abşeron&quot; Hyundai avtomobillərinin satışı ilə yanaşı servis xidmətini və original ehtiyat hissələrinin satışını da təşkil edir.", "Bakı - Sumqayıt şossesi, Xırdalan dairəsi", "https://www.google.com/maps?q=40.444305%2C49.770865&amp;ll=40.444305%2C49.770865&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F12%2F14%2F08%2F52%2F6538c5c2-19de-48e0-8ffe-33a6f48e6a7f%2FLogo-Hyundai.png", "[\r\n  \"(077) 390-26-26\",\r\n  \"(050) 520-26-26\"\r\n]", "5 il / 100.000 km və ya 4 il limitsiz yürüş zəmanət! ", "Hyundai Abşeron Diler" },
                    { 32, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F03%2F16%2F13%2F00%2F12%2F3d70ffbd-2f3f-4ae0-902f-996df221a3bf%2Fi20.jpg", "“Auto Azərbaycan” – Hyundai avtomobillərinin satışını, servis xidmətlərini və orijinal ehtiyat hissələrini təqdim edən yeganə rəsmi şirkətdir.", "Bakı ş., Nərimanov r., Z.Bünyadov pr. 118", "https://www.google.com/maps?q=40.428026%2C49.897884&amp;ll=40.428026%2C49.897884&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F11%2F11%2F20%2F08%2Fe37d2975-26cc-46b1-b39c-ea858cd4f48a%2Flogoo.png", "[\r\n  \"(012) 989\",\r\n  \"(055) 414-76-96\"\r\n]", "5 il və ya 100.000 km zəmanətlə!", "Hyundai Auto Azerbaijan" },
                    { 33, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F03%2F16%2F13%2F00%2F28%2F220102d1-597b-47fd-8c30-4a5917c45542%2Fi20.jpg", "&quot;Hyundai Babək Diler&quot; avtosalonu Hyundai avtomobillərinin distribütoru olan &quot;Auto Azərbaycan&quot; şirkətinin &quot;Otoplaza Mall&quot; avtomobil şəhərciyində yerləşən rəsmi dileridir.", "Bakı ş., Babək pr., Əlişir Nəvai küç., 61C", "https://www.google.com/maps?q=40.393999%2C49.92495&amp;ll=40.393999%2C49.92495&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F08%2F25%2F12%2F18%2F26%2F36fd847d-ad2c-4c20-bc05-7e9e8c6a1f1d%2Flogoo.png", "[\r\n  \"(012) 989\",\r\n  \"(050) 800-09-89\"\r\n]", "5 il və ya 100.000 km zəmanətlə!", "Hyundai Babək Diler" },
                    { 34, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F04%2F20%2F12%2F28%2F49%2F7ae0b982-89ab-45e8-acdc-2b5efa6dc8ec%2Fcovrererre.jpg", "Şirkət avtomobillərin satışı ilə yanaşı servis xidmətini və oriqinal ehtiyyat hissələrinin satışını təşkil edir. 5 il və ya 100 000 km zəmanətlə!\r\n", "Badamdar qəs., M.Müşfiq küç., (Pullman ilə üzbəüz)", "https://www.google.com/maps?q=40.35409%2C49.805181&amp;ll=40.35409%2C49.805181&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F11%2F11%2F19%2F32%2F040c0e26-8632-444e-be86-bb26d1f992eb%2Flogoo.png", "[\r\n  \"(012) 502-90-90\",\r\n  \"(050) 212-09-25\",\r\n  \"(051) 207-55-00\",\r\n  \"(051) 523-90-90\"\r\n]", "Hyundai Badamdar Diler - Azərbaycanda ilk rəsmi diler", "Hyundai Badamdar Diler" },
                    { 35, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F04%2F14%2F16%2F36%2F05%2F23d03d0c-05de-4ea8-84b0-5412ab836173%2Fcover.jpg", "&quot;Hyundai Gənclik&quot; – Hyundai avtomobillərinin satışını, servis xidmətlərini və orijinal ehtiyat hissələrini təqdim edən rəsmi dillerdi.", "Bakı ş., Nərimanov r., ak. Həsən Əliyev küç. ", "https://www.google.com/maps?q=40.401413%2C49.845181&amp;ll=40.401413%2C49.845181&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F06%2F21%2F12%2F31%2F47%2F9e3e9122-c27c-4836-aac5-18faca4d987a%2Flogoo.png", "[\r\n  \"(050) 490-26-26\",\r\n  \"(012) 564-08-22\"\r\n]", "5 il / 100.000 km (hansı daha tez bitərsə) və ya 4 il limitsiz zəmanət", "Hyundai Gənclik" },
                    { 36, "https://turbo.azstatic.com/uploads/f1010x323/2021%2F11%2F02%2F11%2F30%2F46%2F8492930f-af05-4c45-8626-4e374097a5b8%2Fcovererere.png", "BMW, Rolls-Royce və MINI avtomobillərin Azərbaycanda rəsmi idxalçısı.", "Bakı ş., Səbail r., Ə.Əlizadə küç. 5 ", "https://www.google.com/maps?q=40.369221%2C49.83861&amp;ll=40.369221%2C49.83861&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F06%2F16%2F48%2F44%2F01fff738-2158-4c49-828c-5c9a17c62eaf%2FImprotex%20Motors%20logos.jpg", "[\r\n  \"(012) 493-25-39\",\r\n  \"(050) 268-33-14\",\r\n  \"(050) 250-17-70\"\r\n]", "Sükan arxasında əsl zövq!", "Improtex Motors Exclusive" },
                    { 37, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F08%2F11%2F17%2F19%2F00c2081f-6ccc-44b9-8625-853afc67f5b9%2Fturbo_cover_infiniti.jpg", "&quot;Nurgün Motors&quot; şirkəti INFINITI brendinin Azərbaycanda rəsmi distribütorudur. &quot;Nurgün Motors&quot;-un salonlarından alınan hər bir avtomobilə 5 il və ya 155000 km zəmanət verilir.", "Bakı ş., Xətai r., Babək pr., 31", "https://www.google.com/maps?q=40.39017%2C49.885138&amp;ll=40.39017%2C49.885138&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F09%2F30%2F12%2F06%2F45%2F3061e977-b48b-463b-b1bb-825e9b76c1a1%2FI%CC%87nfiniti_logo_turbo.az.png", "[\r\n  \"(012) 934\",\r\n  \"(077) 555-09-34\",\r\n  \"(077) 444-09-34\"\r\n]", "EMPOWER THE DRIVE", "Infınıtı Azərbaycan" },
                    { 38, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F07%2F28%2F17%2F19%2F45%2F90eabbcc-d02a-4dbc-9ba3-6cf112c2b85c%2Fcovererer.png", "«Azermash Group MMC» ISUZU brendinin Azərbaycanda rəsmi distribütorudur.", "Bakı ş., Nizami r.,  Babək pr., 39 B", "https://www.google.com/maps?q=40.39142%2C49.905989&amp;ll=40.39142%2C49.905989&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F22%2F15%2F12%2F37%2Fa5b1f22e-e460-49be-81cf-e36b5215ec8e%2Flogogo.png", "[\r\n  \"(050) 634-82-52\"\r\n]", "2 il və ya 100.000 km rəsmi zəmanət!", "Isuzu Azerbaijan" },
                    { 39, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F05%2F03%2F17%2F21%2F36%2F38836b9a-671a-4315-9d77-4f5080ff2e1b%2FJS8-Turbo.az-Cover.jpg", "JAC Motors markasının Azərbaycandakı rəsmi distributoru &quot;Performance Center&quot; şirkətidir.\r\n", "Bakı ş., Yasamal r., H.Zərdabi 88 ", "https://www.google.com/maps?q=40.397826%2C49.806367&amp;ll=40.397826%2C49.806367&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F11%2F23%2F10%2F01%2F40%2F8d6291c2-806c-4bfc-a4ab-73d70b29a5a5%2FLOGOGO.png", "[\r\n  \"(050) 251-41-54\",\r\n  \"(050) 268-90-40\",\r\n  \"(050) 268-90-39\",\r\n  \"(050) 270-41-20\",\r\n  \"(051) 250-95-95\"\r\n]", "Gücünü hiss et! ", "JAC Motors Azərbaycan" },
                    { 40, "https://turbo.azstatic.com/uploads/f1010x323/2021%2F11%2F15%2F07%2F28%2F13%2F6b209d3c-2428-46e1-9cfa-0ace0ef5e3c0%2FTurbo-Cover.jpg", "&quot;Kia Motors Azərbaycan&quot; 2005-ci ildən bəri Koreya istehsalçısı &quot;Kia Motors&quot; korporasiyasının Azərbaycanda rəsmi distribütorudur.\r\n", "Bakı ş., Nizami r., Babək pr., 43 ", "https://www.google.com/maps?q=40.390832%2C49.904192&amp;ll=40.390832%2C49.904192&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F02%2F23%2F11%2F52%2F36%2F299bb20d-9986-4a34-9267-047a20439b92%2Fkialogo.png", "[\r\n  \"(070) 303-60-60\",\r\n  \"(050) 303-60-60\",\r\n  \"(055) 303-60-60\",\r\n  \"(051) 303-60-60\",\r\n  \"(012) 570-01-01\"\r\n]", "5 il və ya 150.000 km zəmanətlə!", "Kia Motors Azerbaijan" },
                    { 41, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F08%2F24%2F11%2F03%2F07%2F0c833c36-82a8-48b3-bc81-b2e8958f5050%2Fdone.png", "&quot;Kia Motors Azərbaycan&quot; 2005-ci ildən bəri Koreya istehsalçısı &quot;Kia Motors&quot; korporasiyasının Azərbaycanda rəsmi distribütorudur.\r\n", "Bakı ş., Nərimanov r., ak. Həsən Əliyev küç., 683", "https://www.google.com/maps?q=40.404803%2C49.859095&amp;ll=40.404803%2C49.859095&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F02%2F23%2F11%2F41%2F59%2F9e55b824-bdc4-4337-ba15-aec054b09b0a%2Fkialogo.png", "[\r\n  \"(012) 465-05-01\",\r\n  \"(055) 465-05-01\",\r\n  \"(099) 526-99-99\"\r\n]", "5 il və ya 150.000 km zəmanətlə!", "Kia Motors Gənclik" },
                    { 42, "https://turbo.azstatic.com/uploads/f1010x323/2019%2F09%2F13%2F15%2F10%2F16%2Fe4cfb98b-c589-4073-bcb1-7175150397b0%2Fkiacover.png", "Rəsmi dillerdən yeni KIA avtomobilləri 5-il zəmanət ilə!", "Sumqayıt ş., Sülh küç., 76-cı məhəllə", "https://www.google.com/maps?q=40.581236%2C49.657188&amp;ll=40.581236%2C49.657188&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F02%2F23%2F11%2F53%2F06%2Fb7532f04-f83c-4e0c-bfc1-d8430524a6d6%2Fkialogo.png", "[\r\n  \"(018) 655-88-11\",\r\n  \"(012) 585-11-88\",\r\n  \"(050) 505-11-88\",\r\n  \"(055) 442-44-94\"\r\n]", "Heyrətləndirmək bacarığı ilə", "Kia Motors Sumqayıt" },
                    { 43, "https://turbo.azstatic.com/uploads/f1010x323/2020%2F12%2F21%2F17%2F09%2F50%2F536d20df-b375-4efd-b436-8d08b893a13f%2FXEZERLADACOVER%20%282%29.png", "«Xazar Auto MMC» korporativ və fiziki müştərilər üçün hər növ kommersiya, xüsusi təyinatlı və minik &quot;LADA &quot;avtomobillərinin sifarişi və satışını təşkil edir. Nəğd, kredit və köçürmə yolu ilə. ", "Bakı ş., 8-ci mkr., C.Xəndan küç., 28", "https://www.google.com/maps?q=40.416208%2C49.834863&amp;ll=40.416208%2C49.834863&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F09%2F30%2F11%2F11%2F58%2F20c1d748-0362-481a-9e00-0af4f562a621%2Fladalogo.png", "[\r\n  \"(012) 513-09-49\",\r\n  \"(050) 582-48-48\"\r\n]", "Yollarda ugurla!", "Lada Auto" },
                    { 44, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F12%2F17%2F30%2F04%2Fc78b0dca-b69f-447b-aa57-bca0974041a7%2Fmazda_CX-60.png", "Mazda avtomobillərinin Azərbaycanda rəsmi distribütoru.", "Bakı-Sumqayıt şossesi 6-cı km", "https://www.google.com/maps?q=40.459796%2C49.75432&amp;ll=40.459796%2C49.75432&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2018%2F05%2F24%2F16%2F33%2F15%2Ff787b8f7-bb0f-4a40-a8a8-c56de32454a9%2FMazdalogo.jpg", "[\r\n  \"(055) 235-10-53\",\r\n  \"(050) 263-05-15\",\r\n  \"(077) 377-67-56\"\r\n]", "Zoom-Zoom", "Mazda Azerbaijan" },
                    { 45, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F06%2F02%2F16%2F38%2F41%2F74ead912-d64a-4a59-b02a-edb6115b7661%2FOutlander%20June%202022%20-%20Turbo%20AZ%20Cover.jpg", "Mitsubishi avtomobillərinin Azərbaycanda rəsmi distribütoru.", "Bakı-Sumqayıt şossesi 6-cı km", "https://www.google.com/maps?q=40.459813%2C49.754268&amp;ll=40.459813%2C49.754268&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F15%2F14%2F55%2F31%2F68770c3b-901e-442a-9f88-d3e52120a980%2Flogogo.png", "[\r\n  \"(055) 740-47-74\",\r\n  \"(077) 477-77-47\"\r\n]", "Drive your Ambition", "Mitsubishi Azerbaijan" },
                    { 46, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F08%2F11%2F16%2F03%2F0ceb8bc8-c014-4873-b3bd-e87d5de50e23%2Fnissan_turbo.png", "&quot;Nurgün Motors&quot; şirkəti Nissan brendinin Azərbaycanda rəsmi distribütorudur. &quot;Nurgün Motors&quot;-un salonlarından alınan hər bir avtomobilə 5 il və ya 155000 km zəmanət verilir.", "Bakı ş., Xətai r., Babək pr. 31", "https://www.google.com/maps?q=40.389311%2C49.884108&amp;ll=40.389311%2C49.884108&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F09%2F07%2F14%2F19%2F59%2F034d1944-7f2c-4589-bfa1-b731c8322cea%2FNissanNext_Logo_Social.jpg", "[\r\n  \"(050) 555-09-34\",\r\n  \"(070) 555-09-34\"\r\n]", "Innovation that excites", "Nissan Azərbaycan" },
                    { 47, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F08%2F11%2F16%2F23%2F4755be56-4f22-4ae3-a85e-a2d1883f10fd%2Fnissan_turbo.png", "&quot;Nurgün Motors&quot; şirkəti Nissan brendinin Azərbaycanda rəsmi distribütorudur. &quot;Nurgün Motors&quot;-un salonlarından alınan hər bir avtomobilə 5 il və ya 155000 km zəmanət verilir.", "Bakı ş., Yasamal r., A.Salamzadə küç. 2", "https://www.google.com/maps?q=40.40031%2C49.818072&amp;ll=40.40031%2C49.818072&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F09%2F07%2F14%2F18%2F42%2F3cdd855c-adbf-4d5a-b043-d6a0057e2e4b%2FNissanNext_Logo_Social.jpg", "[\r\n  \"(077) 477-09-34\",\r\n  \"(077) 434-09-34\"\r\n]", "Innovation that excites", "Nissan Azərbaycan - Salamzadə küç. " },
                    { 48, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F10%2F18%2F10%2F53%2F44%2F2160eb4f-8406-4de7-9c5c-fcdbfc32eb67%2Fturbo.az.png", "Onvolt şirkəti Skywell elektrik avtomobillərin Azərbaycanda rəsmi idxalçısıdır. Avtomobilə 5 il və ya 150 000 km zəmanət, Batareyaya 8 il və ya 200 000 km zəmanət.", "Bakı ş., Ceyhun Hacıbəyli küç., 194", "https://www.google.com/maps?q=40.398542%2C49.842981&amp;ll=40.398542%2C49.842981&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F09%2F08%2F11%2F09%2F38%2Fc59f454d-9f10-4bb4-a8f2-391b1322a1ea%2Flogogog.png", "[\r\n  \"(012) 440-00-07\",\r\n  \"(099) 440-00-07\"\r\n]", "20% ilkin ödənişlə, illik 14%-dan başlayan 5-ilə dək sərfəli kredit şərtləri. ", "ONVOLT - Skywell" },
                    { 49, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F07%2F20%2F17%2F16%2F41%2F1bfa5b96-e783-4425-ba53-6a6fd23de0a3%2FTAM%20YENI%20%282%29.png", "&quot;Cahan Motors&quot; – Opel avtomobillərinin satışını, servis xidmətlərini və orijinal ehtiyat hissələrini təqdim edən yeganə rəsmi distribütordur.", "Bakı ş., Babək pr. 21/99", "https://www.google.com/maps?q=40.390304%2C49.887214&amp;ll=40.390304%2C49.887214&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F07%2F06%2F17%2F53%2F34%2Faf6754ae-0da1-4126-9369-ba59ec1ff7d0%2Fopellogo.png", "[\r\n  \"(055) 268-55-45\"\r\n]", "Opel – Gələcək Hər Kəsindir!", "Opel Azərbaycan" },
                    { 50, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F12%2F07%2F09%2F44%2F11%2Fde139da9-7853-45ad-b811-d986632d3671%2Fcover.png", "&quot;Peugeot&quot; brendinin Azərbaycanda rəsmi dileri.", "Bakı ş., Xətai r., Babək pr. 49", "https://www.google.com/maps?q=40.389511%2C49.873349&amp;ll=40.389511%2C49.873349&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2022%2F12%2F07%2F17%2F20%2F26%2F1ed923db-c033-41d8-b6b0-a40c271ed4f0%2Flogo2.png", "[\r\n  \"(012) 526-40-40\",\r\n  \"(055) 288-48-40\"\r\n]", "Allure. Excellence. Emotion.", "Peugeot Azərbaycan" },
                    { 51, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F12%2F02%2F11%2F34%2F27%2Fedceb1e9-f8b7-473b-8009-3345ff88089c%2Fcoverpolaris.png", "&quot;E and S International Corp.&quot; MMC &quot;Polaris&quot; modellərinin satışını və servisini, eləcə də orijinal ehtiyat hissələrin və aksesuarların nağd və kreditlə satışını həyata keçirir.", "Bakı ş., Xəzər r., Zaqulba küç., 14", "https://www.google.com/maps?q=40.486171%2C50.117099&amp;ll=40.486171%2C50.117099&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2023%2F06%2F06%2F09%2F23%2F47%2Fe552e3c0-a2ec-46e0-acdb-430a3550313d%2F336641762_695270082289184_404253670732672731_n.jpeg", "[\r\n  \"(050) 208-45-45\",\r\n  \"(012) 554-02-56\"\r\n]", "\"Polaris\" şirkətinin Azərbaycandakı rəsmi distribütoru. Zəmanət 2 il.", "Polaris Azerbaijan" },
                    { 52, "https://turbo.azstatic.com/uploads/f1010x323/2021%2F01%2F15%2F12%2F52%2F58%2F3b12f1ad-5878-44ad-bc82-49ff37102ddd%2FEP20MODOX0007_01_low.jpg", "Sizi Porsche dünyasına və əfsanəvi Porsche avtomobillərini müxtəlif vəziyyətlərdə sınaqdan keçirməyə dəvət edirik.", "Bakı ş., Nizami r., M.Əliyev küç., 7", "https://www.google.com/maps?q=40.408022%2C49.92786&amp;ll=40.408022%2C49.92786&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2020%2F08%2F12%2F14%2F47%2F15%2F06a0e9cc-a6d9-49f4-8e72-36bc5961c405%2Flogogo.png", "[\r\n  \"(012) 511-33-44\",\r\n  \"(050) 511-33-44\"\r\n]", "Aydınlıq, həyacan, dəqiqlik", "Porsche Bakı Mərkəzi" },
                    { 53, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F06%2F08%2F11%2F52%2F55%2F4be327df-01c3-47ce-9f55-266d0ef908fc%2Fturbo_cover.jpg", "&quot;Nurgun Motors&quot; şirkəti Renault brendinin Azərbaycanda rəsmi distribütorudur. &quot;Renault&quot; salonundan alınan hər bir avtomobilə 3 il və ya 100000 km zəmanət verilir.", "Bakı ş., Yasamal r., A.Salamzadə küç. 2", "https://www.google.com/maps?q=40.400053%2C49.817917&amp;ll=40.400053%2C49.817917&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F03%2F24%2F14%2F45%2F09%2F02dba3d6-2144-4dd3-8f90-5ecc7eb327a3%2F156210391_4060725460645230_417073906460337963_o.png", "[\r\n  \"(012) 934\",\r\n  \"(077) 477-09-34\",\r\n  \"(077) 434-09-34\",\r\n  \"(050) 555-09-34\"\r\n]", "Passion for life", "Renault Azərbaycan" },
                    { 54, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F04%2F04%2F11%2F35%2F55%2F20ec0a94-6b53-4eaf-b138-5a6fb6268ae4%2Fturbo-resize.png", "Skaz Autohouse MMC Skoda Avtomobillərinin Azərbaycanda rəsmi distribütorudur. Avtomobillərə 3 il və ya 100000 km-ə qədər zəmanət verilir.", "Bakı ş., Xətai r., Babək pr., 74", "https://www.google.com/maps?q=40.394193%2C49.931127&amp;ll=40.394193%2C49.931127&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2023%2F01%2F31%2F15%2F31%2F12%2F3ae7837c-0c4e-4896-be0a-6c295bf51390%2Fskoda.jpg", "[\r\n  \"(051) 207-53-13\",\r\n  \"(051) 201-89-98\",\r\n  \"(050) 235-84-84\",\r\n  \"(051) 207-53-14\",\r\n  \"*5544\"\r\n]", "Simply Clever. ", "Skoda Azerbaijan" },
                    { 55, "https://turbo.azstatic.com/uploads/f1010x323/2022%2F01%2F11%2F14%2F33%2F17%2F10b9f7ea-fe13-4508-ad41-03656eac6b80%2FSubaru%20Forester%20-%20turbo%20az%20cover%202022.jpg", "“Subaru Azərbaycan” 2006-cı ildən Azərbaycanda Subaru avtomobillərinin rəsmi distribüteridir.", "Bakı-Sumqayıt şossesi 6-cı km", "https://www.google.com/maps?q=40.459895%2C49.754074&amp;ll=40.459895%2C49.754074&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F09%2F30%2F11%2F26%2F56%2F785c9862-50b5-4af4-89bb-c9d6473157de%2Fsubaru.png", "[\r\n  \"(077) 477-77-47\",\r\n  \"(077) 377-67-56\",\r\n  \"(055) 740-47-74\"\r\n]", "Confident in Motion", "Subaru Azerbaijan" },
                    { 56, "https://turbo.azstatic.com/uploads/f1010x323/2020%2F08%2F11%2F11%2F46%2F34%2F6b245d31-3996-4ff7-944b-b7c15ba17f36%2FTurbo%20Salon%20Page%20-%20Salon.jpg", "Toyota avtomobillərin Azərbaycanda rəsmi dileri", "Bakı-Sumqayıt şossesi 6-cı km", "https://www.google.com/maps?q=40.458776%2C49.754975&amp;ll=40.458776%2C49.754975&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F12%2F13%2F17%2F31%2F36%2F2fcaba5d-ceb1-4b0a-b569-8214dd2095e0%2Flogogogo.png", "[\r\n  \"(077) 477-77-40\"\r\n]", "Always a better way", "Toyota Abşeron Mərkəzi" },
                    { 57, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F05%2F19%2F16%2F09%2F00%2F65535328-e56d-42d7-9abd-17e2af61938c%2Ftaoscover.jpg", "Volkswagen avtomobillərin Azərbaycandakı rəsmi və yeganə dileri &quot;Azərbaycan Automobiles&quot; LTD", "Bakı ş., Nəcəfqulu Rəfiyev küçəsi 29", "https://www.google.com/maps?q=40.392172%2C49.914991&amp;ll=40.392172%2C49.914991&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2020%2F09%2F21%2F09%2F58%2F48%2Fd231eb51-080c-48f8-9535-3a024f241905%2FVolkswagen%20LOGO.jpg", "[\r\n  \"*0999\",\r\n  \"(050) 255-61-08\",\r\n  \"(050) 255-61-07\"\r\n]", "Volkswagen", "Volkswagen Azərbaycan" },
                    { 58, "https://turbo.azstatic.com/uploads/f1010x323/2023%2F05%2F03%2F17%2F44%2F16%2Fa96e913b-f85a-41b9-b54f-4420486d39f2%2Fcovererere.jpg", "&quot;Aral Auto&quot; MMC &quot;Volvo Cars&quot; şirkətinin Azərbaycanda rəsmi dileridir. &quot;Volvo&quot; avtomobillərini həm nağd, həm də 20% ilkin ödəniş edilməklə illik 10%-lik kredit şərtləri ilə əldə etmək olar. ", "Bakı ş., Babək pr. 61c", "https://www.google.com/maps?q=40.394292%2C49.925392&amp;ll=40.394292%2C49.925392&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2023%2F03%2F07%2F16%2F24%2F45%2Fbc185e23-ebe3-42a1-948d-b7f584b273ab%2FVolvo%20logo-02%20%281%29.jpg", "[\r\n  \"(012) 570-11-77\",\r\n  \"(051) 280-29-04\",\r\n  \"(051) 280-29-05\"\r\n]", "\"Volvo\" avtomobillərinə yürüş limiti olmadan 3 il zəmanət verilir. ", "Volvo Cars" },
                    { 59, "https://turbo.azstatic.com/uploads/f1010x323/2021%2F10%2F06%2F16%2F06%2F01%2F03cc6e6e-3bf3-4979-a2a1-18ef8c6bfedf%2Fcover%20zx%20auto%20final.png", "ZX Auto avtomobillərinin Azərbaycandakı rəsmi distribütoru “Cahan Motors” şirkətidir.", "Bakı ş., Xətai r., Babək pr., 21/99 “Cahan Motors”", "https://www.google.com/maps?q=40.390272%2C49.887321&amp;ll=40.390272%2C49.887321&amp;z=15", "https://turbo.azstatic.com/uploads/f352x352/2021%2F10%2F06%2F16%2F06%2F01%2Fd4a8f856-19e3-413b-aebe-d335b11534cd%2Flogo.png", "[\r\n  \"(012) 310-07-85\",\r\n  \"(055) 243-55-45\"\r\n]", "3 il və ya 100.000 km Zəmanətlə!", "ZX Auto Azerbaijan" }
                });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 28, "MDX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 30, "159" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 30, "4C" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Giulia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Stelvio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 156, "RS 125" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 156, "RS 660" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Tuono 660");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 249, "XR 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 134, "Topic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 86, "DB9" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 86, "DBX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Rapide");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "V8 Vantage");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 268, "150" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 268, "Hummer 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 9, "100" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 9, "80" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "90");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "A1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "A3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "A4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "A5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 23, "A5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 23, "A5 Sportback" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "A6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "A6 allroad" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "A7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 28, "A7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 28, "A7 Sportback" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "A8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Q2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "Q3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Q5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Q5 Sportback");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Q7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "Q8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "Q8 Sportback e-tron");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "R8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "RS3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "RS4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "RS7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "S5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "S6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "S7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "S8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "e-tron");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 419, "11" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 274, "31" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 218, "A1" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 218, "BJ40" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "M20");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "M60");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "Senova D50");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "X25");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "X3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "X55");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "X7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 327, "Avenger 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 327, "Dominar 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Pulsar N250");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Pulsar NS 200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Pulsar RS 200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 375, "180S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 19, "Bentayga" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 19, "Continental" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Continental Flying Spur");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Continental GT");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Flying Spur");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 387, "NAT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 387, "T33" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "T77");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "T99");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 136, "Fatih" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 136, "Pro 827" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "Pro 832");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Pro 935");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 3, "1-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 78, 3, "116" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 78, "118" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 78, "120" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "2-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 82, "220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 82, "228" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "3-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "316" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "318" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "320 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "321" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "323" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "325" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "328" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "330" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "330e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 85, "335" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "4-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 97, "420" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 97, "428" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 97, "430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 97, "435" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "5-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "520" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "520 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "520e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "523" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "525" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "528" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "530" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "530e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "535" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "535 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "540" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 102, "545" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "6-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 115, "630" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 115, "640" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 115, "650" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "7-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 119, "728" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 119, "730" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 119, "735" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 119, "740" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 119, "740Le" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 119, "745" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 119, "750" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 119, "760" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "8-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 128, "840" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 130,
                column: "Name",
                value: "BMW Moto");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 131,
                column: "Name",
                value: "F 800 GS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 130, "G 310 R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 130, "K 1100 LT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 130, "K 1600 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 130, "S 1000 RR" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "M-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "M3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "M4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "M5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "M6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "M8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "X3 M" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "X5 M" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "X6 M" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 136, "XM" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "X-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 146, "X1" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 146, "X2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 146, "X3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 146, "X5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 146, "X6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 146, "X7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Z-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 153, "Z3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 153, "Z4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "i-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 156, "i3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 156, "i4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 156, "i7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 156, "i8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 156, "iX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 62, "B10" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 62, "B7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 92, "M2 (BS4)" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 92, "V5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 84, "LaCrosse" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 378, "Off Road" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 167, 378, "Hunter 125" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 51, "F3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 51, "F6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 171,
                column: "Name",
                value: "Flyer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 172,
                column: "Name",
                value: "Han");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 173,
                column: "Name",
                value: "Qin Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 174,
                column: "Name",
                value: "Seal");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 175,
                column: "Name",
                value: "Song Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 176,
                column: "Name",
                value: "Tang");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 177,
                column: "Name",
                value: "Yuan Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 395, "CM250R-HY" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 395, "CM400R-18" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 180,
                column: "Name",
                value: "CM400R-F8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 181,
                column: "Name",
                value: "CM400R-HY");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 182,
                column: "Name",
                value: "CMR-F7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 183,
                column: "Name",
                value: "CMR-F8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 184,
                column: "Name",
                value: "CMR-RZ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 185,
                column: "Name",
                value: "CMR-SY");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 186,
                column: "Name",
                value: "CMR-YZ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 38, "ATS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 38, "CT5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 189,
                column: "Name",
                value: "CT6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 190,
                column: "Name",
                value: "CTS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 191,
                column: "Name",
                value: "Escalade");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 192,
                column: "Name",
                value: "SRX");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 193,
                column: "Name",
                value: "XTS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 220, "Renegade" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 220, "Spyder RT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 259, "250 CL-X" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 259, "ATV" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 197, "CFORCE 520L" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 197, "CFORCE-ATV-800" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Moto" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 200, "150 NK" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 200, "300 NK" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 200, "300 SR" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 200, "650 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 200, "650 MT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 200, "650 NK" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 200, "700 CL-X Sport" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Sport SIDE X SIDES" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 208, "ZFORCE 1000 Sport" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 163, "Alsvin" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 163, "Alsvin V3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 212,
                column: "Name",
                value: "Alsvin V7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 213,
                column: "Name",
                value: "Benni");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 214,
                column: "Name",
                value: "Benni E-Star");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 215,
                column: "Name",
                value: "CS 15");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 216,
                column: "Name",
                value: "CS 35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 217,
                column: "Name",
                value: "CS 35 PLUS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 218,
                column: "Name",
                value: "CS 55 Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 219,
                column: "Name",
                value: "CS 75");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 220,
                column: "Name",
                value: "CS 85");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 221,
                column: "Name",
                value: "CS 95");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 222,
                column: "Name",
                value: "CX 20");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 223,
                column: "Name",
                value: "EU-Love");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 224,
                column: "Name",
                value: "Eado");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 225,
                column: "Name",
                value: "Eado Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 226,
                column: "Name",
                value: "F 70");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 227,
                column: "Name",
                value: "Honor");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 228,
                column: "Name",
                value: "Oshan A600");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 229,
                column: "Name",
                value: "Raeton");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 230,
                column: "Name",
                value: "Star");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 231,
                column: "Name",
                value: "Uni-K");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 232,
                column: "Name",
                value: "Uni-T");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 233,
                column: "Name",
                value: "Uni-V");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 52, "Amulet (A15)" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 235,
                column: "Name",
                value: "Arrizo 5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 236,
                column: "Name",
                value: "Arrizo 7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 237,
                column: "Name",
                value: "Eastar (B11)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 238,
                column: "Name",
                value: "Fora (A21)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 239,
                column: "Name",
                value: "Fulwin 2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 240,
                column: "Name",
                value: "Sweet (QQ)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 241,
                column: "Name",
                value: "Tiggo (T11)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 242,
                column: "Name",
                value: "Tiggo 2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 243,
                column: "Name",
                value: "Tiggo 2 Pro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 244,
                column: "Name",
                value: "Tiggo 3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 245,
                column: "Name",
                value: "Tiggo 5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 246,
                column: "Name",
                value: "Tiggo 7 Pro ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 247,
                column: "Name",
                value: "Tiggo 8 Pro e+");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 41, "Aveo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 249,
                column: "Name",
                value: "Blazer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 250,
                column: "Name",
                value: "Camaro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 251,
                column: "Name",
                value: "Captiva");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 252,
                column: "Name",
                value: "Cavalier");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 253,
                column: "Name",
                value: "Cobalt");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 254,
                column: "Name",
                value: "Colorado");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 255,
                column: "Name",
                value: "Cruze");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 256,
                column: "Name",
                value: "Damas");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 257,
                column: "Name",
                value: "Epica");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 258,
                column: "Name",
                value: "Equinox");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 259,
                column: "Name",
                value: "Evanda");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 260,
                column: "Name",
                value: "Labo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 261,
                column: "Name",
                value: "Lacetti");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 262,
                column: "Name",
                value: "Malibu");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 263,
                column: "Name",
                value: "Matiz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 264,
                column: "Name",
                value: "Menlo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 265,
                column: "Name",
                value: "Nexia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 266,
                column: "Name",
                value: "Niva");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 267,
                column: "Name",
                value: "Onix");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 268,
                column: "Name",
                value: "Orlando");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 269,
                column: "Name",
                value: "Rezzo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 270,
                column: "Name",
                value: "Spark");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 271,
                column: "Name",
                value: "Tahoe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 272,
                column: "Name",
                value: "Tracker");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 273,
                column: "Name",
                value: "TrailBlazer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 274,
                column: "Name",
                value: "Traverse");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 275,
                column: "Name",
                value: "Trax");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 276,
                column: "Name",
                value: "Venture");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 277,
                column: "Name",
                value: "Volt");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 10, "200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 279,
                column: "Name",
                value: "300C");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 280,
                column: "Name",
                value: "Crossfire");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 281,
                column: "Name",
                value: "Intrepid");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 282,
                column: "Name",
                value: "Pacifica");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 27, "C-Elysee" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 284,
                column: "Name",
                value: "C4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 285,
                column: "Name",
                value: "C4 Picasso");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 286,
                column: "Name",
                value: "C5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 287,
                column: "Name",
                value: "DS3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 288,
                column: "Name",
                value: "Jumper");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 289,
                column: "Name",
                value: "Nemo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 76, "Lodgy" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 291,
                column: "Name",
                value: "Logan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 292,
                column: "Name",
                value: "Sandero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 180, "City Leading" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 11, "Ace (Super Salon)" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 295,
                column: "Name",
                value: "BS090");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 296,
                column: "Name",
                value: "Damas");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 297,
                column: "Name",
                value: "Espero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 298,
                column: "Name",
                value: "Gentra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 299,
                column: "Name",
                value: "Lanos");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 300,
                column: "Name",
                value: "Leganza");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 301,
                column: "Name",
                value: "Matiz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 302,
                column: "Name",
                value: "Nexia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 303,
                column: "Name",
                value: "Nubira");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 304,
                column: "Name",
                value: "Prince");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 305,
                column: "Name",
                value: "Racer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 91, "105 XF" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 307,
                column: "Name",
                value: "75 CF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 308,
                column: "Name",
                value: "85 CF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 309,
                column: "Name",
                value: "95 XF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 310,
                column: "Name",
                value: "LF 55.220");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 311,
                column: "Name",
                value: "XF 460 FT");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 66, "Feroza" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 313,
                column: "Name",
                value: "Terios");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 148, "DY150-12" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 405, "C-32" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 316,
                column: "Name",
                value: "C-32 S");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 317,
                column: "Name",
                value: "C-35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 318,
                column: "Name",
                value: "C-37");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 319,
                column: "Name",
                value: "D51");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 320,
                column: "Name",
                value: "Glory 330");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 321,
                column: "Name",
                value: "Glory 330 S");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 322,
                column: "Name",
                value: "Glory 330 S Cargo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 162, "11" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 324,
                column: "Name",
                value: "K-750");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 60, "Caliber" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 326,
                column: "Name",
                value: "Challenger");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 327,
                column: "Name",
                value: "Charger");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 328,
                column: "Name",
                value: "Durango");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 329,
                column: "Name",
                value: "Journey");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 330,
                column: "Name",
                value: "Ram");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 331,
                column: "Name",
                value: "Stratus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 332,
                column: "Name",
                value: "Viper");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 117, "EQ1020TF" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 334,
                column: "Name",
                value: "Fengshen A30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 335,
                column: "Name",
                value: "Fengshen S30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 336,
                column: "Name",
                value: "Rich");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 147, "1100 EVO Diesel" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 338,
                column: "Name",
                value: "848 EVO");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 339,
                column: "Name",
                value: "848 EVO Corse");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 340,
                column: "Name",
                value: "Diavel Carbon");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 341,
                column: "Name",
                value: "Monster 1200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 342,
                column: "Name",
                value: "Monster 796");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 343,
                column: "Name",
                value: "Panigale V2	");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 344,
                column: "Name",
                value: "Panigale V4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 79, "Bestune B30" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 346,
                column: "Name",
                value: "Besturn B70");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 347,
                column: "Name",
                value: "Besturn X80");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 348,
                column: "Name",
                value: "CA5013");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 349,
                column: "Name",
                value: "Oley");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 37, "500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 351,
                column: "Name",
                value: "500C");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 352,
                column: "Name",
                value: "500L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 353,
                column: "Name",
                value: "Albea");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 354,
                column: "Name",
                value: "Doblo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 355,
                column: "Name",
                value: "Ducato");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 356,
                column: "Name",
                value: "Fiorino");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 357,
                column: "Name",
                value: "Linea");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 358,
                column: "Name",
                value: "Panda");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 359,
                column: "Name",
                value: "Punto");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 360,
                column: "Name",
                value: "Sedici");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 361,
                column: "Name",
                value: "Stilo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 362,
                column: "Name",
                value: "Tempra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 363,
                column: "Name",
                value: "Uno");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 2, "Bronco Sport" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 2, "C-MAX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 366,
                column: "Name",
                value: "Cargo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 367,
                column: "Name",
                value: "Contour");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 368,
                column: "Name",
                value: "Cougar");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 369,
                column: "Name",
                value: "Ecosport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 370,
                column: "Name",
                value: "Edge");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 371,
                column: "Name",
                value: "Escape");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 372,
                column: "Name",
                value: "Escort");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 373,
                column: "Name",
                value: "Explorer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 374,
                column: "Name",
                value: "F-150");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 375,
                column: "Name",
                value: "Fiesta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 376,
                column: "Name",
                value: "Focus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 377,
                column: "Name",
                value: "Fusion");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 378,
                column: "Name",
                value: "Galaxy");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 379,
                column: "Name",
                value: "Ka");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 380,
                column: "Name",
                value: "Kuga");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 381,
                column: "Name",
                value: "Maverick");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 382,
                column: "Name",
                value: "Mondeo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 383,
                column: "Name",
                value: "Mustang");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 384,
                column: "Name",
                value: "Mustang Mach-E");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 385,
                column: "Name",
                value: "Puma");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 386,
                column: "Name",
                value: "Ranger");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 387,
                column: "Name",
                value: "S-MAX");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 388,
                column: "Name",
                value: "Scorpio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 389,
                column: "Name",
                value: "Taurus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 390,
                column: "Name",
                value: "Tourneo Connect");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 391,
                column: "Name",
                value: "Tourneo Custom");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 392,
                column: "Name",
                value: "Transit");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 49, "Aumark TX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 49, "BJ6486B1DBA-2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 395,
                column: "Name",
                value: "Forland");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 396,
                column: "Name",
                value: "Ollin");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 159, "Sport G 250R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 175, "GA5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 175, "GM8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 400,
                column: "Name",
                value: "GS4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 401,
                column: "Name",
                value: "GS5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 21, "12 ЗИМ" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 21, "13" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 404,
                column: "Name",
                value: "221717");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 405,
                column: "Name",
                value: "231073");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 406,
                column: "Name",
                value: "24");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 407,
                column: "Name",
                value: "24-02");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 408,
                column: "Name",
                value: "24-10");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 409,
                column: "Name",
                value: "24-102");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 410,
                column: "Name",
                value: "2705");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 411,
                column: "Name",
                value: "2705-757");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 412,
                column: "Name",
                value: "2705-777");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 413,
                column: "Name",
                value: "27057");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 414,
                column: "Name",
                value: "27527-745");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 415,
                column: "Name",
                value: "2757");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 416,
                column: "Name",
                value: "3102");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 417,
                column: "Name",
                value: "31029");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 418,
                column: "Name",
                value: "3110");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 419,
                column: "Name",
                value: "31105");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 420,
                column: "Name",
                value: "3111");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 421,
                column: "Name",
                value: "32212");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 422,
                column: "Name",
                value: "322173");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 423,
                column: "Name",
                value: "3302-288");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 424,
                column: "Name",
                value: "3302-744");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 425,
                column: "Name",
                value: "330200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 426,
                column: "Name",
                value: "330202-740");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 427,
                column: "Name",
                value: "33021");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 428,
                column: "Name",
                value: "33023-744");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 429,
                column: "Name",
                value: "330232-744");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 430,
                column: "Name",
                value: "33027");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 431,
                column: "Name",
                value: "3307");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 432,
                column: "Name",
                value: "3308");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 433,
                column: "Name",
                value: "33098-837");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 434,
                column: "Name",
                value: "37053C");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 435,
                column: "Name",
                value: "52");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 436,
                column: "Name",
                value: "53");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 437,
                column: "Name",
                value: "66");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 438,
                column: "Name",
                value: "69");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 439,
                column: "Name",
                value: "A21R22-03");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 440,
                column: "Name",
                value: "Biznes 330273");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 441,
                column: "Name",
                value: "C41R13");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 442,
                column: "Name",
                value: "C41R92");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 443,
                column: "Name",
                value: "C45R02");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 444,
                column: "Name",
                value: "Gazon C41R33");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 445,
                column: "Name",
                value: "M-20 Pobeda");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 446,
                column: "Name",
                value: "M-21");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 447,
                column: "Name",
                value: "NEXT A68R52 CITY LINE");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 448,
                column: "Name",
                value: "Next A21R22-30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 449,
                column: "Name",
                value: "Next A21R32-30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 450,
                column: "Name",
                value: "Next A22R32");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 451,
                column: "Name",
                value: "Next A31R22");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 452,
                column: "Name",
                value: "Next A32R32-40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 453,
                column: "Name",
                value: "Next A65R52");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 454,
                column: "Name",
                value: "Next C41RB3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 455,
                column: "Name",
                value: "Next Sidney A32R32-40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 456,
                column: "Name",
                value: "Next А31R32");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 457,
                column: "Name",
                value: "Siber");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 458,
                column: "Name",
                value: "Sobol");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 72, "Atlas Pro" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 72, "CK" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 72, "Coolray" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 462,
                column: "Name",
                value: "Emgrand");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 463,
                column: "Name",
                value: "Emgrand X7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 464,
                column: "Name",
                value: "MK");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 465,
                column: "Name",
                value: "Monjaro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 466,
                column: "Name",
                value: "Okavango");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 467,
                column: "Name",
                value: "TX4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 468,
                column: "Name",
                value: "Tugella");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 468, "Tugella" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 468, "Tugella S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 376, "G80" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 82, "Acadia" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 82, "Jimmy" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 82, "Savana" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 475,
                column: "Name",
                value: "Terrain");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 476,
                column: "Name",
                value: "Yukon");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 50, "Hover H3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 50, "Hover H5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 50, "Hover H6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 480,
                column: "Name",
                value: "Hover M2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 481,
                column: "Name",
                value: "Hover M4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 482,
                column: "Name",
                value: "Pegasus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 483,
                column: "Name",
                value: "Voleex C30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 484,
                column: "Name",
                value: "Voleex C50");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 485,
                column: "Name",
                value: "Wingle");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 383, "8S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 142, "HJ110-2C" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 142, "HJ125-18" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 142, "HJ150-9A" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 140, "FXDR" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 140, "Softail Fat Boy" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 140, "Sportster Custom 1200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 493,
                column: "Name",
                value: "Sportster Forty Eight");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 494,
                column: "Name",
                value: "Street Rod");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 495,
                column: "Name",
                value: "Touring Electra Glide");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 496,
                column: "Name",
                value: "XL 1200 NS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 497,
                column: "Name",
                value: "XL883N Sportster Iron 883");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 498,
                column: "Name",
                value: "XR1200X");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 242, "Dargo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 242, "F7x" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 242, "H2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 502,
                column: "Name",
                value: "H6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 503,
                column: "Name",
                value: "H6 GT");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 504,
                column: "Name",
                value: "H9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 505,
                column: "Name",
                value: "Jolion");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 12, "Accord" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 12, "CR-V" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 12, "City" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 509,
                column: "Name",
                value: "Civic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 510,
                column: "Name",
                value: "Element");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 511,
                column: "Name",
                value: "Fit");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 512,
                column: "Name",
                value: "HR-V");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 513,
                column: "Name",
                value: "Honda Moto");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 513, "CB 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 513, "CB300R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 513, "CBR 600" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 513, "Giorno" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 513, "H’ness CB350 DLX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 513, "VTX 1300 R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Insight" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "M-NV" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 522,
                column: "Name",
                value: "Odyssey");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 523,
                column: "Name",
                value: "Pilot");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 524,
                column: "Name",
                value: "Ridgeline");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 525,
                column: "Name",
                value: "e:NP1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 526,
                column: "Name",
                value: "e:NS1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 388, "E-HS9" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 388, "H9" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 529,
                column: "Name",
                value: "HS5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 530,
                column: "Name",
                value: "HS7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 110, "371" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 110, "A7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 533,
                column: "Name",
                value: "Sinotruk");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 409, "Neta U" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 409, "Neta V" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 13, "H2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 13, "H3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 1, "Accent" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 1, "Azera" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 540,
                column: "Name",
                value: "Chorus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 541,
                column: "Name",
                value: "County");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 542,
                column: "Name",
                value: "Coupe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 543,
                column: "Name",
                value: "Creta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 544,
                column: "Name",
                value: "Elantra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 545,
                column: "Name",
                value: "Equus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 546,
                column: "Name",
                value: "Excel");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 547,
                column: "Name",
                value: "Galloper");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 548,
                column: "Name",
                value: "Genesis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 549,
                column: "Name",
                value: "Genesis Coupe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 550,
                column: "Name",
                value: "Getz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 551,
                column: "Name",
                value: "Grand Santa Fe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 552,
                column: "Name",
                value: "Grandeur");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 553,
                column: "Name",
                value: "H 100");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 554,
                column: "Name",
                value: "H 350");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 555,
                column: "Name",
                value: "H-1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 556,
                column: "Name",
                value: "HD-35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 557,
                column: "Name",
                value: "HD-45");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 558,
                column: "Name",
                value: "HD-65");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 559,
                column: "Name",
                value: "HD-72");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 560,
                column: "Name",
                value: "IONIQ 5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 561,
                column: "Name",
                value: "IONIQ Plug-in-Hybrid");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 562,
                column: "Name",
                value: "Kona");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 563,
                column: "Name",
                value: "Matrix");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 564,
                column: "Name",
                value: "Palisade");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 565,
                column: "Name",
                value: "Santa Cruz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 566,
                column: "Name",
                value: "Santa Fe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 567,
                column: "Name",
                value: "Solaris");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 568,
                column: "Name",
                value: "Sonata");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 569,
                column: "Name",
                value: "Staria");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 570,
                column: "Name",
                value: "Super Aero City");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 571,
                column: "Name",
                value: "Terracan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 572,
                column: "Name",
                value: "Tucson");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 573,
                column: "Name",
                value: "Veloster");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 574,
                column: "Name",
                value: "Venue");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 575,
                column: "Name",
                value: "Veracruz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 576,
                column: "Name",
                value: "i10");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 577,
                column: "Name",
                value: "i20");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 578,
                column: "Name",
                value: "i30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 579,
                column: "Name",
                value: "i40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 580,
                column: "Name",
                value: "ix35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 581,
                column: "Name",
                value: "ix55");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 64, "2126 Oda" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 64, "2715" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 584,
                column: "Name",
                value: "2717");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 585,
                column: "Name",
                value: "27175");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 586,
                column: "Name",
                value: "IJ Moto");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 586, "Planeta 4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 586, "Planeta 5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 586, "Planeta 7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 15, "EX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 590, 15, "EX35" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 592,
                column: "Name",
                value: "FX-series");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 593,
                column: "Name",
                value: "FX35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 592, "FX37" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 592, "FX45" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 592, "FX50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "G-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 597, "G25" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 597, "G35" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 597, "G37" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "JX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 601, "JX35" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "M-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 603, "M37S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 603, "M45" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 606,
                column: "Name",
                value: "Q-Series");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 607,
                column: "Name",
                value: "Q45");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 608,
                column: "Name",
                value: "Q50");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 606, "Q50S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 606, "Q60" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 606, "Q70" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 606, "QX4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "QX-Series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 613, "QX30" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 613, "QX50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 613, "QX55" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 613, "QX56" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 613, "QX60" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 613, "QX70" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 613, "QX80" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 116, "Runna" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 116, "Samand" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 116, "Soren" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 74, "Bogdan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 74, "Citybus" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 74, "Ecobus" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 74, "FSR 90 L" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 628,
                column: "Name",
                value: "FVR 34 Q");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 629,
                column: "Name",
                value: "NHR 55 E");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 630,
                column: "Name",
                value: "NKR 55 E");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 631,
                column: "Name",
                value: "NKR 55 L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 632,
                column: "Name",
                value: "NKR 66 E");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 633,
                column: "Name",
                value: "NMR 77 H");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 634,
                column: "Name",
                value: "NMR 85 H");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 635,
                column: "Name",
                value: "NPR");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 636,
                column: "Name",
                value: "NPR 66 L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 637,
                column: "Name",
                value: "NPR 66 P");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 638,
                column: "Name",
                value: "NPR 75");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 639,
                column: "Name",
                value: "NPR 75 K");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 640,
                column: "Name",
                value: "NPR 75 L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 641,
                column: "Name",
                value: "NPR75L-K");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 642,
                column: "Name",
                value: "NQR 71 PL");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 643,
                column: "Name",
                value: "Novo Lux");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 644,
                column: "Name",
                value: "Turkuaz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 67, "35 S11" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 67, "35C13V" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 67, "35C15" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 67, "Astra HD8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 649,
                column: "Name",
                value: "Daily 30-8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 650,
                column: "Name",
                value: "Daily 35C12H");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 651,
                column: "Name",
                value: "EuroStar");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 652,
                column: "Name",
                value: "Eurotrakker Cursor");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 653,
                column: "Name",
                value: "Otoyol");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 654,
                column: "Name",
                value: "Stralis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 124, "HFC 1040K" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 124, "HFC1020" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 124, "HFC1083K" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 124, "HFC5020K" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 659,
                column: "Name",
                value: "J5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 660,
                column: "Name",
                value: "J7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 661,
                column: "Name",
                value: "JS3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 662,
                column: "Name",
                value: "JS4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 663,
                column: "Name",
                value: "JS8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 664,
                column: "Name",
                value: "T6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 665,
                column: "Name",
                value: "T8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 35, "F-Pace R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 35, "F-Type" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 35, "F-Type R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 35, "S-Type" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 670,
                column: "Name",
                value: "X-Type");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 671,
                column: "Name",
                value: "XE");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 672,
                column: "Name",
                value: "XF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 673,
                column: "Name",
                value: "XJ L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 155, "350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 36, "Cherokee" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 36, "Commander" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 36, "Compass" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 36, "Gladiator" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 679,
                column: "Name",
                value: "Grand Cherokee");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 680,
                column: "Name",
                value: "Liberty");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 681,
                column: "Name",
                value: "Patriot");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 682,
                column: "Name",
                value: "Renegade");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 683,
                column: "Name",
                value: "Wrangler");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 384, "Dashing" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 384, "X70" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 384, "X70 PLUS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 384, "X90 PLUS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 688,
                column: "Name",
                value: "X95");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 337, "JS125-7F" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 235, "YY50QT-21B" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 390, "X3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 390, "X3 Pro" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 90, "4308" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 90, "43101" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 90, "5320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 90, "53212" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 697,
                column: "Name",
                value: "53213");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 698,
                column: "Name",
                value: "53215");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 699,
                column: "Name",
                value: "53229");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 700,
                column: "Name",
                value: "5410");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 701,
                column: "Name",
                value: "54115");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 702,
                column: "Name",
                value: "5511");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 703,
                column: "Name",
                value: "55111");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 704,
                column: "Name",
                value: "55115");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 705,
                column: "Name",
                value: "65115");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 706,
                column: "Name",
                value: "6520");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 707,
                column: "Name",
                value: "65201");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 406, "Nev 50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 420, "Dolphin" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 139, "Ninja 650" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 139, "Ninja ZX-10R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 139, "Ninja ZX-14" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 139, "VN 1700 Vulcan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 714,
                column: "Name",
                value: "Versys 650");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 715,
                column: "Name",
                value: "Z650");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 716,
                column: "Name",
                value: "ZX-6R");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 374, "T4 ENDURO" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 282, "LX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 282, "SD" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 8, "Avella" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 8, "Besta" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 8, "Bongo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 8, "Cadenza" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 724,
                column: "Name",
                value: "Carens");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 725,
                column: "Name",
                value: "Carnival");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 726,
                column: "Name",
                value: "Ceed");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 727,
                column: "Name",
                value: "Ceed SW");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 728,
                column: "Name",
                value: "Cerato");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 729,
                column: "Name",
                value: "Cerato Koup");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 730,
                column: "Name",
                value: "Clarus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 731,
                column: "Name",
                value: "Credos");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 732,
                column: "Name",
                value: "EV6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 733,
                column: "Name",
                value: "K2700");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 734,
                column: "Name",
                value: "K3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 735,
                column: "Name",
                value: "K5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 736,
                column: "Name",
                value: "K7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 737,
                column: "Name",
                value: "K8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 738,
                column: "Name",
                value: "Magentis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 739,
                column: "Name",
                value: "Mohave");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 740,
                column: "Name",
                value: "Morning");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 741,
                column: "Name",
                value: "Niro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 742,
                column: "Name",
                value: "Optima");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 743,
                column: "Name",
                value: "Picanto");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 744,
                column: "Name",
                value: "Pregio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 745,
                column: "Name",
                value: "Pride");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 746,
                column: "Name",
                value: "ProCeed");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 747,
                column: "Name",
                value: "Quoris");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 748,
                column: "Name",
                value: "Rio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 749,
                column: "Name",
                value: "Rio X-Line");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 750,
                column: "Name",
                value: "Seltos");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 751,
                column: "Name",
                value: "Shuma");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 752,
                column: "Name",
                value: "Sorento");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 753,
                column: "Name",
                value: "Soul");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 754,
                column: "Name",
                value: "Spectra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 755,
                column: "Name",
                value: "Sportage");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 756,
                column: "Name",
                value: "Stinger");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 757,
                column: "Name",
                value: "Stonic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 141, "390 Duke" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 141, "690 Duke" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 141, "RC 390" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 332, "Dragon 50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 332, "Sniper 50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 332, "X-boss" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 5, "2101" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 5, "21011" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 5, "21013" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 767,
                column: "Name",
                value: "2102");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 768,
                column: "Name",
                value: "2103");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 769,
                column: "Name",
                value: "2104");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 770,
                column: "Name",
                value: "21045");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 771,
                column: "Name",
                value: "2105");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 772,
                column: "Name",
                value: "2106");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 773,
                column: "Name",
                value: "2107");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 774,
                column: "Name",
                value: "2108");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 775,
                column: "Name",
                value: "2109");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 776,
                column: "Name",
                value: "21099");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 777,
                column: "Name",
                value: "2110");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 778,
                column: "Name",
                value: "21103");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 779,
                column: "Name",
                value: "2111");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 780,
                column: "Name",
                value: "2112");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 781,
                column: "Name",
                value: "21123");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 782,
                column: "Name",
                value: "2113");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 783,
                column: "Name",
                value: "2114");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 784,
                column: "Name",
                value: "2115");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 785,
                column: "Name",
                value: "Granta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 786,
                column: "Name",
                value: "Kalina");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 787,
                column: "Name",
                value: "Largus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 787, "Largus" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 787, "Largus Cross" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 790,
                column: "Name",
                value: "Niva");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Niva Bronto" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Niva Travel" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 793,
                column: "Name",
                value: "Oka");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 794,
                column: "Name",
                value: "Priora");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 795,
                column: "Name",
                value: "Vesta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 795, "Vesta" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 795, "Vesta Cross" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 795, "Vesta SW" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 795, "Vesta SW Cross" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "XRAY" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 800, "XRAY" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 43, "Aventador" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 20, "Defender" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 20, "Discovery" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 20, "Discovery Sport" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 806,
                column: "Name",
                value: "Freelander");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 807,
                column: "Name",
                value: "RR Evoque");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 808,
                column: "Name",
                value: "RR Sport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 809,
                column: "Name",
                value: "RR Velar");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 810,
                column: "Name",
                value: "Range Rover");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 14, "CT-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 811, 14, "CT 200h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 14, "ES-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 813, "ES 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 813, "ES 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 813, "ES 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 813, "ES 300h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 813, "ES 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GS-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 819, "GS 200t" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 819, "GS 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 819, "GS 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 819, "GS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 819, "GS 430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 819, "GS 450h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 826, "GX 460" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 826, "GX 470" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 829,
                column: "Name",
                value: "HS-series");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 830,
                column: "Name",
                value: "HS 250h");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "IS-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 831, "IS 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 831, "IS 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 831, "IS 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "LS-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 835, "LS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 835, "LS 460" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 835, "LS 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "LX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 839, "LX 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 839, "LX 470" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 839, "LX 500d" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 839, "LX 570" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 839, "LX 600" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "NX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 845, "NX 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 845, "NX 200t" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 845, "NX 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 845, "NX 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 845, "NX 300h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 845, "NX 350h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "RX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 852, "RX 200t" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 852, "RX 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 852, "RX 330" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 852, "RX 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 852, "RX 450h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "UX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 858, "UX 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 858, "UX 250h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 412, "L9" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 87, "320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 87, "330" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 87, "520" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 865,
                column: "Name",
                value: "620");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 866,
                column: "Name",
                value: "720");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 867,
                column: "Name",
                value: "820");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 868,
                column: "Name",
                value: "X60");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 46, "Aviator" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 46, "LS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 46, "MKZ" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 872,
                column: "Name",
                value: "Navigator");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 873,
                column: "Name",
                value: "Towncar");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 103, "967" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 329, "Granite" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 329, "Mack Anthem" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 112, "10163" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 112, "19.414" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 112, "26463" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 880,
                column: "Name",
                value: "L 2000");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 881,
                column: "Name",
                value: "TGA 18.400");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 882,
                column: "Name",
                value: "TGA 18.430");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 883,
                column: "Name",
                value: "TGA 18.440");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 884,
                column: "Name",
                value: "TGA 18.480");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 885,
                column: "Name",
                value: "TGA 26.320");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 886,
                column: "Name",
                value: "TGA 33350");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 887,
                column: "Name",
                value: "TGA 440");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 888,
                column: "Name",
                value: "TGL8.150");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 889,
                column: "Name",
                value: "TGX 18.440");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 890,
                column: "Name",
                value: "TGX 18.480");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 891,
                column: "Name",
                value: "Temsa");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 44, "Ghibli" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 44, "GranTurismo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 44, "GranTurismo S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 895,
                column: "Name",
                value: "Levante");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 896,
                column: "Name",
                value: "Quattroporte");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 100, "3577" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 100, "5334" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 100, "5337" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 900,
                column: "Name",
                value: "54229");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 901,
                column: "Name",
                value: "54323");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 902,
                column: "Name",
                value: "551605");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 903,
                column: "Name",
                value: "5549");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 904,
                column: "Name",
                value: "6303");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 905,
                column: "Name",
                value: "642208");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 906,
                column: "Name",
                value: "643008");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 907,
                column: "Name",
                value: "650108 ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 26, "2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 26, "3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 26, "323" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 911,
                column: "Name",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 912,
                column: "Name",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 913,
                column: "Name",
                value: "CX-30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 914,
                column: "Name",
                value: "CX-5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 915,
                column: "Name",
                value: "CX-60");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 916,
                column: "Name",
                value: "CX-7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 917,
                column: "Name",
                value: "CX-9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 918,
                column: "Name",
                value: "MX-30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 919,
                column: "Name",
                value: "MX-5 Miata");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 920,
                column: "Name",
                value: "RX-8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 921,
                column: "Name",
                value: "Tribute");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 4, "170 V" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 4, "190" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 4, "A-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 924, "A 150" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 924, "A 160" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 924, "A 170" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 924, "A 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 924, "A 190" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 924, "A 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 924, "A 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 924, "A 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "B-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 933, "B 170" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 933, "B 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 933, "B 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "C-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 240" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 300 e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 937, "C 63 S AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CL-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 951, "CL 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 951, "CL 550" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 951, "CL 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CLA-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 955, "CLA 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 955, "CLA 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 955, "CLA 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 955, "CLA 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 955, "CLA 250 e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 955, "CLA 35 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 955, "CLA 45 S AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CLK-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 963, "CLK 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 963, "CLK 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 963, "CLK 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 963, "CLK 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CLS-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 968, "CLS 250 CDI" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 968, "CLS 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 968, "CLS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 968, "CLS 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 968, "CLS 450 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 968, "CLS 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 968, "CLS 55 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 968, "CLS 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Citan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Commercial" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "0303" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "0403" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "1117" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "1217" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "207 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "208 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "307 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "308 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "403" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "408 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "410 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "609 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "612 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "711 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "809 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "811 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "812 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "814 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Actros 1841" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Actros 1843" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Actros 1844" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Actros 1846" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Actros 1848" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Actros 2540" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1217" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1218" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1222" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1223" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1224" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1228" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1229" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1317" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1318" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1323" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1324" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1517" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1523" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1823" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 1828" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 2528" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 812" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 814" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 815" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 816" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 817" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 818" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 822" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Atego 917" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 1824" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 1829" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 1833" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 1840" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 1843" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 2529" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 2533" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 2533" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 2540" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 3028" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 3340" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Axor 4140" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Travego" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 978, "Vario" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "E-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "230 E" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "280 E" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 240" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 260" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 270" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 290" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 300 de" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 300 e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 450 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 53 4MATIC+ " });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1041, "E 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "EQC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1066, "EQC 400 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "EQE" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1068, "EQE 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1068, "EQE 350 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "EQS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1071, "AMG EQS 53 4MATIC+" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1071, "EQS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1071, "EQS 580 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1075,
                column: "Name",
                value: "EQV");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1076,
                column: "Name",
                value: "EQV 300");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "G-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 55 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 55 Brabus K8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1077, "G 65 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GL-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1088, "GL 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1088, "GL 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1088, "GL 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1088, "GL 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1088, "GL 550" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1088, "GL 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1088, "GL Brabus Widestar" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLA-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1096, "GLA 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1096, "GLA 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1096, "GLA 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLB-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1100, "GLB 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1100, "GLB 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1100, "GLB 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1100, "GLB 35 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLC-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 200 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 200 4Matic Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 250 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 300 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 300 e 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 300 e 4Matic Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1105, "GLC 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLE-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 350 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 400 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 43 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 43 AMG Coupe " });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 450 4Matic Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 450 AMG Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 53 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 53 AMG Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1115, "GLE 63 AMG S 4Matic+ Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLK-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1129, "GLK 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1129, "GLK 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1129, "GLK 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLS-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1133, "GLS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1133, "GLS 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1133, "GLS 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1133, "GLS 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1133, "GLS 580" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1133, "GLS 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "ML-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 270" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 550" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1140, "ML 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "R-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1152, "R 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1152, "R 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1155,
                column: "Name",
                value: "S-class");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1156,
                column: "Name",
                value: "250 S");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1157,
                column: "Name",
                value: "300 SEL");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "500 SEL" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 350 d" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 350 d 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 400 d" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 400 d 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 420" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1170,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1171,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1172,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1173,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 500 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1174,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 500 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1175,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 55 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1176,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 550" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1177,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 550 e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1178,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 560 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1179,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 560 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1180,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 580 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1181,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 600" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1182,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1183,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1155, "S 63 AMG Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1184,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "SL-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1185,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1184, "SL 55 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1186,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1184, "SL 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1187,
                column: "Name",
                value: "SLK-class");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1188,
                column: "Name",
                value: "SLK 200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1189,
                column: "Name",
                value: "SLK 230");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1190,
                column: "Name",
                value: "Sprinter");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1191,
                column: "Name",
                value: "Sprinter 208");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1192,
                column: "Name",
                value: "Sprinter 209");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1193,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 210" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1194,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 211" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1195,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 212" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 213" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 224" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 308" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 311" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 312" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 313" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1202,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 314" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1203,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 315" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1204,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 316" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1205,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 318" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1206,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 319" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1207,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 411" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1208,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 412" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1209,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 413" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1210,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 515" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1211,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 516" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1212,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1190, "Sprinter 524" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1213,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "V-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1214,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1213, "V 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1215,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1213, "V 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1216,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1213, "V 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1217,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1213, "V 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1218,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1213, "Viano" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1219,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Vaneo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1220,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Vito" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1221,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1222,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 108" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1223,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 109" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1224,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 110" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1225,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 111" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1226,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 112" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1227,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 113" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1228,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 114" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1229,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 115" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1230,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 116" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1231,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 119" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1232,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1220, "Vito 122" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1233,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "X-Class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1234,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1233, "X 250D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1235,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 252, "GLS 600 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1236,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 252, "S 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1237,
                column: "Name",
                value: "S 450");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1238,
                column: "Name",
                value: "S 500");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1239,
                column: "Name",
                value: "S 560");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1240,
                column: "Name",
                value: "S 580 4MATIC");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1241,
                column: "Name",
                value: "S 600");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1242,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 47, "Mariner" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1243,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 47, "Mountaineer" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1244,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 127, "3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1245,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 127, "350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1246,
                column: "Name",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1247,
                column: "Name",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1248,
                column: "Name",
                value: "750");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1249,
                column: "Name",
                value: "GT");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1250,
                column: "Name",
                value: "HS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1251,
                column: "Name",
                value: "RX8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1252,
                column: "Name",
                value: "ZS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1253,
                column: "Name",
                value: "ZS T");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1254,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 31, "Clubman" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1255,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 31, "Cooper" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1256,
                column: "Name",
                value: "Countryman");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1257,
                column: "Name",
                value: "One");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1258,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 146, "1.101 &quot;Kroha&quot;" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1259,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 146, "3.112.12" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1260,
                column: "Name",
                value: "D4 125");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1261,
                column: "Name",
                value: "X250");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1262,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 6, "ASX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1263,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 6, "Airtrek" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1264,
                column: "Name",
                value: "Attrage");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1265,
                column: "Name",
                value: "Canter");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1266,
                column: "Name",
                value: "Chariot");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1267,
                column: "Name",
                value: "Eclipse Cross");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1268,
                column: "Name",
                value: "Galant");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1269,
                column: "Name",
                value: "Grandis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1270,
                column: "Name",
                value: "L200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1271,
                column: "Name",
                value: "L300");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1272,
                column: "Name",
                value: "Lancer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1273,
                column: "Name",
                value: "Magna");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1274,
                column: "Name",
                value: "Mirage");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1275,
                column: "Name",
                value: "Montero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1276,
                column: "Name",
                value: "Nativa");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1277,
                column: "Name",
                value: "Outlander");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1278,
                column: "Name",
                value: "Outlander Sport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1279,
                column: "Name",
                value: "Pajero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1280,
                column: "Name",
                value: "Pajero Pinin");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1281,
                column: "Name",
                value: "Pajero Sport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1282,
                column: "Name",
                value: "Pajero io");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1283,
                column: "Name",
                value: "Rosa");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1284,
                column: "Name",
                value: "Xpander");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1285,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 286, "50 Revival" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1286,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 81, "2140" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1287,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 81, "2141" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1288,
                column: "Name",
                value: "2715");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1289,
                column: "Name",
                value: "400");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1290,
                column: "Name",
                value: "401");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1291,
                column: "Name",
                value: "408");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1292,
                column: "Name",
                value: "412");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1293,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 416, "V100" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1294,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1293, 416, "V100 Mandello" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1295,
                column: "Name",
                value: "V9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1296,
                column: "Name",
                value: "V9 Bobber");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1297,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 243, "Muravey- 2 01" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1298,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 243, "Muravey- 2 02" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1299,
                column: "Name",
                value: "Muravey- 2 03");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1300,
                column: "Name",
                value: "TG200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1301,
                column: "Name",
                value: "TGA200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1302,
                column: "Name",
                value: "TGA200-01P");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1303,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 158, "Rivale" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1304,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 324, "48-2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 7, "Almera" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 7, "Altima" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1307,
                column: "Name",
                value: "Armada");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1308,
                column: "Name",
                value: "Bluebird");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1309,
                column: "Name",
                value: "Bolero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1310,
                column: "Name",
                value: "GT-R");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1311,
                column: "Name",
                value: "Juke");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1312,
                column: "Name",
                value: "Kicks");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1313,
                column: "Name",
                value: "Leaf");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1314,
                column: "Name",
                value: "March");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1315,
                column: "Name",
                value: "Maxima");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1316,
                column: "Name",
                value: "Micra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1317,
                column: "Name",
                value: "Murano");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1318,
                column: "Name",
                value: "Navara");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1319,
                column: "Name",
                value: "Note");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1320,
                column: "Name",
                value: "Pathfinder");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1321,
                column: "Name",
                value: "Patrol");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1322,
                column: "Name",
                value: "Primera");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1323,
                column: "Name",
                value: "Qashqai");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1324,
                column: "Name",
                value: "Rogue");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1325,
                column: "Name",
                value: "Sentra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1326,
                column: "Name",
                value: "Serena");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1327,
                column: "Name",
                value: "Sunny");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1328,
                column: "Name",
                value: "Teana");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1329,
                column: "Name",
                value: "Terrano");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1330,
                column: "Name",
                value: "Tiida");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1331,
                column: "Name",
                value: "Urvan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1332,
                column: "Name",
                value: "Versa");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1333,
                column: "Name",
                value: "Wingroad");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1334,
                column: "Name",
                value: "X-Trail");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1335,
                column: "Name",
                value: "Xterra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1336,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 29, "Agila" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1337,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 29, "Antara" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1338,
                column: "Name",
                value: "Astra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1339,
                column: "Name",
                value: "Combo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1340,
                column: "Name",
                value: "Corsa");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1341,
                column: "Name",
                value: "Crossland X");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1342,
                column: "Name",
                value: "Frontera");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1343,
                column: "Name",
                value: "Grandland X");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1344,
                column: "Name",
                value: "Insignia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1345,
                column: "Name",
                value: "Kadett");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1346,
                column: "Name",
                value: "Meriva");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1347,
                column: "Name",
                value: "Mokka");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1348,
                column: "Name",
                value: "Mokka X");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1349,
                column: "Name",
                value: "Omega");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1350,
                column: "Name",
                value: "Signum");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1351,
                column: "Name",
                value: "Sintra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1352,
                column: "Name",
                value: "Tigra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1353,
                column: "Name",
                value: "Vectra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1354,
                column: "Name",
                value: "Vita");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1355,
                column: "Name",
                value: "Vivaro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1356,
                column: "Name",
                value: "Zafira");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1357,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 114, "32054" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 114, "4234" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1359,
                column: "Name",
                value: "672");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 16, "2008" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1361,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1360, 16, "2008" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1362,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1360, "e-2008" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1363,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "206" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1364,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "207" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1365,
                column: "Name",
                value: "3008");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1366,
                column: "Name",
                value: "301");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1367,
                column: "Name",
                value: "307");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1368,
                column: "Name",
                value: "307 CC");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1369,
                column: "Name",
                value: "308");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1370,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1369, "308" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1371,
                column: "Name",
                value: "405");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1372,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "406" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1373,
                column: "Name",
                value: "407");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1374,
                column: "Name",
                value: "5008");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1375,
                column: "Name",
                value: "508");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1376,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1375, "508" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1377,
                column: "Name",
                value: "607");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1378,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Boxer" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1379,
                column: "Name",
                value: "Pars");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1380,
                column: "Name",
                value: "Partner");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1381,
                column: "Name",
                value: "RCZ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1382,
                column: "Name",
                value: "Rifter");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1383,
                column: "Name",
                value: "Traveller");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1384,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 247, "GEM" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1384, 247, "GEM e4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1386,
                column: "Name",
                value: "RZR S 1000");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1387,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Sportsman 570" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1388,
                column: "Name",
                value: "Sportsman 850");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1389,
                column: "Name",
                value: "Sportsman Touring 850 SP");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1390,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 396, "2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1391,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 32, "718" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1392,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1391, 32, "718 Boxster" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1393,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1391, "718 Cayman" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1394,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "911" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1395,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1394, "911 Carrera" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1396,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1394, "911 Carrera 4S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1397,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1394, "911 Carrera S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1398,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "924" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1399,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Cayenne" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1401,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1402,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne E-Hybrid" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1403,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne E-hybrid Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1404,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne GTS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1405,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne GTS Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1406,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1407,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne Turbo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1408,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne Turbo GT Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1409,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1399, "Cayenne Turbo S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1410,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Cayman" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Cayman S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1412,
                column: "Name",
                value: "Macan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1412, "Macan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1414,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1412, "Macan S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1415,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Panamera" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1416,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1417,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera 4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1418,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera 4 Sport Turismo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1419,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera 4S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1420,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera 4S E-hybrid" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1421,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera GTS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1422,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera S E-Hybrid" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1423,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera Turbo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1424,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera Turbo Executive" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1425,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1415, "Panamera Turbo S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1426,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Taycan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1427,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1426, "Taycan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1428,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1426, "Taycan 4S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1429,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 105, "22031" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1430,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 272, "Nexia R3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1431,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 272, "R4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1432,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 17, "12 Toros" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1433,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 17, "19" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1434,
                column: "Name",
                value: "9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1435,
                column: "Name",
                value: "Arkana");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1436,
                column: "Name",
                value: "Clio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1437,
                column: "Name",
                value: "Dokker");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1438,
                column: "Name",
                value: "Duster");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1439,
                column: "Name",
                value: "Espace");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1440,
                column: "Name",
                value: "Fluence");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1441,
                column: "Name",
                value: "Grand Scenic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1442,
                column: "Name",
                value: "Kangoo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1443,
                column: "Name",
                value: "Kaptur");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1444,
                column: "Name",
                value: "Koleos");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1445,
                column: "Name",
                value: "Laguna");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1446,
                column: "Name",
                value: "Logan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1447,
                column: "Name",
                value: "Magnum");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1448,
                column: "Name",
                value: "Master");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1449,
                column: "Name",
                value: "Megane");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1450,
                column: "Name",
                value: "Megane Scenic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1451,
                column: "Name",
                value: "Modus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1452,
                column: "Name",
                value: "Premium 250");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1453,
                column: "Name",
                value: "Premium 420");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1454,
                column: "Name",
                value: "Sandero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1455,
                column: "Name",
                value: "Scenic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1456,
                column: "Name",
                value: "Symbol");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1457,
                column: "Name",
                value: "Tondar");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1458,
                column: "Name",
                value: "Trafic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1459,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 333, "Blazer 50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1460,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 333, "Winner 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1461,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 18, "Phantom" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1462,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 422, "Classic 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1463,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 422, "Hunter 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1464,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 94, "132" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1465,
                column: "Name",
                value: "141");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1466,
                column: "Name",
                value: "Rich");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1467,
                column: "Name",
                value: "Saina");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1468,
                column: "Name",
                value: "Tiba");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1469,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 93, "SKY" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1470,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 108, "G 420" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1471,
                column: "Name",
                value: "R 420");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1472,
                column: "Name",
                value: "R 480");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1473,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 59, "Exeo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1474,
                column: "Name",
                value: "Ibiza");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1475,
                column: "Name",
                value: "Leon");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1476,
                column: "Name",
                value: "Toledo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1477,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 133, "F2000" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1478,
                column: "Name",
                value: "F3000");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1479,
                column: "Name",
                value: "SX3314DT366");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1480,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 132, "SLG 6602" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1481,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 418, "XSJ400-6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1482,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 22, "Fabia" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1483,
                column: "Name",
                value: "Kamiq");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1484,
                column: "Name",
                value: "Karoq");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1485,
                column: "Name",
                value: "Kodiaq");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1486,
                column: "Name",
                value: "Octavia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1487,
                column: "Name",
                value: "Rapid");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1488,
                column: "Name",
                value: "Superb");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1489,
                column: "Name",
                value: "Yeti");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1490,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 399, "ET5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1491,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 61, "Forfour" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1492,
                column: "Name",
                value: "Fortwo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1493,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 45, "Actyon Sports" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1494,
                column: "Name",
                value: "Chairman");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1495,
                column: "Name",
                value: "Korando");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1496,
                column: "Name",
                value: "Kyron");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1497,
                column: "Name",
                value: "Musso");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1498,
                column: "Name",
                value: "Rexton");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1499,
                column: "Name",
                value: "Rexton Sports");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1500,
                column: "Name",
                value: "Tivoli");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 34, "B9 Tribeca" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1502,
                column: "Name",
                value: "Forester");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1503,
                column: "Name",
                value: "Impreza");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1504,
                column: "Name",
                value: "Legacy");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1505,
                column: "Name",
                value: "Outback");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1506,
                column: "Name",
                value: "Tribeca");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1507,
                column: "Name",
                value: "XV");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1508,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 33, "Baleno" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1509,
                column: "Name",
                value: "Burgman");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1510,
                column: "Name",
                value: "Grand Vitara");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1511,
                column: "Name",
                value: "Ignis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1512,
                column: "Name",
                value: "Jimny");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1513,
                column: "Name",
                value: "Reno");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1655,
                column: "Name",
                value: "S40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1656,
                column: "Name",
                value: "S80");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1657,
                column: "Name",
                value: "S90");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1658,
                column: "Name",
                value: "XC40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1659,
                column: "Name",
                value: "XC60");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1660,
                column: "Name",
                value: "XC70");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1661,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 25, "XC90" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1662,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 417, "Free" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1663,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 404, "Mini EV" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1664,
                column: "Name",
                value: "Drag Star XVS 650");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1665,
                column: "Name",
                value: "FJR1300A ABS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1666,
                column: "Name",
                value: "FZ 1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1667,
                column: "Name",
                value: "FZ 25");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1668,
                column: "Name",
                value: "FZ 6N");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1669,
                column: "Name",
                value: "FZ-S FI Deluxe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1670,
                column: "Name",
                value: "FZ8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1671,
                column: "Name",
                value: "Fazer 150");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1672,
                column: "Name",
                value: "Fazer 600N");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1673,
                column: "Name",
                value: "Fazer 600N S2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1674,
                column: "Name",
                value: "Grizzly 700");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1675,
                column: "Name",
                value: "MT-15");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1676,
                column: "Name",
                value: "R15 V4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1677,
                column: "Name",
                value: "R15M");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1678,
                column: "Name",
                value: "R15S");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1679,
                column: "Name",
                value: "RAY-ZR");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1680,
                column: "Name",
                value: "Ray Z 115");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1681,
                column: "Name",
                value: "V Max");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1682,
                column: "Name",
                value: "XVS1300A Midnight Star");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1683,
                column: "Name",
                value: "XVS950A Midnight Star");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1684,
                column: "Name",
                value: "YBR 125");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1685,
                column: "Name",
                value: "YZ125");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1686,
                column: "Name",
                value: "YZF-R1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1687,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 138, "YZF-R6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1688,
                column: "Name",
                value: "965");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1689,
                column: "Name",
                value: "968M");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1690,
                column: "Name",
                value: "Sens");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1691,
                column: "Name",
                value: "Slavuta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1692,
                column: "Name",
                value: "Tavriya");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1693,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 57, "Vida" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1694,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 403, "001" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1695,
                column: "Name",
                value: "130");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1696,
                column: "Name",
                value: "131");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1697,
                column: "Name",
                value: "431410");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1698,
                column: "Name",
                value: "431412");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1699,
                column: "Name",
                value: "431610");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1700,
                column: "Name",
                value: "4334");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1701,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 85, "5301" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1702,
                column: "Name",
                value: "Infinity");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1703,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 285, "ZII ZS200-76" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1704,
                column: "Name",
                value: "Panther ZT150-8A");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1705,
                column: "Name",
                value: "R250");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1706,
                column: "Name",
                value: "T310");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1707,
                column: "Name",
                value: "Tiger ZT150-3A");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1708,
                column: "Name",
                value: "U-125");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1709,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 143, "ZT155-G1" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1710,
                column: "Name",
                value: "Grand Tiger");

            migrationBuilder.InsertData(
                table: "Models",
                columns: new[] { "Id", "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1711, null, 217, "Terralord" });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_AutoSalonId",
                table: "Cars",
                column: "AutoSalonId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AutoSalons_AutoSalonId",
                table: "Cars",
                column: "AutoSalonId",
                principalTable: "AutoSalons",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AutoSalons_AutoSalonId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "AutoSalons");

            migrationBuilder.DropIndex(
                name: "IX_Cars_AutoSalonId",
                table: "Cars");

            migrationBuilder.DeleteData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1711);

            migrationBuilder.DropColumn(
                name: "AutoSalonId",
                table: "Cars");

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "Id", "Name" },
                values: new object[] { 280, "Abarth" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 280, "595" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 28, "ILX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 28, "MDX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "159");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "4C");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 30, "Giulia" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 30, "Stelvio" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "RS 125");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 156, "RS 660" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 156, "Tuono 660" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 249, "XR 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 134, "Topic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "DB9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "DBX");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 86, "Rapide" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 86, "V8 Vantage" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 268, "150" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 268, "Hummer 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: "100");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 20,
                column: "Name",
                value: "80");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 21,
                column: "Name",
                value: "90");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: "A1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 23,
                column: "Name",
                value: "A3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "A4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "A5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 25, "A5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 25, "A5 Sportback" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 28,
                column: "Name",
                value: "A6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "A6 allroad" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "A7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 30, "A7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 30, "A7 Sportback" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 33,
                column: "Name",
                value: "A8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 34,
                column: "Name",
                value: "Q2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 35,
                column: "Name",
                value: "Q3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 36,
                column: "Name",
                value: "Q5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 37,
                column: "Name",
                value: "Q5 Sportback");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 38,
                column: "Name",
                value: "Q7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 39,
                column: "Name",
                value: "Q8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 40,
                column: "Name",
                value: "Q8 Sportback e-tron");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 41,
                column: "Name",
                value: "R8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 42,
                column: "Name",
                value: "RS3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 43,
                column: "Name",
                value: "RS4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 44,
                column: "Name",
                value: "RS7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 45,
                column: "Name",
                value: "S5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 46,
                column: "Name",
                value: "S6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 47,
                column: "Name",
                value: "S7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 9, "S8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 9, "e-tron" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 419, "11" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 274, "31" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 52,
                column: "Name",
                value: "A1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 53,
                column: "Name",
                value: "BJ40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 54,
                column: "Name",
                value: "M20");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 55,
                column: "Name",
                value: "M60");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 56,
                column: "Name",
                value: "Senova D50");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 57,
                column: "Name",
                value: "X25");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 58,
                column: "Name",
                value: "X3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 218, "X55" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 218, "X7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 61,
                column: "Name",
                value: "Avenger 220");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 62,
                column: "Name",
                value: "Dominar 400");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 63,
                column: "Name",
                value: "Pulsar N250");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 327, "Pulsar NS 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 327, "Pulsar RS 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 375, "180S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 67,
                column: "Name",
                value: "Bentayga");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 68,
                column: "Name",
                value: "Continental");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 69,
                column: "Name",
                value: "Continental Flying Spur");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 19, "Continental GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 19, "Flying Spur" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 72,
                column: "Name",
                value: "NAT");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 73,
                column: "Name",
                value: "T33");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 387, "T77" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 387, "T99" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 76,
                column: "Name",
                value: "Fatih");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 77,
                column: "Name",
                value: "Pro 827");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 136, "Pro 832" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 136, "Pro 935" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "1-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 80, "116" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 80, "118" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 80, "120" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "2-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 84, "220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 84, "228" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "3-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "316" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "318" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "320 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "321" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "323" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "325" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "328" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "330" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "330e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 87, "335" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "4-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 99, "420" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 99, "428" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 99, "430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 99, "435" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "5-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "520" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "520 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "520e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "523" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "525" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "528" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "530" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "530e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "535" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "535 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "540" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 104, "545" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "6-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 117, "630" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 117, "640" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 117, "650" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "7-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 121, "728" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 121, "730" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 121, "735" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 121, "740" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 121, "740Le" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 121, "745" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 121, "750" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 121, "760" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 130,
                column: "Name",
                value: "8-series");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 131,
                column: "Name",
                value: "840");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "BMW Moto" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 132, "F 800 GS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 132, "G 310 R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 132, "K 1100 LT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 132, "K 1600 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 132, "S 1000 RR" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "M-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "M3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "M4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "M5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "M6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "M8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "X3 M" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "X5 M" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "X6 M" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 138, "XM" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "X-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 148, "X1" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 148, "X2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 148, "X3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 148, "X5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 148, "X6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 148, "X7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Z-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 155, "Z3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 155, "Z4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "i-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 158, "i3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 158, "i4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 158, "i7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 158, 3, "i8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 158, 3, "iX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 62, "B10" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 62, "B7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 92, "M2 (BS4)" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 92, "V5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 84, "LaCrosse" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 378, "Off Road" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 169, 378, "Hunter 125" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 171,
                column: "Name",
                value: "F3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 172,
                column: "Name",
                value: "F6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 173,
                column: "Name",
                value: "Flyer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 174,
                column: "Name",
                value: "Han");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 175,
                column: "Name",
                value: "Qin Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 176,
                column: "Name",
                value: "Seal");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 177,
                column: "Name",
                value: "Song Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 51, "Tang" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 51, "Yuan Plus" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 180,
                column: "Name",
                value: "CM250R-HY");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 181,
                column: "Name",
                value: "CM400R-18");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 182,
                column: "Name",
                value: "CM400R-F8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 183,
                column: "Name",
                value: "CM400R-HY");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 184,
                column: "Name",
                value: "CMR-F7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 185,
                column: "Name",
                value: "CMR-F8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 186,
                column: "Name",
                value: "CMR-RZ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 395, "CMR-SY" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 395, "CMR-YZ" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 189,
                column: "Name",
                value: "ATS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 190,
                column: "Name",
                value: "CT5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 191,
                column: "Name",
                value: "CT6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 192,
                column: "Name",
                value: "CTS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 193,
                column: "Name",
                value: "Escalade");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 38, "SRX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 38, "XTS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 220, "Renegade" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 220, "Spyder RT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "250 CL-X" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "ATV" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 199, "CFORCE 520L" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 199, "CFORCE-ATV-800" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Moto" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 202, "150 NK" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 202, "300 NK" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 202, "300 SR" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 202, "650 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 202, "650 MT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 202, "650 NK" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 202, "700 CL-X Sport" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 259, "Sport SIDE X SIDES" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 210, 259, "ZFORCE 1000 Sport" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 212,
                column: "Name",
                value: "Alsvin");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 213,
                column: "Name",
                value: "Alsvin V3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 214,
                column: "Name",
                value: "Alsvin V7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 215,
                column: "Name",
                value: "Benni");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 216,
                column: "Name",
                value: "Benni E-Star");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 217,
                column: "Name",
                value: "CS 15");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 218,
                column: "Name",
                value: "CS 35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 219,
                column: "Name",
                value: "CS 35 PLUS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 220,
                column: "Name",
                value: "CS 55 Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 221,
                column: "Name",
                value: "CS 75");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 222,
                column: "Name",
                value: "CS 85");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 223,
                column: "Name",
                value: "CS 95");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 224,
                column: "Name",
                value: "EU-Love");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 225,
                column: "Name",
                value: "Eado");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 226,
                column: "Name",
                value: "Eado Plus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 227,
                column: "Name",
                value: "F 70");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 228,
                column: "Name",
                value: "Honor");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 229,
                column: "Name",
                value: "Oshan A600");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 230,
                column: "Name",
                value: "Raeton");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 231,
                column: "Name",
                value: "Star");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 232,
                column: "Name",
                value: "Uni-K");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 233,
                column: "Name",
                value: "Uni-T");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 163, "Uni-V" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 235,
                column: "Name",
                value: "Amulet (A15)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 236,
                column: "Name",
                value: "Arrizo 5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 237,
                column: "Name",
                value: "Arrizo 7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 238,
                column: "Name",
                value: "Eastar (B11)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 239,
                column: "Name",
                value: "Fora (A21)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 240,
                column: "Name",
                value: "Fulwin 2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 241,
                column: "Name",
                value: "Sweet (QQ)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 242,
                column: "Name",
                value: "Tiggo (T11)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 243,
                column: "Name",
                value: "Tiggo 2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 244,
                column: "Name",
                value: "Tiggo 2 Pro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 245,
                column: "Name",
                value: "Tiggo 3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 246,
                column: "Name",
                value: "Tiggo 5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 247,
                column: "Name",
                value: "Tiggo 7 Pro ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 52, "Tiggo 8 Pro e+" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 249,
                column: "Name",
                value: "Aveo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 250,
                column: "Name",
                value: "Blazer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 251,
                column: "Name",
                value: "Camaro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 252,
                column: "Name",
                value: "Captiva");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 253,
                column: "Name",
                value: "Cavalier");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 254,
                column: "Name",
                value: "Cobalt");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 255,
                column: "Name",
                value: "Colorado");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 256,
                column: "Name",
                value: "Cruze");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 257,
                column: "Name",
                value: "Damas");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 258,
                column: "Name",
                value: "Epica");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 259,
                column: "Name",
                value: "Equinox");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 260,
                column: "Name",
                value: "Evanda");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 261,
                column: "Name",
                value: "Labo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 262,
                column: "Name",
                value: "Lacetti");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 263,
                column: "Name",
                value: "Malibu");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 264,
                column: "Name",
                value: "Matiz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 265,
                column: "Name",
                value: "Menlo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 266,
                column: "Name",
                value: "Nexia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 267,
                column: "Name",
                value: "Niva");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 268,
                column: "Name",
                value: "Onix");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 269,
                column: "Name",
                value: "Orlando");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 270,
                column: "Name",
                value: "Rezzo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 271,
                column: "Name",
                value: "Spark");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 272,
                column: "Name",
                value: "Tahoe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 273,
                column: "Name",
                value: "Tracker");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 274,
                column: "Name",
                value: "TrailBlazer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 275,
                column: "Name",
                value: "Traverse");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 276,
                column: "Name",
                value: "Trax");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 277,
                column: "Name",
                value: "Venture");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 41, "Volt" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 279,
                column: "Name",
                value: "200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 280,
                column: "Name",
                value: "300C");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 281,
                column: "Name",
                value: "Crossfire");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 282,
                column: "Name",
                value: "Intrepid");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 10, "Pacifica" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 284,
                column: "Name",
                value: "C-Elysee");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 285,
                column: "Name",
                value: "C4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 286,
                column: "Name",
                value: "C4 Picasso");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 287,
                column: "Name",
                value: "C5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 288,
                column: "Name",
                value: "DS3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 289,
                column: "Name",
                value: "Jumper");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 27, "Nemo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 291,
                column: "Name",
                value: "Lodgy");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 292,
                column: "Name",
                value: "Logan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 76, "Sandero" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 180, "City Leading" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 295,
                column: "Name",
                value: "Ace (Super Salon)");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 296,
                column: "Name",
                value: "BS090");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 297,
                column: "Name",
                value: "Damas");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 298,
                column: "Name",
                value: "Espero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 299,
                column: "Name",
                value: "Gentra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 300,
                column: "Name",
                value: "Lanos");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 301,
                column: "Name",
                value: "Leganza");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 302,
                column: "Name",
                value: "Matiz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 303,
                column: "Name",
                value: "Nexia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 304,
                column: "Name",
                value: "Nubira");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 305,
                column: "Name",
                value: "Prince");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 11, "Racer" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 307,
                column: "Name",
                value: "105 XF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 308,
                column: "Name",
                value: "75 CF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 309,
                column: "Name",
                value: "85 CF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 310,
                column: "Name",
                value: "95 XF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 311,
                column: "Name",
                value: "LF 55.220");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 91, "XF 460 FT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 313,
                column: "Name",
                value: "Feroza");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 66, "Terios" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 148, "DY150-12" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 316,
                column: "Name",
                value: "C-32");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 317,
                column: "Name",
                value: "C-32 S");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 318,
                column: "Name",
                value: "C-35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 319,
                column: "Name",
                value: "C-37");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 320,
                column: "Name",
                value: "D51");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 321,
                column: "Name",
                value: "Glory 330");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 322,
                column: "Name",
                value: "Glory 330 S");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 405, "Glory 330 S Cargo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 324,
                column: "Name",
                value: "11");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 162, "K-750" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 326,
                column: "Name",
                value: "Caliber");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 327,
                column: "Name",
                value: "Challenger");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 328,
                column: "Name",
                value: "Charger");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 329,
                column: "Name",
                value: "Durango");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 330,
                column: "Name",
                value: "Journey");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 331,
                column: "Name",
                value: "Ram");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 332,
                column: "Name",
                value: "Stratus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 60, "Viper" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 334,
                column: "Name",
                value: "EQ1020TF");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 335,
                column: "Name",
                value: "Fengshen A30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 336,
                column: "Name",
                value: "Fengshen S30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 117, "Rich" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 338,
                column: "Name",
                value: "1100 EVO Diesel");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 339,
                column: "Name",
                value: "848 EVO");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 340,
                column: "Name",
                value: "848 EVO Corse");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 341,
                column: "Name",
                value: "Diavel Carbon");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 342,
                column: "Name",
                value: "Monster 1200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 343,
                column: "Name",
                value: "Monster 796");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 344,
                column: "Name",
                value: "Panigale V2	");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 147, "Panigale V4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 346,
                column: "Name",
                value: "Bestune B30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 347,
                column: "Name",
                value: "Besturn B70");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 348,
                column: "Name",
                value: "Besturn X80");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 349,
                column: "Name",
                value: "CA5013");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 79, "Oley" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 351,
                column: "Name",
                value: "500");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 352,
                column: "Name",
                value: "500C");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 353,
                column: "Name",
                value: "500L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 354,
                column: "Name",
                value: "Albea");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 355,
                column: "Name",
                value: "Coupe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 356,
                column: "Name",
                value: "Doblo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 357,
                column: "Name",
                value: "Ducato");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 358,
                column: "Name",
                value: "Fiorino");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 359,
                column: "Name",
                value: "Linea");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 360,
                column: "Name",
                value: "Panda");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 361,
                column: "Name",
                value: "Punto");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 362,
                column: "Name",
                value: "Sedici");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 363,
                column: "Name",
                value: "Stilo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 37, "Tempra" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 37, "Uno" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 366,
                column: "Name",
                value: "Bronco Sport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 367,
                column: "Name",
                value: "C-MAX");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 368,
                column: "Name",
                value: "Cargo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 369,
                column: "Name",
                value: "Contour");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 370,
                column: "Name",
                value: "Cougar");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 371,
                column: "Name",
                value: "Ecosport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 372,
                column: "Name",
                value: "Edge");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 373,
                column: "Name",
                value: "Escape");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 374,
                column: "Name",
                value: "Escort");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 375,
                column: "Name",
                value: "Explorer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 376,
                column: "Name",
                value: "F-150");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 377,
                column: "Name",
                value: "Fiesta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 378,
                column: "Name",
                value: "Focus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 379,
                column: "Name",
                value: "Fusion");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 380,
                column: "Name",
                value: "Galaxy");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 381,
                column: "Name",
                value: "Ka");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 382,
                column: "Name",
                value: "Kuga");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 383,
                column: "Name",
                value: "Maverick");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 384,
                column: "Name",
                value: "Mondeo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 385,
                column: "Name",
                value: "Mustang");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 386,
                column: "Name",
                value: "Mustang Mach-E");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 387,
                column: "Name",
                value: "Puma");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 388,
                column: "Name",
                value: "Ranger");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 389,
                column: "Name",
                value: "S-MAX");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 390,
                column: "Name",
                value: "Scorpio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 391,
                column: "Name",
                value: "Taurus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 392,
                column: "Name",
                value: "Tourneo Connect");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 2, "Tourneo Custom" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 2, "Transit" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 395,
                column: "Name",
                value: "Aumark TX");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 396,
                column: "Name",
                value: "BJ6486B1DBA-2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 49, "Forland" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 49, "Ollin" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 159, "Sport G 250R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 400,
                column: "Name",
                value: "GA5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 401,
                column: "Name",
                value: "GM8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 175, "GS4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 175, "GS5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 404,
                column: "Name",
                value: "12 ЗИМ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 405,
                column: "Name",
                value: "13");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 406,
                column: "Name",
                value: "221717");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 407,
                column: "Name",
                value: "231073");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 408,
                column: "Name",
                value: "24");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 409,
                column: "Name",
                value: "24-02");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 410,
                column: "Name",
                value: "24-10");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 411,
                column: "Name",
                value: "24-102");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 412,
                column: "Name",
                value: "2705");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 413,
                column: "Name",
                value: "2705-757");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 414,
                column: "Name",
                value: "2705-777");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 415,
                column: "Name",
                value: "27057");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 416,
                column: "Name",
                value: "27527-745");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 417,
                column: "Name",
                value: "2757");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 418,
                column: "Name",
                value: "3102");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 419,
                column: "Name",
                value: "31029");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 420,
                column: "Name",
                value: "3110");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 421,
                column: "Name",
                value: "31105");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 422,
                column: "Name",
                value: "3111");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 423,
                column: "Name",
                value: "32212");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 424,
                column: "Name",
                value: "322173");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 425,
                column: "Name",
                value: "3302-288");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 426,
                column: "Name",
                value: "3302-744");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 427,
                column: "Name",
                value: "330200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 428,
                column: "Name",
                value: "330202-740");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 429,
                column: "Name",
                value: "33021");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 430,
                column: "Name",
                value: "33023-744");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 431,
                column: "Name",
                value: "330232-744");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 432,
                column: "Name",
                value: "33027");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 433,
                column: "Name",
                value: "3307");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 434,
                column: "Name",
                value: "3308");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 435,
                column: "Name",
                value: "33098-837");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 436,
                column: "Name",
                value: "37053C");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 437,
                column: "Name",
                value: "52");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 438,
                column: "Name",
                value: "53");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 439,
                column: "Name",
                value: "66");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 440,
                column: "Name",
                value: "69");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 441,
                column: "Name",
                value: "A21R22-03");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 442,
                column: "Name",
                value: "Biznes 330273");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 443,
                column: "Name",
                value: "C41R13");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 444,
                column: "Name",
                value: "C41R92");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 445,
                column: "Name",
                value: "C45R02");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 446,
                column: "Name",
                value: "Gazon C41R33");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 447,
                column: "Name",
                value: "M-1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 448,
                column: "Name",
                value: "M-20 Pobeda");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 449,
                column: "Name",
                value: "M-21");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 450,
                column: "Name",
                value: "NEXT A68R52 CITY LINE");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 451,
                column: "Name",
                value: "Next A21R22-30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 452,
                column: "Name",
                value: "Next A21R32-30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 453,
                column: "Name",
                value: "Next A22R32");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 454,
                column: "Name",
                value: "Next A31R22");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 455,
                column: "Name",
                value: "Next A32R32-40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 456,
                column: "Name",
                value: "Next A65R52");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 457,
                column: "Name",
                value: "Next C41RB3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 458,
                column: "Name",
                value: "Next Sidney A32R32-40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 21, "Next А31R32" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 21, "Siber" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 21, "Sobol" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 462,
                column: "Name",
                value: "Atlas Pro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 463,
                column: "Name",
                value: "CK");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 464,
                column: "Name",
                value: "Coolray");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 465,
                column: "Name",
                value: "Emgrand");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 466,
                column: "Name",
                value: "Emgrand X7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 467,
                column: "Name",
                value: "MK");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 468,
                column: "Name",
                value: "Monjaro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Okavango" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "TX4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 72, "Tugella" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 471, 72, "Tugella" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 471, 72, "Tugella S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 376, "G80" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 475,
                column: "Name",
                value: "Acadia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 476,
                column: "Name",
                value: "Jimmy");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 82, "Savana" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 82, "Terrain" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 82, "Yukon" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 480,
                column: "Name",
                value: "Hover H3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 481,
                column: "Name",
                value: "Hover H5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 482,
                column: "Name",
                value: "Hover H6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 483,
                column: "Name",
                value: "Hover M2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 484,
                column: "Name",
                value: "Hover M4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 485,
                column: "Name",
                value: "Pegasus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 50, "Voleex C30" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 50, "Voleex C50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 50, "Wingle" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 383, "8S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 142, "HJ110-2C" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 142, "HJ125-18" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 142, "HJ150-9A" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 493,
                column: "Name",
                value: "FXDR");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 494,
                column: "Name",
                value: "Softail Fat Boy");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 495,
                column: "Name",
                value: "Sportster Custom 1200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 496,
                column: "Name",
                value: "Sportster Forty Eight");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 497,
                column: "Name",
                value: "Street Rod");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 498,
                column: "Name",
                value: "Touring Electra Glide");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 140, "XL 1200 NS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 140, "XL883N Sportster Iron 883" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 140, "XR1200X" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 502,
                column: "Name",
                value: "Dargo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 503,
                column: "Name",
                value: "F7x");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 504,
                column: "Name",
                value: "H2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 505,
                column: "Name",
                value: "H6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 242, "H6 GT" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 242, "H9" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 242, "Jolion" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 509,
                column: "Name",
                value: "Accord");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 510,
                column: "Name",
                value: "CR-V");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 511,
                column: "Name",
                value: "City");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 512,
                column: "Name",
                value: "Civic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 513,
                column: "Name",
                value: "Element");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Fit" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "HR-V" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Honda Moto" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 516, "CB 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 516, "CBR 600" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 516, "Giorno" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 516, "H’ness CB350 DLX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 516, "VTX 1300 R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 522,
                column: "Name",
                value: "Insight");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 523,
                column: "Name",
                value: "M-NV");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 524,
                column: "Name",
                value: "Odyssey");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 525,
                column: "Name",
                value: "Pilot");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 526,
                column: "Name",
                value: "Ridgeline");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 12, "e:NP1" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 12, "e:NS1" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 529,
                column: "Name",
                value: "E-HS9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 530,
                column: "Name",
                value: "H9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 388, "HS5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 388, "HS7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 533,
                column: "Name",
                value: "371");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 110, "A7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 110, "Sinotruk" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 409, "Neta U" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 409, "Neta V" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 13, "H2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 13, "H3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 540,
                column: "Name",
                value: "Accent");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 541,
                column: "Name",
                value: "Azera");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 542,
                column: "Name",
                value: "Chorus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 543,
                column: "Name",
                value: "County");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 544,
                column: "Name",
                value: "Coupe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 545,
                column: "Name",
                value: "Creta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 546,
                column: "Name",
                value: "Elantra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 547,
                column: "Name",
                value: "Equus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 548,
                column: "Name",
                value: "Excel");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 549,
                column: "Name",
                value: "Galloper");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 550,
                column: "Name",
                value: "Genesis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 551,
                column: "Name",
                value: "Genesis Coupe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 552,
                column: "Name",
                value: "Getz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 553,
                column: "Name",
                value: "Grand Santa Fe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 554,
                column: "Name",
                value: "Grandeur");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 555,
                column: "Name",
                value: "H 100");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 556,
                column: "Name",
                value: "H 350");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 557,
                column: "Name",
                value: "H-1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 558,
                column: "Name",
                value: "HD-35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 559,
                column: "Name",
                value: "HD-45");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 560,
                column: "Name",
                value: "HD-65");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 561,
                column: "Name",
                value: "HD-72");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 562,
                column: "Name",
                value: "IONIQ 5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 563,
                column: "Name",
                value: "IONIQ Plug-in-Hybrid");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 564,
                column: "Name",
                value: "Kona");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 565,
                column: "Name",
                value: "Matrix");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 566,
                column: "Name",
                value: "Palisade");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 567,
                column: "Name",
                value: "Santa Cruz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 568,
                column: "Name",
                value: "Santa Fe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 569,
                column: "Name",
                value: "Solaris");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 570,
                column: "Name",
                value: "Sonata");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 571,
                column: "Name",
                value: "Staria");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 572,
                column: "Name",
                value: "Super Aero City");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 573,
                column: "Name",
                value: "Terracan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 574,
                column: "Name",
                value: "Tucson");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 575,
                column: "Name",
                value: "Veloster");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 576,
                column: "Name",
                value: "Venue");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 577,
                column: "Name",
                value: "Veracruz");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 578,
                column: "Name",
                value: "i10");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 579,
                column: "Name",
                value: "i20");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 580,
                column: "Name",
                value: "i30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 581,
                column: "Name",
                value: "i40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 1, "ix35" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 1, "ix55" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 584,
                column: "Name",
                value: "2126 Oda");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 585,
                column: "Name",
                value: "2715");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 586,
                column: "Name",
                value: "2717");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "27175" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "IJ Moto" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 588, "Planeta 4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 588, 64, "Planeta 5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 588, 64, "Planeta 7" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 592,
                column: "Name",
                value: "EX-series");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 593,
                column: "Name",
                value: "EX35");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "FX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 594, "FX35" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 594, "FX37" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 594, "FX45" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 594, "FX50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "G-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 599, "G25" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 599, "G35" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 599, "G37" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 599, "G37S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "JX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 604, "JX35" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 606,
                column: "Name",
                value: "M-series");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 607,
                column: "Name",
                value: "M37S");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 608,
                column: "Name",
                value: "M45");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Q-Series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 609, "Q45" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 609, "Q50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 609, "Q50S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 609, "Q60" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 609, "Q70" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 609, "QX4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "QX-Series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 616, "QX30" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 616, "QX50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 616, "QX55" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 616, "QX56" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 616, 15, "QX60" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 616, 15, "QX70" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 616, 15, "QX70S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 616, 15, "QX80" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 116, "Runna" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 116, "Samand" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 116, "Soren" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 628,
                column: "Name",
                value: "Bogdan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 629,
                column: "Name",
                value: "Citybus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 630,
                column: "Name",
                value: "Ecobus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 631,
                column: "Name",
                value: "FSR 90 L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 632,
                column: "Name",
                value: "FVR 34 Q");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 633,
                column: "Name",
                value: "NHR 55 E");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 634,
                column: "Name",
                value: "NKR 55 E");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 635,
                column: "Name",
                value: "NKR 55 L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 636,
                column: "Name",
                value: "NKR 66 E");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 637,
                column: "Name",
                value: "NMR 77 H");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 638,
                column: "Name",
                value: "NMR 85 H");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 639,
                column: "Name",
                value: "NPR");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 640,
                column: "Name",
                value: "NPR 66 L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 641,
                column: "Name",
                value: "NPR 66 P");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 642,
                column: "Name",
                value: "NPR 75");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 643,
                column: "Name",
                value: "NPR 75 K");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 644,
                column: "Name",
                value: "NPR 75 L");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 74, "NPR75L-K" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 74, "NQR 71 PL" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 74, "Novo Lux" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 74, "Turkuaz" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 649,
                column: "Name",
                value: "35 S11");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 650,
                column: "Name",
                value: "35C13V");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 651,
                column: "Name",
                value: "35C15");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 652,
                column: "Name",
                value: "Astra HD8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 653,
                column: "Name",
                value: "Daily 30-8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 654,
                column: "Name",
                value: "Daily 35C12H");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 67, "EuroStar" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 67, "Eurotrakker Cursor" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 67, "Otoyol" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 67, "Stralis" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 659,
                column: "Name",
                value: "HFC 1040K");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 660,
                column: "Name",
                value: "HFC1020");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 661,
                column: "Name",
                value: "HFC1083K");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 662,
                column: "Name",
                value: "HFC5020K");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 663,
                column: "Name",
                value: "J5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 664,
                column: "Name",
                value: "J7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 665,
                column: "Name",
                value: "JS3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 124, "JS4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 124, "JS8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 124, "T6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 124, "T8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 670,
                column: "Name",
                value: "F-Pace R");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 671,
                column: "Name",
                value: "F-Type");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 672,
                column: "Name",
                value: "F-Type R");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 673,
                column: "Name",
                value: "S-Type");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 35, "X-Type" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 35, "XE" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 35, "XF" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 35, "XJ L" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 155, "350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 679,
                column: "Name",
                value: "Cherokee");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 680,
                column: "Name",
                value: "Commander");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 681,
                column: "Name",
                value: "Compass");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 682,
                column: "Name",
                value: "Gladiator");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 683,
                column: "Name",
                value: "Grand Cherokee");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 36, "Liberty" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 36, "Patriot" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 36, "Renegade" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 36, "Wrangler" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 688,
                column: "Name",
                value: "Dashing");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 384, "X70" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 384, "X70 PLUS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 384, "X90 PLUS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 384, "X95" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 337, "JS125-7F" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 235, "YY50QT-21B" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 390, "X3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 390, "X3 Pro" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 697,
                column: "Name",
                value: "4308");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 698,
                column: "Name",
                value: "43101");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 699,
                column: "Name",
                value: "5320");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 700,
                column: "Name",
                value: "53212");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 701,
                column: "Name",
                value: "53213");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 702,
                column: "Name",
                value: "53215");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 703,
                column: "Name",
                value: "53229");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 704,
                column: "Name",
                value: "5410");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 705,
                column: "Name",
                value: "54115");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 706,
                column: "Name",
                value: "5511");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 707,
                column: "Name",
                value: "55111");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 90, "55115" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 90, "65115" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 90, "6520" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 90, "65201" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 406, "Nev 50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 420, "Dolphin" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 714,
                column: "Name",
                value: "Ninja 650");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 715,
                column: "Name",
                value: "Ninja ZX-10R");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 716,
                column: "Name",
                value: "Ninja ZX-14");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 139, "VN 1700 Vulcan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 139, "Versys 650" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 139, "Z650" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 139, "ZX-6R" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 374, "T4 ENDURO" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 282, "LX" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 282, "SD" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 724,
                column: "Name",
                value: "Avella");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 725,
                column: "Name",
                value: "Besta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 726,
                column: "Name",
                value: "Bongo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 727,
                column: "Name",
                value: "Cadenza");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 728,
                column: "Name",
                value: "Carens");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 729,
                column: "Name",
                value: "Carnival");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 730,
                column: "Name",
                value: "Ceed");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 731,
                column: "Name",
                value: "Ceed SW");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 732,
                column: "Name",
                value: "Cerato");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 733,
                column: "Name",
                value: "Cerato Koup");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 734,
                column: "Name",
                value: "Clarus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 735,
                column: "Name",
                value: "Credos");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 736,
                column: "Name",
                value: "EV6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 737,
                column: "Name",
                value: "K2700");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 738,
                column: "Name",
                value: "K3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 739,
                column: "Name",
                value: "K5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 740,
                column: "Name",
                value: "K7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 741,
                column: "Name",
                value: "K8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 742,
                column: "Name",
                value: "Magentis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 743,
                column: "Name",
                value: "Mohave");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 744,
                column: "Name",
                value: "Morning");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 745,
                column: "Name",
                value: "Niro");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 746,
                column: "Name",
                value: "Optima");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 747,
                column: "Name",
                value: "Picanto");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 748,
                column: "Name",
                value: "Pregio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 749,
                column: "Name",
                value: "Pride");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 750,
                column: "Name",
                value: "ProCeed");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 751,
                column: "Name",
                value: "Quoris");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 752,
                column: "Name",
                value: "Rio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 753,
                column: "Name",
                value: "Rio X-Line");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 754,
                column: "Name",
                value: "Seltos");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 755,
                column: "Name",
                value: "Shuma");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 756,
                column: "Name",
                value: "Sorento");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 757,
                column: "Name",
                value: "Soul");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 8, "Spectra" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 8, "Sportage" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 8, "Stinger" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 8, "Stonic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 141, "690 Duke" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 141, "RC 390" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 332, "Dragon 50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 332, "Sniper 50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 332, "X-boss" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 767,
                column: "Name",
                value: "2101");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 768,
                column: "Name",
                value: "21011");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 769,
                column: "Name",
                value: "21013");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 770,
                column: "Name",
                value: "2102");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 771,
                column: "Name",
                value: "2103");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 772,
                column: "Name",
                value: "2104");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 773,
                column: "Name",
                value: "21045");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 774,
                column: "Name",
                value: "2105");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 775,
                column: "Name",
                value: "2106");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 776,
                column: "Name",
                value: "2107");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 777,
                column: "Name",
                value: "2108");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 778,
                column: "Name",
                value: "2109");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 779,
                column: "Name",
                value: "21099");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 780,
                column: "Name",
                value: "2110");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 781,
                column: "Name",
                value: "21103");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 782,
                column: "Name",
                value: "2111");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 783,
                column: "Name",
                value: "2112");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 784,
                column: "Name",
                value: "21123");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 785,
                column: "Name",
                value: "2113");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 786,
                column: "Name",
                value: "2114");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 787,
                column: "Name",
                value: "2115");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Granta" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Kalina" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 790,
                column: "Name",
                value: "Largus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 790, "Largus" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 790, "Largus Cross" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 793,
                column: "Name",
                value: "Niva");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 794,
                column: "Name",
                value: "Niva Bronto");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 795,
                column: "Name",
                value: "Niva Travel");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Oka" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Priora" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Vesta" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 798, "Vesta" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 798, "Vesta Cross" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 798, "Vesta SW" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 798, 5, "Vesta SW Cross" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 5, "XRAY" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 803, 5, "XRAY" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 43, "Aventador" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 806,
                column: "Name",
                value: "Defender");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 807,
                column: "Name",
                value: "Discovery");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 808,
                column: "Name",
                value: "Discovery Sport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 809,
                column: "Name",
                value: "Freelander");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 810,
                column: "Name",
                value: "RR Evoque");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 20, "RR Sport" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 20, "RR Velar" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 20, "Range Rover" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CT-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 814, "CT 200h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "ES-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 816, "ES 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 816, "ES 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 816, "ES 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 816, "ES 300h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 816, "ES 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GS-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 822, "GS 200t" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 822, "GS 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 822, "GS 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 822, "GS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 822, "GS 430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 822, "GS 450h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 829,
                column: "Name",
                value: "GX-series");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 830,
                column: "Name",
                value: "GX 460");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 829, "GX 470" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "HS-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 832, "HS 250h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "IS-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 834, "IS 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 834, "IS 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 834, "IS 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "LS-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 838, "LS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 838, "LS 460" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 838, "LS 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "LX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 842, "LX 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 842, "LX 470" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 842, "LX 500d" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 842, "LX 570" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 842, "LX 600" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "NX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 848, "NX 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 848, "NX 200t" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 848, "NX 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 848, "NX 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 848, "NX 300h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 848, "NX 350h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "RX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 855, "RX 200t" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 855, "RX 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 855, "RX 330" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 855, "RX 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 855, "RX 450h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 14, "UX-series" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 861, 14, "UX 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 861, 14, "UX 250h" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 412, "L9" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 865,
                column: "Name",
                value: "320");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 866,
                column: "Name",
                value: "330");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 867,
                column: "Name",
                value: "520");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 868,
                column: "Name",
                value: "620");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 87, "720" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 87, "820" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 87, "X60" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 872,
                column: "Name",
                value: "Aviator");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 873,
                column: "Name",
                value: "LS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 46, "MKZ" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 46, "Navigator" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 46, "Towncar" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 103, "967" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 329, "Granite" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 329, "Mack Anthem" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 880,
                column: "Name",
                value: "10163");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 881,
                column: "Name",
                value: "19.414");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 882,
                column: "Name",
                value: "26463");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 883,
                column: "Name",
                value: "L 2000");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 884,
                column: "Name",
                value: "TGA 18.400");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 885,
                column: "Name",
                value: "TGA 18.430");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 886,
                column: "Name",
                value: "TGA 18.440");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 887,
                column: "Name",
                value: "TGA 18.480");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 888,
                column: "Name",
                value: "TGA 26.320");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 889,
                column: "Name",
                value: "TGA 33350");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 890,
                column: "Name",
                value: "TGA 440");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 891,
                column: "Name",
                value: "TGL8.150");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 112, "TGX 18.440" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 112, "TGX 18.480" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 112, "Temsa" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 895,
                column: "Name",
                value: "Ghibli");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 896,
                column: "Name",
                value: "GranTurismo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 44, "GranTurismo S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 44, "Levante" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 44, "Quattroporte" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 900,
                column: "Name",
                value: "3577");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 901,
                column: "Name",
                value: "5334");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 902,
                column: "Name",
                value: "5337");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 903,
                column: "Name",
                value: "54229");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 904,
                column: "Name",
                value: "54323");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 905,
                column: "Name",
                value: "551605");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 906,
                column: "Name",
                value: "5549");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 907,
                column: "Name",
                value: "6303");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 100, "642208" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 100, "643008" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 100, "650108 " });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 911,
                column: "Name",
                value: "2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 912,
                column: "Name",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 913,
                column: "Name",
                value: "323");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 914,
                column: "Name",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 915,
                column: "Name",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 916,
                column: "Name",
                value: "CX-30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 917,
                column: "Name",
                value: "CX-5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 918,
                column: "Name",
                value: "CX-60");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 919,
                column: "Name",
                value: "CX-7");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 920,
                column: "Name",
                value: "CX-9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 921,
                column: "Name",
                value: "MX-30");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 26, "MX-5 Miata" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 26, "RX-8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 26, "Tribute" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "170 V" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "190" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "A-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 927, "A 150" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 927, "A 160" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 927, "A 170" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 927, "A 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 927, "A 190" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 927, "A 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 927, "A 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 927, "A 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "B-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 936, "B 170" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 936, "B 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 936, "B 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "C-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 240" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 300 e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 940, "C 63 S AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CL-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 954, "CL 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 954, "CL 550" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 954, "CL 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CLA-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 958, "CLA 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 958, "CLA 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 958, "CLA 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 958, "CLA 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 958, "CLA 250 e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 958, "CLA 35 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 958, "CLA 45 S AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CLK-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 966, "CLK 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 966, "CLK 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 966, "CLK 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 966, "CLK 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "CLS-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 971, "CLS 250 CDI" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 971, "CLS 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 971, "CLS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 971, "CLS 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 971, "CLS 450 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 971, "CLS 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 971, "CLS 55 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 971, "CLS 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Citan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Commercial" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "0303" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "0403" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "1117" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "1217" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "207 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "208 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "307 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "308 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "403" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "408 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "410 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "609 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "612 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "711 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "809 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "811 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "812 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "814 D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Actros 1841" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1001,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Actros 1843" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1002,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Actros 1844" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1003,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Actros 1846" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1004,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Actros 1848" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1005,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Actros 2540" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1006,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Actros 2544" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1007,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1217" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1008,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1218" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1009,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1222" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1010,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1223" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1011,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1224" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1012,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1228" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1013,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1229" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1014,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1317" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1015,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1318" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1016,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1323" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1017,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1324" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1018,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1517" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1019,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1523" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1020,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1823" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1021,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 1828" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1022,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 2528" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1023,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 812" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1024,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 814" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1025,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 815" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1026,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 816" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1027,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 817" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1028,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 818" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1029,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 822" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1030,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Atego 917" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1031,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 1824" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1032,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 1829" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1033,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 1833" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1034,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 1840" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1035,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 1843" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1036,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 2529" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1037,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 2533" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1038,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 2533" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1039,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 2540" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1040,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 3028" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1041,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 3340" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1042,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Axor 4140" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1043,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Travego" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1044,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 981, "Vario" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1045,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "E-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1046,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1047,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "230 E" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1048,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "280 E" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1049,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1050,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1051,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1052,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1053,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 240" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1054,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1055,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 260" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1056,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 270" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1057,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1058,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 290" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1059,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1060,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 300 de" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1061,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 300 e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1062,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1063,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1064,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1065,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1066,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 450 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1067,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1068,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 53 4MATIC+ " });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1069,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1045, "E 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1070,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "EQC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1071,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1070, "EQC 400 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1072,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "EQE" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1073,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1072, "EQE 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1074,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1072, "EQE 350 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1075,
                column: "Name",
                value: "EQS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1076,
                column: "Name",
                value: "AMG EQS 53 4MATIC+");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1077,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1075, "EQS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1078,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1075, "EQS 580 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1079,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "EQV" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1080,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1079, "EQV 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1081,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "G-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1082,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1083,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1084,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1085,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1086,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1087,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1088,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 55 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1089,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 55 Brabus K8" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1090,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1081, "G 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1091,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GL-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1092,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1091, "GL 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1093,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1091, "GL 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1094,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1091, "GL 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1095,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1091, "GL 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1096,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1091, "GL 550" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1097,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1091, "GL 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1098,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1091, "GL Brabus Widestar" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1099,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLA-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1100,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1099, "GLA 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1101,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1099, "GLA 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1102,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1099, "GLA 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1103,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLB-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1104,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1103, "GLB 180" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1105,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1103, "GLB 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1106,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1103, "GLB 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1107,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1103, "GLB 35 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1108,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLC-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1109,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 200 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1110,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 200 4Matic Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1111,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1112,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 250 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1113,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1114,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 300 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1115,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 300 e 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1116,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 300 e 4Matic Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1117,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1108, "GLC 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1118,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLE-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1119,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1120,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1121,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 350 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1122,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1123,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 400 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1124,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 43 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1125,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 43 AMG Coupe " });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1126,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1127,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 450 4Matic Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1128,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 450 AMG Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1129,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 53 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1130,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 53 AMG Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1131,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1118, "GLE 63 AMG S 4Matic+ Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1132,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLK-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1133,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1132, "GLK 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1134,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1132, "GLK 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1135,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1132, "GLK 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1136,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "GLS-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1137,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1136, "GLS 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1138,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1136, "GLS 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1139,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1136, "GLS 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1140,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1136, "GLS 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1141,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1136, "GLS 580" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1142,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1136, "GLS 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1143,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "ML-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1144,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1145,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 270" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1146,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1147,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1148,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1149,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1150,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1151,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1152,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1153,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 550" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1154,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1143, "ML 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1155,
                column: "Name",
                value: "R-class");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1156,
                column: "Name",
                value: "R 280");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1157,
                column: "Name",
                value: "R 350");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1158,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "S-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1159,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "250 S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1160,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "300 SEL" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1161,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "500 SEL" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1162,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1163,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 280" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1164,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1165,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 320" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1166,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1167,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 350 d" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1168,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 350 d 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1169,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 400" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1170,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 400 d" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1171,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 400 d 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1172,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 420" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1173,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 430" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1174,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 450" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1175,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 500" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1176,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 500 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1177,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 500 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1178,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 55 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1179,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 550" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1180,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 550 e" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1181,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 560 4Matic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1182,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 560 Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1183,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 580 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1184,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 600" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1185,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 63 AMG" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1186,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1158, "S 63 AMG Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1187,
                column: "Name",
                value: "SL-class");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1188,
                column: "Name",
                value: "SL 55 AMG");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1189,
                column: "Name",
                value: "SL 63 AMG");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1190,
                column: "Name",
                value: "SLK-class");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1191,
                column: "Name",
                value: "SLK 200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1192,
                column: "Name",
                value: "SLK 230");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1193,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Sprinter" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1194,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 208" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1195,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 209" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1196,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 210" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1197,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 211" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1198,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 212" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1199,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 213" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1200,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 224" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1201,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 308" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1202,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 311" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1203,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 312" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1204,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 313" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1205,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 314" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1206,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 315" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1207,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 316" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1208,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 318" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1209,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 411" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1210,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 412" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1211,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 413" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1212,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 515" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1213,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 516" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1214,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1193, "Sprinter 524" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1215,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "V-class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1216,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1215, "V 220" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1217,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1215, "V 230" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1218,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1215, "V 250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1219,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1215, "V 300" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1220,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1215, "Viano" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1221,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Vaneo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1222,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Vito" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1223,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1224,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 108" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1225,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 109" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1226,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 110" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1227,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 111" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1228,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 112" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1229,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 113" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1230,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 114" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1231,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 115" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1232,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 116" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1233,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 119" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1234,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1222, "Vito 122" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1235,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 4, "X-Class" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1236,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1235, 4, "X 250D" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1237,
                column: "Name",
                value: "GLS 600 4MATIC");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1238,
                column: "Name",
                value: "S 400");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1239,
                column: "Name",
                value: "S 450");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1240,
                column: "Name",
                value: "S 500");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1241,
                column: "Name",
                value: "S 560");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1242,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 252, "S 580 4MATIC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1243,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 252, "S 600" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1244,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 47, "Mariner" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1245,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 47, "Mountaineer" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1246,
                column: "Name",
                value: "3");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1247,
                column: "Name",
                value: "350");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1248,
                column: "Name",
                value: "5");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1249,
                column: "Name",
                value: "6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1250,
                column: "Name",
                value: "750");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1251,
                column: "Name",
                value: "GT");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1252,
                column: "Name",
                value: "HS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1253,
                column: "Name",
                value: "RX8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1254,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 127, "ZS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1255,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 127, "ZS T" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1256,
                column: "Name",
                value: "Clubman");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1257,
                column: "Name",
                value: "Cooper");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1258,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 31, "Countryman" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1259,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 31, "One" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1260,
                column: "Name",
                value: "1.101 &quot;Kroha&quot;");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1261,
                column: "Name",
                value: "3.112.12");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1262,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 146, "D4 125" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1263,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 146, "X250" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1264,
                column: "Name",
                value: "ASX");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1265,
                column: "Name",
                value: "Airtrek");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1266,
                column: "Name",
                value: "Attrage");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1267,
                column: "Name",
                value: "Canter");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1268,
                column: "Name",
                value: "Chariot");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1269,
                column: "Name",
                value: "Eclipse Cross");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1270,
                column: "Name",
                value: "Galant");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1271,
                column: "Name",
                value: "Grandis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1272,
                column: "Name",
                value: "L200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1273,
                column: "Name",
                value: "L300");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1274,
                column: "Name",
                value: "Lancer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1275,
                column: "Name",
                value: "Magna");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1276,
                column: "Name",
                value: "Mirage");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1277,
                column: "Name",
                value: "Montero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1278,
                column: "Name",
                value: "Nativa");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1279,
                column: "Name",
                value: "Outlander");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1280,
                column: "Name",
                value: "Outlander Sport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1281,
                column: "Name",
                value: "Pajero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1282,
                column: "Name",
                value: "Pajero Pinin");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1283,
                column: "Name",
                value: "Pajero Sport");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1284,
                column: "Name",
                value: "Pajero io");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1285,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 6, "Rosa" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1286,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 6, "Xpander" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1287,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 286, "50 Revival" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1288,
                column: "Name",
                value: "2140");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1289,
                column: "Name",
                value: "2141");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1290,
                column: "Name",
                value: "2715");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1291,
                column: "Name",
                value: "400");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1292,
                column: "Name",
                value: "401");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1293,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 81, "408" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1294,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 81, "412" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1295,
                column: "Name",
                value: "V100");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1296,
                column: "Name",
                value: "V100 Mandello");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1297,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 416, "V9" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1298,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1297, 416, "V9 Bobber" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1299,
                column: "Name",
                value: "Muravey- 2 01");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1300,
                column: "Name",
                value: "Muravey- 2 02");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1301,
                column: "Name",
                value: "Muravey- 2 03");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1302,
                column: "Name",
                value: "TG200");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1303,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 243, "TGA200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1304,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 243, "TGA200-01P" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1305,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 158, "Rivale" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1306,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 324, "48-2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1307,
                column: "Name",
                value: "Almera");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1308,
                column: "Name",
                value: "Altima");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1309,
                column: "Name",
                value: "Armada");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1310,
                column: "Name",
                value: "Bluebird");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1311,
                column: "Name",
                value: "Bolero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1312,
                column: "Name",
                value: "GT-R");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1313,
                column: "Name",
                value: "Juke");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1314,
                column: "Name",
                value: "Kicks");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1315,
                column: "Name",
                value: "Leaf");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1316,
                column: "Name",
                value: "March");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1317,
                column: "Name",
                value: "Maxima");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1318,
                column: "Name",
                value: "Micra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1319,
                column: "Name",
                value: "Murano");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1320,
                column: "Name",
                value: "Navara");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1321,
                column: "Name",
                value: "Note");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1322,
                column: "Name",
                value: "Pathfinder");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1323,
                column: "Name",
                value: "Patrol");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1324,
                column: "Name",
                value: "Primera");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1325,
                column: "Name",
                value: "Qashqai");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1326,
                column: "Name",
                value: "Rogue");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1327,
                column: "Name",
                value: "Sentra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1328,
                column: "Name",
                value: "Serena");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1329,
                column: "Name",
                value: "Sunny");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1330,
                column: "Name",
                value: "Teana");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1331,
                column: "Name",
                value: "Terrano");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1332,
                column: "Name",
                value: "Tiida");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1333,
                column: "Name",
                value: "Urvan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1334,
                column: "Name",
                value: "Versa");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1335,
                column: "Name",
                value: "Wingroad");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1336,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 7, "X-Trail" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1337,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 7, "Xterra" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1338,
                column: "Name",
                value: "Agila");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1339,
                column: "Name",
                value: "Antara");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1340,
                column: "Name",
                value: "Astra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1341,
                column: "Name",
                value: "Combo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1342,
                column: "Name",
                value: "Corsa");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1343,
                column: "Name",
                value: "Crossland X");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1344,
                column: "Name",
                value: "Frontera");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1345,
                column: "Name",
                value: "Grandland X");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1346,
                column: "Name",
                value: "Insignia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1347,
                column: "Name",
                value: "Kadett");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1348,
                column: "Name",
                value: "Meriva");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1349,
                column: "Name",
                value: "Mokka");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1350,
                column: "Name",
                value: "Mokka X");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1351,
                column: "Name",
                value: "Omega");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1352,
                column: "Name",
                value: "Signum");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1353,
                column: "Name",
                value: "Sintra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1354,
                column: "Name",
                value: "Tigra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1355,
                column: "Name",
                value: "Vectra");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1356,
                column: "Name",
                value: "Vita");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1357,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 29, "Vivaro" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1358,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 29, "Zafira" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1359,
                column: "Name",
                value: "32054");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1360,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 114, "4234" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1361,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 114, "672" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1362,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "2008" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1363,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1362, "2008" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1364,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1362, "e-2008" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1365,
                column: "Name",
                value: "206");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1366,
                column: "Name",
                value: "207");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1367,
                column: "Name",
                value: "3008");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1368,
                column: "Name",
                value: "301");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1369,
                column: "Name",
                value: "307");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1370,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "307 CC" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1371,
                column: "Name",
                value: "308");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1372,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1371, "308" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1373,
                column: "Name",
                value: "405");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1374,
                column: "Name",
                value: "406");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1375,
                column: "Name",
                value: "407");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1376,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "5008" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1377,
                column: "Name",
                value: "508");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1378,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1377, "508" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1379,
                column: "Name",
                value: "607");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1380,
                column: "Name",
                value: "Boxer");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1381,
                column: "Name",
                value: "Pars");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1382,
                column: "Name",
                value: "Partner");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1383,
                column: "Name",
                value: "RCZ");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1384,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 16, "Rifter" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1385,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 16, "Traveller" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1386,
                column: "Name",
                value: "GEM");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1387,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1386, "GEM e4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1388,
                column: "Name",
                value: "RZR S 1000");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1389,
                column: "Name",
                value: "Sportsman 570");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1390,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 247, "Sportsman 850" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1391,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 247, "Sportsman Touring 850 SP" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1392,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { null, 396, "2" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1393,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "718" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1394,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1393, "718 Boxster" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1395,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1393, "718 Cayman" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1396,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "911" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1397,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1396, "911 Carrera" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1398,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1396, "911 Carrera 4S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1399,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1396, "911 Carrera S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1400,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "924" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1401,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Cayenne" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1402,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1403,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1404,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne E-Hybrid" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1405,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne E-hybrid Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1406,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne GTS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1407,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne GTS Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1408,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1409,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne Turbo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1410,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne Turbo GT Coupe" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1411,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1401, "Cayenne Turbo S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1412,
                column: "Name",
                value: "Cayman");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1413,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Cayman S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1414,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Macan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1415,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1414, "Macan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1416,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1414, "Macan S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1417,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Panamera" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1418,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1419,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera 4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1420,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera 4 Sport Turismo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1421,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera 4S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1422,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera 4S E-hybrid" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1423,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera GTS" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1424,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera S E-Hybrid" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1425,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera Turbo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1426,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera Turbo Executive" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1427,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { 1417, "Panamera Turbo S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1428,
                columns: new[] { "BaseModelId", "Name" },
                values: new object[] { null, "Taycan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1429,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1428, 32, "Taycan" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1430,
                columns: new[] { "BaseModelId", "BrandId", "Name" },
                values: new object[] { 1428, 32, "Taycan 4S" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1431,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 105, "22031" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1432,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 272, "Nexia R3" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1433,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 272, "R4" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1434,
                column: "Name",
                value: "12 Toros");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1435,
                column: "Name",
                value: "19");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1436,
                column: "Name",
                value: "9");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1437,
                column: "Name",
                value: "Arkana");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1438,
                column: "Name",
                value: "Clio");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1439,
                column: "Name",
                value: "Dokker");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1440,
                column: "Name",
                value: "Duster");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1441,
                column: "Name",
                value: "Espace");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1442,
                column: "Name",
                value: "Fluence");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1443,
                column: "Name",
                value: "Grand Scenic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1444,
                column: "Name",
                value: "Kangoo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1445,
                column: "Name",
                value: "Kaptur");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1446,
                column: "Name",
                value: "Koleos");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1447,
                column: "Name",
                value: "Laguna");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1448,
                column: "Name",
                value: "Logan");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1449,
                column: "Name",
                value: "Magnum");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1450,
                column: "Name",
                value: "Master");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1451,
                column: "Name",
                value: "Megane");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1452,
                column: "Name",
                value: "Megane Scenic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1453,
                column: "Name",
                value: "Modus");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1454,
                column: "Name",
                value: "Premium 250");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1455,
                column: "Name",
                value: "Premium 420");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1456,
                column: "Name",
                value: "Sandero");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1457,
                column: "Name",
                value: "Scenic");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1458,
                column: "Name",
                value: "Symbol");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1459,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 17, "Tondar" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1460,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 17, "Trafic" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1461,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 333, "Blazer 50" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1462,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 333, "Winner 200" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1463,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 18, "Phantom" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1464,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 422, "Hunter 350" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1465,
                column: "Name",
                value: "132");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1466,
                column: "Name",
                value: "141");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1467,
                column: "Name",
                value: "Rich");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1468,
                column: "Name",
                value: "Saina");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1469,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 94, "Tiba" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1470,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 93, "SKY" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1471,
                column: "Name",
                value: "G 420");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1472,
                column: "Name",
                value: "R 420");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1473,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 108, "R 480" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1474,
                column: "Name",
                value: "Exeo");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1475,
                column: "Name",
                value: "Ibiza");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1476,
                column: "Name",
                value: "Leon");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1477,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 59, "Toledo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1478,
                column: "Name",
                value: "F2000");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1479,
                column: "Name",
                value: "F3000");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1480,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 133, "SX3314DT366" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1481,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 132, "SLG 6602" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1482,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 418, "XSJ400-6" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1483,
                column: "Name",
                value: "Fabia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1484,
                column: "Name",
                value: "Kamiq");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1485,
                column: "Name",
                value: "Karoq");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1486,
                column: "Name",
                value: "Kodiaq");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1487,
                column: "Name",
                value: "Octavia");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1488,
                column: "Name",
                value: "Rapid");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1489,
                column: "Name",
                value: "Superb");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1490,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 22, "Yeti" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1491,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 399, "ET5" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1492,
                column: "Name",
                value: "Forfour");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1493,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 61, "Fortwo" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1494,
                column: "Name",
                value: "Actyon Sports");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1495,
                column: "Name",
                value: "Chairman");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1496,
                column: "Name",
                value: "Korando");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1497,
                column: "Name",
                value: "Kyron");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1498,
                column: "Name",
                value: "Musso");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1499,
                column: "Name",
                value: "Rexton");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1500,
                column: "Name",
                value: "Rexton Sports");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1501,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 45, "Tivoli" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1502,
                column: "Name",
                value: "B9 Tribeca");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1503,
                column: "Name",
                value: "Forester");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1504,
                column: "Name",
                value: "Impreza");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1505,
                column: "Name",
                value: "Legacy");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1506,
                column: "Name",
                value: "Outback");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1507,
                column: "Name",
                value: "Tribeca");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1508,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 34, "XV" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1509,
                column: "Name",
                value: "Baleno");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1510,
                column: "Name",
                value: "Burgman");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1511,
                column: "Name",
                value: "Grand Vitara");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1512,
                column: "Name",
                value: "Ignis");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1513,
                column: "Name",
                value: "Jimny");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1655,
                column: "Name",
                value: "S80");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1656,
                column: "Name",
                value: "S90");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1657,
                column: "Name",
                value: "XC40");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1658,
                column: "Name",
                value: "XC60");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1659,
                column: "Name",
                value: "XC70");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1660,
                column: "Name",
                value: "XC90");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1661,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 417, "Free" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1662,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 404, "Mini EV" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1663,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 138, "Drag Star XVS 650" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1664,
                column: "Name",
                value: "FJR1300A ABS");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1665,
                column: "Name",
                value: "FZ 1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1666,
                column: "Name",
                value: "FZ 25");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1667,
                column: "Name",
                value: "FZ 6N");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1668,
                column: "Name",
                value: "FZ-S FI Deluxe");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1669,
                column: "Name",
                value: "FZ8");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1670,
                column: "Name",
                value: "Fazer 150");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1671,
                column: "Name",
                value: "Fazer 600N");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1672,
                column: "Name",
                value: "Fazer 600N S2");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1673,
                column: "Name",
                value: "Grizzly 700");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1674,
                column: "Name",
                value: "MT-15");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1675,
                column: "Name",
                value: "R15 V4");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1676,
                column: "Name",
                value: "R15M");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1677,
                column: "Name",
                value: "R15S");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1678,
                column: "Name",
                value: "RAY-ZR");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1679,
                column: "Name",
                value: "Ray Z 115");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1680,
                column: "Name",
                value: "V Max");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1681,
                column: "Name",
                value: "XVS1300A Midnight Star");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1682,
                column: "Name",
                value: "XVS950A Midnight Star");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1683,
                column: "Name",
                value: "YBR 125");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1684,
                column: "Name",
                value: "YZ125");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1685,
                column: "Name",
                value: "YZF-R1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1686,
                column: "Name",
                value: "YZF-R6");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1687,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 57, "965" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1688,
                column: "Name",
                value: "968M");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1689,
                column: "Name",
                value: "Sens");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1690,
                column: "Name",
                value: "Slavuta");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1691,
                column: "Name",
                value: "Tavriya");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1692,
                column: "Name",
                value: "Vida");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1693,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 403, "001" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1694,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 85, "130" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1695,
                column: "Name",
                value: "131");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1696,
                column: "Name",
                value: "431410");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1697,
                column: "Name",
                value: "431412");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1698,
                column: "Name",
                value: "431610");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1699,
                column: "Name",
                value: "4334");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1700,
                column: "Name",
                value: "5301");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1701,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 285, "Infinity" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1702,
                column: "Name",
                value: "ZII ZS200-76");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1703,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 143, "Panther ZT150-8A" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1704,
                column: "Name",
                value: "R250");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1705,
                column: "Name",
                value: "T310");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1706,
                column: "Name",
                value: "Tiger ZT150-3A");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1707,
                column: "Name",
                value: "U-125");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1708,
                column: "Name",
                value: "ZT155-G1");

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1709,
                columns: new[] { "BrandId", "Name" },
                values: new object[] { 217, "Grand Tiger" });

            migrationBuilder.UpdateData(
                table: "Models",
                keyColumn: "Id",
                keyValue: 1710,
                column: "Name",
                value: "Terralord");
        }
    }
}
