using Microsoft.AspNetCore.Mvc;

namespace RecruitingWeb.Controllers;

public class JobsController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}