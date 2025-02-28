using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SQLitePCL;
using Mission8_Team2_5.Models;

namespace Mission8_Team2_5.Controllers
{
    public class HomeController : Controller
    {       
        private ITaskRepository _repo;

        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public IActionResult TaskForm()
        //{
        //    ViewBag.Categories = _repo.Categories.ToList();

        //    return View("TaskForm", new Task());
        //}

        //[HttpPost]
        //public IActionResult TaskForm(Task reponse)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _repo.Tasks.Add(response);
        //        _repo.SaveChanges();

        //        return View("Confirmation", reponse);
        //    }
        //    else
        //    {
        //        ViewBag.Categories = _repo.Categories.ToList();
        //        return View(response);
        //    }
        //}

        //[HttpGet]
        //public IActionResult EditTask(int id)
        //{
        //    ViewBag.Categories = _repo.Categories.ToList();
        //    var taskToEdit = _repo.Task.Single(x => x.TaskId == id);

        //    return View("TaskForm", taskToEdit);
        //}

        //[HttpPost]
        //public IActionResult EditTask(Task editTask)
        //{
        //    _repo.Update(editTask);
        //    _repo.SaveChanges();

        //    return RedirectToAction("Index");
        //}

        //[HttpGet]
        //public IActionResult DeleteTask(int id)
        //{
        //    var recordToDelete = _repo.Tasks.Single(x => x.TaskId == id);
        //    return View(recordToDelete);
        //}

        //[HttpPost]
        //public IActionResult DeleteTask(Task deleteTask)
        //{
        //    _repo.Task.Remove(deleteTask);
        //    _repo.SaveChanges();
        //    return RedirectToAction("Delete");
        //}
    }
}
