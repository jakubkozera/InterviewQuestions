using Microsoft.EntityFrameworkCore;

namespace API.Entities;

public class ApiDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=ApiDb;Trusted_Connection=True;");
}