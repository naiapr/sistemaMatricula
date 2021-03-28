using SistemaMatricula.Data;
using SistemaMatricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public class ProfessorService : IProfessorService
    {
        private readonly SistemaMatriculaContext _context;

        public ProfessorService(SistemaMatriculaContext context)
        {
            _context = context;
        }

        /*public List<Professor> FindAll()
        {
            return _context.Professor.ToList();
        }*/
        public void AdicionarProfessor(Professor professor)
        {
            _context.Add(professor);
            _context.SaveChanges();
        }

        public void DetalharProfessor(int IdProfessor)
        {
            throw new NotImplementedException();
        }

        public void EditarProfessor(int IdProfessor)
        {
            throw new NotImplementedException();
        }

        public void RemoverProfessor(int IdProfessor)
        {
            throw new NotImplementedException();
        }
    }
}
