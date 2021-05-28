using Microsoft.EntityFrameworkCore;

namespace WeekFourTemplate.Models
{
  public class WeekFourTemplateContext : DbContext
  {
    public virtual DbSet<TemplateCategory> TemplateCategories { get; set; }
    public DbSet<TemplateItem> TemplateItems { get; set; }
    public DbSet<TemplateCategoryItem> TemplateCategoryItem { get; set; }
    
    public WeekFourTemplateContext(DbContextOptions options) : base(options) { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseLazyLoadingProxies();
    }
  }
}