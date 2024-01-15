using System;
using System.Linq;
using System.Collections.Generic;

public class Item : Tile
{         
    public new TileType tileType = TileType.item;
    public string name { get; private set; } = "";
}
