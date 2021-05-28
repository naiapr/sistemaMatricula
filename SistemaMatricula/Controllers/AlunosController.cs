using Microsoft.AspNetCore.Mvc;
using SistemaMatricula.Models;
using SistemaMatricula.Models.ViewModel;
using SistemaMatricula.Services;
using SistemaMatricula.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace SistemaMatricula.Controllers
{
    public class AlunosController : Microsoft.AspNetCore.Mvc.Controller
    {
        private readonly AlunoService _alunoService;
        private readonly ModalidadeService _modalidadeService;
        private readonly UtilidadesService _utilidadesService;

        public AlunosController(AlunoService alunoService, ModalidadeService modalidadeService, UtilidadesService utilidadesService)
        {
            _alunoService = alunoService;
            _modalidadeService = modalidadeService;
            _utilidadesService = utilidadesService;
        }

        public IActionResult Index()
        {
            var list = _alunoService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            ViewBag.IDModalidade =  _modalidadeService.FindAll();
            
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(AlunoViewModel alunoViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.IDModalidade = _modalidadeService.FindAll();
                return View(alunoViewModel);
            }
            _alunoService.AdicionarAluno(alunoViewModel);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
           var obj = _alunoService.FindById(id);
            
           ViewBag.IDModalidade = _modalidadeService.FindAll();
            
            
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit( AlunoViewModel alunoViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.IDModalidade = _modalidadeService.FindAll();
                return View(alunoViewModel);
            }

            try
            {
                _alunoService.EditarAluno(alunoViewModel);
                return RedirectToAction(nameof(Index));
            }
            catch (NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }

        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _alunoService.BuscarAlunoViewModel(id.Value);
            if (id == null)
            {
                return NotFound();
            }
            return View(obj);
        }


        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _alunoService.FindById(id.Value);
            if (id == null)
            {
                return NotFound();
            }
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            _alunoService.RemoverAluno(id);
            return RedirectToAction(nameof(Index));
        }

        [AcceptVerbs("GET", "POST")]
        public IActionResult ValidaCpf(string Cpf,int AlunoId=0)
        
        {
            var resultado =_utilidadesService.LocalizarCpf(Cpf,AlunoId);
            return Json (resultado);
        }

        


    }
}
