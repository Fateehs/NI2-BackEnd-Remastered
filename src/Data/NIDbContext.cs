using Microsoft.EntityFrameworkCore;

namespace NI2.Data;

public class NIDbContext : DbContext
{
    public NIDbContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(NIDbContext).Assembly);

        base.OnModelCreating(modelBuilder);
    }
}
