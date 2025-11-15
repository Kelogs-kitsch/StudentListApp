using Microsoft.AspNetCore.Mvc;
using StudentListApp.Models;

namespace StudentListApp.Controllers
{

    public class StudentsController : Controller
    {
        private static List<Student> tempStudents = new()
        {
            new Student { Id = 1, Name = "John Santos", Age = 20, Course = "IT" },
            new Student { Id = 2, Name = "Maria Cruz", Age = 21, Course = "CS" },
            new Student { Id = 3, Name = "Alex Tan", Age = 19, Course = "IS" }
        };
        // Display all students
        public IActionResult Index()
        {
            return View(tempStudents);
        }

        // Display Create Form
        public IActionResult Create()
        {
            return View();
        }
        // Handle form submission
        [HttpPost]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                tempStudents.Add(student);
                return RedirectToAction("Index");
            }

            return View(student);
        }
    }
}
