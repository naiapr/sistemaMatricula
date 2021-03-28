using SistemaMatricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public interface IProfessorService
    {
        /*public List<Professor> FindAll();*/
        public void AdicionarProfessor(Professor professor);
        public void DetalharProfessor(int IdProfessor);
        public void EditarProfessor(int IdProfessor);
        public void RemoverProfessor(int IdProfessor);


    }
}
