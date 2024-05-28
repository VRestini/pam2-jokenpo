using CommunityToolkit.Mvvm.ComponentModel;
using Jokenpo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Jokenpo.ViewModels
{
    partial class GameViewModel : ObservableObject
    {
        [ObservableProperty]
        private string _nome;

        [ObservableProperty]
        private int _score;

        [ObservableProperty]
        private string _playerImage;

        [ObservableProperty]
        private string _enemyImage;

        [ObservableProperty]
        private Choice _playerChoice;

        [ObservableProperty]
        private string _result;

        Player player = new Player();

        public void Play()
        {
            Player enemy = new Player();
            enemy.MakeChoice();
            player.Choice = PlayerChoice;
            if (enemy.Choice == player.Choice)
            {
                Result = "empatou";
                player.score++;
            }

            
        }
        public GameViewModel()
        {

        }

    }
}
