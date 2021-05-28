using SistemaMatricula.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Services
{
    public interface IUtilidadedesService
    {
        public bool LocalizarCpf(string Cpf,int Id);
    }
}
