using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Cars.API.Entities;

[Table("Cars")]
public class Car
{
    [Key]
    public int Id { get; set; }

    public string Brand { get; set; } // Manufacturer of the car (e.g., Toyota, Ford)
    public string Model { get; set; } // Model of the car (e.g., Camry, Mustang)
    public int Year { get; set; } // Year of manufacture
    public string Color { get; set; } // Color of the car
    public string VIN { get; set; } // Unique Vehicle Identification Number
}
