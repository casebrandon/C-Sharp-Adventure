using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPAdventure;

public partial class House
{
    public Player Player { get; }
    private readonly Random _random = new(1234);

    public int Width { get; set; }
    public int Height { get; set; }
    public Room[] Rooms { get; private set; }

    public House(Player player)
    {
        Player = player;
    }
}
