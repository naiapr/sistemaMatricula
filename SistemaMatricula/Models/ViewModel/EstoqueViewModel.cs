using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models.ViewModel
{
    public class EstoqueViewModel
    {
        public int EstoqueId { get; set; }
        [Required(ErrorMessage = "O nome do item é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "NOME")]

        public string Nome { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "PREÇO")]
        public float Preco { get; set; }

        [Display(Name = "QUANTIDADE")]
        public int Quantidade { get; set; }
        public Estoque Estoque { get; set; }
        //public double TotalItem { get; set; }
        //public double TotalEstoque { get; set; }
        [Display(Name = "SETOR")]
        public int IdSetor { get; set; }
        [Display(Name = "SETOR")]
        public string NomeSetor { get; set; }

        public ICollection<Setor> Setores { get; set; }
    }
}
