
using Factory.Enums;

namespace Factory;

public class MazeGame
{
    /// <summary>
    /// Cоздает лабиринт состоящий из двух комнат с одной дверью между ними и возвращает ссылку на экземпляр созданного лабиринта.
    /// </summary>
    /// <returns>Лабиринт</returns>
    public Maze CreateMaze()
    {
        // лабиринт
        var maze = new Maze();
        
        // две комнаты между ними
        var r1 = new Room(1);
        var r2 = new Room(2);
        
        // дверь между двумя комнатами
        var door = new Door(r1, r2);
        
        maze.AddRoom(r1);
        maze.AddRoom(r2);
        
        r1.SetSide(Direction.North, new Wall());
        r1.SetSide(Direction.East, door);
        r1.SetSide(Direction.South, new Wall());
        r1.SetSide(Direction.West, new Wall());
        
        r2.SetSide(Direction.North, new Wall());
        r2.SetSide(Direction.East, new Wall());
        r2.SetSide(Direction.South, new Wall());
        r2.SetSide(Direction.West, door);

        return maze;
    }
}