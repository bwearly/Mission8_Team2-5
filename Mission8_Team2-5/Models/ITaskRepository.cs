namespace Mission8_Team2_5.Models
{
    public interface ITaskRepository
    {
        List<ToDoTask> Tasks { get; }
        List<Category> Categories { get; }

        void Add(ToDoTask task);

        void Update(ToDoTask task);

        void RemoveTask(ToDoTask task);

        void SaveChanges();
    }
}
