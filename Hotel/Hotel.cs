namespace Hotel;

public class Hotel
{
    public string Name { get; set; }

    private Room[] rooms;

    public Hotel(string name)
    {
        Name = name;
        rooms = new Room[0];
    }

    public void AddRoom(Room room)
    {
        Array.Resize(ref rooms, rooms.Length + 1);
        rooms[rooms.Length - 1] = room;
    }

    public void MakeReservation(int id)
    {
        for (int i = 0; i < rooms.Length; i++)
        {
            if (rooms[i].Id == id)
            {
                if (rooms[i].IsAvailable)
                {
                    rooms[i].IsAvailable = false;
                    Console.WriteLine("Reservation Successfully Made!");
                }
                else
                {
                    Console.WriteLine("Room is Full!");
                }
            }
        }
    }

    public void ShowRooms()
    {
        if (rooms.Length == 0)
        {
            Console.WriteLine("There are no rooms");
        }
        else
        {
            foreach (Room item in rooms)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
    
    
}