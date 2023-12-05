using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KiDeliciasLanches.Models
{
    public class PedidoDetalhe
    {
        public int PedidoDetalheId { get; set; }

        [Required(ErrorMessage = "Informe  quantidade")]
        public int Quantidade { get; set; }

        [Column(TypeName ="decimal(18,2)")]
        public decimal Preco { get; set; }
        
        [Display(Name ="Produto")]
        [Required(ErrorMessage ="Informe o Produto")]
        public Lanche Lanche { get; set; }
        public int LancheId { get; set; }

        public int PedidoId { get; set; }
        public Pedido Pedido { get; set; }
    }
}
