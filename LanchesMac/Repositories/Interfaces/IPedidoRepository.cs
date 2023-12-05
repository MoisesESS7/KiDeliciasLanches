using KiDeliciasLanches.Models;

namespace KiDeliciasLanches.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        void CriarPedido(Pedido pedido);
    }
}
