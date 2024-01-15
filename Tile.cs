using System;

public class Tile{
    public TileType tileType;
	
	public string GetSymbol (){	
        switch (tileType){
		    case TileType.empty:
			    return "  ";
			case TileType.player:
			    return "@ ";
			case TileType.item:
			    return "$ ";
			case TileType.wall:
			    return "# ";
			default:
			    break;
		}
		
		Console.ForegroundColor = ConsoleColor.Red;
		return "! ";
    }
}

public enum TileType{
    empty,
    player,
	animal,
	item,
	wall
}