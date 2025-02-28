namespace Mission8_Team2_5.Models
{
    public class EFTaskRepository : ITaskRepository
    {
        private TimeManageMatrixContext _context;
        public EFTaskRepository(TimeManageMatrixContext temp)
        {
            _context = temp;
        }
        public List<Task> Tasks => _context.Tasks.ToList();
        public List<Category> Categories => _context.Categories.ToList();

    }
}
