using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MeuCrudMvc.Migrations
{
    /// <inheritdoc />
    public partial class Assuntos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Assunto",
                columns: table => new
                {
                    assuntoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    assunto = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assunto", x => x.assuntoId);

                    //// Exemplo de criação de chave estrangeira em uma tabela chamada "OutraTabela"
                    //table.ForeignKey(
                    //    name: "FK_Assunto",
                    //    column: x => x.assuntoId,
                    //    principalTable: "Assunto",
                    //    principalColumn: "assuntoId",
                    //    onDelete: ReferentialAction.Cascade);
                });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assunto");
        }
    }
}
