using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public float Peso { get; set; }
        public float Altura { get; set; }

        public List <Modalidade> list = new List<Modalidade>();


        public Aluno()
        {

        }

        public Aluno(int id, string nome, string cpf, float peso, float altura)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Peso = peso;
            Altura = altura;
        }

        public double IMC(float peso, float altura)
        {
            return peso / (altura * altura);
        }
    }
}
