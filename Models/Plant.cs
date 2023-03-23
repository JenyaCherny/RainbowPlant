using System.ComponentModel.DataAnnotations;

namespace RainbowPlant.Models;

public class Plant
{
    public int Id { get; set; }
    public string? PlantName { get; set; }
    public string? PlantDescription { get; set; }
    [DataType(DataType.Date)]
    public DateTime DateDelivered { get; set; }
    public int Quantity { get; set; }
    [Range(0.01, 100.00,
        ErrorMessage = "Price must be between 0.01 and 100.00")]
    public decimal UnitPrice { get; set; }
}






