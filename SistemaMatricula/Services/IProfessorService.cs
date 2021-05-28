using SistemaMatricula.Models;
using SistemaMatricula.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public interface IProfessorService
    {
        public List<ProfessorViewModel> FindAll();
        public void AdicionarProfessor(Professor professor);
        public Professor FindById(int IdProfessor);
        public void EditarProfessor(Professor professor);
        public void RemoverProfessor(int IdProfessor);


    }
}
