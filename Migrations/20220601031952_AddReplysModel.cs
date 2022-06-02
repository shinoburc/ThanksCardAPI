using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ThanksCardServer2.Migrations
{
    public partial class AddReplysModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Replys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Sonzai_Id = table.Column<int>(type: "integer", nullable: false),
                    ThanksCardId = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Replys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Replys_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Replys_ThanksCards_ThanksCardId",
                        column: x => x.ThanksCardId,
                        principalTable: "ThanksCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Replys_EmployeeId",
                table: "Replys",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_Replys_ThanksCardId",
                table: "Replys",
                column: "ThanksCardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Replys");
        }
    }
}
