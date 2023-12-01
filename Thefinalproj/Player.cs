using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thefinalproj
{
    public class Player
    {
        public Player(string firstName, string lastName, int gamesPlayed, int goals, int assists, int yellowCards, int redCards )
        {
            FirstName = firstName;
            LastName = lastName;    
            GamesPlayed = gamesPlayed;
            Goals = goals;
            Assists = assists;
            YellowCards = yellowCards;
            RedCards = redCards;
        }

        public string FirstName;
        public string LastName;
        public int GamesPlayed;
        public int Goals;
        public int Assists;
        public int YellowCards;
        public int RedCards;
    }
}
