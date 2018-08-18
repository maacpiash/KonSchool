using Microsoft.EntityFrameworkCore;

namespace KonSchool.Models
{
    public class SchoolDbContext : DbContext
    {
        public SchoolDbContext(DbContextOptions<SchoolDbContext> options) : base(options) { }

        public DbSet<School> Values { get; set; }
    }
}