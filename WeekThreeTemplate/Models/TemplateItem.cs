namespace WeekThreeTemplate.Models
{
  public class TemplateItem
  {
    public int TemplateItemId { get; set; }
    public int TemplateCategoryId { get; set; }
    public virtual TemplateCategory TemplateCategory { get; set; }
  }
}