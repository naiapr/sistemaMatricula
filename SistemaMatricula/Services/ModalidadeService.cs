using SistemaMatricula.Data;
using SistemaMatricula.Models;
using SistemaMatricula.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public class ModalidadeService : IModalidadeService
    {
        private readonly SistemaMatriculaContext _context;

        public ModalidadeService(SistemaMatriculaContext context)
        {
            _context = context;
        }

        public List<Modalidade> FindAll()
        {
            return _context.Modalidade.OrderBy(x => x.Nome).ToList();
        }
        public void AdicionarModalidade(Modalidade modalidade)
        {
            _context.Add(modalidade);
            _context.SaveChanges();
        }

        public Modalidade FindById(int IdModalidade)
        {
            return _context.Modalidade.FirstOrDefault(obj => obj.Id == IdModalidade);
        }
        public void EditarModalidade(Modalidade modalidade)
        {
            if (!_context.Modalidade.Any(x => x.Id == modalidade.Id))
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                var obj = _context.Modalidade.Find(modalidade.Id);
                obj.Nome = modalidade.Nome;
                _context.Modalidade.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }

        public void RemoverModalidade(int IdModalidade)
        {
            var obj = _context.Modalidade.Find(IdModalidade);
            _context.Modalidade.Remove(obj);
            _context.SaveChanges();
        }
    }
}
