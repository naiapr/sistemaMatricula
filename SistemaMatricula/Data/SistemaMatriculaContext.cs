using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaMatricula.Models;

namespace SistemaMatricula.Data
{
    public class SistemaMatriculaContext : DbContext
    {
        public SistemaMatriculaContext (DbContextOptions<SistemaMatriculaContext> options)
            : base(options)
        {
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Modalidade> Modalidade { get; set; }
        public DbSet<Professor> Professor{ get; set; }
    }
}
