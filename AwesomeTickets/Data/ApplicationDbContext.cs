using Microsoft.EntityFrameworkCore;
using AwesomeTickets.Models;

namespace AwesomeTickets.Data
{
    public class ApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
             : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
