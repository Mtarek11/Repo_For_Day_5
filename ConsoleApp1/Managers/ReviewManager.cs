
using ConsoleApp1.Managers;
using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;

public class ReviewManager : Manager<Reviews>, IReviewsManagers
{
    public ReviewManager(DbSet<Reviews> set) : base(set)
    {
    }
}