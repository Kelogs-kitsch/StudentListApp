using Microsoft.AspNetCore.Mvc;
using StudentListApp.Models;
using System;

namespace StudentListApp.Controllers
{
    public class StudentsController : Controller
    {
        private readonly AppDBContext _context;

        // Inject AppDbContext
        public StudentsController(AppDBContext context)
        {
            _context = context;
        }

        // GET: /Students/Index
        public IActionResult Index()
        {
            var students = _context.Students.ToList();
            return View(students);
        }

        // GET: /Students/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: /Students/Create
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: /Students/Edit/1
        public IActionResult Edit(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        // POST: /Students/Edit/1
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                var existingStudent = _context.Students.FirstOrDefault(s => s.Id == student.Id);
                if (existingStudent == null)
                {
                    return NotFound();
                }

                existingStudent.Name = student.Name;
                existingStudent.Age = student.Age;
                existingStudent.Course = student.Course;

                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(student);
        }

        // GET: /Students/Delete/1
        public IActionResult Delete(int id)
        {
            var student = _context.Students.FirstOrDefault(s => s.Id == id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
