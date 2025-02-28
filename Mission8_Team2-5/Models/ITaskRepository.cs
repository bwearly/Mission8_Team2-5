namespace Mission8_Team2_5.Models
{
    public interface ITaskRepository
    {
        List<Task> Tasks { get; }
        List<Category> Categories { get; }

        void Add(Task task);

        void Update(Task task);

        void Delete(Task task);

        void SaveChanges();
    }
}
