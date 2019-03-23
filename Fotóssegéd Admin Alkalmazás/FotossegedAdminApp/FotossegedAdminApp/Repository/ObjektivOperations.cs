using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToMysqlDatabase.Database;
using Fotosseged.Database;
using Fotosseged.Model;

namespace FotossegedAdminApp.Repository
{
    partial class ObjektivOperations
    {
        private Objektivek objektiv;
        private int ujObjektivId;

        private MySQLDatabaseInterface umdi;

        public ObjektivOperations(Objektivek objektiv)
        {
            this.objektiv = objektiv;
        }

        public ObjektivOperations(int ujObjektivId)
        {
            this.ujObjektivId = ujObjektivId;
        }

        internal Objektivek getModositottObjektivek()
        {
            return objektiv;
        }

        public int getUjObjektivId()
        {
            Database d = new Database();
            umdi = d.kapcsolodas();
            umdi.open();
            int Id = Convert.ToInt32(umdi.executeScalarQuery("SELECT MAX(id) FROM objektiv"));
            int ujObjektivId = Id + 1;
            umdi.close();

            return ujObjektivId;
        }
    }
}
