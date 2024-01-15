using System;
using System.Collections.Generic;

public class Player(){
    public VectorPos pos = new VectorPos();
	public Inventory inventory = new Inventory();
	
	public void TakeControll(World world, string input){	
        world.spiritTileMap[pos.x][pos.y].tileType = TileType.empty;
        Move(world, input);
		world.spiritTileMap[pos.x][pos.y].tileType = TileType.player;
	}
	
	public void PickItem(List<Item> items){
	    inventory.AddItems(items);
	}
	
	private void Move(World world, string input){		
        switch (input){
		    case "W":
			    if(world.tileMap[pos.y - 1][pos.x].tileType == TileType.empty){
				    pos.y--;
				}
				else {
				    Loger.AddLog("There are obstacles ahead, it’s impossible to pass", world.time);
				}
                break;
			case "S":
				if(world.tileMap[pos.y + 1][pos.x].tileType == TileType.empty){
					pos.y++;
				}
				else {
				    Loger.AddLog("There are obstacles ahead, it’s impossible to pass", world.time);
				}
				break;
			case "A":
				if(world.tileMap[pos.y][pos.x - 1].tileType == TileType.empty){
				    pos.x--;
				}
				else {
				    Loger.AddLog("There are obstacles ahead, it’s impossible to pass", world.time);
				}
				break;
			case "D":
			    if(world.tileMap[pos.y][pos.x + 1].tileType == TileType.empty)
				{
				    pos.x++;
				}
				else {
				    Loger.AddLog("There are obstacles ahead, it’s impossible to pass", world.time);
				}
				break;
			default:
			    break;
		}
    }
}

public class VectorPos{
    public int x;
	public int y;
	
	public void SetPosition(int x, int y){
	    this.x = x;
		this.y = y;
	}
}