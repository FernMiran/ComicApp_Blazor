using ComicApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace ComicApp.Infrastructure.Context
{
    public class ComicDbContext : DbContext
    {
        public DbSet<Comic> Comics { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<ComicCharacter> ComicCharacters { get; set; }
        public DbSet<User> Users { get; set; }

        public ComicDbContext(DbContextOptions<ComicDbContext> dbContextOptions) : base(dbContextOptions)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ComicDbContext).Assembly);
        }
    }
}
