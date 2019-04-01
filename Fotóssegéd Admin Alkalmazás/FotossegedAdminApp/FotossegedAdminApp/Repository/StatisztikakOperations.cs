using ConnectToMysqlDatabase.Database;
using Fotosseged.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FotossegedAdminApp.Repository
{
    public class StatisztikakOperations
    {
        private MySQLDatabaseInterface mdi;

        public string getUserNumber(string userNumber)
        {
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT COUNT(id) FROM user;";
            userNumber = mdi.executeScalarQuery(query);

            return userNumber;
        }

        internal string getLastUserReg(string userReg)
        {
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT regdatum FROM user ORDER BY regdatum DESC LIMIT 1;";
            userReg = mdi.executeScalarQuery(query);

            return userReg;
        }

        public string getKepekNumber(string kepekNumber)
        {
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT COUNT(id) FROM kepek;";
            kepekNumber = mdi.executeScalarQuery(query);

            return kepekNumber;
        }

        internal string getLastPicDate(string lastPic)
        {
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT feltolt_datum FROM kepek ORDER BY feltolt_datum DESC LIMIT 1;";
            lastPic = mdi.executeScalarQuery(query);

            return lastPic;
        }

        internal string getLastPicUser(string lastPicUser)
        {
            string userId = "";
            string kepId = "";
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query = "SELECT id FROM kepek ORDER BY feltolt_datum DESC LIMIT 1;";
            kepId = mdi.executeScalarQuery(query);
            string query_uid = "SELECT userid FROM fotokeszites WHERE kepid="+ kepId;
            userId = mdi.executeScalarQuery(query_uid);
            string query_username = "SELECT username FROM user WHERE id="+userId;
            lastPicUser = mdi.executeScalarQuery(query_username);

            return lastPicUser;
        }

        internal string getLastChatDate(string lastChatDate)
        {
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query_datum = "SELECT datum FROM chat ORDER BY datum DESC LIMIT 1;";
            lastChatDate = mdi.executeScalarQuery(query_datum);

            return lastChatDate;
        }

        internal string getLastChatUser(string lastChatUser)
        {
            string lastChatUid = "";
            Database md = new Database();
            mdi = md.kapcsolodas();
            mdi.open();
            string query_uid = "SELECT user_id FROM chat ORDER BY datum DESC LIMIT 1;";
            lastChatUid = mdi.executeScalarQuery(query_uid);
            string query_user = "SELECT username FROM user WHERE id="+ lastChatUid;
            lastChatUser = mdi.executeScalarQuery(query_user);

            return lastChatUser;
        }
    }
}
