using System.Collections.Generic;

namespace WeekFourTemplate.Models
{
  public class TemplateItem
  {
    public TemplateItem()
    {
      this.JoinEntities = new HashSet<TemplateCategoryItem>();
    }

    public int TemplateItemId { get; set; }
    public int SomeProperty { get; set; }
    public virtual ICollection<TemplateCategoryItem> JoinEntities { get; }
  }
}