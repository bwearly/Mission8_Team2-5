using Microsoft.AspNetCore.Mvc;
using Mission8_Team2_5.Models;
using System.Linq;
using ToDoTask = Mission8_Team2_5.Models.ToDoTask;

namespace Mission8_Team2_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskRepository _repo;

        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {
            var tasks = _repo.Tasks;
            return View(tasks);
        }

        [HttpGet]
        public IActionResult TaskForm()
        {
            ViewBag.Categories = _repo.Categories;
            return View(new ToDoTask());
        }

        [HttpPost]
        public IActionResult TaskForm(ToDoTask response)
        {
            if (ModelState.IsValid)
            {
                _repo.Add(response);
                _repo.SaveChanges();

                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Categories = _repo.Categories;
                return View(response);
            }
        }

        [HttpGet]
        public IActionResult EditTask(int id)
        {
            ViewBag.Categories = _repo.Categories;
            var taskToEdit = _repo.Tasks.SingleOrDefault(x => x.TaskId == id);

            return View("TaskForm", taskToEdit);
        }

        [HttpPost]
        public IActionResult EditTask(ToDoTask editTask)
        {
            _repo.Update(editTask);
            _repo.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult DeleteTask(int id)
        {
            var recordToDelete = _repo.Tasks.SingleOrDefault(x => x.TaskId == id);

            if (recordToDelete == null)
            {
                return NotFound();
            }

            return View(recordToDelete);
        }

        [HttpPost]
        public IActionResult DeleteTask(ToDoTask deleteTask)
        {
            if (deleteTask.TaskId > 0)
            {
                _repo.RemoveTask(deleteTask);
                _repo.SaveChanges();
            }

            return RedirectToAction("Index");
        }
    }
}
