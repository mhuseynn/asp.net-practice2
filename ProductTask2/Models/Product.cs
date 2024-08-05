namespace ProductTask2.Models;

public class Product
{
    public Product() { }
    public Product(int id, string name, int quantity, double price)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
        Price = price;
    }

    public int Id { get; set; }

    public string Name { get; set; }

    public int Quantity { get; set; }

    public double Price { get; set; }


}
