using Microsoft.EntityFrameworkCore;

namespace TaskManagerAPI.Models
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext(DbContextOptions<TaskDbContext> options) 
            : base(options) 
        { 
        }

        public DbSet<TaskItem> TaskItems { get; set; }
    }
}
