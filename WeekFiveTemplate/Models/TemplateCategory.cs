using System.Collections.Generic;

namespace WeekFiveTemplate.Models
{
  public class TemplateCategory
  {
    public TemplateCategory()
    {
      this.JoinEntities = new HashSet<TemplateCategoryItem>();
    }

    public int TemplateCategoryId { get; set; }
    public string SomeProperty { get; set; }
    public virtual ICollection<TemplateCategoryItem> JoinEntities { get; set; }
  }
}