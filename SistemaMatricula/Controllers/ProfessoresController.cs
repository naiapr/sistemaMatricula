﻿using Microsoft.AspNetCore.Mvc;
using SistemaMatricula.Data;
using SistemaMatricula.Models;
using SistemaMatricula.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaMatricula.Controllers
{
    public class ProfessoresController : Controller
    {
        private readonly  ProfessorService _professorService;

        public ProfessoresController(ProfessorService professorService)
        {
            _professorService = professorService;
        }

        public IActionResult Index()
        {
            return View();
        }

        /*public IActionResult Create()
        {
            var list = _professorService.FindAll();
            return View(list);
        }*/

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Professor professor)
        {
            _professorService.AdicionarProfessor(professor);
            return RedirectToAction(nameof(Index));

        }
    } 
}