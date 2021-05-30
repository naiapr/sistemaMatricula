using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Estoque
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome do item é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "NOME")]
        public string Nome { get; set; }
        [Display(Name = "PREÇO")]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public float Preco { get; set; }
        [Display(Name = "QUANTIDADE")]
        public int Quantidade { get; set; }
        public Setor Setor{ get; set; }
        [Display(Name = "SETOR")]
        public int SetorId { get; set; }

        public Estoque()
        {

        }

        public Estoque(int id, string nome, float preco, int quantidade, Setor setor, int setorId)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
            Setor = setor;
            SetorId = setorId;
        }

      
    }

    
}
