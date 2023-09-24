

using ConsoleApp1.Managers;

public interface IUnitOfWork
{
   public IReviewsManagers REV { get; }
   public IBookingManagers BOOK { get; }
   public int SaveChanges();
}