using Microsoft.EntityFrameworkCore;
using office_manage_api.Models.EF;

namespace office_manage_api
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<Organization> Organizations { get; set; }
        public DbSet<WorkingTime> WorkingTimes { get; set; }
        public DbSet<WorkingTimeOtp> WorkingTimeOtps { get; set; }
        public DbSet<Tasklist> Tasklists { get; set; }
    }
}