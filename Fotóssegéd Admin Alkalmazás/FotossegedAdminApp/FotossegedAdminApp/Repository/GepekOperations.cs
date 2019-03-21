using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToMysqlDatabase;
using ConnectToMysqlDatabase.Database;
using Fotosseged.Database;
using Fotosseged.Model;


namespace FotossegedAdminApp.Repository
{
    partial class GepekOperations
    {
        private Gepek gepek;
        private int ujId;

        private MySQLDatabaseInterface umdi;

        public GepekOperations(Gepek gepek)
        {
            this.gepek = gepek;
        }

        public GepekOperations(int ujId)
        {
            this.ujId = ujId;
        }

        internal Gepek getModositottGepek()
        {
            return gepek;
        }

        public int getUjId()
        {
            Database d = new Database();
            umdi = d.kapcsolodas();
            umdi.open();
            int Id = Convert.ToInt32(umdi.executeScalarQuery("SELECT MAX(id) FROM gepek"));
            int ujId = Id + 1;
            umdi.close();

            return ujId;
        }


    }
}
