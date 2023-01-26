namespace Factory;

/// <summary>
/// Класс Maze используется для представления лабиринта, как набора комнат.
/// </summary>
public class Maze
{
    private Dictionary<int, Room> rooms;

    public Maze()
    {
        rooms = new Dictionary<int, Room>();
    }

    public void AddRoom(Room room)
    {
        rooms.Add(room.RoomNumber, room);
    }
    
    /// <summary>
    /// Для получения ссылки на экземпляр комнаты по ее номеру
    /// </summary>
    /// <param name="number"></param>
    /// <returns></returns>
    public Room GetRoom(int number)
    {
        return rooms[number];
    }
}