namespace Hotel;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Create Hotel");
        Console.WriteLine("Enter Hotel Name: ");
        string hotelName = Console.ReadLine();
        
        Hotel hotel = new Hotel(hotelName);
        Room[] createdRooms = new Room[0];
        
        
        do
        {
            Console.WriteLine("1. Create a room ");
            Console.WriteLine("2. Add room ");
            Console.WriteLine("3. Make reserve ");
            Console.WriteLine("4. Show created rooms ");
            Console.WriteLine("5. Show existing rooms ");
            Console.WriteLine("0. Exit");
            Console.WriteLine();
            Console.WriteLine("Select an option: ");
            
            int choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1: 
                    Console.WriteLine("Enter room name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine("Enter room price: ");
                    double price = double.Parse(Console.ReadLine());
                    Console.WriteLine("Enter room Capacity: ");
                    byte capacity = byte.Parse(Console.ReadLine());
                    Room newRoom = new Room(name, price, capacity);
                    
                    Array.Resize(ref createdRooms, createdRooms.Length + 1);
                    createdRooms[createdRooms.Length - 1] = newRoom;
                    
                    Console.WriteLine("Room succesfully created!");
                    
                    break;
                case 2:
                    if (createdRooms.Length == 0)
                    {
                        Console.WriteLine("No room created yet!");
                    }
                    else
                    {
                        foreach (Room item in createdRooms)
                        {
                            hotel.AddRoom(item);
                        }
                        
                        createdRooms = new Room[0];
                        Console.WriteLine("Room successfully added! ");
                    }
                    
                    break;
                case 3:
                    Console.Write("Enter room ID to reserve: ");
                    int reserveId = int.Parse(Console.ReadLine());
                    hotel.MakeReservation(reserveId);
                    break;
                case 4:
                    if (createdRooms.Length == 0)
                    {
                        Console.WriteLine("No rooms created yet!");
                    }
                    else
                    {
                        foreach (Room item in createdRooms)
                        {
                            Console.WriteLine(item.ToString());
                        }
                    }
                    break;
                case 5:
                    hotel.ShowRooms();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }
            
            
            
        } while (true);
    }
    
}