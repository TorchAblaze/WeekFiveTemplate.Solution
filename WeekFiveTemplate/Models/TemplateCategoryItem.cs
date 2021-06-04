namespace WeekFiveTemplate.Models
{
  public class TemplateCategoryItem
  {
    public int TemplateCategoryItemId { get; set; }
    public int TemplateItemId { get; set; }
    public int TemplateCategoryId { get; set; }
    public virtual TemplateItem TemplateItem { get; set; }
    public virtual TemplateCategory TemplateCategory { get; set; }
  }
}