using Microsoft.AspNetCore.Mvc;

namespace WeekThreeTemplate.Controllers
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