using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaMatricula.Migrations
{
    public partial class AddMigrationInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Modalidade_Professor_ProfessorId",
                table: "Modalidade");

            migrationBuilder.DropIndex(
                name: "IX_Modalidade_ProfessorId",
                table: "Modalidade");

            migrationBuilder.DropColumn(
                name: "ProfessorId",
                table: "Modalidade");

            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Professor",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Professor_ModalidadeId",
                table: "Professor",
                column: "ModalidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Professor_Modalidade_ModalidadeId",
                table: "Professor",
                column: "ModalidadeId",
                principalTable: "Modalidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Professor_Modalidade_ModalidadeId",
                table: "Professor");

            migrationBuilder.DropIndex(
                name: "IX_Professor_ModalidadeId",
                table: "Professor");

            migrationBuilder.DropColumn(
                name: "ModalidadeId",
                table: "Professor");

            migrationBuilder.AddColumn<int>(
                name: "ProfessorId",
                table: "Modalidade",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Modalidade_ProfessorId",
                table: "Modalidade",
                column: "ProfessorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Modalidade_Professor_ProfessorId",
                table: "Modalidade",
                column: "ProfessorId",
                principalTable: "Professor",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
