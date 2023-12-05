using KiDeliciasLanches.Context;
using KiDeliciasLanches.Models;
using KiDeliciasLanches.Repositories.Interfaces;

namespace KiDeliciasLanches.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly AppDbContext _appDbContext;
        private readonly ICarrinhoCompraRepository _carrinhoCompraRepository;

        public PedidoRepository(AppDbContext appDbContext, ICarrinhoCompraRepository carrinhoCompraRepository)
        {
            _appDbContext = appDbContext;
            _carrinhoCompraRepository = carrinhoCompraRepository;
        }

        public void CriarPedido(Pedido pedido)
        {
            pedido.PedidoEnviado = DateTime.Now;
            _appDbContext.Pedidos.Add(pedido);
            _appDbContext.SaveChanges();

            var carrinhoCompraItens = _carrinhoCompraRepository.CarrinhoCompraItems;

            foreach(var carrinhoItem in carrinhoCompraItens)
            {
                var pedidoDetalhe = new PedidoDetalhe
                {
                    Quantidade = carrinhoItem.Quantidade,
                    LancheId = carrinhoItem.Lanche.LancheId,
                    PedidoId = pedido.PedidoId,
                    Preco = carrinhoItem.Lanche.Preco

                };

                _appDbContext.PedidoDetalhes.Add(pedidoDetalhe);
            }

            _appDbContext.SaveChanges();
        }
    }
}
