using SistemaMatricula.Models;
using SistemaMatricula.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public interface IEstoqueService
    {
        public List<EstoqueViewModel> FindAll();
        public void AdicionarItem (EstoqueViewModel estoqueViewModel);
        public EstoqueViewModel FindById(int IdItem);
        public void EditarItem(EstoqueViewModel estoqueViewModel);
        public void RemoverItem(int Id);


    }
}
