using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SimpleApp.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using static SimpleApp.Models.Product;

namespace SimpleApp.Controllers
{
    public class HomeController : Controller
    {


        public IDataSource dataSource = new ProductDataSource();


    //    private readonly ILogger<HomeController> _logger;

    //    public HomeController(ILogger<HomeController> logger)
    //    {
    //        _logger = logger;
    //    }

    //    public IActionResult Index()
    //    {
    //        return View();
    //    }

    //    public IActionResult Privacy()
    //    {
    //        return View();
    //    }

    //    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    //    public IActionResult Error()
    //    {
    //        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    //    }


        public ViewResult Index()
        {
            //return View(Product.GetProducts());
            return View(dataSource.Products);
        }

    }
}
