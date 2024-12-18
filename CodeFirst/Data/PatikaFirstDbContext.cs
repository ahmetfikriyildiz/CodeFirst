using CodeFirst.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace CodeFirst.Data
{
    public class PatikaFirstDbContext : DbContext
    {
        public DbSet<Game> Games { get; set; }
        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Game>(entity =>
            {
                entity.ToTable("Games");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Platform).IsRequired();
                entity.Property(e => e.Rating).IsRequired();
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movies");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name).IsRequired();
                entity.Property(e => e.Genre).IsRequired();
                entity.Property(e => e.ReleaseYear).IsRequired();
            });
        }

    }
}
