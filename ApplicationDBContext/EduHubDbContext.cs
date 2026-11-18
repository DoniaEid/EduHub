
namespace EduHub.ApplicationDBContext
{
    public class EduHubDbContext:DbContext
    {
        public DbSet<Course> course;

        public EduHubDbContext(DbContextOptions<EduHubDbContext> options)
           : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EduHubDbContext).Assembly);

            base.OnModelCreating(modelBuilder);

        }

    }
}
