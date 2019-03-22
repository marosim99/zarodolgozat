using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConnectToMysqlDatabase.Database;
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

        internal Objektivek getModositottObjektivek()
        {
            return objektiv;
        }
    }
}
