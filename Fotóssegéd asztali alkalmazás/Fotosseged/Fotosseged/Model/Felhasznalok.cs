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
        private string bemutatkozas;
        private DateTime regdatum;

        public Felhasznalok(int id, string fnev, string nem, string email, string bemutatkozas, DateTime regdatum)
        {
            this.id = id;
            this.fnev = fnev;
            this.nem = nem;
            this.email = email;
            this.bemutatkozas = bemutatkozas;
            this.regdatum = regdatum;
        }


    }
}
