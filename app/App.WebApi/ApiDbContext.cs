using Microsoft.EntityFrameworkCore;

namespace App.WebApi;

public class ApiDbContext : DbContext
{
    public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);


        modelBuilder.Entity<Driver>(entity =>
        {
            // One to Many relationship
            entity.HasOne(d => d.Team)
                .WithMany(p => p.Drivers)
                .HasForeignKey(d => d.TeamId)
                .OnDelete(DeleteBehavior.Restrict)
                .HasConstraintName("FK_Driver_Team");

        });
    }

    public virtual DbSet<Team> Teams { get; set; }
    public virtual DbSet<Driver> Drivers { get; set; }
}

