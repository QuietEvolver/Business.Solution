using Microsoft.EntityFrameworkCore;

namespace BusinessApi.Models
{
  public class BusinessApiContext : DbContext
  {
    public DbSet<Business> Businesses { get; set; }
    public BusinessApiContext(DbContextOptions<BusinessApiContext>options) : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Business>()
        .HasData(
          new Business { BusinessId=1, Name="Matilda's Bistro", Type="Restaurant", YearsInBusiness=7 }, 
          new Business { BusinessId=2, Name="Rexi Teacups", Type="Shop", YearsInBusiness=10 }, 
          new Business { BusinessId=3, Name="Matilda Toys", Type="Shop", YearsInBusiness=2 }, 
          new Business { BusinessId=4, Name="Pip's Pizza & Brew", Type="Restaurant", YearsInBusiness=4 }, 
          new Business { BusinessId=5, Name="Bartholomew Pet Shop", Type="Shop", YearsInBusiness=22 } 
        );
    }
  }
}