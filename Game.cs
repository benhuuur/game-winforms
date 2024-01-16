using System.Collections.Generic;

public class Game
{
    private static Game crr = new Game();
    public static Game Current => crr;
    public static void New()
        => crr = new Game();

    public static void Load(Game game)
        => crr = game;

    public Player Player {get;set;}
    
    public List<object> BossList {get; set;} = new List<object>();
}