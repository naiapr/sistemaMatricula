using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models
{
    public class Professor
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Modalidade> list = new List<Modalidade>();

        public Professor()
        {

        }

        public Professor(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
