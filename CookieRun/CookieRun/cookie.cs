using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CookieRun
{
    class cookie
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int W { get; set; }
        public int H { get; set; }
        public int hp { get; set; }
        public string jenis_cookie { get; set; }
        public string jenis_cookie_ngapain { get; set; }
        public int jenis_cookie_gambarke { get; set; }
        public string status { get; set; }

        public cookie(int x, int y, int w, int h, int hp, string jenis_cookie, string jenis_cookie_ngapain, int jenis_cookie_gambarke, string status)
        {
            X = x;
            Y = y;
            W = w;
            H = h;
            this.hp = hp;
            this.jenis_cookie = jenis_cookie;
            this.jenis_cookie_ngapain = jenis_cookie_ngapain;
            this.jenis_cookie_gambarke = jenis_cookie_gambarke;
            this.status = status;
        }
        public void getImage(Graphics g)
        {
            try
            {
                gambar(g);
            }
            catch (Exception)
            {
                jenis_cookie_gambarke = 12;//start tile nya
                gambar(g);
            }
        }
        public void gambar(Graphics g)
        {
            object O = Properties.Resources.ResourceManager.GetObject(jenis_cookie + jenis_cookie_ngapain +  jenis_cookie_gambarke);
            Image img = (Image)O;
            g.DrawImage(img, X, Y, W, H);
        }
    }
}


