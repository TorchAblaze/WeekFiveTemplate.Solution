using System.Collections.Generic;

namespace WeekThreeTemplate.Models
{
  public class TemplateCategory
  {
    public TemplateCategory()
    {
      this.TemplateItems = new HashSet<TemplateItem>();
    }

    public int TemplateCategoryId { get; set; }
    public string SomeProperty { get; set; }
    public virtual ICollection<TemplateItem> TemplateItems { get; set; }
  }
}