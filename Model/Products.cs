namespace Reinigungsverwaltung.Application.Reinigungsverwaltung.Model;

public class Products
{
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime ExpirationDate { get; set; }

    public Products(int id, string name, string description, DateTime expirationDate)
    {
        Id = id;
        Name = name;
        Description = description;
        ExpirationDate = expirationDate;
    }

    
}