using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieRun
{
    class Player
    {
        int highscore;
        string namaPlayer;
        int coin;
        string []cookie;
        string []pet;

        public Player()
        {
            this.highscore = 0;
            this.namaPlayer = "";
            this.Coin = 20000;
        }


        public int Coin { get => coin; set => coin = value; }
        public string[] Cookie { get => cookie; set => cookie = value; }
        public string[] Pet { get => pet; set => pet = value; }

        public override string ToString()
        {
            return namaPlayer + " - " + highscore;
        }
    }
}
