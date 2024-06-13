using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuCrudMvc.Migrations
{
    /// <inheritdoc />
    public partial class Contatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contato",
                columns: table => new
                {
                    contatoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assuntoId = table.Column<int>(type: "int", nullable: true),
                    nome = table.Column<string>(type: "varchar(70)", nullable: true),
                    email = table.Column<string>(type: "varchar(80)", nullable: true),
                    telefone = table.Column<string>(type: "varchar(14)", nullable: true),
                    //empresa = table.Column<string>(type: "varchar(50)", nullable: true),
                    mensagem = table.Column<string>(type: "varchar(300)", nullable: true),
                    dataEnvio = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contato", x => x.contatoId);

                    // Exemplo de criação de chave estrangeira em uma tabela chamada "OutraTabela"
                    table.ForeignKey(
                        name: "FK_Assunto",
                        column: x => x.assuntoId,
                        principalTable: "Assunto",
                        principalColumn: "assuntoId",
                        onDelete: ReferentialAction.Cascade);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contato");
        }
    }
}
