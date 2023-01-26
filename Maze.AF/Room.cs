using Factory.Enums;

namespace Factory;

public class Room : MapSite
{
    /// <summary>
    /// Номер комнаты. Каждая из комнат в лабиринте имеет свой уникальный номер.
    /// </summary>
    public int RoomNumber { get; set; }
    
    
    /// <summary>
    /// Ссылки на другие объекты MapSite
    /// </summary>
    private Dictionary<Direction, MapSite> sides;

    public Room(int roomNUmber)
    {
        RoomNumber = roomNUmber;
        sides = new Dictionary<Direction, MapSite>();
    }

    public override void Enter()
    {
        Console.WriteLine("Room");
    }
    
    public MapSite GetSide(Direction direction)
    {
        return sides[direction];
    }
    
    public void SetSide(Direction direction, MapSite mapSide)
    {
        sides.Add(direction, mapSide);
    }
}