using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Modalidade
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome da modalidade é obrigatório")]
        [StringLength(30, ErrorMessage = "Limite máximo de 30 caracteres")]
        [Display(Name = "NOME")]
        public string Nome { get; set; }
        

        public Modalidade()
        {

        }

        public Modalidade(int id, string nome)
        {
            Id = id;
            Nome = nome;
            
        }
    }
}
