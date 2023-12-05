using KiDeliciasLanches.Models;
using System.ComponentModel.DataAnnotations;

namespace KiDeliciasLanches.ViewModels
{
    public class PedidoDetalheViewModel
    {
        public PedidoDetalhe PedidoDetalhe { get; set; }

        [Display(Name = "Valor Total")]
        public decimal ValorTotal { get; set; }
    }
}
