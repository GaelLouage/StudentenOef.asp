using Infrastructuur.Entities;
using Infrastructuur.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace StudentenPunten.Controllers
{
    public class StudentenController : Controller
    {
        private readonly IStudentenService _studentenService;
        private static List<Student> Studenten;
        public StudentenController(IStudentenService studentenService)
        {
            _studentenService = studentenService;
            Studenten = _studentenService.GetStudents();
        }

        public IActionResult Index(string studentFinder)
        {
          
            if(!string.IsNullOrEmpty(studentFinder))
            {
                studentFinder = studentFinder.ToLower();
                return View(Studenten.Where(x => x.FirstName.ToLower().Contains(studentFinder)).ToList());
            }
            return View(Studenten);
        }
        [HttpGet("student/{studentName}")]
        public IActionResult Detail(string studentName)
        {
            return View( Studenten.FirstOrDefault(x => x.FirstName == studentName));
        }
    }
}
