namespace Cars.API.Models;

public class CarDto
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public string FullName => $"{Brand} {Model}";

    public bool IsNew => Year >= DateTime.Now.Year - 1;
}
