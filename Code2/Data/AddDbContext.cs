using Code2.Models;

using Microsoft.EntityFrameworkCore;

namespace Code2.Data

{

    public class AppDbContext : DbContext

    {

        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        
        public DbSet<TodoItem> TodoItems { get; set; }

    }

}

