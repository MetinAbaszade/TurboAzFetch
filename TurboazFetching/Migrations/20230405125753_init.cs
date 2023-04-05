using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TurboazFetching.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Colors",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colors", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fueltypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fueltypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Regions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Regions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Transmissions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transmissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Year",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Value = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Year", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Models",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Models", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Models_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    ModelId = table.Column<int>(type: "int", nullable: false),
                    YearId = table.Column<int>(type: "int", nullable: false),
                    RegionId = table.Column<int>(type: "int", nullable: false),
                    EngineVolume = table.Column<int>(type: "int", nullable: false),
                    HorsePower = table.Column<int>(type: "int", nullable: false),
                    FueltypeId = table.Column<int>(type: "int", nullable: false),
                    TransmissionId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Mileage = table.Column<int>(type: "int", nullable: false),
                    ColorId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CurrencyId = table.Column<int>(type: "int", nullable: false),
                    CreditAvailable = table.Column<bool>(type: "bit", nullable: false),
                    BarterAvailable = table.Column<bool>(type: "bit", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cars_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Colors_ColorId",
                        column: x => x.ColorId,
                        principalTable: "Colors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Currencies_CurrencyId",
                        column: x => x.CurrencyId,
                        principalTable: "Currencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Fueltypes_FueltypeId",
                        column: x => x.FueltypeId,
                        principalTable: "Fueltypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Models_ModelId",
                        column: x => x.ModelId,
                        principalTable: "Models",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Cars_Regions_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Regions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Transmissions_TransmissionId",
                        column: x => x.TransmissionId,
                        principalTable: "Transmissions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cars_Year_YearId",
                        column: x => x.YearId,
                        principalTable: "Year",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CarId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Images_ImageId",
                        column: x => x.ImageId,
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Colors",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Qara" },
                    { 2, "Yaş Asfalt" },
                    { 3, "Boz" },
                    { 4, "Gümüşü" },
                    { 5, "Ağ" },
                    { 6, "Bej" },
                    { 7, "Tünd qırmızı" },
                    { 8, "Qırmızı" },
                    { 9, "Çəhrayı" },
                    { 10, "Narıncı" },
                    { 11, "Qızılı" },
                    { 12, "Sarı" },
                    { 13, "Yaşıl" },
                    { 14, "Mavi" },
                    { 15, "Göy" },
                    { 16, "Bənövşəyi" },
                    { 17, "Qəhvəyi" }
                });

            migrationBuilder.InsertData(
                table: "Currencies",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "AZN" },
                    { 2, "USD" },
                    { 3, "EUR" }
                });

            migrationBuilder.InsertData(
                table: "Fueltypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Benzin" },
                    { 2, "Dizel" },
                    { 3, "Qaz" },
                    { 4, "Elektro" },
                    { 5, "Hibrid" },
                    { 6, "Plug-in Hibrid" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Ağcabədi" },
                    { 2, "Ağdam" },
                    { 3, "Ağdaş" },
                    { 4, "Ağstafa" },
                    { 5, "Ağsu" },
                    { 6, "Astara" },
                    { 7, "Babək" },
                    { 8, "Bakı" },
                    { 9, "Balakən" },
                    { 10, "Beyləqan" },
                    { 11, "Bərdə" },
                    { 12, "Biləsuvar" },
                    { 13, "Cəbrayıl" },
                    { 14, "Cəlilabad" },
                    { 15, "Culfa" },
                    { 16, "Daşkəsən" },
                    { 17, "Dəliməmmədli" },
                    { 18, "Füzuli" },
                    { 19, "Gədəbəy" },
                    { 20, "Gəncə" },
                    { 21, "Goranboy" },
                    { 22, "Göyçay" },
                    { 23, "Göygöl" },
                    { 24, "Göytəpə" },
                    { 25, "Hacıqabul" },
                    { 26, "Horadiz" },
                    { 27, "İmişli" },
                    { 28, "İsmayıllı" },
                    { 29, "Kürdəmir" },
                    { 30, "Lerik" },
                    { 31, "Lənkəran" },
                    { 32, "Masallı" },
                    { 33, "Mingəçevir" },
                    { 34, "Naftalan" },
                    { 35, "Naxçıvan" },
                    { 36, "Neftçala" },
                    { 37, "Oğuz" },
                    { 38, "Ordubad" },
                    { 39, "Qax" },
                    { 40, "Qazax" },
                    { 41, "Qəbələ" },
                    { 42, "Qobustan" },
                    { 43, "Quba" },
                    { 44, "Qusar" },
                    { 45, "Saatlı" },
                    { 46, "Sabirabad" },
                    { 47, "Şabran" },
                    { 48, "Salyan" },
                    { 49, "Şamaxı" },
                    { 50, "Samux" },
                    { 51, "Şəki" },
                    { 52, "Şəmkir" },
                    { 53, "Şərur" },
                    { 54, "Şirvan" },
                    { 55, "Siyəzən" },
                    { 56, "Sumqayıt" },
                    { 57, "Şuşa" },
                    { 58, "Tərtər" },
                    { 59, "Tovuz" },
                    { 60, "Ucar" },
                    { 61, "Xaçmaz" },
                    { 62, "Xırdalan" },
                    { 63, "Xızı" },
                    { 64, "Xudat" },
                    { 65, "Yardımlı" },
                    { 66, "Yevlax" },
                    { 67, "Zaqatala" },
                    { 68, "Zəngilan" },
                    { 69, "Zərdab" }
                });

            migrationBuilder.InsertData(
                table: "Transmissions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mexaniki" },
                    { 2, "Avtomat" },
                    { 3, "Robotlaşdırılmış" },
                    { 4, "Variator" }
                });

            migrationBuilder.InsertData(
                table: "Year",
                columns: new[] { "Id", "Value" },
                values: new object[,]
                {
                    { 1, 2023 },
                    { 2, 2022 },
                    { 3, 2021 },
                    { 4, 2020 },
                    { 5, 2019 },
                    { 6, 2018 },
                    { 7, 2017 },
                    { 8, 2016 },
                    { 9, 2015 },
                    { 10, 2014 },
                    { 11, 2013 },
                    { 12, 2012 },
                    { 13, 2011 },
                    { 14, 2010 },
                    { 15, 2009 },
                    { 16, 2008 },
                    { 17, 2007 },
                    { 18, 2006 },
                    { 19, 2005 },
                    { 20, 2004 },
                    { 21, 2003 },
                    { 22, 2002 },
                    { 23, 2001 },
                    { 24, 2000 },
                    { 25, 1999 },
                    { 26, 1998 },
                    { 27, 1997 },
                    { 28, 1996 },
                    { 29, 1995 },
                    { 30, 1994 },
                    { 31, 1993 },
                    { 32, 1992 },
                    { 33, 1991 },
                    { 34, 1990 },
                    { 35, 1989 },
                    { 36, 1988 },
                    { 37, 1987 },
                    { 38, 1986 },
                    { 39, 1985 },
                    { 40, 1984 },
                    { 41, 1983 },
                    { 42, 1982 },
                    { 43, 1981 },
                    { 44, 1980 },
                    { 45, 1979 },
                    { 46, 1978 },
                    { 47, 1977 },
                    { 48, 1976 },
                    { 49, 1975 },
                    { 50, 1974 },
                    { 51, 1973 },
                    { 52, 1972 },
                    { 53, 1971 },
                    { 54, 1970 },
                    { 55, 1969 },
                    { 56, 1968 },
                    { 57, 1967 },
                    { 58, 1966 },
                    { 59, 1965 },
                    { 60, 1964 },
                    { 61, 1963 },
                    { 62, 1962 },
                    { 63, 1961 },
                    { 64, 1960 },
                    { 65, 1959 },
                    { 66, 1958 },
                    { 67, 1957 },
                    { 68, 1956 },
                    { 69, 1955 },
                    { 70, 1954 },
                    { 71, 1953 },
                    { 72, 1952 },
                    { 73, 1951 },
                    { 74, 1950 },
                    { 75, 1949 },
                    { 76, 1948 },
                    { 77, 1947 },
                    { 78, 1946 },
                    { 79, 1945 },
                    { 80, 1944 },
                    { 81, 1943 },
                    { 82, 1942 },
                    { 83, 1941 },
                    { 84, 1940 },
                    { 85, 1939 },
                    { 86, 1938 },
                    { 87, 1937 },
                    { 88, 1936 },
                    { 89, 1935 },
                    { 90, 1934 },
                    { 91, 1933 },
                    { 92, 1932 },
                    { 93, 1931 },
                    { 94, 1930 },
                    { 95, 1929 },
                    { 96, 1928 },
                    { 97, 1927 },
                    { 98, 1926 },
                    { 99, 1925 },
                    { 100, 1924 },
                    { 101, 1923 },
                    { 102, 1922 },
                    { 103, 1921 },
                    { 104, 1920 },
                    { 105, 1919 },
                    { 106, 1918 },
                    { 107, 1917 },
                    { 108, 1916 },
                    { 109, 1915 },
                    { 110, 1914 },
                    { 111, 1913 },
                    { 112, 1912 },
                    { 113, 1911 },
                    { 114, 1910 },
                    { 115, 1909 },
                    { 116, 1908 },
                    { 117, 1907 },
                    { 118, 1906 },
                    { 119, 1905 },
                    { 120, 1904 },
                    { 121, 1903 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_BrandId",
                table: "Cars",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CategoryId",
                table: "Cars",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ColorId",
                table: "Cars",
                column: "ColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_CurrencyId",
                table: "Cars",
                column: "CurrencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_FueltypeId",
                table: "Cars",
                column: "FueltypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_ModelId",
                table: "Cars",
                column: "ModelId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_RegionId",
                table: "Cars",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_TransmissionId",
                table: "Cars",
                column: "TransmissionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cars_YearId",
                table: "Cars",
                column: "YearId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ImageId",
                table: "Categories",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Images_CarId",
                table: "Images",
                column: "CarId");

            migrationBuilder.CreateIndex(
                name: "IX_Models_BrandId",
                table: "Models",
                column: "BrandId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Brands_BrandId",
                table: "Cars");

            migrationBuilder.DropForeignKey(
                name: "FK_Models_Brands_BrandId",
                table: "Models");

            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Categories_CategoryId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "Cars");

            migrationBuilder.DropTable(
                name: "Colors");

            migrationBuilder.DropTable(
                name: "Currencies");

            migrationBuilder.DropTable(
                name: "Fueltypes");

            migrationBuilder.DropTable(
                name: "Models");

            migrationBuilder.DropTable(
                name: "Regions");

            migrationBuilder.DropTable(
                name: "Transmissions");

            migrationBuilder.DropTable(
                name: "Year");
        }
    }
}
