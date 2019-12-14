using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace CookieRun
{
    class Obstacle
    {
        public int jenis { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public int w { get; set; }
        public int h { get; set; }
        public bool stat { get; set; }

        Image temp;
        //private Bitmap imgObs = null;

        public Obstacle(int jenis, int x, int y, int w, int h)
        {
            this.jenis = jenis;
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            this.stat = false;
        }


        public Image drawObs(int jenis)
        {
            try
            {
                temp = (Image)Properties.Resources.ResourceManager.GetObject("witchOven_" + this.jenis);
            }
            catch (Exception)
            {
                temp = null;
            }
            return temp;
        }

        public Rectangle getObs()
        {
            return new Rectangle(x, y, 100, 100);

        }
    }
}
