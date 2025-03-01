using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission8_Team2_5.Models;
using System.Linq;
using static System.Net.Mime.MediaTypeNames;
using ToDoTask = Mission8_Team2_5.Models.ToDoTask;

namespace Mission8_Team2_5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ITaskRepository _repo;

        // Constructor injecting the repository
        public HomeController(ITaskRepository temp)
        {
            _repo = temp;
        }

        // Displays the main task list
        public IActionResult Index()
        {
            var tasks = _repo.Tasks;
            return View(tasks);
        }

        // GET: Displays the task creation form
        [HttpGet]
        public IActionResult TaskForm()
        {
            ViewBag.Categories = _repo.Categories; // Passes categories to the view
            return View(new ToDoTask());
        }

        // POST: Processes form submission to add a new task
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

        // GET: Displays the edit form for a specific task
        [HttpGet]
        public IActionResult EditTask(int id)
        {
            ViewBag.Categories = _repo.Categories;
            var taskToEdit = _repo.Tasks.SingleOrDefault(x => x.TaskId == id);
            return View("TaskForm", taskToEdit); // Reuses the TaskForm view
        }

        // POST: Processes form submission to update an existing task
        [HttpPost]
        public IActionResult EditTask(ToDoTask editTask)
        {
            _repo.Update(editTask);
            _repo.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Displays the delete confirmation page
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var task = _repo.Tasks.SingleOrDefault(x => x.TaskId == id);
            if (task == null)
            {
                return NotFound();
            }
            return View(task); // Loads Delete.cshtml
        }

        // POST: Confirms and processes task deletion
        [HttpPost]
        public IActionResult DeleteConfirmed(int id)
        {
            var task = _repo.Tasks.SingleOrDefault(x => x.TaskId == id);
            if (task == null)
            {
                _repo.Delete(deleteTask);
                _repo.SaveChanges();
            }

            _repo.Delete(task);
            var changes = _repo.SaveChanges(); // Ensure changes are saved
            Console.WriteLine($"SaveChanges returned: {changes}");

            return RedirectToAction("Index");
        }
    }
}
