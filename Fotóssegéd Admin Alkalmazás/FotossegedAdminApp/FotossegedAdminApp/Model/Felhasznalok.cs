using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotosseged.Model
{
    class Felhasznalok
    {
        private int id;
        private string fnev;
        private string nem;
        private string email;
        private bool admin;

        public Felhasznalok(int id, string fnev, string nem, string email, bool admin)
        {
            this.id = id;
            this.fnev = fnev;
            this.nem = nem;
            this.email = email;
            this.admin = admin;
        }

        public int getId()
        {
            return id;
        }

        public string getFnev()
        {
            return fnev;
        }

        public string getNem()
        {
            return nem;
        }

        public string getEmail()
        {
            return email;
        }

        public bool getAdmin()
        {
            return admin;
        }

        public void setId(int id)
        {
            this.id = id;
        }

        public void setFnev(string fnev)
        {
            this.fnev = fnev;
        }

        public void setNem(string nem)
        {
            this.nem = nem;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public void setAdmin(bool admin)
        {
            this.admin = admin;
        }

        public override string ToString()
        {
            return id + " " + fnev + " " + nem + " " + email + " " + admin;
        }
    }
}
