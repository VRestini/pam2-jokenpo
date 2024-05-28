namespace Jokenpo.Models;

public class Player
{
    public string Name { get; set; }
    public int score { get; set; }
    public Choice Choice { get; set; }
    
	public void MakeChoice()
	{
		Choice =  (Choice) new Random().Next(3);
    }
	
}