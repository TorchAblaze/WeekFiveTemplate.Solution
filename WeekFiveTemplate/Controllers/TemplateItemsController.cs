using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;
using WeekFiveTemplate.Models;

namespace WeekFiveTemplate.Controllers
{
  [Authorize]
  public class TemplateItemsController : Controller
  {
    private readonly WeekFiveTemplateContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public TemplateItemsController(UserManager<ApplicationUser> userManager, WeekFiveTemplateContext db)
    {
      _userManager = userManager;
      _db = db;
    }

     public async Task<ActionResult> Index()
    {
        var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var currentUser = await _userManager.FindByIdAsync(userId);
        var userItems = _db.TemplateItems.Where(entry => entry.User.Id == currentUser.Id).ToList();
        return View(userItems);
    }

     public ActionResult Create()
    {
      ViewBag.TemplateCategoryId = new SelectList(_db.TemplateCategories, "TemplateCategoryId", "Name");
      return View();
    }

    [HttpPost]
    public async Task<ActionResult> Create(TemplateItem item, int CategoryId)
    {
        var userId = this.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
        var currentUser = await _userManager.FindByIdAsync(userId);
        item.User = currentUser;
        _db.TemplateItems.Add(item);
        _db.SaveChanges();
        if (CategoryId != 0)
        {
            _db.TemplateCategoryItem.Add(new TemplateCategoryItem() { TemplateCategoryId = CategoryId, TemplateItemId = item.TemplateItemId });
        }
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
  }
}
