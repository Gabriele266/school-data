using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolData.Models;
using SchoolData.Data;

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

            try
            {
                Student[] students = Student.GetMockValues();
                return View(students);
            }
            catch (Exception)
            {
                return View("Error", new ErrorViewModel());
            }
        }

        [HttpPost]
        public IActionResult Edit(int studentId)
        {
            // Load student
            Student s = Student.GetMockValues()[0];

            return View(s);
        }
    }
}

