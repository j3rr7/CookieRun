using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieRun
{
    class Player
    {
        int []highscore;
        string []namaPlayer;
        int coin;
        string []cookie;
        string []pet;

        public Player()
        {
            this.Coin = 0;
        }


        public int Coin { get => coin; set => coin = value; }
        public string[] Cookie { get => cookie; set => cookie = value; }
        public string[] Pet { get => pet; set => pet = value; }
        public int[] Highscore { get => highscore; set => highscore = value; }
        public string[] NamaPlayer { get => namaPlayer; set => namaPlayer = value; }

        public override string ToString()
        {
            return NamaPlayer + " - " + Highscore;
        }
    }
}
