using Microsoft.EntityFrameworkCore.Migrations;

namespace SistemaMatricula.Migrations
{
    public partial class Final : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Professor",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext CHARACTER SET utf8mb4",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ModalidadeId",
                table: "Aluno",
                nullable: false,
                defaultValue: 0);

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
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "Professor",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
