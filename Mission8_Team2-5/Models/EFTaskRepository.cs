using Microsoft.EntityFrameworkCore;

namespace Mission8_Team2_5.Models
{
    // Entity Framework implementation of ITaskRepository
    public class EFTaskRepository : ITaskRepository
    {
        private TimeManageMatrixContext _context;

        // Constructor injecting the database context
        public EFTaskRepository(TimeManageMatrixContext temp)
        {
            _context = temp;
        }

        // Retrieves all tasks including their associated category
        public List<ToDoTask> Tasks => _context.Tasks.Include(t => t.Category).ToList();

        // Retrieves all categories
        public List<Category> Categories => _context.Categories.ToList();

        // Adds a new task to the database
        public void Add(ToDoTask task)
        {
            _context.Tasks.Add(task);
        }

        // Updates an existing task in the database
        public void Update(ToDoTask task)
        {
            _context.Tasks.Update(task);
        }

        public void Delete(ToDoTask task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }

        // Saves changes to the database and returns the number of affected rows
        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}