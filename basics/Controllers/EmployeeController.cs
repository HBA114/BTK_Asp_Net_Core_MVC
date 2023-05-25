using basics.Models;

using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class EmployeeController : Controller
{
    public IActionResult Index1()
    {
        string message = $"Hello World ,{DateTime.Now.ToString()}";
        return View("Index1", message);
    }

    public ViewResult Index2()
    {
        var names = new string[]{
            "Ahmet",
            "Mehmet",
            "Can"
        };

        return View(names);
    }

    public IActionResult Index3()
    {
        var list = new List<Employee>{
            new(1, "Hasan", "Ayhaner", 23),
            new(2, "Mustafa", "Ayhaner", 14),
            new(3, "Ahmet", "Ayhaner", 12),
    };
        return View("Index3", list);
    }
}
