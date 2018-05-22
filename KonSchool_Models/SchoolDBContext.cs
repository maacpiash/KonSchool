using Microsoft.EntityFrameworkCore;

namespace KonSchool_Models
{
    public class SchoolDBContext : DbContext
    {
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options)
            : base(options)
        {
        }

        public DbSet<School> TodoItems { get; set; }
    }
}