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

        // GET: /<controller>/
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
    }
}