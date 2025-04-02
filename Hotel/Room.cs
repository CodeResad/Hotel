namespace Hotel;

public class Room
{
    private static int _id;
    public int Id { get; }

    public string Name { get; set; }

    public double Price { get; set; }

    public byte PersonCapacity { get; set; }

    public bool IsAvailable { get; set; }

    public Room(string name, double price, byte personCapacity)
    {
        _id++;
        Id = _id;
        Name = name;
        Price = price;
        PersonCapacity = personCapacity;
        IsAvailable = true;
    }

    public string ShowInfo()
    {
        return
            $"Id: {Id}, Name: {Name}, Price: {Price}, PersonCapacity: {PersonCapacity}, IsAvailable: {(IsAvailable ? "Empty" : "Full")}";
    }

    public override string ToString()
    {
        return ShowInfo();
    }
}