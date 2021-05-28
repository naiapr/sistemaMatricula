using SistemaMatricula.Data;
using SistemaMatricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public class UtilidadesService : IUtilidadedesService
    {
        private readonly SistemaMatriculaContext _context;
        private readonly AlunoService alunoService;

        public UtilidadesService(SistemaMatriculaContext context, AlunoService alunoService)
        {
            _context = context;
            this.alunoService = alunoService;
        }

        public bool LocalizarCpf(string Cpf, int Id)
        {
          
            var buscaCpf = _context.Aluno.Any(x=> x.Cpf == Cpf && x.Id!=Id);


            if(buscaCpf == true)
            {
                return false;
            }
            return true;  
        }
    }
}
