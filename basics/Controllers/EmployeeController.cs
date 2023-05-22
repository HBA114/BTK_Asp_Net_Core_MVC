using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

public class EmployeeController : Controller
{
    public string Index()
    {
        return "Hello";
    }

    public ViewResult Index2()
    {
        return View();
    }

    public IActionResult Index3()
    {
        return Content("Employee");
    }
}
