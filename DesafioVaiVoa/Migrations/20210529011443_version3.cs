using Microsoft.EntityFrameworkCore.Migrations;

namespace DesafioVaiVoa.Migrations
{
    public partial class version3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Pessoa_PessoaIdPessoa",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa");

            migrationBuilder.RenameTable(
                name: "Pessoa",
                newName: "Pessoas");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas",
                column: "IdPessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Pessoas_PessoaIdPessoa",
                table: "Cards",
                column: "PessoaIdPessoa",
                principalTable: "Pessoas",
                principalColumn: "IdPessoa",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cards_Pessoas_PessoaIdPessoa",
                table: "Cards");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Pessoas",
                table: "Pessoas");

            migrationBuilder.RenameTable(
                name: "Pessoas",
                newName: "Pessoa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Pessoa",
                table: "Pessoa",
                column: "IdPessoa");

            migrationBuilder.AddForeignKey(
                name: "FK_Cards_Pessoa_PessoaIdPessoa",
                table: "Cards",
                column: "PessoaIdPessoa",
                principalTable: "Pessoa",
                principalColumn: "IdPessoa",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
