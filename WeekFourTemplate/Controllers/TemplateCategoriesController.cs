using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WeekFourTemplate.Models;

namespace WeekFourTemplate.Controllers
{
  public class TemplateCategoriesController : Controller
  {
    private readonly WeekFourTemplateContext _db;

    public TemplateCategoriesController(WeekFourTemplateContext db)
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