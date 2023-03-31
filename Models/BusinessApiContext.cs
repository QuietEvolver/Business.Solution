using Microsoft.EntityFrameworkCore;

namespace BusinessApi.Models
{
  public class BusinessApiContext : DbContext
  {
    public DbSet<Business> Businesss { get; set; }
    public BusinessApiContext(DbContextOptions<BusinessApiContext>options) : base(options)
    {

    }

    // DB SEED:
    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId=1, Name="Matilda", Species="Wooly Mammoth", Age=7 }, 
          new Business { BusinessId=2, Name="Rexi", Species="Dinosaur", Age=10 }, 
          new Business { BusinessId=3, Name="Matilda", Species="Dinosaur", Age=2 }, 
          new Business { BusinessId=4, Name="Pip", Species="Shark", Age=4 }, 
          new Business { BusinessId=5, Name="Bartholomew", Species="Dinosaur", Age=22 } 
        );
    }
  }
}