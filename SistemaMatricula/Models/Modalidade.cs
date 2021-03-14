using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Modalidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Professor Professor { get; set; }
        
        public List <Aluno> list  = new List<Aluno>();

        public Modalidade()
        {

        }

        public Modalidade(int id, string nome, Professor professor)
        {
            Id = id;
            Nome = nome;
            Professor = professor;
        }
    }
}
