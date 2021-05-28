using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WeekFourTemplate.Models;

namespace WeekFourTemplate.Controllers
{
  public class TemplateItemsController : Controller
  {
    private readonly WeekFourTemplateContext _db;

    public TemplateItemsController(WeekFourTemplateContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.TemplateItems.ToList());
    }
  }
}
