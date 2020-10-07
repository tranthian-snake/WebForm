using Bank.Models;
using Bank.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bank
{
    public class ProductRepository
    {
        public Product PostProductDetails(Product ProductModel)
        {
            DbHelper dbInstance = new DbHelper();
            return dbInstance.CreateProduct(ProductModel);
        }
    }
}