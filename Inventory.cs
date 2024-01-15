using System.Collections.Generic;

public class Inventory{
    public List<Item> items = new List<Item>();
	
	public void AddItems(List<Item> items){
        for (int i = 0; i < items.Count; i++)
        {
            this.items.Add(items[i]);
        }
	}
	
	public void Show(){
	    string output = "";
        for (int i = 0; i < items.Count; i++)
        {
            output += items[i].name;
        }
    }
}