using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
//using Mission8_Team2_5.Models;

namespace Mission8_Team2_5.Controllers
{    
  //public class HomeController : Controller

    public class HomeController : Controller
    {
    //{    
        //private TimeManageMatrixContext _context;

    //    private TimeManageMatrixContext _context;
    //    public HomeController(TimeManageMatrixContext temp)
    //    {
    //        _context = temp;
    //    }

    //    public IActionResult Index()
    //    {
        //public HomeController(TimeManageMatrixContext temp)
        //{
        //    _context = temp;
        //}

        //public IActionResult Index()
        //{
    //        return View();
    //    }

    //    [HttpGet]
    //    public IActionResult TaskForm()
    //    {
    //        ViewBag.Categories = _context.Category.ToList();

    //        return View("TaskForm", new Task());
    //    }

    //    [HttpPost]
    //    public IActionResult TaskForm(Task reponse)
    //    {
    //        if (ModelState.IsValid)
    //        {
    //            _context.Task.Add(response);
    //            _context.SaveChanges();

    //            return View("Confirmation", reponse);
    //        }
    //        else
    //        {
    //            ViewBag.Categories = _context.Category.ToList();
    //            return View(response);
    //        }
    //    }

    //    [HttpGet]
    //    public IActionResult EditTask(int id)
    //    {
    //        ViewBag.Categories = _context.Category.ToList();
    //        var taskToEdit = _context.Task.Single(x => x.TaskId == id);

    //        return View("TaskForm", taskToEdit);
    //    }

    //    [HttpPost]
    //    public IActionResult EditTask(Task editTask)
    //    {
    //        _context.Update(editTask);
    //        _context.SaveChanges();

    //        return RedirectToAction("Index");
    //    }

    //    [HttpGet]
    //    public IActionResult DeleteTask(int id)
    //    {
    //        var recordToDelete = _context.Movies.Single(x => x.TaskId == id);
    //        return View(recordToDelete);
    //    }

    //    [HttpPost]
    //    public IActionResult DeleteTask(Task deleteTask)
    //    {
    //        _context.Task.Remove(deleteTask);
    //        _context.SaveChanges();
    //        return RedirectToAction("Delete");
    //    }
    }
}
