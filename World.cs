using System.Collections.Generic;

public class World{
    public System.Random rnd = new System.Random(110224);
    public List<List<Tile>> tileMap = new List<List<Tile>>();
    public List<List<Tile>> spiritTileMap = new List<List<Tile>>();
	public List<List<List<Tile>>> itemsTileMap = new List<List<List<Tile>>>();
	public int size;
	public Player player = new Player();
	public Time time = new Time(8, 0);

    public void Generate(){
	    GenerateField(15);
		GenerateWalls();
		GeneratePlayer();
		GenerateItems();
	}
	
	public void GeneratePlayer(){	
	    player.pos.SetPosition(rnd.Next(size), rnd.Next(size));
	}
	
	private void GenerateField(int size){
	    this.size = size;
		
        for (int y = 0; y < this.size; y++)
        {
		    tileMap.Add(new List<Tile>());
			spiritTileMap.Add(new List<Tile>());
			itemsTileMap.Add(new List<List<Tile>>());
            for (int x = 0; x < this.size; x++)
            {	
                tileMap[y].Add(new Tile());
				spiritTileMap[y].Add(new Tile());
				itemsTileMap[y].Add(new List<Tile>());
            }
        }
    }
	
	private void GenerateItems(){
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                for (int i = 0; rnd.Next(100) < 7 && tileMap[x][y].tileType == TileType.empty; i++)
                {
                    itemsTileMap[x][y].Add(new Item());
					itemsTileMap[x][y][i].tileType = TileType.item;
                }
            }
        }
    }
	
	private void GenerateWalls(){
        for (int y = 0; y < size; y++)
        {
            for (int x = 0; x < size; x++)
            {
                if (y == size - 1 || y == 0 || x == size - 1 || x == 0)
                {
                    tileMap[x][y].tileType = TileType.wall;
                }
            }
        }
    }
    	
	public void Render(){		
	    string graps = "";
        for (int y = 0; y < size; y++)
        {	
		    string grapsX = "";
            for (int x = 0; x < size; x++)
            {
                if (spiritTileMap[x][y].tileType != TileType.empty)
                {
                    grapsX += spiritTileMap[x][y].GetSymbol();
                }
				else if (itemsTileMap[x][y].Count >= 1){
				    grapsX += itemsTileMap[x][y][0].GetSymbol();
				}
				else {
				    grapsX += tileMap[x][y].GetSymbol();
				}
            }
            graps += "\n" + grapsX;
        }
        Console.WriteLine(graps);
    }
}