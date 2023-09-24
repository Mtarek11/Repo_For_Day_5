using ConsoleApp1.Managers;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

public class BookingManager : Manager<Booking>, IBookingManagers
{
    public BookingManager(DbSet<Booking> set) : base(set)
    {
    }
}