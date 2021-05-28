using SistemaMatricula.Data;
using SistemaMatricula.Models;
using SistemaMatricula.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public class SetorService : ISetor
    {
        private readonly SistemaMatriculaContext _context;

        public SetorService(SistemaMatriculaContext context)
        {
            _context = context;
        }
        public void AdicionarSetor(Setor setor)
        {
           
            _context.Add(setor);
            _context.SaveChanges();

        }

        public void EditarSetor(Setor setor)
        {
            if (_context.Setor.Any(x => x.Id != setor.Id))
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                var obj = _context.Setor.Find(setor.Id);
                obj.Nome = setor.Nome;
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }

        }

        public List<Setor> FindAll()
        {
            return _context.Setor.OrderBy(x => x.Nome).ToList();
        }

        public Setor FindById(int IdSetor)
        {
            return _context.Setor.FirstOrDefault(obj => obj.Id == IdSetor);
        }

        public void RemoverSetor(int IdSetor)
        {
            var obj = _context.Setor.Find(IdSetor);
            _context.Setor.Remove(obj);
            _context.SaveChanges();
        }
    }
}
