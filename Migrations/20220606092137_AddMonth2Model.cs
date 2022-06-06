using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ThanksCardAPI.Migrations
{
    public partial class AddMonth2Model : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_TemplateId",
                table: "ThanksCards",
                column: "TemplateId");

            migrationBuilder.AddForeignKey(
                name: "FK_ThanksCards_Templates_TemplateId",
                table: "ThanksCards",
                column: "TemplateId",
                principalTable: "Templates",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ThanksCards_Templates_TemplateId",
                table: "ThanksCards");

            migrationBuilder.DropIndex(
                name: "IX_ThanksCards_TemplateId",
                table: "ThanksCards");
        }
    }
}
