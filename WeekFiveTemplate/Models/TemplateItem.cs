using System.Collections.Generic;

namespace WeekFiveTemplate.Models
{
  public class TemplateItem
  {
    public TemplateItem()
    {
      this.TemplateCategories = new HashSet<TemplateCategoryItem>();
    }

    public int TemplateItemId { get; set; }
    public int SomeProperty { get; set; }
    public virtual ApplicationUser User { get; set; }
    public virtual ICollection<TemplateCategoryItem> TemplateCategories { get; }
  }
}