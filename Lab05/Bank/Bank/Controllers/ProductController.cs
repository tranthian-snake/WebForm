using System;
using Bank.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Bank.Repository;

namespace Bank.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        [HttpPost]
        [Route("api/Product/Create")]
        public string CreateProduct(Product productModel)
        {
            DbHelper dbHelper = new DbHelper();
            productModel = dbHelper.CreateProduct(productModel);
            return "Successfully!";
        }

        [HttpPut]
        [Route("api/Product/Update")]
        public string UpdateProduct(Product productModel)
        {
            DbHelper dbHelper = new DbHelper();
            productModel = dbHelper.UpdateProduct(productModel);
            return "Successfully!";
        }

        [HttpDelete]
        [Route("api/Product/Delete/{id}")]
        public string DeleteProduct(Product productModel, int id)
        {
            DbHelper dbHelper = new DbHelper();
            productModel = dbHelper.DeleteProduct(productModel, id);
            return "Successfully!";
        }
    }
}