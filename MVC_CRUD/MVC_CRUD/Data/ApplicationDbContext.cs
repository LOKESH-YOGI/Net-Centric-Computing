using Microsoft.EntityFrameworkCore;
using MVC_CRUD.Models;
namespace MVC_CRUD.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
