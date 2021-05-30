using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Setor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do setor é obrigatório")]
        [Display(Name = "NOME")]
        [StringLength(30, ErrorMessage = "Limite máximo de 30 caracteres")]
        public string Nome { get; set; }

        public Setor()
        {

        }

        public Setor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
