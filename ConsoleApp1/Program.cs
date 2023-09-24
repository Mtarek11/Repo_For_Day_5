using ConsoleApp1.Managers;
using ConsoleApp1.Models;

public class App
{
    static void Main()
    {
        IStorage storgae = new InMemoryStorage();
        IUnitOfWork unitOfWork = new UnitOfWork(storgae);
        IReviewsManagers REV = unitOfWork.REV;
        IBookingManagers Book = unitOfWork.BOOK;
        REV.Add(new Reviews { Id = 1, Customer = "Mohamed",Content = "content"});
        Book.Add(new Booking { Id = 3, Item = "New Item",Description = "Description",Customer = "Ahmed" });
        unitOfWork.SaveChanges();
        foreach (Booking B in Book.GetAll())
            Console.WriteLine(B.Item);
        foreach (Reviews R in REV.GetAll())
            Console.WriteLine(R.Customer);
    }
}