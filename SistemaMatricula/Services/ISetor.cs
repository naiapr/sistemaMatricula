using SistemaMatricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public interface ISetor
    {
        public List<Setor> FindAll();
        public void AdicionarSetor(Setor setor );
        public Setor FindById(int IdSetor);
        public void EditarSetor(Setor setor);
        public void RemoverSetor(int IdSetor);
    }
}
