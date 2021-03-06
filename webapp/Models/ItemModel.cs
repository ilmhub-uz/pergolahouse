namespace webapp.Models;

public class ItemModel
{
    public int Id { get; set; }
    
    public string DetailImage { get; set; }

    public string Tag { get; set; }

    public string Title { get; set; }

    public string Description { get; set; }
    
    public double Cost { get; set; }

    public string Category { get; set; }

    public string UnitOfMeasurement { get; set; }
}