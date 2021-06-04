using Microsoft.AspNetCore.Mvc;

namespace WeekFiveTemplate.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}