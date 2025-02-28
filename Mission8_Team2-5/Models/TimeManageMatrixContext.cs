using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Mission8_Team2_5.Models
{
    public class TimeManageMatrixContext : DbContext
    {
        public TimeManageMatrixContext(DbContextOptions<TimeManageMatrixContext> options) : base (options)
        {
        }

        public DbSet<ToDoTask> Tasks { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(

                new Category { CategoryId = 1, Name = "Home" },
                new Category { CategoryId = 2, Name = "School" },
                new Category { CategoryId = 3, Name = "Work" },
                new Category { CategoryId = 4, Name = "Church" }
                
            );
;
        }

    }
}
