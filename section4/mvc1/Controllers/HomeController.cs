using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mvc1.Models;

namespace mvc1.Controllers;

public class HomeController : Controller
{
    private IRepository _repository;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private string message;
    public HomeController(IRepository repository,
     IHttpContextAccessor httpContextAccessor)
    {
        _repository = repository;
        _httpContextAccessor = httpContextAccessor;
        var hostname = _httpContextAccessor.HttpContext.Request.Host.Value;
        message = $"Docker - ({hostname})";
    }
    public IActionResult Index()
    {
        ViewBag.Message = message;
        return View(_repository.Products);
    }
}
