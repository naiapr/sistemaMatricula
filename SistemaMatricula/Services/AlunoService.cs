using Microsoft.EntityFrameworkCore;
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
    public class AlunoService : IAlunoService
    {
        private readonly SistemaMatriculaContext _context;
        private readonly ModalidadeService _modalidadeService;

        public AlunoService(SistemaMatriculaContext context, ModalidadeService modalidadeService)
        {
            _context = context;
            _modalidadeService = modalidadeService;
        }

        public List<AlunoViewModel> FindAll()
        {
            List<AlunoViewModel> lista = new List<AlunoViewModel>();
            var listaAlunos= _context.Aluno.ToList();
            foreach (var aluno in listaAlunos)
            {
                AlunoViewModel a = new AlunoViewModel();
                a.AlunoId = aluno.Id;
                a.Cpf = aluno.Cpf;
                a.Peso = aluno.Peso;
                a.Altura = aluno.Altura;
                a.NomeAluno = aluno.Nome;
                a.AlunoIMC = IMC(aluno.Peso, aluno.Altura).ToString();
                a.NomeModalidade = _modalidadeService.FindById(aluno.ModalidadeId).Nome;
                
                lista.Add(a);
            }
            return (lista);
        }

        public void AdicionarAluno(AlunoViewModel alunoViewModel)
        {           

            Aluno aluno = new Aluno();
            // transformar o alunoViewModel em aluno
            aluno.Nome= alunoViewModel.NomeAluno;
            aluno.Cpf=alunoViewModel.Cpf;
            aluno.Peso=alunoViewModel.Peso;
            aluno.Altura=alunoViewModel.Altura;
      
            aluno.ModalidadeId = alunoViewModel.IDModalidade;
            _context.Add(aluno);
            _context.SaveChanges();
        }

        public AlunoViewModel FindById(int id)
        {
            Aluno aluno = new Aluno();
            aluno = _context.Aluno.FirstOrDefault(x => x.Id == id);
            AlunoViewModel alunoViewModel = new AlunoViewModel();
            alunoViewModel.AlunoId = aluno.Id;
            alunoViewModel.NomeAluno = aluno.Nome;
            alunoViewModel.Cpf = aluno.Cpf;
            alunoViewModel.Peso = aluno.Peso;
            alunoViewModel.Altura = aluno.Altura;
            alunoViewModel.IDModalidade = aluno.ModalidadeId;
            alunoViewModel.AlunoId = aluno.Id;

            return alunoViewModel;

        }

        public void EditarAluno(AlunoViewModel alunoViewModel)
        {
            if (!_context.Aluno.Any(x => x.Id == alunoViewModel.AlunoId))
            {
                throw new NotFoundException("Id não encontrado");
            }
            try
            {
                Aluno aluno = new Aluno();

                aluno.Id = alunoViewModel.AlunoId;
                aluno.Nome = alunoViewModel.NomeAluno;
                aluno.Cpf = alunoViewModel.Cpf;
                aluno.Peso = alunoViewModel.Peso;
                aluno.Altura = alunoViewModel.Altura;

                aluno.ModalidadeId = alunoViewModel.IDModalidade;
                _context.Aluno.Update(aluno);
                _context.SaveChanges();
            }
            catch (DbConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }


        }


        public string IMC(float peso, float altura)
        {
            var imc = peso / (altura * altura);
            string fmt = "00.##";


            if (imc >= 18.5 && imc <= 24.5)
            {
                return imc.ToString(fmt) + "-" + " Peso Normal";
            }
            else if (imc > 25.0)
            {
                return imc.ToString(fmt) + "-" + " Acima do Peso ";
            }
            else

                return imc.ToString(fmt) + "-" + " Abaixo do Peso ";
        }


        public void RemoverAluno(int IdAluno)
        {
            var obj = _context.Aluno.Find(IdAluno);
            _context.Aluno.Remove(obj);
            _context.SaveChanges();
        }

        internal object BuscarAlunoViewModel(int IdAluno)
        {
            AlunoViewModel alunoViewModel = new AlunoViewModel();
           _context.Aluno.Include(obj => obj.Modalidade).FirstOrDefault(obj => obj.Id == IdAluno);
            var a = _context.Aluno.Find(IdAluno);
            alunoViewModel.AlunoId = a.Id;
            alunoViewModel.NomeAluno = a.Nome;
            alunoViewModel.Cpf = a.Cpf;
            alunoViewModel.Peso = a.Peso;
            alunoViewModel.Altura = a.Altura;
            alunoViewModel.AlunoIMC = a.IMC(a.Peso, a.Altura).ToString();
            alunoViewModel.NomeModalidade = a.Modalidade.Nome;

            return (alunoViewModel);
        }

    }
}
