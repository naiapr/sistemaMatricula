using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaMatricula.Migrations
{
    public partial class inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Aluno",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Professor",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Professor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modalidade",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Nome = table.Column<string>(nullable: true),
                    ProfessorId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modalidade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Modalidade_Professor_ProfessorId",
                        column: x => x.ProfessorId,
                        principalTable: "Professor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_ModalidadeId",
                table: "Aluno",
                column: "ModalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Modalidade_ProfessorId",
                table: "Modalidade",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Modalidade_ModalidadeId",
                table: "Aluno",
                column: "ModalidadeId",
                principalTable: "Modalidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Modalidade_ModalidadeId",
                table: "Aluno");

            migrationBuilder.DropTable(
                name: "Modalidade");

            migrationBuilder.DropTable(
                name: "Professor");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_ModalidadeId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "ModalidadeId",
                table: "Aluno");
        }
    }
}
