using Microsoft.AspNetCore.Mvc;
using Registrar.Models;
using System.Collections.Generic;
using System.Linq;

namespace Registrar.Controllers
{
    public class HomeController : Controller
    {
      private readonly RegistrarContext _db;

      public HomeController(RegistrarContext db)
      {
        _db = db;
      }

      [HttpGet("/")]
      public ActionResult Index()
      {
        Student[] students = _db.Students.ToArray();
        Course[] courses = _db.Courses.ToArray();
        Dictionary<string, object[]> model = new Dictionary<string, object[]>();
        model.Add("students", students);
        model.Add("courses", courses);
        ViewBag.PageTitle = "Welcome to the University of ToDoList Registrar";
        return View(model);
      }
    }
}