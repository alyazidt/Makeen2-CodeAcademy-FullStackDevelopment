using CodeAcademyShop.Context;
using CodeAcademyShop.Models;
using Microsoft.EntityFrameworkCore;

namespace CodeAcademyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            using ApplicationDbContext _dbContext = new ApplicationDbContext();

            Categories categorItem = new Categories()
            {

                Name = "Sport",
                Description = "a sport item",

            };


            //_dbContext.categories.Add(categorItem);
            //_dbContext.SaveChanges();



            //Product prodItem = new Product()
            //{

            //    Name = "Football",
            //    Descreption = "a football item from sport category",
            //    Quantity = 1,
            //    Price = 3,
            //    CategoriesId = 1,


            //};


            //_dbContext.products.Add(prodItem);
            //_dbContext.SaveChanges();



            //var categorItem = (from c in _dbContext.products
            //                   where c.CategoriesId == 3
            //                   select c).AsNoTracking().FirstOrDefault();


            //_dbContext.categories.Update(categorItem);
            //_dbContext.SaveChanges();


            //_dbContext.categories.Remove(categorItem);
            //_dbContext.SaveChanges();





        }
    }
}
