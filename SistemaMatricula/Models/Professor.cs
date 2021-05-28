using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Professor
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="O nome do professor é obrigatório")]
        [StringLength(30, ErrorMessage = "Limite máximo de 30 caracteres")]
        [Display(Name = "NOME")]
        public string Nome { get; set; }
        public Modalidade Modalidade { get; set; }
        [Display(Name = "MODALIDADE")]
        public int ModalidadeId { get; set; }

        public Professor()
        {

        }

        public Professor(int id, string nome, Modalidade modalidade)
        {
            Id = id;
            Nome = nome;
            Modalidade = modalidade;
            
        }
    }
}
