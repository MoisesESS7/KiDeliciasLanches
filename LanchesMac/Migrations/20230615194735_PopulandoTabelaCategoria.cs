using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KiDeliciasLanches.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoTabelaCategoria : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CATEGORIAS (CategoriaNome, Descricao)" +
                "VALUES ('Normal','Lanche feito com ingradientes normais')");

            migrationBuilder.Sql("INSERT INTO CATEGORIAS (CategoriaNome, Descricao)" +
                "VALUES ('Natural','Lanche feito com ingredientes integrais e naturais')");

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Categorias");
        }
    }
}
