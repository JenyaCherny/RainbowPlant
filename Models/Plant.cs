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
    [RegularExpression(@"^\d+(\.\d{1,2})?$",
       ErrorMessage = "The Unit Price cannot exceed 2 decimal places. Please Enter again")]
    public decimal UnitPrice { get; set; }
}






