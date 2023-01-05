using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Registrar.Models;

namespace Registrar.Controllers
{
  public class StudentsController : Controller
  {
    private readonly RegistrarContext _db;

    public StudentsController(RegistrarContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Student> model = _db.Students.ToList();
      return View(model);
    }

    public ActionResult Create()
    {
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student)
    {
      if (!ModelState.IsValid)
      {
          return View(student);
      }
      else
      {
        _db.Students.Add(student);
        _db.SaveChanges();
        return RedirectToAction("Index");
      }
    }

    public ActionResult Details(int id)
    {
      Student thisStudent = _db.Students
          .Include(Student => Student.JoinEntities)
          .ThenInclude(join => join.Course)
          .FirstOrDefault(Student => Student.StudentId == id);
      return View(thisStudent);
    }

    public ActionResult Edit(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(Student => Student.StudentId == id);
      // ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
      return View(thisStudent);
    }

    [HttpPost]
    public ActionResult Edit(Student Student)
    {
      _db.Students.Update(Student);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    public ActionResult Delete(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(Student => Student.StudentId == id);
      return View(thisStudent);
    }

    [HttpPost, ActionName("Delete")]
    public ActionResult DeleteConfirmed(int id)
    {
      Student thisStudent = _db.Students.FirstOrDefault(Student => Student.StudentId == id);
      _db.Students.Remove(thisStudent);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }

    // public ActionResult AddCourse(int id)
    // {
    //   Student thisStudent = _db.Students.FirstOrDefault(Students => Students.StudentId == id);
    //   ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Title");
    //   return View(thisStudent);
    // }

    // [HttpPost]
    // public ActionResult AddCourse(Student Student, int tagId)
    // {
    //   #nullable enable
    //   StudentCourse? joinEntity = _db.StudentCourses.FirstOrDefault(join => (join.CourseId == tagId && join.StudentId == Student.StudentId));
    //   #nullable disable
    //   if (joinEntity == null && tagId != 0)
    //   {
    //     _db.StudentCourses.Add(new StudentCourse() { CourseId = tagId, StudentId = Student.StudentId });
    //     _db.SaveChanges();
    //   }
    //   return RedirectToAction("Details", new { id = Student.StudentId });
    // }

    // [HttpPost]
    // public ActionResult DeleteJoin(int joinId)
    // {
    //   StudentCourse joinEntry = _db.StudentCourses.FirstOrDefault(entry => entry.StudentCourseId == joinId);
    //   _db.StudentCourses.Remove(joinEntry);
    //   _db.SaveChanges();
    //   return RedirectToAction("Index");
    }
  }