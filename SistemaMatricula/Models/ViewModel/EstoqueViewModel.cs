using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models.ViewModel
{
    public class EstoqueViewModel
    {
        public int EstoqueId { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Quantidade { get; set; }
        public Estoque Estoque { get; set; }
        //public double TotalItem { get; set; }
        //public double TotalEstoque { get; set; }

        public int IdSetor { get; set; }

        public string NomeSetor { get; set; }

        public ICollection<Setor> Setores { get; set; }
    }
}
