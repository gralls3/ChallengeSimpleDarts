using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Darts;

namespace ChallengeSimpleDarts
{
    public class Game
    {
        private Player _playerOne;//creates placeholder for Player obj named _pl*One
        private Player _playerTwo;

        private Random _random;
    //CONSTRUCTOR METHOD
        public Game(string playerOneName, string playerTwoname)//passing names
        {
            _playerOne = new Player();//instantiates player obj. _pl*One
            _playerOne.Name = playerOneName;//sets _pl*One name

            _playerTwo = new Player();
            _playerTwo.Name = playerTwoname;

            _random = new Random();
        }

        public string Play()
        {
            while (_playerOne.Score < 300 && _playerTwo.Score < 300)//play while both players < 300
            {
                playRound(_playerOne);
                playRound(_playerTwo);
            }
            return displayResults();
        }

        private string displayResults()
        {
            string result = String.Format("{0}: {1}<br/>{2}: {3}",
                _playerOne.Name,
                _playerOne.Score,
                _playerTwo.Name,
                _playerTwo.Score);

            return result += "<br/>Winner: " +
                (_playerOne.Score > _playerTwo.Score ? _playerOne.Name : _playerTwo.Name);
        }

        private void playRound(Player player)
        {
            for (int i = 0; i < 3; i++)//3 throws of dart
            {
                Dart dart = new Dart(_random);
                dart.Throw();
                Score.ScoreDart(player, dart);
            }
        }
    }
}