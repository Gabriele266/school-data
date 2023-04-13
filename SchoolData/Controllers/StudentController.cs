using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolData.Models;
using SchoolData.Data;
using SchoolData.Mock;
using Microsoft.EntityFrameworkCore;

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

        /*public IActionResult Edit(int studentId)
        {
            // Load student
            Student s = StudentMock.GetMockValues()[0];

            return View(s);
        }*/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,nome,cognome,assenze,classe,specializzazione,averageVote")] Student @student)
        {
            if (id != @student.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(@student);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StudentExist(@student.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(@student);
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var @student = await _context.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
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

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Student == null)
            {
                return NotFound();
            }

            var @student = await _context.Student
                .FirstOrDefaultAsync(m => m.Id == id);
            if (@student == null)
            {
                return NotFound();
            }

            return View(@student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Student == null)
            {
                return Problem("Entity set 'SchoolDataContext.Student'  is null.");
            }
            var @student = await _context.Student.FindAsync(id);
            if (@student != null)
            {
                _context.Student.Remove(@student);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StudentExist(int id)
        {
           
            return (_context.Student?.Any(e => e.Id == id)).GetValueOrDefault();
            
        }
    }
}