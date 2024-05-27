namespace Jokenpo.Models;

public class Enemy : ContentPage
{
	public Enemy()
	{
		private string choise { get; set; }
		public string Play(String playerChoise)
		{
			int caseDrawn = new Random().Next(3);
			if (caseDrawn == 0) { choise = "Pedra"; }
			else if (caseDrawn == 1) { choise = "Papel"; }
			else { choise = "Tesoura"; }
			if (choise == "Papel" && playerChoise == "Pedra" ) {
			return "Você perdeu.";
		}
			else { return "a"; }
    }

	}
}