using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using BusinessLayer.Contracts;

namespace WebApplication.Controllers
{
    /// <summary>
    /// Handles call regarding products
    /// </summary>
    [RoutePrefix("api/products")]
    public class ProductsController : ApiController
    {
        private readonly IProductsService productsService;

        public ProductsController(IProductsService productsService)
        {
            this.productsService = productsService;
        }

        /// <summary>
        /// Calls the product service to read all the products form the DB
        /// </summary>
        /// <returns>List of Products</returns>
        [Route("availableproducts")]
        [HttpGet]
        public IHttpActionResult AvailableProducts(string warehouse = null, string category = null)
        {
            var products = productsService.GetAllProducts(warehouse, category);
            return Ok(products);
        }
    }
}
