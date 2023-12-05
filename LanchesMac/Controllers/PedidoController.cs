using KiDeliciasLanches.Models;
using KiDeliciasLanches.Repositories.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace KiDeliciasLanches.Controllers
{
    public class PedidoController : Controller
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly ICarrinhoCompraRepository _carrinhoCompraRepository;

        public PedidoController(IPedidoRepository pedidoRepository, ICarrinhoCompraRepository carrinhoCompraRepository)
        {
            _pedidoRepository = pedidoRepository;
            _carrinhoCompraRepository = carrinhoCompraRepository;
        }

        [HttpGet]
        [Authorize]
        public IActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        [Authorize]
        public IActionResult Checkout(Pedido pedido)
        {
            int totalItensPedido = 0;
            decimal precoTotalPedido = 0.0m;

            List<CarrinhoCompraItem> items = _carrinhoCompraRepository.GetCarrinhoCompraItens();
            _carrinhoCompraRepository.CarrinhoCompraItems = items;

            if(_carrinhoCompraRepository.CarrinhoCompraItems.Count == 0)
            {
                ModelState.AddModelError("","Seu carrinho está vazio, que tal adicionar um lanche...");
                return View(pedido);
            }

            foreach(var item in items)
            {
                totalItensPedido += item.Quantidade;
                precoTotalPedido += (item.Lanche.Preco * item.Quantidade);
            }

            pedido.TotalItensPedidos = totalItensPedido;
            pedido.PedidoTotal = precoTotalPedido;

            if(ModelState.IsValid)
            {
                _pedidoRepository.CriarPedido(pedido);
                ViewBag.CheckoutCompletoMensagem = "Obrigado pelo seu pedido :)";
                ViewBag.TotalPedido = _carrinhoCompraRepository.GetCarrinhoCompraTotal();

                _carrinhoCompraRepository.LimparCarrinho();

                return View("~/Views/Pedido/CheckoutCompleto.cshtml", pedido);
            }

            return View(pedido);
        }
    }
}
