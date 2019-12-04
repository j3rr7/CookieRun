using System.Drawing;

namespace CookieRun
{
    class Coin
    {
 
        public string jenis { get; set; }
        public int value { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }

        Image temp;
        private Bitmap imgCoin = null;

        public Coin(string jenis, int value, int x, int y, int w, int h)
        {
            this.jenis = jenis;
            this.value = value;
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
        }

        public Image drawCoin()
        {
            int ran = 1;
            if (ran == 0)
            {
                return CookieRun.Properties.Resources.silverCoin;
            }
            else
            {
                return CookieRun.Properties.Resources.goldCoin;
            }
        }
        public Rectangle getCoin()
        {
            return new Rectangle(x,y,w,h);
        }

    }
    class CoinKecil : Coin
    {
        public CoinKecil(int x, int y) : base("kecil",10,x,y,40,40)
        {

        }
    }
    class CoinBesar : Coin
    {
        public CoinBesar(int x, int y) : base("besar",100,x,y,50,50)
        {

        }
    }
}
