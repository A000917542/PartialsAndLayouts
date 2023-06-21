using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var data = new List<TestModel>() {
            new TestModel {ColA = "Hello", ColB = 23, ColC = 1.4f},
            new TestModel {ColA = "Hello3", ColB = 63, ColC = 3.4f},
            new TestModel {ColA = "Hello4", ColB = 75, ColC = 8.4f},
            new TestModel {ColA = "Hello5", ColB = 34, ColC = 5.4f}
        };

        return View(data);
    }

    public IActionResult Book()
    {
        var book = new List<Book> {
        
            new Book {
                Title = "Test Title",
                Author = "Test Author",
                Pages = 25
            },

            new Book {
                Title = "Test Title2",
                Author = "Test Author2",
                Pages = 678
            },

            new Book {
                Title = "Test Title3",
                Author = "Test Author3",
                Pages = 456
            }
        };

        return View(book);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
