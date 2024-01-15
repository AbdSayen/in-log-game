public class Game{	
    World world = new World();
		
    public void Start(){		
		world.Generate();
		world.Render();
	    GameLoop();
	}
	
	private void GameLoop(){
        while (true)
        {	
		    string input = Console.ReadKey().Key.ToString();
			
			if(input == "W" || input == "A" || input == "S" || input == "D")
			{
			    world.player.TakeControll(world, input);
				world.time.Wait(2);
			}
			else if(input == "I"){
			    world.player.inventory.Show();
			}
			else if (input == "B")
			{
			    break;
			}

            Console.Clear();
            Console.WriteLine(Console.WindowWidth);
            world.Render();
            Loger.Render();
        }
    }
}