using SistemaMatricula.Data;
using SistemaMatricula.Models;
using SistemaMatricula.Models.ViewModel;
using SistemaMatricula.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public class EstoqueService : IEstoqueService
    {
        private readonly SistemaMatriculaContext _context;
        private readonly SetorService _setorService;

        public EstoqueService(SistemaMatriculaContext context, SetorService setorService)
        {
            _context = context;
            _setorService = setorService;
        }

        public void AdicionarItem(EstoqueViewModel estoqueViewModel)
        {
            Estoque estoque = new Estoque();
            estoque.Nome = estoqueViewModel.Nome;
            estoque.Preco = estoqueViewModel.Preco;
            estoque.Quantidade = estoqueViewModel.Quantidade;
            estoque.SetorId = estoqueViewModel.IdSetor;
            _context.Add(estoque);
            _context.SaveChanges();
        }

        public void EditarItem(EstoqueViewModel estoqueViewModel)
        {
            if (!_context.Estoque.Any(x => x.Id == estoqueViewModel.EstoqueId))
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                Estoque estoque = new Estoque();
                estoque.Nome = estoqueViewModel.Nome;
                estoque.Preco = estoqueViewModel.Preco;
                estoque.Quantidade = estoqueViewModel.Quantidade;
                estoque.SetorId = estoqueViewModel.IdSetor;
                _context.Estoque.Update(estoque);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
        }

        public List<EstoqueViewModel> FindAll()//perguntar Mel
        {
            List<EstoqueViewModel> lista = new List<EstoqueViewModel>();
            var listaEstoque = _context.Estoque.ToList();
            foreach (var estoque in listaEstoque)
            {
                EstoqueViewModel e = new EstoqueViewModel();
                e.EstoqueId = estoque.Id;
                e.Nome = estoque.Nome;
                e.Preco = estoque.Preco;
                e.Quantidade = estoque.Quantidade;
                e.NomeSetor = _setorService.FindById(estoque.SetorId).Nome;
                

                lista.Add(e);

            }

            return (lista);
        }

        public EstoqueViewModel FindById(int IdItem)
        {
            Estoque estoque = new Estoque();
            estoque = _context.Estoque.FirstOrDefault(x => x.Id == IdItem);
            EstoqueViewModel estoqueViewModel = new EstoqueViewModel();
            estoqueViewModel.EstoqueId = estoque.Id;
            estoqueViewModel.Nome = estoque.Nome;
            estoqueViewModel.Preco = estoque.Preco;
            estoqueViewModel.Quantidade = estoque.Quantidade;
            estoque.SetorId = estoque.SetorId;
            return estoqueViewModel;
        }

        public void RemoverItem(int IdItem)
        {
            var obj = _context.Estoque.Find(IdItem);
            _context.Estoque.Remove(obj);
            _context.SaveChanges();

        }

      

        public double TotalEstoque(double totalItem)
        {
            throw new NotImplementedException();
        }

        public double TotalItem(float preco, int quantidade)
        {
            throw new NotImplementedException();
        }
    }
}
