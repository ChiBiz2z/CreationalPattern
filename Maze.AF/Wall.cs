namespace Factory;

/// <summary>
/// Стена
/// </summary>
public class Wall : MapSite
{
    public override void Enter()
    {
        Console.WriteLine("Wall");
    }
}