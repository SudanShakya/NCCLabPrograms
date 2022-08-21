using Microsoft.AspNetCore.Mvc;
using StudentCRUD.Data;
using StudentCRUD.Models;

namespace StudentCRUD.Controllers
{
    public class StudentController : Controller
    {
        private ApplicationDbContext _context;

        public StudentController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            IEnumerable<Student> students = _context.Students;
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Add(student);
                _context.SaveChanges();
                TempData["success"] = "Student Created Successfully!";
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _context.Students.Update(student);
                _context.SaveChanges();
                TempData["success"] = "Student Updated Succesfully!";
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteData(int? id)
        {
            var student = _context.Students.Find(id);
            if (student == null)
            {
                return NotFound();
            }
            _context.Students.Remove(student);
            _context.SaveChanges();
            TempData["success"] = "Student Deleted Successfully!";
            return RedirectToAction("Index");
        }
    }
}