public class Time{
    private int hour = 0;
	private int minute = 0;
	public Time(int hour, int minute){
	    this.hour = hour;
		this.minute = minute;
	}
	
	
	private void Stack(){
	    while(minute >= 60){
		    hour++;
			minute = 0;
		}
	}
	
	public void Wait(int value){
	    minute += value;
		Stack();
	}
	
	public string GetTime(){
	    if(minute >= 10){
			return $"{hour}:{minute}";
		}
        else {
		    return $"{hour}:{"0" + minute}";
		}
	}
}