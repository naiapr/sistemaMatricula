using Microsoft.AspNetCore.Mvc;
using SistemaMatricula.Models;
using SistemaMatricula.Services;
using SistemaMatricula.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Controllers
{
    public class ModalidadesController : Controller
    {
        private readonly ModalidadeService _modalidadeservice;

        public ModalidadesController(ModalidadeService modalidadeservice)
        {
            _modalidadeservice = modalidadeservice;
        }

        public IActionResult Index()
        {
            var list = _modalidadeservice.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Modalidade modalidade)
        {

            if (!ModelState.IsValid)
            { 
                return View(modalidade);
            }


            _modalidadeservice.AdicionarModalidade(modalidade);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _modalidadeservice.FindById(id.Value);
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
            var obj = _modalidadeservice.FindById(id.Value);
            if (id == null)
            {
                return NotFound();
            }
          
            return View(obj);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Modalidade modalidade)
        {
            if (!ModelState.IsValid)
            {
                return View(modalidade);
            }
            try
            {
                _modalidadeservice.EditarModalidade(modalidade);
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

        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _modalidadeservice.FindById(id.Value);
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
            _modalidadeservice.RemoverModalidade(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
