using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PMS_NET1.Controllers
{
    [ApiController]
    [Route("inventory")]
    public class InventoryController : ControllerBase
    {
         private static readonly List<Product> _products = new List<Product>
    {
        new Product { Id = 1, Name = "Maggi", BuyingPrice = 430, Quantity = 43, ThresholdValue = 12, ExpiryDate = new DateTime(2022, 12, 11), Availability = "In-stock" },
        new Product { Id = 2, Name = "Bru", BuyingPrice = 257, Quantity = 22, ThresholdValue = 12, ExpiryDate = new DateTime(2022, 12, 21), Availability = "Out of stock" },
        new Product { Id = 3, Name = "Red Bull", BuyingPrice = 405, Quantity = 36, ThresholdValue = 9, ExpiryDate = new DateTime(2022, 12, 05), Availability = "In-stock" },
        new Product { Id = 4, Name = "Bourn Vita", BuyingPrice = 502, Quantity = 14, ThresholdValue = 6, ExpiryDate = new DateTime(2022, 12, 08), Availability = "Out of stock" },
        new Product { Id = 5, Name = "Horlicks", BuyingPrice = 530, Quantity = 5, ThresholdValue = 5, ExpiryDate = new DateTime(2023, 01, 09), Availability = "In-stock" },
        new Product { Id = 6, Name = "Harpic", BuyingPrice = 605, Quantity = 10, ThresholdValue = 5, ExpiryDate = new DateTime(2023, 01, 09), Availability = "In-stock" },
        new Product { Id = 7, Name = "Ariel", BuyingPrice = 408, Quantity = 23, ThresholdValue = 7, ExpiryDate = new DateTime(2023, 12, 15), Availability = "Out of stock" },
        new Product { Id = 8, Name = "Scotch Brite", BuyingPrice = 359, Quantity = 43, ThresholdValue = 8, ExpiryDate = new DateTime(2023, 06, 06), Availability = "In-stock" },
        new Product { Id = 9, Name = "Coca cola", BuyingPrice = 205, Quantity = 41, ThresholdValue = 10, ExpiryDate = new DateTime(2022, 12, 11), Availability = "Low stock" }
    };

    // GET: api/products
    [HttpGet]
    public ActionResult<IEnumerable<Product>> GetProducts()
    {
        return _products;
    }

    // GET: api/products/1
    [HttpGet("{id}")]
    public ActionResult<Product> GetProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }
        return product;
    }

    // POST: api/products
    [HttpPost]
    public ActionResult<Product> CreateProduct([FromBody] Product product)
    {
        product.Id = _products.Max(p => p.Id) + 1;
        product.Availability = CalculateAvailability(product.Quantity, product.ThresholdValue);
        _products.Add(product);
        return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
    }

    // PUT: api/products/1
    [HttpPut("{id}")]
    public IActionResult UpdateProduct(int id, [FromBody] Product updatedProduct)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        product.Name = updatedProduct.Name;
        product.BuyingPrice = updatedProduct.BuyingPrice;
        product.Quantity = updatedProduct.Quantity;
        product.ThresholdValue = updatedProduct.ThresholdValue;
        product.ExpiryDate = updatedProduct.ExpiryDate;
        product.Availability = CalculateAvailability(updatedProduct.Quantity, updatedProduct.ThresholdValue);

        return NoContent();
    }

    // DELETE: api/products/1
    [HttpDelete("{id}")]
    public IActionResult DeleteProduct(int id)
    {
        var product = _products.FirstOrDefault(p => p.Id == id);
        if (product == null)
        {
            return NotFound();
        }

        _products.Remove(product);
        return NoContent();
    }

    private string CalculateAvailability(int quantity, int thresholdValue)
    {
        if (quantity <= 0)
        {
            return "Out of stock";
        }
        else if (quantity <= thresholdValue)
        {
            return "Low stock";
        }
        else
        {
            return "In-stock";
        }
    }
    }
}