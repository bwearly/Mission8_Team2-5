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

        public List<Task> Tasks => _context.Tasks.Include(t => t.Category).ToList();
        public List<Category> Categories => _context.Categories.ToList();

        public void Add(Task task)
        {
            _context.Tasks.Add(task);
        }

        public void Update(Task task)
        {
            _context.Tasks.Update(task);
        }

        public void Delete(Task task)
        {
            _context.Tasks.Remove(task);
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
