using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace proiect.Migrations
{
    public partial class moto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "moto",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    marca = table.Column<string>(nullable: true),
                    model = table.Column<string>(nullable: true),
                    pret = table.Column<decimal>(type: "decimal(6, 2)", nullable: false),
                    PublishingDate = table.Column<DateTime>(nullable: false),
                    DealerID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_moto", x => x.id);
                    table.ForeignKey(
                        name: "FK_moto_Dealer_DealerID",
                        column: x => x.DealerID,
                        principalTable: "Dealer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_moto_DealerID",
                table: "moto",
                column: "DealerID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "moto");
        }
    }
}
