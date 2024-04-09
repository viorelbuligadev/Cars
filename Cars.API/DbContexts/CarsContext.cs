using Cars.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cars.API.DbContexts;

public class CarsContext : DbContext
{
    public DbSet<Car> Cars { get; set; } = null!;

    public CarsContext(DbContextOptions<CarsContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>().HasData(
            new  { Id = 1, Brand = "Toyota", Model = "Camry", Year = 2020, Color = "Red", VIN = "1HGBH41JXMN109186" },
            new  { Id = 2, Brand = "Ford", Model = "Mustang", Year = 2021, Color = "Blue", VIN = "1HGBH41JXMN109187" },
            new  { Id = 3, Brand = "Chevrolet", Model = "Camaro", Year = 2019, Color = "Black", VIN = "1HGBH41JXMN109188" },
            new  { Id = 4, Brand = "Tesla", Model = "Model S", Year = 2022, Color = "White", VIN = "1HGBH41JXMN109189" },
            new  { Id = 5, Brand = "Nissan", Model = "Altima", Year = 2018, Color = "Grey", VIN = "1HGBH41JXMN109190" },
            new  { Id = 6, Brand = "Honda", Model = "Civic", Year = 2020, Color = "Silver", VIN = "1HGBH41JXMN109191" },
            new  { Id = 7, Brand = "BMW", Model = "3 Series", Year = 2021, Color = "Blue", VIN = "1HGBH41JXMN109192" },
            new  { Id = 8, Brand = "Audi", Model = "A4", Year = 2019, Color = "White", VIN = "1HGBH41JXMN109193" },
            new  { Id = 9, Brand = "Mercedes-Benz", Model = "C-Class", Year = 2022, Color = "Black", VIN = "1HGBH41JXMN109194" },
            new  { Id = 10, Brand = "Volkswagen", Model = "Golf", Year = 2018, Color = "Red", VIN = "1HGBH41JXMN109195" },
            new { Id = 11, Brand = "Mazda", Model = "CX-5", Year = 2023, Color = "Red", VIN = "1HGBH41JXMN109199" }
        );

        base.OnModelCreating(modelBuilder);
    }
}
