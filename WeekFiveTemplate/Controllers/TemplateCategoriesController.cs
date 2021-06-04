using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using WeekFiveTemplate.Models;
using System.Collections.Generic;
using System.Linq;

namespace WeekFiveTemplate.Controllers
{
  public class TemplateCategoriesController : Controller
  {
    private readonly WeekFiveTemplateContext _db;

    public TemplateCategoriesController(WeekFiveTemplateContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<TemplateCategory> model = _db.TemplateCategories.ToList();
      return View(model);
    }
  }
}