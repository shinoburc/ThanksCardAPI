using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ThanksCardServer2.Migrations
{
    public partial class AddAllModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Belongs",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: true),
                    sonzai_id = table.Column<long>(type: "bigint", nullable: false),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belongs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Templates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Template_Name = table.Column<string>(type: "text", nullable: true),
                    Template_Content = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Templates", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Titles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Title_Name = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Titles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Cd = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Password = table.Column<string>(type: "text", nullable: true),
                    Sonzai_Id = table.Column<long>(type: "bigint", nullable: false),
                    Belongs_Id = table.Column<long>(type: "bigint", nullable: false),
                    BelongsId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Employees_Belongs_BelongsId",
                        column: x => x.BelongsId,
                        principalTable: "Belongs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ThanksCards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    SenderId = table.Column<long>(type: "bigint", nullable: false),
                    DestinationId = table.Column<long>(type: "bigint", nullable: false),
                    Title_Id = table.Column<long>(type: "bigint", nullable: false),
                    TitleId = table.Column<long>(type: "bigint", nullable: true),
                    ThanksCard_Content = table.Column<string>(type: "text", nullable: true),
                    Template_Id = table.Column<long>(type: "bigint", nullable: false),
                    TemplateId = table.Column<long>(type: "bigint", nullable: true),
                    Good_Number = table.Column<long>(type: "bigint", nullable: false),
                    Alreadtread = table.Column<string>(type: "text", nullable: true),
                    sonzai_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThanksCards", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ThanksCards_Employees_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThanksCards_Employees_SenderId",
                        column: x => x.SenderId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThanksCards_Templates_TemplateId",
                        column: x => x.TemplateId,
                        principalTable: "Templates",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ThanksCards_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Midles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ThanksCard_Id = table.Column<long>(type: "bigint", nullable: false),
                    ThanksCardId = table.Column<long>(type: "bigint", nullable: true),
                    Reply_Id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Midles_ThanksCards_ThanksCardId",
                        column: x => x.ThanksCardId,
                        principalTable: "ThanksCards",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BelongsId",
                table: "Employees",
                column: "BelongsId");

            migrationBuilder.CreateIndex(
                name: "IX_Midles_ThanksCardId",
                table: "Midles",
                column: "ThanksCardId");

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_DestinationId",
                table: "ThanksCards",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_SenderId",
                table: "ThanksCards",
                column: "SenderId");

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_TemplateId",
                table: "ThanksCards",
                column: "TemplateId");

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_TitleId",
                table: "ThanksCards",
                column: "TitleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Midles");

            migrationBuilder.DropTable(
                name: "ThanksCards");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Belongs");
        }
    }
}
