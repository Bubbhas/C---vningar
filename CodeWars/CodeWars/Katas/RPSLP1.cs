using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.Katas
{
    public class RPSLP1
    {
        public static string RPSLP(string  player1, string player2)
        {
            if (string.IsNullOrEmpty(player1) || string.IsNullOrEmpty(player2)) return "Oh, Unknown Thing";

            int p1 = GetStat(player1.ToLower());
            int p2 = GetStat(player2.ToLower());
            if (p1 == 0 || p2 == 0) return "Oh, Unknown Thing";
            if (player1 == player2 ) return "Draw!";
            int svar = p1 - p2;
            if(p1 == 1)
            {
                if (svar == -2 || svar == -4) return "Player 1 won!";
                else return "Player 2 won!";
            }
            if (p1 == 2)
            {
                if (svar == 1 || svar == -2) return "Player 1 won!";
                else return "Player 2 won!";
            }
            if (p1 == 3)
            {
                if (svar == 1 || svar == -2) return "Player 1 won!";
                else return "Player 2 won!";
            }
            if (p1 == 4)
            {
                if (svar == 1 || svar == 3) return "Player 1 won!";
                else return "Player 2 won!";
            }
            if (p1 == 5)
            {
                if (svar == 1 || svar == 3) return "Player 1 won!";
                else return "Player 2 won!";
            }

            return "";
        }

        private static int GetStat(string p)
        {
            if (p == "rock") return 1;
            if (p == "paper") return 2;
            if (p == "scissor") return 3;
            if (p == "spock") return 4;
            if (p == "lizard") return 5;
            else return 0;
        }
    }
}
