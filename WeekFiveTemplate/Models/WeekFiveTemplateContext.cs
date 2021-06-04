using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WeekFiveTemplate.Models
{
  public class WeekFiveTemplateContext : IdentityDbContext<ApplicationUser>
  {
    public virtual DbSet<TemplateCategory> TemplateCategories { get; set; }
    public DbSet<TemplateItem> TemplateItems { get; set; }
    public DbSet<TemplateCategoryItem> TemplateCategoryItem { get; set; }

    public WeekFiveTemplateContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}