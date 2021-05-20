using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using WeekThreeTemplate.Models;

namespace WeekThreeTemplate.Controllers
{
  public class TemplateItemsController : Controller
  {
    private readonly WeekThreeTemplateContext _db;

    public TemplateItemsController(WeekThreeTemplateContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<TemplateItem> model = _db.TemplateItems.Include(templateItem => templateItem.TemplateCategory).ToList();
      return View(model);
    }
  }
}
