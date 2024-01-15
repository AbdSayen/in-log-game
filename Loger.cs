using System.Collections.Generic;

public static class Loger{
    public static List<string> logs = new List<string>();
	
	public static void AddLog(string message, Time time){
	    logs.Add(time.GetTime() + " " + message);
		if(logs.Count >= 16) {
		    logs.RemoveAt(0);
		}
	}
	
	public static void Render(){
        Console.WriteLine("\n\nLogs:\n");
		
		string message = "";
		
        for (int i = 0; i < logs.Count; i++)
        {
            message += logs[i] + "\n";
        }

        Console.WriteLine(message);
    }
}