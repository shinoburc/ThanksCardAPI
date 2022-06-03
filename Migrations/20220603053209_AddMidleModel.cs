using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ThanksCardAPI.Migrations
{
    public partial class AddMidleModel : Migration
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
                    SonzaiId = table.Column<long>(type: "bigint", nullable: false),
                    Parent_Id = table.Column<long>(type: "bigint", nullable: false),
                    ParentId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Belongs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Belongs_Belongs_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Belongs",
                        principalColumn: "Id");
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
                    BelongsId = table.Column<long>(type: "bigint", nullable: true),
                    IsEmployee = table.Column<bool>(type: "boolean", nullable: false)
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
                name: "Replys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Content = table.Column<string>(type: "text", nullable: true),
                    Sonzai_Id = table.Column<int>(type: "integer", nullable: false),
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
                });

            migrationBuilder.CreateTable(
                name: "ThanksCards",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Date = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    SenderId = table.Column<long>(type: "bigint", nullable: false),
                    DestinationId = table.Column<long>(type: "bigint", nullable: false),
                    TitleId = table.Column<long>(type: "bigint", nullable: false),
                    Content = table.Column<string>(type: "text", nullable: true),
                    TemplateId = table.Column<long>(type: "bigint", nullable: false),
                    GoodNumber = table.Column<long>(type: "bigint", nullable: false),
                    Alreadyread = table.Column<string>(type: "text", nullable: true),
                    ThanksCardSonzaiId = table.Column<long>(type: "bigint", nullable: false)
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
                        name: "FK_ThanksCards_Titles_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Titles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Midles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    ThanksCardId = table.Column<long>(type: "bigint", nullable: false),
                    ReplyId = table.Column<long>(type: "bigint", nullable: false),
                    ReplyId1 = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Midles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Midles_Replys_ReplyId1",
                        column: x => x.ReplyId,
                        principalTable: "Replys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Midles_ThanksCards_ThanksCardId",
                        column: x => x.ThanksCardId,
                        principalTable: "ThanksCards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Belongs_ParentId",
                table: "Belongs",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_BelongsId",
                table: "Employees",
                column: "BelongsId");

            migrationBuilder.CreateIndex(
                name: "IX_Midles_ReplyId1",
                table: "Midles",
                column: "ReplyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Midles_ThanksCardId",
                table: "Midles",
                column: "ThanksCardId");

            migrationBuilder.CreateIndex(
                name: "IX_Replys_EmployeeId",
                table: "Replys",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_DestinationId",
                table: "ThanksCards",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_ThanksCards_SenderId",
                table: "ThanksCards",
                column: "SenderId");

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
                name: "Templates");

            migrationBuilder.DropTable(
                name: "Replys");

            migrationBuilder.DropTable(
                name: "ThanksCards");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Titles");

            migrationBuilder.DropTable(
                name: "Belongs");
        }
    }
}
