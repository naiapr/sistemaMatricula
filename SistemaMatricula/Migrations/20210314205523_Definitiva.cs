using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaMatricula.Migrations
{
    public partial class Definitiva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aluno_Modalidade_ModalidadeId",
                table: "Aluno");

            migrationBuilder.DropIndex(
                name: "IX_Aluno_ModalidadeId",
                table: "Aluno");

            migrationBuilder.DropColumn(
                name: "ModalidadeId",
                table: "Aluno");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Aluno",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aluno_ModalidadeId",
                table: "Aluno",
                column: "ModalidadeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aluno_Modalidade_ModalidadeId",
                table: "Aluno",
                column: "ModalidadeId",
                principalTable: "Modalidade",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
