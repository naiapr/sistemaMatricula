using Microsoft.AspNetCore.Mvc;
using SistemaMatricula.Models.ViewModel;
using SistemaMatricula.Services;
using SistemaMatricula.Services.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Controllers
{
    public class EstoquesController : Controller
    {
        private readonly EstoqueService _estoqueService;
        private readonly SetorService _setorService;

        public EstoquesController(EstoqueService estoqueService, SetorService setorService)
        {
            _estoqueService = estoqueService;
            _setorService = setorService;
        }

        public IActionResult Index()
        {
            var lista = _estoqueService.FindAll();
            return View(lista);
        }

        public IActionResult Create()
        {
            ViewBag.SetorId = _setorService.FindAll();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EstoqueViewModel estoqueViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.SetorId = _setorService.FindAll();
                return View(estoqueViewModel);//pq aqui usa aviewmodel e no get não?
            }
            _estoqueService.AdicionarItem(estoqueViewModel);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int Id)
        {
            if(Id == null)
            {
                return NotFound();
            }

            var obj = _estoqueService.FindById(Id);
            ViewBag.IdSetor = _setorService.FindAll();

            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit (EstoqueViewModel estoqueViewModel)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.IdSetor = _setorService.FindAll();
                return View(estoqueViewModel);
            }
            try
            {
                _estoqueService.EditarItem(estoqueViewModel);
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

        public IActionResult Delete(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }

            var obj = _estoqueService.FindById(Id.Value);
            if (Id == null)
            {
                return NotFound();
            }
            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete (int Id)
        {
            _estoqueService.RemoverItem(Id);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obj = _estoqueService.FindById(id.Value);
            if (id == null)
            {
                return NotFound();
            }
            return View(obj);
        }
    }

    }


