using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TurboazFetching.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AutoSalons_AutoSalonId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "AutoSalonId",
                table: "Cars",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AutoSalons_AutoSalonId",
                table: "Cars",
                column: "AutoSalonId",
                principalTable: "AutoSalons",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_AutoSalons_AutoSalonId",
                table: "Cars");

            migrationBuilder.AlterColumn<int>(
                name: "AutoSalonId",
                table: "Cars",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_AutoSalons_AutoSalonId",
                table: "Cars",
                column: "AutoSalonId",
                principalTable: "AutoSalons",
                principalColumn: "Id");
        }
    }
}
