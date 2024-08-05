using Microsoft.AspNetCore.Mvc;
using ProductTask2.Models;

namespace ProductTask2.Controllers;

public class ProductController : Controller
{

    public static List<Product> Products { get; set; }

    static ProductController()
    {
        Products = new List<Product>();
        for (int i = 1; i <= 10; i++)
        {

            int quantity = i;
            double price = i+5;
            Products.Add(new Product(i, $"Product{i}", quantity, price));
        }
    }


    public IActionResult Index()
    {
        return View(Products);
    }

    
    public IActionResult GetProductById(int id)
    {
        var pr = Products.FirstOrDefault(pr => pr.Id == id)!;
        return View("ProductDetail",pr);
    }
   
    [HttpGet("Product/GetProductByPrice/{price}")]
    public IActionResult GetProductByPrice(double price)
    {
        var pr = Products.FirstOrDefault(pr => pr.Price == price)!;
        return View("ProductDetail", pr);
    }

    [HttpGet]
    public IActionResult AddProduct()
    {
        return View();
    }

    [HttpPost]
    public IActionResult AddProduct(Product product)
    {

        Products.Add(product);
        return RedirectToAction("Index");
    }
    
    [HttpPost]
    public IActionResult RemoveProduct(int Id)
    {
        var pr = Products.FirstOrDefault(pr => pr.Id == Id)!;
        Products.Remove(pr);
        return RedirectToAction("Index");
    }

}
