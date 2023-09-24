using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

public interface IStorage
{
    public DbSet<Reviews> Reviews { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    int SaveChanges();
}