using SistemaMatricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public interface IModalidadeService
    {
        public List<Modalidade> FindAll();
        public void AdicionarModalidade(Modalidade modalidade);
        public Modalidade FindById(int IdModalidade);
        public void EditarModalidade(Modalidade modalidade);
        public void RemoverModalidade(int IdModalidade);

    }
}
