using Microsoft.AspNetCore.Mvc;
using SistemaMatricula.Models;
using SistemaMatricula.Services;
using SistemaMatricula.Services.Exceptions;


namespace SistemaMatricula.Controllers
{
    public class SetoresController : Controller
    {
        private readonly SetorService _setorService;

        public SetoresController(SetorService setorService)
        {
            _setorService = setorService;
        }

        public IActionResult Index()
        {
            var list = _setorService.FindAll();
            return View(list);
        }

        public IActionResult Create()
        {
            return View();
        }

    public IActionResult PaginaTeste()
        {
            return View();
        }
        

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Setor setor)
        {
            if (!ModelState.IsValid)
            {
                return View(setor);
            }
            _setorService.AdicionarSetor(setor);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Edit(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }
            var obj = _setorService.FindById(Id.Value);//pq tem que passar a variavel?
            if (Id == null)
            {
                return NotFound();
            }

            return View(obj);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Setor setor)
        {
            if (!ModelState.IsValid)
            {
                return View(setor);
            }
            try
            {
                _setorService.EditarSetor(setor);//pq aqui não passa em uma variavel?
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

        public IActionResult Details(int? Id)
        {
            if (Id == null)
            {
                return NotFound();
            }
            var obj = _setorService.FindById(Id.Value);
            if (Id == null)
            {
                return NotFound();
            }
            return View(obj);

        }

        public IActionResult Delete(int? Id)
        {
            if(Id == null)
            {
                return NotFound();
            }
            var obj = _setorService.FindById(Id.Value);
            if(Id == null)
            {
                return NotFound();
            }
            return View(obj);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete (int Id)
        {
            _setorService.RemoverSetor(Id);
            return RedirectToAction(nameof(Index));
        }
    }
}
