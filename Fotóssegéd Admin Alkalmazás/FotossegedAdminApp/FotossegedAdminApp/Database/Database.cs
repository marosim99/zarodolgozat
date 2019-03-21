using ConnectToMysqlDatabase.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fotosseged.Database
{
    class Database
    {
        public MySQLDatabaseInterface kapcsolodas()
        {
            MySQLDatabaseInterface mdi = new MySQLDatabaseInterface();
            mdi.setErrorToUserInterface(true);
            mdi.setErrorToGraphicalUserInterface(false);
            mdi.setConnectionServerData("localhost", "fotosseged", "3306");
            mdi.setConnectionUserData("root", "");
            mdi.makeConnectionToDatabase();

            return mdi;
        }
    }
}
