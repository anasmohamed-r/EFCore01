using EFCore01.Context;
using Microsoft.EntityFrameworkCore;

namespace EFCore01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();

            context.Database.Migrate();
        }
    }
}
