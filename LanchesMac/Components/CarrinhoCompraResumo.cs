using KiDeliciasLanches.Models;
using KiDeliciasLanches.Repositories.Interfaces;
using KiDeliciasLanches.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace KiDeliciasLanches.Components
{
    public class CarrinhoCompraResumo : ViewComponent
    {
        private readonly ICarrinhoCompraRepository _carrinhoCompraRepository;

        public CarrinhoCompraResumo(ICarrinhoCompraRepository carrinhoCompraRepository)
        {
            _carrinhoCompraRepository = carrinhoCompraRepository;
        }

        public IViewComponentResult Invoke()
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
    }
}
