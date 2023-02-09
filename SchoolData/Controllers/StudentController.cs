using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolData.Models;
using SchoolData.Data;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SchoolData.Controllers
{
    public class StudentController : Controller
    {
            //private readonly MvcStudentContext _context;
        private readonly ILogger<StudentController> _logger;

            public StudentController(ILogger<StudentController> logger)
        {
            // _context = context;
            _logger = logger;
        }

        // GET: /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            // TODO: Sostituire con valori effettivi
            //Student[] students = _context.Student.ToList().ToArray();

            Student[] students = Student.GetMockValues();

            return View(students);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            return View();
        }
    }
}

