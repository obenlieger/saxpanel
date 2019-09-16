using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace saxpanel.Data.Migrations
{
    public partial class saxcompose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SaxCompose",
                columns: table => new
                {
                    SaxComposeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    DockerComposeFile = table.Column<string>(nullable: true),
                    initialized = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaxCompose", x => x.SaxComposeId);
                });

            migrationBuilder.CreateTable(
                name: "SaxTable",
                columns: table => new
                {
                    SaxServiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    installed = table.Column<bool>(nullable: false),
                    SaxComposeId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SaxTable", x => x.SaxServiceId);
                    table.ForeignKey(
                        name: "FK_SaxTable_SaxCompose_SaxComposeId",
                        column: x => x.SaxComposeId,
                        principalTable: "SaxCompose",
                        principalColumn: "SaxComposeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SaxTable_SaxComposeId",
                table: "SaxTable",
                column: "SaxComposeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SaxTable");

            migrationBuilder.DropTable(
                name: "SaxCompose");
        }
    }
}
