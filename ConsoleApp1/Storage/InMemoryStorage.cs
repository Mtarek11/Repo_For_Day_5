

using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

public class InMemoryStorage : DbContext, IStorage
{
    public DbSet<Reviews> Reviews { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseInMemoryDatabase("database");
        base.OnConfiguring(optionsBuilder);
    }

}