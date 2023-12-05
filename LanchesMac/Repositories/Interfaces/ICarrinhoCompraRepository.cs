using KiDeliciasLanches.Models;

namespace KiDeliciasLanches.Repositories.Interfaces
{
    public interface ICarrinhoCompraRepository
    {
        public List<CarrinhoCompraItem> CarrinhoCompraItems { get; set; }

        void AdicionarAoCarrinho(Lanche lanche);
        int RemoverDoCarrinho(Lanche lanche);
        List<CarrinhoCompraItem> GetCarrinhoCompraItens();
        void LimparCarrinho();
        decimal GetCarrinhoCompraTotal();
    }
}
