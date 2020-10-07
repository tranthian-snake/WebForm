using Bank.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank.Repository
{
    public class DbHelper
    {
        public Customer CreateStudent(Customer studentModel)
        {
            using (var dbEntities = new BankContext())
            {
                var studentObj = new Customer()
                {
                    //ID is auto generated.
                    Name = studentModel.Name,
                    Gender = studentModel.Gender,
                    Amount = studentModel.Amount
                };
                dbEntities.Customers.Add(studentObj);
                dbEntities.SaveChanges();
                studentModel.Id = studentObj.Id;
            }
            return studentModel;
        }

        public Product CreateProduct(Product productModel)
        {
            using (var dbEntities = new BankContext())
            {
                var productObj = new Product()
                {
                    //ID is auto generated.
                    Name = productModel.Name,
                    Price = productModel.Price,
                    Qty = productModel.Qty
                };
                dbEntities.Products.Add(productObj);
                dbEntities.SaveChanges();
                productModel.Id = productObj.Id;
            }
            return productModel;
        }

        public Product UpdateProduct(Product productModel)
        {
            using (var dbEntities = new BankContext())
            {
                var productObj = new Product()
                {
                    //ID is auto generated.
                    Id = productModel.Id,
                    Name = productModel.Name,
                    Price = productModel.Price,
                    Qty = productModel.Qty
                };
                dbEntities.Entry(productObj).State = System.Data.Entity.EntityState.Modified;
                dbEntities.SaveChanges();
                productModel.Id = productObj.Id;
            }
            return productModel;
        }

        public Product DeleteProduct(Product productModel, int id)
        {
            using (var dbEntities = new BankContext())
            {
                var productObj = dbEntities.Products.SingleOrDefault(e => e.Id == id);
                dbEntities.Products.Remove(productObj);
                dbEntities.SaveChanges();
                productModel.Id = productObj.Id;
            }
            return productModel;
        }

    }
}