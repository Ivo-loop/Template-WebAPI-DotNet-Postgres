using Domain.Entities.Users;
using Infrastructure.Postgres.Mappings;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Postgres;

public class DatabaseContext : DbContext
{
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        _ = new UserMapping(builder.Entity<User>());
    }
}