using KiDeliciasLanches.Models;
using KiDeliciasLanches.Repositories.Interfaces;
using KiDeliciasLanches.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Text;

namespace KiDeliciasLanches.Controllers
{
    [Authorize]
    public class CarrinhoCompraController : Controller
    {
        private readonly ILancheRepository _lancheRepository;

        private readonly ICarrinhoCompraRepository _carrinhoCompraRepository;

        public CarrinhoCompraController(ILancheRepository lancheRepository,
            ICarrinhoCompraRepository carrinhoCompraRepository)
        {
            _lancheRepository = lancheRepository;
            _carrinhoCompraRepository = carrinhoCompraRepository;
        }

        public IActionResult Index()
        {
            var itens = _carrinhoCompraRepository.GetCarrinhoCompraItens();
            _carrinhoCompraRepository.CarrinhoCompraItems = itens;

            var carrinhoCompraVM = new CarrinhoCompraViewModel
            {
                CarrinhoCompra = (CarrinhoCompra)_carrinhoCompraRepository,
                CarrinhoCompraTotal = _carrinhoCompraRepository.GetCarrinhoCompraTotal()
            };

            return View(carrinhoCompraVM);
        }

        public IActionResult AdicionarNoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado =
                _lancheRepository.Lanches.SingleOrDefault(x => x.LancheId == lancheId);

            if (lancheSelecionado != null)
            {
                _carrinhoCompraRepository.AdicionarAoCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }

        public IActionResult RemoverItemDoCarrinhoCompra(int lancheId)
        {
            var lancheSelecionado =
                _lancheRepository.Lanches.FirstOrDefault(x => x.LancheId == lancheId);

            if (lancheSelecionado != null)
            {
                _carrinhoCompraRepository.RemoverDoCarrinho(lancheSelecionado);
            }

            return RedirectToAction("Index");
        }

        public IActionResult LimparCarrinhoCompra()
        {
            _carrinhoCompraRepository.LimparCarrinho();
            return RedirectToAction("Index");
        }
    }
}
