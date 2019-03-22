using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotosseged.Model
{
    class Objektivek
    {
        private int id;
        private string tipus;
        private string gyarto;
        private string nev;
        private int gyujtotav;
        private bool stabil;
        private double minblende;
        private double maxblende;
        private int hossz;
        private int suly;
        private int ar;

        public Objektivek(int id, string tipus, string gyarto, string nev, int gyujtotav, bool stabil, double minblende, double maxblende, int hossz, int suly, int ar)
        {
            this.id = id;
            this.tipus = tipus;
            this.gyarto = gyarto;
            this.nev = nev;
            this.gyujtotav = gyujtotav;
            this.stabil = stabil;
            this.minblende = minblende;
            this.maxblende = maxblende;
            this.hossz = hossz;
            this.suly = suly;
            this.ar = ar;
        }

        public int getId()
        {
            return id;
        }

        public string getTipus()
        {
            return tipus;
        }

        public string getGyarto()
        {
            return gyarto;
        }

        public string getNev()
        {
            return nev;
        }

        public int getGyujtotav()
        {
            return gyujtotav;
        }

        public bool getStabil()
        {
            return stabil;
        }

        public double getMinblende()
        {
            return minblende;
        }

        public double getMaxblende()
        {
            return maxblende;
        }

        public int getHossz()
        {
            return hossz;
        }

        public int getSuly()
        {
            return suly;
        }

        public int getAr()
        {
            return ar;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setTipus(string tipus)
        {
            this.tipus = tipus;
        }

        public void setGyarto(string gyarto)
        {
            this.gyarto = gyarto;
        }

        public void setNev(string nev)
        {
            this.nev = nev;
        }

        public void setGyujtotav(int gyujtotav)
        {
            this.gyujtotav = gyujtotav;
        }

        public void setStabil(bool stabil)
        {
            this.stabil = stabil;
        }

        public void setMinblende(double minblende)
        {
            this.minblende = minblende;
        }

        public void setMaxblende(double maxblende)
        {
            this.maxblende = maxblende;
        }

        public void setHossz(int hossz)
        {
            this.hossz = hossz;
        }

        public void setSuly(int suly)
        {
            this.suly = suly;
        }

        public void setAr(int ar)
        {
            this.ar = ar;
        }

        public override string ToString()
        {
            return id + " "+ tipus + " " + gyarto + " " + nev + " " + gyujtotav + " " + stabil + " " + minblende + " " + maxblende + " " + hossz + " " + suly + " " + ar;
        }
    }
}
