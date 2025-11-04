using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.Services;

namespace StudentManagement.Controllers;

public class StudentController : Controller
{
    private readonly StudentService service;

    public StudentController(StudentService s)
    {
        service = s;
    }

    public IActionResult Index()
    {
        var students = service.GetAllStudents();
        return View(students);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Student s)
    {
        service.AddStudent(s);
        return RedirectToAction("Index");
    }

    public IActionResult Edit(int id)
    {
        var student = service.GetStudent(id);
        if (student == null) return NotFound();
        return View(student);
    }

    [HttpPost]
    public IActionResult Edit(Student s)
    {
        service.UpdateStudent(s);
        return RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
        var student = service.GetStudent(id);
        if (student == null) return NotFound();
        return View(student);
    }

    [HttpPost, ActionName("Delete")]
    public IActionResult DeleteConfirmed(int id)
    {
        service.DeleteStudent(id);
        return RedirectToAction("Index");
    }
}
