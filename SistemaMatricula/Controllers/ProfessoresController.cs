using Microsoft.AspNetCore.Mvc;
using SistemaMatricula.Data;
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
    public class ProfessoresController : Controller
    {
        private readonly  ProfessorService _professorService;
        private readonly ModalidadeService _modalidadeService;
        public ProfessoresController(ProfessorService professorService, ModalidadeService modalidadeService)
        {
            _professorService = professorService;
            _modalidadeService = modalidadeService;
        }

        public IActionResult Index()
        {
           var list = _professorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            var modalidades = _modalidadeService.FindAll();
            var viewModel = new ProfessorViewModel { Modalidades = modalidades };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Professor professor)
        {
            if (!ModelState.IsValid)
            {
                var modalidades = _modalidadeService.FindAll();
                var viewModel = new ProfessorViewModel { Professor = professor, Modalidades = modalidades };
                return View(viewModel);
            }
            _professorService.AdicionarProfessor(professor);
            return RedirectToAction(nameof(Index));

        }

        public IActionResult Delete(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }

            var obj = _professorService.FindById(id.Value);
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
            _professorService.RemoverProfessor(id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details (int? id)
         {
             if(id == null)
             {
                 return NotFound();
             }

             var obj = _professorService.FindById(id.Value);
             if (id == null)
             {
                 return NotFound();
             }
             return View(obj);
         }

        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var obj = _professorService.FindById(id.Value);
            if (id == null)
            {
                return NotFound();
            }
            List<Modalidade> modalidades = _modalidadeService.FindAll();
            ProfessorViewModel viewModel = new ProfessorViewModel { Professor = obj, Modalidades = modalidades };
            return View(viewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (int id, Professor professor)
        {
            if (!ModelState.IsValid)
            {
                var modalidades = _modalidadeService.FindAll();
                var viewModel = new ProfessorViewModel { Professor = professor, Modalidades = modalidades };
                return View(viewModel);
            }
          
            if (id != professor.Id)
            {
                return BadRequest();
            }
            try
            {
                _professorService.EditarProfessor(professor);
                return RedirectToAction(nameof(Index));
            }
            catch(NotFoundException)
            {
                return NotFound();
            }
            catch (DbConcurrencyException)
            {
                return BadRequest();
            }
            
        }
    }
}
