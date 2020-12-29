using Microsoft.EntityFrameworkCore.Migrations;

namespace proiect.Migrations
{
    public partial class Dealer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DealerID",
                table: "masina",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Dealer",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DealerName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dealer", x => x.ID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_masina_DealerID",
                table: "masina",
                column: "DealerID");

            migrationBuilder.AddForeignKey(
                name: "FK_masina_Dealer_DealerID",
                table: "masina",
                column: "DealerID",
                principalTable: "Dealer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_masina_Dealer_DealerID",
                table: "masina");

            migrationBuilder.DropTable(
                name: "Dealer");

            migrationBuilder.DropIndex(
                name: "IX_masina_DealerID",
                table: "masina");

            migrationBuilder.DropColumn(
                name: "DealerID",
                table: "masina");
        }
    }
}
