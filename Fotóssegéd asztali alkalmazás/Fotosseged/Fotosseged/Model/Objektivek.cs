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
        private bool stabil;
        private double minblende;
        private double maxblende;
        private int suly;
        private int ar;

        public Objektivek(int id, string tipus, string gyarto, string nev, bool stabil, double minblende, double maxblende, int suly, int ar)
        {
            this.id = id;
            this.tipus = tipus;
            this.gyarto = gyarto;
            this.nev = nev;
            this.stabil = stabil;
            this.minblende = minblende;
            this.maxblende = maxblende;
            this.suly = suly;
            this.ar = ar;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
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

        public int getSuly()
        {
            return suly;
        }

        public int getAr()
        {
            return ar;
        }


        public override string ToString()
        {
            return id+" "+tipus+" "+gyarto + " " + stabil + " " + minblende + " " + maxblende + " " + suly + " " + ar;
        }
    }
}
