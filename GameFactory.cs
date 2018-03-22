using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab_2;

namespace GameFactory
{
    public class GameFactory
    {
        List<Game> gameList = new List<Game>();

        public void CreateGameList()
        {
            Game games;
            games = new Game("Celtics", "Rockets", 78, 90);
            gameList.Add(games);

            games = new Game("Red Sox", "Yankees", 5, 9);
            gameList.Add(games);

            games = new Game("Patriots", "Seahawks", 21, 28);
            gameList.Add(games);

            games = new Game("Dolphins", "Raiders", 49, 0);
            gameList.Add(games);

            games = new Game("Hurricanes", "Panters", 36, 70);
            gameList.Add(games);

            games = new Game("Jaguars", "Vikings", 14, 9);
            gameList.Add(games);
        }
    }
}
