
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace WeekFourTemplate.Models
{
  public class WeekFourTemplateContextFactory : IDesignTimeDbContextFactory<WeekFourTemplateContext>
  {

    WeekFourTemplateContext IDesignTimeDbContextFactory<WeekFourTemplateContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<WeekFourTemplateContext>();

      builder.UseMySql(configuration["ConnectionStrings:DefaultConnection"], ServerVersion.AutoDetect(configuration["ConnectionStrings:DefaultConnection"]));

      return new WeekFourTemplateContext(builder.Options);
    }
  }
}