using Microsoft.EntityFrameworkCore;

namespace Mission8_Team2_5.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private TimeManageMatrixContext _context;

        public EFTaskRepository(TimeManageMatrixContext temp)
        {
            _context = temp;
        }

        public List<ToDoTask> Tasks => _context.Tasks.Include(t => t.Category).ToList();
        public List<Category> Categories => _context.Categories.ToList();

        public void Add(ToDoTask task)
        {
            _context.Tasks.Add(task);
        }

        public void Update(ToDoTask task)
        {
            _context.Tasks.Update(task);
        }

        public void RemoveTask(ToDoTask task)
        {
            _context.Tasks.Remove(task);
            _context.SaveChanges();
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
