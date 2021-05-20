using Microsoft.EntityFrameworkCore;

namespace WeekThreeTemplate.Models
{
  public class WeekThreeTemplateContext : DbContext
  {
    public virtual DbSet<TemplateCategory> TemplateCategories { get; set; }
    public DbSet<TemplateItem> TemplateItems { get; set; }

    public WeekThreeTemplateContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}