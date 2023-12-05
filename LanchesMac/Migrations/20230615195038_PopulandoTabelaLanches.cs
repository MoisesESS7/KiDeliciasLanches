using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KiDeliciasLanches.Migrations
{
    /// <inheritdoc />
    public partial class PopulandoTabelaLanches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Lanches(" +
                "CategoriaId,DescricaoCurta, DescricaoDetalhada," +
                "EmEstoque,ImagemThumbnailUrl,ImagemUrl," +
                "IsLanchePreferido,Nome,Preco)" +

                "VALUES(1,'Pão, hambúrger, ovo, presunto, queijo e batata palha'," +
                "'Delicioso pão de hambúrger com ovo frito; presunto e queijo de primeira qualidade acompanhado com batata palha'," +
                "1, 'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg'," +
                "'http://www.macoratti.net/Imagens/lanches/cheesesalada1.jpg'," +
                "0, 'Chesse Salada', 12.50)");

            migrationBuilder.Sql("INSERT INTO Lanches(" +
                "CategoriaId,DescricaoCurta,DescricaoDetalhada," +
                "EmEstoque,ImagemThumbnailUrl,ImagemUrl," +
                "IsLanchePreferido,Nome,Preco)" +

                " VALUES(1,'Pão, presunto, mussarela e tomate'," +
                "'Delicioso pão francês quentinho na chapa com presunto e mussarela bem servidos com tomate preparado com carinho.'," +
                "1,'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg'," +
                "'http://www.macoratti.net/Imagens/lanches/mistoquente4.jpg'," +
                "0,'Misto Quente', 8.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(" +
                "CategoriaId,DescricaoCurta,DescricaoDetalhada," +
                "EmEstoque,ImagemThumbnailUrl,ImagemUrl," +
                "IsLanchePreferido,Nome,Preco)" +

                "VALUES(1,'Pão, hambúrger, presunto, mussarela e batata palha'," +
                "'Pão de hambúrger especial co, hambúrger de nossa preparação e presunto e mussarela; acompanha batata palha.'," +
                "1,'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg'," +
                "'http://www.macoratti.net/Imagens/lanches/cheeseburger1.jpg'," +
                "0,'Chesse burger',11.00)");

            migrationBuilder.Sql("INSERT INTO Lanches(" +
                "CategoriaId,DescricaoCurta,DescricaoDetalhada," +
                "EmEstoque,ImagemThumbnailUrl,ImagemUrl," +
                "IsLanchePreferido,Nome,Preco)" +

                "VALUES(2,'Pão Integral, queijo branco, peito de peru, cenoura, alface, iorgute'," +
                "'Pão integral natural com queijo branco, peito de peru e cenoura ralada com alface picado e iorgurte natural.'," +
                "1,'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg'," +
                "'http://www.macoratti.net/Imagens/lanches/lanchenatural.jpg'," +
                "1,'Lanche Natural de Paito de peru', 15.00)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Lanches");
        }
    }
}
