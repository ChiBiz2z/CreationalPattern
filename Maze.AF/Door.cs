namespace Factory;

public class Door : MapSite
{
    private bool _isOpen;
    Room room1 = null;
    Room room2 = null;

    public Door(Room room1, Room room2)
    {
        this.room1 = room1;
        this.room2 = room2;
    }


    public override void Enter()
    {
        Console.WriteLine("Door");
    }

    public Room OtherSideFrom(Room room) => room == room1 ? room2 : room1;
}