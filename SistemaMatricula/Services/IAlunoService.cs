using SistemaMatricula.Models;
using SistemaMatricula.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public interface IAlunoService
    {
        
        public List<AlunoViewModel> FindAll();
        public string IMC(float altura, float peso);
        public void AdicionarAluno(AlunoViewModel alunoViewModel);
        public AlunoViewModel FindById(int id);
       
        public void EditarAluno(AlunoViewModel alunoViewModel);

        public void RemoverAluno(int IdAluno);
    }
}
