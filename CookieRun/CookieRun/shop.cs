using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;
using System.Threading;
using System.Media;
using System.Windows.Forms;
namespace CookieRun
{
    class shop
    {
        public string gambar { get; set; }
        public int gambarke { get; set; }
        public int X { get; set; }
        public string deskripsi { get; set; }
        public PictureBox picture { get; set; }
        public int harga { get; set; }

        public shop(string gambar, PictureBox picture,string deskripsi, int x,int harga)
        {
            this.gambar = gambar;
            this.gambarke = 1;
            this.picture = picture;
            this.deskripsi = deskripsi;
            X = x;
            this.harga = harga;
        }

        public void ubahgambar()
        {
            object obj = Properties.Resources.ResourceManager.GetObject(gambar + "_idleshop__" + gambarke);
            Image img = (Image)obj;
            picture.BackgroundImage =img;
            gambarke++;
            if (gambarke == 5)
            {
                gambarke = 1;
            }
        }

        public void ubahgambar2()
        {
            object obj = Properties.Resources.ResourceManager.GetObject(gambar + "_shop__" + gambarke+"_");
            Image img = (Image)obj;
            picture.BackgroundImage = img;
            gambarke++;
            if (gambarke == 5)
            {
                gambarke = 1;
            }
        }
    }
}
