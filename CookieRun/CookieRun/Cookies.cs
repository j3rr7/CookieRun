using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Resources;

namespace CookieRun
{
    class Cookies
    {
        int jenis; //0 = Brave | 1 = Hero | 2 = Angel | -ToDo add more dynamic feature
        int status; //0 = idle | 1 = running | 2 = jumping | 3 = sliding | 99 = runboosted -ToDo add more event and validation

        string jenisCookie;
        string statusCookie;

        public Cookies()
        {
            this.jenis = 0;
            this.status = 0;
            this.jenisCookie = "brave";
            this.statusCookie = "idle";
        }
        
        public Image getAnimation(int counterAnimation)//parameter as counter for the animation sequences
        {
            changeStat();
            ////HERO
            ////==================
            //if (jenis == 1)
            //{
            //    temp = (Image)Properties.Resources.ResourceManager.GetObject(this.jenisCookie + "_" + this.statusCookie + "_" + counterAnimation.ToString());
            //}
            ////==================

            ////ANGEL
            ////==================
            //else if (jenis == 2)
            //{
            //    temp = (Image)Properties.Resources.ResourceManager.GetObject(this.jenisCookie + "_" + this.statusCookie + "_" + counterAnimation.ToString());
            //}
            ////==================

            ////BRAVE
            ////==================
            //else
            //{
            //    temp = (Image)Properties.Resources.ResourceManager.GetObject(this.jenisCookie + "_" + this.statusCookie + "_" + counterAnimation.ToString());
            //}
            ////==================
            Image temp = (Image)Properties.Resources.ResourceManager.GetObject(this.jenisCookie + "_" + this.statusCookie + "_" + counterAnimation.ToString());
            return temp;
        }

        private void changeStat()
        {
            //STATE PLAYER
            if (this.status == 1)
            {
                this.statusCookie = "run";
            }
            else if (this.status == 2)
            {
                this.statusCookie = "jump";
            }
            else if (this.status == 3)
            {
                this.statusCookie = "slide";
            }
            else if (this.status == 99)
            {
                this.statusCookie = "run_boost";
            }
            else
            {
                this.statusCookie = "idle";
            }

            //JENIS PLAYER
            if (this.jenis == 1)
            {
                this.jenisCookie = "hero";
            }
            else if (this.jenis == 2)
            {
                this.jenisCookie = "angel";
            }
            else
            {
                this.jenisCookie = "brave";
            }
        }

        public int Jenis { get => jenis; set => jenis = value; }
        public int Status { get => status; set => status = value; }
    }
}
