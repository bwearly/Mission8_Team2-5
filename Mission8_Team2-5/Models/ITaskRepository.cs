namespace Mission8_Team2_5.Models
{
    // Interface defining the contract for task repository operations
    public interface ITaskRepository
    {
        // Retrieves all tasks
        List<ToDoTask> Tasks { get; }

        // Retrieves all categories
        List<Category> Categories { get; }

        // Adds a new task
        void Add(ToDoTask task);

        // Updates an existing task
        void Update(ToDoTask task);

        // Deletes a task
        void Delete(ToDoTask task);

        // Saves changes to the database and returns the number of affected rows
        int SaveChanges(); // Changed from void to int to return affected rows
    }
}
