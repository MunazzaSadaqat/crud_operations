using crud_operations.Data;
using crud_operations.Models;
using Microsoft.AspNetCore.Mvc;

namespace crud_operations.Controllers
{
    public class FirstController : Controller
    {

        private myContext _context;

        public FirstController(myContext context)
        {
          _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public IActionResult Index(Student std)
        {

            _context.tbl_students.Add(std);
            _context.SaveChanges();
            return RedirectToAction("fetchStudents");
        }

        public IActionResult fetchStudents()
        {
            var students = _context.tbl_students.ToList();
            return View(students);
        }

        public IActionResult deleteStudent(int id)
        {
          var student = _context.tbl_students.Find(id);
            _context.tbl_students.Remove(student);
            _context.SaveChanges();
            return RedirectToAction("fetchStudents");
        }

    }
}
