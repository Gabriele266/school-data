using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolData.Models;
using SchoolData.Data;
using SchoolData.Mock;

namespace SchoolData.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private readonly SchoolDataContext _context;

        public StudentController(ILogger<StudentController> logger, SchoolDataContext context)
        {
            _logger = logger;
            this._context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            try
            {
                Student[] students = _context.Student.ToList().ToArray();
                return View(students);
            }
            catch (Exception)
            {
                return View("Error", new ErrorViewModel());
            }
        }

        public IActionResult Edit(int studentId)
        {
            // Load student
            Student s = StudentMock.GetMockValues()[0];

            return View(s);
        }

        // GET: Prenotazione/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,nome,cognome,assenze,classe,specializzazione,averageVote")] Student student)
        {
            _logger.LogInformation(student.Id.ToString());
            _logger.LogInformation(student.nome);
            if (ModelState.IsValid)
            {
                _context.Add(student);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction("Index");
        }
    }
}