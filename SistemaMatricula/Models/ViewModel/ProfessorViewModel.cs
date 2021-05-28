using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Models.ViewModel
{
    public class ProfessorViewModel
    {
        public int ProfessorId { get; set; }
        public Professor Professor{ get; set; }
        [Display(Name = "PROFESSOR")]
        public string NomeProfessor { get; set; }
        [Display(Name = "MODALIDADE")]
        public string NomeModalidade { get; set; }
        public ICollection<Modalidade> Modalidades{ get; set; }
    }
}
