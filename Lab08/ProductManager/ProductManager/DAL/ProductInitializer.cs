using ProductManager.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProductManager.DAL
{
    public class ProductInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            var products = new List<Product>
            {
            new Product{ProductName="Apple", Price=12.0, Qty=20},
            new Product{ProductName="Peach blossom", Price=26.7, Qty=15 },
            new Product{ProductName="Rabbit", Price=15.5, Qty=30 },
            new Product{ProductName="Spoon", Price=5.8, Qty=50 },
            new Product{ProductName="Onions", Price=7.5, Qty=10 },
            new Product{ProductName="Candy", Price=10.0, Qty=20 }
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
            var categories = new List<Category>
            {
            new Category{CategoryID=102, CategoryName="Plants",},
            new Category{CategoryID=133, CategoryName="Food"},
            new Category{CategoryID=222, CategoryName="Animal",},
            new Category{CategoryID=456, CategoryName="Fruit",},
            new Category{CategoryID=999, CategoryName="Houseware"}
            };
            categories.ForEach(s => context.Categories.Add(s));
            context.SaveChanges();
            var enrollments = new List<Enrollment>
            {
            new Enrollment{ProductID=1,CategoryID=102,},
            new Enrollment{ProductID=1,CategoryID=133,},
            new Enrollment{ProductID=1,CategoryID=456,},
            new Enrollment{ProductID=2,CategoryID=102,},
            new Enrollment{ProductID=3,CategoryID=222,},
            new Enrollment{ProductID=3,CategoryID=133,},
            new Enrollment{ProductID=4,CategoryID=999,},
            new Enrollment{ProductID=5,CategoryID=102,},
            new Enrollment{ProductID=6,CategoryID=133,},
            };
            enrollments.ForEach(s => context.Enrollments.Add(s));
            context.SaveChanges();
        }
    }
}