using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models.ViewModel
{
    public class AlunoViewModel
    {
        public int AlunoId { get; set; }
        public Aluno Aluno { get; set; }
        [Required(ErrorMessage = "O nome do aluno é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "ALUNO")]
        public string NomeAluno { get; set; }

        [Required(ErrorMessage = "O CPF do aluno é obrigatório")]
        [StringLength(14, ErrorMessage = "O CPF deve conter 14 caracteres", MinimumLength = 14)]
        [Display(Name = "CPF")]
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato de CPF inválido")]
        [Remote("ValidaCpf", "Alunos", AdditionalFields = "AlunoId", ErrorMessage = "CPF ja cadastrado")]
        //[Remote(action: "ValidaCpf", controller: "Alunos")]
        public string Cpf { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "PESO")]
        [RegularExpression(@"^(?!0\d|$)\d*(\.\d{1,2})?$", ErrorMessage = "Formato de Peso inválido")]
        [Required(ErrorMessage = "O Peso do aluno é obrigatório")]
        public float Peso { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "ALTURA")]
        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Formato de Altura inválido")]
        [Required(ErrorMessage = "A Altura do aluno é obrigatório")]
        public float Altura { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Display(Name = "IMC")]
        public string AlunoIMC { get; set; }

        [Display(Name = "MODALIDADE")]
        public int IDModalidade { get; set; }

        [Display(Name = "MODALIDADE")]
        public string NomeModalidade { get; set; }


        public ICollection<Modalidade> Modalidades { get; set; }
    }
}
