using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WeekThreeTemplate.Models;

namespace WeekThreeTemplate.Controllers
{
  public class TemplateCategoriesController : Controller
  {
    private readonly WeekThreeTemplateContext _db;

    public TemplateCategoriesController(WeekThreeTemplateContext db)
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