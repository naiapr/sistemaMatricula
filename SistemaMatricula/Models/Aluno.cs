using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O Nome do aluno é obrigatório")]
        [StringLength(30, ErrorMessage = "Limite máximo de 30 caracteres")]
        [Display(Name = "NOME")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O CPF do aluno é obrigatório")]
        [StringLength(14, ErrorMessage = "O CPF deve conter 14 caracteres", MinimumLength = 14)]
        [Display(Name = "CPF")]        
        [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "Formato de CPF inválido")]
        [Remote("ValidaCpf", "Alunos", ErrorMessage = "CPF ja cadastrado")]
        public string Cpf { get; set; }

       [DisplayFormat(DataFormatString ="{0:F2}")]
        [Display(Name = "PESO")]
        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Formato de Peso inválido")]
        [Required(ErrorMessage = "O Peso do aluno é obrigatório")]
        public float Peso { get; set; }
        [DisplayFormat(DataFormatString = "{0:F2}")]
        [Required(ErrorMessage = "A altura do aluno é obrigatória")]
        [RegularExpression(@"^\d+\.\d{0,2}$", ErrorMessage = "Formato de Altura inválido")]
        [Display(Name = "ALTURA")]
        public float Altura { get; set; }
        [Display(Name = "MODALIDADE")]
        public int ModalidadeId { get; set; }

        public Modalidade Modalidade { get; set; }
       


        public Aluno()
        {

        }

        public Aluno(int id, string nome, string cpf, float peso, float altura, int modalidadeId, Modalidade modalidade)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Peso = peso;
            Altura = altura;
            ModalidadeId = modalidadeId;
            Modalidade = modalidade;
        }

        public double IMC(float peso, float altura)
        {
            return peso / (altura * altura);
        }
    }
}
