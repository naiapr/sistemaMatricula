using SistemaMatricula.Data;
using SistemaMatricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaMatricula.Services.Exceptions;
using SistemaMatricula.Models.ViewModel;

namespace SistemaMatricula.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly SistemaMatriculaContext _context;
        private readonly ModalidadeService _modalidadeService;

        public ProfessorService(SistemaMatriculaContext context, ModalidadeService modalidadeService)
        {
            _context = context;
            _modalidadeService = modalidadeService;
        }

        public List<ProfessorViewModel> FindAll()
        {
            List<ProfessorViewModel> lista = new List<ProfessorViewModel>();
            var listaProfessores = _context.Professor.ToList();
            foreach (var professor in listaProfessores)
            {
                ProfessorViewModel p = new ProfessorViewModel();
                p.ProfessorId = professor.Id;
                p.NomeProfessor = professor.Nome;
                p.NomeModalidade = _modalidadeService.FindById(professor.ModalidadeId).Nome;
                lista.Add(p);
            }
            return (lista);
        }
        public void AdicionarProfessor(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
        }

        public Professor FindById(int IdProfessor)
        {
            return _context.Professor.Include(obj => obj.Modalidade).FirstOrDefault(obj => obj.Id == IdProfessor);
        }

        public void EditarProfessor(Professor professor)
        {
            if (!_context.Professor.Any(x => x.Id == professor.Id))
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                var obj = _context.Professor.Find(professor.Id);
                obj.Nome = professor.Nome;
                obj.ModalidadeId = professor.ModalidadeId;
                _context.Professor.Update(obj);
                _context.SaveChanges();
            }
            catch(DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
            
        }

        public void RemoverProfessor(int IdProfessor)
        {
            var obj = _context.Professor.Find(IdProfessor);
            _context.Professor.Remove(obj);
            _context.SaveChanges();
        }
    }
}
