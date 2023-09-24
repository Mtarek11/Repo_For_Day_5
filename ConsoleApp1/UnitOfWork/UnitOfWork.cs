
using ConsoleApp1.Managers;
using Microsoft.EntityFrameworkCore.InMemory.Storage.Internal;

public class UnitOfWork : IUnitOfWork
{
    IStorage storage;
    public UnitOfWork(IStorage storage)
    {
        this.storage = storage;
    }
    private IReviewsManagers REV1;
    private IBookingManagers BOOK1;
    public IReviewsManagers REV
    {
        get
        {
            if (REV1 == null)
            {
                 REV1 = new ReviewManager(storage.Reviews);
            }
            return REV1!;
        }
    }
    public IBookingManagers BOOK
    {
        get
        {
            if (BOOK1 == null)
                BOOK1 = new BookingManager(storage.Bookings);
            return BOOK1;
        }
    }
    public int SaveChanges()
    {
        return storage.SaveChanges();
    }
}