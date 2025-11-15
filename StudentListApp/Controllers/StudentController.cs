using Microsoft.AspNetCore.Mvc;
using StudentListApp.Models;

namespace StudentListApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new()
            {
                new Student { Id = 1, Name = "John Santos", Age = 20, Course = "IT" },
                new Student { Id = 2, Name = "Maria Cruz", Age = 21, Course = "CS" },
                new Student { Id = 3, Name = "Alex Tan", Age = 19, Course = "IS" }
            };
            return View(students);
        }
    }
}
